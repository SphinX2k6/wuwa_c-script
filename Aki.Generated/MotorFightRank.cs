using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F31 RID: 3889
	public struct MotorFightRank : IFlatbufferObject
	{
		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x06009F33 RID: 40755 RVA: 0x002AE1E8 File Offset: 0x002AC3E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009F34 RID: 40756 RVA: 0x002AE1F5 File Offset: 0x002AC3F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009F35 RID: 40757 RVA: 0x002AE1FC File Offset: 0x002AC3FC
		public static MotorFightRank GetRootAsMotorFightRank(ByteBuffer _bb)
		{
			return MotorFightRank.GetRootAsMotorFightRank(_bb, default(MotorFightRank));
		}

		// Token: 0x06009F36 RID: 40758 RVA: 0x002AE218 File Offset: 0x002AC418
		public static MotorFightRank GetRootAsMotorFightRank(ByteBuffer _bb, MotorFightRank obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009F37 RID: 40759 RVA: 0x002AE235 File Offset: 0x002AC435
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009F38 RID: 40760 RVA: 0x002AE244 File Offset: 0x002AC444
		public MotorFightRank __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002170 RID: 8560
		// (get) Token: 0x06009F39 RID: 40761 RVA: 0x002AE254 File Offset: 0x002AC454
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

		// Token: 0x17002171 RID: 8561
		// (get) Token: 0x06009F3A RID: 40762 RVA: 0x002AE290 File Offset: 0x002AC490
		public int RoleId
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

		// Token: 0x17002172 RID: 8562
		// (get) Token: 0x06009F3B RID: 40763 RVA: 0x002AE2CC File Offset: 0x002AC4CC
		public int DisplayThreshold
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

		// Token: 0x17002173 RID: 8563
		// (get) Token: 0x06009F3C RID: 40764 RVA: 0x002AE308 File Offset: 0x002AC508
		public int Score
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

		// Token: 0x17002174 RID: 8564
		// (get) Token: 0x06009F3D RID: 40765 RVA: 0x002AE348 File Offset: 0x002AC548
		public int WaveNum
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

		// Token: 0x17002175 RID: 8565
		// (get) Token: 0x06009F3E RID: 40766 RVA: 0x002AE388 File Offset: 0x002AC588
		public int KillNum
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

		// Token: 0x17002176 RID: 8566
		// (get) Token: 0x06009F3F RID: 40767 RVA: 0x002AE3C8 File Offset: 0x002AC5C8
		public int BuffGateNum
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

		// Token: 0x06009F40 RID: 40768 RVA: 0x002AE408 File Offset: 0x002AC608
		public DicIntInt? CollectionItem(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002177 RID: 8567
		// (get) Token: 0x06009F41 RID: 40769 RVA: 0x002AE46C File Offset: 0x002AC66C
		public int CollectionItemLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009F42 RID: 40770 RVA: 0x002AE498 File Offset: 0x002AC698
		[NullableContext(1)]
		public Dictionary<int, int> CollectionItem()
		{
			return this.CollectionItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06009F43 RID: 40771 RVA: 0x002AE4EE File Offset: 0x002AC6EE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> CollectionItemIter()
		{
			MotorFightRank.<CollectionItemIter>d__26 <CollectionItemIter>d__ = new MotorFightRank.<CollectionItemIter>d__26(-2);
			<CollectionItemIter>d__.<>3__<>4__this = this;
			return <CollectionItemIter>d__;
		}

		// Token: 0x06009F44 RID: 40772 RVA: 0x002AE504 File Offset: 0x002AC704
		public int? GetCollectionItem(int key)
		{
			this.EnsureCollectionItemCacheIfNeeded();
			int value;
			if (!this.CollectionItemCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06009F45 RID: 40773 RVA: 0x002AE538 File Offset: 0x002AC738
		private void EnsureCollectionItemCacheIfNeeded()
		{
			if (this.CollectionItemCache != null)
			{
				return;
			}
			this.CollectionItemCache = this.CollectionItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06009F46 RID: 40774 RVA: 0x002AE59E File Offset: 0x002AC79E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetCollectionItemFrozenDict()
		{
			this.EnsureCollectionItemCacheIfNeeded();
			return this.CollectionItemCache;
		}

		// Token: 0x040054D9 RID: 21721
		private Table __p;

		// Token: 0x040054DA RID: 21722
		[Nullable(2)]
		private FrozenDictionary<int, int> CollectionItemCache;
	}
}
