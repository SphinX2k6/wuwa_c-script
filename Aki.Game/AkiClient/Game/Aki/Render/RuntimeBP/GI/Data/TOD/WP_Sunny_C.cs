using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Data.TOD
{
	// Token: 0x02003D7E RID: 15742
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Sunny.WP_Sunny_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 156)]
	public class WP_Sunny_C : WeatherPreset_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026A2F RID: 158255 RVA: 0x0097A304 File Offset: 0x00978504
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WP_Sunny_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Sunny.WP_Sunny_C");
			}
			return WP_Sunny_C._ClassPtr;
		}

		// Token: 0x06026A30 RID: 158256 RVA: 0x0097A328 File Offset: 0x00978528
		public WP_Sunny_C() : this(BuiltinUtils.AllocNativeUObject(WP_Sunny_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026A31 RID: 158257 RVA: 0x0097A350 File Offset: 0x00978550
		[NullableContext(1)]
		public WP_Sunny_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WP_Sunny_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026A32 RID: 158258 RVA: 0x0097A383 File Offset: 0x00978583
		protected WP_Sunny_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040136B6 RID: 79542
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Sunny.WP_Sunny_C";

		// Token: 0x040136B7 RID: 79543
		private static IntPtr _ClassPtr;

		// Token: 0x040136B8 RID: 79544
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
