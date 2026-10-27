using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DE2 RID: 3554
	public struct LordGymFilterType : IFlatbufferObject
	{
		// Token: 0x17001DAA RID: 7594
		// (get) Token: 0x06009040 RID: 36928 RVA: 0x0027CA0D File Offset: 0x0027AC0D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009041 RID: 36929 RVA: 0x0027CA1A File Offset: 0x0027AC1A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009042 RID: 36930 RVA: 0x0027CA24 File Offset: 0x0027AC24
		public static LordGymFilterType GetRootAsLordGymFilterType(ByteBuffer _bb)
		{
			return LordGymFilterType.GetRootAsLordGymFilterType(_bb, default(LordGymFilterType));
		}

		// Token: 0x06009043 RID: 36931 RVA: 0x0027CA40 File Offset: 0x0027AC40
		public static LordGymFilterType GetRootAsLordGymFilterType(ByteBuffer _bb, LordGymFilterType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009044 RID: 36932 RVA: 0x0027CA5D File Offset: 0x0027AC5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009045 RID: 36933 RVA: 0x0027CA6C File Offset: 0x0027AC6C
		public LordGymFilterType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DAB RID: 7595
		// (get) Token: 0x06009046 RID: 36934 RVA: 0x0027CA7C File Offset: 0x0027AC7C
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

		// Token: 0x17001DAC RID: 7596
		// (get) Token: 0x06009047 RID: 36935 RVA: 0x0027CAB8 File Offset: 0x0027ACB8
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

		// Token: 0x06009048 RID: 36936 RVA: 0x0027CAEF File Offset: 0x0027ACEF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009049 RID: 36937 RVA: 0x0027CAFE File Offset: 0x0027ACFE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x0600904A RID: 36938 RVA: 0x0027CB18 File Offset: 0x0027AD18
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(8);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004E7E RID: 20094
		private Table __p;
	}
}
