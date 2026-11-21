using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046E5 RID: 18149
	public struct IWalkingPatternCondition : IFlatbufferObject
	{
		// Token: 0x17007F23 RID: 32547
		// (get) Token: 0x0601AB12 RID: 109330 RVA: 0x003CB3D7 File Offset: 0x003C95D7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AB13 RID: 109331 RVA: 0x003CB3E4 File Offset: 0x003C95E4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AB14 RID: 109332 RVA: 0x003CB3EC File Offset: 0x003C95EC
		public static IWalkingPatternCondition GetRootAsIWalkingPatternCondition(ByteBuffer _bb)
		{
			return IWalkingPatternCondition.GetRootAsIWalkingPatternCondition(_bb, default(IWalkingPatternCondition));
		}

		// Token: 0x0601AB15 RID: 109333 RVA: 0x003CB408 File Offset: 0x003C9608
		public static IWalkingPatternCondition GetRootAsIWalkingPatternCondition(ByteBuffer _bb, IWalkingPatternCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AB16 RID: 109334 RVA: 0x003CB425 File Offset: 0x003C9625
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AB17 RID: 109335 RVA: 0x003CB434 File Offset: 0x003C9634
		public IWalkingPatternCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F24 RID: 32548
		// (get) Token: 0x0601AB18 RID: 109336 RVA: 0x003CB444 File Offset: 0x003C9644
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

		// Token: 0x17007F25 RID: 32549
		// (get) Token: 0x0601AB19 RID: 109337 RVA: 0x003CB480 File Offset: 0x003C9680
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

		// Token: 0x17007F26 RID: 32550
		// (get) Token: 0x0601AB1A RID: 109338 RVA: 0x003CB4E0 File Offset: 0x003C96E0
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007F27 RID: 32551
		// (get) Token: 0x0601AB1B RID: 109339 RVA: 0x003CB51C File Offset: 0x003C971C
		public int EndEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007F28 RID: 32552
		// (get) Token: 0x0601AB1C RID: 109340 RVA: 0x003CB55C File Offset: 0x003C975C
		public TVarRef ScoreVarType
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

		// Token: 0x0601AB1D RID: 109341 RVA: 0x003CB59C File Offset: 0x003C979C
		public TTable? ScoreVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601AB1E RID: 109342 RVA: 0x003CB5E4 File Offset: 0x003C97E4
		public IConstVarRef ScoreVarAsIConstVarRef()
		{
			return this.ScoreVar<IConstVarRef>().Value;
		}

		// Token: 0x0601AB1F RID: 109343 RVA: 0x003CB600 File Offset: 0x003C9800
		public IGlobalVarRef ScoreVarAsIGlobalVarRef()
		{
			return this.ScoreVar<IGlobalVarRef>().Value;
		}

		// Token: 0x0601AB20 RID: 109344 RVA: 0x003CB61C File Offset: 0x003C981C
		public IOtherVarRef ScoreVarAsIOtherVarRef()
		{
			return this.ScoreVar<IOtherVarRef>().Value;
		}

		// Token: 0x0601AB21 RID: 109345 RVA: 0x003CB638 File Offset: 0x003C9838
		public ISelfVarRef ScoreVarAsISelfVarRef()
		{
			return this.ScoreVar<ISelfVarRef>().Value;
		}

		// Token: 0x0601AB22 RID: 109346 RVA: 0x003CB654 File Offset: 0x003C9854
		public ISystemVarRef ScoreVarAsISystemVarRef()
		{
			return this.ScoreVar<ISystemVarRef>().Value;
		}

		// Token: 0x0601AB23 RID: 109347 RVA: 0x003CB66F File Offset: 0x003C986F
		public static Offset<IWalkingPatternCondition> CreateIWalkingPatternCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int SplineEntityId = 0, int EndEntityId = 0, TVarRef ScoreVar_type = TVarRef.NONE, int ScoreVarOffset = 0)
		{
			builder.StartTable(6);
			IWalkingPatternCondition.AddScoreVar(builder, ScoreVarOffset);
			IWalkingPatternCondition.AddEndEntityId(builder, EndEntityId);
			IWalkingPatternCondition.AddSplineEntityId(builder, SplineEntityId);
			IWalkingPatternCondition.AddPreConditions(builder, PreConditionsOffset);
			IWalkingPatternCondition.AddScoreVarType(builder, ScoreVar_type);
			IWalkingPatternCondition.AddType(builder, Type);
			return IWalkingPatternCondition.EndIWalkingPatternCondition(builder);
		}

		// Token: 0x0601AB24 RID: 109348 RVA: 0x003CB6AB File Offset: 0x003C98AB
		public static void StartIWalkingPatternCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601AB25 RID: 109349 RVA: 0x003CB6B4 File Offset: 0x003C98B4
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AB26 RID: 109350 RVA: 0x003CB6BF File Offset: 0x003C98BF
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601AB27 RID: 109351 RVA: 0x003CB6CF File Offset: 0x003C98CF
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(2, splineEntityId, 0);
		}

		// Token: 0x0601AB28 RID: 109352 RVA: 0x003CB6DA File Offset: 0x003C98DA
		public static void AddEndEntityId(FlatBufferBuilder builder, int endEntityId)
		{
			builder.AddInt(3, endEntityId, 0);
		}

		// Token: 0x0601AB29 RID: 109353 RVA: 0x003CB6E5 File Offset: 0x003C98E5
		public static void AddScoreVarType(FlatBufferBuilder builder, TVarRef scoreVarType)
		{
			builder.AddByte(4, (byte)scoreVarType, 0);
		}

		// Token: 0x0601AB2A RID: 109354 RVA: 0x003CB6F0 File Offset: 0x003C98F0
		public static void AddScoreVar(FlatBufferBuilder builder, int scoreVarOffset)
		{
			builder.AddOffset(5, scoreVarOffset, 0);
		}

		// Token: 0x0601AB2B RID: 109355 RVA: 0x003CB6FB File Offset: 0x003C98FB
		public static Offset<IWalkingPatternCondition> EndIWalkingPatternCondition(FlatBufferBuilder builder)
		{
			return new Offset<IWalkingPatternCondition>(builder.EndTable());
		}

		// Token: 0x0601AB2C RID: 109356 RVA: 0x003CB708 File Offset: 0x003C9908
		public IWalkingPatternConditionT UnPack()
		{
			IWalkingPatternConditionT walkingPatternConditionT = new IWalkingPatternConditionT();
			this.UnPackTo(walkingPatternConditionT);
			return walkingPatternConditionT;
		}

		// Token: 0x0601AB2D RID: 109357 RVA: 0x003CB724 File Offset: 0x003C9924
		public void UnPackTo(IWalkingPatternConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.SplineEntityId = this.SplineEntityId;
			_o.EndEntityId = this.EndEntityId;
			_o.ScoreVar = new TVarRefUnion();
			_o.ScoreVar.Type = this.ScoreVarType;
			switch (this.ScoreVarType)
			{
			case TVarRef.IConstVarRef:
				_o.ScoreVar.Value = ((this.ScoreVar<IConstVarRef>() != null) ? this.ScoreVar<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.ScoreVar.Value = ((this.ScoreVar<IGlobalVarRef>() != null) ? this.ScoreVar<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.ScoreVar.Value = ((this.ScoreVar<IOtherVarRef>() != null) ? this.ScoreVar<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.ScoreVar.Value = ((this.ScoreVar<ISelfVarRef>() != null) ? this.ScoreVar<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.ScoreVar.Value = ((this.ScoreVar<ISystemVarRef>() != null) ? this.ScoreVar<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601AB2E RID: 109358 RVA: 0x003CB8DC File Offset: 0x003C9ADC
		public static Offset<IWalkingPatternCondition> Pack(FlatBufferBuilder builder, IWalkingPatternConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWalkingPatternCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			TVarRef scoreVar_type = (_o.ScoreVar == null) ? TVarRef.NONE : _o.ScoreVar.Type;
			int scoreVarOffset = (_o.ScoreVar == null) ? 0 : TVarRefUnion.Pack(builder, _o.ScoreVar);
			return IWalkingPatternCondition.CreateIWalkingPatternCondition(builder, _o.Type, preConditionsOffset, _o.SplineEntityId, _o.EndEntityId, scoreVar_type, scoreVarOffset);
		}

		// Token: 0x0400C934 RID: 51508
		private Table __p;
	}
}
