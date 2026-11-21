using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common
{
	// Token: 0x02003406 RID: 13318
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_DistortionWave.BP_DistortionWave_C")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1228)]
	public class BP_DistortionWave_C : __TsBpFxEffect_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021D0F RID: 138511 RVA: 0x0096C501 File Offset: 0x0096A701
		[SkipLocalsInit]
		public new void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021D10 RID: 138512 RVA: 0x0096C515 File Offset: 0x0096A715
		[SkipLocalsInit]
		protected new void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DistortionWave_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021D11 RID: 138513 RVA: 0x0096C529 File Offset: 0x0096A729
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DistortionWave_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_DistortionWave.BP_DistortionWave_C");
			}
			return BP_DistortionWave_C._ClassPtr;
		}

		// Token: 0x06021D12 RID: 138514 RVA: 0x0096C550 File Offset: 0x0096A750
		public BP_DistortionWave_C() : this(BuiltinUtils.AllocNativeUObject(BP_DistortionWave_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021D13 RID: 138515 RVA: 0x0096C578 File Offset: 0x0096A778
		[NullableContext(1)]
		public BP_DistortionWave_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DistortionWave_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004630 RID: 17968
		// (get) Token: 0x06021D14 RID: 138516 RVA: 0x0096C5AB File Offset: 0x0096A7AB
		// (set) Token: 0x06021D15 RID: 138517 RVA: 0x0096C5BF File Offset: 0x0096A7BF
		public unsafe UPostProcessComponent PostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_PostProcess);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_PostProcess, value);
			}
		}

		// Token: 0x17004631 RID: 17969
		// (get) Token: 0x06021D16 RID: 138518 RVA: 0x0096C5D4 File Offset: 0x0096A7D4
		// (set) Token: 0x06021D17 RID: 138519 RVA: 0x0096C5E8 File Offset: 0x0096A7E8
		public unsafe UTimelineComponent Timeline_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_Timeline_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_Timeline_0, value);
			}
		}

		// Token: 0x17004632 RID: 17970
		// (get) Token: 0x06021D18 RID: 138520 RVA: 0x0096C5FD File Offset: 0x0096A7FD
		// (set) Token: 0x06021D19 RID: 138521 RVA: 0x0096C611 File Offset: 0x0096A811
		public unsafe UTimelineComponent 衰退范围
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_衰退范围);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_衰退范围, value);
			}
		}

		// Token: 0x17004633 RID: 17971
		// (get) Token: 0x06021D1A RID: 138522 RVA: 0x0096C626 File Offset: 0x0096A826
		// (set) Token: 0x06021D1B RID: 138523 RVA: 0x0096C63A File Offset: 0x0096A83A
		public unsafe UTimelineComponent 轮廓强度
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_轮廓强度);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_轮廓强度, value);
			}
		}

		// Token: 0x17004634 RID: 17972
		// (get) Token: 0x06021D1C RID: 138524 RVA: 0x0096C64F File Offset: 0x0096A84F
		// (set) Token: 0x06021D1D RID: 138525 RVA: 0x0096C663 File Offset: 0x0096A863
		public unsafe UTimelineComponent 扫描带强度
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_扫描带强度);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_扫描带强度, value);
			}
		}

		// Token: 0x17004635 RID: 17973
		// (get) Token: 0x06021D1E RID: 138526 RVA: 0x0096C678 File Offset: 0x0096A878
		// (set) Token: 0x06021D1F RID: 138527 RVA: 0x0096C68C File Offset: 0x0096A88C
		public unsafe UTimelineComponent 扫描范围
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_扫描范围);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_扫描范围, value);
			}
		}

		// Token: 0x17004636 RID: 17974
		// (get) Token: 0x06021D20 RID: 138528 RVA: 0x0096C6A1 File Offset: 0x0096A8A1
		// (set) Token: 0x06021D21 RID: 138529 RVA: 0x0096C6B5 File Offset: 0x0096A8B5
		public unsafe UMaterialInterface ScanMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_ScanMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_ScanMaterial, value);
			}
		}

		// Token: 0x17004637 RID: 17975
		// (get) Token: 0x06021D22 RID: 138530 RVA: 0x0096C6CA File Offset: 0x0096A8CA
		// (set) Token: 0x06021D23 RID: 138531 RVA: 0x0096C6DA File Offset: 0x0096A8DA
		public unsafe bool 反向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_反向) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_反向) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004638 RID: 17976
		// (get) Token: 0x06021D24 RID: 138532 RVA: 0x0096C6EB File Offset: 0x0096A8EB
		// (set) Token: 0x06021D25 RID: 138533 RVA: 0x0096C6FB File Offset: 0x0096A8FB
		public unsafe float Play_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_Play_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_Play_Time) = value;
			}
		}

		// Token: 0x17004639 RID: 17977
		// (get) Token: 0x06021D26 RID: 138534 RVA: 0x0096C70C File Offset: 0x0096A90C
		// (set) Token: 0x06021D27 RID: 138535 RVA: 0x0096C720 File Offset: 0x0096A920
		public unsafe UMaterialInstanceDynamic ScanMaterialMID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_ScanMaterialMID);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DistortionWave_C.__PropertyOffset_ScanMaterialMID, value);
			}
		}

		// Token: 0x1700463A RID: 17978
		// (get) Token: 0x06021D28 RID: 138536 RVA: 0x0096C735 File Offset: 0x0096A935
		// (set) Token: 0x06021D29 RID: 138537 RVA: 0x0096C745 File Offset: 0x0096A945
		public unsafe float PlaySpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_PlaySpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_PlaySpeed) = value;
			}
		}

		// Token: 0x1700463B RID: 17979
		// (get) Token: 0x06021D2A RID: 138538 RVA: 0x0096C756 File Offset: 0x0096A956
		// (set) Token: 0x06021D2B RID: 138539 RVA: 0x0096C766 File Offset: 0x0096A966
		public unsafe bool StartTicking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_StartTicking) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_StartTicking) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700463C RID: 17980
		// (get) Token: 0x06021D2C RID: 138540 RVA: 0x0096C777 File Offset: 0x0096A977
		// (set) Token: 0x06021D2D RID: 138541 RVA: 0x0096C787 File Offset: 0x0096A987
		public unsafe bool IsUsedForSeq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_IsUsedForSeq) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_IsUsedForSeq) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700463D RID: 17981
		// (get) Token: 0x06021D2E RID: 138542 RVA: 0x0096C798 File Offset: 0x0096A998
		// (set) Token: 0x06021D2F RID: 138543 RVA: 0x0096C7A8 File Offset: 0x0096A9A8
		public unsafe float SeqLifeCycle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_SeqLifeCycle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DistortionWave_C.__PropertyOffset_SeqLifeCycle) = value;
			}
		}

		// Token: 0x06021D30 RID: 138544 RVA: 0x0096C7B9 File Offset: 0x0096A9B9
		[SkipLocalsInit]
		public virtual void StartScanEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__StartScanEffect_NativeFunctionPtr, null);
		}

		// Token: 0x06021D31 RID: 138545 RVA: 0x0096C7CD File Offset: 0x0096A9CD
		[SkipLocalsInit]
		public virtual void SetRevert()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__SetRevert_NativeFunctionPtr, null);
		}

		// Token: 0x06021D32 RID: 138546 RVA: 0x0096C7E1 File Offset: 0x0096A9E1
		[SkipLocalsInit]
		public virtual void 轮廓强度__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__轮廓强度__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D33 RID: 138547 RVA: 0x0096C7F5 File Offset: 0x0096A9F5
		[SkipLocalsInit]
		public virtual void 轮廓强度__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__轮廓强度__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D34 RID: 138548 RVA: 0x0096C809 File Offset: 0x0096AA09
		[SkipLocalsInit]
		public virtual void 衰退范围__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__衰退范围__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D35 RID: 138549 RVA: 0x0096C81D File Offset: 0x0096AA1D
		[SkipLocalsInit]
		public virtual void 衰退范围__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__衰退范围__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D36 RID: 138550 RVA: 0x0096C831 File Offset: 0x0096AA31
		[SkipLocalsInit]
		public virtual void Timeline_0__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__Timeline_0__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D37 RID: 138551 RVA: 0x0096C845 File Offset: 0x0096AA45
		[SkipLocalsInit]
		public virtual void Timeline_0__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__Timeline_0__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D38 RID: 138552 RVA: 0x0096C859 File Offset: 0x0096AA59
		[SkipLocalsInit]
		public virtual void 扫描带强度__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__扫描带强度__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D39 RID: 138553 RVA: 0x0096C86D File Offset: 0x0096AA6D
		[SkipLocalsInit]
		public virtual void 扫描带强度__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__扫描带强度__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D3A RID: 138554 RVA: 0x0096C881 File Offset: 0x0096AA81
		[SkipLocalsInit]
		public virtual void 扫描范围__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__扫描范围__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D3B RID: 138555 RVA: 0x0096C895 File Offset: 0x0096AA95
		[SkipLocalsInit]
		public virtual void 扫描范围__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__扫描范围__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021D3C RID: 138556 RVA: 0x0096C8AC File Offset: 0x0096AAAC
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_DistortionWave_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DistortionWave_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DistortionWave_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DistortionWave_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DistortionWave_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021D3D RID: 138557 RVA: 0x0096C8F4 File Offset: 0x0096AAF4
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_DistortionWave_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DistortionWave_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DistortionWave_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DistortionWave_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DistortionWave_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021D3E RID: 138558 RVA: 0x0096C93A File Offset: 0x0096AB3A
		protected BP_DistortionWave_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A6F RID: 76399
		[StaticVariableRuleIgnore]
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012A70 RID: 76400
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_DistortionWave.BP_DistortionWave_C";

		// Token: 0x04012A71 RID: 76401
		private static IntPtr _ClassPtr;

		// Token: 0x04012A72 RID: 76402
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012A73 RID: 76403
		internal static int __PropertyOffset_PostProcess;

		// Token: 0x04012A74 RID: 76404
		internal static int __PropertyOffset_Timeline_0;

		// Token: 0x04012A75 RID: 76405
		internal static int __PropertyOffset_衰退范围;

		// Token: 0x04012A76 RID: 76406
		internal static int __PropertyOffset_轮廓强度;

		// Token: 0x04012A77 RID: 76407
		internal static int __PropertyOffset_扫描带强度;

		// Token: 0x04012A78 RID: 76408
		internal static int __PropertyOffset_扫描范围;

		// Token: 0x04012A79 RID: 76409
		internal static int __PropertyOffset_ScanMaterial;

		// Token: 0x04012A7A RID: 76410
		internal static int __PropertyOffset_反向;

		// Token: 0x04012A7B RID: 76411
		internal static int __PropertyOffset_Play_Time;

		// Token: 0x04012A7C RID: 76412
		internal static int __PropertyOffset_ScanMaterialMID;

		// Token: 0x04012A7D RID: 76413
		internal static int __PropertyOffset_PlaySpeed;

		// Token: 0x04012A7E RID: 76414
		internal static int __PropertyOffset_StartTicking;

		// Token: 0x04012A7F RID: 76415
		internal static int __PropertyOffset_IsUsedForSeq;

		// Token: 0x04012A80 RID: 76416
		internal static int __PropertyOffset_SeqLifeCycle;

		// Token: 0x04012A81 RID: 76417
		private static IntPtr __StartScanEffect_NativeFunctionPtr;

		// Token: 0x04012A82 RID: 76418
		private static IntPtr __SetRevert_NativeFunctionPtr;

		// Token: 0x04012A83 RID: 76419
		private static IntPtr __轮廓强度__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04012A84 RID: 76420
		private static IntPtr __轮廓强度__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04012A85 RID: 76421
		private static IntPtr __衰退范围__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04012A86 RID: 76422
		private static IntPtr __衰退范围__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04012A87 RID: 76423
		private static IntPtr __Timeline_0__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04012A88 RID: 76424
		private static IntPtr __Timeline_0__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04012A89 RID: 76425
		private static IntPtr __扫描带强度__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04012A8A RID: 76426
		private static IntPtr __扫描带强度__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04012A8B RID: 76427
		private static IntPtr __扫描范围__FinishedFunc_NativeFunctionPtr;

		// Token: 0x04012A8C RID: 76428
		private static IntPtr __扫描范围__UpdateFunc_NativeFunctionPtr;

		// Token: 0x04012A8D RID: 76429
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x020090F8 RID: 37112
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CFD6 RID: 184278
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
