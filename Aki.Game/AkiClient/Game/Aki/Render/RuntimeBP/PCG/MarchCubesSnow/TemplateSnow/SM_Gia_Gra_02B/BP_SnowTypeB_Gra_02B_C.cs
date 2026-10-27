using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow.TemplateSnow.SM_Gia_Gra_02B
{
	// Token: 0x02003C58 RID: 15448
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Gia_Gra_02B/BP_SnowTypeB_Gra_02B.BP_SnowTypeB_Gra_02B_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SnowTypeB_Gra_02B_C : BP_MarchCubes_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D33 RID: 146739 RVA: 0x0092DFF9 File Offset: 0x0092C1F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTypeB_Gra_02B_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Gia_Gra_02B/BP_SnowTypeB_Gra_02B.BP_SnowTypeB_Gra_02B_C");
			}
			return BP_SnowTypeB_Gra_02B_C._ClassPtr;
		}

		// Token: 0x06023D34 RID: 146740 RVA: 0x0092E020 File Offset: 0x0092C220
		public BP_SnowTypeB_Gra_02B_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeB_Gra_02B_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D35 RID: 146741 RVA: 0x0092E048 File Offset: 0x0092C248
		[NullableContext(1)]
		public BP_SnowTypeB_Gra_02B_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeB_Gra_02B_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043C0 RID: 17344
		// (get) Token: 0x06023D36 RID: 146742 RVA: 0x0092E07B File Offset: 0x0092C27B
		// (set) Token: 0x06023D37 RID: 146743 RVA: 0x0092E08F File Offset: 0x0092C28F
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_SnowTypeE
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeB_Gra_02B_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeB_Gra_02B_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023D38 RID: 146744 RVA: 0x0092E0A4 File Offset: 0x0092C2A4
		protected BP_SnowTypeB_Gra_02B_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B69 RID: 72553
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Gia_Gra_02B/BP_SnowTypeB_Gra_02B.BP_SnowTypeB_Gra_02B_C";

		// Token: 0x04011B6A RID: 72554
		private static IntPtr _ClassPtr;

		// Token: 0x04011B6B RID: 72555
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B6C RID: 72556
		internal static int __PropertyOffset_0;
	}
}
