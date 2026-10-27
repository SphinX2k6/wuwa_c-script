using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow.TemplateSnow.SM_Com3_Veg_27
{
	// Token: 0x02003C5E RID: 15454
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_27/BP_SnowTypeB_Veg_27.BP_SnowTypeB_Veg_27_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SnowTypeB_Veg_27_C : BP_MarchCubes_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D57 RID: 146775 RVA: 0x0092E431 File Offset: 0x0092C631
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTypeB_Veg_27_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_27/BP_SnowTypeB_Veg_27.BP_SnowTypeB_Veg_27_C");
			}
			return BP_SnowTypeB_Veg_27_C._ClassPtr;
		}

		// Token: 0x06023D58 RID: 146776 RVA: 0x0092E458 File Offset: 0x0092C658
		public BP_SnowTypeB_Veg_27_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeB_Veg_27_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D59 RID: 146777 RVA: 0x0092E480 File Offset: 0x0092C680
		[NullableContext(1)]
		public BP_SnowTypeB_Veg_27_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeB_Veg_27_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043C6 RID: 17350
		// (get) Token: 0x06023D5A RID: 146778 RVA: 0x0092E4B3 File Offset: 0x0092C6B3
		// (set) Token: 0x06023D5B RID: 146779 RVA: 0x0092E4C7 File Offset: 0x0092C6C7
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_SnowTypeB
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeB_Veg_27_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeB_Veg_27_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023D5C RID: 146780 RVA: 0x0092E4DC File Offset: 0x0092C6DC
		protected BP_SnowTypeB_Veg_27_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B81 RID: 72577
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_27/BP_SnowTypeB_Veg_27.BP_SnowTypeB_Veg_27_C";

		// Token: 0x04011B82 RID: 72578
		private static IntPtr _ClassPtr;

		// Token: 0x04011B83 RID: 72579
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B84 RID: 72580
		internal static int __PropertyOffset_0;
	}
}
