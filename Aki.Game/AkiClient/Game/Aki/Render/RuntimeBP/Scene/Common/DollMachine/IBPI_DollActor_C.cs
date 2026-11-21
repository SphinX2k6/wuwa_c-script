using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x020030CC RID: 12492
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BPI_DollActor.BPI_DollActor_C")]
	public interface IBPI_DollActor_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601E0FE RID: 123134 RVA: 0x00909BEC File Offset: 0x00907DEC
		[SkipLocalsInit]
		unsafe void PlayGrabEffectByTransform(bool IsEndless, FTransformDouble Transform)
		{
			IBPI_DollActor_C.__PlayGrabEffectByTransform_FunctionParams* ptr = stackalloc IBPI_DollActor_C.__PlayGrabEffectByTransform_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(IBPI_DollActor_C.__PlayGrabEffectByTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_DollActor_C_ReflectionImplementationFields.__PlayGrabEffectByTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEndless = IsEndless;
			ptr->Transform = Transform;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DollActor_C_ReflectionImplementationFields.__PlayGrabEffectByTransform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E0FF RID: 123135 RVA: 0x00909C3C File Offset: 0x00907E3C
		[SkipLocalsInit]
		unsafe void TogglePlayGrabAnim(bool Enable, float Rate)
		{
			IBPI_DollActor_C.__TogglePlayGrabAnim_FunctionParams* ptr = stackalloc IBPI_DollActor_C.__TogglePlayGrabAnim_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IBPI_DollActor_C.__TogglePlayGrabAnim_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_DollActor_C_ReflectionImplementationFields.__TogglePlayGrabAnim_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			ptr->Rate = Rate;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DollActor_C_ReflectionImplementationFields.__TogglePlayGrabAnim_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E100 RID: 123136 RVA: 0x00909C8C File Offset: 0x00907E8C
		[SkipLocalsInit]
		unsafe void TogglePlayShow(bool Toggle, float PlayRate)
		{
			IBPI_DollActor_C.__TogglePlayShow_FunctionParams* ptr = stackalloc IBPI_DollActor_C.__TogglePlayShow_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IBPI_DollActor_C.__TogglePlayShow_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_DollActor_C_ReflectionImplementationFields.__TogglePlayShow_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Toggle = Toggle;
			ptr->PlayRate = PlayRate;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DollActor_C_ReflectionImplementationFields.__TogglePlayShow_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E101 RID: 123137 RVA: 0x00909CD9 File Offset: 0x00907ED9
		[SkipLocalsInit]
		void PlayTimeEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DollActor_C_ReflectionImplementationFields.__PlayTimeEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0601E102 RID: 123138 RVA: 0x00909CED File Offset: 0x00907EED
		[SkipLocalsInit]
		void ResetPhysics()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DollActor_C_ReflectionImplementationFields.__ResetPhysics_NativeFunctionPtr, null);
		}

		// Token: 0x0601E103 RID: 123139 RVA: 0x00909D04 File Offset: 0x00907F04
		[SkipLocalsInit]
		unsafe void PlayGrabEffectByLocation(FVectorDouble Location)
		{
			IBPI_DollActor_C.__PlayGrabEffectByLocation_FunctionParams* ptr = stackalloc IBPI_DollActor_C.__PlayGrabEffectByLocation_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(IBPI_DollActor_C.__PlayGrabEffectByLocation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_DollActor_C_ReflectionImplementationFields.__PlayGrabEffectByLocation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DollActor_C_ReflectionImplementationFields.__PlayGrabEffectByLocation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E104 RID: 123140 RVA: 0x00909D4C File Offset: 0x00907F4C
		[SkipLocalsInit]
		unsafe void SetPhysicsParameters(float AngularDamping, float LineraDamping)
		{
			IBPI_DollActor_C.__SetPhysicsParameters_FunctionParams* ptr = stackalloc IBPI_DollActor_C.__SetPhysicsParameters_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IBPI_DollActor_C.__SetPhysicsParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_DollActor_C_ReflectionImplementationFields.__SetPhysicsParameters_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AngularDamping = AngularDamping;
			ptr->LineraDamping = LineraDamping;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DollActor_C_ReflectionImplementationFields.__SetPhysicsParameters_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E105 RID: 123141 RVA: 0x00909D99 File Offset: 0x00907F99
		[SkipLocalsInit]
		void PlaySpawnEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DollActor_C_ReflectionImplementationFields.__PlaySpawnEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0601E106 RID: 123142 RVA: 0x00909DB0 File Offset: 0x00907FB0
		[SkipLocalsInit]
		unsafe void PlayGrabEffect(bool IsEndless, FVectorDouble Location)
		{
			IBPI_DollActor_C.__PlayGrabEffect_FunctionParams* ptr = stackalloc IBPI_DollActor_C.__PlayGrabEffect_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(IBPI_DollActor_C.__PlayGrabEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_DollActor_C_ReflectionImplementationFields.__PlayGrabEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEndless = IsEndless;
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DollActor_C_ReflectionImplementationFields.__PlayGrabEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E107 RID: 123143 RVA: 0x00909E00 File Offset: 0x00908000
		[SkipLocalsInit]
		unsafe void SetVisible(bool ToggleVisibility, bool TogglePhysics)
		{
			IBPI_DollActor_C.__SetVisible_FunctionParams* ptr = stackalloc IBPI_DollActor_C.__SetVisible_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(IBPI_DollActor_C.__SetVisible_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_DollActor_C_ReflectionImplementationFields.__SetVisible_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ToggleVisibility = ToggleVisibility;
			ptr->TogglePhysics = TogglePhysics;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DollActor_C_ReflectionImplementationFields.__SetVisible_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0400FE3C RID: 65084
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BPI_DollActor.BPI_DollActor_C";

		// Token: 0x02008E04 RID: 36356
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __PlayGrabEffectByTransform_FunctionParams
		{
			// Token: 0x0402CA35 RID: 182837
			[FieldOffset(0)]
			public bool IsEndless;

			// Token: 0x0402CA36 RID: 182838
			[FieldOffset(16)]
			public FTransformDouble Transform;
		}

		// Token: 0x02008E05 RID: 36357
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __TogglePlayGrabAnim_FunctionParams
		{
			// Token: 0x0402CA37 RID: 182839
			[FieldOffset(0)]
			public bool Enable;

			// Token: 0x0402CA38 RID: 182840
			[FieldOffset(4)]
			public float Rate;
		}

		// Token: 0x02008E06 RID: 36358
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __TogglePlayShow_FunctionParams
		{
			// Token: 0x0402CA39 RID: 182841
			[FieldOffset(0)]
			public bool Toggle;

			// Token: 0x0402CA3A RID: 182842
			[FieldOffset(4)]
			public float PlayRate;
		}

		// Token: 0x02008E07 RID: 36359
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __PlayGrabEffectByLocation_FunctionParams
		{
			// Token: 0x0402CA3B RID: 182843
			[FieldOffset(0)]
			public FVectorDouble Location;
		}

		// Token: 0x02008E08 RID: 36360
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetPhysicsParameters_FunctionParams
		{
			// Token: 0x0402CA3C RID: 182844
			[FieldOffset(0)]
			public float AngularDamping;

			// Token: 0x0402CA3D RID: 182845
			[FieldOffset(4)]
			public float LineraDamping;
		}

		// Token: 0x02008E09 RID: 36361
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __PlayGrabEffect_FunctionParams
		{
			// Token: 0x0402CA3E RID: 182846
			[FieldOffset(0)]
			public bool IsEndless;

			// Token: 0x0402CA3F RID: 182847
			[FieldOffset(8)]
			public FVectorDouble Location;
		}

		// Token: 0x02008E0A RID: 36362
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __SetVisible_FunctionParams
		{
			// Token: 0x0402CA40 RID: 182848
			[FieldOffset(0)]
			public bool ToggleVisibility;

			// Token: 0x0402CA41 RID: 182849
			[FieldOffset(1)]
			public bool TogglePhysics;
		}
	}
}
