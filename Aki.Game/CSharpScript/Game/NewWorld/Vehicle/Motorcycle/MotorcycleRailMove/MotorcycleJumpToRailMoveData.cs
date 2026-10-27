using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x02007034 RID: 28724
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleJumpToRailMoveData : MotorcycleRailMoveDataBase
	{
		// Token: 0x06045EEB RID: 286443 RVA: 0x01169EEC File Offset: 0x011680EC
		public MotorcycleJumpToRailMoveData(Entity owner, [Nullable(2)] MotorcycleRailComponent relatedRail) : base(EMotorcycleRailMoveDataType.JumpToRail, owner, relatedRail)
		{
		}

		// Token: 0x17009BE1 RID: 39905
		// (get) Token: 0x06045EEC RID: 286444 RVA: 0x01169FB2 File Offset: 0x011681B2
		private JumpToRailConfig JumpToRailConfig
		{
			get
			{
				return this.MoveConfig.JumpToRailConfig;
			}
		}

		// Token: 0x17009BE2 RID: 39906
		// (get) Token: 0x06045EED RID: 286445 RVA: 0x01169FBF File Offset: 0x011681BF
		private ParabolaMoveConfig ParabolaMoveConfig
		{
			get
			{
				return this.MoveConfig.JumpToRailConfig.ParabolaMoveConfig;
			}
		}

		// Token: 0x17009BE3 RID: 39907
		// (get) Token: 0x06045EEE RID: 286446 RVA: 0x01169FD1 File Offset: 0x011681D1
		private CommonConfig CommonConfig
		{
			get
			{
				return this.MoveConfig.JumpToRailConfig.CommonConfig;
			}
		}

		// Token: 0x17009BE4 RID: 39908
		// (get) Token: 0x06045EEF RID: 286447 RVA: 0x01169FE3 File Offset: 0x011681E3
		private BasicRailMoveConfig BasicRailMoveConfig
		{
			get
			{
				return this.MoveConfig.BasicRailMoveConfig;
			}
		}

		// Token: 0x06045EF0 RID: 286448 RVA: 0x01169FF0 File Offset: 0x011681F0
		public override void OnTick(float deltaSeconds)
		{
			this.TickUpdateMove(deltaSeconds);
			this.UpdateIsBlocked(deltaSeconds);
			this.ApplyMove();
			this.UpdateIsFinishMove();
		}

		// Token: 0x06045EF1 RID: 286449 RVA: 0x0116A00C File Offset: 0x0116820C
		[NullableContext(2)]
		public unsafe override bool OnEnter(MotorcycleRailMoveDataBase lastRailMoveData)
		{
			if (this.TargetSpline == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorRailMove;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[MotorcycleJumpToRailMoveData] OnEnter Failed: Spline is undefined";
				string item = "SplineId";
				MotorcycleRailComponent relatedRail = this.RelatedRail;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (relatedRail != null) ? new int?(relatedRail.GetRailSplineId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			if (this.ParabolaMoveConfig.Duration <= 0f)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.MotorRailMove;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "[MotorcycleJumpToRailMoveData] OnEnter Failed: Duration有误";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item2 = "SplineId";
				MotorcycleRailComponent relatedRail2 = this.RelatedRail;
				ptr = new ValueTuple<string, object>(item2, (relatedRail2 != null) ? new int?(relatedRail2.GetRailSplineId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Duration", this.ParabolaMoveConfig.Duration);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			if (this.MoveGetter == null || !this.MoveGetter(this.StartLocation, this.StartRotation, null))
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.MotorRailMove;
				ELogAuthor author3 = ELogAuthor.ZYL;
				string message3 = "[MotorcycleJumpToRailMoveData] OnEnter Failed: 拿不到位置旋转";
				string item3 = "SplineId";
				MotorcycleRailComponent relatedRail3 = this.RelatedRail;
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item3, (relatedRail3 != null) ? new int?(relatedRail3.GetRailSplineId()) : null);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			this.CurrentLocation.FromUeVector(this.StartLocation);
			this.CurrentRotator.FromUeRotator(this.StartRotation);
			this.RailMoveContext.SourceLoc.FromUeVector(this.StartLocation);
			this.RailMoveContext.SourceRot.FromUeRotator(this.StartRotation);
			this.RailMoveContext.RailSpline = this.TargetSpline;
			if ((lastRailMoveData == null || !lastRailMoveData.GetVelocity(this.RailMoveContext.SourceVel)) && (this.MoveGetter == null || !this.MoveGetter(null, null, this.RailMoveContext.SourceVel)))
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.MotorRailMove;
				ELogAuthor author4 = ELogAuthor.ZYL;
				string message4 = "[MotorcycleJumpToRailMoveData] OnEnter Failed: 拿不到速度";
				string item4 = "SplineId";
				MotorcycleRailComponent relatedRail4 = this.RelatedRail;
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>(item4, (relatedRail4 != null) ? new int?(relatedRail4.GetRailSplineId()) : null);
				instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
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
			bool flag = MotorcycleRailMoveUtils.Instance.CalcRailMoveTargetNotAdvanceBySpeed(this.RailMoveContext, (double)this.ParabolaMoveConfig.MinSpeedAlongRail, (double)this.ParabolaMoveConfig.MaxSpeedAlongRail);
			if (flag)
			{
				flag = MotorcycleRailMoveUtils.Instance.ExecCheckList(this.RailMoveContext, this.JumpToRailConfig.EnterRailCondition, checkList, true, base.GetType().Name);
			}
			if (!flag)
			{
				this.RailMoveContext.IsForward = false;
				flag = MotorcycleRailMoveUtils.Instance.CalcRailMoveTargetNotAdvanceBySpeed(this.RailMoveContext, (double)this.ParabolaMoveConfig.MinSpeedAlongRail, (double)this.ParabolaMoveConfig.MaxSpeedAlongRail);
				if (flag)
				{
					flag = MotorcycleRailMoveUtils.Instance.ExecCheckList(this.RailMoveContext, this.JumpToRailConfig.EnterRailCondition, checkList, true, base.GetType().Name);
				}
			}
			if (!flag)
			{
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.MotorRailMove;
				ELogAuthor author5 = ELogAuthor.ZYL;
				string message5 = "[MotorcycleJumpToRailMoveData] OnEnter Failed: 计算终点并检查失败";
				string item5 = "SplineId";
				MotorcycleRailComponent relatedRail5 = this.RelatedRail;
				ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>(item5, (relatedRail5 != null) ? new int?(relatedRail5.GetRailSplineId()) : null);
				instance5.Warn(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
				return false;
			}
			this.EndLocation.FromUeVector(this.RailMoveContext.RailMoveTarget.TargetLoc);
			this.EndRotation.FromUeRotator(this.RailMoveContext.RailMoveTarget.TargetRot);
			Vector tmpVector = this.TmpVector1;
			Vector tmpVector2 = this.TmpVector2;
			Vector tmpVector3 = this.TmpVector3;
			Vector tmpVector4 = this.TmpVector4;
			this.EndLocation.Subtraction(this.StartLocation, tmpVector);
			double inB = Vector.DotProduct(tmpVector, this.GravityDir);
			this.GravityDir.Multiply(inB, tmpVector2);
			tmpVector.Subtraction(tmpVector2, tmpVector3);
			tmpVector3.Division((double)this.ParabolaMoveConfig.Duration, this.PlaneVelocity);
			this.GravityDir.Multiply((double)this.ParabolaMoveConfig.GravityAccelerationAbs, tmpVector4);
			tmpVector2.Addition(tmpVector4.MultiplyEqual(-0.5 * (double)this.ParabolaMoveConfig.Duration * (double)this.ParabolaMoveConfig.Duration), this.CurrentGravityUpVelocity);
			this.CurrentGravityUpVelocity.DivisionEqual((double)this.ParabolaMoveConfig.Duration);
			BaseTagComponent component = this.OwnerEntity.GetComponent<BaseTagComponent>();
			foreach (KeyValuePair<int, bool> keyValuePair in this.CommonConfig.ModifyVehicleTagsOnEnter)
			{
				int num;
				bool flag2;
				keyValuePair.Deconstruct(out num, out flag2);
				int value = num;
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

		// Token: 0x06045EF2 RID: 286450 RVA: 0x0116A5D8 File Offset: 0x011687D8
		public override void OnExit()
		{
			BaseTagComponent component = this.OwnerEntity.GetComponent<BaseTagComponent>();
			foreach (KeyValuePair<int, bool> keyValuePair in this.CommonConfig.ModifyVehicleTagsOnExit)
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

		// Token: 0x06045EF3 RID: 286451 RVA: 0x0116A668 File Offset: 0x01168868
		public override bool GetVelocity(Vector outVelocity)
		{
			this.CurrentGravityUpVelocity.Addition(this.PlaneVelocity, outVelocity);
			return true;
		}

		// Token: 0x06045EF4 RID: 286452 RVA: 0x0116A680 File Offset: 0x01168880
		public void TickUpdateMove(float deltaSeconds)
		{
			float num = Math.Min(this.ParabolaMoveConfig.Duration - this.CurrentMovingTime, deltaSeconds);
			num = Math.Min(num, this.BasicRailMoveConfig.MaxDeltaTimeForMoveUpdate);
			this.CurrentMovingTime += num;
			Vector tmpVector = this.TmpVector1;
			Vector tmpVector2 = this.TmpVector2;
			Vector tmpVector3 = this.TmpVector3;
			this.PlaneVelocity.Addition(this.CurrentGravityUpVelocity, tmpVector2);
			tmpVector2.Multiply((double)num, tmpVector3);
			this.GravityDir.Multiply(0.5 * (double)this.ParabolaMoveConfig.GravityAccelerationAbs * (double)num * (double)num, tmpVector);
			tmpVector3.AdditionEqual(tmpVector);
			this.CurrentLocation.AdditionEqual(tmpVector3);
			Vector tmpVector4 = this.TmpVector1;
			this.GravityDir.Multiply((double)(this.ParabolaMoveConfig.GravityAccelerationAbs * num), tmpVector4);
			this.CurrentGravityUpVelocity.AdditionEqual(tmpVector4);
			Rotator.Lerp(this.StartRotation, this.EndRotation, this.CurrentMovingTime / this.ParabolaMoveConfig.Duration, this.CurrentRotator);
		}

		// Token: 0x06045EF5 RID: 286453 RVA: 0x0116A794 File Offset: 0x01168994
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

		// Token: 0x06045EF6 RID: 286454 RVA: 0x0116A7F4 File Offset: 0x011689F4
		private unsafe void UpdateIsFinishMove()
		{
			if (this.CommonConfig.EnableBlockingCheck && this.IsBlocked && this.BlockingTime > this.CommonConfig.MaxBlockingTimeOut)
			{
				this.IsFinishMove = true;
				this.IsFinishMoveOnFailure = true;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorRailMove;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[MotorcycleJumpToRailMoveData] Finish move on blocking";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BlockingTime", this.BlockingTime);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurrentLocation", this.CurrentLocation);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.IsFinishMove = (this.CurrentMovingTime >= this.ParabolaMoveConfig.Duration);
		}

		// Token: 0x06045EF7 RID: 286455 RVA: 0x0116A8C0 File Offset: 0x01168AC0
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
			if (!component || ((component2 != null) ? component2.VehicleMovement : null) == null)
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

		// Token: 0x0402494C RID: 149836
		public readonly MotorcycleRailMoveConfig MoveConfig = new MotorcycleRailMoveConfig();

		// Token: 0x0402494D RID: 149837
		[Nullable(2)]
		public SplineCurve TargetSpline;

		// Token: 0x0402494E RID: 149838
		public Vector GravityDir = Vector.Create();

		// Token: 0x0402494F RID: 149839
		[Nullable(2)]
		public TRailMoveUpdater MoveUpdater;

		// Token: 0x04024950 RID: 149840
		[Nullable(2)]
		public TRailMoveGetter MoveGetter;

		// Token: 0x04024951 RID: 149841
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x04024952 RID: 149842
		private readonly Vector EndLocation = Vector.Create();

		// Token: 0x04024953 RID: 149843
		private readonly Rotator StartRotation = Rotator.Create();

		// Token: 0x04024954 RID: 149844
		private readonly Rotator EndRotation = Rotator.Create();

		// Token: 0x04024955 RID: 149845
		private readonly Vector PlaneVelocity = Vector.Create();

		// Token: 0x04024956 RID: 149846
		private readonly Vector CurrentGravityUpVelocity = Vector.Create();

		// Token: 0x04024957 RID: 149847
		private readonly Vector CurrentLocation = Vector.Create();

		// Token: 0x04024958 RID: 149848
		private readonly Rotator CurrentRotator = Rotator.Create();

		// Token: 0x04024959 RID: 149849
		private float CurrentMovingTime;

		// Token: 0x0402495A RID: 149850
		private readonly RailMoveContext RailMoveContext = new RailMoveContext();

		// Token: 0x0402495B RID: 149851
		private readonly Vector TmpVector1 = Vector.Create();

		// Token: 0x0402495C RID: 149852
		private readonly Vector TmpVector2 = Vector.Create();

		// Token: 0x0402495D RID: 149853
		private readonly Vector TmpVector3 = Vector.Create();

		// Token: 0x0402495E RID: 149854
		private readonly Vector TmpVector4 = Vector.Create();

		// Token: 0x0402495F RID: 149855
		private readonly Transform TmpTransform1 = Transform.Create();

		// Token: 0x04024960 RID: 149856
		private bool IsBlocked;

		// Token: 0x04024961 RID: 149857
		private float BlockingTime;
	}
}
