using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048E7 RID: 18663
	public struct IDartSkill : IFlatbufferObject
	{
		// Token: 0x170081FF RID: 33279
		// (get) Token: 0x0601BA13 RID: 113171 RVA: 0x003E7F6A File Offset: 0x003E616A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BA14 RID: 113172 RVA: 0x003E7F77 File Offset: 0x003E6177
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BA15 RID: 113173 RVA: 0x003E7F80 File Offset: 0x003E6180
		public static IDartSkill GetRootAsIDartSkill(ByteBuffer _bb)
		{
			return IDartSkill.GetRootAsIDartSkill(_bb, default(IDartSkill));
		}

		// Token: 0x0601BA16 RID: 113174 RVA: 0x003E7F9C File Offset: 0x003E619C
		public static IDartSkill GetRootAsIDartSkill(ByteBuffer _bb, IDartSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BA17 RID: 113175 RVA: 0x003E7FB9 File Offset: 0x003E61B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BA18 RID: 113176 RVA: 0x003E7FC8 File Offset: 0x003E61C8
		public IDartSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008200 RID: 33280
		// (get) Token: 0x0601BA19 RID: 113177 RVA: 0x003E7FD8 File Offset: 0x003E61D8
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

		// Token: 0x17008201 RID: 33281
		// (get) Token: 0x0601BA1A RID: 113178 RVA: 0x003E8038 File Offset: 0x003E6238
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

		// Token: 0x0601BA1B RID: 113179 RVA: 0x003E8074 File Offset: 0x003E6274
		public TTable? Result<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601BA1C RID: 113180 RVA: 0x003E80B8 File Offset: 0x003E62B8
		public IBlockFinishRouteResult ResultAsIBlockFinishRouteResult()
		{
			return this.Result<IBlockFinishRouteResult>().Value;
		}

		// Token: 0x0601BA1D RID: 113181 RVA: 0x003E80D4 File Offset: 0x003E62D4
		public IHitNoScoreResult ResultAsIHitNoScoreResult()
		{
			return this.Result<IHitNoScoreResult>().Value;
		}

		// Token: 0x0601BA1E RID: 113182 RVA: 0x003E80F0 File Offset: 0x003E62F0
		public IHitPlayerLastZoneResult ResultAsIHitPlayerLastZoneResult()
		{
			return this.Result<IHitPlayerLastZoneResult>().Value;
		}

		// Token: 0x0601BA1F RID: 113183 RVA: 0x003E810C File Offset: 0x003E630C
		public IHitRemainScoreZoneResult ResultAsIHitRemainScoreZoneResult()
		{
			return this.Result<IHitRemainScoreZoneResult>().Value;
		}

		// Token: 0x0601BA20 RID: 113184 RVA: 0x003E8128 File Offset: 0x003E6328
		public IHitZoneTimesResult ResultAsIHitZoneTimesResult()
		{
			return this.Result<IHitZoneTimesResult>().Value;
		}

		// Token: 0x0601BA21 RID: 113185 RVA: 0x003E8144 File Offset: 0x003E6344
		public IHoldBreathResult ResultAsIHoldBreathResult()
		{
			return this.Result<IHoldBreathResult>().Value;
		}

		// Token: 0x0601BA22 RID: 113186 RVA: 0x003E8160 File Offset: 0x003E6360
		public INoBustResult ResultAsINoBustResult()
		{
			return this.Result<INoBustResult>().Value;
		}

		// Token: 0x0601BA23 RID: 113187 RVA: 0x003E817C File Offset: 0x003E637C
		public ITripleZoneHitResult ResultAsITripleZoneHitResult()
		{
			return this.Result<ITripleZoneHitResult>().Value;
		}

		// Token: 0x17008202 RID: 33282
		// (get) Token: 0x0601BA24 RID: 113188 RVA: 0x003E8198 File Offset: 0x003E6398
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

		// Token: 0x0601BA25 RID: 113189 RVA: 0x003E81F6 File Offset: 0x003E63F6
		public static Offset<IDartSkill> CreateIDartSkill(FlatBufferBuilder builder, Offset<IDartSkillConditionGroup> ConditionGroupOffset = default(Offset<IDartSkillConditionGroup>), TDartSkillResult Result_type = TDartSkillResult.NONE, int ResultOffset = 0, Offset<IBubbleIndex> BubbleOffset = default(Offset<IBubbleIndex>))
		{
			builder.StartTable(4);
			IDartSkill.AddBubble(builder, BubbleOffset);
			IDartSkill.AddResult(builder, ResultOffset);
			IDartSkill.AddConditionGroup(builder, ConditionGroupOffset);
			IDartSkill.AddResultType(builder, Result_type);
			return IDartSkill.EndIDartSkill(builder);
		}

		// Token: 0x0601BA26 RID: 113190 RVA: 0x003E8222 File Offset: 0x003E6422
		public static void StartIDartSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601BA27 RID: 113191 RVA: 0x003E822B File Offset: 0x003E642B
		public static void AddConditionGroup(FlatBufferBuilder builder, Offset<IDartSkillConditionGroup> conditionGroupOffset)
		{
			builder.AddOffset(0, conditionGroupOffset.Value, 0);
		}

		// Token: 0x0601BA28 RID: 113192 RVA: 0x003E823B File Offset: 0x003E643B
		public static void AddResultType(FlatBufferBuilder builder, TDartSkillResult resultType)
		{
			builder.AddByte(1, (byte)resultType, 0);
		}

		// Token: 0x0601BA29 RID: 113193 RVA: 0x003E8246 File Offset: 0x003E6446
		public static void AddResult(FlatBufferBuilder builder, int resultOffset)
		{
			builder.AddOffset(2, resultOffset, 0);
		}

		// Token: 0x0601BA2A RID: 113194 RVA: 0x003E8251 File Offset: 0x003E6451
		public static void AddBubble(FlatBufferBuilder builder, Offset<IBubbleIndex> bubbleOffset)
		{
			builder.AddOffset(3, bubbleOffset.Value, 0);
		}

		// Token: 0x0601BA2B RID: 113195 RVA: 0x003E8261 File Offset: 0x003E6461
		public static Offset<IDartSkill> EndIDartSkill(FlatBufferBuilder builder)
		{
			return new Offset<IDartSkill>(builder.EndTable());
		}

		// Token: 0x0601BA2C RID: 113196 RVA: 0x003E8270 File Offset: 0x003E6470
		public IDartSkillT UnPack()
		{
			IDartSkillT dartSkillT = new IDartSkillT();
			this.UnPackTo(dartSkillT);
			return dartSkillT;
		}

		// Token: 0x0601BA2D RID: 113197 RVA: 0x003E828C File Offset: 0x003E648C
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

		// Token: 0x0601BA2E RID: 113198 RVA: 0x003E8520 File Offset: 0x003E6720
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

		// Token: 0x0400CEA2 RID: 52898
		private Table __p;
	}
}
