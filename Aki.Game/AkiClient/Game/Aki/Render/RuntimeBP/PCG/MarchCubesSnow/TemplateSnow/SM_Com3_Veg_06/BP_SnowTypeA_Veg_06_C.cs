using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow.TemplateSnow.SM_Com3_Veg_06
{
	// Token: 0x02003C63 RID: 15459
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_06/BP_SnowTypeA_Veg_06.BP_SnowTypeA_Veg_06_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SnowTypeA_Veg_06_C : BP_MarchCubes_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D75 RID: 146805 RVA: 0x0092E7B5 File Offset: 0x0092C9B5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTypeA_Veg_06_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_06/BP_SnowTypeA_Veg_06.BP_SnowTypeA_Veg_06_C");
			}
			return BP_SnowTypeA_Veg_06_C._ClassPtr;
		}

		// Token: 0x06023D76 RID: 146806 RVA: 0x0092E7DC File Offset: 0x0092C9DC
		public BP_SnowTypeA_Veg_06_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeA_Veg_06_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D77 RID: 146807 RVA: 0x0092E804 File Offset: 0x0092CA04
		[NullableContext(1)]
		public BP_SnowTypeA_Veg_06_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeA_Veg_06_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043CB RID: 17355
		// (get) Token: 0x06023D78 RID: 146808 RVA: 0x0092E837 File Offset: 0x0092CA37
		// (set) Token: 0x06023D79 RID: 146809 RVA: 0x0092E84B File Offset: 0x0092CA4B
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_SnowTypeA
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeA_Veg_06_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeA_Veg_06_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023D7A RID: 146810 RVA: 0x0092E860 File Offset: 0x0092CA60
		protected BP_SnowTypeA_Veg_06_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B95 RID: 72597
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_06/BP_SnowTypeA_Veg_06.BP_SnowTypeA_Veg_06_C";

		// Token: 0x04011B96 RID: 72598
		private static IntPtr _ClassPtr;

		// Token: 0x04011B97 RID: 72599
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B98 RID: 72600
		internal static int __PropertyOffset_0;
	}
}
