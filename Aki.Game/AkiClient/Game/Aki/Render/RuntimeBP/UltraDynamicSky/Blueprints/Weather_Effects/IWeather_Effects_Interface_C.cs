using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.UltraDynamicSky.Blueprints.Weather_Effects
{
	// Token: 0x02003A95 RID: 14997
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Weather_Effects/Weather_Effects_Interface.Weather_Effects_Interface_C")]
	public interface IWeather_Effects_Interface_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060201AD RID: 131501 RVA: 0x008C9A41 File Offset: 0x008C7C41
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void Reset_Emitters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IWeather_Effects_Interface_C_ReflectionImplementationFields.__Reset_Emitters_NativeFunctionPtr, null);
		}

		// Token: 0x060201AE RID: 131502 RVA: 0x008C9A55 File Offset: 0x008C7C55
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void Editor_Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IWeather_Effects_Interface_C_ReflectionImplementationFields.__Editor_Update_NativeFunctionPtr, null);
		}

		// Token: 0x0400F7E0 RID: 63456
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Weather_Effects/Weather_Effects_Interface.Weather_Effects_Interface_C";
	}
}
