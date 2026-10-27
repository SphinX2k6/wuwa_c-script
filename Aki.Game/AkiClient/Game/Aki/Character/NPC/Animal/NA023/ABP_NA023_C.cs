using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA023
{
	// Token: 0x02004219 RID: 16921
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA023/ABP_NA023.ABP_NA023_C")]
	[UnrealStructLayout(18928, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18915)]
	public class ABP_NA023_C : ABP_BaseAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE48 RID: 179784 RVA: 0x00A0DEA9 File Offset: 0x00A0C0A9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA023_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA023/ABP_NA023.ABP_NA023_C");
			}
			return ABP_NA023_C._ClassPtr;
		}

		// Token: 0x0602BE49 RID: 179785 RVA: 0x00A0DED0 File Offset: 0x00A0C0D0
		public ABP_NA023_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA023_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE4A RID: 179786 RVA: 0x00A0DEF8 File Offset: 0x00A0C0F8
		[NullableContext(1)]
		public ABP_NA023_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA023_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BE4B RID: 179787 RVA: 0x00A0DF2B File Offset: 0x00A0C12B
		protected ABP_NA023_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E80 RID: 93824
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA023/ABP_NA023.ABP_NA023_C";

		// Token: 0x04016E81 RID: 93825
		private static IntPtr _ClassPtr;

		// Token: 0x04016E82 RID: 93826
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
