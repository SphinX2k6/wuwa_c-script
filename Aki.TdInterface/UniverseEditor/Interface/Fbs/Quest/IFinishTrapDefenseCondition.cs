using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200428C RID: 17036
	public struct IFinishTrapDefenseCondition : IFlatbufferObject
	{
		// Token: 0x1700747F RID: 29823
		// (get) Token: 0x06017D42 RID: 97602 RVA: 0x00367532 File Offset: 0x00365732
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017D43 RID: 97603 RVA: 0x0036753F File Offset: 0x0036573F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017D44 RID: 97604 RVA: 0x00367548 File Offset: 0x00365748
		public static IFinishTrapDefenseCondition GetRootAsIFinishTrapDefenseCondition(ByteBuffer _bb)
		{
			return IFinishTrapDefenseCondition.GetRootAsIFinishTrapDefenseCondition(_bb, default(IFinishTrapDefenseCondition));
		}

		// Token: 0x06017D45 RID: 97605 RVA: 0x00367564 File Offset: 0x00365764
		public static IFinishTrapDefenseCondition GetRootAsIFinishTrapDefenseCondition(ByteBuffer _bb, IFinishTrapDefenseCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017D46 RID: 97606 RVA: 0x00367581 File Offset: 0x00365781
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017D47 RID: 97607 RVA: 0x00367590 File Offset: 0x00365790
		public IFinishTrapDefenseCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007480 RID: 29824
		// (get) Token: 0x06017D48 RID: 97608 RVA: 0x003675A0 File Offset: 0x003657A0
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

		// Token: 0x17007481 RID: 29825
		// (get) Token: 0x06017D49 RID: 97609 RVA: 0x003675DC File Offset: 0x003657DC
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

		// Token: 0x17007482 RID: 29826
		// (get) Token: 0x06017D4A RID: 97610 RVA: 0x0036763C File Offset: 0x0036583C
		public TTrapDefenseConditionStep StepType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TTrapDefenseConditionStep.NONE;
				}
				return (TTrapDefenseConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017D4B RID: 97611 RVA: 0x00367678 File Offset: 0x00365878
		public TTable? Step<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017D4C RID: 97612 RVA: 0x003676C0 File Offset: 0x003658C0
		public ITrapDefenseConditionStepLoadAndRestoreMap StepAsITrapDefenseConditionStepLoadAndRestoreMap()
		{
			return this.Step<ITrapDefenseConditionStepLoadAndRestoreMap>().Value;
		}

		// Token: 0x06017D4D RID: 97613 RVA: 0x003676DC File Offset: 0x003658DC
		public ITrapDefenseConditionStepMapChange StepAsITrapDefenseConditionStepMapChange()
		{
			return this.Step<ITrapDefenseConditionStepMapChange>().Value;
		}

		// Token: 0x06017D4E RID: 97614 RVA: 0x003676F8 File Offset: 0x003658F8
		public ITrapDefenseConditionStepPreview StepAsITrapDefenseConditionStepPreview()
		{
			return this.Step<ITrapDefenseConditionStepPreview>().Value;
		}

		// Token: 0x06017D4F RID: 97615 RVA: 0x00367714 File Offset: 0x00365914
		public ITrapDefenseConditionStepReward StepAsITrapDefenseConditionStepReward()
		{
			return this.Step<ITrapDefenseConditionStepReward>().Value;
		}

		// Token: 0x06017D50 RID: 97616 RVA: 0x00367730 File Offset: 0x00365930
		public ITrapDefenseConditionStepSpawnMonster StepAsITrapDefenseConditionStepSpawnMonster()
		{
			return this.Step<ITrapDefenseConditionStepSpawnMonster>().Value;
		}

		// Token: 0x17007483 RID: 29827
		// (get) Token: 0x06017D51 RID: 97617 RVA: 0x0036774C File Offset: 0x0036594C
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

		// Token: 0x06017D52 RID: 97618 RVA: 0x0036778C File Offset: 0x0036598C
		public TTable? Batch<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017D53 RID: 97619 RVA: 0x003677D4 File Offset: 0x003659D4
		public IConstVarRef BatchAsIConstVarRef()
		{
			return this.Batch<IConstVarRef>().Value;
		}

		// Token: 0x06017D54 RID: 97620 RVA: 0x003677F0 File Offset: 0x003659F0
		public IGlobalVarRef BatchAsIGlobalVarRef()
		{
			return this.Batch<IGlobalVarRef>().Value;
		}

		// Token: 0x06017D55 RID: 97621 RVA: 0x0036780C File Offset: 0x00365A0C
		public IOtherVarRef BatchAsIOtherVarRef()
		{
			return this.Batch<IOtherVarRef>().Value;
		}

		// Token: 0x06017D56 RID: 97622 RVA: 0x00367828 File Offset: 0x00365A28
		public ISelfVarRef BatchAsISelfVarRef()
		{
			return this.Batch<ISelfVarRef>().Value;
		}

		// Token: 0x06017D57 RID: 97623 RVA: 0x00367844 File Offset: 0x00365A44
		public ISystemVarRef BatchAsISystemVarRef()
		{
			return this.Batch<ISystemVarRef>().Value;
		}

		// Token: 0x17007484 RID: 29828
		// (get) Token: 0x06017D58 RID: 97624 RVA: 0x00367860 File Offset: 0x00365A60
		public bool NeedArchive
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007485 RID: 29829
		// (get) Token: 0x06017D59 RID: 97625 RVA: 0x003678A0 File Offset: 0x00365AA0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017D5A RID: 97626 RVA: 0x003678E0 File Offset: 0x00365AE0
		public static Offset<IFinishTrapDefenseCondition> CreateIFinishTrapDefenseCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TTrapDefenseConditionStep Step_type = TTrapDefenseConditionStep.NONE, int StepOffset = 0, TVarRef Batch_type = TVarRef.NONE, int BatchOffset = 0, bool NeedArchive = false, byte NullMask = 0)
		{
			builder.StartTable(8);
			IFinishTrapDefenseCondition.AddBatch(builder, BatchOffset);
			IFinishTrapDefenseCondition.AddStep(builder, StepOffset);
			IFinishTrapDefenseCondition.AddPreConditions(builder, PreConditionsOffset);
			IFinishTrapDefenseCondition.AddNullMask(builder, NullMask);
			IFinishTrapDefenseCondition.AddNeedArchive(builder, NeedArchive);
			IFinishTrapDefenseCondition.AddBatchType(builder, Batch_type);
			IFinishTrapDefenseCondition.AddStepType(builder, Step_type);
			IFinishTrapDefenseCondition.AddType(builder, Type);
			return IFinishTrapDefenseCondition.EndIFinishTrapDefenseCondition(builder);
		}

		// Token: 0x06017D5B RID: 97627 RVA: 0x00367937 File Offset: 0x00365B37
		public static void StartIFinishTrapDefenseCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06017D5C RID: 97628 RVA: 0x00367940 File Offset: 0x00365B40
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017D5D RID: 97629 RVA: 0x0036794B File Offset: 0x00365B4B
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017D5E RID: 97630 RVA: 0x0036795B File Offset: 0x00365B5B
		public static void AddStepType(FlatBufferBuilder builder, TTrapDefenseConditionStep stepType)
		{
			builder.AddByte(2, (byte)stepType, 0);
		}

		// Token: 0x06017D5F RID: 97631 RVA: 0x00367966 File Offset: 0x00365B66
		public static void AddStep(FlatBufferBuilder builder, int stepOffset)
		{
			builder.AddOffset(3, stepOffset, 0);
		}

		// Token: 0x06017D60 RID: 97632 RVA: 0x00367971 File Offset: 0x00365B71
		public static void AddBatchType(FlatBufferBuilder builder, TVarRef batchType)
		{
			builder.AddByte(4, (byte)batchType, 0);
		}

		// Token: 0x06017D61 RID: 97633 RVA: 0x0036797C File Offset: 0x00365B7C
		public static void AddBatch(FlatBufferBuilder builder, int batchOffset)
		{
			builder.AddOffset(5, batchOffset, 0);
		}

		// Token: 0x06017D62 RID: 97634 RVA: 0x00367987 File Offset: 0x00365B87
		public static void AddNeedArchive(FlatBufferBuilder builder, bool needArchive)
		{
			builder.AddBool(6, needArchive, false);
		}

		// Token: 0x06017D63 RID: 97635 RVA: 0x00367992 File Offset: 0x00365B92
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06017D64 RID: 97636 RVA: 0x0036799D File Offset: 0x00365B9D
		public static Offset<IFinishTrapDefenseCondition> EndIFinishTrapDefenseCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFinishTrapDefenseCondition>(builder.EndTable());
		}

		// Token: 0x06017D65 RID: 97637 RVA: 0x003679AC File Offset: 0x00365BAC
		public IFinishTrapDefenseConditionT UnPack()
		{
			IFinishTrapDefenseConditionT finishTrapDefenseConditionT = new IFinishTrapDefenseConditionT();
			this.UnPackTo(finishTrapDefenseConditionT);
			return finishTrapDefenseConditionT;
		}

		// Token: 0x06017D66 RID: 97638 RVA: 0x003679C8 File Offset: 0x00365BC8
		public void UnPackTo(IFinishTrapDefenseConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Step = new TTrapDefenseConditionStepUnion();
			_o.Step.Type = this.StepType;
			switch (this.StepType)
			{
			case TTrapDefenseConditionStep.ITrapDefenseConditionStepLoadAndRestoreMap:
				_o.Step.Value = ((this.Step<ITrapDefenseConditionStepLoadAndRestoreMap>() != null) ? this.Step<ITrapDefenseConditionStepLoadAndRestoreMap>().Value.UnPack() : null);
				break;
			case TTrapDefenseConditionStep.ITrapDefenseConditionStepMapChange:
				_o.Step.Value = ((this.Step<ITrapDefenseConditionStepMapChange>() != null) ? this.Step<ITrapDefenseConditionStepMapChange>().Value.UnPack() : null);
				break;
			case TTrapDefenseConditionStep.ITrapDefenseConditionStepPreview:
				_o.Step.Value = ((this.Step<ITrapDefenseConditionStepPreview>() != null) ? this.Step<ITrapDefenseConditionStepPreview>().Value.UnPack() : null);
				break;
			case TTrapDefenseConditionStep.ITrapDefenseConditionStepReward:
				_o.Step.Value = ((this.Step<ITrapDefenseConditionStepReward>() != null) ? this.Step<ITrapDefenseConditionStepReward>().Value.UnPack() : null);
				break;
			case TTrapDefenseConditionStep.ITrapDefenseConditionStepSpawnMonster:
				_o.Step.Value = ((this.Step<ITrapDefenseConditionStepSpawnMonster>() != null) ? this.Step<ITrapDefenseConditionStepSpawnMonster>().Value.UnPack() : null);
				break;
			}
			_o.Batch = new TVarRefUnion();
			_o.Batch.Type = this.BatchType;
			switch (this.BatchType)
			{
			case TVarRef.IConstVarRef:
				_o.Batch.Value = ((this.Batch<IConstVarRef>() != null) ? this.Batch<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.Batch.Value = ((this.Batch<IGlobalVarRef>() != null) ? this.Batch<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.Batch.Value = ((this.Batch<IOtherVarRef>() != null) ? this.Batch<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.Batch.Value = ((this.Batch<ISelfVarRef>() != null) ? this.Batch<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.Batch.Value = ((this.Batch<ISystemVarRef>() != null) ? this.Batch<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.NeedArchive = this.NeedArchive;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017D67 RID: 97639 RVA: 0x00367CF4 File Offset: 0x00365EF4
		public static Offset<IFinishTrapDefenseCondition> Pack(FlatBufferBuilder builder, IFinishTrapDefenseConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishTrapDefenseCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			TTrapDefenseConditionStep step_type = (_o.Step == null) ? TTrapDefenseConditionStep.NONE : _o.Step.Type;
			int stepOffset = (_o.Step == null) ? 0 : TTrapDefenseConditionStepUnion.Pack(builder, _o.Step);
			TVarRef batch_type = (_o.Batch == null) ? TVarRef.NONE : _o.Batch.Type;
			int batchOffset = (_o.Batch == null) ? 0 : TVarRefUnion.Pack(builder, _o.Batch);
			return IFinishTrapDefenseCondition.CreateIFinishTrapDefenseCondition(builder, _o.Type, preConditionsOffset, step_type, stepOffset, batch_type, batchOffset, _o.NeedArchive, _o.NullMask);
		}

		// Token: 0x0400C1D5 RID: 49621
		private Table __p;
	}
}
