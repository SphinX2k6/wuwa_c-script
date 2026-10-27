using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004302 RID: 17154
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 25)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SClimbInfo.SClimbInfo")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 28)]
	public struct SClimbInfo : IEqualityOperators<SClimbInfo, SClimbInfo, bool>, IEquatable<SClimbInfo>, IUnrealScriptStruct
	{
		// Token: 0x0602C5A0 RID: 181664 RVA: 0x00A1DC58 File Offset: 0x00A1BE58
		public SClimbInfo(FVector 攀爬速度向量, bool 攀爬移动中, FVector2D 攀爬输入向量, bool 攀爬受阻)
		{
			this.攀爬速度向量 = 攀爬速度向量;
			this.攀爬移动中 = 攀爬移动中;
			this.攀爬输入向量 = 攀爬输入向量;
			this.攀爬受阻 = 攀爬受阻;
		}

		// Token: 0x0602C5A1 RID: 181665 RVA: 0x00A1DC78 File Offset: 0x00A1BE78
		public static bool operator ==(SClimbInfo left, SClimbInfo right)
		{
			return left.攀爬速度向量 == right.攀爬速度向量 && left.攀爬移动中 == right.攀爬移动中 && left.攀爬输入向量 == right.攀爬输入向量 && left.攀爬受阻 == right.攀爬受阻;
		}

		// Token: 0x0602C5A2 RID: 181666 RVA: 0x00A1DCC9 File Offset: 0x00A1BEC9
		public static bool operator !=(SClimbInfo left, SClimbInfo right)
		{
			return !(left == right);
		}

		// Token: 0x0602C5A3 RID: 181667 RVA: 0x00A1DCD5 File Offset: 0x00A1BED5
		public bool Equals(SClimbInfo other)
		{
			return this == other;
		}

		// Token: 0x0602C5A4 RID: 181668 RVA: 0x00A1DCE4 File Offset: 0x00A1BEE4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SClimbInfo)
			{
				SClimbInfo other = (SClimbInfo)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602C5A5 RID: 181669 RVA: 0x00A1DD09 File Offset: 0x00A1BF09
		public override int GetHashCode()
		{
			return HashCode.Combine<FVector, bool, FVector2D, bool>(this.攀爬速度向量, this.攀爬移动中, this.攀爬输入向量, this.攀爬受阻);
		}

		// Token: 0x0602C5A6 RID: 181670 RVA: 0x00A1DD28 File Offset: 0x00A1BF28
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SClimbInfo._ScriptStructPtr != 0) ? SClimbInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SClimbInfo.SClimbInfo", ref SClimbInfo._ScriptStructPtr);
		}

		// Token: 0x0401762B RID: 95787
		[FieldOffset(0)]
		public FVector 攀爬速度向量;

		// Token: 0x0401762C RID: 95788
		[FieldOffset(12)]
		public bool 攀爬移动中;

		// Token: 0x0401762D RID: 95789
		[FieldOffset(16)]
		public FVector2D 攀爬输入向量;

		// Token: 0x0401762E RID: 95790
		[FieldOffset(24)]
		public bool 攀爬受阻;

		// Token: 0x0401762F RID: 95791
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SClimbInfo.SClimbInfo";

		// Token: 0x04017630 RID: 95792
		private static IntPtr _ScriptStructPtr;
	}
}
