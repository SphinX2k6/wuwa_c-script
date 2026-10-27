using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200438F RID: 17295
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskGroupPatrol.BP_SM_TaskGroupPatrol_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_SM_TaskGroupPatrol_C : UASMTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CCC8 RID: 183496 RVA: 0x00A28ED6 File Offset: 0x00A270D6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_TaskGroupPatrol_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskGroupPatrol.BP_SM_TaskGroupPatrol_C");
			}
			return BP_SM_TaskGroupPatrol_C._ClassPtr;
		}

		// Token: 0x0602CCC9 RID: 183497 RVA: 0x00A28EFC File Offset: 0x00A270FC
		public BP_SM_TaskGroupPatrol_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskGroupPatrol_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CCCA RID: 183498 RVA: 0x00A28F24 File Offset: 0x00A27124
		[NullableContext(1)]
		public BP_SM_TaskGroupPatrol_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskGroupPatrol_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602CCCB RID: 183499 RVA: 0x00A28F57 File Offset: 0x00A27157
		protected BP_SM_TaskGroupPatrol_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017A20 RID: 96800
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskGroupPatrol.BP_SM_TaskGroupPatrol_C";

		// Token: 0x04017A21 RID: 96801
		private static IntPtr _ClassPtr;

		// Token: 0x04017A22 RID: 96802
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
