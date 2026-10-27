using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200109A RID: 4250
	public struct SharePlatform : IFlatbufferObject
	{
		// Token: 0x1700353C RID: 13628
		// (get) Token: 0x0600D06D RID: 53357 RVA: 0x0030BBB8 File Offset: 0x00309DB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D06E RID: 53358 RVA: 0x0030BBC5 File Offset: 0x00309DC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D06F RID: 53359 RVA: 0x0030BBCC File Offset: 0x00309DCC
		public static SharePlatform GetRootAsSharePlatform(ByteBuffer _bb)
		{
			return SharePlatform.GetRootAsSharePlatform(_bb, default(SharePlatform));
		}

		// Token: 0x0600D070 RID: 53360 RVA: 0x0030BBE8 File Offset: 0x00309DE8
		public static SharePlatform GetRootAsSharePlatform(ByteBuffer _bb, SharePlatform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D071 RID: 53361 RVA: 0x0030BC05 File Offset: 0x00309E05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D072 RID: 53362 RVA: 0x0030BC14 File Offset: 0x00309E14
		public SharePlatform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700353D RID: 13629
		// (get) Token: 0x0600D073 RID: 53363 RVA: 0x0030BC24 File Offset: 0x00309E24
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

		// Token: 0x1700353E RID: 13630
		// (get) Token: 0x0600D074 RID: 53364 RVA: 0x0030BC60 File Offset: 0x00309E60
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

		// Token: 0x1700353F RID: 13631
		// (get) Token: 0x0600D075 RID: 53365 RVA: 0x0030BC9C File Offset: 0x00309E9C
		public int Sort
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

		// Token: 0x0600D076 RID: 53366 RVA: 0x0030BCD8 File Offset: 0x00309ED8
		public string Language(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003540 RID: 13632
		// (get) Token: 0x0600D077 RID: 53367 RVA: 0x0030BD14 File Offset: 0x00309F14
		public int LanguageLength
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

		// Token: 0x0600D078 RID: 53368 RVA: 0x0030BD40 File Offset: 0x00309F40
		public string PackageId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003541 RID: 13633
		// (get) Token: 0x0600D079 RID: 53369 RVA: 0x0030BD7C File Offset: 0x00309F7C
		public int PackageIdLength
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

		// Token: 0x0600D07A RID: 53370 RVA: 0x0030BDA8 File Offset: 0x00309FA8
		public int Channel(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003542 RID: 13634
		// (get) Token: 0x0600D07B RID: 53371 RVA: 0x0030BDE8 File Offset: 0x00309FE8
		public int ChannelLength
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

		// Token: 0x0600D07C RID: 53372 RVA: 0x0030BE14 File Offset: 0x0030A014
		public Span<int> GetChannelBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600D07D RID: 53373 RVA: 0x0030BE24 File Offset: 0x0030A024
		public int[] GetChannelArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003543 RID: 13635
		// (get) Token: 0x0600D07E RID: 53374 RVA: 0x0030BE3C File Offset: 0x0030A03C
		public int ShareId
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

		// Token: 0x17003544 RID: 13636
		// (get) Token: 0x0600D07F RID: 53375 RVA: 0x0030BE7C File Offset: 0x0030A07C
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D080 RID: 53376 RVA: 0x0030BEB4 File Offset: 0x0030A0B4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D081 RID: 53377 RVA: 0x0030BEC4 File Offset: 0x0030A0C4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D082 RID: 53378 RVA: 0x0030BEDC File Offset: 0x0030A0DC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ChannelIter()或GetChannelBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Channel()
		{
			SharePlatform sharePlatform = this;
			return sharePlatform.GetChannelArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D083 RID: 53379 RVA: 0x0030BF00 File Offset: 0x0030A100
		[NullableContext(1)]
		public readonly IEnumerable<int> ChannelIter()
		{
			SharePlatform.<ChannelIter>d__32 <ChannelIter>d__ = new SharePlatform.<ChannelIter>d__32(-2);
			<ChannelIter>d__.<>3__<>4__this = this;
			return <ChannelIter>d__;
		}

		// Token: 0x0600D084 RID: 53380 RVA: 0x0030BF15 File Offset: 0x0030A115
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LanguageIter()或GetLanguageBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Language()
		{
			return this.LanguageIter().ToArray<string>();
		}

		// Token: 0x0600D085 RID: 53381 RVA: 0x0030BF22 File Offset: 0x0030A122
		[NullableContext(1)]
		public readonly IEnumerable<string> LanguageIter()
		{
			SharePlatform.<LanguageIter>d__34 <LanguageIter>d__ = new SharePlatform.<LanguageIter>d__34(-2);
			<LanguageIter>d__.<>3__<>4__this = this;
			return <LanguageIter>d__;
		}

		// Token: 0x0600D086 RID: 53382 RVA: 0x0030BF37 File Offset: 0x0030A137
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PackageIdIter()或GetPackageIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] PackageId()
		{
			return this.PackageIdIter().ToArray<string>();
		}

		// Token: 0x0600D087 RID: 53383 RVA: 0x0030BF44 File Offset: 0x0030A144
		[NullableContext(1)]
		public readonly IEnumerable<string> PackageIdIter()
		{
			SharePlatform.<PackageIdIter>d__36 <PackageIdIter>d__ = new SharePlatform.<PackageIdIter>d__36(-2);
			<PackageIdIter>d__.<>3__<>4__this = this;
			return <PackageIdIter>d__;
		}

		// Token: 0x040051A7 RID: 20903
		private Table __p;
	}
}
