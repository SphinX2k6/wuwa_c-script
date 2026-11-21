using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003340 RID: 13120
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 25)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SClimbInfo.SClimbInfo")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 28)]
	public struct SClimbInfo : IEqualityOperators<SClimbInfo, SClimbInfo, bool>, IEquatable<SClimbInfo>, IUnrealScriptStruct
	{
		// Token: 0x060212CC RID: 135884 RVA: 0x0095AE17 File Offset: 0x00959017
		public SClimbInfo(FVector 攀爬速度向量, bool 攀爬移动中, FVector2D 攀爬输入向量, bool 攀爬受阻)
		{
			this.攀爬速度向量 = 攀爬速度向量;
			this.攀爬移动中 = 攀爬移动中;
			this.攀爬输入向量 = 攀爬输入向量;
			this.攀爬受阻 = 攀爬受阻;
		}

		// Token: 0x060212CD RID: 135885 RVA: 0x0095AE38 File Offset: 0x00959038
		public static bool operator ==(SClimbInfo left, SClimbInfo right)
		{
			return left.攀爬速度向量 == right.攀爬速度向量 && left.攀爬移动中 == right.攀爬移动中 && left.攀爬输入向量 == right.攀爬输入向量 && left.攀爬受阻 == right.攀爬受阻;
		}

		// Token: 0x060212CE RID: 135886 RVA: 0x0095AE89 File Offset: 0x00959089
		public static bool operator !=(SClimbInfo left, SClimbInfo right)
		{
			return !(left == right);
		}

		// Token: 0x060212CF RID: 135887 RVA: 0x0095AE95 File Offset: 0x00959095
		public bool Equals(SClimbInfo other)
		{
			return this == other;
		}

		// Token: 0x060212D0 RID: 135888 RVA: 0x0095AEA4 File Offset: 0x009590A4
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

		// Token: 0x060212D1 RID: 135889 RVA: 0x0095AEC9 File Offset: 0x009590C9
		public override int GetHashCode()
		{
			return HashCode.Combine<FVector, bool, FVector2D, bool>(this.攀爬速度向量, this.攀爬移动中, this.攀爬输入向量, this.攀爬受阻);
		}

		// Token: 0x060212D2 RID: 135890 RVA: 0x0095AEE8 File Offset: 0x009590E8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SClimbInfo._ScriptStructPtr != 0) ? SClimbInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SClimbInfo.SClimbInfo", ref SClimbInfo._ScriptStructPtr);
		}

		// Token: 0x04012234 RID: 74292
		[FieldOffset(0)]
		public FVector 攀爬速度向量;

		// Token: 0x04012235 RID: 74293
		[FieldOffset(12)]
		public bool 攀爬移动中;

		// Token: 0x04012236 RID: 74294
		[FieldOffset(16)]
		public FVector2D 攀爬输入向量;

		// Token: 0x04012237 RID: 74295
		[FieldOffset(24)]
		public bool 攀爬受阻;

		// Token: 0x04012238 RID: 74296
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SClimbInfo.SClimbInfo";

		// Token: 0x04012239 RID: 74297
		private static IntPtr _ScriptStructPtr;
	}
}
