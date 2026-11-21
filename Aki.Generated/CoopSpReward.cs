using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C87 RID: 3207
	public struct CoopSpReward : IFlatbufferObject
	{
		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06005FE1 RID: 24545 RVA: 0x00220EA1 File Offset: 0x0021F0A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005FE2 RID: 24546 RVA: 0x00220EAE File Offset: 0x0021F0AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005FE3 RID: 24547 RVA: 0x00220EB8 File Offset: 0x0021F0B8
		public static CoopSpReward GetRootAsCoopSpReward(ByteBuffer _bb)
		{
			return CoopSpReward.GetRootAsCoopSpReward(_bb, default(CoopSpReward));
		}

		// Token: 0x06005FE4 RID: 24548 RVA: 0x00220ED4 File Offset: 0x0021F0D4
		public static CoopSpReward GetRootAsCoopSpReward(ByteBuffer _bb, CoopSpReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005FE5 RID: 24549 RVA: 0x00220EF1 File Offset: 0x0021F0F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005FE6 RID: 24550 RVA: 0x00220F00 File Offset: 0x0021F100
		public CoopSpReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06005FE7 RID: 24551 RVA: 0x00220F10 File Offset: 0x0021F110
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

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06005FE8 RID: 24552 RVA: 0x00220F4C File Offset: 0x0021F14C
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

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06005FE9 RID: 24553 RVA: 0x00220F88 File Offset: 0x0021F188
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

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06005FEA RID: 24554 RVA: 0x00220FC4 File Offset: 0x0021F1C4
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

		// Token: 0x06005FEB RID: 24555 RVA: 0x00220FFC File Offset: 0x0021F1FC
		public Span<byte> GetShowTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005FEC RID: 24556 RVA: 0x0022100C File Offset: 0x0021F20C
		public byte[] GetShowTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06005FED RID: 24557 RVA: 0x00221024 File Offset: 0x0021F224
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

		// Token: 0x040051AA RID: 20906
		private Table __p;
	}
}
