using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x020063EF RID: 25583
	[NullableContext(1)]
	[Nullable(0)]
	public class KuroEffectActorHandle
	{
		// Token: 0x0603E047 RID: 254023 RVA: 0x011FDE5B File Offset: 0x011FC05B
		public KuroEffectActorHandle(int id)
		{
		}

		// Token: 0x0603E048 RID: 254024 RVA: 0x011FDE6A File Offset: 0x011FC06A
		public bool IsValid()
		{
			return UKuroEffectSystemHandleHelperLibrary.ActorHandle_IsValid(this.<id>P);
		}

		// Token: 0x0603E049 RID: 254025 RVA: 0x011FDE77 File Offset: 0x011FC077
		public void SetActorHiddenInGame(bool hiddenInGame)
		{
			UKuroEffectSystemHandleHelperLibrary.ActorHandle_SetActorHiddenInGame(this.<id>P, hiddenInGame);
		}

		// Token: 0x0603E04A RID: 254026 RVA: 0x011FDE85 File Offset: 0x011FC085
		[NullableContext(2)]
		public void K2_AttachToActor(AActor parent, FName socketName, EAttachmentRule locationRule, EAttachmentRule rotationRule, EAttachmentRule scaleRule, bool bWeldSimulatedBodies)
		{
			UKuroEffectSystemHandleHelperLibrary.ActorHandle_K2_AttachToActor(this.<id>P, parent, socketName, locationRule, rotationRule, scaleRule, bWeldSimulatedBodies);
		}

		// Token: 0x0603E04B RID: 254027 RVA: 0x011FDE9C File Offset: 0x011FC09C
		[NullableContext(2)]
		public void K2_AttachToComponent(USceneComponent parent, FName socketName, EAttachmentRule locationRule, EAttachmentRule rotationRule, EAttachmentRule scaleRule, bool bWeldSimulatedBodies)
		{
			UKuroEffectSystemHandleHelperLibrary.ActorHandle_K2_AttachToComponent(this.<id>P, parent, socketName, locationRule, rotationRule, scaleRule, bWeldSimulatedBodies);
		}

		// Token: 0x0603E04C RID: 254028 RVA: 0x011FDEB3 File Offset: 0x011FC0B3
		public FVectorDouble GetActorLocation()
		{
			return UKuroEffectSystemHandleHelperLibrary.ActorHandle_GetActorLocation(this.<id>P);
		}

		// Token: 0x0603E04D RID: 254029 RVA: 0x011FDEC0 File Offset: 0x011FC0C0
		public FVectorDouble D_K2_GetActorLocation()
		{
			return UKuroEffectSystemHandleHelperLibrary.ActorHandle_D_K2_GetActorLocation(this.<id>P);
		}

		// Token: 0x0603E04E RID: 254030 RVA: 0x011FDECD File Offset: 0x011FC0CD
		public FRotator K2_GetActorRotation()
		{
			return UKuroEffectSystemHandleHelperLibrary.ActorHandle_K2_GetActorRotation(this.<id>P);
		}

		// Token: 0x0603E04F RID: 254031 RVA: 0x011FDEDA File Offset: 0x011FC0DA
		public FVectorDouble D_GetActorScale3D()
		{
			return UKuroEffectSystemHandleHelperLibrary.ActorHandle_D_GetActorScale3D(this.<id>P);
		}

		// Token: 0x0603E050 RID: 254032 RVA: 0x011FDEE7 File Offset: 0x011FC0E7
		public bool D_K2_SetActorLocation(in FVectorDouble location, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			sweepHitResult = new FHitResult();
			return UKuroEffectSystemHandleHelperLibrary.ActorHandle_D_K2_SetActorLocation(this.<id>P, location, bSweep, ref sweepHitResult, bTeleport);
		}

		// Token: 0x0603E051 RID: 254033 RVA: 0x011FDF00 File Offset: 0x011FC100
		public bool K2_SetActorRotation(in FRotator rotation, bool bTeleportPhysics)
		{
			return UKuroEffectSystemHandleHelperLibrary.ActorHandle_K2_SetActorRotation(this.<id>P, rotation, bTeleportPhysics);
		}

		// Token: 0x0603E052 RID: 254034 RVA: 0x011FDF0F File Offset: 0x011FC10F
		public void D_SetActorScale3D(in FVectorDouble scale)
		{
			UKuroEffectSystemHandleHelperLibrary.ActorHandle_D_SetActorScale3D(this.<id>P, scale);
		}

		// Token: 0x0603E053 RID: 254035 RVA: 0x011FDF1D File Offset: 0x011FC11D
		public bool D_K2_SetActorLocationAndRotation(in FVectorDouble location, in FRotator rotation, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			return UKuroEffectSystemHandleHelperLibrary.ActorHandle_D_K2_SetActorLocationAndRotation(this.<id>P, location, rotation, bSweep, ref sweepHitResult, bTeleport);
		}

		// Token: 0x0603E054 RID: 254036 RVA: 0x011FDF31 File Offset: 0x011FC131
		public void D_K2_AddActorWorldOffset(in FVectorDouble deltaLocation, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			UKuroEffectSystemHandleHelperLibrary.ActorHandle_D_K2_AddActorWorldOffset(this.<id>P, deltaLocation, bSweep, ref sweepHitResult, bTeleport);
		}

		// Token: 0x0603E055 RID: 254037 RVA: 0x011FDF43 File Offset: 0x011FC143
		public bool D_K2_SetActorTransform(in FTransformDouble transform, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			return UKuroEffectSystemHandleHelperLibrary.ActorHandle_D_K2_SetActorTransform(this.<id>P, transform, bSweep, ref sweepHitResult, bTeleport);
		}

		// Token: 0x0603E056 RID: 254038 RVA: 0x011FDF55 File Offset: 0x011FC155
		public void D_K2_SetActorRelativeLocation(in FVectorDouble relativeLocation, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			UKuroEffectSystemHandleHelperLibrary.ActorHandle_D_K2_SetActorRelativeLocation(this.<id>P, relativeLocation, bSweep, ref sweepHitResult, bTeleport);
		}

		// Token: 0x0603E057 RID: 254039 RVA: 0x011FDF67 File Offset: 0x011FC167
		public void K2_SetActorRelativeRotation(in FRotator relativeRotation, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			UKuroEffectSystemHandleHelperLibrary.ActorHandle_K2_SetActorRelativeRotation(this.<id>P, relativeRotation, bSweep, ref sweepHitResult, bTeleport);
		}

		// Token: 0x0603E058 RID: 254040 RVA: 0x011FDF79 File Offset: 0x011FC179
		public void D_K2_SetActorRelativeTransform(in FTransformDouble relativeTransform, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			UKuroEffectSystemHandleHelperLibrary.ActorHandle_D_K2_SetActorRelativeTransform(this.<id>P, relativeTransform, bSweep, ref sweepHitResult, bTeleport);
		}

		// Token: 0x0603E059 RID: 254041 RVA: 0x011FDF8B File Offset: 0x011FC18B
		public void K2_AddActorLocalTransform(in FTransform transform, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			UKuroEffectSystemHandleHelperLibrary.ActorHandle_K2_AddActorLocalTransform(this.<id>P, transform, bSweep, ref sweepHitResult, bTeleport);
		}

		// Token: 0x04020E90 RID: 134800
		[CompilerGenerated]
		private int <id>P = id;
	}
}
