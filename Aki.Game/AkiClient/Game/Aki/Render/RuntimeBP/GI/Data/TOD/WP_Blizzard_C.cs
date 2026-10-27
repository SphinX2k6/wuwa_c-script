using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Data.TOD
{
	// Token: 0x02003D73 RID: 15731
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Blizzard.WP_Blizzard_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 156)]
	public class WP_Blizzard_C : WeatherPreset_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026A03 RID: 158211 RVA: 0x00979D2B File Offset: 0x00977F2B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WP_Blizzard_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Blizzard.WP_Blizzard_C");
			}
			return WP_Blizzard_C._ClassPtr;
		}

		// Token: 0x06026A04 RID: 158212 RVA: 0x00979D50 File Offset: 0x00977F50
		public WP_Blizzard_C() : this(BuiltinUtils.AllocNativeUObject(WP_Blizzard_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026A05 RID: 158213 RVA: 0x00979D78 File Offset: 0x00977F78
		[NullableContext(1)]
		public WP_Blizzard_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WP_Blizzard_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026A06 RID: 158214 RVA: 0x00979DAB File Offset: 0x00977FAB
		protected WP_Blizzard_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013695 RID: 79509
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Blizzard.WP_Blizzard_C";

		// Token: 0x04013696 RID: 79510
		private static IntPtr _ClassPtr;

		// Token: 0x04013697 RID: 79511
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
