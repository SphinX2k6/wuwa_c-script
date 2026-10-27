using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004379 RID: 17273
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionBuffStack.BP_SM_ConditionBuffStack_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class BP_SM_ConditionBuffStack_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CC2C RID: 183340 RVA: 0x00A27E07 File Offset: 0x00A26007
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionBuffStack_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionBuffStack.BP_SM_ConditionBuffStack_C");
			}
			return BP_SM_ConditionBuffStack_C._ClassPtr;
		}

		// Token: 0x0602CC2D RID: 183341 RVA: 0x00A27E2C File Offset: 0x00A2602C
		public BP_SM_ConditionBuffStack_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionBuffStack_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CC2E RID: 183342 RVA: 0x00A27E54 File Offset: 0x00A26054
		[NullableContext(1)]
		public BP_SM_ConditionBuffStack_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionBuffStack_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070BC RID: 28860
		// (get) Token: 0x0602CC2F RID: 183343 RVA: 0x00A27E87 File Offset: 0x00A26087
		// (set) Token: 0x0602CC30 RID: 183344 RVA: 0x00A27E97 File Offset: 0x00A26097
		public unsafe long BuffId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionBuffStack_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionBuffStack_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170070BD RID: 28861
		// (get) Token: 0x0602CC31 RID: 183345 RVA: 0x00A27EA8 File Offset: 0x00A260A8
		// (set) Token: 0x0602CC32 RID: 183346 RVA: 0x00A27EB8 File Offset: 0x00A260B8
		public unsafe int Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionBuffStack_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionBuffStack_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170070BE RID: 28862
		// (get) Token: 0x0602CC33 RID: 183347 RVA: 0x00A27EC9 File Offset: 0x00A260C9
		// (set) Token: 0x0602CC34 RID: 183348 RVA: 0x00A27ED9 File Offset: 0x00A260D9
		public unsafe int Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionBuffStack_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionBuffStack_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602CC35 RID: 183349 RVA: 0x00A27EEA File Offset: 0x00A260EA
		protected BP_SM_ConditionBuffStack_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040179BA RID: 96698
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionBuffStack.BP_SM_ConditionBuffStack_C";

		// Token: 0x040179BB RID: 96699
		private static IntPtr _ClassPtr;

		// Token: 0x040179BC RID: 96700
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040179BD RID: 96701
		internal static int __PropertyOffset_0;

		// Token: 0x040179BE RID: 96702
		internal static int __PropertyOffset_1;

		// Token: 0x040179BF RID: 96703
		internal static int __PropertyOffset_2;
	}
}
