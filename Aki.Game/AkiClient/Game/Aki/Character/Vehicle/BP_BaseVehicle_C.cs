using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle
{
	// Token: 0x02003289 RID: 12937
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/BP_BaseVehicle.BP_BaseVehicle_C")]
	[UnrealStructLayout(2144, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2136)]
	public class BP_BaseVehicle_C : __TsBaseVehicle_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060205D9 RID: 132569 RVA: 0x0094478A File Offset: 0x0094298A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BaseVehicle_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/BP_BaseVehicle.BP_BaseVehicle_C");
			}
			return BP_BaseVehicle_C._ClassPtr;
		}

		// Token: 0x060205DA RID: 132570 RVA: 0x009447B0 File Offset: 0x009429B0
		public BP_BaseVehicle_C() : this(BuiltinUtils.AllocNativeUObject(BP_BaseVehicle_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060205DB RID: 132571 RVA: 0x009447D8 File Offset: 0x009429D8
		[NullableContext(1)]
		public BP_BaseVehicle_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BaseVehicle_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060205DC RID: 132572 RVA: 0x0094480B File Offset: 0x00942A0B
		protected BP_BaseVehicle_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040117A7 RID: 71591
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/BP_BaseVehicle.BP_BaseVehicle_C";

		// Token: 0x040117A8 RID: 71592
		private static IntPtr _ClassPtr;

		// Token: 0x040117A9 RID: 71593
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
