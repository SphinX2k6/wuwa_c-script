using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003384 RID: 13188
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionSendGameplayEvent.BP_SM_ActionSendGameplayEvent_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 60)]
	public class BP_SM_ActionSendGameplayEvent_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021796 RID: 137110 RVA: 0x00961940 File Offset: 0x0095FB40
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionSendGameplayEvent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionSendGameplayEvent.BP_SM_ActionSendGameplayEvent_C");
			}
			return BP_SM_ActionSendGameplayEvent_C._ClassPtr;
		}

		// Token: 0x06021797 RID: 137111 RVA: 0x00961964 File Offset: 0x0095FB64
		public BP_SM_ActionSendGameplayEvent_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionSendGameplayEvent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021798 RID: 137112 RVA: 0x0096198C File Offset: 0x0095FB8C
		[NullableContext(1)]
		public BP_SM_ActionSendGameplayEvent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionSendGameplayEvent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004490 RID: 17552
		// (get) Token: 0x06021799 RID: 137113 RVA: 0x009619BF File Offset: 0x0095FBBF
		// (set) Token: 0x0602179A RID: 137114 RVA: 0x009619D3 File Offset: 0x0095FBD3
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionSendGameplayEvent_C.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionSendGameplayEvent_C.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x0602179B RID: 137115 RVA: 0x009619E8 File Offset: 0x0095FBE8
		protected BP_SM_ActionSendGameplayEvent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124C6 RID: 74950
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionSendGameplayEvent.BP_SM_ActionSendGameplayEvent_C";

		// Token: 0x040124C7 RID: 74951
		private static IntPtr _ClassPtr;

		// Token: 0x040124C8 RID: 74952
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124C9 RID: 74953
		internal static int __PropertyOffset_Tag;
	}
}
