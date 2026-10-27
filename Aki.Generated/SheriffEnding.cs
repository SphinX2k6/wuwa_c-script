using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200109F RID: 4255
	public struct SheriffEnding : IFlatbufferObject
	{
		// Token: 0x17003565 RID: 13669
		// (get) Token: 0x0600D0D1 RID: 53457 RVA: 0x0030CA71 File Offset: 0x0030AC71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D0D2 RID: 53458 RVA: 0x0030CA7E File Offset: 0x0030AC7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D0D3 RID: 53459 RVA: 0x0030CA88 File Offset: 0x0030AC88
		public static SheriffEnding GetRootAsSheriffEnding(ByteBuffer _bb)
		{
			return SheriffEnding.GetRootAsSheriffEnding(_bb, default(SheriffEnding));
		}

		// Token: 0x0600D0D4 RID: 53460 RVA: 0x0030CAA4 File Offset: 0x0030ACA4
		public static SheriffEnding GetRootAsSheriffEnding(ByteBuffer _bb, SheriffEnding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D0D5 RID: 53461 RVA: 0x0030CAC1 File Offset: 0x0030ACC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D0D6 RID: 53462 RVA: 0x0030CAD0 File Offset: 0x0030ACD0
		public SheriffEnding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003566 RID: 13670
		// (get) Token: 0x0600D0D7 RID: 53463 RVA: 0x0030CAE0 File Offset: 0x0030ACE0
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

		// Token: 0x17003567 RID: 13671
		// (get) Token: 0x0600D0D8 RID: 53464 RVA: 0x0030CB1C File Offset: 0x0030AD1C
		public int SheriffAnomalyId
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

		// Token: 0x0600D0D9 RID: 53465 RVA: 0x0030CB58 File Offset: 0x0030AD58
		public int SheriffClueId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003568 RID: 13672
		// (get) Token: 0x0600D0DA RID: 53466 RVA: 0x0030CB98 File Offset: 0x0030AD98
		public int SheriffClueIdLength
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

		// Token: 0x0600D0DB RID: 53467 RVA: 0x0030CBC3 File Offset: 0x0030ADC3
		public Span<int> GetSheriffClueIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600D0DC RID: 53468 RVA: 0x0030CBD2 File Offset: 0x0030ADD2
		public int[] GetSheriffClueIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17003569 RID: 13673
		// (get) Token: 0x0600D0DD RID: 53469 RVA: 0x0030CBEC File Offset: 0x0030ADEC
		public string Context
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

		// Token: 0x0600D0DE RID: 53470 RVA: 0x0030CC24 File Offset: 0x0030AE24
		public Span<byte> GetContextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D0DF RID: 53471 RVA: 0x0030CC34 File Offset: 0x0030AE34
		public byte[] GetContextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700356A RID: 13674
		// (get) Token: 0x0600D0E0 RID: 53472 RVA: 0x0030CC4C File Offset: 0x0030AE4C
		public string Icon
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

		// Token: 0x0600D0E1 RID: 53473 RVA: 0x0030CC84 File Offset: 0x0030AE84
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D0E2 RID: 53474 RVA: 0x0030CC94 File Offset: 0x0030AE94
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D0E3 RID: 53475 RVA: 0x0030CCAC File Offset: 0x0030AEAC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SheriffClueIdIter()或GetSheriffClueIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SheriffClueId()
		{
			SheriffEnding sheriffEnding = this;
			return sheriffEnding.GetSheriffClueIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D0E4 RID: 53476 RVA: 0x0030CCD0 File Offset: 0x0030AED0
		[NullableContext(1)]
		public readonly IEnumerable<int> SheriffClueIdIter()
		{
			SheriffEnding.<SheriffClueIdIter>d__26 <SheriffClueIdIter>d__ = new SheriffEnding.<SheriffClueIdIter>d__26(-2);
			<SheriffClueIdIter>d__.<>3__<>4__this = this;
			return <SheriffClueIdIter>d__;
		}

		// Token: 0x040051AD RID: 20909
		private Table __p;
	}
}
