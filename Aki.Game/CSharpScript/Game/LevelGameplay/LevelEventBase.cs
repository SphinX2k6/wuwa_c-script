using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AE6 RID: 23270
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventBase
	{
		// Token: 0x0603942D RID: 234541 RVA: 0x01008CE1 File Offset: 0x01006EE1
		public LevelEventBase(int id)
		{
			this.Id = id;
		}

		// Token: 0x17006D28 RID: 27944
		// (get) Token: 0x0603942E RID: 234542 RVA: 0x01008D0D File Offset: 0x01006F0D
		public int Id { get; }

		// Token: 0x0603942F RID: 234543 RVA: 0x01008D18 File Offset: 0x01006F18
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

		// Token: 0x06039430 RID: 234544 RVA: 0x01008E1C File Offset: 0x0100701C
		public virtual void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
		}

		// Token: 0x06039431 RID: 234545 RVA: 0x01008E1E File Offset: 0x0100701E
		protected virtual void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			this.ExecuteNew(inParams, context, actionId);
		}

		// Token: 0x06039432 RID: 234546 RVA: 0x01008E29 File Offset: 0x01007029
		protected void CreateWaitEntityTask(List<int> entityIds)
		{
			this.CreateWaitEntityTaskInternal(entityIds);
		}

		// Token: 0x06039433 RID: 234547 RVA: 0x01008E37 File Offset: 0x01007037
		protected void CreateWaitEntityTask(int entityId)
		{
			this.CreateWaitEntityTaskInternal(entityId);
		}

		// Token: 0x06039434 RID: 234548 RVA: 0x01008E48 File Offset: 0x01007048
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

		// Token: 0x06039435 RID: 234549 RVA: 0x01008F67 File Offset: 0x01007167
		protected void CreateWaitEntityTaskBigInt(List<long> entityIds)
		{
			this.CreateWaitEntityTaskBigIntInternal(entityIds);
		}

		// Token: 0x06039436 RID: 234550 RVA: 0x01008F75 File Offset: 0x01007175
		protected void CreateWaitEntityTaskBigInt(long entityId)
		{
			this.CreateWaitEntityTaskBigIntInternal(entityId);
		}

		// Token: 0x06039437 RID: 234551 RVA: 0x01008F84 File Offset: 0x01007184
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

		// Token: 0x06039438 RID: 234552 RVA: 0x01009088 File Offset: 0x01007288
		protected virtual void ExecuteWhenEntitiesReady()
		{
		}

		// Token: 0x06039439 RID: 234553 RVA: 0x0100908A File Offset: 0x0100728A
		public void OpenTick()
		{
			this.IsWaitEnd = true;
			this.IsFinished = false;
			EventSystem.Instance.Emit<bool, LevelEventBase>(EEventName.AddToTickList, true, this);
		}

		// Token: 0x0603943A RID: 234554 RVA: 0x010090AC File Offset: 0x010072AC
		public virtual bool Tick(float deltaTime)
		{
			this.OnTick(deltaTime);
			return this.IsFinished;
		}

		// Token: 0x0603943B RID: 234555 RVA: 0x010090BB File Offset: 0x010072BB
		protected virtual void OnTick(float deltaTime)
		{
		}

		// Token: 0x0603943C RID: 234556 RVA: 0x010090BD File Offset: 0x010072BD
		protected void FinishExecute(bool value, bool isError = false, bool showLog = true)
		{
			this.IsFinished = value;
			if (!this.IsFinished)
			{
				this.Failure(isError, showLog);
			}
		}

		// Token: 0x0603943D RID: 234557 RVA: 0x010090D8 File Offset: 0x010072D8
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

		// Token: 0x0603943E RID: 234558 RVA: 0x01009145 File Offset: 0x01007345
		protected virtual void OnFinish()
		{
		}

		// Token: 0x0603943F RID: 234559 RVA: 0x01009147 File Offset: 0x01007347
		public void UpdateGuarantee()
		{
			this.OnUpdateGuarantee();
		}

		// Token: 0x06039440 RID: 234560 RVA: 0x0100914F File Offset: 0x0100734F
		protected virtual void OnUpdateGuarantee()
		{
		}

		// Token: 0x06039441 RID: 234561 RVA: 0x01009154 File Offset: 0x01007354
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

		// Token: 0x06039442 RID: 234562 RVA: 0x010091DA File Offset: 0x010073DA
		protected virtual void OnFailure()
		{
		}

		// Token: 0x06039443 RID: 234563 RVA: 0x010091DC File Offset: 0x010073DC
		public virtual void Release()
		{
			if (this.IsWaitEnd)
			{
				EventSystem.Instance.Emit<bool, LevelEventBase>(EEventName.AddToTickList, false, this);
			}
		}

		// Token: 0x06039444 RID: 234564 RVA: 0x010091F8 File Offset: 0x010073F8
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

		// Token: 0x06039445 RID: 234565 RVA: 0x0100922A File Offset: 0x0100742A
		protected virtual void OnReset()
		{
		}

		// Token: 0x0401E24B RID: 123467
		public const int EACH_WAIT_ENTITY_OVER_TIME = 30000;

		// Token: 0x0401E24C RID: 123468
		public int GroupId;

		// Token: 0x0401E24D RID: 123469
		public string Type = "";

		// Token: 0x0401E24E RID: 123470
		public bool IsWaitEnd;

		// Token: 0x0401E24F RID: 123471
		public bool IsAsync;

		// Token: 0x0401E250 RID: 123472
		public int SessionId = -1;

		// Token: 0x0401E251 RID: 123473
		public int ActionIndex;

		// Token: 0x0401E252 RID: 123474
		public string ActionGuid = "";

		// Token: 0x0401E253 RID: 123475
		private bool IsFinished;

		// Token: 0x0401E254 RID: 123476
		[Nullable(2)]
		public GeneralContext BaseContext;
	}
}
