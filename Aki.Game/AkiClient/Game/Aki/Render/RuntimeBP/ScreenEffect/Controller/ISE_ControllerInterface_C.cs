using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Controller
{
	// Token: 0x02003AEF RID: 15087
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ScreenEffect/Controller/SE_ControllerInterface.SE_ControllerInterface_C")]
	public interface ISE_ControllerInterface_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06020ABA RID: 133818 RVA: 0x008D99F8 File Offset: 0x008D7BF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void ApplyEnvironmentFactor(float EnvironmentFactor)
		{
			ISE_ControllerInterface_C.__ApplyEnvironmentFactor_FunctionParams* ptr = stackalloc ISE_ControllerInterface_C.__ApplyEnvironmentFactor_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ISE_ControllerInterface_C.__ApplyEnvironmentFactor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISE_ControllerInterface_C_ReflectionImplementationFields.__ApplyEnvironmentFactor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EnvironmentFactor = EnvironmentFactor;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ISE_ControllerInterface_C_ReflectionImplementationFields.__ApplyEnvironmentFactor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020ABB RID: 133819 RVA: 0x008D9A3E File Offset: 0x008D7C3E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void BeforeStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ISE_ControllerInterface_C_ReflectionImplementationFields.__BeforeStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020ABC RID: 133820 RVA: 0x008D9A54 File Offset: 0x008D7C54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void ApplyVisibility(bool visibility)
		{
			ISE_ControllerInterface_C.__ApplyVisibility_FunctionParams* ptr = stackalloc ISE_ControllerInterface_C.__ApplyVisibility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ISE_ControllerInterface_C.__ApplyVisibility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISE_ControllerInterface_C_ReflectionImplementationFields.__ApplyVisibility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->visibility = visibility;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ISE_ControllerInterface_C_ReflectionImplementationFields.__ApplyVisibility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020ABD RID: 133821 RVA: 0x008D9A9C File Offset: 0x008D7C9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void ApplyAlpha(float alpha)
		{
			ISE_ControllerInterface_C.__ApplyAlpha_FunctionParams* ptr = stackalloc ISE_ControllerInterface_C.__ApplyAlpha_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ISE_ControllerInterface_C.__ApplyAlpha_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISE_ControllerInterface_C_ReflectionImplementationFields.__ApplyAlpha_NativeFunctionPtr, (void*)ptr, 1);
			ptr->alpha = alpha;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ISE_ControllerInterface_C_ReflectionImplementationFields.__ApplyAlpha_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020ABE RID: 133822 RVA: 0x008D9AE4 File Offset: 0x008D7CE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void End(float time)
		{
			ISE_ControllerInterface_C.__End_FunctionParams* ptr = stackalloc ISE_ControllerInterface_C.__End_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ISE_ControllerInterface_C.__End_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISE_ControllerInterface_C_ReflectionImplementationFields.__End_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ISE_ControllerInterface_C_ReflectionImplementationFields.__End_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020ABF RID: 133823 RVA: 0x008D9B2C File Offset: 0x008D7D2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void Loop(float time)
		{
			ISE_ControllerInterface_C.__Loop_FunctionParams* ptr = stackalloc ISE_ControllerInterface_C.__Loop_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ISE_ControllerInterface_C.__Loop_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISE_ControllerInterface_C_ReflectionImplementationFields.__Loop_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ISE_ControllerInterface_C_ReflectionImplementationFields.__Loop_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020AC0 RID: 133824 RVA: 0x008D9B74 File Offset: 0x008D7D74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void Start(float time)
		{
			ISE_ControllerInterface_C.__Start_FunctionParams* ptr = stackalloc ISE_ControllerInterface_C.__Start_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ISE_ControllerInterface_C.__Start_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISE_ControllerInterface_C_ReflectionImplementationFields.__Start_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, ISE_ControllerInterface_C_ReflectionImplementationFields.__Start_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0400FDB0 RID: 64944
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/ScreenEffect/Controller/SE_ControllerInterface.SE_ControllerInterface_C";

		// Token: 0x02009C0A RID: 39946
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ApplyEnvironmentFactor_FunctionParams
		{
			// Token: 0x040312AD RID: 201389
			[FieldOffset(0)]
			public float EnvironmentFactor;
		}

		// Token: 0x02009C0B RID: 39947
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ApplyVisibility_FunctionParams
		{
			// Token: 0x040312AE RID: 201390
			[FieldOffset(0)]
			public bool visibility;
		}

		// Token: 0x02009C0C RID: 39948
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ApplyAlpha_FunctionParams
		{
			// Token: 0x040312AF RID: 201391
			[FieldOffset(0)]
			public float alpha;
		}

		// Token: 0x02009C0D RID: 39949
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __End_FunctionParams
		{
			// Token: 0x040312B0 RID: 201392
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009C0E RID: 39950
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Loop_FunctionParams
		{
			// Token: 0x040312B1 RID: 201393
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009C0F RID: 39951
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Start_FunctionParams
		{
			// Token: 0x040312B2 RID: 201394
			[FieldOffset(0)]
			public float time;
		}
	}
}
