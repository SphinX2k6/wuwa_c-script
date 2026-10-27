using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Manipulate
{
	// Token: 0x02003EF9 RID: 16121
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 37)]
	[UnrealObjectPath("/Game/Aki/Data/Manipulate/SManipulatePointInfo.SManipulatePointInfo")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 40)]
	public struct SManipulatePointInfo : IEqualityOperators<SManipulatePointInfo, SManipulatePointInfo, bool>, IEquatable<SManipulatePointInfo>, IUnrealScriptStruct
	{
		// Token: 0x06028D3D RID: 167229 RVA: 0x009B57DF File Offset: 0x009B39DF
		public SManipulatePointInfo(FVector Location, FVector ArriveTangent, FVector LeaveTangent, TEnumAsByte<ESplinePointType> PointType)
		{
			this.Location = Location;
			this.ArriveTangent = ArriveTangent;
			this.LeaveTangent = LeaveTangent;
			this.PointType = PointType;
		}

		// Token: 0x06028D3E RID: 167230 RVA: 0x009B5800 File Offset: 0x009B3A00
		public static bool operator ==(SManipulatePointInfo left, SManipulatePointInfo right)
		{
			return left.Location == right.Location && left.ArriveTangent == right.ArriveTangent && left.LeaveTangent == right.LeaveTangent && left.PointType == right.PointType;
		}

		// Token: 0x06028D3F RID: 167231 RVA: 0x009B5859 File Offset: 0x009B3A59
		public static bool operator !=(SManipulatePointInfo left, SManipulatePointInfo right)
		{
			return !(left == right);
		}

		// Token: 0x06028D40 RID: 167232 RVA: 0x009B5865 File Offset: 0x009B3A65
		public bool Equals(SManipulatePointInfo other)
		{
			return this == other;
		}

		// Token: 0x06028D41 RID: 167233 RVA: 0x009B5874 File Offset: 0x009B3A74
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

		// Token: 0x06028D42 RID: 167234 RVA: 0x009B5899 File Offset: 0x009B3A99
		public override int GetHashCode()
		{
			return HashCode.Combine<FVector, FVector, FVector, TEnumAsByte<ESplinePointType>>(this.Location, this.ArriveTangent, this.LeaveTangent, this.PointType);
		}

		// Token: 0x06028D43 RID: 167235 RVA: 0x009B58B8 File Offset: 0x009B3AB8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SManipulatePointInfo._ScriptStructPtr != 0) ? SManipulatePointInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Manipulate/SManipulatePointInfo.SManipulatePointInfo", ref SManipulatePointInfo._ScriptStructPtr);
		}

		// Token: 0x04014E00 RID: 85504
		[FieldOffset(0)]
		public FVector Location;

		// Token: 0x04014E01 RID: 85505
		[FieldOffset(12)]
		public FVector ArriveTangent;

		// Token: 0x04014E02 RID: 85506
		[FieldOffset(24)]
		public FVector LeaveTangent;

		// Token: 0x04014E03 RID: 85507
		[FieldOffset(36)]
		public TEnumAsByte<ESplinePointType> PointType;

		// Token: 0x04014E04 RID: 85508
		public const string __ObjectPath = "/Game/Aki/Data/Manipulate/SManipulatePointInfo.SManipulatePointInfo";

		// Token: 0x04014E05 RID: 85509
		private static IntPtr _ScriptStructPtr;
	}
}
