using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B6D RID: 15213
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BPI_DollActor.BPI_DollActor_C")]
	public interface IBPI_DollActor_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06021D9C RID: 138652 RVA: 0x008F7724 File Offset: 0x008F5924
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void PlayGrabEffectByTransform(bool IsEndless, FTransformDouble Transform)
		{
			IBPI_DollActor_C.__PlayGrabEffectByTransform_FunctionParams* ptr = stackalloc IBPI_DollActor_C.__PlayGrabEffectByTransform_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(IBPI_DollActor_C.__PlayGrabEffectByTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_DollActor_C_ReflectionImplementationFields.__PlayGrabEffectByTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEndless = IsEndless;
			ptr->Transform = Transform;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DollActor_C_ReflectionImplementationFields.__PlayGrabEffectByTransform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021D9D RID: 138653 RVA: 0x008F7774 File Offset: 0x008F5974
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void TogglePlayGrabAnim(bool Enable, float Rate)
		{
			IBPI_DollActor_C.__TogglePlayGrabAnim_FunctionParams* ptr = stackalloc IBPI_DollActor_C.__TogglePlayGrabAnim_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IBPI_DollActor_C.__TogglePlayGrabAnim_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_DollActor_C_ReflectionImplementationFields.__TogglePlayGrabAnim_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			ptr->Rate = Rate;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DollActor_C_ReflectionImplementationFields.__TogglePlayGrabAnim_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021D9E RID: 138654 RVA: 0x008F77C4 File Offset: 0x008F59C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void TogglePlayShow(bool Toggle, float PlayRate)
		{
			IBPI_DollActor_C.__TogglePlayShow_FunctionParams* ptr = stackalloc IBPI_DollActor_C.__TogglePlayShow_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IBPI_DollActor_C.__TogglePlayShow_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_DollActor_C_ReflectionImplementationFields.__TogglePlayShow_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Toggle = Toggle;
			ptr->PlayRate = PlayRate;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DollActor_C_ReflectionImplementationFields.__TogglePlayShow_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021D9F RID: 138655 RVA: 0x008F7811 File Offset: 0x008F5A11
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void PlayTimeEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DollActor_C_ReflectionImplementationFields.__PlayTimeEffect_NativeFunctionPtr, null);
		}

		// Token: 0x06021DA0 RID: 138656 RVA: 0x008F7825 File Offset: 0x008F5A25
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void ResetPhysics()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DollActor_C_ReflectionImplementationFields.__ResetPhysics_NativeFunctionPtr, null);
		}

		// Token: 0x06021DA1 RID: 138657 RVA: 0x008F783C File Offset: 0x008F5A3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void PlayGrabEffectByLocation(FVectorDouble Location)
		{
			IBPI_DollActor_C.__PlayGrabEffectByLocation_FunctionParams* ptr = stackalloc IBPI_DollActor_C.__PlayGrabEffectByLocation_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(IBPI_DollActor_C.__PlayGrabEffectByLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_DollActor_C_ReflectionImplementationFields.__PlayGrabEffectByLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DollActor_C_ReflectionImplementationFields.__PlayGrabEffectByLocation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021DA2 RID: 138658 RVA: 0x008F7884 File Offset: 0x008F5A84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void SetPhysicsParameters(float AngularDamping, float LineraDamping)
		{
			IBPI_DollActor_C.__SetPhysicsParameters_FunctionParams* ptr = stackalloc IBPI_DollActor_C.__SetPhysicsParameters_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IBPI_DollActor_C.__SetPhysicsParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_DollActor_C_ReflectionImplementationFields.__SetPhysicsParameters_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AngularDamping = AngularDamping;
			ptr->LineraDamping = LineraDamping;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DollActor_C_ReflectionImplementationFields.__SetPhysicsParameters_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021DA3 RID: 138659 RVA: 0x008F78D1 File Offset: 0x008F5AD1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void PlaySpawnEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DollActor_C_ReflectionImplementationFields.__PlaySpawnEffect_NativeFunctionPtr, null);
		}

		// Token: 0x06021DA4 RID: 138660 RVA: 0x008F78E8 File Offset: 0x008F5AE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void PlayGrabEffect(bool IsEndless, FVectorDouble Location)
		{
			IBPI_DollActor_C.__PlayGrabEffect_FunctionParams* ptr = stackalloc IBPI_DollActor_C.__PlayGrabEffect_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(IBPI_DollActor_C.__PlayGrabEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_DollActor_C_ReflectionImplementationFields.__PlayGrabEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEndless = IsEndless;
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DollActor_C_ReflectionImplementationFields.__PlayGrabEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021DA5 RID: 138661 RVA: 0x008F7938 File Offset: 0x008F5B38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void SetVisible(bool ToggleVisibility, bool TogglePhysics)
		{
			IBPI_DollActor_C.__SetVisible_FunctionParams* ptr = stackalloc IBPI_DollActor_C.__SetVisible_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(IBPI_DollActor_C.__SetVisible_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_DollActor_C_ReflectionImplementationFields.__SetVisible_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ToggleVisibility = ToggleVisibility;
			ptr->TogglePhysics = TogglePhysics;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DollActor_C_ReflectionImplementationFields.__SetVisible_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0401089B RID: 67739
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BPI_DollActor.BPI_DollActor_C";

		// Token: 0x02009CDE RID: 40158
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __PlayGrabEffectByTransform_FunctionParams
		{
			// Token: 0x040313D0 RID: 201680
			[FieldOffset(0)]
			public bool IsEndless;

			// Token: 0x040313D1 RID: 201681
			[FieldOffset(16)]
			public FTransformDouble Transform;
		}

		// Token: 0x02009CDF RID: 40159
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __TogglePlayGrabAnim_FunctionParams
		{
			// Token: 0x040313D2 RID: 201682
			[FieldOffset(0)]
			public bool Enable;

			// Token: 0x040313D3 RID: 201683
			[FieldOffset(4)]
			public float Rate;
		}

		// Token: 0x02009CE0 RID: 40160
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __TogglePlayShow_FunctionParams
		{
			// Token: 0x040313D4 RID: 201684
			[FieldOffset(0)]
			public bool Toggle;

			// Token: 0x040313D5 RID: 201685
			[FieldOffset(4)]
			public float PlayRate;
		}

		// Token: 0x02009CE1 RID: 40161
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __PlayGrabEffectByLocation_FunctionParams
		{
			// Token: 0x040313D6 RID: 201686
			[FieldOffset(0)]
			public FVectorDouble Location;
		}

		// Token: 0x02009CE2 RID: 40162
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetPhysicsParameters_FunctionParams
		{
			// Token: 0x040313D7 RID: 201687
			[FieldOffset(0)]
			public float AngularDamping;

			// Token: 0x040313D8 RID: 201688
			[FieldOffset(4)]
			public float LineraDamping;
		}

		// Token: 0x02009CE3 RID: 40163
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __PlayGrabEffect_FunctionParams
		{
			// Token: 0x040313D9 RID: 201689
			[FieldOffset(0)]
			public bool IsEndless;

			// Token: 0x040313DA RID: 201690
			[FieldOffset(8)]
			public FVectorDouble Location;
		}

		// Token: 0x02009CE4 RID: 40164
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __SetVisible_FunctionParams
		{
			// Token: 0x040313DB RID: 201691
			[FieldOffset(0)]
			public bool ToggleVisibility;

			// Token: 0x040313DC RID: 201692
			[FieldOffset(1)]
			public bool TogglePhysics;
		}
	}
}
