using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012C7 RID: 4807
	public struct WeaponBreach : IFlatbufferObject
	{
		// Token: 0x17004113 RID: 16659
		// (get) Token: 0x0600F4CA RID: 62666 RVA: 0x0036C14D File Offset: 0x0036A34D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F4CB RID: 62667 RVA: 0x0036C15A File Offset: 0x0036A35A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F4CC RID: 62668 RVA: 0x0036C164 File Offset: 0x0036A364
		public static WeaponBreach GetRootAsWeaponBreach(ByteBuffer _bb)
		{
			return WeaponBreach.GetRootAsWeaponBreach(_bb, default(WeaponBreach));
		}

		// Token: 0x0600F4CD RID: 62669 RVA: 0x0036C180 File Offset: 0x0036A380
		public static WeaponBreach GetRootAsWeaponBreach(ByteBuffer _bb, WeaponBreach obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F4CE RID: 62670 RVA: 0x0036C19D File Offset: 0x0036A39D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F4CF RID: 62671 RVA: 0x0036C1AC File Offset: 0x0036A3AC
		public WeaponBreach __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004114 RID: 16660
		// (get) Token: 0x0600F4D0 RID: 62672 RVA: 0x0036C1BC File Offset: 0x0036A3BC
		public int Id
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

		// Token: 0x17004115 RID: 16661
		// (get) Token: 0x0600F4D1 RID: 62673 RVA: 0x0036C1F8 File Offset: 0x0036A3F8
		public int BreachId
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

		// Token: 0x17004116 RID: 16662
		// (get) Token: 0x0600F4D2 RID: 62674 RVA: 0x0036C234 File Offset: 0x0036A434
		public int Level
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

		// Token: 0x17004117 RID: 16663
		// (get) Token: 0x0600F4D3 RID: 62675 RVA: 0x0036C270 File Offset: 0x0036A470
		public int ConditionId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17004118 RID: 16664
		// (get) Token: 0x0600F4D4 RID: 62676 RVA: 0x0036C2B0 File Offset: 0x0036A4B0
		public int LevelLimit
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

		// Token: 0x0600F4D5 RID: 62677 RVA: 0x0036C2F0 File Offset: 0x0036A4F0
		public DicIntInt? Consume(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17004119 RID: 16665
		// (get) Token: 0x0600F4D6 RID: 62678 RVA: 0x0036C354 File Offset: 0x0036A554
		public int ConsumeLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700411A RID: 16666
		// (get) Token: 0x0600F4D7 RID: 62679 RVA: 0x0036C380 File Offset: 0x0036A580
		public int GoldConsume
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

		// Token: 0x0600F4D8 RID: 62680 RVA: 0x0036C3C0 File Offset: 0x0036A5C0
		[NullableContext(1)]
		public Dictionary<int, int> Consume()
		{
			return this.ConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600F4D9 RID: 62681 RVA: 0x0036C416 File Offset: 0x0036A616
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ConsumeIter()
		{
			WeaponBreach.<ConsumeIter>d__24 <ConsumeIter>d__ = new WeaponBreach.<ConsumeIter>d__24(-2);
			<ConsumeIter>d__.<>3__<>4__this = this;
			return <ConsumeIter>d__;
		}

		// Token: 0x0600F4DA RID: 62682 RVA: 0x0036C42C File Offset: 0x0036A62C
		public int? GetConsume(int key)
		{
			this.EnsureConsumeCacheIfNeeded();
			int value;
			if (!this.ConsumeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600F4DB RID: 62683 RVA: 0x0036C460 File Offset: 0x0036A660
		private void EnsureConsumeCacheIfNeeded()
		{
			if (this.ConsumeCache != null)
			{
				return;
			}
			this.ConsumeCache = this.ConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600F4DC RID: 62684 RVA: 0x0036C4C6 File Offset: 0x0036A6C6
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetConsumeFrozenDict()
		{
			this.EnsureConsumeCacheIfNeeded();
			return this.ConsumeCache;
		}

		// Token: 0x0400591E RID: 22814
		private Table __p;

		// Token: 0x0400591F RID: 22815
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeCache;
	}
}
