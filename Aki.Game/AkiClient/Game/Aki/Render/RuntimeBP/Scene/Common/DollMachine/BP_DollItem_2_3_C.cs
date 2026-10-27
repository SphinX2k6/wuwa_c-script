using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B76 RID: 15222
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_2_3.BP_DollItem_2_3_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_DollItem_2_3_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E08 RID: 138760 RVA: 0x008F85F2 File Offset: 0x008F67F2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_2_3_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_2_3.BP_DollItem_2_3_C");
			}
			return BP_DollItem_2_3_C._ClassPtr;
		}

		// Token: 0x06021E09 RID: 138761 RVA: 0x008F8618 File Offset: 0x008F6818
		public BP_DollItem_2_3_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_2_3_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E0A RID: 138762 RVA: 0x008F8640 File Offset: 0x008F6840
		[NullableContext(1)]
		public BP_DollItem_2_3_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_2_3_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038CD RID: 14541
		// (get) Token: 0x06021E0B RID: 138763 RVA: 0x008F8673 File Offset: 0x008F6873
		// (set) Token: 0x06021E0C RID: 138764 RVA: 0x008F8687 File Offset: 0x008F6887
		public unsafe UPointLightComponent PointLight1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_2_3_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_2_3_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038CE RID: 14542
		// (get) Token: 0x06021E0D RID: 138765 RVA: 0x008F869C File Offset: 0x008F689C
		// (set) Token: 0x06021E0E RID: 138766 RVA: 0x008F86B0 File Offset: 0x008F68B0
		public unsafe USkeletalMeshComponent EpropJiwawa02QiaoMd10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_2_3_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_2_3_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021E0F RID: 138767 RVA: 0x008F86C5 File Offset: 0x008F68C5
		protected BP_DollItem_2_3_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040108E1 RID: 67809
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_2_3.BP_DollItem_2_3_C";

		// Token: 0x040108E2 RID: 67810
		private static IntPtr _ClassPtr;

		// Token: 0x040108E3 RID: 67811
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040108E4 RID: 67812
		internal static int __PropertyOffset_0;

		// Token: 0x040108E5 RID: 67813
		internal new static int __PropertyOffset_1;
	}
}
