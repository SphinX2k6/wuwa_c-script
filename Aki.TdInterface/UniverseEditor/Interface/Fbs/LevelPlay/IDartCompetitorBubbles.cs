using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048D2 RID: 18642
	public struct IDartCompetitorBubbles : IFlatbufferObject
	{
		// Token: 0x170081D4 RID: 33236
		// (get) Token: 0x0601B969 RID: 113001 RVA: 0x003E6B92 File Offset: 0x003E4D92
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B96A RID: 113002 RVA: 0x003E6B9F File Offset: 0x003E4D9F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B96B RID: 113003 RVA: 0x003E6BA8 File Offset: 0x003E4DA8
		public static IDartCompetitorBubbles GetRootAsIDartCompetitorBubbles(ByteBuffer _bb)
		{
			return IDartCompetitorBubbles.GetRootAsIDartCompetitorBubbles(_bb, default(IDartCompetitorBubbles));
		}

		// Token: 0x0601B96C RID: 113004 RVA: 0x003E6BC4 File Offset: 0x003E4DC4
		public static IDartCompetitorBubbles GetRootAsIDartCompetitorBubbles(ByteBuffer _bb, IDartCompetitorBubbles obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B96D RID: 113005 RVA: 0x003E6BE1 File Offset: 0x003E4DE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B96E RID: 113006 RVA: 0x003E6BF0 File Offset: 0x003E4DF0
		public IDartCompetitorBubbles __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170081D5 RID: 33237
		// (get) Token: 0x0601B96F RID: 113007 RVA: 0x003E6C00 File Offset: 0x003E4E00
		public IBubbleIndex? PlayerRoundScoreOver150
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IBubbleIndex?(default(IBubbleIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170081D6 RID: 33238
		// (get) Token: 0x0601B970 RID: 113008 RVA: 0x003E6C60 File Offset: 0x003E4E60
		public IBubbleIndex? CompetitorRoundScoreOver150
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IBubbleIndex?(default(IBubbleIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170081D7 RID: 33239
		// (get) Token: 0x0601B971 RID: 113009 RVA: 0x003E6CC0 File Offset: 0x003E4EC0
		public IBubbleIndex? CompetitorRoundScore100To149
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IBubbleIndex?(default(IBubbleIndex).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170081D8 RID: 33240
		// (get) Token: 0x0601B972 RID: 113010 RVA: 0x003E6D20 File Offset: 0x003E4F20
		public IBubbleIndex? CompetitorHitZeroScore
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

		// Token: 0x0601B973 RID: 113011 RVA: 0x003E6D7E File Offset: 0x003E4F7E
		public static Offset<IDartCompetitorBubbles> CreateIDartCompetitorBubbles(FlatBufferBuilder builder, Offset<IBubbleIndex> PlayerRoundScoreOver150Offset = default(Offset<IBubbleIndex>), Offset<IBubbleIndex> CompetitorRoundScoreOver150Offset = default(Offset<IBubbleIndex>), Offset<IBubbleIndex> CompetitorRoundScore100To149Offset = default(Offset<IBubbleIndex>), Offset<IBubbleIndex> CompetitorHitZeroScoreOffset = default(Offset<IBubbleIndex>))
		{
			builder.StartTable(4);
			IDartCompetitorBubbles.AddCompetitorHitZeroScore(builder, CompetitorHitZeroScoreOffset);
			IDartCompetitorBubbles.AddCompetitorRoundScore100To149(builder, CompetitorRoundScore100To149Offset);
			IDartCompetitorBubbles.AddCompetitorRoundScoreOver150(builder, CompetitorRoundScoreOver150Offset);
			IDartCompetitorBubbles.AddPlayerRoundScoreOver150(builder, PlayerRoundScoreOver150Offset);
			return IDartCompetitorBubbles.EndIDartCompetitorBubbles(builder);
		}

		// Token: 0x0601B974 RID: 113012 RVA: 0x003E6DAA File Offset: 0x003E4FAA
		public static void StartIDartCompetitorBubbles(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601B975 RID: 113013 RVA: 0x003E6DB3 File Offset: 0x003E4FB3
		public static void AddPlayerRoundScoreOver150(FlatBufferBuilder builder, Offset<IBubbleIndex> playerRoundScoreOver150Offset)
		{
			builder.AddOffset(0, playerRoundScoreOver150Offset.Value, 0);
		}

		// Token: 0x0601B976 RID: 113014 RVA: 0x003E6DC3 File Offset: 0x003E4FC3
		public static void AddCompetitorRoundScoreOver150(FlatBufferBuilder builder, Offset<IBubbleIndex> competitorRoundScoreOver150Offset)
		{
			builder.AddOffset(1, competitorRoundScoreOver150Offset.Value, 0);
		}

		// Token: 0x0601B977 RID: 113015 RVA: 0x003E6DD3 File Offset: 0x003E4FD3
		public static void AddCompetitorRoundScore100To149(FlatBufferBuilder builder, Offset<IBubbleIndex> competitorRoundScore100To149Offset)
		{
			builder.AddOffset(2, competitorRoundScore100To149Offset.Value, 0);
		}

		// Token: 0x0601B978 RID: 113016 RVA: 0x003E6DE3 File Offset: 0x003E4FE3
		public static void AddCompetitorHitZeroScore(FlatBufferBuilder builder, Offset<IBubbleIndex> competitorHitZeroScoreOffset)
		{
			builder.AddOffset(3, competitorHitZeroScoreOffset.Value, 0);
		}

		// Token: 0x0601B979 RID: 113017 RVA: 0x003E6DF3 File Offset: 0x003E4FF3
		public static Offset<IDartCompetitorBubbles> EndIDartCompetitorBubbles(FlatBufferBuilder builder)
		{
			return new Offset<IDartCompetitorBubbles>(builder.EndTable());
		}

		// Token: 0x0601B97A RID: 113018 RVA: 0x003E6E00 File Offset: 0x003E5000
		public IDartCompetitorBubblesT UnPack()
		{
			IDartCompetitorBubblesT dartCompetitorBubblesT = new IDartCompetitorBubblesT();
			this.UnPackTo(dartCompetitorBubblesT);
			return dartCompetitorBubblesT;
		}

		// Token: 0x0601B97B RID: 113019 RVA: 0x003E6E1C File Offset: 0x003E501C
		public void UnPackTo(IDartCompetitorBubblesT _o)
		{
			_o.PlayerRoundScoreOver150 = ((this.PlayerRoundScoreOver150 != null) ? this.PlayerRoundScoreOver150.Value.UnPack() : null);
			_o.CompetitorRoundScoreOver150 = ((this.CompetitorRoundScoreOver150 != null) ? this.CompetitorRoundScoreOver150.Value.UnPack() : null);
			_o.CompetitorRoundScore100To149 = ((this.CompetitorRoundScore100To149 != null) ? this.CompetitorRoundScore100To149.Value.UnPack() : null);
			_o.CompetitorHitZeroScore = ((this.CompetitorHitZeroScore != null) ? this.CompetitorHitZeroScore.Value.UnPack() : null);
		}

		// Token: 0x0601B97C RID: 113020 RVA: 0x003E6EE8 File Offset: 0x003E50E8
		public static Offset<IDartCompetitorBubbles> Pack(FlatBufferBuilder builder, IDartCompetitorBubblesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartCompetitorBubbles>);
			}
			Offset<IBubbleIndex> playerRoundScoreOver150Offset = (_o.PlayerRoundScoreOver150 == null) ? default(Offset<IBubbleIndex>) : IBubbleIndex.Pack(builder, _o.PlayerRoundScoreOver150);
			Offset<IBubbleIndex> competitorRoundScoreOver150Offset = (_o.CompetitorRoundScoreOver150 == null) ? default(Offset<IBubbleIndex>) : IBubbleIndex.Pack(builder, _o.CompetitorRoundScoreOver150);
			Offset<IBubbleIndex> competitorRoundScore100To149Offset = (_o.CompetitorRoundScore100To149 == null) ? default(Offset<IBubbleIndex>) : IBubbleIndex.Pack(builder, _o.CompetitorRoundScore100To149);
			Offset<IBubbleIndex> competitorHitZeroScoreOffset = (_o.CompetitorHitZeroScore == null) ? default(Offset<IBubbleIndex>) : IBubbleIndex.Pack(builder, _o.CompetitorHitZeroScore);
			return IDartCompetitorBubbles.CreateIDartCompetitorBubbles(builder, playerRoundScoreOver150Offset, competitorRoundScoreOver150Offset, competitorRoundScore100To149Offset, competitorHitZeroScoreOffset);
		}

		// Token: 0x0400CE89 RID: 52873
		private Table __p;
	}
}
