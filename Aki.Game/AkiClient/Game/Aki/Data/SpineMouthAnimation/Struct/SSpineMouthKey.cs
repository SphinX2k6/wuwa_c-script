using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Data.SpineMouthAnimation.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.SpineMouthAnimation.Struct
{
	// Token: 0x0200316E RID: 12654
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 5)]
	[UnrealObjectPath("/Game/Aki/Data/SpineMouthAnimation/Struct/SSpineMouthKey.SSpineMouthKey")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct SSpineMouthKey : IEqualityOperators<SSpineMouthKey, SSpineMouthKey, bool>, IEquatable<SSpineMouthKey>, IUnrealScriptStruct
	{
		// Token: 0x0601F37B RID: 127867 RVA: 0x00928DB4 File Offset: 0x00926FB4
		public SSpineMouthKey(int TimeMs, TEnumAsByte<ESpineMouthShape> Shape)
		{
			this.TimeMs = TimeMs;
			this.Shape = Shape;
		}

		// Token: 0x0601F37C RID: 127868 RVA: 0x00928DC4 File Offset: 0x00926FC4
		public static bool operator ==(SSpineMouthKey left, SSpineMouthKey right)
		{
			return left.TimeMs == right.TimeMs && left.Shape == right.Shape;
		}

		// Token: 0x0601F37D RID: 127869 RVA: 0x00928DE7 File Offset: 0x00926FE7
		public static bool operator !=(SSpineMouthKey left, SSpineMouthKey right)
		{
			return !(left == right);
		}

		// Token: 0x0601F37E RID: 127870 RVA: 0x00928DF3 File Offset: 0x00926FF3
		public bool Equals(SSpineMouthKey other)
		{
			return this == other;
		}

		// Token: 0x0601F37F RID: 127871 RVA: 0x00928E04 File Offset: 0x00927004
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SSpineMouthKey)
			{
				SSpineMouthKey other = (SSpineMouthKey)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601F380 RID: 127872 RVA: 0x00928E29 File Offset: 0x00927029
		public override int GetHashCode()
		{
			return HashCode.Combine<int, TEnumAsByte<ESpineMouthShape>>(this.TimeMs, this.Shape);
		}

		// Token: 0x0601F381 RID: 127873 RVA: 0x00928E3C File Offset: 0x0092703C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSpineMouthKey._ScriptStructPtr != 0) ? SSpineMouthKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/SpineMouthAnimation/Struct/SSpineMouthKey.SSpineMouthKey", ref SSpineMouthKey._ScriptStructPtr);
		}

		// Token: 0x04010B1B RID: 68379
		[FieldOffset(0)]
		public int TimeMs;

		// Token: 0x04010B1C RID: 68380
		[FieldOffset(4)]
		public TEnumAsByte<ESpineMouthShape> Shape;

		// Token: 0x04010B1D RID: 68381
		public const string __ObjectPath = "/Game/Aki/Data/SpineMouthAnimation/Struct/SSpineMouthKey.SSpineMouthKey";

		// Token: 0x04010B1E RID: 68382
		private static IntPtr _ScriptStructPtr;
	}
}
