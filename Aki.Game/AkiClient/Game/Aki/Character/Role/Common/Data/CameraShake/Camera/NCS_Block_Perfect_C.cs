using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.CameraShake.Camera
{
	// Token: 0x020040BB RID: 16571
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Block_Perfect.NCS_Block_Perfect_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class NCS_Block_Perfect_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ACBE RID: 175294 RVA: 0x009EB910 File Offset: 0x009E9B10
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NCS_Block_Perfect_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Block_Perfect.NCS_Block_Perfect_C");
			}
			return NCS_Block_Perfect_C._ClassPtr;
		}

		// Token: 0x0602ACBF RID: 175295 RVA: 0x009EB934 File Offset: 0x009E9B34
		public NCS_Block_Perfect_C() : this(BuiltinUtils.AllocNativeUObject(NCS_Block_Perfect_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ACC0 RID: 175296 RVA: 0x009EB95C File Offset: 0x009E9B5C
		[NullableContext(1)]
		public NCS_Block_Perfect_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NCS_Block_Perfect_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ACC1 RID: 175297 RVA: 0x009EB98F File Offset: 0x009E9B8F
		protected NCS_Block_Perfect_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016291 RID: 90769
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/CameraShake/Camera/NCS_Block_Perfect.NCS_Block_Perfect_C";

		// Token: 0x04016292 RID: 90770
		private static IntPtr _ClassPtr;

		// Token: 0x04016293 RID: 90771
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
