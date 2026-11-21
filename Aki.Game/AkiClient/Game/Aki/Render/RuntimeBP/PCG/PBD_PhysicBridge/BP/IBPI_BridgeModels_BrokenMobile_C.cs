using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.PBD_PhysicBridge.BP
{
	// Token: 0x020030E1 RID: 12513
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BPI_BridgeModels_BrokenMobile.BPI_BridgeModels_BrokenMobile_C")]
	public interface IBPI_BridgeModels_BrokenMobile_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601E3E0 RID: 123872 RVA: 0x0090EEC9 File Offset: 0x0090D0C9
		[SkipLocalsInit]
		void BreakTrigger()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_BridgeModels_BrokenMobile_C_ReflectionImplementationFields.__BreakTrigger_NativeFunctionPtr, null);
		}

		// Token: 0x04010011 RID: 65553
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/PBD_PhysicBridge/BP/BPI_BridgeModels_BrokenMobile.BPI_BridgeModels_BrokenMobile_C";
	}
}
