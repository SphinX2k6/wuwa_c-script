using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001DD RID: 477
	public sealed class BossRushScoreRewardData : IMessage<BossRushScoreRewardData>, IMessage, IEquatable<BossRushScoreRewardData>, IDeepCloneable<BossRushScoreRewardData>, IBufferMessage
	{
		// Token: 0x060035E7 RID: 13799 RVA: 0x000879D7 File Offset: 0x00085BD7
		[NullableContext(1)]
		public static BossRushScoreRewardData Create()
		{
			return new BossRushScoreRewardData();
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x060035E8 RID: 13800 RVA: 0x000879DE File Offset: 0x00085BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BossRushScoreRewardData> Parser
		{
			get
			{
				return BossRushScoreRewardData._parser;
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x060035E9 RID: 13801 RVA: 0x000879E5 File Offset: 0x00085BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x060035EA RID: 13802 RVA: 0x000879E8 File Offset: 0x00085BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushScoreRewardData.Descriptor;
			}
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x000879EF File Offset: 0x00085BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushScoreRewardData()
		{
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x000879F7 File Offset: 0x00085BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushScoreRewardData(BossRushScoreRewardData other) : this()
		{
			this.rewardId_ = other.rewardId_;
			this.rewardClaimStatus_ = other.rewardClaimStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060035ED RID: 13805 RVA: 0x00087A28 File Offset: 0x00085C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushScoreRewardData Clone()
		{
			return new BossRushScoreRewardData(this);
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x060035EE RID: 13806 RVA: 0x00087A30 File Offset: 0x00085C30
		// (set) Token: 0x060035EF RID: 13807 RVA: 0x00087A38 File Offset: 0x00085C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardId
		{
			get
			{
				return this.rewardId_;
			}
			set
			{
				this.rewardId_ = value;
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x060035F0 RID: 13808 RVA: 0x00087A41 File Offset: 0x00085C41
		// (set) Token: 0x060035F1 RID: 13809 RVA: 0x00087A49 File Offset: 0x00085C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushRewardClaimStatus RewardClaimStatus
		{
			get
			{
				return this.rewardClaimStatus_;
			}
			set
			{
				this.rewardClaimStatus_ = value;
			}
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x00087A52 File Offset: 0x00085C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushScoreRewardData);
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x00087A60 File Offset: 0x00085C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushScoreRewardData other)
		{
			return other != null && (other == this || (this.RewardId == other.RewardId && this.RewardClaimStatus == other.RewardClaimStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060035F4 RID: 13812 RVA: 0x00087AA0 File Offset: 0x00085CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RewardId != 0)
			{
				num ^= this.RewardId.GetHashCode();
			}
			if (this.RewardClaimStatus != BossRushRewardClaimStatus.Incomplete)
			{
				num ^= this.RewardClaimStatus.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060035F5 RID: 13813 RVA: 0x00087AFE File Offset: 0x00085CFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060035F6 RID: 13814 RVA: 0x00087B0B File Offset: 0x00085D0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060035F7 RID: 13815 RVA: 0x00087B14 File Offset: 0x00085D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RewardId);
			}
			if (this.RewardClaimStatus != BossRushRewardClaimStatus.Incomplete)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.RewardClaimStatus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060035F8 RID: 13816 RVA: 0x00087B6C File Offset: 0x00085D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardId);
			}
			if (this.RewardClaimStatus != BossRushRewardClaimStatus.Incomplete)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RewardClaimStatus);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060035F9 RID: 13817 RVA: 0x00087BC4 File Offset: 0x00085DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushScoreRewardData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RewardId != 0)
			{
				this.RewardId = other.RewardId;
			}
			if (other.RewardClaimStatus != BossRushRewardClaimStatus.Incomplete)
			{
				this.RewardClaimStatus = other.RewardClaimStatus;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060035FA RID: 13818 RVA: 0x00087C14 File Offset: 0x00085E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060035FB RID: 13819 RVA: 0x00087C20 File Offset: 0x00085E20
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RewardClaimStatus = (BossRushRewardClaimStatus)input.ReadEnum();
					}
				}
				else
				{
					this.RewardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002A83 RID: 10883
		private static readonly MessageParser<BossRushScoreRewardData> _parser = new MessageParser<BossRushScoreRewardData>(() => new BossRushScoreRewardData());

		// Token: 0x04002A84 RID: 10884
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A85 RID: 10885
		public const int RewardIdFieldNumber = 1;

		// Token: 0x04002A86 RID: 10886
		private int rewardId_;

		// Token: 0x04002A87 RID: 10887
		public const int RewardClaimStatusFieldNumber = 2;

		// Token: 0x04002A88 RID: 10888
		private BossRushRewardClaimStatus rewardClaimStatus_;
	}
}
