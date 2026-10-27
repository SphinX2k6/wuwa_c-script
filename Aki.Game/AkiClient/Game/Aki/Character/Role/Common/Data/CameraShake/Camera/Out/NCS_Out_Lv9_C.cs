using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Out
{
	// Token: 0x020040F4 RID: 16628
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv9.NCS_Out_Lv9_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Out_Lv9_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADA2 RID: 175522 RVA: 0x009ED758 File Offset: 0x009EB958
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Out_Lv9_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv9.NCS_Out_Lv9_C");
			}
			return NCS_Out_Lv9_C._ClassPtr;
		}

		// Token: 0x0602ADA3 RID: 175523 RVA: 0x009ED77C File Offset: 0x009EB97C
		public NCS_Out_Lv9_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv9_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADA4 RID: 175524 RVA: 0x009ED7A4 File Offset: 0x009EB9A4
		[NullableContext(1)]
		public NCS_Out_Lv9_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv9_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADA5 RID: 175525 RVA: 0x009ED7D7 File Offset: 0x009EB9D7
		protected NCS_Out_Lv9_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401633C RID: 90940
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv9.NCS_Out_Lv9_C";

		// Token: 0x0401633D RID: 90941
		private static IntPtr _ClassPtr;

		// Token: 0x0401633E RID: 90942
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
