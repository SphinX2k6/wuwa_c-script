using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Random
{
	// Token: 0x020040E2 RID: 16610
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv4.NCS_Random_Lv4_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Random_Lv4_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD5A RID: 175450 RVA: 0x009ECDC8 File Offset: 0x009EAFC8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Random_Lv4_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv4.NCS_Random_Lv4_C");
			}
			return NCS_Random_Lv4_C._ClassPtr;
		}

		// Token: 0x0602AD5B RID: 175451 RVA: 0x009ECDEC File Offset: 0x009EAFEC
		public NCS_Random_Lv4_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv4_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD5C RID: 175452 RVA: 0x009ECE14 File Offset: 0x009EB014
		[NullableContext(1)]
		public NCS_Random_Lv4_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv4_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD5D RID: 175453 RVA: 0x009ECE47 File Offset: 0x009EB047
		protected NCS_Random_Lv4_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016306 RID: 90886
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv4.NCS_Random_Lv4_C";

		// Token: 0x04016307 RID: 90887
		private static IntPtr _ClassPtr;

		// Token: 0x04016308 RID: 90888
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
