using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033AF RID: 13231
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskGroupPatrol.BP_SM_TaskGroupPatrol_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_SM_TaskGroupPatrol_C : UASMTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060218DE RID: 137438 RVA: 0x00963C2E File Offset: 0x00961E2E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_TaskGroupPatrol_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskGroupPatrol.BP_SM_TaskGroupPatrol_C");
			}
			return BP_SM_TaskGroupPatrol_C._ClassPtr;
		}

		// Token: 0x060218DF RID: 137439 RVA: 0x00963C54 File Offset: 0x00961E54
		public BP_SM_TaskGroupPatrol_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskGroupPatrol_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060218E0 RID: 137440 RVA: 0x00963C7C File Offset: 0x00961E7C
		[NullableContext(1)]
		public BP_SM_TaskGroupPatrol_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskGroupPatrol_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060218E1 RID: 137441 RVA: 0x00963CAF File Offset: 0x00961EAF
		protected BP_SM_TaskGroupPatrol_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401259B RID: 75163
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskGroupPatrol.BP_SM_TaskGroupPatrol_C";

		// Token: 0x0401259C RID: 75164
		private static IntPtr _ClassPtr;

		// Token: 0x0401259D RID: 75165
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
