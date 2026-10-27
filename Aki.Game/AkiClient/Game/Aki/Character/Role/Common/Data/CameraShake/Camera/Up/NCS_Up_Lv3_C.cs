using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Up
{
	// Token: 0x020040CC RID: 16588
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv3.NCS_Up_Lv3_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Up_Lv3_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD02 RID: 175362 RVA: 0x009EC218 File Offset: 0x009EA418
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Up_Lv3_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv3.NCS_Up_Lv3_C");
			}
			return NCS_Up_Lv3_C._ClassPtr;
		}

		// Token: 0x0602AD03 RID: 175363 RVA: 0x009EC23C File Offset: 0x009EA43C
		public NCS_Up_Lv3_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Up_Lv3_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD04 RID: 175364 RVA: 0x009EC264 File Offset: 0x009EA464
		[NullableContext(1)]
		public NCS_Up_Lv3_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Up_Lv3_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD05 RID: 175365 RVA: 0x009EC297 File Offset: 0x009EA497
		protected NCS_Up_Lv3_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162C4 RID: 90820
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv3.NCS_Up_Lv3_C";

		// Token: 0x040162C5 RID: 90821
		private static IntPtr _ClassPtr;

		// Token: 0x040162C6 RID: 90822
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
