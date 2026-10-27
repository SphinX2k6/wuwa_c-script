using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B71 RID: 15217
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_1_1.BP_DollItem_1_1_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_DollItem_1_1_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021DE0 RID: 138720 RVA: 0x008F81A5 File Offset: 0x008F63A5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_1_1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_1_1.BP_DollItem_1_1_C");
			}
			return BP_DollItem_1_1_C._ClassPtr;
		}

		// Token: 0x06021DE1 RID: 138721 RVA: 0x008F81CC File Offset: 0x008F63CC
		public BP_DollItem_1_1_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_1_1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021DE2 RID: 138722 RVA: 0x008F81F4 File Offset: 0x008F63F4
		[NullableContext(1)]
		public BP_DollItem_1_1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_1_1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038C3 RID: 14531
		// (get) Token: 0x06021DE3 RID: 138723 RVA: 0x008F8227 File Offset: 0x008F6427
		// (set) Token: 0x06021DE4 RID: 138724 RVA: 0x008F823B File Offset: 0x008F643B
		public unsafe USkeletalMeshComponent EpropJiwawa01Md10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_1_1_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_1_1_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038C4 RID: 14532
		// (get) Token: 0x06021DE5 RID: 138725 RVA: 0x008F8250 File Offset: 0x008F6450
		// (set) Token: 0x06021DE6 RID: 138726 RVA: 0x008F8264 File Offset: 0x008F6464
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_1_1_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_1_1_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021DE7 RID: 138727 RVA: 0x008F8279 File Offset: 0x008F6479
		protected BP_DollItem_1_1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040108C8 RID: 67784
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_1_1.BP_DollItem_1_1_C";

		// Token: 0x040108C9 RID: 67785
		private static IntPtr _ClassPtr;

		// Token: 0x040108CA RID: 67786
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040108CB RID: 67787
		internal static int __PropertyOffset_0;

		// Token: 0x040108CC RID: 67788
		internal new static int __PropertyOffset_1;
	}
}
