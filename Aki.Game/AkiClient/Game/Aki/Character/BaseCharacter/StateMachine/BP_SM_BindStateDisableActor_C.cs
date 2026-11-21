using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003391 RID: 13201
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDisableActor.BP_SM_BindStateDisableActor_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_SM_BindStateDisableActor_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060217FE RID: 137214 RVA: 0x00962466 File Offset: 0x00960666
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateDisableActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDisableActor.BP_SM_BindStateDisableActor_C");
			}
			return BP_SM_BindStateDisableActor_C._ClassPtr;
		}

		// Token: 0x060217FF RID: 137215 RVA: 0x0096248C File Offset: 0x0096068C
		public BP_SM_BindStateDisableActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateDisableActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021800 RID: 137216 RVA: 0x009624B4 File Offset: 0x009606B4
		[NullableContext(1)]
		public BP_SM_BindStateDisableActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateDisableActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021801 RID: 137217 RVA: 0x009624E7 File Offset: 0x009606E7
		protected BP_SM_BindStateDisableActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401250B RID: 75019
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDisableActor.BP_SM_BindStateDisableActor_C";

		// Token: 0x0401250C RID: 75020
		private static IntPtr _ClassPtr;

		// Token: 0x0401250D RID: 75021
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
