using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PreWarm
{
	// Token: 0x02005234 RID: 21044
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityPreWarmController : ActivityControllerBase
	{
		// Token: 0x0603459E RID: 214430 RVA: 0x00EA62A6 File Offset: 0x00EA44A6
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x0603459F RID: 214431 RVA: 0x00EA62C4 File Offset: 0x00EA44C4
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x060345A0 RID: 214432 RVA: 0x00EA62E4 File Offset: 0x00EA44E4
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

		// Token: 0x060345A1 RID: 214433 RVA: 0x00EA633E File Offset: 0x00EA453E
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x060345A2 RID: 214434 RVA: 0x00EA6340 File Offset: 0x00EA4540
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

		// Token: 0x060345A3 RID: 214435 RVA: 0x00EA6407 File Offset: 0x00EA4607
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_PreheatActivityMain";
		}

		// Token: 0x060345A4 RID: 214436 RVA: 0x00EA640E File Offset: 0x00EA460E
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewPreWarm();
		}

		// Token: 0x060345A5 RID: 214437 RVA: 0x00EA6415 File Offset: 0x00EA4615
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.Data = new ActivityPreWarmData();
			return this.Data;
		}

		// Token: 0x060345A6 RID: 214438 RVA: 0x00EA6428 File Offset: 0x00EA4628
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x170065D3 RID: 26067
		// (get) Token: 0x060345A7 RID: 214439 RVA: 0x00EA642B File Offset: 0x00EA462B
		public static ActivityPreWarmController Instance
		{
			get
			{
				return ActivityPreWarmController._Instance;
			}
		}

		// Token: 0x060345A8 RID: 214440 RVA: 0x00EA6432 File Offset: 0x00EA4632
		public static ActivityPreWarmController GetOrCreateInstance()
		{
			if (ActivityPreWarmController._Instance == null)
			{
				ActivityPreWarmController.CreateInstance();
			}
			return ActivityPreWarmController._Instance;
		}

		// Token: 0x060345A9 RID: 214441 RVA: 0x00EA6446 File Offset: 0x00EA4646
		public static bool CreateInstance()
		{
			if (ActivityPreWarmController._Instance != null)
			{
				return true;
			}
			ActivityPreWarmController._Instance = new ActivityPreWarmController();
			return true;
		}

		// Token: 0x060345AA RID: 214442 RVA: 0x00EA645C File Offset: 0x00EA465C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060345AB RID: 214443 RVA: 0x00EA645E File Offset: 0x00EA465E
		public static void ResetStaticDefaultValue()
		{
			ActivityPreWarmController._Instance = null;
		}

		// Token: 0x060345AC RID: 214444 RVA: 0x00EA6466 File Offset: 0x00EA4666
		static ActivityPreWarmController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityPreWarmController.CreateStaticDefaultValue), new Action(ActivityPreWarmController.ResetStaticDefaultValue));
		}

		// Token: 0x0401BCFC RID: 113916
		[Nullable(2)]
		public ActivityPreWarmData Data;

		// Token: 0x0401BCFD RID: 113917
		[Nullable(2)]
		private static ActivityPreWarmController _Instance;
	}
}
