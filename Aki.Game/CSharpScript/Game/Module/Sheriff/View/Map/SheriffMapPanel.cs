using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Controller;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Misc;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Module.Track;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Module.WorldMap.SubViews;
using CSharpScript.Game.Module.WorldMap.SubViews.Common;
using CSharpScript.Game.Module.WorldMap.SubViews.MapMarkToggle;
using CSharpScript.Game.Module.WorldMap.ViewComponent;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Map
{
	// Token: 0x02004C64 RID: 19556
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffMapPanel : WorldMapExtraUiPanel
	{
		// Token: 0x17007CD1 RID: 31953
		// (get) Token: 0x060328D1 RID: 207057 RVA: 0x00BC70E4 File Offset: 0x00BC52E4
		// (set) Token: 0x060328D2 RID: 207058 RVA: 0x00BC70F1 File Offset: 0x00BC52F1
		[Nullable(2)]
		public new ISheriffMapPanelParam OpenParam
		{
			[NullableContext(2)]
			get
			{
				return this.OpenParam as ISheriffMapPanelParam;
			}
			[NullableContext(2)]
			set
			{
				this.OpenParam = value;
			}
		}

		// Token: 0x060328D3 RID: 207059 RVA: 0x00BC70FA File Offset: 0x00BC52FA
		public SheriffMapPanel(EWorldMapExtraUiPanelName panelName, WorldMapExtraUiPanelComponent extraUiPanelComponent) : base(panelName, extraUiPanelComponent)
		{
		}

		// Token: 0x060328D4 RID: 207060 RVA: 0x00BC7120 File Offset: 0x00BC5320
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickBtnShop));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060328D5 RID: 207061 RVA: 0x00BC72F2 File Offset: 0x00BC54F2
		private void OnClickBtnShop()
		{
			SheriffModel.Instance.ClearShopRedDot();
			UiManager.Instance.OpenView(EUiViewName.SheriffShopView, null, delegate(bool success, int viewId)
			{
				if (success)
				{
					UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.WorldMapView);
					if (viewByName == null)
					{
						return;
					}
					viewByName.AddChildViewById(viewId);
				}
			});
		}

		// Token: 0x060328D6 RID: 207062 RVA: 0x00BC7330 File Offset: 0x00BC5530
		protected override UniTask OnBeforeStartAsync()
		{
			SheriffMapPanel.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SheriffMapPanel.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060328D7 RID: 207063 RVA: 0x00BC7374 File Offset: 0x00BC5574
		protected override void OnStart()
		{
			this.InitCaptionItem();
			this.RefreshShopRedDot();
			EventSystem.Instance.Add<int>(EEventName.OnGotoAnomaly, new Action<int>(this.OnGotoAnomaly));
			EventSystem.Instance.Add(EEventName.OnSheriffShopRedDotRefresh, new Action(this.RefreshShopRedDot));
			EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoodsList));
			this.SequencePlayer = new UiSequencePlayer(base.GetRootItem());
			this.RefreshShopText();
			ISheriffMapPanelParam openParam = this.OpenParam;
			if (openParam == null)
			{
				return;
			}
			Action onPanelOpened = openParam.OnPanelOpened;
			if (onPanelOpened == null)
			{
				return;
			}
			onPanelOpened();
		}

		// Token: 0x060328D8 RID: 207064 RVA: 0x00BC7412 File Offset: 0x00BC5612
		private void OnRefreshGoodsList(int goodsId, PayShopDefine.EPayShopTabType payShopId, int tabId)
		{
			this.RefreshShopText();
		}

		// Token: 0x060328D9 RID: 207065 RVA: 0x00BC741C File Offset: 0x00BC561C
		private void RefreshShopText()
		{
			ValueTuple<int, int, int> shopGoodsPriceInfo = SheriffModel.Instance.GetShopGoodsPriceInfo();
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(5), "Sheriff_Shop_2", new <>z__ReadOnlyArray<object>(new object[]
			{
				shopGoodsPriceInfo.Item1,
				shopGoodsPriceInfo.Item2
			}));
		}

		// Token: 0x060328DA RID: 207066 RVA: 0x00BC7471 File Offset: 0x00BC5671
		private void RefreshShopRedDot()
		{
			base.GetItem(6).SetUIActive(SheriffModel.Instance.CheckShopRedDot());
		}

		// Token: 0x060328DB RID: 207067 RVA: 0x00BC748C File Offset: 0x00BC568C
		protected override void OnAfterShow()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequence("Start", false, null);
		}

		// Token: 0x060328DC RID: 207068 RVA: 0x00BC74B8 File Offset: 0x00BC56B8
		private void InitCaptionItem()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.CloseCallBack));
			this.CaptionItem.SetTitleLocalText("Activity_110600001_Title");
			this.CaptionItem.CreateHomeBtn(EUiViewName.WorldMapView, null, false);
			this.CaptionItem.SetHelpCallBack(delegate
			{
				HelpController.Instance.OpenHelpById(618);
			});
		}

		// Token: 0x060328DD RID: 207069 RVA: 0x00BC753A File Offset: 0x00BC573A
		private void CloseCallBack()
		{
			base.CloseMe();
		}

		// Token: 0x060328DE RID: 207070 RVA: 0x00BC7544 File Offset: 0x00BC5744
		private UniTask InitCommonMapItemsView()
		{
			SheriffMapPanel.<InitCommonMapItemsView>d__25 <InitCommonMapItemsView>d__;
			<InitCommonMapItemsView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCommonMapItemsView>d__.<>4__this = this;
			<InitCommonMapItemsView>d__.<>1__state = -1;
			<InitCommonMapItemsView>d__.<>t__builder.Start<SheriffMapPanel.<InitCommonMapItemsView>d__25>(ref <InitCommonMapItemsView>d__);
			return <InitCommonMapItemsView>d__.<>t__builder.Task;
		}

		// Token: 0x060328DF RID: 207071 RVA: 0x00BC7588 File Offset: 0x00BC5788
		private void OnClickBtnSwitch()
		{
			List<IMapMarkToggleItemData> list = new List<IMapMarkToggleItemData>();
			if (this.CurrentMainTabType == ESheriffMainTabType.Event)
			{
				list.Add(new MapMarkToggleItemData
				{
					NameId = "FunctionMap_Content_13",
					GetToggleResultCallback = new Func<EToggleState>(this.GetHideCompletedMarkItemToggleState),
					SetToggleStateCallback = new Func<EToggleState, bool>(this.SetHideCompletedMarkItemToggleState)
				});
			}
			WorldMapUiEntity worldMapUiComponent = this.ExtraUiPanelComponent.WorldMapUiComponent;
			if (worldMapUiComponent == null)
			{
				return;
			}
			worldMapUiComponent.SecondaryUiComponent.ShowMapMarkTogglePanel(this.ParentUiItem, list, null);
		}

		// Token: 0x060328E0 RID: 207072 RVA: 0x00BC75FF File Offset: 0x00BC57FF
		private EToggleState GetHideCompletedMarkItemToggleState()
		{
			if (!LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.SheriffHideCompletedMarkItem, false))
			{
				return EToggleState.ETT_UnChecked;
			}
			return EToggleState.ETT_Checked;
		}

		// Token: 0x060328E1 RID: 207073 RVA: 0x00BC7614 File Offset: 0x00BC5814
		private bool SetHideCompletedMarkItemToggleState(EToggleState state)
		{
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.SheriffHideCompletedMarkItem, state == EToggleState.ETT_Checked);
			WorldMapUiEntity worldMapUiComponent = this.ExtraUiPanelComponent.WorldMapUiComponent;
			if (worldMapUiComponent != null)
			{
				worldMapUiComponent.UpdateMarkItems(null);
			}
			return true;
		}

		// Token: 0x060328E2 RID: 207074 RVA: 0x00BC7650 File Offset: 0x00BC5850
		private UniTask InitMainTabLayout()
		{
			SheriffMapPanel.<InitMainTabLayout>d__29 <InitMainTabLayout>d__;
			<InitMainTabLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMainTabLayout>d__.<>4__this = this;
			<InitMainTabLayout>d__.<>1__state = -1;
			<InitMainTabLayout>d__.<>t__builder.Start<SheriffMapPanel.<InitMainTabLayout>d__29>(ref <InitMainTabLayout>d__);
			return <InitMainTabLayout>d__.<>t__builder.Task;
		}

		// Token: 0x060328E3 RID: 207075 RVA: 0x00BC7694 File Offset: 0x00BC5894
		private UniTask RefreshMainTabLayout()
		{
			SheriffMapPanel.<RefreshMainTabLayout>d__30 <RefreshMainTabLayout>d__;
			<RefreshMainTabLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshMainTabLayout>d__.<>4__this = this;
			<RefreshMainTabLayout>d__.<>1__state = -1;
			<RefreshMainTabLayout>d__.<>t__builder.Start<SheriffMapPanel.<RefreshMainTabLayout>d__30>(ref <RefreshMainTabLayout>d__);
			return <RefreshMainTabLayout>d__.<>t__builder.Task;
		}

		// Token: 0x060328E4 RID: 207076 RVA: 0x00BC76D7 File Offset: 0x00BC58D7
		private ESheriffMainTabType GetDefaultMainTabType()
		{
			return ESheriffMainTabType.Event;
		}

		// Token: 0x060328E5 RID: 207077 RVA: 0x00BC76DA File Offset: 0x00BC58DA
		private SheriffMapMainTabItem CreateMainTabItem()
		{
			return new SheriffMapMainTabItem
			{
				SelectCallBack = new Action<ISheriffMainTabItemData>(this.OnSelectMainTab)
			};
		}

		// Token: 0x060328E6 RID: 207078 RVA: 0x00BC76F4 File Offset: 0x00BC58F4
		private void OnSelectMainTab(ISheriffMainTabItemData data)
		{
			this.CurrentMainTabType = data.TabType;
			this.RefreshSubTabLayout(data.TabType);
			this.ExtraUiPanelComponent.RefreshExtraMark();
			this.ExtraUiPanelComponent.RefreshScaleParam();
			this.ExtraUiPanelComponent.UpdateMarkItems();
			if (data.TabType == ESheriffMainTabType.Event)
			{
				EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "SheriffMapEventTabShow");
				return;
			}
			if (data.TabType == ESheriffMainTabType.Quest)
			{
				EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "SheriffMapQuestTabShow");
			}
		}

		// Token: 0x060328E7 RID: 207079 RVA: 0x00BC7776 File Offset: 0x00BC5976
		private void InitSubTabLayout()
		{
			this.SubTabLayout = new GenericLayout<SheriffMapSubTabItem, ISheriffSubTabItemData>(base.GetLayoutBase(2), new Func<SheriffMapSubTabItem>(this.CreateSubTabItem), null, false, true);
		}

		// Token: 0x060328E8 RID: 207080 RVA: 0x00BC779C File Offset: 0x00BC599C
		private void RefreshSubTabLayout(ESheriffMainTabType tabType)
		{
			this.SubTabItemDataList.Clear();
			if (tabType != ESheriffMainTabType.Event)
			{
				if (tabType == ESheriffMainTabType.Quest)
				{
					SheriffQuestState questState = SheriffModel.Instance.GetQuestState(this.CurrentZoneId, ESheriffQuestType.POI);
					if (questState.TotalList.Count > 0)
					{
						int current = questState.TotalList.Count - questState.UnFinishList.Count;
						this.PushSubTabItem(ESheriffSubTabType.POI, "SP_IconMap_Task_10_UI", "FunctionMap_Content_5", current, questState.TotalList.Count);
					}
					SheriffQuestState questState2 = SheriffModel.Instance.GetQuestState(this.CurrentZoneId, ESheriffQuestType.Branch);
					if (questState2.TotalList.Count > 0)
					{
						int current2 = questState2.TotalList.Count - questState2.UnFinishList.Count;
						this.PushSubTabItem(ESheriffSubTabType.Branch, "SP_IconMap_Task_02_UI", "FunctionMap_Content_6", current2, questState2.TotalList.Count);
					}
					if (!this.IsInitialTabSelect)
					{
						this.NavigateToQuestMark(questState, questState2);
					}
				}
			}
			else
			{
				ValueTuple<int, int> anomalyProgress = SheriffModel.Instance.GetAnomalyProgress();
				this.PushSubTabItem(ESheriffSubTabType.Criminal, "SP_IconMapMonster", "FunctionMap_Content_1", anomalyProgress.Item1, anomalyProgress.Item2);
				if (!this.IsInitialTabSelect)
				{
					this.NavigateToAnomalyMark();
				}
			}
			this.IsInitialTabSelect = false;
			GenericLayout<SheriffMapSubTabItem, ISheriffSubTabItemData> subTabLayout = this.SubTabLayout;
			if (subTabLayout != null)
			{
				subTabLayout.RefreshByData(this.SubTabItemDataList, null, false);
			}
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.PlayOrReplaySequenceByName("Switch", false, null);
			}
			UUINiagara uiNiagara = base.GetUiNiagara(10);
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.ActivateSystem(true);
		}

		// Token: 0x060328E9 RID: 207081 RVA: 0x00BC7910 File Offset: 0x00BC5B10
		private void PushSubTabItem(ESheriffSubTabType tabType, string iconId, string textId, int current, int total)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(textId, null);
			this.SubTabItemDataList.Add(new SheriffSubTabItemData
			{
				TabType = tabType,
				TabIcon = UiResourceConfig.Instance.GetResourcePath(iconId),
				TabTxt = StringUtils.Format(localTextNew, new string[]
				{
					current.ToString(),
					total.ToString()
				}),
				IsFinished = (current >= total)
			});
		}

		// Token: 0x060328EA RID: 207082 RVA: 0x00BC7984 File Offset: 0x00BC5B84
		private void NavigateToAnomalyMark()
		{
			int targetAnomalyMarkId = SheriffModel.Instance.GetTargetAnomalyMarkId();
			if (targetAnomalyMarkId == 0)
			{
				return;
			}
			EventSystem.Instance.Emit<NavigateMark>(EEventName.WorldMapNavigate, new NavigateMark
			{
				MarkId = targetAnomalyMarkId,
				MarkType = EMarkType.SheriffAnomaly,
				Focal = new bool?(false)
			});
		}

		// Token: 0x060328EB RID: 207083 RVA: 0x00BC79D0 File Offset: 0x00BC5BD0
		private void NavigateToQuestMark(SheriffQuestState poiState, SheriffQuestState branchState)
		{
			int? num = this.FindTrackingQuestMarkId(poiState.UnFinishList);
			int? num2 = (num != null) ? num : this.FindTrackingQuestMarkId(branchState.UnFinishList);
			if (num2 != null)
			{
				EventSystem.Instance.Emit<NavigateMark>(EEventName.WorldMapNavigate, new NavigateMark
				{
					MarkId = num2.Value,
					MarkType = EMarkType.SheriffQuest,
					Focal = new bool?(false)
				});
				return;
			}
			List<int> list = null;
			if (poiState.UnFinishList.Count > 0)
			{
				list = poiState.UnFinishList;
			}
			else if (branchState.UnFinishList.Count > 0)
			{
				list = branchState.UnFinishList;
			}
			else if (poiState.TotalList.Count > 0)
			{
				list = poiState.TotalList;
			}
			else if (branchState.TotalList.Count > 0)
			{
				list = branchState.TotalList;
			}
			if (list != null)
			{
				int targetMapMarkIdByQuestIds = SheriffModel.Instance.GetTargetMapMarkIdByQuestIds(list);
				EventSystem.Instance.Emit<NavigateMark>(EEventName.WorldMapNavigate, new NavigateMark
				{
					MarkId = targetMapMarkIdByQuestIds,
					MarkType = EMarkType.SheriffQuest,
					Focal = new bool?(false)
				});
			}
		}

		// Token: 0x060328EC RID: 207084 RVA: 0x00BC7AE0 File Offset: 0x00BC5CE0
		private int? FindTrackingQuestMarkId(List<int> questIds)
		{
			foreach (int questId in questIds)
			{
				if (QuestNewModel.Instance.IsTrackingQuest(questId))
				{
					return new int?(SheriffConfig.Instance.GetQuestConfigByQuestId(questId).Value.MarkId);
				}
			}
			return null;
		}

		// Token: 0x060328ED RID: 207085 RVA: 0x00BC7B68 File Offset: 0x00BC5D68
		private SheriffMapSubTabItem CreateSubTabItem()
		{
			return new SheriffMapSubTabItem
			{
				ClickCallBack = new Action<ISheriffSubTabItemData>(this.OnClickSubTab)
			};
		}

		// Token: 0x060328EE RID: 207086 RVA: 0x00BC7B84 File Offset: 0x00BC5D84
		private void OnClickSubTab(ISheriffSubTabItemData data)
		{
			switch (data.TabType)
			{
			case ESheriffSubTabType.Criminal:
			{
				WorldMapUiEntity worldMapUiComponent = this.ExtraUiPanelComponent.WorldMapUiComponent;
				if (worldMapUiComponent == null)
				{
					return;
				}
				worldMapUiComponent.SecondaryUiComponent.OpenUi(ESecondaryPanel.SheriffCriminalPanel, this.ParentUiItem, new object[]
				{
					this.CurrentZoneId
				});
				return;
			}
			case ESheriffSubTabType.POI:
			{
				SheriffQuestState questState = SheriffModel.Instance.GetQuestState(this.CurrentZoneId, ESheriffQuestType.POI);
				int num = questState.TotalList.Count - questState.UnFinishList.Count;
				int count = questState.TotalList.Count;
				if (num >= count)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("FunctionMap_Content_15", Array.Empty<object>());
					return;
				}
				int targetMapMarkIdByQuestIds = SheriffModel.Instance.GetTargetMapMarkIdByQuestIds(questState.UnFinishList);
				EventSystem.Instance.Emit<NavigateMark>(EEventName.WorldMapNavigate, new NavigateMark
				{
					MarkId = targetMapMarkIdByQuestIds,
					MarkType = EMarkType.SheriffQuest,
					Focal = new bool?(true)
				});
				return;
			}
			case ESheriffSubTabType.Branch:
			{
				SheriffQuestState questState2 = SheriffModel.Instance.GetQuestState(this.CurrentZoneId, ESheriffQuestType.Branch);
				int num2 = questState2.TotalList.Count - questState2.UnFinishList.Count;
				int count2 = questState2.TotalList.Count;
				if (num2 >= count2)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("FunctionMap_Content_16", Array.Empty<object>());
					return;
				}
				int targetMapMarkIdByQuestIds2 = SheriffModel.Instance.GetTargetMapMarkIdByQuestIds(questState2.UnFinishList);
				EventSystem.Instance.Emit<NavigateMark>(EEventName.WorldMapNavigate, new NavigateMark
				{
					MarkId = targetMapMarkIdByQuestIds2,
					MarkType = EMarkType.SheriffQuest,
					Focal = new bool?(true)
				});
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x060328EF RID: 207087 RVA: 0x00BC7D09 File Offset: 0x00BC5F09
		[NullableContext(2)]
		public override UUISliderComponent GetScaleSlider()
		{
			CommonMapItemsView commonMapItemsViewInstance = this.CommonMapItemsViewInstance;
			if (commonMapItemsViewInstance == null)
			{
				return null;
			}
			return commonMapItemsViewInstance.GetScaleSlider();
		}

		// Token: 0x060328F0 RID: 207088 RVA: 0x00BC7D1C File Offset: 0x00BC5F1C
		public override float GetDefaultMapScale()
		{
			int mapId = SheriffConfig.Instance.GetZoneConfigById(this.CurrentZoneId).Value.MapId;
			SheriffMap? mapConfigById = SheriffConfig.Instance.GetMapConfigById(mapId);
			return (float)((this.CurrentMainTabType == ESheriffMainTabType.Event) ? ((mapConfigById != null) ? mapConfigById.GetValueOrDefault().BigMapDefaultScale : 0) : ((mapConfigById != null) ? mapConfigById.GetValueOrDefault().QuestMapDefaultScale : 0));
		}

		// Token: 0x060328F1 RID: 207089 RVA: 0x00BC7D9C File Offset: 0x00BC5F9C
		public override float GetMaxMapScale()
		{
			int mapId = SheriffConfig.Instance.GetZoneConfigById(this.CurrentZoneId).Value.MapId;
			SheriffMap? mapConfigById = SheriffConfig.Instance.GetMapConfigById(mapId);
			return (float)((this.CurrentMainTabType == ESheriffMainTabType.Event) ? ((mapConfigById != null) ? mapConfigById.GetValueOrDefault().BigMapMaxScale : 0) : ((mapConfigById != null) ? mapConfigById.GetValueOrDefault().QuestMapMaxScale : 0));
		}

		// Token: 0x060328F2 RID: 207090 RVA: 0x00BC7E1C File Offset: 0x00BC601C
		public override float GetMinMapScale()
		{
			int mapId = SheriffConfig.Instance.GetZoneConfigById(this.CurrentZoneId).Value.MapId;
			SheriffMap? mapConfigById = SheriffConfig.Instance.GetMapConfigById(mapId);
			return (float)((this.CurrentMainTabType == ESheriffMainTabType.Event) ? ((mapConfigById != null) ? mapConfigById.GetValueOrDefault().BigMapMinScale : 0) : ((mapConfigById != null) ? mapConfigById.GetValueOrDefault().QuestMapMinScale : 0));
		}

		// Token: 0x060328F3 RID: 207091 RVA: 0x00BC7E9C File Offset: 0x00BC609C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override IEnumerable<string> GetTileRange()
		{
			int mapId = SheriffConfig.Instance.GetZoneConfigById(this.CurrentZoneId).Value.MapId;
			SheriffMap? mapConfigById = SheriffConfig.Instance.GetMapConfigById(mapId);
			if (mapConfigById == null)
			{
				return null;
			}
			return mapConfigById.Value.TileRangeIter();
		}

		// Token: 0x060328F4 RID: 207092 RVA: 0x00BC7EF4 File Offset: 0x00BC60F4
		[NullableContext(2)]
		public override int[] GetUnlockFogs()
		{
			int mapId = SheriffConfig.Instance.GetZoneConfigById(this.CurrentZoneId).Value.MapId;
			SheriffMap? mapConfigById = SheriffConfig.Instance.GetMapConfigById(mapId);
			if (mapConfigById == null || mapConfigById.Value.UnlockFogsLength == 0)
			{
				return null;
			}
			return mapConfigById.Value.GetUnlockFogsArray();
		}

		// Token: 0x060328F5 RID: 207093 RVA: 0x00BC7F5B File Offset: 0x00BC615B
		public override EMarkType[] GetExtraMarkTypes()
		{
			return new EMarkType[]
			{
				(this.CurrentMainTabType == ESheriffMainTabType.Event) ? EMarkType.SheriffAnomaly : EMarkType.SheriffQuest
			};
		}

		// Token: 0x060328F6 RID: 207094 RVA: 0x00BC7F74 File Offset: 0x00BC6174
		[NullableContext(2)]
		public override int[] GetExtraMarkIds()
		{
			int mapId = SheriffConfig.Instance.GetZoneConfigById(this.CurrentZoneId).Value.MapId;
			SheriffMap? mapConfigById = SheriffConfig.Instance.GetMapConfigById(mapId);
			if (mapConfigById == null || mapConfigById.Value.UnlockFogsLength == 0)
			{
				return null;
			}
			return mapConfigById.Value.GetExtraMarkIdsArray();
		}

		// Token: 0x060328F7 RID: 207095 RVA: 0x00BC7FDC File Offset: 0x00BC61DC
		[return: TupleElementNames(new string[]
		{
			"ResourceId",
			"SequenceType"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public override ValueTuple<string, string>? GetStartSequenceInfo()
		{
			ISheriffMapPanelParam openParam = this.OpenParam;
			if (openParam != null && openParam.IsError.GetValueOrDefault())
			{
				return null;
			}
			return new ValueTuple<string, string>?(new ValueTuple<string, string>("UiItem_SkyEyeMapLoading", "Start"));
		}

		// Token: 0x060328F8 RID: 207096 RVA: 0x00BC8023 File Offset: 0x00BC6223
		public override string GetBackgroundMusicAudioEvent()
		{
			return "play_ui_music_tongji_3_5_layer1";
		}

		// Token: 0x060328F9 RID: 207097 RVA: 0x00BC802C File Offset: 0x00BC622C
		public override int? GetCustomClickRange()
		{
			if (this.CurrentMainTabType != ESheriffMainTabType.Event)
			{
				return null;
			}
			return new int?(65);
		}

		// Token: 0x060328FA RID: 207098 RVA: 0x00BC8054 File Offset: 0x00BC6254
		public override ClickMarkItemRet OnClickMarkItem(MarkItem markItem)
		{
			if (markItem.MarkType == EMarkType.SheriffAnomaly)
			{
				AudioSystem.Instance.PostEvent("play_ui_skyeye_button_npc_click");
				SheriffAnomaly? anomalyConfigByMarkId = SheriffConfig.Instance.GetAnomalyConfigByMarkId(markItem.MarkId);
				SheriffAnomalyInfo anomalyInfo = SheriffModel.Instance.GetAnomalyInfo(anomalyConfigByMarkId.Value.Id);
				WorldMapUiEntity worldMapUiComponent = this.ExtraUiPanelComponent.WorldMapUiComponent;
				if (worldMapUiComponent != null && worldMapUiComponent.SecondaryUiComponent.IsInternalSecondaryUiOpen())
				{
					WorldMapUiEntity worldMapUiComponent2 = this.ExtraUiPanelComponent.WorldMapUiComponent;
					if (worldMapUiComponent2 != null)
					{
						worldMapUiComponent2.SecondaryUiComponent.CloseUi(delegate
						{
							this.HandleAnomalyClick(anomalyInfo);
						}, true);
					}
				}
				else
				{
					this.HandleAnomalyClick(anomalyInfo);
				}
				this.ClickMarkItemRetData.IsExtraUiLogic = true;
				this.ClickMarkItemRetData.IsNeedSelected = false;
				return this.ClickMarkItemRetData;
			}
			this.ClickMarkItemRetData.IsExtraUiLogic = false;
			this.ClickMarkItemRetData.IsNeedSelected = true;
			return this.ClickMarkItemRetData;
		}

		// Token: 0x060328FB RID: 207099 RVA: 0x00BC814C File Offset: 0x00BC634C
		public override bool OnClickEmpty(Vector2D clickedPosition)
		{
			WorldMapUiEntity worldMapUiComponent = this.ExtraUiPanelComponent.WorldMapUiComponent;
			return worldMapUiComponent == null || !worldMapUiComponent.SecondaryUiComponent.IsSecondaryUiOpening;
		}

		// Token: 0x060328FC RID: 207100 RVA: 0x00BC816F File Offset: 0x00BC636F
		private void HandleAnomalyClick(SheriffAnomalyInfo anomalyInfo)
		{
			SheriffController.Instance.OpenSheriffReportPop(anomalyInfo.CriminalId, true);
		}

		// Token: 0x060328FD RID: 207101 RVA: 0x00BC8184 File Offset: 0x00BC6384
		private void OnGotoAnomaly(int anomalyId)
		{
			int markId = SheriffModel.Instance.GetAnomalyInfo(anomalyId).MarkId;
			MarkItem markItem = this.ExtraUiPanelComponent.WorldMapUiComponent.Map.GetMarkItem(EMarkType.SheriffAnomaly, markId);
			if (markItem == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Sheriff;
				ELogAuthor author = ELogAuthor.CB;
				string message = "获取不到异常事件标记";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MarkId", markId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (SheriffModel.Instance.CheckInBehaviorTreeRange(anomalyId))
			{
				TrackMapMarkParams curTrackMark = MapModel.Instance.GetCurTrackMark();
				if (curTrackMark != null)
				{
					MapController.Instance.RequestTrackMapMark(new TrackMapMarkParams
					{
						MarkType = curTrackMark.MarkType,
						MarkId = curTrackMark.MarkId,
						Track = false
					}, null);
				}
				if (!SheriffModel.Instance.IsBehaviorTreeTracking(anomalyId))
				{
					TrackHelper.SetMarkItemTrack(markItem, delegate
					{
						WorldMapUiEntity worldMapUiComponent = this.ExtraUiPanelComponent.WorldMapUiComponent;
						if (worldMapUiComponent == null)
						{
							return;
						}
						worldMapUiComponent.UpdateMarkItems(null);
					});
				}
				UiManager.Instance.ResetToBattleView(delegate(bool success)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("FunctionMap_Content_23", Array.Empty<object>());
				});
				return;
			}
			MarkItem markItem3 = MarkUiUtils.FindNearbyValidGotoMark(this.ExtraUiPanelComponent.WorldMapUiComponent.Map, markItem);
			if (markItem3 != null)
			{
				TrackHelper.SetMarkItemTrack(markItem, delegate
				{
					WorldMapUiEntity worldMapUiComponent = this.ExtraUiPanelComponent.WorldMapUiComponent;
					if (worldMapUiComponent == null)
					{
						return;
					}
					worldMapUiComponent.UpdateMarkItems(null);
				});
				TemporaryTeleportMarkItem temporaryTeleportMarkItem = markItem3 as TemporaryTeleportMarkItem;
				if (temporaryTeleportMarkItem != null)
				{
					MapController.Instance.RequestTeleportToTargetByTemporaryTeleport(temporaryTeleportMarkItem.TeleportId, null);
					EventSystem.Instance.Once<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
				}
				ConfigMarkItem configMarkItem = markItem3 as ConfigMarkItem;
				if (configMarkItem != null)
				{
					WorldMapController.Instance.TryTeleport(configMarkItem.MarkConfigId, null);
					EventSystem.Instance.Once<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
					return;
				}
			}
			else
			{
				Action <>9__4;
				UiManager.Instance.ResetToBattleView(delegate(bool success)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("FunctionMap_Content_17", Array.Empty<object>());
					MarkItem markItem2 = markItem;
					Action finishCallback;
					if ((finishCallback = <>9__4) == null)
					{
						finishCallback = (<>9__4 = delegate()
						{
							WorldMapUiEntity worldMapUiComponent = this.ExtraUiPanelComponent.WorldMapUiComponent;
							if (worldMapUiComponent == null)
							{
								return;
							}
							worldMapUiComponent.UpdateMarkItems(null);
						});
					}
					TrackHelper.SetMarkItemTrack(markItem2, finishCallback);
				});
			}
		}

		// Token: 0x060328FE RID: 207102 RVA: 0x00BC8368 File Offset: 0x00BC6568
		[NullableContext(2)]
		private void OnTeleportComplete(TeleportContext teleportContext)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("FunctionMap_Content_23", Array.Empty<object>());
		}

		// Token: 0x060328FF RID: 207103 RVA: 0x00BC8380 File Offset: 0x00BC6580
		protected override UniTask OnBeforeHideAsync()
		{
			SheriffMapPanel.<OnBeforeHideAsync>d__58 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<SheriffMapPanel.<OnBeforeHideAsync>d__58>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032900 RID: 207104 RVA: 0x00BC83C4 File Offset: 0x00BC65C4
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnGotoAnomaly, new Action<int>(this.OnGotoAnomaly));
			EventSystem.Instance.Remove(EEventName.OnSheriffShopRedDotRefresh, new Action(this.RefreshShopRedDot));
			EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoodsList));
		}

		// Token: 0x0401AE74 RID: 110196
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401AE75 RID: 110197
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<SheriffMapMainTabItem, ISheriffMainTabItemData> MainTabLayout;

		// Token: 0x0401AE76 RID: 110198
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<SheriffMapSubTabItem, ISheriffSubTabItemData> SubTabLayout;

		// Token: 0x0401AE77 RID: 110199
		[Nullable(2)]
		private CommonMapItemsView CommonMapItemsViewInstance;

		// Token: 0x0401AE78 RID: 110200
		private ESheriffMainTabType CurrentMainTabType;

		// Token: 0x0401AE79 RID: 110201
		private const int CUSTOM_CLICK_RANGE = 65;

		// Token: 0x0401AE7A RID: 110202
		private readonly int CurrentZoneId = 1;

		// Token: 0x0401AE7B RID: 110203
		private readonly List<ISheriffSubTabItemData> SubTabItemDataList = new List<ISheriffSubTabItemData>();

		// Token: 0x0401AE7C RID: 110204
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401AE7D RID: 110205
		private bool IsInitialTabSelect = true;

		// Token: 0x0200AE0F RID: 44559
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x04034DCF RID: 216527
			public const int CaptionItem = 0;

			// Token: 0x04034DD0 RID: 216528
			public const int PnlInfo = 1;

			// Token: 0x04034DD1 RID: 216529
			public const int SubTab = 2;

			// Token: 0x04034DD2 RID: 216530
			public const int SubTabItem = 3;

			// Token: 0x04034DD3 RID: 216531
			public const int BtnShop = 4;

			// Token: 0x04034DD4 RID: 216532
			public const int ShopText = 5;

			// Token: 0x04034DD5 RID: 216533
			public const int RedDotShop = 6;

			// Token: 0x04034DD6 RID: 216534
			public const int MainTab = 7;

			// Token: 0x04034DD7 RID: 216535
			public const int MainTabItem = 8;

			// Token: 0x04034DD8 RID: 216536
			public const int PnlContent = 9;

			// Token: 0x04034DD9 RID: 216537
			public const int NiaSwitch = 10;
		}
	}
}
