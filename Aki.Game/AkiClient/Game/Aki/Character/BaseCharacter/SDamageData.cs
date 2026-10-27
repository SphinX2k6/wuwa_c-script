using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200430B RID: 17163
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SDamageData.SDamageData")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct SDamageData : IEqualityOperators<SDamageData, SDamageData, bool>, IEquatable<SDamageData>, IUnrealScriptStruct
	{
		// Token: 0x0602C641 RID: 181825 RVA: 0x00A1EC84 File Offset: 0x00A1CE84
		public SDamageData(float 伤害数值, int 属性Id)
		{
			this.伤害数值 = 伤害数值;
			this.属性Id = 属性Id;
		}

		// Token: 0x0602C642 RID: 181826 RVA: 0x00A1EC94 File Offset: 0x00A1CE94
		public static bool operator ==(SDamageData left, SDamageData right)
		{
			return left.伤害数值 == right.伤害数值 && left.属性Id == right.属性Id;
		}

		// Token: 0x0602C643 RID: 181827 RVA: 0x00A1ECB4 File Offset: 0x00A1CEB4
		public static bool operator !=(SDamageData left, SDamageData right)
		{
			return !(left == right);
		}

		// Token: 0x0602C644 RID: 181828 RVA: 0x00A1ECC0 File Offset: 0x00A1CEC0
		public bool Equals(SDamageData other)
		{
			return this == other;
		}

		// Token: 0x0602C645 RID: 181829 RVA: 0x00A1ECD0 File Offset: 0x00A1CED0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SDamageData)
			{
				SDamageData other = (SDamageData)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602C646 RID: 181830 RVA: 0x00A1ECF5 File Offset: 0x00A1CEF5
		public override int GetHashCode()
		{
			return HashCode.Combine<float, int>(this.伤害数值, this.属性Id);
		}

		// Token: 0x0602C647 RID: 181831 RVA: 0x00A1ED08 File Offset: 0x00A1CF08
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SDamageData._ScriptStructPtr != 0) ? SDamageData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SDamageData.SDamageData", ref SDamageData._ScriptStructPtr);
		}

		// Token: 0x04017682 RID: 95874
		[FieldOffset(0)]
		public float 伤害数值;

		// Token: 0x04017683 RID: 95875
		[FieldOffset(4)]
		public int 属性Id;

		// Token: 0x04017684 RID: 95876
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SDamageData.SDamageData";

		// Token: 0x04017685 RID: 95877
		private static IntPtr _ScriptStructPtr;
	}
}
