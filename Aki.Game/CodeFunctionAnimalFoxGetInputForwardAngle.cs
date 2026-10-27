using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x0200316C RID: 12652
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CodeFunctionAnimalFoxGetInputForwardAngle : CodeFunctionBase<SpecialSkillBase>
{
	// Token: 0x0601B36C RID: 111468 RVA: 0x0076ADEC File Offset: 0x00768FEC
	public CodeFunctionAnimalFoxGetInputForwardAngle(SpecialSkillBase specialSkill) : base(specialSkill)
	{
	}

	// Token: 0x0601B36D RID: 111469 RVA: 0x0076AEA4 File Offset: 0x007690A4
	public override FKuroCodeFunctionResult Execute(FKuroCodeFunctionPayload payload)
	{
		Entity ownerEntity = this.SpecialSkill.GetOwnerEntity();
		CharacterActorComponent component = ownerEntity.GetComponent<CharacterActorComponent>();
		if (component == null)
		{
			return base.GetDefaultFailureResult("CharacterActorComponent not found");
		}
		BaseMoveComponent moveComp = component.MoveComp;
		if (moveComp != null && moveComp.MoveController.IsMoving())
		{
			return base.GetDefaultFailureResult("处于非玩家控制的移动中");
		}
		Vector inputDirectProxy = component.InputDirectProxy;
		CharacterInputComponent component2 = ownerEntity.GetComponent<CharacterInputComponent>();
		Vector vector = (component2 != null) ? component2.GetWorldMoveDirectionCache() : inputDirectProxy;
		CharacterSplineMoveComponent component3 = ownerEntity.GetComponent<CharacterSplineMoveComponent>();
		object obj = (component3 != null) ? component3.CurrentSplineMoveParams : null;
		Vector vector2 = ((component3 != null) ? component3.SplineDirection : null) ?? Vector.ZeroVectorProxy;
		object obj2 = obj;
		bool flag = obj2 != null && obj2.OnlyForward;
		bool flag2 = flag && component3 != null && component3.CurrentSplineMoveType == ESplineMovePattern.PathLine;
		if (flag2 && component2 != null && component2.TryGetManualWorldMoveDirection(this.PathLineInputDirection))
		{
			vector = this.PathLineInputDirection;
		}
		object obj3 = (component2 != null) ? (component.IsAutonomousProxy ? (!component2.GetMoveVectorCache().IsNearlyZero(9.999999747378752E-05)) : (!vector.IsNearlyZero(9.999999747378752E-05))) : (!inputDirectProxy.IsNearlyZero(9.999999747378752E-05));
		bool flag3 = flag2 && (vector2.IsNearlyZero(9.999999747378752E-05) || vector.DotProduct(vector2) < 0.7070000171661377);
		Vector vector3 = vector;
		object obj4 = obj3;
		if (obj4 == null || vector.IsNearlyZero(9.999999747378752E-05) || flag3)
		{
			vector3 = Vector.ZeroVectorProxy;
		}
		else if (flag2)
		{
			vector3 = vector2;
		}
		else if (flag)
		{
			vector3 = inputDirectProxy;
		}
		object obj5 = obj4 != null && !vector.IsNearlyZero(9.999999747378752E-05) && !flag;
		float num = Math.Min(0.08f, Time.Instance.DeltaTimeSeconds);
		Vector actorForwardProxy = component.ActorForwardProxy;
		float num2 = (float)MathUtils.Instance.SignedAngleOnPlaneDeg(actorForwardProxy, vector, Vector.UpVectorProxy);
		object obj6 = obj5;
		float num3 = (obj6 != null) ? (num2 / 180f) : 0f;
		if (obj6 == null)
		{
			this.SmoothedAngle = 0f;
		}
		else
		{
			this.SmoothedAngle = ((Math.Abs(num3) > Math.Abs(this.SmoothedAngle)) ? num3 : ((float)MathUtils.Instance.InterpTo((double)this.SmoothedAngle, (double)num3, (double)num, 8.0)));
		}
		if (Math.Abs(this.SmoothedAngle) < 0.01f)
		{
			this.SmoothedAngle = 0f;
		}
		BaseMoveComponent moveComp2 = component.MoveComp;
		if (((moveComp2 != null) ? moveComp2.Speed : 0f) < 10f)
		{
			this.TurnAngle = MathUtils.Instance.InterpConstantTo(this.TurnAngle, 0f, num, 90f);
		}
		else
		{
			Vector inB = vector3.IsNearlyZero(9.999999747378752E-05) ? actorForwardProxy : vector3;
			float num4 = (float)MathUtils.Instance.SignedAngleOnPlaneDeg(actorForwardProxy, inB, Vector.UpVectorProxy) * 0.3f;
			if (Math.Abs(num4) <= Math.Abs(this.TurnAngle))
			{
				this.TurnAngle = MathUtils.Instance.InterpConstantTo(this.TurnAngle, num4, num, 240f);
			}
			else
			{
				this.TurnAngle = MathUtils.Instance.InterpConstantTo(this.TurnAngle, num4, num, 90f);
			}
		}
		float value = MathUtils.Instance.Clamp(this.TurnAngle / 45f, -0.5f, 0.5f);
		FKuroCodeFunctionResult cachedResult = base.GetCachedResult();
		cachedResult.Values.FloatValues.Add("Angle", value);
		cachedResult.Values.FloatValues.Add("InputAngle", this.SmoothedAngle);
		cachedResult.Values.FloatValues.Add("RawAngle", num3);
		return cachedResult;
	}

	// Token: 0x0601B36E RID: 111470 RVA: 0x0076B258 File Offset: 0x00769458
	private void DrawDebug(Vector currentPos, Vector forward, Vector rawInputDirect)
	{
		double z = currentPos.Z + 30.0;
		this.DebugJointPt.X = currentPos.X;
		this.DebugJointPt.Y = currentPos.Y;
		this.DebugJointPt.Z = z;
		this.DebugForwardEndPt.X = currentPos.X + forward.X * 80.0;
		this.DebugForwardEndPt.Y = currentPos.Y + forward.Y * 80.0;
		this.DebugForwardEndPt.Z = z;
		this.DebugInputEndPt.X = currentPos.X + rawInputDirect.X * 80.0;
		this.DebugInputEndPt.Y = currentPos.Y + rawInputDirect.Y * 80.0;
		this.DebugInputEndPt.Z = z;
		double num = (double)this.TurnAngle * 3.141592653589793 / 180.0;
		double num2 = Math.Cos(num);
		double num3 = Math.Sin(num);
		this.DebugFrontHalfEndPt.X = currentPos.X + (forward.X * num2 - forward.Y * num3) * 80.0;
		this.DebugFrontHalfEndPt.Y = currentPos.Y + (forward.X * num3 + forward.Y * num2) * 80.0;
		this.DebugFrontHalfEndPt.Z = z;
		UKismetSystemLibrary.D_DrawDebugArrow(GlobalData.World, this.DebugJointPt, this.DebugForwardEndPt, 20f, ColorUtils.LinearYellow, 0f, 0f);
		UKismetSystemLibrary.D_DrawDebugArrow(GlobalData.World, this.DebugJointPt, this.DebugInputEndPt, 20f, ColorUtils.LinearCyan, 0f, 0f);
		UKismetSystemLibrary.D_DrawDebugArrow(GlobalData.World, this.DebugJointPt, this.DebugFrontHalfEndPt, 20f, ColorUtils.LinearGreen, 0f, 0f);
		UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, this.DebugJointPt, 8f, 6, new FLinearColor?(ColorUtils.LinearWhite), 3f, 0f);
	}

	// Token: 0x0400D416 RID: 54294
	public static readonly string FunctionName = "AnimalFox.GetInputForwardAngle";

	// Token: 0x0400D417 RID: 54295
	private const string ANGLE_RESULT = "Angle";

	// Token: 0x0400D418 RID: 54296
	private const string INPUT_ANGLE_RESULT = "InputAngle";

	// Token: 0x0400D419 RID: 54297
	private const string RAW_ANGLE_RESULT = "RawAngle";

	// Token: 0x0400D41A RID: 54298
	private const float INTERP_SPEED_DECREASE = 8f;

	// Token: 0x0400D41B RID: 54299
	private const float SMOOTHED_ANGLE_DEAD_ZONE = 0.01f;

	// Token: 0x0400D41C RID: 54300
	private const float MIN_SPEED_FOR_TURN = 10f;

	// Token: 0x0400D41D RID: 54301
	private const float FRONT_ANGULAR_SPEED = 90f;

	// Token: 0x0400D41E RID: 54302
	private const float FRONT_ANGULAR_SPEED_DECREASE = 240f;

	// Token: 0x0400D41F RID: 54303
	private const float FRONT_ANGLE_SCALE = 0.3f;

	// Token: 0x0400D420 RID: 54304
	private const float SATURATION_ANGLE_DEG = 45f;

	// Token: 0x0400D421 RID: 54305
	private const float MAX_FRAME_TIME = 0.08f;

	// Token: 0x0400D422 RID: 54306
	private const float PATH_LINE_MIN_INPUT_COS = 0.707f;

	// Token: 0x0400D423 RID: 54307
	private const bool DEBUG_DRAW = false;

	// Token: 0x0400D424 RID: 54308
	private float SmoothedAngle;

	// Token: 0x0400D425 RID: 54309
	private float TurnAngle;

	// Token: 0x0400D426 RID: 54310
	private readonly Vector PathLineInputDirection = Vector.Create();

	// Token: 0x0400D427 RID: 54311
	private FVectorDouble DebugJointPt = new FVectorDouble(0.0, 0.0, 0.0);

	// Token: 0x0400D428 RID: 54312
	private FVectorDouble DebugForwardEndPt = new FVectorDouble(0.0, 0.0, 0.0);

	// Token: 0x0400D429 RID: 54313
	private FVectorDouble DebugInputEndPt = new FVectorDouble(0.0, 0.0, 0.0);

	// Token: 0x0400D42A RID: 54314
	private FVectorDouble DebugFrontHalfEndPt = new FVectorDouble(0.0, 0.0, 0.0);
}
