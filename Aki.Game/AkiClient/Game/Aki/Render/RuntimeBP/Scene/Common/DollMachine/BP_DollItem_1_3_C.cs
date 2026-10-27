using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B73 RID: 15219
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_1_3.BP_DollItem_1_3_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_DollItem_1_3_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021DF0 RID: 138736 RVA: 0x008F835E File Offset: 0x008F655E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_1_3_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_1_3.BP_DollItem_1_3_C");
			}
			return BP_DollItem_1_3_C._ClassPtr;
		}

		// Token: 0x06021DF1 RID: 138737 RVA: 0x008F8384 File Offset: 0x008F6584
		public BP_DollItem_1_3_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_1_3_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021DF2 RID: 138738 RVA: 0x008F83AC File Offset: 0x008F65AC
		[NullableContext(1)]
		public BP_DollItem_1_3_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_1_3_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038C7 RID: 14535
		// (get) Token: 0x06021DF3 RID: 138739 RVA: 0x008F83DF File Offset: 0x008F65DF
		// (set) Token: 0x06021DF4 RID: 138740 RVA: 0x008F83F3 File Offset: 0x008F65F3
		public unsafe UPointLightComponent PointLight1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_1_3_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_1_3_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038C8 RID: 14536
		// (get) Token: 0x06021DF5 RID: 138741 RVA: 0x008F8408 File Offset: 0x008F6608
		// (set) Token: 0x06021DF6 RID: 138742 RVA: 0x008F841C File Offset: 0x008F661C
		public unsafe USkeletalMeshComponent EpropJiwawa01RDoorMd10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_1_3_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_1_3_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021DF7 RID: 138743 RVA: 0x008F8431 File Offset: 0x008F6631
		protected BP_DollItem_1_3_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040108D2 RID: 67794
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_1_3.BP_DollItem_1_3_C";

		// Token: 0x040108D3 RID: 67795
		private static IntPtr _ClassPtr;

		// Token: 0x040108D4 RID: 67796
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040108D5 RID: 67797
		internal static int __PropertyOffset_0;

		// Token: 0x040108D6 RID: 67798
		internal new static int __PropertyOffset_1;
	}
}
