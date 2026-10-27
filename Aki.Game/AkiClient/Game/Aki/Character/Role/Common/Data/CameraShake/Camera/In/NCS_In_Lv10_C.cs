using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.In
{
	// Token: 0x020040FF RID: 16639
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv10.NCS_In_Lv10_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_In_Lv10_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADCE RID: 175566 RVA: 0x009EDD30 File Offset: 0x009EBF30
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_In_Lv10_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv10.NCS_In_Lv10_C");
			}
			return NCS_In_Lv10_C._ClassPtr;
		}

		// Token: 0x0602ADCF RID: 175567 RVA: 0x009EDD54 File Offset: 0x009EBF54
		public NCS_In_Lv10_C() : this(BuiltinUtils.AllocNativeUObject(NCS_In_Lv10_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADD0 RID: 175568 RVA: 0x009EDD7C File Offset: 0x009EBF7C
		[NullableContext(1)]
		public NCS_In_Lv10_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_In_Lv10_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADD1 RID: 175569 RVA: 0x009EDDAF File Offset: 0x009EBFAF
		protected NCS_In_Lv10_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401635D RID: 90973
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv10.NCS_In_Lv10_C";

		// Token: 0x0401635E RID: 90974
		private static IntPtr _ClassPtr;

		// Token: 0x0401635F RID: 90975
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
