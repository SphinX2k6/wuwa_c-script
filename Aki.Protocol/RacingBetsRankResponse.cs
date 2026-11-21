using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E63 RID: 3683
	[NetMessage(EMessageId.RacingBetsRankResponse)]
	public sealed class RacingBetsRankResponse : IMessage<RacingBetsRankResponse>, IMessage, IEquatable<RacingBetsRankResponse>, IDeepCloneable<RacingBetsRankResponse>, IBufferMessage
	{
		// Token: 0x06013D08 RID: 81160 RVA: 0x002E35D1 File Offset: 0x002E17D1
		[NullableContext(1)]
		public static RacingBetsRankResponse Create()
		{
			return new RacingBetsRankResponse();
		}

		// Token: 0x170041EA RID: 16874
		// (get) Token: 0x06013D09 RID: 81161 RVA: 0x002E35D8 File Offset: 0x002E17D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041EB RID: 16875
		// (get) Token: 0x06013D0A RID: 81162 RVA: 0x002E35DB File Offset: 0x002E17DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsRankResponse.Descriptor;
			}
		}

		// Token: 0x06013D0B RID: 81163 RVA: 0x002E35E2 File Offset: 0x002E17E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRankResponse()
		{
		}

		// Token: 0x06013D0C RID: 81164 RVA: 0x002E35F8 File Offset: 0x002E17F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRankResponse(RacingBetsRankResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.playerInfo_ = other.playerInfo_.Clone();
			this.status_ = other.status_;
			this.percentScore_ = other.percentScore_;
			this.selfData_ = ((other.selfData_ != null) ? other.selfData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013D0D RID: 81165 RVA: 0x002E366D File Offset: 0x002E186D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRankResponse Clone()
		{
			return new RacingBetsRankResponse(this);
		}

		// Token: 0x170041EC RID: 16876
		// (get) Token: 0x06013D0E RID: 81166 RVA: 0x002E3675 File Offset: 0x002E1875
		// (set) Token: 0x06013D0F RID: 81167 RVA: 0x002E367D File Offset: 0x002E187D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170041ED RID: 16877
		// (get) Token: 0x06013D10 RID: 81168 RVA: 0x002E3686 File Offset: 0x002E1886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetRankPlayerInfo> PlayerInfo
		{
			get
			{
				return this.playerInfo_;
			}
		}

		// Token: 0x170041EE RID: 16878
		// (get) Token: 0x06013D11 RID: 81169 RVA: 0x002E368E File Offset: 0x002E188E
		// (set) Token: 0x06013D12 RID: 81170 RVA: 0x002E3696 File Offset: 0x002E1896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRankStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x170041EF RID: 16879
		// (get) Token: 0x06013D13 RID: 81171 RVA: 0x002E369F File Offset: 0x002E189F
		// (set) Token: 0x06013D14 RID: 81172 RVA: 0x002E36A7 File Offset: 0x002E18A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PercentScore
		{
			get
			{
				return this.percentScore_;
			}
			set
			{
				this.percentScore_ = value;
			}
		}

		// Token: 0x170041F0 RID: 16880
		// (get) Token: 0x06013D15 RID: 81173 RVA: 0x002E36B0 File Offset: 0x002E18B0
		// (set) Token: 0x06013D16 RID: 81174 RVA: 0x002E36B8 File Offset: 0x002E18B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetRankSelfData SelfData
		{
			get
			{
				return this.selfData_;
			}
			set
			{
				this.selfData_ = value;
			}
		}

		// Token: 0x06013D17 RID: 81175 RVA: 0x002E36C1 File Offset: 0x002E18C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsRankResponse);
		}

		// Token: 0x06013D18 RID: 81176 RVA: 0x002E36D0 File Offset: 0x002E18D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsRankResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.playerInfo_.Equals(other.playerInfo_) && this.Status == other.Status && this.PercentScore == other.PercentScore && object.Equals(this.SelfData, other.SelfData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013D19 RID: 81177 RVA: 0x002E3754 File Offset: 0x002E1954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.playerInfo_.GetHashCode();
			if (this.Status != RacingBetsRankStatus.Rank)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.PercentScore != 0)
			{
				num ^= this.PercentScore.GetHashCode();
			}
			if (this.selfData_ != null)
			{
				num ^= this.SelfData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013D1A RID: 81178 RVA: 0x002E37F5 File Offset: 0x002E19F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013D1B RID: 81179 RVA: 0x002E3802 File Offset: 0x002E1A02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013D1C RID: 81180 RVA: 0x002E380C File Offset: 0x002E1A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Status != RacingBetsRankStatus.Rank)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Status);
			}
			if (this.PercentScore != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PercentScore);
			}
			this.playerInfo_.WriteTo(ref output, RacingBetsRankResponse._repeated_playerInfo_codec);
			if (this.selfData_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.SelfData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013D1D RID: 81181 RVA: 0x002E38B0 File Offset: 0x002E1AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.playerInfo_.CalculateSize(RacingBetsRankResponse._repeated_playerInfo_codec);
			if (this.Status != RacingBetsRankStatus.Rank)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.PercentScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PercentScore);
			}
			if (this.selfData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SelfData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013D1E RID: 81182 RVA: 0x002E394C File Offset: 0x002E1B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsRankResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.playerInfo_.Add(other.playerInfo_);
			if (other.Status != RacingBetsRankStatus.Rank)
			{
				this.Status = other.Status;
			}
			if (other.PercentScore != 0)
			{
				this.PercentScore = other.PercentScore;
			}
			if (other.selfData_ != null)
			{
				if (this.selfData_ == null)
				{
					this.SelfData = new RacingBetRankSelfData();
				}
				this.SelfData.MergeFrom(other.SelfData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013D1F RID: 81183 RVA: 0x002E39ED File Offset: 0x002E1BED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013D20 RID: 81184 RVA: 0x002E39F8 File Offset: 0x002E1BF8
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
				if (num <= 56U)
				{
					if (num == 24U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 56U)
					{
						this.Status = (RacingBetsRankStatus)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.PercentScore = input.ReadInt32();
						continue;
					}
					if (num == 98U)
					{
						this.playerInfo_.AddEntriesFrom(ref input, RacingBetsRankResponse._repeated_playerInfo_codec);
						continue;
					}
					if (num == 114U)
					{
						if (this.selfData_ == null)
						{
							this.SelfData = new RacingBetRankSelfData();
						}
						input.ReadMessage(this.SelfData);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040079AC RID: 31148
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079AD RID: 31149
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x040079AE RID: 31150
		private ErrorCode errorCode_;

		// Token: 0x040079AF RID: 31151
		public const int PlayerInfoFieldNumber = 12;

		// Token: 0x040079B0 RID: 31152
		private static readonly FieldCodec<RacingBetRankPlayerInfo> _repeated_playerInfo_codec = FieldCodec.ForMessage<RacingBetRankPlayerInfo>(98U, RacingBetRankPlayerInfo.Parser);

		// Token: 0x040079B1 RID: 31153
		private readonly RepeatedField<RacingBetRankPlayerInfo> playerInfo_ = new RepeatedField<RacingBetRankPlayerInfo>();

		// Token: 0x040079B2 RID: 31154
		public const int StatusFieldNumber = 7;

		// Token: 0x040079B3 RID: 31155
		private RacingBetsRankStatus status_;

		// Token: 0x040079B4 RID: 31156
		public const int PercentScoreFieldNumber = 8;

		// Token: 0x040079B5 RID: 31157
		private int percentScore_;

		// Token: 0x040079B6 RID: 31158
		public const int SelfDataFieldNumber = 14;

		// Token: 0x040079B7 RID: 31159
		private RacingBetRankSelfData selfData_;
	}
}
