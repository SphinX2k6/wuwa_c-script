using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033E1 RID: 13281
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 40)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Lens.SCameraModifier_Lens")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 40)]
	public struct SCameraModifier_Lens : IEqualityOperators<SCameraModifier_Lens, SCameraModifier_Lens, bool>, IEquatable<SCameraModifier_Lens>, IUnrealScriptStruct
	{
		// Token: 0x06021A30 RID: 137776 RVA: 0x00965F04 File Offset: 0x00964104
		public SCameraModifier_Lens(float StartFStop, float EndFStop, float RadialBlurStartIntensity, float RadialBlurEndIntensity, FVector2D RadialBlurCenter, float RadialBlurRadius, float RadialBlurHardness, float RadialBlurPassNumber, float RadialBlurSampleNumber)
		{
			this.StartFStop = StartFStop;
			this.EndFStop = EndFStop;
			this.RadialBlurStartIntensity = RadialBlurStartIntensity;
			this.RadialBlurEndIntensity = RadialBlurEndIntensity;
			this.RadialBlurCenter = RadialBlurCenter;
			this.RadialBlurRadius = RadialBlurRadius;
			this.RadialBlurHardness = RadialBlurHardness;
			this.RadialBlurPassNumber = RadialBlurPassNumber;
			this.RadialBlurSampleNumber = RadialBlurSampleNumber;
		}

		// Token: 0x06021A31 RID: 137777 RVA: 0x00965F58 File Offset: 0x00964158
		public static bool operator ==(SCameraModifier_Lens left, SCameraModifier_Lens right)
		{
			return left.StartFStop == right.StartFStop && left.EndFStop == right.EndFStop && left.RadialBlurStartIntensity == right.RadialBlurStartIntensity && left.RadialBlurEndIntensity == right.RadialBlurEndIntensity && left.RadialBlurCenter == right.RadialBlurCenter && left.RadialBlurRadius == right.RadialBlurRadius && left.RadialBlurHardness == right.RadialBlurHardness && left.RadialBlurPassNumber == right.RadialBlurPassNumber && left.RadialBlurSampleNumber == right.RadialBlurSampleNumber;
		}

		// Token: 0x06021A32 RID: 137778 RVA: 0x00965FEA File Offset: 0x009641EA
		public static bool operator !=(SCameraModifier_Lens left, SCameraModifier_Lens right)
		{
			return !(left == right);
		}

		// Token: 0x06021A33 RID: 137779 RVA: 0x00965FF6 File Offset: 0x009641F6
		public bool Equals(SCameraModifier_Lens other)
		{
			return this == other;
		}

		// Token: 0x06021A34 RID: 137780 RVA: 0x00966004 File Offset: 0x00964204
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SCameraModifier_Lens)
			{
				SCameraModifier_Lens other = (SCameraModifier_Lens)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06021A35 RID: 137781 RVA: 0x0096602C File Offset: 0x0096422C
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<float>(this.StartFStop);
			hashCode.Add<float>(this.EndFStop);
			hashCode.Add<float>(this.RadialBlurStartIntensity);
			hashCode.Add<float>(this.RadialBlurEndIntensity);
			hashCode.Add<FVector2D>(this.RadialBlurCenter);
			hashCode.Add<float>(this.RadialBlurRadius);
			hashCode.Add<float>(this.RadialBlurHardness);
			hashCode.Add<float>(this.RadialBlurPassNumber);
			hashCode.Add<float>(this.RadialBlurSampleNumber);
			return hashCode.ToHashCode();
		}

		// Token: 0x06021A36 RID: 137782 RVA: 0x009660BD File Offset: 0x009642BD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraModifier_Lens._ScriptStructPtr != 0) ? SCameraModifier_Lens._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Lens.SCameraModifier_Lens", ref SCameraModifier_Lens._ScriptStructPtr);
		}

		// Token: 0x0401287C RID: 75900
		[FieldOffset(0)]
		public float StartFStop;

		// Token: 0x0401287D RID: 75901
		[FieldOffset(4)]
		public float EndFStop;

		// Token: 0x0401287E RID: 75902
		[FieldOffset(8)]
		public float RadialBlurStartIntensity;

		// Token: 0x0401287F RID: 75903
		[FieldOffset(12)]
		public float RadialBlurEndIntensity;

		// Token: 0x04012880 RID: 75904
		[FieldOffset(16)]
		public FVector2D RadialBlurCenter;

		// Token: 0x04012881 RID: 75905
		[FieldOffset(24)]
		public float RadialBlurRadius;

		// Token: 0x04012882 RID: 75906
		[FieldOffset(28)]
		public float RadialBlurHardness;

		// Token: 0x04012883 RID: 75907
		[FieldOffset(32)]
		public float RadialBlurPassNumber;

		// Token: 0x04012884 RID: 75908
		[FieldOffset(36)]
		public float RadialBlurSampleNumber;

		// Token: 0x04012885 RID: 75909
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Lens.SCameraModifier_Lens";

		// Token: 0x04012886 RID: 75910
		private static IntPtr _ScriptStructPtr;
	}
}
