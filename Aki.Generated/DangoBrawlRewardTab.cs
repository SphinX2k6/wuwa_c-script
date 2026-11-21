using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CB0 RID: 3248
	public struct DangoBrawlRewardTab : IFlatbufferObject
	{
		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x060064E4 RID: 25828 RVA: 0x0022BEED File Offset: 0x0022A0ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060064E5 RID: 25829 RVA: 0x0022BEFA File Offset: 0x0022A0FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060064E6 RID: 25830 RVA: 0x0022BF04 File Offset: 0x0022A104
		public static DangoBrawlRewardTab GetRootAsDangoBrawlRewardTab(ByteBuffer _bb)
		{
			return DangoBrawlRewardTab.GetRootAsDangoBrawlRewardTab(_bb, default(DangoBrawlRewardTab));
		}

		// Token: 0x060064E7 RID: 25831 RVA: 0x0022BF20 File Offset: 0x0022A120
		public static DangoBrawlRewardTab GetRootAsDangoBrawlRewardTab(ByteBuffer _bb, DangoBrawlRewardTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060064E8 RID: 25832 RVA: 0x0022BF3D File Offset: 0x0022A13D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060064E9 RID: 25833 RVA: 0x0022BF4C File Offset: 0x0022A14C
		public DangoBrawlRewardTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x060064EA RID: 25834 RVA: 0x0022BF5C File Offset: 0x0022A15C
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

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x060064EB RID: 25835 RVA: 0x0022BF98 File Offset: 0x0022A198
		public int ActivityId
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

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x060064EC RID: 25836 RVA: 0x0022BFD4 File Offset: 0x0022A1D4
		public string Name
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

		// Token: 0x060064ED RID: 25837 RVA: 0x0022C00B File Offset: 0x0022A20B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060064EE RID: 25838 RVA: 0x0022C01A File Offset: 0x0022A21A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040051DA RID: 20954
		private Table __p;
	}
}
