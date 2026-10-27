using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004387 RID: 17287
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionMontageTimeRemaining.BP_SM_ConditionMontageTimeRemaining_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 60)]
	public class BP_SM_ConditionMontageTimeRemaining_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CC88 RID: 183432 RVA: 0x00A2880D File Offset: 0x00A26A0D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionMontageTimeRemaining_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionMontageTimeRemaining.BP_SM_ConditionMontageTimeRemaining_C");
			}
			return BP_SM_ConditionMontageTimeRemaining_C._ClassPtr;
		}

		// Token: 0x0602CC89 RID: 183433 RVA: 0x00A28834 File Offset: 0x00A26A34
		public BP_SM_ConditionMontageTimeRemaining_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionMontageTimeRemaining_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CC8A RID: 183434 RVA: 0x00A2885C File Offset: 0x00A26A5C
		[NullableContext(1)]
		public BP_SM_ConditionMontageTimeRemaining_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionMontageTimeRemaining_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070CE RID: 28878
		// (get) Token: 0x0602CC8B RID: 183435 RVA: 0x00A2888F File Offset: 0x00A26A8F
		// (set) Token: 0x0602CC8C RID: 183436 RVA: 0x00A2889F File Offset: 0x00A26A9F
		public unsafe int Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionMontageTimeRemaining_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionMontageTimeRemaining_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x0602CC8D RID: 183437 RVA: 0x00A288B0 File Offset: 0x00A26AB0
		protected BP_SM_ConditionMontageTimeRemaining_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040179F6 RID: 96758
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionMontageTimeRemaining.BP_SM_ConditionMontageTimeRemaining_C";

		// Token: 0x040179F7 RID: 96759
		private static IntPtr _ClassPtr;

		// Token: 0x040179F8 RID: 96760
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040179F9 RID: 96761
		internal static int __PropertyOffset_0;
	}
}
