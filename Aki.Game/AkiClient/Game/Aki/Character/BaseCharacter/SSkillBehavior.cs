using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200432B RID: 17195
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillBehavior.SSkillBehavior")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 49)]
	public class SSkillBehavior : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C879 RID: 182393 RVA: 0x00A21EF6 File Offset: 0x00A200F6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillBehavior._ScriptStructPtr != 0) ? SSkillBehavior._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillBehavior.SSkillBehavior", ref SSkillBehavior._ScriptStructPtr);
		}

		// Token: 0x17006FAD RID: 28589
		// (get) Token: 0x0602C87A RID: 182394 RVA: 0x00A21F1C File Offset: 0x00A2011C
		// (set) Token: 0x0602C87B RID: 182395 RVA: 0x00A21F5F File Offset: 0x00A2015F
		public TArray<SSkillBehaviorCondition> SkillBehaviorConditionGroup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSkillBehaviorCondition> result;
				if ((result = this._SkillBehaviorConditionGroup) == null)
				{
					result = (this._SkillBehaviorConditionGroup = new TArray<SSkillBehaviorCondition>(base.NativePtr + (IntPtr)SSkillBehavior.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkillBehaviorConditionGroup.CopyAssign(value);
			}
		}

		// Token: 0x17006FAE RID: 28590
		// (get) Token: 0x0602C87C RID: 182396 RVA: 0x00A21F6D File Offset: 0x00A2016D
		// (set) Token: 0x0602C87D RID: 182397 RVA: 0x00A21F81 File Offset: 0x00A20181
		public unsafe string SkillBehaviorConditionFormula
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillBehavior.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillBehavior.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17006FAF RID: 28591
		// (get) Token: 0x0602C87E RID: 182398 RVA: 0x00A21F98 File Offset: 0x00A20198
		// (set) Token: 0x0602C87F RID: 182399 RVA: 0x00A21FDB File Offset: 0x00A201DB
		public TArray<SSkillBehaviorAction> SkillBehaviorActionGroup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSkillBehaviorAction> result;
				if ((result = this._SkillBehaviorActionGroup) == null)
				{
					result = (this._SkillBehaviorActionGroup = new TArray<SSkillBehaviorAction>(base.NativePtr + (IntPtr)SSkillBehavior.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkillBehaviorActionGroup.CopyAssign(value);
			}
		}

		// Token: 0x17006FB0 RID: 28592
		// (get) Token: 0x0602C880 RID: 182400 RVA: 0x00A21FE9 File Offset: 0x00A201E9
		// (set) Token: 0x0602C881 RID: 182401 RVA: 0x00A21FF9 File Offset: 0x00A201F9
		public unsafe bool SkillBehaviorContinue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehavior.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehavior.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602C882 RID: 182402 RVA: 0x00A2200A File Offset: 0x00A2020A
		public SSkillBehavior()
		{
		}

		// Token: 0x0602C883 RID: 182403 RVA: 0x00A22012 File Offset: 0x00A20212
		public SSkillBehavior(TArray<SSkillBehaviorCondition> SkillBehaviorConditionGroup, string SkillBehaviorConditionFormula, TArray<SSkillBehaviorAction> SkillBehaviorActionGroup, bool SkillBehaviorContinue)
		{
			this.SkillBehaviorConditionGroup = SkillBehaviorConditionGroup;
			this.SkillBehaviorConditionFormula = SkillBehaviorConditionFormula;
			this.SkillBehaviorActionGroup = SkillBehaviorActionGroup;
			this.SkillBehaviorContinue = SkillBehaviorContinue;
		}

		// Token: 0x0602C884 RID: 182404 RVA: 0x00A22037 File Offset: 0x00A20237
		protected override IntPtr GetUStructPtr()
		{
			return SSkillBehavior.StaticStruct();
		}

		// Token: 0x0602C885 RID: 182405 RVA: 0x00A22043 File Offset: 0x00A20243
		[NullableContext(2)]
		public SSkillBehavior(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C886 RID: 182406 RVA: 0x00A2204D File Offset: 0x00A2024D
		public SSkillBehavior(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C887 RID: 182407 RVA: 0x00A22058 File Offset: 0x00A20258
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillBehavior(Pointer, false, true);
		}

		// Token: 0x0602C888 RID: 182408 RVA: 0x00A22062 File Offset: 0x00A20262
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillBehavior(Pointer, MemoryOwner);
		}

		// Token: 0x04017790 RID: 96144
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillBehavior.SSkillBehavior";

		// Token: 0x04017791 RID: 96145
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017792 RID: 96146
		internal static int __PropertyOffset_0;

		// Token: 0x04017793 RID: 96147
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSkillBehaviorCondition> _SkillBehaviorConditionGroup;

		// Token: 0x04017794 RID: 96148
		internal static int __PropertyOffset_1;

		// Token: 0x04017795 RID: 96149
		internal static int __PropertyOffset_2;

		// Token: 0x04017796 RID: 96150
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSkillBehaviorAction> _SkillBehaviorActionGroup;

		// Token: 0x04017797 RID: 96151
		internal static int __PropertyOffset_3;
	}
}
