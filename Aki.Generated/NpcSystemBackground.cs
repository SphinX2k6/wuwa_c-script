using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E9D RID: 3741
	public struct NpcSystemBackground : IFlatbufferObject
	{
		// Token: 0x170023E0 RID: 9184
		// (get) Token: 0x0600A0DE RID: 41182 RVA: 0x002A1999 File Offset: 0x0029FB99
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A0DF RID: 41183 RVA: 0x002A19A6 File Offset: 0x0029FBA6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A0E0 RID: 41184 RVA: 0x002A19B0 File Offset: 0x0029FBB0
		public static NpcSystemBackground GetRootAsNpcSystemBackground(ByteBuffer _bb)
		{
			return NpcSystemBackground.GetRootAsNpcSystemBackground(_bb, default(NpcSystemBackground));
		}

		// Token: 0x0600A0E1 RID: 41185 RVA: 0x002A19CC File Offset: 0x0029FBCC
		public static NpcSystemBackground GetRootAsNpcSystemBackground(ByteBuffer _bb, NpcSystemBackground obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A0E2 RID: 41186 RVA: 0x002A19E9 File Offset: 0x0029FBE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A0E3 RID: 41187 RVA: 0x002A19F8 File Offset: 0x0029FBF8
		public NpcSystemBackground __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023E1 RID: 9185
		// (get) Token: 0x0600A0E4 RID: 41188 RVA: 0x002A1A08 File Offset: 0x0029FC08
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

		// Token: 0x170023E2 RID: 9186
		// (get) Token: 0x0600A0E5 RID: 41189 RVA: 0x002A1A44 File Offset: 0x0029FC44
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

		// Token: 0x0600A0E6 RID: 41190 RVA: 0x002A1A7B File Offset: 0x0029FC7B
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A0E7 RID: 41191 RVA: 0x002A1A8A File Offset: 0x0029FC8A
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170023E3 RID: 9187
		// (get) Token: 0x0600A0E8 RID: 41192 RVA: 0x002A1AA4 File Offset: 0x0029FCA4
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

		// Token: 0x0600A0E9 RID: 41193 RVA: 0x002A1ADB File Offset: 0x0029FCDB
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A0EA RID: 41194 RVA: 0x002A1AEA File Offset: 0x0029FCEA
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170023E4 RID: 9188
		// (get) Token: 0x0600A0EB RID: 41195 RVA: 0x002A1B04 File Offset: 0x0029FD04
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

		// Token: 0x0600A0EC RID: 41196 RVA: 0x002A1B3C File Offset: 0x0029FD3C
		public Span<byte> GetTitleTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A0ED RID: 41197 RVA: 0x002A1B4C File Offset: 0x0029FD4C
		public byte[] GetTitleTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170023E5 RID: 9189
		// (get) Token: 0x0600A0EE RID: 41198 RVA: 0x002A1B64 File Offset: 0x0029FD64
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

		// Token: 0x0600A0EF RID: 41199 RVA: 0x002A1B9C File Offset: 0x0029FD9C
		public Span<byte> GetTitleBgTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A0F0 RID: 41200 RVA: 0x002A1BAC File Offset: 0x0029FDAC
		public byte[] GetTitleBgTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170023E6 RID: 9190
		// (get) Token: 0x0600A0F1 RID: 41201 RVA: 0x002A1BC4 File Offset: 0x0029FDC4
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

		// Token: 0x0600A0F2 RID: 41202 RVA: 0x002A1BFC File Offset: 0x0029FDFC
		public Span<byte> GetTitleSymbolColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A0F3 RID: 41203 RVA: 0x002A1C0C File Offset: 0x0029FE0C
		public byte[] GetTitleSymbolColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170023E7 RID: 9191
		// (get) Token: 0x0600A0F4 RID: 41204 RVA: 0x002A1C24 File Offset: 0x0029FE24
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

		// Token: 0x0600A0F5 RID: 41205 RVA: 0x002A1C5C File Offset: 0x0029FE5C
		public Span<byte> GetCaptionTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A0F6 RID: 41206 RVA: 0x002A1C6C File Offset: 0x0029FE6C
		public byte[] GetCaptionTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170023E8 RID: 9192
		// (get) Token: 0x0600A0F7 RID: 41207 RVA: 0x002A1C84 File Offset: 0x0029FE84
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

		// Token: 0x0600A0F8 RID: 41208 RVA: 0x002A1CBC File Offset: 0x0029FEBC
		public Span<byte> GetCaptionTitleSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A0F9 RID: 41209 RVA: 0x002A1CCC File Offset: 0x0029FECC
		public byte[] GetCaptionTitleSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A0FA RID: 41210 RVA: 0x002A1CE4 File Offset: 0x0029FEE4
		public int CostItemList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170023E9 RID: 9193
		// (get) Token: 0x0600A0FB RID: 41211 RVA: 0x002A1D24 File Offset: 0x0029FF24
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

		// Token: 0x0600A0FC RID: 41212 RVA: 0x002A1D50 File Offset: 0x0029FF50
		public Span<int> GetCostItemListBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600A0FD RID: 41213 RVA: 0x002A1D60 File Offset: 0x0029FF60
		public int[] GetCostItemListArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x170023EA RID: 9194
		// (get) Token: 0x0600A0FE RID: 41214 RVA: 0x002A1D78 File Offset: 0x0029FF78
		public bool IsHelpButtonVisible
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170023EB RID: 9195
		// (get) Token: 0x0600A0FF RID: 41215 RVA: 0x002A1DB8 File Offset: 0x0029FFB8
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

		// Token: 0x0600A100 RID: 41216 RVA: 0x002A1DF8 File Offset: 0x0029FFF8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CostItemListIter()或GetCostItemListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CostItemList()
		{
			NpcSystemBackground npcSystemBackground = this;
			return npcSystemBackground.GetCostItemListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A101 RID: 41217 RVA: 0x002A1E1C File Offset: 0x002A001C
		[NullableContext(1)]
		public readonly IEnumerable<int> CostItemListIter()
		{
			NpcSystemBackground.<CostItemListIter>d__48 <CostItemListIter>d__ = new NpcSystemBackground.<CostItemListIter>d__48(-2);
			<CostItemListIter>d__.<>3__<>4__this = this;
			return <CostItemListIter>d__;
		}

		// Token: 0x04004F51 RID: 20305
		private Table __p;
	}
}
