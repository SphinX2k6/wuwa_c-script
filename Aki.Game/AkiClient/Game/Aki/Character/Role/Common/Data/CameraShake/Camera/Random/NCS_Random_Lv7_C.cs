using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Random
{
	// Token: 0x020040E5 RID: 16613
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv7.NCS_Random_Lv7_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Random_Lv7_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD66 RID: 175462 RVA: 0x009ECF60 File Offset: 0x009EB160
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Random_Lv7_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv7.NCS_Random_Lv7_C");
			}
			return NCS_Random_Lv7_C._ClassPtr;
		}

		// Token: 0x0602AD67 RID: 175463 RVA: 0x009ECF84 File Offset: 0x009EB184
		public NCS_Random_Lv7_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv7_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD68 RID: 175464 RVA: 0x009ECFAC File Offset: 0x009EB1AC
		[NullableContext(1)]
		public NCS_Random_Lv7_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv7_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD69 RID: 175465 RVA: 0x009ECFDF File Offset: 0x009EB1DF
		protected NCS_Random_Lv7_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401630F RID: 90895
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv7.NCS_Random_Lv7_C";

		// Token: 0x04016310 RID: 90896
		private static IntPtr _ClassPtr;

		// Token: 0x04016311 RID: 90897
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
