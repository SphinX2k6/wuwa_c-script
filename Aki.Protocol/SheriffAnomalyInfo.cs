using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011E2 RID: 4578
	public sealed class SheriffAnomalyInfo : IMessage<SheriffAnomalyInfo>, IMessage, IEquatable<SheriffAnomalyInfo>, IDeepCloneable<SheriffAnomalyInfo>, IBufferMessage
	{
		// Token: 0x06018670 RID: 99952 RVA: 0x0038C447 File Offset: 0x0038A647
		[NullableContext(1)]
		public static SheriffAnomalyInfo Create()
		{
			return new SheriffAnomalyInfo();
		}

		// Token: 0x17005223 RID: 21027
		// (get) Token: 0x06018671 RID: 99953 RVA: 0x0038C44E File Offset: 0x0038A64E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SheriffAnomalyInfo> Parser
		{
			get
			{
				return SheriffAnomalyInfo._parser;
			}
		}

		// Token: 0x17005224 RID: 21028
		// (get) Token: 0x06018672 RID: 99954 RVA: 0x0038C455 File Offset: 0x0038A655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005225 RID: 21029
		// (get) Token: 0x06018673 RID: 99955 RVA: 0x0038C458 File Offset: 0x0038A658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SheriffAnomalyInfo.Descriptor;
			}
		}

		// Token: 0x06018674 RID: 99956 RVA: 0x0038C45F File Offset: 0x0038A65F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffAnomalyInfo()
		{
		}

		// Token: 0x06018675 RID: 99957 RVA: 0x0038C480 File Offset: 0x0038A680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffAnomalyInfo(SheriffAnomalyInfo other) : this()
		{
			this.anomalyId_ = other.anomalyId_;
			this.clueIds_ = other.clueIds_.Clone();
			this.progressIds_ = other.progressIds_.Clone();
			this.endingId_ = other.endingId_;
			this.completeTime_ = other.completeTime_;
			this.isActivated_ = other.isActivated_;
			this.isUnlocked_ = other.isUnlocked_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018676 RID: 99958 RVA: 0x0038C502 File Offset: 0x0038A702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffAnomalyInfo Clone()
		{
			return new SheriffAnomalyInfo(this);
		}

		// Token: 0x17005226 RID: 21030
		// (get) Token: 0x06018677 RID: 99959 RVA: 0x0038C50A File Offset: 0x0038A70A
		// (set) Token: 0x06018678 RID: 99960 RVA: 0x0038C512 File Offset: 0x0038A712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AnomalyId
		{
			get
			{
				return this.anomalyId_;
			}
			set
			{
				this.anomalyId_ = value;
			}
		}

		// Token: 0x17005227 RID: 21031
		// (get) Token: 0x06018679 RID: 99961 RVA: 0x0038C51B File Offset: 0x0038A71B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ClueIds
		{
			get
			{
				return this.clueIds_;
			}
		}

		// Token: 0x17005228 RID: 21032
		// (get) Token: 0x0601867A RID: 99962 RVA: 0x0038C523 File Offset: 0x0038A723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ProgressIds
		{
			get
			{
				return this.progressIds_;
			}
		}

		// Token: 0x17005229 RID: 21033
		// (get) Token: 0x0601867B RID: 99963 RVA: 0x0038C52B File Offset: 0x0038A72B
		// (set) Token: 0x0601867C RID: 99964 RVA: 0x0038C533 File Offset: 0x0038A733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EndingId
		{
			get
			{
				return this.endingId_;
			}
			set
			{
				this.endingId_ = value;
			}
		}

		// Token: 0x1700522A RID: 21034
		// (get) Token: 0x0601867D RID: 99965 RVA: 0x0038C53C File Offset: 0x0038A73C
		// (set) Token: 0x0601867E RID: 99966 RVA: 0x0038C544 File Offset: 0x0038A744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CompleteTime
		{
			get
			{
				return this.completeTime_;
			}
			set
			{
				this.completeTime_ = value;
			}
		}

		// Token: 0x1700522B RID: 21035
		// (get) Token: 0x0601867F RID: 99967 RVA: 0x0038C54D File Offset: 0x0038A74D
		// (set) Token: 0x06018680 RID: 99968 RVA: 0x0038C555 File Offset: 0x0038A755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsActivated
		{
			get
			{
				return this.isActivated_;
			}
			set
			{
				this.isActivated_ = value;
			}
		}

		// Token: 0x1700522C RID: 21036
		// (get) Token: 0x06018681 RID: 99969 RVA: 0x0038C55E File Offset: 0x0038A75E
		// (set) Token: 0x06018682 RID: 99970 RVA: 0x0038C566 File Offset: 0x0038A766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlocked
		{
			get
			{
				return this.isUnlocked_;
			}
			set
			{
				this.isUnlocked_ = value;
			}
		}

		// Token: 0x06018683 RID: 99971 RVA: 0x0038C56F File Offset: 0x0038A76F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SheriffAnomalyInfo);
		}

		// Token: 0x06018684 RID: 99972 RVA: 0x0038C580 File Offset: 0x0038A780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SheriffAnomalyInfo other)
		{
			return other != null && (other == this || (this.AnomalyId == other.AnomalyId && this.clueIds_.Equals(other.clueIds_) && this.progressIds_.Equals(other.progressIds_) && this.EndingId == other.EndingId && this.CompleteTime == other.CompleteTime && this.IsActivated == other.IsActivated && this.IsUnlocked == other.IsUnlocked && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018685 RID: 99973 RVA: 0x0038C624 File Offset: 0x0038A824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AnomalyId != 0)
			{
				num ^= this.AnomalyId.GetHashCode();
			}
			num ^= this.clueIds_.GetHashCode();
			num ^= this.progressIds_.GetHashCode();
			if (this.EndingId != 0)
			{
				num ^= this.EndingId.GetHashCode();
			}
			if (this.CompleteTime != 0L)
			{
				num ^= this.CompleteTime.GetHashCode();
			}
			if (this.IsActivated)
			{
				num ^= this.IsActivated.GetHashCode();
			}
			if (this.IsUnlocked)
			{
				num ^= this.IsUnlocked.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018686 RID: 99974 RVA: 0x0038C6E3 File Offset: 0x0038A8E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018687 RID: 99975 RVA: 0x0038C6F0 File Offset: 0x0038A8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018688 RID: 99976 RVA: 0x0038C6FC File Offset: 0x0038A8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AnomalyId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AnomalyId);
			}
			this.clueIds_.WriteTo(ref output, SheriffAnomalyInfo._repeated_clueIds_codec);
			this.progressIds_.WriteTo(ref output, SheriffAnomalyInfo._repeated_progressIds_codec);
			if (this.EndingId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.EndingId);
			}
			if (this.CompleteTime != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.CompleteTime);
			}
			if (this.IsActivated)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsActivated);
			}
			if (this.IsUnlocked)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsUnlocked);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018689 RID: 99977 RVA: 0x0038C7CC File Offset: 0x0038A9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AnomalyId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AnomalyId);
			}
			num += this.clueIds_.CalculateSize(SheriffAnomalyInfo._repeated_clueIds_codec);
			num += this.progressIds_.CalculateSize(SheriffAnomalyInfo._repeated_progressIds_codec);
			if (this.EndingId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EndingId);
			}
			if (this.CompleteTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CompleteTime);
			}
			if (this.IsActivated)
			{
				num += 2;
			}
			if (this.IsUnlocked)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601868A RID: 99978 RVA: 0x0038C878 File Offset: 0x0038AA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SheriffAnomalyInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AnomalyId != 0)
			{
				this.AnomalyId = other.AnomalyId;
			}
			this.clueIds_.Add(other.clueIds_);
			this.progressIds_.Add(other.progressIds_);
			if (other.EndingId != 0)
			{
				this.EndingId = other.EndingId;
			}
			if (other.CompleteTime != 0L)
			{
				this.CompleteTime = other.CompleteTime;
			}
			if (other.IsActivated)
			{
				this.IsActivated = other.IsActivated;
			}
			if (other.IsUnlocked)
			{
				this.IsUnlocked = other.IsUnlocked;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601868B RID: 99979 RVA: 0x0038C926 File Offset: 0x0038AB26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601868C RID: 99980 RVA: 0x0038C930 File Offset: 0x0038AB30
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
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.AnomalyId = input.ReadInt32();
							continue;
						}
						if (num != 16U)
						{
							goto IL_4D;
						}
					}
					else if (num != 18U)
					{
						if (num != 24U)
						{
							goto IL_4D;
						}
						goto IL_82;
					}
					this.clueIds_.AddEntriesFrom(ref input, SheriffAnomalyInfo._repeated_clueIds_codec);
					continue;
				}
				if (num <= 32U)
				{
					if (num == 26U)
					{
						goto IL_82;
					}
					if (num == 32U)
					{
						this.EndingId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.CompleteTime = input.ReadInt64();
						continue;
					}
					if (num == 48U)
					{
						this.IsActivated = input.ReadBool();
						continue;
					}
					if (num == 56U)
					{
						this.IsUnlocked = input.ReadBool();
						continue;
					}
				}
				IL_4D:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_82:
				this.progressIds_.AddEntriesFrom(ref input, SheriffAnomalyInfo._repeated_progressIds_codec);
			}
		}

		// Token: 0x04009043 RID: 36931
		private static readonly MessageParser<SheriffAnomalyInfo> _parser = new MessageParser<SheriffAnomalyInfo>(() => new SheriffAnomalyInfo());

		// Token: 0x04009044 RID: 36932
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009045 RID: 36933
		public const int AnomalyIdFieldNumber = 1;

		// Token: 0x04009046 RID: 36934
		private int anomalyId_;

		// Token: 0x04009047 RID: 36935
		public const int ClueIdsFieldNumber = 2;

		// Token: 0x04009048 RID: 36936
		private static readonly FieldCodec<int> _repeated_clueIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04009049 RID: 36937
		private readonly RepeatedField<int> clueIds_ = new RepeatedField<int>();

		// Token: 0x0400904A RID: 36938
		public const int ProgressIdsFieldNumber = 3;

		// Token: 0x0400904B RID: 36939
		private static readonly FieldCodec<int> _repeated_progressIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400904C RID: 36940
		private readonly RepeatedField<int> progressIds_ = new RepeatedField<int>();

		// Token: 0x0400904D RID: 36941
		public const int EndingIdFieldNumber = 4;

		// Token: 0x0400904E RID: 36942
		private int endingId_;

		// Token: 0x0400904F RID: 36943
		public const int CompleteTimeFieldNumber = 5;

		// Token: 0x04009050 RID: 36944
		private long completeTime_;

		// Token: 0x04009051 RID: 36945
		public const int IsActivatedFieldNumber = 6;

		// Token: 0x04009052 RID: 36946
		private bool isActivated_;

		// Token: 0x04009053 RID: 36947
		public const int IsUnlockedFieldNumber = 7;

		// Token: 0x04009054 RID: 36948
		private bool isUnlocked_;
	}
}
