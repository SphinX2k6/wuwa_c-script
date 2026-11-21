using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033AA RID: 13226
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTag.BP_SM_ConditionTag_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 69)]
	public class BP_SM_ConditionTag_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060218B8 RID: 137400 RVA: 0x00963824 File Offset: 0x00961A24
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionTag_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTag.BP_SM_ConditionTag_C");
			}
			return BP_SM_ConditionTag_C._ClassPtr;
		}

		// Token: 0x060218B9 RID: 137401 RVA: 0x00963848 File Offset: 0x00961A48
		public BP_SM_ConditionTag_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionTag_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060218BA RID: 137402 RVA: 0x00963870 File Offset: 0x00961A70
		[NullableContext(1)]
		public BP_SM_ConditionTag_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionTag_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044D5 RID: 17621
		// (get) Token: 0x060218BB RID: 137403 RVA: 0x009638A3 File Offset: 0x00961AA3
		// (set) Token: 0x060218BC RID: 137404 RVA: 0x009638B7 File Offset: 0x00961AB7
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionTag_C.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionTag_C.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x170044D6 RID: 17622
		// (get) Token: 0x060218BD RID: 137405 RVA: 0x009638CC File Offset: 0x00961ACC
		// (set) Token: 0x060218BE RID: 137406 RVA: 0x009638DC File Offset: 0x00961ADC
		public unsafe bool IsClient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionTag_C.__PropertyOffset_IsClient) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionTag_C.__PropertyOffset_IsClient) = (value ? 1 : 0);
			}
		}

		// Token: 0x060218BF RID: 137407 RVA: 0x009638ED File Offset: 0x00961AED
		protected BP_SM_ConditionTag_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012582 RID: 75138
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionTag.BP_SM_ConditionTag_C";

		// Token: 0x04012583 RID: 75139
		private static IntPtr _ClassPtr;

		// Token: 0x04012584 RID: 75140
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012585 RID: 75141
		internal static int __PropertyOffset_Tag;

		// Token: 0x04012586 RID: 75142
		internal static int __PropertyOffset_IsClient;
	}
}
