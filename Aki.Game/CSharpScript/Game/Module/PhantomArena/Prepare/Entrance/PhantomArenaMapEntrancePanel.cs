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
	// Token: 0x02004145 RID: 16709
	[NullableContext(2)]
	[Nullable(0)]
	public class PhantomArenaMapEntrancePanel : WorldMapExtraUiPanel
	{
		// Token: 0x170054E0 RID: 21728
		// (get) Token: 0x0602A3FE RID: 173054 RVA: 0x00BED9CB File Offset: 0x00BEBBCB
		public new PhantomArenaMapEntrancePanelParam OpenParam
		{
			get
			{
				return this.OpenParam as PhantomArenaMapEntrancePanelParam;
			}
		}

		// Token: 0x0602A3FF RID: 173055 RVA: 0x00BED9D8 File Offset: 0x00BEBBD8
		[NullableContext(1)]
		public PhantomArenaMapEntrancePanel(EWorldMapExtraUiPanelName panelName, WorldMapExtraUiPanelComponent extraUiPanelComponent) : base(panelName, extraUiPanelComponent)
		{
		}

		// Token: 0x0602A400 RID: 173056 RVA: 0x00BED9F4 File Offset: 0x00BEBBF4
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

		// Token: 0x0602A401 RID: 173057 RVA: 0x00BEDD3C File Offset: 0x00BEBF3C
		private int GetMapIdByChallengeId(int challengeId)
		{
			return PhantomArenaConfig.Instance.GetPhantomBattleChallenge(challengeId).MapId;
		}

		// Token: 0x0602A402 RID: 173058 RVA: 0x00BEDD5C File Offset: 0x00BEBF5C
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaMapEntrancePanel.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaMapEntrancePanel.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A403 RID: 173059 RVA: 0x00BEDD9F File Offset: 0x00BEBF9F
		protected override void OnStart()
		{
			this.InitCaptionItem();
			this.InitZoomButton();
			this.InitSequencePlayer();
			this.BindRedDot();
		}

		// Token: 0x0602A404 RID: 173060 RVA: 0x00BEDDBC File Offset: 0x00BEBFBC
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

		// Token: 0x0602A405 RID: 173061 RVA: 0x00BEDE14 File Offset: 0x00BEC014
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

		// Token: 0x0602A406 RID: 173062 RVA: 0x00BEDF10 File Offset: 0x00BEC110
		private void InitSequencePlayer()
		{
			this.RewardBtnSequencePlayer = new UiSequencePlayer(base.GetItem(16));
			this.RewardBtnSequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnRewardBtnSequenceEnd));
			this.RightBtnRootSequencePlayer = new UiSequencePlayer(base.GetItem(25));
			this.RightBtnRootSequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.OnRightBtnRootSequenceEnd));
		}

		// Token: 0x0602A407 RID: 173063 RVA: 0x00BEDF74 File Offset: 0x00BEC174
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

		// Token: 0x0602A408 RID: 173064 RVA: 0x00BEE03C File Offset: 0x00BEC23C
		private UniTask InitDifficultTabLayout()
		{
			PhantomArenaMapEntrancePanel.<InitDifficultTabLayout>d__28 <InitDifficultTabLayout>d__;
			<InitDifficultTabLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDifficultTabLayout>d__.<>4__this = this;
			<InitDifficultTabLayout>d__.<>1__state = -1;
			<InitDifficultTabLayout>d__.<>t__builder.Start<PhantomArenaMapEntrancePanel.<InitDifficultTabLayout>d__28>(ref <InitDifficultTabLayout>d__);
			return <InitDifficultTabLayout>d__.<>t__builder.Task;
		}

		// Token: 0x0602A409 RID: 173065 RVA: 0x00BEE080 File Offset: 0x00BEC280
		private UniTask RefreshDifficultTabLayout()
		{
			PhantomArenaMapEntrancePanel.<RefreshDifficultTabLayout>d__29 <RefreshDifficultTabLayout>d__;
			<RefreshDifficultTabLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshDifficultTabLayout>d__.<>4__this = this;
			<RefreshDifficultTabLayout>d__.<>1__state = -1;
			<RefreshDifficultTabLayout>d__.<>t__builder.Start<PhantomArenaMapEntrancePanel.<RefreshDifficultTabLayout>d__29>(ref <RefreshDifficultTabLayout>d__);
			return <RefreshDifficultTabLayout>d__.<>t__builder.Task;
		}

		// Token: 0x0602A40A RID: 173066 RVA: 0x00BEE0C3 File Offset: 0x00BEC2C3
		private int GetCurrentMapId()
		{
			return this.CurrentMapId;
		}

		// Token: 0x0602A40B RID: 173067 RVA: 0x00BEE0CC File Offset: 0x00BEC2CC
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

		// Token: 0x0602A40C RID: 173068 RVA: 0x00BEE100 File Offset: 0x00BEC300
		private UniTask CreateDetailPanel()
		{
			PhantomArenaMapEntrancePanel.<CreateDetailPanel>d__32 <CreateDetailPanel>d__;
			<CreateDetailPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDetailPanel>d__.<>4__this = this;
			<CreateDetailPanel>d__.<>1__state = -1;
			<CreateDetailPanel>d__.<>t__builder.Start<PhantomArenaMapEntrancePanel.<CreateDetailPanel>d__32>(ref <CreateDetailPanel>d__);
			return <CreateDetailPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0602A40D RID: 173069 RVA: 0x00BEE143 File Offset: 0x00BEC343
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

		// Token: 0x0602A40E RID: 173070 RVA: 0x00BEE15C File Offset: 0x00BEC35C
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

		// Token: 0x0602A40F RID: 173071 RVA: 0x00BEE1D4 File Offset: 0x00BEC3D4
		private UniTask InitDropDownList()
		{
			PhantomArenaMapEntrancePanel.<InitDropDownList>d__35 <InitDropDownList>d__;
			<InitDropDownList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDropDownList>d__.<>4__this = this;
			<InitDropDownList>d__.<>1__state = -1;
			<InitDropDownList>d__.<>t__builder.Start<PhantomArenaMapEntrancePanel.<InitDropDownList>d__35>(ref <InitDropDownList>d__);
			return <InitDropDownList>d__.<>t__builder.Task;
		}

		// Token: 0x0602A410 RID: 173072 RVA: 0x00BEE217 File Offset: 0x00BEC417
		[NullableContext(1)]
		private PhantomArenaMapDropDownTitleItem CreateTitleItem(UUIItem uiItem)
		{
			return new PhantomArenaMapDropDownTitleItem(uiItem);
		}

		// Token: 0x0602A411 RID: 173073 RVA: 0x00BEE21F File Offset: 0x00BEC41F
		[NullableContext(1)]
		private PhantomArenaMapDropDownItem CreateDropDownItem(UUIItem uiItem, int data)
		{
			return new PhantomArenaMapDropDownItem(uiItem);
		}

		// Token: 0x0602A412 RID: 173074 RVA: 0x00BEE228 File Offset: 0x00BEC428
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

		// Token: 0x0602A413 RID: 173075 RVA: 0x00BEE2B2 File Offset: 0x00BEC4B2
		private bool OnCheckCanChange(int oldIndex, int newIndex)
		{
			return oldIndex != newIndex;
		}

		// Token: 0x0602A414 RID: 173076 RVA: 0x00BEE2BB File Offset: 0x00BEC4BB
		private int GetLevelDropDownTextId(int data)
		{
			return data;
		}

		// Token: 0x0602A415 RID: 173077 RVA: 0x00BEE2C0 File Offset: 0x00BEC4C0
		private void InitCaptionItem()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.CloseCallBack));
			this.CaptionItem.SetTitleLocalText(EPhantomArenaTextId.TextEntranceTitle.ToString());
			HomeBtnController.Instance.CreateHomeBtnFromUiItem(base.GetItem(28), EUiViewName.WorldMapView, null, false);
		}

		// Token: 0x0602A416 RID: 173078 RVA: 0x00BEE32A File Offset: 0x00BEC52A
		private void CloseCallBack()
		{
			base.CloseMe();
		}

		// Token: 0x0602A417 RID: 173079 RVA: 0x00BEE334 File Offset: 0x00BEC534
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

		// Token: 0x0602A418 RID: 173080 RVA: 0x00BEE384 File Offset: 0x00BEC584
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

		// Token: 0x0602A419 RID: 173081 RVA: 0x00BEE3D4 File Offset: 0x00BEC5D4
		private void OnClickCollect()
		{
			PhantomArenaActivityData permanentPhantomArenaActivityData = PhantomArenaModel.Instance.GetPermanentPhantomArenaActivityData();
			if (permanentPhantomArenaActivityData == null)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaCollectViewNew, permanentPhantomArenaActivityData.Id, null);
		}

		// Token: 0x0602A41A RID: 173082 RVA: 0x00BEE40C File Offset: 0x00BEC60C
		private void OnClickBtnReward()
		{
			PhantomArenaActivityData permanentPhantomArenaActivityData = PhantomArenaModel.Instance.GetPermanentPhantomArenaActivityData();
			if (permanentPhantomArenaActivityData == null)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.PhantomArenaRewardView, permanentPhantomArenaActivityData.Id, null);
		}

		// Token: 0x0602A41B RID: 173083 RVA: 0x00BEE444 File Offset: 0x00BEC644
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

		// Token: 0x0602A41C RID: 173084 RVA: 0x00BEE494 File Offset: 0x00BEC694
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

		// Token: 0x0602A41D RID: 173085 RVA: 0x00BEE6B4 File Offset: 0x00BEC8B4
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

		// Token: 0x0602A41E RID: 173086 RVA: 0x00BEE764 File Offset: 0x00BEC964
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

		// Token: 0x0602A41F RID: 173087 RVA: 0x00BEE8C8 File Offset: 0x00BECAC8
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

		// Token: 0x0602A420 RID: 173088 RVA: 0x00BEE964 File Offset: 0x00BECB64
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

		// Token: 0x0602A421 RID: 173089 RVA: 0x00BEEACC File Offset: 0x00BECCCC
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

		// Token: 0x0602A422 RID: 173090 RVA: 0x00BEEAEE File Offset: 0x00BECCEE
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

		// Token: 0x0602A423 RID: 173091 RVA: 0x00BEEB10 File Offset: 0x00BECD10
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

		// Token: 0x0602A424 RID: 173092 RVA: 0x00BEEB32 File Offset: 0x00BECD32
		[NullableContext(1)]
		private void OnEventSequence(string sequenceName, string eventName)
		{
			if (sequenceName == "Switch" && eventName == "Switch")
			{
				this.RefreshNpcList();
			}
		}

		// Token: 0x0602A425 RID: 173093 RVA: 0x00BEEB54 File Offset: 0x00BECD54
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

		// Token: 0x0602A426 RID: 173094 RVA: 0x00BEEC50 File Offset: 0x00BECE50
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

		// Token: 0x0602A427 RID: 173095 RVA: 0x00BEECE8 File Offset: 0x00BECEE8
		private void UnBindRedDot()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotPhantomArenaCollect, base.GetItem(24), 0);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotPhantomArenaRole, base.GetItem(23), 0);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotPhantomArenaTaskReward, base.GetItem(27), 0);
		}

		// Token: 0x0602A428 RID: 173096 RVA: 0x00BEED3D File Offset: 0x00BECF3D
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

		// Token: 0x0602A429 RID: 173097 RVA: 0x00BEED67 File Offset: 0x00BECF67
		public override UUISliderComponent GetScaleSlider()
		{
			return base.GetSlider(1);
		}

		// Token: 0x0602A42A RID: 173098 RVA: 0x00BEED70 File Offset: 0x00BECF70
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

		// Token: 0x0602A42B RID: 173099 RVA: 0x00BEEE1C File Offset: 0x00BED01C
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

		// Token: 0x0602A42C RID: 173100 RVA: 0x00BEEE6F File Offset: 0x00BED06F
		private void OnZoomOut()
		{
			AudioSystem.Instance.PostEvent("play_ui_com_slider_tick");
			EventSystem.Instance.Emit<float, EMapScaleSetType>(EEventName.WorldMapZoomBtnInput, -0.1f, EMapScaleSetType.ZoomButton);
		}

		// Token: 0x0602A42D RID: 173101 RVA: 0x00BEEE97 File Offset: 0x00BED097
		private void OnZoomIn()
		{
			AudioSystem.Instance.PostEvent("play_ui_com_slider_tick");
			EventSystem.Instance.Emit<float, EMapScaleSetType>(EEventName.WorldMapZoomBtnInput, 0.1f, EMapScaleSetType.ZoomButton);
		}

		// Token: 0x0602A42E RID: 173102 RVA: 0x00BEEEBF File Offset: 0x00BED0BF
		[NullableContext(1)]
		public override bool OnClickEmpty(Vector2D clickedPosition)
		{
			if (this.IsSecondaryUiOpening)
			{
				this.CloseSecondaryUi(null, true);
			}
			return true;
		}

		// Token: 0x0602A42F RID: 173103 RVA: 0x00BEEED4 File Offset: 0x00BED0D4
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

		// Token: 0x0602A430 RID: 173104 RVA: 0x00BEEF86 File Offset: 0x00BED186
		[NullableContext(1)]
		public override bool OnClickMarks(List<MarkItem> clickedItems, Vector2D clickedPosition)
		{
			this.CloseSecondaryUi(delegate
			{
				AudioSystem.Instance.PostEvent("play_ui_ia_spl_map_click_com");
			}, true);
			return true;
		}

		// Token: 0x0602A431 RID: 173105 RVA: 0x00BEEFAF File Offset: 0x00BED1AF
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

		// Token: 0x170054E1 RID: 21729
		// (get) Token: 0x0602A432 RID: 173106 RVA: 0x00BEEFD5 File Offset: 0x00BED1D5
		private bool IsSecondaryUiOpening
		{
			get
			{
				PhantomArenaMapEntranceDetailPanel detailPanel = this.DetailPanel;
				return detailPanel == null || !detailPanel.IsUiCloseComplete;
			}
		}

		// Token: 0x0602A433 RID: 173107 RVA: 0x00BEEFEE File Offset: 0x00BED1EE
		public override bool GetIsEnableMapScale()
		{
			return !this.IsSecondaryUiOpening;
		}

		// Token: 0x0602A434 RID: 173108 RVA: 0x00BEEFF9 File Offset: 0x00BED1F9
		public override bool GetIsEnableMapCursorButton()
		{
			return !this.IsSecondaryUiOpening;
		}

		// Token: 0x0602A435 RID: 173109 RVA: 0x00BEF004 File Offset: 0x00BED204
		[NullableContext(1)]
		public override bool OnPointerDrag(Vector2D delta)
		{
			if (this.IsSecondaryUiOpening)
			{
				this.CloseSecondaryUi(null, true);
			}
			return true;
		}

		// Token: 0x0602A436 RID: 173110 RVA: 0x00BEF018 File Offset: 0x00BED218
		public override float GetDefaultMapScale()
		{
			PhantomArenaConfig instance = PhantomArenaConfig.Instance;
			PhantomBattleMapParam? phantomBattleMapParam = (instance != null) ? instance.GetPhantomBattleMapParamById(this.CurrentMapId) : null;
			return (float)((phantomBattleMapParam != null) ? phantomBattleMapParam.GetValueOrDefault().BigMapDefaultScale : 0);
		}

		// Token: 0x0602A437 RID: 173111 RVA: 0x00BEF064 File Offset: 0x00BED264
		public override float GetMaxMapScale()
		{
			PhantomArenaConfig instance = PhantomArenaConfig.Instance;
			PhantomBattleMapParam? phantomBattleMapParam = (instance != null) ? instance.GetPhantomBattleMapParamById(this.CurrentMapId) : null;
			return (float)((phantomBattleMapParam != null) ? phantomBattleMapParam.GetValueOrDefault().BigMapMaxScale : 0);
		}

		// Token: 0x0602A438 RID: 173112 RVA: 0x00BEF0B0 File Offset: 0x00BED2B0
		public override float GetMinMapScale()
		{
			PhantomArenaConfig instance = PhantomArenaConfig.Instance;
			PhantomBattleMapParam? phantomBattleMapParam = (instance != null) ? instance.GetPhantomBattleMapParamById(this.CurrentMapId) : null;
			return (float)((phantomBattleMapParam != null) ? phantomBattleMapParam.GetValueOrDefault().BigMapMinScale : 0);
		}

		// Token: 0x0602A439 RID: 173113 RVA: 0x00BEF0F9 File Offset: 0x00BED2F9
		[NullableContext(1)]
		public override EMarkType[] GetExtraMarkTypes()
		{
			return new EMarkType[]
			{
				EMarkType.PhantomArenaNpc,
				EMarkType.AreaMark
			};
		}

		// Token: 0x0602A43A RID: 173114 RVA: 0x00BEF10C File Offset: 0x00BED30C
		public override void SetOpenParam(object openParam)
		{
			this.OpenParam = openParam;
			int challengeId = ((PhantomArenaMapEntrancePanelParam)openParam).ChallengeId;
			this.CurrentMapId = this.GetMapIdByChallengeId(challengeId);
		}

		// Token: 0x04016FCF RID: 94159
		private PopupCaptionItem CaptionItem;

		// Token: 0x04016FD0 RID: 94160
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoopScrollView<PhantomArenaMapEntranceNpcListItem, int> NpcListView;

		// Token: 0x04016FD1 RID: 94161
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<PhantomArenaMapEntranceDifficultItem, int> DifficultTabLayout;

		// Token: 0x04016FD2 RID: 94162
		private PhantomArenaMapEntranceDetailPanel DetailPanel;

		// Token: 0x04016FD3 RID: 94163
		private UiSequencePlayer NpcListSequencePlayer;

		// Token: 0x04016FD4 RID: 94164
		private LongPressButton ZoomInButton;

		// Token: 0x04016FD5 RID: 94165
		private LongPressButton ZoomOutButton;

		// Token: 0x04016FD6 RID: 94166
		private int CurrentSelectedDifficult = -1;

		// Token: 0x04016FD7 RID: 94167
		private int TargetChallengeId;

		// Token: 0x04016FD8 RID: 94168
		private int CurrentSelectedChallengeId;

		// Token: 0x04016FD9 RID: 94169
		private bool IsShowNpcList;

		// Token: 0x04016FDA RID: 94170
		private UiSequencePlayer RewardBtnSequencePlayer;

		// Token: 0x04016FDB RID: 94171
		private UiSequencePlayer RightBtnRootSequencePlayer;

		// Token: 0x04016FDC RID: 94172
		private CommonDropDown<int, int> DropDown;

		// Token: 0x04016FDD RID: 94173
		[Nullable(1)]
		private readonly List<int> MapIdList = new List<int>();

		// Token: 0x04016FDE RID: 94174
		private int CurrentMapId;

		// Token: 0x02009D17 RID: 40215
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04030D71 RID: 200049
			public const int CaptionItem = 0;

			// Token: 0x04030D72 RID: 200050
			public const int ScaleSlider = 1;

			// Token: 0x04030D73 RID: 200051
			public const int ZoomIn = 2;

			// Token: 0x04030D74 RID: 200052
			public const int ZoomOut = 3;

			// Token: 0x04030D75 RID: 200053
			public const int PnlInfo = 4;

			// Token: 0x04030D76 RID: 200054
			public const int ToggleNpcList = 5;

			// Token: 0x04030D77 RID: 200055
			public const int TextLv = 6;

			// Token: 0x04030D78 RID: 200056
			public const int TextExp = 7;

			// Token: 0x04030D79 RID: 200057
			public const int TextTitle = 8;

			// Token: 0x04030D7A RID: 200058
			public const int BtnReward = 9;

			// Token: 0x04030D7B RID: 200059
			public const int TextRewardProgress = 10;

			// Token: 0x04030D7C RID: 200060
			public const int BtnMenuCard = 11;

			// Token: 0x04030D7D RID: 200061
			public const int BtnMenuRole = 12;

			// Token: 0x04030D7E RID: 200062
			public const int BtnMenuCollect = 13;

			// Token: 0x04030D7F RID: 200063
			public const int TextRewardNum = 14;

			// Token: 0x04030D80 RID: 200064
			public const int SpriteExp = 15;

			// Token: 0x04030D81 RID: 200065
			public const int RewardBtnRoot = 16;

			// Token: 0x04030D82 RID: 200066
			public const int PnlNpcList = 17;

			// Token: 0x04030D83 RID: 200067
			public const int DifficultTabList = 18;

			// Token: 0x04030D84 RID: 200068
			public const int DifficultTabItem = 19;

			// Token: 0x04030D85 RID: 200069
			public const int NpcList = 20;

			// Token: 0x04030D86 RID: 200070
			public const int NpcListItem = 21;

			// Token: 0x04030D87 RID: 200071
			public const int ItemRedDotCard = 22;

			// Token: 0x04030D88 RID: 200072
			public const int ItemRedDotRole = 23;

			// Token: 0x04030D89 RID: 200073
			public const int ItemRedDotCollect = 24;

			// Token: 0x04030D8A RID: 200074
			public const int RightButtonsRoot = 25;

			// Token: 0x04030D8B RID: 200075
			public const int ChallengeProgress = 26;

			// Token: 0x04030D8C RID: 200076
			public const int ItemRedDotTask = 27;

			// Token: 0x04030D8D RID: 200077
			public const int HomeBtnRoot = 28;

			// Token: 0x04030D8E RID: 200078
			public const int DropDownItem = 29;

			// Token: 0x04030D8F RID: 200079
			public const int DropDownRedDot = 30;
		}
	}
}
