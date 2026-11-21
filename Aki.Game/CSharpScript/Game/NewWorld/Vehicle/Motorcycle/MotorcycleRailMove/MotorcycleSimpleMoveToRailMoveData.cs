using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x020061CE RID: 25038
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleSimpleMoveToRailMoveData : MotorcycleRailMoveDataBase
	{
		// Token: 0x0603C16E RID: 246126 RVA: 0x011196F0 File Offset: 0x011178F0
		public MotorcycleSimpleMoveToRailMoveData(Entity owner, [Nullable(2)] MotorcycleRailComponent relatedRail) : base(EMotorcycleRailMoveDataType.SimpleMoveToRail, owner, relatedRail)
		{
		}

		// Token: 0x17007158 RID: 29016
		// (get) Token: 0x0603C16F RID: 246127 RVA: 0x011197D2 File Offset: 0x011179D2
		private DirectlyEnterRailConfig DirectlyEnterRailConfig
		{
			get
			{
				return this.MoveConfig.DirectlyEnterRailConfig;
			}
		}

		// Token: 0x17007159 RID: 29017
		// (get) Token: 0x0603C170 RID: 246128 RVA: 0x011197DF File Offset: 0x011179DF
		private LinearMoveConfig LinearMoveConfig
		{
			get
			{
				return this.MoveConfig.DirectlyEnterRailConfig.LinearMoveConfig;
			}
		}

		// Token: 0x1700715A RID: 29018
		// (get) Token: 0x0603C171 RID: 246129 RVA: 0x011197F1 File Offset: 0x011179F1
		private CommonConfig CommonConfig
		{
			get
			{
				return this.MoveConfig.DirectlyEnterRailConfig.CommonConfig;
			}
		}

		// Token: 0x1700715B RID: 29019
		// (get) Token: 0x0603C172 RID: 246130 RVA: 0x01119803 File Offset: 0x01117A03
		private BasicRailMoveConfig BasicRailMoveConfig
		{
			get
			{
				return this.MoveConfig.BasicRailMoveConfig;
			}
		}

		// Token: 0x0603C173 RID: 246131 RVA: 0x01119810 File Offset: 0x01117A10
		[NullableContext(2)]
		public override bool OnEnter(MotorcycleRailMoveDataBase lastRailMoveData)
		{
			if (this.TargetSpline == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorRailMove;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[MotorcycleSimpleMoveToRailMoveData] OnEnter Failed: Spline is undefined";
				string item = "SplineId";
				MotorcycleRailComponent relatedRail = this.RelatedRail;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (relatedRail != null) ? new int?(relatedRail.GetRailSplineId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			Rotator tmpRotator = this.TmpRotator1;
			if (this.MoveGetter == null || !this.MoveGetter(this.StartLocation, tmpRotator, null))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.MotorRailMove;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "[MotorcycleSimpleMoveToRailMoveData] OnEnter Failed: 拿不到位置旋转";
				string item2 = "SplineId";
				MotorcycleRailComponent relatedRail2 = this.RelatedRail;
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item2, (relatedRail2 != null) ? new int?(relatedRail2.GetRailSplineId()) : null);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			tmpRotator.Quaternion(this.StartQuat);
			this.RailMoveContext.SourceLoc.FromUeVector(this.StartLocation);
			this.StartQuat.Rotator(this.RailMoveContext.SourceRot);
			this.RailMoveContext.RailSpline = this.TargetSpline;
			if ((lastRailMoveData == null || !lastRailMoveData.GetVelocity(this.RailMoveContext.SourceVel)) && (this.MoveGetter == null || !this.MoveGetter(null, null, this.RailMoveContext.SourceVel)))
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.MotorRailMove;
				ELogAuthor author3 = ELogAuthor.ZYL;
				string message3 = "[MotorcycleSimpleMoveToRailMoveData] OnEnter Failed: 拿不到速度";
				string item3 = "SplineId";
				MotorcycleRailComponent relatedRail3 = this.RelatedRail;
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>(item3, (relatedRail3 != null) ? new int?(relatedRail3.GetRailSplineId()) : null);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return false;
			}
			if (this.RailMoveContext.SourceVel.IsNearlyZero(1.0))
			{
				this.RailMoveContext.SourceVel.Reset();
			}
			List<TRailMoveChecker> checkList = new List<TRailMoveChecker>
			{
				new TRailMoveChecker(MotorcycleRailMoveUtils.Instance.RailMoveCheckerCheckVehicleNotReverseMove),
				new TRailMoveChecker(MotorcycleRailMoveUtils.Instance.RailMoveCheckerCheckAngleBetweenVehicleUpAndRailUp),
				new TRailMoveChecker(MotorcycleRailMoveUtils.Instance.RailMoveCheckerCheckAngleBetweenVehicleForwardAndRailTangent),
				new TRailMoveChecker(MotorcycleRailMoveUtils.Instance.RailMoveCheckerCheckAngleBetweenVehicleVelocityAndRailTangent),
				MotorcycleRailMoveUtils.Instance.RailMoveCheckerCheckRailLenLeft,
				new TRailMoveChecker(MotorcycleRailMoveUtils.Instance.RailMoveCheckerCheckRelativeLocation)
			};
			this.RailMoveContext.IsForward = true;
			bool flag = MotorcycleRailMoveUtils.Instance.CalcRailMoveTargetNotAdvanceBySpeed(this.RailMoveContext, (double)this.DirectlyEnterRailConfig.LinearMoveConfig.MinSpeed, (double)this.DirectlyEnterRailConfig.LinearMoveConfig.MaxSpeed);
			if (flag)
			{
				flag = MotorcycleRailMoveUtils.Instance.ExecCheckList(this.RailMoveContext, this.DirectlyEnterRailConfig.EnterRailCondition, checkList, true, base.GetType().Name);
			}
			if (!flag)
			{
				this.RailMoveContext.IsForward = false;
				flag = MotorcycleRailMoveUtils.Instance.CalcRailMoveTargetNotAdvanceBySpeed(this.RailMoveContext, (double)this.DirectlyEnterRailConfig.LinearMoveConfig.MinSpeed, (double)this.DirectlyEnterRailConfig.LinearMoveConfig.MaxSpeed);
				if (flag)
				{
					flag = MotorcycleRailMoveUtils.Instance.ExecCheckList(this.RailMoveContext, this.DirectlyEnterRailConfig.EnterRailCondition, checkList, true, base.GetType().Name);
				}
			}
			if (!flag)
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.MotorRailMove;
				ELogAuthor author4 = ELogAuthor.ZYL;
				string message4 = "[MotorcycleSimpleMoveToRailMoveData] OnEnter Failed: 计算终点并检查失败";
				string item4 = "SplineId";
				MotorcycleRailComponent relatedRail4 = this.RelatedRail;
				ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>(item4, (relatedRail4 != null) ? new int?(relatedRail4.GetRailSplineId()) : null);
				instance4.Warn(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
				return false;
			}
			this.TargetLocation.FromUeVector(this.RailMoveContext.RailMoveTarget.TargetLoc);
			this.RailMoveContext.RailMoveTarget.TargetRot.Quaternion(this.TargetQuat);
			Vector tmpVector = this.TmpVector1;
			this.TargetLocation.Subtraction(this.StartLocation, tmpVector);
			double num = tmpVector.Size();
			tmpVector.Normalize(9.99999993922529E-09);
			double num2 = this.RailMoveContext.SourceVel.DotProduct(tmpVector);
			if (MathUtils.Instance.IsNearlyZero(num2, null) || num2 < 0.0)
			{
				num2 = (double)this.BasicRailMoveConfig.DefaultMoveSpeed;
			}
			num2 = MathUtils.Instance.Clamp(num2, (double)this.LinearMoveConfig.MinSpeed, (double)this.LinearMoveConfig.MaxSpeed);
			tmpVector.Multiply(num2, this.Velocity);
			this.Time = (float)(num / num2);
			BaseTagComponent component = this.OwnerEntity.GetComponent<BaseTagComponent>();
			foreach (KeyValuePair<int, bool> keyValuePair in this.DirectlyEnterRailConfig.CommonConfig.ModifyVehicleTagsOnEnter)
			{
				int num3;
				bool flag2;
				keyValuePair.Deconstruct(out num3, out flag2);
				int value = num3;
				if (flag2)
				{
					if (component != null)
					{
						component.AddTag(new int?(value));
					}
				}
				else if (component != null)
				{
					component.RemoveTag(new int?(value));
				}
			}
			return true;
		}

		// Token: 0x0603C174 RID: 246132 RVA: 0x01119D20 File Offset: 0x01117F20
		public override void OnExit()
		{
			BaseTagComponent component = this.OwnerEntity.GetComponent<BaseTagComponent>();
			foreach (KeyValuePair<int, bool> keyValuePair in this.DirectlyEnterRailConfig.CommonConfig.ModifyVehicleTagsOnExit)
			{
				int num;
				bool flag;
				keyValuePair.Deconstruct(out num, out flag);
				int value = num;
				if (flag)
				{
					if (component != null)
					{
						component.AddTag(new int?(value));
					}
				}
				else if (component != null)
				{
					component.RemoveTag(new int?(value));
				}
			}
		}

		// Token: 0x0603C175 RID: 246133 RVA: 0x01119DB8 File Offset: 0x01117FB8
		public override void OnTick(float deltaSeconds)
		{
			this.TickUpdateMove(deltaSeconds);
			this.UpdateIsBlocked(deltaSeconds);
			this.ApplyMove();
			this.UpdateIsFinishMove();
		}

		// Token: 0x0603C176 RID: 246134 RVA: 0x01119DD4 File Offset: 0x01117FD4
		public override bool GetVelocity(Vector outVelocity)
		{
			outVelocity.DeepCopy(this.Velocity);
			return true;
		}

		// Token: 0x0603C177 RID: 246135 RVA: 0x01119DE4 File Offset: 0x01117FE4
		public void TickUpdateMove(float deltaSeconds)
		{
			float num = Math.Min(this.Time - this.CurrentTime, deltaSeconds);
			num = Math.Min(num, this.BasicRailMoveConfig.MaxDeltaTimeForMoveUpdate);
			this.CurrentTime += num;
			this.Velocity.Multiply((double)this.CurrentTime, this.CurrentLocation);
			this.CurrentLocation.AdditionEqual(this.StartLocation);
			Quat.Slerp(this.StartQuat, this.TargetQuat, this.CurrentTime / this.Time, MathUtils.Instance.CommonTempQuat);
			MathUtils.Instance.CommonTempQuat.Rotator(this.CurrentRotator);
		}

		// Token: 0x0603C178 RID: 246136 RVA: 0x01119E90 File Offset: 0x01118090
		private void ApplyMove()
		{
			if (this.CommonConfig.EnableBlockingCheck && this.IsBlocked)
			{
				return;
			}
			Vector tmpVector = this.TmpVector1;
			bool velocity = this.GetVelocity(tmpVector);
			TRailMoveUpdater moveUpdater = this.MoveUpdater;
			if (moveUpdater == null)
			{
				return;
			}
			moveUpdater(this.CurrentLocation, this.CurrentRotator, velocity ? tmpVector : null, this.CommonConfig.EnableBlockingCheck);
		}

		// Token: 0x0603C179 RID: 246137 RVA: 0x01119EF0 File Offset: 0x011180F0
		private void UpdateIsFinishMove()
		{
			if (this.CommonConfig.EnableBlockingCheck && this.IsBlocked && this.BlockingTime > this.CommonConfig.MaxBlockingTimeOut)
			{
				this.IsFinishMove = true;
				this.IsFinishMoveOnFailure = true;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorRailMove;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[MotorcycleSimpleMoveToRailMoveData] Finish move on blocking";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("BlockingTime", this.BlockingTime);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.IsFinishMove = (this.CurrentTime >= this.Time);
		}

		// Token: 0x0603C17A RID: 246138 RVA: 0x01119F80 File Offset: 0x01118180
		private void UpdateIsBlocked(float deltaSeconds)
		{
			if (!this.CommonConfig.EnableBlockingCheck)
			{
				return;
			}
			if (this.IsFinishMove)
			{
				return;
			}
			bool component = this.OwnerEntity.GetComponent<VehicleActorComponent>() != null;
			VehicleMoveComponent component2 = this.OwnerEntity.GetComponent<VehicleMoveComponent>();
			if (!component || component2 == null || component2.VehicleMovement == null)
			{
				return;
			}
			bool isBlocked = this.IsBlocked;
			this.TmpTransform1.Set(this.CurrentLocation, this.CurrentRotator.Quaternion(null), Vector.OneVectorProxy);
			this.IsBlocked = !component2.VehicleMovement.IsValidTransform(this.TmpTransform1.ToUeTransform(), new TArray<AActor>());
			if (this.IsBlocked)
			{
				float num = isBlocked ? Math.Min(deltaSeconds, this.BasicRailMoveConfig.MaxDeltaTimeForMoveUpdate) : 0f;
				this.BlockingTime += num;
				return;
			}
			this.BlockingTime = 0f;
		}

		// Token: 0x0401FC96 RID: 130198
		public readonly MotorcycleRailMoveConfig MoveConfig = new MotorcycleRailMoveConfig();

		// Token: 0x0401FC97 RID: 130199
		[Nullable(2)]
		public SplineCurve TargetSpline;

		// Token: 0x0401FC98 RID: 130200
		[Nullable(2)]
		public TRailMoveUpdater MoveUpdater;

		// Token: 0x0401FC99 RID: 130201
		[Nullable(2)]
		public TRailMoveGetter MoveGetter;

		// Token: 0x0401FC9A RID: 130202
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x0401FC9B RID: 130203
		private readonly Vector TargetLocation = Vector.Create();

		// Token: 0x0401FC9C RID: 130204
		private readonly Vector Velocity = Vector.Create();

		// Token: 0x0401FC9D RID: 130205
		private readonly Quat StartQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0401FC9E RID: 130206
		private readonly Quat TargetQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0401FC9F RID: 130207
		private float Time;

		// Token: 0x0401FCA0 RID: 130208
		private float CurrentTime;

		// Token: 0x0401FCA1 RID: 130209
		private readonly Vector CurrentLocation = Vector.Create();

		// Token: 0x0401FCA2 RID: 130210
		private readonly Rotator CurrentRotator = Rotator.Create();

		// Token: 0x0401FCA3 RID: 130211
		private readonly RailMoveContext RailMoveContext = new RailMoveContext();

		// Token: 0x0401FCA4 RID: 130212
		private readonly Vector TmpVector1 = Vector.Create();

		// Token: 0x0401FCA5 RID: 130213
		private readonly Rotator TmpRotator1 = Rotator.Create();

		// Token: 0x0401FCA6 RID: 130214
		private readonly Transform TmpTransform1 = Transform.Create();

		// Token: 0x0401FCA7 RID: 130215
		private bool IsBlocked;

		// Token: 0x0401FCA8 RID: 130216
		private float BlockingTime;
	}
}
