using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow.TemplateSnow.SM_Gia_Gra_02C
{
	// Token: 0x02003C56 RID: 15446
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Gia_Gra_02C/BP_SnowTypeC_Gra_02C.BP_SnowTypeC_Gra_02C_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SnowTypeC_Gra_02C_C : BP_MarchCubes_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D27 RID: 146727 RVA: 0x0092DE91 File Offset: 0x0092C091
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTypeC_Gra_02C_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Gia_Gra_02C/BP_SnowTypeC_Gra_02C.BP_SnowTypeC_Gra_02C_C");
			}
			return BP_SnowTypeC_Gra_02C_C._ClassPtr;
		}

		// Token: 0x06023D28 RID: 146728 RVA: 0x0092DEB8 File Offset: 0x0092C0B8
		public BP_SnowTypeC_Gra_02C_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeC_Gra_02C_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D29 RID: 146729 RVA: 0x0092DEE0 File Offset: 0x0092C0E0
		[NullableContext(1)]
		public BP_SnowTypeC_Gra_02C_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeC_Gra_02C_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043BE RID: 17342
		// (get) Token: 0x06023D2A RID: 146730 RVA: 0x0092DF13 File Offset: 0x0092C113
		// (set) Token: 0x06023D2B RID: 146731 RVA: 0x0092DF27 File Offset: 0x0092C127
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_SnowTypeD
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeC_Gra_02C_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeC_Gra_02C_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023D2C RID: 146732 RVA: 0x0092DF3C File Offset: 0x0092C13C
		protected BP_SnowTypeC_Gra_02C_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B61 RID: 72545
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Gia_Gra_02C/BP_SnowTypeC_Gra_02C.BP_SnowTypeC_Gra_02C_C";

		// Token: 0x04011B62 RID: 72546
		private static IntPtr _ClassPtr;

		// Token: 0x04011B63 RID: 72547
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B64 RID: 72548
		internal static int __PropertyOffset_0;
	}
}
