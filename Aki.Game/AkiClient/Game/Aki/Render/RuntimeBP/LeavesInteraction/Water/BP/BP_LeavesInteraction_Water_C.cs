using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.LeavesInteraction.Water.BP
{
	// Token: 0x02003CFD RID: 15613
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/LeavesInteraction/Water/BP/BP_LeavesInteraction_Water.BP_LeavesInteraction_Water_C")]
	[UnrealStructLayout(1464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1464)]
	public class BP_LeavesInteraction_Water_C : AInteractiveWaterLeaves, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025493 RID: 152723 RVA: 0x009560BD File Offset: 0x009542BD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LeavesInteraction_Water_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/LeavesInteraction/Water/BP/BP_LeavesInteraction_Water.BP_LeavesInteraction_Water_C");
			}
			return BP_LeavesInteraction_Water_C._ClassPtr;
		}

		// Token: 0x06025494 RID: 152724 RVA: 0x009560E4 File Offset: 0x009542E4
		public BP_LeavesInteraction_Water_C() : this(BuiltinUtils.AllocNativeUObject(BP_LeavesInteraction_Water_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025495 RID: 152725 RVA: 0x0095610C File Offset: 0x0095430C
		[NullableContext(1)]
		public BP_LeavesInteraction_Water_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LeavesInteraction_Water_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06025496 RID: 152726 RVA: 0x0095613F File Offset: 0x0095433F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_Water_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025497 RID: 152727 RVA: 0x00956153 File Offset: 0x00954353
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LeavesInteraction_Water_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025498 RID: 152728 RVA: 0x00956168 File Offset: 0x00954368
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_LeavesInteraction_Water_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LeavesInteraction_Water_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LeavesInteraction_Water_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LeavesInteraction_Water_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesInteraction_Water_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025499 RID: 152729 RVA: 0x009561B0 File Offset: 0x009543B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_LeavesInteraction_Water_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LeavesInteraction_Water_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LeavesInteraction_Water_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LeavesInteraction_Water_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LeavesInteraction_Water_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602549A RID: 152730 RVA: 0x009561F7 File Offset: 0x009543F7
		protected BP_LeavesInteraction_Water_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012963 RID: 76131
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/LeavesInteraction/Water/BP/BP_LeavesInteraction_Water.BP_LeavesInteraction_Water_C";

		// Token: 0x04012964 RID: 76132
		private static IntPtr _ClassPtr;

		// Token: 0x04012965 RID: 76133
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012966 RID: 76134
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012967 RID: 76135
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009FE1 RID: 40929
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A6B RID: 203371
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
