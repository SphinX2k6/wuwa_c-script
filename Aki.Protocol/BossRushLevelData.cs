using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001DC RID: 476
	public sealed class BossRushLevelData : IMessage<BossRushLevelData>, IMessage, IEquatable<BossRushLevelData>, IDeepCloneable<BossRushLevelData>, IBufferMessage
	{
		// Token: 0x060035FA RID: 13818 RVA: 0x00087B2A File Offset: 0x00085D2A
		[NullableContext(1)]
		public static BossRushLevelData Create()
		{
			return new BossRushLevelData();
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x060035FB RID: 13819 RVA: 0x00087B31 File Offset: 0x00085D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BossRushLevelData> Parser
		{
			get
			{
				return BossRushLevelData._parser;
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x060035FC RID: 13820 RVA: 0x00087B38 File Offset: 0x00085D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x060035FD RID: 13821 RVA: 0x00087B3B File Offset: 0x00085D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushLevelData.Descriptor;
			}
		}

		// Token: 0x060035FE RID: 13822 RVA: 0x00087B42 File Offset: 0x00085D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelData()
		{
		}

		// Token: 0x060035FF RID: 13823 RVA: 0x00087B78 File Offset: 0x00085D78
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

		// Token: 0x06003600 RID: 13824 RVA: 0x00087C1C File Offset: 0x00085E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelData Clone()
		{
			return new BossRushLevelData(this);
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06003601 RID: 13825 RVA: 0x00087C24 File Offset: 0x00085E24
		// (set) Token: 0x06003602 RID: 13826 RVA: 0x00087C2C File Offset: 0x00085E2C
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

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06003603 RID: 13827 RVA: 0x00087C35 File Offset: 0x00085E35
		// (set) Token: 0x06003604 RID: 13828 RVA: 0x00087C3D File Offset: 0x00085E3D
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

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06003605 RID: 13829 RVA: 0x00087C46 File Offset: 0x00085E46
		// (set) Token: 0x06003606 RID: 13830 RVA: 0x00087C4E File Offset: 0x00085E4E
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

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06003607 RID: 13831 RVA: 0x00087C57 File Offset: 0x00085E57
		// (set) Token: 0x06003608 RID: 13832 RVA: 0x00087C5F File Offset: 0x00085E5F
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

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06003609 RID: 13833 RVA: 0x00087C68 File Offset: 0x00085E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CharacterSelectionRecord
		{
			get
			{
				return this.characterSelectionRecord_;
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x0600360A RID: 13834 RVA: 0x00087C70 File Offset: 0x00085E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BuffSelection> BuffSelectionRecord
		{
			get
			{
				return this.buffSelectionRecord_;
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x0600360B RID: 13835 RVA: 0x00087C78 File Offset: 0x00085E78
		// (set) Token: 0x0600360C RID: 13836 RVA: 0x00087C80 File Offset: 0x00085E80
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

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x0600360D RID: 13837 RVA: 0x00087C89 File Offset: 0x00085E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreBuff
		{
			get
			{
				return this.scoreBuff_;
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x0600360E RID: 13838 RVA: 0x00087C91 File Offset: 0x00085E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BossRushRewardClaimStatus> LevelScoreRewardStatus
		{
			get
			{
				return this.levelScoreRewardStatus_;
			}
		}

		// Token: 0x0600360F RID: 13839 RVA: 0x00087C99 File Offset: 0x00085E99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushLevelData);
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x00087CA8 File Offset: 0x00085EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushLevelData other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.StartTime == other.StartTime && this.IsOpen == other.IsOpen && this.Score == other.Score && this.characterSelectionRecord_.Equals(other.characterSelectionRecord_) && this.buffSelectionRecord_.Equals(other.buffSelectionRecord_) && this.LevelRewardClaimStatus == other.LevelRewardClaimStatus && this.scoreBuff_.Equals(other.scoreBuff_) && this.levelScoreRewardStatus_.Equals(other.levelScoreRewardStatus_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003611 RID: 13841 RVA: 0x00087D78 File Offset: 0x00085F78
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

		// Token: 0x06003612 RID: 13842 RVA: 0x00087E59 File Offset: 0x00086059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003613 RID: 13843 RVA: 0x00087E66 File Offset: 0x00086066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003614 RID: 13844 RVA: 0x00087E70 File Offset: 0x00086070
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

		// Token: 0x06003615 RID: 13845 RVA: 0x00087F60 File Offset: 0x00086160
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

		// Token: 0x06003616 RID: 13846 RVA: 0x00088040 File Offset: 0x00086240
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

		// Token: 0x06003617 RID: 13847 RVA: 0x00088110 File Offset: 0x00086310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x0008811C File Offset: 0x0008631C
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

		// Token: 0x04002AC3 RID: 10947
		private static readonly MessageParser<BossRushLevelData> _parser = new MessageParser<BossRushLevelData>(() => new BossRushLevelData());

		// Token: 0x04002AC4 RID: 10948
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AC5 RID: 10949
		public const int InstIdFieldNumber = 1;

		// Token: 0x04002AC6 RID: 10950
		private int instId_;

		// Token: 0x04002AC7 RID: 10951
		public const int StartTimeFieldNumber = 2;

		// Token: 0x04002AC8 RID: 10952
		private int startTime_;

		// Token: 0x04002AC9 RID: 10953
		public const int IsOpenFieldNumber = 3;

		// Token: 0x04002ACA RID: 10954
		private bool isOpen_;

		// Token: 0x04002ACB RID: 10955
		public const int ScoreFieldNumber = 4;

		// Token: 0x04002ACC RID: 10956
		private int score_;

		// Token: 0x04002ACD RID: 10957
		public const int CharacterSelectionRecordFieldNumber = 5;

		// Token: 0x04002ACE RID: 10958
		private static readonly FieldCodec<int> _repeated_characterSelectionRecord_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04002ACF RID: 10959
		private readonly RepeatedField<int> characterSelectionRecord_ = new RepeatedField<int>();

		// Token: 0x04002AD0 RID: 10960
		public const int BuffSelectionRecordFieldNumber = 6;

		// Token: 0x04002AD1 RID: 10961
		private static readonly FieldCodec<BuffSelection> _repeated_buffSelectionRecord_codec = FieldCodec.ForMessage<BuffSelection>(50U, BuffSelection.Parser);

		// Token: 0x04002AD2 RID: 10962
		private readonly RepeatedField<BuffSelection> buffSelectionRecord_ = new RepeatedField<BuffSelection>();

		// Token: 0x04002AD3 RID: 10963
		public const int LevelRewardClaimStatusFieldNumber = 7;

		// Token: 0x04002AD4 RID: 10964
		private BossRushRewardClaimStatus levelRewardClaimStatus_;

		// Token: 0x04002AD5 RID: 10965
		public const int ScoreBuffFieldNumber = 8;

		// Token: 0x04002AD6 RID: 10966
		private static readonly FieldCodec<int> _repeated_scoreBuff_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04002AD7 RID: 10967
		private readonly RepeatedField<int> scoreBuff_ = new RepeatedField<int>();

		// Token: 0x04002AD8 RID: 10968
		public const int LevelScoreRewardStatusFieldNumber = 9;

		// Token: 0x04002AD9 RID: 10969
		private static readonly FieldCodec<BossRushRewardClaimStatus> _repeated_levelScoreRewardStatus_codec = FieldCodec.ForEnum<BossRushRewardClaimStatus>(74U, (BossRushRewardClaimStatus x) => (int)x, (int x) => (BossRushRewardClaimStatus)x);

		// Token: 0x04002ADA RID: 10970
		private readonly RepeatedField<BossRushRewardClaimStatus> levelScoreRewardStatus_ = new RepeatedField<BossRushRewardClaimStatus>();
	}
}
