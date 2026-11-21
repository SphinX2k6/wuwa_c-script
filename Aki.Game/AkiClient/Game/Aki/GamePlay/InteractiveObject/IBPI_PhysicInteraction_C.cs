using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.InteractiveObject
{
	// Token: 0x02003150 RID: 12624
	[UnrealObjectPath("/Game/Aki/GamePlay/InteractiveObject/BPI_PhysicInteraction.BPI_PhysicInteraction_C")]
	public interface IBPI_PhysicInteraction_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601F0DA RID: 127194 RVA: 0x009253D8 File Offset: 0x009235D8
		[SkipLocalsInit]
		unsafe void IsPhysicInteracted(ref bool OutInteracted)
		{
			IBPI_PhysicInteraction_C.__IsPhysicInteracted_FunctionParams* ptr = stackalloc IBPI_PhysicInteraction_C.__IsPhysicInteracted_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(IBPI_PhysicInteraction_C.__IsPhysicInteracted_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_PhysicInteraction_C_ReflectionImplementationFields.__IsPhysicInteracted_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutInteracted = OutInteracted;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_PhysicInteraction_C_ReflectionImplementationFields.__IsPhysicInteracted_NativeFunctionPtr, (void*)ptr);
			OutInteracted = ptr->OutInteracted;
		}

		// Token: 0x0601F0DB RID: 127195 RVA: 0x00925428 File Offset: 0x00923628
		[SkipLocalsInit]
		unsafe void WeightResponse(int inMode)
		{
			IBPI_PhysicInteraction_C.__WeightResponse_FunctionParams* ptr = stackalloc IBPI_PhysicInteraction_C.__WeightResponse_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IBPI_PhysicInteraction_C.__WeightResponse_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_PhysicInteraction_C_ReflectionImplementationFields.__WeightResponse_NativeFunctionPtr, (void*)ptr, 1);
			ptr->inMode = inMode;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_PhysicInteraction_C_ReflectionImplementationFields.__WeightResponse_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F0DC RID: 127196 RVA: 0x0092546E File Offset: 0x0092366E
		[SkipLocalsInit]
		void ScanResponse()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_PhysicInteraction_C_ReflectionImplementationFields.__ScanResponse_NativeFunctionPtr, null);
		}

		// Token: 0x0601F0DD RID: 127197 RVA: 0x00925484 File Offset: 0x00923684
		[SkipLocalsInit]
		unsafe void GrabedResponse(bool inGrabed)
		{
			IBPI_PhysicInteraction_C.__GrabedResponse_FunctionParams* ptr = stackalloc IBPI_PhysicInteraction_C.__GrabedResponse_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(IBPI_PhysicInteraction_C.__GrabedResponse_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_PhysicInteraction_C_ReflectionImplementationFields.__GrabedResponse_NativeFunctionPtr, (void*)ptr, 1);
			ptr->inGrabed = inGrabed;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_PhysicInteraction_C_ReflectionImplementationFields.__GrabedResponse_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x04010970 RID: 67952
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/GamePlay/InteractiveObject/BPI_PhysicInteraction.BPI_PhysicInteraction_C";

		// Token: 0x02008F1F RID: 36639
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsPhysicInteracted_FunctionParams
		{
			// Token: 0x0402CC50 RID: 183376
			[FieldOffset(0)]
			public bool OutInteracted;
		}

		// Token: 0x02008F20 RID: 36640
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __WeightResponse_FunctionParams
		{
			// Token: 0x0402CC51 RID: 183377
			[FieldOffset(0)]
			public int inMode;
		}

		// Token: 0x02008F21 RID: 36641
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GrabedResponse_FunctionParams
		{
			// Token: 0x0402CC52 RID: 183378
			[FieldOffset(0)]
			public bool inGrabed;
		}
	}
}
