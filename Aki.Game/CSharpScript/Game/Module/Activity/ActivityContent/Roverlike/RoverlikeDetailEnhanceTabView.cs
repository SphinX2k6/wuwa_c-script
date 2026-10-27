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
	// Token: 0x0200612A RID: 24874
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeDetailEnhanceTabView : UiTabViewBase
	{
		// Token: 0x0603EE25 RID: 257573 RVA: 0x00F303A0 File Offset: 0x00F2E5A0
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

		// Token: 0x0603EE26 RID: 257574 RVA: 0x00F30538 File Offset: 0x00F2E738
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeDetailEnhanceTabView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeDetailEnhanceTabView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EE27 RID: 257575 RVA: 0x00F3057B File Offset: 0x00F2E77B
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.RefreshList();
		}

		// Token: 0x0603EE28 RID: 257576 RVA: 0x00F30596 File Offset: 0x00F2E796
		protected override void OnShowUiTabViewFromToggle()
		{
			if (this.MultiList != null)
			{
				this.RefreshList();
			}
		}

		// Token: 0x0603EE29 RID: 257577 RVA: 0x00F305A6 File Offset: 0x00F2E7A6
		protected override void OnBeforeDestroy()
		{
			this.MultiListAnimController = null;
		}

		// Token: 0x0603EE2A RID: 257578 RVA: 0x00F305B0 File Offset: 0x00F2E7B0
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

		// Token: 0x0603EE2B RID: 257579 RVA: 0x00F3073C File Offset: 0x00F2E93C
		private void PushTitle(string titleKey)
		{
			RoverlikeCollectTitleTemplateData roverlikeCollectTitleTemplateData = new RoverlikeCollectTitleTemplateData();
			roverlikeCollectTitleTemplateData.Data = new RoverlikeCollectTitleData
			{
				TitleKey = titleKey
			};
			this.ScrollDataList.Add(roverlikeCollectTitleTemplateData);
		}

		// Token: 0x0603EE2C RID: 257580 RVA: 0x00F30770 File Offset: 0x00F2E970
		private int PushGrid(RoverlikeGainEntry entry)
		{
			RoverlikeEntryGridItemTemplateData roverlikeEntryGridItemTemplateData = new RoverlikeEntryGridItemTemplateData();
			roverlikeEntryGridItemTemplateData.Data = entry;
			roverlikeEntryGridItemTemplateData.OnClickCb = new Action<RoverlikeGainEntry, int>(this.OnGridClick);
			roverlikeEntryGridItemTemplateData.IsSelected = new Func<RoverlikeGainEntry, int, bool>(this.IsGridSelected);
			this.ScrollDataList.Add(roverlikeEntryGridItemTemplateData);
			return this.ScrollDataList.Count - 1;
		}

		// Token: 0x0603EE2D RID: 257581 RVA: 0x00F307C8 File Offset: 0x00F2E9C8
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

		// Token: 0x0603EE2E RID: 257582 RVA: 0x00F307FC File Offset: 0x00F2E9FC
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

		// Token: 0x0603EE2F RID: 257583 RVA: 0x00F30880 File Offset: 0x00F2EA80
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

		// Token: 0x0603EE30 RID: 257584 RVA: 0x00F30974 File Offset: 0x00F2EB74
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

		// Token: 0x0603EE31 RID: 257585 RVA: 0x00F309CD File Offset: 0x00F2EBCD
		private void OnGridClick(RoverlikeGainEntry data, int gridIndex)
		{
			if (gridIndex == this.SelectedGridIndex)
			{
				return;
			}
			this.SelectByGridIndex(gridIndex);
		}

		// Token: 0x0603EE32 RID: 257586 RVA: 0x00F309E0 File Offset: 0x00F2EBE0
		private bool IsGridSelected(RoverlikeGainEntry data, int gridIndex)
		{
			return gridIndex == this.SelectedGridIndex;
		}

		// Token: 0x04020D4D RID: 134477
		[Nullable(2)]
		private MultiTemplateScrollView MultiList;

		// Token: 0x04020D4E RID: 134478
		[Nullable(2)]
		private UUIInturnAnimController MultiListAnimController;

		// Token: 0x04020D4F RID: 134479
		[Nullable(2)]
		private RoverlikeReinforcementCardItem ReinforceCard;

		// Token: 0x04020D50 RID: 134480
		[Nullable(2)]
		private RoverlikePropCardItem PropCard;

		// Token: 0x04020D51 RID: 134481
		private readonly List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x04020D52 RID: 134482
		private int SelectedGridIndex = -1;

		// Token: 0x0200C384 RID: 50052
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403B00E RID: 241678
			SvMulti,
			// Token: 0x0403B00F RID: 241679
			PanelTitle,
			// Token: 0x0403B010 RID: 241680
			ItemBaseGrid,
			// Token: 0x0403B011 RID: 241681
			PanelEmpty,
			// Token: 0x0403B012 RID: 241682
			ItemBlessDetail,
			// Token: 0x0403B013 RID: 241683
			ItemPropDetail,
			// Token: 0x0403B014 RID: 241684
			ItemReinforceDetail,
			// Token: 0x0403B015 RID: 241685
			PanelEmptySlot,
			// Token: 0x0403B016 RID: 241686
			SprEmptyIcon,
			// Token: 0x0403B017 RID: 241687
			TxtEmptyName,
			// Token: 0x0403B018 RID: 241688
			PanelEmptyGeneral
		}
	}
}
