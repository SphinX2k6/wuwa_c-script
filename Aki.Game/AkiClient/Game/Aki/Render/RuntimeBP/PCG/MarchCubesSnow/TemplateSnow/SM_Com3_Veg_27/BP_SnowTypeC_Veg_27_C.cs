using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow.TemplateSnow.SM_Com3_Veg_27
{
	// Token: 0x02003C5F RID: 15455
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_27/BP_SnowTypeC_Veg_27.BP_SnowTypeC_Veg_27_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SnowTypeC_Veg_27_C : BP_MarchCubes_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D5D RID: 146781 RVA: 0x0092E4E5 File Offset: 0x0092C6E5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTypeC_Veg_27_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_27/BP_SnowTypeC_Veg_27.BP_SnowTypeC_Veg_27_C");
			}
			return BP_SnowTypeC_Veg_27_C._ClassPtr;
		}

		// Token: 0x06023D5E RID: 146782 RVA: 0x0092E50C File Offset: 0x0092C70C
		public BP_SnowTypeC_Veg_27_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeC_Veg_27_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D5F RID: 146783 RVA: 0x0092E534 File Offset: 0x0092C734
		[NullableContext(1)]
		public BP_SnowTypeC_Veg_27_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeC_Veg_27_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043C7 RID: 17351
		// (get) Token: 0x06023D60 RID: 146784 RVA: 0x0092E567 File Offset: 0x0092C767
		// (set) Token: 0x06023D61 RID: 146785 RVA: 0x0092E57B File Offset: 0x0092C77B
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_SnowTypeC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeC_Veg_27_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeC_Veg_27_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023D62 RID: 146786 RVA: 0x0092E590 File Offset: 0x0092C790
		protected BP_SnowTypeC_Veg_27_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B85 RID: 72581
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_27/BP_SnowTypeC_Veg_27.BP_SnowTypeC_Veg_27_C";

		// Token: 0x04011B86 RID: 72582
		private static IntPtr _ClassPtr;

		// Token: 0x04011B87 RID: 72583
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B88 RID: 72584
		internal static int __PropertyOffset_0;
	}
}
