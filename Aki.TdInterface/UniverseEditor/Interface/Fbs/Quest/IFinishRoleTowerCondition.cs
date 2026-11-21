using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004280 RID: 17024
	public struct IFinishRoleTowerCondition : IFlatbufferObject
	{
		// Token: 0x17007436 RID: 29750
		// (get) Token: 0x06017C13 RID: 97299 RVA: 0x003638A6 File Offset: 0x00361AA6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017C14 RID: 97300 RVA: 0x003638B3 File Offset: 0x00361AB3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017C15 RID: 97301 RVA: 0x003638BC File Offset: 0x00361ABC
		public static IFinishRoleTowerCondition GetRootAsIFinishRoleTowerCondition(ByteBuffer _bb)
		{
			return IFinishRoleTowerCondition.GetRootAsIFinishRoleTowerCondition(_bb, default(IFinishRoleTowerCondition));
		}

		// Token: 0x06017C16 RID: 97302 RVA: 0x003638D8 File Offset: 0x00361AD8
		public static IFinishRoleTowerCondition GetRootAsIFinishRoleTowerCondition(ByteBuffer _bb, IFinishRoleTowerCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017C17 RID: 97303 RVA: 0x003638F5 File Offset: 0x00361AF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017C18 RID: 97304 RVA: 0x00363904 File Offset: 0x00361B04
		public IFinishRoleTowerCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007437 RID: 29751
		// (get) Token: 0x06017C19 RID: 97305 RVA: 0x00363914 File Offset: 0x00361B14
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

		// Token: 0x17007438 RID: 29752
		// (get) Token: 0x06017C1A RID: 97306 RVA: 0x00363950 File Offset: 0x00361B50
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

		// Token: 0x17007439 RID: 29753
		// (get) Token: 0x06017C1B RID: 97307 RVA: 0x003639B0 File Offset: 0x00361BB0
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

		// Token: 0x06017C1C RID: 97308 RVA: 0x003639EC File Offset: 0x00361BEC
		public TTable? Step<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017C1D RID: 97309 RVA: 0x00363A34 File Offset: 0x00361C34
		public IRoleTowerConditionStepBattle StepAsIRoleTowerConditionStepBattle()
		{
			return this.Step<IRoleTowerConditionStepBattle>().Value;
		}

		// Token: 0x06017C1E RID: 97310 RVA: 0x00363A50 File Offset: 0x00361C50
		public IRoleTowerConditionStepLoadSubLevel StepAsIRoleTowerConditionStepLoadSubLevel()
		{
			return this.Step<IRoleTowerConditionStepLoadSubLevel>().Value;
		}

		// Token: 0x06017C1F RID: 97311 RVA: 0x00363A6C File Offset: 0x00361C6C
		public IRoleTowerConditionStepPrepare StepAsIRoleTowerConditionStepPrepare()
		{
			return this.Step<IRoleTowerConditionStepPrepare>().Value;
		}

		// Token: 0x06017C20 RID: 97312 RVA: 0x00363A88 File Offset: 0x00361C88
		public IRoleTowerConditionStepSettle StepAsIRoleTowerConditionStepSettle()
		{
			return this.Step<IRoleTowerConditionStepSettle>().Value;
		}

		// Token: 0x06017C21 RID: 97313 RVA: 0x00363AA4 File Offset: 0x00361CA4
		public IRoleTowerConditionStepTeamUpgrade StepAsIRoleTowerConditionStepTeamUpgrade()
		{
			return this.Step<IRoleTowerConditionStepTeamUpgrade>().Value;
		}

		// Token: 0x1700743A RID: 29754
		// (get) Token: 0x06017C22 RID: 97314 RVA: 0x00363AC0 File Offset: 0x00361CC0
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

		// Token: 0x06017C23 RID: 97315 RVA: 0x00363B00 File Offset: 0x00361D00
		public TTable? Batch<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017C24 RID: 97316 RVA: 0x00363B48 File Offset: 0x00361D48
		public IConstVarRef BatchAsIConstVarRef()
		{
			return this.Batch<IConstVarRef>().Value;
		}

		// Token: 0x06017C25 RID: 97317 RVA: 0x00363B64 File Offset: 0x00361D64
		public IGlobalVarRef BatchAsIGlobalVarRef()
		{
			return this.Batch<IGlobalVarRef>().Value;
		}

		// Token: 0x06017C26 RID: 97318 RVA: 0x00363B80 File Offset: 0x00361D80
		public IOtherVarRef BatchAsIOtherVarRef()
		{
			return this.Batch<IOtherVarRef>().Value;
		}

		// Token: 0x06017C27 RID: 97319 RVA: 0x00363B9C File Offset: 0x00361D9C
		public ISelfVarRef BatchAsISelfVarRef()
		{
			return this.Batch<ISelfVarRef>().Value;
		}

		// Token: 0x06017C28 RID: 97320 RVA: 0x00363BB8 File Offset: 0x00361DB8
		public ISystemVarRef BatchAsISystemVarRef()
		{
			return this.Batch<ISystemVarRef>().Value;
		}

		// Token: 0x06017C29 RID: 97321 RVA: 0x00363BD3 File Offset: 0x00361DD3
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

		// Token: 0x06017C2A RID: 97322 RVA: 0x00363C0F File Offset: 0x00361E0F
		public static void StartIFinishRoleTowerCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06017C2B RID: 97323 RVA: 0x00363C18 File Offset: 0x00361E18
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017C2C RID: 97324 RVA: 0x00363C23 File Offset: 0x00361E23
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017C2D RID: 97325 RVA: 0x00363C33 File Offset: 0x00361E33
		public static void AddStepType(FlatBufferBuilder builder, TRoleTowerConditionStep stepType)
		{
			builder.AddByte(2, (byte)stepType, 0);
		}

		// Token: 0x06017C2E RID: 97326 RVA: 0x00363C3E File Offset: 0x00361E3E
		public static void AddStep(FlatBufferBuilder builder, int stepOffset)
		{
			builder.AddOffset(3, stepOffset, 0);
		}

		// Token: 0x06017C2F RID: 97327 RVA: 0x00363C49 File Offset: 0x00361E49
		public static void AddBatchType(FlatBufferBuilder builder, TVarRef batchType)
		{
			builder.AddByte(4, (byte)batchType, 0);
		}

		// Token: 0x06017C30 RID: 97328 RVA: 0x00363C54 File Offset: 0x00361E54
		public static void AddBatch(FlatBufferBuilder builder, int batchOffset)
		{
			builder.AddOffset(5, batchOffset, 0);
		}

		// Token: 0x06017C31 RID: 97329 RVA: 0x00363C5F File Offset: 0x00361E5F
		public static Offset<IFinishRoleTowerCondition> EndIFinishRoleTowerCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFinishRoleTowerCondition>(builder.EndTable());
		}

		// Token: 0x06017C32 RID: 97330 RVA: 0x00363C6C File Offset: 0x00361E6C
		public IFinishRoleTowerConditionT UnPack()
		{
			IFinishRoleTowerConditionT finishRoleTowerConditionT = new IFinishRoleTowerConditionT();
			this.UnPackTo(finishRoleTowerConditionT);
			return finishRoleTowerConditionT;
		}

		// Token: 0x06017C33 RID: 97331 RVA: 0x00363C88 File Offset: 0x00361E88
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

		// Token: 0x06017C34 RID: 97332 RVA: 0x00363F8C File Offset: 0x0036218C
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

		// Token: 0x0400C1AF RID: 49583
		private Table __p;
	}
}
