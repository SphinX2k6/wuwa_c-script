using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.Spindrift.Blueprint
{
	// Token: 0x02003BEF RID: 15343
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/Spindrift/Blueprint/BPI_EditorTicker.BPI_EditorTicker_C")]
	public interface IBPI_EditorTicker_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06022DB6 RID: 142774 RVA: 0x00914284 File Offset: 0x00912484
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_EditorTicker_C_ReflectionImplementationFields.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x0401126B RID: 70251
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/Spindrift/Blueprint/BPI_EditorTicker.BPI_EditorTicker_C";
	}
}
