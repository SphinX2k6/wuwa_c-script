using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Framework
{
	// Token: 0x02003A07 RID: 14855
	[UnrealObjectPath("/Game/Aki/UI/Framework/BP_3DTextAdaptSize.BP_3DTextAdaptSize_C")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class BP_3DTextAdaptSize_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F1F6 RID: 127478 RVA: 0x008AB69E File Offset: 0x008A989E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_3DTextAdaptSize_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Framework/BP_3DTextAdaptSize.BP_3DTextAdaptSize_C");
			}
			return BP_3DTextAdaptSize_C._ClassPtr;
		}

		// Token: 0x0601F1F7 RID: 127479 RVA: 0x008AB6C4 File Offset: 0x008A98C4
		public BP_3DTextAdaptSize_C() : this(BuiltinUtils.AllocNativeUObject(BP_3DTextAdaptSize_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F1F8 RID: 127480 RVA: 0x008AB6EC File Offset: 0x008A98EC
		[NullableContext(1)]
		public BP_3DTextAdaptSize_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_3DTextAdaptSize_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170029FE RID: 10750
		// (get) Token: 0x0601F1F9 RID: 127481 RVA: 0x008AB71F File Offset: 0x008A991F
		// (set) Token: 0x0601F1FA RID: 127482 RVA: 0x008AB733 File Offset: 0x008A9933
		public unsafe FVectorDouble CurrentLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170029FF RID: 10751
		// (get) Token: 0x0601F1FB RID: 127483 RVA: 0x008AB748 File Offset: 0x008A9948
		// (set) Token: 0x0601F1FC RID: 127484 RVA: 0x008AB75C File Offset: 0x008A995C
		[Nullable(2)]
		public unsafe UUIText UIText
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIText>(base.NativePtr / (IntPtr)sizeof(void*) + BP_3DTextAdaptSize_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_3DTextAdaptSize_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002A00 RID: 10752
		// (get) Token: 0x0601F1FD RID: 127485 RVA: 0x008AB771 File Offset: 0x008A9971
		// (set) Token: 0x0601F1FE RID: 127486 RVA: 0x008AB781 File Offset: 0x008A9981
		public unsafe double TargetDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17002A01 RID: 10753
		// (get) Token: 0x0601F1FF RID: 127487 RVA: 0x008AB792 File Offset: 0x008A9992
		// (set) Token: 0x0601F200 RID: 127488 RVA: 0x008AB7A2 File Offset: 0x008A99A2
		public unsafe float OriginalSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002A02 RID: 10754
		// (get) Token: 0x0601F201 RID: 127489 RVA: 0x008AB7B3 File Offset: 0x008A99B3
		// (set) Token: 0x0601F202 RID: 127490 RVA: 0x008AB7C3 File Offset: 0x008A99C3
		public unsafe bool bSetOriginRealSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A03 RID: 10755
		// (get) Token: 0x0601F203 RID: 127491 RVA: 0x008AB7D4 File Offset: 0x008A99D4
		// (set) Token: 0x0601F204 RID: 127492 RVA: 0x008AB7E8 File Offset: 0x008A99E8
		public unsafe FVector2D OriginalRealSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002A04 RID: 10756
		// (get) Token: 0x0601F205 RID: 127493 RVA: 0x008AB7FD File Offset: 0x008A99FD
		// (set) Token: 0x0601F206 RID: 127494 RVA: 0x008AB80D File Offset: 0x008A9A0D
		public unsafe bool AdaptEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A05 RID: 10757
		// (get) Token: 0x0601F207 RID: 127495 RVA: 0x008AB81E File Offset: 0x008A9A1E
		// (set) Token: 0x0601F208 RID: 127496 RVA: 0x008AB82E File Offset: 0x008A9A2E
		public unsafe bool Vertical
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A06 RID: 10758
		// (get) Token: 0x0601F209 RID: 127497 RVA: 0x008AB83F File Offset: 0x008A9A3F
		// (set) Token: 0x0601F20A RID: 127498 RVA: 0x008AB84F File Offset: 0x008A9A4F
		public unsafe float FontSizeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_3DTextAdaptSize_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x0601F20B RID: 127499 RVA: 0x008AB860 File Offset: 0x008A9A60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetAppropriateScale(ref float Result)
		{
			BP_3DTextAdaptSize_C.__GetAppropriateScale_FunctionParams* ptr = stackalloc BP_3DTextAdaptSize_C.__GetAppropriateScale_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_3DTextAdaptSize_C.__GetAppropriateScale_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_3DTextAdaptSize_C.__GetAppropriateScale_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_3DTextAdaptSize_C.__GetAppropriateScale_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x0601F20C RID: 127500 RVA: 0x008AB8B0 File Offset: 0x008A9AB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AdjustTextSize(float ToAdjustSize)
		{
			BP_3DTextAdaptSize_C.__AdjustTextSize_FunctionParams* ptr = stackalloc BP_3DTextAdaptSize_C.__AdjustTextSize_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(BP_3DTextAdaptSize_C.__AdjustTextSize_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_3DTextAdaptSize_C.__AdjustTextSize_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ToAdjustSize = ToAdjustSize;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_3DTextAdaptSize_C.__AdjustTextSize_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F20D RID: 127501 RVA: 0x008AB8F8 File Offset: 0x008A9AF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalculateTargetDistance(float FontSize, ref double TargetDistance)
		{
			BP_3DTextAdaptSize_C.__CalculateTargetDistance_FunctionParams* ptr = stackalloc BP_3DTextAdaptSize_C.__CalculateTargetDistance_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_3DTextAdaptSize_C.__CalculateTargetDistance_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_3DTextAdaptSize_C.__CalculateTargetDistance_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FontSize = FontSize;
			ptr->TargetDistance = TargetDistance;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_3DTextAdaptSize_C.__CalculateTargetDistance_NativeFunctionPtr, (void*)ptr);
			TargetDistance = ptr->TargetDistance;
		}

		// Token: 0x0601F20E RID: 127502 RVA: 0x008AB950 File Offset: 0x008A9B50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalculatePower(float FontSize, ref float Power)
		{
			BP_3DTextAdaptSize_C.__CalculatePower_FunctionParams* ptr = stackalloc BP_3DTextAdaptSize_C.__CalculatePower_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_3DTextAdaptSize_C.__CalculatePower_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_3DTextAdaptSize_C.__CalculatePower_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FontSize = FontSize;
			ptr->Power = Power;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_3DTextAdaptSize_C.__CalculatePower_NativeFunctionPtr, (void*)ptr);
			Power = ptr->Power;
		}

		// Token: 0x0601F20F RID: 127503 RVA: 0x008AB9A6 File Offset: 0x008A9BA6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RefreshOriginalInfo()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_3DTextAdaptSize_C.__RefreshOriginalInfo_NativeFunctionPtr, null);
		}

		// Token: 0x0601F210 RID: 127504 RVA: 0x008AB9BA File Offset: 0x008A9BBA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_3DTextAdaptSize_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601F211 RID: 127505 RVA: 0x008AB9CE File Offset: 0x008A9BCE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_3DTextAdaptSize_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F212 RID: 127506 RVA: 0x008AB9E4 File Offset: 0x008A9BE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_3DTextAdaptSize_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_3DTextAdaptSize_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_3DTextAdaptSize_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_3DTextAdaptSize_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_3DTextAdaptSize_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F213 RID: 127507 RVA: 0x008ABA2C File Offset: 0x008A9C2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_3DTextAdaptSize_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_3DTextAdaptSize_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_3DTextAdaptSize_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_3DTextAdaptSize_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_3DTextAdaptSize_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F214 RID: 127508 RVA: 0x008ABA73 File Offset: 0x008A9C73
		protected BP_3DTextAdaptSize_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EE50 RID: 61008
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/Framework/BP_3DTextAdaptSize.BP_3DTextAdaptSize_C";

		// Token: 0x0400EE51 RID: 61009
		private static IntPtr _ClassPtr;

		// Token: 0x0400EE52 RID: 61010
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EE53 RID: 61011
		internal static int __PropertyOffset_1;

		// Token: 0x0400EE54 RID: 61012
		internal static int __PropertyOffset_2;

		// Token: 0x0400EE55 RID: 61013
		internal static int __PropertyOffset_3;

		// Token: 0x0400EE56 RID: 61014
		internal static int __PropertyOffset_4;

		// Token: 0x0400EE57 RID: 61015
		internal static int __PropertyOffset_5;

		// Token: 0x0400EE58 RID: 61016
		internal static int __PropertyOffset_6;

		// Token: 0x0400EE59 RID: 61017
		internal static int __PropertyOffset_7;

		// Token: 0x0400EE5A RID: 61018
		internal static int __PropertyOffset_8;

		// Token: 0x0400EE5B RID: 61019
		internal static int __PropertyOffset_9;

		// Token: 0x0400EE5C RID: 61020
		private static IntPtr __GetAppropriateScale_NativeFunctionPtr;

		// Token: 0x0400EE5D RID: 61021
		private static IntPtr __AdjustTextSize_NativeFunctionPtr;

		// Token: 0x0400EE5E RID: 61022
		private static IntPtr __CalculateTargetDistance_NativeFunctionPtr;

		// Token: 0x0400EE5F RID: 61023
		private static IntPtr __CalculatePower_NativeFunctionPtr;

		// Token: 0x0400EE60 RID: 61024
		private static IntPtr __RefreshOriginalInfo_NativeFunctionPtr;

		// Token: 0x0400EE61 RID: 61025
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400EE62 RID: 61026
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009A18 RID: 39448
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetAppropriateScale_FunctionParams
		{
			// Token: 0x04030F02 RID: 200450
			[FieldOffset(0)]
			public float Result;
		}

		// Token: 0x02009A19 RID: 39449
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __AdjustTextSize_FunctionParams
		{
			// Token: 0x04030F03 RID: 200451
			[FieldOffset(0)]
			public float ToAdjustSize;
		}

		// Token: 0x02009A1A RID: 39450
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __CalculateTargetDistance_FunctionParams
		{
			// Token: 0x04030F04 RID: 200452
			[FieldOffset(0)]
			public float FontSize;

			// Token: 0x04030F05 RID: 200453
			[FieldOffset(8)]
			public double TargetDistance;
		}

		// Token: 0x02009A1B RID: 39451
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __CalculatePower_FunctionParams
		{
			// Token: 0x04030F06 RID: 200454
			[FieldOffset(0)]
			public float FontSize;

			// Token: 0x04030F07 RID: 200455
			[FieldOffset(4)]
			public float Power;
		}

		// Token: 0x02009A1C RID: 39452
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04030F08 RID: 200456
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
