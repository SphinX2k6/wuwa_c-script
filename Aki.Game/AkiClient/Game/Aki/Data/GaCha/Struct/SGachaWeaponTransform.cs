using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.GaCha.Struct
{
	// Token: 0x02003F4C RID: 16204
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(72, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 72)]
	[UnrealObjectPath("/Game/Aki/Data/GaCha/Struct/SGachaWeaponTransform.SGachaWeaponTransform")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 72)]
	public struct SGachaWeaponTransform : IEqualityOperators<SGachaWeaponTransform, SGachaWeaponTransform, bool>, IEquatable<SGachaWeaponTransform>, IUnrealScriptStruct
	{
		// Token: 0x0602940F RID: 168975 RVA: 0x009BF7B4 File Offset: 0x009BD9B4
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

		// Token: 0x06029410 RID: 168976 RVA: 0x009BF7F4 File Offset: 0x009BD9F4
		public static bool operator ==(SGachaWeaponTransform left, SGachaWeaponTransform right)
		{
			return left.Location == right.Location && left.Rotation == right.Rotation && left.Size == right.Size && left.RotateTime == right.RotateTime && left.ScabbardOffset == right.ScabbardOffset && left.ShowScabbard == right.ShowScabbard && left.AxisRotate == right.AxisRotate && left.ScabbardRotationOffset == right.ScabbardRotationOffset;
		}

		// Token: 0x06029411 RID: 168977 RVA: 0x009BF88A File Offset: 0x009BDA8A
		public static bool operator !=(SGachaWeaponTransform left, SGachaWeaponTransform right)
		{
			return !(left == right);
		}

		// Token: 0x06029412 RID: 168978 RVA: 0x009BF896 File Offset: 0x009BDA96
		public bool Equals(SGachaWeaponTransform other)
		{
			return this == other;
		}

		// Token: 0x06029413 RID: 168979 RVA: 0x009BF8A4 File Offset: 0x009BDAA4
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

		// Token: 0x06029414 RID: 168980 RVA: 0x009BF8C9 File Offset: 0x009BDAC9
		public override int GetHashCode()
		{
			return HashCode.Combine<FVector, FVector, float, float, FVector, bool, FVector, FVector>(this.Location, this.Rotation, this.Size, this.RotateTime, this.ScabbardOffset, this.ShowScabbard, this.AxisRotate, this.ScabbardRotationOffset);
		}

		// Token: 0x06029415 RID: 168981 RVA: 0x009BF900 File Offset: 0x009BDB00
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SGachaWeaponTransform._ScriptStructPtr != 0) ? SGachaWeaponTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/GaCha/Struct/SGachaWeaponTransform.SGachaWeaponTransform", ref SGachaWeaponTransform._ScriptStructPtr);
		}

		// Token: 0x04015209 RID: 86537
		[FieldOffset(0)]
		public FVector Location;

		// Token: 0x0401520A RID: 86538
		[FieldOffset(12)]
		public FVector Rotation;

		// Token: 0x0401520B RID: 86539
		[FieldOffset(24)]
		public float Size;

		// Token: 0x0401520C RID: 86540
		[FieldOffset(28)]
		public float RotateTime;

		// Token: 0x0401520D RID: 86541
		[FieldOffset(32)]
		public FVector ScabbardOffset;

		// Token: 0x0401520E RID: 86542
		[FieldOffset(44)]
		public bool ShowScabbard;

		// Token: 0x0401520F RID: 86543
		[FieldOffset(48)]
		public FVector AxisRotate;

		// Token: 0x04015210 RID: 86544
		[FieldOffset(60)]
		public FVector ScabbardRotationOffset;

		// Token: 0x04015211 RID: 86545
		public const string __ObjectPath = "/Game/Aki/Data/GaCha/Struct/SGachaWeaponTransform.SGachaWeaponTransform";

		// Token: 0x04015212 RID: 86546
		private static IntPtr _ScriptStructPtr;
	}
}
