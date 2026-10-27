using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow.TemplateSnow.SM_Com3_Veg_50
{
	// Token: 0x02003C5B RID: 15451
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_50/BP_SnowTypeB_Veg_50AS.BP_SnowTypeB_Veg_50AS_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SnowTypeB_Veg_50AS_C : BP_MarchCubes_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D45 RID: 146757 RVA: 0x0092E215 File Offset: 0x0092C415
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTypeB_Veg_50AS_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_50/BP_SnowTypeB_Veg_50AS.BP_SnowTypeB_Veg_50AS_C");
			}
			return BP_SnowTypeB_Veg_50AS_C._ClassPtr;
		}

		// Token: 0x06023D46 RID: 146758 RVA: 0x0092E23C File Offset: 0x0092C43C
		public BP_SnowTypeB_Veg_50AS_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeB_Veg_50AS_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D47 RID: 146759 RVA: 0x0092E264 File Offset: 0x0092C464
		[NullableContext(1)]
		public BP_SnowTypeB_Veg_50AS_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeB_Veg_50AS_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043C3 RID: 17347
		// (get) Token: 0x06023D48 RID: 146760 RVA: 0x0092E297 File Offset: 0x0092C497
		// (set) Token: 0x06023D49 RID: 146761 RVA: 0x0092E2AB File Offset: 0x0092C4AB
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_SnowTypeB
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeB_Veg_50AS_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeB_Veg_50AS_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023D4A RID: 146762 RVA: 0x0092E2C0 File Offset: 0x0092C4C0
		protected BP_SnowTypeB_Veg_50AS_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B75 RID: 72565
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_50/BP_SnowTypeB_Veg_50AS.BP_SnowTypeB_Veg_50AS_C";

		// Token: 0x04011B76 RID: 72566
		private static IntPtr _ClassPtr;

		// Token: 0x04011B77 RID: 72567
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B78 RID: 72568
		internal static int __PropertyOffset_0;
	}
}
