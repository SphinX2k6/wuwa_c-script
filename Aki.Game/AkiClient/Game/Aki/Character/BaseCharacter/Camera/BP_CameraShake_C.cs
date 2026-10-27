using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x0200439D RID: 17309
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/BP_CameraShake.BP_CameraShake_C")]
	[UnrealStructLayout(416, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class BP_CameraShake_C : UMatineeCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CD46 RID: 183622 RVA: 0x00A29B71 File Offset: 0x00A27D71
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CameraShake_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Camera/BP_CameraShake.BP_CameraShake_C");
			}
			return BP_CameraShake_C._ClassPtr;
		}

		// Token: 0x0602CD47 RID: 183623 RVA: 0x00A29B98 File Offset: 0x00A27D98
		public BP_CameraShake_C() : this(BuiltinUtils.AllocNativeUObject(BP_CameraShake_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CD48 RID: 183624 RVA: 0x00A29BC0 File Offset: 0x00A27DC0
		[NullableContext(1)]
		public BP_CameraShake_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CameraShake_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602CD49 RID: 183625 RVA: 0x00A29BF3 File Offset: 0x00A27DF3
		protected BP_CameraShake_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017A79 RID: 96889
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/BP_CameraShake.BP_CameraShake_C";

		// Token: 0x04017A7A RID: 96890
		private static IntPtr _ClassPtr;

		// Token: 0x04017A7B RID: 96891
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
