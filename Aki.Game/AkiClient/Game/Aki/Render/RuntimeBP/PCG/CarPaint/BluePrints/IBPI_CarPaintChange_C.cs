using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.CarPaint.BluePrints
{
	// Token: 0x020030E9 RID: 12521
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/CarPaint/BluePrints/BPI_CarPaintChange.BPI_CarPaintChange_C")]
	public interface IBPI_CarPaintChange_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601E510 RID: 124176 RVA: 0x00910ED4 File Offset: 0x0090F0D4
		[SkipLocalsInit]
		unsafe void SetColorFunctionByBPI(bool _bool)
		{
			IBPI_CarPaintChange_C.__SetColorFunctionByBPI_FunctionParams* ptr = stackalloc IBPI_CarPaintChange_C.__SetColorFunctionByBPI_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(IBPI_CarPaintChange_C.__SetColorFunctionByBPI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_CarPaintChange_C_ReflectionImplementationFields.__SetColorFunctionByBPI_NativeFunctionPtr, (void*)ptr, 1);
			ptr->_bool = _bool;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_CarPaintChange_C_ReflectionImplementationFields.__SetColorFunctionByBPI_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x040100C6 RID: 65734
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/CarPaint/BluePrints/BPI_CarPaintChange.BPI_CarPaintChange_C";

		// Token: 0x02008E61 RID: 36449
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetColorFunctionByBPI_FunctionParams
		{
			// Token: 0x0402CAAD RID: 182957
			[FieldOffset(0)]
			public bool _bool;
		}
	}
}
