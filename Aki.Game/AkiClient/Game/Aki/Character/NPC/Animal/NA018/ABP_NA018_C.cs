using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA018
{
	// Token: 0x0200421C RID: 16924
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA018/ABP_NA018.ABP_NA018_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA018_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE56 RID: 179798 RVA: 0x00A0E070 File Offset: 0x00A0C270
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA018_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA018/ABP_NA018.ABP_NA018_C");
			}
			return ABP_NA018_C._ClassPtr;
		}

		// Token: 0x0602BE57 RID: 179799 RVA: 0x00A0E094 File Offset: 0x00A0C294
		public ABP_NA018_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA018_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE58 RID: 179800 RVA: 0x00A0E0BC File Offset: 0x00A0C2BC
		[NullableContext(1)]
		public ABP_NA018_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA018_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE59 RID: 179801 RVA: 0x00A0E0EF File Offset: 0x00A0C2EF
		protected ABP_NA018_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E8A RID: 93834
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA018/ABP_NA018.ABP_NA018_C";

		// Token: 0x04016E8B RID: 93835
		private static IntPtr _ClassPtr;

		// Token: 0x04016E8C RID: 93836
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
