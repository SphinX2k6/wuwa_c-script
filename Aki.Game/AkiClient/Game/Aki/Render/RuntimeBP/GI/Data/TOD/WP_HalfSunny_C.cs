using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Data.TOD
{
	// Token: 0x02003D78 RID: 15736
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_HalfSunny.WP_HalfSunny_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 156)]
	public class WP_HalfSunny_C : WeatherPreset_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026A17 RID: 158231 RVA: 0x00979FD4 File Offset: 0x009781D4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WP_HalfSunny_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_HalfSunny.WP_HalfSunny_C");
			}
			return WP_HalfSunny_C._ClassPtr;
		}

		// Token: 0x06026A18 RID: 158232 RVA: 0x00979FF8 File Offset: 0x009781F8
		public WP_HalfSunny_C() : this(BuiltinUtils.AllocNativeUObject(WP_HalfSunny_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026A19 RID: 158233 RVA: 0x0097A020 File Offset: 0x00978220
		[NullableContext(1)]
		public WP_HalfSunny_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WP_HalfSunny_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026A1A RID: 158234 RVA: 0x0097A053 File Offset: 0x00978253
		protected WP_HalfSunny_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040136A4 RID: 79524
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_HalfSunny.WP_HalfSunny_C";

		// Token: 0x040136A5 RID: 79525
		private static IntPtr _ClassPtr;

		// Token: 0x040136A6 RID: 79526
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
