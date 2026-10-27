using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B9C RID: 15260
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_BeiBi_S.BP_E_DollItem_BeiBi_S_C")]
	[UnrealStructLayout(1664, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1664)]
	public class BP_E_DollItem_BeiBi_S_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021F7D RID: 139133 RVA: 0x008FAE29 File Offset: 0x008F9029
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_E_DollItem_BeiBi_S_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_BeiBi_S.BP_E_DollItem_BeiBi_S_C");
			}
			return BP_E_DollItem_BeiBi_S_C._ClassPtr;
		}

		// Token: 0x06021F7E RID: 139134 RVA: 0x008FAE50 File Offset: 0x008F9050
		public BP_E_DollItem_BeiBi_S_C() : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_BeiBi_S_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021F7F RID: 139135 RVA: 0x008FAE78 File Offset: 0x008F9078
		[NullableContext(1)]
		public BP_E_DollItem_BeiBi_S_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_E_DollItem_BeiBi_S_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021F80 RID: 139136 RVA: 0x008FAEAB File Offset: 0x008F90AB
		protected BP_E_DollItem_BeiBi_S_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109C8 RID: 68040
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_E_DollItem_BeiBi_S.BP_E_DollItem_BeiBi_S_C";

		// Token: 0x040109C9 RID: 68041
		private static IntPtr _ClassPtr;

		// Token: 0x040109CA RID: 68042
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
