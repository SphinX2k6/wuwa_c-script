using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.Common.Component;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x02007033 RID: 28723
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleJumpFromRailMoveData : MotorcycleRailMoveDataBase
	{
		// Token: 0x06045EDE RID: 286430 RVA: 0x01169488 File Offset: 0x01167688
		public MotorcycleJumpFromRailMoveData(Entity owner, [Nullable(2)] MotorcycleRailComponent relatedRail) : base(EMotorcycleRailMoveDataType.JumpFromRail, owner, relatedRail)
		{
		}

		// Token: 0x17009BDD RID: 39901
		// (get) Token: 0x06045EDF RID: 286431 RVA: 0x01169560 File Offset: 0x01167760
		private JumpOffRailConfig JumpOffRailConfig
		{
			get
			{
				return this.MoveConfig.JumpOffRailConfig;
			}
		}

		// Token: 0x17009BDE RID: 39902
		// (get) Token: 0x06045EE0 RID: 286432 RVA: 0x0116956D File Offset: 0x0116776D
		private ParabolaMoveConfig ParabolaMoveConfig
		{
			get
			{
				return this.MoveConfig.JumpOffRailConfig.ParabolaMoveConfig;
			}
		}

		// Token: 0x17009BDF RID: 39903
		// (get) Token: 0x06045EE1 RID: 286433 RVA: 0x0116957F File Offset: 0x0116777F
		private CommonConfig CommonConfig
		{
			get
			{
				return this.MoveConfig.JumpOffRailConfig.CommonConfig;
			}
		}

		// Token: 0x17009BE0 RID: 39904
		// (get) Token: 0x06045EE2 RID: 286434 RVA: 0x01169591 File Offset: 0x01167791
		private BasicRailMoveConfig BasicRailMoveConfig
		{
			get
			{
				return this.MoveConfig.BasicRailMoveConfig;
			}
		}

		// Token: 0x06045EE3 RID: 286435 RVA: 0x0116959E File Offset: 0x0116779E
		public override void OnTick(float deltaSeconds)
		{
			this.TickUpdateMove(deltaSeconds);
			this.UpdateIsBlocked(deltaSeconds);
			this.ApplyMove();
			this.UpdateIsFinishMove();
		}

		// Token: 0x06045EE4 RID: 286436 RVA: 0x011695BC File Offset: 0x011677BC
		[NullableContext(2)]
		public unsafe override bool OnEnter(MotorcycleRailMoveDataBase lastRailMoveData)
		{
			if (this.Spline == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorRailMove;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[MotorcycleJumpFromRailMoveData] OnEnter Failed: Spline is undefined";
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
				string message2 = "[MotorcycleJumpFromRailMoveData] OnEnter Failed: Duration有误";
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
				string message3 = "[MotorcycleJumpFromRailMoveData] OnEnter Failed: 拿不到位置旋转";
				string item3 = "SplineId";
				MotorcycleRailComponent relatedRail3 = this.RelatedRail;
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item3, (relatedRail3 != null) ? new int?(relatedRail3.GetRailSplineId()) : null);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			this.CurrentLocation.FromUeVector(this.StartLocation);
			this.CurrentRotator.FromUeRotator(this.StartRotation);
			Vector tmpVector = this.TmpVector1;
			Vector tmpVector2 = this.TmpVector2;
			Vector tmpVector3 = this.TmpVector3;
			Vector tmpVector4 = this.TmpVector4;
			Vector tmpVector5 = this.TmpVector5;
			if (lastRailMoveData == null || !lastRailMoveData.GetVelocity(tmpVector))
			{
				TRailMoveGetter moveGetter2 = this.MoveGetter;
				if (moveGetter2 == null || !moveGetter2(null, null, tmpVector))
				{
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.MotorRailMove;
					ELogAuthor author4 = ELogAuthor.ZYL;
					string message4 = "[MotorcycleJumpFromRailMoveData] OnEnter Failed: 拿不到速度";
					string item4 = "SplineId";
					MotorcycleRailComponent relatedRail4 = this.RelatedRail;
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>(item4, (relatedRail4 != null) ? new int?(relatedRail4.GetRailSplineId()) : null);
					instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					return false;
				}
			}
			if (tmpVector.IsNearlyZero(1.0))
			{
				tmpVector.Reset();
			}
			this.CurrentRotator.Quaternion(null).GetForwardVector(tmpVector2);
			if (tmpVector2.IsNearlyZero(9.999999747378752E-05))
			{
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.MotorRailMove;
				ELogAuthor author5 = ELogAuthor.ZYL;
				string message5 = "[MotorcycleJumpFromRailMoveData] OnEnter Failed: 朝向出错";
				string item5 = "SplineId";
				MotorcycleRailComponent relatedRail5 = this.RelatedRail;
				ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>(item5, (relatedRail5 != null) ? new int?(relatedRail5.GetRailSplineId()) : null);
				instance5.Warn(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
				return false;
			}
			if (!tmpVector.IsNearlyZero(9.999999747378752E-05) && MathUtils.Instance.DotProduct(tmpVector, tmpVector2) < 0.0)
			{
				Log instance6 = Log.Instance;
				ELogModule module6 = ELogModule.MotorRailMove;
				ELogAuthor author6 = ELogAuthor.ZYL;
				string message6 = "[MotorcycleJumpFromRailMoveData] OnEnter Failed: 朝向和运动方向相反";
				string item6 = "SplineId";
				MotorcycleRailComponent relatedRail6 = this.RelatedRail;
				ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>(item6, (relatedRail6 != null) ? new int?(relatedRail6.GetRailSplineId()) : null);
				instance6.Warn(module6, author6, message6, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
				return false;
			}
			int num = 0;
			if (this.JumpSideDir == EMotorcycleSide.Left)
			{
				num = -1;
			}
			else if (this.JumpSideDir == EMotorcycleSide.Right)
			{
				num = 1;
			}
			tmpVector3.Set(0.0, (double)(this.JumpOffRailConfig.SideOffsetAbs * (float)num), 0.0);
			this.StartRotation.Quaternion(null).RotateVector(tmpVector3, tmpVector3);
			this.StartLocation.Addition(tmpVector3, this.EndLocation);
			tmpVector.Multiply((double)this.ParabolaMoveConfig.Duration, tmpVector3);
			this.EndLocation.Addition(tmpVector3, this.EndLocation);
			this.StartRotation.Quaternion(null).GetForwardVector(tmpVector4);
			this.GravityDir.UnaryNegation(tmpVector5);
			MathUtils.Instance.LookRotationForwardFirst(tmpVector4, tmpVector5, this.EndRotation);
			Vector tmpVector6 = this.TmpVector1;
			Vector tmpVector7 = this.TmpVector2;
			Vector tmpVector8 = this.TmpVector3;
			Vector tmpVector9 = this.TmpVector4;
			this.EndLocation.Subtraction(this.StartLocation, tmpVector6);
			double inB = Vector.DotProduct(tmpVector6, this.GravityDir);
			this.GravityDir.Multiply(inB, tmpVector7);
			tmpVector6.Subtraction(tmpVector7, tmpVector8);
			tmpVector8.Division((double)this.ParabolaMoveConfig.Duration, this.PlaneVelocity);
			this.GravityDir.Multiply((double)this.ParabolaMoveConfig.GravityAccelerationAbs, tmpVector9);
			tmpVector7.Addition(tmpVector9.MultiplyEqual((double)(-0.5f * this.ParabolaMoveConfig.Duration * this.ParabolaMoveConfig.Duration)), this.CurrentGravityUpVelocity);
			this.CurrentGravityUpVelocity.DivisionEqual((double)this.ParabolaMoveConfig.Duration);
			BaseTagComponent component = this.OwnerEntity.GetComponent<BaseTagComponent>();
			foreach (KeyValuePair<int, bool> keyValuePair in this.CommonConfig.ModifyVehicleTagsOnEnter)
			{
				int num2;
				bool flag;
				keyValuePair.Deconstruct(out num2, out flag);
				int value = num2;
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

		// Token: 0x06045EE5 RID: 286437 RVA: 0x01169B3C File Offset: 0x01167D3C
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

		// Token: 0x06045EE6 RID: 286438 RVA: 0x01169BCC File Offset: 0x01167DCC
		public override bool GetVelocity(Vector outVelocity)
		{
			this.CurrentGravityUpVelocity.Addition(this.PlaneVelocity, outVelocity);
			return true;
		}

		// Token: 0x06045EE7 RID: 286439 RVA: 0x01169BE4 File Offset: 0x01167DE4
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
			this.GravityDir.Multiply((double)(0.5f * this.ParabolaMoveConfig.GravityAccelerationAbs * num * num), tmpVector);
			tmpVector3.AdditionEqual(tmpVector);
			this.CurrentLocation.AdditionEqual(tmpVector3);
			Vector tmpVector4 = this.TmpVector1;
			this.GravityDir.Multiply((double)(this.ParabolaMoveConfig.GravityAccelerationAbs * num), tmpVector4);
			this.CurrentGravityUpVelocity.AdditionEqual(tmpVector4);
			Rotator.Lerp(this.StartRotation, this.EndRotation, this.CurrentMovingTime / this.ParabolaMoveConfig.Duration, this.CurrentRotator);
		}

		// Token: 0x06045EE8 RID: 286440 RVA: 0x01169CF0 File Offset: 0x01167EF0
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

		// Token: 0x06045EE9 RID: 286441 RVA: 0x01169D50 File Offset: 0x01167F50
		private unsafe void UpdateIsFinishMove()
		{
			if (this.CommonConfig.EnableBlockingCheck && this.IsBlocked && this.BlockingTime > this.CommonConfig.MaxBlockingTimeOut)
			{
				this.IsFinishMove = true;
				this.IsFinishMoveOnFailure = true;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorRailMove;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[MotorcycleJumpFromRailMoveData] Finish move on blocking";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BlockingTime", this.BlockingTime);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurrentLocation", this.CurrentLocation);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.IsFinishMove = (this.CurrentMovingTime >= this.ParabolaMoveConfig.Duration);
		}

		// Token: 0x06045EEA RID: 286442 RVA: 0x01169E1C File Offset: 0x0116801C
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
			this.IsBlocked = !component2.VehicleMovement.IsValidTransform(this.TmpTransform1.ToUeTransform(), null);
			if (this.IsBlocked)
			{
				float num = isBlocked ? Math.Min(deltaSeconds, this.BasicRailMoveConfig.MaxDeltaTimeForMoveUpdate) : 0f;
				this.BlockingTime += num;
				return;
			}
			this.BlockingTime = 0f;
		}

		// Token: 0x04024934 RID: 149812
		public readonly MotorcycleRailMoveConfig MoveConfig = new MotorcycleRailMoveConfig();

		// Token: 0x04024935 RID: 149813
		[Nullable(2)]
		public SplineCurve Spline;

		// Token: 0x04024936 RID: 149814
		public List<IMotorSlideSplinePoint> SplinePointOptions = new List<IMotorSlideSplinePoint>();

		// Token: 0x04024937 RID: 149815
		public Vector GravityDir = Vector.Create();

		// Token: 0x04024938 RID: 149816
		public EMotorcycleSide JumpSideDir = EMotorcycleSide.Middle;

		// Token: 0x04024939 RID: 149817
		[Nullable(2)]
		public TRailMoveUpdater MoveUpdater;

		// Token: 0x0402493A RID: 149818
		[Nullable(2)]
		public TRailMoveGetter MoveGetter;

		// Token: 0x0402493B RID: 149819
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x0402493C RID: 149820
		private readonly Vector EndLocation = Vector.Create();

		// Token: 0x0402493D RID: 149821
		private readonly Rotator StartRotation = Rotator.Create();

		// Token: 0x0402493E RID: 149822
		private readonly Rotator EndRotation = Rotator.Create();

		// Token: 0x0402493F RID: 149823
		private readonly Vector PlaneVelocity = Vector.Create();

		// Token: 0x04024940 RID: 149824
		private readonly Vector CurrentGravityUpVelocity = Vector.Create();

		// Token: 0x04024941 RID: 149825
		private readonly Vector CurrentLocation = Vector.Create();

		// Token: 0x04024942 RID: 149826
		private readonly Rotator CurrentRotator = Rotator.Create();

		// Token: 0x04024943 RID: 149827
		private float CurrentMovingTime;

		// Token: 0x04024944 RID: 149828
		private readonly Vector TmpVector1 = Vector.Create();

		// Token: 0x04024945 RID: 149829
		private readonly Vector TmpVector2 = Vector.Create();

		// Token: 0x04024946 RID: 149830
		private readonly Vector TmpVector3 = Vector.Create();

		// Token: 0x04024947 RID: 149831
		private readonly Vector TmpVector4 = Vector.Create();

		// Token: 0x04024948 RID: 149832
		private readonly Vector TmpVector5 = Vector.Create();

		// Token: 0x04024949 RID: 149833
		private readonly Transform TmpTransform1 = Transform.Create();

		// Token: 0x0402494A RID: 149834
		private bool IsBlocked;

		// Token: 0x0402494B RID: 149835
		private float BlockingTime;
	}
}
