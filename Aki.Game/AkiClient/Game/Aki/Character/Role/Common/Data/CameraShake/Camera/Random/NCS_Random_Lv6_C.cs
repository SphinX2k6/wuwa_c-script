using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Random
{
	// Token: 0x020040E4 RID: 16612
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv6.NCS_Random_Lv6_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Random_Lv6_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD62 RID: 175458 RVA: 0x009ECED8 File Offset: 0x009EB0D8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Random_Lv6_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv6.NCS_Random_Lv6_C");
			}
			return NCS_Random_Lv6_C._ClassPtr;
		}

		// Token: 0x0602AD63 RID: 175459 RVA: 0x009ECEFC File Offset: 0x009EB0FC
		public NCS_Random_Lv6_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv6_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD64 RID: 175460 RVA: 0x009ECF24 File Offset: 0x009EB124
		[NullableContext(1)]
		public NCS_Random_Lv6_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv6_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD65 RID: 175461 RVA: 0x009ECF57 File Offset: 0x009EB157
		protected NCS_Random_Lv6_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401630C RID: 90892
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv6.NCS_Random_Lv6_C";

		// Token: 0x0401630D RID: 90893
		private static IntPtr _ClassPtr;

		// Token: 0x0401630E RID: 90894
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
