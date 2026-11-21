using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003208 RID: 12808
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 32)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SGravityHookLockInfo.SGravityHookLockInfo")]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 32)]
	public struct SGravityHookLockInfo : IEqualityOperators<SGravityHookLockInfo, SGravityHookLockInfo, bool>, IEquatable<SGravityHookLockInfo>, IUnrealScriptStruct
	{
		// Token: 0x0601FE5F RID: 130655 RVA: 0x0093889E File Offset: 0x00936A9E
		public SGravityHookLockInfo(bool IsValid, FVectorDouble Location)
		{
			this.IsValid = IsValid;
			this.Location = Location;
		}

		// Token: 0x0601FE60 RID: 130656 RVA: 0x009388AE File Offset: 0x00936AAE
		public static bool operator ==(SGravityHookLockInfo left, SGravityHookLockInfo right)
		{
			return left.IsValid == right.IsValid && left.Location == right.Location;
		}

		// Token: 0x0601FE61 RID: 130657 RVA: 0x009388D1 File Offset: 0x00936AD1
		public static bool operator !=(SGravityHookLockInfo left, SGravityHookLockInfo right)
		{
			return !(left == right);
		}

		// Token: 0x0601FE62 RID: 130658 RVA: 0x009388DD File Offset: 0x00936ADD
		public bool Equals(SGravityHookLockInfo other)
		{
			return this == other;
		}

		// Token: 0x0601FE63 RID: 130659 RVA: 0x009388EC File Offset: 0x00936AEC
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

		// Token: 0x0601FE64 RID: 130660 RVA: 0x00938911 File Offset: 0x00936B11
		public override int GetHashCode()
		{
			return HashCode.Combine<bool, FVectorDouble>(this.IsValid, this.Location);
		}

		// Token: 0x0601FE65 RID: 130661 RVA: 0x00938924 File Offset: 0x00936B24
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SGravityHookLockInfo._ScriptStructPtr != 0) ? SGravityHookLockInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SGravityHookLockInfo.SGravityHookLockInfo", ref SGravityHookLockInfo._ScriptStructPtr);
		}

		// Token: 0x04011217 RID: 70167
		[FieldOffset(0)]
		public bool IsValid;

		// Token: 0x04011218 RID: 70168
		[FieldOffset(8)]
		public FVectorDouble Location;

		// Token: 0x04011219 RID: 70169
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SGravityHookLockInfo.SGravityHookLockInfo";

		// Token: 0x0401121A RID: 70170
		private static IntPtr _ScriptStructPtr;
	}
}
