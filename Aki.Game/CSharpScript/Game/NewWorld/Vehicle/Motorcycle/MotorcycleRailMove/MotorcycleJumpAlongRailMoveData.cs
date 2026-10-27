using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x02007032 RID: 28722
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleJumpAlongRailMoveData : MotorcycleRailMoveDataBase
	{
		// Token: 0x06045ED2 RID: 286418 RVA: 0x01168A60 File Offset: 0x01166C60
		public MotorcycleJumpAlongRailMoveData(Entity owner, [Nullable(2)] MotorcycleRailComponent relatedRail) : base(EMotorcycleRailMoveDataType.JumpAlongRail, owner, relatedRail)
		{
		}

		// Token: 0x17009BDA RID: 39898
		// (get) Token: 0x06045ED3 RID: 286419 RVA: 0x01168B2D File Offset: 0x01166D2D
		private ParabolaMoveConfig ParabolaMoveConfig
		{
			get
			{
				return this.MoveConfig.JumpAlongRailConfig.ParabolaMoveConfig;
			}
		}

		// Token: 0x17009BDB RID: 39899
		// (get) Token: 0x06045ED4 RID: 286420 RVA: 0x01168B3F File Offset: 0x01166D3F
		private CommonConfig CommonConfig
		{
			get
			{
				return this.MoveConfig.JumpAlongRailConfig.CommonConfig;
			}
		}

		// Token: 0x17009BDC RID: 39900
		// (get) Token: 0x06045ED5 RID: 286421 RVA: 0x01168B51 File Offset: 0x01166D51
		private BasicRailMoveConfig BasicRailMoveConfig
		{
			get
			{
				return this.MoveConfig.BasicRailMoveConfig;
			}
		}

		// Token: 0x06045ED6 RID: 286422 RVA: 0x01168B5E File Offset: 0x01166D5E
		public override void OnTick(float deltaSeconds)
		{
			this.TickUpdateMove(deltaSeconds);
			this.UpdateIsBlocked(deltaSeconds);
			this.ApplyMove();
			this.UpdateIsFinishMove();
		}

		// Token: 0x06045ED7 RID: 286423 RVA: 0x01168B7C File Offset: 0x01166D7C
		[NullableContext(2)]
		public unsafe override bool OnEnter(MotorcycleRailMoveDataBase lastRailMoveData)
		{
			if (this.TargetSpline == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorRailMove;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[MotorcycleJumpAlongRailMoveData] OnEnter Failed: Spline is undefined";
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
				string message2 = "[MotorcycleJumpAlongRailMoveData] OnEnter Failed: Duration有误";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item2 = "SplineId";
				MotorcycleRailComponent relatedRail2 = this.RelatedRail;
				ptr = new ValueTuple<string, object>(item2, (relatedRail2 != null) ? new int?(relatedRail2.GetRailSplineId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Duration", this.ParabolaMoveConfig.Duration);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			TRailMoveGetter moveGetter = this.MoveGetter;
			if (moveGetter == null || !moveGetter(this.StartLocation, this.StartRotation, null))
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.MotorRailMove;
				ELogAuthor author3 = ELogAuthor.ZYL;
				string message3 = "[MotorcycleJumpAlongRailMoveData] OnEnter Failed: 拿不到位置旋转";
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
			if ((lastRailMoveData == null || !lastRailMoveData.GetVelocity(this.RailMoveContext.SourceVel)) && !this.MoveGetter(null, null, this.RailMoveContext.SourceVel))
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.MotorRailMove;
				ELogAuthor author4 = ELogAuthor.ZYL;
				string message4 = "[MotorcycleJumpAlongRailMoveData] OnEnter Failed: 拿不到速度";
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
			this.RailMoveContext.IsForward = this.TargetIsForward;
			if (!MotorcycleRailMoveUtils.Instance.CalcRailMoveTargetAdvanceBySpeed(this.RailMoveContext, (double)this.ParabolaMoveConfig.Duration, (double)this.ParabolaMoveConfig.MinSpeedAlongRail, (double)this.ParabolaMoveConfig.MaxSpeedAlongRail))
			{
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.MotorRailMove;
				ELogAuthor author5 = ELogAuthor.ZYL;
				string message5 = "[MotorcycleJumpAlongRailMoveData] OnEnter Failed: 计算终点失败";
				string item5 = "SplineId";
				MotorcycleRailComponent relatedRail5 = this.RelatedRail;
				ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>(item5, (relatedRail5 != null) ? new int?(relatedRail5.GetRailSplineId()) : null);
				instance5.Warn(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
				return false;
			}
			TRailMoveChecker[] checkList = new TRailMoveChecker[]
			{
				new TRailMoveChecker(MotorcycleRailMoveUtils.Instance.RailMoveCheckerCheckVehicleNotReverseMove),
				MotorcycleRailMoveUtils.Instance.RailMoveCheckerCheckRailLenLeft
			};
			if (!MotorcycleRailMoveUtils.Instance.ExecCheckList(this.RailMoveContext, null, checkList, true, "MotorcycleJumpAlongRailMoveData"))
			{
				Log instance6 = Log.Instance;
				ELogModule module6 = ELogModule.MotorRailMove;
				ELogAuthor author6 = ELogAuthor.ZYL;
				string message6 = "[MotorcycleJumpAlongRailMoveData] OnEnter Failed: 检查不通过";
				string item6 = "SplineId";
				MotorcycleRailComponent relatedRail6 = this.RelatedRail;
				ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>(item6, (relatedRail6 != null) ? new int?(relatedRail6.GetRailSplineId()) : null);
				instance6.Warn(module6, author6, message6, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
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
			return true;
		}

		// Token: 0x06045ED8 RID: 286424 RVA: 0x011690D0 File Offset: 0x011672D0
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

		// Token: 0x06045ED9 RID: 286425 RVA: 0x01169160 File Offset: 0x01167360
		public override bool GetVelocity(Vector outVelocity)
		{
			this.CurrentGravityUpVelocity.Addition(this.PlaneVelocity, outVelocity);
			return true;
		}

		// Token: 0x06045EDA RID: 286426 RVA: 0x01169178 File Offset: 0x01167378
		public void TickUpdateMove(float deltaSeconds)
		{
			float num = Math.Min(Math.Min(this.ParabolaMoveConfig.Duration - this.CurrentMovingTime, deltaSeconds), this.BasicRailMoveConfig.MaxDeltaTimeForMoveUpdate);
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

		// Token: 0x06045EDB RID: 286427 RVA: 0x01169288 File Offset: 0x01167488
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

		// Token: 0x06045EDC RID: 286428 RVA: 0x011692E8 File Offset: 0x011674E8
		private unsafe void UpdateIsFinishMove()
		{
			if (this.CommonConfig.EnableBlockingCheck && this.IsBlocked && this.BlockingTime > this.CommonConfig.MaxBlockingTimeOut)
			{
				this.IsFinishMove = true;
				this.IsFinishMoveOnFailure = true;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorRailMove;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[MotorcycleJumpAlongRailMoveData] Finish move on blocking";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BlockingTime", this.BlockingTime);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurrentLocation", this.CurrentLocation);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.IsFinishMove = (this.CurrentMovingTime >= this.ParabolaMoveConfig.Duration);
		}

		// Token: 0x06045EDD RID: 286429 RVA: 0x011693B4 File Offset: 0x011675B4
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

		// Token: 0x0402491D RID: 149789
		public MotorcycleRailMoveConfig MoveConfig = new MotorcycleRailMoveConfig();

		// Token: 0x0402491E RID: 149790
		[Nullable(2)]
		public SplineCurve TargetSpline;

		// Token: 0x0402491F RID: 149791
		public bool TargetIsForward = true;

		// Token: 0x04024920 RID: 149792
		public Vector GravityDir = Vector.Create();

		// Token: 0x04024921 RID: 149793
		[Nullable(2)]
		public TRailMoveUpdater MoveUpdater;

		// Token: 0x04024922 RID: 149794
		[Nullable(2)]
		public TRailMoveGetter MoveGetter;

		// Token: 0x04024923 RID: 149795
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x04024924 RID: 149796
		private readonly Vector EndLocation = Vector.Create();

		// Token: 0x04024925 RID: 149797
		private readonly Rotator StartRotation = Rotator.Create();

		// Token: 0x04024926 RID: 149798
		private readonly Rotator EndRotation = Rotator.Create();

		// Token: 0x04024927 RID: 149799
		private readonly Vector PlaneVelocity = Vector.Create();

		// Token: 0x04024928 RID: 149800
		private readonly Vector CurrentGravityUpVelocity = Vector.Create();

		// Token: 0x04024929 RID: 149801
		private readonly Vector CurrentLocation = Vector.Create();

		// Token: 0x0402492A RID: 149802
		private readonly Rotator CurrentRotator = Rotator.Create();

		// Token: 0x0402492B RID: 149803
		private float CurrentMovingTime;

		// Token: 0x0402492C RID: 149804
		private readonly RailMoveContext RailMoveContext = new RailMoveContext();

		// Token: 0x0402492D RID: 149805
		private readonly Vector TmpVector1 = Vector.Create();

		// Token: 0x0402492E RID: 149806
		private readonly Vector TmpVector2 = Vector.Create();

		// Token: 0x0402492F RID: 149807
		private readonly Vector TmpVector3 = Vector.Create();

		// Token: 0x04024930 RID: 149808
		private readonly Vector TmpVector4 = Vector.Create();

		// Token: 0x04024931 RID: 149809
		private readonly Transform TmpTransform1 = Transform.Create();

		// Token: 0x04024932 RID: 149810
		private bool IsBlocked;

		// Token: 0x04024933 RID: 149811
		private float BlockingTime;
	}
}
