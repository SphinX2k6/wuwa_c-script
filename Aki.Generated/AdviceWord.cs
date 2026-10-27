using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AE4 RID: 2788
	public struct AdviceWord : IFlatbufferObject
	{
		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600460A RID: 17930 RVA: 0x001D1A81 File Offset: 0x001CFC81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x001D1A8E File Offset: 0x001CFC8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x001D1A98 File Offset: 0x001CFC98
		public static AdviceWord GetRootAsAdviceWord(ByteBuffer _bb)
		{
			return AdviceWord.GetRootAsAdviceWord(_bb, default(AdviceWord));
		}

		// Token: 0x0600460D RID: 17933 RVA: 0x001D1AB4 File Offset: 0x001CFCB4
		public static AdviceWord GetRootAsAdviceWord(ByteBuffer _bb, AdviceWord obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600460E RID: 17934 RVA: 0x001D1AD1 File Offset: 0x001CFCD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x001D1AE0 File Offset: 0x001CFCE0
		public AdviceWord __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06004610 RID: 17936 RVA: 0x001D1AF0 File Offset: 0x001CFCF0
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

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06004611 RID: 17937 RVA: 0x001D1B2C File Offset: 0x001CFD2C
		public int Type
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

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06004612 RID: 17938 RVA: 0x001D1B68 File Offset: 0x001CFD68
		public string Text
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

		// Token: 0x06004613 RID: 17939 RVA: 0x001D1B9F File Offset: 0x001CFD9F
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004614 RID: 17940 RVA: 0x001D1BAE File Offset: 0x001CFDAE
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AC4 RID: 19140
		private Table __p;
	}
}
