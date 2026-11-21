using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x020026C0 RID: 9920
[NullableContext(1)]
[Nullable(0)]
public class SkillBehaviorMisc : IStaticVariableResetter
{
	// Token: 0x06018DDF RID: 101855 RVA: 0x0078F46E File Offset: 0x0078D66E
	static SkillBehaviorMisc()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SkillBehaviorMisc.CreateStaticDefaultValue), new Action(SkillBehaviorMisc.ResetStaticDefaultValue));
	}

	// Token: 0x06018DE0 RID: 101856 RVA: 0x0078F4A3 File Offset: 0x0078D6A3
	public static List<EndSkillBehaviorParam> GetEndSkillBehaviorParamList(Skill skill)
	{
		if (!SkillBehaviorMisc.ParamMap.ContainsKey(skill))
		{
			SkillBehaviorMisc.ParamMap.Add(skill, new List<EndSkillBehaviorParam>());
		}
		return SkillBehaviorMisc.ParamMap[skill];
	}

	// Token: 0x06018DE1 RID: 101857 RVA: 0x0078F4CD File Offset: 0x0078D6CD
	[NullableContext(0)]
	public static ValueTuple<FVectorDouble, FVectorDouble> GetLocationAndDirection([Nullable(1)] AActor actor)
	{
		return new ValueTuple<FVectorDouble, FVectorDouble>(actor.D_K2_GetActorLocation(), actor.D_GetActorForwardVector());
	}

	// Token: 0x06018DE2 RID: 101858 RVA: 0x0078F4E0 File Offset: 0x0078D6E0
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

	// Token: 0x06018DE3 RID: 101859 RVA: 0x0078F558 File Offset: 0x0078D758
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

	// Token: 0x06018DE4 RID: 101860 RVA: 0x0078F60C File Offset: 0x0078D80C
	private static void Backward(float distance, Vector start, Vector end, Vector @out)
	{
		Vector vector = Vector.Create();
		end.Subtraction(start, vector);
		vector.Normalize(9.99999993922529E-09);
		vector.Multiply((double)distance, vector);
		@out.Subtraction(vector, @out);
	}

	// Token: 0x06018DE5 RID: 101861 RVA: 0x0078F64C File Offset: 0x0078D84C
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

	// Token: 0x06018DE6 RID: 101862 RVA: 0x0078F6F0 File Offset: 0x0078D8F0
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

	// Token: 0x06018DE7 RID: 101863 RVA: 0x0078F768 File Offset: 0x0078D968
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

	// Token: 0x06018DE8 RID: 101864 RVA: 0x0078F900 File Offset: 0x0078DB00
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

	// Token: 0x06018DE9 RID: 101865 RVA: 0x0078F95C File Offset: 0x0078DB5C
	public static void CreateStaticDefaultValue()
	{
		SkillBehaviorMisc.ParamMap = new Dictionary<Skill, List<EndSkillBehaviorParam>>();
	}

	// Token: 0x06018DEA RID: 101866 RVA: 0x0078F968 File Offset: 0x0078DB68
	public static void ResetStaticDefaultValue()
	{
		SkillBehaviorMisc.ParamMap = null;
		SkillBehaviorMisc._lineTraceStatic = null;
		SkillBehaviorMisc._lineTraceWater = null;
	}

	// Token: 0x0400D7E7 RID: 55271
	[StaticVariableRuleIgnore]
	public static readonly int[] Angles = new int[]
	{
		0,
		270,
		90,
		180
	};

	// Token: 0x0400D7E8 RID: 55272
	public static Dictionary<Skill, List<EndSkillBehaviorParam>> ParamMap;

	// Token: 0x0400D7E9 RID: 55273
	public const string CONTEXT = "SkillBehaviorAction.SetLocation";

	// Token: 0x0400D7EA RID: 55274
	private const float DELTA_HEIGHT = 2500f;

	// Token: 0x0400D7EB RID: 55275
	private const float WATER_DETECT_HEIGHT = 500f;

	// Token: 0x0400D7EC RID: 55276
	[Nullable(2)]
	private static UTraceLineElement _lineTraceStatic;

	// Token: 0x0400D7ED RID: 55277
	[Nullable(2)]
	private static UTraceLineElement _lineTraceWater;

	// Token: 0x020088DD RID: 35037
	[NullableContext(0)]
	private enum ETraceType
	{
		// Token: 0x0402BB85 RID: 179077
		Static,
		// Token: 0x0402BB86 RID: 179078
		Water
	}
}
