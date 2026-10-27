using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.BatchedClothDynamicPin
{
	// Token: 0x02003CD7 RID: 15575
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/BatchedClothDynamicPin/BP_BatchedBridgeRope.BP_BatchedBridgeRope_C")]
	[UnrealStructLayout(1752, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1745)]
	public class BP_BatchedBridgeRope_C : AKuroCSClothDynamicPinManager, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024F14 RID: 151316 RVA: 0x0094CC2C File Offset: 0x0094AE2C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BatchedBridgeRope_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/BatchedClothDynamicPin/BP_BatchedBridgeRope.BP_BatchedBridgeRope_C");
			}
			return BP_BatchedBridgeRope_C._ClassPtr;
		}

		// Token: 0x06024F15 RID: 151317 RVA: 0x0094CC50 File Offset: 0x0094AE50
		public BP_BatchedBridgeRope_C() : this(BuiltinUtils.AllocNativeUObject(BP_BatchedBridgeRope_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024F16 RID: 151318 RVA: 0x0094CC78 File Offset: 0x0094AE78
		[NullableContext(1)]
		public BP_BatchedBridgeRope_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BatchedBridgeRope_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170049F1 RID: 18929
		// (get) Token: 0x06024F17 RID: 151319 RVA: 0x0094CCAB File Offset: 0x0094AEAB
		// (set) Token: 0x06024F18 RID: 151320 RVA: 0x0094CCBF File Offset: 0x0094AEBF
		[Nullable(2)]
		public unsafe UBoxComponent ValidBox
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedBridgeRope_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BatchedBridgeRope_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170049F2 RID: 18930
		// (get) Token: 0x06024F19 RID: 151321 RVA: 0x0094CCD4 File Offset: 0x0094AED4
		// (set) Token: 0x06024F1A RID: 151322 RVA: 0x0094CCE4 File Offset: 0x0094AEE4
		public unsafe bool InitOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BatchedBridgeRope_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BatchedBridgeRope_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024F1B RID: 151323 RVA: 0x0094CCF5 File Offset: 0x0094AEF5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedBridgeRope_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024F1C RID: 151324 RVA: 0x0094CD09 File Offset: 0x0094AF09
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BatchedBridgeRope_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024F1D RID: 151325 RVA: 0x0094CD1E File Offset: 0x0094AF1E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedBridgeRope_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024F1E RID: 151326 RVA: 0x0094CD32 File Offset: 0x0094AF32
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BatchedBridgeRope_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024F1F RID: 151327 RVA: 0x0094CD48 File Offset: 0x0094AF48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BatchedBridgeRope_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BatchedBridgeRope_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BatchedBridgeRope_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedBridgeRope_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedBridgeRope_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024F20 RID: 151328 RVA: 0x0094CD90 File Offset: 0x0094AF90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BatchedBridgeRope_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BatchedBridgeRope_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BatchedBridgeRope_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedBridgeRope_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BatchedBridgeRope_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024F21 RID: 151329 RVA: 0x0094CDD8 File Offset: 0x0094AFD8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_BatchedBridgeRope_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BatchedBridgeRope_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_BatchedBridgeRope_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedBridgeRope_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedBridgeRope_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024F22 RID: 151330 RVA: 0x0094CE94 File Offset: 0x0094B094
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_BatchedBridgeRope_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BatchedBridgeRope_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_BatchedBridgeRope_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BatchedBridgeRope_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BatchedBridgeRope_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024F23 RID: 151331 RVA: 0x0094CF1D File Offset: 0x0094B11D
		protected BP_BatchedBridgeRope_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125EA RID: 75242
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/BatchedClothDynamicPin/BP_BatchedBridgeRope.BP_BatchedBridgeRope_C";

		// Token: 0x040125EB RID: 75243
		private static IntPtr _ClassPtr;

		// Token: 0x040125EC RID: 75244
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040125ED RID: 75245
		internal static int __PropertyOffset_1;

		// Token: 0x040125EE RID: 75246
		internal static int __PropertyOffset_2;

		// Token: 0x040125EF RID: 75247
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040125F0 RID: 75248
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040125F1 RID: 75249
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040125F2 RID: 75250
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040125F3 RID: 75251
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009F94 RID: 40852
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040319CA RID: 203210
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F95 RID: 40853
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040319CB RID: 203211
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040319CC RID: 203212
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040319CD RID: 203213
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040319CE RID: 203214
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040319CF RID: 203215
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040319D0 RID: 203216
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F96 RID: 40854
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040319D1 RID: 203217
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040319D2 RID: 203218
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040319D3 RID: 203219
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040319D4 RID: 203220
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
