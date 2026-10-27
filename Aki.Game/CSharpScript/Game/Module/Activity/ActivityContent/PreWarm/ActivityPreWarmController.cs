using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PreWarm
{
	// Token: 0x020062B6 RID: 25270
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityPreWarmController : ActivityControllerBase
	{
		// Token: 0x0603F8DD RID: 260317 RVA: 0x00F5F34A File Offset: 0x00F5D54A
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x0603F8DE RID: 260318 RVA: 0x00F5F368 File Offset: 0x00F5D568
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x0603F8DF RID: 260319 RVA: 0x00F5F388 File Offset: 0x00F5D588
		private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason reason)
		{
			if (!ActivityPreWarmModel.Instance.IsHasQuest(questId))
			{
				return;
			}
			if (this.Data == null)
			{
				return;
			}
			EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, this.Data.Id);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.Data.Id);
		}

		// Token: 0x0603F8E0 RID: 260320 RVA: 0x00F5F3E2 File Offset: 0x00F5D5E2
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x0603F8E1 RID: 260321 RVA: 0x00F5F3E4 File Offset: 0x00F5D5E4
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
		{
			ActivityPreWarmModel instance = ActivityPreWarmModel.Instance;
			int? num = (instance != null) ? instance.GetProgressId() : null;
			if (num == null)
			{
				Log.Instance.Error(ELogModule.ActivityPreWarm, ELogAuthor.CB, "找不到当前正在进行的id", default(ReadOnlySpan<ValueTuple<string, object>>));
				return UniTask.FromResult<bool>(false);
			}
			IActivityPreWarmParam activityPreWarmParam = new IActivityPreWarmParam();
			activityPreWarmParam.Id = num.Value;
			activityPreWarmParam.IsParsing = true;
			ActivityPreWarmData data = this.Data;
			activityPreWarmParam.ActivityId = ((data != null) ? new int?(data.Id) : null);
			IActivityPreWarmParam param = activityPreWarmParam;
			UiManager.Instance.OpenView(viewName, param, null);
			Log.Instance.Info(ELogModule.ActivityPreWarm, ELogAuthor.CB, "打开预热活动界面（解析）", default(ReadOnlySpan<ValueTuple<string, object>>));
			return UniTask.FromResult<bool>(true);
		}

		// Token: 0x0603F8E2 RID: 260322 RVA: 0x00F5F4AB File Offset: 0x00F5D6AB
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_PreheatActivityMain";
		}

		// Token: 0x0603F8E3 RID: 260323 RVA: 0x00F5F4B2 File Offset: 0x00F5D6B2
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewPreWarm();
		}

		// Token: 0x0603F8E4 RID: 260324 RVA: 0x00F5F4B9 File Offset: 0x00F5D6B9
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.Data = new ActivityPreWarmData();
			return this.Data;
		}

		// Token: 0x0603F8E5 RID: 260325 RVA: 0x00F5F4CC File Offset: 0x00F5D6CC
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x17009271 RID: 37489
		// (get) Token: 0x0603F8E6 RID: 260326 RVA: 0x00F5F4CF File Offset: 0x00F5D6CF
		public static ActivityPreWarmController Instance
		{
			get
			{
				return ActivityPreWarmController._Instance;
			}
		}

		// Token: 0x0603F8E7 RID: 260327 RVA: 0x00F5F4D6 File Offset: 0x00F5D6D6
		public static ActivityPreWarmController GetOrCreateInstance()
		{
			if (ActivityPreWarmController._Instance == null)
			{
				ActivityPreWarmController.CreateInstance();
			}
			return ActivityPreWarmController._Instance;
		}

		// Token: 0x0603F8E8 RID: 260328 RVA: 0x00F5F4EA File Offset: 0x00F5D6EA
		public static bool CreateInstance()
		{
			if (ActivityPreWarmController._Instance != null)
			{
				return true;
			}
			ActivityPreWarmController._Instance = new ActivityPreWarmController();
			return true;
		}

		// Token: 0x0603F8E9 RID: 260329 RVA: 0x00F5F500 File Offset: 0x00F5D700
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603F8EA RID: 260330 RVA: 0x00F5F502 File Offset: 0x00F5D702
		public static void ResetStaticDefaultValue()
		{
			ActivityPreWarmController._Instance = null;
		}

		// Token: 0x0603F8EB RID: 260331 RVA: 0x00F5F50A File Offset: 0x00F5D70A
		static ActivityPreWarmController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityPreWarmController.CreateStaticDefaultValue), new Action(ActivityPreWarmController.ResetStaticDefaultValue));
		}

		// Token: 0x040213CD RID: 136141
		[Nullable(2)]
		public ActivityPreWarmData Data;

		// Token: 0x040213CE RID: 136142
		[Nullable(2)]
		private static ActivityPreWarmController _Instance;
	}
}
