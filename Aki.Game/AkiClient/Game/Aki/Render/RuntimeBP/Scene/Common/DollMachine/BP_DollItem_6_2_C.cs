using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B81 RID: 15233
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_6_2.BP_DollItem_6_2_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_DollItem_6_2_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E62 RID: 138850 RVA: 0x008F8F8E File Offset: 0x008F718E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_6_2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_6_2.BP_DollItem_6_2_C");
			}
			return BP_DollItem_6_2_C._ClassPtr;
		}

		// Token: 0x06021E63 RID: 138851 RVA: 0x008F8FB4 File Offset: 0x008F71B4
		public BP_DollItem_6_2_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_6_2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E64 RID: 138852 RVA: 0x008F8FDC File Offset: 0x008F71DC
		[NullableContext(1)]
		public BP_DollItem_6_2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_6_2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038E4 RID: 14564
		// (get) Token: 0x06021E65 RID: 138853 RVA: 0x008F900F File Offset: 0x008F720F
		// (set) Token: 0x06021E66 RID: 138854 RVA: 0x008F9023 File Offset: 0x008F7223
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_6_2_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_6_2_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038E5 RID: 14565
		// (get) Token: 0x06021E67 RID: 138855 RVA: 0x008F9038 File Offset: 0x008F7238
		// (set) Token: 0x06021E68 RID: 138856 RVA: 0x008F904C File Offset: 0x008F724C
		public unsafe USkeletalMeshComponent EpropJiwawa06Tiao1Md10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_6_2_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_6_2_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021E69 RID: 138857 RVA: 0x008F9061 File Offset: 0x008F7261
		protected BP_DollItem_6_2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010919 RID: 67865
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_6_2.BP_DollItem_6_2_C";

		// Token: 0x0401091A RID: 67866
		private static IntPtr _ClassPtr;

		// Token: 0x0401091B RID: 67867
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401091C RID: 67868
		internal static int __PropertyOffset_0;

		// Token: 0x0401091D RID: 67869
		internal new static int __PropertyOffset_1;
	}
}
