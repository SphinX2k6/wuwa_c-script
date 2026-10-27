using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004386 RID: 17286
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionMontageTimeElapsing.BP_SM_ConditionMontageTimeElapsing_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 60)]
	public class BP_SM_ConditionMontageTimeElapsing_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CC82 RID: 183426 RVA: 0x00A28761 File Offset: 0x00A26961
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionMontageTimeElapsing_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionMontageTimeElapsing.BP_SM_ConditionMontageTimeElapsing_C");
			}
			return BP_SM_ConditionMontageTimeElapsing_C._ClassPtr;
		}

		// Token: 0x0602CC83 RID: 183427 RVA: 0x00A28788 File Offset: 0x00A26988
		public BP_SM_ConditionMontageTimeElapsing_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionMontageTimeElapsing_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CC84 RID: 183428 RVA: 0x00A287B0 File Offset: 0x00A269B0
		[NullableContext(1)]
		public BP_SM_ConditionMontageTimeElapsing_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionMontageTimeElapsing_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070CD RID: 28877
		// (get) Token: 0x0602CC85 RID: 183429 RVA: 0x00A287E3 File Offset: 0x00A269E3
		// (set) Token: 0x0602CC86 RID: 183430 RVA: 0x00A287F3 File Offset: 0x00A269F3
		public unsafe int Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionMontageTimeElapsing_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionMontageTimeElapsing_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x0602CC87 RID: 183431 RVA: 0x00A28804 File Offset: 0x00A26A04
		protected BP_SM_ConditionMontageTimeElapsing_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040179F2 RID: 96754
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionMontageTimeElapsing.BP_SM_ConditionMontageTimeElapsing_C";

		// Token: 0x040179F3 RID: 96755
		private static IntPtr _ClassPtr;

		// Token: 0x040179F4 RID: 96756
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040179F5 RID: 96757
		internal static int __PropertyOffset_0;
	}
}
