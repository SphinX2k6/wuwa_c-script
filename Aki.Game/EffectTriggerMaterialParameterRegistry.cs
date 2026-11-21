using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.AnimNotifyInteraction.BP;
using UnrealEngine;

// Token: 0x020029DE RID: 10718
[NullableContext(1)]
[Nullable(0)]
public class EffectTriggerMaterialParameterRegistry
{
	// Token: 0x0601AEA6 RID: 110246 RVA: 0x00844810 File Offset: 0x00842A10
	private static FName CreateName(string name)
	{
		return FNameUtil.GetDynamicFName(name).Value;
	}

	// Token: 0x0601AEA7 RID: 110247 RVA: 0x0084482C File Offset: 0x00842A2C
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

	// Token: 0x0601AEA8 RID: 110248 RVA: 0x0084488D File Offset: 0x00842A8D
	private static bool IsValidAction(EEffectAction action)
	{
		return action >= EEffectAction.GroundPound && action < EEffectAction.EEffectAction_MAX;
	}

	// Token: 0x0601AEA9 RID: 110249 RVA: 0x00844899 File Offset: 0x00842A99
	[NullableContext(2)]
	private static EffectTriggerActionParameterNames GetActionParameterNames(EEffectAction action)
	{
		if (!EffectTriggerMaterialParameterRegistry.IsValidAction(action))
		{
			return null;
		}
		return EffectTriggerMaterialParameterRegistry.ActionParameterNames[(int)action];
	}

	// Token: 0x0601AEAA RID: 110250 RVA: 0x008448B0 File Offset: 0x00842AB0
	public static bool IsValidActionAndIndex(EEffectAction action, int index)
	{
		return EffectTriggerMaterialParameterRegistry.IsValidAction(action) && EffectTriggerMaterialParameterRegistry.ResolveSlot(index) != null;
	}

	// Token: 0x0601AEAB RID: 110251 RVA: 0x008448D8 File Offset: 0x00842AD8
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

	// Token: 0x0601AEAC RID: 110252 RVA: 0x0084491C File Offset: 0x00842B1C
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

	// Token: 0x0601AEAD RID: 110253 RVA: 0x00844960 File Offset: 0x00842B60
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

	// Token: 0x0601AEAE RID: 110254 RVA: 0x008449A4 File Offset: 0x00842BA4
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

	// Token: 0x0601AEAF RID: 110255 RVA: 0x008449E8 File Offset: 0x00842BE8
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

	// Token: 0x0601AEB0 RID: 110256 RVA: 0x00844A2C File Offset: 0x00842C2C
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

	// Token: 0x0601AEB1 RID: 110257 RVA: 0x00844A70 File Offset: 0x00842C70
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

	// Token: 0x0601AEB2 RID: 110258 RVA: 0x00844AB4 File Offset: 0x00842CB4
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

	// Token: 0x0400E9D7 RID: 59863
	public const int MaxSlotIndex = 4;

	// Token: 0x0400E9D8 RID: 59864
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
