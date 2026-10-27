using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x0200704D RID: 28749
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleSimpleMoveToRailMoveData : MotorcycleRailMoveDataBase
	{
		// Token: 0x06045F88 RID: 286600 RVA: 0x0116F954 File Offset: 0x0116DB54
		public MotorcycleSimpleMoveToRailMoveData(Entity owner, [Nullable(2)] MotorcycleRailComponent relatedRail) : base(EMotorcycleRailMoveDataType.SimpleMoveToRail, owner, relatedRail)
		{
		}

		// Token: 0x17009BE7 RID: 39911
		// (get) Token: 0x06045F89 RID: 286601 RVA: 0x0116FA36 File Offset: 0x0116DC36
		private DirectlyEnterRailConfig DirectlyEnterRailConfig
		{
			get
			{
				return this.MoveConfig.DirectlyEnterRailConfig;
			}
		}

		// Token: 0x17009BE8 RID: 39912
		// (get) Token: 0x06045F8A RID: 286602 RVA: 0x0116FA43 File Offset: 0x0116DC43
		private LinearMoveConfig LinearMoveConfig
		{
			get
			{
				return this.MoveConfig.DirectlyEnterRailConfig.LinearMoveConfig;
			}
		}

		// Token: 0x17009BE9 RID: 39913
		// (get) Token: 0x06045F8B RID: 286603 RVA: 0x0116FA55 File Offset: 0x0116DC55
		private CommonConfig CommonConfig
		{
			get
			{
				return this.MoveConfig.DirectlyEnterRailConfig.CommonConfig;
			}
		}

		// Token: 0x17009BEA RID: 39914
		// (get) Token: 0x06045F8C RID: 286604 RVA: 0x0116FA67 File Offset: 0x0116DC67
		private BasicRailMoveConfig BasicRailMoveConfig
		{
			get
			{
				return this.MoveConfig.BasicRailMoveConfig;
			}
		}

		// Token: 0x06045F8D RID: 286605 RVA: 0x0116FA74 File Offset: 0x0116DC74
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

		// Token: 0x06045F8E RID: 286606 RVA: 0x0116FF84 File Offset: 0x0116E184
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

		// Token: 0x06045F8F RID: 286607 RVA: 0x0117001C File Offset: 0x0116E21C
		public override void OnTick(float deltaSeconds)
		{
			this.TickUpdateMove(deltaSeconds);
			this.UpdateIsBlocked(deltaSeconds);
			this.ApplyMove();
			this.UpdateIsFinishMove();
		}

		// Token: 0x06045F90 RID: 286608 RVA: 0x01170038 File Offset: 0x0116E238
		public override bool GetVelocity(Vector outVelocity)
		{
			outVelocity.DeepCopy(this.Velocity);
			return true;
		}

		// Token: 0x06045F91 RID: 286609 RVA: 0x01170048 File Offset: 0x0116E248
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

		// Token: 0x06045F92 RID: 286610 RVA: 0x011700F4 File Offset: 0x0116E2F4
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

		// Token: 0x06045F93 RID: 286611 RVA: 0x01170154 File Offset: 0x0116E354
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

		// Token: 0x06045F94 RID: 286612 RVA: 0x011701E4 File Offset: 0x0116E3E4
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

		// Token: 0x040249E0 RID: 149984
		public readonly MotorcycleRailMoveConfig MoveConfig = new MotorcycleRailMoveConfig();

		// Token: 0x040249E1 RID: 149985
		[Nullable(2)]
		public SplineCurve TargetSpline;

		// Token: 0x040249E2 RID: 149986
		[Nullable(2)]
		public TRailMoveUpdater MoveUpdater;

		// Token: 0x040249E3 RID: 149987
		[Nullable(2)]
		public TRailMoveGetter MoveGetter;

		// Token: 0x040249E4 RID: 149988
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x040249E5 RID: 149989
		private readonly Vector TargetLocation = Vector.Create();

		// Token: 0x040249E6 RID: 149990
		private readonly Vector Velocity = Vector.Create();

		// Token: 0x040249E7 RID: 149991
		private readonly Quat StartQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040249E8 RID: 149992
		private readonly Quat TargetQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x040249E9 RID: 149993
		private float Time;

		// Token: 0x040249EA RID: 149994
		private float CurrentTime;

		// Token: 0x040249EB RID: 149995
		private readonly Vector CurrentLocation = Vector.Create();

		// Token: 0x040249EC RID: 149996
		private readonly Rotator CurrentRotator = Rotator.Create();

		// Token: 0x040249ED RID: 149997
		private readonly RailMoveContext RailMoveContext = new RailMoveContext();

		// Token: 0x040249EE RID: 149998
		private readonly Vector TmpVector1 = Vector.Create();

		// Token: 0x040249EF RID: 149999
		private readonly Rotator TmpRotator1 = Rotator.Create();

		// Token: 0x040249F0 RID: 150000
		private readonly Transform TmpTransform1 = Transform.Create();

		// Token: 0x040249F1 RID: 150001
		private bool IsBlocked;

		// Token: 0x040249F2 RID: 150002
		private float BlockingTime;
	}
}
