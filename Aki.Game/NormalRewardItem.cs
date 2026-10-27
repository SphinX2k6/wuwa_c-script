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

// Token: 0x020014FE RID: 5374
public class NormalRewardItem : SignRewardItemBase
{
	// Token: 0x0600993E RID: 39230 RVA: 0x002127B8 File Offset: 0x002109B8
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

	// Token: 0x0600993F RID: 39231 RVA: 0x00212948 File Offset: 0x00210B48
	protected override UniTask OnBeforeStartAsync()
	{
		NormalRewardItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<NormalRewardItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009940 RID: 39232 RVA: 0x0021298B File Offset: 0x00210B8B
	protected override void OnBeforeDestroy()
	{
		if (this.CommonSmallItemGridInner != null)
		{
			base.AddChild(this.CommonSmallItemGridInner);
		}
	}

	// Token: 0x06009941 RID: 39233 RVA: 0x002129A1 File Offset: 0x00210BA1
	public void SetDayText(int day)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "DayNum", new <>z__ReadOnlySingleElementList<object>(day));
	}

	// Token: 0x06009942 RID: 39234 RVA: 0x002129C4 File Offset: 0x00210BC4
	[NullableContext(1)]
	public void SetStateText(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textId, Array.Empty<object>());
	}

	// Token: 0x06009943 RID: 39235 RVA: 0x002129E0 File Offset: 0x00210BE0
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

	// Token: 0x06009944 RID: 39236 RVA: 0x00212ABC File Offset: 0x00210CBC
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

	// Token: 0x06009945 RID: 39237 RVA: 0x00212C7A File Offset: 0x00210E7A
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

	// Token: 0x04004365 RID: 17253
	[Nullable(2)]
	private SmallItemGrid CommonSmallItemGridInner;

	// Token: 0x04004366 RID: 17254
	private int ConfigId;

	// Token: 0x02007B35 RID: 31541
	private class ENormalRewardItemComponents
	{
		// Token: 0x0402884E RID: 165966
		public const int CommonItemGridSmall = 0;

		// Token: 0x0402884F RID: 165967
		public const int TxtDay = 1;

		// Token: 0x04028850 RID: 165968
		public const int TxtReward = 2;

		// Token: 0x04028851 RID: 165969
		public const int Toggle = 3;

		// Token: 0x04028852 RID: 165970
		public const int PnlReward = 4;

		// Token: 0x04028853 RID: 165971
		public const int SprFrame = 5;

		// Token: 0x04028854 RID: 165972
		public const int SprBgDesc = 6;

		// Token: 0x04028855 RID: 165973
		public const int SpriteBg = 7;

		// Token: 0x04028856 RID: 165974
		public const int RewardEffect = 8;
	}
}
