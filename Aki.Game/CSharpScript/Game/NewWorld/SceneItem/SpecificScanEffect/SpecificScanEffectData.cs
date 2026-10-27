using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.Common;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.SpecificScanEffect
{
	// Token: 0x020071B0 RID: 29104
	public class SpecificScanEffectData : IStaticVariableResetter
	{
		// Token: 0x0604737F RID: 291711 RVA: 0x01219B3C File Offset: 0x01217D3C
		public SpecificScanEffectData(int id, [Nullable(new byte[]
		{
			0,
			1,
			1
		})] OneOf<BP_DistortionWave_C, BP_Fx_Scanning_2_7_C> actor, FVectorDouble loc, ESpecificScanType? type = 1)
		{
			ESpecificScanType value = type.GetValueOrDefault();
			if (type == null)
			{
				value = ESpecificScanType.ChargeSlash;
				type = new ESpecificScanType?(value);
			}
			this.Id = id;
			this.EffectActor = new OneOf<BP_DistortionWave_C, BP_Fx_Scanning_2_7_C>?(actor);
			this.CurLoc = new FVectorDouble?(loc);
			this.CurTime = 0f;
			this.CurRadius = 0f;
			this.ScanType = type.Value;
		}

		// Token: 0x06047380 RID: 291712 RVA: 0x01219BC9 File Offset: 0x01217DC9
		static SpecificScanEffectData()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SpecificScanEffectData.CreateStaticDefaultValue), new Action(SpecificScanEffectData.ResetStaticDefaultValue));
		}

		// Token: 0x06047381 RID: 291713 RVA: 0x01219BE8 File Offset: 0x01217DE8
		public static void CreateStaticDefaultValue()
		{
			SpecificScanEffectData._sphereTrace = null;
			SpecificScanEffectData._useTrace = false;
			SpecificScanEffectData._timer = null;
			SpecificScanEffectData._maxScanDistanceInternal = null;
			SpecificScanEffectData._maxScanInteractionEffectDistanceInternal = null;
		}

		// Token: 0x06047382 RID: 291714 RVA: 0x01219C12 File Offset: 0x01217E12
		public static void ResetStaticDefaultValue()
		{
			SpecificScanEffectData._sphereTrace = null;
			SpecificScanEffectData._useTrace = false;
			SpecificScanEffectData._timer = null;
			SpecificScanEffectData._maxScanDistanceInternal = null;
			SpecificScanEffectData._maxScanInteractionEffectDistanceInternal = null;
		}

		// Token: 0x06047383 RID: 291715 RVA: 0x01219C3C File Offset: 0x01217E3C
		public bool Update(float delta)
		{
			this.CurTime += delta * (float)TimeUtil.Instance.Millisecond;
			if (this.CurRadius >= SpecificScanEffectData.GetScanMaxDistance())
			{
				return false;
			}
			double num = UKismetMathLibrary.D_FInterpTo(0.0, (double)SpecificScanEffectData.GetScanMaxDistance(), this.CurTime, 0.625f);
			this.CurRadius = (float)num;
			if (SpecificScanEffectData._sphereTrace == null)
			{
				SpecificScanEffectData.InitSphereTrace();
			}
			SpecificScanEffectData._sphereTrace.Radius = this.CurRadius;
			TraceElementCommon.Instance.SetStartLocation(SpecificScanEffectData._sphereTrace, this.CurLoc);
			TraceElementCommon.Instance.SetEndLocation(SpecificScanEffectData._sphereTrace, this.CurLoc);
			bool flag = TraceElementCommon.Instance.SphereTrace(SpecificScanEffectData._sphereTrace, "ChargeSlashScanEffectData");
			SpecificScanEffectData._useTrace = true;
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			AActor aactor;
			if (baseCharacter == null)
			{
				aactor = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				aactor = ((characterActorComponent != null) ? characterActorComponent.Owner : null);
			}
			AActor aactor2 = aactor;
			if (flag)
			{
				TArray<TWeakObjectPtr<AActor>> actors = SpecificScanEffectData._sphereTrace.HitResult.Actors;
				for (int i = 0; i < actors.Num(); i++)
				{
					AActor aactor3 = actors.Get(i).Get();
					if (aactor3 != null && aactor3 != aactor2 && !this.ScannedActor.Contains(aactor3))
					{
						if (LevelGamePlayController.Instance.HandleScanResponse(aactor3, (int)this.ScanType))
						{
							this.ScannedActor.Add(aactor3);
						}
						TsBaseCharacter tsBaseCharacter = aactor3 as TsBaseCharacter;
						if (tsBaseCharacter != null && tsBaseCharacter.Camp != ECamp.Player && this.TsBaseCharSet.Add(tsBaseCharacter))
						{
							BaseTagComponent component = EntitySystem.Instance.GetComponent<BaseTagComponent>(tsBaseCharacter.EntityId);
							if (component != null && component.Valid)
							{
								component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.扫描感应中"]));
							}
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06047384 RID: 291716 RVA: 0x01219E0C File Offset: 0x0121800C
		private static void InitSphereTrace()
		{
			SpecificScanEffectData._sphereTrace = new UTraceSphereElement();
			SpecificScanEffectData._sphereTrace.WorldContextObject = GlobalData.World;
			SpecificScanEffectData._sphereTrace.bIsSingle = false;
			SpecificScanEffectData._sphereTrace.bIgnoreSelf = true;
			SpecificScanEffectData._sphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.WorldDynamic);
			SpecificScanEffectData._sphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.Pawn);
			SpecificScanEffectData._sphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.KuroTrigger);
			SpecificScanEffectData._sphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.PawnPlayer);
			SpecificScanEffectData._sphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.PawnMonster);
			if (SpecificScanEffectData._timer == null)
			{
				TimerSystemInstance instance = TimerSystem.Instance;
				TTimerAction action;
				if ((action = SpecificScanEffectData.<>O.<0>__CheckAndReleaseActor) == null)
				{
					action = (SpecificScanEffectData.<>O.<0>__CheckAndReleaseActor = new TTimerAction(SpecificScanEffectData.CheckAndReleaseActor));
				}
				SpecificScanEffectData._timer = instance.Forever(action, 5000f, 1f, null, null, true);
			}
		}

		// Token: 0x06047385 RID: 291717 RVA: 0x01219ED1 File Offset: 0x012180D1
		private static void CheckAndReleaseActor(float delta)
		{
			if (SpecificScanEffectData._useTrace)
			{
				SpecificScanEffectData._useTrace = false;
				return;
			}
			if (SpecificScanEffectData._sphereTrace != null)
			{
				SpecificScanEffectData._sphereTrace.Dispose();
				SpecificScanEffectData._sphereTrace = null;
			}
			TimerSystem.Instance.Remove(SpecificScanEffectData._timer);
			SpecificScanEffectData._timer = null;
		}

		// Token: 0x17009DB2 RID: 40370
		// (get) Token: 0x06047386 RID: 291718 RVA: 0x01219F10 File Offset: 0x01218110
		public static float MaxScanDistance
		{
			get
			{
				if (SpecificScanEffectData._maxScanDistanceInternal == null)
				{
					SpecificScanEffectData._maxScanDistanceInternal = new float?((float)LevelGamePlayConfig.Instance.ScanMaxDistance);
					SpecificScanEffectData._maxScanDistanceInternal *= (float)100;
				}
				return SpecificScanEffectData._maxScanDistanceInternal.Value;
			}
		}

		// Token: 0x17009DB3 RID: 40371
		// (get) Token: 0x06047387 RID: 291719 RVA: 0x01219F7C File Offset: 0x0121817C
		public static float MaxScanInteractionEffectDistance
		{
			get
			{
				if (SpecificScanEffectData._maxScanInteractionEffectDistanceInternal == null)
				{
					SpecificScanEffectData._maxScanInteractionEffectDistanceInternal = new float?((float)LevelGamePlayConfig.Instance.ScanShowInteractionEffectMaxDistance);
					SpecificScanEffectData._maxScanInteractionEffectDistanceInternal *= (float)100;
				}
				return SpecificScanEffectData._maxScanInteractionEffectDistanceInternal.Value;
			}
		}

		// Token: 0x06047388 RID: 291720 RVA: 0x01219FE5 File Offset: 0x012181E5
		public static float GetScanMaxDistance()
		{
			return Math.Max(SpecificScanEffectData.MaxScanDistance, SpecificScanEffectData.MaxScanInteractionEffectDistance);
		}

		// Token: 0x0402572E RID: 153390
		private const float SCAN_EFFECT_STOP_TIME = 1.6f;

		// Token: 0x0402572F RID: 153391
		private const int TIMER_PERIOD = 5000;

		// Token: 0x04025730 RID: 153392
		public int Id;

		// Token: 0x04025731 RID: 153393
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public OneOf<BP_DistortionWave_C, BP_Fx_Scanning_2_7_C>? EffectActor;

		// Token: 0x04025732 RID: 153394
		private readonly FVectorDouble? CurLoc;

		// Token: 0x04025733 RID: 153395
		private float CurTime;

		// Token: 0x04025734 RID: 153396
		private float CurRadius;

		// Token: 0x04025735 RID: 153397
		private readonly ESpecificScanType ScanType = ESpecificScanType.ChargeSlash;

		// Token: 0x04025736 RID: 153398
		[Nullable(1)]
		private readonly HashSet<AActor> ScannedActor = new HashSet<AActor>();

		// Token: 0x04025737 RID: 153399
		[Nullable(1)]
		private readonly HashSet<TsBaseCharacter> TsBaseCharSet = new HashSet<TsBaseCharacter>();

		// Token: 0x04025738 RID: 153400
		[Nullable(2)]
		private static UTraceSphereElement _sphereTrace;

		// Token: 0x04025739 RID: 153401
		private static bool _useTrace;

		// Token: 0x0402573A RID: 153402
		[Nullable(2)]
		private static TimerHandle _timer;

		// Token: 0x0402573B RID: 153403
		private static float? _maxScanDistanceInternal;

		// Token: 0x0402573C RID: 153404
		private static float? _maxScanInteractionEffectDistanceInternal;

		// Token: 0x0200CF05 RID: 52997
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403E439 RID: 255033
			public static TTimerAction <0>__CheckAndReleaseActor;
		}
	}
}
