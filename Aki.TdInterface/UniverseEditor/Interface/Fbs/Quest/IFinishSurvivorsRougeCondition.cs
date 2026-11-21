using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004286 RID: 17030
	public struct IFinishSurvivorsRougeCondition : IFlatbufferObject
	{
		// Token: 0x1700745D RID: 29789
		// (get) Token: 0x06017CBD RID: 97469 RVA: 0x00365A6D File Offset: 0x00363C6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017CBE RID: 97470 RVA: 0x00365A7A File Offset: 0x00363C7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017CBF RID: 97471 RVA: 0x00365A84 File Offset: 0x00363C84
		public static IFinishSurvivorsRougeCondition GetRootAsIFinishSurvivorsRougeCondition(ByteBuffer _bb)
		{
			return IFinishSurvivorsRougeCondition.GetRootAsIFinishSurvivorsRougeCondition(_bb, default(IFinishSurvivorsRougeCondition));
		}

		// Token: 0x06017CC0 RID: 97472 RVA: 0x00365AA0 File Offset: 0x00363CA0
		public static IFinishSurvivorsRougeCondition GetRootAsIFinishSurvivorsRougeCondition(ByteBuffer _bb, IFinishSurvivorsRougeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017CC1 RID: 97473 RVA: 0x00365ABD File Offset: 0x00363CBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017CC2 RID: 97474 RVA: 0x00365ACC File Offset: 0x00363CCC
		public IFinishSurvivorsRougeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700745E RID: 29790
		// (get) Token: 0x06017CC3 RID: 97475 RVA: 0x00365ADC File Offset: 0x00363CDC
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

		// Token: 0x1700745F RID: 29791
		// (get) Token: 0x06017CC4 RID: 97476 RVA: 0x00365B18 File Offset: 0x00363D18
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

		// Token: 0x17007460 RID: 29792
		// (get) Token: 0x06017CC5 RID: 97477 RVA: 0x00365B78 File Offset: 0x00363D78
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

		// Token: 0x06017CC6 RID: 97478 RVA: 0x00365BB4 File Offset: 0x00363DB4
		public TTable? Step<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017CC7 RID: 97479 RVA: 0x00365BFC File Offset: 0x00363DFC
		public ISurvivorsRougeConditionStepBattle StepAsISurvivorsRougeConditionStepBattle()
		{
			return this.Step<ISurvivorsRougeConditionStepBattle>().Value;
		}

		// Token: 0x06017CC8 RID: 97480 RVA: 0x00365C18 File Offset: 0x00363E18
		public ISurvivorsRougeConditionStepChestReward StepAsISurvivorsRougeConditionStepChestReward()
		{
			return this.Step<ISurvivorsRougeConditionStepChestReward>().Value;
		}

		// Token: 0x06017CC9 RID: 97481 RVA: 0x00365C34 File Offset: 0x00363E34
		public ISurvivorsRougeConditionStepChooseItem StepAsISurvivorsRougeConditionStepChooseItem()
		{
			return this.Step<ISurvivorsRougeConditionStepChooseItem>().Value;
		}

		// Token: 0x06017CCA RID: 97482 RVA: 0x00365C50 File Offset: 0x00363E50
		public ISurvivorsRougeConditionStepChooseWeapon StepAsISurvivorsRougeConditionStepChooseWeapon()
		{
			return this.Step<ISurvivorsRougeConditionStepChooseWeapon>().Value;
		}

		// Token: 0x06017CCB RID: 97483 RVA: 0x00365C6C File Offset: 0x00363E6C
		public ISurvivorsRougeConditionStepEnd StepAsISurvivorsRougeConditionStepEnd()
		{
			return this.Step<ISurvivorsRougeConditionStepEnd>().Value;
		}

		// Token: 0x06017CCC RID: 97484 RVA: 0x00365C88 File Offset: 0x00363E88
		public ISurvivorsRougeConditionStepPrepare StepAsISurvivorsRougeConditionStepPrepare()
		{
			return this.Step<ISurvivorsRougeConditionStepPrepare>().Value;
		}

		// Token: 0x06017CCD RID: 97485 RVA: 0x00365CA4 File Offset: 0x00363EA4
		public ISurvivorsRougeConditionStepShopping StepAsISurvivorsRougeConditionStepShopping()
		{
			return this.Step<ISurvivorsRougeConditionStepShopping>().Value;
		}

		// Token: 0x17007461 RID: 29793
		// (get) Token: 0x06017CCE RID: 97486 RVA: 0x00365CC0 File Offset: 0x00363EC0
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

		// Token: 0x06017CCF RID: 97487 RVA: 0x00365D00 File Offset: 0x00363F00
		public TTable? Batch<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017CD0 RID: 97488 RVA: 0x00365D48 File Offset: 0x00363F48
		public IConstVarRef BatchAsIConstVarRef()
		{
			return this.Batch<IConstVarRef>().Value;
		}

		// Token: 0x06017CD1 RID: 97489 RVA: 0x00365D64 File Offset: 0x00363F64
		public IGlobalVarRef BatchAsIGlobalVarRef()
		{
			return this.Batch<IGlobalVarRef>().Value;
		}

		// Token: 0x06017CD2 RID: 97490 RVA: 0x00365D80 File Offset: 0x00363F80
		public IOtherVarRef BatchAsIOtherVarRef()
		{
			return this.Batch<IOtherVarRef>().Value;
		}

		// Token: 0x06017CD3 RID: 97491 RVA: 0x00365D9C File Offset: 0x00363F9C
		public ISelfVarRef BatchAsISelfVarRef()
		{
			return this.Batch<ISelfVarRef>().Value;
		}

		// Token: 0x06017CD4 RID: 97492 RVA: 0x00365DB8 File Offset: 0x00363FB8
		public ISystemVarRef BatchAsISystemVarRef()
		{
			return this.Batch<ISystemVarRef>().Value;
		}

		// Token: 0x06017CD5 RID: 97493 RVA: 0x00365DD3 File Offset: 0x00363FD3
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

		// Token: 0x06017CD6 RID: 97494 RVA: 0x00365E0F File Offset: 0x0036400F
		public static void StartIFinishSurvivorsRougeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06017CD7 RID: 97495 RVA: 0x00365E18 File Offset: 0x00364018
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017CD8 RID: 97496 RVA: 0x00365E23 File Offset: 0x00364023
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017CD9 RID: 97497 RVA: 0x00365E33 File Offset: 0x00364033
		public static void AddStepType(FlatBufferBuilder builder, TSurvivorsRougeConditionStep stepType)
		{
			builder.AddByte(2, (byte)stepType, 0);
		}

		// Token: 0x06017CDA RID: 97498 RVA: 0x00365E3E File Offset: 0x0036403E
		public static void AddStep(FlatBufferBuilder builder, int stepOffset)
		{
			builder.AddOffset(3, stepOffset, 0);
		}

		// Token: 0x06017CDB RID: 97499 RVA: 0x00365E49 File Offset: 0x00364049
		public static void AddBatchType(FlatBufferBuilder builder, TVarRef batchType)
		{
			builder.AddByte(4, (byte)batchType, 0);
		}

		// Token: 0x06017CDC RID: 97500 RVA: 0x00365E54 File Offset: 0x00364054
		public static void AddBatch(FlatBufferBuilder builder, int batchOffset)
		{
			builder.AddOffset(5, batchOffset, 0);
		}

		// Token: 0x06017CDD RID: 97501 RVA: 0x00365E5F File Offset: 0x0036405F
		public static Offset<IFinishSurvivorsRougeCondition> EndIFinishSurvivorsRougeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFinishSurvivorsRougeCondition>(builder.EndTable());
		}

		// Token: 0x06017CDE RID: 97502 RVA: 0x00365E6C File Offset: 0x0036406C
		public IFinishSurvivorsRougeConditionT UnPack()
		{
			IFinishSurvivorsRougeConditionT finishSurvivorsRougeConditionT = new IFinishSurvivorsRougeConditionT();
			this.UnPackTo(finishSurvivorsRougeConditionT);
			return finishSurvivorsRougeConditionT;
		}

		// Token: 0x06017CDF RID: 97503 RVA: 0x00365E88 File Offset: 0x00364088
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

		// Token: 0x06017CE0 RID: 97504 RVA: 0x0036620C File Offset: 0x0036440C
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

		// Token: 0x0400C1C3 RID: 49603
		private Table __p;
	}
}
