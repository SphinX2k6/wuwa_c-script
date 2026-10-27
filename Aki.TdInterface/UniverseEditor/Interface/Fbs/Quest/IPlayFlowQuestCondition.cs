using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FA4 RID: 16292
	public struct IPlayFlowQuestCondition : IFlatbufferObject
	{
		// Token: 0x170071BF RID: 29119
		// (get) Token: 0x06017476 RID: 95350 RVA: 0x0035B45E File Offset: 0x0035965E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017477 RID: 95351 RVA: 0x0035B46B File Offset: 0x0035966B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017478 RID: 95352 RVA: 0x0035B474 File Offset: 0x00359674
		public static IPlayFlowQuestCondition GetRootAsIPlayFlowQuestCondition(ByteBuffer _bb)
		{
			return IPlayFlowQuestCondition.GetRootAsIPlayFlowQuestCondition(_bb, default(IPlayFlowQuestCondition));
		}

		// Token: 0x06017479 RID: 95353 RVA: 0x0035B490 File Offset: 0x00359690
		public static IPlayFlowQuestCondition GetRootAsIPlayFlowQuestCondition(ByteBuffer _bb, IPlayFlowQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601747A RID: 95354 RVA: 0x0035B4AD File Offset: 0x003596AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601747B RID: 95355 RVA: 0x0035B4BC File Offset: 0x003596BC
		public IPlayFlowQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071C0 RID: 29120
		// (get) Token: 0x0601747C RID: 95356 RVA: 0x0035B4CC File Offset: 0x003596CC
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

		// Token: 0x170071C1 RID: 29121
		// (get) Token: 0x0601747D RID: 95357 RVA: 0x0035B508 File Offset: 0x00359708
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

		// Token: 0x170071C2 RID: 29122
		// (get) Token: 0x0601747E RID: 95358 RVA: 0x0035B568 File Offset: 0x00359768
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

		// Token: 0x0601747F RID: 95359 RVA: 0x0035B5C5 File Offset: 0x003597C5
		public static Offset<IPlayFlowQuestCondition> CreateIPlayFlowQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<IPlayFlow> FlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(3);
			IPlayFlowQuestCondition.AddFlow(builder, FlowOffset);
			IPlayFlowQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IPlayFlowQuestCondition.AddType(builder, Type);
			return IPlayFlowQuestCondition.EndIPlayFlowQuestCondition(builder);
		}

		// Token: 0x06017480 RID: 95360 RVA: 0x0035B5E9 File Offset: 0x003597E9
		public static void StartIPlayFlowQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017481 RID: 95361 RVA: 0x0035B5F2 File Offset: 0x003597F2
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017482 RID: 95362 RVA: 0x0035B5FD File Offset: 0x003597FD
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017483 RID: 95363 RVA: 0x0035B60D File Offset: 0x0035980D
		public static void AddFlow(FlatBufferBuilder builder, Offset<IPlayFlow> flowOffset)
		{
			builder.AddOffset(2, flowOffset.Value, 0);
		}

		// Token: 0x06017484 RID: 95364 RVA: 0x0035B61D File Offset: 0x0035981D
		public static Offset<IPlayFlowQuestCondition> EndIPlayFlowQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IPlayFlowQuestCondition>(builder.EndTable());
		}

		// Token: 0x06017485 RID: 95365 RVA: 0x0035B62C File Offset: 0x0035982C
		public IPlayFlowQuestConditionT UnPack()
		{
			IPlayFlowQuestConditionT playFlowQuestConditionT = new IPlayFlowQuestConditionT();
			this.UnPackTo(playFlowQuestConditionT);
			return playFlowQuestConditionT;
		}

		// Token: 0x06017486 RID: 95366 RVA: 0x0035B648 File Offset: 0x00359848
		public void UnPackTo(IPlayFlowQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
		}

		// Token: 0x06017487 RID: 95367 RVA: 0x0035B6C0 File Offset: 0x003598C0
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

		// Token: 0x0400BA0B RID: 47627
		private Table __p;
	}
}
