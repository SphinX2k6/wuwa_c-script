using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.GaCha.Struct
{
	// Token: 0x020031F3 RID: 12787
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(72, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 72)]
	[UnrealObjectPath("/Game/Aki/Data/GaCha/Struct/SGachaWeaponTransform.SGachaWeaponTransform")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 72)]
	public struct SGachaWeaponTransform : IEqualityOperators<SGachaWeaponTransform, SGachaWeaponTransform, bool>, IEquatable<SGachaWeaponTransform>, IUnrealScriptStruct
	{
		// Token: 0x0601FCF2 RID: 130290 RVA: 0x009363A8 File Offset: 0x009345A8
		public SGachaWeaponTransform(FVector Location, FVector Rotation, float Size, float RotateTime, FVector ScabbardOffset, bool ShowScabbard, FVector AxisRotate, FVector ScabbardRotationOffset)
		{
			this.Location = Location;
			this.Rotation = Rotation;
			this.Size = Size;
			this.RotateTime = RotateTime;
			this.ScabbardOffset = ScabbardOffset;
			this.ShowScabbard = ShowScabbard;
			this.AxisRotate = AxisRotate;
			this.ScabbardRotationOffset = ScabbardRotationOffset;
		}

		// Token: 0x0601FCF3 RID: 130291 RVA: 0x009363E8 File Offset: 0x009345E8
		public static bool operator ==(SGachaWeaponTransform left, SGachaWeaponTransform right)
		{
			return left.Location == right.Location && left.Rotation == right.Rotation && left.Size == right.Size && left.RotateTime == right.RotateTime && left.ScabbardOffset == right.ScabbardOffset && left.ShowScabbard == right.ShowScabbard && left.AxisRotate == right.AxisRotate && left.ScabbardRotationOffset == right.ScabbardRotationOffset;
		}

		// Token: 0x0601FCF4 RID: 130292 RVA: 0x0093647E File Offset: 0x0093467E
		public static bool operator !=(SGachaWeaponTransform left, SGachaWeaponTransform right)
		{
			return !(left == right);
		}

		// Token: 0x0601FCF5 RID: 130293 RVA: 0x0093648A File Offset: 0x0093468A
		public bool Equals(SGachaWeaponTransform other)
		{
			return this == other;
		}

		// Token: 0x0601FCF6 RID: 130294 RVA: 0x00936498 File Offset: 0x00934698
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SGachaWeaponTransform)
			{
				SGachaWeaponTransform other = (SGachaWeaponTransform)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601FCF7 RID: 130295 RVA: 0x009364BD File Offset: 0x009346BD
		public override int GetHashCode()
		{
			return HashCode.Combine<FVector, FVector, float, float, FVector, bool, FVector, FVector>(this.Location, this.Rotation, this.Size, this.RotateTime, this.ScabbardOffset, this.ShowScabbard, this.AxisRotate, this.ScabbardRotationOffset);
		}

		// Token: 0x0601FCF8 RID: 130296 RVA: 0x009364F4 File Offset: 0x009346F4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SGachaWeaponTransform._ScriptStructPtr != 0) ? SGachaWeaponTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/GaCha/Struct/SGachaWeaponTransform.SGachaWeaponTransform", ref SGachaWeaponTransform._ScriptStructPtr);
		}

		// Token: 0x04011125 RID: 69925
		[FieldOffset(0)]
		public FVector Location;

		// Token: 0x04011126 RID: 69926
		[FieldOffset(12)]
		public FVector Rotation;

		// Token: 0x04011127 RID: 69927
		[FieldOffset(24)]
		public float Size;

		// Token: 0x04011128 RID: 69928
		[FieldOffset(28)]
		public float RotateTime;

		// Token: 0x04011129 RID: 69929
		[FieldOffset(32)]
		public FVector ScabbardOffset;

		// Token: 0x0401112A RID: 69930
		[FieldOffset(44)]
		public bool ShowScabbard;

		// Token: 0x0401112B RID: 69931
		[FieldOffset(48)]
		public FVector AxisRotate;

		// Token: 0x0401112C RID: 69932
		[FieldOffset(60)]
		public FVector ScabbardRotationOffset;

		// Token: 0x0401112D RID: 69933
		public const string __ObjectPath = "/Game/Aki/Data/GaCha/Struct/SGachaWeaponTransform.SGachaWeaponTransform";

		// Token: 0x0401112E RID: 69934
		private static IntPtr _ScriptStructPtr;
	}
}
