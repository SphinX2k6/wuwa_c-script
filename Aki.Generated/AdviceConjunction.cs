using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AE1 RID: 2785
	public struct AdviceConjunction : IFlatbufferObject
	{
		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060045E6 RID: 17894 RVA: 0x001D16A9 File Offset: 0x001CF8A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060045E7 RID: 17895 RVA: 0x001D16B6 File Offset: 0x001CF8B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060045E8 RID: 17896 RVA: 0x001D16C0 File Offset: 0x001CF8C0
		public static AdviceConjunction GetRootAsAdviceConjunction(ByteBuffer _bb)
		{
			return AdviceConjunction.GetRootAsAdviceConjunction(_bb, default(AdviceConjunction));
		}

		// Token: 0x060045E9 RID: 17897 RVA: 0x001D16DC File Offset: 0x001CF8DC
		public static AdviceConjunction GetRootAsAdviceConjunction(ByteBuffer _bb, AdviceConjunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x001D16F9 File Offset: 0x001CF8F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060045EB RID: 17899 RVA: 0x001D1708 File Offset: 0x001CF908
		public AdviceConjunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060045EC RID: 17900 RVA: 0x001D1718 File Offset: 0x001CF918
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

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060045ED RID: 17901 RVA: 0x001D1754 File Offset: 0x001CF954
		public string Text
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

		// Token: 0x060045EE RID: 17902 RVA: 0x001D178B File Offset: 0x001CF98B
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060045EF RID: 17903 RVA: 0x001D179A File Offset: 0x001CF99A
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AC1 RID: 19137
		private Table __p;
	}
}
