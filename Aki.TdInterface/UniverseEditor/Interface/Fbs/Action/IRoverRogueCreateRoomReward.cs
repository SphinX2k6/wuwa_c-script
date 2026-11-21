using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007690 RID: 30352
	public struct IRoverRogueCreateRoomReward : IFlatbufferObject
	{
		// Token: 0x1700DEB8 RID: 57016
		// (get) Token: 0x060353E2 RID: 218082 RVA: 0x00725085 File Offset: 0x00723285
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060353E3 RID: 218083 RVA: 0x00725092 File Offset: 0x00723292
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060353E4 RID: 218084 RVA: 0x0072509C File Offset: 0x0072329C
		public static IRoverRogueCreateRoomReward GetRootAsIRoverRogueCreateRoomReward(ByteBuffer _bb)
		{
			return IRoverRogueCreateRoomReward.GetRootAsIRoverRogueCreateRoomReward(_bb, default(IRoverRogueCreateRoomReward));
		}

		// Token: 0x060353E5 RID: 218085 RVA: 0x007250B8 File Offset: 0x007232B8
		public static IRoverRogueCreateRoomReward GetRootAsIRoverRogueCreateRoomReward(ByteBuffer _bb, IRoverRogueCreateRoomReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060353E6 RID: 218086 RVA: 0x007250D5 File Offset: 0x007232D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060353E7 RID: 218087 RVA: 0x007250E4 File Offset: 0x007232E4
		public IRoverRogueCreateRoomReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DEB9 RID: 57017
		// (get) Token: 0x060353E8 RID: 218088 RVA: 0x007250F4 File Offset: 0x007232F4
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

		// Token: 0x060353E9 RID: 218089 RVA: 0x00725130 File Offset: 0x00723330
		public static Offset<IRoverRogueCreateRoomReward> CreateIRoverRogueCreateRoomReward(FlatBufferBuilder builder, int RewardType = 0)
		{
			builder.StartTable(1);
			IRoverRogueCreateRoomReward.AddRewardType(builder, RewardType);
			return IRoverRogueCreateRoomReward.EndIRoverRogueCreateRoomReward(builder);
		}

		// Token: 0x060353EA RID: 218090 RVA: 0x00725146 File Offset: 0x00723346
		public static void StartIRoverRogueCreateRoomReward(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060353EB RID: 218091 RVA: 0x0072514F File Offset: 0x0072334F
		public static void AddRewardType(FlatBufferBuilder builder, int rewardType)
		{
			builder.AddInt(0, rewardType, 0);
		}

		// Token: 0x060353EC RID: 218092 RVA: 0x0072515A File Offset: 0x0072335A
		public static Offset<IRoverRogueCreateRoomReward> EndIRoverRogueCreateRoomReward(FlatBufferBuilder builder)
		{
			return new Offset<IRoverRogueCreateRoomReward>(builder.EndTable());
		}

		// Token: 0x060353ED RID: 218093 RVA: 0x00725168 File Offset: 0x00723368
		public IRoverRogueCreateRoomRewardT UnPack()
		{
			IRoverRogueCreateRoomRewardT roverRogueCreateRoomRewardT = new IRoverRogueCreateRoomRewardT();
			this.UnPackTo(roverRogueCreateRoomRewardT);
			return roverRogueCreateRoomRewardT;
		}

		// Token: 0x060353EE RID: 218094 RVA: 0x00725183 File Offset: 0x00723383
		public void UnPackTo(IRoverRogueCreateRoomRewardT _o)
		{
			_o.RewardType = this.RewardType;
		}

		// Token: 0x060353EF RID: 218095 RVA: 0x00725194 File Offset: 0x00723394
		public static Offset<IRoverRogueCreateRoomReward> Pack(FlatBufferBuilder builder, IRoverRogueCreateRoomRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoverRogueCreateRoomReward>);
			}
			return IRoverRogueCreateRoomReward.CreateIRoverRogueCreateRoomReward(builder, _o.RewardType);
		}

		// Token: 0x0401287F RID: 75903
		private Table __p;
	}
}
