using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004301 RID: 17153
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCharacterPart.SCharacterPart")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 364)]
	public class SCharacterPart : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C568 RID: 181608 RVA: 0x00A1D6C6 File Offset: 0x00A1B8C6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCharacterPart._ScriptStructPtr != 0) ? SCharacterPart._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCharacterPart.SCharacterPart", ref SCharacterPart._ScriptStructPtr);
		}

		// Token: 0x17006EC8 RID: 28360
		// (get) Token: 0x0602C569 RID: 181609 RVA: 0x00A1D6EA File Offset: 0x00A1B8EA
		// (set) Token: 0x0602C56A RID: 181610 RVA: 0x00A1D6FE File Offset: 0x00A1B8FE
		public unsafe string 部位名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCharacterPart.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCharacterPart.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17006EC9 RID: 28361
		// (get) Token: 0x0602C56B RID: 181611 RVA: 0x00A1D714 File Offset: 0x00A1B914
		// (set) Token: 0x0602C56C RID: 181612 RVA: 0x00A1D757 File Offset: 0x00A1B957
		public TArray<string> 骨骼名
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._骨骼名) == null)
				{
					result = (this._骨骼名 = new TArray<string>(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.骨骼名.CopyAssign(value);
			}
		}

		// Token: 0x17006ECA RID: 28362
		// (get) Token: 0x0602C56D RID: 181613 RVA: 0x00A1D765 File Offset: 0x00A1B965
		// (set) Token: 0x0602C56E RID: 181614 RVA: 0x00A1D775 File Offset: 0x00A1B975
		public unsafe bool 是否独立承伤
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006ECB RID: 28363
		// (get) Token: 0x0602C56F RID: 181615 RVA: 0x00A1D786 File Offset: 0x00A1B986
		// (set) Token: 0x0602C570 RID: 181616 RVA: 0x00A1D796 File Offset: 0x00A1B996
		public unsafe bool 是否出生激活
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006ECC RID: 28364
		// (get) Token: 0x0602C571 RID: 181617 RVA: 0x00A1D7A7 File Offset: 0x00A1B9A7
		// (set) Token: 0x0602C572 RID: 181618 RVA: 0x00A1D7BB File Offset: 0x00A1B9BB
		public unsafe FGameplayTag 部位标签
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006ECD RID: 28365
		// (get) Token: 0x0602C573 RID: 181619 RVA: 0x00A1D7D0 File Offset: 0x00A1B9D0
		// (set) Token: 0x0602C574 RID: 181620 RVA: 0x00A1D7E4 File Offset: 0x00A1B9E4
		public unsafe FGameplayTag 部位激活标签
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006ECE RID: 28366
		// (get) Token: 0x0602C575 RID: 181621 RVA: 0x00A1D7F9 File Offset: 0x00A1B9F9
		// (set) Token: 0x0602C576 RID: 181622 RVA: 0x00A1D809 File Offset: 0x00A1BA09
		public unsafe float 继承生命值比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006ECF RID: 28367
		// (get) Token: 0x0602C577 RID: 181623 RVA: 0x00A1D81A File Offset: 0x00A1BA1A
		// (set) Token: 0x0602C578 RID: 181624 RVA: 0x00A1D82A File Offset: 0x00A1BA2A
		public unsafe bool 是否弱点
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006ED0 RID: 28368
		// (get) Token: 0x0602C579 RID: 181625 RVA: 0x00A1D83C File Offset: 0x00A1BA3C
		// (set) Token: 0x0602C57A RID: 181626 RVA: 0x00A1D87F File Offset: 0x00A1BA7F
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TSet<TEnumAsByte<EBulletType>> 弱点攻击类型
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TSet<TEnumAsByte<EBulletType>> result;
				if ((result = this._弱点攻击类型) == null)
				{
					result = (this._弱点攻击类型 = new TSet<TEnumAsByte<EBulletType>>(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.弱点攻击类型.CopyAssign(value);
			}
		}

		// Token: 0x17006ED1 RID: 28369
		// (get) Token: 0x0602C57B RID: 181627 RVA: 0x00A1D88D File Offset: 0x00A1BA8D
		// (set) Token: 0x0602C57C RID: 181628 RVA: 0x00A1D89D File Offset: 0x00A1BA9D
		public unsafe float 弱点受击角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006ED2 RID: 28370
		// (get) Token: 0x0602C57D RID: 181629 RVA: 0x00A1D8AE File Offset: 0x00A1BAAE
		// (set) Token: 0x0602C57E RID: 181630 RVA: 0x00A1D8BE File Offset: 0x00A1BABE
		public unsafe bool 精准弱点受击角度判定
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006ED3 RID: 28371
		// (get) Token: 0x0602C57F RID: 181631 RVA: 0x00A1D8D0 File Offset: 0x00A1BAD0
		// (set) Token: 0x0602C580 RID: 181632 RVA: 0x00A1D913 File Offset: 0x00A1BB13
		public TMap<string, string> 碰撞框朝向
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._碰撞框朝向) == null)
				{
					result = (this._碰撞框朝向 = new TMap<string, string>(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_11, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.碰撞框朝向.CopyAssign(value);
			}
		}

		// Token: 0x17006ED4 RID: 28372
		// (get) Token: 0x0602C581 RID: 181633 RVA: 0x00A1D921 File Offset: 0x00A1BB21
		// (set) Token: 0x0602C582 RID: 181634 RVA: 0x00A1D931 File Offset: 0x00A1BB31
		public unsafe bool 是否盾牌
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006ED5 RID: 28373
		// (get) Token: 0x0602C583 RID: 181635 RVA: 0x00A1D942 File Offset: 0x00A1BB42
		// (set) Token: 0x0602C584 RID: 181636 RVA: 0x00A1D952 File Offset: 0x00A1BB52
		public unsafe float 格挡判定角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006ED6 RID: 28374
		// (get) Token: 0x0602C585 RID: 181637 RVA: 0x00A1D963 File Offset: 0x00A1BB63
		// (set) Token: 0x0602C586 RID: 181638 RVA: 0x00A1D973 File Offset: 0x00A1BB73
		public unsafe bool 是否传递伤害
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006ED7 RID: 28375
		// (get) Token: 0x0602C587 RID: 181639 RVA: 0x00A1D984 File Offset: 0x00A1BB84
		// (set) Token: 0x0602C588 RID: 181640 RVA: 0x00A1D994 File Offset: 0x00A1BB94
		public unsafe bool 是否在目标创建时显示部位状态条
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006ED8 RID: 28376
		// (get) Token: 0x0602C589 RID: 181641 RVA: 0x00A1D9A5 File Offset: 0x00A1BBA5
		// (set) Token: 0x0602C58A RID: 181642 RVA: 0x00A1D9B9 File Offset: 0x00A1BBB9
		public unsafe FName 部位状态条骨骼插槽
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006ED9 RID: 28377
		// (get) Token: 0x0602C58B RID: 181643 RVA: 0x00A1D9CE File Offset: 0x00A1BBCE
		// (set) Token: 0x0602C58C RID: 181644 RVA: 0x00A1D9DE File Offset: 0x00A1BBDE
		public unsafe float 受击后血条显示时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006EDA RID: 28378
		// (get) Token: 0x0602C58D RID: 181645 RVA: 0x00A1D9F0 File Offset: 0x00A1BBF0
		// (set) Token: 0x0602C58E RID: 181646 RVA: 0x00A1DA33 File Offset: 0x00A1BC33
		public TArray<long> 属性快照Buff列表
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._属性快照Buff列表) == null)
				{
					result = (this._属性快照Buff列表 = new TArray<long>(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_18, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.属性快照Buff列表.CopyAssign(value);
			}
		}

		// Token: 0x17006EDB RID: 28379
		// (get) Token: 0x0602C58F RID: 181647 RVA: 0x00A1DA41 File Offset: 0x00A1BC41
		// (set) Token: 0x0602C590 RID: 181648 RVA: 0x00A1DA55 File Offset: 0x00A1BC55
		[Nullable(2)]
		public unsafe UEffectModelBase 扫描特效
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + SCharacterPart.__PropertyOffset_19);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SCharacterPart.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17006EDC RID: 28380
		// (get) Token: 0x0602C591 RID: 181649 RVA: 0x00A1DA6C File Offset: 0x00A1BC6C
		// (set) Token: 0x0602C592 RID: 181650 RVA: 0x00A1DAAF File Offset: 0x00A1BCAF
		public FSoftObjectPath 被扫描播放特效
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._被扫描播放特效) == null)
				{
					result = (this._被扫描播放特效 = new FSoftObjectPath(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_20, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_20, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006EDD RID: 28381
		// (get) Token: 0x0602C593 RID: 181651 RVA: 0x00A1DAD0 File Offset: 0x00A1BCD0
		// (set) Token: 0x0602C594 RID: 181652 RVA: 0x00A1DAE4 File Offset: 0x00A1BCE4
		public unsafe string 扫描特效绑定骨骼名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCharacterPart.__PropertyOffset_21)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCharacterPart.__PropertyOffset_21)), value);
			}
		}

		// Token: 0x17006EDE RID: 28382
		// (get) Token: 0x0602C595 RID: 181653 RVA: 0x00A1DAF9 File Offset: 0x00A1BCF9
		// (set) Token: 0x0602C596 RID: 181654 RVA: 0x00A1DB0D File Offset: 0x00A1BD0D
		[Nullable(2)]
		public unsafe PD_CharacterControllerData_C 扫描材质特效
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CharacterControllerData_C>(base.NativePtr / (IntPtr)sizeof(void*) + SCharacterPart.__PropertyOffset_22);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SCharacterPart.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17006EDF RID: 28383
		// (get) Token: 0x0602C597 RID: 181655 RVA: 0x00A1DB22 File Offset: 0x00A1BD22
		// (set) Token: 0x0602C598 RID: 181656 RVA: 0x00A1DB36 File Offset: 0x00A1BD36
		public unsafe FName 合体骨骼名
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterPart.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x0602C599 RID: 181657 RVA: 0x00A1DB4B File Offset: 0x00A1BD4B
		public SCharacterPart()
		{
		}

		// Token: 0x0602C59A RID: 181658 RVA: 0x00A1DB54 File Offset: 0x00A1BD54
		public SCharacterPart(string 部位名, TArray<string> 骨骼名, bool 是否独立承伤, bool 是否出生激活, FGameplayTag 部位标签, FGameplayTag 部位激活标签, float 继承生命值比例, bool 是否弱点, [Nullable(new byte[]
		{
			1,
			0
		})] TSet<TEnumAsByte<EBulletType>> 弱点攻击类型, float 弱点受击角度, bool 精准弱点受击角度判定, TMap<string, string> 碰撞框朝向, bool 是否盾牌, float 格挡判定角度, bool 是否传递伤害, bool 是否在目标创建时显示部位状态条, FName 部位状态条骨骼插槽, float 受击后血条显示时长, TArray<long> 属性快照Buff列表, UEffectModelBase 扫描特效, FSoftObjectPath 被扫描播放特效, string 扫描特效绑定骨骼名, PD_CharacterControllerData_C 扫描材质特效, FName 合体骨骼名)
		{
			this.部位名 = 部位名;
			this.骨骼名 = 骨骼名;
			this.是否独立承伤 = 是否独立承伤;
			this.是否出生激活 = 是否出生激活;
			this.部位标签 = 部位标签;
			this.部位激活标签 = 部位激活标签;
			this.继承生命值比例 = 继承生命值比例;
			this.是否弱点 = 是否弱点;
			this.弱点攻击类型 = 弱点攻击类型;
			this.弱点受击角度 = 弱点受击角度;
			this.精准弱点受击角度判定 = 精准弱点受击角度判定;
			this.碰撞框朝向 = 碰撞框朝向;
			this.是否盾牌 = 是否盾牌;
			this.格挡判定角度 = 格挡判定角度;
			this.是否传递伤害 = 是否传递伤害;
			this.是否在目标创建时显示部位状态条 = 是否在目标创建时显示部位状态条;
			this.部位状态条骨骼插槽 = 部位状态条骨骼插槽;
			this.受击后血条显示时长 = 受击后血条显示时长;
			this.属性快照Buff列表 = 属性快照Buff列表;
			this.扫描特效 = 扫描特效;
			this.被扫描播放特效 = 被扫描播放特效;
			this.扫描特效绑定骨骼名 = 扫描特效绑定骨骼名;
			this.扫描材质特效 = 扫描材质特效;
			this.合体骨骼名 = 合体骨骼名;
		}

		// Token: 0x0602C59B RID: 181659 RVA: 0x00A1DC24 File Offset: 0x00A1BE24
		protected override IntPtr GetUStructPtr()
		{
			return SCharacterPart.StaticStruct();
		}

		// Token: 0x0602C59C RID: 181660 RVA: 0x00A1DC30 File Offset: 0x00A1BE30
		[NullableContext(2)]
		public SCharacterPart(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C59D RID: 181661 RVA: 0x00A1DC3A File Offset: 0x00A1BE3A
		public SCharacterPart(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C59E RID: 181662 RVA: 0x00A1DC45 File Offset: 0x00A1BE45
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCharacterPart(Pointer, false, true);
		}

		// Token: 0x0602C59F RID: 181663 RVA: 0x00A1DC4F File Offset: 0x00A1BE4F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCharacterPart(Pointer, MemoryOwner);
		}

		// Token: 0x0401760C RID: 95756
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCharacterPart.SCharacterPart";

		// Token: 0x0401760D RID: 95757
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401760E RID: 95758
		internal static int __PropertyOffset_0;

		// Token: 0x0401760F RID: 95759
		internal static int __PropertyOffset_1;

		// Token: 0x04017610 RID: 95760
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _骨骼名;

		// Token: 0x04017611 RID: 95761
		internal static int __PropertyOffset_2;

		// Token: 0x04017612 RID: 95762
		internal static int __PropertyOffset_3;

		// Token: 0x04017613 RID: 95763
		internal static int __PropertyOffset_4;

		// Token: 0x04017614 RID: 95764
		internal static int __PropertyOffset_5;

		// Token: 0x04017615 RID: 95765
		internal static int __PropertyOffset_6;

		// Token: 0x04017616 RID: 95766
		internal static int __PropertyOffset_7;

		// Token: 0x04017617 RID: 95767
		internal static int __PropertyOffset_8;

		// Token: 0x04017618 RID: 95768
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TSet<TEnumAsByte<EBulletType>> _弱点攻击类型;

		// Token: 0x04017619 RID: 95769
		internal static int __PropertyOffset_9;

		// Token: 0x0401761A RID: 95770
		internal static int __PropertyOffset_10;

		// Token: 0x0401761B RID: 95771
		internal static int __PropertyOffset_11;

		// Token: 0x0401761C RID: 95772
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _碰撞框朝向;

		// Token: 0x0401761D RID: 95773
		internal static int __PropertyOffset_12;

		// Token: 0x0401761E RID: 95774
		internal static int __PropertyOffset_13;

		// Token: 0x0401761F RID: 95775
		internal static int __PropertyOffset_14;

		// Token: 0x04017620 RID: 95776
		internal static int __PropertyOffset_15;

		// Token: 0x04017621 RID: 95777
		internal static int __PropertyOffset_16;

		// Token: 0x04017622 RID: 95778
		internal static int __PropertyOffset_17;

		// Token: 0x04017623 RID: 95779
		internal static int __PropertyOffset_18;

		// Token: 0x04017624 RID: 95780
		[Nullable(2)]
		private TArray<long> _属性快照Buff列表;

		// Token: 0x04017625 RID: 95781
		internal static int __PropertyOffset_19;

		// Token: 0x04017626 RID: 95782
		internal static int __PropertyOffset_20;

		// Token: 0x04017627 RID: 95783
		[Nullable(2)]
		private FSoftObjectPath _被扫描播放特效;

		// Token: 0x04017628 RID: 95784
		internal static int __PropertyOffset_21;

		// Token: 0x04017629 RID: 95785
		internal static int __PropertyOffset_22;

		// Token: 0x0401762A RID: 95786
		internal static int __PropertyOffset_23;
	}
}
