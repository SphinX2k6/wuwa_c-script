using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Out
{
	// Token: 0x020040F1 RID: 16625
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv7.NCS_Out_Lv7_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Out_Lv7_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD96 RID: 175510 RVA: 0x009ED5C0 File Offset: 0x009EB7C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Out_Lv7_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv7.NCS_Out_Lv7_C");
			}
			return NCS_Out_Lv7_C._ClassPtr;
		}

		// Token: 0x0602AD97 RID: 175511 RVA: 0x009ED5E4 File Offset: 0x009EB7E4
		public NCS_Out_Lv7_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv7_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD98 RID: 175512 RVA: 0x009ED60C File Offset: 0x009EB80C
		[NullableContext(1)]
		public NCS_Out_Lv7_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv7_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD99 RID: 175513 RVA: 0x009ED63F File Offset: 0x009EB83F
		protected NCS_Out_Lv7_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016333 RID: 90931
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv7.NCS_Out_Lv7_C";

		// Token: 0x04016334 RID: 90932
		private static IntPtr _ClassPtr;

		// Token: 0x04016335 RID: 90933
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
