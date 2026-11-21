using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Entity.Struct
{
	// Token: 0x02003221 RID: 12833
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Struct/SEntityTimeDilation.SEntityTimeDilation")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct SEntityTimeDilation : IEqualityOperators<SEntityTimeDilation, SEntityTimeDilation, bool>, IEquatable<SEntityTimeDilation>, IUnrealScriptStruct
	{
		// Token: 0x06020073 RID: 131187 RVA: 0x0093B742 File Offset: 0x00939942
		public SEntityTimeDilation(int SourceType, float TimeDilation)
		{
			this.SourceType = SourceType;
			this.TimeDilation = TimeDilation;
		}

		// Token: 0x06020074 RID: 131188 RVA: 0x0093B752 File Offset: 0x00939952
		public static bool operator ==(SEntityTimeDilation left, SEntityTimeDilation right)
		{
			return left.SourceType == right.SourceType && left.TimeDilation == right.TimeDilation;
		}

		// Token: 0x06020075 RID: 131189 RVA: 0x0093B772 File Offset: 0x00939972
		public static bool operator !=(SEntityTimeDilation left, SEntityTimeDilation right)
		{
			return !(left == right);
		}

		// Token: 0x06020076 RID: 131190 RVA: 0x0093B77E File Offset: 0x0093997E
		public bool Equals(SEntityTimeDilation other)
		{
			return this == other;
		}

		// Token: 0x06020077 RID: 131191 RVA: 0x0093B78C File Offset: 0x0093998C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SEntityTimeDilation)
			{
				SEntityTimeDilation other = (SEntityTimeDilation)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06020078 RID: 131192 RVA: 0x0093B7B1 File Offset: 0x009399B1
		public override int GetHashCode()
		{
			return HashCode.Combine<int, float>(this.SourceType, this.TimeDilation);
		}

		// Token: 0x06020079 RID: 131193 RVA: 0x0093B7C4 File Offset: 0x009399C4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SEntityTimeDilation._ScriptStructPtr != 0) ? SEntityTimeDilation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Entity/Struct/SEntityTimeDilation.SEntityTimeDilation", ref SEntityTimeDilation._ScriptStructPtr);
		}

		// Token: 0x04011359 RID: 70489
		[FieldOffset(0)]
		public int SourceType;

		// Token: 0x0401135A RID: 70490
		[FieldOffset(4)]
		public float TimeDilation;

		// Token: 0x0401135B RID: 70491
		public const string __ObjectPath = "/Game/Aki/Data/Entity/Struct/SEntityTimeDilation.SEntityTimeDilation";

		// Token: 0x0401135C RID: 70492
		private static IntPtr _ScriptStructPtr;
	}
}
