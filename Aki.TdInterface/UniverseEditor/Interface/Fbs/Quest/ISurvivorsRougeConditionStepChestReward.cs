using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200459E RID: 17822
	public struct ISurvivorsRougeConditionStepChestReward : IFlatbufferObject
	{
		// Token: 0x17007C9B RID: 31899
		// (get) Token: 0x06019FEA RID: 106474 RVA: 0x003B4D41 File Offset: 0x003B2F41
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019FEB RID: 106475 RVA: 0x003B4D4E File Offset: 0x003B2F4E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019FEC RID: 106476 RVA: 0x003B4D58 File Offset: 0x003B2F58
		public static ISurvivorsRougeConditionStepChestReward GetRootAsISurvivorsRougeConditionStepChestReward(ByteBuffer _bb)
		{
			return ISurvivorsRougeConditionStepChestReward.GetRootAsISurvivorsRougeConditionStepChestReward(_bb, default(ISurvivorsRougeConditionStepChestReward));
		}

		// Token: 0x06019FED RID: 106477 RVA: 0x003B4D74 File Offset: 0x003B2F74
		public static ISurvivorsRougeConditionStepChestReward GetRootAsISurvivorsRougeConditionStepChestReward(ByteBuffer _bb, ISurvivorsRougeConditionStepChestReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019FEE RID: 106478 RVA: 0x003B4D91 File Offset: 0x003B2F91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019FEF RID: 106479 RVA: 0x003B4DA0 File Offset: 0x003B2FA0
		public ISurvivorsRougeConditionStepChestReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C9C RID: 31900
		// (get) Token: 0x06019FF0 RID: 106480 RVA: 0x003B4DB0 File Offset: 0x003B2FB0
		public ESurvivorsRougeConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESurvivorsRougeConditionStep.Prepare;
				}
				return (ESurvivorsRougeConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019FF1 RID: 106481 RVA: 0x003B4DEC File Offset: 0x003B2FEC
		public static Offset<ISurvivorsRougeConditionStepChestReward> CreateISurvivorsRougeConditionStepChestReward(FlatBufferBuilder builder, ESurvivorsRougeConditionStep Type = ESurvivorsRougeConditionStep.Prepare)
		{
			builder.StartTable(1);
			ISurvivorsRougeConditionStepChestReward.AddType(builder, Type);
			return ISurvivorsRougeConditionStepChestReward.EndISurvivorsRougeConditionStepChestReward(builder);
		}

		// Token: 0x06019FF2 RID: 106482 RVA: 0x003B4E02 File Offset: 0x003B3002
		public static void StartISurvivorsRougeConditionStepChestReward(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019FF3 RID: 106483 RVA: 0x003B4E0B File Offset: 0x003B300B
		public static void AddType(FlatBufferBuilder builder, ESurvivorsRougeConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019FF4 RID: 106484 RVA: 0x003B4E16 File Offset: 0x003B3016
		public static Offset<ISurvivorsRougeConditionStepChestReward> EndISurvivorsRougeConditionStepChestReward(FlatBufferBuilder builder)
		{
			return new Offset<ISurvivorsRougeConditionStepChestReward>(builder.EndTable());
		}

		// Token: 0x06019FF5 RID: 106485 RVA: 0x003B4E24 File Offset: 0x003B3024
		public ISurvivorsRougeConditionStepChestRewardT UnPack()
		{
			ISurvivorsRougeConditionStepChestRewardT survivorsRougeConditionStepChestRewardT = new ISurvivorsRougeConditionStepChestRewardT();
			this.UnPackTo(survivorsRougeConditionStepChestRewardT);
			return survivorsRougeConditionStepChestRewardT;
		}

		// Token: 0x06019FF6 RID: 106486 RVA: 0x003B4E3F File Offset: 0x003B303F
		public void UnPackTo(ISurvivorsRougeConditionStepChestRewardT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019FF7 RID: 106487 RVA: 0x003B4E50 File Offset: 0x003B3050
		public static Offset<ISurvivorsRougeConditionStepChestReward> Pack(FlatBufferBuilder builder, ISurvivorsRougeConditionStepChestRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISurvivorsRougeConditionStepChestReward>);
			}
			return ISurvivorsRougeConditionStepChestReward.CreateISurvivorsRougeConditionStepChestReward(builder, _o.Type);
		}

		// Token: 0x0400C769 RID: 51049
		private Table __p;
	}
}
