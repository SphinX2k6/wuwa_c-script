using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B7A RID: 15226
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_4_1.BP_DollItem_4_1_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_DollItem_4_1_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E28 RID: 138792 RVA: 0x008F8962 File Offset: 0x008F6B62
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_4_1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_4_1.BP_DollItem_4_1_C");
			}
			return BP_DollItem_4_1_C._ClassPtr;
		}

		// Token: 0x06021E29 RID: 138793 RVA: 0x008F8988 File Offset: 0x008F6B88
		public BP_DollItem_4_1_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_4_1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E2A RID: 138794 RVA: 0x008F89B0 File Offset: 0x008F6BB0
		[NullableContext(1)]
		public BP_DollItem_4_1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_4_1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038D5 RID: 14549
		// (get) Token: 0x06021E2B RID: 138795 RVA: 0x008F89E3 File Offset: 0x008F6BE3
		// (set) Token: 0x06021E2C RID: 138796 RVA: 0x008F89F7 File Offset: 0x008F6BF7
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_4_1_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_4_1_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038D6 RID: 14550
		// (get) Token: 0x06021E2D RID: 138797 RVA: 0x008F8A0C File Offset: 0x008F6C0C
		// (set) Token: 0x06021E2E RID: 138798 RVA: 0x008F8A20 File Offset: 0x008F6C20
		public unsafe USkeletalMeshComponent EpropJiwawa04Md10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_4_1_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_4_1_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021E2F RID: 138799 RVA: 0x008F8A35 File Offset: 0x008F6C35
		protected BP_DollItem_4_1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040108F5 RID: 67829
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_4_1.BP_DollItem_4_1_C";

		// Token: 0x040108F6 RID: 67830
		private static IntPtr _ClassPtr;

		// Token: 0x040108F7 RID: 67831
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040108F8 RID: 67832
		internal static int __PropertyOffset_0;

		// Token: 0x040108F9 RID: 67833
		internal new static int __PropertyOffset_1;
	}
}
