using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common
{
	// Token: 0x02003E7C RID: 15996
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_DistortionWave.BP_DistortionWave_C")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1228)]
	public class BP_DistortionWave_C : __TsBpFxEffect_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602854F RID: 165199 RVA: 0x009A9F40 File Offset: 0x009A8140
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DistortionWave_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_DistortionWave.BP_DistortionWave_C");
			}
			return BP_DistortionWave_C._ClassPtr;
		}

		// Token: 0x06028550 RID: 165200 RVA: 0x009A9F64 File Offset: 0x009A8164
		public BP_DistortionWave_C() : this(BuiltinUtils.AllocNativeUObject(BP_DistortionWave_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028551 RID: 165201 RVA: 0x009A9F8C File Offset: 0x009A818C
		[NullableContext(1)]
		public BP_DistortionWave_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DistortionWave_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D32 RID: 23858
		// (get) Token: 0x06028552 RID: 165202 RVA: 0x009A9FBF File Offset: 0x009A81BF
		// (set) Token: 0x06028553 RID: 165203 RVA: 0x009A9FD3 File Offset: 0x009A81D3
		public unsafe UPostProcessComponent PostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005D33 RID: 23859
		// (get) Token: 0x06028554 RID: 165204 RVA: 0x009A9FE8 File Offset: 0x009A81E8
		// (set) Token: 0x06028555 RID: 165205 RVA: 0x009A9FF8 File Offset: 0x009A81F8
		public unsafe float Timeline_0_heiping_F498AE8B4953C4FCA8CB1685A329F1E7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005D34 RID: 23860
		// (get) Token: 0x06028556 RID: 165206 RVA: 0x009AA009 File Offset: 0x009A8209
		// (set) Token: 0x06028557 RID: 165207 RVA: 0x009AA019 File Offset: 0x009A8219
		public unsafe float Timeline_0_LUT_F498AE8B4953C4FCA8CB1685A329F1E7
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005D35 RID: 23861
		// (get) Token: 0x06028558 RID: 165208 RVA: 0x009AA02A File Offset: 0x009A822A
		// (set) Token: 0x06028559 RID: 165209 RVA: 0x009AA03E File Offset: 0x009A823E
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_0__Direction_F498AE8B4953C4FCA8CB1685A329F1E7
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_4);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005D36 RID: 23862
		// (get) Token: 0x0602855A RID: 165210 RVA: 0x009AA053 File Offset: 0x009A8253
		// (set) Token: 0x0602855B RID: 165211 RVA: 0x009AA067 File Offset: 0x009A8267
		public unsafe UTimelineComponent Timeline_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005D37 RID: 23863
		// (get) Token: 0x0602855C RID: 165212 RVA: 0x009AA07C File Offset: 0x009A827C
		// (set) Token: 0x0602855D RID: 165213 RVA: 0x009AA08C File Offset: 0x009A828C
		public unsafe float __________7E2D64524C81AE74B55541807D0FA0EB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005D38 RID: 23864
		// (get) Token: 0x0602855E RID: 165214 RVA: 0x009AA09D File Offset: 0x009A829D
		// (set) Token: 0x0602855F RID: 165215 RVA: 0x009AA0B1 File Offset: 0x009A82B1
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> ______Direction_7E2D64524C81AE74B55541807D0FA0EB
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_7);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005D39 RID: 23865
		// (get) Token: 0x06028560 RID: 165216 RVA: 0x009AA0C6 File Offset: 0x009A82C6
		// (set) Token: 0x06028561 RID: 165217 RVA: 0x009AA0DA File Offset: 0x009A82DA
		public unsafe UTimelineComponent 衰退范围
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005D3A RID: 23866
		// (get) Token: 0x06028562 RID: 165218 RVA: 0x009AA0EF File Offset: 0x009A82EF
		// (set) Token: 0x06028563 RID: 165219 RVA: 0x009AA0FF File Offset: 0x009A82FF
		public unsafe float __________3E10D26547837C4A20A06C899EDEC0D1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005D3B RID: 23867
		// (get) Token: 0x06028564 RID: 165220 RVA: 0x009AA110 File Offset: 0x009A8310
		// (set) Token: 0x06028565 RID: 165221 RVA: 0x009AA124 File Offset: 0x009A8324
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> ______Direction_3E10D26547837C4A20A06C899EDEC0D1
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_10);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005D3C RID: 23868
		// (get) Token: 0x06028566 RID: 165222 RVA: 0x009AA139 File Offset: 0x009A8339
		// (set) Token: 0x06028567 RID: 165223 RVA: 0x009AA14D File Offset: 0x009A834D
		public unsafe UTimelineComponent 轮廓强度
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17005D3D RID: 23869
		// (get) Token: 0x06028568 RID: 165224 RVA: 0x009AA162 File Offset: 0x009A8362
		// (set) Token: 0x06028569 RID: 165225 RVA: 0x009AA172 File Offset: 0x009A8372
		public unsafe float ______NewTrack_0_526C2D26477019A3632C9B84238820CB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005D3E RID: 23870
		// (get) Token: 0x0602856A RID: 165226 RVA: 0x009AA183 File Offset: 0x009A8383
		// (set) Token: 0x0602856B RID: 165227 RVA: 0x009AA197 File Offset: 0x009A8397
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> _______Direction_526C2D26477019A3632C9B84238820CB
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_13);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17005D3F RID: 23871
		// (get) Token: 0x0602856C RID: 165228 RVA: 0x009AA1AC File Offset: 0x009A83AC
		// (set) Token: 0x0602856D RID: 165229 RVA: 0x009AA1C0 File Offset: 0x009A83C0
		public unsafe UTimelineComponent 扫描带强度
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17005D40 RID: 23872
		// (get) Token: 0x0602856E RID: 165230 RVA: 0x009AA1D5 File Offset: 0x009A83D5
		// (set) Token: 0x0602856F RID: 165231 RVA: 0x009AA1E5 File Offset: 0x009A83E5
		public unsafe float _____NewTrack_0_175C8B6644C323A3919A3BBDAA349603
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005D41 RID: 23873
		// (get) Token: 0x06028570 RID: 165232 RVA: 0x009AA1F6 File Offset: 0x009A83F6
		// (set) Token: 0x06028571 RID: 165233 RVA: 0x009AA20A File Offset: 0x009A840A
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> ______Direction_175C8B6644C323A3919A3BBDAA349603
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_16);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005D42 RID: 23874
		// (get) Token: 0x06028572 RID: 165234 RVA: 0x009AA21F File Offset: 0x009A841F
		// (set) Token: 0x06028573 RID: 165235 RVA: 0x009AA233 File Offset: 0x009A8433
		public unsafe UTimelineComponent 扫描范围
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17005D43 RID: 23875
		// (get) Token: 0x06028574 RID: 165236 RVA: 0x009AA248 File Offset: 0x009A8448
		// (set) Token: 0x06028575 RID: 165237 RVA: 0x009AA25C File Offset: 0x009A845C
		public unsafe UMaterialInterface ScanMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17005D44 RID: 23876
		// (get) Token: 0x06028576 RID: 165238 RVA: 0x009AA271 File Offset: 0x009A8471
		// (set) Token: 0x06028577 RID: 165239 RVA: 0x009AA281 File Offset: 0x009A8481
		public unsafe bool 反向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D45 RID: 23877
		// (get) Token: 0x06028578 RID: 165240 RVA: 0x009AA292 File Offset: 0x009A8492
		// (set) Token: 0x06028579 RID: 165241 RVA: 0x009AA2A2 File Offset: 0x009A84A2
		public unsafe float Play_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17005D46 RID: 23878
		// (get) Token: 0x0602857A RID: 165242 RVA: 0x009AA2B3 File Offset: 0x009A84B3
		// (set) Token: 0x0602857B RID: 165243 RVA: 0x009AA2C7 File Offset: 0x009A84C7
		public unsafe UMaterialInstanceDynamic ScanMaterialMID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17005D47 RID: 23879
		// (get) Token: 0x0602857C RID: 165244 RVA: 0x009AA2DC File Offset: 0x009A84DC
		// (set) Token: 0x0602857D RID: 165245 RVA: 0x009AA2EC File Offset: 0x009A84EC
		public unsafe float PlaySpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17005D48 RID: 23880
		// (get) Token: 0x0602857E RID: 165246 RVA: 0x009AA2FD File Offset: 0x009A84FD
		// (set) Token: 0x0602857F RID: 165247 RVA: 0x009AA30D File Offset: 0x009A850D
		public unsafe bool StartTicking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D49 RID: 23881
		// (get) Token: 0x06028580 RID: 165248 RVA: 0x009AA31E File Offset: 0x009A851E
		// (set) Token: 0x06028581 RID: 165249 RVA: 0x009AA32E File Offset: 0x009A852E
		public unsafe bool IsUsedForSeq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D4A RID: 23882
		// (get) Token: 0x06028582 RID: 165250 RVA: 0x009AA33F File Offset: 0x009A853F
		// (set) Token: 0x06028583 RID: 165251 RVA: 0x009AA34F File Offset: 0x009A854F
		public unsafe float SeqLifeCycle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x06028584 RID: 165252 RVA: 0x009AA360 File Offset: 0x009A8560
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartScanEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__StartScanEffect_NativeFunctionPtr, null);
		}

		// Token: 0x06028585 RID: 165253 RVA: 0x009AA374 File Offset: 0x009A8574
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetRevert()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__SetRevert_NativeFunctionPtr, null);
		}

		// Token: 0x06028586 RID: 165254 RVA: 0x009AA388 File Offset: 0x009A8588
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 轮廓强度__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__轮廓强度__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06028587 RID: 165255 RVA: 0x009AA39C File Offset: 0x009A859C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 轮廓强度__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__轮廓强度__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06028588 RID: 165256 RVA: 0x009AA3B0 File Offset: 0x009A85B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 衰退范围__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__衰退范围__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06028589 RID: 165257 RVA: 0x009AA3C4 File Offset: 0x009A85C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 衰退范围__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__衰退范围__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0602858A RID: 165258 RVA: 0x009AA3D8 File Offset: 0x009A85D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_0__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__Timeline_0__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0602858B RID: 165259 RVA: 0x009AA3EC File Offset: 0x009A85EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_0__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__Timeline_0__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0602858C RID: 165260 RVA: 0x009AA400 File Offset: 0x009A8600
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 扫描带强度__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__扫描带强度__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0602858D RID: 165261 RVA: 0x009AA414 File Offset: 0x009A8614
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 扫描带强度__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__扫描带强度__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0602858E RID: 165262 RVA: 0x009AA428 File Offset: 0x009A8628
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 扫描范围__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__扫描范围__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0602858F RID: 165263 RVA: 0x009AA43C File Offset: 0x009A863C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 扫描范围__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__扫描范围__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06028590 RID: 165264 RVA: 0x009AA450 File Offset: 0x009A8650
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_DistortionWave_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DistortionWave_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DistortionWave_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DistortionWave_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06028591 RID: 165265 RVA: 0x009AA498 File Offset: 0x009A8698
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_DistortionWave_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DistortionWave_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DistortionWave_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DistortionWave_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DistortionWave_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06028592 RID: 165266 RVA: 0x009AA4DF File Offset: 0x009A86DF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06028593 RID: 165267 RVA: 0x009AA4F3 File Offset: 0x009A86F3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DistortionWave_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06028594 RID: 165268 RVA: 0x009AA508 File Offset: 0x009A8708
		protected BP_DistortionWave_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040148D6 RID: 84182
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_DistortionWave.BP_DistortionWave_C";

		// Token: 0x040148D7 RID: 84183
		private static IntPtr _ClassPtr;

		// Token: 0x040148D8 RID: 84184
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040148D9 RID: 84185
		internal static int __PropertyOffset_1;

		// Token: 0x040148DA RID: 84186
		internal static int __PropertyOffset_2;

		// Token: 0x040148DB RID: 84187
		internal static int __PropertyOffset_3;

		// Token: 0x040148DC RID: 84188
		internal static int __PropertyOffset_4;

		// Token: 0x040148DD RID: 84189
		internal static int __PropertyOffset_5;

		// Token: 0x040148DE RID: 84190
		internal static int __PropertyOffset_6;

		// Token: 0x040148DF RID: 84191
		internal static int __PropertyOffset_7;

		// Token: 0x040148E0 RID: 84192
		internal static int __PropertyOffset_8;

		// Token: 0x040148E1 RID: 84193
		internal static int __PropertyOffset_9;

		// Token: 0x040148E2 RID: 84194
		internal static int __PropertyOffset_10;

		// Token: 0x040148E3 RID: 84195
		internal static int __PropertyOffset_11;

		// Token: 0x040148E4 RID: 84196
		internal static int __PropertyOffset_12;

		// Token: 0x040148E5 RID: 84197
		internal static int __PropertyOffset_13;

		// Token: 0x040148E6 RID: 84198
		internal static int __PropertyOffset_14;

		// Token: 0x040148E7 RID: 84199
		internal static int __PropertyOffset_15;

		// Token: 0x040148E8 RID: 84200
		internal static int __PropertyOffset_16;

		// Token: 0x040148E9 RID: 84201
		internal static int __PropertyOffset_17;

		// Token: 0x040148EA RID: 84202
		internal static int __PropertyOffset_18;

		// Token: 0x040148EB RID: 84203
		internal static int __PropertyOffset_19;

		// Token: 0x040148EC RID: 84204
		internal static int __PropertyOffset_20;

		// Token: 0x040148ED RID: 84205
		internal static int __PropertyOffset_21;

		// Token: 0x040148EE RID: 84206
		internal static int __PropertyOffset_22;

		// Token: 0x040148EF RID: 84207
		internal static int __PropertyOffset_23;

		// Token: 0x040148F0 RID: 84208
		internal static int __PropertyOffset_24;

		// Token: 0x040148F1 RID: 84209
		internal static int __PropertyOffset_25;

		// Token: 0x040148F2 RID: 84210
		private static IntPtr __StartScanEffect_NativeFunctionPtr;

		// Token: 0x040148F3 RID: 84211
		private static IntPtr __SetRevert_NativeFunctionPtr;

		// Token: 0x040148F4 RID: 84212
		private static IntPtr __轮廓强度__FinishedFunc_NativeFunctionPtr;

		// Token: 0x040148F5 RID: 84213
		private static IntPtr __轮廓强度__UpdateFunc_NativeFunctionPtr;

		// Token: 0x040148F6 RID: 84214
		private static IntPtr __衰退范围__FinishedFunc_NativeFunctionPtr;

		// Token: 0x040148F7 RID: 84215
		private static IntPtr __衰退范围__UpdateFunc_NativeFunctionPtr;

		// Token: 0x040148F8 RID: 84216
		private static IntPtr __Timeline_0__FinishedFunc_NativeFunctionPtr;

		// Token: 0x040148F9 RID: 84217
		private static IntPtr __Timeline_0__UpdateFunc_NativeFunctionPtr;

		// Token: 0x040148FA RID: 84218
		private static IntPtr __扫描带强度__FinishedFunc_NativeFunctionPtr;

		// Token: 0x040148FB RID: 84219
		private static IntPtr __扫描带强度__UpdateFunc_NativeFunctionPtr;

		// Token: 0x040148FC RID: 84220
		private static IntPtr __扫描范围__FinishedFunc_NativeFunctionPtr;

		// Token: 0x040148FD RID: 84221
		private static IntPtr __扫描范围__UpdateFunc_NativeFunctionPtr;

		// Token: 0x040148FE RID: 84222
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040148FF RID: 84223
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0200A2D0 RID: 41680
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04032012 RID: 204818
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
