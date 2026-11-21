using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200427A RID: 17018
	public struct IFinishKurotatoCondition : IFlatbufferObject
	{
		// Token: 0x17007426 RID: 29734
		// (get) Token: 0x06017BCA RID: 97226 RVA: 0x00362B33 File Offset: 0x00360D33
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017BCB RID: 97227 RVA: 0x00362B40 File Offset: 0x00360D40
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017BCC RID: 97228 RVA: 0x00362B48 File Offset: 0x00360D48
		public static IFinishKurotatoCondition GetRootAsIFinishKurotatoCondition(ByteBuffer _bb)
		{
			return IFinishKurotatoCondition.GetRootAsIFinishKurotatoCondition(_bb, default(IFinishKurotatoCondition));
		}

		// Token: 0x06017BCD RID: 97229 RVA: 0x00362B64 File Offset: 0x00360D64
		public static IFinishKurotatoCondition GetRootAsIFinishKurotatoCondition(ByteBuffer _bb, IFinishKurotatoCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017BCE RID: 97230 RVA: 0x00362B81 File Offset: 0x00360D81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017BCF RID: 97231 RVA: 0x00362B90 File Offset: 0x00360D90
		public IFinishKurotatoCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007427 RID: 29735
		// (get) Token: 0x06017BD0 RID: 97232 RVA: 0x00362BA0 File Offset: 0x00360DA0
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

		// Token: 0x17007428 RID: 29736
		// (get) Token: 0x06017BD1 RID: 97233 RVA: 0x00362BDC File Offset: 0x00360DDC
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

		// Token: 0x17007429 RID: 29737
		// (get) Token: 0x06017BD2 RID: 97234 RVA: 0x00362C3C File Offset: 0x00360E3C
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

		// Token: 0x06017BD3 RID: 97235 RVA: 0x00362C78 File Offset: 0x00360E78
		public TTable? Step<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017BD4 RID: 97236 RVA: 0x00362CC0 File Offset: 0x00360EC0
		public IKurotatoConditionStepBattle StepAsIKurotatoConditionStepBattle()
		{
			return this.Step<IKurotatoConditionStepBattle>().Value;
		}

		// Token: 0x06017BD5 RID: 97237 RVA: 0x00362CDC File Offset: 0x00360EDC
		public IKurotatoConditionStepChestReward StepAsIKurotatoConditionStepChestReward()
		{
			return this.Step<IKurotatoConditionStepChestReward>().Value;
		}

		// Token: 0x06017BD6 RID: 97238 RVA: 0x00362CF8 File Offset: 0x00360EF8
		public IKurotatoConditionStepEnd StepAsIKurotatoConditionStepEnd()
		{
			return this.Step<IKurotatoConditionStepEnd>().Value;
		}

		// Token: 0x06017BD7 RID: 97239 RVA: 0x00362D14 File Offset: 0x00360F14
		public IKurotatoConditionStepPrepare StepAsIKurotatoConditionStepPrepare()
		{
			return this.Step<IKurotatoConditionStepPrepare>().Value;
		}

		// Token: 0x06017BD8 RID: 97240 RVA: 0x00362D30 File Offset: 0x00360F30
		public IKurotatoConditionStepSaveRole StepAsIKurotatoConditionStepSaveRole()
		{
			return this.Step<IKurotatoConditionStepSaveRole>().Value;
		}

		// Token: 0x06017BD9 RID: 97241 RVA: 0x00362D4C File Offset: 0x00360F4C
		public IKurotatoConditionStepShopping StepAsIKurotatoConditionStepShopping()
		{
			return this.Step<IKurotatoConditionStepShopping>().Value;
		}

		// Token: 0x06017BDA RID: 97242 RVA: 0x00362D68 File Offset: 0x00360F68
		public IKurotatoConditionStepUpdateBatch StepAsIKurotatoConditionStepUpdateBatch()
		{
			return this.Step<IKurotatoConditionStepUpdateBatch>().Value;
		}

		// Token: 0x06017BDB RID: 97243 RVA: 0x00362D84 File Offset: 0x00360F84
		public IKurotatoConditionStepUpgradeReward StepAsIKurotatoConditionStepUpgradeReward()
		{
			return this.Step<IKurotatoConditionStepUpgradeReward>().Value;
		}

		// Token: 0x1700742A RID: 29738
		// (get) Token: 0x06017BDC RID: 97244 RVA: 0x00362DA0 File Offset: 0x00360FA0
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

		// Token: 0x06017BDD RID: 97245 RVA: 0x00362DE0 File Offset: 0x00360FE0
		public TTable? Batch<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017BDE RID: 97246 RVA: 0x00362E28 File Offset: 0x00361028
		public IConstVarRef BatchAsIConstVarRef()
		{
			return this.Batch<IConstVarRef>().Value;
		}

		// Token: 0x06017BDF RID: 97247 RVA: 0x00362E44 File Offset: 0x00361044
		public IGlobalVarRef BatchAsIGlobalVarRef()
		{
			return this.Batch<IGlobalVarRef>().Value;
		}

		// Token: 0x06017BE0 RID: 97248 RVA: 0x00362E60 File Offset: 0x00361060
		public IOtherVarRef BatchAsIOtherVarRef()
		{
			return this.Batch<IOtherVarRef>().Value;
		}

		// Token: 0x06017BE1 RID: 97249 RVA: 0x00362E7C File Offset: 0x0036107C
		public ISelfVarRef BatchAsISelfVarRef()
		{
			return this.Batch<ISelfVarRef>().Value;
		}

		// Token: 0x06017BE2 RID: 97250 RVA: 0x00362E98 File Offset: 0x00361098
		public ISystemVarRef BatchAsISystemVarRef()
		{
			return this.Batch<ISystemVarRef>().Value;
		}

		// Token: 0x06017BE3 RID: 97251 RVA: 0x00362EB3 File Offset: 0x003610B3
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

		// Token: 0x06017BE4 RID: 97252 RVA: 0x00362EEF File Offset: 0x003610EF
		public static void StartIFinishKurotatoCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06017BE5 RID: 97253 RVA: 0x00362EF8 File Offset: 0x003610F8
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017BE6 RID: 97254 RVA: 0x00362F03 File Offset: 0x00361103
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017BE7 RID: 97255 RVA: 0x00362F13 File Offset: 0x00361113
		public static void AddStepType(FlatBufferBuilder builder, TKurotatoConditionStep stepType)
		{
			builder.AddByte(2, (byte)stepType, 0);
		}

		// Token: 0x06017BE8 RID: 97256 RVA: 0x00362F1E File Offset: 0x0036111E
		public static void AddStep(FlatBufferBuilder builder, int stepOffset)
		{
			builder.AddOffset(3, stepOffset, 0);
		}

		// Token: 0x06017BE9 RID: 97257 RVA: 0x00362F29 File Offset: 0x00361129
		public static void AddBatchType(FlatBufferBuilder builder, TVarRef batchType)
		{
			builder.AddByte(4, (byte)batchType, 0);
		}

		// Token: 0x06017BEA RID: 97258 RVA: 0x00362F34 File Offset: 0x00361134
		public static void AddBatch(FlatBufferBuilder builder, int batchOffset)
		{
			builder.AddOffset(5, batchOffset, 0);
		}

		// Token: 0x06017BEB RID: 97259 RVA: 0x00362F3F File Offset: 0x0036113F
		public static Offset<IFinishKurotatoCondition> EndIFinishKurotatoCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFinishKurotatoCondition>(builder.EndTable());
		}

		// Token: 0x06017BEC RID: 97260 RVA: 0x00362F4C File Offset: 0x0036114C
		public IFinishKurotatoConditionT UnPack()
		{
			IFinishKurotatoConditionT finishKurotatoConditionT = new IFinishKurotatoConditionT();
			this.UnPackTo(finishKurotatoConditionT);
			return finishKurotatoConditionT;
		}

		// Token: 0x06017BED RID: 97261 RVA: 0x00362F68 File Offset: 0x00361168
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

		// Token: 0x06017BEE RID: 97262 RVA: 0x0036332C File Offset: 0x0036152C
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

		// Token: 0x0400C1A6 RID: 49574
		private Table __p;
	}
}
