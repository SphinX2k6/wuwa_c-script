using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Diy.HeadLight.Common.VolumetricConeLight
{
	// Token: 0x02004040 RID: 16448
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/VolumetricConeLight/BP_VolumetricConeLightShaft_InMotor_Ams.BP_VolumetricConeLightShaft_InMotor_Ams_C")]
	[UnrealStructLayout(2880, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2880)]
	public class BP_VolumetricConeLightShaft_InMotor_Ams_C : BP_VolumetricConeLightShaft_InMotor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A36A RID: 172906 RVA: 0x009D96C0 File Offset: 0x009D78C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumetricConeLightShaft_InMotor_Ams_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/VolumetricConeLight/BP_VolumetricConeLightShaft_InMotor_Ams.BP_VolumetricConeLightShaft_InMotor_Ams_C");
			}
			return BP_VolumetricConeLightShaft_InMotor_Ams_C._ClassPtr;
		}

		// Token: 0x0602A36B RID: 172907 RVA: 0x009D96E4 File Offset: 0x009D78E4
		public BP_VolumetricConeLightShaft_InMotor_Ams_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricConeLightShaft_InMotor_Ams_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A36C RID: 172908 RVA: 0x009D970C File Offset: 0x009D790C
		[NullableContext(1)]
		public BP_VolumetricConeLightShaft_InMotor_Ams_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricConeLightShaft_InMotor_Ams_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A36D RID: 172909 RVA: 0x009D973F File Offset: 0x009D793F
		protected BP_VolumetricConeLightShaft_InMotor_Ams_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C3A RID: 89146
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/VolumetricConeLight/BP_VolumetricConeLightShaft_InMotor_Ams.BP_VolumetricConeLightShaft_InMotor_Ams_C";

		// Token: 0x04015C3B RID: 89147
		private static IntPtr _ClassPtr;

		// Token: 0x04015C3C RID: 89148
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
