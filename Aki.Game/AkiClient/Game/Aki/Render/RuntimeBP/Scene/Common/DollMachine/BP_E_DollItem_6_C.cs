using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B97 RID: 15255
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_6.BP_E_DollItem_6_C")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class BP_E_DollItem_6_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F5F RID: 139103 RVA: 0x008FAAA5 File Offset: 0x008F8CA5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_E_DollItem_6_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_6.BP_E_DollItem_6_C");
			}
			return BP_E_DollItem_6_C._ClassPtr;
		}

		// Token: 0x06021F60 RID: 139104 RVA: 0x008FAACC File Offset: 0x008F8CCC
		public BP_E_DollItem_6_C() : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_6_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F61 RID: 139105 RVA: 0x008FAAF4 File Offset: 0x008F8CF4
		[NullableContext(1)]
		public BP_E_DollItem_6_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_6_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003929 RID: 14633
		// (get) Token: 0x06021F62 RID: 139106 RVA: 0x008FAB27 File Offset: 0x008F8D27
		// (set) Token: 0x06021F63 RID: 139107 RVA: 0x008FAB3B File Offset: 0x008F8D3B
		[Nullable(2)]
		public unsafe USkeletalMeshComponent EpropJiwawa06Md10011
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_E_DollItem_6_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_E_DollItem_6_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06021F64 RID: 139108 RVA: 0x008FAB50 File Offset: 0x008F8D50
		protected BP_E_DollItem_6_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109B4 RID: 68020
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_6.BP_E_DollItem_6_C";

		// Token: 0x040109B5 RID: 68021
		private static IntPtr _ClassPtr;

		// Token: 0x040109B6 RID: 68022
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109B7 RID: 68023
		internal static int __PropertyOffset_0;
	}
}
