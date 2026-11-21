using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common
{
	// Token: 0x02003408 RID: 13320
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Scanning.BP_Fx_Scanning_C")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1228)]
	public class BP_Fx_Scanning_C : __TsBpFxEffect_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021D6F RID: 138607 RVA: 0x0096CD83 File Offset: 0x0096AF83
		[SkipLocalsInit]
		public new void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021D70 RID: 138608 RVA: 0x0096CD97 File Offset: 0x0096AF97
		[SkipLocalsInit]
		protected new void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_Scanning_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021D71 RID: 138609 RVA: 0x0096CDAB File Offset: 0x0096AFAB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Fx_Scanning_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Scanning.BP_Fx_Scanning_C");
			}
			return BP_Fx_Scanning_C._ClassPtr;
		}

		// Token: 0x06021D72 RID: 138610 RVA: 0x0096CDD0 File Offset: 0x0096AFD0
		public BP_Fx_Scanning_C() : this(BuiltinUtils.AllocNativeUObject(BP_Fx_Scanning_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021D73 RID: 138611 RVA: 0x0096CDF8 File Offset: 0x0096AFF8
		[NullableContext(1)]
		public BP_Fx_Scanning_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Fx_Scanning_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700464C RID: 17996
		// (get) Token: 0x06021D74 RID: 138612 RVA: 0x0096CE2B File Offset: 0x0096B02B
		// (set) Token: 0x06021D75 RID: 138613 RVA: 0x0096CE3F File Offset: 0x0096B03F
		public unsafe UPostProcessComponent PostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_PostProcess);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_PostProcess, value);
			}
		}

		// Token: 0x1700464D RID: 17997
		// (get) Token: 0x06021D76 RID: 138614 RVA: 0x0096CE54 File Offset: 0x0096B054
		// (set) Token: 0x06021D77 RID: 138615 RVA: 0x0096CE68 File Offset: 0x0096B068
		public unsafe UTimelineComponent Timeline_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_Timeline_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_Timeline_0, value);
			}
		}

		// Token: 0x1700464E RID: 17998
		// (get) Token: 0x06021D78 RID: 138616 RVA: 0x0096CE7D File Offset: 0x0096B07D
		// (set) Token: 0x06021D79 RID: 138617 RVA: 0x0096CE91 File Offset: 0x0096B091
		public unsafe UTimelineComponent 衰退范围
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_衰退范围);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_衰退范围, value);
			}
		}

		// Token: 0x1700464F RID: 17999
		// (get) Token: 0x06021D7A RID: 138618 RVA: 0x0096CEA6 File Offset: 0x0096B0A6
		// (set) Token: 0x06021D7B RID: 138619 RVA: 0x0096CEBA File Offset: 0x0096B0BA
		public unsafe UTimelineComponent 轮廓强度
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_轮廓强度);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_轮廓强度, value);
			}
		}

		// Token: 0x17004650 RID: 18000
		// (get) Token: 0x06021D7C RID: 138620 RVA: 0x0096CECF File Offset: 0x0096B0CF
		// (set) Token: 0x06021D7D RID: 138621 RVA: 0x0096CEE3 File Offset: 0x0096B0E3
		public unsafe UTimelineComponent 扫描带强度
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_扫描带强度);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_扫描带强度, value);
			}
		}

		// Token: 0x17004651 RID: 18001
		// (get) Token: 0x06021D7E RID: 138622 RVA: 0x0096CEF8 File Offset: 0x0096B0F8
		// (set) Token: 0x06021D7F RID: 138623 RVA: 0x0096CF0C File Offset: 0x0096B10C
		public unsafe UTimelineComponent 扫描范围
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_扫描范围);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_扫描范围, value);
			}
		}

		// Token: 0x17004652 RID: 18002
		// (get) Token: 0x06021D80 RID: 138624 RVA: 0x0096CF21 File Offset: 0x0096B121
		// (set) Token: 0x06021D81 RID: 138625 RVA: 0x0096CF35 File Offset: 0x0096B135
		public unsafe UMaterialInterface ScanMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_ScanMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_ScanMaterial, value);
			}
		}

		// Token: 0x17004653 RID: 18003
		// (get) Token: 0x06021D82 RID: 138626 RVA: 0x0096CF4A File Offset: 0x0096B14A
		// (set) Token: 0x06021D83 RID: 138627 RVA: 0x0096CF5A File Offset: 0x0096B15A
		public unsafe bool 反向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_反向) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_反向) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004654 RID: 18004
		// (get) Token: 0x06021D84 RID: 138628 RVA: 0x0096CF6B File Offset: 0x0096B16B
		// (set) Token: 0x06021D85 RID: 138629 RVA: 0x0096CF7B File Offset: 0x0096B17B
		public unsafe float Play_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_Play_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_Play_Time) = value;
			}
		}

		// Token: 0x17004655 RID: 18005
		// (get) Token: 0x06021D86 RID: 138630 RVA: 0x0096CF8C File Offset: 0x0096B18C
		// (set) Token: 0x06021D87 RID: 138631 RVA: 0x0096CFA0 File Offset: 0x0096B1A0
		public unsafe UMaterialInstanceDynamic ScanMaterialMID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_ScanMaterialMID);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_C.__PropertyOffset_ScanMaterialMID, value);
			}
		}

		// Token: 0x17004656 RID: 18006
		// (get) Token: 0x06021D88 RID: 138632 RVA: 0x0096CFB5 File Offset: 0x0096B1B5
		// (set) Token: 0x06021D89 RID: 138633 RVA: 0x0096CFC5 File Offset: 0x0096B1C5
		public unsafe float PlaySpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_PlaySpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_PlaySpeed) = value;
			}
		}

		// Token: 0x17004657 RID: 18007
		// (get) Token: 0x06021D8A RID: 138634 RVA: 0x0096CFD6 File Offset: 0x0096B1D6
		// (set) Token: 0x06021D8B RID: 138635 RVA: 0x0096CFE6 File Offset: 0x0096B1E6
		public unsafe bool StartTicking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_StartTicking) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_StartTicking) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004658 RID: 18008
		// (get) Token: 0x06021D8C RID: 138636 RVA: 0x0096CFF7 File Offset: 0x0096B1F7
		// (set) Token: 0x06021D8D RID: 138637 RVA: 0x0096D007 File Offset: 0x0096B207
		public unsafe bool IsUsedForSeq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_IsUsedForSeq) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_IsUsedForSeq) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004659 RID: 18009
		// (get) Token: 0x06021D8E RID: 138638 RVA: 0x0096D018 File Offset: 0x0096B218
		// (set) Token: 0x06021D8F RID: 138639 RVA: 0x0096D028 File Offset: 0x0096B228
		public unsafe float SeqLifeCycle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_SeqLifeCycle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_C.__PropertyOffset_SeqLifeCycle) = value;
			}
		}

		// Token: 0x06021D90 RID: 138640 RVA: 0x0096D039 File Offset: 0x0096B239
		[SkipLocalsInit]
		public virtual void StartScanEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__StartScanEffect_NativeFunctionPtr, null);
		}

		// Token: 0x06021D91 RID: 138641 RVA: 0x0096D04D File Offset: 0x0096B24D
		[SkipLocalsInit]
		public virtual void SetRevert()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__SetRevert_NativeFunctionPtr, null);
		}

		// Token: 0x06021D92 RID: 138642 RVA: 0x0096D061 File Offset: 0x0096B261
		[SkipLocalsInit]
		public virtual void 扫描范围__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__扫描范围__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D93 RID: 138643 RVA: 0x0096D075 File Offset: 0x0096B275
		[SkipLocalsInit]
		public virtual void 扫描范围__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__扫描范围__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D94 RID: 138644 RVA: 0x0096D089 File Offset: 0x0096B289
		[SkipLocalsInit]
		public virtual void 扫描带强度__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__扫描带强度__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D95 RID: 138645 RVA: 0x0096D09D File Offset: 0x0096B29D
		[SkipLocalsInit]
		public virtual void 扫描带强度__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__扫描带强度__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D96 RID: 138646 RVA: 0x0096D0B1 File Offset: 0x0096B2B1
		[SkipLocalsInit]
		public virtual void 轮廓强度__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__轮廓强度__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D97 RID: 138647 RVA: 0x0096D0C5 File Offset: 0x0096B2C5
		[SkipLocalsInit]
		public virtual void 轮廓强度__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__轮廓强度__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D98 RID: 138648 RVA: 0x0096D0D9 File Offset: 0x0096B2D9
		[SkipLocalsInit]
		public virtual void 衰退范围__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__衰退范围__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D99 RID: 138649 RVA: 0x0096D0ED File Offset: 0x0096B2ED
		[SkipLocalsInit]
		public virtual void 衰退范围__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__衰退范围__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D9A RID: 138650 RVA: 0x0096D101 File Offset: 0x0096B301
		[SkipLocalsInit]
		public virtual void Timeline_0__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__Timeline_0__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D9B RID: 138651 RVA: 0x0096D115 File Offset: 0x0096B315
		[SkipLocalsInit]
		public virtual void Timeline_0__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__Timeline_0__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D9C RID: 138652 RVA: 0x0096D12C File Offset: 0x0096B32C
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Fx_Scanning_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_Scanning_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_Scanning_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_Scanning_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021D9D RID: 138653 RVA: 0x0096D174 File Offset: 0x0096B374
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Fx_Scanning_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_Scanning_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_Scanning_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_Scanning_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_Scanning_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021D9E RID: 138654 RVA: 0x0096D1BA File Offset: 0x0096B3BA
		protected BP_Fx_Scanning_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012AAD RID: 76461
		[StaticVariableRuleIgnore]
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012AAE RID: 76462
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Scanning.BP_Fx_Scanning_C";

		// Token: 0x04012AAF RID: 76463
		private static IntPtr _ClassPtr;

		// Token: 0x04012AB0 RID: 76464
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012AB1 RID: 76465
		internal static int __PropertyOffset_PostProcess;

		// Token: 0x04012AB2 RID: 76466
		internal static int __PropertyOffset_Timeline_0;

		// Token: 0x04012AB3 RID: 76467
		internal static int __PropertyOffset_衰退范围;

		// Token: 0x04012AB4 RID: 76468
		internal static int __PropertyOffset_轮廓强度;

		// Token: 0x04012AB5 RID: 76469
		internal static int __PropertyOffset_扫描带强度;

		// Token: 0x04012AB6 RID: 76470
		internal static int __PropertyOffset_扫描范围;

		// Token: 0x04012AB7 RID: 76471
		internal static int __PropertyOffset_ScanMaterial;

		// Token: 0x04012AB8 RID: 76472
		internal static int __PropertyOffset_反向;

		// Token: 0x04012AB9 RID: 76473
		internal static int __PropertyOffset_Play_Time;

		// Token: 0x04012ABA RID: 76474
		internal static int __PropertyOffset_ScanMaterialMID;

		// Token: 0x04012ABB RID: 76475
		internal static int __PropertyOffset_PlaySpeed;

		// Token: 0x04012ABC RID: 76476
		internal static int __PropertyOffset_StartTicking;

		// Token: 0x04012ABD RID: 76477
		internal static int __PropertyOffset_IsUsedForSeq;

		// Token: 0x04012ABE RID: 76478
		internal static int __PropertyOffset_SeqLifeCycle;

		// Token: 0x04012ABF RID: 76479
		private static IntPtr __StartScanEffect_NativeFunctionPtr;

		// Token: 0x04012AC0 RID: 76480
		private static IntPtr __SetRevert_NativeFunctionPtr;

		// Token: 0x04012AC1 RID: 76481
		private static IntPtr __扫描范围__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04012AC2 RID: 76482
		private static IntPtr __扫描范围__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04012AC3 RID: 76483
		private static IntPtr __扫描带强度__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04012AC4 RID: 76484
		private static IntPtr __扫描带强度__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04012AC5 RID: 76485
		private static IntPtr __轮廓强度__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04012AC6 RID: 76486
		private static IntPtr __轮廓强度__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04012AC7 RID: 76487
		private static IntPtr __衰退范围__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04012AC8 RID: 76488
		private static IntPtr __衰退范围__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04012AC9 RID: 76489
		private static IntPtr __Timeline_0__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04012ACA RID: 76490
		private static IntPtr __Timeline_0__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04012ACB RID: 76491
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x020090FA RID: 37114
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CFD8 RID: 184280
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
