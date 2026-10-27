using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Out
{
	// Token: 0x020040E9 RID: 16617
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv10.NCS_Out_Lv10_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Out_Lv10_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD76 RID: 175478 RVA: 0x009ED180 File Offset: 0x009EB380
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Out_Lv10_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv10.NCS_Out_Lv10_C");
			}
			return NCS_Out_Lv10_C._ClassPtr;
		}

		// Token: 0x0602AD77 RID: 175479 RVA: 0x009ED1A4 File Offset: 0x009EB3A4
		public NCS_Out_Lv10_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv10_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD78 RID: 175480 RVA: 0x009ED1CC File Offset: 0x009EB3CC
		[NullableContext(1)]
		public NCS_Out_Lv10_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv10_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD79 RID: 175481 RVA: 0x009ED1FF File Offset: 0x009EB3FF
		protected NCS_Out_Lv10_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401631B RID: 90907
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv10.NCS_Out_Lv10_C";

		// Token: 0x0401631C RID: 90908
		private static IntPtr _ClassPtr;

		// Token: 0x0401631D RID: 90909
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
