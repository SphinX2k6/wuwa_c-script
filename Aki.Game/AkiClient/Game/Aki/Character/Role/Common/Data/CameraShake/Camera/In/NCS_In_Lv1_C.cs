using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.In
{
	// Token: 0x02004100 RID: 16640
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv1.NCS_In_Lv1_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_In_Lv1_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADD2 RID: 175570 RVA: 0x009EDDB8 File Offset: 0x009EBFB8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_In_Lv1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv1.NCS_In_Lv1_C");
			}
			return NCS_In_Lv1_C._ClassPtr;
		}

		// Token: 0x0602ADD3 RID: 175571 RVA: 0x009EDDDC File Offset: 0x009EBFDC
		public NCS_In_Lv1_C() : this(BuiltinUtils.AllocNativeUObject(NCS_In_Lv1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ADD4 RID: 175572 RVA: 0x009EDE04 File Offset: 0x009EC004
		[NullableContext(1)]
		public NCS_In_Lv1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_In_Lv1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ADD5 RID: 175573 RVA: 0x009EDE37 File Offset: 0x009EC037
		protected NCS_In_Lv1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016360 RID: 90976
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/In/NCS_In_Lv1.NCS_In_Lv1_C";

		// Token: 0x04016361 RID: 90977
		private static IntPtr _ClassPtr;

		// Token: 0x04016362 RID: 90978
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
