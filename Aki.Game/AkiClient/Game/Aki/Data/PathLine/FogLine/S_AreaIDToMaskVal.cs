using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.PathLine.FogLine
{
	// Token: 0x020031AB RID: 12715
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 4)]
	[UnrealObjectPath("/Game/Aki/Data/PathLine/FogLine/S_AreaIDToMaskVal.S_AreaIDToMaskVal")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 4)]
	public struct S_AreaIDToMaskVal : IEqualityOperators<S_AreaIDToMaskVal, S_AreaIDToMaskVal, bool>, IEquatable<S_AreaIDToMaskVal>, IUnrealScriptStruct
	{
		// Token: 0x0601F659 RID: 128601 RVA: 0x0092CE59 File Offset: 0x0092B059
		public S_AreaIDToMaskVal(int Mask)
		{
			this.Mask = Mask;
		}

		// Token: 0x0601F65A RID: 128602 RVA: 0x0092CE62 File Offset: 0x0092B062
		public static bool operator ==(S_AreaIDToMaskVal left, S_AreaIDToMaskVal right)
		{
			return left.Mask == right.Mask;
		}

		// Token: 0x0601F65B RID: 128603 RVA: 0x0092CE72 File Offset: 0x0092B072
		public static bool operator !=(S_AreaIDToMaskVal left, S_AreaIDToMaskVal right)
		{
			return !(left == right);
		}

		// Token: 0x0601F65C RID: 128604 RVA: 0x0092CE7E File Offset: 0x0092B07E
		public bool Equals(S_AreaIDToMaskVal other)
		{
			return this == other;
		}

		// Token: 0x0601F65D RID: 128605 RVA: 0x0092CE8C File Offset: 0x0092B08C
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

		// Token: 0x0601F65E RID: 128606 RVA: 0x0092CEB1 File Offset: 0x0092B0B1
		public override int GetHashCode()
		{
			return HashCode.Combine<int>(this.Mask);
		}

		// Token: 0x0601F65F RID: 128607 RVA: 0x0092CEBE File Offset: 0x0092B0BE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_AreaIDToMaskVal._ScriptStructPtr != 0) ? S_AreaIDToMaskVal._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/PathLine/FogLine/S_AreaIDToMaskVal.S_AreaIDToMaskVal", ref S_AreaIDToMaskVal._ScriptStructPtr);
		}

		// Token: 0x04010D49 RID: 68937
		[FieldOffset(0)]
		public int Mask;

		// Token: 0x04010D4A RID: 68938
		public const string __ObjectPath = "/Game/Aki/Data/PathLine/FogLine/S_AreaIDToMaskVal.S_AreaIDToMaskVal";

		// Token: 0x04010D4B RID: 68939
		private static IntPtr _ScriptStructPtr;
	}
}
