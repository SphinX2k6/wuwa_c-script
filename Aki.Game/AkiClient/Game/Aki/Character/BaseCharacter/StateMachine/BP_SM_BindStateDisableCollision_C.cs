using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003392 RID: 13202
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDisableCollision.BP_SM_BindStateDisableCollision_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_SM_BindStateDisableCollision_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021802 RID: 137218 RVA: 0x009624F0 File Offset: 0x009606F0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateDisableCollision_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDisableCollision.BP_SM_BindStateDisableCollision_C");
			}
			return BP_SM_BindStateDisableCollision_C._ClassPtr;
		}

		// Token: 0x06021803 RID: 137219 RVA: 0x00962514 File Offset: 0x00960714
		public BP_SM_BindStateDisableCollision_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateDisableCollision_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021804 RID: 137220 RVA: 0x0096253C File Offset: 0x0096073C
		[NullableContext(1)]
		public BP_SM_BindStateDisableCollision_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateDisableCollision_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021805 RID: 137221 RVA: 0x0096256F File Offset: 0x0096076F
		protected BP_SM_BindStateDisableCollision_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401250E RID: 75022
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDisableCollision.BP_SM_BindStateDisableCollision_C";

		// Token: 0x0401250F RID: 75023
		private static IntPtr _ClassPtr;

		// Token: 0x04012510 RID: 75024
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
