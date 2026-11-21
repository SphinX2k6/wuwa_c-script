using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Manipulate
{
	// Token: 0x020031B6 RID: 12726
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 37)]
	[UnrealObjectPath("/Game/Aki/Data/Manipulate/SManipulatePointInfo.SManipulatePointInfo")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 40)]
	public struct SManipulatePointInfo : IEqualityOperators<SManipulatePointInfo, SManipulatePointInfo, bool>, IEquatable<SManipulatePointInfo>, IUnrealScriptStruct
	{
		// Token: 0x0601F6DA RID: 128730 RVA: 0x0092D8A6 File Offset: 0x0092BAA6
		public SManipulatePointInfo(FVector Location, FVector ArriveTangent, FVector LeaveTangent, TEnumAsByte<ESplinePointType> PointType)
		{
			this.Location = Location;
			this.ArriveTangent = ArriveTangent;
			this.LeaveTangent = LeaveTangent;
			this.PointType = PointType;
		}

		// Token: 0x0601F6DB RID: 128731 RVA: 0x0092D8C8 File Offset: 0x0092BAC8
		public static bool operator ==(SManipulatePointInfo left, SManipulatePointInfo right)
		{
			return left.Location == right.Location && left.ArriveTangent == right.ArriveTangent && left.LeaveTangent == right.LeaveTangent && left.PointType == right.PointType;
		}

		// Token: 0x0601F6DC RID: 128732 RVA: 0x0092D921 File Offset: 0x0092BB21
		public static bool operator !=(SManipulatePointInfo left, SManipulatePointInfo right)
		{
			return !(left == right);
		}

		// Token: 0x0601F6DD RID: 128733 RVA: 0x0092D92D File Offset: 0x0092BB2D
		public bool Equals(SManipulatePointInfo other)
		{
			return this == other;
		}

		// Token: 0x0601F6DE RID: 128734 RVA: 0x0092D93C File Offset: 0x0092BB3C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SManipulatePointInfo)
			{
				SManipulatePointInfo other = (SManipulatePointInfo)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601F6DF RID: 128735 RVA: 0x0092D961 File Offset: 0x0092BB61
		public override int GetHashCode()
		{
			return HashCode.Combine<FVector, FVector, FVector, TEnumAsByte<ESplinePointType>>(this.Location, this.ArriveTangent, this.LeaveTangent, this.PointType);
		}

		// Token: 0x0601F6E0 RID: 128736 RVA: 0x0092D980 File Offset: 0x0092BB80
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SManipulatePointInfo._ScriptStructPtr != 0) ? SManipulatePointInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Manipulate/SManipulatePointInfo.SManipulatePointInfo", ref SManipulatePointInfo._ScriptStructPtr);
		}

		// Token: 0x04010DA5 RID: 69029
		[FieldOffset(0)]
		public FVector Location;

		// Token: 0x04010DA6 RID: 69030
		[FieldOffset(12)]
		public FVector ArriveTangent;

		// Token: 0x04010DA7 RID: 69031
		[FieldOffset(24)]
		public FVector LeaveTangent;

		// Token: 0x04010DA8 RID: 69032
		[FieldOffset(36)]
		public TEnumAsByte<ESplinePointType> PointType;

		// Token: 0x04010DA9 RID: 69033
		public const string __ObjectPath = "/Game/Aki/Data/Manipulate/SManipulatePointInfo.SManipulatePointInfo";

		// Token: 0x04010DAA RID: 69034
		private static IntPtr _ScriptStructPtr;
	}
}
