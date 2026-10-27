using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GE.GE_Common_Element
{
	// Token: 0x02004411 RID: 17425
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/GE_PropertySlotReduce.GE_PropertySlotReduce_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class GE_PropertySlotReduce_C : UGameplayEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D140 RID: 184640 RVA: 0x00A30838 File Offset: 0x00A2EA38
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GE_PropertySlotReduce_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/GE_PropertySlotReduce.GE_PropertySlotReduce_C");
			}
			return GE_PropertySlotReduce_C._ClassPtr;
		}

		// Token: 0x0602D141 RID: 184641 RVA: 0x00A3085C File Offset: 0x00A2EA5C
		public GE_PropertySlotReduce_C() : this(BuiltinUtils.AllocNativeUObject(GE_PropertySlotReduce_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D142 RID: 184642 RVA: 0x00A30884 File Offset: 0x00A2EA84
		[NullableContext(1)]
		public GE_PropertySlotReduce_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GE_PropertySlotReduce_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602D143 RID: 184643 RVA: 0x00A308B7 File Offset: 0x00A2EAB7
		protected GE_PropertySlotReduce_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017EE7 RID: 98023
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GE/GE_Common_Element/GE_PropertySlotReduce.GE_PropertySlotReduce_C";

		// Token: 0x04017EE8 RID: 98024
		private static IntPtr _ClassPtr;

		// Token: 0x04017EE9 RID: 98025
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
