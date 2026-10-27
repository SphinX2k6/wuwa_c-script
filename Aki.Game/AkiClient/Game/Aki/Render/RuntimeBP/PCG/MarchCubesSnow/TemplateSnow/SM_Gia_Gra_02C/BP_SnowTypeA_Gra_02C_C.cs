using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MarchCubesSnow.TemplateSnow.SM_Gia_Gra_02C
{
	// Token: 0x02003C54 RID: 15444
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Gia_Gra_02C/BP_SnowTypeA_Gra_02C.BP_SnowTypeA_Gra_02C_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_SnowTypeA_Gra_02C_C : BP_MarchCubes_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023D1B RID: 146715 RVA: 0x0092DD2A File Offset: 0x0092BF2A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTypeA_Gra_02C_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Gia_Gra_02C/BP_SnowTypeA_Gra_02C.BP_SnowTypeA_Gra_02C_C");
			}
			return BP_SnowTypeA_Gra_02C_C._ClassPtr;
		}

		// Token: 0x06023D1C RID: 146716 RVA: 0x0092DD50 File Offset: 0x0092BF50
		public BP_SnowTypeA_Gra_02C_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeA_Gra_02C_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023D1D RID: 146717 RVA: 0x0092DD78 File Offset: 0x0092BF78
		[NullableContext(1)]
		public BP_SnowTypeA_Gra_02C_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTypeA_Gra_02C_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043BC RID: 17340
		// (get) Token: 0x06023D1E RID: 146718 RVA: 0x0092DDAB File Offset: 0x0092BFAB
		// (set) Token: 0x06023D1F RID: 146719 RVA: 0x0092DDBF File Offset: 0x0092BFBF
		[Nullable(2)]
		public unsafe UStaticMeshComponent SM_SnowTypeA
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeA_Gra_02C_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTypeA_Gra_02C_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023D20 RID: 146720 RVA: 0x0092DDD4 File Offset: 0x0092BFD4
		protected BP_SnowTypeA_Gra_02C_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B59 RID: 72537
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MarchCubesSnow/TemplateSnow/SM_Gia_Gra_02C/BP_SnowTypeA_Gra_02C.BP_SnowTypeA_Gra_02C_C";

		// Token: 0x04011B5A RID: 72538
		private static IntPtr _ClassPtr;

		// Token: 0x04011B5B RID: 72539
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B5C RID: 72540
		internal static int __PropertyOffset_0;
	}
}
