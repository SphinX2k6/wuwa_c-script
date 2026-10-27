using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EAD RID: 3757
	public struct Pay : IFlatbufferObject
	{
		// Token: 0x1700249C RID: 9372
		// (get) Token: 0x0600A2CE RID: 41678 RVA: 0x002A5FF7 File Offset: 0x002A41F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A2CF RID: 41679 RVA: 0x002A6004 File Offset: 0x002A4204
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A2D0 RID: 41680 RVA: 0x002A600C File Offset: 0x002A420C
		public static Pay GetRootAsPay(ByteBuffer _bb)
		{
			return Pay.GetRootAsPay(_bb, default(Pay));
		}

		// Token: 0x0600A2D1 RID: 41681 RVA: 0x002A6028 File Offset: 0x002A4228
		public static Pay GetRootAsPay(ByteBuffer _bb, Pay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A2D2 RID: 41682 RVA: 0x002A6045 File Offset: 0x002A4245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A2D3 RID: 41683 RVA: 0x002A6054 File Offset: 0x002A4254
		public Pay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700249D RID: 9373
		// (get) Token: 0x0600A2D4 RID: 41684 RVA: 0x002A6064 File Offset: 0x002A4264
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

		// Token: 0x1700249E RID: 9374
		// (get) Token: 0x0600A2D5 RID: 41685 RVA: 0x002A60A0 File Offset: 0x002A42A0
		public int PayId
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

		// Token: 0x1700249F RID: 9375
		// (get) Token: 0x0600A2D6 RID: 41686 RVA: 0x002A60DC File Offset: 0x002A42DC
		public string Region
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

		// Token: 0x0600A2D7 RID: 41687 RVA: 0x002A6113 File Offset: 0x002A4313
		public Span<byte> GetRegionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A2D8 RID: 41688 RVA: 0x002A6122 File Offset: 0x002A4322
		public byte[] GetRegionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170024A0 RID: 9376
		// (get) Token: 0x0600A2D9 RID: 41689 RVA: 0x002A613C File Offset: 0x002A433C
		public float Amount
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170024A1 RID: 9377
		// (get) Token: 0x0600A2DA RID: 41690 RVA: 0x002A6180 File Offset: 0x002A4380
		public float GlobalAmount
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170024A2 RID: 9378
		// (get) Token: 0x0600A2DB RID: 41691 RVA: 0x002A61C4 File Offset: 0x002A43C4
		public string ProductId
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

		// Token: 0x0600A2DC RID: 41692 RVA: 0x002A61FC File Offset: 0x002A43FC
		public Span<byte> GetProductIdBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A2DD RID: 41693 RVA: 0x002A620C File Offset: 0x002A440C
		public byte[] GetProductIdArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170024A3 RID: 9379
		// (get) Token: 0x0600A2DE RID: 41694 RVA: 0x002A6224 File Offset: 0x002A4424
		public string CurrencyType
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

		// Token: 0x0600A2DF RID: 41695 RVA: 0x002A625C File Offset: 0x002A445C
		public Span<byte> GetCurrencyTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A2E0 RID: 41696 RVA: 0x002A626C File Offset: 0x002A446C
		public byte[] GetCurrencyTypeArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F63 RID: 20323
		private Table __p;
	}
}
