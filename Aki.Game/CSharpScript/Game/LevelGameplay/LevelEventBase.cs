using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x0200698A RID: 27018
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventBase
	{
		// Token: 0x060433F5 RID: 275445 RVA: 0x01064A79 File Offset: 0x01062C79
		public LevelEventBase(int id)
		{
			this.Id = id;
		}

		// Token: 0x17009848 RID: 38984
		// (get) Token: 0x060433F6 RID: 275446 RVA: 0x01064AA5 File Offset: 0x01062CA5
		public int Id { get; }

		// Token: 0x060433F7 RID: 275447 RVA: 0x01064AB0 File Offset: 0x01062CB0
		public unsafe virtual void ExecuteAction(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			this.BaseContext = context;
			if (LevelGeneralController.Instance.LevelEventLogOpen)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "LevelEvent:开始执行行为";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("行为类型", this.Type);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			if (AutoRunModel.Instance.IsInLogicTreeGmMode())
			{
				this.ExecuteInGm(inParams, context, actionId);
				return;
			}
			if (!LevelGeneralBaseFrameScheduler.Instance.PushActionToFrameScheduler(this, inParams, context, actionId))
			{
				CombinationContext combinationContext = context as CombinationContext;
				if (combinationContext != null)
				{
					EntityContext contextByType = combinationContext.GetContextByType<EntityContext>(EGeneralContextType.Entity);
					if (contextByType == null)
					{
						global::Log instance2 = global::Log.Instance;
						ELogModule module2 = ELogModule.LevelEvent;
						ELogAuthor author2 = ELogAuthor.CK;
						string message2 = "CombinationContext内不包含EntityContext, 直接传递CombinationContext";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("行为类型", this.Type);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionId", actionId);
						instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						this.ExecuteNew(inParams, context, actionId);
						return;
					}
					this.ExecuteNew(inParams, contextByType, actionId);
					return;
				}
				else
				{
					this.ExecuteNew(inParams, context, actionId);
				}
			}
		}

		// Token: 0x060433F8 RID: 275448 RVA: 0x01064BB4 File Offset: 0x01062DB4
		public virtual void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
		}

		// Token: 0x060433F9 RID: 275449 RVA: 0x01064BB6 File Offset: 0x01062DB6
		protected virtual void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			this.ExecuteNew(inParams, context, actionId);
		}

		// Token: 0x060433FA RID: 275450 RVA: 0x01064BC1 File Offset: 0x01062DC1
		protected void CreateWaitEntityTask(List<int> entityIds)
		{
			this.CreateWaitEntityTaskInternal(entityIds);
		}

		// Token: 0x060433FB RID: 275451 RVA: 0x01064BCF File Offset: 0x01062DCF
		protected void CreateWaitEntityTask(int entityId)
		{
			this.CreateWaitEntityTaskInternal(entityId);
		}

		// Token: 0x060433FC RID: 275452 RVA: 0x01064BE0 File Offset: 0x01062DE0
		private unsafe void CreateWaitEntityTaskInternal([Nullable(new byte[]
		{
			0,
			1
		})] OneOf<List<int>, int> entityIds)
		{
			if (LevelGeneralController.Instance.LevelEventLogOpen)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "等待实体创建";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("行为类型", this.Type);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityIds", entityIds.ToString());
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			int count = 1;
			if (entityIds.IsT1)
			{
				count = entityIds.AsT1.Count;
				WaitEntityTask.CreateWithPbDataId("LevelEventBase.CreateWaitEntityTask", entityIds.AsT1, delegate(bool? result)
				{
					if (!result.GetValueOrDefault())
					{
						global::Log instance2 = global::Log.Instance;
						ELogModule module2 = ELogModule.Event;
						ELogAuthor author2 = ELogAuthor.YZH;
						string message2 = "Entity加载超时或已被移除";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityCount", count);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EntityIds", entityIds.AsT1);
						instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
						this.FinishExecute(false, false, true);
						return;
					}
					this.ExecuteWhenEntitiesReady();
				}, 30000 * count, true, false);
				return;
			}
			WaitEntityTask.CreateWithPbDataId("LevelEventBase.CreateWaitEntityTask", entityIds.AsT2, delegate(bool? result)
			{
				if (!result.GetValueOrDefault())
				{
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.Event;
					ELogAuthor author2 = ELogAuthor.YZH;
					string message2 = "Entity加载超时或已被移除";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityCount", count);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EntityIds", entityIds.AsT2);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					this.FinishExecute(false, false, true);
					return;
				}
				this.ExecuteWhenEntitiesReady();
			}, 30000 * count, true, false);
		}

		// Token: 0x060433FD RID: 275453 RVA: 0x01064CFF File Offset: 0x01062EFF
		protected void CreateWaitEntityTaskBigInt(List<long> entityIds)
		{
			this.CreateWaitEntityTaskBigIntInternal(entityIds);
		}

		// Token: 0x060433FE RID: 275454 RVA: 0x01064D0D File Offset: 0x01062F0D
		protected void CreateWaitEntityTaskBigInt(long entityId)
		{
			this.CreateWaitEntityTaskBigIntInternal(entityId);
		}

		// Token: 0x060433FF RID: 275455 RVA: 0x01064D1C File Offset: 0x01062F1C
		private unsafe void CreateWaitEntityTaskBigIntInternal([Nullable(new byte[]
		{
			0,
			1
		})] OneOf<List<long>, long> entityIds)
		{
			if (LevelGeneralController.Instance.LevelEventLogOpen)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "等待实体创建";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("行为类型", this.Type);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityIds", entityIds.ToString());
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			int count = 1;
			if (entityIds.IsT1)
			{
				count = entityIds.AsT1.Count;
				WaitEntityTask.Create("LevelEventBase.CreateWaitEntityTaskBigInt", entityIds.AsT1, delegate(bool? result)
				{
					if (!result.GetValueOrDefault())
					{
						global::Log instance2 = global::Log.Instance;
						ELogModule module2 = ELogModule.Event;
						ELogAuthor author2 = ELogAuthor.YZH;
						string message2 = "Entity加载超时或已被移除";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityCount", count);
						instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						this.FinishExecute(false, false, true);
						return;
					}
					this.ExecuteWhenEntitiesReady();
				}, count * 30000, true, false);
				return;
			}
			WaitEntityTask.Create("LevelEventBase.CreateWaitEntityTaskBigInt", entityIds.AsT2, delegate(bool? result)
			{
				if (!result.GetValueOrDefault())
				{
					global::Log instance2 = global::Log.Instance;
					ELogModule module2 = ELogModule.Event;
					ELogAuthor author2 = ELogAuthor.YZH;
					string message2 = "Entity加载超时或已被移除";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityCount", count);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					this.FinishExecute(false, false, true);
					return;
				}
				this.ExecuteWhenEntitiesReady();
			}, count * 30000, true, false);
		}

		// Token: 0x06043400 RID: 275456 RVA: 0x01064E20 File Offset: 0x01063020
		protected virtual void ExecuteWhenEntitiesReady()
		{
		}

		// Token: 0x06043401 RID: 275457 RVA: 0x01064E22 File Offset: 0x01063022
		public void OpenTick()
		{
			this.IsWaitEnd = true;
			this.IsFinished = false;
			EventSystem.Instance.Emit<bool, LevelEventBase>(EEventName.AddToTickList, true, this);
		}

		// Token: 0x06043402 RID: 275458 RVA: 0x01064E44 File Offset: 0x01063044
		public virtual bool Tick(float deltaTime)
		{
			this.OnTick(deltaTime);
			return this.IsFinished;
		}

		// Token: 0x06043403 RID: 275459 RVA: 0x01064E53 File Offset: 0x01063053
		protected virtual void OnTick(float deltaTime)
		{
		}

		// Token: 0x06043404 RID: 275460 RVA: 0x01064E55 File Offset: 0x01063055
		protected void FinishExecute(bool value, bool isError = false, bool showLog = true)
		{
			this.IsFinished = value;
			if (!this.IsFinished)
			{
				this.Failure(isError, showLog);
			}
		}

		// Token: 0x06043405 RID: 275461 RVA: 0x01064E70 File Offset: 0x01063070
		public void Finish()
		{
			this.OnFinish();
			this.UpdateGuarantee();
			this.Release();
			if (LevelGeneralController.Instance.LevelEventLogOpen)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "LevelEvent:行为执行完毕_NodeFinished";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("行为类型", this.Type);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			EventSystem.Instance.Emit<int>(EEventName.HandleNextAction, this.GroupId);
		}

		// Token: 0x06043406 RID: 275462 RVA: 0x01064EDD File Offset: 0x010630DD
		protected virtual void OnFinish()
		{
		}

		// Token: 0x06043407 RID: 275463 RVA: 0x01064EDF File Offset: 0x010630DF
		public void UpdateGuarantee()
		{
			this.OnUpdateGuarantee();
		}

		// Token: 0x06043408 RID: 275464 RVA: 0x01064EE7 File Offset: 0x010630E7
		protected virtual void OnUpdateGuarantee()
		{
		}

		// Token: 0x06043409 RID: 275465 RVA: 0x01064EEC File Offset: 0x010630EC
		public void Failure(bool isError = false, bool showLog = true)
		{
			if (GlobalData.IsPlayInEditor)
			{
				EventSystem.Instance.Emit<GeneralContext, int>(EEventName.GmHandleActionFailed, this.BaseContext, this.ActionIndex);
			}
			this.OnFailure();
			this.Release();
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelEvent;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "LevelEvent:行为执行失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("行为类型", this.Type);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			EventSystem.Instance.Emit<int, string, bool, bool>(EEventName.HandleActionFailure, this.GroupId, this.Type, isError, showLog);
		}

		// Token: 0x0604340A RID: 275466 RVA: 0x01064F72 File Offset: 0x01063172
		protected virtual void OnFailure()
		{
		}

		// Token: 0x0604340B RID: 275467 RVA: 0x01064F74 File Offset: 0x01063174
		public virtual void Release()
		{
			if (this.IsWaitEnd)
			{
				EventSystem.Instance.Emit<bool, LevelEventBase>(EEventName.AddToTickList, false, this);
			}
		}

		// Token: 0x0604340C RID: 275468 RVA: 0x01064F90 File Offset: 0x01063190
		public void Reset()
		{
			this.OnReset();
			this.GroupId = 0;
			this.IsWaitEnd = false;
			this.IsFinished = true;
			this.IsAsync = false;
			this.SessionId = -1;
			this.ActionIndex = -1;
		}

		// Token: 0x0604340D RID: 275469 RVA: 0x01064FC2 File Offset: 0x010631C2
		protected virtual void OnReset()
		{
		}

		// Token: 0x04023061 RID: 143457
		public const int EACH_WAIT_ENTITY_OVER_TIME = 30000;

		// Token: 0x04023062 RID: 143458
		public int GroupId;

		// Token: 0x04023063 RID: 143459
		public string Type = "";

		// Token: 0x04023064 RID: 143460
		public bool IsWaitEnd;

		// Token: 0x04023065 RID: 143461
		public bool IsAsync;

		// Token: 0x04023066 RID: 143462
		public int SessionId = -1;

		// Token: 0x04023067 RID: 143463
		public int ActionIndex;

		// Token: 0x04023068 RID: 143464
		public string ActionGuid = "";

		// Token: 0x04023069 RID: 143465
		private bool IsFinished;

		// Token: 0x0402306A RID: 143466
		[Nullable(2)]
		public GeneralContext BaseContext;
	}
}
