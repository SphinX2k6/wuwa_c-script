using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200415A RID: 16730
	public struct ISurvivorsRougeConditionStepChestReward : IFlatbufferObject
	{
		// Token: 0x1700768C RID: 30348
		// (get) Token: 0x06018922 RID: 100642 RVA: 0x0038A785 File Offset: 0x00388985
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018923 RID: 100643 RVA: 0x0038A792 File Offset: 0x00388992
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018924 RID: 100644 RVA: 0x0038A79C File Offset: 0x0038899C
		public static ISurvivorsRougeConditionStepChestReward GetRootAsISurvivorsRougeConditionStepChestReward(ByteBuffer _bb)
		{
			return ISurvivorsRougeConditionStepChestReward.GetRootAsISurvivorsRougeConditionStepChestReward(_bb, default(ISurvivorsRougeConditionStepChestReward));
		}

		// Token: 0x06018925 RID: 100645 RVA: 0x0038A7B8 File Offset: 0x003889B8
		public static ISurvivorsRougeConditionStepChestReward GetRootAsISurvivorsRougeConditionStepChestReward(ByteBuffer _bb, ISurvivorsRougeConditionStepChestReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018926 RID: 100646 RVA: 0x0038A7D5 File Offset: 0x003889D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018927 RID: 100647 RVA: 0x0038A7E4 File Offset: 0x003889E4
		public ISurvivorsRougeConditionStepChestReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700768D RID: 30349
		// (get) Token: 0x06018928 RID: 100648 RVA: 0x0038A7F4 File Offset: 0x003889F4
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

		// Token: 0x06018929 RID: 100649 RVA: 0x0038A830 File Offset: 0x00388A30
		public static Offset<ISurvivorsRougeConditionStepChestReward> CreateISurvivorsRougeConditionStepChestReward(FlatBufferBuilder builder, ESurvivorsRougeConditionStep Type = ESurvivorsRougeConditionStep.Prepare)
		{
			builder.StartTable(1);
			ISurvivorsRougeConditionStepChestReward.AddType(builder, Type);
			return ISurvivorsRougeConditionStepChestReward.EndISurvivorsRougeConditionStepChestReward(builder);
		}

		// Token: 0x0601892A RID: 100650 RVA: 0x0038A846 File Offset: 0x00388A46
		public static void StartISurvivorsRougeConditionStepChestReward(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601892B RID: 100651 RVA: 0x0038A84F File Offset: 0x00388A4F
		public static void AddType(FlatBufferBuilder builder, ESurvivorsRougeConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601892C RID: 100652 RVA: 0x0038A85A File Offset: 0x00388A5A
		public static Offset<ISurvivorsRougeConditionStepChestReward> EndISurvivorsRougeConditionStepChestReward(FlatBufferBuilder builder)
		{
			return new Offset<ISurvivorsRougeConditionStepChestReward>(builder.EndTable());
		}

		// Token: 0x0601892D RID: 100653 RVA: 0x0038A868 File Offset: 0x00388A68
		public ISurvivorsRougeConditionStepChestRewardT UnPack()
		{
			ISurvivorsRougeConditionStepChestRewardT survivorsRougeConditionStepChestRewardT = new ISurvivorsRougeConditionStepChestRewardT();
			this.UnPackTo(survivorsRougeConditionStepChestRewardT);
			return survivorsRougeConditionStepChestRewardT;
		}

		// Token: 0x0601892E RID: 100654 RVA: 0x0038A883 File Offset: 0x00388A83
		public void UnPackTo(ISurvivorsRougeConditionStepChestRewardT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601892F RID: 100655 RVA: 0x0038A894 File Offset: 0x00388A94
		public static Offset<ISurvivorsRougeConditionStepChestReward> Pack(FlatBufferBuilder builder, ISurvivorsRougeConditionStepChestRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISurvivorsRougeConditionStepChestReward>);
			}
			return ISurvivorsRougeConditionStepChestReward.CreateISurvivorsRougeConditionStepChestReward(builder, _o.Type);
		}

		// Token: 0x0400BD7B RID: 48507
		private Table __p;
	}
}
