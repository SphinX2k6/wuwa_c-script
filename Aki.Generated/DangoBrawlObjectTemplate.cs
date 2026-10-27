using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BC7 RID: 3015
	public struct DangoBrawlObjectTemplate : IFlatbufferObject
	{
		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06005E33 RID: 24115 RVA: 0x0020AB89 File Offset: 0x00208D89
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005E34 RID: 24116 RVA: 0x0020AB96 File Offset: 0x00208D96
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005E35 RID: 24117 RVA: 0x0020ABA0 File Offset: 0x00208DA0
		public static DangoBrawlObjectTemplate GetRootAsDangoBrawlObjectTemplate(ByteBuffer _bb)
		{
			return DangoBrawlObjectTemplate.GetRootAsDangoBrawlObjectTemplate(_bb, default(DangoBrawlObjectTemplate));
		}

		// Token: 0x06005E36 RID: 24118 RVA: 0x0020ABBC File Offset: 0x00208DBC
		public static DangoBrawlObjectTemplate GetRootAsDangoBrawlObjectTemplate(ByteBuffer _bb, DangoBrawlObjectTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005E37 RID: 24119 RVA: 0x0020ABD9 File Offset: 0x00208DD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005E38 RID: 24120 RVA: 0x0020ABE8 File Offset: 0x00208DE8
		public DangoBrawlObjectTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06005E39 RID: 24121 RVA: 0x0020ABF8 File Offset: 0x00208DF8
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

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06005E3A RID: 24122 RVA: 0x0020AC34 File Offset: 0x00208E34
		public string SubType
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

		// Token: 0x06005E3B RID: 24123 RVA: 0x0020AC6B File Offset: 0x00208E6B
		public Span<byte> GetSubTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005E3C RID: 24124 RVA: 0x0020AC7A File Offset: 0x00208E7A
		public byte[] GetSubTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06005E3D RID: 24125 RVA: 0x0020AC94 File Offset: 0x00208E94
		public int DataId
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

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06005E3E RID: 24126 RVA: 0x0020ACD0 File Offset: 0x00208ED0
		public string LinkCenterOffset
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

		// Token: 0x06005E3F RID: 24127 RVA: 0x0020AD08 File Offset: 0x00208F08
		public Span<byte> GetLinkCenterOffsetBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005E40 RID: 24128 RVA: 0x0020AD18 File Offset: 0x00208F18
		public byte[] GetLinkCenterOffsetArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06005E41 RID: 24129 RVA: 0x0020AD30 File Offset: 0x00208F30
		public string ShapeCells
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

		// Token: 0x06005E42 RID: 24130 RVA: 0x0020AD68 File Offset: 0x00208F68
		public Span<byte> GetShapeCellsBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005E43 RID: 24131 RVA: 0x0020AD78 File Offset: 0x00208F78
		public byte[] GetShapeCellsArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06005E44 RID: 24132 RVA: 0x0020AD90 File Offset: 0x00208F90
		public string StarCells
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

		// Token: 0x06005E45 RID: 24133 RVA: 0x0020ADC8 File Offset: 0x00208FC8
		public Span<byte> GetStarCellsBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005E46 RID: 24134 RVA: 0x0020ADD8 File Offset: 0x00208FD8
		public byte[] GetStarCellsArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004BF0 RID: 19440
		private Table __p;
	}
}
