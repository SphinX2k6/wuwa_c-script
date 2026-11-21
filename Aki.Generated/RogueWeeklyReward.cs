using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001116 RID: 4374
	public struct RogueWeeklyReward : IFlatbufferObject
	{
		// Token: 0x1700321D RID: 12829
		// (get) Token: 0x0600CCA7 RID: 52391 RVA: 0x0031160E File Offset: 0x0030F80E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CCA8 RID: 52392 RVA: 0x0031161B File Offset: 0x0030F81B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CCA9 RID: 52393 RVA: 0x00311624 File Offset: 0x0030F824
		public static RogueWeeklyReward GetRootAsRogueWeeklyReward(ByteBuffer _bb)
		{
			return RogueWeeklyReward.GetRootAsRogueWeeklyReward(_bb, default(RogueWeeklyReward));
		}

		// Token: 0x0600CCAA RID: 52394 RVA: 0x00311640 File Offset: 0x0030F840
		public static RogueWeeklyReward GetRootAsRogueWeeklyReward(ByteBuffer _bb, RogueWeeklyReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CCAB RID: 52395 RVA: 0x0031165D File Offset: 0x0030F85D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CCAC RID: 52396 RVA: 0x0031166C File Offset: 0x0030F86C
		public RogueWeeklyReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700321E RID: 12830
		// (get) Token: 0x0600CCAD RID: 52397 RVA: 0x0031167C File Offset: 0x0030F87C
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

		// Token: 0x1700321F RID: 12831
		// (get) Token: 0x0600CCAE RID: 52398 RVA: 0x003116B8 File Offset: 0x0030F8B8
		public int CycleId
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

		// Token: 0x17003220 RID: 12832
		// (get) Token: 0x0600CCAF RID: 52399 RVA: 0x003116F4 File Offset: 0x0030F8F4
		public string TargetName
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

		// Token: 0x0600CCB0 RID: 52400 RVA: 0x0031172B File Offset: 0x0030F92B
		public Span<byte> GetTargetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CCB1 RID: 52401 RVA: 0x0031173A File Offset: 0x0030F93A
		public byte[] GetTargetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003221 RID: 12833
		// (get) Token: 0x0600CCB2 RID: 52402 RVA: 0x00311754 File Offset: 0x0030F954
		public int TargetReward
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

		// Token: 0x17003222 RID: 12834
		// (get) Token: 0x0600CCB3 RID: 52403 RVA: 0x00311794 File Offset: 0x0030F994
		public int Score
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

		// Token: 0x0400570E RID: 22286
		private Table __p;
	}
}
