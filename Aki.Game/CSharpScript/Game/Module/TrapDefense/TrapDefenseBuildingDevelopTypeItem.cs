using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A44 RID: 14916
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseBuildingDevelopTypeItem : GridProxyAbstract<TrapDefenseBuildingTypeData>
	{
		// Token: 0x060265A2 RID: 157090 RVA: 0x00ABDC04 File Offset: 0x00ABBE04
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

		// Token: 0x060265A3 RID: 157091 RVA: 0x00ABDCD0 File Offset: 0x00ABBED0
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.Layout = new GenericLayout<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData>(base.GetGridLayout(2), new Func<TrapDefenseBuildingDevelopTypeGridItem>(this.InitGridItem), null, false, true);
		}

		// Token: 0x060265A4 RID: 157092 RVA: 0x00ABDD08 File Offset: 0x00ABBF08
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

		// Token: 0x060265A5 RID: 157093 RVA: 0x00ABDD62 File Offset: 0x00ABBF62
		public void SetScrollParent(UUIScrollViewWithScrollbarComponent scroll)
		{
			this.ScrollParent = scroll;
		}

		// Token: 0x060265A6 RID: 157094 RVA: 0x00ABDD6B File Offset: 0x00ABBF6B
		public bool GetChildRefreshed()
		{
			return this.IsRefreshed;
		}

		// Token: 0x060265A7 RID: 157095 RVA: 0x00ABDD74 File Offset: 0x00ABBF74
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

		// Token: 0x060265A8 RID: 157096 RVA: 0x00ABDDF0 File Offset: 0x00ABBFF0
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

		// Token: 0x060265A9 RID: 157097 RVA: 0x00ABDEAC File Offset: 0x00ABC0AC
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

		// Token: 0x060265AA RID: 157098 RVA: 0x00ABDF24 File Offset: 0x00ABC124
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

		// Token: 0x060265AB RID: 157099 RVA: 0x00ABDFA0 File Offset: 0x00ABC1A0
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

		// Token: 0x060265AC RID: 157100 RVA: 0x00ABDFEC File Offset: 0x00ABC1EC
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

		// Token: 0x060265AD RID: 157101 RVA: 0x00ABE054 File Offset: 0x00ABC254
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

		// Token: 0x060265AE RID: 157102 RVA: 0x00ABE0A5 File Offset: 0x00ABC2A5
		private bool CanExecuteChange(TrapDefenseBuildingDevelopItemData data)
		{
			return data != this.Data.CurSelectedData;
		}

		// Token: 0x060265AF RID: 157103 RVA: 0x00ABE0B8 File Offset: 0x00ABC2B8
		private void OnPointerDown(TrapDefenseBuildingDevelopTypeGridItem item, TrapDefenseBuildingDevelopItemData data)
		{
			if (this.OnPointerDownCb != null)
			{
				this.OnPointerDownCb(item, data);
			}
		}

		// Token: 0x060265B0 RID: 157104 RVA: 0x00ABE0CF File Offset: 0x00ABC2CF
		private void OnPointerUp(TrapDefenseBuildingDevelopTypeGridItem item, TrapDefenseBuildingDevelopItemData data)
		{
			if (this.OnPointerUpCb != null)
			{
				this.OnPointerUpCb(item, data);
			}
		}

		// Token: 0x060265B1 RID: 157105 RVA: 0x00ABE0E8 File Offset: 0x00ABC2E8
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

		// Token: 0x040150BE RID: 86206
		private TrapDefenseBuildingTypeData Data;

		// Token: 0x040150BF RID: 86207
		private List<TrapDefenseBuildingDevelopItemData> DataList = new List<TrapDefenseBuildingDevelopItemData>();

		// Token: 0x040150C0 RID: 86208
		private UUIScrollViewWithScrollbarComponent ScrollParent;

		// Token: 0x040150C1 RID: 86209
		private bool IsRefreshed;

		// Token: 0x040150C2 RID: 86210
		public Action<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData> OnPointerDownCb;

		// Token: 0x040150C3 RID: 86211
		public Action<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData> OnPointerUpCb;

		// Token: 0x040150C4 RID: 86212
		protected GenericLayout<TrapDefenseBuildingDevelopTypeGridItem, TrapDefenseBuildingDevelopItemData> Layout;

		// Token: 0x02009613 RID: 38419
		[NullableContext(0)]
		private class EItemType
		{
			// Token: 0x0402EDB8 RID: 191928
			public const int Icon = 0;

			// Token: 0x0402EDB9 RID: 191929
			public const int Title = 1;

			// Token: 0x0402EDBA RID: 191930
			public const int Layout = 2;

			// Token: 0x0402EDBB RID: 191931
			public const int ItemBase = 3;

			// Token: 0x0402EDBC RID: 191932
			public const int PanelIcon = 4;
		}
	}
}
