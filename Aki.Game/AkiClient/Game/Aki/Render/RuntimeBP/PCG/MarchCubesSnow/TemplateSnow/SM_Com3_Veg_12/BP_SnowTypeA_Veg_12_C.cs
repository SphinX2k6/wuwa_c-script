using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow.TemplateSnow.SM_Com3_Veg_12
{
	// Token: 0x02003C60 RID: 15456
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_12/BP_SnowTypeA_Veg_12.BP_SnowTypeA_Veg_12_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SnowTypeA_Veg_12_C : BP_MarchCubes_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D63 RID: 146787 RVA: 0x0092E599 File Offset: 0x0092C799
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTypeA_Veg_12_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_12/BP_SnowTypeA_Veg_12.BP_SnowTypeA_Veg_12_C");
			}
			return BP_SnowTypeA_Veg_12_C._ClassPtr;
		}

		// Token: 0x06023D64 RID: 146788 RVA: 0x0092E5C0 File Offset: 0x0092C7C0
		public BP_SnowTypeA_Veg_12_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeA_Veg_12_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D65 RID: 146789 RVA: 0x0092E5E8 File Offset: 0x0092C7E8
		[NullableContext(1)]
		public BP_SnowTypeA_Veg_12_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeA_Veg_12_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043C8 RID: 17352
		// (get) Token: 0x06023D66 RID: 146790 RVA: 0x0092E61B File Offset: 0x0092C81B
		// (set) Token: 0x06023D67 RID: 146791 RVA: 0x0092E62F File Offset: 0x0092C82F
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_SnowTypeA
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeA_Veg_12_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeA_Veg_12_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023D68 RID: 146792 RVA: 0x0092E644 File Offset: 0x0092C844
		protected BP_SnowTypeA_Veg_12_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B89 RID: 72585
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_12/BP_SnowTypeA_Veg_12.BP_SnowTypeA_Veg_12_C";

		// Token: 0x04011B8A RID: 72586
		private static IntPtr _ClassPtr;

		// Token: 0x04011B8B RID: 72587
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B8C RID: 72588
		internal static int __PropertyOffset_0;
	}
}
