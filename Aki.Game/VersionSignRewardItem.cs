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

// Token: 0x020009B7 RID: 2487
public class VersionSignRewardItem : SignRewardItemBase
{
	// Token: 0x06006D21 RID: 27937 RVA: 0x0021C9C8 File Offset: 0x0021ABC8
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

	// Token: 0x06006D22 RID: 27938 RVA: 0x0021CB14 File Offset: 0x0021AD14
	protected override void OnStart()
	{
		this.Grid = new SmallItemGrid();
		this.Grid.Initialize(base.GetItem(4).GetOwner());
		this.Grid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		this.Grid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnRewardItemClicked));
	}

	// Token: 0x06006D23 RID: 27939 RVA: 0x0021CB84 File Offset: 0x0021AD84
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

	// Token: 0x06006D24 RID: 27940 RVA: 0x0021CBEE File Offset: 0x0021ADEE
	private void SetDayText(int day)
	{
		base.GetText(5).SetText("0" + day.ToString(), true);
	}

	// Token: 0x06006D25 RID: 27941 RVA: 0x0021CC0E File Offset: 0x0021AE0E
	[NullableContext(1)]
	private void SetStateText(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textId, Array.Empty<object>());
	}

	// Token: 0x06006D26 RID: 27942 RVA: 0x0021CC28 File Offset: 0x0021AE28
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

	// Token: 0x06006D27 RID: 27943 RVA: 0x0021CE2D File Offset: 0x0021B02D
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

	// Token: 0x0400440C RID: 17420
	[Nullable(2)]
	private SmallItemGrid Grid;

	// Token: 0x0400440D RID: 17421
	private int ConfigId;

	// Token: 0x02006CC3 RID: 27843
	private class EVersionSignItemComponents
	{
		// Token: 0x04023B99 RID: 146329
		public const int Button = 0;

		// Token: 0x04023B9A RID: 146330
		public const int PanelReceived = 1;

		// Token: 0x04023B9B RID: 146331
		public const int PanelDone = 2;

		// Token: 0x04023B9C RID: 146332
		public const int TextState = 3;

		// Token: 0x04023B9D RID: 146333
		public const int ItemGrid = 4;

		// Token: 0x04023B9E RID: 146334
		public const int TextIndex = 5;

		// Token: 0x04023B9F RID: 146335
		public const int SpriteLight = 6;
	}
}
