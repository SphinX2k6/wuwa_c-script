using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.SolarSchool;
using UnrealEngine;

namespace CSharpScript.Game.Module.ActivityAction
{
	// Token: 0x02005A99 RID: 23193
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ActivityActionModel : ModelBase
	{
		// Token: 0x17006CD3 RID: 27859
		// (get) Token: 0x0603928D RID: 234125 RVA: 0x01001A68 File Offset: 0x00FFFC68
		public int HandlerCount
		{
			get
			{
				return this.Handlers.Count + this.PendingAdd.Count;
			}
		}

		// Token: 0x17006CD4 RID: 27860
		// (get) Token: 0x0603928E RID: 234126 RVA: 0x01001A81 File Offset: 0x00FFFC81
		public bool IsTicking
		{
			get
			{
				return this.TickerId != -1;
			}
		}

		// Token: 0x0603928F RID: 234127 RVA: 0x01001A90 File Offset: 0x00FFFC90
		protected override bool OnInit()
		{
			ActivityActionModel.RegisterAll();
			if (!this.IsTicking)
			{
				Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.Tick), "ActivityActionModel", ETickingGroup.TG_PrePhysics, true, 0, false);
				if (ticker != null)
				{
					this.TickerId = ticker.Id;
				}
			}
			return true;
		}

		// Token: 0x06039290 RID: 234128 RVA: 0x01001ADC File Offset: 0x00FFFCDC
		private static void RegisterAll()
		{
			ActivityActionFactory instance = ActivityActionFactory.Instance;
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolAvg, () => new SolarSchoolAvgAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolReward, () => new SolarSchoolRewardAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolBehavior, () => new SolarSchoolBehaviorAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolEventCheck, () => new SolarSchoolEventCheckGameplay());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolAffairs, () => new SolarSchoolAffairsGameplay());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolLetter, () => new SolarSchoolLetterGameplay());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolForum, () => new SolarSchoolForumGameplay());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolExam, () => new SolarSchoolExamGameplay());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolFavorLevel, () => new SolarSchoolFavorLevelAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolScoreNotify, () => new SolarSchoolScoreNotifyGameplay());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolEnding, () => new SolarSchoolEndingAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolPopup, () => new SolarSchoolPopupAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolAvgParam, () => new SolarSchoolAvgParamAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolAvgDialogue, () => new SolarSchoolAvgDialogueAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolScratchTicket, () => new SolarSchoolScratchTicketGameplay());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolSpecialBehaviorAccept, () => new SolarSchoolSpecialBehaviorAcceptAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolShop, () => new SolarSchoolShopAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolGiveGift, () => new SolarSchoolGiveGiftAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolEndingTimeSwitch, () => new SolarSchoolEndingTimeSwitchAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolInfluenceLevel, () => new SolarSchoolInfluenceLevelAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolTimeSlotSwitch, () => new SolarSchoolTimeSlotSwitchAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolGoHome, () => new SolarSchoolGoHomeAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolDayTransition, () => new SolarSchoolDayTransitionAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolFullScreenDayTransition, () => new SolarSchoolFullScreenDayTransitionAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolPrizeDrawing, () => new SolarSchoolPrizeDrawingGameplay());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolMonthSummary, () => new SolarSchoolMonthSummaryAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolEndingSummary, () => new SolarSchoolEndingSummaryAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolMapUnlock, () => new SolarSchoolMapUnlockAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolSaveReminder, () => new SolarSchoolSaveReminderAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolAttrImportant, () => new SolarSchoolAttrImportantAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolSkipDays, () => new SolarSchoolSkipDaysAction());
			ActivityActionModel.Register(instance, EActivityActionType.SolarSchoolItemGetPopup, () => new SolarSchoolItemGetPopupAction());
		}

		// Token: 0x06039291 RID: 234129 RVA: 0x01001FD1 File Offset: 0x010001D1
		private static void Register(ActivityActionFactory factory, EActivityActionType type, Func<ActivityActionBase> creator)
		{
			if (factory.IsRegistered(type))
			{
				return;
			}
			factory.Register(type, creator);
		}

		// Token: 0x06039292 RID: 234130 RVA: 0x01001FE5 File Offset: 0x010001E5
		protected override bool OnClear()
		{
			if (this.IsTicking)
			{
				TickSystem.Instance.Remove(this.TickerId);
				this.TickerId = -1;
			}
			this.ClearAllHandlers();
			return true;
		}

		// Token: 0x06039293 RID: 234131 RVA: 0x01002010 File Offset: 0x01000210
		public ActivityActionExecuteHandler GetHandler()
		{
			ActivityActionExecuteHandler activityActionExecuteHandler = new ActivityActionExecuteHandler();
			if (this.InTick)
			{
				this.PendingAdd.Add(activityActionExecuteHandler);
			}
			else
			{
				this.Handlers.Add(activityActionExecuteHandler);
			}
			this.CheckLeak();
			return activityActionExecuteHandler;
		}

		// Token: 0x06039294 RID: 234132 RVA: 0x0100204C File Offset: 0x0100024C
		[NullableContext(2)]
		public unsafe ActivityActionBase CreateAction(int actionId, EActivityCategory expectedCategory = EActivityCategory.None)
		{
			ActivityAction? config = ConfigActivityActionById.GetConfig(actionId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "ActivityActionModel 获取 ActivityAction 配置失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionId", actionId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			ActivityAction value = config.Value;
			if (!this.CheckCategory(actionId, value.ActionType, expectedCategory))
			{
				return null;
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			for (int i = 0; i < value.ActionParamsLength; i++)
			{
				DicStringString? dicStringString = value.ActionParams(i);
				if (dicStringString != null && !string.IsNullOrEmpty(dicStringString.Value.Key))
				{
					dictionary[dicStringString.Value.Key] = (dicStringString.Value.Value ?? string.Empty);
				}
			}
			ActivityActionBase activityActionBase = ActivityActionFactory.Instance.Create((EActivityActionType)value.ActionType, dictionary);
			if (activityActionBase == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Activity;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "ActivityActionModel 根据配置创建 action 失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("actionId", actionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionType", value.ActionType);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			activityActionBase.ActionId = actionId;
			return activityActionBase;
		}

		// Token: 0x06039295 RID: 234133 RVA: 0x010021B4 File Offset: 0x010003B4
		private unsafe bool CheckCategory(int actionId, int actionType, EActivityCategory expectedCategory)
		{
			if (expectedCategory == EActivityCategory.None)
			{
				return true;
			}
			ActivityActionClientType? config = ConfigActivityActionClientTypeById.GetConfig(actionType, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "ActivityActionModel 找不到 ActionType 的类型配置，无法校验玩法大类";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("actionId", actionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionType", actionType);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			EActivityCategory category = (EActivityCategory)config.Value.Category;
			if (category != expectedCategory)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Activity;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "ActivityActionModel ActionType 不属于当前玩法，已拒绝创建";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("actionId", actionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ActionType", actionType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("category", category);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("expectedCategory", expectedCategory);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
				return false;
			}
			return true;
		}

		// Token: 0x06039296 RID: 234134 RVA: 0x010022F0 File Offset: 0x010004F0
		public void PushAction(ActivityActionExecuteHandler handler, int actionId)
		{
			if (handler == null)
			{
				return;
			}
			ActivityActionBase activityActionBase = this.CreateAction(actionId, EActivityCategory.None);
			if (activityActionBase == null)
			{
				return;
			}
			handler.Push(activityActionBase);
		}

		// Token: 0x06039297 RID: 234135 RVA: 0x01002316 File Offset: 0x01000516
		internal void Release(ActivityActionExecuteHandler executeHandler)
		{
			if (this.InTick)
			{
				this.PendingRemove.Add(executeHandler);
				return;
			}
			this.Handlers.Remove(executeHandler);
		}

		// Token: 0x06039298 RID: 234136 RVA: 0x0100233C File Offset: 0x0100053C
		private void ClearAllHandlers()
		{
			ActivityActionExecuteHandler[] array = this.Handlers.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Dispose();
			}
			this.Handlers.Clear();
			this.PendingAdd.Clear();
			this.PendingRemove.Clear();
			this.LeakWarned = false;
		}

		// Token: 0x06039299 RID: 234137 RVA: 0x01002394 File Offset: 0x01000594
		public void Tick(float delta)
		{
			this.InTick = true;
			foreach (ActivityActionExecuteHandler activityActionExecuteHandler in this.Handlers)
			{
				activityActionExecuteHandler.Tick(delta);
			}
			this.InTick = false;
			if (this.PendingRemove.Count > 0)
			{
				foreach (ActivityActionExecuteHandler item in this.PendingRemove)
				{
					this.Handlers.Remove(item);
				}
				this.PendingRemove.Clear();
			}
			if (this.PendingAdd.Count > 0)
			{
				this.Handlers.AddRange(this.PendingAdd);
				this.PendingAdd.Clear();
			}
		}

		// Token: 0x0603929A RID: 234138 RVA: 0x01002480 File Offset: 0x01000680
		private unsafe void CheckLeak()
		{
			if (this.LeakWarned || this.HandlerCount < 256)
			{
				return;
			}
			this.LeakWarned = true;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "ActivityActionModel 存活 Handler 数超阈值，疑似业务忘记 Dispose";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("HandlerCount", this.HandlerCount);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Threshold", 256);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x17006CD5 RID: 27861
		// (get) Token: 0x0603929B RID: 234139 RVA: 0x01002513 File Offset: 0x01000713
		public static ActivityActionModel Instance
		{
			get
			{
				return ActivityActionModel._Instance;
			}
		}

		// Token: 0x0603929C RID: 234140 RVA: 0x0100251A File Offset: 0x0100071A
		public static ActivityActionModel GetOrCreateInstance()
		{
			if (ActivityActionModel._Instance == null)
			{
				ActivityActionModel.CreateInstance();
			}
			return ActivityActionModel._Instance;
		}

		// Token: 0x0603929D RID: 234141 RVA: 0x0100252E File Offset: 0x0100072E
		public static bool CreateInstance()
		{
			if (ActivityActionModel._Instance != null)
			{
				return true;
			}
			ActivityActionModel._Instance = new ActivityActionModel();
			return true;
		}

		// Token: 0x0603929E RID: 234142 RVA: 0x01002544 File Offset: 0x01000744
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603929F RID: 234143 RVA: 0x01002546 File Offset: 0x01000746
		public static void ResetStaticDefaultValue()
		{
			ActivityActionModel._Instance = null;
		}

		// Token: 0x060392A0 RID: 234144 RVA: 0x0100254E File Offset: 0x0100074E
		static ActivityActionModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityActionModel.CreateStaticDefaultValue), new Action(ActivityActionModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E142 RID: 123202
		private readonly List<ActivityActionExecuteHandler> Handlers = new List<ActivityActionExecuteHandler>();

		// Token: 0x0401E143 RID: 123203
		private readonly List<ActivityActionExecuteHandler> PendingAdd = new List<ActivityActionExecuteHandler>();

		// Token: 0x0401E144 RID: 123204
		private readonly List<ActivityActionExecuteHandler> PendingRemove = new List<ActivityActionExecuteHandler>();

		// Token: 0x0401E145 RID: 123205
		private bool InTick;

		// Token: 0x0401E146 RID: 123206
		private const int LeakWarnThreshold = 256;

		// Token: 0x0401E147 RID: 123207
		private bool LeakWarned;

		// Token: 0x0401E148 RID: 123208
		private int TickerId = -1;

		// Token: 0x0401E149 RID: 123209
		[Nullable(2)]
		private static ActivityActionModel _Instance;
	}
}
