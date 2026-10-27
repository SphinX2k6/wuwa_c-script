using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA028
{
	// Token: 0x02004214 RID: 16916
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA028/ABP_NA028.ABP_NA028_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA028_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE32 RID: 179762 RVA: 0x00A0DBD8 File Offset: 0x00A0BDD8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA028_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA028/ABP_NA028.ABP_NA028_C");
			}
			return ABP_NA028_C._ClassPtr;
		}

		// Token: 0x0602BE33 RID: 179763 RVA: 0x00A0DBFC File Offset: 0x00A0BDFC
		public ABP_NA028_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA028_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE34 RID: 179764 RVA: 0x00A0DC24 File Offset: 0x00A0BE24
		[NullableContext(1)]
		public ABP_NA028_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA028_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE35 RID: 179765 RVA: 0x00A0DC57 File Offset: 0x00A0BE57
		protected ABP_NA028_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E70 RID: 93808
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA028/ABP_NA028.ABP_NA028_C";

		// Token: 0x04016E71 RID: 93809
		private static IntPtr _ClassPtr;

		// Token: 0x04016E72 RID: 93810
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
