using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B92 RID: 15250
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_1.BP_E_DollItem_1_C")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class BP_E_DollItem_1_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F41 RID: 139073 RVA: 0x008FA723 File Offset: 0x008F8923
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_E_DollItem_1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_1.BP_E_DollItem_1_C");
			}
			return BP_E_DollItem_1_C._ClassPtr;
		}

		// Token: 0x06021F42 RID: 139074 RVA: 0x008FA748 File Offset: 0x008F8948
		public BP_E_DollItem_1_C() : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F43 RID: 139075 RVA: 0x008FA770 File Offset: 0x008F8970
		[NullableContext(1)]
		public BP_E_DollItem_1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003924 RID: 14628
		// (get) Token: 0x06021F44 RID: 139076 RVA: 0x008FA7A3 File Offset: 0x008F89A3
		// (set) Token: 0x06021F45 RID: 139077 RVA: 0x008FA7B7 File Offset: 0x008F89B7
		[Nullable(2)]
		public unsafe USkeletalMeshComponent EpropJiwawa01Md10011
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_E_DollItem_1_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_E_DollItem_1_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06021F46 RID: 139078 RVA: 0x008FA7CC File Offset: 0x008F89CC
		protected BP_E_DollItem_1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109A0 RID: 68000
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_1.BP_E_DollItem_1_C";

		// Token: 0x040109A1 RID: 68001
		private static IntPtr _ClassPtr;

		// Token: 0x040109A2 RID: 68002
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109A3 RID: 68003
		internal static int __PropertyOffset_0;
	}
}
