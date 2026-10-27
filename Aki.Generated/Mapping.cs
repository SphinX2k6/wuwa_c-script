using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DF3 RID: 3571
	public struct Mapping : IFlatbufferObject
	{
		// Token: 0x17001E43 RID: 7747
		// (get) Token: 0x060091B0 RID: 37296 RVA: 0x0027FFD9 File Offset: 0x0027E1D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060091B1 RID: 37297 RVA: 0x0027FFE6 File Offset: 0x0027E1E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060091B2 RID: 37298 RVA: 0x0027FFF0 File Offset: 0x0027E1F0
		public static Mapping GetRootAsMapping(ByteBuffer _bb)
		{
			return Mapping.GetRootAsMapping(_bb, default(Mapping));
		}

		// Token: 0x060091B3 RID: 37299 RVA: 0x0028000C File Offset: 0x0027E20C
		public static Mapping GetRootAsMapping(ByteBuffer _bb, Mapping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060091B4 RID: 37300 RVA: 0x00280029 File Offset: 0x0027E229
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060091B5 RID: 37301 RVA: 0x00280038 File Offset: 0x0027E238
		public Mapping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E44 RID: 7748
		// (get) Token: 0x060091B6 RID: 37302 RVA: 0x00280048 File Offset: 0x0027E248
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

		// Token: 0x17001E45 RID: 7749
		// (get) Token: 0x060091B7 RID: 37303 RVA: 0x00280084 File Offset: 0x0027E284
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

		// Token: 0x060091B8 RID: 37304 RVA: 0x002800BB File Offset: 0x0027E2BB
		public Span<byte> GetExcelNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060091B9 RID: 37305 RVA: 0x002800CA File Offset: 0x0027E2CA
		public byte[] GetExcelNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E46 RID: 7750
		// (get) Token: 0x060091BA RID: 37306 RVA: 0x002800E4 File Offset: 0x0027E2E4
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

		// Token: 0x060091BB RID: 37307 RVA: 0x0028011B File Offset: 0x0027E31B
		public Span<byte> GetSheetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060091BC RID: 37308 RVA: 0x0028012A File Offset: 0x0027E32A
		public byte[] GetSheetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E47 RID: 7751
		// (get) Token: 0x060091BD RID: 37309 RVA: 0x00280144 File Offset: 0x0027E344
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

		// Token: 0x060091BE RID: 37310 RVA: 0x0028017C File Offset: 0x0027E37C
		public Span<byte> GetFieldNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060091BF RID: 37311 RVA: 0x0028018C File Offset: 0x0027E38C
		public byte[] GetFieldNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E48 RID: 7752
		// (get) Token: 0x060091C0 RID: 37312 RVA: 0x002801A4 File Offset: 0x0027E3A4
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

		// Token: 0x17001E49 RID: 7753
		// (get) Token: 0x060091C1 RID: 37313 RVA: 0x002801E4 File Offset: 0x0027E3E4
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

		// Token: 0x060091C2 RID: 37314 RVA: 0x0028021C File Offset: 0x0027E41C
		public Span<byte> GetCommentBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060091C3 RID: 37315 RVA: 0x0028022C File Offset: 0x0027E42C
		public byte[] GetCommentArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E4A RID: 7754
		// (get) Token: 0x060091C4 RID: 37316 RVA: 0x00280244 File Offset: 0x0027E444
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

		// Token: 0x060091C5 RID: 37317 RVA: 0x0028027C File Offset: 0x0027E47C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060091C6 RID: 37318 RVA: 0x0028028C File Offset: 0x0027E48C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E4B RID: 7755
		// (get) Token: 0x060091C7 RID: 37319 RVA: 0x002802A4 File Offset: 0x0027E4A4
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

		// Token: 0x060091C8 RID: 37320 RVA: 0x002802DC File Offset: 0x0027E4DC
		public Span<byte> GetDetectionDropDownIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060091C9 RID: 37321 RVA: 0x002802EC File Offset: 0x0027E4EC
		public byte[] GetDetectionDropDownIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E91 RID: 20113
		private Table __p;
	}
}
