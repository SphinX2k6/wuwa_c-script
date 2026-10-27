using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200447F RID: 17535
	public struct IDartSkill : IFlatbufferObject
	{
		// Token: 0x17007BC0 RID: 31680
		// (get) Token: 0x0601A242 RID: 107074 RVA: 0x003BBD5E File Offset: 0x003B9F5E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A243 RID: 107075 RVA: 0x003BBD6B File Offset: 0x003B9F6B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A244 RID: 107076 RVA: 0x003BBD74 File Offset: 0x003B9F74
		public static IDartSkill GetRootAsIDartSkill(ByteBuffer _bb)
		{
			return IDartSkill.GetRootAsIDartSkill(_bb, default(IDartSkill));
		}

		// Token: 0x0601A245 RID: 107077 RVA: 0x003BBD90 File Offset: 0x003B9F90
		public static IDartSkill GetRootAsIDartSkill(ByteBuffer _bb, IDartSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A246 RID: 107078 RVA: 0x003BBDAD File Offset: 0x003B9FAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A247 RID: 107079 RVA: 0x003BBDBC File Offset: 0x003B9FBC
		public IDartSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007BC1 RID: 31681
		// (get) Token: 0x0601A248 RID: 107080 RVA: 0x003BBDCC File Offset: 0x003B9FCC
		public IDartSkillConditionGroup? ConditionGroup
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IDartSkillConditionGroup?(default(IDartSkillConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007BC2 RID: 31682
		// (get) Token: 0x0601A249 RID: 107081 RVA: 0x003BBE2C File Offset: 0x003BA02C
		public TDartSkillResult ResultType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TDartSkillResult.NONE;
				}
				return (TDartSkillResult)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A24A RID: 107082 RVA: 0x003BBE68 File Offset: 0x003BA068
		public TTable? Result<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601A24B RID: 107083 RVA: 0x003BBEAC File Offset: 0x003BA0AC
		public IBlockFinishRouteResult ResultAsIBlockFinishRouteResult()
		{
			return this.Result<IBlockFinishRouteResult>().Value;
		}

		// Token: 0x0601A24C RID: 107084 RVA: 0x003BBEC8 File Offset: 0x003BA0C8
		public IHitNoScoreResult ResultAsIHitNoScoreResult()
		{
			return this.Result<IHitNoScoreResult>().Value;
		}

		// Token: 0x0601A24D RID: 107085 RVA: 0x003BBEE4 File Offset: 0x003BA0E4
		public IHitPlayerLastZoneResult ResultAsIHitPlayerLastZoneResult()
		{
			return this.Result<IHitPlayerLastZoneResult>().Value;
		}

		// Token: 0x0601A24E RID: 107086 RVA: 0x003BBF00 File Offset: 0x003BA100
		public IHitRemainScoreZoneResult ResultAsIHitRemainScoreZoneResult()
		{
			return this.Result<IHitRemainScoreZoneResult>().Value;
		}

		// Token: 0x0601A24F RID: 107087 RVA: 0x003BBF1C File Offset: 0x003BA11C
		public IHitZoneTimesResult ResultAsIHitZoneTimesResult()
		{
			return this.Result<IHitZoneTimesResult>().Value;
		}

		// Token: 0x0601A250 RID: 107088 RVA: 0x003BBF38 File Offset: 0x003BA138
		public IHoldBreathResult ResultAsIHoldBreathResult()
		{
			return this.Result<IHoldBreathResult>().Value;
		}

		// Token: 0x0601A251 RID: 107089 RVA: 0x003BBF54 File Offset: 0x003BA154
		public INoBustResult ResultAsINoBustResult()
		{
			return this.Result<INoBustResult>().Value;
		}

		// Token: 0x0601A252 RID: 107090 RVA: 0x003BBF70 File Offset: 0x003BA170
		public ITripleZoneHitResult ResultAsITripleZoneHitResult()
		{
			return this.Result<ITripleZoneHitResult>().Value;
		}

		// Token: 0x17007BC3 RID: 31683
		// (get) Token: 0x0601A253 RID: 107091 RVA: 0x003BBF8C File Offset: 0x003BA18C
		public IBubbleIndex? Bubble
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IBubbleIndex?(default(IBubbleIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601A254 RID: 107092 RVA: 0x003BBFEA File Offset: 0x003BA1EA
		public static Offset<IDartSkill> CreateIDartSkill(FlatBufferBuilder builder, Offset<IDartSkillConditionGroup> ConditionGroupOffset = default(Offset<IDartSkillConditionGroup>), TDartSkillResult Result_type = TDartSkillResult.NONE, int ResultOffset = 0, Offset<IBubbleIndex> BubbleOffset = default(Offset<IBubbleIndex>))
		{
			builder.StartTable(4);
			IDartSkill.AddBubble(builder, BubbleOffset);
			IDartSkill.AddResult(builder, ResultOffset);
			IDartSkill.AddConditionGroup(builder, ConditionGroupOffset);
			IDartSkill.AddResultType(builder, Result_type);
			return IDartSkill.EndIDartSkill(builder);
		}

		// Token: 0x0601A255 RID: 107093 RVA: 0x003BC016 File Offset: 0x003BA216
		public static void StartIDartSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601A256 RID: 107094 RVA: 0x003BC01F File Offset: 0x003BA21F
		public static void AddConditionGroup(FlatBufferBuilder builder, Offset<IDartSkillConditionGroup> conditionGroupOffset)
		{
			builder.AddOffset(0, conditionGroupOffset.Value, 0);
		}

		// Token: 0x0601A257 RID: 107095 RVA: 0x003BC02F File Offset: 0x003BA22F
		public static void AddResultType(FlatBufferBuilder builder, TDartSkillResult resultType)
		{
			builder.AddByte(1, (byte)resultType, 0);
		}

		// Token: 0x0601A258 RID: 107096 RVA: 0x003BC03A File Offset: 0x003BA23A
		public static void AddResult(FlatBufferBuilder builder, int resultOffset)
		{
			builder.AddOffset(2, resultOffset, 0);
		}

		// Token: 0x0601A259 RID: 107097 RVA: 0x003BC045 File Offset: 0x003BA245
		public static void AddBubble(FlatBufferBuilder builder, Offset<IBubbleIndex> bubbleOffset)
		{
			builder.AddOffset(3, bubbleOffset.Value, 0);
		}

		// Token: 0x0601A25A RID: 107098 RVA: 0x003BC055 File Offset: 0x003BA255
		public static Offset<IDartSkill> EndIDartSkill(FlatBufferBuilder builder)
		{
			return new Offset<IDartSkill>(builder.EndTable());
		}

		// Token: 0x0601A25B RID: 107099 RVA: 0x003BC064 File Offset: 0x003BA264
		public IDartSkillT UnPack()
		{
			IDartSkillT dartSkillT = new IDartSkillT();
			this.UnPackTo(dartSkillT);
			return dartSkillT;
		}

		// Token: 0x0601A25C RID: 107100 RVA: 0x003BC080 File Offset: 0x003BA280
		public void UnPackTo(IDartSkillT _o)
		{
			_o.ConditionGroup = ((this.ConditionGroup != null) ? this.ConditionGroup.Value.UnPack() : null);
			_o.Result = new TDartSkillResultUnion();
			_o.Result.Type = this.ResultType;
			switch (this.ResultType)
			{
			case TDartSkillResult.IBlockFinishRouteResult:
				_o.Result.Value = ((this.Result<IBlockFinishRouteResult>() != null) ? this.Result<IBlockFinishRouteResult>().Value.UnPack() : null);
				break;
			case TDartSkillResult.IHitNoScoreResult:
				_o.Result.Value = ((this.Result<IHitNoScoreResult>() != null) ? this.Result<IHitNoScoreResult>().Value.UnPack() : null);
				break;
			case TDartSkillResult.IHitPlayerLastZoneResult:
				_o.Result.Value = ((this.Result<IHitPlayerLastZoneResult>() != null) ? this.Result<IHitPlayerLastZoneResult>().Value.UnPack() : null);
				break;
			case TDartSkillResult.IHitRemainScoreZoneResult:
				_o.Result.Value = ((this.Result<IHitRemainScoreZoneResult>() != null) ? this.Result<IHitRemainScoreZoneResult>().Value.UnPack() : null);
				break;
			case TDartSkillResult.IHitZoneTimesResult:
				_o.Result.Value = ((this.Result<IHitZoneTimesResult>() != null) ? this.Result<IHitZoneTimesResult>().Value.UnPack() : null);
				break;
			case TDartSkillResult.IHoldBreathResult:
				_o.Result.Value = ((this.Result<IHoldBreathResult>() != null) ? this.Result<IHoldBreathResult>().Value.UnPack() : null);
				break;
			case TDartSkillResult.INoBustResult:
				_o.Result.Value = ((this.Result<INoBustResult>() != null) ? this.Result<INoBustResult>().Value.UnPack() : null);
				break;
			case TDartSkillResult.ITripleZoneHitResult:
				_o.Result.Value = ((this.Result<ITripleZoneHitResult>() != null) ? this.Result<ITripleZoneHitResult>().Value.UnPack() : null);
				break;
			}
			_o.Bubble = ((this.Bubble != null) ? this.Bubble.Value.UnPack() : null);
		}

		// Token: 0x0601A25D RID: 107101 RVA: 0x003BC314 File Offset: 0x003BA514
		public static Offset<IDartSkill> Pack(FlatBufferBuilder builder, IDartSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartSkill>);
			}
			Offset<IDartSkillConditionGroup> conditionGroupOffset = (_o.ConditionGroup == null) ? default(Offset<IDartSkillConditionGroup>) : IDartSkillConditionGroup.Pack(builder, _o.ConditionGroup);
			TDartSkillResult result_type = (_o.Result == null) ? TDartSkillResult.NONE : _o.Result.Type;
			int resultOffset = (_o.Result == null) ? 0 : TDartSkillResultUnion.Pack(builder, _o.Result);
			Offset<IBubbleIndex> bubbleOffset = (_o.Bubble == null) ? default(Offset<IBubbleIndex>) : IBubbleIndex.Pack(builder, _o.Bubble);
			return IDartSkill.CreateIDartSkill(builder, conditionGroupOffset, result_type, resultOffset, bubbleOffset);
		}

		// Token: 0x0400C474 RID: 50292
		private Table __p;
	}
}
