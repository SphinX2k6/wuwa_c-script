using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle
{
	// Token: 0x02004030 RID: 16432
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/BP_BaseVehicle.BP_BaseVehicle_C")]
	[UnrealStructLayout(2144, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2136)]
	public class BP_BaseVehicle_C : __TsBaseVehicle_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A269 RID: 172649 RVA: 0x009D77C8 File Offset: 0x009D59C8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BaseVehicle_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/BP_BaseVehicle.BP_BaseVehicle_C");
			}
			return BP_BaseVehicle_C._ClassPtr;
		}

		// Token: 0x0602A26A RID: 172650 RVA: 0x009D77EC File Offset: 0x009D59EC
		public BP_BaseVehicle_C() : this(BuiltinUtils.AllocNativeUObject(BP_BaseVehicle_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A26B RID: 172651 RVA: 0x009D7814 File Offset: 0x009D5A14
		[NullableContext(1)]
		public BP_BaseVehicle_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BaseVehicle_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A26C RID: 172652 RVA: 0x009D7847 File Offset: 0x009D5A47
		protected BP_BaseVehicle_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015B9B RID: 88987
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/BP_BaseVehicle.BP_BaseVehicle_C";

		// Token: 0x04015B9C RID: 88988
		private static IntPtr _ClassPtr;

		// Token: 0x04015B9D RID: 88989
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
