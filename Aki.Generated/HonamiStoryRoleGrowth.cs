using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D4D RID: 3405
	public struct HonamiStoryRoleGrowth : IFlatbufferObject
	{
		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x06008127 RID: 33063 RVA: 0x0025A05D File Offset: 0x0025825D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008128 RID: 33064 RVA: 0x0025A06A File Offset: 0x0025826A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008129 RID: 33065 RVA: 0x0025A074 File Offset: 0x00258274
		public static HonamiStoryRoleGrowth GetRootAsHonamiStoryRoleGrowth(ByteBuffer _bb)
		{
			return HonamiStoryRoleGrowth.GetRootAsHonamiStoryRoleGrowth(_bb, default(HonamiStoryRoleGrowth));
		}

		// Token: 0x0600812A RID: 33066 RVA: 0x0025A090 File Offset: 0x00258290
		public static HonamiStoryRoleGrowth GetRootAsHonamiStoryRoleGrowth(ByteBuffer _bb, HonamiStoryRoleGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600812B RID: 33067 RVA: 0x0025A0AD File Offset: 0x002582AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600812C RID: 33068 RVA: 0x0025A0BC File Offset: 0x002582BC
		public HonamiStoryRoleGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x0600812D RID: 33069 RVA: 0x0025A0CC File Offset: 0x002582CC
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

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x0600812E RID: 33070 RVA: 0x0025A108 File Offset: 0x00258308
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

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x0600812F RID: 33071 RVA: 0x0025A144 File Offset: 0x00258344
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

		// Token: 0x06008130 RID: 33072 RVA: 0x0025A180 File Offset: 0x00258380
		public DicIntInt? AddPro(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x06008131 RID: 33073 RVA: 0x0025A1E4 File Offset: 0x002583E4
		public int AddProLength
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

		// Token: 0x06008132 RID: 33074 RVA: 0x0025A210 File Offset: 0x00258410
		[NullableContext(1)]
		[Obsolete("已废弃，请使用AddProFrozenDict()缓存字典，遍历请使用AddProIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> AddPro()
		{
			return this.AddProIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008133 RID: 33075 RVA: 0x0025A266 File Offset: 0x00258466
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> AddProIter()
		{
			HonamiStoryRoleGrowth.<AddProIter>d__18 <AddProIter>d__ = new HonamiStoryRoleGrowth.<AddProIter>d__18(-2);
			<AddProIter>d__.<>3__<>4__this = this;
			return <AddProIter>d__;
		}

		// Token: 0x06008134 RID: 33076 RVA: 0x0025A27C File Offset: 0x0025847C
		public int? GetAddPro(int key)
		{
			this.EnsureAddProCacheIfNeeded();
			int value;
			if (!this.AddProCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06008135 RID: 33077 RVA: 0x0025A2B0 File Offset: 0x002584B0
		private void EnsureAddProCacheIfNeeded()
		{
			if (this.AddProCache != null)
			{
				return;
			}
			this.AddProCache = this.AddProIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008136 RID: 33078 RVA: 0x0025A316 File Offset: 0x00258516
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetAddProFrozenDict(int key)
		{
			this.EnsureAddProCacheIfNeeded();
			return this.AddProCache;
		}

		// Token: 0x04004DC9 RID: 19913
		private Table __p;

		// Token: 0x04004DCA RID: 19914
		[Nullable(2)]
		private FrozenDictionary<int, int> AddProCache;
	}
}
