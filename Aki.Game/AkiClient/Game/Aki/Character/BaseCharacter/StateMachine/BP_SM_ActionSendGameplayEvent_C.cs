using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004363 RID: 17251
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionSendGameplayEvent.BP_SM_ActionSendGameplayEvent_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 60)]
	public class BP_SM_ActionSendGameplayEvent_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CB78 RID: 183160 RVA: 0x00A26AEC File Offset: 0x00A24CEC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionSendGameplayEvent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionSendGameplayEvent.BP_SM_ActionSendGameplayEvent_C");
			}
			return BP_SM_ActionSendGameplayEvent_C._ClassPtr;
		}

		// Token: 0x0602CB79 RID: 183161 RVA: 0x00A26B10 File Offset: 0x00A24D10
		public BP_SM_ActionSendGameplayEvent_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionSendGameplayEvent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CB7A RID: 183162 RVA: 0x00A26B38 File Offset: 0x00A24D38
		[NullableContext(1)]
		public BP_SM_ActionSendGameplayEvent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionSendGameplayEvent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700708E RID: 28814
		// (get) Token: 0x0602CB7B RID: 183163 RVA: 0x00A26B6B File Offset: 0x00A24D6B
		// (set) Token: 0x0602CB7C RID: 183164 RVA: 0x00A26B7F File Offset: 0x00A24D7F
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionSendGameplayEvent_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionSendGameplayEvent_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x0602CB7D RID: 183165 RVA: 0x00A26B94 File Offset: 0x00A24D94
		protected BP_SM_ActionSendGameplayEvent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017945 RID: 96581
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionSendGameplayEvent.BP_SM_ActionSendGameplayEvent_C";

		// Token: 0x04017946 RID: 96582
		private static IntPtr _ClassPtr;

		// Token: 0x04017947 RID: 96583
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017948 RID: 96584
		internal static int __PropertyOffset_0;
	}
}
