using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020044B3 RID: 17587
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(148, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 148)]
	[UnrealObjectPath("/Niagara/Enums/ENiagara_WaterInteractionStruct.ENiagara_WaterInteractionStruct")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 148)]
	public struct ENiagara_WaterInteractionStruct : IEqualityOperators<ENiagara_WaterInteractionStruct, ENiagara_WaterInteractionStruct, bool>, IEquatable<ENiagara_WaterInteractionStruct>, IUnrealScriptStruct
	{
		// Token: 0x0602D4C3 RID: 185539 RVA: 0x00A38B48 File Offset: 0x00A36D48
		public ENiagara_WaterInteractionStruct(bool Intersects, FVector IntersectionCentroid, FVector IntersectionXBasisVector, FVector IntersectionYBasisVector, FVector Intersection_Z_BasisVector, float Intersection_X_Size, float Intersection_Y_Size, float Occlusion_Delta, float Occluded_volume, float Full_Volume, FVector Volume_X_basis, FVector Volume_Y_basis, FVector Volume_Z_basis, float Volume_Length, float Volume_Radius, FVector Volume_Centroid, FVector Bone_Velocity, float Kinetic_Energy, float Mass)
		{
			this.Intersects = Intersects;
			this.IntersectionCentroid = IntersectionCentroid;
			this.IntersectionXBasisVector = IntersectionXBasisVector;
			this.IntersectionYBasisVector = IntersectionYBasisVector;
			this.Intersection_Z_BasisVector = Intersection_Z_BasisVector;
			this.Intersection_X_Size = Intersection_X_Size;
			this.Intersection_Y_Size = Intersection_Y_Size;
			this.Occlusion_Delta = Occlusion_Delta;
			this.Occluded_volume = Occluded_volume;
			this.Full_Volume = Full_Volume;
			this.Volume_X_basis = Volume_X_basis;
			this.Volume_Y_basis = Volume_Y_basis;
			this.Volume_Z_basis = Volume_Z_basis;
			this.Volume_Length = Volume_Length;
			this.Volume_Radius = Volume_Radius;
			this.Volume_Centroid = Volume_Centroid;
			this.Bone_Velocity = Bone_Velocity;
			this.Kinetic_Energy = Kinetic_Energy;
			this.Mass = Mass;
		}

		// Token: 0x0602D4C4 RID: 185540 RVA: 0x00A38BEC File Offset: 0x00A36DEC
		public static bool operator ==(ENiagara_WaterInteractionStruct left, ENiagara_WaterInteractionStruct right)
		{
			return left.Intersects == right.Intersects && left.IntersectionCentroid == right.IntersectionCentroid && left.IntersectionXBasisVector == right.IntersectionXBasisVector && left.IntersectionYBasisVector == right.IntersectionYBasisVector && left.Intersection_Z_BasisVector == right.Intersection_Z_BasisVector && left.Intersection_X_Size == right.Intersection_X_Size && left.Intersection_Y_Size == right.Intersection_Y_Size && left.Occlusion_Delta == right.Occlusion_Delta && left.Occluded_volume == right.Occluded_volume && left.Full_Volume == right.Full_Volume && left.Volume_X_basis == right.Volume_X_basis && left.Volume_Y_basis == right.Volume_Y_basis && left.Volume_Z_basis == right.Volume_Z_basis && left.Volume_Length == right.Volume_Length && left.Volume_Radius == right.Volume_Radius && left.Volume_Centroid == right.Volume_Centroid && left.Bone_Velocity == right.Bone_Velocity && left.Kinetic_Energy == right.Kinetic_Energy && left.Mass == right.Mass;
		}

		// Token: 0x0602D4C5 RID: 185541 RVA: 0x00A38D53 File Offset: 0x00A36F53
		public static bool operator !=(ENiagara_WaterInteractionStruct left, ENiagara_WaterInteractionStruct right)
		{
			return !(left == right);
		}

		// Token: 0x0602D4C6 RID: 185542 RVA: 0x00A38D5F File Offset: 0x00A36F5F
		public bool Equals(ENiagara_WaterInteractionStruct other)
		{
			return this == other;
		}

		// Token: 0x0602D4C7 RID: 185543 RVA: 0x00A38D70 File Offset: 0x00A36F70
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is ENiagara_WaterInteractionStruct)
			{
				ENiagara_WaterInteractionStruct other = (ENiagara_WaterInteractionStruct)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602D4C8 RID: 185544 RVA: 0x00A38D98 File Offset: 0x00A36F98
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<bool>(this.Intersects);
			hashCode.Add<FVector>(this.IntersectionCentroid);
			hashCode.Add<FVector>(this.IntersectionXBasisVector);
			hashCode.Add<FVector>(this.IntersectionYBasisVector);
			hashCode.Add<FVector>(this.Intersection_Z_BasisVector);
			hashCode.Add<float>(this.Intersection_X_Size);
			hashCode.Add<float>(this.Intersection_Y_Size);
			hashCode.Add<float>(this.Occlusion_Delta);
			hashCode.Add<float>(this.Occluded_volume);
			hashCode.Add<float>(this.Full_Volume);
			hashCode.Add<FVector>(this.Volume_X_basis);
			hashCode.Add<FVector>(this.Volume_Y_basis);
			hashCode.Add<FVector>(this.Volume_Z_basis);
			hashCode.Add<float>(this.Volume_Length);
			hashCode.Add<float>(this.Volume_Radius);
			hashCode.Add<FVector>(this.Volume_Centroid);
			hashCode.Add<FVector>(this.Bone_Velocity);
			hashCode.Add<float>(this.Kinetic_Energy);
			hashCode.Add<float>(this.Mass);
			return hashCode.ToHashCode();
		}

		// Token: 0x0602D4C9 RID: 185545 RVA: 0x00A38EAB File Offset: 0x00A370AB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (ENiagara_WaterInteractionStruct._ScriptStructPtr != 0) ? ENiagara_WaterInteractionStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Niagara/Enums/ENiagara_WaterInteractionStruct.ENiagara_WaterInteractionStruct", ref ENiagara_WaterInteractionStruct._ScriptStructPtr);
		}

		// Token: 0x04018379 RID: 99193
		[FieldOffset(0)]
		public bool Intersects;

		// Token: 0x0401837A RID: 99194
		[FieldOffset(4)]
		public FVector IntersectionCentroid;

		// Token: 0x0401837B RID: 99195
		[FieldOffset(16)]
		public FVector IntersectionXBasisVector;

		// Token: 0x0401837C RID: 99196
		[FieldOffset(28)]
		public FVector IntersectionYBasisVector;

		// Token: 0x0401837D RID: 99197
		[FieldOffset(40)]
		public FVector Intersection_Z_BasisVector;

		// Token: 0x0401837E RID: 99198
		[FieldOffset(52)]
		public float Intersection_X_Size;

		// Token: 0x0401837F RID: 99199
		[FieldOffset(56)]
		public float Intersection_Y_Size;

		// Token: 0x04018380 RID: 99200
		[FieldOffset(60)]
		public float Occlusion_Delta;

		// Token: 0x04018381 RID: 99201
		[FieldOffset(64)]
		public float Occluded_volume;

		// Token: 0x04018382 RID: 99202
		[FieldOffset(68)]
		public float Full_Volume;

		// Token: 0x04018383 RID: 99203
		[FieldOffset(72)]
		public FVector Volume_X_basis;

		// Token: 0x04018384 RID: 99204
		[FieldOffset(84)]
		public FVector Volume_Y_basis;

		// Token: 0x04018385 RID: 99205
		[FieldOffset(96)]
		public FVector Volume_Z_basis;

		// Token: 0x04018386 RID: 99206
		[FieldOffset(108)]
		public float Volume_Length;

		// Token: 0x04018387 RID: 99207
		[FieldOffset(112)]
		public float Volume_Radius;

		// Token: 0x04018388 RID: 99208
		[FieldOffset(116)]
		public FVector Volume_Centroid;

		// Token: 0x04018389 RID: 99209
		[FieldOffset(128)]
		public FVector Bone_Velocity;

		// Token: 0x0401838A RID: 99210
		[FieldOffset(140)]
		public float Kinetic_Energy;

		// Token: 0x0401838B RID: 99211
		[FieldOffset(144)]
		public float Mass;

		// Token: 0x0401838C RID: 99212
		public const string __ObjectPath = "/Niagara/Enums/ENiagara_WaterInteractionStruct.ENiagara_WaterInteractionStruct";

		// Token: 0x0401838D RID: 99213
		private static IntPtr _ScriptStructPtr;
	}
}
