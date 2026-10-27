using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Left
{
	// Token: 0x020040F5 RID: 16629
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv10.NCS_Left_Lv10_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Left_Lv10_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADA6 RID: 175526 RVA: 0x009ED7E0 File Offset: 0x009EB9E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Left_Lv10_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv10.NCS_Left_Lv10_C");
			}
			return NCS_Left_Lv10_C._ClassPtr;
		}

		// Token: 0x0602ADA7 RID: 175527 RVA: 0x009ED804 File Offset: 0x009EBA04
		public NCS_Left_Lv10_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Left_Lv10_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADA8 RID: 175528 RVA: 0x009ED82C File Offset: 0x009EBA2C
		[NullableContext(1)]
		public NCS_Left_Lv10_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Left_Lv10_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADA9 RID: 175529 RVA: 0x009ED85F File Offset: 0x009EBA5F
		protected NCS_Left_Lv10_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401633F RID: 90943
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Left/NCS_Left_Lv10.NCS_Left_Lv10_C";

		// Token: 0x04016340 RID: 90944
		private static IntPtr _ClassPtr;

		// Token: 0x04016341 RID: 90945
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
