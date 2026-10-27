using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200446A RID: 17514
	public struct IDartCompetitorBubbles : IFlatbufferObject
	{
		// Token: 0x17007B95 RID: 31637
		// (get) Token: 0x0601A198 RID: 106904 RVA: 0x003BA986 File Offset: 0x003B8B86
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A199 RID: 106905 RVA: 0x003BA993 File Offset: 0x003B8B93
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A19A RID: 106906 RVA: 0x003BA99C File Offset: 0x003B8B9C
		public static IDartCompetitorBubbles GetRootAsIDartCompetitorBubbles(ByteBuffer _bb)
		{
			return IDartCompetitorBubbles.GetRootAsIDartCompetitorBubbles(_bb, default(IDartCompetitorBubbles));
		}

		// Token: 0x0601A19B RID: 106907 RVA: 0x003BA9B8 File Offset: 0x003B8BB8
		public static IDartCompetitorBubbles GetRootAsIDartCompetitorBubbles(ByteBuffer _bb, IDartCompetitorBubbles obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A19C RID: 106908 RVA: 0x003BA9D5 File Offset: 0x003B8BD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A19D RID: 106909 RVA: 0x003BA9E4 File Offset: 0x003B8BE4
		public IDartCompetitorBubbles __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B96 RID: 31638
		// (get) Token: 0x0601A19E RID: 106910 RVA: 0x003BA9F4 File Offset: 0x003B8BF4
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

		// Token: 0x17007B97 RID: 31639
		// (get) Token: 0x0601A19F RID: 106911 RVA: 0x003BAA54 File Offset: 0x003B8C54
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

		// Token: 0x17007B98 RID: 31640
		// (get) Token: 0x0601A1A0 RID: 106912 RVA: 0x003BAAB4 File Offset: 0x003B8CB4
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

		// Token: 0x17007B99 RID: 31641
		// (get) Token: 0x0601A1A1 RID: 106913 RVA: 0x003BAB14 File Offset: 0x003B8D14
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

		// Token: 0x0601A1A2 RID: 106914 RVA: 0x003BAB72 File Offset: 0x003B8D72
		public static Offset<IDartCompetitorBubbles> CreateIDartCompetitorBubbles(FlatBufferBuilder builder, Offset<IBubbleIndex> PlayerRoundScoreOver150Offset = default(Offset<IBubbleIndex>), Offset<IBubbleIndex> CompetitorRoundScoreOver150Offset = default(Offset<IBubbleIndex>), Offset<IBubbleIndex> CompetitorRoundScore100To149Offset = default(Offset<IBubbleIndex>), Offset<IBubbleIndex> CompetitorHitZeroScoreOffset = default(Offset<IBubbleIndex>))
		{
			builder.StartTable(4);
			IDartCompetitorBubbles.AddCompetitorHitZeroScore(builder, CompetitorHitZeroScoreOffset);
			IDartCompetitorBubbles.AddCompetitorRoundScore100To149(builder, CompetitorRoundScore100To149Offset);
			IDartCompetitorBubbles.AddCompetitorRoundScoreOver150(builder, CompetitorRoundScoreOver150Offset);
			IDartCompetitorBubbles.AddPlayerRoundScoreOver150(builder, PlayerRoundScoreOver150Offset);
			return IDartCompetitorBubbles.EndIDartCompetitorBubbles(builder);
		}

		// Token: 0x0601A1A3 RID: 106915 RVA: 0x003BAB9E File Offset: 0x003B8D9E
		public static void StartIDartCompetitorBubbles(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601A1A4 RID: 106916 RVA: 0x003BABA7 File Offset: 0x003B8DA7
		public static void AddPlayerRoundScoreOver150(FlatBufferBuilder builder, Offset<IBubbleIndex> playerRoundScoreOver150Offset)
		{
			builder.AddOffset(0, playerRoundScoreOver150Offset.Value, 0);
		}

		// Token: 0x0601A1A5 RID: 106917 RVA: 0x003BABB7 File Offset: 0x003B8DB7
		public static void AddCompetitorRoundScoreOver150(FlatBufferBuilder builder, Offset<IBubbleIndex> competitorRoundScoreOver150Offset)
		{
			builder.AddOffset(1, competitorRoundScoreOver150Offset.Value, 0);
		}

		// Token: 0x0601A1A6 RID: 106918 RVA: 0x003BABC7 File Offset: 0x003B8DC7
		public static void AddCompetitorRoundScore100To149(FlatBufferBuilder builder, Offset<IBubbleIndex> competitorRoundScore100To149Offset)
		{
			builder.AddOffset(2, competitorRoundScore100To149Offset.Value, 0);
		}

		// Token: 0x0601A1A7 RID: 106919 RVA: 0x003BABD7 File Offset: 0x003B8DD7
		public static void AddCompetitorHitZeroScore(FlatBufferBuilder builder, Offset<IBubbleIndex> competitorHitZeroScoreOffset)
		{
			builder.AddOffset(3, competitorHitZeroScoreOffset.Value, 0);
		}

		// Token: 0x0601A1A8 RID: 106920 RVA: 0x003BABE7 File Offset: 0x003B8DE7
		public static Offset<IDartCompetitorBubbles> EndIDartCompetitorBubbles(FlatBufferBuilder builder)
		{
			return new Offset<IDartCompetitorBubbles>(builder.EndTable());
		}

		// Token: 0x0601A1A9 RID: 106921 RVA: 0x003BABF4 File Offset: 0x003B8DF4
		public IDartCompetitorBubblesT UnPack()
		{
			IDartCompetitorBubblesT dartCompetitorBubblesT = new IDartCompetitorBubblesT();
			this.UnPackTo(dartCompetitorBubblesT);
			return dartCompetitorBubblesT;
		}

		// Token: 0x0601A1AA RID: 106922 RVA: 0x003BAC10 File Offset: 0x003B8E10
		public void UnPackTo(IDartCompetitorBubblesT _o)
		{
			_o.PlayerRoundScoreOver150 = ((this.PlayerRoundScoreOver150 != null) ? this.PlayerRoundScoreOver150.Value.UnPack() : null);
			_o.CompetitorRoundScoreOver150 = ((this.CompetitorRoundScoreOver150 != null) ? this.CompetitorRoundScoreOver150.Value.UnPack() : null);
			_o.CompetitorRoundScore100To149 = ((this.CompetitorRoundScore100To149 != null) ? this.CompetitorRoundScore100To149.Value.UnPack() : null);
			_o.CompetitorHitZeroScore = ((this.CompetitorHitZeroScore != null) ? this.CompetitorHitZeroScore.Value.UnPack() : null);
		}

		// Token: 0x0601A1AB RID: 106923 RVA: 0x003BACDC File Offset: 0x003B8EDC
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

		// Token: 0x0400C45B RID: 50267
		private Table __p;
	}
}
