using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Diy.HeadLight.Common.VolumetricConeLight
{
	// Token: 0x0200403F RID: 16447
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/VolumetricConeLight/BP_VolumetricConeLightShaft_InMotor_3_5.BP_VolumetricConeLightShaft_InMotor_3_5_C")]
	[UnrealStructLayout(2880, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2880)]
	public class BP_VolumetricConeLightShaft_InMotor_3_5_C : BP_VolumetricConeLightShaft_InMotor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A366 RID: 172902 RVA: 0x009D9636 File Offset: 0x009D7836
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumetricConeLightShaft_InMotor_3_5_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/VolumetricConeLight/BP_VolumetricConeLightShaft_InMotor_3_5.BP_VolumetricConeLightShaft_InMotor_3_5_C");
			}
			return BP_VolumetricConeLightShaft_InMotor_3_5_C._ClassPtr;
		}

		// Token: 0x0602A367 RID: 172903 RVA: 0x009D965C File Offset: 0x009D785C
		public BP_VolumetricConeLightShaft_InMotor_3_5_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricConeLightShaft_InMotor_3_5_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A368 RID: 172904 RVA: 0x009D9684 File Offset: 0x009D7884
		[NullableContext(1)]
		public BP_VolumetricConeLightShaft_InMotor_3_5_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricConeLightShaft_InMotor_3_5_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A369 RID: 172905 RVA: 0x009D96B7 File Offset: 0x009D78B7
		protected BP_VolumetricConeLightShaft_InMotor_3_5_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C37 RID: 89143
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/VolumetricConeLight/BP_VolumetricConeLightShaft_InMotor_3_5.BP_VolumetricConeLightShaft_InMotor_3_5_C";

		// Token: 0x04015C38 RID: 89144
		private static IntPtr _ClassPtr;

		// Token: 0x04015C39 RID: 89145
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
