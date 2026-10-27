using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.RhythmGame
{
	// Token: 0x02003F35 RID: 16181
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 44)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/RhythmGame/RhythmGamePerformanceCameraConfig.RhythmGamePerformanceCameraConfig")]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 48)]
	public struct RhythmGamePerformanceCameraConfig : IEqualityOperators<RhythmGamePerformanceCameraConfig, RhythmGamePerformanceCameraConfig, bool>, IEquatable<RhythmGamePerformanceCameraConfig>, IUnrealScriptStruct
	{
		// Token: 0x06029285 RID: 168581 RVA: 0x009BD2C6 File Offset: 0x009BB4C6
		public RhythmGamePerformanceCameraConfig(FVectorDouble TargetLoc, FRotator TargetRot, float Time, float Fov)
		{
			this.TargetLoc = TargetLoc;
			this.TargetRot = TargetRot;
			this.Time = Time;
			this.Fov = Fov;
		}

		// Token: 0x06029286 RID: 168582 RVA: 0x009BD2E8 File Offset: 0x009BB4E8
		public static bool operator ==(RhythmGamePerformanceCameraConfig left, RhythmGamePerformanceCameraConfig right)
		{
			return left.TargetLoc == right.TargetLoc && left.TargetRot == right.TargetRot && left.Time == right.Time && left.Fov == right.Fov;
		}

		// Token: 0x06029287 RID: 168583 RVA: 0x009BD339 File Offset: 0x009BB539
		public static bool operator !=(RhythmGamePerformanceCameraConfig left, RhythmGamePerformanceCameraConfig right)
		{
			return !(left == right);
		}

		// Token: 0x06029288 RID: 168584 RVA: 0x009BD345 File Offset: 0x009BB545
		public bool Equals(RhythmGamePerformanceCameraConfig other)
		{
			return this == other;
		}

		// Token: 0x06029289 RID: 168585 RVA: 0x009BD354 File Offset: 0x009BB554
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

		// Token: 0x0602928A RID: 168586 RVA: 0x009BD379 File Offset: 0x009BB579
		public override int GetHashCode()
		{
			return HashCode.Combine<FVectorDouble, FRotator, float, float>(this.TargetLoc, this.TargetRot, this.Time, this.Fov);
		}

		// Token: 0x0602928B RID: 168587 RVA: 0x009BD398 File Offset: 0x009BB598
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (RhythmGamePerformanceCameraConfig._ScriptStructPtr != 0) ? RhythmGamePerformanceCameraConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/RhythmGame/RhythmGamePerformanceCameraConfig.RhythmGamePerformanceCameraConfig", ref RhythmGamePerformanceCameraConfig._ScriptStructPtr);
		}

		// Token: 0x0401512F RID: 86319
		[FieldOffset(0)]
		public FVectorDouble TargetLoc;

		// Token: 0x04015130 RID: 86320
		[FieldOffset(24)]
		public FRotator TargetRot;

		// Token: 0x04015131 RID: 86321
		[FieldOffset(36)]
		public float Time;

		// Token: 0x04015132 RID: 86322
		[FieldOffset(40)]
		public float Fov;

		// Token: 0x04015133 RID: 86323
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/RhythmGame/RhythmGamePerformanceCameraConfig.RhythmGamePerformanceCameraConfig";

		// Token: 0x04015134 RID: 86324
		private static IntPtr _ScriptStructPtr;
	}
}
