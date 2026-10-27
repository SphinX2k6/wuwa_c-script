using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.CarPaint.BluePrints
{
	// Token: 0x02003CC9 RID: 15561
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/CarPaint/BluePrints/BPI_CarPaintChange.BPI_CarPaintChange_C")]
	public interface IBPI_CarPaintChange_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06024D17 RID: 150807 RVA: 0x00949200 File Offset: 0x00947400
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void SetColorFunctionByBPI(bool _bool)
		{
			IBPI_CarPaintChange_C.__SetColorFunctionByBPI_FunctionParams* ptr = stackalloc IBPI_CarPaintChange_C.__SetColorFunctionByBPI_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(IBPI_CarPaintChange_C.__SetColorFunctionByBPI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_CarPaintChange_C_ReflectionImplementationFields.__SetColorFunctionByBPI_NativeFunctionPtr, (void*)ptr, 1);
			ptr->_bool = _bool;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_CarPaintChange_C_ReflectionImplementationFields.__SetColorFunctionByBPI_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x040124C3 RID: 74947
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/CarPaint/BluePrints/BPI_CarPaintChange.BPI_CarPaintChange_C";

		// Token: 0x02009F70 RID: 40816
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetColorFunctionByBPI_FunctionParams
		{
			// Token: 0x0403196F RID: 203119
			[FieldOffset(0)]
			public bool _bool;
		}
	}
}
