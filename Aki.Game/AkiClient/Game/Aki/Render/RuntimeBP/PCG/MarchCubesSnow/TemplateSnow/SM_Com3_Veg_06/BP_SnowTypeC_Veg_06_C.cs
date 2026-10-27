using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow.TemplateSnow.SM_Com3_Veg_06
{
	// Token: 0x02003C65 RID: 15461
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_06/BP_SnowTypeC_Veg_06.BP_SnowTypeC_Veg_06_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SnowTypeC_Veg_06_C : BP_MarchCubes_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D81 RID: 146817 RVA: 0x0092E91D File Offset: 0x0092CB1D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTypeC_Veg_06_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_06/BP_SnowTypeC_Veg_06.BP_SnowTypeC_Veg_06_C");
			}
			return BP_SnowTypeC_Veg_06_C._ClassPtr;
		}

		// Token: 0x06023D82 RID: 146818 RVA: 0x0092E944 File Offset: 0x0092CB44
		public BP_SnowTypeC_Veg_06_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeC_Veg_06_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D83 RID: 146819 RVA: 0x0092E96C File Offset: 0x0092CB6C
		[NullableContext(1)]
		public BP_SnowTypeC_Veg_06_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeC_Veg_06_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043CD RID: 17357
		// (get) Token: 0x06023D84 RID: 146820 RVA: 0x0092E99F File Offset: 0x0092CB9F
		// (set) Token: 0x06023D85 RID: 146821 RVA: 0x0092E9B3 File Offset: 0x0092CBB3
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_SnowTypeC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeC_Veg_06_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeC_Veg_06_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023D86 RID: 146822 RVA: 0x0092E9C8 File Offset: 0x0092CBC8
		protected BP_SnowTypeC_Veg_06_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B9D RID: 72605
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_06/BP_SnowTypeC_Veg_06.BP_SnowTypeC_Veg_06_C";

		// Token: 0x04011B9E RID: 72606
		private static IntPtr _ClassPtr;

		// Token: 0x04011B9F RID: 72607
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011BA0 RID: 72608
		internal static int __PropertyOffset_0;
	}
}
