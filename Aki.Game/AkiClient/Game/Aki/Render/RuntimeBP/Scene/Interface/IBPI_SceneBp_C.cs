using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interface
{
	// Token: 0x020030B9 RID: 12473
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interface/BPI_SceneBp.BPI_SceneBp_C")]
	public interface IBPI_SceneBp_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601DFA0 RID: 122784 RVA: 0x009078B0 File Offset: 0x00905AB0
		[SkipLocalsInit]
		unsafe void ShouldStopOnHide(ref bool ret)
		{
			IBPI_SceneBp_C.__ShouldStopOnHide_FunctionParams* ptr = stackalloc IBPI_SceneBp_C.__ShouldStopOnHide_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(IBPI_SceneBp_C.__ShouldStopOnHide_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_SceneBp_C_ReflectionImplementationFields.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SceneBp_C_ReflectionImplementationFields.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x0601DFA1 RID: 122785 RVA: 0x009078FF File Offset: 0x00905AFF
		[SkipLocalsInit]
		void Resume()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SceneBp_C_ReflectionImplementationFields.__Resume_NativeFunctionPtr, null);
		}

		// Token: 0x0601DFA2 RID: 122786 RVA: 0x00907913 File Offset: 0x00905B13
		[SkipLocalsInit]
		void Pause()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SceneBp_C_ReflectionImplementationFields.__Pause_NativeFunctionPtr, null);
		}

		// Token: 0x0601DFA3 RID: 122787 RVA: 0x00907928 File Offset: 0x00905B28
		[SkipLocalsInit]
		unsafe void GetAoiRange(ref int ret)
		{
			IBPI_SceneBp_C.__GetAoiRange_FunctionParams* ptr = stackalloc IBPI_SceneBp_C.__GetAoiRange_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IBPI_SceneBp_C.__GetAoiRange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_SceneBp_C_ReflectionImplementationFields.__GetAoiRange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SceneBp_C_ReflectionImplementationFields.__GetAoiRange_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x0601DFA4 RID: 122788 RVA: 0x00907977 File Offset: 0x00905B77
		[SkipLocalsInit]
		void Stop()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SceneBp_C_ReflectionImplementationFields.__Stop_NativeFunctionPtr, null);
		}

		// Token: 0x0601DFA5 RID: 122789 RVA: 0x0090798B File Offset: 0x00905B8B
		[SkipLocalsInit]
		void Start()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SceneBp_C_ReflectionImplementationFields.__Start_NativeFunctionPtr, null);
		}

		// Token: 0x0601DFA6 RID: 122790 RVA: 0x0090799F File Offset: 0x00905B9F
		[SkipLocalsInit]
		void TickOutside()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_SceneBp_C_ReflectionImplementationFields.__TickOutside_NativeFunctionPtr, null);
		}

		// Token: 0x0400FD68 RID: 64872
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interface/BPI_SceneBp.BPI_SceneBp_C";

		// Token: 0x02008DFB RID: 36347
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ShouldStopOnHide_FunctionParams
		{
			// Token: 0x0402CA21 RID: 182817
			[FieldOffset(0)]
			public bool ret;
		}

		// Token: 0x02008DFC RID: 36348
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetAoiRange_FunctionParams
		{
			// Token: 0x0402CA22 RID: 182818
			[FieldOffset(0)]
			public int ret;
		}
	}
}
