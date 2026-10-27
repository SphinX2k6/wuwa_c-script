using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using AkiClient.Game.Aki.Data.Interaction.Struct;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC
{
	// Token: 0x0200418B RID: 16779
	[UnrealObjectPath("/Game/Aki/Character/NPC/BPI_NPC.BPI_NPC_C")]
	public interface IBPI_NPC_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0602B73B RID: 177979 RVA: 0x00A01258 File Offset: 0x009FF458
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe string GetNPCName()
		{
			IBPI_NPC_C.__GetNPCName_FunctionParams* ptr = stackalloc IBPI_NPC_C.__GetNPCName_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(IBPI_NPC_C.__GetNPCName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_NPC_C_ReflectionImplementationFields.__GetNPCName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NPC_C_ReflectionImplementationFields.__GetNPCName_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(IBPI_NPC_C_ReflectionImplementationFields.__GetNPCName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602B73C RID: 177980 RVA: 0x00A012B4 File Offset: 0x009FF4B4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe SInteractionConfig GetCurrInteractionConfig()
		{
			IBPI_NPC_C.__GetCurrInteractionConfig_FunctionParams* ptr = stackalloc IBPI_NPC_C.__GetCurrInteractionConfig_FunctionParams[(UIntPtr)223] + 15L / (long)sizeof(IBPI_NPC_C.__GetCurrInteractionConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_NPC_C_ReflectionImplementationFields.__GetCurrInteractionConfig_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NPC_C_ReflectionImplementationFields.__GetCurrInteractionConfig_NativeFunctionPtr, (void*)ptr);
			SInteractionConfig result = new SInteractionConfig(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(IBPI_NPC_C_ReflectionImplementationFields.__GetCurrInteractionConfig_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0602B73D RID: 177981 RVA: 0x00A01315 File Offset: 0x009FF515
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void InteractNPC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NPC_C_ReflectionImplementationFields.__InteractNPC_NativeFunctionPtr, null);
		}

		// Token: 0x0602B73E RID: 177982 RVA: 0x00A0132C File Offset: 0x009FF52C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool TriggerNPCInteraction()
		{
			IBPI_NPC_C.__TriggerNPCInteraction_FunctionParams* ptr = stackalloc IBPI_NPC_C.__TriggerNPCInteraction_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(IBPI_NPC_C.__TriggerNPCInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_NPC_C_ReflectionImplementationFields.__TriggerNPCInteraction_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NPC_C_ReflectionImplementationFields.__TriggerNPCInteraction_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602B73F RID: 177983 RVA: 0x00A01374 File Offset: 0x009FF574
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool IsNPCInteractable()
		{
			IBPI_NPC_C.__IsNPCInteractable_FunctionParams* ptr = stackalloc IBPI_NPC_C.__IsNPCInteractable_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(IBPI_NPC_C.__IsNPCInteractable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_NPC_C_ReflectionImplementationFields.__IsNPCInteractable_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NPC_C_ReflectionImplementationFields.__IsNPCInteractable_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602B740 RID: 177984 RVA: 0x00A013BC File Offset: 0x009FF5BC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool ApplyEntityConfig(SEntityConfig inConfig)
		{
			IBPI_NPC_C.__ApplyEntityConfig_FunctionParams* ptr = stackalloc IBPI_NPC_C.__ApplyEntityConfig_FunctionParams[(UIntPtr)695] + 15L / (long)sizeof(IBPI_NPC_C.__ApplyEntityConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_NPC_C_ReflectionImplementationFields.__ApplyEntityConfig_NativeFunctionPtr, (void*)ptr, 1);
			if (inConfig != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SEntityConfig.StaticStruct(), &ptr->inConfig, inConfig.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NPC_C_ReflectionImplementationFields.__ApplyEntityConfig_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(IBPI_NPC_C_ReflectionImplementationFields.__ApplyEntityConfig_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602B741 RID: 177985 RVA: 0x00A01438 File Offset: 0x009FF638
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void NPC通用回调事件(FName EventID)
		{
			IBPI_NPC_C.__NPC通用回调事件_FunctionParams* ptr = stackalloc IBPI_NPC_C.__NPC通用回调事件_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(IBPI_NPC_C.__NPC通用回调事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_NPC_C_ReflectionImplementationFields.__NPC通用回调事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EventID = EventID;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NPC_C_ReflectionImplementationFields.__NPC通用回调事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x040169DD RID: 92637
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/NPC/BPI_NPC.BPI_NPC_C";

		// Token: 0x0200A52A RID: 42282
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetNPCName_FunctionParams
		{
			// Token: 0x04032398 RID: 205720
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x0200A52B RID: 42283
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __GetCurrInteractionConfig_FunctionParams
		{
			// Token: 0x04032399 RID: 205721
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200A52C RID: 42284
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __TriggerNPCInteraction_FunctionParams
		{
			// Token: 0x0403239A RID: 205722
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200A52D RID: 42285
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsNPCInteractable_FunctionParams
		{
			// Token: 0x0403239B RID: 205723
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200A52E RID: 42286
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 680)]
		protected ref struct __ApplyEntityConfig_FunctionParams
		{
			// Token: 0x0403239C RID: 205724
			[FieldOffset(0)]
			public byte inConfig;

			// Token: 0x0403239D RID: 205725
			[FieldOffset(672)]
			public bool __Result;
		}

		// Token: 0x0200A52F RID: 42287
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __NPC通用回调事件_FunctionParams
		{
			// Token: 0x0403239E RID: 205726
			[FieldOffset(0)]
			public FName EventID;
		}
	}
}
