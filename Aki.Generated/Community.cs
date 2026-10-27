using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B92 RID: 2962
	public struct Community : IFlatbufferObject
	{
		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x060057C3 RID: 22467 RVA: 0x001FB690 File Offset: 0x001F9890
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060057C4 RID: 22468 RVA: 0x001FB69D File Offset: 0x001F989D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060057C5 RID: 22469 RVA: 0x001FB6A4 File Offset: 0x001F98A4
		public static Community GetRootAsCommunity(ByteBuffer _bb)
		{
			return Community.GetRootAsCommunity(_bb, default(Community));
		}

		// Token: 0x060057C6 RID: 22470 RVA: 0x001FB6C0 File Offset: 0x001F98C0
		public static Community GetRootAsCommunity(ByteBuffer _bb, Community obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060057C7 RID: 22471 RVA: 0x001FB6DD File Offset: 0x001F98DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060057C8 RID: 22472 RVA: 0x001FB6EC File Offset: 0x001F98EC
		public Community __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x060057C9 RID: 22473 RVA: 0x001FB6FC File Offset: 0x001F98FC
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

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x060057CA RID: 22474 RVA: 0x001FB738 File Offset: 0x001F9938
		public int PackageType
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

		// Token: 0x060057CB RID: 22475 RVA: 0x001FB774 File Offset: 0x001F9974
		public string Language(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x060057CC RID: 22476 RVA: 0x001FB7B0 File Offset: 0x001F99B0
		public int LanguageLength
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

		// Token: 0x060057CD RID: 22477 RVA: 0x001FB7DC File Offset: 0x001F99DC
		public string PackageId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x060057CE RID: 22478 RVA: 0x001FB818 File Offset: 0x001F9A18
		public int PackageIdLength
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

		// Token: 0x060057CF RID: 22479 RVA: 0x001FB844 File Offset: 0x001F9A44
		public int Channel(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x060057D0 RID: 22480 RVA: 0x001FB884 File Offset: 0x001F9A84
		public int ChannelLength
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

		// Token: 0x060057D1 RID: 22481 RVA: 0x001FB8B0 File Offset: 0x001F9AB0
		public Span<int> GetChannelBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060057D2 RID: 22482 RVA: 0x001FB8C0 File Offset: 0x001F9AC0
		public int[] GetChannelArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x060057D3 RID: 22483 RVA: 0x001FB8D8 File Offset: 0x001F9AD8
		public string Adress
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060057D4 RID: 22484 RVA: 0x001FB910 File Offset: 0x001F9B10
		public Span<byte> GetAdressBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060057D5 RID: 22485 RVA: 0x001FB920 File Offset: 0x001F9B20
		public byte[] GetAdressArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x060057D6 RID: 22486 RVA: 0x001FB938 File Offset: 0x001F9B38
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ChannelIter()或GetChannelBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Channel()
		{
			Community community = this;
			return community.GetChannelArray() ?? Array.Empty<int>();
		}

		// Token: 0x060057D7 RID: 22487 RVA: 0x001FB95C File Offset: 0x001F9B5C
		[NullableContext(1)]
		public readonly IEnumerable<int> ChannelIter()
		{
			Community.<ChannelIter>d__28 <ChannelIter>d__ = new Community.<ChannelIter>d__28(-2);
			<ChannelIter>d__.<>3__<>4__this = this;
			return <ChannelIter>d__;
		}

		// Token: 0x060057D8 RID: 22488 RVA: 0x001FB971 File Offset: 0x001F9B71
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LanguageIter()或GetLanguageBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Language()
		{
			return this.LanguageIter().ToArray<string>();
		}

		// Token: 0x060057D9 RID: 22489 RVA: 0x001FB97E File Offset: 0x001F9B7E
		[NullableContext(1)]
		public readonly IEnumerable<string> LanguageIter()
		{
			Community.<LanguageIter>d__30 <LanguageIter>d__ = new Community.<LanguageIter>d__30(-2);
			<LanguageIter>d__.<>3__<>4__this = this;
			return <LanguageIter>d__;
		}

		// Token: 0x060057DA RID: 22490 RVA: 0x001FB993 File Offset: 0x001F9B93
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PackageIdIter()或GetPackageIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] PackageId()
		{
			return this.PackageIdIter().ToArray<string>();
		}

		// Token: 0x060057DB RID: 22491 RVA: 0x001FB9A0 File Offset: 0x001F9BA0
		[NullableContext(1)]
		public readonly IEnumerable<string> PackageIdIter()
		{
			Community.<PackageIdIter>d__32 <PackageIdIter>d__ = new Community.<PackageIdIter>d__32(-2);
			<PackageIdIter>d__.<>3__<>4__this = this;
			return <PackageIdIter>d__;
		}

		// Token: 0x04004BA1 RID: 19361
		private Table __p;
	}
}
