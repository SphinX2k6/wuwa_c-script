using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Up
{
	// Token: 0x020040CB RID: 16587
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv2.NCS_Up_Lv2_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Up_Lv2_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ACFE RID: 175358 RVA: 0x009EC190 File Offset: 0x009EA390
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Up_Lv2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv2.NCS_Up_Lv2_C");
			}
			return NCS_Up_Lv2_C._ClassPtr;
		}

		// Token: 0x0602ACFF RID: 175359 RVA: 0x009EC1B4 File Offset: 0x009EA3B4
		public NCS_Up_Lv2_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Up_Lv2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD00 RID: 175360 RVA: 0x009EC1DC File Offset: 0x009EA3DC
		[NullableContext(1)]
		public NCS_Up_Lv2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Up_Lv2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD01 RID: 175361 RVA: 0x009EC20F File Offset: 0x009EA40F
		protected NCS_Up_Lv2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162C1 RID: 90817
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv2.NCS_Up_Lv2_C";

		// Token: 0x040162C2 RID: 90818
		private static IntPtr _ClassPtr;

		// Token: 0x040162C3 RID: 90819
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
