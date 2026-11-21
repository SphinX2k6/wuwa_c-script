using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C5B RID: 3163
	public struct CiacconaGalStep : IFlatbufferObject
	{
		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06005B38 RID: 23352 RVA: 0x00215A4D File Offset: 0x00213C4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005B39 RID: 23353 RVA: 0x00215A5A File Offset: 0x00213C5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005B3A RID: 23354 RVA: 0x00215A64 File Offset: 0x00213C64
		public static CiacconaGalStep GetRootAsCiacconaGalStep(ByteBuffer _bb)
		{
			return CiacconaGalStep.GetRootAsCiacconaGalStep(_bb, default(CiacconaGalStep));
		}

		// Token: 0x06005B3B RID: 23355 RVA: 0x00215A80 File Offset: 0x00213C80
		public static CiacconaGalStep GetRootAsCiacconaGalStep(ByteBuffer _bb, CiacconaGalStep obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005B3C RID: 23356 RVA: 0x00215A9D File Offset: 0x00213C9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005B3D RID: 23357 RVA: 0x00215AAC File Offset: 0x00213CAC
		public CiacconaGalStep __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06005B3E RID: 23358 RVA: 0x00215ABC File Offset: 0x00213CBC
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

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06005B3F RID: 23359 RVA: 0x00215AF8 File Offset: 0x00213CF8
		public int Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06005B40 RID: 23360 RVA: 0x00215B34 File Offset: 0x00213D34
		public string Content
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

		// Token: 0x06005B41 RID: 23361 RVA: 0x00215B6B File Offset: 0x00213D6B
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005B42 RID: 23362 RVA: 0x00215B7A File Offset: 0x00213D7A
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06005B43 RID: 23363 RVA: 0x00215B94 File Offset: 0x00213D94
		public string Image
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

		// Token: 0x06005B44 RID: 23364 RVA: 0x00215BCC File Offset: 0x00213DCC
		public Span<byte> GetImageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005B45 RID: 23365 RVA: 0x00215BDC File Offset: 0x00213DDC
		public byte[] GetImageArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06005B46 RID: 23366 RVA: 0x00215BF4 File Offset: 0x00213DF4
		public string ImageMale
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

		// Token: 0x06005B47 RID: 23367 RVA: 0x00215C2C File Offset: 0x00213E2C
		public Span<byte> GetImageMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005B48 RID: 23368 RVA: 0x00215C3C File Offset: 0x00213E3C
		public byte[] GetImageMaleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06005B49 RID: 23369 RVA: 0x00215C54 File Offset: 0x00213E54
		public string ImageFemale
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

		// Token: 0x06005B4A RID: 23370 RVA: 0x00215C8C File Offset: 0x00213E8C
		public Span<byte> GetImageFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005B4B RID: 23371 RVA: 0x00215C9C File Offset: 0x00213E9C
		public byte[] GetImageFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06005B4C RID: 23372 RVA: 0x00215CB4 File Offset: 0x00213EB4
		public string Audio
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

		// Token: 0x06005B4D RID: 23373 RVA: 0x00215CEC File Offset: 0x00213EEC
		public Span<byte> GetAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005B4E RID: 23374 RVA: 0x00215CFC File Offset: 0x00213EFC
		public byte[] GetAudioArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06005B4F RID: 23375 RVA: 0x00215D14 File Offset: 0x00213F14
		public string Music
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

		// Token: 0x06005B50 RID: 23376 RVA: 0x00215D4C File Offset: 0x00213F4C
		public Span<byte> GetMusicBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005B51 RID: 23377 RVA: 0x00215D5C File Offset: 0x00213F5C
		public byte[] GetMusicArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06005B52 RID: 23378 RVA: 0x00215D74 File Offset: 0x00213F74
		public string MusicState
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

		// Token: 0x06005B53 RID: 23379 RVA: 0x00215DAC File Offset: 0x00213FAC
		public Span<byte> GetMusicStateBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005B54 RID: 23380 RVA: 0x00215DBC File Offset: 0x00213FBC
		public byte[] GetMusicStateArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06005B55 RID: 23381 RVA: 0x00215DD4 File Offset: 0x00213FD4
		public string Anim
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

		// Token: 0x06005B56 RID: 23382 RVA: 0x00215E0C File Offset: 0x0021400C
		public Span<byte> GetAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005B57 RID: 23383 RVA: 0x00215E1C File Offset: 0x0021401C
		public byte[] GetAnimArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06005B58 RID: 23384 RVA: 0x00215E34 File Offset: 0x00214034
		public int TriggerSubEnding
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005B59 RID: 23385 RVA: 0x00215E74 File Offset: 0x00214074
		public int Choices(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06005B5A RID: 23386 RVA: 0x00215EB4 File Offset: 0x002140B4
		public int ChoicesLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005B5B RID: 23387 RVA: 0x00215EE0 File Offset: 0x002140E0
		public Span<int> GetChoicesBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06005B5C RID: 23388 RVA: 0x00215EF0 File Offset: 0x002140F0
		public int[] GetChoicesArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x06005B5D RID: 23389 RVA: 0x00215F08 File Offset: 0x00214108
		[NullableContext(1)]
		public int[] Choices()
		{
			return this.GetChoicesArray();
		}

		// Token: 0x06005B5E RID: 23390 RVA: 0x00215F10 File Offset: 0x00214110
		[NullableContext(1)]
		public IEnumerable<int> ChoicesIter()
		{
			CiacconaGalStep.<ChoicesIter>d__52 <ChoicesIter>d__ = new CiacconaGalStep.<ChoicesIter>d__52(-2);
			<ChoicesIter>d__.<>3__<>4__this = this;
			return <ChoicesIter>d__;
		}

		// Token: 0x0400515F RID: 20831
		private Table __p;
	}
}
