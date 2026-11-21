using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common
{
	// Token: 0x02003407 RID: 13319
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Scanning_2_7.BP_Fx_Scanning_2_7_C")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1228)]
	public class BP_Fx_Scanning_2_7_C : __TsBpFxEffect_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021D3F RID: 138559 RVA: 0x0096C943 File Offset: 0x0096AB43
		[SkipLocalsInit]
		public new void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021D40 RID: 138560 RVA: 0x0096C957 File Offset: 0x0096AB57
		[SkipLocalsInit]
		protected new void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021D41 RID: 138561 RVA: 0x0096C96B File Offset: 0x0096AB6B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Fx_Scanning_2_7_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Scanning_2_7.BP_Fx_Scanning_2_7_C");
			}
			return BP_Fx_Scanning_2_7_C._ClassPtr;
		}

		// Token: 0x06021D42 RID: 138562 RVA: 0x0096C990 File Offset: 0x0096AB90
		public BP_Fx_Scanning_2_7_C() : this(BuiltinUtils.AllocNativeUObject(BP_Fx_Scanning_2_7_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021D43 RID: 138563 RVA: 0x0096C9B8 File Offset: 0x0096ABB8
		[NullableContext(1)]
		public BP_Fx_Scanning_2_7_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Fx_Scanning_2_7_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700463E RID: 17982
		// (get) Token: 0x06021D44 RID: 138564 RVA: 0x0096C9EB File Offset: 0x0096ABEB
		// (set) Token: 0x06021D45 RID: 138565 RVA: 0x0096C9FF File Offset: 0x0096ABFF
		public unsafe UPostProcessComponent PostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_PostProcess);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_PostProcess, value);
			}
		}

		// Token: 0x1700463F RID: 17983
		// (get) Token: 0x06021D46 RID: 138566 RVA: 0x0096CA14 File Offset: 0x0096AC14
		// (set) Token: 0x06021D47 RID: 138567 RVA: 0x0096CA28 File Offset: 0x0096AC28
		public unsafe UTimelineComponent Timeline_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_Timeline_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_Timeline_0, value);
			}
		}

		// Token: 0x17004640 RID: 17984
		// (get) Token: 0x06021D48 RID: 138568 RVA: 0x0096CA3D File Offset: 0x0096AC3D
		// (set) Token: 0x06021D49 RID: 138569 RVA: 0x0096CA51 File Offset: 0x0096AC51
		public unsafe UTimelineComponent 衰退范围
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_衰退范围);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_衰退范围, value);
			}
		}

		// Token: 0x17004641 RID: 17985
		// (get) Token: 0x06021D4A RID: 138570 RVA: 0x0096CA66 File Offset: 0x0096AC66
		// (set) Token: 0x06021D4B RID: 138571 RVA: 0x0096CA7A File Offset: 0x0096AC7A
		public unsafe UTimelineComponent 轮廓强度
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_轮廓强度);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_轮廓强度, value);
			}
		}

		// Token: 0x17004642 RID: 17986
		// (get) Token: 0x06021D4C RID: 138572 RVA: 0x0096CA8F File Offset: 0x0096AC8F
		// (set) Token: 0x06021D4D RID: 138573 RVA: 0x0096CAA3 File Offset: 0x0096ACA3
		public unsafe UTimelineComponent 扫描带强度
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_扫描带强度);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_扫描带强度, value);
			}
		}

		// Token: 0x17004643 RID: 17987
		// (get) Token: 0x06021D4E RID: 138574 RVA: 0x0096CAB8 File Offset: 0x0096ACB8
		// (set) Token: 0x06021D4F RID: 138575 RVA: 0x0096CACC File Offset: 0x0096ACCC
		public unsafe UTimelineComponent 扫描范围
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_扫描范围);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_扫描范围, value);
			}
		}

		// Token: 0x17004644 RID: 17988
		// (get) Token: 0x06021D50 RID: 138576 RVA: 0x0096CAE1 File Offset: 0x0096ACE1
		// (set) Token: 0x06021D51 RID: 138577 RVA: 0x0096CAF5 File Offset: 0x0096ACF5
		public unsafe UMaterialInterface ScanMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_ScanMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_ScanMaterial, value);
			}
		}

		// Token: 0x17004645 RID: 17989
		// (get) Token: 0x06021D52 RID: 138578 RVA: 0x0096CB0A File Offset: 0x0096AD0A
		// (set) Token: 0x06021D53 RID: 138579 RVA: 0x0096CB1A File Offset: 0x0096AD1A
		public unsafe bool 反向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_反向) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_反向) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004646 RID: 17990
		// (get) Token: 0x06021D54 RID: 138580 RVA: 0x0096CB2B File Offset: 0x0096AD2B
		// (set) Token: 0x06021D55 RID: 138581 RVA: 0x0096CB3B File Offset: 0x0096AD3B
		public unsafe float Play_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_Play_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_Play_Time) = value;
			}
		}

		// Token: 0x17004647 RID: 17991
		// (get) Token: 0x06021D56 RID: 138582 RVA: 0x0096CB4C File Offset: 0x0096AD4C
		// (set) Token: 0x06021D57 RID: 138583 RVA: 0x0096CB60 File Offset: 0x0096AD60
		public unsafe UMaterialInstanceDynamic ScanMaterialMID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_ScanMaterialMID);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_Scanning_2_7_C.__PropertyOffset_ScanMaterialMID, value);
			}
		}

		// Token: 0x17004648 RID: 17992
		// (get) Token: 0x06021D58 RID: 138584 RVA: 0x0096CB75 File Offset: 0x0096AD75
		// (set) Token: 0x06021D59 RID: 138585 RVA: 0x0096CB85 File Offset: 0x0096AD85
		public unsafe float PlaySpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_PlaySpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_PlaySpeed) = value;
			}
		}

		// Token: 0x17004649 RID: 17993
		// (get) Token: 0x06021D5A RID: 138586 RVA: 0x0096CB96 File Offset: 0x0096AD96
		// (set) Token: 0x06021D5B RID: 138587 RVA: 0x0096CBA6 File Offset: 0x0096ADA6
		public unsafe bool StartTicking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_StartTicking) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_StartTicking) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700464A RID: 17994
		// (get) Token: 0x06021D5C RID: 138588 RVA: 0x0096CBB7 File Offset: 0x0096ADB7
		// (set) Token: 0x06021D5D RID: 138589 RVA: 0x0096CBC7 File Offset: 0x0096ADC7
		public unsafe bool IsUsedForSeq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_IsUsedForSeq) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_IsUsedForSeq) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700464B RID: 17995
		// (get) Token: 0x06021D5E RID: 138590 RVA: 0x0096CBD8 File Offset: 0x0096ADD8
		// (set) Token: 0x06021D5F RID: 138591 RVA: 0x0096CBE8 File Offset: 0x0096ADE8
		public unsafe float SeqLifeCycle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_SeqLifeCycle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_Scanning_2_7_C.__PropertyOffset_SeqLifeCycle) = value;
			}
		}

		// Token: 0x06021D60 RID: 138592 RVA: 0x0096CBF9 File Offset: 0x0096ADF9
		[SkipLocalsInit]
		public virtual void StartScanEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__StartScanEffect_NativeFunctionPtr, null);
		}

		// Token: 0x06021D61 RID: 138593 RVA: 0x0096CC0D File Offset: 0x0096AE0D
		[SkipLocalsInit]
		public virtual void SetRevert()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__SetRevert_NativeFunctionPtr, null);
		}

		// Token: 0x06021D62 RID: 138594 RVA: 0x0096CC21 File Offset: 0x0096AE21
		[SkipLocalsInit]
		public virtual void 扫描范围__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__扫描范围__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D63 RID: 138595 RVA: 0x0096CC35 File Offset: 0x0096AE35
		[SkipLocalsInit]
		public virtual void 扫描范围__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__扫描范围__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D64 RID: 138596 RVA: 0x0096CC49 File Offset: 0x0096AE49
		[SkipLocalsInit]
		public virtual void 扫描带强度__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__扫描带强度__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D65 RID: 138597 RVA: 0x0096CC5D File Offset: 0x0096AE5D
		[SkipLocalsInit]
		public virtual void 扫描带强度__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__扫描带强度__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D66 RID: 138598 RVA: 0x0096CC71 File Offset: 0x0096AE71
		[SkipLocalsInit]
		public virtual void 轮廓强度__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__轮廓强度__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D67 RID: 138599 RVA: 0x0096CC85 File Offset: 0x0096AE85
		[SkipLocalsInit]
		public virtual void 轮廓强度__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__轮廓强度__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D68 RID: 138600 RVA: 0x0096CC99 File Offset: 0x0096AE99
		[SkipLocalsInit]
		public virtual void 衰退范围__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__衰退范围__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D69 RID: 138601 RVA: 0x0096CCAD File Offset: 0x0096AEAD
		[SkipLocalsInit]
		public virtual void 衰退范围__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__衰退范围__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D6A RID: 138602 RVA: 0x0096CCC1 File Offset: 0x0096AEC1
		[SkipLocalsInit]
		public virtual void Timeline_0__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__Timeline_0__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D6B RID: 138603 RVA: 0x0096CCD5 File Offset: 0x0096AED5
		[SkipLocalsInit]
		public virtual void Timeline_0__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__Timeline_0__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D6C RID: 138604 RVA: 0x0096CCEC File Offset: 0x0096AEEC
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Fx_Scanning_2_7_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_Scanning_2_7_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_Scanning_2_7_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_Scanning_2_7_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021D6D RID: 138605 RVA: 0x0096CD34 File Offset: 0x0096AF34
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Fx_Scanning_2_7_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_Scanning_2_7_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_Scanning_2_7_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_Scanning_2_7_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_Scanning_2_7_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021D6E RID: 138606 RVA: 0x0096CD7A File Offset: 0x0096AF7A
		protected BP_Fx_Scanning_2_7_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A8E RID: 76430
		[StaticVariableRuleIgnore]
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012A8F RID: 76431
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_Scanning_2_7.BP_Fx_Scanning_2_7_C";

		// Token: 0x04012A90 RID: 76432
		private static IntPtr _ClassPtr;

		// Token: 0x04012A91 RID: 76433
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012A92 RID: 76434
		internal static int __PropertyOffset_PostProcess;

		// Token: 0x04012A93 RID: 76435
		internal static int __PropertyOffset_Timeline_0;

		// Token: 0x04012A94 RID: 76436
		internal static int __PropertyOffset_衰退范围;

		// Token: 0x04012A95 RID: 76437
		internal static int __PropertyOffset_轮廓强度;

		// Token: 0x04012A96 RID: 76438
		internal static int __PropertyOffset_扫描带强度;

		// Token: 0x04012A97 RID: 76439
		internal static int __PropertyOffset_扫描范围;

		// Token: 0x04012A98 RID: 76440
		internal static int __PropertyOffset_ScanMaterial;

		// Token: 0x04012A99 RID: 76441
		internal static int __PropertyOffset_反向;

		// Token: 0x04012A9A RID: 76442
		internal static int __PropertyOffset_Play_Time;

		// Token: 0x04012A9B RID: 76443
		internal static int __PropertyOffset_ScanMaterialMID;

		// Token: 0x04012A9C RID: 76444
		internal static int __PropertyOffset_PlaySpeed;

		// Token: 0x04012A9D RID: 76445
		internal static int __PropertyOffset_StartTicking;

		// Token: 0x04012A9E RID: 76446
		internal static int __PropertyOffset_IsUsedForSeq;

		// Token: 0x04012A9F RID: 76447
		internal static int __PropertyOffset_SeqLifeCycle;

		// Token: 0x04012AA0 RID: 76448
		private static IntPtr __StartScanEffect_NativeFunctionPtr;

		// Token: 0x04012AA1 RID: 76449
		private static IntPtr __SetRevert_NativeFunctionPtr;

		// Token: 0x04012AA2 RID: 76450
		private static IntPtr __扫描范围__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04012AA3 RID: 76451
		private static IntPtr __扫描范围__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04012AA4 RID: 76452
		private static IntPtr __扫描带强度__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04012AA5 RID: 76453
		private static IntPtr __扫描带强度__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04012AA6 RID: 76454
		private static IntPtr __轮廓强度__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04012AA7 RID: 76455
		private static IntPtr __轮廓强度__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04012AA8 RID: 76456
		private static IntPtr __衰退范围__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04012AA9 RID: 76457
		private static IntPtr __衰退范围__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04012AAA RID: 76458
		private static IntPtr __Timeline_0__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04012AAB RID: 76459
		private static IntPtr __Timeline_0__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04012AAC RID: 76460
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x020090F9 RID: 37113
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CFD7 RID: 184279
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
