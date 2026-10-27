using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003E1D RID: 15901
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 24)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerMaterialIndex.SMaterialControllerMaterialIndex")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 24)]
	public struct SMaterialControllerMaterialIndex : IEqualityOperators<SMaterialControllerMaterialIndex, SMaterialControllerMaterialIndex, bool>, IEquatable<SMaterialControllerMaterialIndex>, IUnrealScriptStruct
	{
		// Token: 0x06027DC2 RID: 163266 RVA: 0x0099D2B6 File Offset: 0x0099B4B6
		public SMaterialControllerMaterialIndex(FName BodyName, int SectionIndex, TEnumAsByte<ECharacterSlotSpecifiedType> SlotType, int MaterialIndex)
		{
			this.BodyName = BodyName;
			this.SectionIndex = SectionIndex;
			this.SlotType = SlotType;
			this.MaterialIndex = MaterialIndex;
		}

		// Token: 0x06027DC3 RID: 163267 RVA: 0x0099D2D8 File Offset: 0x0099B4D8
		public static bool operator ==(SMaterialControllerMaterialIndex left, SMaterialControllerMaterialIndex right)
		{
			return left.BodyName == right.BodyName && left.SectionIndex == right.SectionIndex && left.SlotType == right.SlotType && left.MaterialIndex == right.MaterialIndex;
		}

		// Token: 0x06027DC4 RID: 163268 RVA: 0x0099D329 File Offset: 0x0099B529
		public static bool operator !=(SMaterialControllerMaterialIndex left, SMaterialControllerMaterialIndex right)
		{
			return !(left == right);
		}

		// Token: 0x06027DC5 RID: 163269 RVA: 0x0099D335 File Offset: 0x0099B535
		public bool Equals(SMaterialControllerMaterialIndex other)
		{
			return this == other;
		}

		// Token: 0x06027DC6 RID: 163270 RVA: 0x0099D344 File Offset: 0x0099B544
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SMaterialControllerMaterialIndex)
			{
				SMaterialControllerMaterialIndex other = (SMaterialControllerMaterialIndex)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06027DC7 RID: 163271 RVA: 0x0099D369 File Offset: 0x0099B569
		public override int GetHashCode()
		{
			return HashCode.Combine<FName, int, TEnumAsByte<ECharacterSlotSpecifiedType>, int>(this.BodyName, this.SectionIndex, this.SlotType, this.MaterialIndex);
		}

		// Token: 0x06027DC8 RID: 163272 RVA: 0x0099D388 File Offset: 0x0099B588
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMaterialControllerMaterialIndex._ScriptStructPtr != 0) ? SMaterialControllerMaterialIndex._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerMaterialIndex.SMaterialControllerMaterialIndex", ref SMaterialControllerMaterialIndex._ScriptStructPtr);
		}

		// Token: 0x04014351 RID: 82769
		[FieldOffset(0)]
		public FName BodyName;

		// Token: 0x04014352 RID: 82770
		[FieldOffset(12)]
		public int SectionIndex;

		// Token: 0x04014353 RID: 82771
		[FieldOffset(16)]
		public TEnumAsByte<ECharacterSlotSpecifiedType> SlotType;

		// Token: 0x04014354 RID: 82772
		[FieldOffset(20)]
		public int MaterialIndex;

		// Token: 0x04014355 RID: 82773
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerMaterialIndex.SMaterialControllerMaterialIndex";

		// Token: 0x04014356 RID: 82774
		private static IntPtr _ScriptStructPtr;
	}
}
