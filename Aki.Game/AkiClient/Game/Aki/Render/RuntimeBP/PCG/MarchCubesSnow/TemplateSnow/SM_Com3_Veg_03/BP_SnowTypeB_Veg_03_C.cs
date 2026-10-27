using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow.TemplateSnow.SM_Com3_Veg_03
{
	// Token: 0x02003C67 RID: 15463
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_03/BP_SnowTypeB_Veg_03.BP_SnowTypeB_Veg_03_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SnowTypeB_Veg_03_C : BP_MarchCubes_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D8D RID: 146829 RVA: 0x0092EA85 File Offset: 0x0092CC85
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTypeB_Veg_03_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_03/BP_SnowTypeB_Veg_03.BP_SnowTypeB_Veg_03_C");
			}
			return BP_SnowTypeB_Veg_03_C._ClassPtr;
		}

		// Token: 0x06023D8E RID: 146830 RVA: 0x0092EAAC File Offset: 0x0092CCAC
		public BP_SnowTypeB_Veg_03_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeB_Veg_03_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D8F RID: 146831 RVA: 0x0092EAD4 File Offset: 0x0092CCD4
		[NullableContext(1)]
		public BP_SnowTypeB_Veg_03_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeB_Veg_03_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043CF RID: 17359
		// (get) Token: 0x06023D90 RID: 146832 RVA: 0x0092EB07 File Offset: 0x0092CD07
		// (set) Token: 0x06023D91 RID: 146833 RVA: 0x0092EB1B File Offset: 0x0092CD1B
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_SnowTypeB
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeB_Veg_03_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeB_Veg_03_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023D92 RID: 146834 RVA: 0x0092EB30 File Offset: 0x0092CD30
		protected BP_SnowTypeB_Veg_03_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011BA5 RID: 72613
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_03/BP_SnowTypeB_Veg_03.BP_SnowTypeB_Veg_03_C";

		// Token: 0x04011BA6 RID: 72614
		private static IntPtr _ClassPtr;

		// Token: 0x04011BA7 RID: 72615
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011BA8 RID: 72616
		internal static int __PropertyOffset_0;
	}
}
