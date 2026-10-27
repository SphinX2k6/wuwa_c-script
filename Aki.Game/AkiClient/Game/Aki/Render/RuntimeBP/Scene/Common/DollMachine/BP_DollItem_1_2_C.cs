using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B72 RID: 15218
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_1_2.BP_DollItem_1_2_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_DollItem_1_2_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021DE8 RID: 138728 RVA: 0x008F8282 File Offset: 0x008F6482
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_1_2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_1_2.BP_DollItem_1_2_C");
			}
			return BP_DollItem_1_2_C._ClassPtr;
		}

		// Token: 0x06021DE9 RID: 138729 RVA: 0x008F82A8 File Offset: 0x008F64A8
		public BP_DollItem_1_2_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_1_2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021DEA RID: 138730 RVA: 0x008F82D0 File Offset: 0x008F64D0
		[NullableContext(1)]
		public BP_DollItem_1_2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_1_2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038C5 RID: 14533
		// (get) Token: 0x06021DEB RID: 138731 RVA: 0x008F8303 File Offset: 0x008F6503
		// (set) Token: 0x06021DEC RID: 138732 RVA: 0x008F8317 File Offset: 0x008F6517
		public unsafe USkeletalMeshComponent EpropJiwawa01LDoorMd10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_1_2_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_1_2_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038C6 RID: 14534
		// (get) Token: 0x06021DED RID: 138733 RVA: 0x008F832C File Offset: 0x008F652C
		// (set) Token: 0x06021DEE RID: 138734 RVA: 0x008F8340 File Offset: 0x008F6540
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_1_2_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_1_2_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021DEF RID: 138735 RVA: 0x008F8355 File Offset: 0x008F6555
		protected BP_DollItem_1_2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040108CD RID: 67789
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_1_2.BP_DollItem_1_2_C";

		// Token: 0x040108CE RID: 67790
		private static IntPtr _ClassPtr;

		// Token: 0x040108CF RID: 67791
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040108D0 RID: 67792
		internal static int __PropertyOffset_0;

		// Token: 0x040108D1 RID: 67793
		internal new static int __PropertyOffset_1;
	}
}
