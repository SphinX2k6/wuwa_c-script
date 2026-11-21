using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050A8 RID: 20648
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeDetailEnhanceTabView : UiTabViewBase
	{
		// Token: 0x06033AE7 RID: 211687 RVA: 0x00E771B4 File Offset: 0x00E753B4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIMultiTemplateScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033AE8 RID: 211688 RVA: 0x00E7734C File Offset: 0x00E7554C
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeDetailEnhanceTabView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeDetailEnhanceTabView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033AE9 RID: 211689 RVA: 0x00E7738F File Offset: 0x00E7558F
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.RefreshList();
		}

		// Token: 0x06033AEA RID: 211690 RVA: 0x00E773AA File Offset: 0x00E755AA
		protected override void OnShowUiTabViewFromToggle()
		{
			if (this.MultiList != null)
			{
				this.RefreshList();
			}
		}

		// Token: 0x06033AEB RID: 211691 RVA: 0x00E773BA File Offset: 0x00E755BA
		protected override void OnBeforeDestroy()
		{
			this.MultiListAnimController = null;
		}

		// Token: 0x06033AEC RID: 211692 RVA: 0x00E773C4 File Offset: 0x00E755C4
		private void RefreshList()
		{
			this.ScrollDataList.Clear();
			this.SelectedGridIndex = -1;
			RoverlikeInstanceData instanceData = RoverlikeModel.Instance.InstanceData;
			List<RoverlikeGainEntry> list = ((instanceData != null) ? instanceData.GetRoleEnhanceList() : null) ?? new List<RoverlikeGainEntry>();
			RoverlikeInstanceData instanceData2 = RoverlikeModel.Instance.InstanceData;
			List<RoverlikeGainEntry> list2 = ((instanceData2 != null) ? instanceData2.GetItemList() : null) ?? new List<RoverlikeGainEntry>();
			RoverlikeInstanceData.SortGainEntryList(list);
			RoverlikeInstanceData.SortGainEntryList(list2);
			int num = -1;
			this.PushTitle("RoverRogue_SystemShow_Enhance");
			if (list.Count > 0)
			{
				using (List<RoverlikeGainEntry>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						RoverlikeGainEntry entry = enumerator.Current;
						int num2 = this.PushGrid(entry);
						if (num < 0)
						{
							num = num2;
						}
					}
					goto IL_BC;
				}
			}
			this.PushEmpty("RoverRogue_EnhanceNotGet");
			IL_BC:
			this.PushTitle("RoverRogue_SystemShow_Item");
			if (list2.Count > 0)
			{
				using (List<RoverlikeGainEntry>.Enumerator enumerator = list2.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						RoverlikeGainEntry entry2 = enumerator.Current;
						int num3 = this.PushGrid(entry2);
						if (num < 0)
						{
							num = num3;
						}
					}
					goto IL_118;
				}
			}
			this.PushEmpty("RoverRogue_ItemNotGet");
			IL_118:
			MultiTemplateScrollViewRefreshContext multiTemplateScrollViewRefreshContext = new MultiTemplateScrollViewRefreshContext(this.ScrollDataList);
			multiTemplateScrollViewRefreshContext.ScrollToGridIndex = 0;
			this.MultiList.RefreshByData(multiTemplateScrollViewRefreshContext);
			UUIInturnAnimController multiListAnimController = this.MultiListAnimController;
			if (multiListAnimController != null)
			{
				multiListAnimController.Play("", -1, true);
			}
			if (num >= 0)
			{
				this.SelectByGridIndex(num);
				return;
			}
			this.ShowEmptyDetail();
		}

		// Token: 0x06033AED RID: 211693 RVA: 0x00E77550 File Offset: 0x00E75750
		private void PushTitle(string titleKey)
		{
			RoverlikeCollectTitleTemplateData roverlikeCollectTitleTemplateData = new RoverlikeCollectTitleTemplateData();
			roverlikeCollectTitleTemplateData.Data = new RoverlikeCollectTitleData
			{
				TitleKey = titleKey
			};
			this.ScrollDataList.Add(roverlikeCollectTitleTemplateData);
		}

		// Token: 0x06033AEE RID: 211694 RVA: 0x00E77584 File Offset: 0x00E75784
		private int PushGrid(RoverlikeGainEntry entry)
		{
			RoverlikeEntryGridItemTemplateData roverlikeEntryGridItemTemplateData = new RoverlikeEntryGridItemTemplateData();
			roverlikeEntryGridItemTemplateData.Data = entry;
			roverlikeEntryGridItemTemplateData.OnClickCb = new Action<RoverlikeGainEntry, int>(this.OnGridClick);
			roverlikeEntryGridItemTemplateData.IsSelected = new Func<RoverlikeGainEntry, int, bool>(this.IsGridSelected);
			this.ScrollDataList.Add(roverlikeEntryGridItemTemplateData);
			return this.ScrollDataList.Count - 1;
		}

		// Token: 0x06033AEF RID: 211695 RVA: 0x00E775DC File Offset: 0x00E757DC
		private void PushEmpty(string txt)
		{
			RoverlikeCollectEmptyItemTemplateData roverlikeCollectEmptyItemTemplateData = new RoverlikeCollectEmptyItemTemplateData();
			RoverlikeCollectEmptyData data = new RoverlikeCollectEmptyData
			{
				Txt = txt
			};
			roverlikeCollectEmptyItemTemplateData.Data = data;
			this.ScrollDataList.Add(roverlikeCollectEmptyItemTemplateData);
		}

		// Token: 0x06033AF0 RID: 211696 RVA: 0x00E77610 File Offset: 0x00E75810
		private void SelectByGridIndex(int gridIndex)
		{
			int selectedGridIndex = this.SelectedGridIndex;
			this.SelectedGridIndex = gridIndex;
			if (selectedGridIndex >= 0 && selectedGridIndex != gridIndex)
			{
				this.MultiList.RefreshProxyDirectly(selectedGridIndex);
			}
			this.MultiList.RefreshProxyDirectly(gridIndex);
			RoverlikeGainEntry entry = this.ScrollDataList[gridIndex].Data as RoverlikeGainEntry;
			this.RefreshDetail(entry);
			if (selectedGridIndex >= 0 && selectedGridIndex != gridIndex)
			{
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence == null)
				{
					return;
				}
				uiViewSequence.PlayOrReplaySequenceByName("Switch", false, null);
			}
		}

		// Token: 0x06033AF1 RID: 211697 RVA: 0x00E77694 File Offset: 0x00E75894
		[NullableContext(2)]
		private void RefreshDetail(RoverlikeGainEntry entry)
		{
			bool flag = entry != null && entry.Type == RoverRogueGainDataType.RoverRogueGainRoleEnhance;
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(10);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(6);
			if (item3 != null)
			{
				item3.SetUIActive(flag);
			}
			UUIItem item4 = base.GetItem(5);
			if (item4 != null)
			{
				item4.SetUIActive(!flag);
			}
			if (entry == null)
			{
				return;
			}
			if (flag)
			{
				RoverlikeReinforcementItemData data = new RoverlikeReinforcementItemData
				{
					ConfigId = entry.ConfigId,
					IncId = new int?(entry.IncId),
					AllowToggleInteract = new bool?(false)
				};
				RoverlikeReinforcementCardItem reinforceCard = this.ReinforceCard;
				if (reinforceCard == null)
				{
					return;
				}
				reinforceCard.Refresh(data, false, 0);
				return;
			}
			else
			{
				RoverlikePropItemData data2 = new RoverlikePropItemData
				{
					ConfigId = entry.ConfigId,
					IsInGame = true,
					IncId = new int?(entry.IncId)
				};
				RoverlikePropCardItem propCard = this.PropCard;
				if (propCard == null)
				{
					return;
				}
				propCard.Refresh(data2, false, 0);
				return;
			}
		}

		// Token: 0x06033AF2 RID: 211698 RVA: 0x00E77788 File Offset: 0x00E75988
		private void ShowEmptyDetail()
		{
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(7);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			UUIItem item4 = base.GetItem(10);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(true);
		}

		// Token: 0x06033AF3 RID: 211699 RVA: 0x00E777E1 File Offset: 0x00E759E1
		private void OnGridClick(RoverlikeGainEntry data, int gridIndex)
		{
			if (gridIndex == this.SelectedGridIndex)
			{
				return;
			}
			this.SelectByGridIndex(gridIndex);
		}

		// Token: 0x06033AF4 RID: 211700 RVA: 0x00E777F4 File Offset: 0x00E759F4
		private bool IsGridSelected(RoverlikeGainEntry data, int gridIndex)
		{
			return gridIndex == this.SelectedGridIndex;
		}

		// Token: 0x0401B67A RID: 112250
		[Nullable(2)]
		private MultiTemplateScrollView MultiList;

		// Token: 0x0401B67B RID: 112251
		[Nullable(2)]
		private UUIInturnAnimController MultiListAnimController;

		// Token: 0x0401B67C RID: 112252
		[Nullable(2)]
		private RoverlikeReinforcementCardItem ReinforceCard;

		// Token: 0x0401B67D RID: 112253
		[Nullable(2)]
		private RoverlikePropCardItem PropCard;

		// Token: 0x0401B67E RID: 112254
		private readonly List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0401B67F RID: 112255
		private int SelectedGridIndex = -1;

		// Token: 0x0200AD6C RID: 44396
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04035973 RID: 219507
			SvMulti,
			// Token: 0x04035974 RID: 219508
			PanelTitle,
			// Token: 0x04035975 RID: 219509
			ItemBaseGrid,
			// Token: 0x04035976 RID: 219510
			PanelEmpty,
			// Token: 0x04035977 RID: 219511
			ItemBlessDetail,
			// Token: 0x04035978 RID: 219512
			ItemPropDetail,
			// Token: 0x04035979 RID: 219513
			ItemReinforceDetail,
			// Token: 0x0403597A RID: 219514
			PanelEmptySlot,
			// Token: 0x0403597B RID: 219515
			SprEmptyIcon,
			// Token: 0x0403597C RID: 219516
			TxtEmptyName,
			// Token: 0x0403597D RID: 219517
			PanelEmptyGeneral
		}
	}
}
