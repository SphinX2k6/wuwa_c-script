using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B7D RID: 15229
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_5_1.BP_DollItem_5_1_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_DollItem_5_1_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E42 RID: 138818 RVA: 0x008F8C1E File Offset: 0x008F6E1E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_5_1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_5_1.BP_DollItem_5_1_C");
			}
			return BP_DollItem_5_1_C._ClassPtr;
		}

		// Token: 0x06021E43 RID: 138819 RVA: 0x008F8C44 File Offset: 0x008F6E44
		public BP_DollItem_5_1_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_5_1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E44 RID: 138820 RVA: 0x008F8C6C File Offset: 0x008F6E6C
		[NullableContext(1)]
		public BP_DollItem_5_1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_5_1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038DC RID: 14556
		// (get) Token: 0x06021E45 RID: 138821 RVA: 0x008F8C9F File Offset: 0x008F6E9F
		// (set) Token: 0x06021E46 RID: 138822 RVA: 0x008F8CB3 File Offset: 0x008F6EB3
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_5_1_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_5_1_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038DD RID: 14557
		// (get) Token: 0x06021E47 RID: 138823 RVA: 0x008F8CC8 File Offset: 0x008F6EC8
		// (set) Token: 0x06021E48 RID: 138824 RVA: 0x008F8CDC File Offset: 0x008F6EDC
		public unsafe USkeletalMeshComponent EpropJiwawa05Md10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_5_1_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_5_1_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021E49 RID: 138825 RVA: 0x008F8CF1 File Offset: 0x008F6EF1
		protected BP_DollItem_5_1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010905 RID: 67845
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_5_1.BP_DollItem_5_1_C";

		// Token: 0x04010906 RID: 67846
		private static IntPtr _ClassPtr;

		// Token: 0x04010907 RID: 67847
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010908 RID: 67848
		internal static int __PropertyOffset_0;

		// Token: 0x04010909 RID: 67849
		internal new static int __PropertyOffset_1;
	}
}
