using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.RhythmGame
{
	// Token: 0x020031E0 RID: 12768
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 44)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/RhythmGame/RhythmGamePerformanceCameraConfig.RhythmGamePerformanceCameraConfig")]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 48)]
	public struct RhythmGamePerformanceCameraConfig : IEqualityOperators<RhythmGamePerformanceCameraConfig, RhythmGamePerformanceCameraConfig, bool>, IEquatable<RhythmGamePerformanceCameraConfig>, IUnrealScriptStruct
	{
		// Token: 0x0601FB8F RID: 129935 RVA: 0x009342E2 File Offset: 0x009324E2
		public RhythmGamePerformanceCameraConfig(FVectorDouble TargetLoc, FRotator TargetRot, float Time, float Fov)
		{
			this.TargetLoc = TargetLoc;
			this.TargetRot = TargetRot;
			this.Time = Time;
			this.Fov = Fov;
		}

		// Token: 0x0601FB90 RID: 129936 RVA: 0x00934304 File Offset: 0x00932504
		public static bool operator ==(RhythmGamePerformanceCameraConfig left, RhythmGamePerformanceCameraConfig right)
		{
			return left.TargetLoc == right.TargetLoc && left.TargetRot == right.TargetRot && left.Time == right.Time && left.Fov == right.Fov;
		}

		// Token: 0x0601FB91 RID: 129937 RVA: 0x00934355 File Offset: 0x00932555
		public static bool operator !=(RhythmGamePerformanceCameraConfig left, RhythmGamePerformanceCameraConfig right)
		{
			return !(left == right);
		}

		// Token: 0x0601FB92 RID: 129938 RVA: 0x00934361 File Offset: 0x00932561
		public bool Equals(RhythmGamePerformanceCameraConfig other)
		{
			return this == other;
		}

		// Token: 0x0601FB93 RID: 129939 RVA: 0x00934370 File Offset: 0x00932570
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is RhythmGamePerformanceCameraConfig)
			{
				RhythmGamePerformanceCameraConfig other = (RhythmGamePerformanceCameraConfig)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601FB94 RID: 129940 RVA: 0x00934395 File Offset: 0x00932595
		public override int GetHashCode()
		{
			return HashCode.Combine<FVectorDouble, FRotator, float, float>(this.TargetLoc, this.TargetRot, this.Time, this.Fov);
		}

		// Token: 0x0601FB95 RID: 129941 RVA: 0x009343B4 File Offset: 0x009325B4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (RhythmGamePerformanceCameraConfig._ScriptStructPtr != 0) ? RhythmGamePerformanceCameraConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/RhythmGame/RhythmGamePerformanceCameraConfig.RhythmGamePerformanceCameraConfig", ref RhythmGamePerformanceCameraConfig._ScriptStructPtr);
		}

		// Token: 0x04011058 RID: 69720
		[FieldOffset(0)]
		public FVectorDouble TargetLoc;

		// Token: 0x04011059 RID: 69721
		[FieldOffset(24)]
		public FRotator TargetRot;

		// Token: 0x0401105A RID: 69722
		[FieldOffset(36)]
		public float Time;

		// Token: 0x0401105B RID: 69723
		[FieldOffset(40)]
		public float Fov;

		// Token: 0x0401105C RID: 69724
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/RhythmGame/RhythmGamePerformanceCameraConfig.RhythmGamePerformanceCameraConfig";

		// Token: 0x0401105D RID: 69725
		private static IntPtr _ScriptStructPtr;
	}
}
