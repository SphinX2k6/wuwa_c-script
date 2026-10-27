using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004370 RID: 17264
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDisableActor.BP_SM_BindStateDisableActor_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_SM_BindStateDisableActor_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CBE0 RID: 183264 RVA: 0x00A27612 File Offset: 0x00A25812
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateDisableActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDisableActor.BP_SM_BindStateDisableActor_C");
			}
			return BP_SM_BindStateDisableActor_C._ClassPtr;
		}

		// Token: 0x0602CBE1 RID: 183265 RVA: 0x00A27638 File Offset: 0x00A25838
		public BP_SM_BindStateDisableActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateDisableActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CBE2 RID: 183266 RVA: 0x00A27660 File Offset: 0x00A25860
		[NullableContext(1)]
		public BP_SM_BindStateDisableActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateDisableActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602CBE3 RID: 183267 RVA: 0x00A27693 File Offset: 0x00A25893
		protected BP_SM_BindStateDisableActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401798A RID: 96650
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDisableActor.BP_SM_BindStateDisableActor_C";

		// Token: 0x0401798B RID: 96651
		private static IntPtr _ClassPtr;

		// Token: 0x0401798C RID: 96652
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
