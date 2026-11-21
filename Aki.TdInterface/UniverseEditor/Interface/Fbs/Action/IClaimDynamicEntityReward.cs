using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069E4 RID: 27108
	public struct IClaimDynamicEntityReward : IFlatbufferObject
	{
		// Token: 0x1700C76C RID: 51052
		// (get) Token: 0x0602E80E RID: 190478 RVA: 0x0065808E File Offset: 0x0065628E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E80F RID: 190479 RVA: 0x0065809B File Offset: 0x0065629B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E810 RID: 190480 RVA: 0x006580A4 File Offset: 0x006562A4
		public static IClaimDynamicEntityReward GetRootAsIClaimDynamicEntityReward(ByteBuffer _bb)
		{
			return IClaimDynamicEntityReward.GetRootAsIClaimDynamicEntityReward(_bb, default(IClaimDynamicEntityReward));
		}

		// Token: 0x0602E811 RID: 190481 RVA: 0x006580C0 File Offset: 0x006562C0
		public static IClaimDynamicEntityReward GetRootAsIClaimDynamicEntityReward(ByteBuffer _bb, IClaimDynamicEntityReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E812 RID: 190482 RVA: 0x006580DD File Offset: 0x006562DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E813 RID: 190483 RVA: 0x006580EC File Offset: 0x006562EC
		public IClaimDynamicEntityReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C76D RID: 51053
		// (get) Token: 0x0602E814 RID: 190484 RVA: 0x006580FC File Offset: 0x006562FC
		public IClaimDynamicTrafficReward? RewardType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IClaimDynamicTrafficReward?(default(IClaimDynamicTrafficReward).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602E815 RID: 190485 RVA: 0x00658159 File Offset: 0x00656359
		public static Offset<IClaimDynamicEntityReward> CreateIClaimDynamicEntityReward(FlatBufferBuilder builder, Offset<IClaimDynamicTrafficReward> RewardTypeOffset = default(Offset<IClaimDynamicTrafficReward>))
		{
			builder.StartTable(1);
			IClaimDynamicEntityReward.AddRewardType(builder, RewardTypeOffset);
			return IClaimDynamicEntityReward.EndIClaimDynamicEntityReward(builder);
		}

		// Token: 0x0602E816 RID: 190486 RVA: 0x0065816F File Offset: 0x0065636F
		public static void StartIClaimDynamicEntityReward(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E817 RID: 190487 RVA: 0x00658178 File Offset: 0x00656378
		public static void AddRewardType(FlatBufferBuilder builder, Offset<IClaimDynamicTrafficReward> rewardTypeOffset)
		{
			builder.AddOffset(0, rewardTypeOffset.Value, 0);
		}

		// Token: 0x0602E818 RID: 190488 RVA: 0x00658188 File Offset: 0x00656388
		public static Offset<IClaimDynamicEntityReward> EndIClaimDynamicEntityReward(FlatBufferBuilder builder)
		{
			return new Offset<IClaimDynamicEntityReward>(builder.EndTable());
		}

		// Token: 0x0602E819 RID: 190489 RVA: 0x00658198 File Offset: 0x00656398
		public IClaimDynamicEntityRewardT UnPack()
		{
			IClaimDynamicEntityRewardT claimDynamicEntityRewardT = new IClaimDynamicEntityRewardT();
			this.UnPackTo(claimDynamicEntityRewardT);
			return claimDynamicEntityRewardT;
		}

		// Token: 0x0602E81A RID: 190490 RVA: 0x006581B4 File Offset: 0x006563B4
		public void UnPackTo(IClaimDynamicEntityRewardT _o)
		{
			_o.RewardType = ((this.RewardType != null) ? this.RewardType.Value.UnPack() : null);
		}

		// Token: 0x0602E81B RID: 190491 RVA: 0x006581F0 File Offset: 0x006563F0
		public static Offset<IClaimDynamicEntityReward> Pack(FlatBufferBuilder builder, IClaimDynamicEntityRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClaimDynamicEntityReward>);
			}
			Offset<IClaimDynamicTrafficReward> rewardTypeOffset = (_o.RewardType == null) ? default(Offset<IClaimDynamicTrafficReward>) : IClaimDynamicTrafficReward.Pack(builder, _o.RewardType);
			return IClaimDynamicEntityReward.CreateIClaimDynamicEntityReward(builder, rewardTypeOffset);
		}

		// Token: 0x04011756 RID: 71510
		private Table __p;
	}
}
