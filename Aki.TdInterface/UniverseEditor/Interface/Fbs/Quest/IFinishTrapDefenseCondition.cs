using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E51 RID: 15953
	public struct IFinishTrapDefenseCondition : IFlatbufferObject
	{
		// Token: 0x17006E9B RID: 28315
		// (get) Token: 0x0601671B RID: 91931 RVA: 0x0033EA02 File Offset: 0x0033CC02
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601671C RID: 91932 RVA: 0x0033EA0F File Offset: 0x0033CC0F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601671D RID: 91933 RVA: 0x0033EA18 File Offset: 0x0033CC18
		public static IFinishTrapDefenseCondition GetRootAsIFinishTrapDefenseCondition(ByteBuffer _bb)
		{
			return IFinishTrapDefenseCondition.GetRootAsIFinishTrapDefenseCondition(_bb, default(IFinishTrapDefenseCondition));
		}

		// Token: 0x0601671E RID: 91934 RVA: 0x0033EA34 File Offset: 0x0033CC34
		public static IFinishTrapDefenseCondition GetRootAsIFinishTrapDefenseCondition(ByteBuffer _bb, IFinishTrapDefenseCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601671F RID: 91935 RVA: 0x0033EA51 File Offset: 0x0033CC51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016720 RID: 91936 RVA: 0x0033EA60 File Offset: 0x0033CC60
		public IFinishTrapDefenseCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E9C RID: 28316
		// (get) Token: 0x06016721 RID: 91937 RVA: 0x0033EA70 File Offset: 0x0033CC70
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

		// Token: 0x17006E9D RID: 28317
		// (get) Token: 0x06016722 RID: 91938 RVA: 0x0033EAAC File Offset: 0x0033CCAC
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

		// Token: 0x17006E9E RID: 28318
		// (get) Token: 0x06016723 RID: 91939 RVA: 0x0033EB0C File Offset: 0x0033CD0C
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

		// Token: 0x06016724 RID: 91940 RVA: 0x0033EB48 File Offset: 0x0033CD48
		public TTable? Step<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06016725 RID: 91941 RVA: 0x0033EB90 File Offset: 0x0033CD90
		public ITrapDefenseConditionStepLoadAndRestoreMap StepAsITrapDefenseConditionStepLoadAndRestoreMap()
		{
			return this.Step<ITrapDefenseConditionStepLoadAndRestoreMap>().Value;
		}

		// Token: 0x06016726 RID: 91942 RVA: 0x0033EBAC File Offset: 0x0033CDAC
		public ITrapDefenseConditionStepMapChange StepAsITrapDefenseConditionStepMapChange()
		{
			return this.Step<ITrapDefenseConditionStepMapChange>().Value;
		}

		// Token: 0x06016727 RID: 91943 RVA: 0x0033EBC8 File Offset: 0x0033CDC8
		public ITrapDefenseConditionStepPreview StepAsITrapDefenseConditionStepPreview()
		{
			return this.Step<ITrapDefenseConditionStepPreview>().Value;
		}

		// Token: 0x06016728 RID: 91944 RVA: 0x0033EBE4 File Offset: 0x0033CDE4
		public ITrapDefenseConditionStepReward StepAsITrapDefenseConditionStepReward()
		{
			return this.Step<ITrapDefenseConditionStepReward>().Value;
		}

		// Token: 0x06016729 RID: 91945 RVA: 0x0033EC00 File Offset: 0x0033CE00
		public ITrapDefenseConditionStepSpawnMonster StepAsITrapDefenseConditionStepSpawnMonster()
		{
			return this.Step<ITrapDefenseConditionStepSpawnMonster>().Value;
		}

		// Token: 0x17006E9F RID: 28319
		// (get) Token: 0x0601672A RID: 91946 RVA: 0x0033EC1C File Offset: 0x0033CE1C
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

		// Token: 0x0601672B RID: 91947 RVA: 0x0033EC5C File Offset: 0x0033CE5C
		public TTable? Batch<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601672C RID: 91948 RVA: 0x0033ECA4 File Offset: 0x0033CEA4
		public IConstVarRef BatchAsIConstVarRef()
		{
			return this.Batch<IConstVarRef>().Value;
		}

		// Token: 0x0601672D RID: 91949 RVA: 0x0033ECC0 File Offset: 0x0033CEC0
		public IGlobalVarRef BatchAsIGlobalVarRef()
		{
			return this.Batch<IGlobalVarRef>().Value;
		}

		// Token: 0x0601672E RID: 91950 RVA: 0x0033ECDC File Offset: 0x0033CEDC
		public IOtherVarRef BatchAsIOtherVarRef()
		{
			return this.Batch<IOtherVarRef>().Value;
		}

		// Token: 0x0601672F RID: 91951 RVA: 0x0033ECF8 File Offset: 0x0033CEF8
		public ISelfVarRef BatchAsISelfVarRef()
		{
			return this.Batch<ISelfVarRef>().Value;
		}

		// Token: 0x06016730 RID: 91952 RVA: 0x0033ED14 File Offset: 0x0033CF14
		public ISystemVarRef BatchAsISystemVarRef()
		{
			return this.Batch<ISystemVarRef>().Value;
		}

		// Token: 0x17006EA0 RID: 28320
		// (get) Token: 0x06016731 RID: 91953 RVA: 0x0033ED30 File Offset: 0x0033CF30
		public bool NeedArchive
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006EA1 RID: 28321
		// (get) Token: 0x06016732 RID: 91954 RVA: 0x0033ED70 File Offset: 0x0033CF70
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

		// Token: 0x06016733 RID: 91955 RVA: 0x0033EDB0 File Offset: 0x0033CFB0
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

		// Token: 0x06016734 RID: 91956 RVA: 0x0033EE07 File Offset: 0x0033D007
		public static void StartIFinishTrapDefenseCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06016735 RID: 91957 RVA: 0x0033EE10 File Offset: 0x0033D010
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016736 RID: 91958 RVA: 0x0033EE1B File Offset: 0x0033D01B
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06016737 RID: 91959 RVA: 0x0033EE2B File Offset: 0x0033D02B
		public static void AddStepType(FlatBufferBuilder builder, TTrapDefenseConditionStep stepType)
		{
			builder.AddByte(2, (byte)stepType, 0);
		}

		// Token: 0x06016738 RID: 91960 RVA: 0x0033EE36 File Offset: 0x0033D036
		public static void AddStep(FlatBufferBuilder builder, int stepOffset)
		{
			builder.AddOffset(3, stepOffset, 0);
		}

		// Token: 0x06016739 RID: 91961 RVA: 0x0033EE41 File Offset: 0x0033D041
		public static void AddBatchType(FlatBufferBuilder builder, TVarRef batchType)
		{
			builder.AddByte(4, (byte)batchType, 0);
		}

		// Token: 0x0601673A RID: 91962 RVA: 0x0033EE4C File Offset: 0x0033D04C
		public static void AddBatch(FlatBufferBuilder builder, int batchOffset)
		{
			builder.AddOffset(5, batchOffset, 0);
		}

		// Token: 0x0601673B RID: 91963 RVA: 0x0033EE57 File Offset: 0x0033D057
		public static void AddNeedArchive(FlatBufferBuilder builder, bool needArchive)
		{
			builder.AddBool(6, needArchive, false);
		}

		// Token: 0x0601673C RID: 91964 RVA: 0x0033EE62 File Offset: 0x0033D062
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0601673D RID: 91965 RVA: 0x0033EE6D File Offset: 0x0033D06D
		public static Offset<IFinishTrapDefenseCondition> EndIFinishTrapDefenseCondition(FlatBufferBuilder builder)
		{
			return new Offset<IFinishTrapDefenseCondition>(builder.EndTable());
		}

		// Token: 0x0601673E RID: 91966 RVA: 0x0033EE7C File Offset: 0x0033D07C
		public IFinishTrapDefenseConditionT UnPack()
		{
			IFinishTrapDefenseConditionT finishTrapDefenseConditionT = new IFinishTrapDefenseConditionT();
			this.UnPackTo(finishTrapDefenseConditionT);
			return finishTrapDefenseConditionT;
		}

		// Token: 0x0601673F RID: 91967 RVA: 0x0033EE98 File Offset: 0x0033D098
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

		// Token: 0x06016740 RID: 91968 RVA: 0x0033F1C4 File Offset: 0x0033D3C4
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

		// Token: 0x0400B7FE RID: 47102
		private Table __p;
	}
}
