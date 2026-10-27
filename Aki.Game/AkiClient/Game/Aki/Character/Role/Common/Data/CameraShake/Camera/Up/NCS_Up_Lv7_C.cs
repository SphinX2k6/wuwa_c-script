using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Up
{
	// Token: 0x020040D0 RID: 16592
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv7.NCS_Up_Lv7_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Up_Lv7_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD12 RID: 175378 RVA: 0x009EC438 File Offset: 0x009EA638
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Up_Lv7_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv7.NCS_Up_Lv7_C");
			}
			return NCS_Up_Lv7_C._ClassPtr;
		}

		// Token: 0x0602AD13 RID: 175379 RVA: 0x009EC45C File Offset: 0x009EA65C
		public NCS_Up_Lv7_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Up_Lv7_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD14 RID: 175380 RVA: 0x009EC484 File Offset: 0x009EA684
		[NullableContext(1)]
		public NCS_Up_Lv7_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Up_Lv7_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD15 RID: 175381 RVA: 0x009EC4B7 File Offset: 0x009EA6B7
		protected NCS_Up_Lv7_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162D0 RID: 90832
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv7.NCS_Up_Lv7_C";

		// Token: 0x040162D1 RID: 90833
		private static IntPtr _ClassPtr;

		// Token: 0x040162D2 RID: 90834
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
