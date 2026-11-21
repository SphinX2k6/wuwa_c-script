using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Level.KeepFollowing
{
	// Token: 0x020031CA RID: 12746
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Game/Aki/Data/Level/KeepFollowing/SFollowSitConfig.SFollowSitConfig")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct SFollowSitConfig : IEqualityOperators<SFollowSitConfig, SFollowSitConfig, bool>, IEquatable<SFollowSitConfig>, IUnrealScriptStruct
	{
		// Token: 0x0601F929 RID: 129321 RVA: 0x00930AEC File Offset: 0x0092ECEC
		public SFollowSitConfig(bool Enable, int FindChairRadius, int ExitSitDownDistance)
		{
			this.Enable = Enable;
			this.FindChairRadius = FindChairRadius;
			this.ExitSitDownDistance = ExitSitDownDistance;
		}

		// Token: 0x0601F92A RID: 129322 RVA: 0x00930B03 File Offset: 0x0092ED03
		public static bool operator ==(SFollowSitConfig left, SFollowSitConfig right)
		{
			return left.Enable == right.Enable && left.FindChairRadius == right.FindChairRadius && left.ExitSitDownDistance == right.ExitSitDownDistance;
		}

		// Token: 0x0601F92B RID: 129323 RVA: 0x00930B31 File Offset: 0x0092ED31
		public static bool operator !=(SFollowSitConfig left, SFollowSitConfig right)
		{
			return !(left == right);
		}

		// Token: 0x0601F92C RID: 129324 RVA: 0x00930B3D File Offset: 0x0092ED3D
		public bool Equals(SFollowSitConfig other)
		{
			return this == other;
		}

		// Token: 0x0601F92D RID: 129325 RVA: 0x00930B4C File Offset: 0x0092ED4C
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

		// Token: 0x0601F92E RID: 129326 RVA: 0x00930B71 File Offset: 0x0092ED71
		public override int GetHashCode()
		{
			return HashCode.Combine<bool, int, int>(this.Enable, this.FindChairRadius, this.ExitSitDownDistance);
		}

		// Token: 0x0601F92F RID: 129327 RVA: 0x00930B8A File Offset: 0x0092ED8A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFollowSitConfig._ScriptStructPtr != 0) ? SFollowSitConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Level/KeepFollowing/SFollowSitConfig.SFollowSitConfig", ref SFollowSitConfig._ScriptStructPtr);
		}

		// Token: 0x04010EFC RID: 69372
		[FieldOffset(0)]
		public bool Enable;

		// Token: 0x04010EFD RID: 69373
		[FieldOffset(4)]
		public int FindChairRadius;

		// Token: 0x04010EFE RID: 69374
		[FieldOffset(8)]
		public int ExitSitDownDistance;

		// Token: 0x04010EFF RID: 69375
		public const string __ObjectPath = "/Game/Aki/Data/Level/KeepFollowing/SFollowSitConfig.SFollowSitConfig";

		// Token: 0x04010F00 RID: 69376
		private static IntPtr _ScriptStructPtr;
	}
}
