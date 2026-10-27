using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B91 RID: 2961
	public struct Communicate : IFlatbufferObject
	{
		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x060057B8 RID: 22456 RVA: 0x001FB549 File Offset: 0x001F9749
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060057B9 RID: 22457 RVA: 0x001FB556 File Offset: 0x001F9756
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060057BA RID: 22458 RVA: 0x001FB560 File Offset: 0x001F9760
		public static Communicate GetRootAsCommunicate(ByteBuffer _bb)
		{
			return Communicate.GetRootAsCommunicate(_bb, default(Communicate));
		}

		// Token: 0x060057BB RID: 22459 RVA: 0x001FB57C File Offset: 0x001F977C
		public static Communicate GetRootAsCommunicate(ByteBuffer _bb, Communicate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060057BC RID: 22460 RVA: 0x001FB599 File Offset: 0x001F9799
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060057BD RID: 22461 RVA: 0x001FB5A8 File Offset: 0x001F97A8
		public Communicate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x060057BE RID: 22462 RVA: 0x001FB5B8 File Offset: 0x001F97B8
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

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x060057BF RID: 22463 RVA: 0x001FB5F4 File Offset: 0x001F97F4
		public string DescText
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

		// Token: 0x060057C0 RID: 22464 RVA: 0x001FB62B File Offset: 0x001F982B
		public Span<byte> GetDescTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060057C1 RID: 22465 RVA: 0x001FB63A File Offset: 0x001F983A
		public byte[] GetDescTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x060057C2 RID: 22466 RVA: 0x001FB654 File Offset: 0x001F9854
		public int Talker
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

		// Token: 0x04004BA0 RID: 19360
		private Table __p;
	}
}
