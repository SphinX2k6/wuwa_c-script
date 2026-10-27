using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SceneTransition
{
	// Token: 0x02003BAE RID: 15278
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneTransition/BP_SceneTransitionComponent_Hongguang.BP_SceneTransitionComponent_Hongguang_C")]
	[UnrealStructLayout(688, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 673)]
	public class BP_SceneTransitionComponent_Hongguang_C : BP_SceneTransitionComponent_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060221AA RID: 139690 RVA: 0x008FF465 File Offset: 0x008FD665
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SceneTransitionComponent_Hongguang_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneTransition/BP_SceneTransitionComponent_Hongguang.BP_SceneTransitionComponent_Hongguang_C");
			}
			return BP_SceneTransitionComponent_Hongguang_C._ClassPtr;
		}

		// Token: 0x060221AB RID: 139691 RVA: 0x008FF48C File Offset: 0x008FD68C
		public BP_SceneTransitionComponent_Hongguang_C() : this(BuiltinUtils.AllocNativeUObject(BP_SceneTransitionComponent_Hongguang_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060221AC RID: 139692 RVA: 0x008FF4B4 File Offset: 0x008FD6B4
		[NullableContext(1)]
		public BP_SceneTransitionComponent_Hongguang_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SceneTransitionComponent_Hongguang_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170039CD RID: 14797
		// (get) Token: 0x060221AD RID: 139693 RVA: 0x008FF4E7 File Offset: 0x008FD6E7
		// (set) Token: 0x060221AE RID: 139694 RVA: 0x008FF4F7 File Offset: 0x008FD6F7
		public unsafe bool IsBush
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneTransitionComponent_Hongguang_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneTransitionComponent_Hongguang_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x060221AF RID: 139695 RVA: 0x008FF508 File Offset: 0x008FD708
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void NeedDynMatForRoot(ref bool Out)
		{
			BP_SceneTransitionComponent_Hongguang_C.__NeedDynMatForRoot_FunctionParams* ptr = stackalloc BP_SceneTransitionComponent_Hongguang_C.__NeedDynMatForRoot_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_SceneTransitionComponent_Hongguang_C.__NeedDynMatForRoot_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneTransitionComponent_Hongguang_C.__NeedDynMatForRoot_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Out = Out;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneTransitionComponent_Hongguang_C.__NeedDynMatForRoot_NativeFunctionPtr, (void*)ptr);
			Out = ptr->Out;
		}

		// Token: 0x060221B0 RID: 139696 RVA: 0x008FF558 File Offset: 0x008FD758
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void SetMaterialParameters(float DeltaTime, float TransitionAge, float TransitionNormalizedProcess)
		{
			BP_SceneTransitionComponent_Hongguang_C.__SetMaterialParameters_FunctionParams* ptr = stackalloc BP_SceneTransitionComponent_Hongguang_C.__SetMaterialParameters_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(BP_SceneTransitionComponent_Hongguang_C.__SetMaterialParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneTransitionComponent_Hongguang_C.__SetMaterialParameters_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			ptr->TransitionAge = TransitionAge;
			ptr->TransitionNormalizedProcess = TransitionNormalizedProcess;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneTransitionComponent_Hongguang_C.__SetMaterialParameters_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060221B1 RID: 139697 RVA: 0x008FF5AF File Offset: 0x008FD7AF
		protected BP_SceneTransitionComponent_Hongguang_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010B30 RID: 68400
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneTransition/BP_SceneTransitionComponent_Hongguang.BP_SceneTransitionComponent_Hongguang_C";

		// Token: 0x04010B31 RID: 68401
		private static IntPtr _ClassPtr;

		// Token: 0x04010B32 RID: 68402
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010B33 RID: 68403
		internal static int __PropertyOffset_0;

		// Token: 0x04010B34 RID: 68404
		private static IntPtr __NeedDynMatForRoot_NativeFunctionPtr;

		// Token: 0x04010B35 RID: 68405
		private static IntPtr __SetMaterialParameters_NativeFunctionPtr;

		// Token: 0x02009D30 RID: 40240
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __NeedDynMatForRoot_FunctionParams
		{
			// Token: 0x04031470 RID: 201840
			[FieldOffset(0)]
			public bool Out;
		}

		// Token: 0x02009D31 RID: 40241
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected new ref struct __SetMaterialParameters_FunctionParams
		{
			// Token: 0x04031471 RID: 201841
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x04031472 RID: 201842
			[FieldOffset(4)]
			public float TransitionAge;

			// Token: 0x04031473 RID: 201843
			[FieldOffset(8)]
			public float TransitionNormalizedProcess;
		}
	}
}
