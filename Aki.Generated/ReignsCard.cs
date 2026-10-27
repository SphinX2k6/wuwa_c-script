using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FB7 RID: 4023
	public struct ReignsCard : IFlatbufferObject
	{
		// Token: 0x17002DE2 RID: 11746
		// (get) Token: 0x0600BB74 RID: 47988 RVA: 0x002DCFFA File Offset: 0x002DB1FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BB75 RID: 47989 RVA: 0x002DD007 File Offset: 0x002DB207
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BB76 RID: 47990 RVA: 0x002DD010 File Offset: 0x002DB210
		public static ReignsCard GetRootAsReignsCard(ByteBuffer _bb)
		{
			return ReignsCard.GetRootAsReignsCard(_bb, default(ReignsCard));
		}

		// Token: 0x0600BB77 RID: 47991 RVA: 0x002DD02C File Offset: 0x002DB22C
		public static ReignsCard GetRootAsReignsCard(ByteBuffer _bb, ReignsCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BB78 RID: 47992 RVA: 0x002DD049 File Offset: 0x002DB249
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BB79 RID: 47993 RVA: 0x002DD058 File Offset: 0x002DB258
		public ReignsCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DE3 RID: 11747
		// (get) Token: 0x0600BB7A RID: 47994 RVA: 0x002DD068 File Offset: 0x002DB268
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

		// Token: 0x17002DE4 RID: 11748
		// (get) Token: 0x0600BB7B RID: 47995 RVA: 0x002DD0A4 File Offset: 0x002DB2A4
		public string CardType
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

		// Token: 0x0600BB7C RID: 47996 RVA: 0x002DD0DB File Offset: 0x002DB2DB
		public Span<byte> GetCardTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BB7D RID: 47997 RVA: 0x002DD0EA File Offset: 0x002DB2EA
		public byte[] GetCardTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DE5 RID: 11749
		// (get) Token: 0x0600BB7E RID: 47998 RVA: 0x002DD104 File Offset: 0x002DB304
		public string CardBackground
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

		// Token: 0x0600BB7F RID: 47999 RVA: 0x002DD13B File Offset: 0x002DB33B
		public Span<byte> GetCardBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BB80 RID: 48000 RVA: 0x002DD14A File Offset: 0x002DB34A
		public byte[] GetCardBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DE6 RID: 11750
		// (get) Token: 0x0600BB81 RID: 48001 RVA: 0x002DD164 File Offset: 0x002DB364
		public string CardIcon
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

		// Token: 0x0600BB82 RID: 48002 RVA: 0x002DD19C File Offset: 0x002DB39C
		public Span<byte> GetCardIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BB83 RID: 48003 RVA: 0x002DD1AC File Offset: 0x002DB3AC
		public byte[] GetCardIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DE7 RID: 11751
		// (get) Token: 0x0600BB84 RID: 48004 RVA: 0x002DD1C4 File Offset: 0x002DB3C4
		public string CardTitle
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BB85 RID: 48005 RVA: 0x002DD1FC File Offset: 0x002DB3FC
		public Span<byte> GetCardTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BB86 RID: 48006 RVA: 0x002DD20C File Offset: 0x002DB40C
		public byte[] GetCardTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DE8 RID: 11752
		// (get) Token: 0x0600BB87 RID: 48007 RVA: 0x002DD224 File Offset: 0x002DB424
		public string CardDescription
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

		// Token: 0x0600BB88 RID: 48008 RVA: 0x002DD25C File Offset: 0x002DB45C
		public Span<byte> GetCardDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BB89 RID: 48009 RVA: 0x002DD26C File Offset: 0x002DB46C
		public byte[] GetCardDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DE9 RID: 11753
		// (get) Token: 0x0600BB8A RID: 48010 RVA: 0x002DD284 File Offset: 0x002DB484
		public string CardHeader
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BB8B RID: 48011 RVA: 0x002DD2BC File Offset: 0x002DB4BC
		public Span<byte> GetCardHeaderBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BB8C RID: 48012 RVA: 0x002DD2CC File Offset: 0x002DB4CC
		public byte[] GetCardHeaderArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BB8D RID: 48013 RVA: 0x002DD2E4 File Offset: 0x002DB4E4
		public string StaticImageFlow(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DEA RID: 11754
		// (get) Token: 0x0600BB8E RID: 48014 RVA: 0x002DD320 File Offset: 0x002DB520
		public int StaticImageFlowLength
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

		// Token: 0x0600BB8F RID: 48015 RVA: 0x002DD34C File Offset: 0x002DB54C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用StaticImageFlowIter()或GetStaticImageFlowBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] StaticImageFlow()
		{
			return this.StaticImageFlowIter().ToArray<string>();
		}

		// Token: 0x0600BB90 RID: 48016 RVA: 0x002DD359 File Offset: 0x002DB559
		[NullableContext(1)]
		public readonly IEnumerable<string> StaticImageFlowIter()
		{
			ReignsCard.<StaticImageFlowIter>d__38 <StaticImageFlowIter>d__ = new ReignsCard.<StaticImageFlowIter>d__38(-2);
			<StaticImageFlowIter>d__.<>3__<>4__this = this;
			return <StaticImageFlowIter>d__;
		}

		// Token: 0x04005090 RID: 20624
		private Table __p;
	}
}
