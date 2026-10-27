using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001D9 RID: 473
	[NetMessage(EMessageId.BossRushLevelInfoNotify)]
	public sealed class BossRushLevelInfoNotify : IMessage<BossRushLevelInfoNotify>, IMessage, IEquatable<BossRushLevelInfoNotify>, IDeepCloneable<BossRushLevelInfoNotify>, IBufferMessage
	{
		// Token: 0x0600358D RID: 13709 RVA: 0x00086B68 File Offset: 0x00084D68
		[NullableContext(1)]
		public static BossRushLevelInfoNotify Create()
		{
			return new BossRushLevelInfoNotify();
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x0600358E RID: 13710 RVA: 0x00086B6F File Offset: 0x00084D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x0600358F RID: 13711 RVA: 0x00086B72 File Offset: 0x00084D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushLevelInfoNotify.Descriptor;
			}
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x00086B79 File Offset: 0x00084D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelInfoNotify()
		{
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x00086BA4 File Offset: 0x00084DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelInfoNotify(BossRushLevelInfoNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.bossRushLevelInfo_ = other.bossRushLevelInfo_.Clone();
			this.bossRushScoreScoreRewardInfo_ = other.bossRushScoreScoreRewardInfo_.Clone();
			this.unlockedBuffIndices_ = other.unlockedBuffIndices_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x00086C07 File Offset: 0x00084E07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelInfoNotify Clone()
		{
			return new BossRushLevelInfoNotify(this);
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06003593 RID: 13715 RVA: 0x00086C0F File Offset: 0x00084E0F
		// (set) Token: 0x06003594 RID: 13716 RVA: 0x00086C17 File Offset: 0x00084E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06003595 RID: 13717 RVA: 0x00086C20 File Offset: 0x00084E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BossRushLevelData> BossRushLevelInfo
		{
			get
			{
				return this.bossRushLevelInfo_;
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06003596 RID: 13718 RVA: 0x00086C28 File Offset: 0x00084E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BossRushScoreRewardData> BossRushScoreScoreRewardInfo
		{
			get
			{
				return this.bossRushScoreScoreRewardInfo_;
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06003597 RID: 13719 RVA: 0x00086C30 File Offset: 0x00084E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedBuffIndices
		{
			get
			{
				return this.unlockedBuffIndices_;
			}
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x00086C38 File Offset: 0x00084E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushLevelInfoNotify);
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x00086C48 File Offset: 0x00084E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushLevelInfoNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.bossRushLevelInfo_.Equals(other.bossRushLevelInfo_) && this.bossRushScoreScoreRewardInfo_.Equals(other.bossRushScoreScoreRewardInfo_) && this.unlockedBuffIndices_.Equals(other.unlockedBuffIndices_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x00086CC0 File Offset: 0x00084EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.bossRushLevelInfo_.GetHashCode();
			num ^= this.bossRushScoreScoreRewardInfo_.GetHashCode();
			num ^= this.unlockedBuffIndices_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x00086D29 File Offset: 0x00084F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x00086D36 File Offset: 0x00084F36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600359D RID: 13725 RVA: 0x00086D40 File Offset: 0x00084F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bossRushLevelInfo_.WriteTo(ref output, BossRushLevelInfoNotify._repeated_bossRushLevelInfo_codec);
			this.unlockedBuffIndices_.WriteTo(ref output, BossRushLevelInfoNotify._repeated_unlockedBuffIndices_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			this.bossRushScoreScoreRewardInfo_.WriteTo(ref output, BossRushLevelInfoNotify._repeated_bossRushScoreScoreRewardInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600359E RID: 13726 RVA: 0x00086DB0 File Offset: 0x00084FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.bossRushLevelInfo_.CalculateSize(BossRushLevelInfoNotify._repeated_bossRushLevelInfo_codec);
			num += this.bossRushScoreScoreRewardInfo_.CalculateSize(BossRushLevelInfoNotify._repeated_bossRushScoreScoreRewardInfo_codec);
			num += this.unlockedBuffIndices_.CalculateSize(BossRushLevelInfoNotify._repeated_unlockedBuffIndices_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600359F RID: 13727 RVA: 0x00086E28 File Offset: 0x00085028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushLevelInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.bossRushLevelInfo_.Add(other.bossRushLevelInfo_);
			this.bossRushScoreScoreRewardInfo_.Add(other.bossRushScoreScoreRewardInfo_);
			this.unlockedBuffIndices_.Add(other.unlockedBuffIndices_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060035A0 RID: 13728 RVA: 0x00086E97 File Offset: 0x00085097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060035A1 RID: 13729 RVA: 0x00086EA0 File Offset: 0x000850A0
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
					if (num == 18U)
					{
						this.bossRushLevelInfo_.AddEntriesFrom(ref input, BossRushLevelInfoNotify._repeated_bossRushLevelInfo_codec);
						continue;
					}
					if (num == 56U)
					{
						goto IL_53;
					}
				}
				else
				{
					if (num == 58U)
					{
						goto IL_53;
					}
					if (num == 104U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						this.bossRushScoreScoreRewardInfo_.AddEntriesFrom(ref input, BossRushLevelInfoNotify._repeated_bossRushScoreScoreRewardInfo_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_53:
				this.unlockedBuffIndices_.AddEntriesFrom(ref input, BossRushLevelInfoNotify._repeated_unlockedBuffIndices_codec);
			}
		}

		// Token: 0x04002A60 RID: 10848
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A61 RID: 10849
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04002A62 RID: 10850
		private int activityId_;

		// Token: 0x04002A63 RID: 10851
		public const int BossRushLevelInfoFieldNumber = 2;

		// Token: 0x04002A64 RID: 10852
		private static readonly FieldCodec<BossRushLevelData> _repeated_bossRushLevelInfo_codec = FieldCodec.ForMessage<BossRushLevelData>(18U, BossRushLevelData.Parser);

		// Token: 0x04002A65 RID: 10853
		private readonly RepeatedField<BossRushLevelData> bossRushLevelInfo_ = new RepeatedField<BossRushLevelData>();

		// Token: 0x04002A66 RID: 10854
		public const int BossRushScoreScoreRewardInfoFieldNumber = 14;

		// Token: 0x04002A67 RID: 10855
		private static readonly FieldCodec<BossRushScoreRewardData> _repeated_bossRushScoreScoreRewardInfo_codec = FieldCodec.ForMessage<BossRushScoreRewardData>(114U, BossRushScoreRewardData.Parser);

		// Token: 0x04002A68 RID: 10856
		private readonly RepeatedField<BossRushScoreRewardData> bossRushScoreScoreRewardInfo_ = new RepeatedField<BossRushScoreRewardData>();

		// Token: 0x04002A69 RID: 10857
		public const int UnlockedBuffIndicesFieldNumber = 7;

		// Token: 0x04002A6A RID: 10858
		private static readonly FieldCodec<int> _repeated_unlockedBuffIndices_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04002A6B RID: 10859
		private readonly RepeatedField<int> unlockedBuffIndices_ = new RepeatedField<int>();
	}
}
