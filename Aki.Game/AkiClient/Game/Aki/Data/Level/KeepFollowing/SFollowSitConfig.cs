using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Level.KeepFollowing
{
	// Token: 0x02003F0E RID: 16142
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Game/Aki/Data/Level/KeepFollowing/SFollowSitConfig.SFollowSitConfig")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct SFollowSitConfig : IEqualityOperators<SFollowSitConfig, SFollowSitConfig, bool>, IEquatable<SFollowSitConfig>, IUnrealScriptStruct
	{
		// Token: 0x06028F97 RID: 167831 RVA: 0x009B8BA0 File Offset: 0x009B6DA0
		public SFollowSitConfig(bool Enable, int FindChairRadius, int ExitSitDownDistance)
		{
			this.Enable = Enable;
			this.FindChairRadius = FindChairRadius;
			this.ExitSitDownDistance = ExitSitDownDistance;
		}

		// Token: 0x06028F98 RID: 167832 RVA: 0x009B8BB7 File Offset: 0x009B6DB7
		public static bool operator ==(SFollowSitConfig left, SFollowSitConfig right)
		{
			return left.Enable == right.Enable && left.FindChairRadius == right.FindChairRadius && left.ExitSitDownDistance == right.ExitSitDownDistance;
		}

		// Token: 0x06028F99 RID: 167833 RVA: 0x009B8BE5 File Offset: 0x009B6DE5
		public static bool operator !=(SFollowSitConfig left, SFollowSitConfig right)
		{
			return !(left == right);
		}

		// Token: 0x06028F9A RID: 167834 RVA: 0x009B8BF1 File Offset: 0x009B6DF1
		public bool Equals(SFollowSitConfig other)
		{
			return this == other;
		}

		// Token: 0x06028F9B RID: 167835 RVA: 0x009B8C00 File Offset: 0x009B6E00
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SFollowSitConfig)
			{
				SFollowSitConfig other = (SFollowSitConfig)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06028F9C RID: 167836 RVA: 0x009B8C25 File Offset: 0x009B6E25
		public override int GetHashCode()
		{
			return HashCode.Combine<bool, int, int>(this.Enable, this.FindChairRadius, this.ExitSitDownDistance);
		}

		// Token: 0x06028F9D RID: 167837 RVA: 0x009B8C3E File Offset: 0x009B6E3E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFollowSitConfig._ScriptStructPtr != 0) ? SFollowSitConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Level/KeepFollowing/SFollowSitConfig.SFollowSitConfig", ref SFollowSitConfig._ScriptStructPtr);
		}

		// Token: 0x04014F5D RID: 85853
		[FieldOffset(0)]
		public bool Enable;

		// Token: 0x04014F5E RID: 85854
		[FieldOffset(4)]
		public int FindChairRadius;

		// Token: 0x04014F5F RID: 85855
		[FieldOffset(8)]
		public int ExitSitDownDistance;

		// Token: 0x04014F60 RID: 85856
		public const string __ObjectPath = "/Game/Aki/Data/Level/KeepFollowing/SFollowSitConfig.SFollowSitConfig";

		// Token: 0x04014F61 RID: 85857
		private static IntPtr _ScriptStructPtr;
	}
}
