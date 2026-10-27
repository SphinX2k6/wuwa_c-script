using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Data.TOD
{
	// Token: 0x02003D75 RID: 15733
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Cloudy.WP_Cloudy_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 156)]
	public class WP_Cloudy_C : WeatherPreset_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026A0B RID: 158219 RVA: 0x00979E3C File Offset: 0x0097803C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WP_Cloudy_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Cloudy.WP_Cloudy_C");
			}
			return WP_Cloudy_C._ClassPtr;
		}

		// Token: 0x06026A0C RID: 158220 RVA: 0x00979E60 File Offset: 0x00978060
		public WP_Cloudy_C() : this(BuiltinUtils.AllocNativeUObject(WP_Cloudy_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026A0D RID: 158221 RVA: 0x00979E88 File Offset: 0x00978088
		[NullableContext(1)]
		public WP_Cloudy_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WP_Cloudy_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026A0E RID: 158222 RVA: 0x00979EBB File Offset: 0x009780BB
		protected WP_Cloudy_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401369B RID: 79515
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Cloudy.WP_Cloudy_C";

		// Token: 0x0401369C RID: 79516
		private static IntPtr _ClassPtr;

		// Token: 0x0401369D RID: 79517
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
