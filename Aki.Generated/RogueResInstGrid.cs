using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200100B RID: 4107
	public struct RogueResInstGrid : IFlatbufferObject
	{
		// Token: 0x1700308C RID: 12428
		// (get) Token: 0x0600C34C RID: 49996 RVA: 0x002EE6DE File Offset: 0x002EC8DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C34D RID: 49997 RVA: 0x002EE6EB File Offset: 0x002EC8EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C34E RID: 49998 RVA: 0x002EE6F4 File Offset: 0x002EC8F4
		public static RogueResInstGrid GetRootAsRogueResInstGrid(ByteBuffer _bb)
		{
			return RogueResInstGrid.GetRootAsRogueResInstGrid(_bb, default(RogueResInstGrid));
		}

		// Token: 0x0600C34F RID: 49999 RVA: 0x002EE710 File Offset: 0x002EC910
		public static RogueResInstGrid GetRootAsRogueResInstGrid(ByteBuffer _bb, RogueResInstGrid obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C350 RID: 50000 RVA: 0x002EE72D File Offset: 0x002EC92D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C351 RID: 50001 RVA: 0x002EE73C File Offset: 0x002EC93C
		public RogueResInstGrid __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700308D RID: 12429
		// (get) Token: 0x0600C352 RID: 50002 RVA: 0x002EE74C File Offset: 0x002EC94C
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

		// Token: 0x0600C353 RID: 50003 RVA: 0x002EE788 File Offset: 0x002EC988
		public string SubLevelArray(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700308E RID: 12430
		// (get) Token: 0x0600C354 RID: 50004 RVA: 0x002EE7C4 File Offset: 0x002EC9C4
		public int SubLevelArrayLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700308F RID: 12431
		// (get) Token: 0x0600C355 RID: 50005 RVA: 0x002EE7F0 File Offset: 0x002EC9F0
		public string Title
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C356 RID: 50006 RVA: 0x002EE827 File Offset: 0x002ECA27
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C357 RID: 50007 RVA: 0x002EE836 File Offset: 0x002ECA36
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003090 RID: 12432
		// (get) Token: 0x0600C358 RID: 50008 RVA: 0x002EE850 File Offset: 0x002ECA50
		public int MapScaleMin
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003091 RID: 12433
		// (get) Token: 0x0600C359 RID: 50009 RVA: 0x002EE894 File Offset: 0x002ECA94
		public int MapScaleMax
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 2000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003092 RID: 12434
		// (get) Token: 0x0600C35A RID: 50010 RVA: 0x002EE8D8 File Offset: 0x002ECAD8
		public int MapInitScale
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003093 RID: 12435
		// (get) Token: 0x0600C35B RID: 50011 RVA: 0x002EE91C File Offset: 0x002ECB1C
		public int MapHeight
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 6000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003094 RID: 12436
		// (get) Token: 0x0600C35C RID: 50012 RVA: 0x002EE960 File Offset: 0x002ECB60
		public int MapWidth
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 6000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003095 RID: 12437
		// (get) Token: 0x0600C35D RID: 50013 RVA: 0x002EE9A4 File Offset: 0x002ECBA4
		public string MapBackground
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C35E RID: 50014 RVA: 0x002EE9DC File Offset: 0x002ECBDC
		public Span<byte> GetMapBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C35F RID: 50015 RVA: 0x002EE9EC File Offset: 0x002ECBEC
		public byte[] GetMapBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003096 RID: 12438
		// (get) Token: 0x0600C360 RID: 50016 RVA: 0x002EEA04 File Offset: 0x002ECC04
		public string MapMusicState
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

		// Token: 0x0600C361 RID: 50017 RVA: 0x002EEA3C File Offset: 0x002ECC3C
		public Span<byte> GetMapMusicStateBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600C362 RID: 50018 RVA: 0x002EEA4C File Offset: 0x002ECC4C
		public byte[] GetMapMusicStateArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003097 RID: 12439
		// (get) Token: 0x0600C363 RID: 50019 RVA: 0x002EEA64 File Offset: 0x002ECC64
		public string LoseTitle
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

		// Token: 0x0600C364 RID: 50020 RVA: 0x002EEA9C File Offset: 0x002ECC9C
		public Span<byte> GetLoseTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600C365 RID: 50021 RVA: 0x002EEAAC File Offset: 0x002ECCAC
		public byte[] GetLoseTitleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17003098 RID: 12440
		// (get) Token: 0x0600C366 RID: 50022 RVA: 0x002EEAC4 File Offset: 0x002ECCC4
		public string LoseDesc
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C367 RID: 50023 RVA: 0x002EEAFC File Offset: 0x002ECCFC
		public Span<byte> GetLoseDescBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600C368 RID: 50024 RVA: 0x002EEB0C File Offset: 0x002ECD0C
		public byte[] GetLoseDescArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C369 RID: 50025 RVA: 0x002EEB24 File Offset: 0x002ECD24
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SubLevelArrayIter()或GetSubLevelArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SubLevelArray()
		{
			return this.SubLevelArrayIter().ToArray<string>();
		}

		// Token: 0x0600C36A RID: 50026 RVA: 0x002EEB31 File Offset: 0x002ECD31
		[NullableContext(1)]
		public readonly IEnumerable<string> SubLevelArrayIter()
		{
			RogueResInstGrid.<SubLevelArrayIter>d__44 <SubLevelArrayIter>d__ = new RogueResInstGrid.<SubLevelArrayIter>d__44(-2);
			<SubLevelArrayIter>d__.<>3__<>4__this = this;
			return <SubLevelArrayIter>d__;
		}

		// Token: 0x040050F8 RID: 20728
		private Table __p;
	}
}
