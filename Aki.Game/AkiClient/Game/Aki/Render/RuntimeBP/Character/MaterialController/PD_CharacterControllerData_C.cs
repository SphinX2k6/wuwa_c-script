using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x0200312D RID: 12589
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CharacterControllerData.PD_CharacterControllerData_C")]
	[UnrealStructLayout(22168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 22164)]
	public class PD_CharacterControllerData_C : UKuroMaterialControllerDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EEE9 RID: 126697 RVA: 0x0092159E File Offset: 0x0091F79E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_CharacterControllerData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CharacterControllerData.PD_CharacterControllerData_C");
			}
			return PD_CharacterControllerData_C._ClassPtr;
		}

		// Token: 0x0601EEEA RID: 126698 RVA: 0x009215C4 File Offset: 0x0091F7C4
		public PD_CharacterControllerData_C() : this(BuiltinUtils.AllocNativeUObject(PD_CharacterControllerData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EEEB RID: 126699 RVA: 0x009215EC File Offset: 0x0091F7EC
		public PD_CharacterControllerData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_CharacterControllerData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700366F RID: 13935
		// (get) Token: 0x0601EEEC RID: 126700 RVA: 0x0092161F File Offset: 0x0091F81F
		// (set) Token: 0x0601EEED RID: 126701 RVA: 0x00921633 File Offset: 0x0091F833
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharacterControllerType> DataType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_DataType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_DataType) = value;
			}
		}

		// Token: 0x17003670 RID: 13936
		// (get) Token: 0x0601EEEE RID: 126702 RVA: 0x00921648 File Offset: 0x0091F848
		// (set) Token: 0x0601EEEF RID: 126703 RVA: 0x0092165C File Offset: 0x0091F85C
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharacterBodySpecifiedType> SpecifiedBodyType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_SpecifiedBodyType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_SpecifiedBodyType) = value;
			}
		}

		// Token: 0x17003671 RID: 13937
		// (get) Token: 0x0601EEF0 RID: 126704 RVA: 0x00921674 File Offset: 0x0091F874
		// (set) Token: 0x0601EEF1 RID: 126705 RVA: 0x009216AD File Offset: 0x0091F8AD
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<ECharacterMeshPart>> SpecifiedParts
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<ECharacterMeshPart>> result;
				if ((result = this._SpecifiedParts) == null)
				{
					result = (this._SpecifiedParts = new TArray<TEnumAsByte<ECharacterMeshPart>>(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_SpecifiedParts, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.SpecifiedParts.CopyAssign(value);
			}
		}

		// Token: 0x17003672 RID: 13938
		// (get) Token: 0x0601EEF2 RID: 126706 RVA: 0x009216BB File Offset: 0x0091F8BB
		// (set) Token: 0x0601EEF3 RID: 126707 RVA: 0x009216CF File Offset: 0x0091F8CF
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharacterSlotSpecifiedType> SpecifiedSlotType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_SpecifiedSlotType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_SpecifiedSlotType) = value;
			}
		}

		// Token: 0x17003673 RID: 13939
		// (get) Token: 0x0601EEF4 RID: 126708 RVA: 0x009216E4 File Offset: 0x0091F8E4
		// (set) Token: 0x0601EEF5 RID: 126709 RVA: 0x009216F8 File Offset: 0x0091F8F8
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharacterControllerApplyType> MaterialModifyType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_MaterialModifyType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_MaterialModifyType) = value;
			}
		}

		// Token: 0x17003674 RID: 13940
		// (get) Token: 0x0601EEF6 RID: 126710 RVA: 0x0092170D File Offset: 0x0091F90D
		// (set) Token: 0x0601EEF7 RID: 126711 RVA: 0x00921721 File Offset: 0x0091F921
		[Nullable(2)]
		public unsafe UMaterialInterface ReplaceMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + PD_CharacterControllerData_C.__PropertyOffset_ReplaceMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_CharacterControllerData_C.__PropertyOffset_ReplaceMaterial, value);
			}
		}

		// Token: 0x17003675 RID: 13941
		// (get) Token: 0x0601EEF8 RID: 126712 RVA: 0x00921736 File Offset: 0x0091F936
		// (set) Token: 0x0601EEF9 RID: 126713 RVA: 0x0092174A File Offset: 0x0091F94A
		[Nullable(2)]
		public unsafe UMaterialInterface ReplaceMaterialMobile
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + PD_CharacterControllerData_C.__PropertyOffset_ReplaceMaterialMobile);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_CharacterControllerData_C.__PropertyOffset_ReplaceMaterialMobile, value);
			}
		}

		// Token: 0x17003676 RID: 13942
		// (get) Token: 0x0601EEFA RID: 126714 RVA: 0x0092175F File Offset: 0x0091F95F
		// (set) Token: 0x0601EEFB RID: 126715 RVA: 0x0092176F File Offset: 0x0091F96F
		public unsafe bool RevertMaterial_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_RevertMaterial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_RevertMaterial) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003677 RID: 13943
		// (get) Token: 0x0601EEFC RID: 126716 RVA: 0x00921780 File Offset: 0x0091F980
		// (set) Token: 0x0601EEFD RID: 126717 RVA: 0x00921790 File Offset: 0x0091F990
		public unsafe bool UseRim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseRim) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseRim) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003678 RID: 13944
		// (get) Token: 0x0601EEFE RID: 126718 RVA: 0x009217A1 File Offset: 0x0091F9A1
		// (set) Token: 0x0601EEFF RID: 126719 RVA: 0x009217B1 File Offset: 0x0091F9B1
		public unsafe bool UseOutline
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseOutline) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseOutline) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003679 RID: 13945
		// (get) Token: 0x0601EF00 RID: 126720 RVA: 0x009217C2 File Offset: 0x0091F9C2
		// (set) Token: 0x0601EF01 RID: 126721 RVA: 0x009217D2 File Offset: 0x0091F9D2
		public unsafe bool OutlineRevertProperty_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_OutlineRevertProperty) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_OutlineRevertProperty) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700367A RID: 13946
		// (get) Token: 0x0601EF02 RID: 126722 RVA: 0x009217E3 File Offset: 0x0091F9E3
		// (set) Token: 0x0601EF03 RID: 126723 RVA: 0x009217F3 File Offset: 0x0091F9F3
		public unsafe bool UseDissolve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseDissolve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseDissolve) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700367B RID: 13947
		// (get) Token: 0x0601EF04 RID: 126724 RVA: 0x00921804 File Offset: 0x0091FA04
		// (set) Token: 0x0601EF05 RID: 126725 RVA: 0x00921818 File Offset: 0x0091FA18
		public unsafe SMaterialControllerLoopTime LoopTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_LoopTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_LoopTime) = value;
			}
		}

		// Token: 0x1700367C RID: 13948
		// (get) Token: 0x0601EF06 RID: 126726 RVA: 0x0092182D File Offset: 0x0091FA2D
		// (set) Token: 0x0601EF07 RID: 126727 RVA: 0x0092183D File Offset: 0x0091FA3D
		public unsafe bool RimRevertProperty_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_RimRevertProperty) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_RimRevertProperty) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700367D RID: 13949
		// (get) Token: 0x0601EF08 RID: 126728 RVA: 0x0092184E File Offset: 0x0091FA4E
		// (set) Token: 0x0601EF09 RID: 126729 RVA: 0x0092185E File Offset: 0x0091FA5E
		public unsafe bool RimUseTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_RimUseTex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_RimUseTex) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700367E RID: 13950
		// (get) Token: 0x0601EF0A RID: 126730 RVA: 0x0092186F File Offset: 0x0091FA6F
		// (set) Token: 0x0601EF0B RID: 126731 RVA: 0x00921883 File Offset: 0x0091FA83
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharacterControllerChannelSwitch> RimChannel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_RimChannel);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_RimChannel) = value;
			}
		}

		// Token: 0x1700367F RID: 13951
		// (get) Token: 0x0601EF0C RID: 126732 RVA: 0x00921898 File Offset: 0x0091FA98
		// (set) Token: 0x0601EF0D RID: 126733 RVA: 0x009218D1 File Offset: 0x0091FAD1
		public SMaterialControllerFloatGroup RimRange
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._RimRange) == null)
				{
					result = (this._RimRange = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_RimRange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_RimRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003680 RID: 13952
		// (get) Token: 0x0601EF0E RID: 126734 RVA: 0x009218F4 File Offset: 0x0091FAF4
		// (set) Token: 0x0601EF0F RID: 126735 RVA: 0x0092192D File Offset: 0x0091FB2D
		public SMaterialControllerColorGroup RimColor
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerColorGroup result;
				if ((result = this._RimColor) == null)
				{
					result = (this._RimColor = new SMaterialControllerColorGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_RimColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_RimColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003681 RID: 13953
		// (get) Token: 0x0601EF10 RID: 126736 RVA: 0x0092194E File Offset: 0x0091FB4E
		// (set) Token: 0x0601EF11 RID: 126737 RVA: 0x0092195E File Offset: 0x0091FB5E
		public unsafe bool OutlineUseTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_OutlineUseTex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_OutlineUseTex) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003682 RID: 13954
		// (get) Token: 0x0601EF12 RID: 126738 RVA: 0x00921970 File Offset: 0x0091FB70
		// (set) Token: 0x0601EF13 RID: 126739 RVA: 0x009219A9 File Offset: 0x0091FBA9
		public SMaterialControllerFloatGroup OutlineWidth
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._OutlineWidth) == null)
				{
					result = (this._OutlineWidth = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_OutlineWidth, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_OutlineWidth, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003683 RID: 13955
		// (get) Token: 0x0601EF14 RID: 126740 RVA: 0x009219CC File Offset: 0x0091FBCC
		// (set) Token: 0x0601EF15 RID: 126741 RVA: 0x00921A05 File Offset: 0x0091FC05
		public SMaterialControllerColorGroup OutlineColor
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerColorGroup result;
				if ((result = this._OutlineColor) == null)
				{
					result = (this._OutlineColor = new SMaterialControllerColorGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_OutlineColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_OutlineColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003684 RID: 13956
		// (get) Token: 0x0601EF16 RID: 126742 RVA: 0x00921A26 File Offset: 0x0091FC26
		// (set) Token: 0x0601EF17 RID: 126743 RVA: 0x00921A36 File Offset: 0x0091FC36
		public unsafe bool DissolveRevertProperty_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_DissolveRevertProperty) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_DissolveRevertProperty) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003685 RID: 13957
		// (get) Token: 0x0601EF18 RID: 126744 RVA: 0x00921A47 File Offset: 0x0091FC47
		// (set) Token: 0x0601EF19 RID: 126745 RVA: 0x00921A5B File Offset: 0x0091FC5B
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharacterControllerChannelSwitch> DissolveChannel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_DissolveChannel);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_DissolveChannel) = value;
			}
		}

		// Token: 0x17003686 RID: 13958
		// (get) Token: 0x0601EF1A RID: 126746 RVA: 0x00921A70 File Offset: 0x0091FC70
		// (set) Token: 0x0601EF1B RID: 126747 RVA: 0x00921AA9 File Offset: 0x0091FCA9
		public SMaterialControllerFloatGroup DissolveProgress
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._DissolveProgress) == null)
				{
					result = (this._DissolveProgress = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_DissolveProgress, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_DissolveProgress, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003687 RID: 13959
		// (get) Token: 0x0601EF1C RID: 126748 RVA: 0x00921ACC File Offset: 0x0091FCCC
		// (set) Token: 0x0601EF1D RID: 126749 RVA: 0x00921B05 File Offset: 0x0091FD05
		public SMaterialControllerColorGroup DissolveColor
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerColorGroup result;
				if ((result = this._DissolveColor) == null)
				{
					result = (this._DissolveColor = new SMaterialControllerColorGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_DissolveColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_DissolveColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003688 RID: 13960
		// (get) Token: 0x0601EF1E RID: 126750 RVA: 0x00921B28 File Offset: 0x0091FD28
		// (set) Token: 0x0601EF1F RID: 126751 RVA: 0x00921B61 File Offset: 0x0091FD61
		public SMaterialControllerFloatGroup DissolveColorIntensity
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._DissolveColorIntensity) == null)
				{
					result = (this._DissolveColorIntensity = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_DissolveColorIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_DissolveColorIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003689 RID: 13961
		// (get) Token: 0x0601EF20 RID: 126752 RVA: 0x00921B82 File Offset: 0x0091FD82
		// (set) Token: 0x0601EF21 RID: 126753 RVA: 0x00921B92 File Offset: 0x0091FD92
		public unsafe bool UseTextureSample
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseTextureSample) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseTextureSample) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700368A RID: 13962
		// (get) Token: 0x0601EF22 RID: 126754 RVA: 0x00921BA3 File Offset: 0x0091FDA3
		// (set) Token: 0x0601EF23 RID: 126755 RVA: 0x00921BB3 File Offset: 0x0091FDB3
		public unsafe bool TextureSampleRevertProperty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_TextureSampleRevertProperty) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_TextureSampleRevertProperty) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700368B RID: 13963
		// (get) Token: 0x0601EF24 RID: 126756 RVA: 0x00921BC4 File Offset: 0x0091FDC4
		// (set) Token: 0x0601EF25 RID: 126757 RVA: 0x00921BD4 File Offset: 0x0091FDD4
		public unsafe bool UseAlphaToMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseAlphaToMask) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseAlphaToMask) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700368C RID: 13964
		// (get) Token: 0x0601EF26 RID: 126758 RVA: 0x00921BE5 File Offset: 0x0091FDE5
		// (set) Token: 0x0601EF27 RID: 126759 RVA: 0x00921BF9 File Offset: 0x0091FDF9
		[Nullable(2)]
		public unsafe UTexture2D MaskTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + PD_CharacterControllerData_C.__PropertyOffset_MaskTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_CharacterControllerData_C.__PropertyOffset_MaskTexture, value);
			}
		}

		// Token: 0x1700368D RID: 13965
		// (get) Token: 0x0601EF28 RID: 126760 RVA: 0x00921C10 File Offset: 0x0091FE10
		// (set) Token: 0x0601EF29 RID: 126761 RVA: 0x00921C49 File Offset: 0x0091FE49
		public SMaterialControllerFloatGroup Rotation
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_Rotation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_Rotation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700368E RID: 13966
		// (get) Token: 0x0601EF2A RID: 126762 RVA: 0x00921C6A File Offset: 0x0091FE6A
		// (set) Token: 0x0601EF2B RID: 126763 RVA: 0x00921C7E File Offset: 0x0091FE7E
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharacterControllerUVSwitch> UVSelection
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UVSelection);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UVSelection) = value;
			}
		}

		// Token: 0x1700368F RID: 13967
		// (get) Token: 0x0601EF2C RID: 126764 RVA: 0x00921C94 File Offset: 0x0091FE94
		// (set) Token: 0x0601EF2D RID: 126765 RVA: 0x00921CCD File Offset: 0x0091FECD
		public SMaterialControllerColorGroup TextureScaleAndOffset
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerColorGroup result;
				if ((result = this._TextureScaleAndOffset) == null)
				{
					result = (this._TextureScaleAndOffset = new SMaterialControllerColorGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_TextureScaleAndOffset, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_TextureScaleAndOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003690 RID: 13968
		// (get) Token: 0x0601EF2E RID: 126766 RVA: 0x00921CF0 File Offset: 0x0091FEF0
		// (set) Token: 0x0601EF2F RID: 126767 RVA: 0x00921D29 File Offset: 0x0091FF29
		public SMaterialControllerColorGroup TextureSpeed
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerColorGroup result;
				if ((result = this._TextureSpeed) == null)
				{
					result = (this._TextureSpeed = new SMaterialControllerColorGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_TextureSpeed, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_TextureSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003691 RID: 13969
		// (get) Token: 0x0601EF30 RID: 126768 RVA: 0x00921D4C File Offset: 0x0091FF4C
		// (set) Token: 0x0601EF31 RID: 126769 RVA: 0x00921D85 File Offset: 0x0091FF85
		public SMaterialControllerColorGroup TextureColorTint
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerColorGroup result;
				if ((result = this._TextureColorTint) == null)
				{
					result = (this._TextureColorTint = new SMaterialControllerColorGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_TextureColorTint, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_TextureColorTint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003692 RID: 13970
		// (get) Token: 0x0601EF32 RID: 126770 RVA: 0x00921DA8 File Offset: 0x0091FFA8
		// (set) Token: 0x0601EF33 RID: 126771 RVA: 0x00921DE1 File Offset: 0x0091FFE1
		public SMaterialControllerFloatGroup OutlineIntensity
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._OutlineIntensity) == null)
				{
					result = (this._OutlineIntensity = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_OutlineIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_OutlineIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003693 RID: 13971
		// (get) Token: 0x0601EF34 RID: 126772 RVA: 0x00921E02 File Offset: 0x00920002
		// (set) Token: 0x0601EF35 RID: 126773 RVA: 0x00921E12 File Offset: 0x00920012
		public unsafe bool UseOuterOutlineEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseOuterOutlineEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseOuterOutlineEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003694 RID: 13972
		// (get) Token: 0x0601EF36 RID: 126774 RVA: 0x00921E23 File Offset: 0x00920023
		// (set) Token: 0x0601EF37 RID: 126775 RVA: 0x00921E33 File Offset: 0x00920033
		public unsafe bool UseParameterModify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseParameterModify) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseParameterModify) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003695 RID: 13973
		// (get) Token: 0x0601EF38 RID: 126776 RVA: 0x00921E44 File Offset: 0x00920044
		// (set) Token: 0x0601EF39 RID: 126777 RVA: 0x00921E7D File Offset: 0x0092007D
		public TArray<SMaterialControllerFloatParameter> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SMaterialControllerFloatParameter> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TArray<SMaterialControllerFloatParameter>(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_FloatParameters, this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17003696 RID: 13974
		// (get) Token: 0x0601EF3A RID: 126778 RVA: 0x00921E8B File Offset: 0x0092008B
		// (set) Token: 0x0601EF3B RID: 126779 RVA: 0x00921E9B File Offset: 0x0092009B
		public unsafe bool UseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003697 RID: 13975
		// (get) Token: 0x0601EF3C RID: 126780 RVA: 0x00921EAC File Offset: 0x009200AC
		// (set) Token: 0x0601EF3D RID: 126781 RVA: 0x00921EBC File Offset: 0x009200BC
		public unsafe bool ColorRevertProperty_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_ColorRevertProperty) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_ColorRevertProperty) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003698 RID: 13976
		// (get) Token: 0x0601EF3E RID: 126782 RVA: 0x00921ECD File Offset: 0x009200CD
		// (set) Token: 0x0601EF3F RID: 126783 RVA: 0x00921EDD File Offset: 0x009200DD
		public unsafe bool BaseUseTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_BaseUseTex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_BaseUseTex) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003699 RID: 13977
		// (get) Token: 0x0601EF40 RID: 126784 RVA: 0x00921EF0 File Offset: 0x009200F0
		// (set) Token: 0x0601EF41 RID: 126785 RVA: 0x00921F29 File Offset: 0x00920129
		public SMaterialControllerColorGroup BaseColor
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerColorGroup result;
				if ((result = this._BaseColor) == null)
				{
					result = (this._BaseColor = new SMaterialControllerColorGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_BaseColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_BaseColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700369A RID: 13978
		// (get) Token: 0x0601EF42 RID: 126786 RVA: 0x00921F4C File Offset: 0x0092014C
		// (set) Token: 0x0601EF43 RID: 126787 RVA: 0x00921F85 File Offset: 0x00920185
		public SMaterialControllerFloatGroup BaseColorIntensity
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._BaseColorIntensity) == null)
				{
					result = (this._BaseColorIntensity = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_BaseColorIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_BaseColorIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700369B RID: 13979
		// (get) Token: 0x0601EF44 RID: 126788 RVA: 0x00921FA6 File Offset: 0x009201A6
		// (set) Token: 0x0601EF45 RID: 126789 RVA: 0x00921FB6 File Offset: 0x009201B6
		public unsafe bool EmissionUseTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_EmissionUseTex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_EmissionUseTex) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700369C RID: 13980
		// (get) Token: 0x0601EF46 RID: 126790 RVA: 0x00921FC8 File Offset: 0x009201C8
		// (set) Token: 0x0601EF47 RID: 126791 RVA: 0x00922001 File Offset: 0x00920201
		public SMaterialControllerColorGroup EmissionColor
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerColorGroup result;
				if ((result = this._EmissionColor) == null)
				{
					result = (this._EmissionColor = new SMaterialControllerColorGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_EmissionColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_EmissionColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700369D RID: 13981
		// (get) Token: 0x0601EF48 RID: 126792 RVA: 0x00922024 File Offset: 0x00920224
		// (set) Token: 0x0601EF49 RID: 126793 RVA: 0x0092205D File Offset: 0x0092025D
		public SMaterialControllerFloatGroup EmissionIntensity
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._EmissionIntensity) == null)
				{
					result = (this._EmissionIntensity = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_EmissionIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_EmissionIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700369E RID: 13982
		// (get) Token: 0x0601EF4A RID: 126794 RVA: 0x00922080 File Offset: 0x00920280
		// (set) Token: 0x0601EF4B RID: 126795 RVA: 0x009220B9 File Offset: 0x009202B9
		public TArray<SMaterialControllerColorParameter> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SMaterialControllerColorParameter> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TArray<SMaterialControllerColorParameter>(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_ColorParameters, this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x1700369F RID: 13983
		// (get) Token: 0x0601EF4C RID: 126796 RVA: 0x009220C7 File Offset: 0x009202C7
		// (set) Token: 0x0601EF4D RID: 126797 RVA: 0x009220D7 File Offset: 0x009202D7
		public unsafe bool UseCustomMaterialEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseCustomMaterialEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseCustomMaterialEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036A0 RID: 13984
		// (get) Token: 0x0601EF4E RID: 126798 RVA: 0x009220E8 File Offset: 0x009202E8
		// (set) Token: 0x0601EF4F RID: 126799 RVA: 0x009220F8 File Offset: 0x009202F8
		public unsafe bool CustomRevertProperty_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_CustomRevertProperty) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_CustomRevertProperty) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036A1 RID: 13985
		// (get) Token: 0x0601EF50 RID: 126800 RVA: 0x0092210C File Offset: 0x0092030C
		// (set) Token: 0x0601EF51 RID: 126801 RVA: 0x00922145 File Offset: 0x00920345
		public TArray<SMaterialControllerFloatParameter> CustomFloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SMaterialControllerFloatParameter> result;
				if ((result = this._CustomFloatParameters) == null)
				{
					result = (this._CustomFloatParameters = new TArray<SMaterialControllerFloatParameter>(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_CustomFloatParameters, this));
				}
				return result;
			}
			set
			{
				this.CustomFloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x170036A2 RID: 13986
		// (get) Token: 0x0601EF52 RID: 126802 RVA: 0x00922154 File Offset: 0x00920354
		// (set) Token: 0x0601EF53 RID: 126803 RVA: 0x0092218D File Offset: 0x0092038D
		public TArray<SMaterialControllerColorParameter> CustomColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SMaterialControllerColorParameter> result;
				if ((result = this._CustomColorParameters) == null)
				{
					result = (this._CustomColorParameters = new TArray<SMaterialControllerColorParameter>(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_CustomColorParameters, this));
				}
				return result;
			}
			set
			{
				this.CustomColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x170036A3 RID: 13987
		// (get) Token: 0x0601EF54 RID: 126804 RVA: 0x0092219C File Offset: 0x0092039C
		// (set) Token: 0x0601EF55 RID: 126805 RVA: 0x009221D5 File Offset: 0x009203D5
		public TArray<SMaterialControllerTextureParameter> CustomTextureParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SMaterialControllerTextureParameter> result;
				if ((result = this._CustomTextureParameters) == null)
				{
					result = (this._CustomTextureParameters = new TArray<SMaterialControllerTextureParameter>(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_CustomTextureParameters, this));
				}
				return result;
			}
			set
			{
				this.CustomTextureParameters.CopyAssign(value);
			}
		}

		// Token: 0x170036A4 RID: 13988
		// (get) Token: 0x0601EF56 RID: 126806 RVA: 0x009221E3 File Offset: 0x009203E3
		// (set) Token: 0x0601EF57 RID: 126807 RVA: 0x009221F3 File Offset: 0x009203F3
		public unsafe bool UseMotionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseMotionOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseMotionOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036A5 RID: 13989
		// (get) Token: 0x0601EF58 RID: 126808 RVA: 0x00922204 File Offset: 0x00920404
		// (set) Token: 0x0601EF59 RID: 126809 RVA: 0x00922214 File Offset: 0x00920414
		public unsafe bool MotionOffsetRevertProperty_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_MotionOffsetRevertProperty) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_MotionOffsetRevertProperty) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036A6 RID: 13990
		// (get) Token: 0x0601EF5A RID: 126810 RVA: 0x00922225 File Offset: 0x00920425
		// (set) Token: 0x0601EF5B RID: 126811 RVA: 0x00922235 File Offset: 0x00920435
		public unsafe float MotionOffsetLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_MotionOffsetLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_MotionOffsetLength) = value;
			}
		}

		// Token: 0x170036A7 RID: 13991
		// (get) Token: 0x0601EF5C RID: 126812 RVA: 0x00922246 File Offset: 0x00920446
		// (set) Token: 0x0601EF5D RID: 126813 RVA: 0x00922256 File Offset: 0x00920456
		public unsafe float MotionAffectVertexRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_MotionAffectVertexRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_MotionAffectVertexRange) = value;
			}
		}

		// Token: 0x170036A8 RID: 13992
		// (get) Token: 0x0601EF5E RID: 126814 RVA: 0x00922268 File Offset: 0x00920468
		// (set) Token: 0x0601EF5F RID: 126815 RVA: 0x009222A1 File Offset: 0x009204A1
		public TArray<string> WeaponCases
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._WeaponCases) == null)
				{
					result = (this._WeaponCases = new TArray<string>(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_WeaponCases, this));
				}
				return result;
			}
			set
			{
				this.WeaponCases.CopyAssign(value);
			}
		}

		// Token: 0x170036A9 RID: 13993
		// (get) Token: 0x0601EF60 RID: 126816 RVA: 0x009222AF File Offset: 0x009204AF
		// (set) Token: 0x0601EF61 RID: 126817 RVA: 0x009222BF File Offset: 0x009204BF
		public unsafe bool IgnoreTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_IgnoreTimeDilation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_IgnoreTimeDilation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036AA RID: 13994
		// (get) Token: 0x0601EF62 RID: 126818 RVA: 0x009222D0 File Offset: 0x009204D0
		// (set) Token: 0x0601EF63 RID: 126819 RVA: 0x009222E0 File Offset: 0x009204E0
		public unsafe bool HiddenAfterEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_HiddenAfterEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_HiddenAfterEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036AB RID: 13995
		// (get) Token: 0x0601EF64 RID: 126820 RVA: 0x009222F4 File Offset: 0x009204F4
		// (set) Token: 0x0601EF65 RID: 126821 RVA: 0x0092232D File Offset: 0x0092052D
		public SMaterialControllerFloatGroup DissolveSmooth
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._DissolveSmooth) == null)
				{
					result = (this._DissolveSmooth = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_DissolveSmooth, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_DissolveSmooth, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170036AC RID: 13996
		// (get) Token: 0x0601EF66 RID: 126822 RVA: 0x00922350 File Offset: 0x00920550
		// (set) Token: 0x0601EF67 RID: 126823 RVA: 0x00922389 File Offset: 0x00920589
		public SMaterialControllerFloatGroup MotionNoiseSpeed
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._MotionNoiseSpeed) == null)
				{
					result = (this._MotionNoiseSpeed = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_MotionNoiseSpeed, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_MotionNoiseSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170036AD RID: 13997
		// (get) Token: 0x0601EF68 RID: 126824 RVA: 0x009223AA File Offset: 0x009205AA
		// (set) Token: 0x0601EF69 RID: 126825 RVA: 0x009223BA File Offset: 0x009205BA
		public unsafe bool UseDitherEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseDitherEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UseDitherEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036AE RID: 13998
		// (get) Token: 0x0601EF6A RID: 126826 RVA: 0x009223CB File Offset: 0x009205CB
		// (set) Token: 0x0601EF6B RID: 126827 RVA: 0x009223DB File Offset: 0x009205DB
		public unsafe bool DitherRevertProperty_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_DitherRevertProperty) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_DitherRevertProperty) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036AF RID: 13999
		// (get) Token: 0x0601EF6C RID: 126828 RVA: 0x009223EC File Offset: 0x009205EC
		// (set) Token: 0x0601EF6D RID: 126829 RVA: 0x00922425 File Offset: 0x00920625
		public SMaterialControllerFloatGroup DitherValue
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._DitherValue) == null)
				{
					result = (this._DitherValue = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_DitherValue, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_DitherValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170036B0 RID: 14000
		// (get) Token: 0x0601EF6E RID: 126830 RVA: 0x00922448 File Offset: 0x00920648
		// (set) Token: 0x0601EF6F RID: 126831 RVA: 0x00922481 File Offset: 0x00920681
		public TArray<string> OtherCases
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._OtherCases) == null)
				{
					result = (this._OtherCases = new TArray<string>(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_OtherCases, this));
				}
				return result;
			}
			set
			{
				this.OtherCases.CopyAssign(value);
			}
		}

		// Token: 0x170036B1 RID: 14001
		// (get) Token: 0x0601EF70 RID: 126832 RVA: 0x00922490 File Offset: 0x00920690
		// (set) Token: 0x0601EF71 RID: 126833 RVA: 0x009224C9 File Offset: 0x009206C9
		public SMaterialControllerFloatGroup RimIntensity
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._RimIntensity) == null)
				{
					result = (this._RimIntensity = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_RimIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_RimIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170036B2 RID: 14002
		// (get) Token: 0x0601EF72 RID: 126834 RVA: 0x009224EC File Offset: 0x009206EC
		// (set) Token: 0x0601EF73 RID: 126835 RVA: 0x00922525 File Offset: 0x00920725
		public TArray<string> CustomPartNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._CustomPartNames) == null)
				{
					result = (this._CustomPartNames = new TArray<string>(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_CustomPartNames, this));
				}
				return result;
			}
			set
			{
				this.CustomPartNames.CopyAssign(value);
			}
		}

		// Token: 0x170036B3 RID: 14003
		// (get) Token: 0x0601EF74 RID: 126836 RVA: 0x00922534 File Offset: 0x00920734
		// (set) Token: 0x0601EF75 RID: 126837 RVA: 0x0092256D File Offset: 0x0092076D
		public SMaterialControllerFloatGroup TextureMaskRange
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._TextureMaskRange) == null)
				{
					result = (this._TextureMaskRange = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_TextureMaskRange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_TextureMaskRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170036B4 RID: 14004
		// (get) Token: 0x0601EF76 RID: 126838 RVA: 0x0092258E File Offset: 0x0092078E
		// (set) Token: 0x0601EF77 RID: 126839 RVA: 0x0092259E File Offset: 0x0092079E
		public unsafe bool MaskOriginEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_MaskOriginEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_MaskOriginEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036B5 RID: 14005
		// (get) Token: 0x0601EF78 RID: 126840 RVA: 0x009225AF File Offset: 0x009207AF
		// (set) Token: 0x0601EF79 RID: 126841 RVA: 0x009225BF File Offset: 0x009207BF
		public unsafe bool UpdateAtLeastOneFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UpdateAtLeastOneFrame) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_UpdateAtLeastOneFrame) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036B6 RID: 14006
		// (get) Token: 0x0601EF7A RID: 126842 RVA: 0x009225D0 File Offset: 0x009207D0
		// (set) Token: 0x0601EF7B RID: 126843 RVA: 0x00922609 File Offset: 0x00920809
		public TArray<string> CustomExcludePartNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._CustomExcludePartNames) == null)
				{
					result = (this._CustomExcludePartNames = new TArray<string>(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_CustomExcludePartNames, this));
				}
				return result;
			}
			set
			{
				this.CustomExcludePartNames.CopyAssign(value);
			}
		}

		// Token: 0x170036B7 RID: 14007
		// (get) Token: 0x0601EF7C RID: 126844 RVA: 0x00922617 File Offset: 0x00920817
		// (set) Token: 0x0601EF7D RID: 126845 RVA: 0x00922627 File Offset: 0x00920827
		public unsafe bool ForceUpdateOnAdd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_ForceUpdateOnAdd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_ForceUpdateOnAdd) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036B8 RID: 14008
		// (get) Token: 0x0601EF7E RID: 126846 RVA: 0x00922638 File Offset: 0x00920838
		// (set) Token: 0x0601EF7F RID: 126847 RVA: 0x00922648 File Offset: 0x00920848
		public unsafe bool MobileUseDifferentMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_MobileUseDifferentMaterial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_MobileUseDifferentMaterial) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036B9 RID: 14009
		// (get) Token: 0x0601EF80 RID: 126848 RVA: 0x00922659 File Offset: 0x00920859
		// (set) Token: 0x0601EF81 RID: 126849 RVA: 0x00922669 File Offset: 0x00920869
		public unsafe bool OnlyApplyOnLocalPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_OnlyApplyOnLocalPlayer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_OnlyApplyOnLocalPlayer) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036BA RID: 14010
		// (get) Token: 0x0601EF82 RID: 126850 RVA: 0x0092267A File Offset: 0x0092087A
		// (set) Token: 0x0601EF83 RID: 126851 RVA: 0x0092268A File Offset: 0x0092088A
		public unsafe bool NeverApplyOnLocalPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_NeverApplyOnLocalPlayer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_NeverApplyOnLocalPlayer) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601EF84 RID: 126852 RVA: 0x0092269B File Offset: 0x0092089B
		[SkipLocalsInit]
		public virtual void InitCache()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_CharacterControllerData_C.__InitCache_NativeFunctionPtr, null);
		}

		// Token: 0x0601EF85 RID: 126853 RVA: 0x009226AF File Offset: 0x009208AF
		protected PD_CharacterControllerData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010762 RID: 67426
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CharacterControllerData.PD_CharacterControllerData_C";

		// Token: 0x04010763 RID: 67427
		private static IntPtr _ClassPtr;

		// Token: 0x04010764 RID: 67428
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010765 RID: 67429
		internal static int __PropertyOffset_DataType;

		// Token: 0x04010766 RID: 67430
		internal static int __PropertyOffset_SpecifiedBodyType;

		// Token: 0x04010767 RID: 67431
		internal static int __PropertyOffset_SpecifiedParts;

		// Token: 0x04010768 RID: 67432
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<ECharacterMeshPart>> _SpecifiedParts;

		// Token: 0x04010769 RID: 67433
		internal static int __PropertyOffset_SpecifiedSlotType;

		// Token: 0x0401076A RID: 67434
		internal static int __PropertyOffset_MaterialModifyType;

		// Token: 0x0401076B RID: 67435
		internal static int __PropertyOffset_ReplaceMaterial;

		// Token: 0x0401076C RID: 67436
		internal static int __PropertyOffset_ReplaceMaterialMobile;

		// Token: 0x0401076D RID: 67437
		internal static int __PropertyOffset_RevertMaterial;

		// Token: 0x0401076E RID: 67438
		internal static int __PropertyOffset_UseRim;

		// Token: 0x0401076F RID: 67439
		internal static int __PropertyOffset_UseOutline;

		// Token: 0x04010770 RID: 67440
		internal static int __PropertyOffset_OutlineRevertProperty;

		// Token: 0x04010771 RID: 67441
		internal static int __PropertyOffset_UseDissolve;

		// Token: 0x04010772 RID: 67442
		internal static int __PropertyOffset_LoopTime;

		// Token: 0x04010773 RID: 67443
		internal static int __PropertyOffset_RimRevertProperty;

		// Token: 0x04010774 RID: 67444
		internal static int __PropertyOffset_RimUseTex;

		// Token: 0x04010775 RID: 67445
		internal static int __PropertyOffset_RimChannel;

		// Token: 0x04010776 RID: 67446
		internal static int __PropertyOffset_RimRange;

		// Token: 0x04010777 RID: 67447
		[Nullable(2)]
		private SMaterialControllerFloatGroup _RimRange;

		// Token: 0x04010778 RID: 67448
		internal static int __PropertyOffset_RimColor;

		// Token: 0x04010779 RID: 67449
		[Nullable(2)]
		private SMaterialControllerColorGroup _RimColor;

		// Token: 0x0401077A RID: 67450
		internal static int __PropertyOffset_OutlineUseTex;

		// Token: 0x0401077B RID: 67451
		internal static int __PropertyOffset_OutlineWidth;

		// Token: 0x0401077C RID: 67452
		[Nullable(2)]
		private SMaterialControllerFloatGroup _OutlineWidth;

		// Token: 0x0401077D RID: 67453
		internal static int __PropertyOffset_OutlineColor;

		// Token: 0x0401077E RID: 67454
		[Nullable(2)]
		private SMaterialControllerColorGroup _OutlineColor;

		// Token: 0x0401077F RID: 67455
		internal static int __PropertyOffset_DissolveRevertProperty;

		// Token: 0x04010780 RID: 67456
		internal static int __PropertyOffset_DissolveChannel;

		// Token: 0x04010781 RID: 67457
		internal static int __PropertyOffset_DissolveProgress;

		// Token: 0x04010782 RID: 67458
		[Nullable(2)]
		private SMaterialControllerFloatGroup _DissolveProgress;

		// Token: 0x04010783 RID: 67459
		internal static int __PropertyOffset_DissolveColor;

		// Token: 0x04010784 RID: 67460
		[Nullable(2)]
		private SMaterialControllerColorGroup _DissolveColor;

		// Token: 0x04010785 RID: 67461
		internal static int __PropertyOffset_DissolveColorIntensity;

		// Token: 0x04010786 RID: 67462
		[Nullable(2)]
		private SMaterialControllerFloatGroup _DissolveColorIntensity;

		// Token: 0x04010787 RID: 67463
		internal static int __PropertyOffset_UseTextureSample;

		// Token: 0x04010788 RID: 67464
		internal static int __PropertyOffset_TextureSampleRevertProperty;

		// Token: 0x04010789 RID: 67465
		internal static int __PropertyOffset_UseAlphaToMask;

		// Token: 0x0401078A RID: 67466
		internal static int __PropertyOffset_MaskTexture;

		// Token: 0x0401078B RID: 67467
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0401078C RID: 67468
		[Nullable(2)]
		private SMaterialControllerFloatGroup _Rotation;

		// Token: 0x0401078D RID: 67469
		internal static int __PropertyOffset_UVSelection;

		// Token: 0x0401078E RID: 67470
		internal static int __PropertyOffset_TextureScaleAndOffset;

		// Token: 0x0401078F RID: 67471
		[Nullable(2)]
		private SMaterialControllerColorGroup _TextureScaleAndOffset;

		// Token: 0x04010790 RID: 67472
		internal static int __PropertyOffset_TextureSpeed;

		// Token: 0x04010791 RID: 67473
		[Nullable(2)]
		private SMaterialControllerColorGroup _TextureSpeed;

		// Token: 0x04010792 RID: 67474
		internal static int __PropertyOffset_TextureColorTint;

		// Token: 0x04010793 RID: 67475
		[Nullable(2)]
		private SMaterialControllerColorGroup _TextureColorTint;

		// Token: 0x04010794 RID: 67476
		internal static int __PropertyOffset_OutlineIntensity;

		// Token: 0x04010795 RID: 67477
		[Nullable(2)]
		private SMaterialControllerFloatGroup _OutlineIntensity;

		// Token: 0x04010796 RID: 67478
		internal static int __PropertyOffset_UseOuterOutlineEffect;

		// Token: 0x04010797 RID: 67479
		internal static int __PropertyOffset_UseParameterModify;

		// Token: 0x04010798 RID: 67480
		internal static int __PropertyOffset_FloatParameters;

		// Token: 0x04010799 RID: 67481
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SMaterialControllerFloatParameter> _FloatParameters;

		// Token: 0x0401079A RID: 67482
		internal static int __PropertyOffset_UseColor;

		// Token: 0x0401079B RID: 67483
		internal static int __PropertyOffset_ColorRevertProperty;

		// Token: 0x0401079C RID: 67484
		internal static int __PropertyOffset_BaseUseTex;

		// Token: 0x0401079D RID: 67485
		internal static int __PropertyOffset_BaseColor;

		// Token: 0x0401079E RID: 67486
		[Nullable(2)]
		private SMaterialControllerColorGroup _BaseColor;

		// Token: 0x0401079F RID: 67487
		internal static int __PropertyOffset_BaseColorIntensity;

		// Token: 0x040107A0 RID: 67488
		[Nullable(2)]
		private SMaterialControllerFloatGroup _BaseColorIntensity;

		// Token: 0x040107A1 RID: 67489
		internal static int __PropertyOffset_EmissionUseTex;

		// Token: 0x040107A2 RID: 67490
		internal static int __PropertyOffset_EmissionColor;

		// Token: 0x040107A3 RID: 67491
		[Nullable(2)]
		private SMaterialControllerColorGroup _EmissionColor;

		// Token: 0x040107A4 RID: 67492
		internal static int __PropertyOffset_EmissionIntensity;

		// Token: 0x040107A5 RID: 67493
		[Nullable(2)]
		private SMaterialControllerFloatGroup _EmissionIntensity;

		// Token: 0x040107A6 RID: 67494
		internal static int __PropertyOffset_ColorParameters;

		// Token: 0x040107A7 RID: 67495
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SMaterialControllerColorParameter> _ColorParameters;

		// Token: 0x040107A8 RID: 67496
		internal static int __PropertyOffset_UseCustomMaterialEffect;

		// Token: 0x040107A9 RID: 67497
		internal static int __PropertyOffset_CustomRevertProperty;

		// Token: 0x040107AA RID: 67498
		internal static int __PropertyOffset_CustomFloatParameters;

		// Token: 0x040107AB RID: 67499
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SMaterialControllerFloatParameter> _CustomFloatParameters;

		// Token: 0x040107AC RID: 67500
		internal static int __PropertyOffset_CustomColorParameters;

		// Token: 0x040107AD RID: 67501
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SMaterialControllerColorParameter> _CustomColorParameters;

		// Token: 0x040107AE RID: 67502
		internal static int __PropertyOffset_CustomTextureParameters;

		// Token: 0x040107AF RID: 67503
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SMaterialControllerTextureParameter> _CustomTextureParameters;

		// Token: 0x040107B0 RID: 67504
		internal static int __PropertyOffset_UseMotionOffset;

		// Token: 0x040107B1 RID: 67505
		internal static int __PropertyOffset_MotionOffsetRevertProperty;

		// Token: 0x040107B2 RID: 67506
		internal static int __PropertyOffset_MotionOffsetLength;

		// Token: 0x040107B3 RID: 67507
		internal static int __PropertyOffset_MotionAffectVertexRange;

		// Token: 0x040107B4 RID: 67508
		internal static int __PropertyOffset_WeaponCases;

		// Token: 0x040107B5 RID: 67509
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _WeaponCases;

		// Token: 0x040107B6 RID: 67510
		internal static int __PropertyOffset_IgnoreTimeDilation;

		// Token: 0x040107B7 RID: 67511
		internal static int __PropertyOffset_HiddenAfterEffect;

		// Token: 0x040107B8 RID: 67512
		internal static int __PropertyOffset_DissolveSmooth;

		// Token: 0x040107B9 RID: 67513
		[Nullable(2)]
		private SMaterialControllerFloatGroup _DissolveSmooth;

		// Token: 0x040107BA RID: 67514
		internal static int __PropertyOffset_MotionNoiseSpeed;

		// Token: 0x040107BB RID: 67515
		[Nullable(2)]
		private SMaterialControllerFloatGroup _MotionNoiseSpeed;

		// Token: 0x040107BC RID: 67516
		internal static int __PropertyOffset_UseDitherEffect;

		// Token: 0x040107BD RID: 67517
		internal static int __PropertyOffset_DitherRevertProperty;

		// Token: 0x040107BE RID: 67518
		internal static int __PropertyOffset_DitherValue;

		// Token: 0x040107BF RID: 67519
		[Nullable(2)]
		private SMaterialControllerFloatGroup _DitherValue;

		// Token: 0x040107C0 RID: 67520
		internal static int __PropertyOffset_OtherCases;

		// Token: 0x040107C1 RID: 67521
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _OtherCases;

		// Token: 0x040107C2 RID: 67522
		internal static int __PropertyOffset_RimIntensity;

		// Token: 0x040107C3 RID: 67523
		[Nullable(2)]
		private SMaterialControllerFloatGroup _RimIntensity;

		// Token: 0x040107C4 RID: 67524
		internal static int __PropertyOffset_CustomPartNames;

		// Token: 0x040107C5 RID: 67525
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _CustomPartNames;

		// Token: 0x040107C6 RID: 67526
		internal static int __PropertyOffset_TextureMaskRange;

		// Token: 0x040107C7 RID: 67527
		[Nullable(2)]
		private SMaterialControllerFloatGroup _TextureMaskRange;

		// Token: 0x040107C8 RID: 67528
		internal static int __PropertyOffset_MaskOriginEffect;

		// Token: 0x040107C9 RID: 67529
		internal static int __PropertyOffset_UpdateAtLeastOneFrame;

		// Token: 0x040107CA RID: 67530
		internal static int __PropertyOffset_CustomExcludePartNames;

		// Token: 0x040107CB RID: 67531
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _CustomExcludePartNames;

		// Token: 0x040107CC RID: 67532
		internal static int __PropertyOffset_ForceUpdateOnAdd;

		// Token: 0x040107CD RID: 67533
		internal static int __PropertyOffset_MobileUseDifferentMaterial;

		// Token: 0x040107CE RID: 67534
		internal static int __PropertyOffset_OnlyApplyOnLocalPlayer;

		// Token: 0x040107CF RID: 67535
		internal static int __PropertyOffset_NeverApplyOnLocalPlayer;

		// Token: 0x040107D0 RID: 67536
		private static IntPtr __InitCache_NativeFunctionPtr;
	}
}
