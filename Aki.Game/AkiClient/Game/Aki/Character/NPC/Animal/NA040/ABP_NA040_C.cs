using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA040
{
	// Token: 0x02004201 RID: 16897
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA040/ABP_na040.ABP_NA040_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA040_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BDDC RID: 179676 RVA: 0x00A0D0F0 File Offset: 0x00A0B2F0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA040_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA040/ABP_na040.ABP_NA040_C");
			}
			return ABP_NA040_C._ClassPtr;
		}

		// Token: 0x0602BDDD RID: 179677 RVA: 0x00A0D114 File Offset: 0x00A0B314
		public ABP_NA040_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA040_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BDDE RID: 179678 RVA: 0x00A0D13C File Offset: 0x00A0B33C
		[NullableContext(1)]
		public ABP_NA040_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA040_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BDDF RID: 179679 RVA: 0x00A0D16F File Offset: 0x00A0B36F
		protected ABP_NA040_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E32 RID: 93746
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA040/ABP_na040.ABP_NA040_C";

		// Token: 0x04016E33 RID: 93747
		private static IntPtr _ClassPtr;

		// Token: 0x04016E34 RID: 93748
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
