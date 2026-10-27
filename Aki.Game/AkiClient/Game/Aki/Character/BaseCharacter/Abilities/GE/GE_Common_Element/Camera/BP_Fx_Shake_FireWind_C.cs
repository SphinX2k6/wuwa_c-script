using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Element.Camera
{
	// Token: 0x02004419 RID: 17433
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/Camera/BP_Fx_Shake_FireWind.BP_Fx_Shake_FireWind_C")]
	[UnrealStructLayout(416, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class BP_Fx_Shake_FireWind_C : UMatineeCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D160 RID: 184672 RVA: 0x00A30C78 File Offset: 0x00A2EE78
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Fx_Shake_FireWind_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/Camera/BP_Fx_Shake_FireWind.BP_Fx_Shake_FireWind_C");
			}
			return BP_Fx_Shake_FireWind_C._ClassPtr;
		}

		// Token: 0x0602D161 RID: 184673 RVA: 0x00A30C9C File Offset: 0x00A2EE9C
		public BP_Fx_Shake_FireWind_C() : this(BuiltinUtils.AllocNativeUObject(BP_Fx_Shake_FireWind_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D162 RID: 184674 RVA: 0x00A30CC4 File Offset: 0x00A2EEC4
		[NullableContext(1)]
		public BP_Fx_Shake_FireWind_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Fx_Shake_FireWind_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D163 RID: 184675 RVA: 0x00A30CF7 File Offset: 0x00A2EEF7
		protected BP_Fx_Shake_FireWind_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EFF RID: 98047
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/Camera/BP_Fx_Shake_FireWind.BP_Fx_Shake_FireWind_C";

		// Token: 0x04017F00 RID: 98048
		private static IntPtr _ClassPtr;

		// Token: 0x04017F01 RID: 98049
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
