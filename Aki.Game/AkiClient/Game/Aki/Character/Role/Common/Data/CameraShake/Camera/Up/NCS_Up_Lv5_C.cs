using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Up
{
	// Token: 0x020040CE RID: 16590
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv5.NCS_Up_Lv5_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Up_Lv5_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD0A RID: 175370 RVA: 0x009EC328 File Offset: 0x009EA528
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Up_Lv5_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv5.NCS_Up_Lv5_C");
			}
			return NCS_Up_Lv5_C._ClassPtr;
		}

		// Token: 0x0602AD0B RID: 175371 RVA: 0x009EC34C File Offset: 0x009EA54C
		public NCS_Up_Lv5_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Up_Lv5_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD0C RID: 175372 RVA: 0x009EC374 File Offset: 0x009EA574
		[NullableContext(1)]
		public NCS_Up_Lv5_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Up_Lv5_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD0D RID: 175373 RVA: 0x009EC3A7 File Offset: 0x009EA5A7
		protected NCS_Up_Lv5_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162CA RID: 90826
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv5.NCS_Up_Lv5_C";

		// Token: 0x040162CB RID: 90827
		private static IntPtr _ClassPtr;

		// Token: 0x040162CC RID: 90828
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
