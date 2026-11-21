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
	// Token: 0x02006265 RID: 25189
	public class SpecificScanEffectData : IStaticVariableResetter
	{
		// Token: 0x0603CC7A RID: 248954 RVA: 0x01173A40 File Offset: 0x01171C40
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

		// Token: 0x0603CC7B RID: 248955 RVA: 0x01173ACD File Offset: 0x01171CCD
		static SpecificScanEffectData()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SpecificScanEffectData.CreateStaticDefaultValue), new Action(SpecificScanEffectData.ResetStaticDefaultValue));
		}

		// Token: 0x0603CC7C RID: 248956 RVA: 0x01173AEC File Offset: 0x01171CEC
		public static void CreateStaticDefaultValue()
		{
			SpecificScanEffectData._sphereTrace = null;
			SpecificScanEffectData._useTrace = false;
			SpecificScanEffectData._timer = null;
			SpecificScanEffectData._maxScanDistanceInternal = null;
			SpecificScanEffectData._maxScanInteractionEffectDistanceInternal = null;
		}

		// Token: 0x0603CC7D RID: 248957 RVA: 0x01173B16 File Offset: 0x01171D16
		public static void ResetStaticDefaultValue()
		{
			SpecificScanEffectData._sphereTrace = null;
			SpecificScanEffectData._useTrace = false;
			SpecificScanEffectData._timer = null;
			SpecificScanEffectData._maxScanDistanceInternal = null;
			SpecificScanEffectData._maxScanInteractionEffectDistanceInternal = null;
		}

		// Token: 0x0603CC7E RID: 248958 RVA: 0x01173B40 File Offset: 0x01171D40
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

		// Token: 0x0603CC7F RID: 248959 RVA: 0x01173D10 File Offset: 0x01171F10
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

		// Token: 0x0603CC80 RID: 248960 RVA: 0x01173DD5 File Offset: 0x01171FD5
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

		// Token: 0x17007302 RID: 29442
		// (get) Token: 0x0603CC81 RID: 248961 RVA: 0x01173E14 File Offset: 0x01172014
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

		// Token: 0x17007303 RID: 29443
		// (get) Token: 0x0603CC82 RID: 248962 RVA: 0x01173E80 File Offset: 0x01172080
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

		// Token: 0x0603CC83 RID: 248963 RVA: 0x01173EE9 File Offset: 0x011720E9
		public static float GetScanMaxDistance()
		{
			return Math.Max(SpecificScanEffectData.MaxScanDistance, SpecificScanEffectData.MaxScanInteractionEffectDistance);
		}

		// Token: 0x0402039D RID: 131997
		private const float SCAN_EFFECT_STOP_TIME = 1.6f;

		// Token: 0x0402039E RID: 131998
		private const int TIMER_PERIOD = 5000;

		// Token: 0x0402039F RID: 131999
		public int Id;

		// Token: 0x040203A0 RID: 132000
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public OneOf<BP_DistortionWave_C, BP_Fx_Scanning_2_7_C>? EffectActor;

		// Token: 0x040203A1 RID: 132001
		private readonly FVectorDouble? CurLoc;

		// Token: 0x040203A2 RID: 132002
		private float CurTime;

		// Token: 0x040203A3 RID: 132003
		private float CurRadius;

		// Token: 0x040203A4 RID: 132004
		private readonly ESpecificScanType ScanType = ESpecificScanType.ChargeSlash;

		// Token: 0x040203A5 RID: 132005
		[Nullable(1)]
		private readonly HashSet<AActor> ScannedActor = new HashSet<AActor>();

		// Token: 0x040203A6 RID: 132006
		[Nullable(1)]
		private readonly HashSet<TsBaseCharacter> TsBaseCharSet = new HashSet<TsBaseCharacter>();

		// Token: 0x040203A7 RID: 132007
		[Nullable(2)]
		private static UTraceSphereElement _sphereTrace;

		// Token: 0x040203A8 RID: 132008
		private static bool _useTrace;

		// Token: 0x040203A9 RID: 132009
		[Nullable(2)]
		private static TimerHandle _timer;

		// Token: 0x040203AA RID: 132010
		private static float? _maxScanDistanceInternal;

		// Token: 0x040203AB RID: 132011
		private static float? _maxScanInteractionEffectDistanceInternal;

		// Token: 0x0200BA9A RID: 47770
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403975E RID: 235358
			public static TTimerAction <0>__CheckAndReleaseActor;
		}
	}
}
