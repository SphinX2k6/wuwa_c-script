using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SceneTransition
{
	// Token: 0x02003BAD RID: 15277
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneTransition/BP_SceneTransitionComponent.BP_SceneTransitionComponent_C")]
	[UnrealStructLayout(672, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 672)]
	public class BP_SceneTransitionComponent_C : UKuroSceneTransitionComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022194 RID: 139668 RVA: 0x008FF16E File Offset: 0x008FD36E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SceneTransitionComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneTransition/BP_SceneTransitionComponent.BP_SceneTransitionComponent_C");
			}
			return BP_SceneTransitionComponent_C._ClassPtr;
		}

		// Token: 0x06022195 RID: 139669 RVA: 0x008FF194 File Offset: 0x008FD394
		public BP_SceneTransitionComponent_C() : this(BuiltinUtils.AllocNativeUObject(BP_SceneTransitionComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022196 RID: 139670 RVA: 0x008FF1BC File Offset: 0x008FD3BC
		[NullableContext(1)]
		public BP_SceneTransitionComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SceneTransitionComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170039C9 RID: 14793
		// (get) Token: 0x06022197 RID: 139671 RVA: 0x008FF1EF File Offset: 0x008FD3EF
		// (set) Token: 0x06022198 RID: 139672 RVA: 0x008FF203 File Offset: 0x008FD403
		public unsafe UStaticMeshComponent MeshComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneTransitionComponent_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneTransitionComponent_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170039CA RID: 14794
		// (get) Token: 0x06022199 RID: 139673 RVA: 0x008FF218 File Offset: 0x008FD418
		// (set) Token: 0x0602219A RID: 139674 RVA: 0x008FF22C File Offset: 0x008FD42C
		public unsafe UMaterialInterface ReplaceMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneTransitionComponent_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneTransitionComponent_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170039CB RID: 14795
		// (get) Token: 0x0602219B RID: 139675 RVA: 0x008FF241 File Offset: 0x008FD441
		// (set) Token: 0x0602219C RID: 139676 RVA: 0x008FF255 File Offset: 0x008FD455
		public unsafe UMaterialInterface ReplaceMaterialLOD
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneTransitionComponent_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneTransitionComponent_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170039CC RID: 14796
		// (get) Token: 0x0602219D RID: 139677 RVA: 0x008FF26A File Offset: 0x008FD46A
		// (set) Token: 0x0602219E RID: 139678 RVA: 0x008FF27E File Offset: 0x008FD47E
		public unsafe UStaticMeshComponent RootMeshComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneTransitionComponent_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneTransitionComponent_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x0602219F RID: 139679 RVA: 0x008FF294 File Offset: 0x008FD494
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void NeedDynMatForRoot(ref bool Out)
		{
			BP_SceneTransitionComponent_C.__NeedDynMatForRoot_FunctionParams* ptr = stackalloc BP_SceneTransitionComponent_C.__NeedDynMatForRoot_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SceneTransitionComponent_C.__NeedDynMatForRoot_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneTransitionComponent_C.__NeedDynMatForRoot_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Out = Out;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneTransitionComponent_C.__NeedDynMatForRoot_NativeFunctionPtr, (void*)ptr);
			Out = ptr->Out;
		}

		// Token: 0x060221A0 RID: 139680 RVA: 0x008FF2E4 File Offset: 0x008FD4E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetMaterialParameters(float DeltaTime, float TransitionAge, float TransitionNormalizedProcess)
		{
			BP_SceneTransitionComponent_C.__SetMaterialParameters_FunctionParams* ptr = stackalloc BP_SceneTransitionComponent_C.__SetMaterialParameters_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_SceneTransitionComponent_C.__SetMaterialParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneTransitionComponent_C.__SetMaterialParameters_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			ptr->TransitionAge = TransitionAge;
			ptr->TransitionNormalizedProcess = TransitionNormalizedProcess;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneTransitionComponent_C.__SetMaterialParameters_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060221A1 RID: 139681 RVA: 0x008FF338 File Offset: 0x008FD538
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void TickSceneTransition(float DeltaTime, float TransitionAge, float TransitionNormalizedProgress)
		{
			BP_SceneTransitionComponent_C.__TickSceneTransition_FunctionParams* ptr = stackalloc BP_SceneTransitionComponent_C.__TickSceneTransition_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_SceneTransitionComponent_C.__TickSceneTransition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneTransitionComponent_C.__TickSceneTransition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			ptr->TransitionAge = TransitionAge;
			ptr->TransitionNormalizedProgress = TransitionNormalizedProgress;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneTransitionComponent_C.__TickSceneTransition_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060221A2 RID: 139682 RVA: 0x008FF38C File Offset: 0x008FD58C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void TickSceneTransition_Implementation(float DeltaTime, float TransitionAge, float TransitionNormalizedProgress)
		{
			BP_SceneTransitionComponent_C.__TickSceneTransition_FunctionParams* ptr = stackalloc BP_SceneTransitionComponent_C.__TickSceneTransition_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_SceneTransitionComponent_C.__TickSceneTransition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneTransitionComponent_C.__TickSceneTransition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			ptr->TransitionAge = TransitionAge;
			ptr->TransitionNormalizedProgress = TransitionNormalizedProgress;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneTransitionComponent_C.__TickSceneTransition_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060221A3 RID: 139683 RVA: 0x008FF3E1 File Offset: 0x008FD5E1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnSceneTransitionStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneTransitionComponent_C.__OnSceneTransitionStart_NativeFunctionPtr, null);
		}

		// Token: 0x060221A4 RID: 139684 RVA: 0x008FF3F5 File Offset: 0x008FD5F5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnSceneTransitionStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneTransitionComponent_C.__OnSceneTransitionStart_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060221A5 RID: 139685 RVA: 0x008FF40A File Offset: 0x008FD60A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnSceneTransitionRegistered()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneTransitionComponent_C.__OnSceneTransitionRegistered_NativeFunctionPtr, null);
		}

		// Token: 0x060221A6 RID: 139686 RVA: 0x008FF41E File Offset: 0x008FD61E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnSceneTransitionRegistered_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneTransitionComponent_C.__OnSceneTransitionRegistered_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060221A7 RID: 139687 RVA: 0x008FF433 File Offset: 0x008FD633
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnSceneTransitionEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneTransitionComponent_C.__OnSceneTransitionEnd_NativeFunctionPtr, null);
		}

		// Token: 0x060221A8 RID: 139688 RVA: 0x008FF447 File Offset: 0x008FD647
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnSceneTransitionEnd_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneTransitionComponent_C.__OnSceneTransitionEnd_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060221A9 RID: 139689 RVA: 0x008FF45C File Offset: 0x008FD65C
		protected BP_SceneTransitionComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010B23 RID: 68387
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneTransition/BP_SceneTransitionComponent.BP_SceneTransitionComponent_C";

		// Token: 0x04010B24 RID: 68388
		private static IntPtr _ClassPtr;

		// Token: 0x04010B25 RID: 68389
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010B26 RID: 68390
		internal static int __PropertyOffset_1;

		// Token: 0x04010B27 RID: 68391
		internal static int __PropertyOffset_2;

		// Token: 0x04010B28 RID: 68392
		internal static int __PropertyOffset_3;

		// Token: 0x04010B29 RID: 68393
		internal static int __PropertyOffset_4;

		// Token: 0x04010B2A RID: 68394
		private static IntPtr __NeedDynMatForRoot_NativeFunctionPtr;

		// Token: 0x04010B2B RID: 68395
		private static IntPtr __SetMaterialParameters_NativeFunctionPtr;

		// Token: 0x04010B2C RID: 68396
		private static IntPtr __TickSceneTransition_NativeFunctionPtr;

		// Token: 0x04010B2D RID: 68397
		private static IntPtr __OnSceneTransitionStart_NativeFunctionPtr;

		// Token: 0x04010B2E RID: 68398
		private static IntPtr __OnSceneTransitionRegistered_NativeFunctionPtr;

		// Token: 0x04010B2F RID: 68399
		private static IntPtr __OnSceneTransitionEnd_NativeFunctionPtr;

		// Token: 0x02009D2D RID: 40237
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __NeedDynMatForRoot_FunctionParams
		{
			// Token: 0x04031469 RID: 201833
			[FieldOffset(0)]
			public bool Out;
		}

		// Token: 0x02009D2E RID: 40238
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetMaterialParameters_FunctionParams
		{
			// Token: 0x0403146A RID: 201834
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x0403146B RID: 201835
			[FieldOffset(4)]
			public float TransitionAge;

			// Token: 0x0403146C RID: 201836
			[FieldOffset(8)]
			public float TransitionNormalizedProcess;
		}

		// Token: 0x02009D2F RID: 40239
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected new ref struct __TickSceneTransition_FunctionParams
		{
			// Token: 0x0403146D RID: 201837
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x0403146E RID: 201838
			[FieldOffset(4)]
			public float TransitionAge;

			// Token: 0x0403146F RID: 201839
			[FieldOffset(8)]
			public float TransitionNormalizedProgress;
		}
	}
}
