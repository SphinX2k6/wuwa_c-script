using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B7F RID: 15231
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_5_3.BP_DollItem_5_3_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class BP_DollItem_5_3_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E52 RID: 138834 RVA: 0x008F8DD6 File Offset: 0x008F6FD6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_5_3_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_5_3.BP_DollItem_5_3_C");
			}
			return BP_DollItem_5_3_C._ClassPtr;
		}

		// Token: 0x06021E53 RID: 138835 RVA: 0x008F8DFC File Offset: 0x008F6FFC
		public BP_DollItem_5_3_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_5_3_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E54 RID: 138836 RVA: 0x008F8E24 File Offset: 0x008F7024
		[NullableContext(1)]
		public BP_DollItem_5_3_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_5_3_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038E0 RID: 14560
		// (get) Token: 0x06021E55 RID: 138837 RVA: 0x008F8E57 File Offset: 0x008F7057
		// (set) Token: 0x06021E56 RID: 138838 RVA: 0x008F8E6B File Offset: 0x008F706B
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_5_3_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_5_3_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170038E1 RID: 14561
		// (get) Token: 0x06021E57 RID: 138839 RVA: 0x008F8E80 File Offset: 0x008F7080
		// (set) Token: 0x06021E58 RID: 138840 RVA: 0x008F8E94 File Offset: 0x008F7094
		public unsafe USkeletalMeshComponent EpropJiwawa05DizuoMd10011
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_5_3_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_5_3_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06021E59 RID: 138841 RVA: 0x008F8EA9 File Offset: 0x008F70A9
		protected BP_DollItem_5_3_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401090F RID: 67855
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_5_3.BP_DollItem_5_3_C";

		// Token: 0x04010910 RID: 67856
		private static IntPtr _ClassPtr;

		// Token: 0x04010911 RID: 67857
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010912 RID: 67858
		internal static int __PropertyOffset_0;

		// Token: 0x04010913 RID: 67859
		internal new static int __PropertyOffset_1;
	}
}
