using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001183 RID: 4483
	public struct RoverRogueRoomReward : IFlatbufferObject
	{
		// Token: 0x170035D8 RID: 13784
		// (get) Token: 0x0600D719 RID: 55065 RVA: 0x00328B98 File Offset: 0x00326D98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D71A RID: 55066 RVA: 0x00328BA5 File Offset: 0x00326DA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D71B RID: 55067 RVA: 0x00328BAC File Offset: 0x00326DAC
		public static RoverRogueRoomReward GetRootAsRoverRogueRoomReward(ByteBuffer _bb)
		{
			return RoverRogueRoomReward.GetRootAsRoverRogueRoomReward(_bb, default(RoverRogueRoomReward));
		}

		// Token: 0x0600D71C RID: 55068 RVA: 0x00328BC8 File Offset: 0x00326DC8
		public static RoverRogueRoomReward GetRootAsRoverRogueRoomReward(ByteBuffer _bb, RoverRogueRoomReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D71D RID: 55069 RVA: 0x00328BE5 File Offset: 0x00326DE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D71E RID: 55070 RVA: 0x00328BF4 File Offset: 0x00326DF4
		public RoverRogueRoomReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035D9 RID: 13785
		// (get) Token: 0x0600D71F RID: 55071 RVA: 0x00328C04 File Offset: 0x00326E04
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

		// Token: 0x170035DA RID: 13786
		// (get) Token: 0x0600D720 RID: 55072 RVA: 0x00328C40 File Offset: 0x00326E40
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

		// Token: 0x170035DB RID: 13787
		// (get) Token: 0x0600D721 RID: 55073 RVA: 0x00328C7C File Offset: 0x00326E7C
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

		// Token: 0x04005794 RID: 22420
		private Table __p;
	}
}
