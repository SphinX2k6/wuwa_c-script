using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003198 RID: 12696
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SBattleQteAction.SBattleQteAction")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class SBattleQteAction : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F4B0 RID: 128176 RVA: 0x0092A891 File Offset: 0x00928A91
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBattleQteAction._ScriptStructPtr != 0) ? SBattleQteAction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SBattleQteAction.SBattleQteAction", ref SBattleQteAction._ScriptStructPtr);
		}

		// Token: 0x1700387B RID: 14459
		// (get) Token: 0x0601F4B1 RID: 128177 RVA: 0x0092A8B5 File Offset: 0x00928AB5
		// (set) Token: 0x0601F4B2 RID: 128178 RVA: 0x0092A8C5 File Offset: 0x00928AC5
		public unsafe int Target
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_Target);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_Target) = value;
			}
		}

		// Token: 0x1700387C RID: 14460
		// (get) Token: 0x0601F4B3 RID: 128179 RVA: 0x0092A8D8 File Offset: 0x00928AD8
		// (set) Token: 0x0601F4B4 RID: 128180 RVA: 0x0092A91B File Offset: 0x00928B1B
		public TArray<FGameplayTag> TagConditions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._TagConditions) == null)
				{
					result = (this._TagConditions = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_TagConditions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TagConditions.CopyAssign(value);
			}
		}

		// Token: 0x1700387D RID: 14461
		// (get) Token: 0x0601F4B5 RID: 128181 RVA: 0x0092A92C File Offset: 0x00928B2C
		// (set) Token: 0x0601F4B6 RID: 128182 RVA: 0x0092A96F File Offset: 0x00928B6F
		public TArray<FGameplayTag> AddTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._AddTags) == null)
				{
					result = (this._AddTags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_AddTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AddTags.CopyAssign(value);
			}
		}

		// Token: 0x1700387E RID: 14462
		// (get) Token: 0x0601F4B7 RID: 128183 RVA: 0x0092A980 File Offset: 0x00928B80
		// (set) Token: 0x0601F4B8 RID: 128184 RVA: 0x0092A9C3 File Offset: 0x00928BC3
		public TArray<FGameplayTag> RemoveTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._RemoveTags) == null)
				{
					result = (this._RemoveTags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_RemoveTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RemoveTags.CopyAssign(value);
			}
		}

		// Token: 0x1700387F RID: 14463
		// (get) Token: 0x0601F4B9 RID: 128185 RVA: 0x0092A9D4 File Offset: 0x00928BD4
		// (set) Token: 0x0601F4BA RID: 128186 RVA: 0x0092AA17 File Offset: 0x00928C17
		public TArray<long> AddBuffs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._AddBuffs) == null)
				{
					result = (this._AddBuffs = new TArray<long>(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_AddBuffs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AddBuffs.CopyAssign(value);
			}
		}

		// Token: 0x17003880 RID: 14464
		// (get) Token: 0x0601F4BB RID: 128187 RVA: 0x0092AA28 File Offset: 0x00928C28
		// (set) Token: 0x0601F4BC RID: 128188 RVA: 0x0092AA6B File Offset: 0x00928C6B
		public TArray<long> RemoveBuffs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._RemoveBuffs) == null)
				{
					result = (this._RemoveBuffs = new TArray<long>(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_RemoveBuffs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RemoveBuffs.CopyAssign(value);
			}
		}

		// Token: 0x17003881 RID: 14465
		// (get) Token: 0x0601F4BD RID: 128189 RVA: 0x0092AA7C File Offset: 0x00928C7C
		// (set) Token: 0x0601F4BE RID: 128190 RVA: 0x0092AABF File Offset: 0x00928CBF
		public TArray<long> AddBullets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._AddBullets) == null)
				{
					result = (this._AddBullets = new TArray<long>(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_AddBullets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AddBullets.CopyAssign(value);
			}
		}

		// Token: 0x17003882 RID: 14466
		// (get) Token: 0x0601F4BF RID: 128191 RVA: 0x0092AACD File Offset: 0x00928CCD
		// (set) Token: 0x0601F4C0 RID: 128192 RVA: 0x0092AADD File Offset: 0x00928CDD
		public unsafe int UseSkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_UseSkillId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_UseSkillId) = value;
			}
		}

		// Token: 0x17003883 RID: 14467
		// (get) Token: 0x0601F4C1 RID: 128193 RVA: 0x0092AAEE File Offset: 0x00928CEE
		// (set) Token: 0x0601F4C2 RID: 128194 RVA: 0x0092AAFE File Offset: 0x00928CFE
		public unsafe int ChangeMainSkillPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_ChangeMainSkillPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_ChangeMainSkillPriority) = value;
			}
		}

		// Token: 0x17003884 RID: 14468
		// (get) Token: 0x0601F4C3 RID: 128195 RVA: 0x0092AB0F File Offset: 0x00928D0F
		// (set) Token: 0x0601F4C4 RID: 128196 RVA: 0x0092AB23 File Offset: 0x00928D23
		[Nullable(0)]
		public unsafe TEnumAsByte<EBattleQteCustomAction> CustomAction
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_CustomAction);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_CustomAction) = value;
			}
		}

		// Token: 0x17003885 RID: 14469
		// (get) Token: 0x0601F4C5 RID: 128197 RVA: 0x0092AB38 File Offset: 0x00928D38
		// (set) Token: 0x0601F4C6 RID: 128198 RVA: 0x0092AB4C File Offset: 0x00928D4C
		public unsafe string CustomActionParam
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBattleQteAction.__PropertyOffset_CustomActionParam)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBattleQteAction.__PropertyOffset_CustomActionParam)), value);
			}
		}

		// Token: 0x0601F4C7 RID: 128199 RVA: 0x0092AB61 File Offset: 0x00928D61
		public SBattleQteAction()
		{
		}

		// Token: 0x0601F4C8 RID: 128200 RVA: 0x0092AB69 File Offset: 0x00928D69
		protected override IntPtr GetUStructPtr()
		{
			return SBattleQteAction.StaticStruct();
		}

		// Token: 0x0601F4C9 RID: 128201 RVA: 0x0092AB75 File Offset: 0x00928D75
		[NullableContext(2)]
		public SBattleQteAction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F4CA RID: 128202 RVA: 0x0092AB7F File Offset: 0x00928D7F
		public SBattleQteAction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F4CB RID: 128203 RVA: 0x0092AB8A File Offset: 0x00928D8A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBattleQteAction(Pointer, false, true);
		}

		// Token: 0x0601F4CC RID: 128204 RVA: 0x0092AB94 File Offset: 0x00928D94
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBattleQteAction(Pointer, MemoryOwner);
		}

		// Token: 0x04010C63 RID: 68707
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SBattleQteAction.SBattleQteAction";

		// Token: 0x04010C64 RID: 68708
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010C65 RID: 68709
		internal static int __PropertyOffset_Target;

		// Token: 0x04010C66 RID: 68710
		internal static int __PropertyOffset_TagConditions;

		// Token: 0x04010C67 RID: 68711
		[Nullable(2)]
		private TArray<FGameplayTag> _TagConditions;

		// Token: 0x04010C68 RID: 68712
		internal static int __PropertyOffset_AddTags;

		// Token: 0x04010C69 RID: 68713
		[Nullable(2)]
		private TArray<FGameplayTag> _AddTags;

		// Token: 0x04010C6A RID: 68714
		internal static int __PropertyOffset_RemoveTags;

		// Token: 0x04010C6B RID: 68715
		[Nullable(2)]
		private TArray<FGameplayTag> _RemoveTags;

		// Token: 0x04010C6C RID: 68716
		internal static int __PropertyOffset_AddBuffs;

		// Token: 0x04010C6D RID: 68717
		[Nullable(2)]
		private TArray<long> _AddBuffs;

		// Token: 0x04010C6E RID: 68718
		internal static int __PropertyOffset_RemoveBuffs;

		// Token: 0x04010C6F RID: 68719
		[Nullable(2)]
		private TArray<long> _RemoveBuffs;

		// Token: 0x04010C70 RID: 68720
		internal static int __PropertyOffset_AddBullets;

		// Token: 0x04010C71 RID: 68721
		[Nullable(2)]
		private TArray<long> _AddBullets;

		// Token: 0x04010C72 RID: 68722
		internal static int __PropertyOffset_UseSkillId;

		// Token: 0x04010C73 RID: 68723
		internal static int __PropertyOffset_ChangeMainSkillPriority;

		// Token: 0x04010C74 RID: 68724
		internal static int __PropertyOffset_CustomAction;

		// Token: 0x04010C75 RID: 68725
		internal static int __PropertyOffset_CustomActionParam;
	}
}
