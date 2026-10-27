using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A9C RID: 19100
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseBuildingDevelopTypeItem : GridProxyAbstract<TrapDefenseBuildingTypeData>
	{
		// Token: 0x06031812 RID: 202770 RVA: 0x00B79C50 File Offset: 0x00B77E50
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031813 RID: 202771 RVA: 0x00B79D1C File Offset: 0x00B77F1C
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.Layout = new GenericLayout<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData>(base.GetGridLayout(2), new Func<TrapDefenseBuildingDevelopTypeGridItem>(this.InitGridItem), null, false, true);
		}

		// Token: 0x06031814 RID: 202772 RVA: 0x00B79D54 File Offset: 0x00B77F54
		private TrapDefenseBuildingDevelopTypeGridItem InitGridItem()
		{
			return new TrapDefenseBuildingDevelopTypeGridItem
			{
				OnItemClickCallback = new Action<TrapDefenseBuildingDevelopItemData>(this.OnClickItem),
				CanExecuteChangeCb = new Func<TrapDefenseBuildingDevelopItemData, bool>(this.CanExecuteChange),
				OnPointDownCb = new Action<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData>(this.OnPointerDown),
				OnPointUpCb = new Action<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData>(this.OnPointerUp)
			};
		}

		// Token: 0x06031815 RID: 202773 RVA: 0x00B79DAE File Offset: 0x00B77FAE
		public void SetScrollParent(UUIScrollViewWithScrollbarComponent scroll)
		{
			this.ScrollParent = scroll;
		}

		// Token: 0x06031816 RID: 202774 RVA: 0x00B79DB7 File Offset: 0x00B77FB7
		public bool GetChildRefreshed()
		{
			return this.IsRefreshed;
		}

		// Token: 0x06031817 RID: 202775 RVA: 0x00B79DC0 File Offset: 0x00B77FC0
		public override void Refresh(TrapDefenseBuildingTypeData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.DataList = data.GetDataList();
			if (data.IsInDungeon && data.Type == ETrapDefenseMachineType.Auxiliary)
			{
				this.RefreshAuxiliaryTabName();
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.GetTitleId(), Array.Empty<object>());
			}
			this.IsRefreshed = false;
			this.Layout.RefreshByData(this.DataList, delegate
			{
				this.SetInitSelect();
				this.IsRefreshed = true;
				if (this.ScrollParent != null)
				{
					TimerSystem.Instance.Next(delegate(float _)
					{
						TimerSystem.Instance.Next(delegate(float _)
						{
							FVector2D fvector2D = new FVector2D();
							UUIScrollViewWithScrollbarComponent scrollParent = this.ScrollParent;
							if (scrollParent != null)
							{
								scrollParent.ScrollToTop(ref fvector2D, this.RootItem, false);
							}
							this.ScrollParent = null;
						}, null, null);
					}, null, null);
				}
			}, true);
		}

		// Token: 0x06031818 RID: 202776 RVA: 0x00B79E3C File Offset: 0x00B7803C
		private void RefreshAuxiliaryTabName()
		{
			List<TrapDefenseBuildingSlotData> slotData = TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetSlotData();
			int num = 0;
			foreach (TrapDefenseBuildingSlotData trapDefenseBuildingSlotData in slotData)
			{
				TrapDefenseBuildingDevelopItemData slotData2 = trapDefenseBuildingSlotData.GetSlotData();
				if (slotData2 != null)
				{
					num += ((slotData2 == null || !slotData2.IsBuilding) ? 1 : 0);
				}
			}
			float auxiliaryLimit = TrapDefenseModel.Instance.BattleData.GetAuxiliaryLimit();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.Data.GetTitleId(), new <>z__ReadOnlyArray<object>(new object[]
			{
				num,
				auxiliaryLimit
			}));
		}

		// Token: 0x06031819 RID: 202777 RVA: 0x00B79EF8 File Offset: 0x00B780F8
		public void UpdateEquipped()
		{
			if (this.Data.IsInDungeon && this.Data.Type == ETrapDefenseMachineType.Auxiliary)
			{
				this.RefreshAuxiliaryTabName();
			}
			foreach (TrapDefenseBuildingDevelopTypeGridItem trapDefenseBuildingDevelopTypeGridItem in this.Layout.GetLayoutItemList())
			{
				trapDefenseBuildingDevelopTypeGridItem.UpdateState();
			}
		}

		// Token: 0x0603181A RID: 202778 RVA: 0x00B79F70 File Offset: 0x00B78170
		public void SetInitSelect()
		{
			if (this.Data.CurSelectedData != null)
			{
				int num = this.DataList.IndexOf(this.Data.CurSelectedData);
				this.Layout.SelectGridProxy(num, false);
				TrapDefenseBuildingDevelopTypeGridItem layoutItemByIndex = this.Layout.GetLayoutItemByIndex(num);
				if (layoutItemByIndex != null)
				{
					layoutItemByIndex.OnForceSelected();
				}
				EventSystem.Instance.Emit<TrapDefenseBuildingDevelopItemData>(EEventName.TrapDefenseBuildingDevelopSelectUpdate, this.Data.CurSelectedData);
				return;
			}
			this.Layout.DeselectCurrentGridProxy();
		}

		// Token: 0x0603181B RID: 202779 RVA: 0x00B79FEC File Offset: 0x00B781EC
		public void CheckSelectedIsInTypeItem(TrapDefenseBuildingDevelopItemData data)
		{
			this.Layout.DeselectCurrentGridProxy();
			if (this.Data.PlacementType != data.GetPlacementType())
			{
				return;
			}
			int gridIndex = this.DataList.IndexOf(data);
			GenericLayout<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData> layout = this.Layout;
			if (layout == null)
			{
				return;
			}
			layout.SelectGridProxy(gridIndex, false);
		}

		// Token: 0x0603181C RID: 202780 RVA: 0x00B7A038 File Offset: 0x00B78238
		public bool CheckBottomItemIsInTypeItem(TrapDefenseBuildingDevelopItemData data)
		{
			this.Layout.DeselectCurrentGridProxy();
			if (this.Data.PlacementType != data.GetPlacementType())
			{
				return false;
			}
			int num = this.DataList.IndexOf(data);
			GenericLayout<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData> layout = this.Layout;
			if (layout != null)
			{
				layout.SelectGridProxy(num, false);
			}
			TrapDefenseBuildingDevelopTypeGridItem layoutItemByIndex = this.Layout.GetLayoutItemByIndex(num);
			if (layoutItemByIndex != null)
			{
				layoutItemByIndex.OnForceSelected();
			}
			return true;
		}

		// Token: 0x0603181D RID: 202781 RVA: 0x00B7A0A0 File Offset: 0x00B782A0
		private void OnClickItem(TrapDefenseBuildingDevelopItemData data)
		{
			TrapDefenseBuildingDevelopItemData curSelectedData = this.Data.CurSelectedData;
			EventSystem.Instance.Emit<TrapDefenseBuildingDevelopItemData>(EEventName.TrapDefenseBuildingDevelopSelectUpdate, data);
			if (curSelectedData != null)
			{
				int index = this.DataList.IndexOf(curSelectedData);
				TrapDefenseBuildingDevelopTypeGridItem layoutItemByIndex = this.Layout.GetLayoutItemByIndex(index);
				if (layoutItemByIndex == null)
				{
					return;
				}
				layoutItemByIndex.OnDeselected(false);
			}
		}

		// Token: 0x0603181E RID: 202782 RVA: 0x00B7A0F1 File Offset: 0x00B782F1
		private bool CanExecuteChange(TrapDefenseBuildingDevelopItemData data)
		{
			return data != this.Data.CurSelectedData;
		}

		// Token: 0x0603181F RID: 202783 RVA: 0x00B7A104 File Offset: 0x00B78304
		private void OnPointerDown(TrapDefenseBuildingDevelopTypeGridItem item, TrapDefenseBuildingDevelopItemData data)
		{
			if (this.OnPointerDownCb != null)
			{
				this.OnPointerDownCb(item, data);
			}
		}

		// Token: 0x06031820 RID: 202784 RVA: 0x00B7A11B File Offset: 0x00B7831B
		private void OnPointerUp(TrapDefenseBuildingDevelopTypeGridItem item, TrapDefenseBuildingDevelopItemData data)
		{
			if (this.OnPointerUpCb != null)
			{
				this.OnPointerUpCb(item, data);
			}
		}

		// Token: 0x06031821 RID: 202785 RVA: 0x00B7A134 File Offset: 0x00B78334
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			string a = configParams[0];
			if (!(a == "MachineGrid"))
			{
				if (a == "FirstLevelTwoGrid")
				{
					int num = this.DataList.FindIndex((TrapDefenseBuildingDevelopItemData data) => data.GetLevel() == 2);
					if (num >= 0)
					{
						GenericLayout<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData> layout = this.Layout;
						UUIItem uuiitem = (layout != null) ? layout.GetItemByIndex(num) : null;
						if (uuiitem == null)
						{
							return null;
						}
						return new UUIItem[]
						{
							uuiitem,
							uuiitem
						};
					}
				}
				return null;
			}
			if (configParams.Length < 3)
			{
				return null;
			}
			int num2;
			if (!int.TryParse(configParams[2], out num2) || num2 < 0 || num2 >= this.DataList.Count)
			{
				return null;
			}
			UUIItem itemByIndex = this.Layout.GetItemByIndex(num2);
			if (itemByIndex == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				itemByIndex,
				itemByIndex
			};
		}

		// Token: 0x0401A76C RID: 108396
		private TrapDefenseBuildingTypeData Data;

		// Token: 0x0401A76D RID: 108397
		private List<TrapDefenseBuildingDevelopItemData> DataList = new List<TrapDefenseBuildingDevelopItemData>();

		// Token: 0x0401A76E RID: 108398
		private UUIScrollViewWithScrollbarComponent ScrollParent;

		// Token: 0x0401A76F RID: 108399
		private bool IsRefreshed;

		// Token: 0x0401A770 RID: 108400
		public Action<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData> OnPointerDownCb;

		// Token: 0x0401A771 RID: 108401
		public Action<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData> OnPointerUpCb;

		// Token: 0x0401A772 RID: 108402
		protected GenericLayout<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData> Layout;

		// Token: 0x0200ABF3 RID: 44019
		[NullableContext(0)]
		private class EItemType
		{
			// Token: 0x04034407 RID: 214023
			public const int Icon = 0;

			// Token: 0x04034408 RID: 214024
			public const int Title = 1;

			// Token: 0x04034409 RID: 214025
			public const int Layout = 2;

			// Token: 0x0403440A RID: 214026
			public const int ItemBase = 3;

			// Token: 0x0403440B RID: 214027
			public const int PanelIcon = 4;
		}
	}
}
