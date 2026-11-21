using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ED8 RID: 3800
	public struct Mapping : IFlatbufferObject
	{
		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x060097CC RID: 38860 RVA: 0x0029E145 File Offset: 0x0029C345
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060097CD RID: 38861 RVA: 0x0029E152 File Offset: 0x0029C352
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060097CE RID: 38862 RVA: 0x0029E15C File Offset: 0x0029C35C
		public static Mapping GetRootAsMapping(ByteBuffer _bb)
		{
			return Mapping.GetRootAsMapping(_bb, default(Mapping));
		}

		// Token: 0x060097CF RID: 38863 RVA: 0x0029E178 File Offset: 0x0029C378
		public static Mapping GetRootAsMapping(ByteBuffer _bb, Mapping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060097D0 RID: 38864 RVA: 0x0029E195 File Offset: 0x0029C395
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060097D1 RID: 38865 RVA: 0x0029E1A4 File Offset: 0x0029C3A4
		public Mapping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001EA8 RID: 7848
		// (get) Token: 0x060097D2 RID: 38866 RVA: 0x0029E1B4 File Offset: 0x0029C3B4
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

		// Token: 0x17001EA9 RID: 7849
		// (get) Token: 0x060097D3 RID: 38867 RVA: 0x0029E1F0 File Offset: 0x0029C3F0
		public string ExcelName
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

		// Token: 0x060097D4 RID: 38868 RVA: 0x0029E227 File Offset: 0x0029C427
		public Span<byte> GetExcelNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060097D5 RID: 38869 RVA: 0x0029E236 File Offset: 0x0029C436
		public byte[] GetExcelNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EAA RID: 7850
		// (get) Token: 0x060097D6 RID: 38870 RVA: 0x0029E250 File Offset: 0x0029C450
		public string SheetName
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

		// Token: 0x060097D7 RID: 38871 RVA: 0x0029E287 File Offset: 0x0029C487
		public Span<byte> GetSheetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060097D8 RID: 38872 RVA: 0x0029E296 File Offset: 0x0029C496
		public byte[] GetSheetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EAB RID: 7851
		// (get) Token: 0x060097D9 RID: 38873 RVA: 0x0029E2B0 File Offset: 0x0029C4B0
		public string FieldName
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

		// Token: 0x060097DA RID: 38874 RVA: 0x0029E2E8 File Offset: 0x0029C4E8
		public Span<byte> GetFieldNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060097DB RID: 38875 RVA: 0x0029E2F8 File Offset: 0x0029C4F8
		public byte[] GetFieldNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EAC RID: 7852
		// (get) Token: 0x060097DC RID: 38876 RVA: 0x0029E310 File Offset: 0x0029C510
		public int Value
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001EAD RID: 7853
		// (get) Token: 0x060097DD RID: 38877 RVA: 0x0029E350 File Offset: 0x0029C550
		public string Comment
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

		// Token: 0x060097DE RID: 38878 RVA: 0x0029E388 File Offset: 0x0029C588
		public Span<byte> GetCommentBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060097DF RID: 38879 RVA: 0x0029E398 File Offset: 0x0029C598
		public byte[] GetCommentArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EAE RID: 7854
		// (get) Token: 0x060097E0 RID: 38880 RVA: 0x0029E3B0 File Offset: 0x0029C5B0
		public string Icon
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

		// Token: 0x060097E1 RID: 38881 RVA: 0x0029E3E8 File Offset: 0x0029C5E8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060097E2 RID: 38882 RVA: 0x0029E3F8 File Offset: 0x0029C5F8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EAF RID: 7855
		// (get) Token: 0x060097E3 RID: 38883 RVA: 0x0029E410 File Offset: 0x0029C610
		public string DetectionDropDownIcon
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

		// Token: 0x060097E4 RID: 38884 RVA: 0x0029E448 File Offset: 0x0029C648
		public Span<byte> GetDetectionDropDownIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060097E5 RID: 38885 RVA: 0x0029E458 File Offset: 0x0029C658
		public byte[] GetDetectionDropDownIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04005476 RID: 21622
		private Table __p;
	}
}
