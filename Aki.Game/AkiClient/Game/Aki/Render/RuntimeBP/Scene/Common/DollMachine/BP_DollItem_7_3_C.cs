using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B85 RID: 15237
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_7_3.BP_DollItem_7_3_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_DollItem_7_3_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E82 RID: 138882 RVA: 0x008F92FE File Offset: 0x008F74FE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_7_3_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_7_3.BP_DollItem_7_3_C");
			}
			return BP_DollItem_7_3_C._ClassPtr;
		}

		// Token: 0x06021E83 RID: 138883 RVA: 0x008F9324 File Offset: 0x008F7524
		public BP_DollItem_7_3_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_7_3_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E84 RID: 138884 RVA: 0x008F934C File Offset: 0x008F754C
		[NullableContext(1)]
		public BP_DollItem_7_3_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_7_3_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038EC RID: 14572
		// (get) Token: 0x06021E85 RID: 138885 RVA: 0x008F937F File Offset: 0x008F757F
		// (set) Token: 0x06021E86 RID: 138886 RVA: 0x008F9393 File Offset: 0x008F7593
		public unsafe UPointLightComponent PointLight1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_7_3_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_7_3_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038ED RID: 14573
		// (get) Token: 0x06021E87 RID: 138887 RVA: 0x008F93A8 File Offset: 0x008F75A8
		// (set) Token: 0x06021E88 RID: 138888 RVA: 0x008F93BC File Offset: 0x008F75BC
		public unsafe USkeletalMeshComponent EpropJiwawa07DitaiMd10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_7_3_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_7_3_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021E89 RID: 138889 RVA: 0x008F93D1 File Offset: 0x008F75D1
		protected BP_DollItem_7_3_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401092D RID: 67885
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_7_3.BP_DollItem_7_3_C";

		// Token: 0x0401092E RID: 67886
		private static IntPtr _ClassPtr;

		// Token: 0x0401092F RID: 67887
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010930 RID: 67888
		internal static int __PropertyOffset_0;

		// Token: 0x04010931 RID: 67889
		internal new static int __PropertyOffset_1;
	}
}
