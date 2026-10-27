using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Controller
{
	// Token: 0x02003AEE RID: 15086
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ScreenEffect/Controller/SE_ControllerBase.SE_ControllerBase_C")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class SE_ControllerBase_C : UActorComponent, IUnrealUObject, IUnrealObject, ISE_ControllerInterface_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06020AAD RID: 133805 RVA: 0x008D971B File Offset: 0x008D791B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (SE_ControllerBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/ScreenEffect/Controller/SE_ControllerBase.SE_ControllerBase_C");
			}
			return SE_ControllerBase_C._ClassPtr;
		}

		// Token: 0x06020AAE RID: 133806 RVA: 0x008D9740 File Offset: 0x008D7940
		public SE_ControllerBase_C() : this(BuiltinUtils.AllocNativeUObject(SE_ControllerBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020AAF RID: 133807 RVA: 0x008D9768 File Offset: 0x008D7968
		[NullableContext(1)]
		public SE_ControllerBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SE_ControllerBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06020AB0 RID: 133808 RVA: 0x008D979C File Offset: 0x008D799C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ApplyVisibility(bool visibility)
		{
			SE_ControllerBase_C.__ApplyVisibility_FunctionParams* ptr = stackalloc SE_ControllerBase_C.__ApplyVisibility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(SE_ControllerBase_C.__ApplyVisibility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_ControllerBase_C.__ApplyVisibility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->visibility = visibility;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_ControllerBase_C.__ApplyVisibility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020AB1 RID: 133809 RVA: 0x008D97E2 File Offset: 0x008D79E2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BeforeStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_ControllerBase_C.__BeforeStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020AB2 RID: 133810 RVA: 0x008D97F8 File Offset: 0x008D79F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			SE_ControllerBase_C.__ReceiveTick_FunctionParams* ptr = stackalloc SE_ControllerBase_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SE_ControllerBase_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_ControllerBase_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_ControllerBase_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020AB3 RID: 133811 RVA: 0x008D9840 File Offset: 0x008D7A40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			SE_ControllerBase_C.__ReceiveTick_FunctionParams* ptr = stackalloc SE_ControllerBase_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SE_ControllerBase_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_ControllerBase_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, SE_ControllerBase_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020AB4 RID: 133812 RVA: 0x008D9888 File Offset: 0x008D7A88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void End(float time)
		{
			SE_ControllerBase_C.__End_FunctionParams* ptr = stackalloc SE_ControllerBase_C.__End_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SE_ControllerBase_C.__End_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_ControllerBase_C.__End_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_ControllerBase_C.__End_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020AB5 RID: 133813 RVA: 0x008D98D0 File Offset: 0x008D7AD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Start(float time)
		{
			SE_ControllerBase_C.__Start_FunctionParams* ptr = stackalloc SE_ControllerBase_C.__Start_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SE_ControllerBase_C.__Start_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_ControllerBase_C.__Start_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_ControllerBase_C.__Start_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020AB6 RID: 133814 RVA: 0x008D9918 File Offset: 0x008D7B18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Loop(float time)
		{
			SE_ControllerBase_C.__Loop_FunctionParams* ptr = stackalloc SE_ControllerBase_C.__Loop_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SE_ControllerBase_C.__Loop_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_ControllerBase_C.__Loop_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_ControllerBase_C.__Loop_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020AB7 RID: 133815 RVA: 0x008D9960 File Offset: 0x008D7B60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ApplyAlpha(float alpha)
		{
			SE_ControllerBase_C.__ApplyAlpha_FunctionParams* ptr = stackalloc SE_ControllerBase_C.__ApplyAlpha_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SE_ControllerBase_C.__ApplyAlpha_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_ControllerBase_C.__ApplyAlpha_NativeFunctionPtr, (void*)ptr, 1);
			ptr->alpha = alpha;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_ControllerBase_C.__ApplyAlpha_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020AB8 RID: 133816 RVA: 0x008D99A8 File Offset: 0x008D7BA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ApplyEnvironmentFactor(float EnvironmentFactor)
		{
			SE_ControllerBase_C.__ApplyEnvironmentFactor_FunctionParams* ptr = stackalloc SE_ControllerBase_C.__ApplyEnvironmentFactor_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(SE_ControllerBase_C.__ApplyEnvironmentFactor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_ControllerBase_C.__ApplyEnvironmentFactor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EnvironmentFactor = EnvironmentFactor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_ControllerBase_C.__ApplyEnvironmentFactor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020AB9 RID: 133817 RVA: 0x008D99EE File Offset: 0x008D7BEE
		protected SE_ControllerBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FDA5 RID: 64933
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/ScreenEffect/Controller/SE_ControllerBase.SE_ControllerBase_C";

		// Token: 0x0400FDA6 RID: 64934
		private static IntPtr _ClassPtr;

		// Token: 0x0400FDA7 RID: 64935
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FDA8 RID: 64936
		private static IntPtr __ApplyVisibility_NativeFunctionPtr;

		// Token: 0x0400FDA9 RID: 64937
		private static IntPtr __BeforeStart_NativeFunctionPtr;

		// Token: 0x0400FDAA RID: 64938
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FDAB RID: 64939
		private static IntPtr __End_NativeFunctionPtr;

		// Token: 0x0400FDAC RID: 64940
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x0400FDAD RID: 64941
		private static IntPtr __Loop_NativeFunctionPtr;

		// Token: 0x0400FDAE RID: 64942
		private static IntPtr __ApplyAlpha_NativeFunctionPtr;

		// Token: 0x0400FDAF RID: 64943
		private static IntPtr __ApplyEnvironmentFactor_NativeFunctionPtr;

		// Token: 0x02009C03 RID: 39939
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ApplyVisibility_FunctionParams
		{
			// Token: 0x040312A6 RID: 201382
			[FieldOffset(0)]
			public bool visibility;
		}

		// Token: 0x02009C04 RID: 39940
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040312A7 RID: 201383
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C05 RID: 39941
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __End_FunctionParams
		{
			// Token: 0x040312A8 RID: 201384
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009C06 RID: 39942
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Start_FunctionParams
		{
			// Token: 0x040312A9 RID: 201385
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009C07 RID: 39943
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Loop_FunctionParams
		{
			// Token: 0x040312AA RID: 201386
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009C08 RID: 39944
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ApplyAlpha_FunctionParams
		{
			// Token: 0x040312AB RID: 201387
			[FieldOffset(0)]
			public float alpha;
		}

		// Token: 0x02009C09 RID: 39945
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ApplyEnvironmentFactor_FunctionParams
		{
			// Token: 0x040312AC RID: 201388
			[FieldOffset(0)]
			public float EnvironmentFactor;
		}
	}
}
