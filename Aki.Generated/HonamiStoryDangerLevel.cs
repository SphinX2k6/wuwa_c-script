using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E18 RID: 3608
	public struct HonamiStoryDangerLevel : IFlatbufferObject
	{
		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x06008565 RID: 34149 RVA: 0x00274844 File Offset: 0x00272A44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008566 RID: 34150 RVA: 0x00274851 File Offset: 0x00272A51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008567 RID: 34151 RVA: 0x00274858 File Offset: 0x00272A58
		public static HonamiStoryDangerLevel GetRootAsHonamiStoryDangerLevel(ByteBuffer _bb)
		{
			return HonamiStoryDangerLevel.GetRootAsHonamiStoryDangerLevel(_bb, default(HonamiStoryDangerLevel));
		}

		// Token: 0x06008568 RID: 34152 RVA: 0x00274874 File Offset: 0x00272A74
		public static HonamiStoryDangerLevel GetRootAsHonamiStoryDangerLevel(ByteBuffer _bb, HonamiStoryDangerLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008569 RID: 34153 RVA: 0x00274891 File Offset: 0x00272A91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600856A RID: 34154 RVA: 0x002748A0 File Offset: 0x00272AA0
		public HonamiStoryDangerLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x0600856B RID: 34155 RVA: 0x002748B0 File Offset: 0x00272AB0
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

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x0600856C RID: 34156 RVA: 0x002748EC File Offset: 0x00272AEC
		public int ActivityId
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

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x0600856D RID: 34157 RVA: 0x00274928 File Offset: 0x00272B28
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

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x0600856E RID: 34158 RVA: 0x00274964 File Offset: 0x00272B64
		public int MonsterEnhanceLevel
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

		// Token: 0x0600856F RID: 34159 RVA: 0x002749A4 File Offset: 0x00272BA4
		public DicIntInt? ConsumeItems(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x06008570 RID: 34160 RVA: 0x00274A08 File Offset: 0x00272C08
		public int ConsumeItemsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x06008571 RID: 34161 RVA: 0x00274A34 File Offset: 0x00272C34
		public int SafeLeavePrice
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

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x06008572 RID: 34162 RVA: 0x00274A74 File Offset: 0x00272C74
		public int AddDropLevel
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

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x06008573 RID: 34163 RVA: 0x00274AB4 File Offset: 0x00272CB4
		public int DangerLv
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

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x06008574 RID: 34164 RVA: 0x00274AF4 File Offset: 0x00272CF4
		public int PollutionGroup
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x06008575 RID: 34165 RVA: 0x00274B34 File Offset: 0x00272D34
		public string LvShow
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008576 RID: 34166 RVA: 0x00274B6C File Offset: 0x00272D6C
		public Span<byte> GetLvShowBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008577 RID: 34167 RVA: 0x00274B7C File Offset: 0x00272D7C
		public byte[] GetLvShowArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x06008578 RID: 34168 RVA: 0x00274B94 File Offset: 0x00272D94
		public string FallQuaId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008579 RID: 34169 RVA: 0x00274BCC File Offset: 0x00272DCC
		public Span<byte> GetFallQuaIdBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600857A RID: 34170 RVA: 0x00274BDC File Offset: 0x00272DDC
		public byte[] GetFallQuaIdArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x0600857B RID: 34171 RVA: 0x00274BF4 File Offset: 0x00272DF4
		public int HightQuality
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x0600857C RID: 34172 RVA: 0x00274C34 File Offset: 0x00272E34
		public int BoZaiTalk
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

		// Token: 0x0600857D RID: 34173 RVA: 0x00274C74 File Offset: 0x00272E74
		[NullableContext(1)]
		public Dictionary<int, int> ConsumeItems()
		{
			return this.ConsumeItemsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600857E RID: 34174 RVA: 0x00274CCA File Offset: 0x00272ECA
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ConsumeItemsIter()
		{
			HonamiStoryDangerLevel.<ConsumeItemsIter>d__40 <ConsumeItemsIter>d__ = new HonamiStoryDangerLevel.<ConsumeItemsIter>d__40(-2);
			<ConsumeItemsIter>d__.<>3__<>4__this = this;
			return <ConsumeItemsIter>d__;
		}

		// Token: 0x0600857F RID: 34175 RVA: 0x00274CE0 File Offset: 0x00272EE0
		public int? GetConsumeItems(int key)
		{
			this.EnsureConsumeItemsCacheIfNeeded();
			int value;
			if (!this.ConsumeItemsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06008580 RID: 34176 RVA: 0x00274D14 File Offset: 0x00272F14
		private void EnsureConsumeItemsCacheIfNeeded()
		{
			if (this.ConsumeItemsCache != null)
			{
				return;
			}
			this.ConsumeItemsCache = this.ConsumeItemsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008581 RID: 34177 RVA: 0x00274D7A File Offset: 0x00272F7A
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetConsumeItemsFrozenDict()
		{
			this.EnsureConsumeItemsCacheIfNeeded();
			return this.ConsumeItemsCache;
		}

		// Token: 0x04005391 RID: 21393
		private Table __p;

		// Token: 0x04005392 RID: 21394
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeItemsCache;
	}
}
