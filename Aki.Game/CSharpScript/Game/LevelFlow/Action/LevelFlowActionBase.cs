using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x020060FA RID: 24826
	public class LevelFlowActionBase : IStaticVariableResetter
	{
		// Token: 0x0603B855 RID: 243797 RVA: 0x010DEC5B File Offset: 0x010DCE5B
		static LevelFlowActionBase()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelFlowActionBase.CreateStaticDefaultValue), new Action(LevelFlowActionBase.ResetStaticDefaultValue));
		}

		// Token: 0x0603B856 RID: 243798 RVA: 0x010DEC7A File Offset: 0x010DCE7A
		public LevelFlowActionBase()
		{
			this.ActionId = LevelFlowActionBase.SelfIncrementId++;
		}

		// Token: 0x0603B857 RID: 243799 RVA: 0x010DEC95 File Offset: 0x010DCE95
		[NullableContext(1)]
		public void BindCompleteCallBack(Action<LevelFlowActionBase, bool> completeCallBack)
		{
			this.CompleteCallBack = completeCallBack;
		}

		// Token: 0x0603B858 RID: 243800 RVA: 0x010DEC9E File Offset: 0x010DCE9E
		public void Execute()
		{
			this.IsExecute = true;
			this.LogExecuteInfo();
			this.OnAddEventListener();
			this.OnExecute();
		}

		// Token: 0x0603B859 RID: 243801 RVA: 0x010DECBC File Offset: 0x010DCEBC
		public unsafe void FinishExecute(bool isSuccess)
		{
			if (!this.IsExecute)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LevelFlow;
			ELogAuthor author = ELogAuthor.BB;
			string message = "行为完成";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionId", this.ActionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionName", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("IsSuccess", isSuccess);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.IsExecute = false;
			this.OnRemoveEventListener();
			this.OnComplete(isSuccess);
			Action<LevelFlowActionBase, bool> completeCallBack = this.CompleteCallBack;
			if (completeCallBack != null)
			{
				completeCallBack(this, isSuccess);
			}
			this.CompleteCallBack = null;
		}

		// Token: 0x0603B85A RID: 243802 RVA: 0x010DED87 File Offset: 0x010DCF87
		public void Tick(float deltaTime)
		{
			if (!this.IsExecute)
			{
				return;
			}
			this.OnTick(deltaTime);
		}

		// Token: 0x0603B85B RID: 243803 RVA: 0x010DED99 File Offset: 0x010DCF99
		public void Reset()
		{
			this.IsExecute = false;
			this.OnReset();
		}

		// Token: 0x0603B85C RID: 243804 RVA: 0x010DEDA8 File Offset: 0x010DCFA8
		protected unsafe void CreateWaitEntityTask([Nullable(new byte[]
		{
			0,
			1
		})] OneOf<List<int>, int> entityIds)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LevelFlow;
			ELogAuthor author = ELogAuthor.BB;
			string message = "等待实体创建";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("行为Id", this.ActionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityIds", entityIds.ToString());
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			int count = 1;
			if (entityIds.IsT1)
			{
				count = entityIds.AsT1.Count;
			}
			if (entityIds.IsT1)
			{
				WaitEntityTask.CreateWithPbDataId("LevelEventBase.CreateWaitEntityTask", entityIds.AsT1, delegate(bool? result)
				{
					if (!result.GetValueOrDefault())
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.Event;
						ELogAuthor author2 = ELogAuthor.YZH;
						string message2 = "Entity加载超时或已被移除";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityCount", count);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EntityIds", entityIds.AsT1.ToString());
						instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
						this.FinishExecute(false);
						return;
					}
					this.ExecuteWhenEntitiesReady();
				}, 30000 * count, true, false);
			}
			if (entityIds.IsT2)
			{
				WaitEntityTask.CreateWithPbDataId("LevelEventBase.CreateWaitEntityTask", entityIds.AsT2, delegate(bool? result)
				{
					if (!result.GetValueOrDefault())
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.Event;
						ELogAuthor author2 = ELogAuthor.YZH;
						string message2 = "Entity加载超时或已被移除";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityCount", count);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("EntityIds", entityIds.AsT1.ToString());
						instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
						this.FinishExecute(false);
						return;
					}
					this.ExecuteWhenEntitiesReady();
				}, 30000 * count, true, false);
			}
		}

		// Token: 0x0603B85D RID: 243805 RVA: 0x010DEEE0 File Offset: 0x010DD0E0
		protected unsafe void CreateWaitEntityTaskBigInt([Nullable(new byte[]
		{
			0,
			1
		})] OneOf<List<long>, long> entityIds)
		{
			if (LevelGeneralController.Instance.LevelEventLogOpen)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "等待实体创建";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("行为Id", this.ActionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityIds", entityIds.ToString());
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			int count = 1;
			if (entityIds.IsT1)
			{
				count = entityIds.AsT1.Count;
			}
			if (entityIds.IsT1)
			{
				WaitEntityTask.Create("LevelEventBase.CreateWaitEntityTaskBigInt", entityIds.AsT1, delegate(bool? result)
				{
					if (!result.GetValueOrDefault())
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.Event;
						ELogAuthor author2 = ELogAuthor.YZH;
						string message2 = "Entity加载超时或已被移除";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityCount", count);
						instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						this.FinishExecute(false);
						return;
					}
					this.ExecuteWhenEntitiesReady();
				}, count * 30000, true, false);
			}
			if (entityIds.IsT2)
			{
				WaitEntityTask.Create("LevelEventBase.CreateWaitEntityTaskBigInt", entityIds.AsT2, delegate(bool? result)
				{
					if (!result.GetValueOrDefault())
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.Event;
						ELogAuthor author2 = ELogAuthor.YZH;
						string message2 = "Entity加载超时或已被移除";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityCount", count);
						instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						this.FinishExecute(false);
						return;
					}
					this.ExecuteWhenEntitiesReady();
				}, count * 30000, true, false);
			}
		}

		// Token: 0x0603B85E RID: 243806 RVA: 0x010DEFFA File Offset: 0x010DD1FA
		protected virtual void OnExecute()
		{
		}

		// Token: 0x0603B85F RID: 243807 RVA: 0x010DEFFC File Offset: 0x010DD1FC
		protected virtual void OnAddEventListener()
		{
		}

		// Token: 0x0603B860 RID: 243808 RVA: 0x010DEFFE File Offset: 0x010DD1FE
		protected virtual void OnTick(float deltaTime)
		{
		}

		// Token: 0x0603B861 RID: 243809 RVA: 0x010DF000 File Offset: 0x010DD200
		protected virtual void ExecuteWhenEntitiesReady()
		{
		}

		// Token: 0x0603B862 RID: 243810 RVA: 0x010DF002 File Offset: 0x010DD202
		protected virtual void OnRemoveEventListener()
		{
		}

		// Token: 0x0603B863 RID: 243811 RVA: 0x010DF004 File Offset: 0x010DD204
		protected virtual void OnComplete(bool isSuccess)
		{
		}

		// Token: 0x0603B864 RID: 243812 RVA: 0x010DF006 File Offset: 0x010DD206
		protected virtual void OnReset()
		{
		}

		// Token: 0x0603B865 RID: 243813 RVA: 0x010DF008 File Offset: 0x010DD208
		protected unsafe virtual void LogExecuteInfo()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LevelFlow;
			ELogAuthor author = ELogAuthor.BB;
			string message = "执行行为";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionId", this.ActionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionName", base.GetType().Name);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0603B866 RID: 243814 RVA: 0x010DF07F File Offset: 0x010DD27F
		public static void CreateStaticDefaultValue()
		{
			LevelFlowActionBase.SelfIncrementId = 0;
		}

		// Token: 0x0603B867 RID: 243815 RVA: 0x010DF087 File Offset: 0x010DD287
		public static void ResetStaticDefaultValue()
		{
			LevelFlowActionBase.SelfIncrementId = 0;
		}

		// Token: 0x0401F649 RID: 128585
		public readonly int ActionId;

		// Token: 0x0401F64A RID: 128586
		private static int SelfIncrementId;

		// Token: 0x0401F64B RID: 128587
		private bool IsExecute;

		// Token: 0x0401F64C RID: 128588
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<LevelFlowActionBase, bool> CompleteCallBack;

		// Token: 0x0401F64D RID: 128589
		private const int EACH_WAIT_ENTITY_OVER_TIME = 30000;
	}
}
