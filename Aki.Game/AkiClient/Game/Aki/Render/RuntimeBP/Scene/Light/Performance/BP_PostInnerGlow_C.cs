using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light.Performance
{
	// Token: 0x02003B33 RID: 15155
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/Performance/BP_PostInnerGlow.BP_PostInnerGlow_C")]
	[UnrealStructLayout(1664, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1664)]
	public class BP_PostInnerGlow_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060217D0 RID: 137168 RVA: 0x008EDB68 File Offset: 0x008EBD68
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PostInnerGlow_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/Performance/BP_PostInnerGlow.BP_PostInnerGlow_C");
			}
			return BP_PostInnerGlow_C._ClassPtr;
		}

		// Token: 0x060217D1 RID: 137169 RVA: 0x008EDB8C File Offset: 0x008EBD8C
		public BP_PostInnerGlow_C() : this(BuiltinUtils.AllocNativeUObject(BP_PostInnerGlow_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060217D2 RID: 137170 RVA: 0x008EDBB4 File Offset: 0x008EBDB4
		[NullableContext(1)]
		public BP_PostInnerGlow_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PostInnerGlow_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170036D3 RID: 14035
		// (get) Token: 0x060217D3 RID: 137171 RVA: 0x008EDBE7 File Offset: 0x008EBDE7
		// (set) Token: 0x060217D4 RID: 137172 RVA: 0x008EDBFB File Offset: 0x008EBDFB
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostInnerGlow_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostInnerGlow_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170036D4 RID: 14036
		// (get) Token: 0x060217D5 RID: 137173 RVA: 0x008EDC10 File Offset: 0x008EBE10
		// (set) Token: 0x060217D6 RID: 137174 RVA: 0x008EDC24 File Offset: 0x008EBE24
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostInnerGlow_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostInnerGlow_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170036D5 RID: 14037
		// (get) Token: 0x060217D7 RID: 137175 RVA: 0x008EDC39 File Offset: 0x008EBE39
		// (set) Token: 0x060217D8 RID: 137176 RVA: 0x008EDC4D File Offset: 0x008EBE4D
		public unsafe UMaterialInstanceDynamic DynamicMaterial_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostInnerGlow_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostInnerGlow_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170036D6 RID: 14038
		// (get) Token: 0x060217D9 RID: 137177 RVA: 0x008EDC62 File Offset: 0x008EBE62
		// (set) Token: 0x060217DA RID: 137178 RVA: 0x008EDC72 File Offset: 0x008EBE72
		public unsafe float OffsetX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170036D7 RID: 14039
		// (get) Token: 0x060217DB RID: 137179 RVA: 0x008EDC83 File Offset: 0x008EBE83
		// (set) Token: 0x060217DC RID: 137180 RVA: 0x008EDC93 File Offset: 0x008EBE93
		public unsafe float OffsetY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170036D8 RID: 14040
		// (get) Token: 0x060217DD RID: 137181 RVA: 0x008EDCA4 File Offset: 0x008EBEA4
		// (set) Token: 0x060217DE RID: 137182 RVA: 0x008EDCB4 File Offset: 0x008EBEB4
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170036D9 RID: 14041
		// (get) Token: 0x060217DF RID: 137183 RVA: 0x008EDCC5 File Offset: 0x008EBEC5
		// (set) Token: 0x060217E0 RID: 137184 RVA: 0x008EDCD9 File Offset: 0x008EBED9
		public unsafe UMaterial Material_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostInnerGlow_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostInnerGlow_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170036DA RID: 14042
		// (get) Token: 0x060217E1 RID: 137185 RVA: 0x008EDCEE File Offset: 0x008EBEEE
		// (set) Token: 0x060217E2 RID: 137186 RVA: 0x008EDD02 File Offset: 0x008EBF02
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170036DB RID: 14043
		// (get) Token: 0x060217E3 RID: 137187 RVA: 0x008EDD17 File Offset: 0x008EBF17
		// (set) Token: 0x060217E4 RID: 137188 RVA: 0x008EDD27 File Offset: 0x008EBF27
		public unsafe float Range
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170036DC RID: 14044
		// (get) Token: 0x060217E5 RID: 137189 RVA: 0x008EDD38 File Offset: 0x008EBF38
		// (set) Token: 0x060217E6 RID: 137190 RVA: 0x008EDD48 File Offset: 0x008EBF48
		public unsafe int ToonDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170036DD RID: 14045
		// (get) Token: 0x060217E7 RID: 137191 RVA: 0x008EDD59 File Offset: 0x008EBF59
		// (set) Token: 0x060217E8 RID: 137192 RVA: 0x008EDD69 File Offset: 0x008EBF69
		public unsafe float OffsetX_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170036DE RID: 14046
		// (get) Token: 0x060217E9 RID: 137193 RVA: 0x008EDD7A File Offset: 0x008EBF7A
		// (set) Token: 0x060217EA RID: 137194 RVA: 0x008EDD8A File Offset: 0x008EBF8A
		public unsafe float OffsetX_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170036DF RID: 14047
		// (get) Token: 0x060217EB RID: 137195 RVA: 0x008EDD9B File Offset: 0x008EBF9B
		// (set) Token: 0x060217EC RID: 137196 RVA: 0x008EDDAB File Offset: 0x008EBFAB
		public unsafe float OffsetY_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170036E0 RID: 14048
		// (get) Token: 0x060217ED RID: 137197 RVA: 0x008EDDBC File Offset: 0x008EBFBC
		// (set) Token: 0x060217EE RID: 137198 RVA: 0x008EDDCC File Offset: 0x008EBFCC
		public unsafe float OffsetY_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170036E1 RID: 14049
		// (get) Token: 0x060217EF RID: 137199 RVA: 0x008EDDDD File Offset: 0x008EBFDD
		// (set) Token: 0x060217F0 RID: 137200 RVA: 0x008EDDED File Offset: 0x008EBFED
		public unsafe float Intensity_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170036E2 RID: 14050
		// (get) Token: 0x060217F1 RID: 137201 RVA: 0x008EDDFE File Offset: 0x008EBFFE
		// (set) Token: 0x060217F2 RID: 137202 RVA: 0x008EDE0E File Offset: 0x008EC00E
		public unsafe float Intensity_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170036E3 RID: 14051
		// (get) Token: 0x060217F3 RID: 137203 RVA: 0x008EDE1F File Offset: 0x008EC01F
		// (set) Token: 0x060217F4 RID: 137204 RVA: 0x008EDE33 File Offset: 0x008EC033
		public unsafe FLinearColor Color_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170036E4 RID: 14052
		// (get) Token: 0x060217F5 RID: 137205 RVA: 0x008EDE48 File Offset: 0x008EC048
		// (set) Token: 0x060217F6 RID: 137206 RVA: 0x008EDE5C File Offset: 0x008EC05C
		public unsafe FLinearColor Color_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170036E5 RID: 14053
		// (get) Token: 0x060217F7 RID: 137207 RVA: 0x008EDE71 File Offset: 0x008EC071
		// (set) Token: 0x060217F8 RID: 137208 RVA: 0x008EDE81 File Offset: 0x008EC081
		public unsafe float Range_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170036E6 RID: 14054
		// (get) Token: 0x060217F9 RID: 137209 RVA: 0x008EDE92 File Offset: 0x008EC092
		// (set) Token: 0x060217FA RID: 137210 RVA: 0x008EDEA2 File Offset: 0x008EC0A2
		public unsafe float Range_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170036E7 RID: 14055
		// (get) Token: 0x060217FB RID: 137211 RVA: 0x008EDEB3 File Offset: 0x008EC0B3
		// (set) Token: 0x060217FC RID: 137212 RVA: 0x008EDEC7 File Offset: 0x008EC0C7
		public unsafe UMaterial Material_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostInnerGlow_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostInnerGlow_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x170036E8 RID: 14056
		// (get) Token: 0x060217FD RID: 137213 RVA: 0x008EDEDC File Offset: 0x008EC0DC
		// (set) Token: 0x060217FE RID: 137214 RVA: 0x008EDEF0 File Offset: 0x008EC0F0
		public unsafe UMaterialInstanceDynamic DynamicMaterial_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostInnerGlow_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostInnerGlow_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x170036E9 RID: 14057
		// (get) Token: 0x060217FF RID: 137215 RVA: 0x008EDF05 File Offset: 0x008EC105
		// (set) Token: 0x06021800 RID: 137216 RVA: 0x008EDF19 File Offset: 0x008EC119
		public unsafe UMaterialInstanceDynamic DynamicMaterial_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostInnerGlow_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostInnerGlow_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x170036EA RID: 14058
		// (get) Token: 0x06021801 RID: 137217 RVA: 0x008EDF2E File Offset: 0x008EC12E
		// (set) Token: 0x06021802 RID: 137218 RVA: 0x008EDF42 File Offset: 0x008EC142
		public unsafe UMaterial Material_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostInnerGlow_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostInnerGlow_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x170036EB RID: 14059
		// (get) Token: 0x06021803 RID: 137219 RVA: 0x008EDF58 File Offset: 0x008EC158
		// (set) Token: 0x06021804 RID: 137220 RVA: 0x008EDF91 File Offset: 0x008EC191
		[Nullable(1)]
		public TArray<FWeightedBlendable> Post_Process_Materials_Array
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FWeightedBlendable> result;
				if ((result = this._Post_Process_Materials_Array) == null)
				{
					result = (this._Post_Process_Materials_Array = new TArray<FWeightedBlendable>(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_25, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Post_Process_Materials_Array.CopyAssign(value);
			}
		}

		// Token: 0x170036EC RID: 14060
		// (get) Token: 0x06021805 RID: 137221 RVA: 0x008EDF9F File Offset: 0x008EC19F
		// (set) Token: 0x06021806 RID: 137222 RVA: 0x008EDFAF File Offset: 0x008EC1AF
		public unsafe float bUseNewColorBlend_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x170036ED RID: 14061
		// (get) Token: 0x06021807 RID: 137223 RVA: 0x008EDFC0 File Offset: 0x008EC1C0
		// (set) Token: 0x06021808 RID: 137224 RVA: 0x008EDFD0 File Offset: 0x008EC1D0
		public unsafe float bUseNewColorBlend_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x170036EE RID: 14062
		// (get) Token: 0x06021809 RID: 137225 RVA: 0x008EDFE1 File Offset: 0x008EC1E1
		// (set) Token: 0x0602180A RID: 137226 RVA: 0x008EDFF1 File Offset: 0x008EC1F1
		public unsafe float bUseNewColorBlend_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x170036EF RID: 14063
		// (get) Token: 0x0602180B RID: 137227 RVA: 0x008EE002 File Offset: 0x008EC202
		// (set) Token: 0x0602180C RID: 137228 RVA: 0x008EE012 File Offset: 0x008EC212
		public unsafe float Smooth_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x170036F0 RID: 14064
		// (get) Token: 0x0602180D RID: 137229 RVA: 0x008EE023 File Offset: 0x008EC223
		// (set) Token: 0x0602180E RID: 137230 RVA: 0x008EE033 File Offset: 0x008EC233
		public unsafe float Smooth_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x170036F1 RID: 14065
		// (get) Token: 0x0602180F RID: 137231 RVA: 0x008EE044 File Offset: 0x008EC244
		// (set) Token: 0x06021810 RID: 137232 RVA: 0x008EE054 File Offset: 0x008EC254
		public unsafe float Smooth_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostInnerGlow_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x06021811 RID: 137233 RVA: 0x008EE065 File Offset: 0x008EC265
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetPar()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PostInnerGlow_C.__SetPar_NativeFunctionPtr, null);
		}

		// Token: 0x06021812 RID: 137234 RVA: 0x008EE079 File Offset: 0x008EC279
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetPostMaterial()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PostInnerGlow_C.__SetPostMaterial_NativeFunctionPtr, null);
		}

		// Token: 0x06021813 RID: 137235 RVA: 0x008EE090 File Offset: 0x008EC290
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetParameter(UMaterialInstanceDynamic MaterialInstance, float RimRange, float RimOffsetX, float RimOffsetY, float RimIntensity, FLinearColor RimColor, float bUseNewColorBlend, float Smooth)
		{
			BP_PostInnerGlow_C.__SetParameter_FunctionParams* ptr = stackalloc BP_PostInnerGlow_C.__SetParameter_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_PostInnerGlow_C.__SetParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PostInnerGlow_C.__SetParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MaterialInstance = ((MaterialInstance != null) ? MaterialInstance.NativePtr : IntPtr.Zero);
			ptr->RimRange = RimRange;
			ptr->RimOffsetX = RimOffsetX;
			ptr->RimOffsetY = RimOffsetY;
			ptr->RimIntensity = RimIntensity;
			ptr->RimColor = RimColor;
			ptr->bUseNewColorBlend = bUseNewColorBlend;
			ptr->Smooth = Smooth;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PostInnerGlow_C.__SetParameter_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021814 RID: 137236 RVA: 0x008EE11B File Offset: 0x008EC31B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PostInnerGlow_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021815 RID: 137237 RVA: 0x008EE12F File Offset: 0x008EC32F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PostInnerGlow_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021816 RID: 137238 RVA: 0x008EE144 File Offset: 0x008EC344
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PostInnerGlow_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021817 RID: 137239 RVA: 0x008EE158 File Offset: 0x008EC358
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PostInnerGlow_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021818 RID: 137240 RVA: 0x008EE170 File Offset: 0x008EC370
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_PostInnerGlow_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PostInnerGlow_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PostInnerGlow_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PostInnerGlow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PostInnerGlow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021819 RID: 137241 RVA: 0x008EE1B8 File Offset: 0x008EC3B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_PostInnerGlow_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PostInnerGlow_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PostInnerGlow_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PostInnerGlow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PostInnerGlow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602181A RID: 137242 RVA: 0x008EE1FF File Offset: 0x008EC3FF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PostInnerGlow_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0602181B RID: 137243 RVA: 0x008EE213 File Offset: 0x008EC413
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PostInnerGlow_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602181C RID: 137244 RVA: 0x008EE228 File Offset: 0x008EC428
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_PostInnerGlow_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PostInnerGlow_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PostInnerGlow_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PostInnerGlow_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PostInnerGlow_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602181D RID: 137245 RVA: 0x008EE270 File Offset: 0x008EC470
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_PostInnerGlow_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PostInnerGlow_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PostInnerGlow_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PostInnerGlow_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PostInnerGlow_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602181E RID: 137246 RVA: 0x008EE2B7 File Offset: 0x008EC4B7
		protected BP_PostInnerGlow_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010512 RID: 66834
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/Performance/BP_PostInnerGlow.BP_PostInnerGlow_C";

		// Token: 0x04010513 RID: 66835
		private static IntPtr _ClassPtr;

		// Token: 0x04010514 RID: 66836
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010515 RID: 66837
		internal static int __PropertyOffset_1;

		// Token: 0x04010516 RID: 66838
		internal static int __PropertyOffset_2;

		// Token: 0x04010517 RID: 66839
		internal static int __PropertyOffset_3;

		// Token: 0x04010518 RID: 66840
		internal static int __PropertyOffset_4;

		// Token: 0x04010519 RID: 66841
		internal static int __PropertyOffset_5;

		// Token: 0x0401051A RID: 66842
		internal static int __PropertyOffset_6;

		// Token: 0x0401051B RID: 66843
		internal static int __PropertyOffset_7;

		// Token: 0x0401051C RID: 66844
		internal static int __PropertyOffset_8;

		// Token: 0x0401051D RID: 66845
		internal static int __PropertyOffset_9;

		// Token: 0x0401051E RID: 66846
		internal static int __PropertyOffset_10;

		// Token: 0x0401051F RID: 66847
		internal static int __PropertyOffset_11;

		// Token: 0x04010520 RID: 66848
		internal static int __PropertyOffset_12;

		// Token: 0x04010521 RID: 66849
		internal static int __PropertyOffset_13;

		// Token: 0x04010522 RID: 66850
		internal static int __PropertyOffset_14;

		// Token: 0x04010523 RID: 66851
		internal static int __PropertyOffset_15;

		// Token: 0x04010524 RID: 66852
		internal static int __PropertyOffset_16;

		// Token: 0x04010525 RID: 66853
		internal static int __PropertyOffset_17;

		// Token: 0x04010526 RID: 66854
		internal static int __PropertyOffset_18;

		// Token: 0x04010527 RID: 66855
		internal static int __PropertyOffset_19;

		// Token: 0x04010528 RID: 66856
		internal static int __PropertyOffset_20;

		// Token: 0x04010529 RID: 66857
		internal static int __PropertyOffset_21;

		// Token: 0x0401052A RID: 66858
		internal static int __PropertyOffset_22;

		// Token: 0x0401052B RID: 66859
		internal static int __PropertyOffset_23;

		// Token: 0x0401052C RID: 66860
		internal static int __PropertyOffset_24;

		// Token: 0x0401052D RID: 66861
		internal static int __PropertyOffset_25;

		// Token: 0x0401052E RID: 66862
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWeightedBlendable> _Post_Process_Materials_Array;

		// Token: 0x0401052F RID: 66863
		internal static int __PropertyOffset_26;

		// Token: 0x04010530 RID: 66864
		internal static int __PropertyOffset_27;

		// Token: 0x04010531 RID: 66865
		internal static int __PropertyOffset_28;

		// Token: 0x04010532 RID: 66866
		internal static int __PropertyOffset_29;

		// Token: 0x04010533 RID: 66867
		internal static int __PropertyOffset_30;

		// Token: 0x04010534 RID: 66868
		internal static int __PropertyOffset_31;

		// Token: 0x04010535 RID: 66869
		private static IntPtr __SetPar_NativeFunctionPtr;

		// Token: 0x04010536 RID: 66870
		private static IntPtr __SetPostMaterial_NativeFunctionPtr;

		// Token: 0x04010537 RID: 66871
		private static IntPtr __SetParameter_NativeFunctionPtr;

		// Token: 0x04010538 RID: 66872
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010539 RID: 66873
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401053A RID: 66874
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401053B RID: 66875
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x0401053C RID: 66876
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C99 RID: 40089
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __SetParameter_FunctionParams
		{
			// Token: 0x04031357 RID: 201559
			[FieldOffset(0)]
			public IntPtr MaterialInstance;

			// Token: 0x04031358 RID: 201560
			[FieldOffset(8)]
			public float RimRange;

			// Token: 0x04031359 RID: 201561
			[FieldOffset(12)]
			public float RimOffsetX;

			// Token: 0x0403135A RID: 201562
			[FieldOffset(16)]
			public float RimOffsetY;

			// Token: 0x0403135B RID: 201563
			[FieldOffset(20)]
			public float RimIntensity;

			// Token: 0x0403135C RID: 201564
			[FieldOffset(24)]
			public FLinearColor RimColor;

			// Token: 0x0403135D RID: 201565
			[FieldOffset(40)]
			public float bUseNewColorBlend;

			// Token: 0x0403135E RID: 201566
			[FieldOffset(44)]
			public float Smooth;
		}

		// Token: 0x02009C9A RID: 40090
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403135F RID: 201567
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C9B RID: 40091
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031360 RID: 201568
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
