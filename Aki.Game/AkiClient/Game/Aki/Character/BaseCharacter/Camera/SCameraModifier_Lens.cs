using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043C6 RID: 17350
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 40)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Lens.SCameraModifier_Lens")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 40)]
	public struct SCameraModifier_Lens : IEqualityOperators<SCameraModifier_Lens, SCameraModifier_Lens, bool>, IEquatable<SCameraModifier_Lens>, IUnrealScriptStruct
	{
		// Token: 0x0602CE2B RID: 183851 RVA: 0x00A2B5DC File Offset: 0x00A297DC
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

		// Token: 0x0602CE2C RID: 183852 RVA: 0x00A2B630 File Offset: 0x00A29830
		public static bool operator ==(SCameraModifier_Lens left, SCameraModifier_Lens right)
		{
			return left.StartFStop == right.StartFStop && left.EndFStop == right.EndFStop && left.RadialBlurStartIntensity == right.RadialBlurStartIntensity && left.RadialBlurEndIntensity == right.RadialBlurEndIntensity && left.RadialBlurCenter == right.RadialBlurCenter && left.RadialBlurRadius == right.RadialBlurRadius && left.RadialBlurHardness == right.RadialBlurHardness && left.RadialBlurPassNumber == right.RadialBlurPassNumber && left.RadialBlurSampleNumber == right.RadialBlurSampleNumber;
		}

		// Token: 0x0602CE2D RID: 183853 RVA: 0x00A2B6C2 File Offset: 0x00A298C2
		public static bool operator !=(SCameraModifier_Lens left, SCameraModifier_Lens right)
		{
			return !(left == right);
		}

		// Token: 0x0602CE2E RID: 183854 RVA: 0x00A2B6CE File Offset: 0x00A298CE
		public bool Equals(SCameraModifier_Lens other)
		{
			return this == other;
		}

		// Token: 0x0602CE2F RID: 183855 RVA: 0x00A2B6DC File Offset: 0x00A298DC
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

		// Token: 0x0602CE30 RID: 183856 RVA: 0x00A2B704 File Offset: 0x00A29904
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

		// Token: 0x0602CE31 RID: 183857 RVA: 0x00A2B795 File Offset: 0x00A29995
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraModifier_Lens._ScriptStructPtr != 0) ? SCameraModifier_Lens._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Lens.SCameraModifier_Lens", ref SCameraModifier_Lens._ScriptStructPtr);
		}

		// Token: 0x04017D14 RID: 97556
		[FieldOffset(0)]
		public float StartFStop;

		// Token: 0x04017D15 RID: 97557
		[FieldOffset(4)]
		public float EndFStop;

		// Token: 0x04017D16 RID: 97558
		[FieldOffset(8)]
		public float RadialBlurStartIntensity;

		// Token: 0x04017D17 RID: 97559
		[FieldOffset(12)]
		public float RadialBlurEndIntensity;

		// Token: 0x04017D18 RID: 97560
		[FieldOffset(16)]
		public FVector2D RadialBlurCenter;

		// Token: 0x04017D19 RID: 97561
		[FieldOffset(24)]
		public float RadialBlurRadius;

		// Token: 0x04017D1A RID: 97562
		[FieldOffset(28)]
		public float RadialBlurHardness;

		// Token: 0x04017D1B RID: 97563
		[FieldOffset(32)]
		public float RadialBlurPassNumber;

		// Token: 0x04017D1C RID: 97564
		[FieldOffset(36)]
		public float RadialBlurSampleNumber;

		// Token: 0x04017D1D RID: 97565
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Lens.SCameraModifier_Lens";

		// Token: 0x04017D1E RID: 97566
		private static IntPtr _ScriptStructPtr;
	}
}
