using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.World
{
	// Token: 0x02003FE6 RID: 16358
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 29)]
	[UnrealObjectPath("/Game/Aki/Core/World/SSimpleInteractResult.SSimpleInteractResult")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 32)]
	public struct SSimpleInteractResult : IEqualityOperators<SSimpleInteractResult, SSimpleInteractResult, bool>, IEquatable<SSimpleInteractResult>, IUnrealScriptStruct
	{
		// Token: 0x06029E55 RID: 171605 RVA: 0x009CF96E File Offset: 0x009CDB6E
		public SSimpleInteractResult(FVector Location, FRotator Rotator, float SquaredOffsetLength, bool Success)
		{
			this.Location = Location;
			this.Rotator = Rotator;
			this.SquaredOffsetLength = SquaredOffsetLength;
			this.Success = Success;
		}

		// Token: 0x06029E56 RID: 171606 RVA: 0x009CF990 File Offset: 0x009CDB90
		public static bool operator ==(SSimpleInteractResult left, SSimpleInteractResult right)
		{
			return left.Location == right.Location && left.Rotator == right.Rotator && left.SquaredOffsetLength == right.SquaredOffsetLength && left.Success == right.Success;
		}

		// Token: 0x06029E57 RID: 171607 RVA: 0x009CF9E1 File Offset: 0x009CDBE1
		public static bool operator !=(SSimpleInteractResult left, SSimpleInteractResult right)
		{
			return !(left == right);
		}

		// Token: 0x06029E58 RID: 171608 RVA: 0x009CF9ED File Offset: 0x009CDBED
		public bool Equals(SSimpleInteractResult other)
		{
			return this == other;
		}

		// Token: 0x06029E59 RID: 171609 RVA: 0x009CF9FC File Offset: 0x009CDBFC
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SSimpleInteractResult)
			{
				SSimpleInteractResult other = (SSimpleInteractResult)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06029E5A RID: 171610 RVA: 0x009CFA21 File Offset: 0x009CDC21
		public override int GetHashCode()
		{
			return HashCode.Combine<FVector, FRotator, float, bool>(this.Location, this.Rotator, this.SquaredOffsetLength, this.Success);
		}

		// Token: 0x06029E5B RID: 171611 RVA: 0x009CFA40 File Offset: 0x009CDC40
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSimpleInteractResult._ScriptStructPtr != 0) ? SSimpleInteractResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/World/SSimpleInteractResult.SSimpleInteractResult", ref SSimpleInteractResult._ScriptStructPtr);
		}

		// Token: 0x04015859 RID: 88153
		[FieldOffset(0)]
		public FVector Location;

		// Token: 0x0401585A RID: 88154
		[FieldOffset(12)]
		public FRotator Rotator;

		// Token: 0x0401585B RID: 88155
		[FieldOffset(24)]
		public float SquaredOffsetLength;

		// Token: 0x0401585C RID: 88156
		[FieldOffset(28)]
		public bool Success;

		// Token: 0x0401585D RID: 88157
		public const string __ObjectPath = "/Game/Aki/Core/World/SSimpleInteractResult.SSimpleInteractResult";

		// Token: 0x0401585E RID: 88158
		private static IntPtr _ScriptStructPtr;
	}
}
