using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.Data.Weather
{
	// Token: 0x02003E3F RID: 15935
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/Data/Weather/BP_Weather.BP_Weather_C")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class BP_Weather_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602809B RID: 163995 RVA: 0x009A27A6 File Offset: 0x009A09A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Weather_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/Data/Weather/BP_Weather.BP_Weather_C");
			}
			return BP_Weather_C._ClassPtr;
		}

		// Token: 0x0602809C RID: 163996 RVA: 0x009A27CC File Offset: 0x009A09CC
		public BP_Weather_C() : this(BuiltinUtils.AllocNativeUObject(BP_Weather_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602809D RID: 163997 RVA: 0x009A27F4 File Offset: 0x009A09F4
		[NullableContext(1)]
		public BP_Weather_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Weather_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005B75 RID: 23413
		// (get) Token: 0x0602809E RID: 163998 RVA: 0x009A2827 File Offset: 0x009A0A27
		// (set) Token: 0x0602809F RID: 163999 RVA: 0x009A283B File Offset: 0x009A0A3B
		public unsafe UKuroPostProcessComponent KuroPostProcess_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Weather_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Weather_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005B76 RID: 23414
		// (get) Token: 0x060280A0 RID: 164000 RVA: 0x009A2850 File Offset: 0x009A0A50
		// (set) Token: 0x060280A1 RID: 164001 RVA: 0x009A2864 File Offset: 0x009A0A64
		public unsafe UKuroPostProcessComponent KuroPostProcess_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Weather_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Weather_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x060280A2 RID: 164002 RVA: 0x009A2879 File Offset: 0x009A0A79
		protected BP_Weather_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014550 RID: 83280
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/Data/Weather/BP_Weather.BP_Weather_C";

		// Token: 0x04014551 RID: 83281
		private static IntPtr _ClassPtr;

		// Token: 0x04014552 RID: 83282
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014553 RID: 83283
		internal static int __PropertyOffset_0;

		// Token: 0x04014554 RID: 83284
		internal static int __PropertyOffset_1;
	}
}
