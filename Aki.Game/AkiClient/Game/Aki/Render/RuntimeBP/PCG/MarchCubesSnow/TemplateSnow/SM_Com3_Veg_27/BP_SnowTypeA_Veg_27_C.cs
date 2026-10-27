using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow.TemplateSnow.SM_Com3_Veg_27
{
	// Token: 0x02003C5D RID: 15453
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_27/BP_SnowTypeA_Veg_27.BP_SnowTypeA_Veg_27_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SnowTypeA_Veg_27_C : BP_MarchCubes_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D51 RID: 146769 RVA: 0x0092E37D File Offset: 0x0092C57D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTypeA_Veg_27_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_27/BP_SnowTypeA_Veg_27.BP_SnowTypeA_Veg_27_C");
			}
			return BP_SnowTypeA_Veg_27_C._ClassPtr;
		}

		// Token: 0x06023D52 RID: 146770 RVA: 0x0092E3A4 File Offset: 0x0092C5A4
		public BP_SnowTypeA_Veg_27_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeA_Veg_27_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D53 RID: 146771 RVA: 0x0092E3CC File Offset: 0x0092C5CC
		[NullableContext(1)]
		public BP_SnowTypeA_Veg_27_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeA_Veg_27_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043C5 RID: 17349
		// (get) Token: 0x06023D54 RID: 146772 RVA: 0x0092E3FF File Offset: 0x0092C5FF
		// (set) Token: 0x06023D55 RID: 146773 RVA: 0x0092E413 File Offset: 0x0092C613
		[Nullable(2)]
		public unsafe UStaticMeshComponent SnowTypeA
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeA_Veg_27_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeA_Veg_27_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023D56 RID: 146774 RVA: 0x0092E428 File Offset: 0x0092C628
		protected BP_SnowTypeA_Veg_27_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B7D RID: 72573
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_27/BP_SnowTypeA_Veg_27.BP_SnowTypeA_Veg_27_C";

		// Token: 0x04011B7E RID: 72574
		private static IntPtr _ClassPtr;

		// Token: 0x04011B7F RID: 72575
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B80 RID: 72576
		internal static int __PropertyOffset_0;
	}
}
