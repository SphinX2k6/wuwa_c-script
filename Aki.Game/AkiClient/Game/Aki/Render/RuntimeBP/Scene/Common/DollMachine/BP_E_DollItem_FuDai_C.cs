using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B9D RID: 15261
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_FuDai.BP_E_DollItem_FuDai_C")]
	[UnrealStructLayout(1664, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1664)]
	public class BP_E_DollItem_FuDai_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F81 RID: 139137 RVA: 0x008FAEB4 File Offset: 0x008F90B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_E_DollItem_FuDai_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_FuDai.BP_E_DollItem_FuDai_C");
			}
			return BP_E_DollItem_FuDai_C._ClassPtr;
		}

		// Token: 0x06021F82 RID: 139138 RVA: 0x008FAED8 File Offset: 0x008F90D8
		public BP_E_DollItem_FuDai_C() : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_FuDai_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F83 RID: 139139 RVA: 0x008FAF00 File Offset: 0x008F9100
		[NullableContext(1)]
		public BP_E_DollItem_FuDai_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_FuDai_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021F84 RID: 139140 RVA: 0x008FAF33 File Offset: 0x008F9133
		protected BP_E_DollItem_FuDai_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109CB RID: 68043
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_FuDai.BP_E_DollItem_FuDai_C";

		// Token: 0x040109CC RID: 68044
		private static IntPtr _ClassPtr;

		// Token: 0x040109CD RID: 68045
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
