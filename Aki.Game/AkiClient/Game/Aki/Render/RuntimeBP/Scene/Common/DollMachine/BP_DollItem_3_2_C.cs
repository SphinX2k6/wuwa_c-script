using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B78 RID: 15224
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_3_2.BP_DollItem_3_2_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_DollItem_3_2_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E18 RID: 138776 RVA: 0x008F87AA File Offset: 0x008F69AA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_3_2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_3_2.BP_DollItem_3_2_C");
			}
			return BP_DollItem_3_2_C._ClassPtr;
		}

		// Token: 0x06021E19 RID: 138777 RVA: 0x008F87D0 File Offset: 0x008F69D0
		public BP_DollItem_3_2_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_3_2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E1A RID: 138778 RVA: 0x008F87F8 File Offset: 0x008F69F8
		[NullableContext(1)]
		public BP_DollItem_3_2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_3_2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038D1 RID: 14545
		// (get) Token: 0x06021E1B RID: 138779 RVA: 0x008F882B File Offset: 0x008F6A2B
		// (set) Token: 0x06021E1C RID: 138780 RVA: 0x008F883F File Offset: 0x008F6A3F
		public unsafe UPointLightComponent PointLight1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_3_2_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_3_2_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038D2 RID: 14546
		// (get) Token: 0x06021E1D RID: 138781 RVA: 0x008F8854 File Offset: 0x008F6A54
		// (set) Token: 0x06021E1E RID: 138782 RVA: 0x008F8868 File Offset: 0x008F6A68
		public unsafe USkeletalMeshComponent EpropJiwawa03AppleMd10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_3_2_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_3_2_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021E1F RID: 138783 RVA: 0x008F887D File Offset: 0x008F6A7D
		protected BP_DollItem_3_2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040108EB RID: 67819
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_3_2.BP_DollItem_3_2_C";

		// Token: 0x040108EC RID: 67820
		private static IntPtr _ClassPtr;

		// Token: 0x040108ED RID: 67821
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040108EE RID: 67822
		internal static int __PropertyOffset_0;

		// Token: 0x040108EF RID: 67823
		internal new static int __PropertyOffset_1;
	}
}
