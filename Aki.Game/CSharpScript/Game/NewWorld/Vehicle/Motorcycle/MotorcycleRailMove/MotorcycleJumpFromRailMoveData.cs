using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.Common.Component;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x020061B4 RID: 25012
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleJumpFromRailMoveData : MotorcycleRailMoveDataBase
	{
		// Token: 0x0603C0C0 RID: 245952 RVA: 0x011132D4 File Offset: 0x011114D4
		public MotorcycleJumpFromRailMoveData(Entity owner, [Nullable(2)] MotorcycleRailComponent relatedRail) : base(EMotorcycleRailMoveDataType.JumpFromRail, owner, relatedRail)
		{
		}

		// Token: 0x1700714A RID: 29002
		// (get) Token: 0x0603C0C1 RID: 245953 RVA: 0x011133AC File Offset: 0x011115AC
		private JumpOffRailConfig JumpOffRailConfig
		{
			get
			{
				return this.MoveConfig.JumpOffRailConfig;
			}
		}

		// Token: 0x1700714B RID: 29003
		// (get) Token: 0x0603C0C2 RID: 245954 RVA: 0x011133B9 File Offset: 0x011115B9
		private ParabolaMoveConfig ParabolaMoveConfig
		{
			get
			{
				return this.MoveConfig.JumpOffRailConfig.ParabolaMoveConfig;
			}
		}

		// Token: 0x1700714C RID: 29004
		// (get) Token: 0x0603C0C3 RID: 245955 RVA: 0x011133CB File Offset: 0x011115CB
		private CommonConfig CommonConfig
		{
			get
			{
				return this.MoveConfig.JumpOffRailConfig.CommonConfig;
			}
		}

		// Token: 0x1700714D RID: 29005
		// (get) Token: 0x0603C0C4 RID: 245956 RVA: 0x011133DD File Offset: 0x011115DD
		private BasicRailMoveConfig BasicRailMoveConfig
		{
			get
			{
				return this.MoveConfig.BasicRailMoveConfig;
			}
		}

		// Token: 0x0603C0C5 RID: 245957 RVA: 0x011133EA File Offset: 0x011115EA
		public override void OnTick(float deltaSeconds)
		{
			this.TickUpdateMove(deltaSeconds);
			this.UpdateIsBlocked(deltaSeconds);
			this.ApplyMove();
			this.UpdateIsFinishMove();
		}

		// Token: 0x0603C0C6 RID: 245958 RVA: 0x01113408 File Offset: 0x01111608
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

		// Token: 0x0603C0C7 RID: 245959 RVA: 0x01113988 File Offset: 0x01111B88
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

		// Token: 0x0603C0C8 RID: 245960 RVA: 0x01113A18 File Offset: 0x01111C18
		public override bool GetVelocity(Vector outVelocity)
		{
			this.CurrentGravityUpVelocity.Addition(this.PlaneVelocity, outVelocity);
			return true;
		}

		// Token: 0x0603C0C9 RID: 245961 RVA: 0x01113A30 File Offset: 0x01111C30
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

		// Token: 0x0603C0CA RID: 245962 RVA: 0x01113B3C File Offset: 0x01111D3C
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

		// Token: 0x0603C0CB RID: 245963 RVA: 0x01113B9C File Offset: 0x01111D9C
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

		// Token: 0x0603C0CC RID: 245964 RVA: 0x01113C68 File Offset: 0x01111E68
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

		// Token: 0x0401FBEA RID: 130026
		public readonly MotorcycleRailMoveConfig MoveConfig = new MotorcycleRailMoveConfig();

		// Token: 0x0401FBEB RID: 130027
		[Nullable(2)]
		public SplineCurve Spline;

		// Token: 0x0401FBEC RID: 130028
		public List<IMotorSlideSplinePoint> SplinePointOptions = new List<IMotorSlideSplinePoint>();

		// Token: 0x0401FBED RID: 130029
		public Vector GravityDir = Vector.Create();

		// Token: 0x0401FBEE RID: 130030
		public EMotorcycleSide JumpSideDir = EMotorcycleSide.Middle;

		// Token: 0x0401FBEF RID: 130031
		[Nullable(2)]
		public TRailMoveUpdater MoveUpdater;

		// Token: 0x0401FBF0 RID: 130032
		[Nullable(2)]
		public TRailMoveGetter MoveGetter;

		// Token: 0x0401FBF1 RID: 130033
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x0401FBF2 RID: 130034
		private readonly Vector EndLocation = Vector.Create();

		// Token: 0x0401FBF3 RID: 130035
		private readonly Rotator StartRotation = Rotator.Create();

		// Token: 0x0401FBF4 RID: 130036
		private readonly Rotator EndRotation = Rotator.Create();

		// Token: 0x0401FBF5 RID: 130037
		private readonly Vector PlaneVelocity = Vector.Create();

		// Token: 0x0401FBF6 RID: 130038
		private readonly Vector CurrentGravityUpVelocity = Vector.Create();

		// Token: 0x0401FBF7 RID: 130039
		private readonly Vector CurrentLocation = Vector.Create();

		// Token: 0x0401FBF8 RID: 130040
		private readonly Rotator CurrentRotator = Rotator.Create();

		// Token: 0x0401FBF9 RID: 130041
		private float CurrentMovingTime;

		// Token: 0x0401FBFA RID: 130042
		private readonly Vector TmpVector1 = Vector.Create();

		// Token: 0x0401FBFB RID: 130043
		private readonly Vector TmpVector2 = Vector.Create();

		// Token: 0x0401FBFC RID: 130044
		private readonly Vector TmpVector3 = Vector.Create();

		// Token: 0x0401FBFD RID: 130045
		private readonly Vector TmpVector4 = Vector.Create();

		// Token: 0x0401FBFE RID: 130046
		private readonly Vector TmpVector5 = Vector.Create();

		// Token: 0x0401FBFF RID: 130047
		private readonly Transform TmpTransform1 = Transform.Create();

		// Token: 0x0401FC00 RID: 130048
		private bool IsBlocked;

		// Token: 0x0401FC01 RID: 130049
		private float BlockingTime;
	}
}
