using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E45 RID: 15941
	public struct IFinishRoleTowerCondition : IFlatbufferObject
	{
		// Token: 0x17006E52 RID: 28242
		// (get) Token: 0x060165EC RID: 91628 RVA: 0x0033AD76 File Offset: 0x00338F76
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060165ED RID: 91629 RVA: 0x0033AD83 File Offset: 0x00338F83
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060165EE RID: 91630 RVA: 0x0033AD8C File Offset: 0x00338F8C
		public static IFinishRoleTowerCondition GetRootAsIFinishRoleTowerCondition(ByteBuffer _bb)
		{
			return IFinishRoleTowerCondition.GetRootAsIFinishRoleTowerCondition(_bb, default(IFinishRoleTowerCondition));
		}

		// Token: 0x060165EF RID: 91631 RVA: 0x0033ADA8 File Offset: 0x00338FA8
		public static IFinishRoleTowerCondition GetRootAsIFinishRoleTowerCondition(ByteBuffer _bb, IFinishRoleTowerCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060165F0 RID: 91632 RVA: 0x0033ADC5 File Offset: 0x00338FC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060165F1 RID: 91633 RVA: 0x0033ADD4 File Offset: 0x00338FD4
		public IFinishRoleTowerCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E53 RID: 28243
		// (get) Token: 0x060165F2 RID: 91634 RVA: 0x0033ADE4 File Offset: 0x00338FE4
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

		// Token: 0x17006E54 RID: 28244
		// (get) Token: 0x060165F3 RID: 91635 RVA: 0x0033AE20 File Offset: 0x00339020
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

		// Token: 0x17006E55 RID: 28245
		// (get) Token: 0x060165F4 RID: 91636 RVA: 0x0033AE80 File Offset: 0x00339080
		public TRoleTowerConditionStep StepType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TRoleTowerConditionStep.NONE;
				}
				return (TRoleTowerConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060165F5 RID: 91637 RVA: 0x0033AEBC File Offset: 0x003390BC
		public TTable? Step<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060165F6 RID: 91638 RVA: 0x0033AF04 File Offset: 0x00339104
		public IRoleTowerConditionStepBattle StepAsIRoleTowerConditionStepBattle()
		{
			return this.Step<IRoleTowerConditionStepBattle>().Value;
		}

		// Token: 0x060165F7 RID: 91639 RVA: 0x0033AF20 File Offset: 0x00339120
		public IRoleTowerConditionStepLoadSubLevel StepAsIRoleTowerConditionStepLoadSubLevel()
		{
			return this.Step<IRoleTowerConditionStepLoadSubLevel>().Value;
		}

		// Token: 0x060165F8 RID: 91640 RVA: 0x0033AF3C File Offset: 0x0033913C
		public IRoleTowerConditionStepPrepare StepAsIRoleTowerConditionStepPrepare()
		{
			return this.Step<IRoleTowerConditionStepPrepare>().Value;
		}

		// Token: 0x060165F9 RID: 91641 RVA: 0x0033AF58 File Offset: 0x00339158
		public IRoleTowerConditionStepSettle StepAsIRoleTowerConditionStepSettle()
		{
			return this.Step<IRoleTowerConditionStepSettle>().Value;
		}

		// Token: 0x060165FA RID: 91642 RVA: 0x0033AF74 File Offset: 0x00339174
		public IRoleTowerConditionStepTeamUpgrade StepAsIRoleTowerConditionStepTeamUpgrade()
		{
			return this.Step<IRoleTowerConditionStepTeamUpgrade>().Value;
		}

		// Token: 0x17006E56 RID: 28246
		// (get) Token: 0x060165FB RID: 91643 RVA: 0x0033AF90 File Offset: 0x00339190
		public TVarRef BatchType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060165FC RID: 91644 RVA: 0x0033AFD0 File Offset: 0x003391D0
		public TTable? Batch<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060165FD RID: 91645 RVA: 0x0033B018 File Offset: 0x00339218
		public IConstVarRef BatchAsIConstVarRef()
		{
			return this.Batch<IConstVarRef>().Value;
		}

		// Token: 0x060165FE RID: 91646 RVA: 0x0033B034 File Offset: 0x00339234
		public IGlobalVarRef BatchAsIGlobalVarRef()
		{
			return this.Batch<IGlobalVarRef>().Value;
		}

		// Token: 0x060165FF RID: 91647 RVA: 0x0033B050 File Offset: 0x00339250
		public IOtherVarRef BatchAsIOtherVarRef()
		{
			return this.Batch<IOtherVarRef>().Value;
		}

		// Token: 0x06016600 RID: 91648 RVA: 0x0033B06C File Offset: 0x0033926C
		public ISelfVarRef BatchAsISelfVarRef()
		{
			return this.Batch<ISelfVarRef>().Value;
		}

		// Token: 0x06016601 RID: 91649 RVA: 0x0033B088 File Offset: 0x00339288
		public ISystemVarRef BatchAsISystemVarRef()
		{
			return this.Batch<ISystemVarRef>().Value;
		}

		// Token: 0x06016602 RID: 91650 RVA: 0x0033B0A3 File Offset: 0x003392A3
		public static Offset<IFinishRoleTowerCondition> CreateIFinishRoleTowerCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TRoleTowerConditionStep Step_type = TRoleTowerConditionStep.NONE, int StepOffset = 0, TVarRef Batch_type = TVarRef.NONE, int BatchOffset = 0)
		{
			builder.StartTable(6);
			IFinishRoleTowerCondition.AddBatch(builder, BatchOffset);
			IFinishRoleTowerCondition.AddStep(builder, StepOffset);
			IFinishRoleTowerCondition.AddPreConditions(builder, PreConditionsOffset);
			IFinishRoleTowerCondition.AddBatchType(builder, Batch_type);
			IFinishRoleTowerCondition.AddStepType(builder, Step_type);
			IFinishRoleTowerCondition.AddType(builder, Type);
			return IFinishRoleTowerCondition.EndIFinishRoleTowerCondition(builder);
		}

		// Token: 0x06016603 RID: 91651 RVA: 0x0033B0DF File Offset: 0x003392DF
		public static void StartIFinishRoleTowerCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06016604 RID: 91652 RVA: 0x0033B0E8 File Offset: 0x003392E8
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016605 RID: 91653 RVA: 0x0033B0F3 File Offset: 0x003392F3
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06016606 RID: 91654 RVA: 0x0033B103 File Offset: 0x00339303
		public static void AddStepType(FlatBufferBuilder builder, TRoleTowerConditionStep stepType)
		{
			builder.AddByte(2, (byte)stepType, 0);
		}

		// Token: 0x06016607 RID: 91655 RVA: 0x0033B10E File Offset: 0x0033930E
		public static void AddStep(FlatBufferBuilder builder, int stepOffset)
		{
			builder.AddOffset(3, stepOffset, 0);
		}

		// Token: 0x06016608 RID: 91656 RVA: 0x0033B119 File Offset: 0x00339319
		public static void AddBatchType(FlatBufferBuilder builder, TVarRef batchType)
		{
			builder.AddByte(4, (byte)batchType, 0);
		}

		// Token: 0x06016609 RID: 91657 RVA: 0x0033B124 File Offset: 0x00339324
		public static void AddBatch(FlatBufferBuilder builder, int batchOffset)
		{
			builder.AddOffset(5, batchOffset, 0);
		}

		// Token: 0x0601660A RID: 91658 RVA: 0x0033B12F File Offset: 0x0033932F
		public static Offset<IFinishRoleTowerCondition> EndIFinishRoleTowerCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFinishRoleTowerCondition>(builder.EndTable());
		}

		// Token: 0x0601660B RID: 91659 RVA: 0x0033B13C File Offset: 0x0033933C
		public IFinishRoleTowerConditionT UnPack()
		{
			IFinishRoleTowerConditionT finishRoleTowerConditionT = new IFinishRoleTowerConditionT();
			this.UnPackTo(finishRoleTowerConditionT);
			return finishRoleTowerConditionT;
		}

		// Token: 0x0601660C RID: 91660 RVA: 0x0033B158 File Offset: 0x00339358
		public void UnPackTo(IFinishRoleTowerConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Step = new TRoleTowerConditionStepUnion();
			_o.Step.Type = this.StepType;
			switch (this.StepType)
			{
			case TRoleTowerConditionStep.IRoleTowerConditionStepBattle:
				_o.Step.Value = ((this.Step<IRoleTowerConditionStepBattle>() != null) ? this.Step<IRoleTowerConditionStepBattle>().Value.UnPack() : null);
				break;
			case TRoleTowerConditionStep.IRoleTowerConditionStepLoadSubLevel:
				_o.Step.Value = ((this.Step<IRoleTowerConditionStepLoadSubLevel>() != null) ? this.Step<IRoleTowerConditionStepLoadSubLevel>().Value.UnPack() : null);
				break;
			case TRoleTowerConditionStep.IRoleTowerConditionStepPrepare:
				_o.Step.Value = ((this.Step<IRoleTowerConditionStepPrepare>() != null) ? this.Step<IRoleTowerConditionStepPrepare>().Value.UnPack() : null);
				break;
			case TRoleTowerConditionStep.IRoleTowerConditionStepSettle:
				_o.Step.Value = ((this.Step<IRoleTowerConditionStepSettle>() != null) ? this.Step<IRoleTowerConditionStepSettle>().Value.UnPack() : null);
				break;
			case TRoleTowerConditionStep.IRoleTowerConditionStepTeamUpgrade:
				_o.Step.Value = ((this.Step<IRoleTowerConditionStepTeamUpgrade>() != null) ? this.Step<IRoleTowerConditionStepTeamUpgrade>().Value.UnPack() : null);
				break;
			}
			_o.Batch = new TVarRefUnion();
			_o.Batch.Type = this.BatchType;
			switch (this.BatchType)
			{
			case TVarRef.IConstVarRef:
				_o.Batch.Value = ((this.Batch<IConstVarRef>() != null) ? this.Batch<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.Batch.Value = ((this.Batch<IGlobalVarRef>() != null) ? this.Batch<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.Batch.Value = ((this.Batch<IOtherVarRef>() != null) ? this.Batch<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.Batch.Value = ((this.Batch<ISelfVarRef>() != null) ? this.Batch<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.Batch.Value = ((this.Batch<ISystemVarRef>() != null) ? this.Batch<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601660D RID: 91661 RVA: 0x0033B45C File Offset: 0x0033965C
		public static Offset<IFinishRoleTowerCondition> Pack(FlatBufferBuilder builder, IFinishRoleTowerConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishRoleTowerCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			TRoleTowerConditionStep step_type = (_o.Step == null) ? TRoleTowerConditionStep.NONE : _o.Step.Type;
			int stepOffset = (_o.Step == null) ? 0 : TRoleTowerConditionStepUnion.Pack(builder, _o.Step);
			TVarRef batch_type = (_o.Batch == null) ? TVarRef.NONE : _o.Batch.Type;
			int batchOffset = (_o.Batch == null) ? 0 : TVarRefUnion.Pack(builder, _o.Batch);
			return IFinishRoleTowerCondition.CreateIFinishRoleTowerCondition(builder, _o.Type, preConditionsOffset, step_type, stepOffset, batch_type, batchOffset);
		}

		// Token: 0x0400B7D8 RID: 47064
		private Table __p;
	}
}
