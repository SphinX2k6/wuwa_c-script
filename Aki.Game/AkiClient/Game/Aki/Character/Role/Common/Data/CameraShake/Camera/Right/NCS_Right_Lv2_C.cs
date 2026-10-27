using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Right
{
	// Token: 0x020040D5 RID: 16597
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv2.NCS_Right_Lv2_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Right_Lv2_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD26 RID: 175398 RVA: 0x009EC6E0 File Offset: 0x009EA8E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Right_Lv2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv2.NCS_Right_Lv2_C");
			}
			return NCS_Right_Lv2_C._ClassPtr;
		}

		// Token: 0x0602AD27 RID: 175399 RVA: 0x009EC704 File Offset: 0x009EA904
		public NCS_Right_Lv2_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Right_Lv2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD28 RID: 175400 RVA: 0x009EC72C File Offset: 0x009EA92C
		[NullableContext(1)]
		public NCS_Right_Lv2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Right_Lv2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD29 RID: 175401 RVA: 0x009EC75F File Offset: 0x009EA95F
		protected NCS_Right_Lv2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162DF RID: 90847
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv2.NCS_Right_Lv2_C";

		// Token: 0x040162E0 RID: 90848
		private static IntPtr _ClassPtr;

		// Token: 0x040162E1 RID: 90849
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
