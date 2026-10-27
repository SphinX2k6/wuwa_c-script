using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils
{
	// Token: 0x02004544 RID: 17732
	[NullableContext(1)]
	[Nullable(0)]
	public class ActionUtils
	{
		// Token: 0x0602DD5D RID: 187741 RVA: 0x00A89390 File Offset: 0x00A87590
		public static void CalcCatapultToTargetConfigByGravity(Vector startPos, Vector targetLocation, Vector locationOffset, float heightOffset, float gravityMagnitude, Vector gravityDirect, Vector defaultForward, CatapultToTargetResult @out)
		{
			targetLocation.Subtraction(startPos, ActionUtils.TmpVector);
			ActionUtils.TmpVector.Normalize(9.99999993922529E-09);
			gravityDirect.UnaryNegation(ActionUtils.TmpVector2);
			if (Math.Abs(ActionUtils.TmpVector.DotProduct(ActionUtils.TmpVector2)) < 0.9999)
			{
				MathUtils.Instance.LookRotationUpFirst(ActionUtils.TmpVector, ActionUtils.TmpVector2, ActionUtils.TmpQuat);
			}
			else
			{
				ActionUtils.TmpVector.DeepCopy(defaultForward);
				MathUtils.Instance.LookRotationUpFirst(ActionUtils.TmpVector, ActionUtils.TmpVector2, ActionUtils.TmpQuat);
			}
			ActionUtils.TmpQuat.Rotator(@out.EndRotator);
			ActionUtils.TmpQuat.RotateVector(locationOffset, ActionUtils.TmpVector);
			@out.EndPoint.Set(targetLocation.X + ActionUtils.TmpVector.X, targetLocation.Y + ActionUtils.TmpVector.Y, targetLocation.Z + ActionUtils.TmpVector.Z);
			double znInGravity = GravityUtils.Instance.GetZnInGravity(gravityDirect, startPos);
			double znInGravity2 = GravityUtils.Instance.GetZnInGravity(gravityDirect, @out.EndPoint);
			double num = Math.Max(znInGravity, znInGravity2) + (double)heightOffset;
			float num2 = (float)Math.Sqrt(2.0 * Math.Max(0.0, num - znInGravity) / (double)gravityMagnitude);
			float num3 = (float)Math.Sqrt(2.0 * Math.Max(0.0, num - znInGravity2) / (double)gravityMagnitude);
			@out.MiddlePoint.DeepCopy(@out.EndPoint);
			@out.MiddlePoint.SubtractionEqual(startPos);
			GravityUtils.Instance.ConvertToPlanarVectorForDirect(gravityDirect, @out.MiddlePoint);
			@out.MiddlePoint.MultiplyEqual((double)(num2 / (num2 + num3)));
			@out.MiddlePoint.AdditionEqual(startPos);
			GravityUtils.Instance.SetZnInGravity(gravityDirect, @out.MiddlePoint, num);
			@out.Time1 = num2;
			@out.StartPoint.DeepCopy(startPos);
			@out.GravityMagnitude = gravityMagnitude;
			@out.GravityDirect.DeepCopy(gravityDirect);
		}

		// Token: 0x0602DD5E RID: 187742 RVA: 0x00A8959C File Offset: 0x00A8779C
		public static void CalcCatapultToTargetConfigByTime(Vector startPos, Vector targetLocation, Vector locationOffset, float time1, Vector gravityDirect, Vector defaultForward, CatapultToTargetResult @out)
		{
			targetLocation.Subtraction(startPos, ActionUtils.TmpVector);
			ActionUtils.TmpVector.Normalize(9.99999993922529E-09);
			gravityDirect.UnaryNegation(ActionUtils.TmpVector2);
			if (Math.Abs(ActionUtils.TmpVector.DotProduct(ActionUtils.TmpVector2)) < 0.9999)
			{
				MathUtils.Instance.LookRotationUpFirst(ActionUtils.TmpVector, ActionUtils.TmpVector2, ActionUtils.TmpQuat);
			}
			else
			{
				ActionUtils.TmpVector.DeepCopy(defaultForward);
				MathUtils.Instance.LookRotationUpFirst(ActionUtils.TmpVector, ActionUtils.TmpVector2, ActionUtils.TmpQuat);
			}
			ActionUtils.TmpQuat.Rotator(@out.EndRotator);
			ActionUtils.TmpQuat.RotateVector(locationOffset, ActionUtils.TmpVector);
			@out.EndPoint.Set(targetLocation.X + ActionUtils.TmpVector.X, targetLocation.Y + ActionUtils.TmpVector.Y, targetLocation.Z + ActionUtils.TmpVector.Z);
			@out.MiddlePoint.DeepCopy(@out.EndPoint);
			@out.Time1 = time1;
			@out.StartPoint.DeepCopy(startPos);
			@out.GravityMagnitude = 0f;
			@out.GravityDirect.DeepCopy(gravityDirect);
		}

		// Token: 0x04018782 RID: 100226
		[StaticVariableRuleIgnore]
		private static readonly Vector TmpVector = Vector.Create();

		// Token: 0x04018783 RID: 100227
		[StaticVariableRuleIgnore]
		private static readonly Vector TmpVector2 = Vector.Create();

		// Token: 0x04018784 RID: 100228
		[StaticVariableRuleIgnore]
		private static readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
	}
}
