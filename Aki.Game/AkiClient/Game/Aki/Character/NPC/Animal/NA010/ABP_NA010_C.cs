using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA010
{
	// Token: 0x02004232 RID: 16946
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA010/ABP_NA010.ABP_NA010_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA010_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BEBE RID: 179902 RVA: 0x00A0EE74 File Offset: 0x00A0D074
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA010_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA010/ABP_NA010.ABP_NA010_C");
			}
			return ABP_NA010_C._ClassPtr;
		}

		// Token: 0x0602BEBF RID: 179903 RVA: 0x00A0EE98 File Offset: 0x00A0D098
		public ABP_NA010_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA010_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BEC0 RID: 179904 RVA: 0x00A0EEC0 File Offset: 0x00A0D0C0
		[NullableContext(1)]
		public ABP_NA010_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA010_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BEC1 RID: 179905 RVA: 0x00A0EEF3 File Offset: 0x00A0D0F3
		protected ABP_NA010_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016ED6 RID: 93910
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA010/ABP_NA010.ABP_NA010_C";

		// Token: 0x04016ED7 RID: 93911
		private static IntPtr _ClassPtr;

		// Token: 0x04016ED8 RID: 93912
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
