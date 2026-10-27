using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F09 RID: 28425
	public struct IRoverRogueCreateRoomReward : IFlatbufferObject
	{
		// Token: 0x1700D35C RID: 54108
		// (get) Token: 0x0603238A RID: 205706 RVA: 0x006C911D File Offset: 0x006C731D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603238B RID: 205707 RVA: 0x006C912A File Offset: 0x006C732A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603238C RID: 205708 RVA: 0x006C9134 File Offset: 0x006C7334
		public static IRoverRogueCreateRoomReward GetRootAsIRoverRogueCreateRoomReward(ByteBuffer _bb)
		{
			return IRoverRogueCreateRoomReward.GetRootAsIRoverRogueCreateRoomReward(_bb, default(IRoverRogueCreateRoomReward));
		}

		// Token: 0x0603238D RID: 205709 RVA: 0x006C9150 File Offset: 0x006C7350
		public static IRoverRogueCreateRoomReward GetRootAsIRoverRogueCreateRoomReward(ByteBuffer _bb, IRoverRogueCreateRoomReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603238E RID: 205710 RVA: 0x006C916D File Offset: 0x006C736D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603238F RID: 205711 RVA: 0x006C917C File Offset: 0x006C737C
		public IRoverRogueCreateRoomReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D35D RID: 54109
		// (get) Token: 0x06032390 RID: 205712 RVA: 0x006C918C File Offset: 0x006C738C
		public int RewardType
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

		// Token: 0x06032391 RID: 205713 RVA: 0x006C91C8 File Offset: 0x006C73C8
		public static Offset<IRoverRogueCreateRoomReward> CreateIRoverRogueCreateRoomReward(FlatBufferBuilder builder, int RewardType = 0)
		{
			builder.StartTable(1);
			IRoverRogueCreateRoomReward.AddRewardType(builder, RewardType);
			return IRoverRogueCreateRoomReward.EndIRoverRogueCreateRoomReward(builder);
		}

		// Token: 0x06032392 RID: 205714 RVA: 0x006C91DE File Offset: 0x006C73DE
		public static void StartIRoverRogueCreateRoomReward(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032393 RID: 205715 RVA: 0x006C91E7 File Offset: 0x006C73E7
		public static void AddRewardType(FlatBufferBuilder builder, int rewardType)
		{
			builder.AddInt(0, rewardType, 0);
		}

		// Token: 0x06032394 RID: 205716 RVA: 0x006C91F2 File Offset: 0x006C73F2
		public static Offset<IRoverRogueCreateRoomReward> EndIRoverRogueCreateRoomReward(FlatBufferBuilder builder)
		{
			return new Offset<IRoverRogueCreateRoomReward>(builder.EndTable());
		}

		// Token: 0x06032395 RID: 205717 RVA: 0x006C9200 File Offset: 0x006C7400
		public IRoverRogueCreateRoomRewardT UnPack()
		{
			IRoverRogueCreateRoomRewardT roverRogueCreateRoomRewardT = new IRoverRogueCreateRoomRewardT();
			this.UnPackTo(roverRogueCreateRoomRewardT);
			return roverRogueCreateRoomRewardT;
		}

		// Token: 0x06032396 RID: 205718 RVA: 0x006C921B File Offset: 0x006C741B
		public void UnPackTo(IRoverRogueCreateRoomRewardT _o)
		{
			_o.RewardType = this.RewardType;
		}

		// Token: 0x06032397 RID: 205719 RVA: 0x006C922C File Offset: 0x006C742C
		public static Offset<IRoverRogueCreateRoomReward> Pack(FlatBufferBuilder builder, IRoverRogueCreateRoomRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoverRogueCreateRoomReward>);
			}
			return IRoverRogueCreateRoomReward.CreateIRoverRogueCreateRoomReward(builder, _o.RewardType);
		}

		// Token: 0x040118F7 RID: 71927
		private Table __p;
	}
}
