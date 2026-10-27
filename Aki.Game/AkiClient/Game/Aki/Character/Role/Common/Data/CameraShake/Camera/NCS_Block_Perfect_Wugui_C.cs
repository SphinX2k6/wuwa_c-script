using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera
{
	// Token: 0x020040BC RID: 16572
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Block_Perfect_Wugui.NCS_Block_Perfect_Wugui_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Block_Perfect_Wugui_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ACC2 RID: 175298 RVA: 0x009EB998 File Offset: 0x009E9B98
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Block_Perfect_Wugui_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Block_Perfect_Wugui.NCS_Block_Perfect_Wugui_C");
			}
			return NCS_Block_Perfect_Wugui_C._ClassPtr;
		}

		// Token: 0x0602ACC3 RID: 175299 RVA: 0x009EB9BC File Offset: 0x009E9BBC
		public NCS_Block_Perfect_Wugui_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Block_Perfect_Wugui_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ACC4 RID: 175300 RVA: 0x009EB9E4 File Offset: 0x009E9BE4
		[NullableContext(1)]
		public NCS_Block_Perfect_Wugui_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Block_Perfect_Wugui_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ACC5 RID: 175301 RVA: 0x009EBA17 File Offset: 0x009E9C17
		protected NCS_Block_Perfect_Wugui_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016294 RID: 90772
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Block_Perfect_Wugui.NCS_Block_Perfect_Wugui_C";

		// Token: 0x04016295 RID: 90773
		private static IntPtr _ClassPtr;

		// Token: 0x04016296 RID: 90774
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
