using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033B7 RID: 13239
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskSkill.BP_SM_TaskSkill_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 68)]
	public class BP_SM_TaskSkill_C : UASMTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021932 RID: 137522 RVA: 0x00964417 File Offset: 0x00962617
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_TaskSkill_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskSkill.BP_SM_TaskSkill_C");
			}
			return BP_SM_TaskSkill_C._ClassPtr;
		}

		// Token: 0x06021933 RID: 137523 RVA: 0x0096443C File Offset: 0x0096263C
		public BP_SM_TaskSkill_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskSkill_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021934 RID: 137524 RVA: 0x00964464 File Offset: 0x00962664
		[NullableContext(1)]
		public BP_SM_TaskSkill_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskSkill_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044F8 RID: 17656
		// (get) Token: 0x06021935 RID: 137525 RVA: 0x00964497 File Offset: 0x00962697
		// (set) Token: 0x06021936 RID: 137526 RVA: 0x009644A7 File Offset: 0x009626A7
		public unsafe int SkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskSkill_C.__PropertyOffset_SkillId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskSkill_C.__PropertyOffset_SkillId) = value;
			}
		}

		// Token: 0x170044F9 RID: 17657
		// (get) Token: 0x06021937 RID: 137527 RVA: 0x009644B8 File Offset: 0x009626B8
		// (set) Token: 0x06021938 RID: 137528 RVA: 0x009644C8 File Offset: 0x009626C8
		public unsafe bool 允许打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskSkill_C.__PropertyOffset_允许打断) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskSkill_C.__PropertyOffset_允许打断) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044FA RID: 17658
		// (get) Token: 0x06021939 RID: 137529 RVA: 0x009644D9 File Offset: 0x009626D9
		// (set) Token: 0x0602193A RID: 137530 RVA: 0x009644ED File Offset: 0x009626ED
		public unsafe FGameplayTag ConfigReplaceTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskSkill_C.__PropertyOffset_ConfigReplaceTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskSkill_C.__PropertyOffset_ConfigReplaceTag) = value;
			}
		}

		// Token: 0x0602193B RID: 137531 RVA: 0x00964502 File Offset: 0x00962702
		protected BP_SM_TaskSkill_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125CE RID: 75214
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskSkill.BP_SM_TaskSkill_C";

		// Token: 0x040125CF RID: 75215
		private static IntPtr _ClassPtr;

		// Token: 0x040125D0 RID: 75216
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040125D1 RID: 75217
		internal static int __PropertyOffset_SkillId;

		// Token: 0x040125D2 RID: 75218
		internal static int __PropertyOffset_允许打断;

		// Token: 0x040125D3 RID: 75219
		internal static int __PropertyOffset_ConfigReplaceTag;
	}
}
