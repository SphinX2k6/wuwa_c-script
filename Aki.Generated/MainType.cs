using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ECD RID: 3789
	public struct MainType : IFlatbufferObject
	{
		// Token: 0x17001E2A RID: 7722
		// (get) Token: 0x060096A6 RID: 38566 RVA: 0x0029B568 File Offset: 0x00299768
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060096A7 RID: 38567 RVA: 0x0029B575 File Offset: 0x00299775
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060096A8 RID: 38568 RVA: 0x0029B57C File Offset: 0x0029977C
		public static MainType GetRootAsMainType(ByteBuffer _bb)
		{
			return MainType.GetRootAsMainType(_bb, default(MainType));
		}

		// Token: 0x060096A9 RID: 38569 RVA: 0x0029B598 File Offset: 0x00299798
		public static MainType GetRootAsMainType(ByteBuffer _bb, MainType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060096AA RID: 38570 RVA: 0x0029B5B5 File Offset: 0x002997B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060096AB RID: 38571 RVA: 0x0029B5C4 File Offset: 0x002997C4
		public MainType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E2B RID: 7723
		// (get) Token: 0x060096AC RID: 38572 RVA: 0x0029B5D4 File Offset: 0x002997D4
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

		// Token: 0x17001E2C RID: 7724
		// (get) Token: 0x060096AD RID: 38573 RVA: 0x0029B610 File Offset: 0x00299810
		public int MainSort
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

		// Token: 0x17001E2D RID: 7725
		// (get) Token: 0x060096AE RID: 38574 RVA: 0x0029B64C File Offset: 0x0029984C
		public string MainName
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

		// Token: 0x060096AF RID: 38575 RVA: 0x0029B683 File Offset: 0x00299883
		public Span<byte> GetMainNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060096B0 RID: 38576 RVA: 0x0029B692 File Offset: 0x00299892
		public byte[] GetMainNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E2E RID: 7726
		// (get) Token: 0x060096B1 RID: 38577 RVA: 0x0029B6AC File Offset: 0x002998AC
		public string MainIcon
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

		// Token: 0x060096B2 RID: 38578 RVA: 0x0029B6E4 File Offset: 0x002998E4
		public Span<byte> GetMainIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060096B3 RID: 38579 RVA: 0x0029B6F4 File Offset: 0x002998F4
		public byte[] GetMainIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E2F RID: 7727
		// (get) Token: 0x060096B4 RID: 38580 RVA: 0x0029B70C File Offset: 0x0029990C
		public int TabPanelType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E30 RID: 7728
		// (get) Token: 0x060096B5 RID: 38581 RVA: 0x0029B74C File Offset: 0x0029994C
		public int PcTabPanelType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E31 RID: 7729
		// (get) Token: 0x060096B6 RID: 38582 RVA: 0x0029B78C File Offset: 0x0029998C
		public int XboxTabPanelType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E32 RID: 7730
		// (get) Token: 0x060096B7 RID: 38583 RVA: 0x0029B7CC File Offset: 0x002999CC
		public int PsTabPanelType
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

		// Token: 0x17001E33 RID: 7731
		// (get) Token: 0x060096B8 RID: 38584 RVA: 0x0029B80C File Offset: 0x00299A0C
		public string MainSmallIcon
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060096B9 RID: 38585 RVA: 0x0029B844 File Offset: 0x00299A44
		public Span<byte> GetMainSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060096BA RID: 38586 RVA: 0x0029B854 File Offset: 0x00299A54
		public byte[] GetMainSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x04005469 RID: 21609
		private Table __p;
	}
}
