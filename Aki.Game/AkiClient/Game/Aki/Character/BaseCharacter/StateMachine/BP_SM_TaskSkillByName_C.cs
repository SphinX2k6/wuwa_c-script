using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004396 RID: 17302
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskSkillByName.BP_SM_TaskSkillByName_C")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class BP_SM_TaskSkillByName_C : UASMTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CD12 RID: 183570 RVA: 0x00A295C4 File Offset: 0x00A277C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_TaskSkillByName_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskSkillByName.BP_SM_TaskSkillByName_C");
			}
			return BP_SM_TaskSkillByName_C._ClassPtr;
		}

		// Token: 0x0602CD13 RID: 183571 RVA: 0x00A295E8 File Offset: 0x00A277E8
		public BP_SM_TaskSkillByName_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskSkillByName_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CD14 RID: 183572 RVA: 0x00A29610 File Offset: 0x00A27810
		public BP_SM_TaskSkillByName_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskSkillByName_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070F4 RID: 28916
		// (get) Token: 0x0602CD15 RID: 183573 RVA: 0x00A29643 File Offset: 0x00A27843
		// (set) Token: 0x0602CD16 RID: 183574 RVA: 0x00A29657 File Offset: 0x00A27857
		public unsafe string SkillName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_TaskSkillByName_C.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_TaskSkillByName_C.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x170070F5 RID: 28917
		// (get) Token: 0x0602CD17 RID: 183575 RVA: 0x00A2966C File Offset: 0x00A2786C
		// (set) Token: 0x0602CD18 RID: 183576 RVA: 0x00A2967C File Offset: 0x00A2787C
		public unsafe bool 允许打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskSkillByName_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskSkillByName_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070F6 RID: 28918
		// (get) Token: 0x0602CD19 RID: 183577 RVA: 0x00A2968D File Offset: 0x00A2788D
		// (set) Token: 0x0602CD1A RID: 183578 RVA: 0x00A296A1 File Offset: 0x00A278A1
		public unsafe FGameplayTag ConfigReplaceTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskSkillByName_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskSkillByName_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602CD1B RID: 183579 RVA: 0x00A296B6 File Offset: 0x00A278B6
		protected BP_SM_TaskSkillByName_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017A4D RID: 96845
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskSkillByName.BP_SM_TaskSkillByName_C";

		// Token: 0x04017A4E RID: 96846
		private static IntPtr _ClassPtr;

		// Token: 0x04017A4F RID: 96847
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017A50 RID: 96848
		internal static int __PropertyOffset_0;

		// Token: 0x04017A51 RID: 96849
		internal static int __PropertyOffset_1;

		// Token: 0x04017A52 RID: 96850
		internal static int __PropertyOffset_2;
	}
}
