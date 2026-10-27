using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Random
{
	// Token: 0x020040E3 RID: 16611
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv5.NCS_Random_Lv5_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Random_Lv5_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD5E RID: 175454 RVA: 0x009ECE50 File Offset: 0x009EB050
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Random_Lv5_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv5.NCS_Random_Lv5_C");
			}
			return NCS_Random_Lv5_C._ClassPtr;
		}

		// Token: 0x0602AD5F RID: 175455 RVA: 0x009ECE74 File Offset: 0x009EB074
		public NCS_Random_Lv5_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv5_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD60 RID: 175456 RVA: 0x009ECE9C File Offset: 0x009EB09C
		[NullableContext(1)]
		public NCS_Random_Lv5_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv5_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD61 RID: 175457 RVA: 0x009ECECF File Offset: 0x009EB0CF
		protected NCS_Random_Lv5_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016309 RID: 90889
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv5.NCS_Random_Lv5_C";

		// Token: 0x0401630A RID: 90890
		private static IntPtr _ClassPtr;

		// Token: 0x0401630B RID: 90891
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
