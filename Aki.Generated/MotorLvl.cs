using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E5C RID: 3676
	public struct MotorLvl : IFlatbufferObject
	{
		// Token: 0x170021B0 RID: 8624
		// (get) Token: 0x06009AD0 RID: 39632 RVA: 0x00294535 File Offset: 0x00292735
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009AD1 RID: 39633 RVA: 0x00294542 File Offset: 0x00292742
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009AD2 RID: 39634 RVA: 0x0029454C File Offset: 0x0029274C
		public static MotorLvl GetRootAsMotorLvl(ByteBuffer _bb)
		{
			return MotorLvl.GetRootAsMotorLvl(_bb, default(MotorLvl));
		}

		// Token: 0x06009AD3 RID: 39635 RVA: 0x00294568 File Offset: 0x00292768
		public static MotorLvl GetRootAsMotorLvl(ByteBuffer _bb, MotorLvl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009AD4 RID: 39636 RVA: 0x00294585 File Offset: 0x00292785
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009AD5 RID: 39637 RVA: 0x00294594 File Offset: 0x00292794
		public MotorLvl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021B1 RID: 8625
		// (get) Token: 0x06009AD6 RID: 39638 RVA: 0x002945A4 File Offset: 0x002927A4
		public int Level
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170021B2 RID: 8626
		// (get) Token: 0x06009AD7 RID: 39639 RVA: 0x002945E0 File Offset: 0x002927E0
		public int Exp
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170021B3 RID: 8627
		// (get) Token: 0x06009AD8 RID: 39640 RVA: 0x0029461C File Offset: 0x0029281C
		public int RewardId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009AD9 RID: 39641 RVA: 0x00294658 File Offset: 0x00292858
		public DicIntInt? WorldLv2Attack(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170021B4 RID: 8628
		// (get) Token: 0x06009ADA RID: 39642 RVA: 0x002946BC File Offset: 0x002928BC
		public int WorldLv2AttackLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170021B5 RID: 8629
		// (get) Token: 0x06009ADB RID: 39643 RVA: 0x002946E8 File Offset: 0x002928E8
		public int Speed
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170021B6 RID: 8630
		// (get) Token: 0x06009ADC RID: 39644 RVA: 0x00294728 File Offset: 0x00292928
		public int NitrogenSpeedValue
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170021B7 RID: 8631
		// (get) Token: 0x06009ADD RID: 39645 RVA: 0x00294768 File Offset: 0x00292968
		public int NitrogenValue
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170021B8 RID: 8632
		// (get) Token: 0x06009ADE RID: 39646 RVA: 0x002947A8 File Offset: 0x002929A8
		public int NitrogenRecoverRate
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170021B9 RID: 8633
		// (get) Token: 0x06009ADF RID: 39647 RVA: 0x002947E8 File Offset: 0x002929E8
		public float NitrogenRecoverCoolDown
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170021BA RID: 8634
		// (get) Token: 0x06009AE0 RID: 39648 RVA: 0x0029482C File Offset: 0x00292A2C
		public int NitrogenConsumeRate
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170021BB RID: 8635
		// (get) Token: 0x06009AE1 RID: 39649 RVA: 0x0029486C File Offset: 0x00292A6C
		public int MotorInitialShieldRate
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009AE2 RID: 39650 RVA: 0x002948AC File Offset: 0x00292AAC
		public DicIntInt? WorldLv2MotorShield(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170021BC RID: 8636
		// (get) Token: 0x06009AE3 RID: 39651 RVA: 0x00294910 File Offset: 0x00292B10
		public int WorldLv2MotorShieldLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170021BD RID: 8637
		// (get) Token: 0x06009AE4 RID: 39652 RVA: 0x0029493C File Offset: 0x00292B3C
		public int MotorShieldRecoverRate
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170021BE RID: 8638
		// (get) Token: 0x06009AE5 RID: 39653 RVA: 0x0029497C File Offset: 0x00292B7C
		public float MotorShieldCoolDown
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170021BF RID: 8639
		// (get) Token: 0x06009AE6 RID: 39654 RVA: 0x002949C0 File Offset: 0x00292BC0
		public int SoaringEnergy
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009AE7 RID: 39655 RVA: 0x00294A00 File Offset: 0x00292C00
		[NullableContext(1)]
		[Obsolete("已废弃，请使用WorldLv2AttackFrozenDict()缓存字典，遍历请使用WorldLv2AttackIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> WorldLv2Attack()
		{
			return this.WorldLv2AttackIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06009AE8 RID: 39656 RVA: 0x00294A56 File Offset: 0x00292C56
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> WorldLv2AttackIter()
		{
			MotorLvl.<WorldLv2AttackIter>d__41 <WorldLv2AttackIter>d__ = new MotorLvl.<WorldLv2AttackIter>d__41(-2);
			<WorldLv2AttackIter>d__.<>3__<>4__this = this;
			return <WorldLv2AttackIter>d__;
		}

		// Token: 0x06009AE9 RID: 39657 RVA: 0x00294A6C File Offset: 0x00292C6C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用WorldLv2MotorShieldFrozenDict()缓存字典，遍历请使用WorldLv2MotorShieldIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> WorldLv2MotorShield()
		{
			return this.WorldLv2MotorShieldIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06009AEA RID: 39658 RVA: 0x00294AC2 File Offset: 0x00292CC2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> WorldLv2MotorShieldIter()
		{
			MotorLvl.<WorldLv2MotorShieldIter>d__43 <WorldLv2MotorShieldIter>d__ = new MotorLvl.<WorldLv2MotorShieldIter>d__43(-2);
			<WorldLv2MotorShieldIter>d__.<>3__<>4__this = this;
			return <WorldLv2MotorShieldIter>d__;
		}

		// Token: 0x06009AEB RID: 39659 RVA: 0x00294AD8 File Offset: 0x00292CD8
		public int? GetWorldLv2Attack(int key)
		{
			this.EnsureWorldLv2AttackCacheIfNeeded();
			int value;
			if (!this.WorldLv2AttackCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06009AEC RID: 39660 RVA: 0x00294B0C File Offset: 0x00292D0C
		public int? GetWorldLv2MotorShield(int key)
		{
			this.EnsureWorldLv2MotorShieldCacheIfNeeded();
			int value;
			if (!this.WorldLv2MotorShieldCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06009AED RID: 39661 RVA: 0x00294B40 File Offset: 0x00292D40
		private void EnsureWorldLv2AttackCacheIfNeeded()
		{
			if (this.WorldLv2AttackCache != null)
			{
				return;
			}
			this.WorldLv2AttackCache = this.WorldLv2AttackIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06009AEE RID: 39662 RVA: 0x00294BA8 File Offset: 0x00292DA8
		private void EnsureWorldLv2MotorShieldCacheIfNeeded()
		{
			if (this.WorldLv2MotorShieldCache != null)
			{
				return;
			}
			this.WorldLv2MotorShieldCache = this.WorldLv2MotorShieldIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06009AEF RID: 39663 RVA: 0x00294C0E File Offset: 0x00292E0E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetWorldLv2AttackFrozenDict(int key)
		{
			this.EnsureWorldLv2AttackCacheIfNeeded();
			return this.WorldLv2AttackCache;
		}

		// Token: 0x06009AF0 RID: 39664 RVA: 0x00294C1C File Offset: 0x00292E1C
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetWorldLv2MotorShieldFrozenDict(int key)
		{
			this.EnsureWorldLv2MotorShieldCacheIfNeeded();
			return this.WorldLv2MotorShieldCache;
		}

		// Token: 0x04004F06 RID: 20230
		private Table __p;

		// Token: 0x04004F07 RID: 20231
		[Nullable(2)]
		private FrozenDictionary<int, int> WorldLv2AttackCache;

		// Token: 0x04004F08 RID: 20232
		[Nullable(2)]
		private FrozenDictionary<int, int> WorldLv2MotorShieldCache;
	}
}
