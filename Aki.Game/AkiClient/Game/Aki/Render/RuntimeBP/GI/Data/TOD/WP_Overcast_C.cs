using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Data.TOD
{
	// Token: 0x02003D79 RID: 15737
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Overcast.WP_Overcast_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 156)]
	public class WP_Overcast_C : WeatherPreset_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026A1B RID: 158235 RVA: 0x0097A05C File Offset: 0x0097825C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WP_Overcast_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Overcast.WP_Overcast_C");
			}
			return WP_Overcast_C._ClassPtr;
		}

		// Token: 0x06026A1C RID: 158236 RVA: 0x0097A080 File Offset: 0x00978280
		public WP_Overcast_C() : this(BuiltinUtils.AllocNativeUObject(WP_Overcast_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026A1D RID: 158237 RVA: 0x0097A0A8 File Offset: 0x009782A8
		[NullableContext(1)]
		public WP_Overcast_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WP_Overcast_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026A1E RID: 158238 RVA: 0x0097A0DB File Offset: 0x009782DB
		protected WP_Overcast_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040136A7 RID: 79527
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Overcast.WP_Overcast_C";

		// Token: 0x040136A8 RID: 79528
		private static IntPtr _ClassPtr;

		// Token: 0x040136A9 RID: 79529
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
