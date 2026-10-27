using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B7B RID: 15227
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_4_2.BP_DollItem_4_2_C")]
	[UnrealStructLayout(1688, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1688)]
	public class BP_DollItem_4_2_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E30 RID: 138800 RVA: 0x008F8A3E File Offset: 0x008F6C3E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_4_2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_4_2.BP_DollItem_4_2_C");
			}
			return BP_DollItem_4_2_C._ClassPtr;
		}

		// Token: 0x06021E31 RID: 138801 RVA: 0x008F8A64 File Offset: 0x008F6C64
		public BP_DollItem_4_2_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_4_2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E32 RID: 138802 RVA: 0x008F8A8C File Offset: 0x008F6C8C
		[NullableContext(1)]
		public BP_DollItem_4_2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_4_2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038D7 RID: 14551
		// (get) Token: 0x06021E33 RID: 138803 RVA: 0x008F8ABF File Offset: 0x008F6CBF
		// (set) Token: 0x06021E34 RID: 138804 RVA: 0x008F8AD3 File Offset: 0x008F6CD3
		public unsafe USkeletalMeshComponent EpropJiwawa04YulouMd10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_4_2_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_4_2_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038D8 RID: 14552
		// (get) Token: 0x06021E35 RID: 138805 RVA: 0x008F8AE8 File Offset: 0x008F6CE8
		// (set) Token: 0x06021E36 RID: 138806 RVA: 0x008F8AFC File Offset: 0x008F6CFC
		public unsafe UPointLightComponent PointLight1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_4_2_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_4_2_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170038D9 RID: 14553
		// (get) Token: 0x06021E37 RID: 138807 RVA: 0x008F8B11 File Offset: 0x008F6D11
		// (set) Token: 0x06021E38 RID: 138808 RVA: 0x008F8B25 File Offset: 0x008F6D25
		public unsafe USkeletalMeshComponent EpropJiwawa04YujuMd10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_4_2_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_4_2_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x06021E39 RID: 138809 RVA: 0x008F8B3A File Offset: 0x008F6D3A
		protected BP_DollItem_4_2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040108FA RID: 67834
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_4_2.BP_DollItem_4_2_C";

		// Token: 0x040108FB RID: 67835
		private static IntPtr _ClassPtr;

		// Token: 0x040108FC RID: 67836
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040108FD RID: 67837
		internal static int __PropertyOffset_0;

		// Token: 0x040108FE RID: 67838
		internal new static int __PropertyOffset_1;

		// Token: 0x040108FF RID: 67839
		internal new static int __PropertyOffset_2;
	}
}
