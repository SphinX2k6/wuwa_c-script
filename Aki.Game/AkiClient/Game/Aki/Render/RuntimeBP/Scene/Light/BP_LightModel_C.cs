using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B11 RID: 15121
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_LightModel.BP_LightModel_C")]
	[UnrealStructLayout(1352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1352)]
	public class BP_LightModel_C : AActor, IUnrealUObject, IUnrealObject, IInterface_KuroLightBP, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06020FFA RID: 135162 RVA: 0x008E232C File Offset: 0x008E052C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LightModel_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_LightModel.BP_LightModel_C");
			}
			return BP_LightModel_C._ClassPtr;
		}

		// Token: 0x06020FFB RID: 135163 RVA: 0x008E2350 File Offset: 0x008E0550
		int IInterface_KuroLightBP.InterfaceOffset()
		{
			return BP_LightModel_C.__InterfaceOffset_IInterface_KuroLightBP;
		}

		// Token: 0x06020FFC RID: 135164 RVA: 0x008E2358 File Offset: 0x008E0558
		public BP_LightModel_C() : this(BuiltinUtils.AllocNativeUObject(BP_LightModel_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020FFD RID: 135165 RVA: 0x008E2380 File Offset: 0x008E0580
		public BP_LightModel_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LightModel_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033C9 RID: 13257
		// (get) Token: 0x06020FFE RID: 135166 RVA: 0x008E23B3 File Offset: 0x008E05B3
		// (set) Token: 0x06020FFF RID: 135167 RVA: 0x008E23C7 File Offset: 0x008E05C7
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightModel_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightModel_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170033CA RID: 13258
		// (get) Token: 0x06021000 RID: 135168 RVA: 0x008E23DC File Offset: 0x008E05DC
		// (set) Token: 0x06021001 RID: 135169 RVA: 0x008E23F0 File Offset: 0x008E05F0
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightModel_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightModel_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170033CB RID: 13259
		// (get) Token: 0x06021002 RID: 135170 RVA: 0x008E2405 File Offset: 0x008E0605
		// (set) Token: 0x06021003 RID: 135171 RVA: 0x008E2419 File Offset: 0x008E0619
		[Nullable(2)]
		public unsafe UStaticMesh LightModel
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightModel_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LightModel_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170033CC RID: 13260
		// (get) Token: 0x06021004 RID: 135172 RVA: 0x008E242E File Offset: 0x008E062E
		// (set) Token: 0x06021005 RID: 135173 RVA: 0x008E2442 File Offset: 0x008E0642
		public unsafe FLinearColor EmissionDayColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170033CD RID: 13261
		// (get) Token: 0x06021006 RID: 135174 RVA: 0x008E2457 File Offset: 0x008E0657
		// (set) Token: 0x06021007 RID: 135175 RVA: 0x008E246B File Offset: 0x008E066B
		public unsafe FLinearColor EmissionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170033CE RID: 13262
		// (get) Token: 0x06021008 RID: 135176 RVA: 0x008E2480 File Offset: 0x008E0680
		// (set) Token: 0x06021009 RID: 135177 RVA: 0x008E2490 File Offset: 0x008E0690
		public unsafe bool UseWholeDayEmission
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033CF RID: 13263
		// (get) Token: 0x0602100A RID: 135178 RVA: 0x008E24A1 File Offset: 0x008E06A1
		// (set) Token: 0x0602100B RID: 135179 RVA: 0x008E24B1 File Offset: 0x008E06B1
		public unsafe bool UseMaterial_LOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033D0 RID: 13264
		// (get) Token: 0x0602100C RID: 135180 RVA: 0x008E24C2 File Offset: 0x008E06C2
		// (set) Token: 0x0602100D RID: 135181 RVA: 0x008E24D2 File Offset: 0x008E06D2
		public unsafe bool UseFrenel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033D1 RID: 13265
		// (get) Token: 0x0602100E RID: 135182 RVA: 0x008E24E3 File Offset: 0x008E06E3
		// (set) Token: 0x0602100F RID: 135183 RVA: 0x008E24F3 File Offset: 0x008E06F3
		public unsafe float Frenel_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170033D2 RID: 13266
		// (get) Token: 0x06021010 RID: 135184 RVA: 0x008E2504 File Offset: 0x008E0704
		// (set) Token: 0x06021011 RID: 135185 RVA: 0x008E2518 File Offset: 0x008E0718
		public unsafe FLinearColor Frenel_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170033D3 RID: 13267
		// (get) Token: 0x06021012 RID: 135186 RVA: 0x008E252D File Offset: 0x008E072D
		// (set) Token: 0x06021013 RID: 135187 RVA: 0x008E2541 File Offset: 0x008E0741
		public unsafe FName Frenel_Intensity_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170033D4 RID: 13268
		// (get) Token: 0x06021014 RID: 135188 RVA: 0x008E2556 File Offset: 0x008E0756
		// (set) Token: 0x06021015 RID: 135189 RVA: 0x008E256A File Offset: 0x008E076A
		public unsafe FName Frenel_Color_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170033D5 RID: 13269
		// (get) Token: 0x06021016 RID: 135190 RVA: 0x008E257F File Offset: 0x008E077F
		// (set) Token: 0x06021017 RID: 135191 RVA: 0x008E258F File Offset: 0x008E078F
		public unsafe float BrightLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170033D6 RID: 13270
		// (get) Token: 0x06021018 RID: 135192 RVA: 0x008E25A0 File Offset: 0x008E07A0
		// (set) Token: 0x06021019 RID: 135193 RVA: 0x008E25B0 File Offset: 0x008E07B0
		public unsafe float FlickerTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170033D7 RID: 13271
		// (get) Token: 0x0602101A RID: 135194 RVA: 0x008E25C1 File Offset: 0x008E07C1
		// (set) Token: 0x0602101B RID: 135195 RVA: 0x008E25D1 File Offset: 0x008E07D1
		public unsafe float MinimumBright
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170033D8 RID: 13272
		// (get) Token: 0x0602101C RID: 135196 RVA: 0x008E25E2 File Offset: 0x008E07E2
		// (set) Token: 0x0602101D RID: 135197 RVA: 0x008E25F2 File Offset: 0x008E07F2
		public unsafe float ViewTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170033D9 RID: 13273
		// (get) Token: 0x0602101E RID: 135198 RVA: 0x008E2604 File Offset: 0x008E0804
		// (set) Token: 0x0602101F RID: 135199 RVA: 0x008E263D File Offset: 0x008E083D
		public TMap<FName, float> CustomScale
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._CustomScale) == null)
				{
					result = (this._CustomScale = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_16, this));
				}
				return result;
			}
			set
			{
				this.CustomScale.CopyAssign(value);
			}
		}

		// Token: 0x170033DA RID: 13274
		// (get) Token: 0x06021020 RID: 135200 RVA: 0x008E264C File Offset: 0x008E084C
		// (set) Token: 0x06021021 RID: 135201 RVA: 0x008E2685 File Offset: 0x008E0885
		public TMap<FName, FLinearColor> CustomColor
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._CustomColor) == null)
				{
					result = (this._CustomColor = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_17, this));
				}
				return result;
			}
			set
			{
				this.CustomColor.CopyAssign(value);
			}
		}

		// Token: 0x170033DB RID: 13275
		// (get) Token: 0x06021022 RID: 135202 RVA: 0x008E2694 File Offset: 0x008E0894
		// (set) Token: 0x06021023 RID: 135203 RVA: 0x008E26CD File Offset: 0x008E08CD
		public TArray<UMaterialInterface> CustomOverrideMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._CustomOverrideMaterials) == null)
				{
					result = (this._CustomOverrideMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_18, this));
				}
				return result;
			}
			set
			{
				this.CustomOverrideMaterials.CopyAssign(value);
			}
		}

		// Token: 0x170033DC RID: 13276
		// (get) Token: 0x06021024 RID: 135204 RVA: 0x008E26DC File Offset: 0x008E08DC
		// (set) Token: 0x06021025 RID: 135205 RVA: 0x008E2715 File Offset: 0x008E0915
		public TArray<float> CustomData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CustomData) == null)
				{
					result = (this._CustomData = new TArray<float>(base.NativePtr + (IntPtr)BP_LightModel_C.__PropertyOffset_19, this));
				}
				return result;
			}
			set
			{
				this.CustomData.CopyAssign(value);
			}
		}

		// Token: 0x06021026 RID: 135206 RVA: 0x008E2724 File Offset: 0x008E0924
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual int GetPlacementSortOrder()
		{
			BP_LightModel_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_LightModel_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightModel_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightModel_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightModel_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06021027 RID: 135207 RVA: 0x008E276C File Offset: 0x008E096C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual int GetPlacementSortOrder_Implementation()
		{
			BP_LightModel_C.__GetPlacementSortOrder_FunctionParams* ptr = stackalloc BP_LightModel_C.__GetPlacementSortOrder_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LightModel_C.__GetPlacementSortOrder_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightModel_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightModel_C.__GetPlacementSortOrder_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06021028 RID: 135208 RVA: 0x008E27B4 File Offset: 0x008E09B4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Custom_Parameter(UMaterialInstanceDynamic MaterialIns)
		{
			BP_LightModel_C.__Custom_Parameter_FunctionParams* ptr = stackalloc BP_LightModel_C.__Custom_Parameter_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BP_LightModel_C.__Custom_Parameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LightModel_C.__Custom_Parameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MaterialIns = ((MaterialIns != null) ? MaterialIns.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightModel_C.__Custom_Parameter_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021029 RID: 135209 RVA: 0x008E280C File Offset: 0x008E0A0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LightModel_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602102A RID: 135210 RVA: 0x008E2820 File Offset: 0x008E0A20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LightModel_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602102B RID: 135211 RVA: 0x008E2835 File Offset: 0x008E0A35
		protected BP_LightModel_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040100BC RID: 65724
		internal static int __InterfaceOffset_IInterface_KuroLightBP;

		// Token: 0x040100BD RID: 65725
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_LightModel.BP_LightModel_C";

		// Token: 0x040100BE RID: 65726
		private static IntPtr _ClassPtr;

		// Token: 0x040100BF RID: 65727
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040100C0 RID: 65728
		internal static int __PropertyOffset_0;

		// Token: 0x040100C1 RID: 65729
		internal static int __PropertyOffset_1;

		// Token: 0x040100C2 RID: 65730
		internal static int __PropertyOffset_2;

		// Token: 0x040100C3 RID: 65731
		internal static int __PropertyOffset_3;

		// Token: 0x040100C4 RID: 65732
		internal static int __PropertyOffset_4;

		// Token: 0x040100C5 RID: 65733
		internal static int __PropertyOffset_5;

		// Token: 0x040100C6 RID: 65734
		internal static int __PropertyOffset_6;

		// Token: 0x040100C7 RID: 65735
		internal static int __PropertyOffset_7;

		// Token: 0x040100C8 RID: 65736
		internal static int __PropertyOffset_8;

		// Token: 0x040100C9 RID: 65737
		internal static int __PropertyOffset_9;

		// Token: 0x040100CA RID: 65738
		internal static int __PropertyOffset_10;

		// Token: 0x040100CB RID: 65739
		internal static int __PropertyOffset_11;

		// Token: 0x040100CC RID: 65740
		internal static int __PropertyOffset_12;

		// Token: 0x040100CD RID: 65741
		internal static int __PropertyOffset_13;

		// Token: 0x040100CE RID: 65742
		internal static int __PropertyOffset_14;

		// Token: 0x040100CF RID: 65743
		internal static int __PropertyOffset_15;

		// Token: 0x040100D0 RID: 65744
		internal static int __PropertyOffset_16;

		// Token: 0x040100D1 RID: 65745
		[Nullable(2)]
		private TMap<FName, float> _CustomScale;

		// Token: 0x040100D2 RID: 65746
		internal static int __PropertyOffset_17;

		// Token: 0x040100D3 RID: 65747
		[Nullable(2)]
		private TMap<FName, FLinearColor> _CustomColor;

		// Token: 0x040100D4 RID: 65748
		internal static int __PropertyOffset_18;

		// Token: 0x040100D5 RID: 65749
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _CustomOverrideMaterials;

		// Token: 0x040100D6 RID: 65750
		internal static int __PropertyOffset_19;

		// Token: 0x040100D7 RID: 65751
		[Nullable(2)]
		private TArray<float> _CustomData;

		// Token: 0x040100D8 RID: 65752
		private static IntPtr __GetPlacementSortOrder_NativeFunctionPtr;

		// Token: 0x040100D9 RID: 65753
		private static IntPtr __Custom_Parameter_NativeFunctionPtr;

		// Token: 0x040100DA RID: 65754
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x02009C58 RID: 40024
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPlacementSortOrder_FunctionParams
		{
			// Token: 0x04031314 RID: 201492
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02009C59 RID: 40025
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __Custom_Parameter_FunctionParams
		{
			// Token: 0x04031315 RID: 201493
			[FieldOffset(0)]
			public IntPtr MaterialIns;
		}
	}
}
