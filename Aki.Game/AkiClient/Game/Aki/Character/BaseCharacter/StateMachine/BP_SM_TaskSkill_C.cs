using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004397 RID: 17303
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskSkill.BP_SM_TaskSkill_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 68)]
	public class BP_SM_TaskSkill_C : UASMTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CD1C RID: 183580 RVA: 0x00A296BF File Offset: 0x00A278BF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_TaskSkill_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskSkill.BP_SM_TaskSkill_C");
			}
			return BP_SM_TaskSkill_C._ClassPtr;
		}

		// Token: 0x0602CD1D RID: 183581 RVA: 0x00A296E4 File Offset: 0x00A278E4
		public BP_SM_TaskSkill_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskSkill_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CD1E RID: 183582 RVA: 0x00A2970C File Offset: 0x00A2790C
		[NullableContext(1)]
		public BP_SM_TaskSkill_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskSkill_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070F7 RID: 28919
		// (get) Token: 0x0602CD1F RID: 183583 RVA: 0x00A2973F File Offset: 0x00A2793F
		// (set) Token: 0x0602CD20 RID: 183584 RVA: 0x00A2974F File Offset: 0x00A2794F
		public unsafe int SkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskSkill_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskSkill_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170070F8 RID: 28920
		// (get) Token: 0x0602CD21 RID: 183585 RVA: 0x00A29760 File Offset: 0x00A27960
		// (set) Token: 0x0602CD22 RID: 183586 RVA: 0x00A29770 File Offset: 0x00A27970
		public unsafe bool 允许打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskSkill_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskSkill_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070F9 RID: 28921
		// (get) Token: 0x0602CD23 RID: 183587 RVA: 0x00A29781 File Offset: 0x00A27981
		// (set) Token: 0x0602CD24 RID: 183588 RVA: 0x00A29795 File Offset: 0x00A27995
		public unsafe FGameplayTag ConfigReplaceTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskSkill_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskSkill_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602CD25 RID: 183589 RVA: 0x00A297AA File Offset: 0x00A279AA
		protected BP_SM_TaskSkill_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017A53 RID: 96851
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskSkill.BP_SM_TaskSkill_C";

		// Token: 0x04017A54 RID: 96852
		private static IntPtr _ClassPtr;

		// Token: 0x04017A55 RID: 96853
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017A56 RID: 96854
		internal static int __PropertyOffset_0;

		// Token: 0x04017A57 RID: 96855
		internal static int __PropertyOffset_1;

		// Token: 0x04017A58 RID: 96856
		internal static int __PropertyOffset_2;
	}
}
