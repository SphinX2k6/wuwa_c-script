using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F68 RID: 16232
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SInputCommandTransform.SInputCommandTransform")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 85)]
	public class SInputCommandTransform : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060295DE RID: 169438 RVA: 0x009C282C File Offset: 0x009C0A2C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInputCommandTransform._ScriptStructPtr != 0) ? SInputCommandTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SInputCommandTransform.SInputCommandTransform", ref SInputCommandTransform._ScriptStructPtr);
		}

		// Token: 0x170062D5 RID: 25301
		// (get) Token: 0x060295DF RID: 169439 RVA: 0x009C2850 File Offset: 0x009C0A50
		// (set) Token: 0x060295E0 RID: 169440 RVA: 0x009C2864 File Offset: 0x009C0A64
		public unsafe string Desc
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SInputCommandTransform.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SInputCommandTransform.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x170062D6 RID: 25302
		// (get) Token: 0x060295E1 RID: 169441 RVA: 0x009C2879 File Offset: 0x009C0A79
		// (set) Token: 0x060295E2 RID: 169442 RVA: 0x009C288D File Offset: 0x009C0A8D
		[Nullable(0)]
		public unsafe TEnumAsByte<EInputAction> Action
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_1);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170062D7 RID: 25303
		// (get) Token: 0x060295E3 RID: 169443 RVA: 0x009C28A2 File Offset: 0x009C0AA2
		// (set) Token: 0x060295E4 RID: 169444 RVA: 0x009C28B6 File Offset: 0x009C0AB6
		[Nullable(0)]
		public unsafe TEnumAsByte<EInputState> State
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_2);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170062D8 RID: 25304
		// (get) Token: 0x060295E5 RID: 169445 RVA: 0x009C28CB File Offset: 0x009C0ACB
		// (set) Token: 0x060295E6 RID: 169446 RVA: 0x009C28DF File Offset: 0x009C0ADF
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170062D9 RID: 25305
		// (get) Token: 0x060295E7 RID: 169447 RVA: 0x009C28F4 File Offset: 0x009C0AF4
		// (set) Token: 0x060295E8 RID: 169448 RVA: 0x009C2937 File Offset: 0x009C0B37
		public TArray<SSkillBehaviorCondition> BehaviorConditionGroup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSkillBehaviorCondition> result;
				if ((result = this._BehaviorConditionGroup) == null)
				{
					result = (this._BehaviorConditionGroup = new TArray<SSkillBehaviorCondition>(base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BehaviorConditionGroup.CopyAssign(value);
			}
		}

		// Token: 0x170062DA RID: 25306
		// (get) Token: 0x060295E9 RID: 169449 RVA: 0x009C2945 File Offset: 0x009C0B45
		// (set) Token: 0x060295EA RID: 169450 RVA: 0x009C2959 File Offset: 0x009C0B59
		public unsafe string BehaviorConditionFormula
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SInputCommandTransform.__PropertyOffset_5)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SInputCommandTransform.__PropertyOffset_5)), value);
			}
		}

		// Token: 0x170062DB RID: 25307
		// (get) Token: 0x060295EB RID: 169451 RVA: 0x009C2970 File Offset: 0x009C0B70
		// (set) Token: 0x060295EC RID: 169452 RVA: 0x009C29B3 File Offset: 0x009C0BB3
		public SInputCommand Command
		{
			get
			{
				base.FastCheckIsValid();
				SInputCommand result;
				if ((result = this._Command) == null)
				{
					result = (this._Command = new SInputCommand(base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SInputCommand.StaticStruct(), base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170062DC RID: 25308
		// (get) Token: 0x060295ED RID: 169453 RVA: 0x009C29D4 File Offset: 0x009C0BD4
		// (set) Token: 0x060295EE RID: 169454 RVA: 0x009C29E4 File Offset: 0x009C0BE4
		public unsafe bool PriorityBelowExploreDerive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x060295EF RID: 169455 RVA: 0x009C29F5 File Offset: 0x009C0BF5
		public SInputCommandTransform()
		{
		}

		// Token: 0x060295F0 RID: 169456 RVA: 0x009C2A00 File Offset: 0x009C0C00
		public SInputCommandTransform(string Desc, [Nullable(0)] TEnumAsByte<EInputAction> Action, [Nullable(0)] TEnumAsByte<EInputState> State, FGameplayTag Tag, TArray<SSkillBehaviorCondition> BehaviorConditionGroup, string BehaviorConditionFormula, SInputCommand Command, bool PriorityBelowExploreDerive)
		{
			this.Desc = Desc;
			this.Action = Action;
			this.State = State;
			this.Tag = Tag;
			this.BehaviorConditionGroup = BehaviorConditionGroup;
			this.BehaviorConditionFormula = BehaviorConditionFormula;
			this.Command = Command;
			this.PriorityBelowExploreDerive = PriorityBelowExploreDerive;
		}

		// Token: 0x060295F1 RID: 169457 RVA: 0x009C2A50 File Offset: 0x009C0C50
		protected override IntPtr GetUStructPtr()
		{
			return SInputCommandTransform.StaticStruct();
		}

		// Token: 0x060295F2 RID: 169458 RVA: 0x009C2A5C File Offset: 0x009C0C5C
		[NullableContext(2)]
		public SInputCommandTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060295F3 RID: 169459 RVA: 0x009C2A66 File Offset: 0x009C0C66
		public SInputCommandTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060295F4 RID: 169460 RVA: 0x009C2A71 File Offset: 0x009C0C71
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInputCommandTransform(Pointer, false, true);
		}

		// Token: 0x060295F5 RID: 169461 RVA: 0x009C2A7B File Offset: 0x009C0C7B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInputCommandTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04015327 RID: 86823
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SInputCommandTransform.SInputCommandTransform";

		// Token: 0x04015328 RID: 86824
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015329 RID: 86825
		internal static int __PropertyOffset_0;

		// Token: 0x0401532A RID: 86826
		internal static int __PropertyOffset_1;

		// Token: 0x0401532B RID: 86827
		internal static int __PropertyOffset_2;

		// Token: 0x0401532C RID: 86828
		internal static int __PropertyOffset_3;

		// Token: 0x0401532D RID: 86829
		internal static int __PropertyOffset_4;

		// Token: 0x0401532E RID: 86830
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSkillBehaviorCondition> _BehaviorConditionGroup;

		// Token: 0x0401532F RID: 86831
		internal static int __PropertyOffset_5;

		// Token: 0x04015330 RID: 86832
		internal static int __PropertyOffset_6;

		// Token: 0x04015331 RID: 86833
		[Nullable(2)]
		private SInputCommand _Command;

		// Token: 0x04015332 RID: 86834
		internal static int __PropertyOffset_7;
	}
}
