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
	// Token: 0x020045F4 RID: 17908
	[NullableContext(2)]
	[Nullable(0)]
	public class MapRogueMainView : UiTickViewBase
	{
		// Token: 0x0602D040 RID: 184384 RVA: 0x00C964A0 File Offset: 0x00C946A0
		[NullableContext(1)]
		public MapRogueMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602D041 RID: 184385 RVA: 0x00C964D4 File Offset: 0x00C946D4
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

		// Token: 0x0602D042 RID: 184386 RVA: 0x00C965F0 File Offset: 0x00C947F0
		protected override UniTask OnBeforeStartAsync()
		{
			MapRogueMainView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapRogueMainView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D043 RID: 184387 RVA: 0x00C96634 File Offset: 0x00C94834
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

		// Token: 0x0602D044 RID: 184388 RVA: 0x00C96788 File Offset: 0x00C94988
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

		// Token: 0x0602D045 RID: 184389 RVA: 0x00C967B8 File Offset: 0x00C949B8
		protected override UniTask OnBeforeHideAsync()
		{
			MapRogueMainView.<OnBeforeHideAsync>d__14 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<MapRogueMainView.<OnBeforeHideAsync>d__14>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D046 RID: 184390 RVA: 0x00C967FB File Offset: 0x00C949FB
		protected override void OnBeforeHide()
		{
			this.GameInfo.ViewShowPromise = new CustomPromise();
			this.MapModule.MapHide();
		}

		// Token: 0x0602D047 RID: 184391 RVA: 0x00C96818 File Offset: 0x00C94A18
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

		// Token: 0x0602D048 RID: 184392 RVA: 0x00C96874 File Offset: 0x00C94A74
		protected override void OnAfterDestroy()
		{
			MapRogueGameInfo gameInfo = this.GameInfo;
			if (gameInfo != null && gameInfo.EnterBattleFlag)
			{
				this.GameInfo.EnterBattleFlag = false;
				BlackScreenController.Instance.RemoveBlackScreen("Close", "MapRogueMainView.BattleClose", "Default");
			}
		}

		// Token: 0x0602D049 RID: 184393 RVA: 0x00C968AF File Offset: 0x00C94AAF
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

		// Token: 0x0602D04A RID: 184394 RVA: 0x00C968CE File Offset: 0x00C94ACE
		public void ChangeGameStagePerformance(EMapRogueGameStage lastStage, EMapRogueGameStage curStage)
		{
		}

		// Token: 0x0602D04B RID: 184395 RVA: 0x00C968D0 File Offset: 0x00C94AD0
		private UniTask InitMapModule()
		{
			MapRogueMainView.<InitMapModule>d__20 <InitMapModule>d__;
			<InitMapModule>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMapModule>d__.<>4__this = this;
			<InitMapModule>d__.<>1__state = -1;
			<InitMapModule>d__.<>t__builder.Start<MapRogueMainView.<InitMapModule>d__20>(ref <InitMapModule>d__);
			return <InitMapModule>d__.<>t__builder.Task;
		}

		// Token: 0x0602D04C RID: 184396 RVA: 0x00C96914 File Offset: 0x00C94B14
		private UniTask InitCaption()
		{
			MapRogueMainView.<InitCaption>d__21 <InitCaption>d__;
			<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaption>d__.<>4__this = this;
			<InitCaption>d__.<>1__state = -1;
			<InitCaption>d__.<>t__builder.Start<MapRogueMainView.<InitCaption>d__21>(ref <InitCaption>d__);
			return <InitCaption>d__.<>t__builder.Task;
		}

		// Token: 0x0602D04D RID: 184397 RVA: 0x00C96958 File Offset: 0x00C94B58
		private UniTask InitPanelLv()
		{
			MapRogueMainView.<InitPanelLv>d__22 <InitPanelLv>d__;
			<InitPanelLv>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPanelLv>d__.<>4__this = this;
			<InitPanelLv>d__.<>1__state = -1;
			<InitPanelLv>d__.<>t__builder.Start<MapRogueMainView.<InitPanelLv>d__22>(ref <InitPanelLv>d__);
			return <InitPanelLv>d__.<>t__builder.Task;
		}

		// Token: 0x0602D04E RID: 184398 RVA: 0x00C9699C File Offset: 0x00C94B9C
		private UniTask InitPanelFetter()
		{
			MapRogueMainView.<InitPanelFetter>d__23 <InitPanelFetter>d__;
			<InitPanelFetter>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPanelFetter>d__.<>4__this = this;
			<InitPanelFetter>d__.<>1__state = -1;
			<InitPanelFetter>d__.<>t__builder.Start<MapRogueMainView.<InitPanelFetter>d__23>(ref <InitPanelFetter>d__);
			return <InitPanelFetter>d__.<>t__builder.Task;
		}

		// Token: 0x0602D04F RID: 184399 RVA: 0x00C969E0 File Offset: 0x00C94BE0
		private UniTask InitMoodBar()
		{
			MapRogueMainView.<InitMoodBar>d__24 <InitMoodBar>d__;
			<InitMoodBar>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMoodBar>d__.<>4__this = this;
			<InitMoodBar>d__.<>1__state = -1;
			<InitMoodBar>d__.<>t__builder.Start<MapRogueMainView.<InitMoodBar>d__24>(ref <InitMoodBar>d__);
			return <InitMoodBar>d__.<>t__builder.Task;
		}

		// Token: 0x0602D050 RID: 184400 RVA: 0x00C96A24 File Offset: 0x00C94C24
		private UniTask InitTipsItem()
		{
			MapRogueMainView.<InitTipsItem>d__25 <InitTipsItem>d__;
			<InitTipsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTipsItem>d__.<>4__this = this;
			<InitTipsItem>d__.<>1__state = -1;
			<InitTipsItem>d__.<>t__builder.Start<MapRogueMainView.<InitTipsItem>d__25>(ref <InitTipsItem>d__);
			return <InitTipsItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602D051 RID: 184401 RVA: 0x00C96A67 File Offset: 0x00C94C67
		private bool CheckCanOpenMenu()
		{
			return this.GameInfo.CanInteract;
		}

		// Token: 0x0602D052 RID: 184402 RVA: 0x00C96A74 File Offset: 0x00C94C74
		private void OnBackBtnClick()
		{
			MapRogueController.Instance.OpenExploreEnd(false);
		}

		// Token: 0x0602D053 RID: 184403 RVA: 0x00C96A81 File Offset: 0x00C94C81
		private void OnHelpBtnClick()
		{
			MapRogueController.Instance.OpenMapHelpView();
		}

		// Token: 0x0602D054 RID: 184404 RVA: 0x00C96A8D File Offset: 0x00C94C8D
		private void OnProgressBtnClick()
		{
			MapRogueController.Instance.OpenExplore();
		}

		// Token: 0x0602D055 RID: 184405 RVA: 0x00C96A9C File Offset: 0x00C94C9C
		public void RefreshProgress()
		{
			int num = this.GameInfo.ExplorationCurrentProgress();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "RogueResExplore_3", new <>z__ReadOnlySingleElementList<object>(num));
		}

		// Token: 0x0602D056 RID: 184406 RVA: 0x00C96AD8 File Offset: 0x00C94CD8
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

		// Token: 0x0602D057 RID: 184407 RVA: 0x00C96B12 File Offset: 0x00C94D12
		public void RefreshTeamLv()
		{
			MapRoguePanelLv panelLv = this.PanelLv;
			if (panelLv == null)
			{
				return;
			}
			panelLv.SetLv(this.GameInfo.TeamLv, false);
		}

		// Token: 0x0602D058 RID: 184408 RVA: 0x00C96B30 File Offset: 0x00C94D30
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

		// Token: 0x0602D059 RID: 184409 RVA: 0x00C96B58 File Offset: 0x00C94D58
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

		// Token: 0x0602D05A RID: 184410 RVA: 0x00C96BA4 File Offset: 0x00C94DA4
		public void RefreshMoodMusicState()
		{
			RogueResMoodRule? moodRuleById = MapRogueConfig.Instance.GetMoodRuleById(this.GameInfo.MoodRuleId);
			if (moodRuleById != null && !StringUtils.IsEmpty(moodRuleById.Value.MapMusicStateSwitch))
			{
				this.MapMoodMusicState.State = moodRuleById.Value.MapMusicStateSwitch;
			}
		}

		// Token: 0x0602D05B RID: 184411 RVA: 0x00C96C00 File Offset: 0x00C94E00
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

		// Token: 0x0401826E RID: 98926
		public MapRogueMapModule MapModule;

		// Token: 0x0401826F RID: 98927
		public MapRogueMoodBar MoodBar;

		// Token: 0x04018270 RID: 98928
		protected PopupCaptionItem CaptionItem;

		// Token: 0x04018271 RID: 98929
		protected MapRoguePanelLv PanelLv;

		// Token: 0x04018272 RID: 98930
		protected MapRoguePanelFetter PanelFetter;

		// Token: 0x04018273 RID: 98931
		protected MapRogueFloatTipsItem TipsItem;

		// Token: 0x04018274 RID: 98932
		[Nullable(1)]
		protected MapRogueGameInfo GameInfo;

		// Token: 0x04018275 RID: 98933
		private GridPopupView PopViewCacheForGuide;

		// Token: 0x04018276 RID: 98934
		[Nullable(1)]
		private const string STATE_NONE = "none";

		// Token: 0x04018277 RID: 98935
		[Nullable(1)]
		private readonly StateRef MapMusicState = new StateRef("game_maprogue_map_type", "none");

		// Token: 0x04018278 RID: 98936
		[Nullable(1)]
		private readonly StateRef MapMoodMusicState = new StateRef("game_maprogue_map_vibe", "none");
	}
}
