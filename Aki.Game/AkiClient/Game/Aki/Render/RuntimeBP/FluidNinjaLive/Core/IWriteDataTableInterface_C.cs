using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core
{
	// Token: 0x02003DAC RID: 15788
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/WriteDataTableInterface.WriteDataTableInterface_C")]
	public interface IWriteDataTableInterface_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06027318 RID: 160536 RVA: 0x0098AB24 File Offset: 0x00988D24
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void WriteDataTableFunction([Nullable(2)] UDataTable InputTable, string InputData)
		{
			IWriteDataTableInterface_C.__WriteDataTableFunction_FunctionParams* ptr = stackalloc IWriteDataTableInterface_C.__WriteDataTableFunction_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(IWriteDataTableInterface_C.__WriteDataTableFunction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IWriteDataTableInterface_C_ReflectionImplementationFields.__WriteDataTableFunction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InputTable = ((InputTable != null) ? InputTable.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->InputData), InputData);
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IWriteDataTableInterface_C_ReflectionImplementationFields.__WriteDataTableFunction_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(IWriteDataTableInterface_C_ReflectionImplementationFields.__WriteDataTableFunction_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x04013C45 RID: 80965
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/WriteDataTableInterface.WriteDataTableInterface_C";

		// Token: 0x0200A1F8 RID: 41464
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __WriteDataTableFunction_FunctionParams
		{
			// Token: 0x04031E58 RID: 204376
			[FieldOffset(0)]
			public IntPtr InputTable;

			// Token: 0x04031E59 RID: 204377
			[FieldOffset(8)]
			public FString InputData;
		}
	}
}
