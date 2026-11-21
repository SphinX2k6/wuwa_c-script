using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x0200319C RID: 12700
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 50)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQte_Attach.SCommonQte_Attach")]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 56)]
	public struct SCommonQte_Attach : IEqualityOperators<SCommonQte_Attach, SCommonQte_Attach, bool>, IEquatable<SCommonQte_Attach>, IUnrealScriptStruct
	{
		// Token: 0x0601F50A RID: 128266 RVA: 0x0092B0AA File Offset: 0x009292AA
		public SCommonQte_Attach(FVectorDouble Location, FVectorDouble Rotation, bool KeepRelativeToCamera, bool UseTargetScreenPos)
		{
			this.Location = Location;
			this.Rotation = Rotation;
			this.KeepRelativeToCamera = KeepRelativeToCamera;
			this.UseTargetScreenPos = UseTargetScreenPos;
		}

		// Token: 0x0601F50B RID: 128267 RVA: 0x0092B0CC File Offset: 0x009292CC
		public static bool operator ==(SCommonQte_Attach left, SCommonQte_Attach right)
		{
			return left.Location == right.Location && left.Rotation == right.Rotation && left.KeepRelativeToCamera == right.KeepRelativeToCamera && left.UseTargetScreenPos == right.UseTargetScreenPos;
		}

		// Token: 0x0601F50C RID: 128268 RVA: 0x0092B11D File Offset: 0x0092931D
		public static bool operator !=(SCommonQte_Attach left, SCommonQte_Attach right)
		{
			return !(left == right);
		}

		// Token: 0x0601F50D RID: 128269 RVA: 0x0092B129 File Offset: 0x00929329
		public bool Equals(SCommonQte_Attach other)
		{
			return this == other;
		}

		// Token: 0x0601F50E RID: 128270 RVA: 0x0092B138 File Offset: 0x00929338
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SCommonQte_Attach)
			{
				SCommonQte_Attach other = (SCommonQte_Attach)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0601F50F RID: 128271 RVA: 0x0092B15D File Offset: 0x0092935D
		public override int GetHashCode()
		{
			return HashCode.Combine<FVectorDouble, FVectorDouble, bool, bool>(this.Location, this.Rotation, this.KeepRelativeToCamera, this.UseTargetScreenPos);
		}

		// Token: 0x0601F510 RID: 128272 RVA: 0x0092B17C File Offset: 0x0092937C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQte_Attach._ScriptStructPtr != 0) ? SCommonQte_Attach._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQte_Attach.SCommonQte_Attach", ref SCommonQte_Attach._ScriptStructPtr);
		}

		// Token: 0x04010C94 RID: 68756
		[FieldOffset(0)]
		public FVectorDouble Location;

		// Token: 0x04010C95 RID: 68757
		[FieldOffset(24)]
		public FVectorDouble Rotation;

		// Token: 0x04010C96 RID: 68758
		[FieldOffset(48)]
		public bool KeepRelativeToCamera;

		// Token: 0x04010C97 RID: 68759
		[FieldOffset(49)]
		public bool UseTargetScreenPos;

		// Token: 0x04010C98 RID: 68760
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQte_Attach.SCommonQte_Attach";

		// Token: 0x04010C99 RID: 68761
		private static IntPtr _ScriptStructPtr;
	}
}
