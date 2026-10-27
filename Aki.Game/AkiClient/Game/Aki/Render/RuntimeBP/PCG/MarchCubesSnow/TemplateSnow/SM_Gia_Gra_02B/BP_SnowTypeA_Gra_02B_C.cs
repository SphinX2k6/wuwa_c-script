using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow.TemplateSnow.SM_Gia_Gra_02B
{
	// Token: 0x02003C57 RID: 15447
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Gia_Gra_02B/BP_SnowTypeA_Gra_02B.BP_SnowTypeA_Gra_02B_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SnowTypeA_Gra_02B_C : BP_MarchCubes_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D2D RID: 146733 RVA: 0x0092DF45 File Offset: 0x0092C145
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTypeA_Gra_02B_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Gia_Gra_02B/BP_SnowTypeA_Gra_02B.BP_SnowTypeA_Gra_02B_C");
			}
			return BP_SnowTypeA_Gra_02B_C._ClassPtr;
		}

		// Token: 0x06023D2E RID: 146734 RVA: 0x0092DF6C File Offset: 0x0092C16C
		public BP_SnowTypeA_Gra_02B_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeA_Gra_02B_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D2F RID: 146735 RVA: 0x0092DF94 File Offset: 0x0092C194
		[NullableContext(1)]
		public BP_SnowTypeA_Gra_02B_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeA_Gra_02B_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043BF RID: 17343
		// (get) Token: 0x06023D30 RID: 146736 RVA: 0x0092DFC7 File Offset: 0x0092C1C7
		// (set) Token: 0x06023D31 RID: 146737 RVA: 0x0092DFDB File Offset: 0x0092C1DB
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_SnowTypeD
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeA_Gra_02B_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeA_Gra_02B_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023D32 RID: 146738 RVA: 0x0092DFF0 File Offset: 0x0092C1F0
		protected BP_SnowTypeA_Gra_02B_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B65 RID: 72549
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Gia_Gra_02B/BP_SnowTypeA_Gra_02B.BP_SnowTypeA_Gra_02B_C";

		// Token: 0x04011B66 RID: 72550
		private static IntPtr _ClassPtr;

		// Token: 0x04011B67 RID: 72551
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B68 RID: 72552
		internal static int __PropertyOffset_0;
	}
}
