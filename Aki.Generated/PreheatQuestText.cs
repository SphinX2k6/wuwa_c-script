using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F55 RID: 3925
	public struct PreheatQuestText : IFlatbufferObject
	{
		// Token: 0x17002AC3 RID: 10947
		// (get) Token: 0x0600B2D3 RID: 45779 RVA: 0x002CA3A4 File Offset: 0x002C85A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B2D4 RID: 45780 RVA: 0x002CA3B1 File Offset: 0x002C85B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B2D5 RID: 45781 RVA: 0x002CA3B8 File Offset: 0x002C85B8
		public static PreheatQuestText GetRootAsPreheatQuestText(ByteBuffer _bb)
		{
			return PreheatQuestText.GetRootAsPreheatQuestText(_bb, default(PreheatQuestText));
		}

		// Token: 0x0600B2D6 RID: 45782 RVA: 0x002CA3D4 File Offset: 0x002C85D4
		public static PreheatQuestText GetRootAsPreheatQuestText(ByteBuffer _bb, PreheatQuestText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B2D7 RID: 45783 RVA: 0x002CA3F1 File Offset: 0x002C85F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B2D8 RID: 45784 RVA: 0x002CA400 File Offset: 0x002C8600
		public PreheatQuestText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002AC4 RID: 10948
		// (get) Token: 0x0600B2D9 RID: 45785 RVA: 0x002CA410 File Offset: 0x002C8610
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

		// Token: 0x17002AC5 RID: 10949
		// (get) Token: 0x0600B2DA RID: 45786 RVA: 0x002CA44C File Offset: 0x002C864C
		public string MainTexPath
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

		// Token: 0x0600B2DB RID: 45787 RVA: 0x002CA483 File Offset: 0x002C8683
		public Span<byte> GetMainTexPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B2DC RID: 45788 RVA: 0x002CA492 File Offset: 0x002C8692
		public byte[] GetMainTexPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AC6 RID: 10950
		// (get) Token: 0x0600B2DD RID: 45789 RVA: 0x002CA4AC File Offset: 0x002C86AC
		public int CrestIndex
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

		// Token: 0x17002AC7 RID: 10951
		// (get) Token: 0x0600B2DE RID: 45790 RVA: 0x002CA4E8 File Offset: 0x002C86E8
		public string ThemeBefore
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

		// Token: 0x0600B2DF RID: 45791 RVA: 0x002CA520 File Offset: 0x002C8720
		public Span<byte> GetThemeBeforeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B2E0 RID: 45792 RVA: 0x002CA530 File Offset: 0x002C8730
		public byte[] GetThemeBeforeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AC8 RID: 10952
		// (get) Token: 0x0600B2E1 RID: 45793 RVA: 0x002CA548 File Offset: 0x002C8748
		public string ThemeAfter
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

		// Token: 0x0600B2E2 RID: 45794 RVA: 0x002CA580 File Offset: 0x002C8780
		public Span<byte> GetThemeAfterBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B2E3 RID: 45795 RVA: 0x002CA590 File Offset: 0x002C8790
		public byte[] GetThemeAfterArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AC9 RID: 10953
		// (get) Token: 0x0600B2E4 RID: 45796 RVA: 0x002CA5A8 File Offset: 0x002C87A8
		public string QuestContent
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

		// Token: 0x0600B2E5 RID: 45797 RVA: 0x002CA5E0 File Offset: 0x002C87E0
		public Span<byte> GetQuestContentBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B2E6 RID: 45798 RVA: 0x002CA5F0 File Offset: 0x002C87F0
		public byte[] GetQuestContentArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ACA RID: 10954
		// (get) Token: 0x0600B2E7 RID: 45799 RVA: 0x002CA608 File Offset: 0x002C8808
		public string DisplayTex
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

		// Token: 0x0600B2E8 RID: 45800 RVA: 0x002CA640 File Offset: 0x002C8840
		public Span<byte> GetDisplayTexBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B2E9 RID: 45801 RVA: 0x002CA650 File Offset: 0x002C8850
		public byte[] GetDisplayTexArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ACB RID: 10955
		// (get) Token: 0x0600B2EA RID: 45802 RVA: 0x002CA668 File Offset: 0x002C8868
		public string ShareTex
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

		// Token: 0x0600B2EB RID: 45803 RVA: 0x002CA6A0 File Offset: 0x002C88A0
		public Span<byte> GetShareTexBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B2EC RID: 45804 RVA: 0x002CA6B0 File Offset: 0x002C88B0
		public byte[] GetShareTexArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04005022 RID: 20514
		private Table __p;
	}
}
