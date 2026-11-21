using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033B6 RID: 13238
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskSkillByName.BP_SM_TaskSkillByName_C")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class BP_SM_TaskSkillByName_C : UASMTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021928 RID: 137512 RVA: 0x0096431C File Offset: 0x0096251C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_TaskSkillByName_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskSkillByName.BP_SM_TaskSkillByName_C");
			}
			return BP_SM_TaskSkillByName_C._ClassPtr;
		}

		// Token: 0x06021929 RID: 137513 RVA: 0x00964340 File Offset: 0x00962540
		public BP_SM_TaskSkillByName_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskSkillByName_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602192A RID: 137514 RVA: 0x00964368 File Offset: 0x00962568
		public BP_SM_TaskSkillByName_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskSkillByName_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044F5 RID: 17653
		// (get) Token: 0x0602192B RID: 137515 RVA: 0x0096439B File Offset: 0x0096259B
		// (set) Token: 0x0602192C RID: 137516 RVA: 0x009643AF File Offset: 0x009625AF
		public unsafe string SkillName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_TaskSkillByName_C.__PropertyOffset_SkillName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_TaskSkillByName_C.__PropertyOffset_SkillName)), value);
			}
		}

		// Token: 0x170044F6 RID: 17654
		// (get) Token: 0x0602192D RID: 137517 RVA: 0x009643C4 File Offset: 0x009625C4
		// (set) Token: 0x0602192E RID: 137518 RVA: 0x009643D4 File Offset: 0x009625D4
		public unsafe bool 允许打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskSkillByName_C.__PropertyOffset_允许打断) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskSkillByName_C.__PropertyOffset_允许打断) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044F7 RID: 17655
		// (get) Token: 0x0602192F RID: 137519 RVA: 0x009643E5 File Offset: 0x009625E5
		// (set) Token: 0x06021930 RID: 137520 RVA: 0x009643F9 File Offset: 0x009625F9
		public unsafe FGameplayTag ConfigReplaceTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskSkillByName_C.__PropertyOffset_ConfigReplaceTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskSkillByName_C.__PropertyOffset_ConfigReplaceTag) = value;
			}
		}

		// Token: 0x06021931 RID: 137521 RVA: 0x0096440E File Offset: 0x0096260E
		protected BP_SM_TaskSkillByName_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125C8 RID: 75208
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskSkillByName.BP_SM_TaskSkillByName_C";

		// Token: 0x040125C9 RID: 75209
		private static IntPtr _ClassPtr;

		// Token: 0x040125CA RID: 75210
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040125CB RID: 75211
		internal static int __PropertyOffset_SkillName;

		// Token: 0x040125CC RID: 75212
		internal static int __PropertyOffset_允许打断;

		// Token: 0x040125CD RID: 75213
		internal static int __PropertyOffset_ConfigReplaceTag;
	}
}
