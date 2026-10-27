using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow.TemplateSnow.SM_Com3_Veg_12
{
	// Token: 0x02003C62 RID: 15458
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_12/BP_SnowTypeC_Veg_12.BP_SnowTypeC_Veg_12_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SnowTypeC_Veg_12_C : BP_MarchCubes_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D6F RID: 146799 RVA: 0x0092E701 File Offset: 0x0092C901
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTypeC_Veg_12_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_12/BP_SnowTypeC_Veg_12.BP_SnowTypeC_Veg_12_C");
			}
			return BP_SnowTypeC_Veg_12_C._ClassPtr;
		}

		// Token: 0x06023D70 RID: 146800 RVA: 0x0092E728 File Offset: 0x0092C928
		public BP_SnowTypeC_Veg_12_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeC_Veg_12_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D71 RID: 146801 RVA: 0x0092E750 File Offset: 0x0092C950
		[NullableContext(1)]
		public BP_SnowTypeC_Veg_12_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeC_Veg_12_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043CA RID: 17354
		// (get) Token: 0x06023D72 RID: 146802 RVA: 0x0092E783 File Offset: 0x0092C983
		// (set) Token: 0x06023D73 RID: 146803 RVA: 0x0092E797 File Offset: 0x0092C997
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_SnowTypeC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeC_Veg_12_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeC_Veg_12_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023D74 RID: 146804 RVA: 0x0092E7AC File Offset: 0x0092C9AC
		protected BP_SnowTypeC_Veg_12_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B91 RID: 72593
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_12/BP_SnowTypeC_Veg_12.BP_SnowTypeC_Veg_12_C";

		// Token: 0x04011B92 RID: 72594
		private static IntPtr _ClassPtr;

		// Token: 0x04011B93 RID: 72595
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B94 RID: 72596
		internal static int __PropertyOffset_0;
	}
}
