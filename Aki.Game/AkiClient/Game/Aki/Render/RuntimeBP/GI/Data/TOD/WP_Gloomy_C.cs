using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Data.TOD
{
	// Token: 0x02003D77 RID: 15735
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Gloomy.WP_Gloomy_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 156)]
	public class WP_Gloomy_C : WeatherPreset_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026A13 RID: 158227 RVA: 0x00979F4C File Offset: 0x0097814C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WP_Gloomy_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Gloomy.WP_Gloomy_C");
			}
			return WP_Gloomy_C._ClassPtr;
		}

		// Token: 0x06026A14 RID: 158228 RVA: 0x00979F70 File Offset: 0x00978170
		public WP_Gloomy_C() : this(BuiltinUtils.AllocNativeUObject(WP_Gloomy_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026A15 RID: 158229 RVA: 0x00979F98 File Offset: 0x00978198
		[NullableContext(1)]
		public WP_Gloomy_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WP_Gloomy_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026A16 RID: 158230 RVA: 0x00979FCB File Offset: 0x009781CB
		protected WP_Gloomy_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040136A1 RID: 79521
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Gloomy.WP_Gloomy_C";

		// Token: 0x040136A2 RID: 79522
		private static IntPtr _ClassPtr;

		// Token: 0x040136A3 RID: 79523
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
