using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.CameraShake
{
	// Token: 0x020043E1 RID: 17377
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/CameraShake/SprintStepShake.SprintStepShake_C")]
	[UnrealStructLayout(416, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class SprintStepShake_C : UMatineeCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D04E RID: 184398 RVA: 0x00A2E7E6 File Offset: 0x00A2C9E6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (SprintStepShake_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Camera/CameraShake/SprintStepShake.SprintStepShake_C");
			}
			return SprintStepShake_C._ClassPtr;
		}

		// Token: 0x0602D04F RID: 184399 RVA: 0x00A2E80C File Offset: 0x00A2CA0C
		public SprintStepShake_C() : this(BuiltinUtils.AllocNativeUObject(SprintStepShake_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D050 RID: 184400 RVA: 0x00A2E834 File Offset: 0x00A2CA34
		[NullableContext(1)]
		public SprintStepShake_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SprintStepShake_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D051 RID: 184401 RVA: 0x00A2E867 File Offset: 0x00A2CA67
		protected SprintStepShake_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017E3B RID: 97851
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/CameraShake/SprintStepShake.SprintStepShake_C";

		// Token: 0x04017E3C RID: 97852
		private static IntPtr _ClassPtr;

		// Token: 0x04017E3D RID: 97853
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
