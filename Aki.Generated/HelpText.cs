using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D28 RID: 3368
	public struct HelpText : IFlatbufferObject
	{
		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x06007E58 RID: 32344 RVA: 0x00253B85 File Offset: 0x00251D85
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007E59 RID: 32345 RVA: 0x00253B92 File Offset: 0x00251D92
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007E5A RID: 32346 RVA: 0x00253B9C File Offset: 0x00251D9C
		public static HelpText GetRootAsHelpText(ByteBuffer _bb)
		{
			return HelpText.GetRootAsHelpText(_bb, default(HelpText));
		}

		// Token: 0x06007E5B RID: 32347 RVA: 0x00253BB8 File Offset: 0x00251DB8
		public static HelpText GetRootAsHelpText(ByteBuffer _bb, HelpText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007E5C RID: 32348 RVA: 0x00253BD5 File Offset: 0x00251DD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007E5D RID: 32349 RVA: 0x00253BE4 File Offset: 0x00251DE4
		public HelpText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x06007E5E RID: 32350 RVA: 0x00253BF4 File Offset: 0x00251DF4
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

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x06007E5F RID: 32351 RVA: 0x00253C30 File Offset: 0x00251E30
		public int GroupId
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

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x06007E60 RID: 32352 RVA: 0x00253C6C File Offset: 0x00251E6C
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

		// Token: 0x06007E61 RID: 32353 RVA: 0x00253CA3 File Offset: 0x00251EA3
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007E62 RID: 32354 RVA: 0x00253CB2 File Offset: 0x00251EB2
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x06007E63 RID: 32355 RVA: 0x00253CCC File Offset: 0x00251ECC
		public string Picture
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

		// Token: 0x06007E64 RID: 32356 RVA: 0x00253D04 File Offset: 0x00251F04
		public Span<byte> GetPictureBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007E65 RID: 32357 RVA: 0x00253D14 File Offset: 0x00251F14
		public byte[] GetPictureArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x06007E66 RID: 32358 RVA: 0x00253D2C File Offset: 0x00251F2C
		public string Content
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

		// Token: 0x06007E67 RID: 32359 RVA: 0x00253D64 File Offset: 0x00251F64
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007E68 RID: 32360 RVA: 0x00253D74 File Offset: 0x00251F74
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x06007E69 RID: 32361 RVA: 0x00253D8C File Offset: 0x00251F8C
		public int Type
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x06007E6A RID: 32362 RVA: 0x00253DCC File Offset: 0x00251FCC
		public int Style
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

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x06007E6B RID: 32363 RVA: 0x00253E0C File Offset: 0x0025200C
		public int TimeDilation
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004DA0 RID: 19872
		private Table __p;
	}
}
