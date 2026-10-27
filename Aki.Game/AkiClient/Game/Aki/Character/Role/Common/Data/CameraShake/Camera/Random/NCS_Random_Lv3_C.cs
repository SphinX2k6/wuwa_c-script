using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Random
{
	// Token: 0x020040E1 RID: 16609
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv3.NCS_Random_Lv3_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Random_Lv3_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD56 RID: 175446 RVA: 0x009ECD40 File Offset: 0x009EAF40
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Random_Lv3_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv3.NCS_Random_Lv3_C");
			}
			return NCS_Random_Lv3_C._ClassPtr;
		}

		// Token: 0x0602AD57 RID: 175447 RVA: 0x009ECD64 File Offset: 0x009EAF64
		public NCS_Random_Lv3_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv3_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD58 RID: 175448 RVA: 0x009ECD8C File Offset: 0x009EAF8C
		[NullableContext(1)]
		public NCS_Random_Lv3_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Random_Lv3_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD59 RID: 175449 RVA: 0x009ECDBF File Offset: 0x009EAFBF
		protected NCS_Random_Lv3_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016303 RID: 90883
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Random/NCS_Random_Lv3.NCS_Random_Lv3_C";

		// Token: 0x04016304 RID: 90884
		private static IntPtr _ClassPtr;

		// Token: 0x04016305 RID: 90885
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
