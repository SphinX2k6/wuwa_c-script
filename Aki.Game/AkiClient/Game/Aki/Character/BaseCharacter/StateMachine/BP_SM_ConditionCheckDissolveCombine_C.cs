using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200339B RID: 13211
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckDissolveCombine.BP_SM_ConditionCheckDissolveCombine_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class BP_SM_ConditionCheckDissolveCombine_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021854 RID: 137300 RVA: 0x00962D47 File Offset: 0x00960F47
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionCheckDissolveCombine_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckDissolveCombine.BP_SM_ConditionCheckDissolveCombine_C");
			}
			return BP_SM_ConditionCheckDissolveCombine_C._ClassPtr;
		}

		// Token: 0x06021855 RID: 137301 RVA: 0x00962D6C File Offset: 0x00960F6C
		public BP_SM_ConditionCheckDissolveCombine_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckDissolveCombine_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021856 RID: 137302 RVA: 0x00962D94 File Offset: 0x00960F94
		[NullableContext(1)]
		public BP_SM_ConditionCheckDissolveCombine_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckDissolveCombine_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021857 RID: 137303 RVA: 0x00962DC7 File Offset: 0x00960FC7
		protected BP_SM_ConditionCheckDissolveCombine_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012541 RID: 75073
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckDissolveCombine.BP_SM_ConditionCheckDissolveCombine_C";

		// Token: 0x04012542 RID: 75074
		private static IntPtr _ClassPtr;

		// Token: 0x04012543 RID: 75075
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
