using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow.TemplateSnow.SM_Gia_Gra_02B
{
	// Token: 0x02003C59 RID: 15449
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Gia_Gra_02B/BP_SnowTypeC_Gra_02B.BP_SnowTypeC_Gra_02B_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SnowTypeC_Gra_02B_C : BP_MarchCubes_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D39 RID: 146745 RVA: 0x0092E0AD File Offset: 0x0092C2AD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTypeC_Gra_02B_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Gia_Gra_02B/BP_SnowTypeC_Gra_02B.BP_SnowTypeC_Gra_02B_C");
			}
			return BP_SnowTypeC_Gra_02B_C._ClassPtr;
		}

		// Token: 0x06023D3A RID: 146746 RVA: 0x0092E0D4 File Offset: 0x0092C2D4
		public BP_SnowTypeC_Gra_02B_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeC_Gra_02B_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D3B RID: 146747 RVA: 0x0092E0FC File Offset: 0x0092C2FC
		[NullableContext(1)]
		public BP_SnowTypeC_Gra_02B_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeC_Gra_02B_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043C1 RID: 17345
		// (get) Token: 0x06023D3C RID: 146748 RVA: 0x0092E12F File Offset: 0x0092C32F
		// (set) Token: 0x06023D3D RID: 146749 RVA: 0x0092E143 File Offset: 0x0092C343
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_SnowTypeF
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeC_Gra_02B_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeC_Gra_02B_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023D3E RID: 146750 RVA: 0x0092E158 File Offset: 0x0092C358
		protected BP_SnowTypeC_Gra_02B_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B6D RID: 72557
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Gia_Gra_02B/BP_SnowTypeC_Gra_02B.BP_SnowTypeC_Gra_02B_C";

		// Token: 0x04011B6E RID: 72558
		private static IntPtr _ClassPtr;

		// Token: 0x04011B6F RID: 72559
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B70 RID: 72560
		internal static int __PropertyOffset_0;
	}
}
