using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02003153 RID: 12627
[NullableContext(1)]
[Nullable(0)]
public class SkillBehaviorMisc : IStaticVariableResetter
{
	// Token: 0x0601B2DA RID: 111322 RVA: 0x00767AA2 File Offset: 0x00765CA2
	static SkillBehaviorMisc()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SkillBehaviorMisc.CreateStaticDefaultValue), new Action(SkillBehaviorMisc.ResetStaticDefaultValue));
	}

	// Token: 0x0601B2DB RID: 111323 RVA: 0x00767AD7 File Offset: 0x00765CD7
	public static List<EndSkillBehaviorParam> GetEndSkillBehaviorParamList(Skill skill)
	{
		if (!SkillBehaviorMisc.ParamMap.ContainsKey(skill))
		{
			SkillBehaviorMisc.ParamMap.Add(skill, new List<EndSkillBehaviorParam>());
		}
		return SkillBehaviorMisc.ParamMap[skill];
	}

	// Token: 0x0601B2DC RID: 111324 RVA: 0x00767B01 File Offset: 0x00765D01
	[NullableContext(0)]
	public static ValueTuple<FVectorDouble, FVectorDouble> GetLocationAndDirection([Nullable(1)] AActor actor)
	{
		return new ValueTuple<FVectorDouble, FVectorDouble>(actor.D_K2_GetActorLocation(), actor.D_GetActorForwardVector());
	}

	// Token: 0x0601B2DD RID: 111325 RVA: 0x00767B14 File Offset: 0x00765D14
	private static void SetupLineTrace(UTraceLineElement lineTrace, FLinearColor traceColor, FLinearColor hitColor, object queryType)
	{
		lineTrace.bIsSingle = true;
		lineTrace.bIgnoreSelf = true;
		lineTrace.DrawTime = 5f;
		TraceElementCommon.Instance.SetTraceColor(lineTrace, traceColor);
		TraceElementCommon.Instance.SetTraceHitColor(lineTrace, hitColor);
		Array array = queryType as Array;
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				lineTrace.AddObjectTypeQuery((EObjectTypeQuery)array.GetValue(i));
			}
			return;
		}
		lineTrace.SetTraceTypeQuery((ETraceTypeQuery)queryType);
	}

	// Token: 0x0601B2DE RID: 111326 RVA: 0x00767B8C File Offset: 0x00765D8C
	private static UTraceLineElement GetLineTrace(AActor myActor, bool draw, SkillBehaviorMisc.ETraceType type)
	{
		UTraceLineElement utraceLineElement = null;
		if (type != SkillBehaviorMisc.ETraceType.Static)
		{
			if (type == SkillBehaviorMisc.ETraceType.Water)
			{
				if (SkillBehaviorMisc._lineTraceWater == null)
				{
					SkillBehaviorMisc._lineTraceWater = new UTraceLineElement();
					SkillBehaviorMisc.SetupLineTrace(SkillBehaviorMisc._lineTraceWater, ColorUtils.LinearBlue, ColorUtils.LinearYellow, KuroTraceTypeQuery.Water);
				}
				utraceLineElement = SkillBehaviorMisc._lineTraceWater;
			}
		}
		else
		{
			if (SkillBehaviorMisc._lineTraceStatic == null)
			{
				SkillBehaviorMisc._lineTraceStatic = new UTraceLineElement();
				SkillBehaviorMisc.SetupLineTrace(SkillBehaviorMisc._lineTraceStatic, ColorUtils.LinearGreen, ColorUtils.LinearRed, new EObjectTypeQuery[]
				{
					KuroObjectTypeQuery.WorldStatic,
					KuroObjectTypeQuery.WorldStaticIgnoreBullet
				});
			}
			utraceLineElement = SkillBehaviorMisc._lineTraceStatic;
		}
		if (draw)
		{
			utraceLineElement.SetDrawDebugTrace(EDrawDebugTrace.ForDuration);
		}
		else
		{
			utraceLineElement.SetDrawDebugTrace(EDrawDebugTrace.None);
		}
		utraceLineElement.WorldContextObject = myActor;
		utraceLineElement.ClearCacheData(false);
		return utraceLineElement;
	}

	// Token: 0x0601B2DF RID: 111327 RVA: 0x00767C40 File Offset: 0x00765E40
	private static void Backward(float distance, Vector start, Vector end, Vector @out)
	{
		Vector vector = Vector.Create();
		end.Subtraction(start, vector);
		vector.Normalize(9.99999993922529E-09);
		vector.Multiply((double)distance, vector);
		@out.Subtraction(vector, @out);
	}

	// Token: 0x0601B2E0 RID: 111328 RVA: 0x00767C80 File Offset: 0x00765E80
	[return: Nullable(new byte[]
	{
		0,
		2,
		1
	})]
	public static ValueTuple<UKuroHitResult, Vector>? TraceWall(CharacterActorComponent myActorComp, Vector start, Vector end, bool draw)
	{
		UTraceLineElement lineTrace = SkillBehaviorMisc.GetLineTrace(myActorComp.Actor, draw, SkillBehaviorMisc.ETraceType.Static);
		TraceElementCommon.Instance.SetStartLocation(lineTrace, start);
		TraceElementCommon.Instance.SetEndLocation(lineTrace, end);
		bool flag = TraceElementCommon.Instance.LineTrace(lineTrace, "SkillBehaviorAction.SetLocation.traceWall");
		UKuroHitResult hitResult = lineTrace.HitResult;
		if (!flag || !hitResult.bBlockingHit)
		{
			return new ValueTuple<UKuroHitResult, Vector>?(new ValueTuple<UKuroHitResult, Vector>(null, end));
		}
		TraceElementCommon.Instance.GetHitLocation(hitResult, 0, end);
		if (start.Equals(end, 9.999999747378752E-05))
		{
			return null;
		}
		SkillBehaviorMisc.Backward(myActorComp.ScaledRadius, start, end, end);
		return new ValueTuple<UKuroHitResult, Vector>?(new ValueTuple<UKuroHitResult, Vector>(hitResult, end));
	}

	// Token: 0x0601B2E1 RID: 111329 RVA: 0x00767D24 File Offset: 0x00765F24
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	private static ValueTuple<bool, Vector> TraceWater(CharacterActorComponent myActorComp, Vector start, Vector end, bool draw)
	{
		UTraceLineElement lineTrace = SkillBehaviorMisc.GetLineTrace(myActorComp.Actor, draw, SkillBehaviorMisc.ETraceType.Water);
		TraceElementCommon.Instance.SetStartLocation(lineTrace, start);
		TraceElementCommon.Instance.SetEndLocation(lineTrace, end);
		bool flag = TraceElementCommon.Instance.LineTrace(lineTrace, "SkillBehaviorAction.SetLocation.traceWater");
		UKuroHitResult hitResult = lineTrace.HitResult;
		if (flag && hitResult.bBlockingHit)
		{
			Vector vector = Vector.Create();
			TraceElementCommon.Instance.GetHitLocation(hitResult, 0, vector);
			return new ValueTuple<bool, Vector>(true, vector);
		}
		return new ValueTuple<bool, Vector>(false, null);
	}

	// Token: 0x0601B2E2 RID: 111330 RVA: 0x00767D9C File Offset: 0x00765F9C
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public static ValueTuple<bool, Vector> TraceGroundWithGravity(CharacterActorComponent myActorComp, Vector start, bool draw, float traceHeight = 2500f)
	{
		CharacterMoveComponent component = myActorComp.Entity.GetComponent<CharacterMoveComponent>();
		CharacterSwimComponent component2 = myActorComp.Entity.GetComponent<CharacterSwimComponent>();
		Vector vector = Vector.Create();
		Vector vector2 = vector;
		component.GravityUp.Multiply((double)traceHeight, vector2);
		start.Subtraction(vector2, vector);
		UTraceLineElement lineTrace = SkillBehaviorMisc.GetLineTrace(myActorComp.Actor, draw, SkillBehaviorMisc.ETraceType.Static);
		TraceElementCommon.Instance.SetStartLocation(lineTrace, start);
		TraceElementCommon.Instance.SetEndLocation(lineTrace, vector);
		bool flag = TraceElementCommon.Instance.LineTrace(lineTrace, "SkillBehaviorAction.SetLocation.traceGround");
		UKuroHitResult hitResult = lineTrace.HitResult;
		if (!flag || !hitResult.bBlockingHit)
		{
			return new ValueTuple<bool, Vector>(false, null);
		}
		Vector vector3 = Vector.Create();
		Vector vector4 = Vector.Create();
		TraceElementCommon.Instance.GetHitLocation(hitResult, 0, vector3);
		component.GravityUp.Multiply((double)myActorComp.ScaledHalfHeight, vector2);
		start.Addition(vector2, vector4);
		ValueTuple<bool, Vector> valueTuple = SkillBehaviorMisc.TraceWater(myActorComp, vector4, vector3, draw);
		if (valueTuple.Item1 && valueTuple.Item2.Subtraction(vector3, vector4).DotProduct(component.GravityUp) >= (double)(myActorComp.ScaledHalfHeight * 2f) * 0.7)
		{
			return new ValueTuple<bool, Vector>(false, null);
		}
		if (component2 != null)
		{
			Vector vector5 = Vector.Create();
			start.Addition(vector2, vector5);
			Vector vector6 = Vector.Create();
			component.GravityUp.Multiply(500.0, vector6);
			vector6.AdditionEqual(vector5);
			if (SkillBehaviorMisc.TraceWater(myActorComp, vector6, vector5, draw).Item1)
			{
				return new ValueTuple<bool, Vector>(false, null);
			}
		}
		vector3.AdditionEqual(vector2);
		return new ValueTuple<bool, Vector>(true, vector3);
	}

	// Token: 0x0601B2E3 RID: 111331 RVA: 0x00767F34 File Offset: 0x00766134
	public static bool Compare(ESkillBehaviorComparisonLogic logic, float lValue, float rValue, float lRange, float rRange)
	{
		switch (logic)
		{
		case ESkillBehaviorComparisonLogic.Greater:
			return lValue > rValue;
		case ESkillBehaviorComparisonLogic.GreaterEqual:
			return lValue >= rValue;
		case ESkillBehaviorComparisonLogic.Equal:
			return lValue == rValue;
		case ESkillBehaviorComparisonLogic.Less:
			return lValue < rValue;
		case ESkillBehaviorComparisonLogic.LessEqual:
			return lValue <= rValue;
		case ESkillBehaviorComparisonLogic.Range:
			return lValue >= lRange && lValue <= rRange;
		default:
			return false;
		}
	}

	// Token: 0x0601B2E4 RID: 111332 RVA: 0x00767F90 File Offset: 0x00766190
	public static void CreateStaticDefaultValue()
	{
		SkillBehaviorMisc.ParamMap = new Dictionary<Skill, List<EndSkillBehaviorParam>>();
	}

	// Token: 0x0601B2E5 RID: 111333 RVA: 0x00767F9C File Offset: 0x0076619C
	public static void ResetStaticDefaultValue()
	{
		SkillBehaviorMisc.ParamMap = null;
		SkillBehaviorMisc._lineTraceStatic = null;
		SkillBehaviorMisc._lineTraceWater = null;
	}

	// Token: 0x0400D384 RID: 54148
	[StaticVariableRuleIgnore]
	public static readonly int[] Angles = new int[]
	{
		0,
		270,
		90,
		180
	};

	// Token: 0x0400D385 RID: 54149
	public static Dictionary<Skill, List<EndSkillBehaviorParam>> ParamMap;

	// Token: 0x0400D386 RID: 54150
	public const string CONTEXT = "SkillBehaviorAction.SetLocation";

	// Token: 0x0400D387 RID: 54151
	private const float DELTA_HEIGHT = 2500f;

	// Token: 0x0400D388 RID: 54152
	private const float WATER_DETECT_HEIGHT = 500f;

	// Token: 0x0400D389 RID: 54153
	[Nullable(2)]
	private static UTraceLineElement _lineTraceStatic;

	// Token: 0x0400D38A RID: 54154
	[Nullable(2)]
	private static UTraceLineElement _lineTraceWater;

	// Token: 0x020096B7 RID: 38583
	[NullableContext(0)]
	private enum ETraceType
	{
		// Token: 0x040304F0 RID: 197872
		Static,
		// Token: 0x040304F1 RID: 197873
		Water
	}
}
