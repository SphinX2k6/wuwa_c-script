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
	// Token: 0x02004A93 RID: 19091
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingDevelopBottomItem : UiPanelBase
	{
		// Token: 0x060317C4 RID: 202692 RVA: 0x00B78366 File Offset: 0x00B76566
		public TrapDefenseBuildingDevelopBottomItem(bool isInDungeon)
		{
			this.IsInDungeon = isInDungeon;
		}

		// Token: 0x060317C5 RID: 202693 RVA: 0x00B78380 File Offset: 0x00B76580
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

		// Token: 0x060317C6 RID: 202694 RVA: 0x00B784D0 File Offset: 0x00B766D0
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBuildingDevelopBottomItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBuildingDevelopBottomItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060317C7 RID: 202695 RVA: 0x00B78513 File Offset: 0x00B76713
		private void OnClickedUnload()
		{
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.EquipOrgan(this.CurSelectedIndex, this.MenuData);
		}

		// Token: 0x060317C8 RID: 202696 RVA: 0x00B78531 File Offset: 0x00B76731
		private void OnClickedQuickEquip()
		{
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.QuickEquipOrgan();
		}

		// Token: 0x060317C9 RID: 202697 RVA: 0x00B78544 File Offset: 0x00B76744
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

		// Token: 0x060317CA RID: 202698 RVA: 0x00B785DD File Offset: 0x00B767DD
		private bool CanExecuteChange(TrapDefenseBuildingSlotData slot)
		{
			if (!this.HasInit)
			{
				this.HasInit = true;
				return true;
			}
			return this.CurSelectedIndex != slot.GetIndex();
		}

		// Token: 0x060317CB RID: 202699 RVA: 0x00B78601 File Offset: 0x00B76801
		private TrapDefenseBuildingDevelopBottomGrid CreateItem()
		{
			return new TrapDefenseBuildingDevelopBottomGrid
			{
				OnClickCb = new Action<TrapDefenseBuildingSlotData>(this.OnClickedItem),
				CanExecuteChangeCb = new Func<TrapDefenseBuildingSlotData, bool>(this.CanExecuteChange)
			};
		}

		// Token: 0x060317CC RID: 202700 RVA: 0x00B7862C File Offset: 0x00B7682C
		public TrapDefenseBuildingDevelopItemData CheckCurSlotEmpty()
		{
			return this.DataList[this.CurSelectedIndex].GetSlotData();
		}

		// Token: 0x060317CD RID: 202701 RVA: 0x00B78644 File Offset: 0x00B76844
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

		// Token: 0x060317CE RID: 202702 RVA: 0x00B786AC File Offset: 0x00B768AC
		public void UpdateSlot()
		{
			foreach (TrapDefenseBuildingDevelopBottomGrid trapDefenseBuildingDevelopBottomGrid in this.Layout.GetLayoutItemList())
			{
				trapDefenseBuildingDevelopBottomGrid.UpdateData();
			}
		}

		// Token: 0x060317CF RID: 202703 RVA: 0x00B78704 File Offset: 0x00B76904
		public void UpdateEquipTxt()
		{
			if (this.DataList[this.CurSelectedIndex].GetSlotData() == this.MenuData)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "TowerDefense_Battle_Unload", Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), this.GetEquipTxt(this.MenuData), Array.Empty<object>());
		}

		// Token: 0x060317D0 RID: 202704 RVA: 0x00B7876D File Offset: 0x00B7696D
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

		// Token: 0x060317D1 RID: 202705 RVA: 0x00B7878C File Offset: 0x00B7698C
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

		// Token: 0x060317D2 RID: 202706 RVA: 0x00B78820 File Offset: 0x00B76A20
		public List<TrapDefenseBuildingDevelopBottomInfoItem> InitBottomDragItem()
		{
			List<TrapDefenseBuildingDevelopBottomInfoItem> list = new List<TrapDefenseBuildingDevelopBottomInfoItem>();
			foreach (TrapDefenseBuildingDevelopBottomGrid trapDefenseBuildingDevelopBottomGrid in this.Layout.GetLayoutItemList())
			{
				list.Add(trapDefenseBuildingDevelopBottomGrid.GetDataItem());
			}
			return list;
		}

		// Token: 0x060317D3 RID: 202707 RVA: 0x00B78884 File Offset: 0x00B76A84
		private TrapDefenseBuildingDevelopDragDataItem CreateDragDataItem()
		{
			return new TrapDefenseBuildingDevelopDragDataItem();
		}

		// Token: 0x0401A74C RID: 108364
		protected GenericLayout<TrapDefenseBuildingDevelopBottomGrid, TrapDefenseBuildingSlotData> Layout;

		// Token: 0x0401A74D RID: 108365
		protected List<TrapDefenseBuildingSlotData> DataList = new List<TrapDefenseBuildingSlotData>();

		// Token: 0x0401A74E RID: 108366
		protected TrapDefenseBuildingDevelopItemData MenuData;

		// Token: 0x0401A74F RID: 108367
		protected int CurSelectedIndex;

		// Token: 0x0401A750 RID: 108368
		protected bool HasInit;

		// Token: 0x0401A751 RID: 108369
		protected bool IsInDungeon;

		// Token: 0x0200ABE6 RID: 44006
		[NullableContext(0)]
		private class EDefine
		{
			// Token: 0x040343CD RID: 213965
			public const int ContentLayout = 0;

			// Token: 0x040343CE RID: 213966
			public const int PanelItemLayout = 1;

			// Token: 0x040343CF RID: 213967
			public const int Item = 2;

			// Token: 0x040343D0 RID: 213968
			public const int BtnQuickEquipped = 3;

			// Token: 0x040343D1 RID: 213969
			public const int TxtBtn = 4;

			// Token: 0x040343D2 RID: 213970
			public const int BtnConfirm = 5;
		}
	}
}
