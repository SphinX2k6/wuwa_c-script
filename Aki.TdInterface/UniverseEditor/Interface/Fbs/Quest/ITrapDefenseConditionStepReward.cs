using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004232 RID: 16946
	public struct ITrapDefenseConditionStepReward : IFlatbufferObject
	{
		// Token: 0x17007855 RID: 30805
		// (get) Token: 0x060190DA RID: 102618 RVA: 0x0039A9B9 File Offset: 0x00398BB9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060190DB RID: 102619 RVA: 0x0039A9C6 File Offset: 0x00398BC6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060190DC RID: 102620 RVA: 0x0039A9D0 File Offset: 0x00398BD0
		public static ITrapDefenseConditionStepReward GetRootAsITrapDefenseConditionStepReward(ByteBuffer _bb)
		{
			return ITrapDefenseConditionStepReward.GetRootAsITrapDefenseConditionStepReward(_bb, default(ITrapDefenseConditionStepReward));
		}

		// Token: 0x060190DD RID: 102621 RVA: 0x0039A9EC File Offset: 0x00398BEC
		public static ITrapDefenseConditionStepReward GetRootAsITrapDefenseConditionStepReward(ByteBuffer _bb, ITrapDefenseConditionStepReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060190DE RID: 102622 RVA: 0x0039AA09 File Offset: 0x00398C09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060190DF RID: 102623 RVA: 0x0039AA18 File Offset: 0x00398C18
		public ITrapDefenseConditionStepReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007856 RID: 30806
		// (get) Token: 0x060190E0 RID: 102624 RVA: 0x0039AA28 File Offset: 0x00398C28
		public ETrapDefenseConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrapDefenseConditionStep.Reward;
				}
				return (ETrapDefenseConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060190E1 RID: 102625 RVA: 0x0039AA64 File Offset: 0x00398C64
		public static Offset<ITrapDefenseConditionStepReward> CreateITrapDefenseConditionStepReward(FlatBufferBuilder builder, ETrapDefenseConditionStep Type = ETrapDefenseConditionStep.Reward)
		{
			builder.StartTable(1);
			ITrapDefenseConditionStepReward.AddType(builder, Type);
			return ITrapDefenseConditionStepReward.EndITrapDefenseConditionStepReward(builder);
		}

		// Token: 0x060190E2 RID: 102626 RVA: 0x0039AA7A File Offset: 0x00398C7A
		public static void StartITrapDefenseConditionStepReward(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060190E3 RID: 102627 RVA: 0x0039AA83 File Offset: 0x00398C83
		public static void AddType(FlatBufferBuilder builder, ETrapDefenseConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060190E4 RID: 102628 RVA: 0x0039AA8E File Offset: 0x00398C8E
		public static Offset<ITrapDefenseConditionStepReward> EndITrapDefenseConditionStepReward(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseConditionStepReward>(builder.EndTable());
		}

		// Token: 0x060190E5 RID: 102629 RVA: 0x0039AA9C File Offset: 0x00398C9C
		public ITrapDefenseConditionStepRewardT UnPack()
		{
			ITrapDefenseConditionStepRewardT trapDefenseConditionStepRewardT = new ITrapDefenseConditionStepRewardT();
			this.UnPackTo(trapDefenseConditionStepRewardT);
			return trapDefenseConditionStepRewardT;
		}

		// Token: 0x060190E6 RID: 102630 RVA: 0x0039AAB7 File Offset: 0x00398CB7
		public void UnPackTo(ITrapDefenseConditionStepRewardT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060190E7 RID: 102631 RVA: 0x0039AAC8 File Offset: 0x00398CC8
		public static Offset<ITrapDefenseConditionStepReward> Pack(FlatBufferBuilder builder, ITrapDefenseConditionStepRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseConditionStepReward>);
			}
			return ITrapDefenseConditionStepReward.CreateITrapDefenseConditionStepReward(builder, _o.Type);
		}

		// Token: 0x0400BEB6 RID: 48822
		private Table __p;
	}
}
