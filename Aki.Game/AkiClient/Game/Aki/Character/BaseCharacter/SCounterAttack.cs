using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004304 RID: 17156
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCounterAttack.SCounterAttack")]
	[UnrealStructLayout(1152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1149)]
	public class SCounterAttack : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C5AE RID: 181678 RVA: 0x00A1DE1A File Offset: 0x00A1C01A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCounterAttack._ScriptStructPtr != 0) ? SCounterAttack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCounterAttack.SCounterAttack", ref SCounterAttack._ScriptStructPtr);
		}

		// Token: 0x17006EE0 RID: 28384
		// (get) Token: 0x0602C5AF RID: 181679 RVA: 0x00A1DE40 File Offset: 0x00A1C040
		// (set) Token: 0x0602C5B0 RID: 181680 RVA: 0x00A1DE83 File Offset: 0x00A1C083
		public TArray<FName> 弹反部位
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._弹反部位) == null)
				{
					result = (this._弹反部位 = new TArray<FName>(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.弹反部位.CopyAssign(value);
			}
		}

		// Token: 0x17006EE1 RID: 28385
		// (get) Token: 0x0602C5B1 RID: 181681 RVA: 0x00A1DE94 File Offset: 0x00A1C094
		// (set) Token: 0x0602C5B2 RID: 181682 RVA: 0x00A1DED7 File Offset: 0x00A1C0D7
		public SCounterAttackEffect 无弹反动作效果
		{
			get
			{
				base.FastCheckIsValid();
				SCounterAttackEffect result;
				if ((result = this._无弹反动作效果) == null)
				{
					result = (this._无弹反动作效果 = new SCounterAttackEffect(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCounterAttackEffect.StaticStruct(), base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006EE2 RID: 28386
		// (get) Token: 0x0602C5B3 RID: 181683 RVA: 0x00A1DEF8 File Offset: 0x00A1C0F8
		// (set) Token: 0x0602C5B4 RID: 181684 RVA: 0x00A1DF3B File Offset: 0x00A1C13B
		public SCounterAttackEffect 有弹反动作效果
		{
			get
			{
				base.FastCheckIsValid();
				SCounterAttackEffect result;
				if ((result = this._有弹反动作效果) == null)
				{
					result = (this._有弹反动作效果 = new SCounterAttackEffect(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCounterAttackEffect.StaticStruct(), base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006EE3 RID: 28387
		// (get) Token: 0x0602C5B5 RID: 181685 RVA: 0x00A1DF5C File Offset: 0x00A1C15C
		// (set) Token: 0x0602C5B6 RID: 181686 RVA: 0x00A1DF6C File Offset: 0x00A1C16C
		public unsafe float 削韧倍率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006EE4 RID: 28388
		// (get) Token: 0x0602C5B7 RID: 181687 RVA: 0x00A1DF7D File Offset: 0x00A1C17D
		// (set) Token: 0x0602C5B8 RID: 181688 RVA: 0x00A1DF8D File Offset: 0x00A1C18D
		public unsafe float 最大触发距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006EE5 RID: 28389
		// (get) Token: 0x0602C5B9 RID: 181689 RVA: 0x00A1DF9E File Offset: 0x00A1C19E
		// (set) Token: 0x0602C5BA RID: 181690 RVA: 0x00A1DFAE File Offset: 0x00A1C1AE
		public unsafe float 最大触发夹角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006EE6 RID: 28390
		// (get) Token: 0x0602C5BB RID: 181691 RVA: 0x00A1DFBF File Offset: 0x00A1C1BF
		// (set) Token: 0x0602C5BC RID: 181692 RVA: 0x00A1DFCF File Offset: 0x00A1C1CF
		public unsafe long 被弹反者应用BuffID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006EE7 RID: 28391
		// (get) Token: 0x0602C5BD RID: 181693 RVA: 0x00A1DFE0 File Offset: 0x00A1C1E0
		// (set) Token: 0x0602C5BE RID: 181694 RVA: 0x00A1DFF0 File Offset: 0x00A1C1F0
		public unsafe long 攻击者应用BuffID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006EE8 RID: 28392
		// (get) Token: 0x0602C5BF RID: 181695 RVA: 0x00A1E001 File Offset: 0x00A1C201
		// (set) Token: 0x0602C5C0 RID: 181696 RVA: 0x00A1E011 File Offset: 0x00A1C211
		public unsafe bool 受击动画忽略Buff检测
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006EE9 RID: 28393
		// (get) Token: 0x0602C5C1 RID: 181697 RVA: 0x00A1E024 File Offset: 0x00A1C224
		// (set) Token: 0x0602C5C2 RID: 181698 RVA: 0x00A1E067 File Offset: 0x00A1C267
		public TArray<SCounterAttackBuff> 检测Buff列表
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SCounterAttackBuff> result;
				if ((result = this._检测Buff列表) == null)
				{
					result = (this._检测Buff列表 = new TArray<SCounterAttackBuff>(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_9, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.检测Buff列表.CopyAssign(value);
			}
		}

		// Token: 0x17006EEA RID: 28394
		// (get) Token: 0x0602C5C3 RID: 181699 RVA: 0x00A1E075 File Offset: 0x00A1C275
		// (set) Token: 0x0602C5C4 RID: 181700 RVA: 0x00A1E085 File Offset: 0x00A1C285
		public unsafe long ANS期间被弹反者生效的BuffID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006EEB RID: 28395
		// (get) Token: 0x0602C5C5 RID: 181701 RVA: 0x00A1E096 File Offset: 0x00A1C296
		// (set) Token: 0x0602C5C6 RID: 181702 RVA: 0x00A1E0AA File Offset: 0x00A1C2AA
		public unsafe FGameplayTag 结束事件Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006EEC RID: 28396
		// (get) Token: 0x0602C5C7 RID: 181703 RVA: 0x00A1E0BF File Offset: 0x00A1C2BF
		// (set) Token: 0x0602C5C8 RID: 181704 RVA: 0x00A1E0CF File Offset: 0x00A1C2CF
		public unsafe bool QTE弹刀忽略角度距离检测
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCounterAttack.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602C5C9 RID: 181705 RVA: 0x00A1E0E0 File Offset: 0x00A1C2E0
		public SCounterAttack()
		{
		}

		// Token: 0x0602C5CA RID: 181706 RVA: 0x00A1E0E8 File Offset: 0x00A1C2E8
		public SCounterAttack(TArray<FName> 弹反部位, SCounterAttackEffect 无弹反动作效果, SCounterAttackEffect 有弹反动作效果, float 削韧倍率, float 最大触发距离, float 最大触发夹角, long 被弹反者应用BuffID, long 攻击者应用BuffID, bool 受击动画忽略Buff检测, TArray<SCounterAttackBuff> 检测Buff列表, long ANS期间被弹反者生效的BuffID, FGameplayTag 结束事件Tag, bool QTE弹刀忽略角度距离检测)
		{
			this.弹反部位 = 弹反部位;
			this.无弹反动作效果 = 无弹反动作效果;
			this.有弹反动作效果 = 有弹反动作效果;
			this.削韧倍率 = 削韧倍率;
			this.最大触发距离 = 最大触发距离;
			this.最大触发夹角 = 最大触发夹角;
			this.被弹反者应用BuffID = 被弹反者应用BuffID;
			this.攻击者应用BuffID = 攻击者应用BuffID;
			this.受击动画忽略Buff检测 = 受击动画忽略Buff检测;
			this.检测Buff列表 = 检测Buff列表;
			this.ANS期间被弹反者生效的BuffID = ANS期间被弹反者生效的BuffID;
			this.结束事件Tag = 结束事件Tag;
			this.QTE弹刀忽略角度距离检测 = QTE弹刀忽略角度距离检测;
		}

		// Token: 0x0602C5CB RID: 181707 RVA: 0x00A1E160 File Offset: 0x00A1C360
		protected override IntPtr GetUStructPtr()
		{
			return SCounterAttack.StaticStruct();
		}

		// Token: 0x0602C5CC RID: 181708 RVA: 0x00A1E16C File Offset: 0x00A1C36C
		[NullableContext(2)]
		public SCounterAttack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C5CD RID: 181709 RVA: 0x00A1E176 File Offset: 0x00A1C376
		public SCounterAttack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C5CE RID: 181710 RVA: 0x00A1E181 File Offset: 0x00A1C381
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCounterAttack(Pointer, false, true);
		}

		// Token: 0x0602C5CF RID: 181711 RVA: 0x00A1E18B File Offset: 0x00A1C38B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCounterAttack(Pointer, MemoryOwner);
		}

		// Token: 0x04017636 RID: 95798
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCounterAttack.SCounterAttack";

		// Token: 0x04017637 RID: 95799
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017638 RID: 95800
		internal static int __PropertyOffset_0;

		// Token: 0x04017639 RID: 95801
		[Nullable(2)]
		private TArray<FName> _弹反部位;

		// Token: 0x0401763A RID: 95802
		internal static int __PropertyOffset_1;

		// Token: 0x0401763B RID: 95803
		[Nullable(2)]
		private SCounterAttackEffect _无弹反动作效果;

		// Token: 0x0401763C RID: 95804
		internal static int __PropertyOffset_2;

		// Token: 0x0401763D RID: 95805
		[Nullable(2)]
		private SCounterAttackEffect _有弹反动作效果;

		// Token: 0x0401763E RID: 95806
		internal static int __PropertyOffset_3;

		// Token: 0x0401763F RID: 95807
		internal static int __PropertyOffset_4;

		// Token: 0x04017640 RID: 95808
		internal static int __PropertyOffset_5;

		// Token: 0x04017641 RID: 95809
		internal static int __PropertyOffset_6;

		// Token: 0x04017642 RID: 95810
		internal static int __PropertyOffset_7;

		// Token: 0x04017643 RID: 95811
		internal static int __PropertyOffset_8;

		// Token: 0x04017644 RID: 95812
		internal static int __PropertyOffset_9;

		// Token: 0x04017645 RID: 95813
		[Nullable(2)]
		private TArray<SCounterAttackBuff> _检测Buff列表;

		// Token: 0x04017646 RID: 95814
		internal static int __PropertyOffset_10;

		// Token: 0x04017647 RID: 95815
		internal static int __PropertyOffset_11;

		// Token: 0x04017648 RID: 95816
		internal static int __PropertyOffset_12;
	}
}
