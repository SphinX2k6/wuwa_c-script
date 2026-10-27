using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow.TemplateSnow.SM_Com3_Veg_50
{
	// Token: 0x02003C5A RID: 15450
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_50/BP_SnowTypeA_Veg_50AS.BP_SnowTypeA_Veg_50AS_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SnowTypeA_Veg_50AS_C : BP_MarchCubes_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D3F RID: 146751 RVA: 0x0092E161 File Offset: 0x0092C361
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTypeA_Veg_50AS_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_50/BP_SnowTypeA_Veg_50AS.BP_SnowTypeA_Veg_50AS_C");
			}
			return BP_SnowTypeA_Veg_50AS_C._ClassPtr;
		}

		// Token: 0x06023D40 RID: 146752 RVA: 0x0092E188 File Offset: 0x0092C388
		public BP_SnowTypeA_Veg_50AS_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeA_Veg_50AS_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D41 RID: 146753 RVA: 0x0092E1B0 File Offset: 0x0092C3B0
		[NullableContext(1)]
		public BP_SnowTypeA_Veg_50AS_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeA_Veg_50AS_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043C2 RID: 17346
		// (get) Token: 0x06023D42 RID: 146754 RVA: 0x0092E1E3 File Offset: 0x0092C3E3
		// (set) Token: 0x06023D43 RID: 146755 RVA: 0x0092E1F7 File Offset: 0x0092C3F7
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_SnowTypeA
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeA_Veg_50AS_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeA_Veg_50AS_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023D44 RID: 146756 RVA: 0x0092E20C File Offset: 0x0092C40C
		protected BP_SnowTypeA_Veg_50AS_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B71 RID: 72561
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Com3_Veg_50/BP_SnowTypeA_Veg_50AS.BP_SnowTypeA_Veg_50AS_C";

		// Token: 0x04011B72 RID: 72562
		private static IntPtr _ClassPtr;

		// Token: 0x04011B73 RID: 72563
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B74 RID: 72564
		internal static int __PropertyOffset_0;
	}
}
