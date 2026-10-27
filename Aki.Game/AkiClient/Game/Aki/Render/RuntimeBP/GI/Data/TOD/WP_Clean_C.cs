using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Data.TOD
{
	// Token: 0x02003D74 RID: 15732
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Clean.WP_Clean_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 156)]
	public class WP_Clean_C : WeatherPreset_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026A07 RID: 158215 RVA: 0x00979DB4 File Offset: 0x00977FB4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WP_Clean_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Clean.WP_Clean_C");
			}
			return WP_Clean_C._ClassPtr;
		}

		// Token: 0x06026A08 RID: 158216 RVA: 0x00979DD8 File Offset: 0x00977FD8
		public WP_Clean_C() : this(BuiltinUtils.AllocNativeUObject(WP_Clean_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026A09 RID: 158217 RVA: 0x00979E00 File Offset: 0x00978000
		[NullableContext(1)]
		public WP_Clean_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WP_Clean_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026A0A RID: 158218 RVA: 0x00979E33 File Offset: 0x00978033
		protected WP_Clean_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013698 RID: 79512
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Data/TOD/WP_Clean.WP_Clean_C";

		// Token: 0x04013699 RID: 79513
		private static IntPtr _ClassPtr;

		// Token: 0x0401369A RID: 79514
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
