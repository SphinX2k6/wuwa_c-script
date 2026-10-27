using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Down
{
	// Token: 0x02004113 RID: 16659
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv9.NCS_Down_Lv9_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Down_Lv9_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AE1E RID: 175646 RVA: 0x009EE7D0 File Offset: 0x009EC9D0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Down_Lv9_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv9.NCS_Down_Lv9_C");
			}
			return NCS_Down_Lv9_C._ClassPtr;
		}

		// Token: 0x0602AE1F RID: 175647 RVA: 0x009EE7F4 File Offset: 0x009EC9F4
		public NCS_Down_Lv9_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv9_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AE20 RID: 175648 RVA: 0x009EE81C File Offset: 0x009ECA1C
		[NullableContext(1)]
		public NCS_Down_Lv9_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv9_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AE21 RID: 175649 RVA: 0x009EE84F File Offset: 0x009ECA4F
		protected NCS_Down_Lv9_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016399 RID: 91033
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv9.NCS_Down_Lv9_C";

		// Token: 0x0401639A RID: 91034
		private static IntPtr _ClassPtr;

		// Token: 0x0401639B RID: 91035
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
