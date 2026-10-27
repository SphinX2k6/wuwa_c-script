using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Entity.Struct
{
	// Token: 0x02003F8D RID: 16269
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Struct/SHardnessStageInfo.SHardnessStageInfo")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct SHardnessStageInfo : IEqualityOperators<SHardnessStageInfo, SHardnessStageInfo, bool>, IEquatable<SHardnessStageInfo>, IUnrealScriptStruct
	{
		// Token: 0x060298F0 RID: 170224 RVA: 0x009C72D8 File Offset: 0x009C54D8
		public SHardnessStageInfo(int HardnessStagePercent, int HardnessStrengh)
		{
			this.HardnessStagePercent = HardnessStagePercent;
			this.HardnessStrengh = HardnessStrengh;
		}

		// Token: 0x060298F1 RID: 170225 RVA: 0x009C72E8 File Offset: 0x009C54E8
		public static bool operator ==(SHardnessStageInfo left, SHardnessStageInfo right)
		{
			return left.HardnessStagePercent == right.HardnessStagePercent && left.HardnessStrengh == right.HardnessStrengh;
		}

		// Token: 0x060298F2 RID: 170226 RVA: 0x009C7308 File Offset: 0x009C5508
		public static bool operator !=(SHardnessStageInfo left, SHardnessStageInfo right)
		{
			return !(left == right);
		}

		// Token: 0x060298F3 RID: 170227 RVA: 0x009C7314 File Offset: 0x009C5514
		public bool Equals(SHardnessStageInfo other)
		{
			return this == other;
		}

		// Token: 0x060298F4 RID: 170228 RVA: 0x009C7324 File Offset: 0x009C5524
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SHardnessStageInfo)
			{
				SHardnessStageInfo other = (SHardnessStageInfo)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060298F5 RID: 170229 RVA: 0x009C7349 File Offset: 0x009C5549
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.HardnessStagePercent, this.HardnessStrengh);
		}

		// Token: 0x060298F6 RID: 170230 RVA: 0x009C735C File Offset: 0x009C555C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SHardnessStageInfo._ScriptStructPtr != 0) ? SHardnessStageInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Entity/Struct/SHardnessStageInfo.SHardnessStageInfo", ref SHardnessStageInfo._ScriptStructPtr);
		}

		// Token: 0x040154E3 RID: 87267
		[FieldOffset(0)]
		public int HardnessStagePercent;

		// Token: 0x040154E4 RID: 87268
		[FieldOffset(4)]
		public int HardnessStrengh;

		// Token: 0x040154E5 RID: 87269
		public const string __ObjectPath = "/Game/Aki/Data/Entity/Struct/SHardnessStageInfo.SHardnessStageInfo";

		// Token: 0x040154E6 RID: 87270
		private static IntPtr _ScriptStructPtr;
	}
}
