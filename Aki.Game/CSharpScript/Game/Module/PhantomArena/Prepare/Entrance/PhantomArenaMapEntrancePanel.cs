using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.UiComponent.UiHomeButton;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Module.WorldMap.SubViews;
using CSharpScript.Game.Module.WorldMap.ViewComponent;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02005175 RID: 20853
	[NullableContext(2)]
	[Nullable(0)]
	public class PhantomArenaMapEntrancePanel : WorldMapExtraUiPanel
	{
		// Token: 0x17008120 RID: 33056
		// (get) Token: 0x06035502 RID: 218370 RVA: 0x00CA044F File Offset: 0x00C9E64F
		public new PhantomArenaMapEntrancePanelParam OpenParam
		{
			get
			{
				return this.OpenParam as PhantomArenaMapEntrancePanelParam;
			}
		}

		// Token: 0x06035503 RID: 218371 RVA: 0x00CA045C File Offset: 0x00C9E65C
		[NullableContext(1)]
		public PhantomArenaMapEntrancePanel(EWorldMapExtraUiPanelName panelName, WorldMapExtraUiPanelComponent extraUiPanelComponent) : base(panelName, extraUiPanelComponent)
		{
		}

		// Token: 0x06035504 RID: 218372 RVA: 0x00CA0478 File Offset: 0x00C9E678
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUISliderComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(10, typeof(UUIText)),
				new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(14, typeof(UUIText)),
				new ValueTuple<int, Type>(15, typeof(UUISprite)),
				new ValueTuple<int, Type>(16, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUIItem)),
				new ValueTuple<int, Type>(18, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(20, typeof(UUIItem)),
				new ValueTuple<int, Type>(21, typeof(UUIItem)),
				new ValueTuple<int, Type>(22, typeof(UUIItem)),
				new ValueTuple<int, Type>(23, typeof(UUIItem)),
				new ValueTuple<int, Type>(24, typeof(UUIItem)),
				new ValueTuple<int, Type>(25, typeof(UUIItem)),
				new ValueTuple<int, Type>(26, typeof(UUIText)),
				new ValueTuple<int, Type>(27, typeof(UUIItem)),
				new ValueTuple<int, Type>(28, typeof(UUIItem)),
				new ValueTuple<int, Type>(29, typeof(UUIItem)),
				new ValueTuple<int, Type>(30, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(9, new Action(this.OnClickBtnReward)),
				new ValueTuple<int, Delegate>(11, new Action(this.OnClickCard)),
				new ValueTuple<int, Delegate>(12, new Action(this.OnClickRole)),
				new ValueTuple<int, Delegate>(13, new Action(this.OnClickCollect)),
				new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.OnClickToggleNpcList))
			};
		}

		// Token: 0x06035505 RID: 218373 RVA: 0x00CA07C0 File Offset: 0x00C9E9C0
		private int GetMapIdByChallengeId(int challengeId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId).MapId;
		}

		// Token: 0x06035506 RID: 218374 RVA: 0x00CA07E0 File Offset: 0x00C9E9E0
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaMapEntrancePanel.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaMapEntrancePanel.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035507 RID: 218375 RVA: 0x00CA0823 File Offset: 0x00C9EA23
		protected override void OnStart()
		{
			this.InitCaptionItem();
			this.InitZoomButton();
			this.InitSequencePlayer();
			this.BindRedDot();
		}

		// Token: 0x06035508 RID: 218376 RVA: 0x00CA0840 File Offset: 0x00C9EA40
		private void InitZoomButton()
		{
			UUIButtonComponent button = base.GetButton(2);
			if (button != null)
			{
				this.ZoomInButton = new LongPressButton(button, delegate(float delta)
				{
					this.OnZoomIn();
				}, 100);
			}
			UUIButtonComponent button2 = base.GetButton(3);
			if (button2 != null)
			{
				this.ZoomOutButton = new LongPressButton(button2, delegate(float delta)
				{
					this.OnZoomOut();
				}, 100);
			}
		}

		// Token: 0x06035509 RID: 218377 RVA: 0x00CA0898 File Offset: 0x00C9EA98
		private void InitNpcListView()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(5);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			UUIItem item = base.GetItem(17);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.NpcListSequencePlayer = new UiSequencePlayer(base.GetItem(17));
			this.NpcListSequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnNpcListSequenceEnd));
			UUIItem item2 = base.GetItem(20);
			AUIBaseActor auibaseActor = ((item2 != null) ? item2.GetOwner() : null) as AUIBaseActor;
			if (auibaseActor != null)
			{
				auibaseActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnEventSequence));
			}
			UUILoopScrollViewComponent uuiloopScrollViewComponent = ((auibaseActor != null) ? auibaseActor.GetComponentByClass(UUILoopScrollViewComponent.StaticClass()) : null) as UUILoopScrollViewComponent;
			UUILoopScrollViewComponent scrollView = uuiloopScrollViewComponent;
			UUIItem item3 = base.GetItem(21);
			this.NpcListView = new LoopScrollView<PhantomArenaMapEntranceNpcListItem, int>(scrollView, ((item3 != null) ? item3.GetOwner() : null) as AUIBaseActor, () => new PhantomArenaMapEntranceNpcListItem
			{
				SelectCallBack = new Action<int>(this.OnSelectNpcListItem)
			}, false);
			UUIItem item4 = base.GetItem(21);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(false);
		}

		// Token: 0x0603550A RID: 218378 RVA: 0x00CA0994 File Offset: 0x00C9EB94
		private void InitSequencePlayer()
		{
			this.RewardBtnSequencePlayer = new UiSequencePlayer(base.GetItem(16));
			this.RewardBtnSequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnRewardBtnSequenceEnd));
			this.RightBtnRootSequencePlayer = new UiSequencePlayer(base.GetItem(25));
			this.RightBtnRootSequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnRightBtnRootSequenceEnd));
		}

		// Token: 0x0603550B RID: 218379 RVA: 0x00CA09F8 File Offset: 0x00C9EBF8
		private void OnSelectNpcListItem(int challengeId)
		{
			if (this.CurrentSelectedChallengeId == challengeId)
			{
				return;
			}
			this.CurrentSelectedChallengeId = challengeId;
			UiSequencePlayer rightBtnRootSequencePlayer = this.RightBtnRootSequencePlayer;
			if (rightBtnRootSequencePlayer != null)
			{
				rightBtnRootSequencePlayer.PlaySequence("Hide", false, null);
			}
			PhantomArenaMapEntranceDetailPanel detailPanel = this.DetailPanel;
			if (detailPanel != null)
			{
				detailPanel.ShowPanel(challengeId);
			}
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.SetUiActive(false);
			}
			CommonDropDown<int, int> dropDown = this.DropDown;
			if (dropDown != null)
			{
				dropDown.SetActive(false);
			}
			int markId = PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId).MarkId;
			if (WorldMapModel.Instance.GetIsMarkFocal(markId, EMarkType.PhantomArenaNpc))
			{
				return;
			}
			EventSystem.Instance.Emit<NavigateMark>(EEventName.WorldMapNavigate, new NavigateMark
			{
				MarkId = markId,
				MarkType = EMarkType.PhantomArenaNpc,
				Focal = new bool?(true)
			});
		}

		// Token: 0x0603550C RID: 218380 RVA: 0x00CA0AC0 File Offset: 0x00C9ECC0
		private UniTask InitDifficultTabLayout()
		{
			PhantomArenaMapEntrancePanel.<InitDifficultTabLayout>d__28 <InitDifficultTabLayout>d__;
			<InitDifficultTabLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDifficultTabLayout>d__.<>4__this = this;
			<InitDifficultTabLayout>d__.<>1__state = -1;
			<InitDifficultTabLayout>d__.<>t__builder.Start<PhantomArenaMapEntrancePanel.<InitDifficultTabLayout>d__28>(ref <InitDifficultTabLayout>d__);
			return <InitDifficultTabLayout>d__.<>t__builder.Task;
		}

		// Token: 0x0603550D RID: 218381 RVA: 0x00CA0B04 File Offset: 0x00C9ED04
		private UniTask RefreshDifficultTabLayout()
		{
			PhantomArenaMapEntrancePanel.<RefreshDifficultTabLayout>d__29 <RefreshDifficultTabLayout>d__;
			<RefreshDifficultTabLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshDifficultTabLayout>d__.<>4__this = this;
			<RefreshDifficultTabLayout>d__.<>1__state = -1;
			<RefreshDifficultTabLayout>d__.<>t__builder.Start<PhantomArenaMapEntrancePanel.<RefreshDifficultTabLayout>d__29>(ref <RefreshDifficultTabLayout>d__);
			return <RefreshDifficultTabLayout>d__.<>t__builder.Task;
		}

		// Token: 0x0603550E RID: 218382 RVA: 0x00CA0B47 File Offset: 0x00C9ED47
		private int GetCurrentMapId()
		{
			return this.CurrentMapId;
		}

		// Token: 0x0603550F RID: 218383 RVA: 0x00CA0B50 File Offset: 0x00C9ED50
		private void OnSelectDifficultItem(int difficult)
		{
			this.CurrentSelectedDifficult = difficult;
			UiSequencePlayer npcListSequencePlayer = this.NpcListSequencePlayer;
			if (npcListSequencePlayer == null)
			{
				return;
			}
			npcListSequencePlayer.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x06035510 RID: 218384 RVA: 0x00CA0B84 File Offset: 0x00C9ED84
		private UniTask CreateDetailPanel()
		{
			PhantomArenaMapEntrancePanel.<CreateDetailPanel>d__32 <CreateDetailPanel>d__;
			<CreateDetailPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDetailPanel>d__.<>4__this = this;
			<CreateDetailPanel>d__.<>1__state = -1;
			<CreateDetailPanel>d__.<>t__builder.Start<PhantomArenaMapEntrancePanel.<CreateDetailPanel>d__32>(ref <CreateDetailPanel>d__);
			return <CreateDetailPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06035511 RID: 218385 RVA: 0x00CA0BC7 File Offset: 0x00C9EDC7
		private void OnCloseDetailPanel()
		{
			this.CancelSelectNpc();
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem == null)
			{
				return;
			}
			captionItem.SetUiActive(true);
		}

		// Token: 0x06035512 RID: 218386 RVA: 0x00CA0BE0 File Offset: 0x00C9EDE0
		private void CancelSelectNpc()
		{
			this.CurrentSelectedChallengeId = 0;
			UUIItem item = base.GetItem(25);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UiSequencePlayer rightBtnRootSequencePlayer = this.RightBtnRootSequencePlayer;
			if (rightBtnRootSequencePlayer != null)
			{
				rightBtnRootSequencePlayer.PlaySequence("Show", false, null);
			}
			LoopScrollView<PhantomArenaMapEntranceNpcListItem, int> npcListView = this.NpcListView;
			if (npcListView != null)
			{
				npcListView.DeselectCurrentGridProxy(true);
			}
			this.ExtraUiPanelComponent.ClearClickItem();
			CommonDropDown<int, int> dropDown = this.DropDown;
			if (dropDown == null)
			{
				return;
			}
			dropDown.SetActive(true);
		}

		// Token: 0x06035513 RID: 218387 RVA: 0x00CA0C58 File Offset: 0x00C9EE58
		private UniTask InitDropDownList()
		{
			PhantomArenaMapEntrancePanel.<InitDropDownList>d__35 <InitDropDownList>d__;
			<InitDropDownList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDropDownList>d__.<>4__this = this;
			<InitDropDownList>d__.<>1__state = -1;
			<InitDropDownList>d__.<>t__builder.Start<PhantomArenaMapEntrancePanel.<InitDropDownList>d__35>(ref <InitDropDownList>d__);
			return <InitDropDownList>d__.<>t__builder.Task;
		}

		// Token: 0x06035514 RID: 218388 RVA: 0x00CA0C9B File Offset: 0x00C9EE9B
		[NullableContext(1)]
		private PhantomArenaMapDropDownTitleItem CreateTitleItem(UUIItem uiItem)
		{
			return new PhantomArenaMapDropDownTitleItem(uiItem);
		}

		// Token: 0x06035515 RID: 218389 RVA: 0x00CA0CA3 File Offset: 0x00C9EEA3
		[NullableContext(1)]
		private PhantomArenaMapDropDownItem CreateDropDownItem(UUIItem uiItem, int data)
		{
			return new PhantomArenaMapDropDownItem(uiItem);
		}

		// Token: 0x06035516 RID: 218390 RVA: 0x00CA0CAC File Offset: 0x00C9EEAC
		private void OnDropDownSelectCall(int index, int data)
		{
			PhantomArenaModel instance = PhantomArenaModel.Instance;
			if (instance != null)
			{
				instance.SaveMapUnlockRedDotById(data, false);
			}
			ValueTuple<int, int>? permanentDefaultChallengeIdAndMarkId = PhantomArenaModel.Instance.GetPermanentDefaultChallengeIdAndMarkId(new int?(data));
			if (permanentDefaultChallengeIdAndMarkId == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.CB;
				string message = "找不到对应地图的默认挑战数据";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("mapId", data);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			PhantomArenaBattleController.OpenPhantomArenaMapEntrance(new int?(permanentDefaultChallengeIdAndMarkId.Value.Item1), null);
		}

		// Token: 0x06035517 RID: 218391 RVA: 0x00CA0D36 File Offset: 0x00C9EF36
		private bool OnCheckCanChange(int oldIndex, int newIndex)
		{
			return oldIndex != newIndex;
		}

		// Token: 0x06035518 RID: 218392 RVA: 0x00CA0D3F File Offset: 0x00C9EF3F
		private int GetLevelDropDownTextId(int data)
		{
			return data;
		}

		// Token: 0x06035519 RID: 218393 RVA: 0x00CA0D44 File Offset: 0x00C9EF44
		private void InitCaptionItem()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.CloseCallBack));
			this.CaptionItem.SetTitleLocalText(EPhantomArenaTextId.TextEntranceTitle.ToString());
			HomeBtnController.Instance.CreateHomeBtnFromUiItem(base.GetItem(28), EUiViewName.WorldMapView, null, false);
		}

		// Token: 0x0603551A RID: 218394 RVA: 0x00CA0DAE File Offset: 0x00C9EFAE
		private void CloseCallBack()
		{
			base.CloseMe();
		}

		// Token: 0x0603551B RID: 218395 RVA: 0x00CA0DB8 File Offset: 0x00C9EFB8
		private void OnClickCard()
		{
			PhantomArenaActivityData permanentPhantomArenaActivityData = PhantomArenaModel.Instance.GetPermanentPhantomArenaActivityData();
			if (permanentPhantomArenaActivityData == null)
			{
				return;
			}
			PhantomArenaMainViewOpenParam param = new PhantomArenaMainViewOpenParam
			{
				ChallengeId = 0,
				OpenView = EPhantomArenaChildViewName.PhantomArenaDeckOverviewTabView,
				ActivityId = permanentPhantomArenaActivityData.Id
			};
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaMainView, param, null);
		}

		// Token: 0x0603551C RID: 218396 RVA: 0x00CA0E08 File Offset: 0x00C9F008
		private void OnClickRole()
		{
			PhantomArenaActivityData permanentPhantomArenaActivityData = PhantomArenaModel.Instance.GetPermanentPhantomArenaActivityData();
			if (permanentPhantomArenaActivityData == null)
			{
				return;
			}
			PhantomArenaMainViewOpenParam param = new PhantomArenaMainViewOpenParam
			{
				ChallengeId = 0,
				OpenView = EPhantomArenaChildViewName.PhantomArenaRoleSelectTabView,
				ActivityId = permanentPhantomArenaActivityData.Id
			};
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaMainView, param, null);
		}

		// Token: 0x0603551D RID: 218397 RVA: 0x00CA0E58 File Offset: 0x00C9F058
		private void OnClickCollect()
		{
			PhantomArenaActivityData permanentPhantomArenaActivityData = PhantomArenaModel.Instance.GetPermanentPhantomArenaActivityData();
			if (permanentPhantomArenaActivityData == null)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaCollectViewNew, permanentPhantomArenaActivityData.Id, null);
		}

		// Token: 0x0603551E RID: 218398 RVA: 0x00CA0E90 File Offset: 0x00C9F090
		private void OnClickBtnReward()
		{
			PhantomArenaActivityData permanentPhantomArenaActivityData = PhantomArenaModel.Instance.GetPermanentPhantomArenaActivityData();
			if (permanentPhantomArenaActivityData == null)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaRewardView, permanentPhantomArenaActivityData.Id, null);
		}

		// Token: 0x0603551F RID: 218399 RVA: 0x00CA0EC8 File Offset: 0x00C9F0C8
		protected override void OnBeforeShow()
		{
			this.RefreshInfo();
			this.RefreshBtnReward();
			this.RefreshRightDownBtns();
			WorldMapUiEntity worldMapUiComponent = this.ExtraUiPanelComponent.WorldMapUiComponent;
			if (worldMapUiComponent != null)
			{
				worldMapUiComponent.MultiFloorComponent.DeSelectMultiMapFloor(true);
			}
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "BvbMapPanelShow");
		}

		// Token: 0x06035520 RID: 218400 RVA: 0x00CA0F18 File Offset: 0x00C9F118
		private void RefreshInfo()
		{
			PhantomArenaActivityData permanentPhantomArenaActivityData = PhantomArenaModel.Instance.GetPermanentPhantomArenaActivityData();
			if (permanentPhantomArenaActivityData == null)
			{
				return;
			}
			PhantomArenaModel instance = PhantomArenaModel.Instance;
			int? num = (instance != null) ? new int?(instance.GetMasterLevel(permanentPhantomArenaActivityData.Id)) : null;
			UUIText text = base.GetText(6);
			if (text != null)
			{
				text.SetText(num.ToString(), true);
			}
			PhantomArenaModel instance2 = PhantomArenaModel.Instance;
			int? num2 = (instance2 != null) ? new int?(instance2.GetMasterExpNow(permanentPhantomArenaActivityData.Id, null)) : null;
			PhantomArenaModel instance3 = PhantomArenaModel.Instance;
			PhantomBattleMasterLevel? phantomBattleMasterLevel = (instance3 != null) ? instance3.GetMasterLevelConfig(num.Value, permanentPhantomArenaActivityData.Id) : null;
			if (phantomBattleMasterLevel == null)
			{
				return;
			}
			int? num3 = num2 - phantomBattleMasterLevel.Value.ExpNeed;
			int expNext = phantomBattleMasterLevel.Value.ExpNext;
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(7), EPhantomArenaTextId.TextExp.ToString(), new <>z__ReadOnlyArray<object>(new object[]
			{
				num3,
				expNext
			}));
			int titleId = phantomBattleMasterLevel.Value.TitleId;
			PhantomArenaConfig instance4 = PhantomArenaConfig.Instance;
			PhantomBattleMasterTitle? phantomBattleMasterTitle = (instance4 != null) ? new PhantomBattleMasterTitle?(instance4.GetPhantomBattleMasterTitleById(titleId)) : null;
			int? num4 = num3;
			float? num5 = ((num4 != null) ? new float?((float)num4.GetValueOrDefault()) : null) / (float)expNext;
			base.GetSprite(15).SetFillAmount(num5.Value);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(8), (phantomBattleMasterTitle != null) ? phantomBattleMasterTitle.GetValueOrDefault().Name : null, Array.Empty<object>());
		}

		// Token: 0x06035521 RID: 218401 RVA: 0x00CA1138 File Offset: 0x00C9F338
		private void RefreshChallengeProgress()
		{
			PhantomArenaModel instance = PhantomArenaModel.Instance;
			int? num = (instance != null) ? new int?(instance.GetPermanentFinishedChallengeCount(this.CurrentMapId)) : null;
			PhantomArenaModel instance2 = PhantomArenaModel.Instance;
			int? num2 = (instance2 != null) ? new int?(instance2.GetPermanentAllChallengeCount(this.CurrentMapId)) : null;
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(26), this.IsShowNpcList ? EPhantomArenaTextId.TextChallengeProgressSelect.ToString() : EPhantomArenaTextId.TextChallengeProgressNormal.ToString(), new <>z__ReadOnlyArray<object>(new object[]
			{
				num,
				num2
			}));
		}

		// Token: 0x06035522 RID: 218402 RVA: 0x00CA11E8 File Offset: 0x00C9F3E8
		private void RefreshBtnReward()
		{
			PhantomArenaActivityData permanentPhantomArenaActivityData = PhantomArenaModel.Instance.GetPermanentPhantomArenaActivityData();
			if (permanentPhantomArenaActivityData == null)
			{
				return;
			}
			UUIItem item = base.GetItem(16);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			PhantomArenaModel instance = PhantomArenaModel.Instance;
			ValueTuple<int, int>? valueTuple = (instance != null) ? new ValueTuple<int, int>?(instance.GetAllTaskProgress(permanentPhantomArenaActivityData.Id)) : null;
			PhantomArenaModel instance2 = PhantomArenaModel.Instance;
			int? num = (instance2 != null) ? new int?(instance2.GetAllTaskSecondCurrencyNum(permanentPhantomArenaActivityData.Id)) : null;
			UUIText text = base.GetText(14);
			if (text != null)
			{
				text.SetText(num.ToString(), true);
			}
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(10), EPhantomArenaTextId.TextRewardProgress.ToString(), new <>z__ReadOnlyArray<object>(new object[]
			{
				valueTuple.Value.Item1,
				valueTuple.Value.Item2
			}));
			UiSequencePlayer rewardBtnSequencePlayer = this.RewardBtnSequencePlayer;
			if (rewardBtnSequencePlayer != null)
			{
				rewardBtnSequencePlayer.StopPrevSequence(false, true);
			}
			if (this.IsShowNpcList)
			{
				UiSequencePlayer rewardBtnSequencePlayer2 = this.RewardBtnSequencePlayer;
				if (rewardBtnSequencePlayer2 == null)
				{
					return;
				}
				rewardBtnSequencePlayer2.PlaySequence("Hide", false, null);
				return;
			}
			else
			{
				UUIItem item2 = base.GetItem(16);
				if (item2 != null)
				{
					item2.SetUIActive(true);
				}
				UiSequencePlayer rewardBtnSequencePlayer3 = this.RewardBtnSequencePlayer;
				if (rewardBtnSequencePlayer3 == null)
				{
					return;
				}
				rewardBtnSequencePlayer3.PlaySequence("Show", false, null);
				return;
			}
		}

		// Token: 0x06035523 RID: 218403 RVA: 0x00CA134C File Offset: 0x00C9F54C
		private void RefreshRightDownBtns()
		{
			UUIButtonComponent button = base.GetButton(11);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(FunctionModel.Instance.IsOpen(EFunctionType.PermanentPhantomArenaCard));
			}
			UUIButtonComponent button2 = base.GetButton(12);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(FunctionModel.Instance.IsOpen(EFunctionType.PermanentPhantomArenaRole));
			}
			UUIButtonComponent button3 = base.GetButton(13);
			if (button3 == null)
			{
				return;
			}
			button3.RootUIComp.Get().SetUIActive(FunctionModel.Instance.IsOpen(EFunctionType.PermanentPhantomAreaCollect));
		}

		// Token: 0x06035524 RID: 218404 RVA: 0x00CA13E8 File Offset: 0x00C9F5E8
		private void OnClickToggleNpcList(EToggleState toggleState)
		{
			EToggleState toggleState2 = base.GetExtendToggle(5).GetToggleState();
			this.IsShowNpcList = (toggleState2 == EToggleState.ETT_Checked);
			this.RefreshBtnReward();
			if (this.IsShowNpcList)
			{
				UUIItem item = base.GetItem(17);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UiSequencePlayer npcListSequencePlayer = this.NpcListSequencePlayer;
				if (npcListSequencePlayer != null)
				{
					npcListSequencePlayer.StopPrevSequence(false, true);
				}
				UiSequencePlayer npcListSequencePlayer2 = this.NpcListSequencePlayer;
				if (npcListSequencePlayer2 != null)
				{
					npcListSequencePlayer2.PlaySequence("Show", false, null);
				}
			}
			else
			{
				UiSequencePlayer npcListSequencePlayer3 = this.NpcListSequencePlayer;
				if (npcListSequencePlayer3 != null)
				{
					npcListSequencePlayer3.StopPrevSequence(false, true);
				}
				UiSequencePlayer npcListSequencePlayer4 = this.NpcListSequencePlayer;
				if (npcListSequencePlayer4 != null)
				{
					npcListSequencePlayer4.PlaySequence("Hide", false, null);
				}
			}
			if (this.CurrentSelectedChallengeId == 0)
			{
				List<int> permanentSortedDifficultList = PhantomArenaModel.Instance.GetPermanentSortedDifficultList(this.CurrentMapId);
				if (permanentSortedDifficultList == null)
				{
					Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.CB, "difficultList为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				int num = -1;
				foreach (int num2 in permanentSortedDifficultList)
				{
					num = num2;
					if (!PhantomArenaModel.Instance.GetPermanentIsDifficultCompleted(this.CurrentMapId, num2))
					{
						break;
					}
				}
				if (num != -1)
				{
					GenericLayout<PhantomArenaMapEntranceDifficultItem, int> difficultTabLayout = this.DifficultTabLayout;
					if (difficultTabLayout != null)
					{
						difficultTabLayout.SelectGridProxyByKey(num, true);
					}
				}
			}
			this.RefreshChallengeProgress();
		}

		// Token: 0x06035525 RID: 218405 RVA: 0x00CA1550 File Offset: 0x00C9F750
		[NullableContext(1)]
		private void OnNpcListSequenceEnd(string sequenceName)
		{
			if (sequenceName == "Hide")
			{
				UUIItem item = base.GetItem(17);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
			}
		}

		// Token: 0x06035526 RID: 218406 RVA: 0x00CA1572 File Offset: 0x00C9F772
		[NullableContext(1)]
		private void OnRewardBtnSequenceEnd(string sequenceName)
		{
			if (sequenceName == "Hide")
			{
				UUIItem item = base.GetItem(16);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
			}
		}

		// Token: 0x06035527 RID: 218407 RVA: 0x00CA1594 File Offset: 0x00C9F794
		[NullableContext(1)]
		private void OnRightBtnRootSequenceEnd(string sequenceName)
		{
			if (sequenceName == "Hide")
			{
				UUIItem item = base.GetItem(25);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
			}
		}

		// Token: 0x06035528 RID: 218408 RVA: 0x00CA15B6 File Offset: 0x00C9F7B6
		[NullableContext(1)]
		private void OnEventSequence(string sequenceName, string eventName)
		{
			if (sequenceName == "Switch" && eventName == "Switch")
			{
				this.RefreshNpcList();
			}
		}

		// Token: 0x06035529 RID: 218409 RVA: 0x00CA15D8 File Offset: 0x00C9F7D8
		private void RefreshNpcList()
		{
			PhantomArenaActivityData permanentPhantomArenaActivityData = PhantomArenaModel.Instance.GetPermanentPhantomArenaActivityData();
			Dictionary<int, List<int>> dictionary = (permanentPhantomArenaActivityData != null) ? permanentPhantomArenaActivityData.GetDifficultChallengeIdsMap(this.CurrentMapId) : null;
			List<int> list;
			if (dictionary == null || !dictionary.TryGetValue(this.CurrentSelectedDifficult, out list))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.CB;
				string message = "RefreshNpcList:当前难度对应的ChallengeIdList为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("difficult", this.CurrentSelectedDifficult);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			int index = -1;
			bool isSelectFireEvent = false;
			if (this.TargetChallengeId == 0)
			{
				index = list.IndexOf(this.CurrentSelectedChallengeId);
			}
			else
			{
				index = list.IndexOf(this.TargetChallengeId);
				this.TargetChallengeId = 0;
				isSelectFireEvent = true;
			}
			LoopScrollView<PhantomArenaMapEntranceNpcListItem, int> npcListView = this.NpcListView;
			if (npcListView != null)
			{
				npcListView.DeselectCurrentGridProxy(false);
			}
			LoopScrollView<PhantomArenaMapEntranceNpcListItem, int> npcListView2 = this.NpcListView;
			if (npcListView2 == null)
			{
				return;
			}
			npcListView2.RefreshByData(list, false, delegate
			{
				if (index != -1)
				{
					LoopScrollView<PhantomArenaMapEntranceNpcListItem, int> npcListView3 = this.NpcListView;
					if (npcListView3 != null)
					{
						npcListView3.SelectGridProxy(index, isSelectFireEvent);
					}
					LoopScrollView<PhantomArenaMapEntranceNpcListItem, int> npcListView4 = this.NpcListView;
					if (npcListView4 == null || !npcListView4.IsGridDisplaying(index))
					{
						LoopScrollView<PhantomArenaMapEntranceNpcListItem, int> npcListView5 = this.NpcListView;
						if (npcListView5 == null)
						{
							return;
						}
						npcListView5.ScrollToGridIndex(index, true);
					}
				}
			}, false);
		}

		// Token: 0x0603552A RID: 218410 RVA: 0x00CA16D4 File Offset: 0x00C9F8D4
		private void BindRedDot()
		{
			PhantomArenaActivityData permanentPhantomArenaActivityData = PhantomArenaModel.Instance.GetPermanentPhantomArenaActivityData();
			if (permanentPhantomArenaActivityData == null)
			{
				return;
			}
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotPhantomArenaCollect, base.GetItem(24), null, permanentPhantomArenaActivityData.Id);
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotPhantomArenaRole, base.GetItem(23), null, permanentPhantomArenaActivityData.Id);
			base.GetItem(22).SetUIActive(false);
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotPhantomArenaTaskReward, base.GetItem(27), null, permanentPhantomArenaActivityData.Id);
			UUIItem item = base.GetItem(30);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0603552B RID: 218411 RVA: 0x00CA176C File Offset: 0x00C9F96C
		private void UnBindRedDot()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotPhantomArenaCollect, base.GetItem(24), 0);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotPhantomArenaRole, base.GetItem(23), 0);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotPhantomArenaTaskReward, base.GetItem(27), 0);
		}

		// Token: 0x0603552C RID: 218412 RVA: 0x00CA17C1 File Offset: 0x00C9F9C1
		protected override void OnBeforeDestroy()
		{
			LongPressButton zoomInButton = this.ZoomInButton;
			if (zoomInButton != null)
			{
				zoomInButton.OnDestroy();
			}
			LongPressButton zoomOutButton = this.ZoomOutButton;
			if (zoomOutButton != null)
			{
				zoomOutButton.OnDestroy();
			}
			this.UnBindRedDot();
		}

		// Token: 0x0603552D RID: 218413 RVA: 0x00CA17EB File Offset: 0x00C9F9EB
		public override UUISliderComponent GetScaleSlider()
		{
			return base.GetSlider(1);
		}

		// Token: 0x0603552E RID: 218414 RVA: 0x00CA17F4 File Offset: 0x00C9F9F4
		public override void OnHandleShowParam(object param = null)
		{
			this.OpenParam = (param as PhantomArenaMapEntrancePanelParam);
			if (this.OpenParam == null || this.OpenParam.ChallengeId == 0)
			{
				Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.CB, "PhantomArenaMapEntrancePanel:OnHandleShowParam challengeId undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.CB;
			string message = "PhantomArenaMapEntrancePanel:OnHandleShowParam";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ChallengeId", this.OpenParam.ChallengeId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.SelectChallenge(this.OpenParam.ChallengeId, this.OpenParam.IsNeedSelect.GetValueOrDefault());
		}

		// Token: 0x0603552F RID: 218415 RVA: 0x00CA18A0 File Offset: 0x00C9FAA0
		private UniTask SelectChallenge(int challengeId, bool isNeedSelect)
		{
			PhantomArenaMapEntrancePanel.<SelectChallenge>d__63 <SelectChallenge>d__;
			<SelectChallenge>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SelectChallenge>d__.<>4__this = this;
			<SelectChallenge>d__.challengeId = challengeId;
			<SelectChallenge>d__.isNeedSelect = isNeedSelect;
			<SelectChallenge>d__.<>1__state = -1;
			<SelectChallenge>d__.<>t__builder.Start<PhantomArenaMapEntrancePanel.<SelectChallenge>d__63>(ref <SelectChallenge>d__);
			return <SelectChallenge>d__.<>t__builder.Task;
		}

		// Token: 0x06035530 RID: 218416 RVA: 0x00CA18F3 File Offset: 0x00C9FAF3
		private void OnZoomOut()
		{
			AudioSystem.Instance.PostEvent("play_ui_com_slider_tick");
			EventSystem.Instance.Emit<float, EMapScaleSetType>(EEventName.WorldMapZoomBtnInput, -0.1f, EMapScaleSetType.ZoomButton);
		}

		// Token: 0x06035531 RID: 218417 RVA: 0x00CA191B File Offset: 0x00C9FB1B
		private void OnZoomIn()
		{
			AudioSystem.Instance.PostEvent("play_ui_com_slider_tick");
			EventSystem.Instance.Emit<float, EMapScaleSetType>(EEventName.WorldMapZoomBtnInput, 0.1f, EMapScaleSetType.ZoomButton);
		}

		// Token: 0x06035532 RID: 218418 RVA: 0x00CA1943 File Offset: 0x00C9FB43
		[NullableContext(1)]
		public override bool OnClickEmpty(Vector2D clickedPosition)
		{
			if (this.IsSecondaryUiOpening)
			{
				this.CloseSecondaryUi(null, true);
			}
			return true;
		}

		// Token: 0x06035533 RID: 218419 RVA: 0x00CA1958 File Offset: 0x00C9FB58
		[NullableContext(1)]
		public override ClickMarkItemRet OnClickMarkItem(MarkItem markItem)
		{
			this.ClickMarkItemRetData.IsExtraUiLogic = true;
			int markId = markItem.MarkId;
			if (markId == 0)
			{
				Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.CB, "markItem.MarkId为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return this.ClickMarkItemRetData;
			}
			PhantomBattleChallenge? phantomBattleChallengeByMarkId = PhantomArenaConfig.Instance.GetPhantomBattleChallengeByMarkId(markId);
			if (phantomBattleChallengeByMarkId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.CB;
				string message = "对应markId的Challenge为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("markId", markId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return this.ClickMarkItemRetData;
			}
			this.SelectChallenge(phantomBattleChallengeByMarkId.Value.Id, true);
			return this.ClickMarkItemRetData;
		}

		// Token: 0x06035534 RID: 218420 RVA: 0x00CA1A0A File Offset: 0x00C9FC0A
		[NullableContext(1)]
		public override bool OnClickMarks(List<MarkItem> clickedItems, Vector2D clickedPosition)
		{
			this.CloseSecondaryUi(delegate
			{
				AudioSystem.Instance.PostEvent("play_ui_ia_spl_map_click_com");
			}, true);
			return true;
		}

		// Token: 0x06035535 RID: 218421 RVA: 0x00CA1A33 File Offset: 0x00C9FC33
		private void CloseSecondaryUi(Action onClosed = null, bool playSequence = true)
		{
			if (!this.IsSecondaryUiOpening)
			{
				if (onClosed != null)
				{
					onClosed();
				}
				return;
			}
			PhantomArenaMapEntranceDetailPanel detailPanel = this.DetailPanel;
			if (detailPanel == null)
			{
				return;
			}
			detailPanel.Close(onClosed, playSequence);
		}

		// Token: 0x17008121 RID: 33057
		// (get) Token: 0x06035536 RID: 218422 RVA: 0x00CA1A59 File Offset: 0x00C9FC59
		private bool IsSecondaryUiOpening
		{
			get
			{
				PhantomArenaMapEntranceDetailPanel detailPanel = this.DetailPanel;
				return detailPanel == null || !detailPanel.IsUiCloseComplete;
			}
		}

		// Token: 0x06035537 RID: 218423 RVA: 0x00CA1A72 File Offset: 0x00C9FC72
		public override bool GetIsEnableMapScale()
		{
			return !this.IsSecondaryUiOpening;
		}

		// Token: 0x06035538 RID: 218424 RVA: 0x00CA1A7D File Offset: 0x00C9FC7D
		public override bool GetIsEnableMapCursorButton()
		{
			return !this.IsSecondaryUiOpening;
		}

		// Token: 0x06035539 RID: 218425 RVA: 0x00CA1A88 File Offset: 0x00C9FC88
		[NullableContext(1)]
		public override bool OnPointerDrag(Vector2D delta)
		{
			if (this.IsSecondaryUiOpening)
			{
				this.CloseSecondaryUi(null, true);
			}
			return true;
		}

		// Token: 0x0603553A RID: 218426 RVA: 0x00CA1A9C File Offset: 0x00C9FC9C
		public override float GetDefaultMapScale()
		{
			PhantomArenaConfig instance = PhantomArenaConfig.Instance;
			PhantomBattleMapParam? phantomBattleMapParam = (instance != null) ? instance.GetPhantomBattleMapParamById(this.CurrentMapId) : null;
			return (float)((phantomBattleMapParam != null) ? phantomBattleMapParam.GetValueOrDefault().BigMapDefaultScale : 0);
		}

		// Token: 0x0603553B RID: 218427 RVA: 0x00CA1AE8 File Offset: 0x00C9FCE8
		public override float GetMaxMapScale()
		{
			PhantomArenaConfig instance = PhantomArenaConfig.Instance;
			PhantomBattleMapParam? phantomBattleMapParam = (instance != null) ? instance.GetPhantomBattleMapParamById(this.CurrentMapId) : null;
			return (float)((phantomBattleMapParam != null) ? phantomBattleMapParam.GetValueOrDefault().BigMapMaxScale : 0);
		}

		// Token: 0x0603553C RID: 218428 RVA: 0x00CA1B34 File Offset: 0x00C9FD34
		public override float GetMinMapScale()
		{
			PhantomArenaConfig instance = PhantomArenaConfig.Instance;
			PhantomBattleMapParam? phantomBattleMapParam = (instance != null) ? instance.GetPhantomBattleMapParamById(this.CurrentMapId) : null;
			return (float)((phantomBattleMapParam != null) ? phantomBattleMapParam.GetValueOrDefault().BigMapMinScale : 0);
		}

		// Token: 0x0603553D RID: 218429 RVA: 0x00CA1B7D File Offset: 0x00C9FD7D
		[NullableContext(1)]
		public override EMarkType[] GetExtraMarkTypes()
		{
			return new EMarkType[]
			{
				EMarkType.PhantomArenaNpc,
				EMarkType.AreaMark
			};
		}

		// Token: 0x0603553E RID: 218430 RVA: 0x00CA1B90 File Offset: 0x00C9FD90
		public override void SetOpenParam(object openParam)
		{
			this.OpenParam = openParam;
			int challengeId = ((PhantomArenaMapEntrancePanelParam)openParam).ChallengeId;
			this.CurrentMapId = this.GetMapIdByChallengeId(challengeId);
		}

		// Token: 0x0401C59A RID: 116122
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C59B RID: 116123
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoopScrollView<PhantomArenaMapEntranceNpcListItem, int> NpcListView;

		// Token: 0x0401C59C RID: 116124
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<PhantomArenaMapEntranceDifficultItem, int> DifficultTabLayout;

		// Token: 0x0401C59D RID: 116125
		private PhantomArenaMapEntranceDetailPanel DetailPanel;

		// Token: 0x0401C59E RID: 116126
		private UiSequencePlayer NpcListSequencePlayer;

		// Token: 0x0401C59F RID: 116127
		private LongPressButton ZoomInButton;

		// Token: 0x0401C5A0 RID: 116128
		private LongPressButton ZoomOutButton;

		// Token: 0x0401C5A1 RID: 116129
		private int CurrentSelectedDifficult = -1;

		// Token: 0x0401C5A2 RID: 116130
		private int TargetChallengeId;

		// Token: 0x0401C5A3 RID: 116131
		private int CurrentSelectedChallengeId;

		// Token: 0x0401C5A4 RID: 116132
		private bool IsShowNpcList;

		// Token: 0x0401C5A5 RID: 116133
		private UiSequencePlayer RewardBtnSequencePlayer;

		// Token: 0x0401C5A6 RID: 116134
		private UiSequencePlayer RightBtnRootSequencePlayer;

		// Token: 0x0401C5A7 RID: 116135
		private CommonDropDown<int, int> DropDown;

		// Token: 0x0401C5A8 RID: 116136
		[Nullable(1)]
		private readonly List<int> MapIdList = new List<int>();

		// Token: 0x0401C5A9 RID: 116137
		private int CurrentMapId;

		// Token: 0x0200B2DD RID: 45789
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403631A RID: 221978
			public const int CaptionItem = 0;

			// Token: 0x0403631B RID: 221979
			public const int ScaleSlider = 1;

			// Token: 0x0403631C RID: 221980
			public const int ZoomIn = 2;

			// Token: 0x0403631D RID: 221981
			public const int ZoomOut = 3;

			// Token: 0x0403631E RID: 221982
			public const int PnlInfo = 4;

			// Token: 0x0403631F RID: 221983
			public const int ToggleNpcList = 5;

			// Token: 0x04036320 RID: 221984
			public const int TextLv = 6;

			// Token: 0x04036321 RID: 221985
			public const int TextExp = 7;

			// Token: 0x04036322 RID: 221986
			public const int TextTitle = 8;

			// Token: 0x04036323 RID: 221987
			public const int BtnReward = 9;

			// Token: 0x04036324 RID: 221988
			public const int TextRewardProgress = 10;

			// Token: 0x04036325 RID: 221989
			public const int BtnMenuCard = 11;

			// Token: 0x04036326 RID: 221990
			public const int BtnMenuRole = 12;

			// Token: 0x04036327 RID: 221991
			public const int BtnMenuCollect = 13;

			// Token: 0x04036328 RID: 221992
			public const int TextRewardNum = 14;

			// Token: 0x04036329 RID: 221993
			public const int SpriteExp = 15;

			// Token: 0x0403632A RID: 221994
			public const int RewardBtnRoot = 16;

			// Token: 0x0403632B RID: 221995
			public const int PnlNpcList = 17;

			// Token: 0x0403632C RID: 221996
			public const int DifficultTabList = 18;

			// Token: 0x0403632D RID: 221997
			public const int DifficultTabItem = 19;

			// Token: 0x0403632E RID: 221998
			public const int NpcList = 20;

			// Token: 0x0403632F RID: 221999
			public const int NpcListItem = 21;

			// Token: 0x04036330 RID: 222000
			public const int ItemRedDotCard = 22;

			// Token: 0x04036331 RID: 222001
			public const int ItemRedDotRole = 23;

			// Token: 0x04036332 RID: 222002
			public const int ItemRedDotCollect = 24;

			// Token: 0x04036333 RID: 222003
			public const int RightButtonsRoot = 25;

			// Token: 0x04036334 RID: 222004
			public const int ChallengeProgress = 26;

			// Token: 0x04036335 RID: 222005
			public const int ItemRedDotTask = 27;

			// Token: 0x04036336 RID: 222006
			public const int HomeBtnRoot = 28;

			// Token: 0x04036337 RID: 222007
			public const int DropDownItem = 29;

			// Token: 0x04036338 RID: 222008
			public const int DropDownRedDot = 30;
		}
	}
}
