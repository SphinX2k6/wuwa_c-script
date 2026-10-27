using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Out
{
	// Token: 0x020040F2 RID: 16626
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv8.NCS_Out_Lv8_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Out_Lv8_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD9A RID: 175514 RVA: 0x009ED648 File Offset: 0x009EB848
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Out_Lv8_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv8.NCS_Out_Lv8_C");
			}
			return NCS_Out_Lv8_C._ClassPtr;
		}

		// Token: 0x0602AD9B RID: 175515 RVA: 0x009ED66C File Offset: 0x009EB86C
		public NCS_Out_Lv8_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv8_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD9C RID: 175516 RVA: 0x009ED694 File Offset: 0x009EB894
		[NullableContext(1)]
		public NCS_Out_Lv8_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv8_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD9D RID: 175517 RVA: 0x009ED6C7 File Offset: 0x009EB8C7
		protected NCS_Out_Lv8_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016336 RID: 90934
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv8.NCS_Out_Lv8_C";

		// Token: 0x04016337 RID: 90935
		private static IntPtr _ClassPtr;

		// Token: 0x04016338 RID: 90936
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
