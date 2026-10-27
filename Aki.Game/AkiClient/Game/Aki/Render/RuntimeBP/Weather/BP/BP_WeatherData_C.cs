using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Weather.BP
{
	// Token: 0x02003A7E RID: 14974
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Weather/BP/BP_WeatherData.BP_WeatherData_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_WeatherData_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FC46 RID: 130118 RVA: 0x008C1F60 File Offset: 0x008C0160
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WeatherData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Weather/BP/BP_WeatherData.BP_WeatherData_C");
			}
			return BP_WeatherData_C._ClassPtr;
		}

		// Token: 0x0601FC47 RID: 130119 RVA: 0x008C1F84 File Offset: 0x008C0184
		public BP_WeatherData_C() : this(BuiltinUtils.AllocNativeUObject(BP_WeatherData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FC48 RID: 130120 RVA: 0x008C1FAC File Offset: 0x008C01AC
		[NullableContext(1)]
		public BP_WeatherData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WeatherData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601FC49 RID: 130121 RVA: 0x008C1FDF File Offset: 0x008C01DF
		protected BP_WeatherData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F4E4 RID: 62692
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Weather/BP/BP_WeatherData.BP_WeatherData_C";

		// Token: 0x0400F4E5 RID: 62693
		private static IntPtr _ClassPtr;

		// Token: 0x0400F4E6 RID: 62694
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
