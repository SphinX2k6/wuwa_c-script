using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Right
{
	// Token: 0x020040D4 RID: 16596
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv1.NCS_Right_Lv1_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Right_Lv1_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD22 RID: 175394 RVA: 0x009EC658 File Offset: 0x009EA858
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Right_Lv1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv1.NCS_Right_Lv1_C");
			}
			return NCS_Right_Lv1_C._ClassPtr;
		}

		// Token: 0x0602AD23 RID: 175395 RVA: 0x009EC67C File Offset: 0x009EA87C
		public NCS_Right_Lv1_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Right_Lv1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD24 RID: 175396 RVA: 0x009EC6A4 File Offset: 0x009EA8A4
		[NullableContext(1)]
		public NCS_Right_Lv1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Right_Lv1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD25 RID: 175397 RVA: 0x009EC6D7 File Offset: 0x009EA8D7
		protected NCS_Right_Lv1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162DC RID: 90844
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv1.NCS_Right_Lv1_C";

		// Token: 0x040162DD RID: 90845
		private static IntPtr _ClassPtr;

		// Token: 0x040162DE RID: 90846
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
