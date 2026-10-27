using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B80 RID: 15232
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_6_1.BP_DollItem_6_1_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_DollItem_6_1_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E5A RID: 138842 RVA: 0x008F8EB2 File Offset: 0x008F70B2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_6_1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_6_1.BP_DollItem_6_1_C");
			}
			return BP_DollItem_6_1_C._ClassPtr;
		}

		// Token: 0x06021E5B RID: 138843 RVA: 0x008F8ED8 File Offset: 0x008F70D8
		public BP_DollItem_6_1_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_6_1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E5C RID: 138844 RVA: 0x008F8F00 File Offset: 0x008F7100
		[NullableContext(1)]
		public BP_DollItem_6_1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_6_1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038E2 RID: 14562
		// (get) Token: 0x06021E5D RID: 138845 RVA: 0x008F8F33 File Offset: 0x008F7133
		// (set) Token: 0x06021E5E RID: 138846 RVA: 0x008F8F47 File Offset: 0x008F7147
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_6_1_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_6_1_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038E3 RID: 14563
		// (get) Token: 0x06021E5F RID: 138847 RVA: 0x008F8F5C File Offset: 0x008F715C
		// (set) Token: 0x06021E60 RID: 138848 RVA: 0x008F8F70 File Offset: 0x008F7170
		public unsafe USkeletalMeshComponent EpropJiwawa06Md10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_6_1_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_6_1_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021E61 RID: 138849 RVA: 0x008F8F85 File Offset: 0x008F7185
		protected BP_DollItem_6_1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010914 RID: 67860
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_6_1.BP_DollItem_6_1_C";

		// Token: 0x04010915 RID: 67861
		private static IntPtr _ClassPtr;

		// Token: 0x04010916 RID: 67862
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010917 RID: 67863
		internal static int __PropertyOffset_0;

		// Token: 0x04010918 RID: 67864
		internal new static int __PropertyOffset_1;
	}
}
