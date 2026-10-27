using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Camera
{
	// Token: 0x020040B8 RID: 16568
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Camera/CS_Block_Nomal.CS_Block_Nomal_C")]
	[UnrealStructLayout(416, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class CS_Block_Nomal_C : UMatineeCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ACB2 RID: 175282 RVA: 0x009EB775 File Offset: 0x009E9975
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CS_Block_Nomal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/Camera/CS_Block_Nomal.CS_Block_Nomal_C");
			}
			return CS_Block_Nomal_C._ClassPtr;
		}

		// Token: 0x0602ACB3 RID: 175283 RVA: 0x009EB79C File Offset: 0x009E999C
		public CS_Block_Nomal_C() : this(BuiltinUtils.AllocNativeUObject(CS_Block_Nomal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ACB4 RID: 175284 RVA: 0x009EB7C4 File Offset: 0x009E99C4
		[NullableContext(1)]
		public CS_Block_Nomal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CS_Block_Nomal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ACB5 RID: 175285 RVA: 0x009EB7F7 File Offset: 0x009E99F7
		protected CS_Block_Nomal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016288 RID: 90760
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Camera/CS_Block_Nomal.CS_Block_Nomal_C";

		// Token: 0x04016289 RID: 90761
		private static IntPtr _ClassPtr;

		// Token: 0x0401628A RID: 90762
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
