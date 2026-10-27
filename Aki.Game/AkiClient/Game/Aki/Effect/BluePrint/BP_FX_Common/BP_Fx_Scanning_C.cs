using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common
{
	// Token: 0x02003E80 RID: 16000
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Scanning.BP_Fx_Scanning_C")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1228)]
	public class BP_Fx_Scanning_C : __TsBpFxEffect_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028605 RID: 165381 RVA: 0x009AAFE9 File Offset: 0x009A91E9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Fx_Scanning_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Scanning.BP_Fx_Scanning_C");
			}
			return BP_Fx_Scanning_C._ClassPtr;
		}

		// Token: 0x06028606 RID: 165382 RVA: 0x009AB010 File Offset: 0x009A9210
		public BP_Fx_Scanning_C() : this(BuiltinUtils.AllocNativeUObject(BP_Fx_Scanning_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028607 RID: 165383 RVA: 0x009AB038 File Offset: 0x009A9238
		[NullableContext(1)]
		public BP_Fx_Scanning_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Fx_Scanning_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D71 RID: 23921
		// (get) Token: 0x06028608 RID: 165384 RVA: 0x009AB06B File Offset: 0x009A926B
		// (set) Token: 0x06028609 RID: 165385 RVA: 0x009AB07F File Offset: 0x009A927F
		public unsafe UPostProcessComponent PostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005D72 RID: 23922
		// (get) Token: 0x0602860A RID: 165386 RVA: 0x009AB094 File Offset: 0x009A9294
		// (set) Token: 0x0602860B RID: 165387 RVA: 0x009AB0A4 File Offset: 0x009A92A4
		public unsafe float Timeline_0_heiping_353B1A7A4A9CB64DD0E9F4A743D43275
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005D73 RID: 23923
		// (get) Token: 0x0602860C RID: 165388 RVA: 0x009AB0B5 File Offset: 0x009A92B5
		// (set) Token: 0x0602860D RID: 165389 RVA: 0x009AB0C5 File Offset: 0x009A92C5
		public unsafe float Timeline_0_LUT_353B1A7A4A9CB64DD0E9F4A743D43275
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005D74 RID: 23924
		// (get) Token: 0x0602860E RID: 165390 RVA: 0x009AB0D6 File Offset: 0x009A92D6
		// (set) Token: 0x0602860F RID: 165391 RVA: 0x009AB0EA File Offset: 0x009A92EA
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Timeline_0__Direction_353B1A7A4A9CB64DD0E9F4A743D43275
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_4);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005D75 RID: 23925
		// (get) Token: 0x06028610 RID: 165392 RVA: 0x009AB0FF File Offset: 0x009A92FF
		// (set) Token: 0x06028611 RID: 165393 RVA: 0x009AB113 File Offset: 0x009A9313
		public unsafe UTimelineComponent Timeline_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005D76 RID: 23926
		// (get) Token: 0x06028612 RID: 165394 RVA: 0x009AB128 File Offset: 0x009A9328
		// (set) Token: 0x06028613 RID: 165395 RVA: 0x009AB138 File Offset: 0x009A9338
		public unsafe float __________51722C4C46877BE320D640A615DF102A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005D77 RID: 23927
		// (get) Token: 0x06028614 RID: 165396 RVA: 0x009AB149 File Offset: 0x009A9349
		// (set) Token: 0x06028615 RID: 165397 RVA: 0x009AB15D File Offset: 0x009A935D
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> ______Direction_51722C4C46877BE320D640A615DF102A
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_7);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005D78 RID: 23928
		// (get) Token: 0x06028616 RID: 165398 RVA: 0x009AB172 File Offset: 0x009A9372
		// (set) Token: 0x06028617 RID: 165399 RVA: 0x009AB186 File Offset: 0x009A9386
		public unsafe UTimelineComponent 衰退范围
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005D79 RID: 23929
		// (get) Token: 0x06028618 RID: 165400 RVA: 0x009AB19B File Offset: 0x009A939B
		// (set) Token: 0x06028619 RID: 165401 RVA: 0x009AB1AB File Offset: 0x009A93AB
		public unsafe float __________4BA202604863CA55AF0FC0B49F86965B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005D7A RID: 23930
		// (get) Token: 0x0602861A RID: 165402 RVA: 0x009AB1BC File Offset: 0x009A93BC
		// (set) Token: 0x0602861B RID: 165403 RVA: 0x009AB1D0 File Offset: 0x009A93D0
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> ______Direction_4BA202604863CA55AF0FC0B49F86965B
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_10);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005D7B RID: 23931
		// (get) Token: 0x0602861C RID: 165404 RVA: 0x009AB1E5 File Offset: 0x009A93E5
		// (set) Token: 0x0602861D RID: 165405 RVA: 0x009AB1F9 File Offset: 0x009A93F9
		public unsafe UTimelineComponent 轮廓强度
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17005D7C RID: 23932
		// (get) Token: 0x0602861E RID: 165406 RVA: 0x009AB20E File Offset: 0x009A940E
		// (set) Token: 0x0602861F RID: 165407 RVA: 0x009AB21E File Offset: 0x009A941E
		public unsafe float ______NewTrack_0_F355743F48DC9EB377A77A9C1115080C
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005D7D RID: 23933
		// (get) Token: 0x06028620 RID: 165408 RVA: 0x009AB22F File Offset: 0x009A942F
		// (set) Token: 0x06028621 RID: 165409 RVA: 0x009AB243 File Offset: 0x009A9443
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> _______Direction_F355743F48DC9EB377A77A9C1115080C
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_13);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17005D7E RID: 23934
		// (get) Token: 0x06028622 RID: 165410 RVA: 0x009AB258 File Offset: 0x009A9458
		// (set) Token: 0x06028623 RID: 165411 RVA: 0x009AB26C File Offset: 0x009A946C
		public unsafe UTimelineComponent 扫描带强度
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17005D7F RID: 23935
		// (get) Token: 0x06028624 RID: 165412 RVA: 0x009AB281 File Offset: 0x009A9481
		// (set) Token: 0x06028625 RID: 165413 RVA: 0x009AB291 File Offset: 0x009A9491
		public unsafe float _____NewTrack_0_06BB87C141833981013181AD8BBDFB4F
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005D80 RID: 23936
		// (get) Token: 0x06028626 RID: 165414 RVA: 0x009AB2A2 File Offset: 0x009A94A2
		// (set) Token: 0x06028627 RID: 165415 RVA: 0x009AB2B6 File Offset: 0x009A94B6
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> ______Direction_06BB87C141833981013181AD8BBDFB4F
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_16);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005D81 RID: 23937
		// (get) Token: 0x06028628 RID: 165416 RVA: 0x009AB2CB File Offset: 0x009A94CB
		// (set) Token: 0x06028629 RID: 165417 RVA: 0x009AB2DF File Offset: 0x009A94DF
		public unsafe UTimelineComponent 扫描范围
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17005D82 RID: 23938
		// (get) Token: 0x0602862A RID: 165418 RVA: 0x009AB2F4 File Offset: 0x009A94F4
		// (set) Token: 0x0602862B RID: 165419 RVA: 0x009AB308 File Offset: 0x009A9508
		public unsafe UMaterialInterface ScanMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17005D83 RID: 23939
		// (get) Token: 0x0602862C RID: 165420 RVA: 0x009AB31D File Offset: 0x009A951D
		// (set) Token: 0x0602862D RID: 165421 RVA: 0x009AB32D File Offset: 0x009A952D
		public unsafe bool 反向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D84 RID: 23940
		// (get) Token: 0x0602862E RID: 165422 RVA: 0x009AB33E File Offset: 0x009A953E
		// (set) Token: 0x0602862F RID: 165423 RVA: 0x009AB34E File Offset: 0x009A954E
		public unsafe float Play_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17005D85 RID: 23941
		// (get) Token: 0x06028630 RID: 165424 RVA: 0x009AB35F File Offset: 0x009A955F
		// (set) Token: 0x06028631 RID: 165425 RVA: 0x009AB373 File Offset: 0x009A9573
		public unsafe UMaterialInstanceDynamic ScanMaterialMID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17005D86 RID: 23942
		// (get) Token: 0x06028632 RID: 165426 RVA: 0x009AB388 File Offset: 0x009A9588
		// (set) Token: 0x06028633 RID: 165427 RVA: 0x009AB398 File Offset: 0x009A9598
		public unsafe float PlaySpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17005D87 RID: 23943
		// (get) Token: 0x06028634 RID: 165428 RVA: 0x009AB3A9 File Offset: 0x009A95A9
		// (set) Token: 0x06028635 RID: 165429 RVA: 0x009AB3B9 File Offset: 0x009A95B9
		public unsafe bool StartTicking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D88 RID: 23944
		// (get) Token: 0x06028636 RID: 165430 RVA: 0x009AB3CA File Offset: 0x009A95CA
		// (set) Token: 0x06028637 RID: 165431 RVA: 0x009AB3DA File Offset: 0x009A95DA
		public unsafe bool IsUsedForSeq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D89 RID: 23945
		// (get) Token: 0x06028638 RID: 165432 RVA: 0x009AB3EB File Offset: 0x009A95EB
		// (set) Token: 0x06028639 RID: 165433 RVA: 0x009AB3FB File Offset: 0x009A95FB
		public unsafe float SeqLifeCycle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x0602863A RID: 165434 RVA: 0x009AB40C File Offset: 0x009A960C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartScanEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__StartScanEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0602863B RID: 165435 RVA: 0x009AB420 File Offset: 0x009A9620
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetRevert()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__SetRevert_NativeFunctionPtr, null);
		}

		// Token: 0x0602863C RID: 165436 RVA: 0x009AB434 File Offset: 0x009A9634
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 扫描范围__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__扫描范围__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0602863D RID: 165437 RVA: 0x009AB448 File Offset: 0x009A9648
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 扫描范围__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__扫描范围__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0602863E RID: 165438 RVA: 0x009AB45C File Offset: 0x009A965C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 扫描带强度__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__扫描带强度__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0602863F RID: 165439 RVA: 0x009AB470 File Offset: 0x009A9670
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 扫描带强度__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__扫描带强度__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06028640 RID: 165440 RVA: 0x009AB484 File Offset: 0x009A9684
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 轮廓强度__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__轮廓强度__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06028641 RID: 165441 RVA: 0x009AB498 File Offset: 0x009A9698
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 轮廓强度__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__轮廓强度__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06028642 RID: 165442 RVA: 0x009AB4AC File Offset: 0x009A96AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 衰退范围__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__衰退范围__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06028643 RID: 165443 RVA: 0x009AB4C0 File Offset: 0x009A96C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 衰退范围__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__衰退范围__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06028644 RID: 165444 RVA: 0x009AB4D4 File Offset: 0x009A96D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_0__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__Timeline_0__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06028645 RID: 165445 RVA: 0x009AB4E8 File Offset: 0x009A96E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Timeline_0__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__Timeline_0__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06028646 RID: 165446 RVA: 0x009AB4FC File Offset: 0x009A96FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Fx_Scanning_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_Scanning_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_Scanning_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_Scanning_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06028647 RID: 165447 RVA: 0x009AB544 File Offset: 0x009A9744
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Fx_Scanning_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_Scanning_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_Scanning_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_Scanning_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_Scanning_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06028648 RID: 165448 RVA: 0x009AB58B File Offset: 0x009A978B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06028649 RID: 165449 RVA: 0x009AB59F File Offset: 0x009A979F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_Scanning_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602864A RID: 165450 RVA: 0x009AB5B4 File Offset: 0x009A97B4
		protected BP_Fx_Scanning_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014942 RID: 84290
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Scanning.BP_Fx_Scanning_C";

		// Token: 0x04014943 RID: 84291
		private static IntPtr _ClassPtr;

		// Token: 0x04014944 RID: 84292
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014945 RID: 84293
		internal static int __PropertyOffset_1;

		// Token: 0x04014946 RID: 84294
		internal static int __PropertyOffset_2;

		// Token: 0x04014947 RID: 84295
		internal static int __PropertyOffset_3;

		// Token: 0x04014948 RID: 84296
		internal static int __PropertyOffset_4;

		// Token: 0x04014949 RID: 84297
		internal static int __PropertyOffset_5;

		// Token: 0x0401494A RID: 84298
		internal static int __PropertyOffset_6;

		// Token: 0x0401494B RID: 84299
		internal static int __PropertyOffset_7;

		// Token: 0x0401494C RID: 84300
		internal static int __PropertyOffset_8;

		// Token: 0x0401494D RID: 84301
		internal static int __PropertyOffset_9;

		// Token: 0x0401494E RID: 84302
		internal static int __PropertyOffset_10;

		// Token: 0x0401494F RID: 84303
		internal static int __PropertyOffset_11;

		// Token: 0x04014950 RID: 84304
		internal static int __PropertyOffset_12;

		// Token: 0x04014951 RID: 84305
		internal static int __PropertyOffset_13;

		// Token: 0x04014952 RID: 84306
		internal static int __PropertyOffset_14;

		// Token: 0x04014953 RID: 84307
		internal static int __PropertyOffset_15;

		// Token: 0x04014954 RID: 84308
		internal static int __PropertyOffset_16;

		// Token: 0x04014955 RID: 84309
		internal static int __PropertyOffset_17;

		// Token: 0x04014956 RID: 84310
		internal static int __PropertyOffset_18;

		// Token: 0x04014957 RID: 84311
		internal static int __PropertyOffset_19;

		// Token: 0x04014958 RID: 84312
		internal static int __PropertyOffset_20;

		// Token: 0x04014959 RID: 84313
		internal static int __PropertyOffset_21;

		// Token: 0x0401495A RID: 84314
		internal static int __PropertyOffset_22;

		// Token: 0x0401495B RID: 84315
		internal static int __PropertyOffset_23;

		// Token: 0x0401495C RID: 84316
		internal static int __PropertyOffset_24;

		// Token: 0x0401495D RID: 84317
		internal static int __PropertyOffset_25;

		// Token: 0x0401495E RID: 84318
		private static IntPtr __StartScanEffect_NativeFunctionPtr;

		// Token: 0x0401495F RID: 84319
		private static IntPtr __SetRevert_NativeFunctionPtr;

		// Token: 0x04014960 RID: 84320
		private static IntPtr __扫描范围__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04014961 RID: 84321
		private static IntPtr __扫描范围__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04014962 RID: 84322
		private static IntPtr __扫描带强度__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04014963 RID: 84323
		private static IntPtr __扫描带强度__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04014964 RID: 84324
		private static IntPtr __轮廓强度__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04014965 RID: 84325
		private static IntPtr __轮廓强度__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04014966 RID: 84326
		private static IntPtr __衰退范围__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04014967 RID: 84327
		private static IntPtr __衰退范围__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04014968 RID: 84328
		private static IntPtr __Timeline_0__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04014969 RID: 84329
		private static IntPtr __Timeline_0__UpdateFunc_NativeFunctionPtr;

		// Token: 0x0401496A RID: 84330
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401496B RID: 84331
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0200A2D6 RID: 41686
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04032019 RID: 204825
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
