using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F88 RID: 3976
	public struct RacingBetsBulletPool : IFlatbufferObject
	{
		// Token: 0x17002C8D RID: 11405
		// (get) Token: 0x0600B7E8 RID: 47080 RVA: 0x002D4CEC File Offset: 0x002D2EEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B7E9 RID: 47081 RVA: 0x002D4CF9 File Offset: 0x002D2EF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B7EA RID: 47082 RVA: 0x002D4D00 File Offset: 0x002D2F00
		public static RacingBetsBulletPool GetRootAsRacingBetsBulletPool(ByteBuffer _bb)
		{
			return RacingBetsBulletPool.GetRootAsRacingBetsBulletPool(_bb, default(RacingBetsBulletPool));
		}

		// Token: 0x0600B7EB RID: 47083 RVA: 0x002D4D1C File Offset: 0x002D2F1C
		public static RacingBetsBulletPool GetRootAsRacingBetsBulletPool(ByteBuffer _bb, RacingBetsBulletPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B7EC RID: 47084 RVA: 0x002D4D39 File Offset: 0x002D2F39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B7ED RID: 47085 RVA: 0x002D4D48 File Offset: 0x002D2F48
		public RacingBetsBulletPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C8E RID: 11406
		// (get) Token: 0x0600B7EE RID: 47086 RVA: 0x002D4D58 File Offset: 0x002D2F58
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

		// Token: 0x17002C8F RID: 11407
		// (get) Token: 0x0600B7EF RID: 47087 RVA: 0x002D4D94 File Offset: 0x002D2F94
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

		// Token: 0x17002C90 RID: 11408
		// (get) Token: 0x0600B7F0 RID: 47088 RVA: 0x002D4DD0 File Offset: 0x002D2FD0
		public int Threshold
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

		// Token: 0x0600B7F1 RID: 47089 RVA: 0x002D4E0C File Offset: 0x002D300C
		public DicIntInt? BulletPool(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002C91 RID: 11409
		// (get) Token: 0x0600B7F2 RID: 47090 RVA: 0x002D4E70 File Offset: 0x002D3070
		public int BulletPoolLength
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

		// Token: 0x0600B7F3 RID: 47091 RVA: 0x002D4E9C File Offset: 0x002D309C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用BulletPoolFrozenDict()缓存字典，遍历请使用BulletPoolIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> BulletPool()
		{
			return this.BulletPoolIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600B7F4 RID: 47092 RVA: 0x002D4EF2 File Offset: 0x002D30F2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> BulletPoolIter()
		{
			RacingBetsBulletPool.<BulletPoolIter>d__18 <BulletPoolIter>d__ = new RacingBetsBulletPool.<BulletPoolIter>d__18(-2);
			<BulletPoolIter>d__.<>3__<>4__this = this;
			return <BulletPoolIter>d__;
		}

		// Token: 0x0600B7F5 RID: 47093 RVA: 0x002D4F08 File Offset: 0x002D3108
		public int? GetBulletPool(int key)
		{
			this.EnsureBulletPoolCacheIfNeeded();
			int value;
			if (!this.BulletPoolCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600B7F6 RID: 47094 RVA: 0x002D4F3C File Offset: 0x002D313C
		private void EnsureBulletPoolCacheIfNeeded()
		{
			if (this.BulletPoolCache != null)
			{
				return;
			}
			this.BulletPoolCache = this.BulletPoolIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600B7F7 RID: 47095 RVA: 0x002D4FA2 File Offset: 0x002D31A2
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetBulletPoolFrozenDict(int key)
		{
			this.EnsureBulletPoolCacheIfNeeded();
			return this.BulletPoolCache;
		}

		// Token: 0x04005056 RID: 20566
		private Table __p;

		// Token: 0x04005057 RID: 20567
		[Nullable(2)]
		private FrozenDictionary<int, int> BulletPoolCache;
	}
}
