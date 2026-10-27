using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Camera
{
	// Token: 0x020040B9 RID: 16569
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Camera/CS_Block_Perfect.CS_Block_Perfect_C")]
	[UnrealStructLayout(416, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class CS_Block_Perfect_C : UMatineeCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602ACB6 RID: 175286 RVA: 0x009EB800 File Offset: 0x009E9A00
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CS_Block_Perfect_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/Camera/CS_Block_Perfect.CS_Block_Perfect_C");
			}
			return CS_Block_Perfect_C._ClassPtr;
		}

		// Token: 0x0602ACB7 RID: 175287 RVA: 0x009EB824 File Offset: 0x009E9A24
		public CS_Block_Perfect_C() : this(BuiltinUtils.AllocNativeUObject(CS_Block_Perfect_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602ACB8 RID: 175288 RVA: 0x009EB84C File Offset: 0x009E9A4C
		[NullableContext(1)]
		public CS_Block_Perfect_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CS_Block_Perfect_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602ACB9 RID: 175289 RVA: 0x009EB87F File Offset: 0x009E9A7F
		protected CS_Block_Perfect_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401628B RID: 90763
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Camera/CS_Block_Perfect.CS_Block_Perfect_C";

		// Token: 0x0401628C RID: 90764
		private static IntPtr _ClassPtr;

		// Token: 0x0401628D RID: 90765
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
