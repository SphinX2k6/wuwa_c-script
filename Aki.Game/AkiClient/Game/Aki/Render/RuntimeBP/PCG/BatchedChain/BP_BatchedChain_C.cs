using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.BatchedChain
{
	// Token: 0x02003CD8 RID: 15576
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/BatchedChain/BP_BatchedChain.BP_BatchedChain_C")]
	[UnrealStructLayout(2216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2211)]
	public class BP_BatchedChain_C : ACSBatchedChainBoundsManager, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024F24 RID: 151332 RVA: 0x0094CF26 File Offset: 0x0094B126
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BatchedChain_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/BatchedChain/BP_BatchedChain.BP_BatchedChain_C");
			}
			return BP_BatchedChain_C._ClassPtr;
		}

		// Token: 0x06024F25 RID: 151333 RVA: 0x0094CF4C File Offset: 0x0094B14C
		public BP_BatchedChain_C() : this(BuiltinUtils.AllocNativeUObject(BP_BatchedChain_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024F26 RID: 151334 RVA: 0x0094CF74 File Offset: 0x0094B174
		[NullableContext(1)]
		public BP_BatchedChain_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BatchedChain_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170049F3 RID: 18931
		// (get) Token: 0x06024F27 RID: 151335 RVA: 0x0094CFA7 File Offset: 0x0094B1A7
		// (set) Token: 0x06024F28 RID: 151336 RVA: 0x0094CFBB File Offset: 0x0094B1BB
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_ClothController
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedChain_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedChain_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170049F4 RID: 18932
		// (get) Token: 0x06024F29 RID: 151337 RVA: 0x0094CFD0 File Offset: 0x0094B1D0
		// (set) Token: 0x06024F2A RID: 151338 RVA: 0x0094CFE0 File Offset: 0x0094B1E0
		public unsafe bool StopBP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedChain_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedChain_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049F5 RID: 18933
		// (get) Token: 0x06024F2B RID: 151339 RVA: 0x0094CFF1 File Offset: 0x0094B1F1
		// (set) Token: 0x06024F2C RID: 151340 RVA: 0x0094D001 File Offset: 0x0094B201
		public unsafe bool initOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedChain_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedChain_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x170049F6 RID: 18934
		// (get) Token: 0x06024F2D RID: 151341 RVA: 0x0094D012 File Offset: 0x0094B212
		// (set) Token: 0x06024F2E RID: 151342 RVA: 0x0094D022 File Offset: 0x0094B222
		public unsafe bool bAfterBeginplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedChain_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedChain_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024F2F RID: 151343 RVA: 0x0094D033 File Offset: 0x0094B233
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedChain_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024F30 RID: 151344 RVA: 0x0094D047 File Offset: 0x0094B247
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BatchedChain_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024F31 RID: 151345 RVA: 0x0094D05C File Offset: 0x0094B25C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedChain_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024F32 RID: 151346 RVA: 0x0094D070 File Offset: 0x0094B270
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BatchedChain_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024F33 RID: 151347 RVA: 0x0094D088 File Offset: 0x0094B288
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BatchedChain_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BatchedChain_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BatchedChain_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedChain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedChain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024F34 RID: 151348 RVA: 0x0094D0D0 File Offset: 0x0094B2D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BatchedChain_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BatchedChain_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BatchedChain_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedChain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BatchedChain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024F35 RID: 151349 RVA: 0x0094D118 File Offset: 0x0094B318
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_BatchedChain_ManagementBounds_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_BatchedChain_C.__BndEvt__BP_BatchedChain_ManagementBounds_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BatchedChain_C.__BndEvt__BP_BatchedChain_ManagementBounds_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_BatchedChain_C.__BndEvt__BP_BatchedChain_ManagementBounds_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedChain_C.__BndEvt__BP_BatchedChain_ManagementBounds_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedChain_C.__BndEvt__BP_BatchedChain_ManagementBounds_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024F36 RID: 151350 RVA: 0x0094D1D4 File Offset: 0x0094B3D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_BatchedChain_ManagementBounds_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_BatchedChain_C.__BndEvt__BP_BatchedChain_ManagementBounds_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BatchedChain_C.__BndEvt__BP_BatchedChain_ManagementBounds_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_BatchedChain_C.__BndEvt__BP_BatchedChain_ManagementBounds_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedChain_C.__BndEvt__BP_BatchedChain_ManagementBounds_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedChain_C.__BndEvt__BP_BatchedChain_ManagementBounds_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024F37 RID: 151351 RVA: 0x0094D25D File Offset: 0x0094B45D
		protected BP_BatchedChain_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125F4 RID: 75252
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/BatchedChain/BP_BatchedChain.BP_BatchedChain_C";

		// Token: 0x040125F5 RID: 75253
		private static IntPtr _ClassPtr;

		// Token: 0x040125F6 RID: 75254
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040125F7 RID: 75255
		internal static int __PropertyOffset_1;

		// Token: 0x040125F8 RID: 75256
		internal static int __PropertyOffset_2;

		// Token: 0x040125F9 RID: 75257
		internal static int __PropertyOffset_3;

		// Token: 0x040125FA RID: 75258
		internal static int __PropertyOffset_4;

		// Token: 0x040125FB RID: 75259
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040125FC RID: 75260
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040125FD RID: 75261
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040125FE RID: 75262
		private static IntPtr __BndEvt__BP_BatchedChain_ManagementBounds_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040125FF RID: 75263
		private static IntPtr __BndEvt__BP_BatchedChain_ManagementBounds_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009F97 RID: 40855
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040319D5 RID: 203221
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F98 RID: 40856
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_BatchedChain_ManagementBounds_K2Node_ComponentBoundEvent_1_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040319D6 RID: 203222
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040319D7 RID: 203223
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040319D8 RID: 203224
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040319D9 RID: 203225
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040319DA RID: 203226
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040319DB RID: 203227
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F99 RID: 40857
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_BatchedChain_ManagementBounds_K2Node_ComponentBoundEvent_2_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040319DC RID: 203228
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040319DD RID: 203229
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040319DE RID: 203230
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040319DF RID: 203231
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
