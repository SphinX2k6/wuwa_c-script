using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x020061B2 RID: 25010
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleAccelerateAlongRailMoveData : MotorcycleRailMoveDataBase
	{
		// Token: 0x0603C0A2 RID: 245922 RVA: 0x011119F8 File Offset: 0x0110FBF8
		public MotorcycleAccelerateAlongRailMoveData(Entity owner, [Nullable(2)] MotorcycleRailComponent relatedRail) : base(EMotorcycleRailMoveDataType.AccelerateAlongRail, owner, relatedRail)
		{
		}

		// Token: 0x17007144 RID: 28996
		// (get) Token: 0x0603C0A3 RID: 245923 RVA: 0x01111A8A File Offset: 0x0110FC8A
		private LinearMoveConfig LinearMoveConfig
		{
			get
			{
				return this.MoveConfig.AccelerateAlongRailConfig.LinearMoveConfig;
			}
		}

		// Token: 0x17007145 RID: 28997
		// (get) Token: 0x0603C0A4 RID: 245924 RVA: 0x01111A9C File Offset: 0x0110FC9C
		private CommonConfig CommonConfig
		{
			get
			{
				return this.MoveConfig.AccelerateAlongRailConfig.CommonConfig;
			}
		}

		// Token: 0x17007146 RID: 28998
		// (get) Token: 0x0603C0A5 RID: 245925 RVA: 0x01111AAE File Offset: 0x0110FCAE
		private BasicRailMoveConfig BasicRailMoveConfig
		{
			get
			{
				return this.MoveConfig.BasicRailMoveConfig;
			}
		}

		// Token: 0x0603C0A6 RID: 245926 RVA: 0x01111ABB File Offset: 0x0110FCBB
		public override void OnTick(float deltaSeconds)
		{
			this.TickUpdateMove(deltaSeconds);
			this.UpdateIsBlocked(deltaSeconds);
			this.ApplyMove();
			this.UpdateIsFinishMove();
		}

		// Token: 0x0603C0A7 RID: 245927 RVA: 0x01111AD8 File Offset: 0x0110FCD8
		[NullableContext(2)]
		public unsafe override bool OnEnter(MotorcycleRailMoveDataBase lastRailMoveData)
		{
			if (this.Spline == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorRailMove;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[MotorcycleAccelerateAlongRailMoveData] OnEnter Failed: Spline is undefined";
				string item = "SplineId";
				MotorcycleRailComponent relatedRail = this.RelatedRail;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (relatedRail != null) ? new int?(relatedRail.GetRailSplineId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			if (this.MoveGetter == null || !this.MoveGetter(this.CurrentLocation, this.CurrentRotator, null))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.MotorRailMove;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "[MotorcycleAccelerateAlongRailMoveData] OnEnter Failed: 拿不到位置旋转";
				string item2 = "SplineId";
				MotorcycleRailComponent relatedRail2 = this.RelatedRail;
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item2, (relatedRail2 != null) ? new int?(relatedRail2.GetRailSplineId()) : null);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			float input = this.Spline.FindInputKeyClosestToWorldLocation(this.CurrentLocation);
			this.CurrentDistAlongSpline = MathUtils.Instance.Clamp(this.Spline.GetDistanceAlongSplineAtSplineInputKey(input), 0f, this.Spline.GetSplineLength());
			this.Spline.GetLocationAtSplineInputKey(input, ESplineCoordinateSpace.World, this.CurrentLocation);
			Vector tmpVector = this.TmpVector1;
			Vector tmpVector2 = this.TmpVector2;
			Vector tmpVector3 = this.TmpVector3;
			Vector tmpVector4 = this.TmpVector4;
			Vector tmpVector5 = this.TmpVector5;
			if ((lastRailMoveData == null || !lastRailMoveData.GetVelocity(tmpVector)) && (this.MoveGetter == null || !this.MoveGetter(null, null, tmpVector)))
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.MotorRailMove;
				ELogAuthor author3 = ELogAuthor.ZYL;
				string message3 = "[MotorcycleAccelerateAlongRailMoveData] OnEnter Failed: 拿不到速度";
				string item3 = "SplineId";
				MotorcycleRailComponent relatedRail3 = this.RelatedRail;
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>(item3, (relatedRail3 != null) ? new int?(relatedRail3.GetRailSplineId()) : null);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return false;
			}
			if (tmpVector.IsNearlyZero(1.0))
			{
				tmpVector.Reset();
			}
			this.CurrentRotator.Quaternion(null).GetForwardVector(tmpVector2);
			if (tmpVector2.IsNearlyZero(9.999999747378752E-05))
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.MotorRailMove;
				ELogAuthor author4 = ELogAuthor.ZYL;
				string message4 = "[MotorcycleAccelerateAlongRailMoveData] OnEnter Failed: 朝向出错";
				string item4 = "SplineId";
				MotorcycleRailComponent relatedRail4 = this.RelatedRail;
				ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>(item4, (relatedRail4 != null) ? new int?(relatedRail4.GetRailSplineId()) : null);
				instance4.Warn(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
				return false;
			}
			double num = MathUtils.Instance.DotProduct(tmpVector, tmpVector2);
			if (!tmpVector.IsNearlyZero(9.999999747378752E-05) && num < 0.0)
			{
				tmpVector2.Multiply(num, tmpVector3);
				tmpVector.SubtractionEqual(tmpVector3);
				if (tmpVector.IsNearlyZero(1.0))
				{
					tmpVector.Reset();
				}
			}
			this.Spline.GetDirectionAtDistanceAlongSpline(this.CurrentDistAlongSpline, ESplineCoordinateSpace.World, tmpVector4);
			double num2 = Vector.DotProduct(tmpVector4, tmpVector2);
			if (MathUtils.Instance.IsNearlyZero(num2, null))
			{
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.MotorRailMove;
				ELogAuthor author5 = ELogAuthor.ZYL;
				string message5 = "[MotorcycleAccelerateAlongRailMoveData] OnEnter Failed: 朝向和样条方向点乘为0";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item5 = "SplineId";
				MotorcycleRailComponent relatedRail5 = this.RelatedRail;
				ptr = new ValueTuple<string, object>(item5, (relatedRail5 != null) ? new int?(relatedRail5.GetRailSplineId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SplineDir", tmpVector4);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("CurrentRotForward", tmpVector2);
				instance5.Warn(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return false;
			}
			this.IsMoveAlongSplineForward = (num2 > 0.0);
			if (!this.IsMoveAlongSplineForward)
			{
				tmpVector4.UnaryNegation(tmpVector4);
			}
			double value = Vector.DotProduct(tmpVector4, tmpVector);
			this.CurrentSpeed = (float)MathUtils.Instance.Clamp(Math.Abs(value), (double)this.LinearMoveConfig.MinSpeed, (double)this.LinearMoveConfig.MaxSpeed);
			this.Spline.GetQuaternionAtDistanceAlongSpline(this.CurrentDistAlongSpline, ESplineCoordinateSpace.World, MathUtils.Instance.CommonTempQuat);
			MathUtils.Instance.CommonTempQuat.GetUpVector(tmpVector5);
			MathUtils.Instance.LookRotationForwardFirst(tmpVector4, tmpVector5, this.CurrentRotator);
			BaseTagComponent component = this.OwnerEntity.GetComponent<BaseTagComponent>();
			foreach (KeyValuePair<int, bool> keyValuePair in this.CommonConfig.ModifyVehicleTagsOnEnter)
			{
				int num3;
				bool flag;
				keyValuePair.Deconstruct(out num3, out flag);
				int value2 = num3;
				if (flag)
				{
					if (component != null)
					{
						component.AddTag(new int?(value2));
					}
				}
				else if (component != null)
				{
					component.RemoveTag(new int?(value2));
				}
			}
			return true;
		}

		// Token: 0x0603C0A8 RID: 245928 RVA: 0x01111F88 File Offset: 0x01110188
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
			if (this.CurrentSegmentPointIndex != -1)
			{
				this.OnLeaveSegment(this.CurrentSegmentPointIndex);
			}
		}

		// Token: 0x0603C0A9 RID: 245929 RVA: 0x01112030 File Offset: 0x01110230
		public override bool GetVelocity(Vector outVelocity)
		{
			if (this.Spline != null)
			{
				outVelocity.Reset();
				this.Spline.GetDirectionAtDistanceAlongSpline(this.CurrentDistAlongSpline, ESplineCoordinateSpace.World, outVelocity);
				outVelocity.MultiplyEqual((double)MathUtils.Instance.Clamp(Math.Abs(this.CurrentSpeed), this.LinearMoveConfig.MinSpeed, this.LinearMoveConfig.MaxSpeed));
				if (!this.IsMoveAlongSplineForward)
				{
					outVelocity.MultiplyEqual(-1.0);
				}
				return true;
			}
			return base.GetVelocity(outVelocity);
		}

		// Token: 0x0603C0AA RID: 245930 RVA: 0x011120B4 File Offset: 0x011102B4
		public void TickUpdateMove(float deltaSeconds)
		{
			if (this.Spline == null)
			{
				return;
			}
			IMotorSlideSplinePoint currentSegmentPointOption = this.GetCurrentSegmentPointOption();
			this.TargetSpeed = Math.Abs(((currentSegmentPointOption != null) ? currentSegmentPointOption.MaxSpeed : null) ?? this.BasicRailMoveConfig.DefaultMoveSpeed);
			this.Acceleration = Math.Abs(((currentSegmentPointOption != null) ? currentSegmentPointOption.AbsAcceleration : null).GetValueOrDefault());
			if (MathUtils.Instance.IsNearlyZero((double)this.CurrentSpeed, null) && MathUtils.Instance.IsNearlyZero((double)this.Acceleration, null))
			{
				this.CurrentSpeed = this.BasicRailMoveConfig.DefaultMoveSpeed;
			}
			float num = Math.Min(deltaSeconds, this.BasicRailMoveConfig.MaxDeltaTimeForMoveUpdate);
			float num2 = MathUtils.Instance.Clamp(Math.Abs(this.CurrentSpeed), this.LinearMoveConfig.MinSpeed, this.LinearMoveConfig.MaxSpeed);
			float num3 = MathUtils.Instance.Clamp(Math.Abs(this.TargetSpeed), this.LinearMoveConfig.MinSpeed, this.LinearMoveConfig.MaxSpeed);
			float num4 = Math.Abs(this.Acceleration) * (float)((num3 - num2 > 0f) ? 1 : -1);
			float num5 = Math.Abs(num3 - num2);
			float num6 = this.IsMoveAlongSplineForward ? Math.Abs(this.Spline.GetSplineLength() - this.CurrentDistAlongSpline) : Math.Abs(0f - this.CurrentDistAlongSpline);
			float num7 = num4 * num;
			float num8 = num;
			if (num4 != 0f && Math.Abs(num7) > num5)
			{
				num7 = num5;
				num8 = num7 / num4;
			}
			float num9 = num2 * num8 + 0.5f * num4 * num8 * num8;
			if (num9 > num6)
			{
				num9 = num6;
				if (num4 == 0f)
				{
					num7 = 0f;
					num8 = num9 / num2;
				}
				else
				{
					num7 = MathF.Sqrt(2f * num4 * num9 + num2 * num2) - num2;
					num8 = num7 / num4;
				}
			}
			float num10 = num - num8;
			float num11 = (num2 + num7) * num10;
			if (num9 + num11 > num6)
			{
				num11 = num6 - num9;
				num10 = num11 / (num2 + num7);
			}
			if (this.IsMoveAlongSplineForward)
			{
				this.CurrentSpeed = MathUtils.Instance.Clamp(num2 + num7, 0f, num3);
				this.CurrentDistAlongSpline = MathUtils.Instance.Clamp(this.CurrentDistAlongSpline + (num9 + num11), 0f, this.Spline.GetSplineLength());
			}
			else
			{
				this.CurrentSpeed = MathUtils.Instance.Clamp(num2 + num7, 0f, num3);
				this.CurrentDistAlongSpline = MathUtils.Instance.Clamp(this.CurrentDistAlongSpline - (num9 + num11), 0f, this.Spline.GetSplineLength());
			}
			this.Spline.GetLocationAtDistanceAlongSpline(this.CurrentDistAlongSpline, ESplineCoordinateSpace.World, this.CurrentLocation);
			Vector tmpVector = this.TmpVector1;
			Vector tmpVector2 = this.TmpVector2;
			this.Spline.GetDirectionAtDistanceAlongSpline(this.CurrentDistAlongSpline, ESplineCoordinateSpace.World, tmpVector);
			if (!this.IsMoveAlongSplineForward)
			{
				tmpVector.UnaryNegation(tmpVector);
			}
			this.Spline.GetQuaternionAtDistanceAlongSpline(this.CurrentDistAlongSpline, ESplineCoordinateSpace.World, MathUtils.Instance.CommonTempQuat);
			MathUtils.Instance.CommonTempQuat.GetUpVector(tmpVector2);
			MathUtils.Instance.LookRotationForwardFirst(tmpVector, tmpVector2, this.CurrentRotator);
			this.UpdateCurrentSegmentPointIndex();
		}

		// Token: 0x0603C0AB RID: 245931 RVA: 0x0111241C File Offset: 0x0111061C
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

		// Token: 0x0603C0AC RID: 245932 RVA: 0x0111247C File Offset: 0x0111067C
		private unsafe void UpdateIsFinishMove()
		{
			if (this.CommonConfig.EnableBlockingCheck && this.IsBlocked && this.BlockingTime > this.CommonConfig.MaxBlockingTimeOut)
			{
				this.IsFinishMove = true;
				this.IsFinishMoveOnFailure = true;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorRailMove;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[MotorcycleAccelerateAlongRailMoveData] Finish move on blocking";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BlockingTime", this.BlockingTime);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurrentLocation", this.CurrentLocation);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (this.Spline == null)
			{
				return;
			}
			if (this.IsMoveAlongSplineForward)
			{
				this.IsFinishMove = (this.CurrentDistAlongSpline >= this.Spline.GetSplineLength());
				return;
			}
			this.IsFinishMove = (this.CurrentDistAlongSpline <= 0f);
		}

		// Token: 0x0603C0AD RID: 245933 RVA: 0x01112570 File Offset: 0x01110770
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

		// Token: 0x0603C0AE RID: 245934 RVA: 0x01112644 File Offset: 0x01110844
		private void UpdateCurrentSegmentPointIndex()
		{
			int? num = this.IsFinishMove ? this.GetCurrentSegmentPointIndex() : new int?(-1);
			if (num == null)
			{
				return;
			}
			int currentSegmentPointIndex = this.CurrentSegmentPointIndex;
			int? num2 = num;
			if (currentSegmentPointIndex == num2.GetValueOrDefault() & num2 != null)
			{
				return;
			}
			if (num.GetValueOrDefault() == -1)
			{
				this.OnLeaveSegment(this.CurrentSegmentPointIndex);
				this.CurrentSegmentPointIndex = num.Value;
				return;
			}
			if (this.CurrentSegmentPointIndex == -1)
			{
				this.CurrentSegmentPointIndex = num.Value;
				this.OnEnterSegment(this.CurrentSegmentPointIndex);
				return;
			}
			if (this.IsMoveAlongSplineForward)
			{
				for (;;)
				{
					int currentSegmentPointIndex2 = this.CurrentSegmentPointIndex;
					num2 = num;
					if (!(currentSegmentPointIndex2 < num2.GetValueOrDefault() & num2 != null))
					{
						break;
					}
					this.OnLeaveSegment(this.CurrentSegmentPointIndex);
					this.CurrentSegmentPointIndex++;
					this.OnEnterSegment(this.CurrentSegmentPointIndex);
				}
				return;
			}
			for (;;)
			{
				int currentSegmentPointIndex3 = this.CurrentSegmentPointIndex;
				num2 = num;
				if (!(currentSegmentPointIndex3 > num2.GetValueOrDefault() & num2 != null))
				{
					break;
				}
				this.OnLeaveSegment(this.CurrentSegmentPointIndex);
				this.CurrentSegmentPointIndex--;
				this.OnEnterSegment(this.CurrentSegmentPointIndex);
			}
		}

		// Token: 0x0603C0AF RID: 245935 RVA: 0x01112764 File Offset: 0x01110964
		private void OnEnterSegment(int pointIndex)
		{
			if (pointIndex == -1)
			{
				return;
			}
			IMotorSlideSplinePoint motorSlideSplinePoint = this.SplinePointOptions[pointIndex];
			if (motorSlideSplinePoint != null)
			{
				int? subCameraTag = motorSlideSplinePoint.SubCameraTag;
				int num = 0;
				if (!(subCameraTag.GetValueOrDefault() == num & subCameraTag != null))
				{
					BaseTagComponent component = this.OwnerEntity.GetComponent<BaseTagComponent>();
					if (component == null)
					{
						return;
					}
					component.AddTag(motorSlideSplinePoint.SubCameraTag);
					return;
				}
			}
		}

		// Token: 0x0603C0B0 RID: 245936 RVA: 0x011127C0 File Offset: 0x011109C0
		private void OnLeaveSegment(int pointIndex)
		{
			if (pointIndex == -1)
			{
				return;
			}
			IMotorSlideSplinePoint motorSlideSplinePoint = this.SplinePointOptions[pointIndex];
			if (motorSlideSplinePoint != null)
			{
				int? subCameraTag = motorSlideSplinePoint.SubCameraTag;
				int num = 0;
				if (!(subCameraTag.GetValueOrDefault() == num & subCameraTag != null))
				{
					BaseTagComponent component = this.OwnerEntity.GetComponent<BaseTagComponent>();
					if (component == null)
					{
						return;
					}
					component.RemoveTag(motorSlideSplinePoint.SubCameraTag);
					return;
				}
			}
		}

		// Token: 0x0603C0B1 RID: 245937 RVA: 0x0111281C File Offset: 0x01110A1C
		[NullableContext(2)]
		public IMotorSlideSplinePoint GetCurrentSegmentPointOption()
		{
			if (this.Spline == null)
			{
				return null;
			}
			float inputKeyAtDistanceAlongSpline = this.Spline.GetInputKeyAtDistanceAlongSpline(this.CurrentDistAlongSpline);
			int nearestPositionIndexAtInputKey = this.Spline.GetNearestPositionIndexAtInputKey(inputKeyAtDistanceAlongSpline);
			return this.SplinePointOptions[nearestPositionIndexAtInputKey];
		}

		// Token: 0x0603C0B2 RID: 245938 RVA: 0x01112860 File Offset: 0x01110A60
		public int? GetCurrentSegmentPointIndex()
		{
			if (this.Spline == null)
			{
				return null;
			}
			float inputKeyAtDistanceAlongSpline = this.Spline.GetInputKeyAtDistanceAlongSpline(this.CurrentDistAlongSpline);
			return new int?(this.Spline.GetNearestPositionIndexAtInputKey(inputKeyAtDistanceAlongSpline));
		}

		// Token: 0x0603C0B3 RID: 245939 RVA: 0x011128A2 File Offset: 0x01110AA2
		public bool GetIsMoveAlongSplineForward()
		{
			return this.IsMoveAlongSplineForward;
		}

		// Token: 0x0401FBBE RID: 129982
		public readonly MotorcycleRailMoveConfig MoveConfig = new MotorcycleRailMoveConfig();

		// Token: 0x0401FBBF RID: 129983
		[Nullable(2)]
		public SplineCurve Spline;

		// Token: 0x0401FBC0 RID: 129984
		public List<IMotorSlideSplinePoint> SplinePointOptions = new List<IMotorSlideSplinePoint>();

		// Token: 0x0401FBC1 RID: 129985
		[Nullable(2)]
		public TRailMoveUpdater MoveUpdater;

		// Token: 0x0401FBC2 RID: 129986
		[Nullable(2)]
		public TRailMoveGetter MoveGetter;

		// Token: 0x0401FBC3 RID: 129987
		private float CurrentSpeed;

		// Token: 0x0401FBC4 RID: 129988
		private float TargetSpeed;

		// Token: 0x0401FBC5 RID: 129989
		private float Acceleration;

		// Token: 0x0401FBC6 RID: 129990
		private float CurrentDistAlongSpline;

		// Token: 0x0401FBC7 RID: 129991
		private bool IsMoveAlongSplineForward = true;

		// Token: 0x0401FBC8 RID: 129992
		private readonly Vector CurrentLocation = Vector.Create();

		// Token: 0x0401FBC9 RID: 129993
		private readonly Rotator CurrentRotator = Rotator.Create();

		// Token: 0x0401FBCA RID: 129994
		private readonly Vector TmpVector1 = Vector.Create();

		// Token: 0x0401FBCB RID: 129995
		private readonly Vector TmpVector2 = Vector.Create();

		// Token: 0x0401FBCC RID: 129996
		private readonly Vector TmpVector3 = Vector.Create();

		// Token: 0x0401FBCD RID: 129997
		private readonly Vector TmpVector4 = Vector.Create();

		// Token: 0x0401FBCE RID: 129998
		private readonly Vector TmpVector5 = Vector.Create();

		// Token: 0x0401FBCF RID: 129999
		private readonly Transform TmpTransform1 = Transform.Create();

		// Token: 0x0401FBD0 RID: 130000
		private bool IsBlocked;

		// Token: 0x0401FBD1 RID: 130001
		private float BlockingTime;

		// Token: 0x0401FBD2 RID: 130002
		private int CurrentSegmentPointIndex = -1;
	}
}
