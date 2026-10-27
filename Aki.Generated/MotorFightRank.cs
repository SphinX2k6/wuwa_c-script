using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E4C RID: 3660
	public struct MotorFightRank : IFlatbufferObject
	{
		// Token: 0x1700210A RID: 8458
		// (get) Token: 0x06009913 RID: 39187 RVA: 0x00290658 File Offset: 0x0028E858
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009914 RID: 39188 RVA: 0x00290665 File Offset: 0x0028E865
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009915 RID: 39189 RVA: 0x0029066C File Offset: 0x0028E86C
		public static MotorFightRank GetRootAsMotorFightRank(ByteBuffer _bb)
		{
			return MotorFightRank.GetRootAsMotorFightRank(_bb, default(MotorFightRank));
		}

		// Token: 0x06009916 RID: 39190 RVA: 0x00290688 File Offset: 0x0028E888
		public static MotorFightRank GetRootAsMotorFightRank(ByteBuffer _bb, MotorFightRank obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009917 RID: 39191 RVA: 0x002906A5 File Offset: 0x0028E8A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009918 RID: 39192 RVA: 0x002906B4 File Offset: 0x0028E8B4
		public MotorFightRank __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700210B RID: 8459
		// (get) Token: 0x06009919 RID: 39193 RVA: 0x002906C4 File Offset: 0x0028E8C4
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

		// Token: 0x1700210C RID: 8460
		// (get) Token: 0x0600991A RID: 39194 RVA: 0x00290700 File Offset: 0x0028E900
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

		// Token: 0x1700210D RID: 8461
		// (get) Token: 0x0600991B RID: 39195 RVA: 0x0029073C File Offset: 0x0028E93C
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

		// Token: 0x1700210E RID: 8462
		// (get) Token: 0x0600991C RID: 39196 RVA: 0x00290778 File Offset: 0x0028E978
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

		// Token: 0x1700210F RID: 8463
		// (get) Token: 0x0600991D RID: 39197 RVA: 0x002907B8 File Offset: 0x0028E9B8
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

		// Token: 0x17002110 RID: 8464
		// (get) Token: 0x0600991E RID: 39198 RVA: 0x002907F8 File Offset: 0x0028E9F8
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

		// Token: 0x17002111 RID: 8465
		// (get) Token: 0x0600991F RID: 39199 RVA: 0x00290838 File Offset: 0x0028EA38
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

		// Token: 0x06009920 RID: 39200 RVA: 0x00290878 File Offset: 0x0028EA78
		public DicIntInt? CollectionItem(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002112 RID: 8466
		// (get) Token: 0x06009921 RID: 39201 RVA: 0x002908DC File Offset: 0x0028EADC
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

		// Token: 0x06009922 RID: 39202 RVA: 0x00290908 File Offset: 0x0028EB08
		[NullableContext(1)]
		[Obsolete("已废弃，请使用CollectionItemFrozenDict()缓存字典，遍历请使用CollectionItemIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> CollectionItem()
		{
			return this.CollectionItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06009923 RID: 39203 RVA: 0x0029095E File Offset: 0x0028EB5E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> CollectionItemIter()
		{
			MotorFightRank.<CollectionItemIter>d__26 <CollectionItemIter>d__ = new MotorFightRank.<CollectionItemIter>d__26(-2);
			<CollectionItemIter>d__.<>3__<>4__this = this;
			return <CollectionItemIter>d__;
		}

		// Token: 0x06009924 RID: 39204 RVA: 0x00290974 File Offset: 0x0028EB74
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

		// Token: 0x06009925 RID: 39205 RVA: 0x002909A8 File Offset: 0x0028EBA8
		private void EnsureCollectionItemCacheIfNeeded()
		{
			if (this.CollectionItemCache != null)
			{
				return;
			}
			this.CollectionItemCache = this.CollectionItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06009926 RID: 39206 RVA: 0x00290A0E File Offset: 0x0028EC0E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetCollectionItemFrozenDict(int key)
		{
			this.EnsureCollectionItemCacheIfNeeded();
			return this.CollectionItemCache;
		}

		// Token: 0x04004EF4 RID: 20212
		private Table __p;

		// Token: 0x04004EF5 RID: 20213
		[Nullable(2)]
		private FrozenDictionary<int, int> CollectionItemCache;
	}
}
