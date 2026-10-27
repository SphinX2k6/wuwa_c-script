using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B95 RID: 15253
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_4.BP_E_DollItem_4_C")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class BP_E_DollItem_4_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F53 RID: 139091 RVA: 0x008FA93D File Offset: 0x008F8B3D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_E_DollItem_4_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_4.BP_E_DollItem_4_C");
			}
			return BP_E_DollItem_4_C._ClassPtr;
		}

		// Token: 0x06021F54 RID: 139092 RVA: 0x008FA964 File Offset: 0x008F8B64
		public BP_E_DollItem_4_C() : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_4_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F55 RID: 139093 RVA: 0x008FA98C File Offset: 0x008F8B8C
		[NullableContext(1)]
		public BP_E_DollItem_4_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_4_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003927 RID: 14631
		// (get) Token: 0x06021F56 RID: 139094 RVA: 0x008FA9BF File Offset: 0x008F8BBF
		// (set) Token: 0x06021F57 RID: 139095 RVA: 0x008FA9D3 File Offset: 0x008F8BD3
		[Nullable(2)]
		public unsafe USkeletalMeshComponent EpropJiwawa04Md10011
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_E_DollItem_4_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_E_DollItem_4_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06021F58 RID: 139096 RVA: 0x008FA9E8 File Offset: 0x008F8BE8
		protected BP_E_DollItem_4_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109AC RID: 68012
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_4.BP_E_DollItem_4_C";

		// Token: 0x040109AD RID: 68013
		private static IntPtr _ClassPtr;

		// Token: 0x040109AE RID: 68014
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109AF RID: 68015
		internal static int __PropertyOffset_0;
	}
}
