using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common
{
	// Token: 0x0200340A RID: 13322
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_WayFinding.BP_Fx_WayFinding_C")]
	[UnrealStructLayout(1488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1484)]
	public class BP_Fx_WayFinding_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021DAB RID: 138667 RVA: 0x0096D34F File Offset: 0x0096B54F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Fx_WayFinding_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_WayFinding.BP_Fx_WayFinding_C");
			}
			return BP_Fx_WayFinding_C._ClassPtr;
		}

		// Token: 0x06021DAC RID: 138668 RVA: 0x0096D374 File Offset: 0x0096B574
		public BP_Fx_WayFinding_C() : this(BuiltinUtils.AllocNativeUObject(BP_Fx_WayFinding_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021DAD RID: 138669 RVA: 0x0096D39C File Offset: 0x0096B59C
		[NullableContext(1)]
		public BP_Fx_WayFinding_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Fx_WayFinding_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700465D RID: 18013
		// (get) Token: 0x06021DAE RID: 138670 RVA: 0x0096D3CF File Offset: 0x0096B5CF
		// (set) Token: 0x06021DAF RID: 138671 RVA: 0x0096D3E3 File Offset: 0x0096B5E3
		public unsafe UNiagaraComponent NS_Fx_WayFinding
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_WayFinding_C.__PropertyOffset_NS_Fx_WayFinding);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_WayFinding_C.__PropertyOffset_NS_Fx_WayFinding, value);
			}
		}

		// Token: 0x1700465E RID: 18014
		// (get) Token: 0x06021DB0 RID: 138672 RVA: 0x0096D3F8 File Offset: 0x0096B5F8
		// (set) Token: 0x06021DB1 RID: 138673 RVA: 0x0096D40C File Offset: 0x0096B60C
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_WayFinding_C.__PropertyOffset_Spline);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_WayFinding_C.__PropertyOffset_Spline, value);
			}
		}

		// Token: 0x1700465F RID: 18015
		// (get) Token: 0x06021DB2 RID: 138674 RVA: 0x0096D421 File Offset: 0x0096B621
		// (set) Token: 0x06021DB3 RID: 138675 RVA: 0x0096D431 File Offset: 0x0096B631
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_WayFinding_C.__PropertyOffset_Distance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_WayFinding_C.__PropertyOffset_Distance) = value;
			}
		}

		// Token: 0x17004660 RID: 18016
		// (get) Token: 0x06021DB4 RID: 138676 RVA: 0x0096D442 File Offset: 0x0096B642
		// (set) Token: 0x06021DB5 RID: 138677 RVA: 0x0096D452 File Offset: 0x0096B652
		public unsafe int MinFragmentsNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_WayFinding_C.__PropertyOffset_MinFragmentsNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_WayFinding_C.__PropertyOffset_MinFragmentsNum) = value;
			}
		}

		// Token: 0x17004661 RID: 18017
		// (get) Token: 0x06021DB6 RID: 138678 RVA: 0x0096D463 File Offset: 0x0096B663
		// (set) Token: 0x06021DB7 RID: 138679 RVA: 0x0096D473 File Offset: 0x0096B673
		public unsafe bool Deactivating
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_WayFinding_C.__PropertyOffset_Deactivating) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_WayFinding_C.__PropertyOffset_Deactivating) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004662 RID: 18018
		// (get) Token: 0x06021DB8 RID: 138680 RVA: 0x0096D484 File Offset: 0x0096B684
		// (set) Token: 0x06021DB9 RID: 138681 RVA: 0x0096D494 File Offset: 0x0096B694
		public unsafe float DeactiveAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_WayFinding_C.__PropertyOffset_DeactiveAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_WayFinding_C.__PropertyOffset_DeactiveAlpha) = value;
			}
		}

		// Token: 0x17004663 RID: 18019
		// (get) Token: 0x06021DBA RID: 138682 RVA: 0x0096D4A5 File Offset: 0x0096B6A5
		// (set) Token: 0x06021DBB RID: 138683 RVA: 0x0096D4B5 File Offset: 0x0096B6B5
		public unsafe float DeactiveAlphaSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_WayFinding_C.__PropertyOffset_DeactiveAlphaSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_WayFinding_C.__PropertyOffset_DeactiveAlphaSpeed) = value;
			}
		}

		// Token: 0x06021DBC RID: 138684 RVA: 0x0096D4C6 File Offset: 0x0096B6C6
		[SkipLocalsInit]
		public virtual void StopEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_WayFinding_C.__StopEffect_NativeFunctionPtr, null);
		}

		// Token: 0x06021DBD RID: 138685 RVA: 0x0096D4DA File Offset: 0x0096B6DA
		[SkipLocalsInit]
		public virtual void EnsureEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_WayFinding_C.__EnsureEffect_NativeFunctionPtr, null);
		}

		// Token: 0x06021DBE RID: 138686 RVA: 0x0096D4EE File Offset: 0x0096B6EE
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_WayFinding_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021DBF RID: 138687 RVA: 0x0096D502 File Offset: 0x0096B702
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_WayFinding_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021DC0 RID: 138688 RVA: 0x0096D518 File Offset: 0x0096B718
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Fx_WayFinding_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_WayFinding_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_WayFinding_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_WayFinding_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_WayFinding_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021DC1 RID: 138689 RVA: 0x0096D560 File Offset: 0x0096B760
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Fx_WayFinding_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_WayFinding_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_WayFinding_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_WayFinding_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_WayFinding_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021DC2 RID: 138690 RVA: 0x0096D5A6 File Offset: 0x0096B7A6
		protected BP_Fx_WayFinding_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012AD3 RID: 76499
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_WayFinding.BP_Fx_WayFinding_C";

		// Token: 0x04012AD4 RID: 76500
		private static IntPtr _ClassPtr;

		// Token: 0x04012AD5 RID: 76501
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012AD6 RID: 76502
		internal static int __PropertyOffset_NS_Fx_WayFinding;

		// Token: 0x04012AD7 RID: 76503
		internal static int __PropertyOffset_Spline;

		// Token: 0x04012AD8 RID: 76504
		internal static int __PropertyOffset_Distance;

		// Token: 0x04012AD9 RID: 76505
		internal static int __PropertyOffset_MinFragmentsNum;

		// Token: 0x04012ADA RID: 76506
		internal static int __PropertyOffset_Deactivating;

		// Token: 0x04012ADB RID: 76507
		internal static int __PropertyOffset_DeactiveAlpha;

		// Token: 0x04012ADC RID: 76508
		internal static int __PropertyOffset_DeactiveAlphaSpeed;

		// Token: 0x04012ADD RID: 76509
		private static IntPtr __StopEffect_NativeFunctionPtr;

		// Token: 0x04012ADE RID: 76510
		private static IntPtr __EnsureEffect_NativeFunctionPtr;

		// Token: 0x04012ADF RID: 76511
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012AE0 RID: 76512
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x020090FC RID: 37116
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CFDA RID: 184282
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
