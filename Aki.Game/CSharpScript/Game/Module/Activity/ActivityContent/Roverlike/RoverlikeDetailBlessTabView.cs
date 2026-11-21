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
	// Token: 0x020050A7 RID: 20647
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeDetailBlessTabView : UiTabViewBase
	{
		// Token: 0x06033AD6 RID: 211670 RVA: 0x00E768EC File Offset: 0x00E74AEC
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

		// Token: 0x06033AD7 RID: 211671 RVA: 0x00E76A84 File Offset: 0x00E74C84
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeDetailBlessTabView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeDetailBlessTabView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033AD8 RID: 211672 RVA: 0x00E76AC7 File Offset: 0x00E74CC7
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

		// Token: 0x06033AD9 RID: 211673 RVA: 0x00E76AF5 File Offset: 0x00E74CF5
		protected override void OnShowUiTabViewFromToggle()
		{
			if (this.MultiList != null)
			{
				this.RefreshList();
			}
		}

		// Token: 0x06033ADA RID: 211674 RVA: 0x00E76B05 File Offset: 0x00E74D05
		protected override void OnBeforeDestroy()
		{
			this.MultiListAnimController = null;
		}

		// Token: 0x06033ADB RID: 211675 RVA: 0x00E76B10 File Offset: 0x00E74D10
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

		// Token: 0x06033ADC RID: 211676 RVA: 0x00E76D40 File Offset: 0x00E74F40
		private void PushTitle(string titleKey)
		{
			RoverlikeCollectTitleTemplateData roverlikeCollectTitleTemplateData = new RoverlikeCollectTitleTemplateData();
			roverlikeCollectTitleTemplateData.Data = new RoverlikeCollectTitleData
			{
				TitleKey = titleKey
			};
			this.ScrollDataList.Add(roverlikeCollectTitleTemplateData);
		}

		// Token: 0x06033ADD RID: 211677 RVA: 0x00E76D74 File Offset: 0x00E74F74
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

		// Token: 0x06033ADE RID: 211678 RVA: 0x00E76DE0 File Offset: 0x00E74FE0
		private int GetSlotIdByGridIndex(int gridIndex)
		{
			int num = gridIndex - this.FirstSlotIndex;
			if (this.FirstSlotIndex < 0 || num < 0 || num >= this.SlotList.Count)
			{
				return 0;
			}
			return this.SlotList[num];
		}

		// Token: 0x06033ADF RID: 211679 RVA: 0x00E76E20 File Offset: 0x00E75020
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

		// Token: 0x06033AE0 RID: 211680 RVA: 0x00E76E54 File Offset: 0x00E75054
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

		// Token: 0x06033AE1 RID: 211681 RVA: 0x00E76ED8 File Offset: 0x00E750D8
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

		// Token: 0x06033AE2 RID: 211682 RVA: 0x00E76FB0 File Offset: 0x00E751B0
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

		// Token: 0x06033AE3 RID: 211683 RVA: 0x00E7712E File Offset: 0x00E7532E
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

		// Token: 0x06033AE4 RID: 211684 RVA: 0x00E77169 File Offset: 0x00E75369
		private void OnGridClick(RoverlikeGainEntry data, int gridIndex)
		{
			if (gridIndex == this.SelectedGridIndex)
			{
				return;
			}
			this.SelectByGridIndex(gridIndex);
		}

		// Token: 0x06033AE5 RID: 211685 RVA: 0x00E7717C File Offset: 0x00E7537C
		private bool IsGridSelected(RoverlikeGainEntry data, int gridIndex)
		{
			return gridIndex == this.SelectedGridIndex;
		}

		// Token: 0x0401B673 RID: 112243
		[Nullable(2)]
		private MultiTemplateScrollView MultiList;

		// Token: 0x0401B674 RID: 112244
		[Nullable(2)]
		private UUIInturnAnimController MultiListAnimController;

		// Token: 0x0401B675 RID: 112245
		[Nullable(2)]
		private RoverlikeBlessingCardItem DetailCard;

		// Token: 0x0401B676 RID: 112246
		private readonly List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0401B677 RID: 112247
		private int SelectedGridIndex = -1;

		// Token: 0x0401B678 RID: 112248
		private List<int> SlotList = new List<int>();

		// Token: 0x0401B679 RID: 112249
		private int FirstSlotIndex = -1;

		// Token: 0x0200AD6A RID: 44394
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04035963 RID: 219491
			SvMulti,
			// Token: 0x04035964 RID: 219492
			PanelTitle,
			// Token: 0x04035965 RID: 219493
			ItemBaseGrid,
			// Token: 0x04035966 RID: 219494
			PanelEmpty,
			// Token: 0x04035967 RID: 219495
			ItemBlessDetail,
			// Token: 0x04035968 RID: 219496
			ItemPropDetail,
			// Token: 0x04035969 RID: 219497
			ItemReinforceDetail,
			// Token: 0x0403596A RID: 219498
			PanelEmptySlot,
			// Token: 0x0403596B RID: 219499
			TexEmptyIcon,
			// Token: 0x0403596C RID: 219500
			TxtEmptyName,
			// Token: 0x0403596D RID: 219501
			PanelEmptyGeneral
		}
	}
}
