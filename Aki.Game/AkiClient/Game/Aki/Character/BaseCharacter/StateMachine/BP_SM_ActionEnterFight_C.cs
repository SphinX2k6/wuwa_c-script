using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200337E RID: 13182
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionEnterFight.BP_SM_ActionEnterFight_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_SM_ActionEnterFight_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021772 RID: 137074 RVA: 0x00961534 File Offset: 0x0095F734
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionEnterFight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionEnterFight.BP_SM_ActionEnterFight_C");
			}
			return BP_SM_ActionEnterFight_C._ClassPtr;
		}

		// Token: 0x06021773 RID: 137075 RVA: 0x00961558 File Offset: 0x0095F758
		public BP_SM_ActionEnterFight_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionEnterFight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021774 RID: 137076 RVA: 0x00961580 File Offset: 0x0095F780
		[NullableContext(1)]
		public BP_SM_ActionEnterFight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionEnterFight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021775 RID: 137077 RVA: 0x009615B3 File Offset: 0x0095F7B3
		protected BP_SM_ActionEnterFight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124AE RID: 74926
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionEnterFight.BP_SM_ActionEnterFight_C";

		// Token: 0x040124AF RID: 74927
		private static IntPtr _ClassPtr;

		// Token: 0x040124B0 RID: 74928
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
