using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common
{
	// Token: 0x02003E7F RID: 15999
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Scanning_2_7.BP_Fx_Scanning_2_7_C")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1228)]
	public class BP_Fx_Scanning_2_7_C : __TsBpFxEffect_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060285BF RID: 165311 RVA: 0x009AAA18 File Offset: 0x009A8C18
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Fx_Scanning_2_7_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Scanning_2_7.BP_Fx_Scanning_2_7_C");
			}
			return BP_Fx_Scanning_2_7_C._ClassPtr;
		}

		// Token: 0x060285C0 RID: 165312 RVA: 0x009AAA3C File Offset: 0x009A8C3C
		public BP_Fx_Scanning_2_7_C() : this(BuiltinUtils.AllocNativeUObject(BP_Fx_Scanning_2_7_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060285C1 RID: 165313 RVA: 0x009AAA64 File Offset: 0x009A8C64
		[NullableContext(1)]
		public BP_Fx_Scanning_2_7_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Fx_Scanning_2_7_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D58 RID: 23896
		// (get) Token: 0x060285C2 RID: 165314 RVA: 0x009AAA97 File Offset: 0x009A8C97
		// (set) Token: 0x060285C3 RID: 165315 RVA: 0x009AAAAB File Offset: 0x009A8CAB
		public unsafe UPostProcessComponent PostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005D59 RID: 23897
		// (get) Token: 0x060285C4 RID: 165316 RVA: 0x009AAAC0 File Offset: 0x009A8CC0
		// (set) Token: 0x060285C5 RID: 165317 RVA: 0x009AAAD0 File Offset: 0x009A8CD0
		public unsafe float Timeline_0_heiping_26A4F0B3447A7F029D57DD9F98C94050
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005D5A RID: 23898
		// (get) Token: 0x060285C6 RID: 165318 RVA: 0x009AAAE1 File Offset: 0x009A8CE1
		// (set) Token: 0x060285C7 RID: 165319 RVA: 0x009AAAF1 File Offset: 0x009A8CF1
		public unsafe float Timeline_0_LUT_26A4F0B3447A7F029D57DD9F98C94050
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005D5B RID: 23899
		// (get) Token: 0x060285C8 RID: 165320 RVA: 0x009AAB02 File Offset: 0x009A8D02
		// (set) Token: 0x060285C9 RID: 165321 RVA: 0x009AAB16 File Offset: 0x009A8D16
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_0__Direction_26A4F0B3447A7F029D57DD9F98C94050
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_4);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005D5C RID: 23900
		// (get) Token: 0x060285CA RID: 165322 RVA: 0x009AAB2B File Offset: 0x009A8D2B
		// (set) Token: 0x060285CB RID: 165323 RVA: 0x009AAB3F File Offset: 0x009A8D3F
		public unsafe UTimelineComponent Timeline_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005D5D RID: 23901
		// (get) Token: 0x060285CC RID: 165324 RVA: 0x009AAB54 File Offset: 0x009A8D54
		// (set) Token: 0x060285CD RID: 165325 RVA: 0x009AAB64 File Offset: 0x009A8D64
		public unsafe float __________4C5B91014089D599A5FB9C8759D37F26
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005D5E RID: 23902
		// (get) Token: 0x060285CE RID: 165326 RVA: 0x009AAB75 File Offset: 0x009A8D75
		// (set) Token: 0x060285CF RID: 165327 RVA: 0x009AAB89 File Offset: 0x009A8D89
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> ______Direction_4C5B91014089D599A5FB9C8759D37F26
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_7);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005D5F RID: 23903
		// (get) Token: 0x060285D0 RID: 165328 RVA: 0x009AAB9E File Offset: 0x009A8D9E
		// (set) Token: 0x060285D1 RID: 165329 RVA: 0x009AABB2 File Offset: 0x009A8DB2
		public unsafe UTimelineComponent 衰退范围
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005D60 RID: 23904
		// (get) Token: 0x060285D2 RID: 165330 RVA: 0x009AABC7 File Offset: 0x009A8DC7
		// (set) Token: 0x060285D3 RID: 165331 RVA: 0x009AABD7 File Offset: 0x009A8DD7
		public unsafe float __________EC357DD942DC2CB793230ABE2809390C
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005D61 RID: 23905
		// (get) Token: 0x060285D4 RID: 165332 RVA: 0x009AABE8 File Offset: 0x009A8DE8
		// (set) Token: 0x060285D5 RID: 165333 RVA: 0x009AABFC File Offset: 0x009A8DFC
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> ______Direction_EC357DD942DC2CB793230ABE2809390C
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_10);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005D62 RID: 23906
		// (get) Token: 0x060285D6 RID: 165334 RVA: 0x009AAC11 File Offset: 0x009A8E11
		// (set) Token: 0x060285D7 RID: 165335 RVA: 0x009AAC25 File Offset: 0x009A8E25
		public unsafe UTimelineComponent 轮廓强度
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17005D63 RID: 23907
		// (get) Token: 0x060285D8 RID: 165336 RVA: 0x009AAC3A File Offset: 0x009A8E3A
		// (set) Token: 0x060285D9 RID: 165337 RVA: 0x009AAC4A File Offset: 0x009A8E4A
		public unsafe float ______NewTrack_0_54592E184B553C57485F69996828A3B7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005D64 RID: 23908
		// (get) Token: 0x060285DA RID: 165338 RVA: 0x009AAC5B File Offset: 0x009A8E5B
		// (set) Token: 0x060285DB RID: 165339 RVA: 0x009AAC6F File Offset: 0x009A8E6F
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> _______Direction_54592E184B553C57485F69996828A3B7
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_13);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17005D65 RID: 23909
		// (get) Token: 0x060285DC RID: 165340 RVA: 0x009AAC84 File Offset: 0x009A8E84
		// (set) Token: 0x060285DD RID: 165341 RVA: 0x009AAC98 File Offset: 0x009A8E98
		public unsafe UTimelineComponent 扫描带强度
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17005D66 RID: 23910
		// (get) Token: 0x060285DE RID: 165342 RVA: 0x009AACAD File Offset: 0x009A8EAD
		// (set) Token: 0x060285DF RID: 165343 RVA: 0x009AACBD File Offset: 0x009A8EBD
		public unsafe float _____NewTrack_0_DA519B584841DBEF7DB959A666386E51
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005D67 RID: 23911
		// (get) Token: 0x060285E0 RID: 165344 RVA: 0x009AACCE File Offset: 0x009A8ECE
		// (set) Token: 0x060285E1 RID: 165345 RVA: 0x009AACE2 File Offset: 0x009A8EE2
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> ______Direction_DA519B584841DBEF7DB959A666386E51
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_16);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005D68 RID: 23912
		// (get) Token: 0x060285E2 RID: 165346 RVA: 0x009AACF7 File Offset: 0x009A8EF7
		// (set) Token: 0x060285E3 RID: 165347 RVA: 0x009AAD0B File Offset: 0x009A8F0B
		public unsafe UTimelineComponent 扫描范围
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17005D69 RID: 23913
		// (get) Token: 0x060285E4 RID: 165348 RVA: 0x009AAD20 File Offset: 0x009A8F20
		// (set) Token: 0x060285E5 RID: 165349 RVA: 0x009AAD34 File Offset: 0x009A8F34
		public unsafe UMaterialInterface ScanMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17005D6A RID: 23914
		// (get) Token: 0x060285E6 RID: 165350 RVA: 0x009AAD49 File Offset: 0x009A8F49
		// (set) Token: 0x060285E7 RID: 165351 RVA: 0x009AAD59 File Offset: 0x009A8F59
		public unsafe bool 反向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D6B RID: 23915
		// (get) Token: 0x060285E8 RID: 165352 RVA: 0x009AAD6A File Offset: 0x009A8F6A
		// (set) Token: 0x060285E9 RID: 165353 RVA: 0x009AAD7A File Offset: 0x009A8F7A
		public unsafe float Play_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17005D6C RID: 23916
		// (get) Token: 0x060285EA RID: 165354 RVA: 0x009AAD8B File Offset: 0x009A8F8B
		// (set) Token: 0x060285EB RID: 165355 RVA: 0x009AAD9F File Offset: 0x009A8F9F
		public unsafe UMaterialInstanceDynamic ScanMaterialMID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17005D6D RID: 23917
		// (get) Token: 0x060285EC RID: 165356 RVA: 0x009AADB4 File Offset: 0x009A8FB4
		// (set) Token: 0x060285ED RID: 165357 RVA: 0x009AADC4 File Offset: 0x009A8FC4
		public unsafe float PlaySpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17005D6E RID: 23918
		// (get) Token: 0x060285EE RID: 165358 RVA: 0x009AADD5 File Offset: 0x009A8FD5
		// (set) Token: 0x060285EF RID: 165359 RVA: 0x009AADE5 File Offset: 0x009A8FE5
		public unsafe bool StartTicking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D6F RID: 23919
		// (get) Token: 0x060285F0 RID: 165360 RVA: 0x009AADF6 File Offset: 0x009A8FF6
		// (set) Token: 0x060285F1 RID: 165361 RVA: 0x009AAE06 File Offset: 0x009A9006
		public unsafe bool IsUsedForSeq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D70 RID: 23920
		// (get) Token: 0x060285F2 RID: 165362 RVA: 0x009AAE17 File Offset: 0x009A9017
		// (set) Token: 0x060285F3 RID: 165363 RVA: 0x009AAE27 File Offset: 0x009A9027
		public unsafe float SeqLifeCycle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x060285F4 RID: 165364 RVA: 0x009AAE38 File Offset: 0x009A9038
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartScanEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__StartScanEffect_NativeFunctionPtr, null);
		}

		// Token: 0x060285F5 RID: 165365 RVA: 0x009AAE4C File Offset: 0x009A904C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetRevert()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__SetRevert_NativeFunctionPtr, null);
		}

		// Token: 0x060285F6 RID: 165366 RVA: 0x009AAE60 File Offset: 0x009A9060
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 扫描范围__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__扫描范围__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x060285F7 RID: 165367 RVA: 0x009AAE74 File Offset: 0x009A9074
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 扫描范围__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__扫描范围__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x060285F8 RID: 165368 RVA: 0x009AAE88 File Offset: 0x009A9088
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 扫描带强度__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__扫描带强度__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x060285F9 RID: 165369 RVA: 0x009AAE9C File Offset: 0x009A909C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 扫描带强度__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__扫描带强度__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x060285FA RID: 165370 RVA: 0x009AAEB0 File Offset: 0x009A90B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 轮廓强度__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__轮廓强度__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x060285FB RID: 165371 RVA: 0x009AAEC4 File Offset: 0x009A90C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 轮廓强度__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__轮廓强度__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x060285FC RID: 165372 RVA: 0x009AAED8 File Offset: 0x009A90D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 衰退范围__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__衰退范围__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x060285FD RID: 165373 RVA: 0x009AAEEC File Offset: 0x009A90EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 衰退范围__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__衰退范围__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x060285FE RID: 165374 RVA: 0x009AAF00 File Offset: 0x009A9100
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_0__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__Timeline_0__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x060285FF RID: 165375 RVA: 0x009AAF14 File Offset: 0x009A9114
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_0__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__Timeline_0__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06028600 RID: 165376 RVA: 0x009AAF28 File Offset: 0x009A9128
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Fx_Scanning_2_7_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_Scanning_2_7_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_Scanning_2_7_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_Scanning_2_7_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06028601 RID: 165377 RVA: 0x009AAF70 File Offset: 0x009A9170
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Fx_Scanning_2_7_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_Scanning_2_7_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_Scanning_2_7_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_Scanning_2_7_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06028602 RID: 165378 RVA: 0x009AAFB7 File Offset: 0x009A91B7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06028603 RID: 165379 RVA: 0x009AAFCB File Offset: 0x009A91CB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06028604 RID: 165380 RVA: 0x009AAFE0 File Offset: 0x009A91E0
		protected BP_Fx_Scanning_2_7_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014918 RID: 84248
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Scanning_2_7.BP_Fx_Scanning_2_7_C";

		// Token: 0x04014919 RID: 84249
		private static IntPtr _ClassPtr;

		// Token: 0x0401491A RID: 84250
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401491B RID: 84251
		internal static int __PropertyOffset_1;

		// Token: 0x0401491C RID: 84252
		internal static int __PropertyOffset_2;

		// Token: 0x0401491D RID: 84253
		internal static int __PropertyOffset_3;

		// Token: 0x0401491E RID: 84254
		internal static int __PropertyOffset_4;

		// Token: 0x0401491F RID: 84255
		internal static int __PropertyOffset_5;

		// Token: 0x04014920 RID: 84256
		internal static int __PropertyOffset_6;

		// Token: 0x04014921 RID: 84257
		internal static int __PropertyOffset_7;

		// Token: 0x04014922 RID: 84258
		internal static int __PropertyOffset_8;

		// Token: 0x04014923 RID: 84259
		internal static int __PropertyOffset_9;

		// Token: 0x04014924 RID: 84260
		internal static int __PropertyOffset_10;

		// Token: 0x04014925 RID: 84261
		internal static int __PropertyOffset_11;

		// Token: 0x04014926 RID: 84262
		internal static int __PropertyOffset_12;

		// Token: 0x04014927 RID: 84263
		internal static int __PropertyOffset_13;

		// Token: 0x04014928 RID: 84264
		internal static int __PropertyOffset_14;

		// Token: 0x04014929 RID: 84265
		internal static int __PropertyOffset_15;

		// Token: 0x0401492A RID: 84266
		internal static int __PropertyOffset_16;

		// Token: 0x0401492B RID: 84267
		internal static int __PropertyOffset_17;

		// Token: 0x0401492C RID: 84268
		internal static int __PropertyOffset_18;

		// Token: 0x0401492D RID: 84269
		internal static int __PropertyOffset_19;

		// Token: 0x0401492E RID: 84270
		internal static int __PropertyOffset_20;

		// Token: 0x0401492F RID: 84271
		internal static int __PropertyOffset_21;

		// Token: 0x04014930 RID: 84272
		internal static int __PropertyOffset_22;

		// Token: 0x04014931 RID: 84273
		internal static int __PropertyOffset_23;

		// Token: 0x04014932 RID: 84274
		internal static int __PropertyOffset_24;

		// Token: 0x04014933 RID: 84275
		internal static int __PropertyOffset_25;

		// Token: 0x04014934 RID: 84276
		private static IntPtr __StartScanEffect_NativeFunctionPtr;

		// Token: 0x04014935 RID: 84277
		private static IntPtr __SetRevert_NativeFunctionPtr;

		// Token: 0x04014936 RID: 84278
		private static IntPtr __扫描范围__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04014937 RID: 84279
		private static IntPtr __扫描范围__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04014938 RID: 84280
		private static IntPtr __扫描带强度__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04014939 RID: 84281
		private static IntPtr __扫描带强度__UpdateFunc_NativeFunctionPtr;

		// Token: 0x0401493A RID: 84282
		private static IntPtr __轮廓强度__FinishedFunc_NativeFunctionPtr;

		// Token: 0x0401493B RID: 84283
		private static IntPtr __轮廓强度__UpdateFunc_NativeFunctionPtr;

		// Token: 0x0401493C RID: 84284
		private static IntPtr __衰退范围__FinishedFunc_NativeFunctionPtr;

		// Token: 0x0401493D RID: 84285
		private static IntPtr __衰退范围__UpdateFunc_NativeFunctionPtr;

		// Token: 0x0401493E RID: 84286
		private static IntPtr __Timeline_0__FinishedFunc_NativeFunctionPtr;

		// Token: 0x0401493F RID: 84287
		private static IntPtr __Timeline_0__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04014940 RID: 84288
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04014941 RID: 84289
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0200A2D5 RID: 41685
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04032018 RID: 204824
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
