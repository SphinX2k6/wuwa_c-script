using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006373 RID: 25459
	public struct IClaimDynamicEntityReward : IFlatbufferObject
	{
		// Token: 0x1700BDE4 RID: 48612
		// (get) Token: 0x0602C0A4 RID: 180388 RVA: 0x0060CF3A File Offset: 0x0060B13A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C0A5 RID: 180389 RVA: 0x0060CF47 File Offset: 0x0060B147
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C0A6 RID: 180390 RVA: 0x0060CF50 File Offset: 0x0060B150
		public static IClaimDynamicEntityReward GetRootAsIClaimDynamicEntityReward(ByteBuffer _bb)
		{
			return IClaimDynamicEntityReward.GetRootAsIClaimDynamicEntityReward(_bb, default(IClaimDynamicEntityReward));
		}

		// Token: 0x0602C0A7 RID: 180391 RVA: 0x0060CF6C File Offset: 0x0060B16C
		public static IClaimDynamicEntityReward GetRootAsIClaimDynamicEntityReward(ByteBuffer _bb, IClaimDynamicEntityReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C0A8 RID: 180392 RVA: 0x0060CF89 File Offset: 0x0060B189
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C0A9 RID: 180393 RVA: 0x0060CF98 File Offset: 0x0060B198
		public IClaimDynamicEntityReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDE5 RID: 48613
		// (get) Token: 0x0602C0AA RID: 180394 RVA: 0x0060CFA8 File Offset: 0x0060B1A8
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

		// Token: 0x0602C0AB RID: 180395 RVA: 0x0060D005 File Offset: 0x0060B205
		public static Offset<IClaimDynamicEntityReward> CreateIClaimDynamicEntityReward(FlatBufferBuilder builder, Offset<IClaimDynamicTrafficReward> RewardTypeOffset = default(Offset<IClaimDynamicTrafficReward>))
		{
			builder.StartTable(1);
			IClaimDynamicEntityReward.AddRewardType(builder, RewardTypeOffset);
			return IClaimDynamicEntityReward.EndIClaimDynamicEntityReward(builder);
		}

		// Token: 0x0602C0AC RID: 180396 RVA: 0x0060D01B File Offset: 0x0060B21B
		public static void StartIClaimDynamicEntityReward(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C0AD RID: 180397 RVA: 0x0060D024 File Offset: 0x0060B224
		public static void AddRewardType(FlatBufferBuilder builder, Offset<IClaimDynamicTrafficReward> rewardTypeOffset)
		{
			builder.AddOffset(0, rewardTypeOffset.Value, 0);
		}

		// Token: 0x0602C0AE RID: 180398 RVA: 0x0060D034 File Offset: 0x0060B234
		public static Offset<IClaimDynamicEntityReward> EndIClaimDynamicEntityReward(FlatBufferBuilder builder)
		{
			return new Offset<IClaimDynamicEntityReward>(builder.EndTable());
		}

		// Token: 0x0602C0AF RID: 180399 RVA: 0x0060D044 File Offset: 0x0060B244
		public IClaimDynamicEntityRewardT UnPack()
		{
			IClaimDynamicEntityRewardT claimDynamicEntityRewardT = new IClaimDynamicEntityRewardT();
			this.UnPackTo(claimDynamicEntityRewardT);
			return claimDynamicEntityRewardT;
		}

		// Token: 0x0602C0B0 RID: 180400 RVA: 0x0060D060 File Offset: 0x0060B260
		public void UnPackTo(IClaimDynamicEntityRewardT _o)
		{
			_o.RewardType = ((this.RewardType != null) ? this.RewardType.Value.UnPack() : null);
		}

		// Token: 0x0602C0B1 RID: 180401 RVA: 0x0060D09C File Offset: 0x0060B29C
		public static Offset<IClaimDynamicEntityReward> Pack(FlatBufferBuilder builder, IClaimDynamicEntityRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClaimDynamicEntityReward>);
			}
			Offset<IClaimDynamicTrafficReward> rewardTypeOffset = (_o.RewardType == null) ? default(Offset<IClaimDynamicTrafficReward>) : IClaimDynamicTrafficReward.Pack(builder, _o.RewardType);
			return IClaimDynamicEntityReward.CreateIClaimDynamicEntityReward(builder, rewardTypeOffset);
		}

		// Token: 0x04010941 RID: 67905
		private Table __p;
	}
}
