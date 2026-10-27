using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Out
{
	// Token: 0x020040EA RID: 16618
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv10_Long.NCS_Out_Lv10_Long_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Out_Lv10_Long_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD7A RID: 175482 RVA: 0x009ED208 File Offset: 0x009EB408
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Out_Lv10_Long_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv10_Long.NCS_Out_Lv10_Long_C");
			}
			return NCS_Out_Lv10_Long_C._ClassPtr;
		}

		// Token: 0x0602AD7B RID: 175483 RVA: 0x009ED22C File Offset: 0x009EB42C
		public NCS_Out_Lv10_Long_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv10_Long_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD7C RID: 175484 RVA: 0x009ED254 File Offset: 0x009EB454
		[NullableContext(1)]
		public NCS_Out_Lv10_Long_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv10_Long_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD7D RID: 175485 RVA: 0x009ED287 File Offset: 0x009EB487
		protected NCS_Out_Lv10_Long_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401631E RID: 90910
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv10_Long.NCS_Out_Lv10_Long_C";

		// Token: 0x0401631F RID: 90911
		private static IntPtr _ClassPtr;

		// Token: 0x04016320 RID: 90912
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
