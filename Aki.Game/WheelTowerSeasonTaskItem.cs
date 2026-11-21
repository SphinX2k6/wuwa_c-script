using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000A94 RID: 2708
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WheelTowerSeasonTaskItem : SyncGridProxyAbstract<ActivityTaskData>
{
	// Token: 0x06007226 RID: 29222 RVA: 0x00231AC4 File Offset: 0x0022FCC4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnGetBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06007227 RID: 29223 RVA: 0x00231CB8 File Offset: 0x0022FEB8
	protected override void OnStart()
	{
		this.RewardLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(6), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, true);
	}

	// Token: 0x06007228 RID: 29224 RVA: 0x00231CDB File Offset: 0x0022FEDB
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06007229 RID: 29225 RVA: 0x00231CE4 File Offset: 0x0022FEE4
	public override void Refresh(ActivityTaskData data)
	{
		NewTowerSeasonAward? seasonTaskRewardConfig = WheelTowerConfig.Instance.GetSeasonTaskRewardConfig(data.Id);
		if (seasonTaskRewardConfig == null)
		{
			return;
		}
		List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(seasonTaskRewardConfig.Value.DropId);
		GenericLayout<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
		if (rewardLayout != null)
		{
			rewardLayout.RefreshByData(dropPackagePreviewItemList, null, false);
		}
		string newText = StringUtils.Format("({0}/{1})", new string[]
		{
			data.Current.ToString(),
			data.Target.ToString()
		});
		this.SetSpriteByPath(seasonTaskRewardConfig.Value.ShineIcon, base.GetSprite(3), false, null, null);
		base.SetTextureByPath(seasonTaskRewardConfig.Value.Icon, base.GetTexture(4), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), seasonTaskRewardConfig.Value.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), seasonTaskRewardConfig.Value.Desc, Array.Empty<object>());
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetText(newText, true);
		}
		UUIText text2 = base.GetText(9);
		if (text2 != null)
		{
			text2.SetUIActive(data.Status == EActivityTaskState.Active);
		}
		UUIButtonComponent button = base.GetButton(8);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(data.Status == EActivityTaskState.FinishedAndUnclaimed);
			}
		}
		UUIItem item = base.GetItem(10);
		if (item != null)
		{
			item.SetUIActive(data.Status == EActivityTaskState.FinishedAndClaimed);
		}
		this.CycleId = seasonTaskRewardConfig.Value.CycleId;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "WheelTower_SeasonTask_Doing", Array.Empty<object>());
		if (this.CycleId > 0)
		{
			UUITexture texture = base.GetTexture(5);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			string cycleEndRemainTime = WheelTowerModel.Instance.GetCycleEndRemainTime();
			if (!string.IsNullOrEmpty(cycleEndRemainTime))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "WheelTower_SeasonTask_ResetTime", new <>z__ReadOnlySingleElementList<object>(cycleEndRemainTime));
				return;
			}
		}
		else
		{
			UUITexture texture2 = base.GetTexture(5);
			if (texture2 == null)
			{
				return;
			}
			texture2.SetUIActive(false);
		}
	}

	// Token: 0x0600722A RID: 29226 RVA: 0x00231F10 File Offset: 0x00230110
	public void OnTick()
	{
		if (this.CycleId <= 0)
		{
			return;
		}
		string cycleEndRemainTime = WheelTowerModel.Instance.GetCycleEndRemainTime();
		if (string.IsNullOrEmpty(cycleEndRemainTime))
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "WheelTower_SeasonTask_Doing", Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "WheelTower_SeasonTask_ResetTime", new <>z__ReadOnlySingleElementList<object>(cycleEndRemainTime));
	}

	// Token: 0x0600722B RID: 29227 RVA: 0x00231F74 File Offset: 0x00230174
	private void OnGetBtnClick()
	{
		Action onClickToGet = this.OnClickToGet;
		if (onClickToGet == null)
		{
			return;
		}
		onClickToGet();
	}

	// Token: 0x04004725 RID: 18213
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x04004726 RID: 18214
	private int CycleId;

	// Token: 0x04004727 RID: 18215
	[Nullable(2)]
	public Action OnClickToGet;
}
