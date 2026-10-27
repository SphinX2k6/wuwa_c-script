using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F79 RID: 28537
	public class LevelFlowActionBase : IStaticVariableResetter
	{
		// Token: 0x060456A7 RID: 284327 RVA: 0x01134E57 File Offset: 0x01133057
		static LevelFlowActionBase()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelFlowActionBase.CreateStaticDefaultValue), new Action(LevelFlowActionBase.ResetStaticDefaultValue));
		}

		// Token: 0x060456A8 RID: 284328 RVA: 0x01134E76 File Offset: 0x01133076
		public LevelFlowActionBase()
		{
			this.ActionId = LevelFlowActionBase.SelfIncrementId++;
		}

		// Token: 0x060456A9 RID: 284329 RVA: 0x01134E91 File Offset: 0x01133091
		[NullableContext(1)]
		public void BindCompleteCallBack(Action<LevelFlowActionBase, bool> completeCallBack)
		{
			this.CompleteCallBack = completeCallBack;
		}

		// Token: 0x060456AA RID: 284330 RVA: 0x01134E9A File Offset: 0x0113309A
		public void Execute()
		{
			this.IsExecute = true;
			this.LogExecuteInfo();
			this.OnAddEventListener();
			this.OnExecute();
		}

		// Token: 0x060456AB RID: 284331 RVA: 0x01134EB8 File Offset: 0x011330B8
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

		// Token: 0x060456AC RID: 284332 RVA: 0x01134F83 File Offset: 0x01133183
		public void Tick(float deltaTime)
		{
			if (!this.IsExecute)
			{
				return;
			}
			this.OnTick(deltaTime);
		}

		// Token: 0x060456AD RID: 284333 RVA: 0x01134F95 File Offset: 0x01133195
		public void Reset()
		{
			this.IsExecute = false;
			this.OnReset();
		}

		// Token: 0x060456AE RID: 284334 RVA: 0x01134FA4 File Offset: 0x011331A4
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

		// Token: 0x060456AF RID: 284335 RVA: 0x011350DC File Offset: 0x011332DC
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

		// Token: 0x060456B0 RID: 284336 RVA: 0x011351F6 File Offset: 0x011333F6
		protected virtual void OnExecute()
		{
		}

		// Token: 0x060456B1 RID: 284337 RVA: 0x011351F8 File Offset: 0x011333F8
		protected virtual void OnAddEventListener()
		{
		}

		// Token: 0x060456B2 RID: 284338 RVA: 0x011351FA File Offset: 0x011333FA
		protected virtual void OnTick(float deltaTime)
		{
		}

		// Token: 0x060456B3 RID: 284339 RVA: 0x011351FC File Offset: 0x011333FC
		protected virtual void ExecuteWhenEntitiesReady()
		{
		}

		// Token: 0x060456B4 RID: 284340 RVA: 0x011351FE File Offset: 0x011333FE
		protected virtual void OnRemoveEventListener()
		{
		}

		// Token: 0x060456B5 RID: 284341 RVA: 0x01135200 File Offset: 0x01133400
		protected virtual void OnComplete(bool isSuccess)
		{
		}

		// Token: 0x060456B6 RID: 284342 RVA: 0x01135202 File Offset: 0x01133402
		protected virtual void OnReset()
		{
		}

		// Token: 0x060456B7 RID: 284343 RVA: 0x01135204 File Offset: 0x01133404
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

		// Token: 0x060456B8 RID: 284344 RVA: 0x0113527B File Offset: 0x0113347B
		public static void CreateStaticDefaultValue()
		{
			LevelFlowActionBase.SelfIncrementId = 0;
		}

		// Token: 0x060456B9 RID: 284345 RVA: 0x01135283 File Offset: 0x01133483
		public static void ResetStaticDefaultValue()
		{
			LevelFlowActionBase.SelfIncrementId = 0;
		}

		// Token: 0x04024394 RID: 148372
		public readonly int ActionId;

		// Token: 0x04024395 RID: 148373
		private static int SelfIncrementId;

		// Token: 0x04024396 RID: 148374
		private bool IsExecute;

		// Token: 0x04024397 RID: 148375
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<LevelFlowActionBase, bool> CompleteCallBack;

		// Token: 0x04024398 RID: 148376
		private const int EACH_WAIT_ENTITY_OVER_TIME = 30000;
	}
}
