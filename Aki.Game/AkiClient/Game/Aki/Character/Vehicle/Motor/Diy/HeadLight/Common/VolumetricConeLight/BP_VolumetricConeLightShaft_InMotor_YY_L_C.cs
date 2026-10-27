using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Diy.HeadLight.Common.VolumetricConeLight
{
	// Token: 0x02004043 RID: 16451
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/VolumetricConeLight/BP_VolumetricConeLightShaft_InMotor_YY_L.BP_VolumetricConeLightShaft_InMotor_YY_L_C")]
	[UnrealStructLayout(2888, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2888)]
	public class BP_VolumetricConeLightShaft_InMotor_YY_L_C : BP_VolumetricConeLightShaft_InMotor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A410 RID: 173072 RVA: 0x009DA680 File Offset: 0x009D8880
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VolumetricConeLightShaft_InMotor_YY_L_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/VolumetricConeLight/BP_VolumetricConeLightShaft_InMotor_YY_L.BP_VolumetricConeLightShaft_InMotor_YY_L_C");
			}
			return BP_VolumetricConeLightShaft_InMotor_YY_L_C._ClassPtr;
		}

		// Token: 0x0602A411 RID: 173073 RVA: 0x009DA6A4 File Offset: 0x009D88A4
		public BP_VolumetricConeLightShaft_InMotor_YY_L_C() : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricConeLightShaft_InMotor_YY_L_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A412 RID: 173074 RVA: 0x009DA6CC File Offset: 0x009D88CC
		[NullableContext(1)]
		public BP_VolumetricConeLightShaft_InMotor_YY_L_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VolumetricConeLightShaft_InMotor_YY_L_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700677F RID: 26495
		// (get) Token: 0x0602A413 RID: 173075 RVA: 0x009DA6FF File Offset: 0x009D88FF
		// (set) Token: 0x0602A414 RID: 173076 RVA: 0x009DA713 File Offset: 0x009D8913
		[Nullable(2)]
		public unsafe UChildActorComponent BP_VolumetricConeLightShaft_InMotor_YY_R
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_YY_L_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VolumetricConeLightShaft_InMotor_YY_L_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0602A415 RID: 173077 RVA: 0x009DA728 File Offset: 0x009D8928
		protected BP_VolumetricConeLightShaft_InMotor_YY_L_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C9D RID: 89245
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/VolumetricConeLight/BP_VolumetricConeLightShaft_InMotor_YY_L.BP_VolumetricConeLightShaft_InMotor_YY_L_C";

		// Token: 0x04015C9E RID: 89246
		private static IntPtr _ClassPtr;

		// Token: 0x04015C9F RID: 89247
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015CA0 RID: 89248
		internal static int __PropertyOffset_0;
	}
}
