using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Random
{
	// Token: 0x020040DD RID: 16605
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv10.NCS_Random_Lv10_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Random_Lv10_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD46 RID: 175430 RVA: 0x009ECB20 File Offset: 0x009EAD20
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Random_Lv10_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv10.NCS_Random_Lv10_C");
			}
			return NCS_Random_Lv10_C._ClassPtr;
		}

		// Token: 0x0602AD47 RID: 175431 RVA: 0x009ECB44 File Offset: 0x009EAD44
		public NCS_Random_Lv10_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv10_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD48 RID: 175432 RVA: 0x009ECB6C File Offset: 0x009EAD6C
		[NullableContext(1)]
		public NCS_Random_Lv10_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv10_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD49 RID: 175433 RVA: 0x009ECB9F File Offset: 0x009EAD9F
		protected NCS_Random_Lv10_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162F7 RID: 90871
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv10.NCS_Random_Lv10_C";

		// Token: 0x040162F8 RID: 90872
		private static IntPtr _ClassPtr;

		// Token: 0x040162F9 RID: 90873
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
