using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interface
{
	// Token: 0x02003B3A RID: 15162
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interface/BPI_DayNightEvent.BPI_DayNightEvent_C")]
	public interface IBPI_DayNightEvent_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060218C3 RID: 137411 RVA: 0x008EF282 File Offset: 0x008ED482
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void OnEnterNight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DayNightEvent_C_ReflectionImplementationFields.__OnEnterNight_NativeFunctionPtr, null);
		}

		// Token: 0x060218C4 RID: 137412 RVA: 0x008EF296 File Offset: 0x008ED496
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void OnEnterDay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DayNightEvent_C_ReflectionImplementationFields.__OnEnterDay_NativeFunctionPtr, null);
		}

		// Token: 0x04010599 RID: 66969
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interface/BPI_DayNightEvent.BPI_DayNightEvent_C";
	}
}
