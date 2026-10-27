using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AB9 RID: 2745
	public struct AbyssSettle : IFlatbufferObject
	{
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06004204 RID: 16900 RVA: 0x001C8ED0 File Offset: 0x001C70D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004205 RID: 16901 RVA: 0x001C8EDD File Offset: 0x001C70DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004206 RID: 16902 RVA: 0x001C8EE4 File Offset: 0x001C70E4
		public static AbyssSettle GetRootAsAbyssSettle(ByteBuffer _bb)
		{
			return AbyssSettle.GetRootAsAbyssSettle(_bb, default(AbyssSettle));
		}

		// Token: 0x06004207 RID: 16903 RVA: 0x001C8F00 File Offset: 0x001C7100
		public static AbyssSettle GetRootAsAbyssSettle(ByteBuffer _bb, AbyssSettle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004208 RID: 16904 RVA: 0x001C8F1D File Offset: 0x001C711D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004209 RID: 16905 RVA: 0x001C8F2C File Offset: 0x001C712C
		public AbyssSettle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600420A RID: 16906 RVA: 0x001C8F3C File Offset: 0x001C713C
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

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600420B RID: 16907 RVA: 0x001C8F78 File Offset: 0x001C7178
		public string BattleScoreName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600420C RID: 16908 RVA: 0x001C8FAF File Offset: 0x001C71AF
		public Span<byte> GetBattleScoreNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600420D RID: 16909 RVA: 0x001C8FBE File Offset: 0x001C71BE
		public byte[] GetBattleScoreNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600420E RID: 16910 RVA: 0x001C8FD8 File Offset: 0x001C71D8
		public bool IsTotalRatio
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600420F RID: 16911 RVA: 0x001C9018 File Offset: 0x001C7218
		public string BaseTitle
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004210 RID: 16912 RVA: 0x001C9050 File Offset: 0x001C7250
		public Span<byte> GetBaseTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004211 RID: 16913 RVA: 0x001C9060 File Offset: 0x001C7260
		public byte[] GetBaseTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06004212 RID: 16914 RVA: 0x001C9078 File Offset: 0x001C7278
		public DicIntString? Title(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06004213 RID: 16915 RVA: 0x001C90DC File Offset: 0x001C72DC
		public int TitleLength
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

		// Token: 0x06004214 RID: 16916 RVA: 0x001C9108 File Offset: 0x001C7308
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TitleFrozenDict()缓存字典，遍历请使用TitleIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> Title()
		{
			return this.TitleIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06004215 RID: 16917 RVA: 0x001C915E File Offset: 0x001C735E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> TitleIter()
		{
			AbyssSettle.<TitleIter>d__24 <TitleIter>d__ = new AbyssSettle.<TitleIter>d__24(-2);
			<TitleIter>d__.<>3__<>4__this = this;
			return <TitleIter>d__;
		}

		// Token: 0x06004216 RID: 16918 RVA: 0x001C9174 File Offset: 0x001C7374
		[NullableContext(2)]
		public string GetTitle(int key)
		{
			this.EnsureTitleCacheIfNeeded();
			string result;
			if (!this.TitleCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06004217 RID: 16919 RVA: 0x001C919C File Offset: 0x001C739C
		private void EnsureTitleCacheIfNeeded()
		{
			if (this.TitleCache != null)
			{
				return;
			}
			this.TitleCache = this.TitleIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x06004218 RID: 16920 RVA: 0x001C9202 File Offset: 0x001C7402
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetTitleFrozenDict(int key)
		{
			this.EnsureTitleCacheIfNeeded();
			return this.TitleCache;
		}

		// Token: 0x04004A90 RID: 19088
		private Table __p;

		// Token: 0x04004A91 RID: 19089
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> TitleCache;
	}
}
