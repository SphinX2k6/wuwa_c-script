using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow.TemplateSnow.SM_Com3_Veg_50
{
	// Token: 0x02003C5C RID: 15452
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_50/BP_SnowTypeC_Veg_50AS.BP_SnowTypeC_Veg_50AS_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SnowTypeC_Veg_50AS_C : BP_MarchCubes_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D4B RID: 146763 RVA: 0x0092E2C9 File Offset: 0x0092C4C9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTypeC_Veg_50AS_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_50/BP_SnowTypeC_Veg_50AS.BP_SnowTypeC_Veg_50AS_C");
			}
			return BP_SnowTypeC_Veg_50AS_C._ClassPtr;
		}

		// Token: 0x06023D4C RID: 146764 RVA: 0x0092E2F0 File Offset: 0x0092C4F0
		public BP_SnowTypeC_Veg_50AS_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeC_Veg_50AS_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D4D RID: 146765 RVA: 0x0092E318 File Offset: 0x0092C518
		[NullableContext(1)]
		public BP_SnowTypeC_Veg_50AS_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeC_Veg_50AS_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043C4 RID: 17348
		// (get) Token: 0x06023D4E RID: 146766 RVA: 0x0092E34B File Offset: 0x0092C54B
		// (set) Token: 0x06023D4F RID: 146767 RVA: 0x0092E35F File Offset: 0x0092C55F
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_SnowTypeC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeC_Veg_50AS_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeC_Veg_50AS_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023D50 RID: 146768 RVA: 0x0092E374 File Offset: 0x0092C574
		protected BP_SnowTypeC_Veg_50AS_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B79 RID: 72569
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_50/BP_SnowTypeC_Veg_50AS.BP_SnowTypeC_Veg_50AS_C";

		// Token: 0x04011B7A RID: 72570
		private static IntPtr _ClassPtr;

		// Token: 0x04011B7B RID: 72571
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B7C RID: 72572
		internal static int __PropertyOffset_0;
	}
}
