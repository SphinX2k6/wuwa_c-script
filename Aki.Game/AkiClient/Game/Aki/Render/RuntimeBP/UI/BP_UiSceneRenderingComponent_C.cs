using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.UI
{
	// Token: 0x02003AA0 RID: 15008
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/UI/BP_UiSceneRenderingComponent.BP_UiSceneRenderingComponent_C")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class BP_UiSceneRenderingComponent_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060201BD RID: 131517 RVA: 0x008C9CAB File Offset: 0x008C7EAB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_UiSceneRenderingComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/UI/BP_UiSceneRenderingComponent.BP_UiSceneRenderingComponent_C");
			}
			return BP_UiSceneRenderingComponent_C._ClassPtr;
		}

		// Token: 0x060201BE RID: 131518 RVA: 0x008C9CD0 File Offset: 0x008C7ED0
		public BP_UiSceneRenderingComponent_C() : this(BuiltinUtils.AllocNativeUObject(BP_UiSceneRenderingComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060201BF RID: 131519 RVA: 0x008C9CF8 File Offset: 0x008C7EF8
		[NullableContext(1)]
		public BP_UiSceneRenderingComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_UiSceneRenderingComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F04 RID: 12036
		// (get) Token: 0x060201C0 RID: 131520 RVA: 0x008C9D2B File Offset: 0x008C7F2B
		// (set) Token: 0x060201C1 RID: 131521 RVA: 0x008C9D3F File Offset: 0x008C7F3F
		public unsafe BP_GlobalGI_C BP_GlobalGI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GlobalGI_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UiSceneRenderingComponent_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UiSceneRenderingComponent_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002F05 RID: 12037
		// (get) Token: 0x060201C2 RID: 131522 RVA: 0x008C9D54 File Offset: 0x008C7F54
		// (set) Token: 0x060201C3 RID: 131523 RVA: 0x008C9D64 File Offset: 0x008C7F64
		public unsafe bool IsInUiSceneRenderingState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UiSceneRenderingComponent_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UiSceneRenderingComponent_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F06 RID: 12038
		// (get) Token: 0x060201C4 RID: 131524 RVA: 0x008C9D75 File Offset: 0x008C7F75
		// (set) Token: 0x060201C5 RID: 131525 RVA: 0x008C9D89 File Offset: 0x008C7F89
		[Nullable(1)]
		public unsafe string CurUiScenePath
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_UiSceneRenderingComponent_C.__PropertyOffset_3)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_UiSceneRenderingComponent_C.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x17002F07 RID: 12039
		// (get) Token: 0x060201C6 RID: 131526 RVA: 0x008C9D9E File Offset: 0x008C7F9E
		// (set) Token: 0x060201C7 RID: 131527 RVA: 0x008C9DB2 File Offset: 0x008C7FB2
		public unsafe UDirectionalLightComponent MainLightComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDirectionalLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UiSceneRenderingComponent_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UiSceneRenderingComponent_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x060201C8 RID: 131528 RVA: 0x008C9DC7 File Offset: 0x008C7FC7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnKuroEndUiScene()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UiSceneRenderingComponent_C.__OnKuroEndUiScene_NativeFunctionPtr, null);
		}

		// Token: 0x060201C9 RID: 131529 RVA: 0x008C9DDC File Offset: 0x008C7FDC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnKuroStartUiScene(string UiScenePath)
		{
			BP_UiSceneRenderingComponent_C.__OnKuroStartUiScene_FunctionParams* ptr = stackalloc BP_UiSceneRenderingComponent_C.__OnKuroStartUiScene_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_UiSceneRenderingComponent_C.__OnKuroStartUiScene_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UiSceneRenderingComponent_C.__OnKuroStartUiScene_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->UiScenePath), UiScenePath);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UiSceneRenderingComponent_C.__OnKuroStartUiScene_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_UiSceneRenderingComponent_C.__OnKuroStartUiScene_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060201CA RID: 131530 RVA: 0x008C9E3C File Offset: 0x008C803C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Init(BP_GlobalGI_C InGlobalGI)
		{
			BP_UiSceneRenderingComponent_C.__Init_FunctionParams* ptr = stackalloc BP_UiSceneRenderingComponent_C.__Init_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_UiSceneRenderingComponent_C.__Init_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UiSceneRenderingComponent_C.__Init_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InGlobalGI = ((InGlobalGI != null) ? InGlobalGI.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UiSceneRenderingComponent_C.__Init_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060201CB RID: 131531 RVA: 0x008C9E94 File Offset: 0x008C8094
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_UiSceneRenderingComponent_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_UiSceneRenderingComponent_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_UiSceneRenderingComponent_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UiSceneRenderingComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UiSceneRenderingComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060201CC RID: 131532 RVA: 0x008C9EE0 File Offset: 0x008C80E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_UiSceneRenderingComponent_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_UiSceneRenderingComponent_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_UiSceneRenderingComponent_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UiSceneRenderingComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UiSceneRenderingComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060201CD RID: 131533 RVA: 0x008C9F2C File Offset: 0x008C812C
		protected BP_UiSceneRenderingComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F824 RID: 63524
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/UI/BP_UiSceneRenderingComponent.BP_UiSceneRenderingComponent_C";

		// Token: 0x0400F825 RID: 63525
		private static IntPtr _ClassPtr;

		// Token: 0x0400F826 RID: 63526
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F827 RID: 63527
		internal static int __PropertyOffset_1;

		// Token: 0x0400F828 RID: 63528
		internal static int __PropertyOffset_2;

		// Token: 0x0400F829 RID: 63529
		internal static int __PropertyOffset_3;

		// Token: 0x0400F82A RID: 63530
		internal static int __PropertyOffset_4;

		// Token: 0x0400F82B RID: 63531
		private static IntPtr __OnKuroEndUiScene_NativeFunctionPtr;

		// Token: 0x0400F82C RID: 63532
		private static IntPtr __OnKuroStartUiScene_NativeFunctionPtr;

		// Token: 0x0400F82D RID: 63533
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x0400F82E RID: 63534
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009B74 RID: 39796
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __OnKuroStartUiScene_FunctionParams
		{
			// Token: 0x040311B8 RID: 201144
			[FieldOffset(0)]
			public FString UiScenePath;
		}

		// Token: 0x02009B75 RID: 39797
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Init_FunctionParams
		{
			// Token: 0x040311B9 RID: 201145
			[FieldOffset(0)]
			public IntPtr InGlobalGI;
		}

		// Token: 0x02009B76 RID: 39798
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040311BA RID: 201146
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
