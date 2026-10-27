using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B75 RID: 15221
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_2_2.BP_DollItem_2_2_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_DollItem_2_2_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E00 RID: 138752 RVA: 0x008F8516 File Offset: 0x008F6716
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_2_2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_2_2.BP_DollItem_2_2_C");
			}
			return BP_DollItem_2_2_C._ClassPtr;
		}

		// Token: 0x06021E01 RID: 138753 RVA: 0x008F853C File Offset: 0x008F673C
		public BP_DollItem_2_2_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_2_2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E02 RID: 138754 RVA: 0x008F8564 File Offset: 0x008F6764
		[NullableContext(1)]
		public BP_DollItem_2_2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_2_2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038CB RID: 14539
		// (get) Token: 0x06021E03 RID: 138755 RVA: 0x008F8597 File Offset: 0x008F6797
		// (set) Token: 0x06021E04 RID: 138756 RVA: 0x008F85AB File Offset: 0x008F67AB
		public unsafe UPointLightComponent PointLight1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_2_2_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_2_2_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038CC RID: 14540
		// (get) Token: 0x06021E05 RID: 138757 RVA: 0x008F85C0 File Offset: 0x008F67C0
		// (set) Token: 0x06021E06 RID: 138758 RVA: 0x008F85D4 File Offset: 0x008F67D4
		public unsafe USkeletalMeshComponent EpropJiwawa02JianMd10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_2_2_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_2_2_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021E07 RID: 138759 RVA: 0x008F85E9 File Offset: 0x008F67E9
		protected BP_DollItem_2_2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040108DC RID: 67804
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_2_2.BP_DollItem_2_2_C";

		// Token: 0x040108DD RID: 67805
		private static IntPtr _ClassPtr;

		// Token: 0x040108DE RID: 67806
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040108DF RID: 67807
		internal static int __PropertyOffset_0;

		// Token: 0x040108E0 RID: 67808
		internal new static int __PropertyOffset_1;
	}
}
