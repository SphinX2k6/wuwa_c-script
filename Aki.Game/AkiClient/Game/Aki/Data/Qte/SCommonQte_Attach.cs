using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003ED7 RID: 16087
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 50)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SCommonQte_Attach.SCommonQte_Attach")]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 56)]
	public struct SCommonQte_Attach : IEqualityOperators<SCommonQte_Attach, SCommonQte_Attach, bool>, IEquatable<SCommonQte_Attach>, IUnrealScriptStruct
	{
		// Token: 0x06028ADA RID: 166618 RVA: 0x009B1FD7 File Offset: 0x009B01D7
		public SCommonQte_Attach(FVectorDouble Location, FVectorDouble Rotation, bool KeepRelativeToCamera, bool UseTargetScreenPos)
		{
			this.Location = Location;
			this.Rotation = Rotation;
			this.KeepRelativeToCamera = KeepRelativeToCamera;
			this.UseTargetScreenPos = UseTargetScreenPos;
		}

		// Token: 0x06028ADB RID: 166619 RVA: 0x009B1FF8 File Offset: 0x009B01F8
		public static bool operator ==(SCommonQte_Attach left, SCommonQte_Attach right)
		{
			return left.Location == right.Location && left.Rotation == right.Rotation && left.KeepRelativeToCamera == right.KeepRelativeToCamera && left.UseTargetScreenPos == right.UseTargetScreenPos;
		}

		// Token: 0x06028ADC RID: 166620 RVA: 0x009B2049 File Offset: 0x009B0249
		public static bool operator !=(SCommonQte_Attach left, SCommonQte_Attach right)
		{
			return !(left == right);
		}

		// Token: 0x06028ADD RID: 166621 RVA: 0x009B2055 File Offset: 0x009B0255
		public bool Equals(SCommonQte_Attach other)
		{
			return this == other;
		}

		// Token: 0x06028ADE RID: 166622 RVA: 0x009B2064 File Offset: 0x009B0264
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

		// Token: 0x06028ADF RID: 166623 RVA: 0x009B2089 File Offset: 0x009B0289
		public override int GetHashCode()
		{
			return HashCode.Combine<FVectorDouble, FVectorDouble, bool, bool>(this.Location, this.Rotation, this.KeepRelativeToCamera, this.UseTargetScreenPos);
		}

		// Token: 0x06028AE0 RID: 166624 RVA: 0x009B20A8 File Offset: 0x009B02A8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCommonQte_Attach._ScriptStructPtr != 0) ? SCommonQte_Attach._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SCommonQte_Attach.SCommonQte_Attach", ref SCommonQte_Attach._ScriptStructPtr);
		}

		// Token: 0x04014CAD RID: 85165
		[FieldOffset(0)]
		public FVectorDouble Location;

		// Token: 0x04014CAE RID: 85166
		[FieldOffset(24)]
		public FVectorDouble Rotation;

		// Token: 0x04014CAF RID: 85167
		[FieldOffset(48)]
		public bool KeepRelativeToCamera;

		// Token: 0x04014CB0 RID: 85168
		[FieldOffset(49)]
		public bool UseTargetScreenPos;

		// Token: 0x04014CB1 RID: 85169
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SCommonQte_Attach.SCommonQte_Attach";

		// Token: 0x04014CB2 RID: 85170
		private static IntPtr _ScriptStructPtr;
	}
}
