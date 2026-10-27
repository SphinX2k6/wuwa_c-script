using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Data.TOD
{
	// Token: 0x02003D7B RID: 15739
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Smoky.WP_Smoky_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 156)]
	public class WP_Smoky_C : WeatherPreset_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026A23 RID: 158243 RVA: 0x0097A16C File Offset: 0x0097836C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WP_Smoky_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Smoky.WP_Smoky_C");
			}
			return WP_Smoky_C._ClassPtr;
		}

		// Token: 0x06026A24 RID: 158244 RVA: 0x0097A190 File Offset: 0x00978390
		public WP_Smoky_C() : this(BuiltinUtils.AllocNativeUObject(WP_Smoky_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026A25 RID: 158245 RVA: 0x0097A1B8 File Offset: 0x009783B8
		[NullableContext(1)]
		public WP_Smoky_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WP_Smoky_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026A26 RID: 158246 RVA: 0x0097A1EB File Offset: 0x009783EB
		protected WP_Smoky_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040136AD RID: 79533
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Smoky.WP_Smoky_C";

		// Token: 0x040136AE RID: 79534
		private static IntPtr _ClassPtr;

		// Token: 0x040136AF RID: 79535
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
