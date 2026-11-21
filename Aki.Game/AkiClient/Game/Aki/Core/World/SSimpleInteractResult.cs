using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.World
{
	// Token: 0x02003254 RID: 12884
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 29)]
	[UnrealObjectPath("/Game/Aki/Core/World/SSimpleInteractResult.SSimpleInteractResult")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 32)]
	public struct SSimpleInteractResult : IEqualityOperators<SSimpleInteractResult, SSimpleInteractResult, bool>, IEquatable<SSimpleInteractResult>, IUnrealScriptStruct
	{
		// Token: 0x060202F4 RID: 131828 RVA: 0x0093F3E4 File Offset: 0x0093D5E4
		public SSimpleInteractResult(FVector Location, FRotator Rotator, float SquaredOffsetLength, bool Success)
		{
			this.Location = Location;
			this.Rotator = Rotator;
			this.SquaredOffsetLength = SquaredOffsetLength;
			this.Success = Success;
		}

		// Token: 0x060202F5 RID: 131829 RVA: 0x0093F404 File Offset: 0x0093D604
		public static bool operator ==(SSimpleInteractResult left, SSimpleInteractResult right)
		{
			return left.Location == right.Location && left.Rotator == right.Rotator && left.SquaredOffsetLength == right.SquaredOffsetLength && left.Success == right.Success;
		}

		// Token: 0x060202F6 RID: 131830 RVA: 0x0093F455 File Offset: 0x0093D655
		public static bool operator !=(SSimpleInteractResult left, SSimpleInteractResult right)
		{
			return !(left == right);
		}

		// Token: 0x060202F7 RID: 131831 RVA: 0x0093F461 File Offset: 0x0093D661
		public bool Equals(SSimpleInteractResult other)
		{
			return this == other;
		}

		// Token: 0x060202F8 RID: 131832 RVA: 0x0093F470 File Offset: 0x0093D670
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

		// Token: 0x060202F9 RID: 131833 RVA: 0x0093F495 File Offset: 0x0093D695
		public override int GetHashCode()
		{
			return HashCode.Combine<FVector, FRotator, float, bool>(this.Location, this.Rotator, this.SquaredOffsetLength, this.Success);
		}

		// Token: 0x060202FA RID: 131834 RVA: 0x0093F4B4 File Offset: 0x0093D6B4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSimpleInteractResult._ScriptStructPtr != 0) ? SSimpleInteractResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/World/SSimpleInteractResult.SSimpleInteractResult", ref SSimpleInteractResult._ScriptStructPtr);
		}

		// Token: 0x0401153D RID: 70973
		[FieldOffset(0)]
		public FVector Location;

		// Token: 0x0401153E RID: 70974
		[FieldOffset(12)]
		public FRotator Rotator;

		// Token: 0x0401153F RID: 70975
		[FieldOffset(24)]
		public float SquaredOffsetLength;

		// Token: 0x04011540 RID: 70976
		[FieldOffset(28)]
		public bool Success;

		// Token: 0x04011541 RID: 70977
		public const string __ObjectPath = "/Game/Aki/Core/World/SSimpleInteractResult.SSimpleInteractResult";

		// Token: 0x04011542 RID: 70978
		private static IntPtr _ScriptStructPtr;
	}
}
