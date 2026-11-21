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
	// Token: 0x02003C15 RID: 15381
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffMapPanel : WorldMapExtraUiPanel
	{
		// Token: 0x1700507B RID: 20603
		// (get) Token: 0x06027684 RID: 161412 RVA: 0x00B0BD50 File Offset: 0x00B09F50
		// (set) Token: 0x06027685 RID: 161413 RVA: 0x00B0BD5D File Offset: 0x00B09F5D
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

		// Token: 0x06027686 RID: 161414 RVA: 0x00B0BD66 File Offset: 0x00B09F66
		public SheriffMapPanel(EWorldMapExtraUiPanelName panelName, WorldMapExtraUiPanelComponent extraUiPanelComponent) : base(panelName, extraUiPanelComponent)
		{
		}

		// Token: 0x06027687 RID: 161415 RVA: 0x00B0BD8C File Offset: 0x00B09F8C
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

		// Token: 0x06027688 RID: 161416 RVA: 0x00B0BF5E File Offset: 0x00B0A15E
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

		// Token: 0x06027689 RID: 161417 RVA: 0x00B0BF9C File Offset: 0x00B0A19C
		protected override UniTask OnBeforeStartAsync()
		{
			SheriffMapPanel.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SheriffMapPanel.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602768A RID: 161418 RVA: 0x00B0BFE0 File Offset: 0x00B0A1E0
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

		// Token: 0x0602768B RID: 161419 RVA: 0x00B0C07E File Offset: 0x00B0A27E
		private void OnRefreshGoodsList(int goodsId, PayShopDefine.EPayShopTabType payShopId, int tabId)
		{
			this.RefreshShopText();
		}

		// Token: 0x0602768C RID: 161420 RVA: 0x00B0C088 File Offset: 0x00B0A288
		private void RefreshShopText()
		{
			ValueTuple<int, int, int> shopGoodsPriceInfo = SheriffModel.Instance.GetShopGoodsPriceInfo();
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(5), "Sheriff_Shop_2", new <>z__ReadOnlyArray<object>(new object[]
			{
				shopGoodsPriceInfo.Item1,
				shopGoodsPriceInfo.Item2
			}));
		}

		// Token: 0x0602768D RID: 161421 RVA: 0x00B0C0DD File Offset: 0x00B0A2DD
		private void RefreshShopRedDot()
		{
			base.GetItem(6).SetUIActive(SheriffModel.Instance.CheckShopRedDot());
		}

		// Token: 0x0602768E RID: 161422 RVA: 0x00B0C0F8 File Offset: 0x00B0A2F8
		protected override void OnAfterShow()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequence("Start", false, null);
		}

		// Token: 0x0602768F RID: 161423 RVA: 0x00B0C124 File Offset: 0x00B0A324
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

		// Token: 0x06027690 RID: 161424 RVA: 0x00B0C1A6 File Offset: 0x00B0A3A6
		private void CloseCallBack()
		{
			base.CloseMe();
		}

		// Token: 0x06027691 RID: 161425 RVA: 0x00B0C1B0 File Offset: 0x00B0A3B0
		private UniTask InitCommonMapItemsView()
		{
			SheriffMapPanel.<InitCommonMapItemsView>d__25 <InitCommonMapItemsView>d__;
			<InitCommonMapItemsView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCommonMapItemsView>d__.<>4__this = this;
			<InitCommonMapItemsView>d__.<>1__state = -1;
			<InitCommonMapItemsView>d__.<>t__builder.Start<SheriffMapPanel.<InitCommonMapItemsView>d__25>(ref <InitCommonMapItemsView>d__);
			return <InitCommonMapItemsView>d__.<>t__builder.Task;
		}

		// Token: 0x06027692 RID: 161426 RVA: 0x00B0C1F4 File Offset: 0x00B0A3F4
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

		// Token: 0x06027693 RID: 161427 RVA: 0x00B0C26B File Offset: 0x00B0A46B
		private EToggleState GetHideCompletedMarkItemToggleState()
		{
			if (!LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.SheriffHideCompletedMarkItem, false))
			{
				return EToggleState.ETT_UnChecked;
			}
			return EToggleState.ETT_Checked;
		}

		// Token: 0x06027694 RID: 161428 RVA: 0x00B0C280 File Offset: 0x00B0A480
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

		// Token: 0x06027695 RID: 161429 RVA: 0x00B0C2BC File Offset: 0x00B0A4BC
		private UniTask InitMainTabLayout()
		{
			SheriffMapPanel.<InitMainTabLayout>d__29 <InitMainTabLayout>d__;
			<InitMainTabLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMainTabLayout>d__.<>4__this = this;
			<InitMainTabLayout>d__.<>1__state = -1;
			<InitMainTabLayout>d__.<>t__builder.Start<SheriffMapPanel.<InitMainTabLayout>d__29>(ref <InitMainTabLayout>d__);
			return <InitMainTabLayout>d__.<>t__builder.Task;
		}

		// Token: 0x06027696 RID: 161430 RVA: 0x00B0C300 File Offset: 0x00B0A500
		private UniTask RefreshMainTabLayout()
		{
			SheriffMapPanel.<RefreshMainTabLayout>d__30 <RefreshMainTabLayout>d__;
			<RefreshMainTabLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshMainTabLayout>d__.<>4__this = this;
			<RefreshMainTabLayout>d__.<>1__state = -1;
			<RefreshMainTabLayout>d__.<>t__builder.Start<SheriffMapPanel.<RefreshMainTabLayout>d__30>(ref <RefreshMainTabLayout>d__);
			return <RefreshMainTabLayout>d__.<>t__builder.Task;
		}

		// Token: 0x06027697 RID: 161431 RVA: 0x00B0C343 File Offset: 0x00B0A543
		private ESheriffMainTabType GetDefaultMainTabType()
		{
			return ESheriffMainTabType.Event;
		}

		// Token: 0x06027698 RID: 161432 RVA: 0x00B0C346 File Offset: 0x00B0A546
		private SheriffMapMainTabItem CreateMainTabItem()
		{
			return new SheriffMapMainTabItem
			{
				SelectCallBack = new Action<ISheriffMainTabItemData>(this.OnSelectMainTab)
			};
		}

		// Token: 0x06027699 RID: 161433 RVA: 0x00B0C360 File Offset: 0x00B0A560
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

		// Token: 0x0602769A RID: 161434 RVA: 0x00B0C3E2 File Offset: 0x00B0A5E2
		private void InitSubTabLayout()
		{
			this.SubTabLayout = new GenericLayout<SheriffMapSubTabItem, ISheriffSubTabItemData>(base.GetLayoutBase(2), new Func<SheriffMapSubTabItem>(this.CreateSubTabItem), null, false, true);
		}

		// Token: 0x0602769B RID: 161435 RVA: 0x00B0C408 File Offset: 0x00B0A608
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

		// Token: 0x0602769C RID: 161436 RVA: 0x00B0C57C File Offset: 0x00B0A77C
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

		// Token: 0x0602769D RID: 161437 RVA: 0x00B0C5F0 File Offset: 0x00B0A7F0
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

		// Token: 0x0602769E RID: 161438 RVA: 0x00B0C63C File Offset: 0x00B0A83C
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

		// Token: 0x0602769F RID: 161439 RVA: 0x00B0C74C File Offset: 0x00B0A94C
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

		// Token: 0x060276A0 RID: 161440 RVA: 0x00B0C7D4 File Offset: 0x00B0A9D4
		private SheriffMapSubTabItem CreateSubTabItem()
		{
			return new SheriffMapSubTabItem
			{
				ClickCallBack = new Action<ISheriffSubTabItemData>(this.OnClickSubTab)
			};
		}

		// Token: 0x060276A1 RID: 161441 RVA: 0x00B0C7F0 File Offset: 0x00B0A9F0
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

		// Token: 0x060276A2 RID: 161442 RVA: 0x00B0C975 File Offset: 0x00B0AB75
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

		// Token: 0x060276A3 RID: 161443 RVA: 0x00B0C988 File Offset: 0x00B0AB88
		public override float GetDefaultMapScale()
		{
			int mapId = SheriffConfig.Instance.GetZoneConfigById(this.CurrentZoneId).Value.MapId;
			SheriffMap? mapConfigById = SheriffConfig.Instance.GetMapConfigById(mapId);
			return (float)((this.CurrentMainTabType == ESheriffMainTabType.Event) ? ((mapConfigById != null) ? mapConfigById.GetValueOrDefault().BigMapDefaultScale : 0) : ((mapConfigById != null) ? mapConfigById.GetValueOrDefault().QuestMapDefaultScale : 0));
		}

		// Token: 0x060276A4 RID: 161444 RVA: 0x00B0CA08 File Offset: 0x00B0AC08
		public override float GetMaxMapScale()
		{
			int mapId = SheriffConfig.Instance.GetZoneConfigById(this.CurrentZoneId).Value.MapId;
			SheriffMap? mapConfigById = SheriffConfig.Instance.GetMapConfigById(mapId);
			return (float)((this.CurrentMainTabType == ESheriffMainTabType.Event) ? ((mapConfigById != null) ? mapConfigById.GetValueOrDefault().BigMapMaxScale : 0) : ((mapConfigById != null) ? mapConfigById.GetValueOrDefault().QuestMapMaxScale : 0));
		}

		// Token: 0x060276A5 RID: 161445 RVA: 0x00B0CA88 File Offset: 0x00B0AC88
		public override float GetMinMapScale()
		{
			int mapId = SheriffConfig.Instance.GetZoneConfigById(this.CurrentZoneId).Value.MapId;
			SheriffMap? mapConfigById = SheriffConfig.Instance.GetMapConfigById(mapId);
			return (float)((this.CurrentMainTabType == ESheriffMainTabType.Event) ? ((mapConfigById != null) ? mapConfigById.GetValueOrDefault().BigMapMinScale : 0) : ((mapConfigById != null) ? mapConfigById.GetValueOrDefault().QuestMapMinScale : 0));
		}

		// Token: 0x060276A6 RID: 161446 RVA: 0x00B0CB08 File Offset: 0x00B0AD08
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

		// Token: 0x060276A7 RID: 161447 RVA: 0x00B0CB60 File Offset: 0x00B0AD60
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

		// Token: 0x060276A8 RID: 161448 RVA: 0x00B0CBC7 File Offset: 0x00B0ADC7
		public override EMarkType[] GetExtraMarkTypes()
		{
			return new EMarkType[]
			{
				(this.CurrentMainTabType == ESheriffMainTabType.Event) ? EMarkType.SheriffAnomaly : EMarkType.SheriffQuest
			};
		}

		// Token: 0x060276A9 RID: 161449 RVA: 0x00B0CBE0 File Offset: 0x00B0ADE0
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

		// Token: 0x060276AA RID: 161450 RVA: 0x00B0CC48 File Offset: 0x00B0AE48
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

		// Token: 0x060276AB RID: 161451 RVA: 0x00B0CC8F File Offset: 0x00B0AE8F
		public override string GetBackgroundMusicAudioEvent()
		{
			return "play_ui_music_tongji_3_5_layer1";
		}

		// Token: 0x060276AC RID: 161452 RVA: 0x00B0CC98 File Offset: 0x00B0AE98
		public override int? GetCustomClickRange()
		{
			if (this.CurrentMainTabType != ESheriffMainTabType.Event)
			{
				return null;
			}
			return new int?(65);
		}

		// Token: 0x060276AD RID: 161453 RVA: 0x00B0CCC0 File Offset: 0x00B0AEC0
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

		// Token: 0x060276AE RID: 161454 RVA: 0x00B0CDB8 File Offset: 0x00B0AFB8
		public override bool OnClickEmpty(Vector2D clickedPosition)
		{
			WorldMapUiEntity worldMapUiComponent = this.ExtraUiPanelComponent.WorldMapUiComponent;
			return worldMapUiComponent == null || !worldMapUiComponent.SecondaryUiComponent.IsSecondaryUiOpening;
		}

		// Token: 0x060276AF RID: 161455 RVA: 0x00B0CDDB File Offset: 0x00B0AFDB
		private void HandleAnomalyClick(SheriffAnomalyInfo anomalyInfo)
		{
			SheriffController.Instance.OpenSheriffReportPop(anomalyInfo.CriminalId, true);
		}

		// Token: 0x060276B0 RID: 161456 RVA: 0x00B0CDF0 File Offset: 0x00B0AFF0
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

		// Token: 0x060276B1 RID: 161457 RVA: 0x00B0CFD4 File Offset: 0x00B0B1D4
		[NullableContext(2)]
		private void OnTeleportComplete(TeleportContext teleportContext)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("FunctionMap_Content_23", Array.Empty<object>());
		}

		// Token: 0x060276B2 RID: 161458 RVA: 0x00B0CFEC File Offset: 0x00B0B1EC
		protected override UniTask OnBeforeHideAsync()
		{
			SheriffMapPanel.<OnBeforeHideAsync>d__58 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<SheriffMapPanel.<OnBeforeHideAsync>d__58>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060276B3 RID: 161459 RVA: 0x00B0D030 File Offset: 0x00B0B230
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnGotoAnomaly, new Action<int>(this.OnGotoAnomaly));
			EventSystem.Instance.Remove(EEventName.OnSheriffShopRedDotRefresh, new Action(this.RefreshShopRedDot));
			EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoodsList));
		}

		// Token: 0x040157D1 RID: 88017
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x040157D2 RID: 88018
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<SheriffMapMainTabItem, ISheriffMainTabItemData> MainTabLayout;

		// Token: 0x040157D3 RID: 88019
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<SheriffMapSubTabItem, ISheriffSubTabItemData> SubTabLayout;

		// Token: 0x040157D4 RID: 88020
		[Nullable(2)]
		private CommonMapItemsView CommonMapItemsViewInstance;

		// Token: 0x040157D5 RID: 88021
		private ESheriffMainTabType CurrentMainTabType;

		// Token: 0x040157D6 RID: 88022
		private const int CUSTOM_CLICK_RANGE = 65;

		// Token: 0x040157D7 RID: 88023
		private readonly int CurrentZoneId = 1;

		// Token: 0x040157D8 RID: 88024
		private readonly List<ISheriffSubTabItemData> SubTabItemDataList = new List<ISheriffSubTabItemData>();

		// Token: 0x040157D9 RID: 88025
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x040157DA RID: 88026
		private bool IsInitialTabSelect = true;

		// Token: 0x0200982D RID: 38957
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x0402F774 RID: 194420
			public const int CaptionItem = 0;

			// Token: 0x0402F775 RID: 194421
			public const int PnlInfo = 1;

			// Token: 0x0402F776 RID: 194422
			public const int SubTab = 2;

			// Token: 0x0402F777 RID: 194423
			public const int SubTabItem = 3;

			// Token: 0x0402F778 RID: 194424
			public const int BtnShop = 4;

			// Token: 0x0402F779 RID: 194425
			public const int ShopText = 5;

			// Token: 0x0402F77A RID: 194426
			public const int RedDotShop = 6;

			// Token: 0x0402F77B RID: 194427
			public const int MainTab = 7;

			// Token: 0x0402F77C RID: 194428
			public const int MainTabItem = 8;

			// Token: 0x0402F77D RID: 194429
			public const int PnlContent = 9;

			// Token: 0x0402F77E RID: 194430
			public const int NiaSwitch = 10;
		}
	}
}
