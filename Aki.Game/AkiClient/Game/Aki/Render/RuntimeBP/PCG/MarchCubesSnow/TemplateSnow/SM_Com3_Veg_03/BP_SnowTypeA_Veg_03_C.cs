using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow.TemplateSnow.SM_Com3_Veg_03
{
	// Token: 0x02003C66 RID: 15462
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_03/BP_SnowTypeA_Veg_03.BP_SnowTypeA_Veg_03_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SnowTypeA_Veg_03_C : BP_MarchCubes_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D87 RID: 146823 RVA: 0x0092E9D1 File Offset: 0x0092CBD1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTypeA_Veg_03_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_03/BP_SnowTypeA_Veg_03.BP_SnowTypeA_Veg_03_C");
			}
			return BP_SnowTypeA_Veg_03_C._ClassPtr;
		}

		// Token: 0x06023D88 RID: 146824 RVA: 0x0092E9F8 File Offset: 0x0092CBF8
		public BP_SnowTypeA_Veg_03_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeA_Veg_03_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D89 RID: 146825 RVA: 0x0092EA20 File Offset: 0x0092CC20
		[NullableContext(1)]
		public BP_SnowTypeA_Veg_03_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeA_Veg_03_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043CE RID: 17358
		// (get) Token: 0x06023D8A RID: 146826 RVA: 0x0092EA53 File Offset: 0x0092CC53
		// (set) Token: 0x06023D8B RID: 146827 RVA: 0x0092EA67 File Offset: 0x0092CC67
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_SnowTypeA
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeA_Veg_03_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeA_Veg_03_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023D8C RID: 146828 RVA: 0x0092EA7C File Offset: 0x0092CC7C
		protected BP_SnowTypeA_Veg_03_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011BA1 RID: 72609
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_03/BP_SnowTypeA_Veg_03.BP_SnowTypeA_Veg_03_C";

		// Token: 0x04011BA2 RID: 72610
		private static IntPtr _ClassPtr;

		// Token: 0x04011BA3 RID: 72611
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011BA4 RID: 72612
		internal static int __PropertyOffset_0;
	}
}
