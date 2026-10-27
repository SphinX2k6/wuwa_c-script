using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Out
{
	// Token: 0x020040EB RID: 16619
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv1.NCS_Out_Lv1_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Out_Lv1_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD7E RID: 175486 RVA: 0x009ED290 File Offset: 0x009EB490
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Out_Lv1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv1.NCS_Out_Lv1_C");
			}
			return NCS_Out_Lv1_C._ClassPtr;
		}

		// Token: 0x0602AD7F RID: 175487 RVA: 0x009ED2B4 File Offset: 0x009EB4B4
		public NCS_Out_Lv1_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD80 RID: 175488 RVA: 0x009ED2DC File Offset: 0x009EB4DC
		[NullableContext(1)]
		public NCS_Out_Lv1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD81 RID: 175489 RVA: 0x009ED30F File Offset: 0x009EB50F
		protected NCS_Out_Lv1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016321 RID: 90913
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv1.NCS_Out_Lv1_C";

		// Token: 0x04016322 RID: 90914
		private static IntPtr _ClassPtr;

		// Token: 0x04016323 RID: 90915
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
