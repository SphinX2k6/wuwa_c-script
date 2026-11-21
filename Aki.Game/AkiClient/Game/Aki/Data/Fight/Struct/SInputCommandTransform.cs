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
	// Token: 0x02003209 RID: 12809
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SInputCommandTransform.SInputCommandTransform")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 85)]
	public class SInputCommandTransform : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FE66 RID: 130662 RVA: 0x00938948 File Offset: 0x00936B48
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInputCommandTransform._ScriptStructPtr != 0) ? SInputCommandTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SInputCommandTransform.SInputCommandTransform", ref SInputCommandTransform._ScriptStructPtr);
		}

		// Token: 0x17003C11 RID: 15377
		// (get) Token: 0x0601FE67 RID: 130663 RVA: 0x0093896C File Offset: 0x00936B6C
		// (set) Token: 0x0601FE68 RID: 130664 RVA: 0x00938980 File Offset: 0x00936B80
		public unsafe string Desc
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SInputCommandTransform.__PropertyOffset_Desc)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SInputCommandTransform.__PropertyOffset_Desc)), value);
			}
		}

		// Token: 0x17003C12 RID: 15378
		// (get) Token: 0x0601FE69 RID: 130665 RVA: 0x00938995 File Offset: 0x00936B95
		// (set) Token: 0x0601FE6A RID: 130666 RVA: 0x009389A9 File Offset: 0x00936BA9
		[Nullable(0)]
		public unsafe TEnumAsByte<EInputAction> Action
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_Action);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_Action) = value;
			}
		}

		// Token: 0x17003C13 RID: 15379
		// (get) Token: 0x0601FE6B RID: 130667 RVA: 0x009389BE File Offset: 0x00936BBE
		// (set) Token: 0x0601FE6C RID: 130668 RVA: 0x009389D2 File Offset: 0x00936BD2
		[Nullable(0)]
		public unsafe TEnumAsByte<EInputState> State
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_State);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_State) = value;
			}
		}

		// Token: 0x17003C14 RID: 15380
		// (get) Token: 0x0601FE6D RID: 130669 RVA: 0x009389E7 File Offset: 0x00936BE7
		// (set) Token: 0x0601FE6E RID: 130670 RVA: 0x009389FB File Offset: 0x00936BFB
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x17003C15 RID: 15381
		// (get) Token: 0x0601FE6F RID: 130671 RVA: 0x00938A10 File Offset: 0x00936C10
		// (set) Token: 0x0601FE70 RID: 130672 RVA: 0x00938A53 File Offset: 0x00936C53
		public TArray<SSkillBehaviorCondition> BehaviorConditionGroup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SSkillBehaviorCondition> result;
				if ((result = this._BehaviorConditionGroup) == null)
				{
					result = (this._BehaviorConditionGroup = new TArray<SSkillBehaviorCondition>(base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_BehaviorConditionGroup, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BehaviorConditionGroup.CopyAssign(value);
			}
		}

		// Token: 0x17003C16 RID: 15382
		// (get) Token: 0x0601FE71 RID: 130673 RVA: 0x00938A61 File Offset: 0x00936C61
		// (set) Token: 0x0601FE72 RID: 130674 RVA: 0x00938A75 File Offset: 0x00936C75
		public unsafe string BehaviorConditionFormula
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SInputCommandTransform.__PropertyOffset_BehaviorConditionFormula)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SInputCommandTransform.__PropertyOffset_BehaviorConditionFormula)), value);
			}
		}

		// Token: 0x17003C17 RID: 15383
		// (get) Token: 0x0601FE73 RID: 130675 RVA: 0x00938A8C File Offset: 0x00936C8C
		// (set) Token: 0x0601FE74 RID: 130676 RVA: 0x00938ACF File Offset: 0x00936CCF
		public SInputCommand Command
		{
			get
			{
				base.FastCheckIsValid();
				SInputCommand result;
				if ((result = this._Command) == null)
				{
					result = (this._Command = new SInputCommand(base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_Command, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SInputCommand.StaticStruct(), base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_Command, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003C18 RID: 15384
		// (get) Token: 0x0601FE75 RID: 130677 RVA: 0x00938AF0 File Offset: 0x00936CF0
		// (set) Token: 0x0601FE76 RID: 130678 RVA: 0x00938B00 File Offset: 0x00936D00
		public unsafe bool PriorityBelowExploreDerive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_PriorityBelowExploreDerive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputCommandTransform.__PropertyOffset_PriorityBelowExploreDerive) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601FE77 RID: 130679 RVA: 0x00938B11 File Offset: 0x00936D11
		public SInputCommandTransform()
		{
		}

		// Token: 0x0601FE78 RID: 130680 RVA: 0x00938B19 File Offset: 0x00936D19
		protected override IntPtr GetUStructPtr()
		{
			return SInputCommandTransform.StaticStruct();
		}

		// Token: 0x0601FE79 RID: 130681 RVA: 0x00938B25 File Offset: 0x00936D25
		[NullableContext(2)]
		public SInputCommandTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FE7A RID: 130682 RVA: 0x00938B2F File Offset: 0x00936D2F
		public SInputCommandTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FE7B RID: 130683 RVA: 0x00938B3A File Offset: 0x00936D3A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInputCommandTransform(Pointer, false, true);
		}

		// Token: 0x0601FE7C RID: 130684 RVA: 0x00938B44 File Offset: 0x00936D44
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInputCommandTransform(Pointer, MemoryOwner);
		}

		// Token: 0x0401121B RID: 70171
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SInputCommandTransform.SInputCommandTransform";

		// Token: 0x0401121C RID: 70172
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401121D RID: 70173
		internal static int __PropertyOffset_Desc;

		// Token: 0x0401121E RID: 70174
		internal static int __PropertyOffset_Action;

		// Token: 0x0401121F RID: 70175
		internal static int __PropertyOffset_State;

		// Token: 0x04011220 RID: 70176
		internal static int __PropertyOffset_Tag;

		// Token: 0x04011221 RID: 70177
		internal static int __PropertyOffset_BehaviorConditionGroup;

		// Token: 0x04011222 RID: 70178
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SSkillBehaviorCondition> _BehaviorConditionGroup;

		// Token: 0x04011223 RID: 70179
		internal static int __PropertyOffset_BehaviorConditionFormula;

		// Token: 0x04011224 RID: 70180
		internal static int __PropertyOffset_Command;

		// Token: 0x04011225 RID: 70181
		[Nullable(2)]
		private SInputCommand _Command;

		// Token: 0x04011226 RID: 70182
		internal static int __PropertyOffset_PriorityBelowExploreDerive;
	}
}
