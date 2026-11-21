using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interface
{
	// Token: 0x020030B8 RID: 12472
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interface/BPI_DayNightEvent.BPI_DayNightEvent_C")]
	public interface IBPI_DayNightEvent_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601DF9E RID: 122782 RVA: 0x00907887 File Offset: 0x00905A87
		[SkipLocalsInit]
		void OnEnterNight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DayNightEvent_C_ReflectionImplementationFields.__OnEnterNight_NativeFunctionPtr, null);
		}

		// Token: 0x0601DF9F RID: 122783 RVA: 0x0090789B File Offset: 0x00905A9B
		[SkipLocalsInit]
		void OnEnterDay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_DayNightEvent_C_ReflectionImplementationFields.__OnEnterDay_NativeFunctionPtr, null);
		}

		// Token: 0x0400FD67 RID: 64871
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interface/BPI_DayNightEvent.BPI_DayNightEvent_C";
	}
}
