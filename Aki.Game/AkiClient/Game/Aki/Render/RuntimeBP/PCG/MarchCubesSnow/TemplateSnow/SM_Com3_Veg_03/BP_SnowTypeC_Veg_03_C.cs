using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow.TemplateSnow.SM_Com3_Veg_03
{
	// Token: 0x02003C68 RID: 15464
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_03/BP_SnowTypeC_Veg_03.BP_SnowTypeC_Veg_03_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SnowTypeC_Veg_03_C : BP_MarchCubes_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D93 RID: 146835 RVA: 0x0092EB39 File Offset: 0x0092CD39
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTypeC_Veg_03_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_03/BP_SnowTypeC_Veg_03.BP_SnowTypeC_Veg_03_C");
			}
			return BP_SnowTypeC_Veg_03_C._ClassPtr;
		}

		// Token: 0x06023D94 RID: 146836 RVA: 0x0092EB60 File Offset: 0x0092CD60
		public BP_SnowTypeC_Veg_03_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeC_Veg_03_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D95 RID: 146837 RVA: 0x0092EB88 File Offset: 0x0092CD88
		[NullableContext(1)]
		public BP_SnowTypeC_Veg_03_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeC_Veg_03_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043D0 RID: 17360
		// (get) Token: 0x06023D96 RID: 146838 RVA: 0x0092EBBB File Offset: 0x0092CDBB
		// (set) Token: 0x06023D97 RID: 146839 RVA: 0x0092EBCF File Offset: 0x0092CDCF
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_SnowTypeC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeC_Veg_03_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeC_Veg_03_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023D98 RID: 146840 RVA: 0x0092EBE4 File Offset: 0x0092CDE4
		protected BP_SnowTypeC_Veg_03_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011BA9 RID: 72617
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_03/BP_SnowTypeC_Veg_03.BP_SnowTypeC_Veg_03_C";

		// Token: 0x04011BAA RID: 72618
		private static IntPtr _ClassPtr;

		// Token: 0x04011BAB RID: 72619
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011BAC RID: 72620
		internal static int __PropertyOffset_0;
	}
}
