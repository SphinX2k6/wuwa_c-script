using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B86 RID: 15238
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_8_1.BP_DollItem_8_1_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_DollItem_8_1_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E8A RID: 138890 RVA: 0x008F93DA File Offset: 0x008F75DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_8_1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_8_1.BP_DollItem_8_1_C");
			}
			return BP_DollItem_8_1_C._ClassPtr;
		}

		// Token: 0x06021E8B RID: 138891 RVA: 0x008F9400 File Offset: 0x008F7600
		public BP_DollItem_8_1_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_8_1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E8C RID: 138892 RVA: 0x008F9428 File Offset: 0x008F7628
		[NullableContext(1)]
		public BP_DollItem_8_1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_8_1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038EE RID: 14574
		// (get) Token: 0x06021E8D RID: 138893 RVA: 0x008F945B File Offset: 0x008F765B
		// (set) Token: 0x06021E8E RID: 138894 RVA: 0x008F946F File Offset: 0x008F766F
		public unsafe UPointLightComponent PointLight1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_8_1_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_8_1_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038EF RID: 14575
		// (get) Token: 0x06021E8F RID: 138895 RVA: 0x008F9484 File Offset: 0x008F7684
		// (set) Token: 0x06021E90 RID: 138896 RVA: 0x008F9498 File Offset: 0x008F7698
		public unsafe USkeletalMeshComponent EpropJiwawa08Md10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_8_1_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_8_1_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021E91 RID: 138897 RVA: 0x008F94AD File Offset: 0x008F76AD
		protected BP_DollItem_8_1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010932 RID: 67890
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_8_1.BP_DollItem_8_1_C";

		// Token: 0x04010933 RID: 67891
		private static IntPtr _ClassPtr;

		// Token: 0x04010934 RID: 67892
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010935 RID: 67893
		internal static int __PropertyOffset_0;

		// Token: 0x04010936 RID: 67894
		internal new static int __PropertyOffset_1;
	}
}
