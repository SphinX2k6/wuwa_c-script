using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F82 RID: 3970
	public struct NpcSystemBackground : IFlatbufferObject
	{
		// Token: 0x17002445 RID: 9285
		// (get) Token: 0x0600A6FE RID: 42750 RVA: 0x002BEEA1 File Offset: 0x002BD0A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A6FF RID: 42751 RVA: 0x002BEEAE File Offset: 0x002BD0AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A700 RID: 42752 RVA: 0x002BEEB8 File Offset: 0x002BD0B8
		public static NpcSystemBackground GetRootAsNpcSystemBackground(ByteBuffer _bb)
		{
			return NpcSystemBackground.GetRootAsNpcSystemBackground(_bb, default(NpcSystemBackground));
		}

		// Token: 0x0600A701 RID: 42753 RVA: 0x002BEED4 File Offset: 0x002BD0D4
		public static NpcSystemBackground GetRootAsNpcSystemBackground(ByteBuffer _bb, NpcSystemBackground obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A702 RID: 42754 RVA: 0x002BEEF1 File Offset: 0x002BD0F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A703 RID: 42755 RVA: 0x002BEF00 File Offset: 0x002BD100
		public NpcSystemBackground __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002446 RID: 9286
		// (get) Token: 0x0600A704 RID: 42756 RVA: 0x002BEF10 File Offset: 0x002BD110
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

		// Token: 0x17002447 RID: 9287
		// (get) Token: 0x0600A705 RID: 42757 RVA: 0x002BEF4C File Offset: 0x002BD14C
		public string ViewName
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

		// Token: 0x0600A706 RID: 42758 RVA: 0x002BEF83 File Offset: 0x002BD183
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A707 RID: 42759 RVA: 0x002BEF92 File Offset: 0x002BD192
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002448 RID: 9288
		// (get) Token: 0x0600A708 RID: 42760 RVA: 0x002BEFAC File Offset: 0x002BD1AC
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

		// Token: 0x0600A709 RID: 42761 RVA: 0x002BEFE3 File Offset: 0x002BD1E3
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A70A RID: 42762 RVA: 0x002BEFF2 File Offset: 0x002BD1F2
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002449 RID: 9289
		// (get) Token: 0x0600A70B RID: 42763 RVA: 0x002BF00C File Offset: 0x002BD20C
		public string TitleTexturePath
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

		// Token: 0x0600A70C RID: 42764 RVA: 0x002BF044 File Offset: 0x002BD244
		public Span<byte> GetTitleTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A70D RID: 42765 RVA: 0x002BF054 File Offset: 0x002BD254
		public byte[] GetTitleTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700244A RID: 9290
		// (get) Token: 0x0600A70E RID: 42766 RVA: 0x002BF06C File Offset: 0x002BD26C
		public string TitleBgTexturePath
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

		// Token: 0x0600A70F RID: 42767 RVA: 0x002BF0A4 File Offset: 0x002BD2A4
		public Span<byte> GetTitleBgTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A710 RID: 42768 RVA: 0x002BF0B4 File Offset: 0x002BD2B4
		public byte[] GetTitleBgTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700244B RID: 9291
		// (get) Token: 0x0600A711 RID: 42769 RVA: 0x002BF0CC File Offset: 0x002BD2CC
		public string TitleSymbolColor
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

		// Token: 0x0600A712 RID: 42770 RVA: 0x002BF104 File Offset: 0x002BD304
		public Span<byte> GetTitleSymbolColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A713 RID: 42771 RVA: 0x002BF114 File Offset: 0x002BD314
		public byte[] GetTitleSymbolColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700244C RID: 9292
		// (get) Token: 0x0600A714 RID: 42772 RVA: 0x002BF12C File Offset: 0x002BD32C
		public string CaptionTitle
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

		// Token: 0x0600A715 RID: 42773 RVA: 0x002BF164 File Offset: 0x002BD364
		public Span<byte> GetCaptionTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A716 RID: 42774 RVA: 0x002BF174 File Offset: 0x002BD374
		public byte[] GetCaptionTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700244D RID: 9293
		// (get) Token: 0x0600A717 RID: 42775 RVA: 0x002BF18C File Offset: 0x002BD38C
		public string CaptionTitleSpritePath
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

		// Token: 0x0600A718 RID: 42776 RVA: 0x002BF1C4 File Offset: 0x002BD3C4
		public Span<byte> GetCaptionTitleSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A719 RID: 42777 RVA: 0x002BF1D4 File Offset: 0x002BD3D4
		public byte[] GetCaptionTitleSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A71A RID: 42778 RVA: 0x002BF1EC File Offset: 0x002BD3EC
		public int CostItemList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700244E RID: 9294
		// (get) Token: 0x0600A71B RID: 42779 RVA: 0x002BF22C File Offset: 0x002BD42C
		public int CostItemListLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A71C RID: 42780 RVA: 0x002BF258 File Offset: 0x002BD458
		public Span<int> GetCostItemListBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600A71D RID: 42781 RVA: 0x002BF268 File Offset: 0x002BD468
		public int[] GetCostItemListArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x1700244F RID: 9295
		// (get) Token: 0x0600A71E RID: 42782 RVA: 0x002BF280 File Offset: 0x002BD480
		public bool IsHelpButtonVisible
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002450 RID: 9296
		// (get) Token: 0x0600A71F RID: 42783 RVA: 0x002BF2C0 File Offset: 0x002BD4C0
		public int HelpGroupId
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

		// Token: 0x0600A720 RID: 42784 RVA: 0x002BF2FD File Offset: 0x002BD4FD
		[NullableContext(1)]
		public int[] CostItemList()
		{
			return this.GetCostItemListArray();
		}

		// Token: 0x0600A721 RID: 42785 RVA: 0x002BF305 File Offset: 0x002BD505
		[NullableContext(1)]
		public IEnumerable<int> CostItemListIter()
		{
			NpcSystemBackground.<CostItemListIter>d__48 <CostItemListIter>d__ = new NpcSystemBackground.<CostItemListIter>d__48(-2);
			<CostItemListIter>d__.<>3__<>4__this = this;
			return <CostItemListIter>d__;
		}

		// Token: 0x04005536 RID: 21814
		private Table __p;
	}
}
