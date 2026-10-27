using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Random
{
	// Token: 0x020040E7 RID: 16615
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv9.NCS_Random_Lv9_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Random_Lv9_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD6E RID: 175470 RVA: 0x009ED070 File Offset: 0x009EB270
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Random_Lv9_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv9.NCS_Random_Lv9_C");
			}
			return NCS_Random_Lv9_C._ClassPtr;
		}

		// Token: 0x0602AD6F RID: 175471 RVA: 0x009ED094 File Offset: 0x009EB294
		public NCS_Random_Lv9_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv9_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD70 RID: 175472 RVA: 0x009ED0BC File Offset: 0x009EB2BC
		[NullableContext(1)]
		public NCS_Random_Lv9_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv9_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD71 RID: 175473 RVA: 0x009ED0EF File Offset: 0x009EB2EF
		protected NCS_Random_Lv9_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016315 RID: 90901
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv9.NCS_Random_Lv9_C";

		// Token: 0x04016316 RID: 90902
		private static IntPtr _ClassPtr;

		// Token: 0x04016317 RID: 90903
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
