using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200468E RID: 18062
	public struct ITrapDefenseConditionStepReward : IFlatbufferObject
	{
		// Token: 0x17007E86 RID: 32390
		// (get) Token: 0x0601A846 RID: 108614 RVA: 0x003C6091 File Offset: 0x003C4291
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A847 RID: 108615 RVA: 0x003C609E File Offset: 0x003C429E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A848 RID: 108616 RVA: 0x003C60A8 File Offset: 0x003C42A8
		public static ITrapDefenseConditionStepReward GetRootAsITrapDefenseConditionStepReward(ByteBuffer _bb)
		{
			return ITrapDefenseConditionStepReward.GetRootAsITrapDefenseConditionStepReward(_bb, default(ITrapDefenseConditionStepReward));
		}

		// Token: 0x0601A849 RID: 108617 RVA: 0x003C60C4 File Offset: 0x003C42C4
		public static ITrapDefenseConditionStepReward GetRootAsITrapDefenseConditionStepReward(ByteBuffer _bb, ITrapDefenseConditionStepReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A84A RID: 108618 RVA: 0x003C60E1 File Offset: 0x003C42E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A84B RID: 108619 RVA: 0x003C60F0 File Offset: 0x003C42F0
		public ITrapDefenseConditionStepReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E87 RID: 32391
		// (get) Token: 0x0601A84C RID: 108620 RVA: 0x003C6100 File Offset: 0x003C4300
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

		// Token: 0x0601A84D RID: 108621 RVA: 0x003C613C File Offset: 0x003C433C
		public static Offset<ITrapDefenseConditionStepReward> CreateITrapDefenseConditionStepReward(FlatBufferBuilder builder, ETrapDefenseConditionStep Type = ETrapDefenseConditionStep.Reward)
		{
			builder.StartTable(1);
			ITrapDefenseConditionStepReward.AddType(builder, Type);
			return ITrapDefenseConditionStepReward.EndITrapDefenseConditionStepReward(builder);
		}

		// Token: 0x0601A84E RID: 108622 RVA: 0x003C6152 File Offset: 0x003C4352
		public static void StartITrapDefenseConditionStepReward(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A84F RID: 108623 RVA: 0x003C615B File Offset: 0x003C435B
		public static void AddType(FlatBufferBuilder builder, ETrapDefenseConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A850 RID: 108624 RVA: 0x003C6166 File Offset: 0x003C4366
		public static Offset<ITrapDefenseConditionStepReward> EndITrapDefenseConditionStepReward(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseConditionStepReward>(builder.EndTable());
		}

		// Token: 0x0601A851 RID: 108625 RVA: 0x003C6174 File Offset: 0x003C4374
		public ITrapDefenseConditionStepRewardT UnPack()
		{
			ITrapDefenseConditionStepRewardT trapDefenseConditionStepRewardT = new ITrapDefenseConditionStepRewardT();
			this.UnPackTo(trapDefenseConditionStepRewardT);
			return trapDefenseConditionStepRewardT;
		}

		// Token: 0x0601A852 RID: 108626 RVA: 0x003C618F File Offset: 0x003C438F
		public void UnPackTo(ITrapDefenseConditionStepRewardT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A853 RID: 108627 RVA: 0x003C61A0 File Offset: 0x003C43A0
		public static Offset<ITrapDefenseConditionStepReward> Pack(FlatBufferBuilder builder, ITrapDefenseConditionStepRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseConditionStepReward>);
			}
			return ITrapDefenseConditionStepReward.CreateITrapDefenseConditionStepReward(builder, _o.Type);
		}

		// Token: 0x0400C8C3 RID: 51395
		private Table __p;
	}
}
