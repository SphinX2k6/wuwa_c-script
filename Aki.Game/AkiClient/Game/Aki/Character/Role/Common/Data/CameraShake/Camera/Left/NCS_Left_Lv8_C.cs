using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Left
{
	// Token: 0x020040FD RID: 16637
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv8.NCS_Left_Lv8_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Left_Lv8_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADC6 RID: 175558 RVA: 0x009EDC20 File Offset: 0x009EBE20
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Left_Lv8_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv8.NCS_Left_Lv8_C");
			}
			return NCS_Left_Lv8_C._ClassPtr;
		}

		// Token: 0x0602ADC7 RID: 175559 RVA: 0x009EDC44 File Offset: 0x009EBE44
		public NCS_Left_Lv8_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Left_Lv8_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADC8 RID: 175560 RVA: 0x009EDC6C File Offset: 0x009EBE6C
		[NullableContext(1)]
		public NCS_Left_Lv8_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Left_Lv8_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADC9 RID: 175561 RVA: 0x009EDC9F File Offset: 0x009EBE9F
		protected NCS_Left_Lv8_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016357 RID: 90967
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv8.NCS_Left_Lv8_C";

		// Token: 0x04016358 RID: 90968
		private static IntPtr _ClassPtr;

		// Token: 0x04016359 RID: 90969
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
