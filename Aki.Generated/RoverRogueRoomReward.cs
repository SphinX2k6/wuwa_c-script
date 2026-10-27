using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001088 RID: 4232
	public struct RoverRogueRoomReward : IFlatbufferObject
	{
		// Token: 0x170034CB RID: 13515
		// (get) Token: 0x0600CF46 RID: 53062 RVA: 0x00309583 File Offset: 0x00307783
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CF47 RID: 53063 RVA: 0x00309590 File Offset: 0x00307790
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CF48 RID: 53064 RVA: 0x00309598 File Offset: 0x00307798
		public static RoverRogueRoomReward GetRootAsRoverRogueRoomReward(ByteBuffer _bb)
		{
			return RoverRogueRoomReward.GetRootAsRoverRogueRoomReward(_bb, default(RoverRogueRoomReward));
		}

		// Token: 0x0600CF49 RID: 53065 RVA: 0x003095B4 File Offset: 0x003077B4
		public static RoverRogueRoomReward GetRootAsRoverRogueRoomReward(ByteBuffer _bb, RoverRogueRoomReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CF4A RID: 53066 RVA: 0x003095D1 File Offset: 0x003077D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CF4B RID: 53067 RVA: 0x003095E0 File Offset: 0x003077E0
		public RoverRogueRoomReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034CC RID: 13516
		// (get) Token: 0x0600CF4C RID: 53068 RVA: 0x003095F0 File Offset: 0x003077F0
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

		// Token: 0x170034CD RID: 13517
		// (get) Token: 0x0600CF4D RID: 53069 RVA: 0x0030962C File Offset: 0x0030782C
		public int ChaosEntityId
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

		// Token: 0x170034CE RID: 13518
		// (get) Token: 0x0600CF4E RID: 53070 RVA: 0x00309668 File Offset: 0x00307868
		public int ChaosEntityBallId
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

		// Token: 0x04005195 RID: 20885
		private Table __p;
	}
}
