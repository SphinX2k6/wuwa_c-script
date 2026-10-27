using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.PathLine.FogLine
{
	// Token: 0x02003EE9 RID: 16105
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 4)]
	[UnrealObjectPath("/Game/Aki/Data/PathLine/FogLine/S_AreaIDToMaskVal.S_AreaIDToMaskVal")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 4)]
	public struct S_AreaIDToMaskVal : IEqualityOperators<S_AreaIDToMaskVal, S_AreaIDToMaskVal, bool>, IEquatable<S_AreaIDToMaskVal>, IUnrealScriptStruct
	{
		// Token: 0x06028C7C RID: 167036 RVA: 0x009B475D File Offset: 0x009B295D
		public S_AreaIDToMaskVal(int Mask)
		{
			this.Mask = Mask;
		}

		// Token: 0x06028C7D RID: 167037 RVA: 0x009B4766 File Offset: 0x009B2966
		public static bool operator ==(S_AreaIDToMaskVal left, S_AreaIDToMaskVal right)
		{
			return left.Mask == right.Mask;
		}

		// Token: 0x06028C7E RID: 167038 RVA: 0x009B4776 File Offset: 0x009B2976
		public static bool operator !=(S_AreaIDToMaskVal left, S_AreaIDToMaskVal right)
		{
			return !(left == right);
		}

		// Token: 0x06028C7F RID: 167039 RVA: 0x009B4782 File Offset: 0x009B2982
		public bool Equals(S_AreaIDToMaskVal other)
		{
			return this == other;
		}

		// Token: 0x06028C80 RID: 167040 RVA: 0x009B4790 File Offset: 0x009B2990
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is S_AreaIDToMaskVal)
			{
				S_AreaIDToMaskVal other = (S_AreaIDToMaskVal)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06028C81 RID: 167041 RVA: 0x009B47B5 File Offset: 0x009B29B5
		public override int GetHashCode()
		{
			return HashCode.Combine<int>(this.Mask);
		}

		// Token: 0x06028C82 RID: 167042 RVA: 0x009B47C2 File Offset: 0x009B29C2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_AreaIDToMaskVal._ScriptStructPtr != 0) ? S_AreaIDToMaskVal._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/PathLine/FogLine/S_AreaIDToMaskVal.S_AreaIDToMaskVal", ref S_AreaIDToMaskVal._ScriptStructPtr);
		}

		// Token: 0x04014D88 RID: 85384
		[FieldOffset(0)]
		public int Mask;

		// Token: 0x04014D89 RID: 85385
		public const string __ObjectPath = "/Game/Aki/Data/PathLine/FogLine/S_AreaIDToMaskVal.S_AreaIDToMaskVal";

		// Token: 0x04014D8A RID: 85386
		private static IntPtr _ScriptStructPtr;
	}
}
