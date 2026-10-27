using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera
{
	// Token: 0x020040BA RID: 16570
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Block_Nomal.NCS_Block_Nomal_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Block_Nomal_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ACBA RID: 175290 RVA: 0x009EB888 File Offset: 0x009E9A88
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Block_Nomal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Block_Nomal.NCS_Block_Nomal_C");
			}
			return NCS_Block_Nomal_C._ClassPtr;
		}

		// Token: 0x0602ACBB RID: 175291 RVA: 0x009EB8AC File Offset: 0x009E9AAC
		public NCS_Block_Nomal_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Block_Nomal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ACBC RID: 175292 RVA: 0x009EB8D4 File Offset: 0x009E9AD4
		[NullableContext(1)]
		public NCS_Block_Nomal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Block_Nomal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ACBD RID: 175293 RVA: 0x009EB907 File Offset: 0x009E9B07
		protected NCS_Block_Nomal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401628E RID: 90766
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Block_Nomal.NCS_Block_Nomal_C";

		// Token: 0x0401628F RID: 90767
		private static IntPtr _ClassPtr;

		// Token: 0x04016290 RID: 90768
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
