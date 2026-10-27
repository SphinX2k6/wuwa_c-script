using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Data.TOD
{
	// Token: 0x02003D7C RID: 15740
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Snowy.WP_Snowy_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 156)]
	public class WP_Snowy_C : WeatherPreset_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026A27 RID: 158247 RVA: 0x0097A1F4 File Offset: 0x009783F4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WP_Snowy_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Snowy.WP_Snowy_C");
			}
			return WP_Snowy_C._ClassPtr;
		}

		// Token: 0x06026A28 RID: 158248 RVA: 0x0097A218 File Offset: 0x00978418
		public WP_Snowy_C() : this(BuiltinUtils.AllocNativeUObject(WP_Snowy_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026A29 RID: 158249 RVA: 0x0097A240 File Offset: 0x00978440
		[NullableContext(1)]
		public WP_Snowy_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WP_Snowy_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026A2A RID: 158250 RVA: 0x0097A273 File Offset: 0x00978473
		protected WP_Snowy_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040136B0 RID: 79536
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Snowy.WP_Snowy_C";

		// Token: 0x040136B1 RID: 79537
		private static IntPtr _ClassPtr;

		// Token: 0x040136B2 RID: 79538
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
