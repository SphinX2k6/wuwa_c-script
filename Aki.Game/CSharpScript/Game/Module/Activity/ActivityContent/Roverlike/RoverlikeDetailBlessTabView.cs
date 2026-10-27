using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006129 RID: 24873
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeDetailBlessTabView : UiTabViewBase
	{
		// Token: 0x0603EE14 RID: 257556 RVA: 0x00F2FAD8 File Offset: 0x00F2DCD8
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
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603EE15 RID: 257557 RVA: 0x00F2FC70 File Offset: 0x00F2DE70
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeDetailBlessTabView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeDetailBlessTabView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EE16 RID: 257558 RVA: 0x00F2FCB3 File Offset: 0x00F2DEB3
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			this.RefreshList();
		}

		// Token: 0x0603EE17 RID: 257559 RVA: 0x00F2FCE1 File Offset: 0x00F2DEE1
		protected override void OnShowUiTabViewFromToggle()
		{
			if (this.MultiList != null)
			{
				this.RefreshList();
			}
		}

		// Token: 0x0603EE18 RID: 257560 RVA: 0x00F2FCF1 File Offset: 0x00F2DEF1
		protected override void OnBeforeDestroy()
		{
			this.MultiListAnimController = null;
		}

		// Token: 0x0603EE19 RID: 257561 RVA: 0x00F2FCFC File Offset: 0x00F2DEFC
		private void RefreshList()
		{
			this.ScrollDataList.Clear();
			this.SelectedGridIndex = -1;
			RoverlikeInstanceData instanceData = RoverlikeModel.Instance.InstanceData;
			List<RoverlikeGainEntry> list = ((instanceData != null) ? instanceData.GetBlessList() : null) ?? new List<RoverlikeGainEntry>();
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			int[] array;
			if (instance == null)
			{
				array = null;
			}
			else
			{
				RoverlikeActivityData currentActivityData = instance.GetCurrentActivityData();
				array = ((currentActivityData != null) ? currentActivityData.GetParamConfig().Value.SlotList() : null);
			}
			int[] array2 = array ?? Array.Empty<int>();
			HashSet<int> hashSet = new HashSet<int>(array2);
			Dictionary<int, RoverlikeGainEntry> dictionary = new Dictionary<int, RoverlikeGainEntry>();
			List<RoverlikeGainEntry> list2 = new List<RoverlikeGainEntry>();
			foreach (RoverlikeGainEntry roverlikeGainEntry in list)
			{
				RoverRogueBless? blessConfig = RoverlikeConfig.Instance.GetBlessConfig(roverlikeGainEntry.ConfigId);
				if (blessConfig != null && hashSet.Contains(blessConfig.Value.SlotId))
				{
					dictionary[blessConfig.Value.SlotId] = roverlikeGainEntry;
				}
				else
				{
					list2.Add(roverlikeGainEntry);
				}
			}
			this.PushTitle("RoverRogue_SystemShow_CoreBlessing");
			int count = this.ScrollDataList.Count;
			this.SlotList = new List<int>(array2);
			this.FirstSlotIndex = count;
			foreach (int key in array2)
			{
				RoverlikeGainEntry roverlikeGainEntry2;
				dictionary.TryGetValue(key, out roverlikeGainEntry2);
				RoverlikeGainEntry entry = roverlikeGainEntry2 ?? new RoverlikeGainEntry();
				this.PushGrid(entry, true);
			}
			RoverlikeInstanceData.SortGainEntryList(list2);
			this.PushTitle("RoverRogue_SystemShow_NormalBlessing");
			if (list2.Count > 0)
			{
				using (List<RoverlikeGainEntry>.Enumerator enumerator = list2.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						RoverlikeGainEntry entry2 = enumerator.Current;
						this.PushGrid(entry2, false);
					}
					goto IL_1C4;
				}
			}
			this.PushEmpty("RoverRogue_BlessingNotGet");
			IL_1C4:
			MultiTemplateScrollViewRefreshContext multiTemplateScrollViewRefreshContext = new MultiTemplateScrollViewRefreshContext(this.ScrollDataList);
			multiTemplateScrollViewRefreshContext.ScrollToGridIndex = 0;
			this.MultiList.RefreshByData(multiTemplateScrollViewRefreshContext);
			UUIInturnAnimController multiListAnimController = this.MultiListAnimController;
			if (multiListAnimController != null)
			{
				multiListAnimController.Play("", -1, true);
			}
			this.SelectByGridIndex(count);
		}

		// Token: 0x0603EE1A RID: 257562 RVA: 0x00F2FF2C File Offset: 0x00F2E12C
		private void PushTitle(string titleKey)
		{
			RoverlikeCollectTitleTemplateData roverlikeCollectTitleTemplateData = new RoverlikeCollectTitleTemplateData();
			roverlikeCollectTitleTemplateData.Data = new RoverlikeCollectTitleData
			{
				TitleKey = titleKey
			};
			this.ScrollDataList.Add(roverlikeCollectTitleTemplateData);
		}

		// Token: 0x0603EE1B RID: 257563 RVA: 0x00F2FF60 File Offset: 0x00F2E160
		private int PushGrid(RoverlikeGainEntry entry, bool isSlotGroup = false)
		{
			RoverlikeEntryGridItemTemplateData roverlikeEntryGridItemTemplateData = new RoverlikeEntryGridItemTemplateData();
			roverlikeEntryGridItemTemplateData.Data = entry;
			roverlikeEntryGridItemTemplateData.OnClickCb = new Action<RoverlikeGainEntry, int>(this.OnGridClick);
			roverlikeEntryGridItemTemplateData.IsSelected = new Func<RoverlikeGainEntry, int, bool>(this.IsGridSelected);
			if (isSlotGroup)
			{
				roverlikeEntryGridItemTemplateData.GetSlotId = new Func<int, int>(this.GetSlotIdByGridIndex);
			}
			this.ScrollDataList.Add(roverlikeEntryGridItemTemplateData);
			return this.ScrollDataList.Count - 1;
		}

		// Token: 0x0603EE1C RID: 257564 RVA: 0x00F2FFCC File Offset: 0x00F2E1CC
		private int GetSlotIdByGridIndex(int gridIndex)
		{
			int num = gridIndex - this.FirstSlotIndex;
			if (this.FirstSlotIndex < 0 || num < 0 || num >= this.SlotList.Count)
			{
				return 0;
			}
			return this.SlotList[num];
		}

		// Token: 0x0603EE1D RID: 257565 RVA: 0x00F3000C File Offset: 0x00F2E20C
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

		// Token: 0x0603EE1E RID: 257566 RVA: 0x00F30040 File Offset: 0x00F2E240
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

		// Token: 0x0603EE1F RID: 257567 RVA: 0x00F300C4 File Offset: 0x00F2E2C4
		[NullableContext(2)]
		private void RefreshDetail(RoverlikeGainEntry entry)
		{
			if (entry == null || entry.ConfigId <= 0)
			{
				int num = this.SelectedGridIndex - this.FirstSlotIndex;
				if (this.FirstSlotIndex >= 0 && num >= 0 && num < this.SlotList.Count)
				{
					this.ShowSlotEmptyDetail(this.SlotList[num]);
					return;
				}
				this.ShowEmptyDetail();
				return;
			}
			else
			{
				UUIItem item = base.GetItem(4);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUIItem item2 = base.GetItem(7);
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
				UUIItem item3 = base.GetItem(10);
				if (item3 != null)
				{
					item3.SetUIActive(false);
				}
				RoverlikeBlessingItemData data = new RoverlikeBlessingItemData
				{
					BlessId = entry.ConfigId,
					IncId = new int?(entry.IncId),
					AllowToggleInteract = new bool?(false)
				};
				RoverlikeBlessingCardItem detailCard = this.DetailCard;
				if (detailCard == null)
				{
					return;
				}
				detailCard.Refresh(data, false, 0);
				return;
			}
		}

		// Token: 0x0603EE20 RID: 257568 RVA: 0x00F3019C File Offset: 0x00F2E39C
		private void ShowSlotEmptyDetail(int slotId)
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(10);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(7);
			if (item3 != null)
			{
				item3.SetUIActive(true);
			}
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			RoverRogueActivity? roverRogueActivity;
			if (instance == null)
			{
				roverRogueActivity = null;
			}
			else
			{
				RoverlikeActivityData currentActivityData = instance.GetCurrentActivityData();
				roverRogueActivity = ((currentActivityData != null) ? currentActivityData.GetParamConfig() : null);
			}
			RoverRogueActivity? roverRogueActivity2 = roverRogueActivity;
			if (roverRogueActivity2 == null)
			{
				return;
			}
			RoverRogueActivity value = roverRogueActivity2.Value;
			string text = null;
			for (int i = 0; i < value.SlotEmptyIconLength; i++)
			{
				DicIntString? dicIntString = value.SlotEmptyIcon(i);
				if (dicIntString != null && dicIntString.GetValueOrDefault().Key == slotId)
				{
					text = dicIntString.Value.Value;
					break;
				}
			}
			UUITexture texture = base.GetTexture(8);
			if (texture != null)
			{
				if (text != null)
				{
					base.SetTextureShowUntilLoaded(text, texture, null);
				}
				else
				{
					texture.SetUIActive(false);
				}
			}
			string text2 = null;
			for (int j = 0; j < value.SlotNameLength; j++)
			{
				DicIntString? dicIntString2 = value.SlotName(j);
				if (dicIntString2 != null && dicIntString2.GetValueOrDefault().Key == slotId)
				{
					text2 = dicIntString2.Value.Value;
					break;
				}
			}
			UUIText text3 = base.GetText(9);
			if (text3 != null && text2 != null)
			{
				LguiUtil.Instance.SetLocalTextNew(text3, text2, Array.Empty<object>());
			}
		}

		// Token: 0x0603EE21 RID: 257569 RVA: 0x00F3031A File Offset: 0x00F2E51A
		private void ShowEmptyDetail()
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(7);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(10);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(true);
		}

		// Token: 0x0603EE22 RID: 257570 RVA: 0x00F30355 File Offset: 0x00F2E555
		private void OnGridClick(RoverlikeGainEntry data, int gridIndex)
		{
			if (gridIndex == this.SelectedGridIndex)
			{
				return;
			}
			this.SelectByGridIndex(gridIndex);
		}

		// Token: 0x0603EE23 RID: 257571 RVA: 0x00F30368 File Offset: 0x00F2E568
		private bool IsGridSelected(RoverlikeGainEntry data, int gridIndex)
		{
			return gridIndex == this.SelectedGridIndex;
		}

		// Token: 0x04020D46 RID: 134470
		[Nullable(2)]
		private MultiTemplateScrollView MultiList;

		// Token: 0x04020D47 RID: 134471
		[Nullable(2)]
		private UUIInturnAnimController MultiListAnimController;

		// Token: 0x04020D48 RID: 134472
		[Nullable(2)]
		private RoverlikeBlessingCardItem DetailCard;

		// Token: 0x04020D49 RID: 134473
		private readonly List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x04020D4A RID: 134474
		private int SelectedGridIndex = -1;

		// Token: 0x04020D4B RID: 134475
		private List<int> SlotList = new List<int>();

		// Token: 0x04020D4C RID: 134476
		private int FirstSlotIndex = -1;

		// Token: 0x0200C382 RID: 50050
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403AFFE RID: 241662
			SvMulti,
			// Token: 0x0403AFFF RID: 241663
			PanelTitle,
			// Token: 0x0403B000 RID: 241664
			ItemBaseGrid,
			// Token: 0x0403B001 RID: 241665
			PanelEmpty,
			// Token: 0x0403B002 RID: 241666
			ItemBlessDetail,
			// Token: 0x0403B003 RID: 241667
			ItemPropDetail,
			// Token: 0x0403B004 RID: 241668
			ItemReinforceDetail,
			// Token: 0x0403B005 RID: 241669
			PanelEmptySlot,
			// Token: 0x0403B006 RID: 241670
			TexEmptyIcon,
			// Token: 0x0403B007 RID: 241671
			TxtEmptyName,
			// Token: 0x0403B008 RID: 241672
			PanelEmptyGeneral
		}
	}
}
