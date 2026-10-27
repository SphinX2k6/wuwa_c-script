using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Sequence
{
	// Token: 0x02003ADC RID: 15068
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Sequence/BP_RuntimeShadow.BP_RuntimeShadow_C")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class BP_RuntimeShadow_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060208A5 RID: 133285 RVA: 0x008D59A9 File Offset: 0x008D3BA9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RuntimeShadow_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Sequence/BP_RuntimeShadow.BP_RuntimeShadow_C");
			}
			return BP_RuntimeShadow_C._ClassPtr;
		}

		// Token: 0x060208A6 RID: 133286 RVA: 0x008D59D0 File Offset: 0x008D3BD0
		public BP_RuntimeShadow_C() : this(BuiltinUtils.AllocNativeUObject(BP_RuntimeShadow_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060208A7 RID: 133287 RVA: 0x008D59F8 File Offset: 0x008D3BF8
		[NullableContext(1)]
		public BP_RuntimeShadow_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RuntimeShadow_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003143 RID: 12611
		// (get) Token: 0x060208A8 RID: 133288 RVA: 0x008D5A2B File Offset: 0x008D3C2B
		// (set) Token: 0x060208A9 RID: 133289 RVA: 0x008D5A3F File Offset: 0x008D3C3F
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RuntimeShadow_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RuntimeShadow_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x060208AA RID: 133290 RVA: 0x008D5A54 File Offset: 0x008D3C54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RuntimeShadow_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060208AB RID: 133291 RVA: 0x008D5A68 File Offset: 0x008D3C68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RuntimeShadow_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060208AC RID: 133292 RVA: 0x008D5A80 File Offset: 0x008D3C80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_RuntimeShadow_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_RuntimeShadow_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RuntimeShadow_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RuntimeShadow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RuntimeShadow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060208AD RID: 133293 RVA: 0x008D5AC8 File Offset: 0x008D3CC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_RuntimeShadow_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_RuntimeShadow_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RuntimeShadow_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RuntimeShadow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RuntimeShadow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060208AE RID: 133294 RVA: 0x008D5B10 File Offset: 0x008D3D10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_RuntimeShadow_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_RuntimeShadow_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_RuntimeShadow_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RuntimeShadow_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RuntimeShadow_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060208AF RID: 133295 RVA: 0x008D5B5C File Offset: 0x008D3D5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_RuntimeShadow_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_RuntimeShadow_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_RuntimeShadow_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RuntimeShadow_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RuntimeShadow_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060208B0 RID: 133296 RVA: 0x008D5BA8 File Offset: 0x008D3DA8
		protected BP_RuntimeShadow_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC4C RID: 64588
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Sequence/BP_RuntimeShadow.BP_RuntimeShadow_C";

		// Token: 0x0400FC4D RID: 64589
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC4E RID: 64590
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC4F RID: 64591
		internal static int __PropertyOffset_1;

		// Token: 0x0400FC50 RID: 64592
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FC51 RID: 64593
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FC52 RID: 64594
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009BD5 RID: 39893
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031267 RID: 201319
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009BD6 RID: 39894
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031268 RID: 201320
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
