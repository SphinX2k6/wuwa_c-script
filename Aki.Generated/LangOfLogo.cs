using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EA2 RID: 3746
	public struct LangOfLogo : IFlatbufferObject
	{
		// Token: 0x17001CF5 RID: 7413
		// (get) Token: 0x06009314 RID: 37652 RVA: 0x00293D90 File Offset: 0x00291F90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009315 RID: 37653 RVA: 0x00293D9D File Offset: 0x00291F9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009316 RID: 37654 RVA: 0x00293DA4 File Offset: 0x00291FA4
		public static LangOfLogo GetRootAsLangOfLogo(ByteBuffer _bb)
		{
			return LangOfLogo.GetRootAsLangOfLogo(_bb, default(LangOfLogo));
		}

		// Token: 0x06009317 RID: 37655 RVA: 0x00293DC0 File Offset: 0x00291FC0
		public static LangOfLogo GetRootAsLangOfLogo(ByteBuffer _bb, LangOfLogo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009318 RID: 37656 RVA: 0x00293DDD File Offset: 0x00291FDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009319 RID: 37657 RVA: 0x00293DEC File Offset: 0x00291FEC
		public LangOfLogo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CF6 RID: 7414
		// (get) Token: 0x0600931A RID: 37658 RVA: 0x00293DFC File Offset: 0x00291FFC
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

		// Token: 0x0600931B RID: 37659 RVA: 0x00293E33 File Offset: 0x00292033
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600931C RID: 37660 RVA: 0x00293E42 File Offset: 0x00292042
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CF7 RID: 7415
		// (get) Token: 0x0600931D RID: 37661 RVA: 0x00293E5C File Offset: 0x0029205C
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

		// Token: 0x0600931E RID: 37662 RVA: 0x00293E93 File Offset: 0x00292093
		public Span<byte> GetZhHansLogoBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600931F RID: 37663 RVA: 0x00293EA2 File Offset: 0x002920A2
		public byte[] GetZhHansLogoArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CF8 RID: 7416
		// (get) Token: 0x06009320 RID: 37664 RVA: 0x00293EBC File Offset: 0x002920BC
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

		// Token: 0x06009321 RID: 37665 RVA: 0x00293EF3 File Offset: 0x002920F3
		public Span<byte> GetEnLogoBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009322 RID: 37666 RVA: 0x00293F02 File Offset: 0x00292102
		public byte[] GetEnLogoArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CF9 RID: 7417
		// (get) Token: 0x06009323 RID: 37667 RVA: 0x00293F1C File Offset: 0x0029211C
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

		// Token: 0x06009324 RID: 37668 RVA: 0x00293F54 File Offset: 0x00292154
		public Span<byte> GetJpLogoBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009325 RID: 37669 RVA: 0x00293F64 File Offset: 0x00292164
		public byte[] GetJpLogoArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CFA RID: 7418
		// (get) Token: 0x06009326 RID: 37670 RVA: 0x00293F7C File Offset: 0x0029217C
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

		// Token: 0x06009327 RID: 37671 RVA: 0x00293FB4 File Offset: 0x002921B4
		public Span<byte> GetZhHantLogoBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009328 RID: 37672 RVA: 0x00293FC4 File Offset: 0x002921C4
		public byte[] GetZhHantLogoArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CFB RID: 7419
		// (get) Token: 0x06009329 RID: 37673 RVA: 0x00293FDC File Offset: 0x002921DC
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

		// Token: 0x0600932A RID: 37674 RVA: 0x00294014 File Offset: 0x00292214
		public Span<byte> GetKrLogoBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600932B RID: 37675 RVA: 0x00294024 File Offset: 0x00292224
		public byte[] GetKrLogoArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005438 RID: 21560
		private Table __p;
	}
}
