using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Random
{
	// Token: 0x020040E0 RID: 16608
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv2.NCS_Random_Lv2_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Random_Lv2_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD52 RID: 175442 RVA: 0x009ECCB8 File Offset: 0x009EAEB8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Random_Lv2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv2.NCS_Random_Lv2_C");
			}
			return NCS_Random_Lv2_C._ClassPtr;
		}

		// Token: 0x0602AD53 RID: 175443 RVA: 0x009ECCDC File Offset: 0x009EAEDC
		public NCS_Random_Lv2_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD54 RID: 175444 RVA: 0x009ECD04 File Offset: 0x009EAF04
		[NullableContext(1)]
		public NCS_Random_Lv2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD55 RID: 175445 RVA: 0x009ECD37 File Offset: 0x009EAF37
		protected NCS_Random_Lv2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016300 RID: 90880
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv2.NCS_Random_Lv2_C";

		// Token: 0x04016301 RID: 90881
		private static IntPtr _ClassPtr;

		// Token: 0x04016302 RID: 90882
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
