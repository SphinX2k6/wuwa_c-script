using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B79 RID: 15225
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_3_3.BP_DollItem_3_3_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_DollItem_3_3_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E20 RID: 138784 RVA: 0x008F8886 File Offset: 0x008F6A86
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_3_3_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_3_3.BP_DollItem_3_3_C");
			}
			return BP_DollItem_3_3_C._ClassPtr;
		}

		// Token: 0x06021E21 RID: 138785 RVA: 0x008F88AC File Offset: 0x008F6AAC
		public BP_DollItem_3_3_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_3_3_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E22 RID: 138786 RVA: 0x008F88D4 File Offset: 0x008F6AD4
		[NullableContext(1)]
		public BP_DollItem_3_3_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_3_3_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038D3 RID: 14547
		// (get) Token: 0x06021E23 RID: 138787 RVA: 0x008F8907 File Offset: 0x008F6B07
		// (set) Token: 0x06021E24 RID: 138788 RVA: 0x008F891B File Offset: 0x008F6B1B
		public unsafe UPointLightComponent PointLight1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_3_3_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_3_3_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038D4 RID: 14548
		// (get) Token: 0x06021E25 RID: 138789 RVA: 0x008F8930 File Offset: 0x008F6B30
		// (set) Token: 0x06021E26 RID: 138790 RVA: 0x008F8944 File Offset: 0x008F6B44
		public unsafe USkeletalMeshComponent EpropJiwawa03DengMd10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_3_3_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_3_3_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021E27 RID: 138791 RVA: 0x008F8959 File Offset: 0x008F6B59
		protected BP_DollItem_3_3_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040108F0 RID: 67824
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_3_3.BP_DollItem_3_3_C";

		// Token: 0x040108F1 RID: 67825
		private static IntPtr _ClassPtr;

		// Token: 0x040108F2 RID: 67826
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040108F3 RID: 67827
		internal static int __PropertyOffset_0;

		// Token: 0x040108F4 RID: 67828
		internal new static int __PropertyOffset_1;
	}
}
