using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Random
{
	// Token: 0x020040DE RID: 16606
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv10_Long.NCS_Random_Lv10_Long_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Random_Lv10_Long_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD4A RID: 175434 RVA: 0x009ECBA8 File Offset: 0x009EADA8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Random_Lv10_Long_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv10_Long.NCS_Random_Lv10_Long_C");
			}
			return NCS_Random_Lv10_Long_C._ClassPtr;
		}

		// Token: 0x0602AD4B RID: 175435 RVA: 0x009ECBCC File Offset: 0x009EADCC
		public NCS_Random_Lv10_Long_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv10_Long_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD4C RID: 175436 RVA: 0x009ECBF4 File Offset: 0x009EADF4
		[NullableContext(1)]
		public NCS_Random_Lv10_Long_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv10_Long_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD4D RID: 175437 RVA: 0x009ECC27 File Offset: 0x009EAE27
		protected NCS_Random_Lv10_Long_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162FA RID: 90874
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv10_Long.NCS_Random_Lv10_Long_C";

		// Token: 0x040162FB RID: 90875
		private static IntPtr _ClassPtr;

		// Token: 0x040162FC RID: 90876
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
