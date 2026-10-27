using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Random
{
	// Token: 0x020040E6 RID: 16614
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv8.NCS_Random_Lv8_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Random_Lv8_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD6A RID: 175466 RVA: 0x009ECFE8 File Offset: 0x009EB1E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Random_Lv8_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv8.NCS_Random_Lv8_C");
			}
			return NCS_Random_Lv8_C._ClassPtr;
		}

		// Token: 0x0602AD6B RID: 175467 RVA: 0x009ED00C File Offset: 0x009EB20C
		public NCS_Random_Lv8_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv8_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD6C RID: 175468 RVA: 0x009ED034 File Offset: 0x009EB234
		[NullableContext(1)]
		public NCS_Random_Lv8_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv8_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD6D RID: 175469 RVA: 0x009ED067 File Offset: 0x009EB267
		protected NCS_Random_Lv8_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016312 RID: 90898
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv8.NCS_Random_Lv8_C";

		// Token: 0x04016313 RID: 90899
		private static IntPtr _ClassPtr;

		// Token: 0x04016314 RID: 90900
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
