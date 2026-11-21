using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001228 RID: 4648
	public struct State : IFlatbufferObject
	{
		// Token: 0x17003BBF RID: 15295
		// (get) Token: 0x0600E6AE RID: 59054 RVA: 0x0034CA84 File Offset: 0x0034AC84
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E6AF RID: 59055 RVA: 0x0034CA91 File Offset: 0x0034AC91
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E6B0 RID: 59056 RVA: 0x0034CA98 File Offset: 0x0034AC98
		public static State GetRootAsState(ByteBuffer _bb)
		{
			return State.GetRootAsState(_bb, default(State));
		}

		// Token: 0x0600E6B1 RID: 59057 RVA: 0x0034CAB4 File Offset: 0x0034ACB4
		public static State GetRootAsState(ByteBuffer _bb, State obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E6B2 RID: 59058 RVA: 0x0034CAD1 File Offset: 0x0034ACD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E6B3 RID: 59059 RVA: 0x0034CAE0 File Offset: 0x0034ACE0
		public State __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003BC0 RID: 15296
		// (get) Token: 0x0600E6B4 RID: 59060 RVA: 0x0034CAF0 File Offset: 0x0034ACF0
		public int StateId
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

		// Token: 0x17003BC1 RID: 15297
		// (get) Token: 0x0600E6B5 RID: 59061 RVA: 0x0034CB2C File Offset: 0x0034AD2C
		public string StateName
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

		// Token: 0x0600E6B6 RID: 59062 RVA: 0x0034CB63 File Offset: 0x0034AD63
		public Span<byte> GetStateNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E6B7 RID: 59063 RVA: 0x0034CB72 File Offset: 0x0034AD72
		public byte[] GetStateNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BC2 RID: 15298
		// (get) Token: 0x0600E6B8 RID: 59064 RVA: 0x0034CB8C File Offset: 0x0034AD8C
		public string CountryId
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

		// Token: 0x0600E6B9 RID: 59065 RVA: 0x0034CBC3 File Offset: 0x0034ADC3
		public Span<byte> GetCountryIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E6BA RID: 59066 RVA: 0x0034CBD2 File Offset: 0x0034ADD2
		public byte[] GetCountryIdArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003BC3 RID: 15299
		// (get) Token: 0x0600E6BB RID: 59067 RVA: 0x0034CBEC File Offset: 0x0034ADEC
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003BC4 RID: 15300
		// (get) Token: 0x0600E6BC RID: 59068 RVA: 0x0034CC2C File Offset: 0x0034AE2C
		public string WwiseStateName
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

		// Token: 0x0600E6BD RID: 59069 RVA: 0x0034CC64 File Offset: 0x0034AE64
		public Span<byte> GetWwiseStateNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E6BE RID: 59070 RVA: 0x0034CC74 File Offset: 0x0034AE74
		public byte[] GetWwiseStateNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005869 RID: 22633
		private Table __p;
	}
}
