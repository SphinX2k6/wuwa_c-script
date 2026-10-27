using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BA5 RID: 2981
	public struct CoopSpReward : IFlatbufferObject
	{
		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06005A08 RID: 23048 RVA: 0x0020115D File Offset: 0x001FF35D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005A09 RID: 23049 RVA: 0x0020116A File Offset: 0x001FF36A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005A0A RID: 23050 RVA: 0x00201174 File Offset: 0x001FF374
		public static CoopSpReward GetRootAsCoopSpReward(ByteBuffer _bb)
		{
			return CoopSpReward.GetRootAsCoopSpReward(_bb, default(CoopSpReward));
		}

		// Token: 0x06005A0B RID: 23051 RVA: 0x00201190 File Offset: 0x001FF390
		public static CoopSpReward GetRootAsCoopSpReward(ByteBuffer _bb, CoopSpReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005A0C RID: 23052 RVA: 0x002011AD File Offset: 0x001FF3AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005A0D RID: 23053 RVA: 0x002011BC File Offset: 0x001FF3BC
		public CoopSpReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06005A0E RID: 23054 RVA: 0x002011CC File Offset: 0x001FF3CC
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

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06005A0F RID: 23055 RVA: 0x00201208 File Offset: 0x001FF408
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

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06005A10 RID: 23056 RVA: 0x00201244 File Offset: 0x001FF444
		public int Reward
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

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06005A11 RID: 23057 RVA: 0x00201280 File Offset: 0x001FF480
		public string ShowText
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

		// Token: 0x06005A12 RID: 23058 RVA: 0x002012B8 File Offset: 0x001FF4B8
		public Span<byte> GetShowTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005A13 RID: 23059 RVA: 0x002012C8 File Offset: 0x001FF4C8
		public byte[] GetShowTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06005A14 RID: 23060 RVA: 0x002012E0 File Offset: 0x001FF4E0
		public int RoleLevelSum
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004BC8 RID: 19400
		private Table __p;
	}
}
