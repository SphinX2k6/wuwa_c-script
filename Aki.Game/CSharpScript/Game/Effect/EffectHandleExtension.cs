using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x02007269 RID: 29289
	[NullableContext(1)]
	[Nullable(0)]
	public static class EffectHandleExtension
	{
		// Token: 0x06047BFD RID: 293885 RVA: 0x0125C3D6 File Offset: 0x0125A5D6
		public static bool IsValid([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self)
		{
			if (self.IsT1)
			{
				return self.AsT1.IsValid();
			}
			return self.IsT2 && self.AsT2.IsValid();
		}

		// Token: 0x06047BFE RID: 293886 RVA: 0x0125C405 File Offset: 0x0125A605
		public static void SetActorHiddenInGame([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, bool hiddenInGame)
		{
			if (self.IsT1)
			{
				self.AsT1.SetActorHiddenInGame(hiddenInGame);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.SetActorHiddenInGame(hiddenInGame);
			}
		}

		// Token: 0x06047BFF RID: 293887 RVA: 0x0125C434 File Offset: 0x0125A634
		[NullableContext(2)]
		public static void K2_AttachToActor([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, AActor parent, in FName? socketName, EAttachmentRule locationRule, EAttachmentRule rotationRule, EAttachmentRule scaleRule, bool bWeldSimulatedBodies)
		{
			if (self.IsT1)
			{
				self.AsT1.K2_AttachToActor(parent, socketName ?? FName.NAME_None, locationRule, rotationRule, scaleRule, bWeldSimulatedBodies);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.K2_AttachToActor(parent, socketName ?? FName.NAME_None, locationRule, rotationRule, scaleRule, bWeldSimulatedBodies, true);
			}
		}

		// Token: 0x06047C00 RID: 293888 RVA: 0x0125C4BC File Offset: 0x0125A6BC
		[NullableContext(2)]
		public static void K2_AttachToComponent([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, USceneComponent parent, FName? socketName, EAttachmentRule locationRule, EAttachmentRule rotationRule, EAttachmentRule scaleRule, bool bWeldSimulatedBodies)
		{
			if (self.IsT1)
			{
				self.AsT1.K2_AttachToComponent(parent, socketName ?? FName.NAME_None, locationRule, rotationRule, scaleRule, bWeldSimulatedBodies);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.K2_AttachToComponent(parent, socketName ?? FName.NAME_None, locationRule, rotationRule, scaleRule, bWeldSimulatedBodies, true);
			}
		}

		// Token: 0x06047C01 RID: 293889 RVA: 0x0125C538 File Offset: 0x0125A738
		public static FVectorDouble GetActorLocation([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self)
		{
			if (self.IsT1)
			{
				return self.AsT1.GetActorLocation();
			}
			if (self.IsT2)
			{
				return self.AsT2.D_K2_GetActorLocation();
			}
			return default(FVectorDouble);
		}

		// Token: 0x06047C02 RID: 293890 RVA: 0x0125C57C File Offset: 0x0125A77C
		public static FVectorDouble D_K2_GetActorLocation([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self)
		{
			if (self.IsT1)
			{
				return self.AsT1.D_K2_GetActorLocation();
			}
			if (self.IsT2)
			{
				return self.AsT2.D_K2_GetActorLocation();
			}
			return default(FVectorDouble);
		}

		// Token: 0x06047C03 RID: 293891 RVA: 0x0125C5C0 File Offset: 0x0125A7C0
		public static FRotator K2_GetActorRotation([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self)
		{
			if (self.IsT1)
			{
				return self.AsT1.K2_GetActorRotation();
			}
			if (self.IsT2)
			{
				return self.AsT2.K2_GetActorRotation();
			}
			return default(FRotator);
		}

		// Token: 0x06047C04 RID: 293892 RVA: 0x0125C604 File Offset: 0x0125A804
		public static FVectorDouble D_GetActorScale3D([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self)
		{
			if (self.IsT1)
			{
				return self.AsT1.D_GetActorScale3D();
			}
			if (self.IsT2)
			{
				return self.AsT2.D_GetActorScale3D();
			}
			return default(FVectorDouble);
		}

		// Token: 0x06047C05 RID: 293893 RVA: 0x0125C646 File Offset: 0x0125A846
		public static bool D_K2_SetActorLocation([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, in FVectorDouble location, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			if (self.IsT1)
			{
				return self.AsT1.D_K2_SetActorLocation(location, bSweep, ref sweepHitResult, bTeleport);
			}
			return self.IsT2 && self.AsT2.D_K2_SetActorLocation(location, bSweep, ref sweepHitResult, bTeleport);
		}

		// Token: 0x06047C06 RID: 293894 RVA: 0x0125C684 File Offset: 0x0125A884
		public static bool K2_SetActorRotation([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, in FRotator rotation, bool bTeleportPhysics)
		{
			if (self.IsT1)
			{
				return self.AsT1.K2_SetActorRotation(rotation, bTeleportPhysics);
			}
			return self.IsT2 && self.AsT2.K2_SetActorRotation(rotation, bTeleportPhysics);
		}

		// Token: 0x06047C07 RID: 293895 RVA: 0x0125C6BC File Offset: 0x0125A8BC
		public static void D_SetActorScale3D([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, in FVectorDouble scale)
		{
			if (self.IsT1)
			{
				self.AsT1.D_SetActorScale3D(scale);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.D_SetActorScale3D(scale);
			}
		}

		// Token: 0x06047C08 RID: 293896 RVA: 0x0125C6F0 File Offset: 0x0125A8F0
		public static bool D_K2_SetActorLocationAndRotation([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, in FVectorDouble location, in FRotator rotation, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			if (self.IsT1)
			{
				return self.AsT1.D_K2_SetActorLocationAndRotation(location, rotation, false, ref sweepHitResult, true);
			}
			return self.IsT2 && self.AsT2.D_K2_SetActorLocationAndRotation(location, rotation, false, ref sweepHitResult, true);
		}

		// Token: 0x06047C09 RID: 293897 RVA: 0x0125C740 File Offset: 0x0125A940
		public static void D_K2_AddActorWorldOffset([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, in FVectorDouble deltaLocation, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			if (self.IsT1)
			{
				self.AsT1.D_K2_AddActorWorldOffset(deltaLocation, bSweep, ref sweepHitResult, bTeleport);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.D_K2_AddActorWorldOffset(deltaLocation, bSweep, ref sweepHitResult, bTeleport);
			}
		}

		// Token: 0x06047C0A RID: 293898 RVA: 0x0125C77C File Offset: 0x0125A97C
		public static bool D_K2_SetActorTransform([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, in FTransformDouble transform, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			if (self.IsT1)
			{
				return self.AsT1.D_K2_SetActorTransform(transform, bSweep, ref sweepHitResult, bTeleport);
			}
			return self.IsT2 && self.AsT2.D_K2_SetActorTransform(transform, bSweep, ref sweepHitResult, bTeleport);
		}

		// Token: 0x06047C0B RID: 293899 RVA: 0x0125C7B5 File Offset: 0x0125A9B5
		public static void D_K2_SetActorRelativeLocation([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, in FVectorDouble relativeLocation, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			if (self.IsT1)
			{
				self.AsT1.D_K2_SetActorRelativeLocation(relativeLocation, bSweep, ref sweepHitResult, bTeleport);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.D_K2_SetActorRelativeLocation(relativeLocation, bSweep, ref sweepHitResult, bTeleport);
			}
		}

		// Token: 0x06047C0C RID: 293900 RVA: 0x0125C7F1 File Offset: 0x0125A9F1
		public static void K2_SetActorRelativeRotation([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, in FRotator relativeRotation, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			if (self.IsT1)
			{
				self.AsT1.K2_SetActorRelativeRotation(relativeRotation, bSweep, ref sweepHitResult, bTeleport);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.K2_SetActorRelativeRotation(relativeRotation, bSweep, ref sweepHitResult, bTeleport);
			}
		}

		// Token: 0x06047C0D RID: 293901 RVA: 0x0125C82D File Offset: 0x0125AA2D
		public static void D_K2_SetActorRelativeTransform([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, in FTransformDouble relativeTransform, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			if (self.IsT1)
			{
				self.AsT1.D_K2_SetActorRelativeTransform(relativeTransform, bSweep, ref sweepHitResult, bTeleport);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.D_K2_SetActorRelativeTransform(relativeTransform, bSweep, ref sweepHitResult, bTeleport);
			}
		}

		// Token: 0x06047C0E RID: 293902 RVA: 0x0125C864 File Offset: 0x0125AA64
		public static void K2_AddActorLocalTransform([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, in FTransform transform, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			if (self.IsT1)
			{
				self.AsT1.K2_AddActorLocalTransform(transform, bSweep, ref sweepHitResult, bTeleport);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.K2_AddActorLocalTransform(transform, bSweep, ref sweepHitResult, bTeleport);
			}
		}
	}
}
