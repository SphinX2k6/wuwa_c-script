using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Diy.HeadLight.Common.VolumetricConeLight
{
	// Token: 0x02004042 RID: 16450
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/VolumetricConeLight/BP_VolumetricConeLightShaft_InMotor_FX.BP_VolumetricConeLightShaft_InMotor_FX_C")]
	[UnrealStructLayout(2880, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2880)]
	public class BP_VolumetricConeLightShaft_InMotor_FX_C : BP_VolumetricConeLightShaft_InMotor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A40C RID: 173068 RVA: 0x009DA5F5 File Offset: 0x009D87F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumetricConeLightShaft_InMotor_FX_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/VolumetricConeLight/BP_VolumetricConeLightShaft_InMotor_FX.BP_VolumetricConeLightShaft_InMotor_FX_C");
			}
			return BP_VolumetricConeLightShaft_InMotor_FX_C._ClassPtr;
		}

		// Token: 0x0602A40D RID: 173069 RVA: 0x009DA61C File Offset: 0x009D881C
		public BP_VolumetricConeLightShaft_InMotor_FX_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricConeLightShaft_InMotor_FX_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A40E RID: 173070 RVA: 0x009DA644 File Offset: 0x009D8844
		[NullableContext(1)]
		public BP_VolumetricConeLightShaft_InMotor_FX_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricConeLightShaft_InMotor_FX_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A40F RID: 173071 RVA: 0x009DA677 File Offset: 0x009D8877
		protected BP_VolumetricConeLightShaft_InMotor_FX_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C9A RID: 89242
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/VolumetricConeLight/BP_VolumetricConeLightShaft_InMotor_FX.BP_VolumetricConeLightShaft_InMotor_FX_C";

		// Token: 0x04015C9B RID: 89243
		private static IntPtr _ClassPtr;

		// Token: 0x04015C9C RID: 89244
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
