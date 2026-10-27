using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B82 RID: 15234
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_6_3.BP_DollItem_6_3_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_DollItem_6_3_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E6A RID: 138858 RVA: 0x008F906A File Offset: 0x008F726A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_6_3_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_6_3.BP_DollItem_6_3_C");
			}
			return BP_DollItem_6_3_C._ClassPtr;
		}

		// Token: 0x06021E6B RID: 138859 RVA: 0x008F9090 File Offset: 0x008F7290
		public BP_DollItem_6_3_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_6_3_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E6C RID: 138860 RVA: 0x008F90B8 File Offset: 0x008F72B8
		[NullableContext(1)]
		public BP_DollItem_6_3_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_6_3_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038E6 RID: 14566
		// (get) Token: 0x06021E6D RID: 138861 RVA: 0x008F90EB File Offset: 0x008F72EB
		// (set) Token: 0x06021E6E RID: 138862 RVA: 0x008F90FF File Offset: 0x008F72FF
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_6_3_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_6_3_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038E7 RID: 14567
		// (get) Token: 0x06021E6F RID: 138863 RVA: 0x008F9114 File Offset: 0x008F7314
		// (set) Token: 0x06021E70 RID: 138864 RVA: 0x008F9128 File Offset: 0x008F7328
		public unsafe USkeletalMeshComponent EpropJiwawa06Tiao1Md10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_6_3_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_6_3_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021E71 RID: 138865 RVA: 0x008F913D File Offset: 0x008F733D
		protected BP_DollItem_6_3_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401091E RID: 67870
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_6_3.BP_DollItem_6_3_C";

		// Token: 0x0401091F RID: 67871
		private static IntPtr _ClassPtr;

		// Token: 0x04010920 RID: 67872
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010921 RID: 67873
		internal static int __PropertyOffset_0;

		// Token: 0x04010922 RID: 67874
		internal new static int __PropertyOffset_1;
	}
}
