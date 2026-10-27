using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042EA RID: 17130
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 4)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SAbilityLimitCountInfo.SAbilityLimitCountInfo")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 4)]
	public struct SAbilityLimitCountInfo : IEqualityOperators<SAbilityLimitCountInfo, SAbilityLimitCountInfo, bool>, IEquatable<SAbilityLimitCountInfo>, IUnrealScriptStruct
	{
		// Token: 0x0602C3A2 RID: 181154 RVA: 0x00A1A97D File Offset: 0x00A18B7D
		public SAbilityLimitCountInfo(int MaxCount)
		{
			this.MaxCount = MaxCount;
		}

		// Token: 0x0602C3A3 RID: 181155 RVA: 0x00A1A986 File Offset: 0x00A18B86
		public static bool operator ==(SAbilityLimitCountInfo left, SAbilityLimitCountInfo right)
		{
			return left.MaxCount == right.MaxCount;
		}

		// Token: 0x0602C3A4 RID: 181156 RVA: 0x00A1A996 File Offset: 0x00A18B96
		public static bool operator !=(SAbilityLimitCountInfo left, SAbilityLimitCountInfo right)
		{
			return !(left == right);
		}

		// Token: 0x0602C3A5 RID: 181157 RVA: 0x00A1A9A2 File Offset: 0x00A18BA2
		public bool Equals(SAbilityLimitCountInfo other)
		{
			return this == other;
		}

		// Token: 0x0602C3A6 RID: 181158 RVA: 0x00A1A9B0 File Offset: 0x00A18BB0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SAbilityLimitCountInfo)
			{
				SAbilityLimitCountInfo other = (SAbilityLimitCountInfo)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602C3A7 RID: 181159 RVA: 0x00A1A9D5 File Offset: 0x00A18BD5
		public override int GetHashCode()
		{
			return HashCode.Combine<int>(this.MaxCount);
		}

		// Token: 0x0602C3A8 RID: 181160 RVA: 0x00A1A9E2 File Offset: 0x00A18BE2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAbilityLimitCountInfo._ScriptStructPtr != 0) ? SAbilityLimitCountInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SAbilityLimitCountInfo.SAbilityLimitCountInfo", ref SAbilityLimitCountInfo._ScriptStructPtr);
		}

		// Token: 0x0401751B RID: 95515
		[FieldOffset(0)]
		public int MaxCount;

		// Token: 0x0401751C RID: 95516
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SAbilityLimitCountInfo.SAbilityLimitCountInfo";

		// Token: 0x0401751D RID: 95517
		private static IntPtr _ScriptStructPtr;
	}
}
