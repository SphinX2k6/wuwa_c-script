using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B9E RID: 15262
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_FuDai_S.BP_E_DollItem_FuDai_S_C")]
	[UnrealStructLayout(1664, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1664)]
	public class BP_E_DollItem_FuDai_S_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F85 RID: 139141 RVA: 0x008FAF3C File Offset: 0x008F913C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_E_DollItem_FuDai_S_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_FuDai_S.BP_E_DollItem_FuDai_S_C");
			}
			return BP_E_DollItem_FuDai_S_C._ClassPtr;
		}

		// Token: 0x06021F86 RID: 139142 RVA: 0x008FAF60 File Offset: 0x008F9160
		public BP_E_DollItem_FuDai_S_C() : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_FuDai_S_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F87 RID: 139143 RVA: 0x008FAF88 File Offset: 0x008F9188
		[NullableContext(1)]
		public BP_E_DollItem_FuDai_S_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_FuDai_S_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021F88 RID: 139144 RVA: 0x008FAFBB File Offset: 0x008F91BB
		protected BP_E_DollItem_FuDai_S_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109CE RID: 68046
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_FuDai_S.BP_E_DollItem_FuDai_S_C";

		// Token: 0x040109CF RID: 68047
		private static IntPtr _ClassPtr;

		// Token: 0x040109D0 RID: 68048
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
