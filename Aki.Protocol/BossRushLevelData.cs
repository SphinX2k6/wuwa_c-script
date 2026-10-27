using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001D8 RID: 472
	public sealed class BossRushLevelData : IMessage<BossRushLevelData>, IMessage, IEquatable<BossRushLevelData>, IDeepCloneable<BossRushLevelData>, IBufferMessage
	{
		// Token: 0x0600356D RID: 13677 RVA: 0x000863B6 File Offset: 0x000845B6
		[NullableContext(1)]
		public static BossRushLevelData Create()
		{
			return new BossRushLevelData();
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x0600356E RID: 13678 RVA: 0x000863BD File Offset: 0x000845BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BossRushLevelData> Parser
		{
			get
			{
				return BossRushLevelData._parser;
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x0600356F RID: 13679 RVA: 0x000863C4 File Offset: 0x000845C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06003570 RID: 13680 RVA: 0x000863C7 File Offset: 0x000845C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushLevelData.Descriptor;
			}
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x000863CE File Offset: 0x000845CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelData()
		{
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x00086404 File Offset: 0x00084604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelData(BossRushLevelData other) : this()
		{
			this.instId_ = other.instId_;
			this.startTime_ = other.startTime_;
			this.isOpen_ = other.isOpen_;
			this.score_ = other.score_;
			this.characterSelectionRecord_ = other.characterSelectionRecord_.Clone();
			this.buffSelectionRecord_ = other.buffSelectionRecord_.Clone();
			this.levelRewardClaimStatus_ = other.levelRewardClaimStatus_;
			this.scoreBuff_ = other.scoreBuff_.Clone();
			this.levelScoreRewardStatus_ = other.levelScoreRewardStatus_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x000864A8 File Offset: 0x000846A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelData Clone()
		{
			return new BossRushLevelData(this);
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06003574 RID: 13684 RVA: 0x000864B0 File Offset: 0x000846B0
		// (set) Token: 0x06003575 RID: 13685 RVA: 0x000864B8 File Offset: 0x000846B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06003576 RID: 13686 RVA: 0x000864C1 File Offset: 0x000846C1
		// (set) Token: 0x06003577 RID: 13687 RVA: 0x000864C9 File Offset: 0x000846C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StartTime
		{
			get
			{
				return this.startTime_;
			}
			set
			{
				this.startTime_ = value;
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06003578 RID: 13688 RVA: 0x000864D2 File Offset: 0x000846D2
		// (set) Token: 0x06003579 RID: 13689 RVA: 0x000864DA File Offset: 0x000846DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOpen
		{
			get
			{
				return this.isOpen_;
			}
			set
			{
				this.isOpen_ = value;
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x0600357A RID: 13690 RVA: 0x000864E3 File Offset: 0x000846E3
		// (set) Token: 0x0600357B RID: 13691 RVA: 0x000864EB File Offset: 0x000846EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x0600357C RID: 13692 RVA: 0x000864F4 File Offset: 0x000846F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CharacterSelectionRecord
		{
			get
			{
				return this.characterSelectionRecord_;
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x0600357D RID: 13693 RVA: 0x000864FC File Offset: 0x000846FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BuffSelection> BuffSelectionRecord
		{
			get
			{
				return this.buffSelectionRecord_;
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x0600357E RID: 13694 RVA: 0x00086504 File Offset: 0x00084704
		// (set) Token: 0x0600357F RID: 13695 RVA: 0x0008650C File Offset: 0x0008470C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushRewardClaimStatus LevelRewardClaimStatus
		{
			get
			{
				return this.levelRewardClaimStatus_;
			}
			set
			{
				this.levelRewardClaimStatus_ = value;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06003580 RID: 13696 RVA: 0x00086515 File Offset: 0x00084715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreBuff
		{
			get
			{
				return this.scoreBuff_;
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06003581 RID: 13697 RVA: 0x0008651D File Offset: 0x0008471D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BossRushRewardClaimStatus> LevelScoreRewardStatus
		{
			get
			{
				return this.levelScoreRewardStatus_;
			}
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x00086525 File Offset: 0x00084725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushLevelData);
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x00086534 File Offset: 0x00084734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushLevelData other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.StartTime == other.StartTime && this.IsOpen == other.IsOpen && this.Score == other.Score && this.characterSelectionRecord_.Equals(other.characterSelectionRecord_) && this.buffSelectionRecord_.Equals(other.buffSelectionRecord_) && this.LevelRewardClaimStatus == other.LevelRewardClaimStatus && this.scoreBuff_.Equals(other.scoreBuff_) && this.levelScoreRewardStatus_.Equals(other.levelScoreRewardStatus_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003584 RID: 13700 RVA: 0x00086604 File Offset: 0x00084804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.StartTime != 0)
			{
				num ^= this.StartTime.GetHashCode();
			}
			if (this.IsOpen)
			{
				num ^= this.IsOpen.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			num ^= this.characterSelectionRecord_.GetHashCode();
			num ^= this.buffSelectionRecord_.GetHashCode();
			if (this.LevelRewardClaimStatus != BossRushRewardClaimStatus.Incomplete)
			{
				num ^= this.LevelRewardClaimStatus.GetHashCode();
			}
			num ^= this.scoreBuff_.GetHashCode();
			num ^= this.levelScoreRewardStatus_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003585 RID: 13701 RVA: 0x000866E5 File Offset: 0x000848E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x000866F2 File Offset: 0x000848F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x000866FC File Offset: 0x000848FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			if (this.StartTime != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.StartTime);
			}
			if (this.IsOpen)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsOpen);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Score);
			}
			this.characterSelectionRecord_.WriteTo(ref output, BossRushLevelData._repeated_characterSelectionRecord_codec);
			this.buffSelectionRecord_.WriteTo(ref output, BossRushLevelData._repeated_buffSelectionRecord_codec);
			if (this.LevelRewardClaimStatus != BossRushRewardClaimStatus.Incomplete)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.LevelRewardClaimStatus);
			}
			this.scoreBuff_.WriteTo(ref output, BossRushLevelData._repeated_scoreBuff_codec);
			this.levelScoreRewardStatus_.WriteTo(ref output, BossRushLevelData._repeated_levelScoreRewardStatus_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003588 RID: 13704 RVA: 0x000867EC File Offset: 0x000849EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.StartTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StartTime);
			}
			if (this.IsOpen)
			{
				num += 2;
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			num += this.characterSelectionRecord_.CalculateSize(BossRushLevelData._repeated_characterSelectionRecord_codec);
			num += this.buffSelectionRecord_.CalculateSize(BossRushLevelData._repeated_buffSelectionRecord_codec);
			if (this.LevelRewardClaimStatus != BossRushRewardClaimStatus.Incomplete)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.LevelRewardClaimStatus);
			}
			num += this.scoreBuff_.CalculateSize(BossRushLevelData._repeated_scoreBuff_codec);
			num += this.levelScoreRewardStatus_.CalculateSize(BossRushLevelData._repeated_levelScoreRewardStatus_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003589 RID: 13705 RVA: 0x000868CC File Offset: 0x00084ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushLevelData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.StartTime != 0)
			{
				this.StartTime = other.StartTime;
			}
			if (other.IsOpen)
			{
				this.IsOpen = other.IsOpen;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this.characterSelectionRecord_.Add(other.characterSelectionRecord_);
			this.buffSelectionRecord_.Add(other.buffSelectionRecord_);
			if (other.LevelRewardClaimStatus != BossRushRewardClaimStatus.Incomplete)
			{
				this.LevelRewardClaimStatus = other.LevelRewardClaimStatus;
			}
			this.scoreBuff_.Add(other.scoreBuff_);
			this.levelScoreRewardStatus_.Add(other.levelScoreRewardStatus_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600358A RID: 13706 RVA: 0x0008699C File Offset: 0x00084B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x000869A8 File Offset: 0x00084BA8
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
				if (num > 42U)
				{
					if (num <= 64U)
					{
						if (num == 50U)
						{
							this.buffSelectionRecord_.AddEntriesFrom(ref input, BossRushLevelData._repeated_buffSelectionRecord_codec);
							continue;
						}
						if (num == 56U)
						{
							this.LevelRewardClaimStatus = (BossRushRewardClaimStatus)input.ReadEnum();
							continue;
						}
						if (num != 64U)
						{
							goto IL_7D;
						}
					}
					else if (num != 66U)
					{
						if (num != 72U && num != 74U)
						{
							goto IL_7D;
						}
						this.levelScoreRewardStatus_.AddEntriesFrom(ref input, BossRushLevelData._repeated_levelScoreRewardStatus_codec);
						continue;
					}
					this.scoreBuff_.AddEntriesFrom(ref input, BossRushLevelData._repeated_scoreBuff_codec);
					continue;
				}
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.StartTime = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.IsOpen = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
					if (num == 40U || num == 42U)
					{
						this.characterSelectionRecord_.AddEntriesFrom(ref input, BossRushLevelData._repeated_characterSelectionRecord_codec);
						continue;
					}
				}
				IL_7D:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002A48 RID: 10824
		private static readonly MessageParser<BossRushLevelData> _parser = new MessageParser<BossRushLevelData>(() => new BossRushLevelData());

		// Token: 0x04002A49 RID: 10825
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A4A RID: 10826
		public const int InstIdFieldNumber = 1;

		// Token: 0x04002A4B RID: 10827
		private int instId_;

		// Token: 0x04002A4C RID: 10828
		public const int StartTimeFieldNumber = 2;

		// Token: 0x04002A4D RID: 10829
		private int startTime_;

		// Token: 0x04002A4E RID: 10830
		public const int IsOpenFieldNumber = 3;

		// Token: 0x04002A4F RID: 10831
		private bool isOpen_;

		// Token: 0x04002A50 RID: 10832
		public const int ScoreFieldNumber = 4;

		// Token: 0x04002A51 RID: 10833
		private int score_;

		// Token: 0x04002A52 RID: 10834
		public const int CharacterSelectionRecordFieldNumber = 5;

		// Token: 0x04002A53 RID: 10835
		private static readonly FieldCodec<int> _repeated_characterSelectionRecord_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04002A54 RID: 10836
		private readonly RepeatedField<int> characterSelectionRecord_ = new RepeatedField<int>();

		// Token: 0x04002A55 RID: 10837
		public const int BuffSelectionRecordFieldNumber = 6;

		// Token: 0x04002A56 RID: 10838
		private static readonly FieldCodec<BuffSelection> _repeated_buffSelectionRecord_codec = FieldCodec.ForMessage<BuffSelection>(50U, BuffSelection.Parser);

		// Token: 0x04002A57 RID: 10839
		private readonly RepeatedField<BuffSelection> buffSelectionRecord_ = new RepeatedField<BuffSelection>();

		// Token: 0x04002A58 RID: 10840
		public const int LevelRewardClaimStatusFieldNumber = 7;

		// Token: 0x04002A59 RID: 10841
		private BossRushRewardClaimStatus levelRewardClaimStatus_;

		// Token: 0x04002A5A RID: 10842
		public const int ScoreBuffFieldNumber = 8;

		// Token: 0x04002A5B RID: 10843
		private static readonly FieldCodec<int> _repeated_scoreBuff_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04002A5C RID: 10844
		private readonly RepeatedField<int> scoreBuff_ = new RepeatedField<int>();

		// Token: 0x04002A5D RID: 10845
		public const int LevelScoreRewardStatusFieldNumber = 9;

		// Token: 0x04002A5E RID: 10846
		private static readonly FieldCodec<BossRushRewardClaimStatus> _repeated_levelScoreRewardStatus_codec = FieldCodec.ForEnum<BossRushRewardClaimStatus>(74U, (BossRushRewardClaimStatus x) => (int)x, (int x) => (BossRushRewardClaimStatus)x);

		// Token: 0x04002A5F RID: 10847
		private readonly RepeatedField<BossRushRewardClaimStatus> levelScoreRewardStatus_ = new RepeatedField<BossRushRewardClaimStatus>();
	}
}
