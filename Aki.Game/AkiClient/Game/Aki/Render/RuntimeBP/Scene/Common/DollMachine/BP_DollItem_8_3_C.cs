using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B88 RID: 15240
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_8_3.BP_DollItem_8_3_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_DollItem_8_3_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E9A RID: 138906 RVA: 0x008F9592 File Offset: 0x008F7792
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_8_3_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_8_3.BP_DollItem_8_3_C");
			}
			return BP_DollItem_8_3_C._ClassPtr;
		}

		// Token: 0x06021E9B RID: 138907 RVA: 0x008F95B8 File Offset: 0x008F77B8
		public BP_DollItem_8_3_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_8_3_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E9C RID: 138908 RVA: 0x008F95E0 File Offset: 0x008F77E0
		[NullableContext(1)]
		public BP_DollItem_8_3_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_8_3_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038F2 RID: 14578
		// (get) Token: 0x06021E9D RID: 138909 RVA: 0x008F9613 File Offset: 0x008F7813
		// (set) Token: 0x06021E9E RID: 138910 RVA: 0x008F9627 File Offset: 0x008F7827
		public unsafe UPointLightComponent PointLight1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_8_3_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_8_3_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038F3 RID: 14579
		// (get) Token: 0x06021E9F RID: 138911 RVA: 0x008F963C File Offset: 0x008F783C
		// (set) Token: 0x06021EA0 RID: 138912 RVA: 0x008F9650 File Offset: 0x008F7850
		public unsafe USkeletalMeshComponent EpropJiwawa08YinchaMd10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_8_3_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_8_3_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021EA1 RID: 138913 RVA: 0x008F9665 File Offset: 0x008F7865
		protected BP_DollItem_8_3_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401093C RID: 67900
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_8_3.BP_DollItem_8_3_C";

		// Token: 0x0401093D RID: 67901
		private static IntPtr _ClassPtr;

		// Token: 0x0401093E RID: 67902
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401093F RID: 67903
		internal static int __PropertyOffset_0;

		// Token: 0x04010940 RID: 67904
		internal new static int __PropertyOffset_1;
	}
}
