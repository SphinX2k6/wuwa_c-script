using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow.TemplateSnow.SM_Com3_Veg_12
{
	// Token: 0x02003C61 RID: 15457
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_12/BP_SnowTypeB_Veg_12.BP_SnowTypeB_Veg_12_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SnowTypeB_Veg_12_C : BP_MarchCubes_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D69 RID: 146793 RVA: 0x0092E64D File Offset: 0x0092C84D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTypeB_Veg_12_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_12/BP_SnowTypeB_Veg_12.BP_SnowTypeB_Veg_12_C");
			}
			return BP_SnowTypeB_Veg_12_C._ClassPtr;
		}

		// Token: 0x06023D6A RID: 146794 RVA: 0x0092E674 File Offset: 0x0092C874
		public BP_SnowTypeB_Veg_12_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeB_Veg_12_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D6B RID: 146795 RVA: 0x0092E69C File Offset: 0x0092C89C
		[NullableContext(1)]
		public BP_SnowTypeB_Veg_12_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeB_Veg_12_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043C9 RID: 17353
		// (get) Token: 0x06023D6C RID: 146796 RVA: 0x0092E6CF File Offset: 0x0092C8CF
		// (set) Token: 0x06023D6D RID: 146797 RVA: 0x0092E6E3 File Offset: 0x0092C8E3
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_SnowTypeB
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeB_Veg_12_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeB_Veg_12_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023D6E RID: 146798 RVA: 0x0092E6F8 File Offset: 0x0092C8F8
		protected BP_SnowTypeB_Veg_12_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B8D RID: 72589
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_12/BP_SnowTypeB_Veg_12.BP_SnowTypeB_Veg_12_C";

		// Token: 0x04011B8E RID: 72590
		private static IntPtr _ClassPtr;

		// Token: 0x04011B8F RID: 72591
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B90 RID: 72592
		internal static int __PropertyOffset_0;
	}
}
