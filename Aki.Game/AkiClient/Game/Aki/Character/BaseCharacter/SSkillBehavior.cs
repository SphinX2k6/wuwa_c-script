using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003363 RID: 13155
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillBehavior.SSkillBehavior")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 49)]
	public class SSkillBehavior : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021579 RID: 136569 RVA: 0x0095E7AD File Offset: 0x0095C9AD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillBehavior._ScriptStructPtr != 0) ? SSkillBehavior._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillBehavior.SSkillBehavior", ref SSkillBehavior._ScriptStructPtr);
		}

		// Token: 0x170043DA RID: 17370
		// (get) Token: 0x0602157A RID: 136570 RVA: 0x0095E7D4 File Offset: 0x0095C9D4
		// (set) Token: 0x0602157B RID: 136571 RVA: 0x0095E817 File Offset: 0x0095CA17
		public TArray<SSkillBehaviorCondition> SkillBehaviorConditionGroup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSkillBehaviorCondition> result;
				if ((result = this._SkillBehaviorConditionGroup) == null)
				{
					result = (this._SkillBehaviorConditionGroup = new TArray<SSkillBehaviorCondition>(base.NativePtr + (IntPtr)SSkillBehavior.__PropertyOffset_SkillBehaviorConditionGroup, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkillBehaviorConditionGroup.CopyAssign(value);
			}
		}

		// Token: 0x170043DB RID: 17371
		// (get) Token: 0x0602157C RID: 136572 RVA: 0x0095E825 File Offset: 0x0095CA25
		// (set) Token: 0x0602157D RID: 136573 RVA: 0x0095E839 File Offset: 0x0095CA39
		public unsafe string SkillBehaviorConditionFormula
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillBehavior.__PropertyOffset_SkillBehaviorConditionFormula)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillBehavior.__PropertyOffset_SkillBehaviorConditionFormula)), value);
			}
		}

		// Token: 0x170043DC RID: 17372
		// (get) Token: 0x0602157E RID: 136574 RVA: 0x0095E850 File Offset: 0x0095CA50
		// (set) Token: 0x0602157F RID: 136575 RVA: 0x0095E893 File Offset: 0x0095CA93
		public TArray<SSkillBehaviorAction> SkillBehaviorActionGroup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSkillBehaviorAction> result;
				if ((result = this._SkillBehaviorActionGroup) == null)
				{
					result = (this._SkillBehaviorActionGroup = new TArray<SSkillBehaviorAction>(base.NativePtr + (IntPtr)SSkillBehavior.__PropertyOffset_SkillBehaviorActionGroup, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkillBehaviorActionGroup.CopyAssign(value);
			}
		}

		// Token: 0x170043DD RID: 17373
		// (get) Token: 0x06021580 RID: 136576 RVA: 0x0095E8A1 File Offset: 0x0095CAA1
		// (set) Token: 0x06021581 RID: 136577 RVA: 0x0095E8B1 File Offset: 0x0095CAB1
		public unsafe bool SkillBehaviorContinue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehavior.__PropertyOffset_SkillBehaviorContinue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehavior.__PropertyOffset_SkillBehaviorContinue) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021582 RID: 136578 RVA: 0x0095E8C2 File Offset: 0x0095CAC2
		public SSkillBehavior()
		{
		}

		// Token: 0x06021583 RID: 136579 RVA: 0x0095E8CA File Offset: 0x0095CACA
		protected override IntPtr GetUStructPtr()
		{
			return SSkillBehavior.StaticStruct();
		}

		// Token: 0x06021584 RID: 136580 RVA: 0x0095E8D6 File Offset: 0x0095CAD6
		[NullableContext(2)]
		public SSkillBehavior(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021585 RID: 136581 RVA: 0x0095E8E0 File Offset: 0x0095CAE0
		public SSkillBehavior(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021586 RID: 136582 RVA: 0x0095E8EB File Offset: 0x0095CAEB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillBehavior(Pointer, false, true);
		}

		// Token: 0x06021587 RID: 136583 RVA: 0x0095E8F5 File Offset: 0x0095CAF5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillBehavior(Pointer, MemoryOwner);
		}

		// Token: 0x04012391 RID: 74641
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillBehavior.SSkillBehavior";

		// Token: 0x04012392 RID: 74642
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012393 RID: 74643
		internal static int __PropertyOffset_SkillBehaviorConditionGroup;

		// Token: 0x04012394 RID: 74644
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSkillBehaviorCondition> _SkillBehaviorConditionGroup;

		// Token: 0x04012395 RID: 74645
		internal static int __PropertyOffset_SkillBehaviorConditionFormula;

		// Token: 0x04012396 RID: 74646
		internal static int __PropertyOffset_SkillBehaviorActionGroup;

		// Token: 0x04012397 RID: 74647
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSkillBehaviorAction> _SkillBehaviorActionGroup;

		// Token: 0x04012398 RID: 74648
		internal static int __PropertyOffset_SkillBehaviorContinue;
	}
}
