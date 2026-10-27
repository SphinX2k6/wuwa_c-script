using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.AnimNotifyInteraction.BP;
using UnrealEngine;

// Token: 0x0200346A RID: 13418
[NullableContext(1)]
[Nullable(0)]
public class EffectTriggerMaterialParameterRegistry
{
	// Token: 0x0601D19E RID: 119198 RVA: 0x0081D510 File Offset: 0x0081B710
	private static FName CreateName(string name)
	{
		return FNameUtil.GetDynamicFName(name).Value;
	}

	// Token: 0x0601D19F RID: 119199 RVA: 0x0081D52C File Offset: 0x0081B72C
	private static int? ResolveSlot(int index)
	{
		if (index < 0 || index > 4)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.ZJL;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(65, 1);
			defaultInterpolatedStringHandler.AppendLiteral("EffectTriggerMaterialParameterRegistry ResolveSlot index无效 index=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(index);
			instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return new int?(index);
	}

	// Token: 0x0601D1A0 RID: 119200 RVA: 0x0081D58D File Offset: 0x0081B78D
	private static bool IsValidAction(EEffectAction action)
	{
		return action >= EEffectAction.GroundPound && action < EEffectAction.EEffectAction_MAX;
	}

	// Token: 0x0601D1A1 RID: 119201 RVA: 0x0081D599 File Offset: 0x0081B799
	[NullableContext(2)]
	private static EffectTriggerActionParameterNames GetActionParameterNames(EEffectAction action)
	{
		if (!EffectTriggerMaterialParameterRegistry.IsValidAction(action))
		{
			return null;
		}
		return EffectTriggerMaterialParameterRegistry.ActionParameterNames[(int)action];
	}

	// Token: 0x0601D1A2 RID: 119202 RVA: 0x0081D5B0 File Offset: 0x0081B7B0
	public static bool IsValidActionAndIndex(EEffectAction action, int index)
	{
		return EffectTriggerMaterialParameterRegistry.IsValidAction(action) && EffectTriggerMaterialParameterRegistry.ResolveSlot(index) != null;
	}

	// Token: 0x0601D1A3 RID: 119203 RVA: 0x0081D5D8 File Offset: 0x0081B7D8
	public static FName GetTriggerParameterName(EEffectAction action, int index)
	{
		int? num = EffectTriggerMaterialParameterRegistry.ResolveSlot(index);
		if (num == null)
		{
			return FNameUtil.EMPTY;
		}
		EffectTriggerActionParameterNames actionParameterNames = EffectTriggerMaterialParameterRegistry.GetActionParameterNames(action);
		if (actionParameterNames == null)
		{
			return FNameUtil.EMPTY;
		}
		return actionParameterNames.Trigger[num.Value];
	}

	// Token: 0x0601D1A4 RID: 119204 RVA: 0x0081D61C File Offset: 0x0081B81C
	public static FName GetDurationParameterName(EEffectAction action, int index)
	{
		int? num = EffectTriggerMaterialParameterRegistry.ResolveSlot(index);
		if (num == null)
		{
			return FNameUtil.EMPTY;
		}
		EffectTriggerActionParameterNames actionParameterNames = EffectTriggerMaterialParameterRegistry.GetActionParameterNames(action);
		if (actionParameterNames == null)
		{
			return FNameUtil.EMPTY;
		}
		return actionParameterNames.Duration[num.Value];
	}

	// Token: 0x0601D1A5 RID: 119205 RVA: 0x0081D660 File Offset: 0x0081B860
	public static FName GetAttackRadiusParameterName(EEffectAction action, int index)
	{
		int? num = EffectTriggerMaterialParameterRegistry.ResolveSlot(index);
		if (num == null)
		{
			return FNameUtil.EMPTY;
		}
		EffectTriggerActionParameterNames actionParameterNames = EffectTriggerMaterialParameterRegistry.GetActionParameterNames(action);
		if (actionParameterNames == null)
		{
			return FNameUtil.EMPTY;
		}
		return actionParameterNames.AttackRadius[num.Value];
	}

	// Token: 0x0601D1A6 RID: 119206 RVA: 0x0081D6A4 File Offset: 0x0081B8A4
	public static FName GetAttackMagnitudeParameterName(EEffectAction action, int index)
	{
		int? num = EffectTriggerMaterialParameterRegistry.ResolveSlot(index);
		if (num == null)
		{
			return FNameUtil.EMPTY;
		}
		EffectTriggerActionParameterNames actionParameterNames = EffectTriggerMaterialParameterRegistry.GetActionParameterNames(action);
		if (actionParameterNames == null)
		{
			return FNameUtil.EMPTY;
		}
		return actionParameterNames.AttackMagnitude[num.Value];
	}

	// Token: 0x0601D1A7 RID: 119207 RVA: 0x0081D6E8 File Offset: 0x0081B8E8
	public static FName GetActorLocationParameterName(EEffectAction action, int index)
	{
		int? num = EffectTriggerMaterialParameterRegistry.ResolveSlot(index);
		if (num == null)
		{
			return FNameUtil.EMPTY;
		}
		EffectTriggerActionParameterNames actionParameterNames = EffectTriggerMaterialParameterRegistry.GetActionParameterNames(action);
		if (actionParameterNames == null)
		{
			return FNameUtil.EMPTY;
		}
		return actionParameterNames.ActorLocation[num.Value];
	}

	// Token: 0x0601D1A8 RID: 119208 RVA: 0x0081D72C File Offset: 0x0081B92C
	public static FName GetCurveFloatParameterName(EEffectAction action, int index)
	{
		int? num = EffectTriggerMaterialParameterRegistry.ResolveSlot(index);
		if (num == null)
		{
			return FNameUtil.EMPTY;
		}
		EffectTriggerActionParameterNames actionParameterNames = EffectTriggerMaterialParameterRegistry.GetActionParameterNames(action);
		if (actionParameterNames == null)
		{
			return FNameUtil.EMPTY;
		}
		return actionParameterNames.CurveFloat[num.Value];
	}

	// Token: 0x0601D1A9 RID: 119209 RVA: 0x0081D770 File Offset: 0x0081B970
	public static FName GetElapsedTimeParameterName(EEffectAction action, int index)
	{
		int? num = EffectTriggerMaterialParameterRegistry.ResolveSlot(index);
		if (num == null)
		{
			return FNameUtil.EMPTY;
		}
		EffectTriggerActionParameterNames actionParameterNames = EffectTriggerMaterialParameterRegistry.GetActionParameterNames(action);
		if (actionParameterNames == null)
		{
			return FNameUtil.EMPTY;
		}
		return actionParameterNames.ElapsedTime[num.Value];
	}

	// Token: 0x0601D1AA RID: 119210 RVA: 0x0081D7B4 File Offset: 0x0081B9B4
	public static FName GetTextureHeightParameterName(EEffectAction action, int index)
	{
		int? num = EffectTriggerMaterialParameterRegistry.ResolveSlot(index);
		if (num == null)
		{
			return FNameUtil.EMPTY;
		}
		EffectTriggerActionParameterNames actionParameterNames = EffectTriggerMaterialParameterRegistry.GetActionParameterNames(action);
		if (actionParameterNames == null)
		{
			return FNameUtil.EMPTY;
		}
		return actionParameterNames.TextureHeight[num.Value];
	}

	// Token: 0x0400E51F RID: 58655
	public const int MaxSlotIndex = 4;

	// Token: 0x0400E520 RID: 58656
	private static readonly IReadOnlyList<EffectTriggerActionParameterNames> ActionParameterNames = new EffectTriggerActionParameterNames[]
	{
		new EffectTriggerActionParameterNames(new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundTrig0"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundTrig1"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundTrig2"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundTrig3"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundTrig4")
		}, new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundDurat0"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundDurat1"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundDurat2"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundDurat3"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundDurat4")
		}, new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundAtkRad0"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundAtkRad1"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundAtkRad2"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundAtkRad3"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundAtkRad4")
		}, new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundAtkMag0"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundAtkMag1"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundAtkMag2"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundAtkMag3"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundAtkMag4")
		}, new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundActorLoc0"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundActorLoc1"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundActorLoc2"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundActorLoc3"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundActorLoc4")
		}, new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundCurve0"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundCurve1"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundCurve2"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundCurve3"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundCurve4")
		}, new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundElapsedTime0"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundElapsedTime1"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundElapsedTime2"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundElapsedTime3"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundElapsedTime4")
		}, new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundTextureHeight0"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundTextureHeight1"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundTextureHeight2"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundTextureHeight3"),
			EffectTriggerMaterialParameterRegistry.CreateName("GroundPoundTextureHeight4")
		}),
		new EffectTriggerActionParameterNames(new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveTrig0"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveTrig1"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveTrig2"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveTrig3"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveTrig4")
		}, new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveDurat0"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveDurat1"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveDurat2"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveDurat3"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveDurat4")
		}, new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveAtkRad0"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveAtkRad1"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveAtkRad2"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveAtkRad3"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveAtkRad4")
		}, new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveAtkMag0"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveAtkMag1"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveAtkMag2"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveAtkMag3"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveAtkMag4")
		}, new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveActorLoc0"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveActorLoc1"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveActorLoc2"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveActorLoc3"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveActorLoc4")
		}, new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveCurve0"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveCurve1"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveCurve2"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveCurve3"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveCurve4")
		}, new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveElapsedTime0"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveElapsedTime1"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveElapsedTime2"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveElapsedTime3"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveElapsedTime4")
		}, new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveTextureHeight0"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveTextureHeight1"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveTextureHeight2"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveTextureHeight3"),
			EffectTriggerMaterialParameterRegistry.CreateName("ShockwaveTextureHeight4")
		}),
		new EffectTriggerActionParameterNames(new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalTrig0"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalTrig1"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalTrig2"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalTrig3"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalTrig4")
		}, new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalDurat0"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalDurat1"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalDurat2"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalDurat3"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalDurat4")
		}, new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalAtkRad0"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalAtkRad1"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalAtkRad2"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalAtkRad3"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalAtkRad4")
		}, new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalAtkMag0"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalAtkMag1"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalAtkMag2"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalAtkMag3"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalAtkMag4")
		}, new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalActorLoc0"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalActorLoc1"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalActorLoc2"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalActorLoc3"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalActorLoc4")
		}, new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalCurve0"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalCurve1"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalCurve2"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalCurve3"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalCurve4")
		}, new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalElapsedTime0"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalElapsedTime1"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalElapsedTime2"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalElapsedTime3"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalElapsedTime4")
		}, new FName[]
		{
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalTextureHeight0"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalTextureHeight1"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalTextureHeight2"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalTextureHeight3"),
			EffectTriggerMaterialParameterRegistry.CreateName("DiagonalTextureHeight4")
		})
	};
}
