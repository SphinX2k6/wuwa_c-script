using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004289 RID: 17033
	public struct IWalkingPatternCondition : IFlatbufferObject
	{
		// Token: 0x170078F2 RID: 30962
		// (get) Token: 0x060193A6 RID: 103334 RVA: 0x0039FCFF File Offset: 0x0039DEFF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060193A7 RID: 103335 RVA: 0x0039FD0C File Offset: 0x0039DF0C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060193A8 RID: 103336 RVA: 0x0039FD14 File Offset: 0x0039DF14
		public static IWalkingPatternCondition GetRootAsIWalkingPatternCondition(ByteBuffer _bb)
		{
			return IWalkingPatternCondition.GetRootAsIWalkingPatternCondition(_bb, default(IWalkingPatternCondition));
		}

		// Token: 0x060193A9 RID: 103337 RVA: 0x0039FD30 File Offset: 0x0039DF30
		public static IWalkingPatternCondition GetRootAsIWalkingPatternCondition(ByteBuffer _bb, IWalkingPatternCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060193AA RID: 103338 RVA: 0x0039FD4D File Offset: 0x0039DF4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060193AB RID: 103339 RVA: 0x0039FD5C File Offset: 0x0039DF5C
		public IWalkingPatternCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170078F3 RID: 30963
		// (get) Token: 0x060193AC RID: 103340 RVA: 0x0039FD6C File Offset: 0x0039DF6C
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

		// Token: 0x170078F4 RID: 30964
		// (get) Token: 0x060193AD RID: 103341 RVA: 0x0039FDA8 File Offset: 0x0039DFA8
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

		// Token: 0x170078F5 RID: 30965
		// (get) Token: 0x060193AE RID: 103342 RVA: 0x0039FE08 File Offset: 0x0039E008
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

		// Token: 0x170078F6 RID: 30966
		// (get) Token: 0x060193AF RID: 103343 RVA: 0x0039FE44 File Offset: 0x0039E044
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

		// Token: 0x170078F7 RID: 30967
		// (get) Token: 0x060193B0 RID: 103344 RVA: 0x0039FE84 File Offset: 0x0039E084
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

		// Token: 0x060193B1 RID: 103345 RVA: 0x0039FEC4 File Offset: 0x0039E0C4
		public TTable? ScoreVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060193B2 RID: 103346 RVA: 0x0039FF0C File Offset: 0x0039E10C
		public IConstVarRef ScoreVarAsIConstVarRef()
		{
			return this.ScoreVar<IConstVarRef>().Value;
		}

		// Token: 0x060193B3 RID: 103347 RVA: 0x0039FF28 File Offset: 0x0039E128
		public IGlobalVarRef ScoreVarAsIGlobalVarRef()
		{
			return this.ScoreVar<IGlobalVarRef>().Value;
		}

		// Token: 0x060193B4 RID: 103348 RVA: 0x0039FF44 File Offset: 0x0039E144
		public IOtherVarRef ScoreVarAsIOtherVarRef()
		{
			return this.ScoreVar<IOtherVarRef>().Value;
		}

		// Token: 0x060193B5 RID: 103349 RVA: 0x0039FF60 File Offset: 0x0039E160
		public ISelfVarRef ScoreVarAsISelfVarRef()
		{
			return this.ScoreVar<ISelfVarRef>().Value;
		}

		// Token: 0x060193B6 RID: 103350 RVA: 0x0039FF7C File Offset: 0x0039E17C
		public ISystemVarRef ScoreVarAsISystemVarRef()
		{
			return this.ScoreVar<ISystemVarRef>().Value;
		}

		// Token: 0x060193B7 RID: 103351 RVA: 0x0039FF97 File Offset: 0x0039E197
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

		// Token: 0x060193B8 RID: 103352 RVA: 0x0039FFD3 File Offset: 0x0039E1D3
		public static void StartIWalkingPatternCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060193B9 RID: 103353 RVA: 0x0039FFDC File Offset: 0x0039E1DC
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060193BA RID: 103354 RVA: 0x0039FFE7 File Offset: 0x0039E1E7
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060193BB RID: 103355 RVA: 0x0039FFF7 File Offset: 0x0039E1F7
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(2, splineEntityId, 0);
		}

		// Token: 0x060193BC RID: 103356 RVA: 0x003A0002 File Offset: 0x0039E202
		public static void AddEndEntityId(FlatBufferBuilder builder, int endEntityId)
		{
			builder.AddInt(3, endEntityId, 0);
		}

		// Token: 0x060193BD RID: 103357 RVA: 0x003A000D File Offset: 0x0039E20D
		public static void AddScoreVarType(FlatBufferBuilder builder, TVarRef scoreVarType)
		{
			builder.AddByte(4, (byte)scoreVarType, 0);
		}

		// Token: 0x060193BE RID: 103358 RVA: 0x003A0018 File Offset: 0x0039E218
		public static void AddScoreVar(FlatBufferBuilder builder, int scoreVarOffset)
		{
			builder.AddOffset(5, scoreVarOffset, 0);
		}

		// Token: 0x060193BF RID: 103359 RVA: 0x003A0023 File Offset: 0x0039E223
		public static Offset<IWalkingPatternCondition> EndIWalkingPatternCondition(FlatBufferBuilder builder)
		{
			return new Offset<IWalkingPatternCondition>(builder.EndTable());
		}

		// Token: 0x060193C0 RID: 103360 RVA: 0x003A0030 File Offset: 0x0039E230
		public IWalkingPatternConditionT UnPack()
		{
			IWalkingPatternConditionT walkingPatternConditionT = new IWalkingPatternConditionT();
			this.UnPackTo(walkingPatternConditionT);
			return walkingPatternConditionT;
		}

		// Token: 0x060193C1 RID: 103361 RVA: 0x003A004C File Offset: 0x0039E24C
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

		// Token: 0x060193C2 RID: 103362 RVA: 0x003A0204 File Offset: 0x0039E404
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

		// Token: 0x0400BF27 RID: 48935
		private Table __p;
	}
}
