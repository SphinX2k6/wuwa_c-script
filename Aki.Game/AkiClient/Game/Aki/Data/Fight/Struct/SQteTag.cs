using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F71 RID: 16241
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SQteTag.SQteTag")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 91)]
	public class SQteTag : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060296B6 RID: 169654 RVA: 0x009C3B64 File Offset: 0x009C1D64
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQteTag._ScriptStructPtr != 0) ? SQteTag._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SQteTag.SQteTag", ref SQteTag._ScriptStructPtr);
		}

		// Token: 0x1700631D RID: 25373
		// (get) Token: 0x060296B7 RID: 169655 RVA: 0x009C3B88 File Offset: 0x009C1D88
		// (set) Token: 0x060296B8 RID: 169656 RVA: 0x009C3B9C File Offset: 0x009C1D9C
		public unsafe FGameplayTag QteTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700631E RID: 25374
		// (get) Token: 0x060296B9 RID: 169657 RVA: 0x009C3BB1 File Offset: 0x009C1DB1
		// (set) Token: 0x060296BA RID: 169658 RVA: 0x009C3BC5 File Offset: 0x009C1DC5
		public unsafe FGameplayTag NoTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700631F RID: 25375
		// (get) Token: 0x060296BB RID: 169659 RVA: 0x009C3BDA File Offset: 0x009C1DDA
		// (set) Token: 0x060296BC RID: 169660 RVA: 0x009C3BEE File Offset: 0x009C1DEE
		public unsafe FGameplayTag QteTrigger
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006320 RID: 25376
		// (get) Token: 0x060296BD RID: 169661 RVA: 0x009C3C03 File Offset: 0x009C1E03
		// (set) Token: 0x060296BE RID: 169662 RVA: 0x009C3C17 File Offset: 0x009C1E17
		public unsafe FGameplayTag ExitSkillTrigger
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006321 RID: 25377
		// (get) Token: 0x060296BF RID: 169663 RVA: 0x009C3C2C File Offset: 0x009C1E2C
		// (set) Token: 0x060296C0 RID: 169664 RVA: 0x009C3C3C File Offset: 0x009C1E3C
		public unsafe int Energy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006322 RID: 25378
		// (get) Token: 0x060296C1 RID: 169665 RVA: 0x009C3C50 File Offset: 0x009C1E50
		// (set) Token: 0x060296C2 RID: 169666 RVA: 0x009C3C93 File Offset: 0x009C1E93
		public TArray<long> QteBuffs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._QteBuffs) == null)
				{
					result = (this._QteBuffs = new TArray<long>(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.QteBuffs.CopyAssign(value);
			}
		}

		// Token: 0x17006323 RID: 25379
		// (get) Token: 0x060296C3 RID: 169667 RVA: 0x009C3CA4 File Offset: 0x009C1EA4
		// (set) Token: 0x060296C4 RID: 169668 RVA: 0x009C3CE7 File Offset: 0x009C1EE7
		public TArray<long> ConsumeBuffs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._ConsumeBuffs) == null)
				{
					result = (this._ConsumeBuffs = new TArray<long>(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ConsumeBuffs.CopyAssign(value);
			}
		}

		// Token: 0x17006324 RID: 25380
		// (get) Token: 0x060296C5 RID: 169669 RVA: 0x009C3CF5 File Offset: 0x009C1EF5
		// (set) Token: 0x060296C6 RID: 169670 RVA: 0x009C3D05 File Offset: 0x009C1F05
		public unsafe bool ChangeRoleOnQte
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006325 RID: 25381
		// (get) Token: 0x060296C7 RID: 169671 RVA: 0x009C3D16 File Offset: 0x009C1F16
		// (set) Token: 0x060296C8 RID: 169672 RVA: 0x009C3D26 File Offset: 0x009C1F26
		public unsafe bool ChangeRole
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006326 RID: 25382
		// (get) Token: 0x060296C9 RID: 169673 RVA: 0x009C3D37 File Offset: 0x009C1F37
		// (set) Token: 0x060296CA RID: 169674 RVA: 0x009C3D47 File Offset: 0x009C1F47
		public unsafe byte Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQteTag.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x060296CB RID: 169675 RVA: 0x009C3D58 File Offset: 0x009C1F58
		public SQteTag()
		{
		}

		// Token: 0x060296CC RID: 169676 RVA: 0x009C3D60 File Offset: 0x009C1F60
		public SQteTag(FGameplayTag QteTag, FGameplayTag NoTag, FGameplayTag QteTrigger, FGameplayTag ExitSkillTrigger, int Energy, TArray<long> QteBuffs, TArray<long> ConsumeBuffs, bool ChangeRoleOnQte, bool ChangeRole, byte Priority)
		{
			this.QteTag = QteTag;
			this.NoTag = NoTag;
			this.QteTrigger = QteTrigger;
			this.ExitSkillTrigger = ExitSkillTrigger;
			this.Energy = Energy;
			this.QteBuffs = QteBuffs;
			this.ConsumeBuffs = ConsumeBuffs;
			this.ChangeRoleOnQte = ChangeRoleOnQte;
			this.ChangeRole = ChangeRole;
			this.Priority = Priority;
		}

		// Token: 0x060296CD RID: 169677 RVA: 0x009C3DC0 File Offset: 0x009C1FC0
		protected override IntPtr GetUStructPtr()
		{
			return SQteTag.StaticStruct();
		}

		// Token: 0x060296CE RID: 169678 RVA: 0x009C3DCC File Offset: 0x009C1FCC
		[NullableContext(2)]
		public SQteTag(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060296CF RID: 169679 RVA: 0x009C3DD6 File Offset: 0x009C1FD6
		public SQteTag(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060296D0 RID: 169680 RVA: 0x009C3DE1 File Offset: 0x009C1FE1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQteTag(Pointer, false, true);
		}

		// Token: 0x060296D1 RID: 169681 RVA: 0x009C3DEB File Offset: 0x009C1FEB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQteTag(Pointer, MemoryOwner);
		}

		// Token: 0x0401538C RID: 86924
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SQteTag.SQteTag";

		// Token: 0x0401538D RID: 86925
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401538E RID: 86926
		internal static int __PropertyOffset_0;

		// Token: 0x0401538F RID: 86927
		internal static int __PropertyOffset_1;

		// Token: 0x04015390 RID: 86928
		internal static int __PropertyOffset_2;

		// Token: 0x04015391 RID: 86929
		internal static int __PropertyOffset_3;

		// Token: 0x04015392 RID: 86930
		internal static int __PropertyOffset_4;

		// Token: 0x04015393 RID: 86931
		internal static int __PropertyOffset_5;

		// Token: 0x04015394 RID: 86932
		[Nullable(2)]
		private TArray<long> _QteBuffs;

		// Token: 0x04015395 RID: 86933
		internal static int __PropertyOffset_6;

		// Token: 0x04015396 RID: 86934
		[Nullable(2)]
		private TArray<long> _ConsumeBuffs;

		// Token: 0x04015397 RID: 86935
		internal static int __PropertyOffset_7;

		// Token: 0x04015398 RID: 86936
		internal static int __PropertyOffset_8;

		// Token: 0x04015399 RID: 86937
		internal static int __PropertyOffset_9;
	}
}
