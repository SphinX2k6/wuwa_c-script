using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B84 RID: 15236
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_7_2.BP_DollItem_7_2_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_DollItem_7_2_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E7A RID: 138874 RVA: 0x008F9222 File Offset: 0x008F7422
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_7_2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_7_2.BP_DollItem_7_2_C");
			}
			return BP_DollItem_7_2_C._ClassPtr;
		}

		// Token: 0x06021E7B RID: 138875 RVA: 0x008F9248 File Offset: 0x008F7448
		public BP_DollItem_7_2_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_7_2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E7C RID: 138876 RVA: 0x008F9270 File Offset: 0x008F7470
		[NullableContext(1)]
		public BP_DollItem_7_2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_7_2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038EA RID: 14570
		// (get) Token: 0x06021E7D RID: 138877 RVA: 0x008F92A3 File Offset: 0x008F74A3
		// (set) Token: 0x06021E7E RID: 138878 RVA: 0x008F92B7 File Offset: 0x008F74B7
		public unsafe UPointLightComponent PointLight1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_7_2_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_7_2_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038EB RID: 14571
		// (get) Token: 0x06021E7F RID: 138879 RVA: 0x008F92CC File Offset: 0x008F74CC
		// (set) Token: 0x06021E80 RID: 138880 RVA: 0x008F92E0 File Offset: 0x008F74E0
		public unsafe USkeletalMeshComponent EpropJiwawa07Md10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_7_2_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_7_2_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021E81 RID: 138881 RVA: 0x008F92F5 File Offset: 0x008F74F5
		protected BP_DollItem_7_2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010928 RID: 67880
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_7_2.BP_DollItem_7_2_C";

		// Token: 0x04010929 RID: 67881
		private static IntPtr _ClassPtr;

		// Token: 0x0401092A RID: 67882
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401092B RID: 67883
		internal static int __PropertyOffset_0;

		// Token: 0x0401092C RID: 67884
		internal new static int __PropertyOffset_1;
	}
}
