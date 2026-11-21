using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003386 RID: 13190
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionStopMontage.BP_SM_ActionStopMontage_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 52)]
	public class BP_SM_ActionStopMontage_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060217A0 RID: 137120 RVA: 0x00961A7C File Offset: 0x0095FC7C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionStopMontage_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionStopMontage.BP_SM_ActionStopMontage_C");
			}
			return BP_SM_ActionStopMontage_C._ClassPtr;
		}

		// Token: 0x060217A1 RID: 137121 RVA: 0x00961AA0 File Offset: 0x0095FCA0
		public BP_SM_ActionStopMontage_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionStopMontage_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060217A2 RID: 137122 RVA: 0x00961AC8 File Offset: 0x0095FCC8
		[NullableContext(1)]
		public BP_SM_ActionStopMontage_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionStopMontage_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004491 RID: 17553
		// (get) Token: 0x060217A3 RID: 137123 RVA: 0x00961AFB File Offset: 0x0095FCFB
		// (set) Token: 0x060217A4 RID: 137124 RVA: 0x00961B0B File Offset: 0x0095FD0B
		public unsafe int 淡出时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionStopMontage_C.__PropertyOffset_淡出时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionStopMontage_C.__PropertyOffset_淡出时间) = value;
			}
		}

		// Token: 0x060217A5 RID: 137125 RVA: 0x00961B1C File Offset: 0x0095FD1C
		protected BP_SM_ActionStopMontage_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124CD RID: 74957
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionStopMontage.BP_SM_ActionStopMontage_C";

		// Token: 0x040124CE RID: 74958
		private static IntPtr _ClassPtr;

		// Token: 0x040124CF RID: 74959
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124D0 RID: 74960
		internal static int __PropertyOffset_淡出时间;
	}
}
