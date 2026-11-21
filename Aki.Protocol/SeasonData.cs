using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011E4 RID: 4580
	public sealed class SeasonData : IMessage<SeasonData>, IMessage, IEquatable<SeasonData>, IDeepCloneable<SeasonData>, IBufferMessage
	{
		// Token: 0x06018723 RID: 100131 RVA: 0x0038EF2D File Offset: 0x0038D12D
		[NullableContext(1)]
		public static SeasonData Create()
		{
			return new SeasonData();
		}

		// Token: 0x17005267 RID: 21095
		// (get) Token: 0x06018724 RID: 100132 RVA: 0x0038EF34 File Offset: 0x0038D134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005268 RID: 21096
		// (get) Token: 0x06018725 RID: 100133 RVA: 0x0038EF37 File Offset: 0x0038D137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SeasonData.Descriptor;
			}
		}

		// Token: 0x06018726 RID: 100134 RVA: 0x0038EF3E File Offset: 0x0038D13E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeasonData()
		{
		}

		// Token: 0x06018727 RID: 100135 RVA: 0x0038EF5C File Offset: 0x0038D15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeasonData(SeasonData other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this.startTime_ = other.startTime_;
			this.endTime_ = other.endTime_;
			this.roguelikeTokenList_ = other.roguelikeTokenList_.Clone();
			this.seasonRewardList_ = other.seasonRewardList_.Clone();
			this.tokenItemCount_ = other.tokenItemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018728 RID: 100136 RVA: 0x0038EFD2 File Offset: 0x0038D1D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeasonData Clone()
		{
			return new SeasonData(this);
		}

		// Token: 0x17005269 RID: 21097
		// (get) Token: 0x06018729 RID: 100137 RVA: 0x0038EFDA File Offset: 0x0038D1DA
		// (set) Token: 0x0601872A RID: 100138 RVA: 0x0038EFE2 File Offset: 0x0038D1E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SeasonId
		{
			get
			{
				return this.seasonId_;
			}
			set
			{
				this.seasonId_ = value;
			}
		}

		// Token: 0x1700526A RID: 21098
		// (get) Token: 0x0601872B RID: 100139 RVA: 0x0038EFEB File Offset: 0x0038D1EB
		// (set) Token: 0x0601872C RID: 100140 RVA: 0x0038EFF3 File Offset: 0x0038D1F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long StartTime
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

		// Token: 0x1700526B RID: 21099
		// (get) Token: 0x0601872D RID: 100141 RVA: 0x0038EFFC File Offset: 0x0038D1FC
		// (set) Token: 0x0601872E RID: 100142 RVA: 0x0038F004 File Offset: 0x0038D204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x1700526C RID: 21100
		// (get) Token: 0x0601872F RID: 100143 RVA: 0x0038F00D File Offset: 0x0038D20D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoguelikeToken> RoguelikeTokenList
		{
			get
			{
				return this.roguelikeTokenList_;
			}
		}

		// Token: 0x1700526D RID: 21101
		// (get) Token: 0x06018730 RID: 100144 RVA: 0x0038F015 File Offset: 0x0038D215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SeasonReward> SeasonRewardList
		{
			get
			{
				return this.seasonRewardList_;
			}
		}

		// Token: 0x1700526E RID: 21102
		// (get) Token: 0x06018731 RID: 100145 RVA: 0x0038F01D File Offset: 0x0038D21D
		// (set) Token: 0x06018732 RID: 100146 RVA: 0x0038F025 File Offset: 0x0038D225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TokenItemCount
		{
			get
			{
				return this.tokenItemCount_;
			}
			set
			{
				this.tokenItemCount_ = value;
			}
		}

		// Token: 0x06018733 RID: 100147 RVA: 0x0038F02E File Offset: 0x0038D22E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SeasonData);
		}

		// Token: 0x06018734 RID: 100148 RVA: 0x0038F03C File Offset: 0x0038D23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SeasonData other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && this.StartTime == other.StartTime && this.EndTime == other.EndTime && this.roguelikeTokenList_.Equals(other.roguelikeTokenList_) && this.seasonRewardList_.Equals(other.seasonRewardList_) && this.TokenItemCount == other.TokenItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018735 RID: 100149 RVA: 0x0038F0D0 File Offset: 0x0038D2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			if (this.StartTime != 0L)
			{
				num ^= this.StartTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			num ^= this.roguelikeTokenList_.GetHashCode();
			num ^= this.seasonRewardList_.GetHashCode();
			if (this.TokenItemCount != 0)
			{
				num ^= this.TokenItemCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018736 RID: 100150 RVA: 0x0038F176 File Offset: 0x0038D376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018737 RID: 100151 RVA: 0x0038F183 File Offset: 0x0038D383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018738 RID: 100152 RVA: 0x0038F18C File Offset: 0x0038D38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SeasonId);
			}
			if (this.StartTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.StartTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EndTime);
			}
			this.roguelikeTokenList_.WriteTo(ref output, SeasonData._repeated_roguelikeTokenList_codec);
			this.seasonRewardList_.WriteTo(ref output, SeasonData._repeated_seasonRewardList_codec);
			if (this.TokenItemCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TokenItemCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018739 RID: 100153 RVA: 0x0038F240 File Offset: 0x0038D440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
			if (this.StartTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.StartTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			num += this.roguelikeTokenList_.CalculateSize(SeasonData._repeated_roguelikeTokenList_codec);
			num += this.seasonRewardList_.CalculateSize(SeasonData._repeated_seasonRewardList_codec);
			if (this.TokenItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TokenItemCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601873A RID: 100154 RVA: 0x0038F2EC File Offset: 0x0038D4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SeasonData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			if (other.StartTime != 0L)
			{
				this.StartTime = other.StartTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			this.roguelikeTokenList_.Add(other.roguelikeTokenList_);
			this.seasonRewardList_.Add(other.seasonRewardList_);
			if (other.TokenItemCount != 0)
			{
				this.TokenItemCount = other.TokenItemCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601873B RID: 100155 RVA: 0x0038F386 File Offset: 0x0038D586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601873C RID: 100156 RVA: 0x0038F390 File Offset: 0x0038D590
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.SeasonId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.StartTime = input.ReadInt64();
						continue;
					}
					if (num == 24U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						this.roguelikeTokenList_.AddEntriesFrom(ref input, SeasonData._repeated_roguelikeTokenList_codec);
						continue;
					}
					if (num == 42U)
					{
						this.seasonRewardList_.AddEntriesFrom(ref input, SeasonData._repeated_seasonRewardList_codec);
						continue;
					}
					if (num == 48U)
					{
						this.TokenItemCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400912A RID: 37162
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400912B RID: 37163
		public const int SeasonIdFieldNumber = 1;

		// Token: 0x0400912C RID: 37164
		private int seasonId_;

		// Token: 0x0400912D RID: 37165
		public const int StartTimeFieldNumber = 2;

		// Token: 0x0400912E RID: 37166
		private long startTime_;

		// Token: 0x0400912F RID: 37167
		public const int EndTimeFieldNumber = 3;

		// Token: 0x04009130 RID: 37168
		private long endTime_;

		// Token: 0x04009131 RID: 37169
		public const int RoguelikeTokenListFieldNumber = 4;

		// Token: 0x04009132 RID: 37170
		private static readonly FieldCodec<RoguelikeToken> _repeated_roguelikeTokenList_codec = FieldCodec.ForMessage<RoguelikeToken>(34U, RoguelikeToken.Parser);

		// Token: 0x04009133 RID: 37171
		private readonly RepeatedField<RoguelikeToken> roguelikeTokenList_ = new RepeatedField<RoguelikeToken>();

		// Token: 0x04009134 RID: 37172
		public const int SeasonRewardListFieldNumber = 5;

		// Token: 0x04009135 RID: 37173
		private static readonly FieldCodec<SeasonReward> _repeated_seasonRewardList_codec = FieldCodec.ForMessage<SeasonReward>(42U, SeasonReward.Parser);

		// Token: 0x04009136 RID: 37174
		private readonly RepeatedField<SeasonReward> seasonRewardList_ = new RepeatedField<SeasonReward>();

		// Token: 0x04009137 RID: 37175
		public const int TokenItemCountFieldNumber = 6;

		// Token: 0x04009138 RID: 37176
		private int tokenItemCount_;
	}
}
