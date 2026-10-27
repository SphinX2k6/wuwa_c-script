using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E4B RID: 15947
	public struct IFinishSurvivorsRougeCondition : IFlatbufferObject
	{
		// Token: 0x17006E79 RID: 28281
		// (get) Token: 0x06016696 RID: 91798 RVA: 0x0033CF3D File Offset: 0x0033B13D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016697 RID: 91799 RVA: 0x0033CF4A File Offset: 0x0033B14A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016698 RID: 91800 RVA: 0x0033CF54 File Offset: 0x0033B154
		public static IFinishSurvivorsRougeCondition GetRootAsIFinishSurvivorsRougeCondition(ByteBuffer _bb)
		{
			return IFinishSurvivorsRougeCondition.GetRootAsIFinishSurvivorsRougeCondition(_bb, default(IFinishSurvivorsRougeCondition));
		}

		// Token: 0x06016699 RID: 91801 RVA: 0x0033CF70 File Offset: 0x0033B170
		public static IFinishSurvivorsRougeCondition GetRootAsIFinishSurvivorsRougeCondition(ByteBuffer _bb, IFinishSurvivorsRougeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601669A RID: 91802 RVA: 0x0033CF8D File Offset: 0x0033B18D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601669B RID: 91803 RVA: 0x0033CF9C File Offset: 0x0033B19C
		public IFinishSurvivorsRougeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E7A RID: 28282
		// (get) Token: 0x0601669C RID: 91804 RVA: 0x0033CFAC File Offset: 0x0033B1AC
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

		// Token: 0x17006E7B RID: 28283
		// (get) Token: 0x0601669D RID: 91805 RVA: 0x0033CFE8 File Offset: 0x0033B1E8
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

		// Token: 0x17006E7C RID: 28284
		// (get) Token: 0x0601669E RID: 91806 RVA: 0x0033D048 File Offset: 0x0033B248
		public TSurvivorsRougeConditionStep StepType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TSurvivorsRougeConditionStep.NONE;
				}
				return (TSurvivorsRougeConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601669F RID: 91807 RVA: 0x0033D084 File Offset: 0x0033B284
		public TTable? Step<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060166A0 RID: 91808 RVA: 0x0033D0CC File Offset: 0x0033B2CC
		public ISurvivorsRougeConditionStepBattle StepAsISurvivorsRougeConditionStepBattle()
		{
			return this.Step<ISurvivorsRougeConditionStepBattle>().Value;
		}

		// Token: 0x060166A1 RID: 91809 RVA: 0x0033D0E8 File Offset: 0x0033B2E8
		public ISurvivorsRougeConditionStepChestReward StepAsISurvivorsRougeConditionStepChestReward()
		{
			return this.Step<ISurvivorsRougeConditionStepChestReward>().Value;
		}

		// Token: 0x060166A2 RID: 91810 RVA: 0x0033D104 File Offset: 0x0033B304
		public ISurvivorsRougeConditionStepChooseItem StepAsISurvivorsRougeConditionStepChooseItem()
		{
			return this.Step<ISurvivorsRougeConditionStepChooseItem>().Value;
		}

		// Token: 0x060166A3 RID: 91811 RVA: 0x0033D120 File Offset: 0x0033B320
		public ISurvivorsRougeConditionStepChooseWeapon StepAsISurvivorsRougeConditionStepChooseWeapon()
		{
			return this.Step<ISurvivorsRougeConditionStepChooseWeapon>().Value;
		}

		// Token: 0x060166A4 RID: 91812 RVA: 0x0033D13C File Offset: 0x0033B33C
		public ISurvivorsRougeConditionStepEnd StepAsISurvivorsRougeConditionStepEnd()
		{
			return this.Step<ISurvivorsRougeConditionStepEnd>().Value;
		}

		// Token: 0x060166A5 RID: 91813 RVA: 0x0033D158 File Offset: 0x0033B358
		public ISurvivorsRougeConditionStepPrepare StepAsISurvivorsRougeConditionStepPrepare()
		{
			return this.Step<ISurvivorsRougeConditionStepPrepare>().Value;
		}

		// Token: 0x060166A6 RID: 91814 RVA: 0x0033D174 File Offset: 0x0033B374
		public ISurvivorsRougeConditionStepShopping StepAsISurvivorsRougeConditionStepShopping()
		{
			return this.Step<ISurvivorsRougeConditionStepShopping>().Value;
		}

		// Token: 0x17006E7D RID: 28285
		// (get) Token: 0x060166A7 RID: 91815 RVA: 0x0033D190 File Offset: 0x0033B390
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

		// Token: 0x060166A8 RID: 91816 RVA: 0x0033D1D0 File Offset: 0x0033B3D0
		public TTable? Batch<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060166A9 RID: 91817 RVA: 0x0033D218 File Offset: 0x0033B418
		public IConstVarRef BatchAsIConstVarRef()
		{
			return this.Batch<IConstVarRef>().Value;
		}

		// Token: 0x060166AA RID: 91818 RVA: 0x0033D234 File Offset: 0x0033B434
		public IGlobalVarRef BatchAsIGlobalVarRef()
		{
			return this.Batch<IGlobalVarRef>().Value;
		}

		// Token: 0x060166AB RID: 91819 RVA: 0x0033D250 File Offset: 0x0033B450
		public IOtherVarRef BatchAsIOtherVarRef()
		{
			return this.Batch<IOtherVarRef>().Value;
		}

		// Token: 0x060166AC RID: 91820 RVA: 0x0033D26C File Offset: 0x0033B46C
		public ISelfVarRef BatchAsISelfVarRef()
		{
			return this.Batch<ISelfVarRef>().Value;
		}

		// Token: 0x060166AD RID: 91821 RVA: 0x0033D288 File Offset: 0x0033B488
		public ISystemVarRef BatchAsISystemVarRef()
		{
			return this.Batch<ISystemVarRef>().Value;
		}

		// Token: 0x060166AE RID: 91822 RVA: 0x0033D2A3 File Offset: 0x0033B4A3
		public static Offset<IFinishSurvivorsRougeCondition> CreateIFinishSurvivorsRougeCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TSurvivorsRougeConditionStep Step_type = TSurvivorsRougeConditionStep.NONE, int StepOffset = 0, TVarRef Batch_type = TVarRef.NONE, int BatchOffset = 0)
		{
			builder.StartTable(6);
			IFinishSurvivorsRougeCondition.AddBatch(builder, BatchOffset);
			IFinishSurvivorsRougeCondition.AddStep(builder, StepOffset);
			IFinishSurvivorsRougeCondition.AddPreConditions(builder, PreConditionsOffset);
			IFinishSurvivorsRougeCondition.AddBatchType(builder, Batch_type);
			IFinishSurvivorsRougeCondition.AddStepType(builder, Step_type);
			IFinishSurvivorsRougeCondition.AddType(builder, Type);
			return IFinishSurvivorsRougeCondition.EndIFinishSurvivorsRougeCondition(builder);
		}

		// Token: 0x060166AF RID: 91823 RVA: 0x0033D2DF File Offset: 0x0033B4DF
		public static void StartIFinishSurvivorsRougeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060166B0 RID: 91824 RVA: 0x0033D2E8 File Offset: 0x0033B4E8
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060166B1 RID: 91825 RVA: 0x0033D2F3 File Offset: 0x0033B4F3
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060166B2 RID: 91826 RVA: 0x0033D303 File Offset: 0x0033B503
		public static void AddStepType(FlatBufferBuilder builder, TSurvivorsRougeConditionStep stepType)
		{
			builder.AddByte(2, (byte)stepType, 0);
		}

		// Token: 0x060166B3 RID: 91827 RVA: 0x0033D30E File Offset: 0x0033B50E
		public static void AddStep(FlatBufferBuilder builder, int stepOffset)
		{
			builder.AddOffset(3, stepOffset, 0);
		}

		// Token: 0x060166B4 RID: 91828 RVA: 0x0033D319 File Offset: 0x0033B519
		public static void AddBatchType(FlatBufferBuilder builder, TVarRef batchType)
		{
			builder.AddByte(4, (byte)batchType, 0);
		}

		// Token: 0x060166B5 RID: 91829 RVA: 0x0033D324 File Offset: 0x0033B524
		public static void AddBatch(FlatBufferBuilder builder, int batchOffset)
		{
			builder.AddOffset(5, batchOffset, 0);
		}

		// Token: 0x060166B6 RID: 91830 RVA: 0x0033D32F File Offset: 0x0033B52F
		public static Offset<IFinishSurvivorsRougeCondition> EndIFinishSurvivorsRougeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFinishSurvivorsRougeCondition>(builder.EndTable());
		}

		// Token: 0x060166B7 RID: 91831 RVA: 0x0033D33C File Offset: 0x0033B53C
		public IFinishSurvivorsRougeConditionT UnPack()
		{
			IFinishSurvivorsRougeConditionT finishSurvivorsRougeConditionT = new IFinishSurvivorsRougeConditionT();
			this.UnPackTo(finishSurvivorsRougeConditionT);
			return finishSurvivorsRougeConditionT;
		}

		// Token: 0x060166B8 RID: 91832 RVA: 0x0033D358 File Offset: 0x0033B558
		public void UnPackTo(IFinishSurvivorsRougeConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Step = new TSurvivorsRougeConditionStepUnion();
			_o.Step.Type = this.StepType;
			switch (this.StepType)
			{
			case TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepBattle:
				_o.Step.Value = ((this.Step<ISurvivorsRougeConditionStepBattle>() != null) ? this.Step<ISurvivorsRougeConditionStepBattle>().Value.UnPack() : null);
				break;
			case TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepChestReward:
				_o.Step.Value = ((this.Step<ISurvivorsRougeConditionStepChestReward>() != null) ? this.Step<ISurvivorsRougeConditionStepChestReward>().Value.UnPack() : null);
				break;
			case TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepChooseItem:
				_o.Step.Value = ((this.Step<ISurvivorsRougeConditionStepChooseItem>() != null) ? this.Step<ISurvivorsRougeConditionStepChooseItem>().Value.UnPack() : null);
				break;
			case TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepChooseWeapon:
				_o.Step.Value = ((this.Step<ISurvivorsRougeConditionStepChooseWeapon>() != null) ? this.Step<ISurvivorsRougeConditionStepChooseWeapon>().Value.UnPack() : null);
				break;
			case TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepEnd:
				_o.Step.Value = ((this.Step<ISurvivorsRougeConditionStepEnd>() != null) ? this.Step<ISurvivorsRougeConditionStepEnd>().Value.UnPack() : null);
				break;
			case TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepPrepare:
				_o.Step.Value = ((this.Step<ISurvivorsRougeConditionStepPrepare>() != null) ? this.Step<ISurvivorsRougeConditionStepPrepare>().Value.UnPack() : null);
				break;
			case TSurvivorsRougeConditionStep.ISurvivorsRougeConditionStepShopping:
				_o.Step.Value = ((this.Step<ISurvivorsRougeConditionStepShopping>() != null) ? this.Step<ISurvivorsRougeConditionStepShopping>().Value.UnPack() : null);
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

		// Token: 0x060166B9 RID: 91833 RVA: 0x0033D6DC File Offset: 0x0033B8DC
		public static Offset<IFinishSurvivorsRougeCondition> Pack(FlatBufferBuilder builder, IFinishSurvivorsRougeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishSurvivorsRougeCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			TSurvivorsRougeConditionStep step_type = (_o.Step == null) ? TSurvivorsRougeConditionStep.NONE : _o.Step.Type;
			int stepOffset = (_o.Step == null) ? 0 : TSurvivorsRougeConditionStepUnion.Pack(builder, _o.Step);
			TVarRef batch_type = (_o.Batch == null) ? TVarRef.NONE : _o.Batch.Type;
			int batchOffset = (_o.Batch == null) ? 0 : TVarRefUnion.Pack(builder, _o.Batch);
			return IFinishSurvivorsRougeCondition.CreateIFinishSurvivorsRougeCondition(builder, _o.Type, preConditionsOffset, step_type, stepOffset, batch_type, batchOffset);
		}

		// Token: 0x0400B7EC RID: 47084
		private Table __p;
	}
}
