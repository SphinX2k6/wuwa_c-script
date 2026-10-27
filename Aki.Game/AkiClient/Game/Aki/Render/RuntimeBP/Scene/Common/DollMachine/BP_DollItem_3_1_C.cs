using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B77 RID: 15223
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_3_1.BP_DollItem_3_1_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_DollItem_3_1_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E10 RID: 138768 RVA: 0x008F86CE File Offset: 0x008F68CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_3_1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_3_1.BP_DollItem_3_1_C");
			}
			return BP_DollItem_3_1_C._ClassPtr;
		}

		// Token: 0x06021E11 RID: 138769 RVA: 0x008F86F4 File Offset: 0x008F68F4
		public BP_DollItem_3_1_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_3_1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E12 RID: 138770 RVA: 0x008F871C File Offset: 0x008F691C
		[NullableContext(1)]
		public BP_DollItem_3_1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_3_1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038CF RID: 14543
		// (get) Token: 0x06021E13 RID: 138771 RVA: 0x008F874F File Offset: 0x008F694F
		// (set) Token: 0x06021E14 RID: 138772 RVA: 0x008F8763 File Offset: 0x008F6963
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_3_1_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_3_1_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038D0 RID: 14544
		// (get) Token: 0x06021E15 RID: 138773 RVA: 0x008F8778 File Offset: 0x008F6978
		// (set) Token: 0x06021E16 RID: 138774 RVA: 0x008F878C File Offset: 0x008F698C
		public unsafe USkeletalMeshComponent EpropJiwawa03Md10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_3_1_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_3_1_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021E17 RID: 138775 RVA: 0x008F87A1 File Offset: 0x008F69A1
		protected BP_DollItem_3_1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040108E6 RID: 67814
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_3_1.BP_DollItem_3_1_C";

		// Token: 0x040108E7 RID: 67815
		private static IntPtr _ClassPtr;

		// Token: 0x040108E8 RID: 67816
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040108E9 RID: 67817
		internal static int __PropertyOffset_0;

		// Token: 0x040108EA RID: 67818
		internal new static int __PropertyOffset_1;
	}
}
