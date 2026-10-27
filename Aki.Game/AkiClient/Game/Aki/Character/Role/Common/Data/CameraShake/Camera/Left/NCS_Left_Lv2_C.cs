using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Left
{
	// Token: 0x020040F7 RID: 16631
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv2.NCS_Left_Lv2_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Left_Lv2_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADAE RID: 175534 RVA: 0x009ED8F0 File Offset: 0x009EBAF0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Left_Lv2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv2.NCS_Left_Lv2_C");
			}
			return NCS_Left_Lv2_C._ClassPtr;
		}

		// Token: 0x0602ADAF RID: 175535 RVA: 0x009ED914 File Offset: 0x009EBB14
		public NCS_Left_Lv2_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Left_Lv2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADB0 RID: 175536 RVA: 0x009ED93C File Offset: 0x009EBB3C
		[NullableContext(1)]
		public NCS_Left_Lv2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Left_Lv2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADB1 RID: 175537 RVA: 0x009ED96F File Offset: 0x009EBB6F
		protected NCS_Left_Lv2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016345 RID: 90949
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv2.NCS_Left_Lv2_C";

		// Token: 0x04016346 RID: 90950
		private static IntPtr _ClassPtr;

		// Token: 0x04016347 RID: 90951
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
