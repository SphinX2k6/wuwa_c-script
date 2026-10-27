using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common
{
	// Token: 0x02003E81 RID: 16001
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_WayFinding.BP_Fx_WayFinding_C")]
	[UnrealStructLayout(1488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1484)]
	public class BP_Fx_WayFinding_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602864B RID: 165451 RVA: 0x009AB5BD File Offset: 0x009A97BD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Fx_WayFinding_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_WayFinding.BP_Fx_WayFinding_C");
			}
			return BP_Fx_WayFinding_C._ClassPtr;
		}

		// Token: 0x0602864C RID: 165452 RVA: 0x009AB5E4 File Offset: 0x009A97E4
		public BP_Fx_WayFinding_C() : this(BuiltinUtils.AllocNativeUObject(BP_Fx_WayFinding_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602864D RID: 165453 RVA: 0x009AB60C File Offset: 0x009A980C
		[NullableContext(1)]
		public BP_Fx_WayFinding_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Fx_WayFinding_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D8A RID: 23946
		// (get) Token: 0x0602864E RID: 165454 RVA: 0x009AB63F File Offset: 0x009A983F
		// (set) Token: 0x0602864F RID: 165455 RVA: 0x009AB653 File Offset: 0x009A9853
		public unsafe UNiagaraComponent NS_Fx_WayFinding
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_WayFinding_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_WayFinding_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005D8B RID: 23947
		// (get) Token: 0x06028650 RID: 165456 RVA: 0x009AB668 File Offset: 0x009A9868
		// (set) Token: 0x06028651 RID: 165457 RVA: 0x009AB67C File Offset: 0x009A987C
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_WayFinding_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Fx_WayFinding_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005D8C RID: 23948
		// (get) Token: 0x06028652 RID: 165458 RVA: 0x009AB691 File Offset: 0x009A9891
		// (set) Token: 0x06028653 RID: 165459 RVA: 0x009AB6A1 File Offset: 0x009A98A1
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_WayFinding_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_WayFinding_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005D8D RID: 23949
		// (get) Token: 0x06028654 RID: 165460 RVA: 0x009AB6B2 File Offset: 0x009A98B2
		// (set) Token: 0x06028655 RID: 165461 RVA: 0x009AB6C2 File Offset: 0x009A98C2
		public unsafe int MinFragmentsNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_WayFinding_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_WayFinding_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005D8E RID: 23950
		// (get) Token: 0x06028656 RID: 165462 RVA: 0x009AB6D3 File Offset: 0x009A98D3
		// (set) Token: 0x06028657 RID: 165463 RVA: 0x009AB6E3 File Offset: 0x009A98E3
		public unsafe bool Deactivating
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_WayFinding_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_WayFinding_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D8F RID: 23951
		// (get) Token: 0x06028658 RID: 165464 RVA: 0x009AB6F4 File Offset: 0x009A98F4
		// (set) Token: 0x06028659 RID: 165465 RVA: 0x009AB704 File Offset: 0x009A9904
		public unsafe float DeactiveAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_WayFinding_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_WayFinding_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005D90 RID: 23952
		// (get) Token: 0x0602865A RID: 165466 RVA: 0x009AB715 File Offset: 0x009A9915
		// (set) Token: 0x0602865B RID: 165467 RVA: 0x009AB725 File Offset: 0x009A9925
		public unsafe float DeactiveAlphaSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Fx_WayFinding_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Fx_WayFinding_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x0602865C RID: 165468 RVA: 0x009AB736 File Offset: 0x009A9936
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_WayFinding_C.__StopEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0602865D RID: 165469 RVA: 0x009AB74A File Offset: 0x009A994A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EnsureEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_WayFinding_C.__EnsureEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0602865E RID: 165470 RVA: 0x009AB75E File Offset: 0x009A995E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_WayFinding_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602865F RID: 165471 RVA: 0x009AB772 File Offset: 0x009A9972
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_WayFinding_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06028660 RID: 165472 RVA: 0x009AB788 File Offset: 0x009A9988
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Fx_WayFinding_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_WayFinding_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_WayFinding_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_WayFinding_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Fx_WayFinding_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06028661 RID: 165473 RVA: 0x009AB7D0 File Offset: 0x009A99D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Fx_WayFinding_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Fx_WayFinding_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Fx_WayFinding_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Fx_WayFinding_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Fx_WayFinding_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06028662 RID: 165474 RVA: 0x009AB817 File Offset: 0x009A9A17
		protected BP_Fx_WayFinding_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401496C RID: 84332
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Effect/BluePrint/BP_FX_Common/BP_Fx_WayFinding.BP_Fx_WayFinding_C";

		// Token: 0x0401496D RID: 84333
		private static IntPtr _ClassPtr;

		// Token: 0x0401496E RID: 84334
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401496F RID: 84335
		internal static int __PropertyOffset_1;

		// Token: 0x04014970 RID: 84336
		internal static int __PropertyOffset_2;

		// Token: 0x04014971 RID: 84337
		internal static int __PropertyOffset_3;

		// Token: 0x04014972 RID: 84338
		internal static int __PropertyOffset_4;

		// Token: 0x04014973 RID: 84339
		internal static int __PropertyOffset_5;

		// Token: 0x04014974 RID: 84340
		internal static int __PropertyOffset_6;

		// Token: 0x04014975 RID: 84341
		internal static int __PropertyOffset_7;

		// Token: 0x04014976 RID: 84342
		private static IntPtr __StopEffect_NativeFunctionPtr;

		// Token: 0x04014977 RID: 84343
		private static IntPtr __EnsureEffect_NativeFunctionPtr;

		// Token: 0x04014978 RID: 84344
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04014979 RID: 84345
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A2D7 RID: 41687
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403201A RID: 204826
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
