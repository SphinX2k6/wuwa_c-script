using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Up
{
	// Token: 0x020040CA RID: 16586
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv1.NCS_Up_Lv1_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Up_Lv1_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ACFA RID: 175354 RVA: 0x009EC108 File Offset: 0x009EA308
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Up_Lv1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv1.NCS_Up_Lv1_C");
			}
			return NCS_Up_Lv1_C._ClassPtr;
		}

		// Token: 0x0602ACFB RID: 175355 RVA: 0x009EC12C File Offset: 0x009EA32C
		public NCS_Up_Lv1_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Up_Lv1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ACFC RID: 175356 RVA: 0x009EC154 File Offset: 0x009EA354
		[NullableContext(1)]
		public NCS_Up_Lv1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Up_Lv1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ACFD RID: 175357 RVA: 0x009EC187 File Offset: 0x009EA387
		protected NCS_Up_Lv1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040162BE RID: 90814
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Up/NCS_Up_Lv1.NCS_Up_Lv1_C";

		// Token: 0x040162BF RID: 90815
		private static IntPtr _ClassPtr;

		// Token: 0x040162C0 RID: 90816
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
