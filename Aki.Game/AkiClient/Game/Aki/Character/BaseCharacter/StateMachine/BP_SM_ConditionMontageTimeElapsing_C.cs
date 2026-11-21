using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033A7 RID: 13223
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionMontageTimeElapsing.BP_SM_ConditionMontageTimeElapsing_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 60)]
	public class BP_SM_ConditionMontageTimeElapsing_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060218A0 RID: 137376 RVA: 0x009635B5 File Offset: 0x009617B5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionMontageTimeElapsing_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionMontageTimeElapsing.BP_SM_ConditionMontageTimeElapsing_C");
			}
			return BP_SM_ConditionMontageTimeElapsing_C._ClassPtr;
		}

		// Token: 0x060218A1 RID: 137377 RVA: 0x009635DC File Offset: 0x009617DC
		public BP_SM_ConditionMontageTimeElapsing_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionMontageTimeElapsing_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060218A2 RID: 137378 RVA: 0x00963604 File Offset: 0x00961804
		[NullableContext(1)]
		public BP_SM_ConditionMontageTimeElapsing_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionMontageTimeElapsing_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044CF RID: 17615
		// (get) Token: 0x060218A3 RID: 137379 RVA: 0x00963637 File Offset: 0x00961837
		// (set) Token: 0x060218A4 RID: 137380 RVA: 0x00963647 File Offset: 0x00961847
		public unsafe int Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionMontageTimeElapsing_C.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionMontageTimeElapsing_C.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x060218A5 RID: 137381 RVA: 0x00963658 File Offset: 0x00961858
		protected BP_SM_ConditionMontageTimeElapsing_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012573 RID: 75123
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionMontageTimeElapsing.BP_SM_ConditionMontageTimeElapsing_C";

		// Token: 0x04012574 RID: 75124
		private static IntPtr _ClassPtr;

		// Token: 0x04012575 RID: 75125
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012576 RID: 75126
		internal static int __PropertyOffset_Time;
	}
}
