using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow.TemplateSnow.SM_Gia_Gra_02C
{
	// Token: 0x02003C55 RID: 15445
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Gia_Gra_02C/BP_SnowTypeB_Gra_02C.BP_SnowTypeB_Gra_02C_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SnowTypeB_Gra_02C_C : BP_MarchCubes_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D21 RID: 146721 RVA: 0x0092DDDD File Offset: 0x0092BFDD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTypeB_Gra_02C_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Gia_Gra_02C/BP_SnowTypeB_Gra_02C.BP_SnowTypeB_Gra_02C_C");
			}
			return BP_SnowTypeB_Gra_02C_C._ClassPtr;
		}

		// Token: 0x06023D22 RID: 146722 RVA: 0x0092DE04 File Offset: 0x0092C004
		public BP_SnowTypeB_Gra_02C_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeB_Gra_02C_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D23 RID: 146723 RVA: 0x0092DE2C File Offset: 0x0092C02C
		[NullableContext(1)]
		public BP_SnowTypeB_Gra_02C_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeB_Gra_02C_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043BD RID: 17341
		// (get) Token: 0x06023D24 RID: 146724 RVA: 0x0092DE5F File Offset: 0x0092C05F
		// (set) Token: 0x06023D25 RID: 146725 RVA: 0x0092DE73 File Offset: 0x0092C073
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_SnowTypeB
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeB_Gra_02C_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeB_Gra_02C_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023D26 RID: 146726 RVA: 0x0092DE88 File Offset: 0x0092C088
		protected BP_SnowTypeB_Gra_02C_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B5D RID: 72541
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Gia_Gra_02C/BP_SnowTypeB_Gra_02C.BP_SnowTypeB_Gra_02C_C";

		// Token: 0x04011B5E RID: 72542
		private static IntPtr _ClassPtr;

		// Token: 0x04011B5F RID: 72543
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B60 RID: 72544
		internal static int __PropertyOffset_0;
	}
}
