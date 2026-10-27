using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200561E RID: 22046
	[NullableContext(2)]
	[Nullable(0)]
	public class MapRogueMainView : UiTickViewBase
	{
		// Token: 0x06038142 RID: 229698 RVA: 0x00D48758 File Offset: 0x00D46958
		[NullableContext(1)]
		public MapRogueMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038143 RID: 229699 RVA: 0x00D4878C File Offset: 0x00D4698C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUISprite)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(9, new Action(this.OnProgressBtnClick))
			};
		}

		// Token: 0x06038144 RID: 229700 RVA: 0x00D488A8 File Offset: 0x00D46AA8
		protected override UniTask OnBeforeStartAsync()
		{
			MapRogueMainView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapRogueMainView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038145 RID: 229701 RVA: 0x00D488EC File Offset: 0x00D46AEC
		protected override void OnStart()
		{
			RogueResInstGrid? insGridConfigByInstId = MapRogueConfig.Instance.GetInsGridConfigByInstId(this.GameInfo.InstanceId);
			if (insGridConfigByInstId == null)
			{
				return;
			}
			UUIText text = base.GetText(3);
			LguiUtil.Instance.SetLocalTextNew(text, insGridConfigByInstId.Value.Title, Array.Empty<object>());
			this.MoodBar.SetLimit(this.GameInfo.MoodMin, this.GameInfo.MoodMax);
			this.MoodBar.SetCurrentValue(this.GameInfo.Mood);
			this.MapModule.SetRolePos(this.GameInfo.PlayerGridIndex);
			this.MapModule.SetInteractState(false, false, null);
			this.RefreshProgress();
			this.MapMusicState.State = insGridConfigByInstId.Value.MapMusicState;
			this.RefreshTeamLv();
			this.RefreshMoodMusicState();
			this.GameInfo.BindView(this);
			this.GameInfo.SetInteractAvailable(EMapForbiddenTag.AsyncUi, false);
			if (MapRogueConfig.Instance.GetGlobalParamConfig().Value.OpenMapViewBlackScreen && !LoadingModel.Instance.IsLoading)
			{
				BlackScreenController.Instance.RemoveBlackScreen("Close", "MapRogueMainView.Create", "Default");
			}
			CustomPromise viewOpenPromise = this.GameInfo.ViewOpenPromise;
			if (viewOpenPromise == null)
			{
				return;
			}
			viewOpenPromise.SetResult();
		}

		// Token: 0x06038146 RID: 229702 RVA: 0x00D48A40 File Offset: 0x00D46C40
		protected override void OnAfterShow()
		{
			this.MapModule.MapShow();
			CustomPromise viewShowPromise = this.GameInfo.ViewShowPromise;
			if (viewShowPromise != null)
			{
				viewShowPromise.SetResult();
			}
			this.GameInfo.SetInteractAvailable(EMapForbiddenTag.AsyncUi, true);
		}

		// Token: 0x06038147 RID: 229703 RVA: 0x00D48A70 File Offset: 0x00D46C70
		protected override UniTask OnBeforeHideAsync()
		{
			MapRogueMainView.<OnBeforeHideAsync>d__14 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<MapRogueMainView.<OnBeforeHideAsync>d__14>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038148 RID: 229704 RVA: 0x00D48AB3 File Offset: 0x00D46CB3
		protected override void OnBeforeHide()
		{
			this.GameInfo.ViewShowPromise = new CustomPromise();
			this.MapModule.MapHide();
		}

		// Token: 0x06038149 RID: 229705 RVA: 0x00D48AD0 File Offset: 0x00D46CD0
		protected override void OnBeforeDestroy()
		{
			MapRogueActorPool actorPool = this.GameInfo.ActorPool;
			if (actorPool != null)
			{
				actorPool.CancelLoad();
			}
			MapRogueGameInfo gameInfo = this.GameInfo;
			if (gameInfo != null)
			{
				gameInfo.BindView(null);
			}
			this.MapMusicState.State = "none";
			this.MapMoodMusicState.State = "none";
			this.PopViewCacheForGuide = null;
		}

		// Token: 0x0603814A RID: 229706 RVA: 0x00D48B2C File Offset: 0x00D46D2C
		protected override void OnAfterDestroy()
		{
			MapRogueGameInfo gameInfo = this.GameInfo;
			if (gameInfo != null && gameInfo.EnterBattleFlag)
			{
				this.GameInfo.EnterBattleFlag = false;
				BlackScreenController.Instance.RemoveBlackScreen("Close", "MapRogueMainView.BattleClose", "Default");
			}
		}

		// Token: 0x0603814B RID: 229707 RVA: 0x00D48B67 File Offset: 0x00D46D67
		protected override void OnTick(float delta)
		{
			this.GameInfo.OnTick(delta);
			MapRogueMapModule mapModule = this.MapModule;
			if (mapModule == null)
			{
				return;
			}
			mapModule.OnTick(delta);
		}

		// Token: 0x0603814C RID: 229708 RVA: 0x00D48B86 File Offset: 0x00D46D86
		public void ChangeGameStagePerformance(EMapRogueGameStage lastStage, EMapRogueGameStage curStage)
		{
		}

		// Token: 0x0603814D RID: 229709 RVA: 0x00D48B88 File Offset: 0x00D46D88
		private UniTask InitMapModule()
		{
			MapRogueMainView.<InitMapModule>d__20 <InitMapModule>d__;
			<InitMapModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMapModule>d__.<>4__this = this;
			<InitMapModule>d__.<>1__state = -1;
			<InitMapModule>d__.<>t__builder.Start<MapRogueMainView.<InitMapModule>d__20>(ref <InitMapModule>d__);
			return <InitMapModule>d__.<>t__builder.Task;
		}

		// Token: 0x0603814E RID: 229710 RVA: 0x00D48BCC File Offset: 0x00D46DCC
		private UniTask InitCaption()
		{
			MapRogueMainView.<InitCaption>d__21 <InitCaption>d__;
			<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaption>d__.<>4__this = this;
			<InitCaption>d__.<>1__state = -1;
			<InitCaption>d__.<>t__builder.Start<MapRogueMainView.<InitCaption>d__21>(ref <InitCaption>d__);
			return <InitCaption>d__.<>t__builder.Task;
		}

		// Token: 0x0603814F RID: 229711 RVA: 0x00D48C10 File Offset: 0x00D46E10
		private UniTask InitPanelLv()
		{
			MapRogueMainView.<InitPanelLv>d__22 <InitPanelLv>d__;
			<InitPanelLv>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPanelLv>d__.<>4__this = this;
			<InitPanelLv>d__.<>1__state = -1;
			<InitPanelLv>d__.<>t__builder.Start<MapRogueMainView.<InitPanelLv>d__22>(ref <InitPanelLv>d__);
			return <InitPanelLv>d__.<>t__builder.Task;
		}

		// Token: 0x06038150 RID: 229712 RVA: 0x00D48C54 File Offset: 0x00D46E54
		private UniTask InitPanelFetter()
		{
			MapRogueMainView.<InitPanelFetter>d__23 <InitPanelFetter>d__;
			<InitPanelFetter>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPanelFetter>d__.<>4__this = this;
			<InitPanelFetter>d__.<>1__state = -1;
			<InitPanelFetter>d__.<>t__builder.Start<MapRogueMainView.<InitPanelFetter>d__23>(ref <InitPanelFetter>d__);
			return <InitPanelFetter>d__.<>t__builder.Task;
		}

		// Token: 0x06038151 RID: 229713 RVA: 0x00D48C98 File Offset: 0x00D46E98
		private UniTask InitMoodBar()
		{
			MapRogueMainView.<InitMoodBar>d__24 <InitMoodBar>d__;
			<InitMoodBar>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMoodBar>d__.<>4__this = this;
			<InitMoodBar>d__.<>1__state = -1;
			<InitMoodBar>d__.<>t__builder.Start<MapRogueMainView.<InitMoodBar>d__24>(ref <InitMoodBar>d__);
			return <InitMoodBar>d__.<>t__builder.Task;
		}

		// Token: 0x06038152 RID: 229714 RVA: 0x00D48CDC File Offset: 0x00D46EDC
		private UniTask InitTipsItem()
		{
			MapRogueMainView.<InitTipsItem>d__25 <InitTipsItem>d__;
			<InitTipsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTipsItem>d__.<>4__this = this;
			<InitTipsItem>d__.<>1__state = -1;
			<InitTipsItem>d__.<>t__builder.Start<MapRogueMainView.<InitTipsItem>d__25>(ref <InitTipsItem>d__);
			return <InitTipsItem>d__.<>t__builder.Task;
		}

		// Token: 0x06038153 RID: 229715 RVA: 0x00D48D1F File Offset: 0x00D46F1F
		private bool CheckCanOpenMenu()
		{
			return this.GameInfo.CanInteract;
		}

		// Token: 0x06038154 RID: 229716 RVA: 0x00D48D2C File Offset: 0x00D46F2C
		private void OnBackBtnClick()
		{
			MapRogueController.Instance.OpenExploreEnd(false);
		}

		// Token: 0x06038155 RID: 229717 RVA: 0x00D48D39 File Offset: 0x00D46F39
		private void OnHelpBtnClick()
		{
			MapRogueController.Instance.OpenMapHelpView();
		}

		// Token: 0x06038156 RID: 229718 RVA: 0x00D48D45 File Offset: 0x00D46F45
		private void OnProgressBtnClick()
		{
			MapRogueController.Instance.OpenExplore();
		}

		// Token: 0x06038157 RID: 229719 RVA: 0x00D48D54 File Offset: 0x00D46F54
		public void RefreshProgress()
		{
			int num = this.GameInfo.ExplorationCurrentProgress();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "RogueResExplore_3", new <>z__ReadOnlySingleElementList<object>(num));
		}

		// Token: 0x06038158 RID: 229720 RVA: 0x00D48D90 File Offset: 0x00D46F90
		public void SetInteractAvailable(bool bAvailable)
		{
			MapRogueMapModule mapModule = this.MapModule;
			if (mapModule != null)
			{
				mapModule.SetInteractAvailable(bAvailable);
			}
			MapRogueMapModule mapModule2 = this.MapModule;
			if (mapModule2 == null)
			{
				return;
			}
			mapModule2.SetInteractState(false, false, null);
		}

		// Token: 0x06038159 RID: 229721 RVA: 0x00D48DCA File Offset: 0x00D46FCA
		public void RefreshTeamLv()
		{
			MapRoguePanelLv panelLv = this.PanelLv;
			if (panelLv == null)
			{
				return;
			}
			panelLv.SetLv(this.GameInfo.TeamLv, false);
		}

		// Token: 0x0603815A RID: 229722 RVA: 0x00D48DE8 File Offset: 0x00D46FE8
		public void SetTipsItem(bool bVisible, string textId = null)
		{
			if (textId != null)
			{
				MapRogueFloatTipsItem tipsItem = this.TipsItem;
				if (tipsItem != null)
				{
					tipsItem.SetText(textId);
				}
			}
			MapRogueFloatTipsItem tipsItem2 = this.TipsItem;
			if (tipsItem2 == null)
			{
				return;
			}
			tipsItem2.SetActive(bVisible);
		}

		// Token: 0x0603815B RID: 229723 RVA: 0x00D48E10 File Offset: 0x00D47010
		[NullableContext(1)]
		public UniTask OpenPopupView(MapGridData gridData)
		{
			MapRogueMainView.<OpenPopupView>d__34 <OpenPopupView>d__;
			<OpenPopupView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenPopupView>d__.<>4__this = this;
			<OpenPopupView>d__.gridData = gridData;
			<OpenPopupView>d__.<>1__state = -1;
			<OpenPopupView>d__.<>t__builder.Start<MapRogueMainView.<OpenPopupView>d__34>(ref <OpenPopupView>d__);
			return <OpenPopupView>d__.<>t__builder.Task;
		}

		// Token: 0x0603815C RID: 229724 RVA: 0x00D48E5C File Offset: 0x00D4705C
		public void RefreshMoodMusicState()
		{
			RogueResMoodRule? moodRuleById = MapRogueConfig.Instance.GetMoodRuleById(this.GameInfo.MoodRuleId);
			if (moodRuleById != null && !StringUtils.IsEmpty(moodRuleById.Value.MapMusicStateSwitch))
			{
				this.MapMoodMusicState.State = moodRuleById.Value.MapMusicStateSwitch;
			}
		}

		// Token: 0x0603815D RID: 229725 RVA: 0x00D48EB8 File Offset: 0x00D470B8
		[NullableContext(1)]
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
			if (a == "Mood")
			{
				MapRogueMoodBar moodBar = this.MoodBar;
				if (moodBar == null)
				{
					return null;
				}
				return moodBar.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
			else if (a == "MapRougeGrid")
			{
				MapRogueMapModule mapModule = this.MapModule;
				if (mapModule == null)
				{
					return null;
				}
				return mapModule.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
			else
			{
				GridPopupView popViewCacheForGuide = this.PopViewCacheForGuide;
				if (popViewCacheForGuide == null)
				{
					return null;
				}
				return popViewCacheForGuide.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
		}

		// Token: 0x0401D7E3 RID: 120803
		public MapRogueMapModule MapModule;

		// Token: 0x0401D7E4 RID: 120804
		public MapRogueMoodBar MoodBar;

		// Token: 0x0401D7E5 RID: 120805
		protected PopupCaptionItem CaptionItem;

		// Token: 0x0401D7E6 RID: 120806
		protected MapRoguePanelLv PanelLv;

		// Token: 0x0401D7E7 RID: 120807
		protected MapRoguePanelFetter PanelFetter;

		// Token: 0x0401D7E8 RID: 120808
		protected MapRogueFloatTipsItem TipsItem;

		// Token: 0x0401D7E9 RID: 120809
		[Nullable(1)]
		protected MapRogueGameInfo GameInfo;

		// Token: 0x0401D7EA RID: 120810
		private GridPopupView PopViewCacheForGuide;

		// Token: 0x0401D7EB RID: 120811
		[Nullable(1)]
		private const string STATE_NONE = "none";

		// Token: 0x0401D7EC RID: 120812
		[Nullable(1)]
		private readonly StateRef MapMusicState = new StateRef("game_maprogue_map_type", "none");

		// Token: 0x0401D7ED RID: 120813
		[Nullable(1)]
		private readonly StateRef MapMoodMusicState = new StateRef("game_maprogue_map_vibe", "none");
	}
}
