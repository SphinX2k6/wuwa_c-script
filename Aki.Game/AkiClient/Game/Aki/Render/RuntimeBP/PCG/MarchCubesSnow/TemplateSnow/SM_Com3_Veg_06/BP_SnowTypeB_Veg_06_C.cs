using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow.TemplateSnow.SM_Com3_Veg_06
{
	// Token: 0x02003C64 RID: 15460
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_06/BP_SnowTypeB_Veg_06.BP_SnowTypeB_Veg_06_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SnowTypeB_Veg_06_C : BP_MarchCubes_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D7B RID: 146811 RVA: 0x0092E869 File Offset: 0x0092CA69
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTypeB_Veg_06_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_06/BP_SnowTypeB_Veg_06.BP_SnowTypeB_Veg_06_C");
			}
			return BP_SnowTypeB_Veg_06_C._ClassPtr;
		}

		// Token: 0x06023D7C RID: 146812 RVA: 0x0092E890 File Offset: 0x0092CA90
		public BP_SnowTypeB_Veg_06_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeB_Veg_06_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D7D RID: 146813 RVA: 0x0092E8B8 File Offset: 0x0092CAB8
		[NullableContext(1)]
		public BP_SnowTypeB_Veg_06_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeB_Veg_06_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043CC RID: 17356
		// (get) Token: 0x06023D7E RID: 146814 RVA: 0x0092E8EB File Offset: 0x0092CAEB
		// (set) Token: 0x06023D7F RID: 146815 RVA: 0x0092E8FF File Offset: 0x0092CAFF
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_SnowTypeB
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeB_Veg_06_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeB_Veg_06_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023D80 RID: 146816 RVA: 0x0092E914 File Offset: 0x0092CB14
		protected BP_SnowTypeB_Veg_06_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B99 RID: 72601
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_06/BP_SnowTypeB_Veg_06.BP_SnowTypeB_Veg_06_C";

		// Token: 0x04011B9A RID: 72602
		private static IntPtr _ClassPtr;

		// Token: 0x04011B9B RID: 72603
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B9C RID: 72604
		internal static int __PropertyOffset_0;
	}
}
