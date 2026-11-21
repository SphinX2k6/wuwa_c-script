using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020009B6 RID: 2486
public class NormalRewardItem : SignRewardItemBase
{
	// Token: 0x06006D18 RID: 27928 RVA: 0x0021C4D0 File Offset: 0x0021A6D0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(base.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06006D19 RID: 27929 RVA: 0x0021C660 File Offset: 0x0021A860
	protected override UniTask OnBeforeStartAsync()
	{
		NormalRewardItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<NormalRewardItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006D1A RID: 27930 RVA: 0x0021C6A3 File Offset: 0x0021A8A3
	protected override void OnBeforeDestroy()
	{
		if (this.CommonSmallItemGridInner != null)
		{
			base.AddChild(this.CommonSmallItemGridInner);
		}
	}

	// Token: 0x06006D1B RID: 27931 RVA: 0x0021C6B9 File Offset: 0x0021A8B9
	public void SetDayText(int day)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "DayNum", new <>z__ReadOnlySingleElementList<object>(day));
	}

	// Token: 0x06006D1C RID: 27932 RVA: 0x0021C6DC File Offset: 0x0021A8DC
	[NullableContext(1)]
	public void SetStateText(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textId, Array.Empty<object>());
	}

	// Token: 0x06006D1D RID: 27933 RVA: 0x0021C6F8 File Offset: 0x0021A8F8
	public override void RefreshByData(OneItemConfig data, SignState state, int index)
	{
		this.Index = index;
		this.ConfigId = data.ItemId;
		this.SetDayText(index + 1);
		this.SetStateText(base.GetRewardStateTextId(state));
		bool uiactive = state == SignState.IsReceive;
		bool flag = state == SignState.Unlock;
		this.CanGetReward = flag;
		UUIText text = base.GetText(2);
		if (text != null)
		{
			UUIItem uuiitem = text;
			bool bUseChangeColor = state == SignState.Lock;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}
		base.GetItem(4).SetUIActive(uiactive);
		base.GetSprite(5).SetUIActive(flag);
		base.GetSprite(6).SetUIActive(flag);
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(flag ? "SP_NewSignInSmallItemBg_Reward" : "SP_NewSignInSmallItemBg_Normal");
		this.SetSpriteByPath(resourcePath, base.GetSprite(7), false, null, null);
		base.GetItem(8).SetUIActive(flag);
		this.RefreshGrid(data, state);
	}

	// Token: 0x06006D1E RID: 27934 RVA: 0x0021C7D4 File Offset: 0x0021A9D4
	private void RefreshGrid(OneItemConfig data, SignState state)
	{
		int count = data.Count;
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(this.ConfigId));
		bool value = state == SignState.Unlock;
		bool value2 = state == SignState.Lock;
		bool value3 = state == SignState.IsReceive;
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.RoleItem)
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.ConfigId);
			CharacterSmallItemGrid parameters = new CharacterSmallItemGrid
			{
				Data = data,
				ElementId = new int?(roleConfig.Value.ElementId),
				ItemConfigId = new int?(this.ConfigId),
				BottomText = count.ToString(),
				QualityId = new int?(roleConfig.Value.QualityId),
				IsReceivableVisible = new bool?(value),
				IsLockVisible = new bool?(value2),
				IsReceivedVisible = new bool?(value3)
			};
			this.CommonSmallItemGridInner.Apply<CharacterSmallItemGrid>(parameters);
			return;
		}
		if (itemDataTypeByConfigId != InventoryDefine.EItemDataType.PhantomItem)
		{
			PropSmallItemGrid parameters2 = new PropSmallItemGrid
			{
				Data = data,
				ItemConfigId = new int?(this.ConfigId),
				BottomText = count.ToString(),
				IsReceivableVisible = new bool?(value),
				IsLockVisible = new bool?(value2),
				IsReceivedVisible = new bool?(value3)
			};
			this.CommonSmallItemGridInner.Apply<PropSmallItemGrid>(parameters2);
			return;
		}
		PhantomSmallItemGrid parameters3 = new PhantomSmallItemGrid
		{
			Data = data,
			ItemConfigId = new int?(this.ConfigId),
			BottomText = count.ToString(),
			IsReceivableVisible = new bool?(value),
			IsLockVisible = new bool?(value2),
			IsReceivedVisible = new bool?(value3)
		};
		this.CommonSmallItemGridInner.Apply<PhantomSmallItemGrid>(parameters3);
	}

	// Token: 0x06006D1F RID: 27935 RVA: 0x0021C992 File Offset: 0x0021AB92
	[NullableContext(1)]
	private void OnExtendToggleClicked(MediumItemGridExtendCallback callback)
	{
		if (!this.CanGetReward)
		{
			ActivitySevenDaySignDefine.OpenSignActivityRewardPreviewWhenLocked(this.ConfigId);
			return;
		}
		Action<int> onClickToGet = this.OnClickToGet;
		if (onClickToGet == null)
		{
			return;
		}
		onClickToGet(this.Index);
	}

	// Token: 0x0400440A RID: 17418
	[Nullable(2)]
	private SmallItemGrid CommonSmallItemGridInner;

	// Token: 0x0400440B RID: 17419
	private int ConfigId;

	// Token: 0x02006CC0 RID: 27840
	private class ENormalRewardItemComponents
	{
		// Token: 0x04023B8A RID: 146314
		public const int CommonItemGridSmall = 0;

		// Token: 0x04023B8B RID: 146315
		public const int TxtDay = 1;

		// Token: 0x04023B8C RID: 146316
		public const int TxtReward = 2;

		// Token: 0x04023B8D RID: 146317
		public const int Toggle = 3;

		// Token: 0x04023B8E RID: 146318
		public const int PnlReward = 4;

		// Token: 0x04023B8F RID: 146319
		public const int SprFrame = 5;

		// Token: 0x04023B90 RID: 146320
		public const int SprBgDesc = 6;

		// Token: 0x04023B91 RID: 146321
		public const int SpriteBg = 7;

		// Token: 0x04023B92 RID: 146322
		public const int RewardEffect = 8;
	}
}
