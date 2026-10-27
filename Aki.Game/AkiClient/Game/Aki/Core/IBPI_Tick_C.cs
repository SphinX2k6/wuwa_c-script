using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core
{
	// Token: 0x02003FD5 RID: 16341
	[UnrealObjectPath("/Game/Aki/Core/BPI_Tick.BPI_Tick_C")]
	public interface IBPI_Tick_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06029DB5 RID: 171445 RVA: 0x009CDF78 File Offset: 0x009CC178
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void Tick(float DeltaSeconds)
		{
			IBPI_Tick_C.__Tick_FunctionParams* ptr = stackalloc IBPI_Tick_C.__Tick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IBPI_Tick_C.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Tick_C_ReflectionImplementationFields.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Tick_C_ReflectionImplementationFields.__Tick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x040157E6 RID: 88038
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/BPI_Tick.BPI_Tick_C";

		// Token: 0x0200A2E5 RID: 41701
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Tick_FunctionParams
		{
			// Token: 0x04032033 RID: 204851
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
