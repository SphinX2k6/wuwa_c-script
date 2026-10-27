using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F67 RID: 16231
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 32)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SGravityHookLockInfo.SGravityHookLockInfo")]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 32)]
	public struct SGravityHookLockInfo : IEqualityOperators<SGravityHookLockInfo, SGravityHookLockInfo, bool>, IEquatable<SGravityHookLockInfo>, IUnrealScriptStruct
	{
		// Token: 0x060295D7 RID: 169431 RVA: 0x009C2783 File Offset: 0x009C0983
		public SGravityHookLockInfo(bool IsValid, FVectorDouble Location)
		{
			this.IsValid = IsValid;
			this.Location = Location;
		}

		// Token: 0x060295D8 RID: 169432 RVA: 0x009C2793 File Offset: 0x009C0993
		public static bool operator ==(SGravityHookLockInfo left, SGravityHookLockInfo right)
		{
			return left.IsValid == right.IsValid && left.Location == right.Location;
		}

		// Token: 0x060295D9 RID: 169433 RVA: 0x009C27B6 File Offset: 0x009C09B6
		public static bool operator !=(SGravityHookLockInfo left, SGravityHookLockInfo right)
		{
			return !(left == right);
		}

		// Token: 0x060295DA RID: 169434 RVA: 0x009C27C2 File Offset: 0x009C09C2
		public bool Equals(SGravityHookLockInfo other)
		{
			return this == other;
		}

		// Token: 0x060295DB RID: 169435 RVA: 0x009C27D0 File Offset: 0x009C09D0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SGravityHookLockInfo)
			{
				SGravityHookLockInfo other = (SGravityHookLockInfo)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060295DC RID: 169436 RVA: 0x009C27F5 File Offset: 0x009C09F5
		public override int GetHashCode()
		{
			return HashCode.Combine<bool, FVectorDouble>(this.IsValid, this.Location);
		}

		// Token: 0x060295DD RID: 169437 RVA: 0x009C2808 File Offset: 0x009C0A08
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SGravityHookLockInfo._ScriptStructPtr != 0) ? SGravityHookLockInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SGravityHookLockInfo.SGravityHookLockInfo", ref SGravityHookLockInfo._ScriptStructPtr);
		}

		// Token: 0x04015323 RID: 86819
		[FieldOffset(0)]
		public bool IsValid;

		// Token: 0x04015324 RID: 86820
		[FieldOffset(8)]
		public FVectorDouble Location;

		// Token: 0x04015325 RID: 86821
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SGravityHookLockInfo.SGravityHookLockInfo";

		// Token: 0x04015326 RID: 86822
		private static IntPtr _ScriptStructPtr;
	}
}
