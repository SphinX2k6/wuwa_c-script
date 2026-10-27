using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common
{
	// Token: 0x020040A3 RID: 16547
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/IAbp_Shell.IAbp_Shell_C")]
	public interface IIAbp_Shell_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0602AB6B RID: 174955 RVA: 0x009E9AF8 File Offset: 0x009E7CF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void SetEnableAreaMove(bool Enable)
		{
			IIAbp_Shell_C.__SetEnableAreaMove_FunctionParams* ptr = stackalloc IIAbp_Shell_C.__SetEnableAreaMove_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(IIAbp_Shell_C.__SetEnableAreaMove_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IIAbp_Shell_C_ReflectionImplementationFields.__SetEnableAreaMove_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IIAbp_Shell_C_ReflectionImplementationFields.__SetEnableAreaMove_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x040161B5 RID: 90549
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/Role/Common/IAbp_Shell.IAbp_Shell_C";

		// Token: 0x0200A41A RID: 42010
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetEnableAreaMove_FunctionParams
		{
			// Token: 0x04032253 RID: 205395
			[FieldOffset(0)]
			public bool Enable;
		}
	}
}
