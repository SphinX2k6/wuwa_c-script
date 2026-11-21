using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EC7 RID: 3783
	public struct LordGymFilterType : IFlatbufferObject
	{
		// Token: 0x17001E0E RID: 7694
		// (get) Token: 0x0600965C RID: 38492 RVA: 0x0029AC8E File Offset: 0x00298E8E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600965D RID: 38493 RVA: 0x0029AC9B File Offset: 0x00298E9B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600965E RID: 38494 RVA: 0x0029ACA4 File Offset: 0x00298EA4
		public static LordGymFilterType GetRootAsLordGymFilterType(ByteBuffer _bb)
		{
			return LordGymFilterType.GetRootAsLordGymFilterType(_bb, default(LordGymFilterType));
		}

		// Token: 0x0600965F RID: 38495 RVA: 0x0029ACC0 File Offset: 0x00298EC0
		public static LordGymFilterType GetRootAsLordGymFilterType(ByteBuffer _bb, LordGymFilterType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009660 RID: 38496 RVA: 0x0029ACDD File Offset: 0x00298EDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009661 RID: 38497 RVA: 0x0029ACEC File Offset: 0x00298EEC
		public LordGymFilterType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E0F RID: 7695
		// (get) Token: 0x06009662 RID: 38498 RVA: 0x0029ACFC File Offset: 0x00298EFC
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

		// Token: 0x17001E10 RID: 7696
		// (get) Token: 0x06009663 RID: 38499 RVA: 0x0029AD38 File Offset: 0x00298F38
		public string Name
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

		// Token: 0x06009664 RID: 38500 RVA: 0x0029AD6F File Offset: 0x00298F6F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009665 RID: 38501 RVA: 0x0029AD7E File Offset: 0x00298F7E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E11 RID: 7697
		// (get) Token: 0x06009666 RID: 38502 RVA: 0x0029AD98 File Offset: 0x00298F98
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(8);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005463 RID: 21603
		private Table __p;
	}
}
