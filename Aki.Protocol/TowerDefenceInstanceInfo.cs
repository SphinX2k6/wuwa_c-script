using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001413 RID: 5139
	public sealed class TowerDefenceInstanceInfo : IMessage<TowerDefenceInstanceInfo>, IMessage, IEquatable<TowerDefenceInstanceInfo>, IDeepCloneable<TowerDefenceInstanceInfo>, IBufferMessage
	{
		// Token: 0x0601B50D RID: 111885 RVA: 0x003F8FA8 File Offset: 0x003F71A8
		[NullableContext(1)]
		public static TowerDefenceInstanceInfo Create()
		{
			return new TowerDefenceInstanceInfo();
		}

		// Token: 0x17005C76 RID: 23670
		// (get) Token: 0x0601B50E RID: 111886 RVA: 0x003F8FAF File Offset: 0x003F71AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerDefenceInstanceInfo> Parser
		{
			get
			{
				return TowerDefenceInstanceInfo._parser;
			}
		}

		// Token: 0x17005C77 RID: 23671
		// (get) Token: 0x0601B50F RID: 111887 RVA: 0x003F8FB6 File Offset: 0x003F71B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C78 RID: 23672
		// (get) Token: 0x0601B510 RID: 111888 RVA: 0x003F8FB9 File Offset: 0x003F71B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceInstanceInfo.Descriptor;
			}
		}

		// Token: 0x0601B511 RID: 111889 RVA: 0x003F8FC0 File Offset: 0x003F71C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceInfo()
		{
		}

		// Token: 0x0601B512 RID: 111890 RVA: 0x003F8FC8 File Offset: 0x003F71C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceInfo(TowerDefenceInstanceInfo other) : this()
		{
			this.id_ = other.id_;
			this.score_ = other.score_;
			this.rewarded_ = other.rewarded_;
			this.passed_ = other.passed_;
			this.unlockTime_ = other.unlockTime_;
			this.maxScore_ = other.maxScore_;
			this.passTime_ = other.passTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B513 RID: 111891 RVA: 0x003F9040 File Offset: 0x003F7240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceInfo Clone()
		{
			return new TowerDefenceInstanceInfo(this);
		}

		// Token: 0x17005C79 RID: 23673
		// (get) Token: 0x0601B514 RID: 111892 RVA: 0x003F9048 File Offset: 0x003F7248
		// (set) Token: 0x0601B515 RID: 111893 RVA: 0x003F9050 File Offset: 0x003F7250
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

		// Token: 0x17005C7A RID: 23674
		// (get) Token: 0x0601B516 RID: 111894 RVA: 0x003F9059 File Offset: 0x003F7259
		// (set) Token: 0x0601B517 RID: 111895 RVA: 0x003F9061 File Offset: 0x003F7261
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

		// Token: 0x17005C7B RID: 23675
		// (get) Token: 0x0601B518 RID: 111896 RVA: 0x003F906A File Offset: 0x003F726A
		// (set) Token: 0x0601B519 RID: 111897 RVA: 0x003F9072 File Offset: 0x003F7272
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

		// Token: 0x17005C7C RID: 23676
		// (get) Token: 0x0601B51A RID: 111898 RVA: 0x003F907B File Offset: 0x003F727B
		// (set) Token: 0x0601B51B RID: 111899 RVA: 0x003F9083 File Offset: 0x003F7283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Passed
		{
			get
			{
				return this.passed_;
			}
			set
			{
				this.passed_ = value;
			}
		}

		// Token: 0x17005C7D RID: 23677
		// (get) Token: 0x0601B51C RID: 111900 RVA: 0x003F908C File Offset: 0x003F728C
		// (set) Token: 0x0601B51D RID: 111901 RVA: 0x003F9094 File Offset: 0x003F7294
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

		// Token: 0x17005C7E RID: 23678
		// (get) Token: 0x0601B51E RID: 111902 RVA: 0x003F909D File Offset: 0x003F729D
		// (set) Token: 0x0601B51F RID: 111903 RVA: 0x003F90A5 File Offset: 0x003F72A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxScore
		{
			get
			{
				return this.maxScore_;
			}
			set
			{
				this.maxScore_ = value;
			}
		}

		// Token: 0x17005C7F RID: 23679
		// (get) Token: 0x0601B520 RID: 111904 RVA: 0x003F90AE File Offset: 0x003F72AE
		// (set) Token: 0x0601B521 RID: 111905 RVA: 0x003F90B6 File Offset: 0x003F72B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PassTime
		{
			get
			{
				return this.passTime_;
			}
			set
			{
				this.passTime_ = value;
			}
		}

		// Token: 0x0601B522 RID: 111906 RVA: 0x003F90BF File Offset: 0x003F72BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceInstanceInfo);
		}

		// Token: 0x0601B523 RID: 111907 RVA: 0x003F90D0 File Offset: 0x003F72D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceInstanceInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Score == other.Score && this.Rewarded == other.Rewarded && this.Passed == other.Passed && this.UnlockTime == other.UnlockTime && this.MaxScore == other.MaxScore && this.PassTime == other.PassTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B524 RID: 111908 RVA: 0x003F916C File Offset: 0x003F736C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.Rewarded)
			{
				num ^= this.Rewarded.GetHashCode();
			}
			if (this.Passed)
			{
				num ^= this.Passed.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this.MaxScore != 0)
			{
				num ^= this.MaxScore.GetHashCode();
			}
			if (this.PassTime != 0)
			{
				num ^= this.PassTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B525 RID: 111909 RVA: 0x003F9241 File Offset: 0x003F7441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B526 RID: 111910 RVA: 0x003F924E File Offset: 0x003F744E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B527 RID: 111911 RVA: 0x003F9258 File Offset: 0x003F7458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Score);
			}
			if (this.Rewarded)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Rewarded);
			}
			if (this.Passed)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Passed);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.UnlockTime);
			}
			if (this.MaxScore != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MaxScore);
			}
			if (this.PassTime != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PassTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B528 RID: 111912 RVA: 0x003F933C File Offset: 0x003F753C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.Rewarded)
			{
				num += 2;
			}
			if (this.Passed)
			{
				num += 2;
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this.MaxScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxScore);
			}
			if (this.PassTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PassTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B529 RID: 111913 RVA: 0x003F93F4 File Offset: 0x003F75F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceInstanceInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.Rewarded)
			{
				this.Rewarded = other.Rewarded;
			}
			if (other.Passed)
			{
				this.Passed = other.Passed;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			if (other.MaxScore != 0)
			{
				this.MaxScore = other.MaxScore;
			}
			if (other.PassTime != 0)
			{
				this.PassTime = other.PassTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B52A RID: 111914 RVA: 0x003F94A8 File Offset: 0x003F76A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B52B RID: 111915 RVA: 0x003F94B4 File Offset: 0x003F76B4
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
						this.Score = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.Rewarded = input.ReadBool();
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.Passed = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.UnlockTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.MaxScore = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.PassTime = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009F21 RID: 40737
		private static readonly MessageParser<TowerDefenceInstanceInfo> _parser = new MessageParser<TowerDefenceInstanceInfo>(() => new TowerDefenceInstanceInfo());

		// Token: 0x04009F22 RID: 40738
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F23 RID: 40739
		public const int IdFieldNumber = 1;

		// Token: 0x04009F24 RID: 40740
		private int id_;

		// Token: 0x04009F25 RID: 40741
		public const int ScoreFieldNumber = 2;

		// Token: 0x04009F26 RID: 40742
		private int score_;

		// Token: 0x04009F27 RID: 40743
		public const int RewardedFieldNumber = 3;

		// Token: 0x04009F28 RID: 40744
		private bool rewarded_;

		// Token: 0x04009F29 RID: 40745
		public const int PassedFieldNumber = 4;

		// Token: 0x04009F2A RID: 40746
		private bool passed_;

		// Token: 0x04009F2B RID: 40747
		public const int UnlockTimeFieldNumber = 5;

		// Token: 0x04009F2C RID: 40748
		private long unlockTime_;

		// Token: 0x04009F2D RID: 40749
		public const int MaxScoreFieldNumber = 6;

		// Token: 0x04009F2E RID: 40750
		private int maxScore_;

		// Token: 0x04009F2F RID: 40751
		public const int PassTimeFieldNumber = 7;

		// Token: 0x04009F30 RID: 40752
		private int passTime_;
	}
}
