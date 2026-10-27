using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003E15 RID: 15893
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CharacterControllerData.PD_CharacterControllerData_C")]
	[UnrealStructLayout(22168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 22164)]
	public class PD_CharacterControllerData_C : UKuroMaterialControllerDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027CDA RID: 163034 RVA: 0x0099B972 File Offset: 0x00999B72
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_CharacterControllerData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CharacterControllerData.PD_CharacterControllerData_C");
			}
			return PD_CharacterControllerData_C._ClassPtr;
		}

		// Token: 0x06027CDB RID: 163035 RVA: 0x0099B998 File Offset: 0x00999B98
		public PD_CharacterControllerData_C() : this(BuiltinUtils.AllocNativeUObject(PD_CharacterControllerData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027CDC RID: 163036 RVA: 0x0099B9C0 File Offset: 0x00999BC0
		public PD_CharacterControllerData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_CharacterControllerData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005A23 RID: 23075
		// (get) Token: 0x06027CDD RID: 163037 RVA: 0x0099B9F3 File Offset: 0x00999BF3
		// (set) Token: 0x06027CDE RID: 163038 RVA: 0x0099BA07 File Offset: 0x00999C07
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharacterControllerType> DataType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_0);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005A24 RID: 23076
		// (get) Token: 0x06027CDF RID: 163039 RVA: 0x0099BA1C File Offset: 0x00999C1C
		// (set) Token: 0x06027CE0 RID: 163040 RVA: 0x0099BA30 File Offset: 0x00999C30
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharacterBodySpecifiedType> SpecifiedBodyType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_1);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005A25 RID: 23077
		// (get) Token: 0x06027CE1 RID: 163041 RVA: 0x0099BA48 File Offset: 0x00999C48
		// (set) Token: 0x06027CE2 RID: 163042 RVA: 0x0099BA81 File Offset: 0x00999C81
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
					result = (this._SpecifiedParts = new TArray<TEnumAsByte<ECharacterMeshPart>>(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_2, this));
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

		// Token: 0x17005A26 RID: 23078
		// (get) Token: 0x06027CE3 RID: 163043 RVA: 0x0099BA8F File Offset: 0x00999C8F
		// (set) Token: 0x06027CE4 RID: 163044 RVA: 0x0099BAA3 File Offset: 0x00999CA3
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharacterSlotSpecifiedType> SpecifiedSlotType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_3);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005A27 RID: 23079
		// (get) Token: 0x06027CE5 RID: 163045 RVA: 0x0099BAB8 File Offset: 0x00999CB8
		// (set) Token: 0x06027CE6 RID: 163046 RVA: 0x0099BACC File Offset: 0x00999CCC
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharacterControllerApplyType> MaterialModifyType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_4);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005A28 RID: 23080
		// (get) Token: 0x06027CE7 RID: 163047 RVA: 0x0099BAE1 File Offset: 0x00999CE1
		// (set) Token: 0x06027CE8 RID: 163048 RVA: 0x0099BAF5 File Offset: 0x00999CF5
		[Nullable(2)]
		public unsafe UMaterialInterface ReplaceMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + PD_CharacterControllerData_C.__PropertyOffset_5);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_CharacterControllerData_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005A29 RID: 23081
		// (get) Token: 0x06027CE9 RID: 163049 RVA: 0x0099BB0A File Offset: 0x00999D0A
		// (set) Token: 0x06027CEA RID: 163050 RVA: 0x0099BB1E File Offset: 0x00999D1E
		[Nullable(2)]
		public unsafe UMaterialInterface ReplaceMaterialMobile
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + PD_CharacterControllerData_C.__PropertyOffset_6);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_CharacterControllerData_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005A2A RID: 23082
		// (get) Token: 0x06027CEB RID: 163051 RVA: 0x0099BB33 File Offset: 0x00999D33
		// (set) Token: 0x06027CEC RID: 163052 RVA: 0x0099BB43 File Offset: 0x00999D43
		public unsafe bool RevertMaterial_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A2B RID: 23083
		// (get) Token: 0x06027CED RID: 163053 RVA: 0x0099BB54 File Offset: 0x00999D54
		// (set) Token: 0x06027CEE RID: 163054 RVA: 0x0099BB64 File Offset: 0x00999D64
		public unsafe bool UseRim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A2C RID: 23084
		// (get) Token: 0x06027CEF RID: 163055 RVA: 0x0099BB75 File Offset: 0x00999D75
		// (set) Token: 0x06027CF0 RID: 163056 RVA: 0x0099BB85 File Offset: 0x00999D85
		public unsafe bool UseOutline
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A2D RID: 23085
		// (get) Token: 0x06027CF1 RID: 163057 RVA: 0x0099BB96 File Offset: 0x00999D96
		// (set) Token: 0x06027CF2 RID: 163058 RVA: 0x0099BBA6 File Offset: 0x00999DA6
		public unsafe bool OutlineRevertProperty_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A2E RID: 23086
		// (get) Token: 0x06027CF3 RID: 163059 RVA: 0x0099BBB7 File Offset: 0x00999DB7
		// (set) Token: 0x06027CF4 RID: 163060 RVA: 0x0099BBC7 File Offset: 0x00999DC7
		public unsafe bool UseDissolve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A2F RID: 23087
		// (get) Token: 0x06027CF5 RID: 163061 RVA: 0x0099BBD8 File Offset: 0x00999DD8
		// (set) Token: 0x06027CF6 RID: 163062 RVA: 0x0099BBEC File Offset: 0x00999DEC
		public unsafe SMaterialControllerLoopTime LoopTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005A30 RID: 23088
		// (get) Token: 0x06027CF7 RID: 163063 RVA: 0x0099BC01 File Offset: 0x00999E01
		// (set) Token: 0x06027CF8 RID: 163064 RVA: 0x0099BC11 File Offset: 0x00999E11
		public unsafe bool RimRevertProperty_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A31 RID: 23089
		// (get) Token: 0x06027CF9 RID: 163065 RVA: 0x0099BC22 File Offset: 0x00999E22
		// (set) Token: 0x06027CFA RID: 163066 RVA: 0x0099BC32 File Offset: 0x00999E32
		public unsafe bool RimUseTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A32 RID: 23090
		// (get) Token: 0x06027CFB RID: 163067 RVA: 0x0099BC43 File Offset: 0x00999E43
		// (set) Token: 0x06027CFC RID: 163068 RVA: 0x0099BC57 File Offset: 0x00999E57
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharacterControllerChannelSwitch> RimChannel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_15);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005A33 RID: 23091
		// (get) Token: 0x06027CFD RID: 163069 RVA: 0x0099BC6C File Offset: 0x00999E6C
		// (set) Token: 0x06027CFE RID: 163070 RVA: 0x0099BCA5 File Offset: 0x00999EA5
		public SMaterialControllerFloatGroup RimRange
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._RimRange) == null)
				{
					result = (this._RimRange = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_16, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_16, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A34 RID: 23092
		// (get) Token: 0x06027CFF RID: 163071 RVA: 0x0099BCC8 File Offset: 0x00999EC8
		// (set) Token: 0x06027D00 RID: 163072 RVA: 0x0099BD01 File Offset: 0x00999F01
		public SMaterialControllerColorGroup RimColor
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerColorGroup result;
				if ((result = this._RimColor) == null)
				{
					result = (this._RimColor = new SMaterialControllerColorGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_17, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_17, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A35 RID: 23093
		// (get) Token: 0x06027D01 RID: 163073 RVA: 0x0099BD22 File Offset: 0x00999F22
		// (set) Token: 0x06027D02 RID: 163074 RVA: 0x0099BD32 File Offset: 0x00999F32
		public unsafe bool OutlineUseTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A36 RID: 23094
		// (get) Token: 0x06027D03 RID: 163075 RVA: 0x0099BD44 File Offset: 0x00999F44
		// (set) Token: 0x06027D04 RID: 163076 RVA: 0x0099BD7D File Offset: 0x00999F7D
		public SMaterialControllerFloatGroup OutlineWidth
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._OutlineWidth) == null)
				{
					result = (this._OutlineWidth = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_19, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_19, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A37 RID: 23095
		// (get) Token: 0x06027D05 RID: 163077 RVA: 0x0099BDA0 File Offset: 0x00999FA0
		// (set) Token: 0x06027D06 RID: 163078 RVA: 0x0099BDD9 File Offset: 0x00999FD9
		public SMaterialControllerColorGroup OutlineColor
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerColorGroup result;
				if ((result = this._OutlineColor) == null)
				{
					result = (this._OutlineColor = new SMaterialControllerColorGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_20, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_20, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A38 RID: 23096
		// (get) Token: 0x06027D07 RID: 163079 RVA: 0x0099BDFA File Offset: 0x00999FFA
		// (set) Token: 0x06027D08 RID: 163080 RVA: 0x0099BE0A File Offset: 0x0099A00A
		public unsafe bool DissolveRevertProperty_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A39 RID: 23097
		// (get) Token: 0x06027D09 RID: 163081 RVA: 0x0099BE1B File Offset: 0x0099A01B
		// (set) Token: 0x06027D0A RID: 163082 RVA: 0x0099BE2F File Offset: 0x0099A02F
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharacterControllerChannelSwitch> DissolveChannel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_22);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17005A3A RID: 23098
		// (get) Token: 0x06027D0B RID: 163083 RVA: 0x0099BE44 File Offset: 0x0099A044
		// (set) Token: 0x06027D0C RID: 163084 RVA: 0x0099BE7D File Offset: 0x0099A07D
		public SMaterialControllerFloatGroup DissolveProgress
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._DissolveProgress) == null)
				{
					result = (this._DissolveProgress = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_23, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_23, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A3B RID: 23099
		// (get) Token: 0x06027D0D RID: 163085 RVA: 0x0099BEA0 File Offset: 0x0099A0A0
		// (set) Token: 0x06027D0E RID: 163086 RVA: 0x0099BED9 File Offset: 0x0099A0D9
		public SMaterialControllerColorGroup DissolveColor
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerColorGroup result;
				if ((result = this._DissolveColor) == null)
				{
					result = (this._DissolveColor = new SMaterialControllerColorGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_24, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_24, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A3C RID: 23100
		// (get) Token: 0x06027D0F RID: 163087 RVA: 0x0099BEFC File Offset: 0x0099A0FC
		// (set) Token: 0x06027D10 RID: 163088 RVA: 0x0099BF35 File Offset: 0x0099A135
		public SMaterialControllerFloatGroup DissolveColorIntensity
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._DissolveColorIntensity) == null)
				{
					result = (this._DissolveColorIntensity = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_25, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_25, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A3D RID: 23101
		// (get) Token: 0x06027D11 RID: 163089 RVA: 0x0099BF56 File Offset: 0x0099A156
		// (set) Token: 0x06027D12 RID: 163090 RVA: 0x0099BF66 File Offset: 0x0099A166
		public unsafe bool UseTextureSample
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A3E RID: 23102
		// (get) Token: 0x06027D13 RID: 163091 RVA: 0x0099BF77 File Offset: 0x0099A177
		// (set) Token: 0x06027D14 RID: 163092 RVA: 0x0099BF87 File Offset: 0x0099A187
		public unsafe bool TextureSampleRevertProperty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A3F RID: 23103
		// (get) Token: 0x06027D15 RID: 163093 RVA: 0x0099BF98 File Offset: 0x0099A198
		// (set) Token: 0x06027D16 RID: 163094 RVA: 0x0099BFA8 File Offset: 0x0099A1A8
		public unsafe bool UseAlphaToMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A40 RID: 23104
		// (get) Token: 0x06027D17 RID: 163095 RVA: 0x0099BFB9 File Offset: 0x0099A1B9
		// (set) Token: 0x06027D18 RID: 163096 RVA: 0x0099BFCD File Offset: 0x0099A1CD
		[Nullable(2)]
		public unsafe UTexture2D MaskTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + PD_CharacterControllerData_C.__PropertyOffset_29);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_CharacterControllerData_C.__PropertyOffset_29, value);
			}
		}

		// Token: 0x17005A41 RID: 23105
		// (get) Token: 0x06027D19 RID: 163097 RVA: 0x0099BFE4 File Offset: 0x0099A1E4
		// (set) Token: 0x06027D1A RID: 163098 RVA: 0x0099C01D File Offset: 0x0099A21D
		public SMaterialControllerFloatGroup Rotation
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_30, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_30, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A42 RID: 23106
		// (get) Token: 0x06027D1B RID: 163099 RVA: 0x0099C03E File Offset: 0x0099A23E
		// (set) Token: 0x06027D1C RID: 163100 RVA: 0x0099C052 File Offset: 0x0099A252
		[Nullable(0)]
		public unsafe TEnumAsByte<ECharacterControllerUVSwitch> UVSelection
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_31);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17005A43 RID: 23107
		// (get) Token: 0x06027D1D RID: 163101 RVA: 0x0099C068 File Offset: 0x0099A268
		// (set) Token: 0x06027D1E RID: 163102 RVA: 0x0099C0A1 File Offset: 0x0099A2A1
		public SMaterialControllerColorGroup TextureScaleAndOffset
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerColorGroup result;
				if ((result = this._TextureScaleAndOffset) == null)
				{
					result = (this._TextureScaleAndOffset = new SMaterialControllerColorGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_32, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_32, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A44 RID: 23108
		// (get) Token: 0x06027D1F RID: 163103 RVA: 0x0099C0C4 File Offset: 0x0099A2C4
		// (set) Token: 0x06027D20 RID: 163104 RVA: 0x0099C0FD File Offset: 0x0099A2FD
		public SMaterialControllerColorGroup TextureSpeed
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerColorGroup result;
				if ((result = this._TextureSpeed) == null)
				{
					result = (this._TextureSpeed = new SMaterialControllerColorGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_33, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_33, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A45 RID: 23109
		// (get) Token: 0x06027D21 RID: 163105 RVA: 0x0099C120 File Offset: 0x0099A320
		// (set) Token: 0x06027D22 RID: 163106 RVA: 0x0099C159 File Offset: 0x0099A359
		public SMaterialControllerColorGroup TextureColorTint
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerColorGroup result;
				if ((result = this._TextureColorTint) == null)
				{
					result = (this._TextureColorTint = new SMaterialControllerColorGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_34, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_34, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A46 RID: 23110
		// (get) Token: 0x06027D23 RID: 163107 RVA: 0x0099C17C File Offset: 0x0099A37C
		// (set) Token: 0x06027D24 RID: 163108 RVA: 0x0099C1B5 File Offset: 0x0099A3B5
		public SMaterialControllerFloatGroup OutlineIntensity
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._OutlineIntensity) == null)
				{
					result = (this._OutlineIntensity = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_35, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_35, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A47 RID: 23111
		// (get) Token: 0x06027D25 RID: 163109 RVA: 0x0099C1D6 File Offset: 0x0099A3D6
		// (set) Token: 0x06027D26 RID: 163110 RVA: 0x0099C1E6 File Offset: 0x0099A3E6
		public unsafe bool UseOuterOutlineEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_36) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_36) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A48 RID: 23112
		// (get) Token: 0x06027D27 RID: 163111 RVA: 0x0099C1F7 File Offset: 0x0099A3F7
		// (set) Token: 0x06027D28 RID: 163112 RVA: 0x0099C207 File Offset: 0x0099A407
		public unsafe bool UseParameterModify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_37) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_37) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A49 RID: 23113
		// (get) Token: 0x06027D29 RID: 163113 RVA: 0x0099C218 File Offset: 0x0099A418
		// (set) Token: 0x06027D2A RID: 163114 RVA: 0x0099C251 File Offset: 0x0099A451
		public TArray<SMaterialControllerFloatParameter> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SMaterialControllerFloatParameter> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TArray<SMaterialControllerFloatParameter>(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_38, this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005A4A RID: 23114
		// (get) Token: 0x06027D2B RID: 163115 RVA: 0x0099C25F File Offset: 0x0099A45F
		// (set) Token: 0x06027D2C RID: 163116 RVA: 0x0099C26F File Offset: 0x0099A46F
		public unsafe bool UseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_39) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_39) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A4B RID: 23115
		// (get) Token: 0x06027D2D RID: 163117 RVA: 0x0099C280 File Offset: 0x0099A480
		// (set) Token: 0x06027D2E RID: 163118 RVA: 0x0099C290 File Offset: 0x0099A490
		public unsafe bool ColorRevertProperty_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_40) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_40) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A4C RID: 23116
		// (get) Token: 0x06027D2F RID: 163119 RVA: 0x0099C2A1 File Offset: 0x0099A4A1
		// (set) Token: 0x06027D30 RID: 163120 RVA: 0x0099C2B1 File Offset: 0x0099A4B1
		public unsafe bool BaseUseTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_41) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_41) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A4D RID: 23117
		// (get) Token: 0x06027D31 RID: 163121 RVA: 0x0099C2C4 File Offset: 0x0099A4C4
		// (set) Token: 0x06027D32 RID: 163122 RVA: 0x0099C2FD File Offset: 0x0099A4FD
		public SMaterialControllerColorGroup BaseColor
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerColorGroup result;
				if ((result = this._BaseColor) == null)
				{
					result = (this._BaseColor = new SMaterialControllerColorGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_42, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_42, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A4E RID: 23118
		// (get) Token: 0x06027D33 RID: 163123 RVA: 0x0099C320 File Offset: 0x0099A520
		// (set) Token: 0x06027D34 RID: 163124 RVA: 0x0099C359 File Offset: 0x0099A559
		public SMaterialControllerFloatGroup BaseColorIntensity
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._BaseColorIntensity) == null)
				{
					result = (this._BaseColorIntensity = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_43, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_43, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A4F RID: 23119
		// (get) Token: 0x06027D35 RID: 163125 RVA: 0x0099C37A File Offset: 0x0099A57A
		// (set) Token: 0x06027D36 RID: 163126 RVA: 0x0099C38A File Offset: 0x0099A58A
		public unsafe bool EmissionUseTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_44) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_44) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A50 RID: 23120
		// (get) Token: 0x06027D37 RID: 163127 RVA: 0x0099C39C File Offset: 0x0099A59C
		// (set) Token: 0x06027D38 RID: 163128 RVA: 0x0099C3D5 File Offset: 0x0099A5D5
		public SMaterialControllerColorGroup EmissionColor
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerColorGroup result;
				if ((result = this._EmissionColor) == null)
				{
					result = (this._EmissionColor = new SMaterialControllerColorGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_45, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_45, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A51 RID: 23121
		// (get) Token: 0x06027D39 RID: 163129 RVA: 0x0099C3F8 File Offset: 0x0099A5F8
		// (set) Token: 0x06027D3A RID: 163130 RVA: 0x0099C431 File Offset: 0x0099A631
		public SMaterialControllerFloatGroup EmissionIntensity
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._EmissionIntensity) == null)
				{
					result = (this._EmissionIntensity = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_46, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_46, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A52 RID: 23122
		// (get) Token: 0x06027D3B RID: 163131 RVA: 0x0099C454 File Offset: 0x0099A654
		// (set) Token: 0x06027D3C RID: 163132 RVA: 0x0099C48D File Offset: 0x0099A68D
		public TArray<SMaterialControllerColorParameter> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SMaterialControllerColorParameter> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TArray<SMaterialControllerColorParameter>(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_47, this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005A53 RID: 23123
		// (get) Token: 0x06027D3D RID: 163133 RVA: 0x0099C49B File Offset: 0x0099A69B
		// (set) Token: 0x06027D3E RID: 163134 RVA: 0x0099C4AB File Offset: 0x0099A6AB
		public unsafe bool UseCustomMaterialEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_48) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_48) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A54 RID: 23124
		// (get) Token: 0x06027D3F RID: 163135 RVA: 0x0099C4BC File Offset: 0x0099A6BC
		// (set) Token: 0x06027D40 RID: 163136 RVA: 0x0099C4CC File Offset: 0x0099A6CC
		public unsafe bool CustomRevertProperty_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_49) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_49) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A55 RID: 23125
		// (get) Token: 0x06027D41 RID: 163137 RVA: 0x0099C4E0 File Offset: 0x0099A6E0
		// (set) Token: 0x06027D42 RID: 163138 RVA: 0x0099C519 File Offset: 0x0099A719
		public TArray<SMaterialControllerFloatParameter> CustomFloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SMaterialControllerFloatParameter> result;
				if ((result = this._CustomFloatParameters) == null)
				{
					result = (this._CustomFloatParameters = new TArray<SMaterialControllerFloatParameter>(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_50, this));
				}
				return result;
			}
			set
			{
				this.CustomFloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005A56 RID: 23126
		// (get) Token: 0x06027D43 RID: 163139 RVA: 0x0099C528 File Offset: 0x0099A728
		// (set) Token: 0x06027D44 RID: 163140 RVA: 0x0099C561 File Offset: 0x0099A761
		public TArray<SMaterialControllerColorParameter> CustomColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SMaterialControllerColorParameter> result;
				if ((result = this._CustomColorParameters) == null)
				{
					result = (this._CustomColorParameters = new TArray<SMaterialControllerColorParameter>(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_51, this));
				}
				return result;
			}
			set
			{
				this.CustomColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005A57 RID: 23127
		// (get) Token: 0x06027D45 RID: 163141 RVA: 0x0099C570 File Offset: 0x0099A770
		// (set) Token: 0x06027D46 RID: 163142 RVA: 0x0099C5A9 File Offset: 0x0099A7A9
		public TArray<SMaterialControllerTextureParameter> CustomTextureParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SMaterialControllerTextureParameter> result;
				if ((result = this._CustomTextureParameters) == null)
				{
					result = (this._CustomTextureParameters = new TArray<SMaterialControllerTextureParameter>(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_52, this));
				}
				return result;
			}
			set
			{
				this.CustomTextureParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005A58 RID: 23128
		// (get) Token: 0x06027D47 RID: 163143 RVA: 0x0099C5B7 File Offset: 0x0099A7B7
		// (set) Token: 0x06027D48 RID: 163144 RVA: 0x0099C5C7 File Offset: 0x0099A7C7
		public unsafe bool UseMotionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_53) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_53) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A59 RID: 23129
		// (get) Token: 0x06027D49 RID: 163145 RVA: 0x0099C5D8 File Offset: 0x0099A7D8
		// (set) Token: 0x06027D4A RID: 163146 RVA: 0x0099C5E8 File Offset: 0x0099A7E8
		public unsafe bool MotionOffsetRevertProperty_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_54) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_54) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A5A RID: 23130
		// (get) Token: 0x06027D4B RID: 163147 RVA: 0x0099C5F9 File Offset: 0x0099A7F9
		// (set) Token: 0x06027D4C RID: 163148 RVA: 0x0099C609 File Offset: 0x0099A809
		public unsafe float MotionOffsetLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_55);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_55) = value;
			}
		}

		// Token: 0x17005A5B RID: 23131
		// (get) Token: 0x06027D4D RID: 163149 RVA: 0x0099C61A File Offset: 0x0099A81A
		// (set) Token: 0x06027D4E RID: 163150 RVA: 0x0099C62A File Offset: 0x0099A82A
		public unsafe float MotionAffectVertexRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_56);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_56) = value;
			}
		}

		// Token: 0x17005A5C RID: 23132
		// (get) Token: 0x06027D4F RID: 163151 RVA: 0x0099C63C File Offset: 0x0099A83C
		// (set) Token: 0x06027D50 RID: 163152 RVA: 0x0099C675 File Offset: 0x0099A875
		public TArray<string> WeaponCases
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._WeaponCases) == null)
				{
					result = (this._WeaponCases = new TArray<string>(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_57, this));
				}
				return result;
			}
			set
			{
				this.WeaponCases.CopyAssign(value);
			}
		}

		// Token: 0x17005A5D RID: 23133
		// (get) Token: 0x06027D51 RID: 163153 RVA: 0x0099C683 File Offset: 0x0099A883
		// (set) Token: 0x06027D52 RID: 163154 RVA: 0x0099C693 File Offset: 0x0099A893
		public unsafe bool IgnoreTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_58) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_58) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A5E RID: 23134
		// (get) Token: 0x06027D53 RID: 163155 RVA: 0x0099C6A4 File Offset: 0x0099A8A4
		// (set) Token: 0x06027D54 RID: 163156 RVA: 0x0099C6B4 File Offset: 0x0099A8B4
		public unsafe bool HiddenAfterEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_59) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_59) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A5F RID: 23135
		// (get) Token: 0x06027D55 RID: 163157 RVA: 0x0099C6C8 File Offset: 0x0099A8C8
		// (set) Token: 0x06027D56 RID: 163158 RVA: 0x0099C701 File Offset: 0x0099A901
		public SMaterialControllerFloatGroup DissolveSmooth
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._DissolveSmooth) == null)
				{
					result = (this._DissolveSmooth = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_60, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_60, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A60 RID: 23136
		// (get) Token: 0x06027D57 RID: 163159 RVA: 0x0099C724 File Offset: 0x0099A924
		// (set) Token: 0x06027D58 RID: 163160 RVA: 0x0099C75D File Offset: 0x0099A95D
		public SMaterialControllerFloatGroup MotionNoiseSpeed
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._MotionNoiseSpeed) == null)
				{
					result = (this._MotionNoiseSpeed = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_61, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_61, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A61 RID: 23137
		// (get) Token: 0x06027D59 RID: 163161 RVA: 0x0099C77E File Offset: 0x0099A97E
		// (set) Token: 0x06027D5A RID: 163162 RVA: 0x0099C78E File Offset: 0x0099A98E
		public unsafe bool UseDitherEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_62) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_62) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A62 RID: 23138
		// (get) Token: 0x06027D5B RID: 163163 RVA: 0x0099C79F File Offset: 0x0099A99F
		// (set) Token: 0x06027D5C RID: 163164 RVA: 0x0099C7AF File Offset: 0x0099A9AF
		public unsafe bool DitherRevertProperty_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_63) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_63) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A63 RID: 23139
		// (get) Token: 0x06027D5D RID: 163165 RVA: 0x0099C7C0 File Offset: 0x0099A9C0
		// (set) Token: 0x06027D5E RID: 163166 RVA: 0x0099C7F9 File Offset: 0x0099A9F9
		public SMaterialControllerFloatGroup DitherValue
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._DitherValue) == null)
				{
					result = (this._DitherValue = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_64, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_64, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A64 RID: 23140
		// (get) Token: 0x06027D5F RID: 163167 RVA: 0x0099C81C File Offset: 0x0099AA1C
		// (set) Token: 0x06027D60 RID: 163168 RVA: 0x0099C855 File Offset: 0x0099AA55
		public TArray<string> OtherCases
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._OtherCases) == null)
				{
					result = (this._OtherCases = new TArray<string>(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_65, this));
				}
				return result;
			}
			set
			{
				this.OtherCases.CopyAssign(value);
			}
		}

		// Token: 0x17005A65 RID: 23141
		// (get) Token: 0x06027D61 RID: 163169 RVA: 0x0099C864 File Offset: 0x0099AA64
		// (set) Token: 0x06027D62 RID: 163170 RVA: 0x0099C89D File Offset: 0x0099AA9D
		public SMaterialControllerFloatGroup RimIntensity
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._RimIntensity) == null)
				{
					result = (this._RimIntensity = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_66, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_66, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A66 RID: 23142
		// (get) Token: 0x06027D63 RID: 163171 RVA: 0x0099C8C0 File Offset: 0x0099AAC0
		// (set) Token: 0x06027D64 RID: 163172 RVA: 0x0099C8F9 File Offset: 0x0099AAF9
		public TArray<string> CustomPartNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._CustomPartNames) == null)
				{
					result = (this._CustomPartNames = new TArray<string>(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_67, this));
				}
				return result;
			}
			set
			{
				this.CustomPartNames.CopyAssign(value);
			}
		}

		// Token: 0x17005A67 RID: 23143
		// (get) Token: 0x06027D65 RID: 163173 RVA: 0x0099C908 File Offset: 0x0099AB08
		// (set) Token: 0x06027D66 RID: 163174 RVA: 0x0099C941 File Offset: 0x0099AB41
		public SMaterialControllerFloatGroup TextureMaskRange
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._TextureMaskRange) == null)
				{
					result = (this._TextureMaskRange = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_68, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_68, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005A68 RID: 23144
		// (get) Token: 0x06027D67 RID: 163175 RVA: 0x0099C962 File Offset: 0x0099AB62
		// (set) Token: 0x06027D68 RID: 163176 RVA: 0x0099C972 File Offset: 0x0099AB72
		public unsafe bool MaskOriginEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_69) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_69) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A69 RID: 23145
		// (get) Token: 0x06027D69 RID: 163177 RVA: 0x0099C983 File Offset: 0x0099AB83
		// (set) Token: 0x06027D6A RID: 163178 RVA: 0x0099C993 File Offset: 0x0099AB93
		public unsafe bool UpdateAtLeastOneFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_70) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_70) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A6A RID: 23146
		// (get) Token: 0x06027D6B RID: 163179 RVA: 0x0099C9A4 File Offset: 0x0099ABA4
		// (set) Token: 0x06027D6C RID: 163180 RVA: 0x0099C9DD File Offset: 0x0099ABDD
		public TArray<string> CustomExcludePartNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._CustomExcludePartNames) == null)
				{
					result = (this._CustomExcludePartNames = new TArray<string>(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_71, this));
				}
				return result;
			}
			set
			{
				this.CustomExcludePartNames.CopyAssign(value);
			}
		}

		// Token: 0x17005A6B RID: 23147
		// (get) Token: 0x06027D6D RID: 163181 RVA: 0x0099C9EB File Offset: 0x0099ABEB
		// (set) Token: 0x06027D6E RID: 163182 RVA: 0x0099C9FB File Offset: 0x0099ABFB
		public unsafe bool ForceUpdateOnAdd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_72) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_72) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A6C RID: 23148
		// (get) Token: 0x06027D6F RID: 163183 RVA: 0x0099CA0C File Offset: 0x0099AC0C
		// (set) Token: 0x06027D70 RID: 163184 RVA: 0x0099CA1C File Offset: 0x0099AC1C
		public unsafe bool MobileUseDifferentMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_73) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_73) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A6D RID: 23149
		// (get) Token: 0x06027D71 RID: 163185 RVA: 0x0099CA2D File Offset: 0x0099AC2D
		// (set) Token: 0x06027D72 RID: 163186 RVA: 0x0099CA3D File Offset: 0x0099AC3D
		public unsafe bool OnlyApplyOnLocalPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_74) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_74) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A6E RID: 23150
		// (get) Token: 0x06027D73 RID: 163187 RVA: 0x0099CA4E File Offset: 0x0099AC4E
		// (set) Token: 0x06027D74 RID: 163188 RVA: 0x0099CA5E File Offset: 0x0099AC5E
		public unsafe bool NeverApplyOnLocalPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_75) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_CharacterControllerData_C.__PropertyOffset_75) = (value ? 1 : 0);
			}
		}

		// Token: 0x06027D75 RID: 163189 RVA: 0x0099CA6F File Offset: 0x0099AC6F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitCache()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PD_CharacterControllerData_C.__InitCache_NativeFunctionPtr, null);
		}

		// Token: 0x06027D76 RID: 163190 RVA: 0x0099CA83 File Offset: 0x0099AC83
		protected PD_CharacterControllerData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040142B7 RID: 82615
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/PD_CharacterControllerData.PD_CharacterControllerData_C";

		// Token: 0x040142B8 RID: 82616
		private static IntPtr _ClassPtr;

		// Token: 0x040142B9 RID: 82617
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040142BA RID: 82618
		internal static int __PropertyOffset_0;

		// Token: 0x040142BB RID: 82619
		internal static int __PropertyOffset_1;

		// Token: 0x040142BC RID: 82620
		internal static int __PropertyOffset_2;

		// Token: 0x040142BD RID: 82621
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<ECharacterMeshPart>> _SpecifiedParts;

		// Token: 0x040142BE RID: 82622
		internal static int __PropertyOffset_3;

		// Token: 0x040142BF RID: 82623
		internal static int __PropertyOffset_4;

		// Token: 0x040142C0 RID: 82624
		internal static int __PropertyOffset_5;

		// Token: 0x040142C1 RID: 82625
		internal static int __PropertyOffset_6;

		// Token: 0x040142C2 RID: 82626
		internal static int __PropertyOffset_7;

		// Token: 0x040142C3 RID: 82627
		internal static int __PropertyOffset_8;

		// Token: 0x040142C4 RID: 82628
		internal static int __PropertyOffset_9;

		// Token: 0x040142C5 RID: 82629
		internal static int __PropertyOffset_10;

		// Token: 0x040142C6 RID: 82630
		internal static int __PropertyOffset_11;

		// Token: 0x040142C7 RID: 82631
		internal static int __PropertyOffset_12;

		// Token: 0x040142C8 RID: 82632
		internal static int __PropertyOffset_13;

		// Token: 0x040142C9 RID: 82633
		internal static int __PropertyOffset_14;

		// Token: 0x040142CA RID: 82634
		internal static int __PropertyOffset_15;

		// Token: 0x040142CB RID: 82635
		internal static int __PropertyOffset_16;

		// Token: 0x040142CC RID: 82636
		[Nullable(2)]
		private SMaterialControllerFloatGroup _RimRange;

		// Token: 0x040142CD RID: 82637
		internal static int __PropertyOffset_17;

		// Token: 0x040142CE RID: 82638
		[Nullable(2)]
		private SMaterialControllerColorGroup _RimColor;

		// Token: 0x040142CF RID: 82639
		internal static int __PropertyOffset_18;

		// Token: 0x040142D0 RID: 82640
		internal static int __PropertyOffset_19;

		// Token: 0x040142D1 RID: 82641
		[Nullable(2)]
		private SMaterialControllerFloatGroup _OutlineWidth;

		// Token: 0x040142D2 RID: 82642
		internal static int __PropertyOffset_20;

		// Token: 0x040142D3 RID: 82643
		[Nullable(2)]
		private SMaterialControllerColorGroup _OutlineColor;

		// Token: 0x040142D4 RID: 82644
		internal static int __PropertyOffset_21;

		// Token: 0x040142D5 RID: 82645
		internal static int __PropertyOffset_22;

		// Token: 0x040142D6 RID: 82646
		internal static int __PropertyOffset_23;

		// Token: 0x040142D7 RID: 82647
		[Nullable(2)]
		private SMaterialControllerFloatGroup _DissolveProgress;

		// Token: 0x040142D8 RID: 82648
		internal static int __PropertyOffset_24;

		// Token: 0x040142D9 RID: 82649
		[Nullable(2)]
		private SMaterialControllerColorGroup _DissolveColor;

		// Token: 0x040142DA RID: 82650
		internal static int __PropertyOffset_25;

		// Token: 0x040142DB RID: 82651
		[Nullable(2)]
		private SMaterialControllerFloatGroup _DissolveColorIntensity;

		// Token: 0x040142DC RID: 82652
		internal static int __PropertyOffset_26;

		// Token: 0x040142DD RID: 82653
		internal static int __PropertyOffset_27;

		// Token: 0x040142DE RID: 82654
		internal static int __PropertyOffset_28;

		// Token: 0x040142DF RID: 82655
		internal static int __PropertyOffset_29;

		// Token: 0x040142E0 RID: 82656
		internal static int __PropertyOffset_30;

		// Token: 0x040142E1 RID: 82657
		[Nullable(2)]
		private SMaterialControllerFloatGroup _Rotation;

		// Token: 0x040142E2 RID: 82658
		internal static int __PropertyOffset_31;

		// Token: 0x040142E3 RID: 82659
		internal static int __PropertyOffset_32;

		// Token: 0x040142E4 RID: 82660
		[Nullable(2)]
		private SMaterialControllerColorGroup _TextureScaleAndOffset;

		// Token: 0x040142E5 RID: 82661
		internal static int __PropertyOffset_33;

		// Token: 0x040142E6 RID: 82662
		[Nullable(2)]
		private SMaterialControllerColorGroup _TextureSpeed;

		// Token: 0x040142E7 RID: 82663
		internal static int __PropertyOffset_34;

		// Token: 0x040142E8 RID: 82664
		[Nullable(2)]
		private SMaterialControllerColorGroup _TextureColorTint;

		// Token: 0x040142E9 RID: 82665
		internal static int __PropertyOffset_35;

		// Token: 0x040142EA RID: 82666
		[Nullable(2)]
		private SMaterialControllerFloatGroup _OutlineIntensity;

		// Token: 0x040142EB RID: 82667
		internal static int __PropertyOffset_36;

		// Token: 0x040142EC RID: 82668
		internal static int __PropertyOffset_37;

		// Token: 0x040142ED RID: 82669
		internal static int __PropertyOffset_38;

		// Token: 0x040142EE RID: 82670
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SMaterialControllerFloatParameter> _FloatParameters;

		// Token: 0x040142EF RID: 82671
		internal static int __PropertyOffset_39;

		// Token: 0x040142F0 RID: 82672
		internal static int __PropertyOffset_40;

		// Token: 0x040142F1 RID: 82673
		internal static int __PropertyOffset_41;

		// Token: 0x040142F2 RID: 82674
		internal static int __PropertyOffset_42;

		// Token: 0x040142F3 RID: 82675
		[Nullable(2)]
		private SMaterialControllerColorGroup _BaseColor;

		// Token: 0x040142F4 RID: 82676
		internal static int __PropertyOffset_43;

		// Token: 0x040142F5 RID: 82677
		[Nullable(2)]
		private SMaterialControllerFloatGroup _BaseColorIntensity;

		// Token: 0x040142F6 RID: 82678
		internal static int __PropertyOffset_44;

		// Token: 0x040142F7 RID: 82679
		internal static int __PropertyOffset_45;

		// Token: 0x040142F8 RID: 82680
		[Nullable(2)]
		private SMaterialControllerColorGroup _EmissionColor;

		// Token: 0x040142F9 RID: 82681
		internal static int __PropertyOffset_46;

		// Token: 0x040142FA RID: 82682
		[Nullable(2)]
		private SMaterialControllerFloatGroup _EmissionIntensity;

		// Token: 0x040142FB RID: 82683
		internal static int __PropertyOffset_47;

		// Token: 0x040142FC RID: 82684
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SMaterialControllerColorParameter> _ColorParameters;

		// Token: 0x040142FD RID: 82685
		internal static int __PropertyOffset_48;

		// Token: 0x040142FE RID: 82686
		internal static int __PropertyOffset_49;

		// Token: 0x040142FF RID: 82687
		internal static int __PropertyOffset_50;

		// Token: 0x04014300 RID: 82688
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SMaterialControllerFloatParameter> _CustomFloatParameters;

		// Token: 0x04014301 RID: 82689
		internal static int __PropertyOffset_51;

		// Token: 0x04014302 RID: 82690
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SMaterialControllerColorParameter> _CustomColorParameters;

		// Token: 0x04014303 RID: 82691
		internal static int __PropertyOffset_52;

		// Token: 0x04014304 RID: 82692
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SMaterialControllerTextureParameter> _CustomTextureParameters;

		// Token: 0x04014305 RID: 82693
		internal static int __PropertyOffset_53;

		// Token: 0x04014306 RID: 82694
		internal static int __PropertyOffset_54;

		// Token: 0x04014307 RID: 82695
		internal static int __PropertyOffset_55;

		// Token: 0x04014308 RID: 82696
		internal static int __PropertyOffset_56;

		// Token: 0x04014309 RID: 82697
		internal static int __PropertyOffset_57;

		// Token: 0x0401430A RID: 82698
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _WeaponCases;

		// Token: 0x0401430B RID: 82699
		internal static int __PropertyOffset_58;

		// Token: 0x0401430C RID: 82700
		internal static int __PropertyOffset_59;

		// Token: 0x0401430D RID: 82701
		internal static int __PropertyOffset_60;

		// Token: 0x0401430E RID: 82702
		[Nullable(2)]
		private SMaterialControllerFloatGroup _DissolveSmooth;

		// Token: 0x0401430F RID: 82703
		internal static int __PropertyOffset_61;

		// Token: 0x04014310 RID: 82704
		[Nullable(2)]
		private SMaterialControllerFloatGroup _MotionNoiseSpeed;

		// Token: 0x04014311 RID: 82705
		internal static int __PropertyOffset_62;

		// Token: 0x04014312 RID: 82706
		internal static int __PropertyOffset_63;

		// Token: 0x04014313 RID: 82707
		internal static int __PropertyOffset_64;

		// Token: 0x04014314 RID: 82708
		[Nullable(2)]
		private SMaterialControllerFloatGroup _DitherValue;

		// Token: 0x04014315 RID: 82709
		internal static int __PropertyOffset_65;

		// Token: 0x04014316 RID: 82710
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _OtherCases;

		// Token: 0x04014317 RID: 82711
		internal static int __PropertyOffset_66;

		// Token: 0x04014318 RID: 82712
		[Nullable(2)]
		private SMaterialControllerFloatGroup _RimIntensity;

		// Token: 0x04014319 RID: 82713
		internal static int __PropertyOffset_67;

		// Token: 0x0401431A RID: 82714
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _CustomPartNames;

		// Token: 0x0401431B RID: 82715
		internal static int __PropertyOffset_68;

		// Token: 0x0401431C RID: 82716
		[Nullable(2)]
		private SMaterialControllerFloatGroup _TextureMaskRange;

		// Token: 0x0401431D RID: 82717
		internal static int __PropertyOffset_69;

		// Token: 0x0401431E RID: 82718
		internal static int __PropertyOffset_70;

		// Token: 0x0401431F RID: 82719
		internal static int __PropertyOffset_71;

		// Token: 0x04014320 RID: 82720
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _CustomExcludePartNames;

		// Token: 0x04014321 RID: 82721
		internal static int __PropertyOffset_72;

		// Token: 0x04014322 RID: 82722
		internal static int __PropertyOffset_73;

		// Token: 0x04014323 RID: 82723
		internal static int __PropertyOffset_74;

		// Token: 0x04014324 RID: 82724
		internal static int __PropertyOffset_75;

		// Token: 0x04014325 RID: 82725
		private static IntPtr __InitCache_NativeFunctionPtr;
	}
}
