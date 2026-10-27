using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F5F RID: 3935
	public sealed class RiskHarvestInstInfo : IMessage<RiskHarvestInstInfo>, IMessage, IEquatable<RiskHarvestInstInfo>, IDeepCloneable<RiskHarvestInstInfo>, IBufferMessage
	{
		// Token: 0x060150B9 RID: 86201 RVA: 0x0030D747 File Offset: 0x0030B947
		[NullableContext(1)]
		public static RiskHarvestInstInfo Create()
		{
			return new RiskHarvestInstInfo();
		}

		// Token: 0x17004601 RID: 17921
		// (get) Token: 0x060150BA RID: 86202 RVA: 0x0030D74E File Offset: 0x0030B94E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RiskHarvestInstInfo> Parser
		{
			get
			{
				return RiskHarvestInstInfo._parser;
			}
		}

		// Token: 0x17004602 RID: 17922
		// (get) Token: 0x060150BB RID: 86203 RVA: 0x0030D755 File Offset: 0x0030B955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004603 RID: 17923
		// (get) Token: 0x060150BC RID: 86204 RVA: 0x0030D758 File Offset: 0x0030B958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestInstInfo.Descriptor;
			}
		}

		// Token: 0x060150BD RID: 86205 RVA: 0x0030D75F File Offset: 0x0030B95F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstInfo()
		{
		}

		// Token: 0x060150BE RID: 86206 RVA: 0x0030D774 File Offset: 0x0030B974
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

		// Token: 0x060150BF RID: 86207 RVA: 0x0030D7F1 File Offset: 0x0030B9F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestInstInfo Clone()
		{
			return new RiskHarvestInstInfo(this);
		}

		// Token: 0x17004604 RID: 17924
		// (get) Token: 0x060150C0 RID: 86208 RVA: 0x0030D7F9 File Offset: 0x0030B9F9
		// (set) Token: 0x060150C1 RID: 86209 RVA: 0x0030D801 File Offset: 0x0030BA01
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

		// Token: 0x17004605 RID: 17925
		// (get) Token: 0x060150C2 RID: 86210 RVA: 0x0030D80A File Offset: 0x0030BA0A
		// (set) Token: 0x060150C3 RID: 86211 RVA: 0x0030D812 File Offset: 0x0030BA12
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

		// Token: 0x17004606 RID: 17926
		// (get) Token: 0x060150C4 RID: 86212 RVA: 0x0030D81B File Offset: 0x0030BA1B
		// (set) Token: 0x060150C5 RID: 86213 RVA: 0x0030D823 File Offset: 0x0030BA23
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

		// Token: 0x17004607 RID: 17927
		// (get) Token: 0x060150C6 RID: 86214 RVA: 0x0030D82C File Offset: 0x0030BA2C
		// (set) Token: 0x060150C7 RID: 86215 RVA: 0x0030D834 File Offset: 0x0030BA34
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

		// Token: 0x17004608 RID: 17928
		// (get) Token: 0x060150C8 RID: 86216 RVA: 0x0030D83D File Offset: 0x0030BA3D
		// (set) Token: 0x060150C9 RID: 86217 RVA: 0x0030D845 File Offset: 0x0030BA45
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

		// Token: 0x17004609 RID: 17929
		// (get) Token: 0x060150CA RID: 86218 RVA: 0x0030D84E File Offset: 0x0030BA4E
		// (set) Token: 0x060150CB RID: 86219 RVA: 0x0030D856 File Offset: 0x0030BA56
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

		// Token: 0x1700460A RID: 17930
		// (get) Token: 0x060150CC RID: 86220 RVA: 0x0030D85F File Offset: 0x0030BA5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RiskHarvestStarRewardInfo> StarRewardInfos
		{
			get
			{
				return this.starRewardInfos_;
			}
		}

		// Token: 0x060150CD RID: 86221 RVA: 0x0030D867 File Offset: 0x0030BA67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestInstInfo);
		}

		// Token: 0x060150CE RID: 86222 RVA: 0x0030D878 File Offset: 0x0030BA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestInstInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.UnlockTime == other.UnlockTime && this.IsUnlock == other.IsUnlock && this.Score == other.Score && this.Rewarded == other.Rewarded && this.Pass == other.Pass && this.starRewardInfos_.Equals(other.starRewardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060150CF RID: 86223 RVA: 0x0030D918 File Offset: 0x0030BB18
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

		// Token: 0x060150D0 RID: 86224 RVA: 0x0030D9E2 File Offset: 0x0030BBE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060150D1 RID: 86225 RVA: 0x0030D9EF File Offset: 0x0030BBEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060150D2 RID: 86226 RVA: 0x0030D9F8 File Offset: 0x0030BBF8
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

		// Token: 0x060150D3 RID: 86227 RVA: 0x0030DAD4 File Offset: 0x0030BCD4
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

		// Token: 0x060150D4 RID: 86228 RVA: 0x0030DB7C File Offset: 0x0030BD7C
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

		// Token: 0x060150D5 RID: 86229 RVA: 0x0030DC2D File Offset: 0x0030BE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060150D6 RID: 86230 RVA: 0x0030DC38 File Offset: 0x0030BE38
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

		// Token: 0x04007EC7 RID: 32455
		private static readonly MessageParser<RiskHarvestInstInfo> _parser = new MessageParser<RiskHarvestInstInfo>(() => new RiskHarvestInstInfo());

		// Token: 0x04007EC8 RID: 32456
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EC9 RID: 32457
		public const int IdFieldNumber = 1;

		// Token: 0x04007ECA RID: 32458
		private int id_;

		// Token: 0x04007ECB RID: 32459
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x04007ECC RID: 32460
		private long unlockTime_;

		// Token: 0x04007ECD RID: 32461
		public const int IsUnlockFieldNumber = 3;

		// Token: 0x04007ECE RID: 32462
		private bool isUnlock_;

		// Token: 0x04007ECF RID: 32463
		public const int ScoreFieldNumber = 4;

		// Token: 0x04007ED0 RID: 32464
		private int score_;

		// Token: 0x04007ED1 RID: 32465
		public const int RewardedFieldNumber = 5;

		// Token: 0x04007ED2 RID: 32466
		private bool rewarded_;

		// Token: 0x04007ED3 RID: 32467
		public const int PassFieldNumber = 6;

		// Token: 0x04007ED4 RID: 32468
		private bool pass_;

		// Token: 0x04007ED5 RID: 32469
		public const int StarRewardInfosFieldNumber = 7;

		// Token: 0x04007ED6 RID: 32470
		private static readonly FieldCodec<RiskHarvestStarRewardInfo> _repeated_starRewardInfos_codec = FieldCodec.ForMessage<RiskHarvestStarRewardInfo>(58U, RiskHarvestStarRewardInfo.Parser);

		// Token: 0x04007ED7 RID: 32471
		private readonly RepeatedField<RiskHarvestStarRewardInfo> starRewardInfos_ = new RepeatedField<RiskHarvestStarRewardInfo>();
	}
}
