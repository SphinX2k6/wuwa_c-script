using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Out
{
	// Token: 0x020040ED RID: 16621
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv3.NCS_Out_Lv3_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Out_Lv3_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD86 RID: 175494 RVA: 0x009ED3A0 File Offset: 0x009EB5A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Out_Lv3_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv3.NCS_Out_Lv3_C");
			}
			return NCS_Out_Lv3_C._ClassPtr;
		}

		// Token: 0x0602AD87 RID: 175495 RVA: 0x009ED3C4 File Offset: 0x009EB5C4
		public NCS_Out_Lv3_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv3_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD88 RID: 175496 RVA: 0x009ED3EC File Offset: 0x009EB5EC
		[NullableContext(1)]
		public NCS_Out_Lv3_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Lv3_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD89 RID: 175497 RVA: 0x009ED41F File Offset: 0x009EB61F
		protected NCS_Out_Lv3_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016327 RID: 90919
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Lv3.NCS_Out_Lv3_C";

		// Token: 0x04016328 RID: 90920
		private static IntPtr _ClassPtr;

		// Token: 0x04016329 RID: 90921
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
