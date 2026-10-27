using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.Common;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006FAC RID: 28588
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelFlowWaitSplineMoveAction : LevelFlowActionBase
	{
		// Token: 0x060457B0 RID: 284592 RVA: 0x0113C650 File Offset: 0x0113A850
		[NullableContext(1)]
		public LevelFlowWaitSplineMoveAction Init(int entityId, int splineId, float timeKey)
		{
			this.EntityId = entityId;
			this.SplineId = splineId;
			this.TimeKey = timeKey;
			if (LevelFlowModel.Instance.IsDebug)
			{
				this.SplineComponent = GameSplineModel.Instance.LoadAndGetSplineComponent(splineId, entityId, EIdType.EntityId);
				if (this.SplineComponent == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.LevelFlow;
					ELogAuthor author = ELogAuthor.BB;
					string message = "[LevelFlowWaitSplineMoveAction] 行为传入的路径未找到";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", this.SplineId);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return this;
				}
				FVectorDouble center = this.SplineComponent.D_GetLocationAtSplineInputKey(this.TimeKey, ESplineCoordinateSpace.World);
				FRotator rotationAtSplineInputKey = this.SplineComponent.GetRotationAtSplineInputKey(this.TimeKey, ESplineCoordinateSpace.World);
				UKismetSystemLibrary.D_DrawDebugBox(GlobalData.World, center, LevelFlowWaitSplineMoveAction.extent.ToUeVector(false), ColorUtils.LinearGreen, rotationAtSplineInputKey, 1000f, 10f);
			}
			return this;
		}

		// Token: 0x060457B1 RID: 284593 RVA: 0x0113C720 File Offset: 0x0113A920
		protected override void OnExecute()
		{
			this.SplineComponent = GameSplineModel.Instance.LoadAndGetSplineComponent(this.SplineId, this.EntityId, EIdType.EntityId);
			if (this.SplineComponent == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelFlow;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[LevelFlowWaitSplineMoveAction] 行为传入的路径未找到";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", this.SplineId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.FinishExecute(false);
				return;
			}
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(this.EntityId);
			if (entityById == null || entityById.Entity == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.LevelFlow;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "[LevelFlowWaitSplineMoveAction] 行为传入的实体未找到";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("PbDataId", this.EntityId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				base.FinishExecute(false);
				return;
			}
			this.SplineMoveComponent = entityById.Entity.GetComponent<BaseSplineMoveComponent>();
			if (this.SplineMoveComponent == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.LevelFlow;
				ELogAuthor author3 = ELogAuthor.BB;
				string message3 = "[LevelFlowWaitSplineMoveAction] 行为传入的实体未找到路径移动组件";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("PbDataId", this.EntityId);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				base.FinishExecute(false);
				return;
			}
			this.ActorComponent = entityById.Entity.GetComponent<BaseActorComponent>();
			if (this.ActorComponent == null)
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.LevelFlow;
				ELogAuthor author4 = ELogAuthor.BB;
				string message4 = "[LevelFlowWaitSplineMoveAction] 行为传入的实体未找到基础组件";
				ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("PbDataId", this.EntityId);
				instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
				base.FinishExecute(false);
				return;
			}
			this.CheckTimeKey();
		}

		// Token: 0x060457B2 RID: 284594 RVA: 0x0113C896 File Offset: 0x0113AA96
		protected override void OnTick(float deltaTime)
		{
			this.CheckTimeKey();
		}

		// Token: 0x060457B3 RID: 284595 RVA: 0x0113C8A0 File Offset: 0x0113AAA0
		private void CheckTimeKey()
		{
			if (this.SplineMoveComponent == null || this.ActorComponent == null || this.SplineComponent == null)
			{
				base.FinishExecute(false);
				return;
			}
			USplineComponent splineComponent = this.SplineComponent;
			FVectorDouble fvectorDouble = this.ActorComponent.ActorLocationProxy.ToUeVector(false);
			if (splineComponent.D_FindInputKeyClosestToWorldLocationInGravity(fvectorDouble, this.ActorComponent.ActorGravityDirectProxy.ToUeVectorOld(), 100000f) >= this.TimeKey)
			{
				base.FinishExecute(true);
			}
		}

		// Token: 0x060457B4 RID: 284596 RVA: 0x0113C910 File Offset: 0x0113AB10
		protected unsafe override void LogExecuteInfo()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LevelFlow;
			ELogAuthor author = ELogAuthor.BB;
			string message = "执行行为";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionId", this.ActionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionName", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntityId", this.EntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("SplineId", this.SplineId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("TimeKey", this.TimeKey);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
		}

		// Token: 0x04024409 RID: 148489
		private int EntityId;

		// Token: 0x0402440A RID: 148490
		private int SplineId;

		// Token: 0x0402440B RID: 148491
		private float TimeKey;

		// Token: 0x0402440C RID: 148492
		private BaseSplineMoveComponent SplineMoveComponent;

		// Token: 0x0402440D RID: 148493
		private BaseActorComponent ActorComponent;

		// Token: 0x0402440E RID: 148494
		private USplineComponent SplineComponent;

		// Token: 0x0402440F RID: 148495
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Vector extent = Vector.Create(30.0, 300.0, 500.0);
	}
}
