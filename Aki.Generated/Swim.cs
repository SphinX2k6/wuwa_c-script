using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200110F RID: 4367
	public struct Swim : IFlatbufferObject
	{
		// Token: 0x1700397F RID: 14719
		// (get) Token: 0x0600DC68 RID: 56424 RVA: 0x00328730 File Offset: 0x00326930
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DC69 RID: 56425 RVA: 0x0032873D File Offset: 0x0032693D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DC6A RID: 56426 RVA: 0x00328744 File Offset: 0x00326944
		public static Swim GetRootAsSwim(ByteBuffer _bb)
		{
			return Swim.GetRootAsSwim(_bb, default(Swim));
		}

		// Token: 0x0600DC6B RID: 56427 RVA: 0x00328760 File Offset: 0x00326960
		public static Swim GetRootAsSwim(ByteBuffer _bb, Swim obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DC6C RID: 56428 RVA: 0x0032877D File Offset: 0x0032697D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DC6D RID: 56429 RVA: 0x0032878C File Offset: 0x0032698C
		public Swim __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003980 RID: 14720
		// (get) Token: 0x0600DC6E RID: 56430 RVA: 0x0032879C File Offset: 0x0032699C
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DC6F RID: 56431 RVA: 0x003287D3 File Offset: 0x003269D3
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600DC70 RID: 56432 RVA: 0x003287E2 File Offset: 0x003269E2
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003981 RID: 14721
		// (get) Token: 0x0600DC71 RID: 56433 RVA: 0x003287FC File Offset: 0x003269FC
		public float SprintZOffsetRate
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0.2f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003982 RID: 14722
		// (get) Token: 0x0600DC72 RID: 56434 RVA: 0x0032883C File Offset: 0x00326A3C
		public float SprintZOffsetSpeed
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 100f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400524C RID: 21068
		private Table __p;
	}
}
