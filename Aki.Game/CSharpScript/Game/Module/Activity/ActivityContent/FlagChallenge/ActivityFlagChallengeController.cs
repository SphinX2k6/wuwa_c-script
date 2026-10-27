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
	// Token: 0x02006576 RID: 25974
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityFlagChallengeController : ActivityControllerBase
	{
		// Token: 0x06041191 RID: 266641 RVA: 0x00FC7084 File Offset: 0x00FC5284
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		}

		// Token: 0x06041192 RID: 266642 RVA: 0x00FC70A2 File Offset: 0x00FC52A2
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		}

		// Token: 0x06041193 RID: 266643 RVA: 0x00FC70C0 File Offset: 0x00FC52C0
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

		// Token: 0x06041194 RID: 266644 RVA: 0x00FC710C File Offset: 0x00FC530C
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

		// Token: 0x06041195 RID: 266645 RVA: 0x00FC7158 File Offset: 0x00FC5358
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_FlagChallengeMain";
		}

		// Token: 0x06041196 RID: 266646 RVA: 0x00FC715F File Offset: 0x00FC535F
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivityFlagChallengeSubView();
		}

		// Token: 0x06041197 RID: 266647 RVA: 0x00FC7166 File Offset: 0x00FC5366
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.Data = new ActivityFlagChallengeData();
			return this.Data;
		}

		// Token: 0x06041198 RID: 266648 RVA: 0x00FC717C File Offset: 0x00FC537C
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

		// Token: 0x06041199 RID: 266649 RVA: 0x00FC71F4 File Offset: 0x00FC53F4
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

		// Token: 0x0604119A RID: 266650 RVA: 0x00FC722C File Offset: 0x00FC542C
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

		// Token: 0x1700954B RID: 38219
		// (get) Token: 0x0604119B RID: 266651 RVA: 0x00FC7262 File Offset: 0x00FC5462
		public static ActivityFlagChallengeController Instance
		{
			get
			{
				return ActivityFlagChallengeController._Instance;
			}
		}

		// Token: 0x0604119C RID: 266652 RVA: 0x00FC7269 File Offset: 0x00FC5469
		public static ActivityFlagChallengeController GetOrCreateInstance()
		{
			if (ActivityFlagChallengeController._Instance == null)
			{
				ActivityFlagChallengeController.CreateInstance();
			}
			return ActivityFlagChallengeController._Instance;
		}

		// Token: 0x0604119D RID: 266653 RVA: 0x00FC727D File Offset: 0x00FC547D
		public static bool CreateInstance()
		{
			if (ActivityFlagChallengeController._Instance != null)
			{
				return true;
			}
			ActivityFlagChallengeController._Instance = new ActivityFlagChallengeController();
			return true;
		}

		// Token: 0x0604119E RID: 266654 RVA: 0x00FC7293 File Offset: 0x00FC5493
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604119F RID: 266655 RVA: 0x00FC7295 File Offset: 0x00FC5495
		public static void ResetStaticDefaultValue()
		{
			ActivityFlagChallengeController._Instance = null;
		}

		// Token: 0x060411A0 RID: 266656 RVA: 0x00FC729D File Offset: 0x00FC549D
		static ActivityFlagChallengeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityFlagChallengeController.CreateStaticDefaultValue), new Action(ActivityFlagChallengeController.ResetStaticDefaultValue));
		}

		// Token: 0x04021EAF RID: 138927
		[Nullable(2)]
		public ActivityFlagChallengeData Data;

		// Token: 0x04021EB0 RID: 138928
		[Nullable(2)]
		private static ActivityFlagChallengeController _Instance;
	}
}
