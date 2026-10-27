using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA061
{
	// Token: 0x020041D1 RID: 16849
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA061/ABP_NA061.ABP_NA061_C")]
	[UnrealStructLayout(19248, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 19234)]
	public class ABP_NA061_C : ABP_BaseRunAnimal_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BCD8 RID: 179416 RVA: 0x00A0AFBC File Offset: 0x00A091BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_NA061_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA061/ABP_NA061.ABP_NA061_C");
			}
			return ABP_NA061_C._ClassPtr;
		}

		// Token: 0x0602BCD9 RID: 179417 RVA: 0x00A0AFE0 File Offset: 0x00A091E0
		public ABP_NA061_C() : this(BuiltinUtils.AllocNativeUObject(ABP_NA061_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BCDA RID: 179418 RVA: 0x00A0B008 File Offset: 0x00A09208
		[NullableContext(1)]
		public ABP_NA061_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_NA061_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602BCDB RID: 179419 RVA: 0x00A0B03B File Offset: 0x00A0923B
		protected ABP_NA061_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016D76 RID: 93558
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA061/ABP_NA061.ABP_NA061_C";

		// Token: 0x04016D77 RID: 93559
		private static IntPtr _ClassPtr;

		// Token: 0x04016D78 RID: 93560
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
