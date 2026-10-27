using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Data.TOD
{
	// Token: 0x02003D7D RID: 15741
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Stormy.WP_Stormy_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 156)]
	public class WP_Stormy_C : WeatherPreset_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026A2B RID: 158251 RVA: 0x0097A27C File Offset: 0x0097847C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WP_Stormy_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Stormy.WP_Stormy_C");
			}
			return WP_Stormy_C._ClassPtr;
		}

		// Token: 0x06026A2C RID: 158252 RVA: 0x0097A2A0 File Offset: 0x009784A0
		public WP_Stormy_C() : this(BuiltinUtils.AllocNativeUObject(WP_Stormy_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026A2D RID: 158253 RVA: 0x0097A2C8 File Offset: 0x009784C8
		[NullableContext(1)]
		public WP_Stormy_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WP_Stormy_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026A2E RID: 158254 RVA: 0x0097A2FB File Offset: 0x009784FB
		protected WP_Stormy_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040136B3 RID: 79539
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Stormy.WP_Stormy_C";

		// Token: 0x040136B4 RID: 79540
		private static IntPtr _ClassPtr;

		// Token: 0x040136B5 RID: 79541
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
