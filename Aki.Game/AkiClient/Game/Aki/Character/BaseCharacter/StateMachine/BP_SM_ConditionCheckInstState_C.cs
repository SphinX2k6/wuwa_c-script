using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200339E RID: 13214
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckInstState.BP_SM_ConditionCheckInstState_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 68)]
	public class BP_SM_ConditionCheckInstState_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021860 RID: 137312 RVA: 0x00962EE0 File Offset: 0x009610E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionCheckInstState_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckInstState.BP_SM_ConditionCheckInstState_C");
			}
			return BP_SM_ConditionCheckInstState_C._ClassPtr;
		}

		// Token: 0x06021861 RID: 137313 RVA: 0x00962F04 File Offset: 0x00961104
		public BP_SM_ConditionCheckInstState_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckInstState_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021862 RID: 137314 RVA: 0x00962F2C File Offset: 0x0096112C
		[NullableContext(1)]
		public BP_SM_ConditionCheckInstState_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionCheckInstState_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044C1 RID: 17601
		// (get) Token: 0x06021863 RID: 137315 RVA: 0x00962F5F File Offset: 0x0096115F
		// (set) Token: 0x06021864 RID: 137316 RVA: 0x00962F73 File Offset: 0x00961173
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionCheckInstState_C.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionCheckInstState_C.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x06021865 RID: 137317 RVA: 0x00962F88 File Offset: 0x00961188
		protected BP_SM_ConditionCheckInstState_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401254A RID: 75082
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionCheckInstState.BP_SM_ConditionCheckInstState_C";

		// Token: 0x0401254B RID: 75083
		private static IntPtr _ClassPtr;

		// Token: 0x0401254C RID: 75084
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401254D RID: 75085
		internal static int __PropertyOffset_Tag;
	}
}
