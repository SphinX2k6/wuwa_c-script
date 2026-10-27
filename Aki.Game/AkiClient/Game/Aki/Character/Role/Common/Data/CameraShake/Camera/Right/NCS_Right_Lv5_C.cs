using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Right
{
	// Token: 0x020040D8 RID: 16600
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv5.NCS_Right_Lv5_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Right_Lv5_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD32 RID: 175410 RVA: 0x009EC878 File Offset: 0x009EAA78
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Right_Lv5_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv5.NCS_Right_Lv5_C");
			}
			return NCS_Right_Lv5_C._ClassPtr;
		}

		// Token: 0x0602AD33 RID: 175411 RVA: 0x009EC89C File Offset: 0x009EAA9C
		public NCS_Right_Lv5_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Right_Lv5_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD34 RID: 175412 RVA: 0x009EC8C4 File Offset: 0x009EAAC4
		[NullableContext(1)]
		public NCS_Right_Lv5_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Right_Lv5_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD35 RID: 175413 RVA: 0x009EC8F7 File Offset: 0x009EAAF7
		protected NCS_Right_Lv5_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162E8 RID: 90856
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv5.NCS_Right_Lv5_C";

		// Token: 0x040162E9 RID: 90857
		private static IntPtr _ClassPtr;

		// Token: 0x040162EA RID: 90858
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
