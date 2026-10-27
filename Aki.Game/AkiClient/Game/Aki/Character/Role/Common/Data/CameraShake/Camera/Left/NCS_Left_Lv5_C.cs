using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Left
{
	// Token: 0x020040FA RID: 16634
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv5.NCS_Left_Lv5_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Left_Lv5_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADBA RID: 175546 RVA: 0x009EDA88 File Offset: 0x009EBC88
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Left_Lv5_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv5.NCS_Left_Lv5_C");
			}
			return NCS_Left_Lv5_C._ClassPtr;
		}

		// Token: 0x0602ADBB RID: 175547 RVA: 0x009EDAAC File Offset: 0x009EBCAC
		public NCS_Left_Lv5_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Left_Lv5_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADBC RID: 175548 RVA: 0x009EDAD4 File Offset: 0x009EBCD4
		[NullableContext(1)]
		public NCS_Left_Lv5_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Left_Lv5_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADBD RID: 175549 RVA: 0x009EDB07 File Offset: 0x009EBD07
		protected NCS_Left_Lv5_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401634E RID: 90958
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv5.NCS_Left_Lv5_C";

		// Token: 0x0401634F RID: 90959
		private static IntPtr _ClassPtr;

		// Token: 0x04016350 RID: 90960
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
