using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera
{
	// Token: 0x020040BE RID: 16574
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_EarthQuake.NCS_EarthQuake_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_EarthQuake_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ACCA RID: 175306 RVA: 0x009EBAA8 File Offset: 0x009E9CA8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_EarthQuake_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_EarthQuake.NCS_EarthQuake_C");
			}
			return NCS_EarthQuake_C._ClassPtr;
		}

		// Token: 0x0602ACCB RID: 175307 RVA: 0x009EBACC File Offset: 0x009E9CCC
		public NCS_EarthQuake_C() : this(BuiltinUtils.AllocNativeUObject(NCS_EarthQuake_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ACCC RID: 175308 RVA: 0x009EBAF4 File Offset: 0x009E9CF4
		[NullableContext(1)]
		public NCS_EarthQuake_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_EarthQuake_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ACCD RID: 175309 RVA: 0x009EBB27 File Offset: 0x009E9D27
		protected NCS_EarthQuake_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401629A RID: 90778
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_EarthQuake.NCS_EarthQuake_C";

		// Token: 0x0401629B RID: 90779
		private static IntPtr _ClassPtr;

		// Token: 0x0401629C RID: 90780
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
