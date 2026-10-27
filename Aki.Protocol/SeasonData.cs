using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011AA RID: 4522
	public sealed class SeasonData : IMessage<SeasonData>, IMessage, IEquatable<SeasonData>, IDeepCloneable<SeasonData>, IBufferMessage
	{
		// Token: 0x06018182 RID: 98690 RVA: 0x0037FBE9 File Offset: 0x0037DDE9
		[NullableContext(1)]
		public static SeasonData Create()
		{
			return new SeasonData();
		}

		// Token: 0x170050FB RID: 20731
		// (get) Token: 0x06018183 RID: 98691 RVA: 0x0037FBF0 File Offset: 0x0037DDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050FC RID: 20732
		// (get) Token: 0x06018184 RID: 98692 RVA: 0x0037FBF3 File Offset: 0x0037DDF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SeasonData.Descriptor;
			}
		}

		// Token: 0x06018185 RID: 98693 RVA: 0x0037FBFA File Offset: 0x0037DDFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeasonData()
		{
		}

		// Token: 0x06018186 RID: 98694 RVA: 0x0037FC18 File Offset: 0x0037DE18
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

		// Token: 0x06018187 RID: 98695 RVA: 0x0037FC8E File Offset: 0x0037DE8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeasonData Clone()
		{
			return new SeasonData(this);
		}

		// Token: 0x170050FD RID: 20733
		// (get) Token: 0x06018188 RID: 98696 RVA: 0x0037FC96 File Offset: 0x0037DE96
		// (set) Token: 0x06018189 RID: 98697 RVA: 0x0037FC9E File Offset: 0x0037DE9E
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

		// Token: 0x170050FE RID: 20734
		// (get) Token: 0x0601818A RID: 98698 RVA: 0x0037FCA7 File Offset: 0x0037DEA7
		// (set) Token: 0x0601818B RID: 98699 RVA: 0x0037FCAF File Offset: 0x0037DEAF
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

		// Token: 0x170050FF RID: 20735
		// (get) Token: 0x0601818C RID: 98700 RVA: 0x0037FCB8 File Offset: 0x0037DEB8
		// (set) Token: 0x0601818D RID: 98701 RVA: 0x0037FCC0 File Offset: 0x0037DEC0
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

		// Token: 0x17005100 RID: 20736
		// (get) Token: 0x0601818E RID: 98702 RVA: 0x0037FCC9 File Offset: 0x0037DEC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoguelikeToken> RoguelikeTokenList
		{
			get
			{
				return this.roguelikeTokenList_;
			}
		}

		// Token: 0x17005101 RID: 20737
		// (get) Token: 0x0601818F RID: 98703 RVA: 0x0037FCD1 File Offset: 0x0037DED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SeasonReward> SeasonRewardList
		{
			get
			{
				return this.seasonRewardList_;
			}
		}

		// Token: 0x17005102 RID: 20738
		// (get) Token: 0x06018190 RID: 98704 RVA: 0x0037FCD9 File Offset: 0x0037DED9
		// (set) Token: 0x06018191 RID: 98705 RVA: 0x0037FCE1 File Offset: 0x0037DEE1
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

		// Token: 0x06018192 RID: 98706 RVA: 0x0037FCEA File Offset: 0x0037DEEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SeasonData);
		}

		// Token: 0x06018193 RID: 98707 RVA: 0x0037FCF8 File Offset: 0x0037DEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SeasonData other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && this.StartTime == other.StartTime && this.EndTime == other.EndTime && this.roguelikeTokenList_.Equals(other.roguelikeTokenList_) && this.seasonRewardList_.Equals(other.seasonRewardList_) && this.TokenItemCount == other.TokenItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018194 RID: 98708 RVA: 0x0037FD8C File Offset: 0x0037DF8C
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

		// Token: 0x06018195 RID: 98709 RVA: 0x0037FE32 File Offset: 0x0037E032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018196 RID: 98710 RVA: 0x0037FE3F File Offset: 0x0037E03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018197 RID: 98711 RVA: 0x0037FE48 File Offset: 0x0037E048
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

		// Token: 0x06018198 RID: 98712 RVA: 0x0037FEFC File Offset: 0x0037E0FC
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

		// Token: 0x06018199 RID: 98713 RVA: 0x0037FFA8 File Offset: 0x0037E1A8
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

		// Token: 0x0601819A RID: 98714 RVA: 0x00380042 File Offset: 0x0037E242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601819B RID: 98715 RVA: 0x0038004C File Offset: 0x0037E24C
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

		// Token: 0x04008E97 RID: 36503
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E98 RID: 36504
		public const int SeasonIdFieldNumber = 1;

		// Token: 0x04008E99 RID: 36505
		private int seasonId_;

		// Token: 0x04008E9A RID: 36506
		public const int StartTimeFieldNumber = 2;

		// Token: 0x04008E9B RID: 36507
		private long startTime_;

		// Token: 0x04008E9C RID: 36508
		public const int EndTimeFieldNumber = 3;

		// Token: 0x04008E9D RID: 36509
		private long endTime_;

		// Token: 0x04008E9E RID: 36510
		public const int RoguelikeTokenListFieldNumber = 4;

		// Token: 0x04008E9F RID: 36511
		private static readonly FieldCodec<RoguelikeToken> _repeated_roguelikeTokenList_codec = FieldCodec.ForMessage<RoguelikeToken>(34U, RoguelikeToken.Parser);

		// Token: 0x04008EA0 RID: 36512
		private readonly RepeatedField<RoguelikeToken> roguelikeTokenList_ = new RepeatedField<RoguelikeToken>();

		// Token: 0x04008EA1 RID: 36513
		public const int SeasonRewardListFieldNumber = 5;

		// Token: 0x04008EA2 RID: 36514
		private static readonly FieldCodec<SeasonReward> _repeated_seasonRewardList_codec = FieldCodec.ForMessage<SeasonReward>(42U, SeasonReward.Parser);

		// Token: 0x04008EA3 RID: 36515
		private readonly RepeatedField<SeasonReward> seasonRewardList_ = new RepeatedField<SeasonReward>();

		// Token: 0x04008EA4 RID: 36516
		public const int TokenItemCountFieldNumber = 6;

		// Token: 0x04008EA5 RID: 36517
		private int tokenItemCount_;
	}
}
