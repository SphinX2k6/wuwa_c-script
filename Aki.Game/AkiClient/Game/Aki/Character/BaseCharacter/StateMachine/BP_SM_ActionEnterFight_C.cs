using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200435D RID: 17245
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionEnterFight.BP_SM_ActionEnterFight_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_SM_ActionEnterFight_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB54 RID: 183124 RVA: 0x00A266E0 File Offset: 0x00A248E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionEnterFight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionEnterFight.BP_SM_ActionEnterFight_C");
			}
			return BP_SM_ActionEnterFight_C._ClassPtr;
		}

		// Token: 0x0602CB55 RID: 183125 RVA: 0x00A26704 File Offset: 0x00A24904
		public BP_SM_ActionEnterFight_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionEnterFight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB56 RID: 183126 RVA: 0x00A2672C File Offset: 0x00A2492C
		[NullableContext(1)]
		public BP_SM_ActionEnterFight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionEnterFight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602CB57 RID: 183127 RVA: 0x00A2675F File Offset: 0x00A2495F
		protected BP_SM_ActionEnterFight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401792D RID: 96557
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionEnterFight.BP_SM_ActionEnterFight_C";

		// Token: 0x0401792E RID: 96558
		private static IntPtr _ClassPtr;

		// Token: 0x0401792F RID: 96559
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
