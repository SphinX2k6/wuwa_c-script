using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera.Out
{
	// Token: 0x020040E8 RID: 16616
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Location.NCS_Out_Location_C")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class NCS_Out_Location_C : UKuroCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AD72 RID: 175474 RVA: 0x009ED0F8 File Offset: 0x009EB2F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Out_Location_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Location.NCS_Out_Location_C");
			}
			return NCS_Out_Location_C._ClassPtr;
		}

		// Token: 0x0602AD73 RID: 175475 RVA: 0x009ED11C File Offset: 0x009EB31C
		public NCS_Out_Location_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Location_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AD74 RID: 175476 RVA: 0x009ED144 File Offset: 0x009EB344
		[NullableContext(1)]
		public NCS_Out_Location_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Out_Location_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602AD75 RID: 175477 RVA: 0x009ED177 File Offset: 0x009EB377
		protected NCS_Out_Location_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016318 RID: 90904
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/Out/NCS_Out_Location.NCS_Out_Location_C";

		// Token: 0x04016319 RID: 90905
		private static IntPtr _ClassPtr;

		// Token: 0x0401631A RID: 90906
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
