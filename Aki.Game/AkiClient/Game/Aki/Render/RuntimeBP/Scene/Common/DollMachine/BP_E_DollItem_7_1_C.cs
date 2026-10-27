using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B98 RID: 15256
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_7_1.BP_E_DollItem_7_1_C")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class BP_E_DollItem_7_1_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F65 RID: 139109 RVA: 0x008FAB59 File Offset: 0x008F8D59
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_E_DollItem_7_1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_7_1.BP_E_DollItem_7_1_C");
			}
			return BP_E_DollItem_7_1_C._ClassPtr;
		}

		// Token: 0x06021F66 RID: 139110 RVA: 0x008FAB80 File Offset: 0x008F8D80
		public BP_E_DollItem_7_1_C() : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_7_1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F67 RID: 139111 RVA: 0x008FABA8 File Offset: 0x008F8DA8
		[NullableContext(1)]
		public BP_E_DollItem_7_1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_7_1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700392A RID: 14634
		// (get) Token: 0x06021F68 RID: 139112 RVA: 0x008FABDB File Offset: 0x008F8DDB
		// (set) Token: 0x06021F69 RID: 139113 RVA: 0x008FABEF File Offset: 0x008F8DEF
		[Nullable(2)]
		public unsafe USkeletalMeshComponent EpropJiwawa07Md10011
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_E_DollItem_7_1_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_E_DollItem_7_1_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06021F6A RID: 139114 RVA: 0x008FAC04 File Offset: 0x008F8E04
		protected BP_E_DollItem_7_1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109B8 RID: 68024
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_7_1.BP_E_DollItem_7_1_C";

		// Token: 0x040109B9 RID: 68025
		private static IntPtr _ClassPtr;

		// Token: 0x040109BA RID: 68026
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109BB RID: 68027
		internal static int __PropertyOffset_0;
	}
}
