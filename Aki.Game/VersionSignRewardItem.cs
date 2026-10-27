using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x020014FF RID: 5375
public class VersionSignRewardItem : SignRewardItemBase
{
	// Token: 0x06009947 RID: 39239 RVA: 0x00212CB0 File Offset: 0x00210EB0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(base.OnClickButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009948 RID: 39240 RVA: 0x00212DFC File Offset: 0x00210FFC
	protected override void OnStart()
	{
		this.Grid = new SmallItemGrid();
		this.Grid.Initialize(base.GetItem(4).GetOwner());
		this.Grid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		this.Grid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnRewardItemClicked));
	}

	// Token: 0x06009949 RID: 39241 RVA: 0x00212E6C File Offset: 0x0021106C
	public override void RefreshByData(OneItemConfig data, SignState state, int index)
	{
		this.Index = index;
		this.ConfigId = data.ItemId;
		this.SetDayText(index + 1);
		bool uiactive = state == SignState.IsReceive;
		bool flag = state == SignState.Unlock;
		this.CanGetReward = flag;
		this.SetStateText(base.GetRewardStateTextId(state));
		base.GetItem(1).SetUIActive(flag);
		base.GetItem(2).SetUIActive(uiactive);
		this.RefreshGrid(data, state);
	}

	// Token: 0x0600994A RID: 39242 RVA: 0x00212ED6 File Offset: 0x002110D6
	private void SetDayText(int day)
	{
		base.GetText(5).SetText("0" + day.ToString(), true);
	}

	// Token: 0x0600994B RID: 39243 RVA: 0x00212EF6 File Offset: 0x002110F6
	[NullableContext(1)]
	private void SetStateText(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textId, Array.Empty<object>());
	}

	// Token: 0x0600994C RID: 39244 RVA: 0x00212F10 File Offset: 0x00211110
	private void RefreshGrid(OneItemConfig data, SignState state)
	{
		int count = data.Count;
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(this.ConfigId));
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.ConfigId);
		int num = (itemConfigData != null) ? itemConfigData.QualityId : 1;
		bool value = state == SignState.Unlock;
		bool value2 = state == SignState.Lock;
		bool value3 = state == SignState.IsReceive;
		if (itemDataTypeByConfigId != InventoryDefine.EItemDataType.RoleItem)
		{
			if (itemDataTypeByConfigId != InventoryDefine.EItemDataType.PhantomItem)
			{
				PropSmallItemGrid parameters = new PropSmallItemGrid
				{
					Data = data,
					ItemConfigId = new int?(this.ConfigId),
					QualityId = new int?(num),
					BottomText = count.ToString(),
					IsReceivableVisible = new bool?(value),
					IsLockVisible = new bool?(value2),
					IsReceivedVisible = new bool?(value3)
				};
				this.Grid.Apply<PropSmallItemGrid>(parameters);
			}
			else
			{
				PhantomSmallItemGrid parameters2 = new PhantomSmallItemGrid
				{
					Data = data,
					ItemConfigId = new int?(this.ConfigId),
					BottomText = count.ToString(),
					IsReceivableVisible = new bool?(value),
					IsLockVisible = new bool?(value2),
					IsReceivedVisible = new bool?(value3)
				};
				this.Grid.Apply<PhantomSmallItemGrid>(parameters2);
			}
		}
		else
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.ConfigId);
			CharacterSmallItemGrid parameters3 = new CharacterSmallItemGrid
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
			this.Grid.Apply<CharacterSmallItemGrid>(parameters3);
		}
		UUIItem item = base.GetItem(6);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(num == 5);
	}

	// Token: 0x0600994D RID: 39245 RVA: 0x00213115 File Offset: 0x00211315
	[NullableContext(1)]
	private void OnRewardItemClicked(MediumItemGridExtendCallback _)
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

	// Token: 0x04004367 RID: 17255
	[Nullable(2)]
	private SmallItemGrid Grid;

	// Token: 0x04004368 RID: 17256
	private int ConfigId;

	// Token: 0x02007B38 RID: 31544
	private class EVersionSignItemComponents
	{
		// Token: 0x0402885D RID: 165981
		public const int Button = 0;

		// Token: 0x0402885E RID: 165982
		public const int PanelReceived = 1;

		// Token: 0x0402885F RID: 165983
		public const int PanelDone = 2;

		// Token: 0x04028860 RID: 165984
		public const int TextState = 3;

		// Token: 0x04028861 RID: 165985
		public const int ItemGrid = 4;

		// Token: 0x04028862 RID: 165986
		public const int TextIndex = 5;

		// Token: 0x04028863 RID: 165987
		public const int SpriteLight = 6;
	}
}
