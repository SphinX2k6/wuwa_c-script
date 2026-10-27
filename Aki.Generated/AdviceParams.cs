using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AE2 RID: 2786
	public struct AdviceParams : IFlatbufferObject
	{
		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060045F0 RID: 17904 RVA: 0x001D17B1 File Offset: 0x001CF9B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x001D17BE File Offset: 0x001CF9BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060045F2 RID: 17906 RVA: 0x001D17C8 File Offset: 0x001CF9C8
		public static AdviceParams GetRootAsAdviceParams(ByteBuffer _bb)
		{
			return AdviceParams.GetRootAsAdviceParams(_bb, default(AdviceParams));
		}

		// Token: 0x060045F3 RID: 17907 RVA: 0x001D17E4 File Offset: 0x001CF9E4
		public static AdviceParams GetRootAsAdviceParams(ByteBuffer _bb, AdviceParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060045F4 RID: 17908 RVA: 0x001D1801 File Offset: 0x001CFA01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060045F5 RID: 17909 RVA: 0x001D1810 File Offset: 0x001CFA10
		public AdviceParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060045F6 RID: 17910 RVA: 0x001D1820 File Offset: 0x001CFA20
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

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060045F7 RID: 17911 RVA: 0x001D185C File Offset: 0x001CFA5C
		public string Title
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

		// Token: 0x060045F8 RID: 17912 RVA: 0x001D1893 File Offset: 0x001CFA93
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x001D18A2 File Offset: 0x001CFAA2
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060045FA RID: 17914 RVA: 0x001D18BC File Offset: 0x001CFABC
		public string Content
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

		// Token: 0x060045FB RID: 17915 RVA: 0x001D18F3 File Offset: 0x001CFAF3
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x001D1902 File Offset: 0x001CFB02
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060045FD RID: 17917 RVA: 0x001D191C File Offset: 0x001CFB1C
		public string MotionImg
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

		// Token: 0x060045FE RID: 17918 RVA: 0x001D1954 File Offset: 0x001CFB54
		public Span<byte> GetMotionImgBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x001D1964 File Offset: 0x001CFB64
		public byte[] GetMotionImgArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AC2 RID: 19138
		private Table __p;
	}
}
