using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Out
{
	// Token: 0x020040EF RID: 16623
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv5.NCS_Out_Lv5_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Out_Lv5_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD8E RID: 175502 RVA: 0x009ED4B0 File Offset: 0x009EB6B0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Out_Lv5_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv5.NCS_Out_Lv5_C");
			}
			return NCS_Out_Lv5_C._ClassPtr;
		}

		// Token: 0x0602AD8F RID: 175503 RVA: 0x009ED4D4 File Offset: 0x009EB6D4
		public NCS_Out_Lv5_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv5_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD90 RID: 175504 RVA: 0x009ED4FC File Offset: 0x009EB6FC
		[NullableContext(1)]
		public NCS_Out_Lv5_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv5_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD91 RID: 175505 RVA: 0x009ED52F File Offset: 0x009EB72F
		protected NCS_Out_Lv5_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401632D RID: 90925
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv5.NCS_Out_Lv5_C";

		// Token: 0x0401632E RID: 90926
		private static IntPtr _ClassPtr;

		// Token: 0x0401632F RID: 90927
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
