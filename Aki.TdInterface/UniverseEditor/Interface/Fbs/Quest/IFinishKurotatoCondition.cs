using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E3F RID: 15935
	public struct IFinishKurotatoCondition : IFlatbufferObject
	{
		// Token: 0x17006E42 RID: 28226
		// (get) Token: 0x060165A3 RID: 91555 RVA: 0x0033A003 File Offset: 0x00338203
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060165A4 RID: 91556 RVA: 0x0033A010 File Offset: 0x00338210
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060165A5 RID: 91557 RVA: 0x0033A018 File Offset: 0x00338218
		public static IFinishKurotatoCondition GetRootAsIFinishKurotatoCondition(ByteBuffer _bb)
		{
			return IFinishKurotatoCondition.GetRootAsIFinishKurotatoCondition(_bb, default(IFinishKurotatoCondition));
		}

		// Token: 0x060165A6 RID: 91558 RVA: 0x0033A034 File Offset: 0x00338234
		public static IFinishKurotatoCondition GetRootAsIFinishKurotatoCondition(ByteBuffer _bb, IFinishKurotatoCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060165A7 RID: 91559 RVA: 0x0033A051 File Offset: 0x00338251
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060165A8 RID: 91560 RVA: 0x0033A060 File Offset: 0x00338260
		public IFinishKurotatoCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E43 RID: 28227
		// (get) Token: 0x060165A9 RID: 91561 RVA: 0x0033A070 File Offset: 0x00338270
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

		// Token: 0x17006E44 RID: 28228
		// (get) Token: 0x060165AA RID: 91562 RVA: 0x0033A0AC File Offset: 0x003382AC
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

		// Token: 0x17006E45 RID: 28229
		// (get) Token: 0x060165AB RID: 91563 RVA: 0x0033A10C File Offset: 0x0033830C
		public TKurotatoConditionStep StepType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TKurotatoConditionStep.NONE;
				}
				return (TKurotatoConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060165AC RID: 91564 RVA: 0x0033A148 File Offset: 0x00338348
		public TTable? Step<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060165AD RID: 91565 RVA: 0x0033A190 File Offset: 0x00338390
		public IKurotatoConditionStepBattle StepAsIKurotatoConditionStepBattle()
		{
			return this.Step<IKurotatoConditionStepBattle>().Value;
		}

		// Token: 0x060165AE RID: 91566 RVA: 0x0033A1AC File Offset: 0x003383AC
		public IKurotatoConditionStepChestReward StepAsIKurotatoConditionStepChestReward()
		{
			return this.Step<IKurotatoConditionStepChestReward>().Value;
		}

		// Token: 0x060165AF RID: 91567 RVA: 0x0033A1C8 File Offset: 0x003383C8
		public IKurotatoConditionStepEnd StepAsIKurotatoConditionStepEnd()
		{
			return this.Step<IKurotatoConditionStepEnd>().Value;
		}

		// Token: 0x060165B0 RID: 91568 RVA: 0x0033A1E4 File Offset: 0x003383E4
		public IKurotatoConditionStepPrepare StepAsIKurotatoConditionStepPrepare()
		{
			return this.Step<IKurotatoConditionStepPrepare>().Value;
		}

		// Token: 0x060165B1 RID: 91569 RVA: 0x0033A200 File Offset: 0x00338400
		public IKurotatoConditionStepSaveRole StepAsIKurotatoConditionStepSaveRole()
		{
			return this.Step<IKurotatoConditionStepSaveRole>().Value;
		}

		// Token: 0x060165B2 RID: 91570 RVA: 0x0033A21C File Offset: 0x0033841C
		public IKurotatoConditionStepShopping StepAsIKurotatoConditionStepShopping()
		{
			return this.Step<IKurotatoConditionStepShopping>().Value;
		}

		// Token: 0x060165B3 RID: 91571 RVA: 0x0033A238 File Offset: 0x00338438
		public IKurotatoConditionStepUpdateBatch StepAsIKurotatoConditionStepUpdateBatch()
		{
			return this.Step<IKurotatoConditionStepUpdateBatch>().Value;
		}

		// Token: 0x060165B4 RID: 91572 RVA: 0x0033A254 File Offset: 0x00338454
		public IKurotatoConditionStepUpgradeReward StepAsIKurotatoConditionStepUpgradeReward()
		{
			return this.Step<IKurotatoConditionStepUpgradeReward>().Value;
		}

		// Token: 0x17006E46 RID: 28230
		// (get) Token: 0x060165B5 RID: 91573 RVA: 0x0033A270 File Offset: 0x00338470
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

		// Token: 0x060165B6 RID: 91574 RVA: 0x0033A2B0 File Offset: 0x003384B0
		public TTable? Batch<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060165B7 RID: 91575 RVA: 0x0033A2F8 File Offset: 0x003384F8
		public IConstVarRef BatchAsIConstVarRef()
		{
			return this.Batch<IConstVarRef>().Value;
		}

		// Token: 0x060165B8 RID: 91576 RVA: 0x0033A314 File Offset: 0x00338514
		public IGlobalVarRef BatchAsIGlobalVarRef()
		{
			return this.Batch<IGlobalVarRef>().Value;
		}

		// Token: 0x060165B9 RID: 91577 RVA: 0x0033A330 File Offset: 0x00338530
		public IOtherVarRef BatchAsIOtherVarRef()
		{
			return this.Batch<IOtherVarRef>().Value;
		}

		// Token: 0x060165BA RID: 91578 RVA: 0x0033A34C File Offset: 0x0033854C
		public ISelfVarRef BatchAsISelfVarRef()
		{
			return this.Batch<ISelfVarRef>().Value;
		}

		// Token: 0x060165BB RID: 91579 RVA: 0x0033A368 File Offset: 0x00338568
		public ISystemVarRef BatchAsISystemVarRef()
		{
			return this.Batch<ISystemVarRef>().Value;
		}

		// Token: 0x060165BC RID: 91580 RVA: 0x0033A383 File Offset: 0x00338583
		public static Offset<IFinishKurotatoCondition> CreateIFinishKurotatoCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TKurotatoConditionStep Step_type = TKurotatoConditionStep.NONE, int StepOffset = 0, TVarRef Batch_type = TVarRef.NONE, int BatchOffset = 0)
		{
			builder.StartTable(6);
			IFinishKurotatoCondition.AddBatch(builder, BatchOffset);
			IFinishKurotatoCondition.AddStep(builder, StepOffset);
			IFinishKurotatoCondition.AddPreConditions(builder, PreConditionsOffset);
			IFinishKurotatoCondition.AddBatchType(builder, Batch_type);
			IFinishKurotatoCondition.AddStepType(builder, Step_type);
			IFinishKurotatoCondition.AddType(builder, Type);
			return IFinishKurotatoCondition.EndIFinishKurotatoCondition(builder);
		}

		// Token: 0x060165BD RID: 91581 RVA: 0x0033A3BF File Offset: 0x003385BF
		public static void StartIFinishKurotatoCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060165BE RID: 91582 RVA: 0x0033A3C8 File Offset: 0x003385C8
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060165BF RID: 91583 RVA: 0x0033A3D3 File Offset: 0x003385D3
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060165C0 RID: 91584 RVA: 0x0033A3E3 File Offset: 0x003385E3
		public static void AddStepType(FlatBufferBuilder builder, TKurotatoConditionStep stepType)
		{
			builder.AddByte(2, (byte)stepType, 0);
		}

		// Token: 0x060165C1 RID: 91585 RVA: 0x0033A3EE File Offset: 0x003385EE
		public static void AddStep(FlatBufferBuilder builder, int stepOffset)
		{
			builder.AddOffset(3, stepOffset, 0);
		}

		// Token: 0x060165C2 RID: 91586 RVA: 0x0033A3F9 File Offset: 0x003385F9
		public static void AddBatchType(FlatBufferBuilder builder, TVarRef batchType)
		{
			builder.AddByte(4, (byte)batchType, 0);
		}

		// Token: 0x060165C3 RID: 91587 RVA: 0x0033A404 File Offset: 0x00338604
		public static void AddBatch(FlatBufferBuilder builder, int batchOffset)
		{
			builder.AddOffset(5, batchOffset, 0);
		}

		// Token: 0x060165C4 RID: 91588 RVA: 0x0033A40F File Offset: 0x0033860F
		public static Offset<IFinishKurotatoCondition> EndIFinishKurotatoCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFinishKurotatoCondition>(builder.EndTable());
		}

		// Token: 0x060165C5 RID: 91589 RVA: 0x0033A41C File Offset: 0x0033861C
		public IFinishKurotatoConditionT UnPack()
		{
			IFinishKurotatoConditionT finishKurotatoConditionT = new IFinishKurotatoConditionT();
			this.UnPackTo(finishKurotatoConditionT);
			return finishKurotatoConditionT;
		}

		// Token: 0x060165C6 RID: 91590 RVA: 0x0033A438 File Offset: 0x00338638
		public void UnPackTo(IFinishKurotatoConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Step = new TKurotatoConditionStepUnion();
			_o.Step.Type = this.StepType;
			switch (this.StepType)
			{
			case TKurotatoConditionStep.IKurotatoConditionStepBattle:
				_o.Step.Value = ((this.Step<IKurotatoConditionStepBattle>() != null) ? this.Step<IKurotatoConditionStepBattle>().Value.UnPack() : null);
				break;
			case TKurotatoConditionStep.IKurotatoConditionStepChestReward:
				_o.Step.Value = ((this.Step<IKurotatoConditionStepChestReward>() != null) ? this.Step<IKurotatoConditionStepChestReward>().Value.UnPack() : null);
				break;
			case TKurotatoConditionStep.IKurotatoConditionStepEnd:
				_o.Step.Value = ((this.Step<IKurotatoConditionStepEnd>() != null) ? this.Step<IKurotatoConditionStepEnd>().Value.UnPack() : null);
				break;
			case TKurotatoConditionStep.IKurotatoConditionStepPrepare:
				_o.Step.Value = ((this.Step<IKurotatoConditionStepPrepare>() != null) ? this.Step<IKurotatoConditionStepPrepare>().Value.UnPack() : null);
				break;
			case TKurotatoConditionStep.IKurotatoConditionStepSaveRole:
				_o.Step.Value = ((this.Step<IKurotatoConditionStepSaveRole>() != null) ? this.Step<IKurotatoConditionStepSaveRole>().Value.UnPack() : null);
				break;
			case TKurotatoConditionStep.IKurotatoConditionStepShopping:
				_o.Step.Value = ((this.Step<IKurotatoConditionStepShopping>() != null) ? this.Step<IKurotatoConditionStepShopping>().Value.UnPack() : null);
				break;
			case TKurotatoConditionStep.IKurotatoConditionStepUpdateBatch:
				_o.Step.Value = ((this.Step<IKurotatoConditionStepUpdateBatch>() != null) ? this.Step<IKurotatoConditionStepUpdateBatch>().Value.UnPack() : null);
				break;
			case TKurotatoConditionStep.IKurotatoConditionStepUpgradeReward:
				_o.Step.Value = ((this.Step<IKurotatoConditionStepUpgradeReward>() != null) ? this.Step<IKurotatoConditionStepUpgradeReward>().Value.UnPack() : null);
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

		// Token: 0x060165C7 RID: 91591 RVA: 0x0033A7FC File Offset: 0x003389FC
		public static Offset<IFinishKurotatoCondition> Pack(FlatBufferBuilder builder, IFinishKurotatoConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishKurotatoCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			TKurotatoConditionStep step_type = (_o.Step == null) ? TKurotatoConditionStep.NONE : _o.Step.Type;
			int stepOffset = (_o.Step == null) ? 0 : TKurotatoConditionStepUnion.Pack(builder, _o.Step);
			TVarRef batch_type = (_o.Batch == null) ? TVarRef.NONE : _o.Batch.Type;
			int batchOffset = (_o.Batch == null) ? 0 : TVarRefUnion.Pack(builder, _o.Batch);
			return IFinishKurotatoCondition.CreateIFinishKurotatoCondition(builder, _o.Type, preConditionsOffset, step_type, stepOffset, batch_type, batchOffset);
		}

		// Token: 0x0400B7CF RID: 47055
		private Table __p;
	}
}
