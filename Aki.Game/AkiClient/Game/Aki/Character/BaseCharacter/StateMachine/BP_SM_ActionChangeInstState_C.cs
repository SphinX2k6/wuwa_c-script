using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200337A RID: 13178
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionChangeInstState.BP_SM_ActionChangeInstState_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 60)]
	public class BP_SM_ActionChangeInstState_C : UASMAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602175A RID: 137050 RVA: 0x00961245 File Offset: 0x0095F445
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ActionChangeInstState_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionChangeInstState.BP_SM_ActionChangeInstState_C");
			}
			return BP_SM_ActionChangeInstState_C._ClassPtr;
		}

		// Token: 0x0602175B RID: 137051 RVA: 0x0096126C File Offset: 0x0095F46C
		public BP_SM_ActionChangeInstState_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionChangeInstState_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602175C RID: 137052 RVA: 0x00961294 File Offset: 0x0095F494
		[NullableContext(1)]
		public BP_SM_ActionChangeInstState_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ActionChangeInstState_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004486 RID: 17542
		// (get) Token: 0x0602175D RID: 137053 RVA: 0x009612C7 File Offset: 0x0095F4C7
		// (set) Token: 0x0602175E RID: 137054 RVA: 0x009612DB File Offset: 0x0095F4DB
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ActionChangeInstState_C.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ActionChangeInstState_C.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x0602175F RID: 137055 RVA: 0x009612F0 File Offset: 0x0095F4F0
		protected BP_SM_ActionChangeInstState_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401249D RID: 74909
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ActionChangeInstState.BP_SM_ActionChangeInstState_C";

		// Token: 0x0401249E RID: 74910
		private static IntPtr _ClassPtr;

		// Token: 0x0401249F RID: 74911
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124A0 RID: 74912
		internal static int __PropertyOffset_Tag;
	}
}
