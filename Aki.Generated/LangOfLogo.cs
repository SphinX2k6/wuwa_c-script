using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DBD RID: 3517
	public struct LangOfLogo : IFlatbufferObject
	{
		// Token: 0x17001C91 RID: 7313
		// (get) Token: 0x06008CF8 RID: 36088 RVA: 0x00275678 File Offset: 0x00273878
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008CF9 RID: 36089 RVA: 0x00275685 File Offset: 0x00273885
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008CFA RID: 36090 RVA: 0x0027568C File Offset: 0x0027388C
		public static LangOfLogo GetRootAsLangOfLogo(ByteBuffer _bb)
		{
			return LangOfLogo.GetRootAsLangOfLogo(_bb, default(LangOfLogo));
		}

		// Token: 0x06008CFB RID: 36091 RVA: 0x002756A8 File Offset: 0x002738A8
		public static LangOfLogo GetRootAsLangOfLogo(ByteBuffer _bb, LangOfLogo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008CFC RID: 36092 RVA: 0x002756C5 File Offset: 0x002738C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008CFD RID: 36093 RVA: 0x002756D4 File Offset: 0x002738D4
		public LangOfLogo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C92 RID: 7314
		// (get) Token: 0x06008CFE RID: 36094 RVA: 0x002756E4 File Offset: 0x002738E4
		public string Name
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

		// Token: 0x06008CFF RID: 36095 RVA: 0x0027571B File Offset: 0x0027391B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06008D00 RID: 36096 RVA: 0x0027572A File Offset: 0x0027392A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C93 RID: 7315
		// (get) Token: 0x06008D01 RID: 36097 RVA: 0x00275744 File Offset: 0x00273944
		public string ZhHansLogo
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

		// Token: 0x06008D02 RID: 36098 RVA: 0x0027577B File Offset: 0x0027397B
		public Span<byte> GetZhHansLogoBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008D03 RID: 36099 RVA: 0x0027578A File Offset: 0x0027398A
		public byte[] GetZhHansLogoArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C94 RID: 7316
		// (get) Token: 0x06008D04 RID: 36100 RVA: 0x002757A4 File Offset: 0x002739A4
		public string EnLogo
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

		// Token: 0x06008D05 RID: 36101 RVA: 0x002757DB File Offset: 0x002739DB
		public Span<byte> GetEnLogoBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008D06 RID: 36102 RVA: 0x002757EA File Offset: 0x002739EA
		public byte[] GetEnLogoArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C95 RID: 7317
		// (get) Token: 0x06008D07 RID: 36103 RVA: 0x00275804 File Offset: 0x00273A04
		public string JpLogo
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

		// Token: 0x06008D08 RID: 36104 RVA: 0x0027583C File Offset: 0x00273A3C
		public Span<byte> GetJpLogoBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008D09 RID: 36105 RVA: 0x0027584C File Offset: 0x00273A4C
		public byte[] GetJpLogoArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C96 RID: 7318
		// (get) Token: 0x06008D0A RID: 36106 RVA: 0x00275864 File Offset: 0x00273A64
		public string ZhHantLogo
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

		// Token: 0x06008D0B RID: 36107 RVA: 0x0027589C File Offset: 0x00273A9C
		public Span<byte> GetZhHantLogoBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008D0C RID: 36108 RVA: 0x002758AC File Offset: 0x00273AAC
		public byte[] GetZhHantLogoArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C97 RID: 7319
		// (get) Token: 0x06008D0D RID: 36109 RVA: 0x002758C4 File Offset: 0x00273AC4
		public string KrLogo
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

		// Token: 0x06008D0E RID: 36110 RVA: 0x002758FC File Offset: 0x00273AFC
		public Span<byte> GetKrLogoBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008D0F RID: 36111 RVA: 0x0027590C File Offset: 0x00273B0C
		public byte[] GetKrLogoArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E53 RID: 20051
		private Table __p;
	}
}
