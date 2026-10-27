using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Down
{
	// Token: 0x0200410B RID: 16651
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv1.NCS_Down_Lv1_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Down_Lv1_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ADFE RID: 175614 RVA: 0x009EE390 File Offset: 0x009EC590
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Down_Lv1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv1.NCS_Down_Lv1_C");
			}
			return NCS_Down_Lv1_C._ClassPtr;
		}

		// Token: 0x0602ADFF RID: 175615 RVA: 0x009EE3B4 File Offset: 0x009EC5B4
		public NCS_Down_Lv1_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AE00 RID: 175616 RVA: 0x009EE3DC File Offset: 0x009EC5DC
		[NullableContext(1)]
		public NCS_Down_Lv1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Down_Lv1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AE01 RID: 175617 RVA: 0x009EE40F File Offset: 0x009EC60F
		protected NCS_Down_Lv1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016381 RID: 91009
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Down/NCS_Down_Lv1.NCS_Down_Lv1_C";

		// Token: 0x04016382 RID: 91010
		private static IntPtr _ClassPtr;

		// Token: 0x04016383 RID: 91011
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
