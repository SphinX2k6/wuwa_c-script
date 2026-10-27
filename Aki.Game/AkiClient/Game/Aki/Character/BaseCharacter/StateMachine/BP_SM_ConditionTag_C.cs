using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004389 RID: 17289
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTag.BP_SM_ConditionTag_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 69)]
	public class BP_SM_ConditionTag_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CC9A RID: 183450 RVA: 0x00A289D0 File Offset: 0x00A26BD0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionTag_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTag.BP_SM_ConditionTag_C");
			}
			return BP_SM_ConditionTag_C._ClassPtr;
		}

		// Token: 0x0602CC9B RID: 183451 RVA: 0x00A289F4 File Offset: 0x00A26BF4
		public BP_SM_ConditionTag_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionTag_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CC9C RID: 183452 RVA: 0x00A28A1C File Offset: 0x00A26C1C
		[NullableContext(1)]
		public BP_SM_ConditionTag_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionTag_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070D3 RID: 28883
		// (get) Token: 0x0602CC9D RID: 183453 RVA: 0x00A28A4F File Offset: 0x00A26C4F
		// (set) Token: 0x0602CC9E RID: 183454 RVA: 0x00A28A63 File Offset: 0x00A26C63
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionTag_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionTag_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170070D4 RID: 28884
		// (get) Token: 0x0602CC9F RID: 183455 RVA: 0x00A28A78 File Offset: 0x00A26C78
		// (set) Token: 0x0602CCA0 RID: 183456 RVA: 0x00A28A88 File Offset: 0x00A26C88
		public unsafe bool IsClient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionTag_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionTag_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602CCA1 RID: 183457 RVA: 0x00A28A99 File Offset: 0x00A26C99
		protected BP_SM_ConditionTag_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017A01 RID: 96769
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTag.BP_SM_ConditionTag_C";

		// Token: 0x04017A02 RID: 96770
		private static IntPtr _ClassPtr;

		// Token: 0x04017A03 RID: 96771
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017A04 RID: 96772
		internal static int __PropertyOffset_0;

		// Token: 0x04017A05 RID: 96773
		internal static int __PropertyOffset_1;
	}
}
