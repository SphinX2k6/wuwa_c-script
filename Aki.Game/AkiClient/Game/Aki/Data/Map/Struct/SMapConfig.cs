using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Map.Struct
{
	// Token: 0x02003EF7 RID: 16119
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Game/Aki/Data/Map/Struct/SMapConfig.SMapConfig")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct SMapConfig : IEqualityOperators<SMapConfig, SMapConfig, bool>, IEquatable<SMapConfig>, IUnrealScriptStruct
	{
		// Token: 0x06028D28 RID: 167208 RVA: 0x009B561B File Offset: 0x009B381B
		public SMapConfig(int ID, FName MapPath)
		{
			this.ID = ID;
			this.MapPath = MapPath;
		}

		// Token: 0x06028D29 RID: 167209 RVA: 0x009B562B File Offset: 0x009B382B
		public static bool operator ==(SMapConfig left, SMapConfig right)
		{
			return left.ID == right.ID && left.MapPath == right.MapPath;
		}

		// Token: 0x06028D2A RID: 167210 RVA: 0x009B564E File Offset: 0x009B384E
		public static bool operator !=(SMapConfig left, SMapConfig right)
		{
			return !(left == right);
		}

		// Token: 0x06028D2B RID: 167211 RVA: 0x009B565A File Offset: 0x009B385A
		public bool Equals(SMapConfig other)
		{
			return this == other;
		}

		// Token: 0x06028D2C RID: 167212 RVA: 0x009B5668 File Offset: 0x009B3868
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SMapConfig)
			{
				SMapConfig other = (SMapConfig)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06028D2D RID: 167213 RVA: 0x009B568D File Offset: 0x009B388D
		public override int GetHashCode()
		{
			return HashCode.Combine<int, FName>(this.ID, this.MapPath);
		}

		// Token: 0x06028D2E RID: 167214 RVA: 0x009B56A0 File Offset: 0x009B38A0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMapConfig._ScriptStructPtr != 0) ? SMapConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Map/Struct/SMapConfig.SMapConfig", ref SMapConfig._ScriptStructPtr);
		}

		// Token: 0x04014DF6 RID: 85494
		[FieldOffset(0)]
		public int ID;

		// Token: 0x04014DF7 RID: 85495
		[FieldOffset(4)]
		public FName MapPath;

		// Token: 0x04014DF8 RID: 85496
		public const string __ObjectPath = "/Game/Aki/Data/Map/Struct/SMapConfig.SMapConfig";

		// Token: 0x04014DF9 RID: 85497
		private static IntPtr _ScriptStructPtr;
	}
}
