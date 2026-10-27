using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.TickMaster
{
	// Token: 0x02003D41 RID: 15681
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/TickMaster/BPI_EditorTickMaster.BPI_EditorTickMaster_C")]
	public interface IBPI_EditorTickMaster_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0602617C RID: 156028 RVA: 0x0096B40C File Offset: 0x0096960C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void EditorTickMaster(float DeltaTime)
		{
			IBPI_EditorTickMaster_C.__EditorTickMaster_FunctionParams* ptr = stackalloc IBPI_EditorTickMaster_C.__EditorTickMaster_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IBPI_EditorTickMaster_C.__EditorTickMaster_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_EditorTickMaster_C_ReflectionImplementationFields.__EditorTickMaster_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_EditorTickMaster_C_ReflectionImplementationFields.__EditorTickMaster_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x04013120 RID: 78112
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/TickMaster/BPI_EditorTickMaster.BPI_EditorTickMaster_C";

		// Token: 0x0200A098 RID: 41112
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __EditorTickMaster_FunctionParams
		{
			// Token: 0x04031B96 RID: 203670
			[FieldOffset(0)]
			public float DeltaTime;
		}
	}
}
