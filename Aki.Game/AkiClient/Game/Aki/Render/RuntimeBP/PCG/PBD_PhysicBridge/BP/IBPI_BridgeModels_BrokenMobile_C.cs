using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.PBD_PhysicBridge.BP
{
	// Token: 0x02003C3D RID: 15421
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BPI_BridgeModels_BrokenMobile.BPI_BridgeModels_BrokenMobile_C")]
	public interface IBPI_BridgeModels_BrokenMobile_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060237BC RID: 145340 RVA: 0x009250E7 File Offset: 0x009232E7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void BreakTrigger()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_BridgeModels_BrokenMobile_C_ReflectionImplementationFields.__BreakTrigger_NativeFunctionPtr, null);
		}

		// Token: 0x04011846 RID: 71750
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BPI_BridgeModels_BrokenMobile.BPI_BridgeModels_BrokenMobile_C";
	}
}
