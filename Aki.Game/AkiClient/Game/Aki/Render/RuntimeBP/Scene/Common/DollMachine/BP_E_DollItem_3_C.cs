using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B94 RID: 15252
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_3.BP_E_DollItem_3_C")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class BP_E_DollItem_3_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F4D RID: 139085 RVA: 0x008FA889 File Offset: 0x008F8A89
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_E_DollItem_3_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_3.BP_E_DollItem_3_C");
			}
			return BP_E_DollItem_3_C._ClassPtr;
		}

		// Token: 0x06021F4E RID: 139086 RVA: 0x008FA8B0 File Offset: 0x008F8AB0
		public BP_E_DollItem_3_C() : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_3_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F4F RID: 139087 RVA: 0x008FA8D8 File Offset: 0x008F8AD8
		[NullableContext(1)]
		public BP_E_DollItem_3_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_3_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003926 RID: 14630
		// (get) Token: 0x06021F50 RID: 139088 RVA: 0x008FA90B File Offset: 0x008F8B0B
		// (set) Token: 0x06021F51 RID: 139089 RVA: 0x008FA91F File Offset: 0x008F8B1F
		[Nullable(2)]
		public unsafe USkeletalMeshComponent EpropJiwawa03Md10011
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_E_DollItem_3_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_E_DollItem_3_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06021F52 RID: 139090 RVA: 0x008FA934 File Offset: 0x008F8B34
		protected BP_E_DollItem_3_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109A8 RID: 68008
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_3.BP_E_DollItem_3_C";

		// Token: 0x040109A9 RID: 68009
		private static IntPtr _ClassPtr;

		// Token: 0x040109AA RID: 68010
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109AB RID: 68011
		internal static int __PropertyOffset_0;
	}
}
