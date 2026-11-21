using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F4F RID: 3919
	public sealed class RiskHarvestInstInfo : IMessage<RiskHarvestInstInfo>, IMessage, IEquatable<RiskHarvestInstInfo>, IDeepCloneable<RiskHarvestInstInfo>, IBufferMessage
	{
		// Token: 0x06014FD4 RID: 85972 RVA: 0x0030C097 File Offset: 0x0030A297
		[NullableContext(1)]
		public static RiskHarvestInstInfo Create()
		{
			return new RiskHarvestInstInfo();
		}

		// Token: 0x170045D7 RID: 17879
		// (get) Token: 0x06014FD5 RID: 85973 RVA: 0x0030C09E File Offset: 0x0030A29E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RiskHarvestInstInfo> Parser
		{
			get
			{
				return RiskHarvestInstInfo._parser;
			}
		}

		// Token: 0x170045D8 RID: 17880
		// (get) Token: 0x06014FD6 RID: 85974 RVA: 0x0030C0A5 File Offset: 0x0030A2A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045D9 RID: 17881
		// (get) Token: 0x06014FD7 RID: 85975 RVA: 0x0030C0A8 File Offset: 0x0030A2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestInstInfo.Descriptor;
			}
		}

		// Token: 0x06014FD8 RID: 85976 RVA: 0x0030C0AF File Offset: 0x0030A2AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstInfo()
		{
		}

		// Token: 0x06014FD9 RID: 85977 RVA: 0x0030C0C4 File Offset: 0x0030A2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstInfo(RiskHarvestInstInfo other) : this()
		{
			this.id_ = other.id_;
			this.unlockTime_ = other.unlockTime_;
			this.isUnlock_ = other.isUnlock_;
			this.score_ = other.score_;
			this.rewarded_ = other.rewarded_;
			this.pass_ = other.pass_;
			this.starRewardInfos_ = other.starRewardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014FDA RID: 85978 RVA: 0x0030C141 File Offset: 0x0030A341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstInfo Clone()
		{
			return new RiskHarvestInstInfo(this);
		}

		// Token: 0x170045DA RID: 17882
		// (get) Token: 0x06014FDB RID: 85979 RVA: 0x0030C149 File Offset: 0x0030A349
		// (set) Token: 0x06014FDC RID: 85980 RVA: 0x0030C151 File Offset: 0x0030A351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170045DB RID: 17883
		// (get) Token: 0x06014FDD RID: 85981 RVA: 0x0030C15A File Offset: 0x0030A35A
		// (set) Token: 0x06014FDE RID: 85982 RVA: 0x0030C162 File Offset: 0x0030A362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				return this.unlockTime_;
			}
			set
			{
				this.unlockTime_ = value;
			}
		}

		// Token: 0x170045DC RID: 17884
		// (get) Token: 0x06014FDF RID: 85983 RVA: 0x0030C16B File Offset: 0x0030A36B
		// (set) Token: 0x06014FE0 RID: 85984 RVA: 0x0030C173 File Offset: 0x0030A373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlock
		{
			get
			{
				return this.isUnlock_;
			}
			set
			{
				this.isUnlock_ = value;
			}
		}

		// Token: 0x170045DD RID: 17885
		// (get) Token: 0x06014FE1 RID: 85985 RVA: 0x0030C17C File Offset: 0x0030A37C
		// (set) Token: 0x06014FE2 RID: 85986 RVA: 0x0030C184 File Offset: 0x0030A384
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

		// Token: 0x170045DE RID: 17886
		// (get) Token: 0x06014FE3 RID: 85987 RVA: 0x0030C18D File Offset: 0x0030A38D
		// (set) Token: 0x06014FE4 RID: 85988 RVA: 0x0030C195 File Offset: 0x0030A395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Rewarded
		{
			get
			{
				return this.rewarded_;
			}
			set
			{
				this.rewarded_ = value;
			}
		}

		// Token: 0x170045DF RID: 17887
		// (get) Token: 0x06014FE5 RID: 85989 RVA: 0x0030C19E File Offset: 0x0030A39E
		// (set) Token: 0x06014FE6 RID: 85990 RVA: 0x0030C1A6 File Offset: 0x0030A3A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Pass
		{
			get
			{
				return this.pass_;
			}
			set
			{
				this.pass_ = value;
			}
		}

		// Token: 0x170045E0 RID: 17888
		// (get) Token: 0x06014FE7 RID: 85991 RVA: 0x0030C1AF File Offset: 0x0030A3AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RiskHarvestStarRewardInfo> StarRewardInfos
		{
			get
			{
				return this.starRewardInfos_;
			}
		}

		// Token: 0x06014FE8 RID: 85992 RVA: 0x0030C1B7 File Offset: 0x0030A3B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestInstInfo);
		}

		// Token: 0x06014FE9 RID: 85993 RVA: 0x0030C1C8 File Offset: 0x0030A3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestInstInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.UnlockTime == other.UnlockTime && this.IsUnlock == other.IsUnlock && this.Score == other.Score && this.Rewarded == other.Rewarded && this.Pass == other.Pass && this.starRewardInfos_.Equals(other.starRewardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014FEA RID: 85994 RVA: 0x0030C268 File Offset: 0x0030A468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.Rewarded)
			{
				num ^= this.Rewarded.GetHashCode();
			}
			if (this.Pass)
			{
				num ^= this.Pass.GetHashCode();
			}
			num ^= this.starRewardInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014FEB RID: 85995 RVA: 0x0030C332 File Offset: 0x0030A532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014FEC RID: 85996 RVA: 0x0030C33F File Offset: 0x0030A53F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014FED RID: 85997 RVA: 0x0030C348 File Offset: 0x0030A548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.UnlockTime);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsUnlock);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Score);
			}
			if (this.Rewarded)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.Rewarded);
			}
			if (this.Pass)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.Pass);
			}
			this.starRewardInfos_.WriteTo(ref output, RiskHarvestInstInfo._repeated_starRewardInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014FEE RID: 85998 RVA: 0x0030C424 File Offset: 0x0030A624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.Rewarded)
			{
				num += 2;
			}
			if (this.Pass)
			{
				num += 2;
			}
			num += this.starRewardInfos_.CalculateSize(RiskHarvestInstInfo._repeated_starRewardInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014FEF RID: 85999 RVA: 0x0030C4CC File Offset: 0x0030A6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestInstInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.Rewarded)
			{
				this.Rewarded = other.Rewarded;
			}
			if (other.Pass)
			{
				this.Pass = other.Pass;
			}
			this.starRewardInfos_.Add(other.starRewardInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014FF0 RID: 86000 RVA: 0x0030C57D File Offset: 0x0030A77D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014FF1 RID: 86001 RVA: 0x0030C588 File Offset: 0x0030A788
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
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.UnlockTime = input.ReadInt64();
						continue;
					}
					if (num == 24U)
					{
						this.IsUnlock = input.ReadBool();
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Rewarded = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.Pass = input.ReadBool();
						continue;
					}
					if (num == 58U)
					{
						this.starRewardInfos_.AddEntriesFrom(ref input, RiskHarvestInstInfo._repeated_starRewardInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007EF1 RID: 32497
		private static readonly MessageParser<RiskHarvestInstInfo> _parser = new MessageParser<RiskHarvestInstInfo>(() => new RiskHarvestInstInfo());

		// Token: 0x04007EF2 RID: 32498
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EF3 RID: 32499
		public const int IdFieldNumber = 1;

		// Token: 0x04007EF4 RID: 32500
		private int id_;

		// Token: 0x04007EF5 RID: 32501
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x04007EF6 RID: 32502
		private long unlockTime_;

		// Token: 0x04007EF7 RID: 32503
		public const int IsUnlockFieldNumber = 3;

		// Token: 0x04007EF8 RID: 32504
		private bool isUnlock_;

		// Token: 0x04007EF9 RID: 32505
		public const int ScoreFieldNumber = 4;

		// Token: 0x04007EFA RID: 32506
		private int score_;

		// Token: 0x04007EFB RID: 32507
		public const int RewardedFieldNumber = 5;

		// Token: 0x04007EFC RID: 32508
		private bool rewarded_;

		// Token: 0x04007EFD RID: 32509
		public const int PassFieldNumber = 6;

		// Token: 0x04007EFE RID: 32510
		private bool pass_;

		// Token: 0x04007EFF RID: 32511
		public const int StarRewardInfosFieldNumber = 7;

		// Token: 0x04007F00 RID: 32512
		private static readonly FieldCodec<RiskHarvestStarRewardInfo> _repeated_starRewardInfos_codec = FieldCodec.ForMessage<RiskHarvestStarRewardInfo>(58U, RiskHarvestStarRewardInfo.Parser);

		// Token: 0x04007F01 RID: 32513
		private readonly RepeatedField<RiskHarvestStarRewardInfo> starRewardInfos_ = new RepeatedField<RiskHarvestStarRewardInfo>();
	}
}
