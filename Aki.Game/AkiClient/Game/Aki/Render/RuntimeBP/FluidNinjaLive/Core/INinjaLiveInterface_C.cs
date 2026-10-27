using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core
{
	// Token: 0x02003D9C RID: 15772
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaLiveInterface.NinjaLiveInterface_C")]
	public interface INinjaLiveInterface_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06027295 RID: 160405 RVA: 0x00989958 File Offset: 0x00987B58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void LiveFluidParams(float BrushSize)
		{
			INinjaLiveInterface_C.__LiveFluidParams_FunctionParams* ptr = stackalloc INinjaLiveInterface_C.__LiveFluidParams_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(INinjaLiveInterface_C.__LiveFluidParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(INinjaLiveInterface_C_ReflectionImplementationFields.__LiveFluidParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BrushSize = BrushSize;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, INinjaLiveInterface_C_ReflectionImplementationFields.__LiveFluidParams_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027296 RID: 160406 RVA: 0x009899A0 File Offset: 0x00987BA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void LiveActivation(FName ParamName, float FadeTimeOfBrush, float FadeTimeOfCanvas)
		{
			INinjaLiveInterface_C.__LiveActivation_FunctionParams* ptr = stackalloc INinjaLiveInterface_C.__LiveActivation_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(INinjaLiveInterface_C.__LiveActivation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(INinjaLiveInterface_C_ReflectionImplementationFields.__LiveActivation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ParamName = ParamName;
			ptr->FadeTimeOfBrush = FadeTimeOfBrush;
			ptr->FadeTimeOfCanvas = FadeTimeOfCanvas;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, INinjaLiveInterface_C_ReflectionImplementationFields.__LiveActivation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x04013BE1 RID: 80865
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaLiveInterface.NinjaLiveInterface_C";

		// Token: 0x0200A1E0 RID: 41440
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __LiveFluidParams_FunctionParams
		{
			// Token: 0x04031E31 RID: 204337
			[FieldOffset(0)]
			public float BrushSize;
		}

		// Token: 0x0200A1E1 RID: 41441
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __LiveActivation_FunctionParams
		{
			// Token: 0x04031E32 RID: 204338
			[FieldOffset(0)]
			public FName ParamName;

			// Token: 0x04031E33 RID: 204339
			[FieldOffset(12)]
			public float FadeTimeOfBrush;

			// Token: 0x04031E34 RID: 204340
			[FieldOffset(16)]
			public float FadeTimeOfCanvas;
		}
	}
}
