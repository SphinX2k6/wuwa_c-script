using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F41 RID: 3905
	public struct MotorLvl : IFlatbufferObject
	{
		// Token: 0x17002215 RID: 8725
		// (get) Token: 0x0600A0F0 RID: 41200 RVA: 0x002B1F02 File Offset: 0x002B0102
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A0F1 RID: 41201 RVA: 0x002B1F0F File Offset: 0x002B010F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A0F2 RID: 41202 RVA: 0x002B1F18 File Offset: 0x002B0118
		public static MotorLvl GetRootAsMotorLvl(ByteBuffer _bb)
		{
			return MotorLvl.GetRootAsMotorLvl(_bb, default(MotorLvl));
		}

		// Token: 0x0600A0F3 RID: 41203 RVA: 0x002B1F34 File Offset: 0x002B0134
		public static MotorLvl GetRootAsMotorLvl(ByteBuffer _bb, MotorLvl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A0F4 RID: 41204 RVA: 0x002B1F51 File Offset: 0x002B0151
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A0F5 RID: 41205 RVA: 0x002B1F60 File Offset: 0x002B0160
		public MotorLvl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002216 RID: 8726
		// (get) Token: 0x0600A0F6 RID: 41206 RVA: 0x002B1F70 File Offset: 0x002B0170
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

		// Token: 0x17002217 RID: 8727
		// (get) Token: 0x0600A0F7 RID: 41207 RVA: 0x002B1FAC File Offset: 0x002B01AC
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

		// Token: 0x17002218 RID: 8728
		// (get) Token: 0x0600A0F8 RID: 41208 RVA: 0x002B1FE8 File Offset: 0x002B01E8
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

		// Token: 0x0600A0F9 RID: 41209 RVA: 0x002B2024 File Offset: 0x002B0224
		public DicIntInt? WorldLv2Attack(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002219 RID: 8729
		// (get) Token: 0x0600A0FA RID: 41210 RVA: 0x002B2088 File Offset: 0x002B0288
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

		// Token: 0x1700221A RID: 8730
		// (get) Token: 0x0600A0FB RID: 41211 RVA: 0x002B20B4 File Offset: 0x002B02B4
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

		// Token: 0x1700221B RID: 8731
		// (get) Token: 0x0600A0FC RID: 41212 RVA: 0x002B20F4 File Offset: 0x002B02F4
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

		// Token: 0x1700221C RID: 8732
		// (get) Token: 0x0600A0FD RID: 41213 RVA: 0x002B2134 File Offset: 0x002B0334
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

		// Token: 0x1700221D RID: 8733
		// (get) Token: 0x0600A0FE RID: 41214 RVA: 0x002B2174 File Offset: 0x002B0374
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

		// Token: 0x1700221E RID: 8734
		// (get) Token: 0x0600A0FF RID: 41215 RVA: 0x002B21B4 File Offset: 0x002B03B4
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

		// Token: 0x1700221F RID: 8735
		// (get) Token: 0x0600A100 RID: 41216 RVA: 0x002B21F8 File Offset: 0x002B03F8
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

		// Token: 0x17002220 RID: 8736
		// (get) Token: 0x0600A101 RID: 41217 RVA: 0x002B2238 File Offset: 0x002B0438
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

		// Token: 0x0600A102 RID: 41218 RVA: 0x002B2278 File Offset: 0x002B0478
		public DicIntInt? WorldLv2MotorShield(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002221 RID: 8737
		// (get) Token: 0x0600A103 RID: 41219 RVA: 0x002B22DC File Offset: 0x002B04DC
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

		// Token: 0x17002222 RID: 8738
		// (get) Token: 0x0600A104 RID: 41220 RVA: 0x002B2308 File Offset: 0x002B0508
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

		// Token: 0x17002223 RID: 8739
		// (get) Token: 0x0600A105 RID: 41221 RVA: 0x002B2348 File Offset: 0x002B0548
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

		// Token: 0x17002224 RID: 8740
		// (get) Token: 0x0600A106 RID: 41222 RVA: 0x002B238C File Offset: 0x002B058C
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

		// Token: 0x0600A107 RID: 41223 RVA: 0x002B23CC File Offset: 0x002B05CC
		[NullableContext(1)]
		public Dictionary<int, int> WorldLv2Attack()
		{
			return this.WorldLv2AttackIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600A108 RID: 41224 RVA: 0x002B2422 File Offset: 0x002B0622
		[NullableContext(1)]
		public IEnumerable<DicIntInt> WorldLv2AttackIter()
		{
			MotorLvl.<WorldLv2AttackIter>d__41 <WorldLv2AttackIter>d__ = new MotorLvl.<WorldLv2AttackIter>d__41(-2);
			<WorldLv2AttackIter>d__.<>3__<>4__this = this;
			return <WorldLv2AttackIter>d__;
		}

		// Token: 0x0600A109 RID: 41225 RVA: 0x002B2438 File Offset: 0x002B0638
		[NullableContext(1)]
		public Dictionary<int, int> WorldLv2MotorShield()
		{
			return this.WorldLv2MotorShieldIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600A10A RID: 41226 RVA: 0x002B248E File Offset: 0x002B068E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> WorldLv2MotorShieldIter()
		{
			MotorLvl.<WorldLv2MotorShieldIter>d__43 <WorldLv2MotorShieldIter>d__ = new MotorLvl.<WorldLv2MotorShieldIter>d__43(-2);
			<WorldLv2MotorShieldIter>d__.<>3__<>4__this = this;
			return <WorldLv2MotorShieldIter>d__;
		}

		// Token: 0x0600A10B RID: 41227 RVA: 0x002B24A4 File Offset: 0x002B06A4
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

		// Token: 0x0600A10C RID: 41228 RVA: 0x002B24D8 File Offset: 0x002B06D8
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

		// Token: 0x0600A10D RID: 41229 RVA: 0x002B250C File Offset: 0x002B070C
		private void EnsureWorldLv2AttackCacheIfNeeded()
		{
			if (this.WorldLv2AttackCache != null)
			{
				return;
			}
			this.WorldLv2AttackCache = this.WorldLv2AttackIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600A10E RID: 41230 RVA: 0x002B2574 File Offset: 0x002B0774
		private void EnsureWorldLv2MotorShieldCacheIfNeeded()
		{
			if (this.WorldLv2MotorShieldCache != null)
			{
				return;
			}
			this.WorldLv2MotorShieldCache = this.WorldLv2MotorShieldIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600A10F RID: 41231 RVA: 0x002B25DA File Offset: 0x002B07DA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetWorldLv2AttackFrozenDict()
		{
			this.EnsureWorldLv2AttackCacheIfNeeded();
			return this.WorldLv2AttackCache;
		}

		// Token: 0x0600A110 RID: 41232 RVA: 0x002B25E8 File Offset: 0x002B07E8
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetWorldLv2MotorShieldFrozenDict()
		{
			this.EnsureWorldLv2MotorShieldCacheIfNeeded();
			return this.WorldLv2MotorShieldCache;
		}

		// Token: 0x040054EB RID: 21739
		private Table __p;

		// Token: 0x040054EC RID: 21740
		[Nullable(2)]
		private FrozenDictionary<int, int> WorldLv2AttackCache;

		// Token: 0x040054ED RID: 21741
		[Nullable(2)]
		private FrozenDictionary<int, int> WorldLv2MotorShieldCache;
	}
}
