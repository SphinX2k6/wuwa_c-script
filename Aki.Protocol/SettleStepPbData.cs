using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200121C RID: 4636
	public sealed class SettleStepPbData : IMessage<SettleStepPbData>, IMessage, IEquatable<SettleStepPbData>, IDeepCloneable<SettleStepPbData>, IBufferMessage
	{
		// Token: 0x06018C11 RID: 101393 RVA: 0x0039B777 File Offset: 0x00399977
		[NullableContext(1)]
		public static SettleStepPbData Create()
		{
			return new SettleStepPbData();
		}

		// Token: 0x1700538F RID: 21391
		// (get) Token: 0x06018C12 RID: 101394 RVA: 0x0039B77E File Offset: 0x0039997E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005390 RID: 21392
		// (get) Token: 0x06018C13 RID: 101395 RVA: 0x0039B781 File Offset: 0x00399981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SettleStepPbData.Descriptor;
			}
		}

		// Token: 0x06018C14 RID: 101396 RVA: 0x0039B788 File Offset: 0x00399988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettleStepPbData()
		{
		}

		// Token: 0x06018C15 RID: 101397 RVA: 0x0039B7A8 File Offset: 0x003999A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettleStepPbData(SettleStepPbData other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.stageId_ = other.stageId_;
			this.floorId_ = other.floorId_;
			this.branchIndex_ = other.branchIndex_;
			this.costTimeMs_ = other.costTimeMs_;
			this.gainTimeMs_ = other.gainTimeMs_;
			this.remainTimeMs_ = other.remainTimeMs_;
			this.teamStarInfo_ = other.teamStarInfo_.Clone();
			this.phantomInfo_ = ((other.phantomInfo_ != null) ? other.phantomInfo_.Clone() : null);
			this.gainTokens_ = other.gainTokens_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018C16 RID: 101398 RVA: 0x0039B85E File Offset: 0x00399A5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettleStepPbData Clone()
		{
			return new SettleStepPbData(this);
		}

		// Token: 0x17005391 RID: 21393
		// (get) Token: 0x06018C17 RID: 101399 RVA: 0x0039B866 File Offset: 0x00399A66
		// (set) Token: 0x06018C18 RID: 101400 RVA: 0x0039B86E File Offset: 0x00399A6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x17005392 RID: 21394
		// (get) Token: 0x06018C19 RID: 101401 RVA: 0x0039B877 File Offset: 0x00399A77
		// (set) Token: 0x06018C1A RID: 101402 RVA: 0x0039B87F File Offset: 0x00399A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StageId
		{
			get
			{
				return this.stageId_;
			}
			set
			{
				this.stageId_ = value;
			}
		}

		// Token: 0x17005393 RID: 21395
		// (get) Token: 0x06018C1B RID: 101403 RVA: 0x0039B888 File Offset: 0x00399A88
		// (set) Token: 0x06018C1C RID: 101404 RVA: 0x0039B890 File Offset: 0x00399A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FloorId
		{
			get
			{
				return this.floorId_;
			}
			set
			{
				this.floorId_ = value;
			}
		}

		// Token: 0x17005394 RID: 21396
		// (get) Token: 0x06018C1D RID: 101405 RVA: 0x0039B899 File Offset: 0x00399A99
		// (set) Token: 0x06018C1E RID: 101406 RVA: 0x0039B8A1 File Offset: 0x00399AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BranchIndex
		{
			get
			{
				return this.branchIndex_;
			}
			set
			{
				this.branchIndex_ = value;
			}
		}

		// Token: 0x17005395 RID: 21397
		// (get) Token: 0x06018C1F RID: 101407 RVA: 0x0039B8AA File Offset: 0x00399AAA
		// (set) Token: 0x06018C20 RID: 101408 RVA: 0x0039B8B2 File Offset: 0x00399AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CostTimeMs
		{
			get
			{
				return this.costTimeMs_;
			}
			set
			{
				this.costTimeMs_ = value;
			}
		}

		// Token: 0x17005396 RID: 21398
		// (get) Token: 0x06018C21 RID: 101409 RVA: 0x0039B8BB File Offset: 0x00399ABB
		// (set) Token: 0x06018C22 RID: 101410 RVA: 0x0039B8C3 File Offset: 0x00399AC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long GainTimeMs
		{
			get
			{
				return this.gainTimeMs_;
			}
			set
			{
				this.gainTimeMs_ = value;
			}
		}

		// Token: 0x17005397 RID: 21399
		// (get) Token: 0x06018C23 RID: 101411 RVA: 0x0039B8CC File Offset: 0x00399ACC
		// (set) Token: 0x06018C24 RID: 101412 RVA: 0x0039B8D4 File Offset: 0x00399AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RemainTimeMs
		{
			get
			{
				return this.remainTimeMs_;
			}
			set
			{
				this.remainTimeMs_ = value;
			}
		}

		// Token: 0x17005398 RID: 21400
		// (get) Token: 0x06018C25 RID: 101413 RVA: 0x0039B8DD File Offset: 0x00399ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> TeamStarInfo
		{
			get
			{
				return this.teamStarInfo_;
			}
		}

		// Token: 0x17005399 RID: 21401
		// (get) Token: 0x06018C26 RID: 101414 RVA: 0x0039B8E5 File Offset: 0x00399AE5
		// (set) Token: 0x06018C27 RID: 101415 RVA: 0x0039B8ED File Offset: 0x00399AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPhantomInfo PhantomInfo
		{
			get
			{
				return this.phantomInfo_;
			}
			set
			{
				this.phantomInfo_ = value;
			}
		}

		// Token: 0x1700539A RID: 21402
		// (get) Token: 0x06018C28 RID: 101416 RVA: 0x0039B8F6 File Offset: 0x00399AF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerTokenCount> GainTokens
		{
			get
			{
				return this.gainTokens_;
			}
		}

		// Token: 0x06018C29 RID: 101417 RVA: 0x0039B8FE File Offset: 0x00399AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SettleStepPbData);
		}

		// Token: 0x06018C2A RID: 101418 RVA: 0x0039B90C File Offset: 0x00399B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SettleStepPbData other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.StageId == other.StageId && this.FloorId == other.FloorId && this.BranchIndex == other.BranchIndex && this.CostTimeMs == other.CostTimeMs && this.GainTimeMs == other.GainTimeMs && this.RemainTimeMs == other.RemainTimeMs && this.TeamStarInfo.Equals(other.TeamStarInfo) && object.Equals(this.PhantomInfo, other.PhantomInfo) && this.gainTokens_.Equals(other.gainTokens_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018C2B RID: 101419 RVA: 0x0039B9E4 File Offset: 0x00399BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.StageId != 0)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this.FloorId != 0)
			{
				num ^= this.FloorId.GetHashCode();
			}
			if (this.BranchIndex != 0)
			{
				num ^= this.BranchIndex.GetHashCode();
			}
			if (this.CostTimeMs != 0L)
			{
				num ^= this.CostTimeMs.GetHashCode();
			}
			if (this.GainTimeMs != 0L)
			{
				num ^= this.GainTimeMs.GetHashCode();
			}
			if (this.RemainTimeMs != 0L)
			{
				num ^= this.RemainTimeMs.GetHashCode();
			}
			num ^= this.TeamStarInfo.GetHashCode();
			if (this.phantomInfo_ != null)
			{
				num ^= this.PhantomInfo.GetHashCode();
			}
			num ^= this.gainTokens_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018C2C RID: 101420 RVA: 0x0039BAEB File Offset: 0x00399CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018C2D RID: 101421 RVA: 0x0039BAF8 File Offset: 0x00399CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018C2E RID: 101422 RVA: 0x0039BB04 File Offset: 0x00399D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.StageId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.StageId);
			}
			if (this.FloorId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FloorId);
			}
			if (this.BranchIndex != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.BranchIndex);
			}
			if (this.CostTimeMs != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.CostTimeMs);
			}
			if (this.GainTimeMs != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.GainTimeMs);
			}
			if (this.RemainTimeMs != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.RemainTimeMs);
			}
			this.teamStarInfo_.WriteTo(ref output, SettleStepPbData._map_teamStarInfo_codec);
			if (this.phantomInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PhantomInfo);
			}
			this.gainTokens_.WriteTo(ref output, SettleStepPbData._repeated_gainTokens_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018C2F RID: 101423 RVA: 0x0039BC28 File Offset: 0x00399E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.StageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StageId);
			}
			if (this.FloorId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FloorId);
			}
			if (this.BranchIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BranchIndex);
			}
			if (this.CostTimeMs != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CostTimeMs);
			}
			if (this.GainTimeMs != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.GainTimeMs);
			}
			if (this.RemainTimeMs != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RemainTimeMs);
			}
			num += this.teamStarInfo_.CalculateSize(SettleStepPbData._map_teamStarInfo_codec);
			if (this.phantomInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomInfo);
			}
			num += this.gainTokens_.CalculateSize(SettleStepPbData._repeated_gainTokens_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018C30 RID: 101424 RVA: 0x0039BD34 File Offset: 0x00399F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SettleStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.StageId != 0)
			{
				this.StageId = other.StageId;
			}
			if (other.FloorId != 0)
			{
				this.FloorId = other.FloorId;
			}
			if (other.BranchIndex != 0)
			{
				this.BranchIndex = other.BranchIndex;
			}
			if (other.CostTimeMs != 0L)
			{
				this.CostTimeMs = other.CostTimeMs;
			}
			if (other.GainTimeMs != 0L)
			{
				this.GainTimeMs = other.GainTimeMs;
			}
			if (other.RemainTimeMs != 0L)
			{
				this.RemainTimeMs = other.RemainTimeMs;
			}
			this.teamStarInfo_.MergeFrom(other.teamStarInfo_);
			if (other.phantomInfo_ != null)
			{
				if (this.phantomInfo_ == null)
				{
					this.PhantomInfo = new RoleTowerPhantomInfo();
				}
				this.PhantomInfo.MergeFrom(other.PhantomInfo);
			}
			this.gainTokens_.Add(other.gainTokens_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018C31 RID: 101425 RVA: 0x0039BE36 File Offset: 0x0039A036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018C32 RID: 101426 RVA: 0x0039BE40 File Offset: 0x0039A040
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
				if (num <= 48U)
				{
					if (num <= 24U)
					{
						if (num == 16U)
						{
							this.ChallengeId = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.StageId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.FloorId = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.BranchIndex = input.ReadInt32();
							continue;
						}
						if (num == 48U)
						{
							this.CostTimeMs = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 64U)
				{
					if (num == 56U)
					{
						this.GainTimeMs = input.ReadInt64();
						continue;
					}
					if (num == 64U)
					{
						this.RemainTimeMs = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.teamStarInfo_.AddEntriesFrom(ref input, SettleStepPbData._map_teamStarInfo_codec);
						continue;
					}
					if (num == 82U)
					{
						if (this.phantomInfo_ == null)
						{
							this.PhantomInfo = new RoleTowerPhantomInfo();
						}
						input.ReadMessage(this.PhantomInfo);
						continue;
					}
					if (num == 90U)
					{
						this.gainTokens_.AddEntriesFrom(ref input, SettleStepPbData._repeated_gainTokens_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040092D6 RID: 37590
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092D7 RID: 37591
		public const int ChallengeIdFieldNumber = 2;

		// Token: 0x040092D8 RID: 37592
		private int challengeId_;

		// Token: 0x040092D9 RID: 37593
		public const int StageIdFieldNumber = 3;

		// Token: 0x040092DA RID: 37594
		private int stageId_;

		// Token: 0x040092DB RID: 37595
		public const int FloorIdFieldNumber = 4;

		// Token: 0x040092DC RID: 37596
		private int floorId_;

		// Token: 0x040092DD RID: 37597
		public const int BranchIndexFieldNumber = 5;

		// Token: 0x040092DE RID: 37598
		private int branchIndex_;

		// Token: 0x040092DF RID: 37599
		public const int CostTimeMsFieldNumber = 6;

		// Token: 0x040092E0 RID: 37600
		private long costTimeMs_;

		// Token: 0x040092E1 RID: 37601
		public const int GainTimeMsFieldNumber = 7;

		// Token: 0x040092E2 RID: 37602
		private long gainTimeMs_;

		// Token: 0x040092E3 RID: 37603
		public const int RemainTimeMsFieldNumber = 8;

		// Token: 0x040092E4 RID: 37604
		private long remainTimeMs_;

		// Token: 0x040092E5 RID: 37605
		public const int TeamStarInfoFieldNumber = 9;

		// Token: 0x040092E6 RID: 37606
		private static readonly MapField<int, int>.Codec _map_teamStarInfo_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 74U);

		// Token: 0x040092E7 RID: 37607
		private readonly MapField<int, int> teamStarInfo_ = new MapField<int, int>();

		// Token: 0x040092E8 RID: 37608
		public const int PhantomInfoFieldNumber = 10;

		// Token: 0x040092E9 RID: 37609
		private RoleTowerPhantomInfo phantomInfo_;

		// Token: 0x040092EA RID: 37610
		public const int GainTokensFieldNumber = 11;

		// Token: 0x040092EB RID: 37611
		private static readonly FieldCodec<RoleTowerTokenCount> _repeated_gainTokens_codec = FieldCodec.ForMessage<RoleTowerTokenCount>(90U, RoleTowerTokenCount.Parser);

		// Token: 0x040092EC RID: 37612
		private readonly RepeatedField<RoleTowerTokenCount> gainTokens_ = new RepeatedField<RoleTowerTokenCount>();
	}
}
