using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.FlagChallenge;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FlagChallenge
{
	// Token: 0x020054F4 RID: 21748
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityFlagChallengeController : ActivityControllerBase
	{
		// Token: 0x06035E56 RID: 220758 RVA: 0x00F0E068 File Offset: 0x00F0C268
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		}

		// Token: 0x06035E57 RID: 220759 RVA: 0x00F0E086 File Offset: 0x00F0C286
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		}

		// Token: 0x06035E58 RID: 220760 RVA: 0x00F0E0A4 File Offset: 0x00F0C2A4
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
		{
			ActivityFlagChallengeController.<OnOpenSubView>d__3 <OnOpenSubView>d__;
			<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnOpenSubView>d__.<>4__this = this;
			<OnOpenSubView>d__.viewName = viewName;
			<OnOpenSubView>d__.<>1__state = -1;
			<OnOpenSubView>d__.<>t__builder.Start<ActivityFlagChallengeController.<OnOpenSubView>d__3>(ref <OnOpenSubView>d__);
			return <OnOpenSubView>d__.<>t__builder.Task;
		}

		// Token: 0x06035E59 RID: 220761 RVA: 0x00F0E0F0 File Offset: 0x00F0C2F0
		protected override void OnOpenView(ActivityBaseData data)
		{
			if (!data.GetPreGuideQuestFinishState())
			{
				int unFinishPreGuideQuestId = data.GetUnFinishPreGuideQuestId();
				UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				return;
			}
			FlagChallengeController.Instance.OpenFlagChallengeMainView(data.Id, null);
		}

		// Token: 0x06035E5A RID: 220762 RVA: 0x00F0E13C File Offset: 0x00F0C33C
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_FlagChallengeMain";
		}

		// Token: 0x06035E5B RID: 220763 RVA: 0x00F0E143 File Offset: 0x00F0C343
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivityFlagChallengeSubView();
		}

		// Token: 0x06035E5C RID: 220764 RVA: 0x00F0E14A File Offset: 0x00F0C34A
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.Data = new ActivityFlagChallengeData();
			return this.Data;
		}

		// Token: 0x06035E5D RID: 220765 RVA: 0x00F0E160 File Offset: 0x00F0C360
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			foreach (EUiViewName viewName in new List<EUiViewName>
			{
				EUiViewName.FlagChallengeMainView,
				EUiViewName.FlagChallengeAreaDetailView
			})
			{
				if (UiManager.Instance.IsViewOpen(viewName))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06035E5E RID: 220766 RVA: 0x00F0E1D8 File Offset: 0x00F0C3D8
		private void OnWorldDone()
		{
			if (!FlagChallengeBattleModel.Instance.IsNeedShowMainView)
			{
				return;
			}
			FlagChallengeBattleModel.Instance.IsNeedShowMainView = false;
			if (this.Data == null || this.Data.CheckIfClose())
			{
				return;
			}
			this.AddMainViewSplashTask();
		}

		// Token: 0x06035E5F RID: 220767 RVA: 0x00F0E210 File Offset: 0x00F0C410
		private void AddMainViewSplashTask()
		{
			if (this.Data == null)
			{
				return;
			}
			SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.None, ESplashScreenType.Other, delegate()
			{
				FlagChallengeController.Instance.OpenFlagChallengeMainView(this.Data.Id, null);
			});
			SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, false);
		}

		// Token: 0x170068AD RID: 26797
		// (get) Token: 0x06035E60 RID: 220768 RVA: 0x00F0E246 File Offset: 0x00F0C446
		public static ActivityFlagChallengeController Instance
		{
			get
			{
				return ActivityFlagChallengeController._Instance;
			}
		}

		// Token: 0x06035E61 RID: 220769 RVA: 0x00F0E24D File Offset: 0x00F0C44D
		public static ActivityFlagChallengeController GetOrCreateInstance()
		{
			if (ActivityFlagChallengeController._Instance == null)
			{
				ActivityFlagChallengeController.CreateInstance();
			}
			return ActivityFlagChallengeController._Instance;
		}

		// Token: 0x06035E62 RID: 220770 RVA: 0x00F0E261 File Offset: 0x00F0C461
		public static bool CreateInstance()
		{
			if (ActivityFlagChallengeController._Instance != null)
			{
				return true;
			}
			ActivityFlagChallengeController._Instance = new ActivityFlagChallengeController();
			return true;
		}

		// Token: 0x06035E63 RID: 220771 RVA: 0x00F0E277 File Offset: 0x00F0C477
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06035E64 RID: 220772 RVA: 0x00F0E279 File Offset: 0x00F0C479
		public static void ResetStaticDefaultValue()
		{
			ActivityFlagChallengeController._Instance = null;
		}

		// Token: 0x06035E65 RID: 220773 RVA: 0x00F0E281 File Offset: 0x00F0C481
		static ActivityFlagChallengeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityFlagChallengeController.CreateStaticDefaultValue), new Action(ActivityFlagChallengeController.ResetStaticDefaultValue));
		}

		// Token: 0x0401C7E0 RID: 116704
		[Nullable(2)]
		public ActivityFlagChallengeData Data;

		// Token: 0x0401C7E1 RID: 116705
		[Nullable(2)]
		private static ActivityFlagChallengeController _Instance;
	}
}
