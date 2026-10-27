using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroCS.ClothPath
{
	// Token: 0x02003C93 RID: 15507
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(92, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 92)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/ClothPath/particle_cloth_path.particle_cloth_path")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 92)]
	public struct particle_cloth_path : IEqualityOperators<particle_cloth_path, particle_cloth_path, bool>, IEquatable<particle_cloth_path>, IUnrealScriptStruct
	{
		// Token: 0x0602444F RID: 148559 RVA: 0x00939B84 File Offset: 0x00937D84
		public particle_cloth_path(float dis_top, float dis_bottom, float dis_left, float dis_right, float dis_topLeft, float dis_topRight, float dis_bottomLeft, float dis_bottomRight, int topID, int bottomID, int leftID, int rightID, int topLeftID, int topRightID, int bottomLeftID, int bottomRightID, FVector pos, float pinWeight, FVector normal)
		{
			this.dis_top = dis_top;
			this.dis_bottom = dis_bottom;
			this.dis_left = dis_left;
			this.dis_right = dis_right;
			this.dis_topLeft = dis_topLeft;
			this.dis_topRight = dis_topRight;
			this.dis_bottomLeft = dis_bottomLeft;
			this.dis_bottomRight = dis_bottomRight;
			this.topID = topID;
			this.bottomID = bottomID;
			this.leftID = leftID;
			this.rightID = rightID;
			this.topLeftID = topLeftID;
			this.topRightID = topRightID;
			this.bottomLeftID = bottomLeftID;
			this.bottomRightID = bottomRightID;
			this.pos = pos;
			this.pinWeight = pinWeight;
			this.normal = normal;
		}

		// Token: 0x06024450 RID: 148560 RVA: 0x00939C28 File Offset: 0x00937E28
		public static bool operator ==(particle_cloth_path left, particle_cloth_path right)
		{
			return left.dis_top == right.dis_top && left.dis_bottom == right.dis_bottom && left.dis_left == right.dis_left && left.dis_right == right.dis_right && left.dis_topLeft == right.dis_topLeft && left.dis_topRight == right.dis_topRight && left.dis_bottomLeft == right.dis_bottomLeft && left.dis_bottomRight == right.dis_bottomRight && left.topID == right.topID && left.bottomID == right.bottomID && left.leftID == right.leftID && left.rightID == right.rightID && left.topLeftID == right.topLeftID && left.topRightID == right.topRightID && left.bottomLeftID == right.bottomLeftID && left.bottomRightID == right.bottomRightID && left.pos == right.pos && left.pinWeight == right.pinWeight && left.normal == right.normal;
		}

		// Token: 0x06024451 RID: 148561 RVA: 0x00939D67 File Offset: 0x00937F67
		public static bool operator !=(particle_cloth_path left, particle_cloth_path right)
		{
			return !(left == right);
		}

		// Token: 0x06024452 RID: 148562 RVA: 0x00939D73 File Offset: 0x00937F73
		public bool Equals(particle_cloth_path other)
		{
			return this == other;
		}

		// Token: 0x06024453 RID: 148563 RVA: 0x00939D84 File Offset: 0x00937F84
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is particle_cloth_path)
			{
				particle_cloth_path other = (particle_cloth_path)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06024454 RID: 148564 RVA: 0x00939DAC File Offset: 0x00937FAC
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<float>(this.dis_top);
			hashCode.Add<float>(this.dis_bottom);
			hashCode.Add<float>(this.dis_left);
			hashCode.Add<float>(this.dis_right);
			hashCode.Add<float>(this.dis_topLeft);
			hashCode.Add<float>(this.dis_topRight);
			hashCode.Add<float>(this.dis_bottomLeft);
			hashCode.Add<float>(this.dis_bottomRight);
			hashCode.Add<int>(this.topID);
			hashCode.Add<int>(this.bottomID);
			hashCode.Add<int>(this.leftID);
			hashCode.Add<int>(this.rightID);
			hashCode.Add<int>(this.topLeftID);
			hashCode.Add<int>(this.topRightID);
			hashCode.Add<int>(this.bottomLeftID);
			hashCode.Add<int>(this.bottomRightID);
			hashCode.Add<FVector>(this.pos);
			hashCode.Add<float>(this.pinWeight);
			hashCode.Add<FVector>(this.normal);
			return hashCode.ToHashCode();
		}

		// Token: 0x06024455 RID: 148565 RVA: 0x00939EBF File Offset: 0x009380BF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (particle_cloth_path._ScriptStructPtr != 0) ? particle_cloth_path._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/ClothPath/particle_cloth_path.particle_cloth_path", ref particle_cloth_path._ScriptStructPtr);
		}

		// Token: 0x04011FA0 RID: 73632
		[FieldOffset(0)]
		public float dis_top;

		// Token: 0x04011FA1 RID: 73633
		[FieldOffset(4)]
		public float dis_bottom;

		// Token: 0x04011FA2 RID: 73634
		[FieldOffset(8)]
		public float dis_left;

		// Token: 0x04011FA3 RID: 73635
		[FieldOffset(12)]
		public float dis_right;

		// Token: 0x04011FA4 RID: 73636
		[FieldOffset(16)]
		public float dis_topLeft;

		// Token: 0x04011FA5 RID: 73637
		[FieldOffset(20)]
		public float dis_topRight;

		// Token: 0x04011FA6 RID: 73638
		[FieldOffset(24)]
		public float dis_bottomLeft;

		// Token: 0x04011FA7 RID: 73639
		[FieldOffset(28)]
		public float dis_bottomRight;

		// Token: 0x04011FA8 RID: 73640
		[FieldOffset(32)]
		public int topID;

		// Token: 0x04011FA9 RID: 73641
		[FieldOffset(36)]
		public int bottomID;

		// Token: 0x04011FAA RID: 73642
		[FieldOffset(40)]
		public int leftID;

		// Token: 0x04011FAB RID: 73643
		[FieldOffset(44)]
		public int rightID;

		// Token: 0x04011FAC RID: 73644
		[FieldOffset(48)]
		public int topLeftID;

		// Token: 0x04011FAD RID: 73645
		[FieldOffset(52)]
		public int topRightID;

		// Token: 0x04011FAE RID: 73646
		[FieldOffset(56)]
		public int bottomLeftID;

		// Token: 0x04011FAF RID: 73647
		[FieldOffset(60)]
		public int bottomRightID;

		// Token: 0x04011FB0 RID: 73648
		[FieldOffset(64)]
		public FVector pos;

		// Token: 0x04011FB1 RID: 73649
		[FieldOffset(76)]
		public float pinWeight;

		// Token: 0x04011FB2 RID: 73650
		[FieldOffset(80)]
		public FVector normal;

		// Token: 0x04011FB3 RID: 73651
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/ClothPath/particle_cloth_path.particle_cloth_path";

		// Token: 0x04011FB4 RID: 73652
		private static IntPtr _ScriptStructPtr;
	}
}
