using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003ED3 RID: 16083
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/SBattleQteAction.SBattleQteAction")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class SBattleQteAction : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028A7C RID: 166524 RVA: 0x009B1696 File Offset: 0x009AF896
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBattleQteAction._ScriptStructPtr != 0) ? SBattleQteAction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Qte/SBattleQteAction.SBattleQteAction", ref SBattleQteAction._ScriptStructPtr);
		}

		// Token: 0x17005EEF RID: 24303
		// (get) Token: 0x06028A7D RID: 166525 RVA: 0x009B16BA File Offset: 0x009AF8BA
		// (set) Token: 0x06028A7E RID: 166526 RVA: 0x009B16CA File Offset: 0x009AF8CA
		public unsafe int Target
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005EF0 RID: 24304
		// (get) Token: 0x06028A7F RID: 166527 RVA: 0x009B16DC File Offset: 0x009AF8DC
		// (set) Token: 0x06028A80 RID: 166528 RVA: 0x009B171F File Offset: 0x009AF91F
		public TArray<FGameplayTag> TagConditions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._TagConditions) == null)
				{
					result = (this._TagConditions = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TagConditions.CopyAssign(value);
			}
		}

		// Token: 0x17005EF1 RID: 24305
		// (get) Token: 0x06028A81 RID: 166529 RVA: 0x009B1730 File Offset: 0x009AF930
		// (set) Token: 0x06028A82 RID: 166530 RVA: 0x009B1773 File Offset: 0x009AF973
		public TArray<FGameplayTag> AddTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._AddTags) == null)
				{
					result = (this._AddTags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AddTags.CopyAssign(value);
			}
		}

		// Token: 0x17005EF2 RID: 24306
		// (get) Token: 0x06028A83 RID: 166531 RVA: 0x009B1784 File Offset: 0x009AF984
		// (set) Token: 0x06028A84 RID: 166532 RVA: 0x009B17C7 File Offset: 0x009AF9C7
		public TArray<FGameplayTag> RemoveTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._RemoveTags) == null)
				{
					result = (this._RemoveTags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RemoveTags.CopyAssign(value);
			}
		}

		// Token: 0x17005EF3 RID: 24307
		// (get) Token: 0x06028A85 RID: 166533 RVA: 0x009B17D8 File Offset: 0x009AF9D8
		// (set) Token: 0x06028A86 RID: 166534 RVA: 0x009B181B File Offset: 0x009AFA1B
		public TArray<long> AddBuffs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._AddBuffs) == null)
				{
					result = (this._AddBuffs = new TArray<long>(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AddBuffs.CopyAssign(value);
			}
		}

		// Token: 0x17005EF4 RID: 24308
		// (get) Token: 0x06028A87 RID: 166535 RVA: 0x009B182C File Offset: 0x009AFA2C
		// (set) Token: 0x06028A88 RID: 166536 RVA: 0x009B186F File Offset: 0x009AFA6F
		public TArray<long> RemoveBuffs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._RemoveBuffs) == null)
				{
					result = (this._RemoveBuffs = new TArray<long>(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RemoveBuffs.CopyAssign(value);
			}
		}

		// Token: 0x17005EF5 RID: 24309
		// (get) Token: 0x06028A89 RID: 166537 RVA: 0x009B1880 File Offset: 0x009AFA80
		// (set) Token: 0x06028A8A RID: 166538 RVA: 0x009B18C3 File Offset: 0x009AFAC3
		public TArray<long> AddBullets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._AddBullets) == null)
				{
					result = (this._AddBullets = new TArray<long>(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AddBullets.CopyAssign(value);
			}
		}

		// Token: 0x17005EF6 RID: 24310
		// (get) Token: 0x06028A8B RID: 166539 RVA: 0x009B18D1 File Offset: 0x009AFAD1
		// (set) Token: 0x06028A8C RID: 166540 RVA: 0x009B18E1 File Offset: 0x009AFAE1
		public unsafe int UseSkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005EF7 RID: 24311
		// (get) Token: 0x06028A8D RID: 166541 RVA: 0x009B18F2 File Offset: 0x009AFAF2
		// (set) Token: 0x06028A8E RID: 166542 RVA: 0x009B1902 File Offset: 0x009AFB02
		public unsafe int ChangeMainSkillPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005EF8 RID: 24312
		// (get) Token: 0x06028A8F RID: 166543 RVA: 0x009B1913 File Offset: 0x009AFB13
		// (set) Token: 0x06028A90 RID: 166544 RVA: 0x009B1927 File Offset: 0x009AFB27
		[Nullable(0)]
		public unsafe TEnumAsByte<EBattleQteCustomAction> CustomAction
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_9);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SBattleQteAction.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005EF9 RID: 24313
		// (get) Token: 0x06028A91 RID: 166545 RVA: 0x009B193C File Offset: 0x009AFB3C
		// (set) Token: 0x06028A92 RID: 166546 RVA: 0x009B1950 File Offset: 0x009AFB50
		public unsafe string CustomActionParam
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBattleQteAction.__PropertyOffset_10)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBattleQteAction.__PropertyOffset_10)), value);
			}
		}

		// Token: 0x06028A93 RID: 166547 RVA: 0x009B1965 File Offset: 0x009AFB65
		public SBattleQteAction()
		{
		}

		// Token: 0x06028A94 RID: 166548 RVA: 0x009B1970 File Offset: 0x009AFB70
		public SBattleQteAction(int Target, TArray<FGameplayTag> TagConditions, TArray<FGameplayTag> AddTags, TArray<FGameplayTag> RemoveTags, TArray<long> AddBuffs, TArray<long> RemoveBuffs, TArray<long> AddBullets, int UseSkillId, int ChangeMainSkillPriority, [Nullable(0)] TEnumAsByte<EBattleQteCustomAction> CustomAction, string CustomActionParam)
		{
			this.Target = Target;
			this.TagConditions = TagConditions;
			this.AddTags = AddTags;
			this.RemoveTags = RemoveTags;
			this.AddBuffs = AddBuffs;
			this.RemoveBuffs = RemoveBuffs;
			this.AddBullets = AddBullets;
			this.UseSkillId = UseSkillId;
			this.ChangeMainSkillPriority = ChangeMainSkillPriority;
			this.CustomAction = CustomAction;
			this.CustomActionParam = CustomActionParam;
		}

		// Token: 0x06028A95 RID: 166549 RVA: 0x009B19D8 File Offset: 0x009AFBD8
		protected override IntPtr GetUStructPtr()
		{
			return SBattleQteAction.StaticStruct();
		}

		// Token: 0x06028A96 RID: 166550 RVA: 0x009B19E4 File Offset: 0x009AFBE4
		[NullableContext(2)]
		public SBattleQteAction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028A97 RID: 166551 RVA: 0x009B19EE File Offset: 0x009AFBEE
		public SBattleQteAction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028A98 RID: 166552 RVA: 0x009B19F9 File Offset: 0x009AFBF9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBattleQteAction(Pointer, false, true);
		}

		// Token: 0x06028A99 RID: 166553 RVA: 0x009B1A03 File Offset: 0x009AFC03
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBattleQteAction(Pointer, MemoryOwner);
		}

		// Token: 0x04014C7C RID: 85116
		public const string __ObjectPath = "/Game/Aki/Data/Qte/SBattleQteAction.SBattleQteAction";

		// Token: 0x04014C7D RID: 85117
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014C7E RID: 85118
		internal static int __PropertyOffset_0;

		// Token: 0x04014C7F RID: 85119
		internal static int __PropertyOffset_1;

		// Token: 0x04014C80 RID: 85120
		[Nullable(2)]
		private TArray<FGameplayTag> _TagConditions;

		// Token: 0x04014C81 RID: 85121
		internal static int __PropertyOffset_2;

		// Token: 0x04014C82 RID: 85122
		[Nullable(2)]
		private TArray<FGameplayTag> _AddTags;

		// Token: 0x04014C83 RID: 85123
		internal static int __PropertyOffset_3;

		// Token: 0x04014C84 RID: 85124
		[Nullable(2)]
		private TArray<FGameplayTag> _RemoveTags;

		// Token: 0x04014C85 RID: 85125
		internal static int __PropertyOffset_4;

		// Token: 0x04014C86 RID: 85126
		[Nullable(2)]
		private TArray<long> _AddBuffs;

		// Token: 0x04014C87 RID: 85127
		internal static int __PropertyOffset_5;

		// Token: 0x04014C88 RID: 85128
		[Nullable(2)]
		private TArray<long> _RemoveBuffs;

		// Token: 0x04014C89 RID: 85129
		internal static int __PropertyOffset_6;

		// Token: 0x04014C8A RID: 85130
		[Nullable(2)]
		private TArray<long> _AddBullets;

		// Token: 0x04014C8B RID: 85131
		internal static int __PropertyOffset_7;

		// Token: 0x04014C8C RID: 85132
		internal static int __PropertyOffset_8;

		// Token: 0x04014C8D RID: 85133
		internal static int __PropertyOffset_9;

		// Token: 0x04014C8E RID: 85134
		internal static int __PropertyOffset_10;
	}
}
