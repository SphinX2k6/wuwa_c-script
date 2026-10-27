using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200435E RID: 17246
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionExitHit.BP_SM_ActionExitHit_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_SM_ActionExitHit_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB58 RID: 183128 RVA: 0x00A26768 File Offset: 0x00A24968
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionExitHit_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionExitHit.BP_SM_ActionExitHit_C");
			}
			return BP_SM_ActionExitHit_C._ClassPtr;
		}

		// Token: 0x0602CB59 RID: 183129 RVA: 0x00A2678C File Offset: 0x00A2498C
		public BP_SM_ActionExitHit_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionExitHit_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB5A RID: 183130 RVA: 0x00A267B4 File Offset: 0x00A249B4
		[NullableContext(1)]
		public BP_SM_ActionExitHit_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionExitHit_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602CB5B RID: 183131 RVA: 0x00A267E7 File Offset: 0x00A249E7
		protected BP_SM_ActionExitHit_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017930 RID: 96560
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionExitHit.BP_SM_ActionExitHit_C";

		// Token: 0x04017931 RID: 96561
		private static IntPtr _ClassPtr;

		// Token: 0x04017932 RID: 96562
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
