using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.Data.Weather
{
	// Token: 0x02003144 RID: 12612
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/Data/Weather/BP_Weather.BP_Weather_C")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class BP_Weather_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F03A RID: 127034 RVA: 0x009240E1 File Offset: 0x009222E1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Weather_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/Data/Weather/BP_Weather.BP_Weather_C");
			}
			return BP_Weather_C._ClassPtr;
		}

		// Token: 0x0601F03B RID: 127035 RVA: 0x00924108 File Offset: 0x00922308
		public BP_Weather_C() : this(BuiltinUtils.AllocNativeUObject(BP_Weather_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F03C RID: 127036 RVA: 0x00924130 File Offset: 0x00922330
		[NullableContext(1)]
		public BP_Weather_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Weather_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170036E3 RID: 14051
		// (get) Token: 0x0601F03D RID: 127037 RVA: 0x00924163 File Offset: 0x00922363
		// (set) Token: 0x0601F03E RID: 127038 RVA: 0x00924177 File Offset: 0x00922377
		public unsafe UKuroPostProcessComponent KuroPostProcess_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Weather_C.__PropertyOffset_KuroPostProcess_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Weather_C.__PropertyOffset_KuroPostProcess_2, value);
			}
		}

		// Token: 0x170036E4 RID: 14052
		// (get) Token: 0x0601F03F RID: 127039 RVA: 0x0092418C File Offset: 0x0092238C
		// (set) Token: 0x0601F040 RID: 127040 RVA: 0x009241A0 File Offset: 0x009223A0
		public unsafe UKuroPostProcessComponent KuroPostProcess_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Weather_C.__PropertyOffset_KuroPostProcess_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Weather_C.__PropertyOffset_KuroPostProcess_1, value);
			}
		}

		// Token: 0x0601F041 RID: 127041 RVA: 0x009241B5 File Offset: 0x009223B5
		protected BP_Weather_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010879 RID: 67705
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/Data/Weather/BP_Weather.BP_Weather_C";

		// Token: 0x0401087A RID: 67706
		private static IntPtr _ClassPtr;

		// Token: 0x0401087B RID: 67707
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401087C RID: 67708
		internal static int __PropertyOffset_KuroPostProcess_2;

		// Token: 0x0401087D RID: 67709
		internal static int __PropertyOffset_KuroPostProcess_1;
	}
}
