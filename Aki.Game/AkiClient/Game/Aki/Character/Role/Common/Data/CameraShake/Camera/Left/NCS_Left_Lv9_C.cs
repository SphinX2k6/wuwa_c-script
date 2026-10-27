using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Left
{
	// Token: 0x020040FE RID: 16638
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv9.NCS_Left_Lv9_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Left_Lv9_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADCA RID: 175562 RVA: 0x009EDCA8 File Offset: 0x009EBEA8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Left_Lv9_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv9.NCS_Left_Lv9_C");
			}
			return NCS_Left_Lv9_C._ClassPtr;
		}

		// Token: 0x0602ADCB RID: 175563 RVA: 0x009EDCCC File Offset: 0x009EBECC
		public NCS_Left_Lv9_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Left_Lv9_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADCC RID: 175564 RVA: 0x009EDCF4 File Offset: 0x009EBEF4
		[NullableContext(1)]
		public NCS_Left_Lv9_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Left_Lv9_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADCD RID: 175565 RVA: 0x009EDD27 File Offset: 0x009EBF27
		protected NCS_Left_Lv9_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401635A RID: 90970
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv9.NCS_Left_Lv9_C";

		// Token: 0x0401635B RID: 90971
		private static IntPtr _ClassPtr;

		// Token: 0x0401635C RID: 90972
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
