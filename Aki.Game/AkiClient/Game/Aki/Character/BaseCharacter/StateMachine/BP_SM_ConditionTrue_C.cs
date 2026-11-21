using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033AD RID: 13229
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTrue.BP_SM_ConditionTrue_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_ConditionTrue_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060218CE RID: 137422 RVA: 0x00963A6B File Offset: 0x00961C6B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionTrue_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTrue.BP_SM_ConditionTrue_C");
			}
			return BP_SM_ConditionTrue_C._ClassPtr;
		}

		// Token: 0x060218CF RID: 137423 RVA: 0x00963A90 File Offset: 0x00961C90
		public BP_SM_ConditionTrue_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionTrue_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060218D0 RID: 137424 RVA: 0x00963AB8 File Offset: 0x00961CB8
		[NullableContext(1)]
		public BP_SM_ConditionTrue_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionTrue_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060218D1 RID: 137425 RVA: 0x00963AEB File Offset: 0x00961CEB
		protected BP_SM_ConditionTrue_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012590 RID: 75152
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTrue.BP_SM_ConditionTrue_C";

		// Token: 0x04012591 RID: 75153
		private static IntPtr _ClassPtr;

		// Token: 0x04012592 RID: 75154
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
