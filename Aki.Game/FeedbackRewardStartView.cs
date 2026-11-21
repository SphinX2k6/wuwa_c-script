using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F96 RID: 3990
public class FeedbackRewardStartView : UiViewBase
{
	// Token: 0x06009FF7 RID: 40951 RVA: 0x002F39F8 File Offset: 0x002F1BF8
	[NullableContext(1)]
	public FeedbackRewardStartView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009FF8 RID: 40952 RVA: 0x002F3A04 File Offset: 0x002F1C04
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009FF9 RID: 40953 RVA: 0x002F3ACC File Offset: 0x002F1CCC
	protected override void OnStart()
	{
		List<int> canFinishRewardId = FeedbackRewardModel.Instance.GetCanFinishRewardId();
		if (canFinishRewardId.Count <= 0)
		{
			return;
		}
		int id = canFinishRewardId[canFinishRewardId.Count - 1];
		GivebackScoreReward? givebackScoreRewardById = FeedbackRewardConfig.Instance.GetGivebackScoreRewardById(id);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "FeedBackReward_StartView_Text", new <>z__ReadOnlyArray<object>(new object[]
		{
			FeedbackRewardModel.Instance.CurrentPointCount,
			(givebackScoreRewardById != null) ? new int?(givebackScoreRewardById.GetValueOrDefault().Target) : null
		}));
		this.RewardLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(2), new Func<CommonItemSmallItemGrid>(this.InitItem), null, false, true);
		List<TItem> list = new List<TItem>();
		foreach (int id2 in canFinishRewardId)
		{
			GivebackScoreReward? givebackScoreRewardById2 = FeedbackRewardConfig.Instance.GetGivebackScoreRewardById(id2);
			if (givebackScoreRewardById2 != null)
			{
				DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(givebackScoreRewardById2.Value.DropId);
				if (dropPackage != null)
				{
					using (Dictionary<int, int>.Enumerator enumerator2 = dropPackage.Value.DropPreview().GetEnumerator())
					{
						if (enumerator2.MoveNext())
						{
							KeyValuePair<int, int> keyValuePair = enumerator2.Current;
							int key = keyValuePair.Key;
							int value = keyValuePair.Value;
							TItem item = new TItem(new InventoryDefine.GetItemData(key, 0), value);
							list.Add(item);
						}
					}
				}
			}
		}
		this.RewardLayout.RefreshByData(list, delegate
		{
			GenericLayout<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
			foreach (CommonItemSmallItemGrid commonItemSmallItemGrid in (((rewardLayout != null) ? rewardLayout.GetLayoutItemList() : null) ?? new List<CommonItemSmallItemGrid>()))
			{
				commonItemSmallItemGrid.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
				commonItemSmallItemGrid.SetAllowClickBack(false);
			}
		}, false);
	}

	// Token: 0x06009FFA RID: 40954 RVA: 0x002F3CA4 File Offset: 0x002F1EA4
	protected override void OnBeforeShow()
	{
		SplashScreenController.Instance.FinishCurTask(ESplashScreenSourceModuleType.FeedbackReward);
	}

	// Token: 0x06009FFB RID: 40955 RVA: 0x002F3CB1 File Offset: 0x002F1EB1
	[NullableContext(1)]
	private CommonItemSmallItemGrid InitItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06009FFC RID: 40956 RVA: 0x002F3CB8 File Offset: 0x002F1EB8
	private void OnClickBtn()
	{
		base.CloseMe(null);
		UiManager.Instance.OpenView(EUiViewName.FeedbackRewardMainView, null, null);
	}

	// Token: 0x04005E8E RID: 24206
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x020071C3 RID: 29123
	private enum ECompDefine
	{
		// Token: 0x040250F4 RID: 151796
		Button,
		// Token: 0x040250F5 RID: 151797
		PointText,
		// Token: 0x040250F6 RID: 151798
		RewardLayout
	}
}
