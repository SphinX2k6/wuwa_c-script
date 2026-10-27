using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E79 RID: 3705
	public struct MusicBeatType : IFlatbufferObject
	{
		// Token: 0x170022C3 RID: 8899
		// (get) Token: 0x06009DCA RID: 40394 RVA: 0x0029ADF8 File Offset: 0x00298FF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009DCB RID: 40395 RVA: 0x0029AE05 File Offset: 0x00299005
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009DCC RID: 40396 RVA: 0x0029AE0C File Offset: 0x0029900C
		public static MusicBeatType GetRootAsMusicBeatType(ByteBuffer _bb)
		{
			return MusicBeatType.GetRootAsMusicBeatType(_bb, default(MusicBeatType));
		}

		// Token: 0x06009DCD RID: 40397 RVA: 0x0029AE28 File Offset: 0x00299028
		public static MusicBeatType GetRootAsMusicBeatType(ByteBuffer _bb, MusicBeatType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009DCE RID: 40398 RVA: 0x0029AE45 File Offset: 0x00299045
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009DCF RID: 40399 RVA: 0x0029AE54 File Offset: 0x00299054
		public MusicBeatType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022C4 RID: 8900
		// (get) Token: 0x06009DD0 RID: 40400 RVA: 0x0029AE64 File Offset: 0x00299064
		public string BeatType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009DD1 RID: 40401 RVA: 0x0029AE9B File Offset: 0x0029909B
		public Span<byte> GetBeatTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06009DD2 RID: 40402 RVA: 0x0029AEAA File Offset: 0x002990AA
		public byte[] GetBeatTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170022C5 RID: 8901
		// (get) Token: 0x06009DD3 RID: 40403 RVA: 0x0029AEC4 File Offset: 0x002990C4
		public string MusicType
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

		// Token: 0x06009DD4 RID: 40404 RVA: 0x0029AEFB File Offset: 0x002990FB
		public Span<byte> GetMusicTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009DD5 RID: 40405 RVA: 0x0029AF0A File Offset: 0x0029910A
		public byte[] GetMusicTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170022C6 RID: 8902
		// (get) Token: 0x06009DD6 RID: 40406 RVA: 0x0029AF24 File Offset: 0x00299124
		public string BeatConfigType
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

		// Token: 0x06009DD7 RID: 40407 RVA: 0x0029AF5B File Offset: 0x0029915B
		public Span<byte> GetBeatConfigTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009DD8 RID: 40408 RVA: 0x0029AF6A File Offset: 0x0029916A
		public byte[] GetBeatConfigTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06009DD9 RID: 40409 RVA: 0x0029AF84 File Offset: 0x00299184
		public int BeatConfig(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022C7 RID: 8903
		// (get) Token: 0x06009DDA RID: 40410 RVA: 0x0029AFC4 File Offset: 0x002991C4
		public int BeatConfigLength
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

		// Token: 0x06009DDB RID: 40411 RVA: 0x0029AFF0 File Offset: 0x002991F0
		public Span<int> GetBeatConfigBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06009DDC RID: 40412 RVA: 0x0029B000 File Offset: 0x00299200
		public int[] GetBeatConfigArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06009DDD RID: 40413 RVA: 0x0029B018 File Offset: 0x00299218
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BeatConfigIter()或GetBeatConfigBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BeatConfig()
		{
			MusicBeatType musicBeatType = this;
			return musicBeatType.GetBeatConfigArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009DDE RID: 40414 RVA: 0x0029B03C File Offset: 0x0029923C
		[NullableContext(1)]
		public readonly IEnumerable<int> BeatConfigIter()
		{
			MusicBeatType.<BeatConfigIter>d__26 <BeatConfigIter>d__ = new MusicBeatType.<BeatConfigIter>d__26(-2);
			<BeatConfigIter>d__.<>3__<>4__this = this;
			return <BeatConfigIter>d__;
		}

		// Token: 0x04004F27 RID: 20263
		private Table __p;
	}
}
