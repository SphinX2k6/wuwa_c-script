using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E73 RID: 3699
	[NetMessage(EMessageId.RacingBetsRankResponse)]
	public sealed class RacingBetsRankResponse : IMessage<RacingBetsRankResponse>, IMessage, IEquatable<RacingBetsRankResponse>, IDeepCloneable<RacingBetsRankResponse>, IBufferMessage
	{
		// Token: 0x06013DED RID: 81389 RVA: 0x002E4C91 File Offset: 0x002E2E91
		[NullableContext(1)]
		public static RacingBetsRankResponse Create()
		{
			return new RacingBetsRankResponse();
		}

		// Token: 0x17004214 RID: 16916
		// (get) Token: 0x06013DEE RID: 81390 RVA: 0x002E4C98 File Offset: 0x002E2E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004215 RID: 16917
		// (get) Token: 0x06013DEF RID: 81391 RVA: 0x002E4C9B File Offset: 0x002E2E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsRankResponse.Descriptor;
			}
		}

		// Token: 0x06013DF0 RID: 81392 RVA: 0x002E4CA2 File Offset: 0x002E2EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRankResponse()
		{
		}

		// Token: 0x06013DF1 RID: 81393 RVA: 0x002E4CB8 File Offset: 0x002E2EB8
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

		// Token: 0x06013DF2 RID: 81394 RVA: 0x002E4D2D File Offset: 0x002E2F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRankResponse Clone()
		{
			return new RacingBetsRankResponse(this);
		}

		// Token: 0x17004216 RID: 16918
		// (get) Token: 0x06013DF3 RID: 81395 RVA: 0x002E4D35 File Offset: 0x002E2F35
		// (set) Token: 0x06013DF4 RID: 81396 RVA: 0x002E4D3D File Offset: 0x002E2F3D
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

		// Token: 0x17004217 RID: 16919
		// (get) Token: 0x06013DF5 RID: 81397 RVA: 0x002E4D46 File Offset: 0x002E2F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetRankPlayerInfo> PlayerInfo
		{
			get
			{
				return this.playerInfo_;
			}
		}

		// Token: 0x17004218 RID: 16920
		// (get) Token: 0x06013DF6 RID: 81398 RVA: 0x002E4D4E File Offset: 0x002E2F4E
		// (set) Token: 0x06013DF7 RID: 81399 RVA: 0x002E4D56 File Offset: 0x002E2F56
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

		// Token: 0x17004219 RID: 16921
		// (get) Token: 0x06013DF8 RID: 81400 RVA: 0x002E4D5F File Offset: 0x002E2F5F
		// (set) Token: 0x06013DF9 RID: 81401 RVA: 0x002E4D67 File Offset: 0x002E2F67
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

		// Token: 0x1700421A RID: 16922
		// (get) Token: 0x06013DFA RID: 81402 RVA: 0x002E4D70 File Offset: 0x002E2F70
		// (set) Token: 0x06013DFB RID: 81403 RVA: 0x002E4D78 File Offset: 0x002E2F78
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

		// Token: 0x06013DFC RID: 81404 RVA: 0x002E4D81 File Offset: 0x002E2F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsRankResponse);
		}

		// Token: 0x06013DFD RID: 81405 RVA: 0x002E4D90 File Offset: 0x002E2F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsRankResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.playerInfo_.Equals(other.playerInfo_) && this.Status == other.Status && this.PercentScore == other.PercentScore && object.Equals(this.SelfData, other.SelfData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013DFE RID: 81406 RVA: 0x002E4E14 File Offset: 0x002E3014
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

		// Token: 0x06013DFF RID: 81407 RVA: 0x002E4EB5 File Offset: 0x002E30B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013E00 RID: 81408 RVA: 0x002E4EC2 File Offset: 0x002E30C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013E01 RID: 81409 RVA: 0x002E4ECC File Offset: 0x002E30CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PercentScore != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PercentScore);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.playerInfo_.WriteTo(ref output, RacingBetsRankResponse._repeated_playerInfo_codec);
			if (this.selfData_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.SelfData);
			}
			if (this.Status != RacingBetsRankStatus.Rank)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013E02 RID: 81410 RVA: 0x002E4F70 File Offset: 0x002E3170
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

		// Token: 0x06013E03 RID: 81411 RVA: 0x002E500C File Offset: 0x002E320C
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

		// Token: 0x06013E04 RID: 81412 RVA: 0x002E50AD File Offset: 0x002E32AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013E05 RID: 81413 RVA: 0x002E50B8 File Offset: 0x002E32B8
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
				if (num <= 72U)
				{
					if (num == 16U)
					{
						this.PercentScore = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						this.playerInfo_.AddEntriesFrom(ref input, RacingBetsRankResponse._repeated_playerInfo_codec);
						continue;
					}
					if (num == 90U)
					{
						if (this.selfData_ == null)
						{
							this.SelfData = new RacingBetRankSelfData();
						}
						input.ReadMessage(this.SelfData);
						continue;
					}
					if (num == 120U)
					{
						this.Status = (RacingBetsRankStatus)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007982 RID: 31106
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007983 RID: 31107
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04007984 RID: 31108
		private ErrorCode errorCode_;

		// Token: 0x04007985 RID: 31109
		public const int PlayerInfoFieldNumber = 10;

		// Token: 0x04007986 RID: 31110
		private static readonly FieldCodec<RacingBetRankPlayerInfo> _repeated_playerInfo_codec = FieldCodec.ForMessage<RacingBetRankPlayerInfo>(82U, RacingBetRankPlayerInfo.Parser);

		// Token: 0x04007987 RID: 31111
		private readonly RepeatedField<RacingBetRankPlayerInfo> playerInfo_ = new RepeatedField<RacingBetRankPlayerInfo>();

		// Token: 0x04007988 RID: 31112
		public const int StatusFieldNumber = 15;

		// Token: 0x04007989 RID: 31113
		private RacingBetsRankStatus status_;

		// Token: 0x0400798A RID: 31114
		public const int PercentScoreFieldNumber = 2;

		// Token: 0x0400798B RID: 31115
		private int percentScore_;

		// Token: 0x0400798C RID: 31116
		public const int SelfDataFieldNumber = 11;

		// Token: 0x0400798D RID: 31117
		private RacingBetRankSelfData selfData_;
	}
}
