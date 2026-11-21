using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A3B RID: 14907
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingDevelopBottomItem : UiPanelBase
	{
		// Token: 0x06026554 RID: 157012 RVA: 0x00ABC31A File Offset: 0x00ABA51A
		public TrapDefenseBuildingDevelopBottomItem(bool isInDungeon)
		{
			this.IsInDungeon = isInDungeon;
		}

		// Token: 0x06026555 RID: 157013 RVA: 0x00ABC334 File Offset: 0x00ABA534
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickedQuickEquip));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickedUnload));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06026556 RID: 157014 RVA: 0x00ABC484 File Offset: 0x00ABA684
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBuildingDevelopBottomItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBuildingDevelopBottomItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026557 RID: 157015 RVA: 0x00ABC4C7 File Offset: 0x00ABA6C7
		private void OnClickedUnload()
		{
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.EquipOrgan(this.CurSelectedIndex, this.MenuData);
		}

		// Token: 0x06026558 RID: 157016 RVA: 0x00ABC4E5 File Offset: 0x00ABA6E5
		private void OnClickedQuickEquip()
		{
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.QuickEquipOrgan();
		}

		// Token: 0x06026559 RID: 157017 RVA: 0x00ABC4F8 File Offset: 0x00ABA6F8
		private void OnClickedItem(TrapDefenseBuildingSlotData slot)
		{
			TrapDefenseBuildingDevelopItemData slotData = slot.GetSlotData();
			if (slotData != null)
			{
				EventSystem.Instance.Emit<TrapDefenseBuildingDevelopItemData>(EEventName.TrapDefenseBuildingBottomSelectUpdate, slotData);
			}
			this.CurSelectedIndex = slot.GetIndex();
			if (slotData == this.MenuData)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "TowerDefense_Battle_Unload", Array.Empty<object>());
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), this.GetEquipTxt(slotData), Array.Empty<object>());
			}
			this.Layout.DeselectCurrentGridProxy();
			GenericLayout<TrapDefenseBuildingDevelopBottomGrid, TrapDefenseBuildingSlotData> layout = this.Layout;
			if (layout == null)
			{
				return;
			}
			layout.SelectGridProxy(this.CurSelectedIndex, false);
		}

		// Token: 0x0602655A RID: 157018 RVA: 0x00ABC591 File Offset: 0x00ABA791
		private bool CanExecuteChange(TrapDefenseBuildingSlotData slot)
		{
			if (!this.HasInit)
			{
				this.HasInit = true;
				return true;
			}
			return this.CurSelectedIndex != slot.GetIndex();
		}

		// Token: 0x0602655B RID: 157019 RVA: 0x00ABC5B5 File Offset: 0x00ABA7B5
		private TrapDefenseBuildingDevelopBottomGrid CreateItem()
		{
			return new TrapDefenseBuildingDevelopBottomGrid
			{
				OnClickCb = new Action<TrapDefenseBuildingSlotData>(this.OnClickedItem),
				CanExecuteChangeCb = new Func<TrapDefenseBuildingSlotData, bool>(this.CanExecuteChange)
			};
		}

		// Token: 0x0602655C RID: 157020 RVA: 0x00ABC5E0 File Offset: 0x00ABA7E0
		public TrapDefenseBuildingDevelopItemData CheckCurSlotEmpty()
		{
			return this.DataList[this.CurSelectedIndex].GetSlotData();
		}

		// Token: 0x0602655D RID: 157021 RVA: 0x00ABC5F8 File Offset: 0x00ABA7F8
		public void SetMenuSelectedData(TrapDefenseBuildingDevelopItemData data)
		{
			this.MenuData = data;
			TrapDefenseBuildingDevelopItemData slotData = this.DataList[this.CurSelectedIndex].GetSlotData();
			if (data == slotData)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "TowerDefense_Battle_Unload", Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), this.GetEquipTxt(data), Array.Empty<object>());
		}

		// Token: 0x0602655E RID: 157022 RVA: 0x00ABC660 File Offset: 0x00ABA860
		public void UpdateSlot()
		{
			foreach (TrapDefenseBuildingDevelopBottomGrid trapDefenseBuildingDevelopBottomGrid in this.Layout.GetLayoutItemList())
			{
				trapDefenseBuildingDevelopBottomGrid.UpdateData();
			}
		}

		// Token: 0x0602655F RID: 157023 RVA: 0x00ABC6B8 File Offset: 0x00ABA8B8
		public void UpdateEquipTxt()
		{
			if (this.DataList[this.CurSelectedIndex].GetSlotData() == this.MenuData)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "TowerDefense_Battle_Unload", Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), this.GetEquipTxt(this.MenuData), Array.Empty<object>());
		}

		// Token: 0x06026560 RID: 157024 RVA: 0x00ABC721 File Offset: 0x00ABA921
		private string GetEquipTxt(TrapDefenseBuildingDevelopItemData data)
		{
			if (data == null)
			{
				return "TowerDefense_Battle_Equip";
			}
			if (!data.IsBuilding)
			{
				return "TowerDefense_Battle_Equip_Auxiliary";
			}
			return "TowerDefense_Battle_Equip";
		}

		// Token: 0x06026561 RID: 157025 RVA: 0x00ABC740 File Offset: 0x00ABA940
		public List<CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData>> InitBottomDragLogic()
		{
			List<CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData>> list = new List<CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData>>();
			foreach (TrapDefenseBuildingDevelopBottomGrid trapDefenseBuildingDevelopBottomGrid in this.Layout.GetLayoutItemList())
			{
				TrapDefenseBuildingDevelopBottomInfoItem dataItem = trapDefenseBuildingDevelopBottomGrid.GetDataItem();
				CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData> commonDragItemLogic = new CommonDragItemLogic<TrapDefenseBuildingDevelopDragDataItem, TrapDefenseBuildingDevelopItemData>(dataItem.GetRootItem(), dataItem.GetDragComp(), trapDefenseBuildingDevelopBottomGrid.GridIndex, new Func<TrapDefenseBuildingDevelopDragDataItem>(this.CreateDragDataItem));
				dataItem.SetDragLogic(commonDragItemLogic);
				list.Add(commonDragItemLogic);
			}
			return list;
		}

		// Token: 0x06026562 RID: 157026 RVA: 0x00ABC7D4 File Offset: 0x00ABA9D4
		public List<TrapDefenseBuildingDevelopBottomInfoItem> InitBottomDragItem()
		{
			List<TrapDefenseBuildingDevelopBottomInfoItem> list = new List<TrapDefenseBuildingDevelopBottomInfoItem>();
			foreach (TrapDefenseBuildingDevelopBottomGrid trapDefenseBuildingDevelopBottomGrid in this.Layout.GetLayoutItemList())
			{
				list.Add(trapDefenseBuildingDevelopBottomGrid.GetDataItem());
			}
			return list;
		}

		// Token: 0x06026563 RID: 157027 RVA: 0x00ABC838 File Offset: 0x00ABAA38
		private TrapDefenseBuildingDevelopDragDataItem CreateDragDataItem()
		{
			return new TrapDefenseBuildingDevelopDragDataItem();
		}

		// Token: 0x0401509E RID: 86174
		protected GenericLayout<TrapDefenseBuildingDevelopBottomGrid, TrapDefenseBuildingSlotData> Layout;

		// Token: 0x0401509F RID: 86175
		protected List<TrapDefenseBuildingSlotData> DataList = new List<TrapDefenseBuildingSlotData>();

		// Token: 0x040150A0 RID: 86176
		protected TrapDefenseBuildingDevelopItemData MenuData;

		// Token: 0x040150A1 RID: 86177
		protected int CurSelectedIndex;

		// Token: 0x040150A2 RID: 86178
		protected bool HasInit;

		// Token: 0x040150A3 RID: 86179
		protected bool IsInDungeon;

		// Token: 0x02009606 RID: 38406
		[NullableContext(0)]
		private class EDefine
		{
			// Token: 0x0402ED7E RID: 191870
			public const int ContentLayout = 0;

			// Token: 0x0402ED7F RID: 191871
			public const int PanelItemLayout = 1;

			// Token: 0x0402ED80 RID: 191872
			public const int Item = 2;

			// Token: 0x0402ED81 RID: 191873
			public const int BtnQuickEquipped = 3;

			// Token: 0x0402ED82 RID: 191874
			public const int TxtBtn = 4;

			// Token: 0x0402ED83 RID: 191875
			public const int BtnConfirm = 5;
		}
	}
}
