using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043D0 RID: 17360
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 1)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SFreeCameraDragInput.SFreeCameraDragInput")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
	public struct SFreeCameraDragInput : IEqualityOperators<SFreeCameraDragInput, SFreeCameraDragInput, bool>, IEquatable<SFreeCameraDragInput>, IUnrealScriptStruct
	{
		// Token: 0x0602CF7A RID: 184186 RVA: 0x00A2D65C File Offset: 0x00A2B85C
		public SFreeCameraDragInput(bool MemberVar_0)
		{
			this.MemberVar_0 = MemberVar_0;
		}

		// Token: 0x0602CF7B RID: 184187 RVA: 0x00A2D665 File Offset: 0x00A2B865
		public static bool operator ==(SFreeCameraDragInput left, SFreeCameraDragInput right)
		{
			return left.MemberVar_0 == right.MemberVar_0;
		}

		// Token: 0x0602CF7C RID: 184188 RVA: 0x00A2D675 File Offset: 0x00A2B875
		public static bool operator !=(SFreeCameraDragInput left, SFreeCameraDragInput right)
		{
			return !(left == right);
		}

		// Token: 0x0602CF7D RID: 184189 RVA: 0x00A2D681 File Offset: 0x00A2B881
		public bool Equals(SFreeCameraDragInput other)
		{
			return this == other;
		}

		// Token: 0x0602CF7E RID: 184190 RVA: 0x00A2D690 File Offset: 0x00A2B890
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SFreeCameraDragInput)
			{
				SFreeCameraDragInput other = (SFreeCameraDragInput)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602CF7F RID: 184191 RVA: 0x00A2D6B5 File Offset: 0x00A2B8B5
		public override int GetHashCode()
		{
			return HashCode.Combine<bool>(this.MemberVar_0);
		}

		// Token: 0x0602CF80 RID: 184192 RVA: 0x00A2D6C2 File Offset: 0x00A2B8C2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFreeCameraDragInput._ScriptStructPtr != 0) ? SFreeCameraDragInput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SFreeCameraDragInput.SFreeCameraDragInput", ref SFreeCameraDragInput._ScriptStructPtr);
		}

		// Token: 0x04017DC6 RID: 97734
		[FieldOffset(0)]
		public bool MemberVar_0;

		// Token: 0x04017DC7 RID: 97735
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SFreeCameraDragInput.SFreeCameraDragInput";

		// Token: 0x04017DC8 RID: 97736
		private static IntPtr _ScriptStructPtr;
	}
}
