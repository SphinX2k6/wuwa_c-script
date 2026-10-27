using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ABA RID: 2746
	public struct AbyssSynthesis : IFlatbufferObject
	{
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06004219 RID: 16921 RVA: 0x001C9210 File Offset: 0x001C7410
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x001C921D File Offset: 0x001C741D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x001C9224 File Offset: 0x001C7424
		public static AbyssSynthesis GetRootAsAbyssSynthesis(ByteBuffer _bb)
		{
			return AbyssSynthesis.GetRootAsAbyssSynthesis(_bb, default(AbyssSynthesis));
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x001C9240 File Offset: 0x001C7440
		public static AbyssSynthesis GetRootAsAbyssSynthesis(ByteBuffer _bb, AbyssSynthesis obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x001C925D File Offset: 0x001C745D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600421E RID: 16926 RVA: 0x001C926C File Offset: 0x001C746C
		public AbyssSynthesis __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600421F RID: 16927 RVA: 0x001C927C File Offset: 0x001C747C
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

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06004220 RID: 16928 RVA: 0x001C92B8 File Offset: 0x001C74B8
		public int Quality
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

		// Token: 0x06004221 RID: 16929 RVA: 0x001C92F4 File Offset: 0x001C74F4
		public DicIntInt? DecomposeInfo(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06004222 RID: 16930 RVA: 0x001C9354 File Offset: 0x001C7554
		public int DecomposeInfoLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x001C9380 File Offset: 0x001C7580
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DecomposeInfoFrozenDict()缓存字典，遍历请使用DecomposeInfoIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> DecomposeInfo()
		{
			return this.DecomposeInfoIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004224 RID: 16932 RVA: 0x001C93D6 File Offset: 0x001C75D6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> DecomposeInfoIter()
		{
			AbyssSynthesis.<DecomposeInfoIter>d__16 <DecomposeInfoIter>d__ = new AbyssSynthesis.<DecomposeInfoIter>d__16(-2);
			<DecomposeInfoIter>d__.<>3__<>4__this = this;
			return <DecomposeInfoIter>d__;
		}

		// Token: 0x06004225 RID: 16933 RVA: 0x001C93EC File Offset: 0x001C75EC
		public int? GetDecomposeInfo(int key)
		{
			this.EnsureDecomposeInfoCacheIfNeeded();
			int value;
			if (!this.DecomposeInfoCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06004226 RID: 16934 RVA: 0x001C9420 File Offset: 0x001C7620
		private void EnsureDecomposeInfoCacheIfNeeded()
		{
			if (this.DecomposeInfoCache != null)
			{
				return;
			}
			this.DecomposeInfoCache = this.DecomposeInfoIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004227 RID: 16935 RVA: 0x001C9486 File Offset: 0x001C7686
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetDecomposeInfoFrozenDict(int key)
		{
			this.EnsureDecomposeInfoCacheIfNeeded();
			return this.DecomposeInfoCache;
		}

		// Token: 0x04004A92 RID: 19090
		private Table __p;

		// Token: 0x04004A93 RID: 19091
		[Nullable(2)]
		private FrozenDictionary<int, int> DecomposeInfoCache;
	}
}
