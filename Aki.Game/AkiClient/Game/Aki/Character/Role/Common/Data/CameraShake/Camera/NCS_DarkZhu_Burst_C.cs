using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera
{
	// Token: 0x020040BD RID: 16573
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_DarkZhu_Burst.NCS_DarkZhu_Burst_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_DarkZhu_Burst_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ACC6 RID: 175302 RVA: 0x009EBA20 File Offset: 0x009E9C20
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_DarkZhu_Burst_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_DarkZhu_Burst.NCS_DarkZhu_Burst_C");
			}
			return NCS_DarkZhu_Burst_C._ClassPtr;
		}

		// Token: 0x0602ACC7 RID: 175303 RVA: 0x009EBA44 File Offset: 0x009E9C44
		public NCS_DarkZhu_Burst_C() : this(BuiltinUtils.AllocNativeUObject(NCS_DarkZhu_Burst_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ACC8 RID: 175304 RVA: 0x009EBA6C File Offset: 0x009E9C6C
		[NullableContext(1)]
		public NCS_DarkZhu_Burst_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_DarkZhu_Burst_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ACC9 RID: 175305 RVA: 0x009EBA9F File Offset: 0x009E9C9F
		protected NCS_DarkZhu_Burst_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016297 RID: 90775
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_DarkZhu_Burst.NCS_DarkZhu_Burst_C";

		// Token: 0x04016298 RID: 90776
		private static IntPtr _ClassPtr;

		// Token: 0x04016299 RID: 90777
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
