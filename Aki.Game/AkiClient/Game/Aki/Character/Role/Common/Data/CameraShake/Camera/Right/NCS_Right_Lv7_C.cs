using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Right
{
	// Token: 0x020040DA RID: 16602
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv7.NCS_Right_Lv7_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Right_Lv7_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD3A RID: 175418 RVA: 0x009EC988 File Offset: 0x009EAB88
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Right_Lv7_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv7.NCS_Right_Lv7_C");
			}
			return NCS_Right_Lv7_C._ClassPtr;
		}

		// Token: 0x0602AD3B RID: 175419 RVA: 0x009EC9AC File Offset: 0x009EABAC
		public NCS_Right_Lv7_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Right_Lv7_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD3C RID: 175420 RVA: 0x009EC9D4 File Offset: 0x009EABD4
		[NullableContext(1)]
		public NCS_Right_Lv7_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Right_Lv7_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD3D RID: 175421 RVA: 0x009ECA07 File Offset: 0x009EAC07
		protected NCS_Right_Lv7_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162EE RID: 90862
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Right/NCS_Right_Lv7.NCS_Right_Lv7_C";

		// Token: 0x040162EF RID: 90863
		private static IntPtr _ClassPtr;

		// Token: 0x040162F0 RID: 90864
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
