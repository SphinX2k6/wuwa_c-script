using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043E5 RID: 17381
	public struct IPlayFlowQuestCondition : IFlatbufferObject
	{
		// Token: 0x170077BD RID: 30653
		// (get) Token: 0x06018B05 RID: 101125 RVA: 0x00385076 File Offset: 0x00383276
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018B06 RID: 101126 RVA: 0x00385083 File Offset: 0x00383283
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018B07 RID: 101127 RVA: 0x0038508C File Offset: 0x0038328C
		public static IPlayFlowQuestCondition GetRootAsIPlayFlowQuestCondition(ByteBuffer _bb)
		{
			return IPlayFlowQuestCondition.GetRootAsIPlayFlowQuestCondition(_bb, default(IPlayFlowQuestCondition));
		}

		// Token: 0x06018B08 RID: 101128 RVA: 0x003850A8 File Offset: 0x003832A8
		public static IPlayFlowQuestCondition GetRootAsIPlayFlowQuestCondition(ByteBuffer _bb, IPlayFlowQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018B09 RID: 101129 RVA: 0x003850C5 File Offset: 0x003832C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018B0A RID: 101130 RVA: 0x003850D4 File Offset: 0x003832D4
		public IPlayFlowQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077BE RID: 30654
		// (get) Token: 0x06018B0B RID: 101131 RVA: 0x003850E4 File Offset: 0x003832E4
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170077BF RID: 30655
		// (get) Token: 0x06018B0C RID: 101132 RVA: 0x00385120 File Offset: 0x00383320
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170077C0 RID: 30656
		// (get) Token: 0x06018B0D RID: 101133 RVA: 0x00385180 File Offset: 0x00383380
		public IPlayFlow? Flow
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06018B0E RID: 101134 RVA: 0x003851DD File Offset: 0x003833DD
		public static Offset<IPlayFlowQuestCondition> CreateIPlayFlowQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<IPlayFlow> FlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(3);
			IPlayFlowQuestCondition.AddFlow(builder, FlowOffset);
			IPlayFlowQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IPlayFlowQuestCondition.AddType(builder, Type);
			return IPlayFlowQuestCondition.EndIPlayFlowQuestCondition(builder);
		}

		// Token: 0x06018B0F RID: 101135 RVA: 0x00385201 File Offset: 0x00383401
		public static void StartIPlayFlowQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06018B10 RID: 101136 RVA: 0x0038520A File Offset: 0x0038340A
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018B11 RID: 101137 RVA: 0x00385215 File Offset: 0x00383415
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06018B12 RID: 101138 RVA: 0x00385225 File Offset: 0x00383425
		public static void AddFlow(FlatBufferBuilder builder, Offset<IPlayFlow> flowOffset)
		{
			builder.AddOffset(2, flowOffset.Value, 0);
		}

		// Token: 0x06018B13 RID: 101139 RVA: 0x00385235 File Offset: 0x00383435
		public static Offset<IPlayFlowQuestCondition> EndIPlayFlowQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IPlayFlowQuestCondition>(builder.EndTable());
		}

		// Token: 0x06018B14 RID: 101140 RVA: 0x00385244 File Offset: 0x00383444
		public IPlayFlowQuestConditionT UnPack()
		{
			IPlayFlowQuestConditionT playFlowQuestConditionT = new IPlayFlowQuestConditionT();
			this.UnPackTo(playFlowQuestConditionT);
			return playFlowQuestConditionT;
		}

		// Token: 0x06018B15 RID: 101141 RVA: 0x00385260 File Offset: 0x00383460
		public void UnPackTo(IPlayFlowQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
		}

		// Token: 0x06018B16 RID: 101142 RVA: 0x003852D8 File Offset: 0x003834D8
		public static Offset<IPlayFlowQuestCondition> Pack(FlatBufferBuilder builder, IPlayFlowQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayFlowQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			Offset<IPlayFlow> flowOffset = (_o.Flow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.Flow);
			return IPlayFlowQuestCondition.CreateIPlayFlowQuestCondition(builder, _o.Type, preConditionsOffset, flowOffset);
		}

		// Token: 0x0400C3F0 RID: 50160
		private Table __p;
	}
}
