using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x0200704C RID: 28748
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleRailMoveUtils : Singleton
	{
		// Token: 0x06045F78 RID: 286584 RVA: 0x0116EF78 File Offset: 0x0116D178
		[NullableContext(2)]
		public unsafe bool ExecCheckList([Nullable(1)] RailMoveContext checkRailMoveContext, EnterRailCondition enterRailCondition = null, [Nullable(new byte[]
		{
			2,
			1
		})] IList<TRailMoveChecker> checkList = null, bool bEnableLog = false, string logSource = null)
		{
			if (checkList == null)
			{
				return true;
			}
			for (int i = 0; i < checkList.Count; i++)
			{
				if (!checkList[i](checkRailMoveContext, enterRailCondition))
				{
					if (bEnableLog)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.MotorRailMove;
						ELogAuthor author = ELogAuthor.ZYL;
						string message = "[MotorcycleRailMoveUtils] ExecCheckList not pass";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Source", logSource);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CheckerIndex", i);
						instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					}
					return false;
				}
			}
			if (bEnableLog)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.MotorRailMove;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "[MotorcycleRailMoveUtils] ExecCheckList pass";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Source", logSource);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return true;
		}

		// Token: 0x06045F79 RID: 286585 RVA: 0x0116F040 File Offset: 0x0116D240
		public bool CalcRailMoveTargetNotAdvanceBySpeed(RailMoveContext checkRailMoveContext, double minSpeed, double maxSpeed)
		{
			SplineCurve railSpline = checkRailMoveContext.RailSpline;
			if (railSpline == null)
			{
				return false;
			}
			bool isForward = checkRailMoveContext.IsForward;
			RailMoveTarget railMoveTarget = checkRailMoveContext.RailMoveTarget;
			Vector sourceLoc = checkRailMoveContext.SourceLoc;
			Vector sourceVel = checkRailMoveContext.SourceVel;
			railMoveTarget.TargetSpline = railSpline;
			railMoveTarget.IsForward = isForward;
			railMoveTarget.TargetSplineInputKey = railSpline.FindInputKeyClosestToWorldLocation(sourceLoc);
			railMoveTarget.TargetSplineDist = railSpline.GetDistanceAlongSplineAtSplineInputKey(railMoveTarget.TargetSplineInputKey);
			railSpline.GetDirectionAtSplineInputKey(railMoveTarget.TargetSplineInputKey, ESplineCoordinateSpace.World, railMoveTarget.TargetSplineDir);
			railSpline.GetRotationAtSplineInputKey(railMoveTarget.TargetSplineInputKey, ESplineCoordinateSpace.World, railMoveTarget.TargetSplineRot);
			railSpline.GetLocationAtSplineInputKey(railMoveTarget.TargetSplineInputKey, ESplineCoordinateSpace.World, railMoveTarget.TargetLoc);
			Vector tmpVector = this.TmpVector1;
			Vector tmpVector2 = this.TmpVector2;
			if (isForward)
			{
				tmpVector2.DeepCopy(railMoveTarget.TargetSplineDir);
			}
			else
			{
				railMoveTarget.TargetSplineDir.UnaryNegation(tmpVector2);
			}
			double num = sourceVel.DotProduct(tmpVector2);
			num = ((num > 0.0) ? num : 0.0);
			num = MathUtils.Instance.Clamp(num, minSpeed, maxSpeed);
			railMoveTarget.TargetSplineDir.Multiply(num, railMoveTarget.TargetVel);
			if (tmpVector2.IsZero())
			{
				return false;
			}
			MathUtils.Instance.LookRotationForwardFirst(tmpVector2, railMoveTarget.TargetSplineRot.Quaternion(null).GetUpVector(tmpVector), railMoveTarget.TargetRot);
			return true;
		}

		// Token: 0x06045F7A RID: 286586 RVA: 0x0116F184 File Offset: 0x0116D384
		public bool CalcRailMoveTargetAdvanceBySpeed(RailMoveContext checkRailMoveContext, double duration, double minSpeed, double maxSpeed)
		{
			SplineCurve railSpline = checkRailMoveContext.RailSpline;
			if (railSpline == null)
			{
				return false;
			}
			bool isForward = checkRailMoveContext.IsForward;
			RailMoveTarget railMoveTarget = checkRailMoveContext.RailMoveTarget;
			Vector sourceLoc = checkRailMoveContext.SourceLoc;
			Vector sourceVel = checkRailMoveContext.SourceVel;
			railMoveTarget.TargetSpline = railSpline;
			railMoveTarget.IsForward = isForward;
			float splineLength = railSpline.GetSplineLength();
			float input = railSpline.FindInputKeyClosestToWorldLocation(sourceLoc);
			float num = MathUtils.Instance.Clamp(railSpline.GetDistanceAlongSplineAtSplineInputKey(input), 0f, splineLength);
			Vector tmpVector = this.TmpVector1;
			Vector tmpVector2 = this.TmpVector2;
			Vector tmpVector3 = this.TmpVector3;
			Vector tmpVector4 = this.TmpVector4;
			Vector tmpVector5 = this.TmpVector5;
			railSpline.GetDirectionAtSplineInputKey(input, ESplineCoordinateSpace.World, tmpVector);
			railSpline.GetLocationAtSplineInputKey(input, ESplineCoordinateSpace.World, tmpVector2);
			if (isForward)
			{
				tmpVector4.DeepCopy(tmpVector);
			}
			else
			{
				tmpVector.UnaryNegation(tmpVector4);
			}
			double num2 = Vector.PointPlaneDist(sourceLoc, tmpVector2, tmpVector4);
			double num3 = sourceVel.DotProduct(tmpVector4);
			num3 = ((num3 > 0.0) ? num3 : 0.0);
			num3 = MathUtils.Instance.Clamp(num3, minSpeed, maxSpeed);
			double num4;
			if (MathUtils.Instance.IsNearlyZero(num3, new double?((double)0.0001f)))
			{
				num4 = 0.0;
			}
			else if (num2 < 0.0)
			{
				double num5 = -num2 / num3;
				double num6 = Math.Max(0.0, duration - num5);
				num4 = num3 * num6;
			}
			else
			{
				num4 = num3 * duration;
			}
			if (isForward)
			{
				railMoveTarget.TargetSplineDist = (float)MathUtils.Instance.Clamp((double)num + num4, 0.0, (double)splineLength);
			}
			else
			{
				railMoveTarget.TargetSplineDist = (float)MathUtils.Instance.Clamp((double)num - num4, 0.0, (double)splineLength);
			}
			railMoveTarget.TargetSplineInputKey = railSpline.GetInputKeyAtDistanceAlongSpline(railMoveTarget.TargetSplineDist);
			railSpline.GetRotationAtSplineInputKey(railMoveTarget.TargetSplineInputKey, ESplineCoordinateSpace.World, railMoveTarget.TargetSplineRot);
			railSpline.GetDirectionAtSplineInputKey(railMoveTarget.TargetSplineInputKey, ESplineCoordinateSpace.World, railMoveTarget.TargetSplineDir);
			railSpline.GetLocationAtSplineInputKey(railMoveTarget.TargetSplineInputKey, ESplineCoordinateSpace.World, railMoveTarget.TargetLoc);
			if (isForward)
			{
				tmpVector5.DeepCopy(railMoveTarget.TargetSplineDir);
			}
			else
			{
				railMoveTarget.TargetSplineDir.UnaryNegation(tmpVector5);
			}
			if (tmpVector5.IsZero())
			{
				return false;
			}
			MathUtils.Instance.LookRotationForwardFirst(tmpVector5, railMoveTarget.TargetSplineRot.Quaternion(null).GetUpVector(tmpVector3), railMoveTarget.TargetRot);
			tmpVector5.Multiply(num3, railMoveTarget.TargetVel);
			return true;
		}

		// Token: 0x06045F7B RID: 286587 RVA: 0x0116F3E8 File Offset: 0x0116D5E8
		public bool RailMoveCheckerCheckRelativeLocation(RailMoveContext checkRailMoveContext, [Nullable(2)] EnterRailCondition enterRailCondition = null)
		{
			if (enterRailCondition == null)
			{
				return false;
			}
			RailMoveTarget railMoveTarget = checkRailMoveContext.RailMoveTarget;
			Vector sourceLoc = checkRailMoveContext.SourceLoc;
			bool isForward = railMoveTarget.IsForward;
			if (railMoveTarget.TargetSpline == null)
			{
				return false;
			}
			if ((isForward && MathUtils.Instance.IsNearlyZero((double)railMoveTarget.TargetSplineDist, new double?((double)0.0001f))) || (!isForward && MathUtils.Instance.IsNearlyZero((double)(railMoveTarget.TargetSpline.GetSplineLength() - railMoveTarget.TargetSplineDist), new double?((double)0.0001f))))
			{
				return true;
			}
			Vector tmpVector = this.TmpVector1;
			sourceLoc.Subtraction(railMoveTarget.TargetLoc, tmpVector);
			railMoveTarget.TargetRot.Quaternion(null).UnRotateVector(tmpVector, tmpVector);
			double num;
			if (MathUtils.Instance.IsNearlyZero(tmpVector.Z, new double?((double)0.0001f)))
			{
				num = (double)(MathUtils.Instance.IsNearlyZero(tmpVector.Y, new double?((double)0.0001f)) ? 0 : 90);
			}
			else
			{
				num = Math.Atan(Math.Abs(tmpVector.Y) / tmpVector.Z) * 57.295780181884766;
				if (num < 0.0)
				{
					num += 180.0;
				}
			}
			return num <= (double)enterRailCondition.MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent;
		}

		// Token: 0x06045F7C RID: 286588 RVA: 0x0116F52C File Offset: 0x0116D72C
		public bool RailMoveCheckerCheckVehicleNotReverseMove(RailMoveContext checkRailMoveContext, [Nullable(2)] EnterRailCondition enterRailCondition = null)
		{
			Vector tmpVector = this.TmpVector1;
			checkRailMoveContext.SourceRot.Quaternion(null).GetForwardVector(tmpVector);
			return checkRailMoveContext.SourceVel.DotProduct(tmpVector) >= 0.0;
		}

		// Token: 0x06045F7D RID: 286589 RVA: 0x0116F570 File Offset: 0x0116D770
		public bool RailMoveCheckerCheckAngleBetweenVehicleUpAndRailUp(RailMoveContext checkRailMoveContext, [Nullable(2)] EnterRailCondition enterRailCondition = null)
		{
			if (enterRailCondition == null)
			{
				return false;
			}
			Vector tmpVector = this.TmpVector1;
			Vector tmpVector2 = this.TmpVector1;
			checkRailMoveContext.RailMoveTarget.TargetSplineRot.Quaternion(null).GetUpVector(tmpVector2);
			checkRailMoveContext.SourceRot.Quaternion(null).GetUpVector(tmpVector);
			return MathUtils.Instance.GetAngleByVectorDot(tmpVector2, tmpVector) <= (double)enterRailCondition.MaxAngleBetweenUpAndRailUp;
		}

		// Token: 0x06045F7E RID: 286590 RVA: 0x0116F5D4 File Offset: 0x0116D7D4
		public bool RailMoveCheckerCheckAngleBetweenVehicleForwardAndRailTangent(RailMoveContext checkRailMoveContext, [Nullable(2)] EnterRailCondition enterRailCondition = null)
		{
			if (enterRailCondition == null)
			{
				return false;
			}
			Vector tmpVector = this.TmpVector1;
			Vector tmpVector2 = this.TmpVector2;
			if (!checkRailMoveContext.RailMoveTarget.IsForward)
			{
				checkRailMoveContext.RailMoveTarget.TargetSplineDir.UnaryNegation(tmpVector2);
			}
			else
			{
				tmpVector2.DeepCopy(checkRailMoveContext.RailMoveTarget.TargetSplineDir);
			}
			if (tmpVector2.IsZero())
			{
				return false;
			}
			checkRailMoveContext.SourceRot.Quaternion(null).GetForwardVector(tmpVector);
			return Math.Abs(MathUtils.Instance.GetAngleByVectorDot(tmpVector2, tmpVector)) <= (double)enterRailCondition.MaxAngleBetweenForwardAndRailTangent;
		}

		// Token: 0x06045F7F RID: 286591 RVA: 0x0116F660 File Offset: 0x0116D860
		public bool RailMoveCheckerCheckAngleBetweenVehicleVelocityAndRailTangent(RailMoveContext checkRailMoveContext, [Nullable(2)] EnterRailCondition enterRailCondition = null)
		{
			if (enterRailCondition == null)
			{
				return false;
			}
			Vector tmpVector = this.TmpVector1;
			if (!checkRailMoveContext.RailMoveTarget.IsForward)
			{
				checkRailMoveContext.RailMoveTarget.TargetSplineDir.UnaryNegation(tmpVector);
			}
			else
			{
				tmpVector.DeepCopy(checkRailMoveContext.RailMoveTarget.TargetSplineDir);
			}
			return !tmpVector.IsZero() && (checkRailMoveContext.SourceVel.IsNearlyZero(9.999999747378752E-05) || Math.Abs(MathUtils.Instance.GetAngleByVectorDot(tmpVector, checkRailMoveContext.SourceVel)) <= (double)enterRailCondition.MaxAngleBetweenVelocityAndRailTangent);
		}

		// Token: 0x06045F80 RID: 286592 RVA: 0x0116F6EC File Offset: 0x0116D8EC
		public double GetDistanceFromTargetToRail(USplineComponent targetSplineComp, TRailMoveGetter targetMoveGetter)
		{
			if (!targetMoveGetter(MathUtils.Instance.CommonTempVector, null, null))
			{
				return -1.0;
			}
			FVectorDouble fvectorDouble = MathUtils.Instance.CommonTempVector.ToUeVector(false);
			float inKey = targetSplineComp.D_FindInputKeyClosestToWorldLocation(fvectorDouble);
			FVectorDouble fvectorDouble2 = targetSplineComp.D_GetLocationAtSplineInputKey(inKey, ESplineCoordinateSpace.World);
			return MathUtils.Instance.VectorDistance(fvectorDouble2, MathUtils.Instance.CommonTempVector);
		}

		// Token: 0x06045F81 RID: 286593 RVA: 0x0116F754 File Offset: 0x0116D954
		public EMotorcycleSide? GetRailRelativeSideOfTarget(USplineComponent targetSplineComp, TRailMoveGetter vehicleMoveGetter)
		{
			Vector tmpVector = this.TmpVector1;
			Vector tmpVector2 = this.TmpVector2;
			Rotator tmpRotator = this.TmpRotator1;
			if (!vehicleMoveGetter(tmpVector, tmpRotator, null))
			{
				return null;
			}
			FVectorDouble fvectorDouble = tmpVector.ToUeVector(false);
			float inKey = targetSplineComp.D_FindInputKeyClosestToWorldLocation(fvectorDouble);
			Vector vector = tmpVector2;
			fvectorDouble = targetSplineComp.D_GetLocationAtSplineInputKey(inKey, ESplineCoordinateSpace.World);
			vector.FromUeVector(fvectorDouble);
			tmpVector2.SubtractionEqual(tmpVector);
			tmpRotator.Quaternion(MathUtils.Instance.CommonTempQuat).UnRotateVector(tmpVector2, tmpVector2);
			if (MathUtils.Instance.IsNearlyZero(tmpVector2.Y, new double?((double)0.0001f)))
			{
				return new EMotorcycleSide?(EMotorcycleSide.Middle);
			}
			return new EMotorcycleSide?((tmpVector2.Y < 0.0) ? EMotorcycleSide.Left : EMotorcycleSide.Right);
		}

		// Token: 0x06045F82 RID: 286594 RVA: 0x0116F810 File Offset: 0x0116DA10
		public void UpdateRailMoveConfig(string targetRowName, MotorcycleRailMoveConfig targetConfig, [Nullable(new byte[]
		{
			1,
			1,
			2
		})] Func<string, SMotorRailMoveConfig> ueConfigGetter)
		{
			string text = "Default";
			if (targetRowName != text)
			{
				this.UpdateRailMoveConfig(text, targetConfig, ueConfigGetter);
			}
			SMotorRailMoveConfig smotorRailMoveConfig = ueConfigGetter(targetRowName);
			if (smotorRailMoveConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorRailMove;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[MotorcycleRailMoveUtils] UpdateRailMoveConfig失败，找不到对应行的数据";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("targetRowName", targetRowName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			targetConfig.UpdateFromUeData(smotorRailMoveConfig);
		}

		// Token: 0x17009BE6 RID: 39910
		// (get) Token: 0x06045F83 RID: 286595 RVA: 0x0116F878 File Offset: 0x0116DA78
		public static MotorcycleRailMoveUtils Instance
		{
			get
			{
				if (MotorcycleRailMoveUtils._instance == null)
				{
					MotorcycleRailMoveUtils._instance = new MotorcycleRailMoveUtils();
					MotorcycleRailMoveUtils._instance.OnInit();
				}
				return MotorcycleRailMoveUtils._instance;
			}
		}

		// Token: 0x06045F84 RID: 286596 RVA: 0x0116F89B File Offset: 0x0116DA9B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06045F85 RID: 286597 RVA: 0x0116F89D File Offset: 0x0116DA9D
		public static void ResetStaticDefaultValue()
		{
			MotorcycleRailMoveUtils instance = MotorcycleRailMoveUtils._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			MotorcycleRailMoveUtils._instance = null;
		}

		// Token: 0x06045F86 RID: 286598 RVA: 0x0116F8B6 File Offset: 0x0116DAB6
		static MotorcycleRailMoveUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleRailMoveUtils.CreateStaticDefaultValue), new Action(MotorcycleRailMoveUtils.ResetStaticDefaultValue));
		}

		// Token: 0x040249D8 RID: 149976
		private readonly Vector TmpVector1 = Vector.Create();

		// Token: 0x040249D9 RID: 149977
		private readonly Vector TmpVector2 = Vector.Create();

		// Token: 0x040249DA RID: 149978
		private readonly Vector TmpVector3 = Vector.Create();

		// Token: 0x040249DB RID: 149979
		private readonly Vector TmpVector4 = Vector.Create();

		// Token: 0x040249DC RID: 149980
		private readonly Vector TmpVector5 = Vector.Create();

		// Token: 0x040249DD RID: 149981
		private readonly Rotator TmpRotator1 = Rotator.Create();

		// Token: 0x040249DE RID: 149982
		public TRailMoveChecker RailMoveCheckerCheckRailLenLeft = delegate(RailMoveContext checkRailMoveContext, [Nullable(2)] EnterRailCondition enterRailCondition = null)
		{
			RailMoveTarget railMoveTarget = checkRailMoveContext.RailMoveTarget;
			bool isForward = railMoveTarget.IsForward;
			if (railMoveTarget.TargetSpline == null)
			{
				return false;
			}
			if (isForward)
			{
				return railMoveTarget.TargetSpline.GetSplineLength() - railMoveTarget.TargetSplineDist > ((enterRailCondition != null) ? enterRailCondition.MinRailLenLeftAfterEnterRail : 0f);
			}
			return railMoveTarget.TargetSplineDist > ((enterRailCondition != null) ? enterRailCondition.MinRailLenLeftAfterEnterRail : 0f);
		};

		// Token: 0x040249DF RID: 149983
		[Nullable(2)]
		private static MotorcycleRailMoveUtils _instance;
	}
}
