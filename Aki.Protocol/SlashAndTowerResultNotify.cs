using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001250 RID: 4688
	[NetMessage(EMessageId.SlashAndTowerResultNotify)]
	public sealed class SlashAndTowerResultNotify : IMessage<SlashAndTowerResultNotify>, IMessage, IEquatable<SlashAndTowerResultNotify>, IDeepCloneable<SlashAndTowerResultNotify>, IBufferMessage
	{
		// Token: 0x06018F9F RID: 102303 RVA: 0x003A23A1 File Offset: 0x003A05A1
		[NullableContext(1)]
		public static SlashAndTowerResultNotify Create()
		{
			return new SlashAndTowerResultNotify();
		}

		// Token: 0x17005438 RID: 21560
		// (get) Token: 0x06018FA0 RID: 102304 RVA: 0x003A23A8 File Offset: 0x003A05A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005439 RID: 21561
		// (get) Token: 0x06018FA1 RID: 102305 RVA: 0x003A23AB File Offset: 0x003A05AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerResultNotify.Descriptor;
			}
		}

		// Token: 0x06018FA2 RID: 102306 RVA: 0x003A23B2 File Offset: 0x003A05B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerResultNotify()
		{
		}

		// Token: 0x06018FA3 RID: 102307 RVA: 0x003A23BC File Offset: 0x003A05BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerResultNotify(SlashAndTowerResultNotify other) : this()
		{
			this.levelsId_ = other.levelsId_;
			this.firstKillMonsterScore_ = other.firstKillMonsterScore_;
			this.firstRoundScore_ = other.firstRoundScore_;
			this.secondKillMonsterScore_ = other.secondKillMonsterScore_;
			this.secondRoundScore_ = other.secondRoundScore_;
			this.firstFormation_ = ((other.firstFormation_ != null) ? other.firstFormation_.Clone() : null);
			this.secondFormation_ = ((other.secondFormation_ != null) ? other.secondFormation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018FA4 RID: 102308 RVA: 0x003A2454 File Offset: 0x003A0654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerResultNotify Clone()
		{
			return new SlashAndTowerResultNotify(this);
		}

		// Token: 0x1700543A RID: 21562
		// (get) Token: 0x06018FA5 RID: 102309 RVA: 0x003A245C File Offset: 0x003A065C
		// (set) Token: 0x06018FA6 RID: 102310 RVA: 0x003A2464 File Offset: 0x003A0664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelsId
		{
			get
			{
				return this.levelsId_;
			}
			set
			{
				this.levelsId_ = value;
			}
		}

		// Token: 0x1700543B RID: 21563
		// (get) Token: 0x06018FA7 RID: 102311 RVA: 0x003A246D File Offset: 0x003A066D
		// (set) Token: 0x06018FA8 RID: 102312 RVA: 0x003A2475 File Offset: 0x003A0675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FirstKillMonsterScore
		{
			get
			{
				return this.firstKillMonsterScore_;
			}
			set
			{
				this.firstKillMonsterScore_ = value;
			}
		}

		// Token: 0x1700543C RID: 21564
		// (get) Token: 0x06018FA9 RID: 102313 RVA: 0x003A247E File Offset: 0x003A067E
		// (set) Token: 0x06018FAA RID: 102314 RVA: 0x003A2486 File Offset: 0x003A0686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FirstRoundScore
		{
			get
			{
				return this.firstRoundScore_;
			}
			set
			{
				this.firstRoundScore_ = value;
			}
		}

		// Token: 0x1700543D RID: 21565
		// (get) Token: 0x06018FAB RID: 102315 RVA: 0x003A248F File Offset: 0x003A068F
		// (set) Token: 0x06018FAC RID: 102316 RVA: 0x003A2497 File Offset: 0x003A0697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SecondKillMonsterScore
		{
			get
			{
				return this.secondKillMonsterScore_;
			}
			set
			{
				this.secondKillMonsterScore_ = value;
			}
		}

		// Token: 0x1700543E RID: 21566
		// (get) Token: 0x06018FAD RID: 102317 RVA: 0x003A24A0 File Offset: 0x003A06A0
		// (set) Token: 0x06018FAE RID: 102318 RVA: 0x003A24A8 File Offset: 0x003A06A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SecondRoundScore
		{
			get
			{
				return this.secondRoundScore_;
			}
			set
			{
				this.secondRoundScore_ = value;
			}
		}

		// Token: 0x1700543F RID: 21567
		// (get) Token: 0x06018FAF RID: 102319 RVA: 0x003A24B1 File Offset: 0x003A06B1
		// (set) Token: 0x06018FB0 RID: 102320 RVA: 0x003A24B9 File Offset: 0x003A06B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleFormation FirstFormation
		{
			get
			{
				return this.firstFormation_;
			}
			set
			{
				this.firstFormation_ = value;
			}
		}

		// Token: 0x17005440 RID: 21568
		// (get) Token: 0x06018FB1 RID: 102321 RVA: 0x003A24C2 File Offset: 0x003A06C2
		// (set) Token: 0x06018FB2 RID: 102322 RVA: 0x003A24CA File Offset: 0x003A06CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleFormation SecondFormation
		{
			get
			{
				return this.secondFormation_;
			}
			set
			{
				this.secondFormation_ = value;
			}
		}

		// Token: 0x06018FB3 RID: 102323 RVA: 0x003A24D3 File Offset: 0x003A06D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerResultNotify);
		}

		// Token: 0x06018FB4 RID: 102324 RVA: 0x003A24E4 File Offset: 0x003A06E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerResultNotify other)
		{
			return other != null && (other == this || (this.LevelsId == other.LevelsId && this.FirstKillMonsterScore == other.FirstKillMonsterScore && this.FirstRoundScore == other.FirstRoundScore && this.SecondKillMonsterScore == other.SecondKillMonsterScore && this.SecondRoundScore == other.SecondRoundScore && object.Equals(this.FirstFormation, other.FirstFormation) && object.Equals(this.SecondFormation, other.SecondFormation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018FB5 RID: 102325 RVA: 0x003A2588 File Offset: 0x003A0788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelsId != 0)
			{
				num ^= this.LevelsId.GetHashCode();
			}
			if (this.FirstKillMonsterScore != 0)
			{
				num ^= this.FirstKillMonsterScore.GetHashCode();
			}
			if (this.FirstRoundScore != 0)
			{
				num ^= this.FirstRoundScore.GetHashCode();
			}
			if (this.SecondKillMonsterScore != 0)
			{
				num ^= this.SecondKillMonsterScore.GetHashCode();
			}
			if (this.SecondRoundScore != 0)
			{
				num ^= this.SecondRoundScore.GetHashCode();
			}
			if (this.firstFormation_ != null)
			{
				num ^= this.FirstFormation.GetHashCode();
			}
			if (this.secondFormation_ != null)
			{
				num ^= this.SecondFormation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018FB6 RID: 102326 RVA: 0x003A2657 File Offset: 0x003A0857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018FB7 RID: 102327 RVA: 0x003A2664 File Offset: 0x003A0864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018FB8 RID: 102328 RVA: 0x003A2670 File Offset: 0x003A0870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FirstRoundScore != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FirstRoundScore);
			}
			if (this.SecondKillMonsterScore != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SecondKillMonsterScore);
			}
			if (this.LevelsId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LevelsId);
			}
			if (this.secondFormation_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.SecondFormation);
			}
			if (this.firstFormation_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.FirstFormation);
			}
			if (this.SecondRoundScore != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.SecondRoundScore);
			}
			if (this.FirstKillMonsterScore != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.FirstKillMonsterScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018FB9 RID: 102329 RVA: 0x003A2758 File Offset: 0x003A0958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelsId);
			}
			if (this.FirstKillMonsterScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FirstKillMonsterScore);
			}
			if (this.FirstRoundScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FirstRoundScore);
			}
			if (this.SecondKillMonsterScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SecondKillMonsterScore);
			}
			if (this.SecondRoundScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SecondRoundScore);
			}
			if (this.firstFormation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FirstFormation);
			}
			if (this.secondFormation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SecondFormation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018FBA RID: 102330 RVA: 0x003A2828 File Offset: 0x003A0A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelsId != 0)
			{
				this.LevelsId = other.LevelsId;
			}
			if (other.FirstKillMonsterScore != 0)
			{
				this.FirstKillMonsterScore = other.FirstKillMonsterScore;
			}
			if (other.FirstRoundScore != 0)
			{
				this.FirstRoundScore = other.FirstRoundScore;
			}
			if (other.SecondKillMonsterScore != 0)
			{
				this.SecondKillMonsterScore = other.SecondKillMonsterScore;
			}
			if (other.SecondRoundScore != 0)
			{
				this.SecondRoundScore = other.SecondRoundScore;
			}
			if (other.firstFormation_ != null)
			{
				if (this.firstFormation_ == null)
				{
					this.FirstFormation = new BattleFormation();
				}
				this.FirstFormation.MergeFrom(other.FirstFormation);
			}
			if (other.secondFormation_ != null)
			{
				if (this.secondFormation_ == null)
				{
					this.SecondFormation = new BattleFormation();
				}
				this.SecondFormation.MergeFrom(other.SecondFormation);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018FBB RID: 102331 RVA: 0x003A290C File Offset: 0x003A0B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018FBC RID: 102332 RVA: 0x003A2918 File Offset: 0x003A0B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 40U)
				{
					if (num == 16U)
					{
						this.FirstRoundScore = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.SecondKillMonsterScore = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.LevelsId = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 74U)
				{
					if (num == 58U)
					{
						if (this.secondFormation_ == null)
						{
							this.SecondFormation = new BattleFormation();
						}
						input.ReadMessage(this.SecondFormation);
						continue;
					}
					if (num == 74U)
					{
						if (this.firstFormation_ == null)
						{
							this.FirstFormation = new BattleFormation();
						}
						input.ReadMessage(this.FirstFormation);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.SecondRoundScore = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.FirstKillMonsterScore = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009334 RID: 37684
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009335 RID: 37685
		public const int LevelsIdFieldNumber = 5;

		// Token: 0x04009336 RID: 37686
		private int levelsId_;

		// Token: 0x04009337 RID: 37687
		public const int FirstKillMonsterScoreFieldNumber = 13;

		// Token: 0x04009338 RID: 37688
		private int firstKillMonsterScore_;

		// Token: 0x04009339 RID: 37689
		public const int FirstRoundScoreFieldNumber = 2;

		// Token: 0x0400933A RID: 37690
		private int firstRoundScore_;

		// Token: 0x0400933B RID: 37691
		public const int SecondKillMonsterScoreFieldNumber = 3;

		// Token: 0x0400933C RID: 37692
		private int secondKillMonsterScore_;

		// Token: 0x0400933D RID: 37693
		public const int SecondRoundScoreFieldNumber = 10;

		// Token: 0x0400933E RID: 37694
		private int secondRoundScore_;

		// Token: 0x0400933F RID: 37695
		public const int FirstFormationFieldNumber = 9;

		// Token: 0x04009340 RID: 37696
		private BattleFormation firstFormation_;

		// Token: 0x04009341 RID: 37697
		public const int SecondFormationFieldNumber = 7;

		// Token: 0x04009342 RID: 37698
		private BattleFormation secondFormation_;
	}
}
