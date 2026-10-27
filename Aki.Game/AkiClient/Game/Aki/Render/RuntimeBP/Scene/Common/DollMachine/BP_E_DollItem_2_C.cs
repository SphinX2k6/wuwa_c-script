using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B93 RID: 15251
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_2.BP_E_DollItem_2_C")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class BP_E_DollItem_2_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F47 RID: 139079 RVA: 0x008FA7D5 File Offset: 0x008F89D5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_E_DollItem_2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_2.BP_E_DollItem_2_C");
			}
			return BP_E_DollItem_2_C._ClassPtr;
		}

		// Token: 0x06021F48 RID: 139080 RVA: 0x008FA7FC File Offset: 0x008F89FC
		public BP_E_DollItem_2_C() : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F49 RID: 139081 RVA: 0x008FA824 File Offset: 0x008F8A24
		[NullableContext(1)]
		public BP_E_DollItem_2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003925 RID: 14629
		// (get) Token: 0x06021F4A RID: 139082 RVA: 0x008FA857 File Offset: 0x008F8A57
		// (set) Token: 0x06021F4B RID: 139083 RVA: 0x008FA86B File Offset: 0x008F8A6B
		[Nullable(2)]
		public unsafe USkeletalMeshComponent EpropJiwawa02Md10011
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_E_DollItem_2_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_E_DollItem_2_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06021F4C RID: 139084 RVA: 0x008FA880 File Offset: 0x008F8A80
		protected BP_E_DollItem_2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109A4 RID: 68004
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_2.BP_E_DollItem_2_C";

		// Token: 0x040109A5 RID: 68005
		private static IntPtr _ClassPtr;

		// Token: 0x040109A6 RID: 68006
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109A7 RID: 68007
		internal static int __PropertyOffset_0;
	}
}
