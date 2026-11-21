using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033A8 RID: 13224
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionMontageTimeRemaining.BP_SM_ConditionMontageTimeRemaining_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 60)]
	public class BP_SM_ConditionMontageTimeRemaining_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060218A6 RID: 137382 RVA: 0x00963661 File Offset: 0x00961861
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionMontageTimeRemaining_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionMontageTimeRemaining.BP_SM_ConditionMontageTimeRemaining_C");
			}
			return BP_SM_ConditionMontageTimeRemaining_C._ClassPtr;
		}

		// Token: 0x060218A7 RID: 137383 RVA: 0x00963688 File Offset: 0x00961888
		public BP_SM_ConditionMontageTimeRemaining_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionMontageTimeRemaining_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060218A8 RID: 137384 RVA: 0x009636B0 File Offset: 0x009618B0
		[NullableContext(1)]
		public BP_SM_ConditionMontageTimeRemaining_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionMontageTimeRemaining_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044D0 RID: 17616
		// (get) Token: 0x060218A9 RID: 137385 RVA: 0x009636E3 File Offset: 0x009618E3
		// (set) Token: 0x060218AA RID: 137386 RVA: 0x009636F3 File Offset: 0x009618F3
		public unsafe int Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionMontageTimeRemaining_C.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionMontageTimeRemaining_C.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x060218AB RID: 137387 RVA: 0x00963704 File Offset: 0x00961904
		protected BP_SM_ConditionMontageTimeRemaining_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012577 RID: 75127
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionMontageTimeRemaining.BP_SM_ConditionMontageTimeRemaining_C";

		// Token: 0x04012578 RID: 75128
		private static IntPtr _ClassPtr;

		// Token: 0x04012579 RID: 75129
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401257A RID: 75130
		internal static int __PropertyOffset_Time;
	}
}
