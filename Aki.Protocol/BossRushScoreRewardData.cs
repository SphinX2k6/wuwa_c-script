using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001E1 RID: 481
	public sealed class BossRushScoreRewardData : IMessage<BossRushScoreRewardData>, IMessage, IEquatable<BossRushScoreRewardData>, IDeepCloneable<BossRushScoreRewardData>, IBufferMessage
	{
		// Token: 0x06003674 RID: 13940 RVA: 0x00089146 File Offset: 0x00087346
		[NullableContext(1)]
		public static BossRushScoreRewardData Create()
		{
			return new BossRushScoreRewardData();
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06003675 RID: 13941 RVA: 0x0008914D File Offset: 0x0008734D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BossRushScoreRewardData> Parser
		{
			get
			{
				return BossRushScoreRewardData._parser;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06003676 RID: 13942 RVA: 0x00089154 File Offset: 0x00087354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06003677 RID: 13943 RVA: 0x00089157 File Offset: 0x00087357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushScoreRewardData.Descriptor;
			}
		}

		// Token: 0x06003678 RID: 13944 RVA: 0x0008915E File Offset: 0x0008735E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushScoreRewardData()
		{
		}

		// Token: 0x06003679 RID: 13945 RVA: 0x00089166 File Offset: 0x00087366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushScoreRewardData(BossRushScoreRewardData other) : this()
		{
			this.rewardId_ = other.rewardId_;
			this.rewardClaimStatus_ = other.rewardClaimStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600367A RID: 13946 RVA: 0x00089197 File Offset: 0x00087397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushScoreRewardData Clone()
		{
			return new BossRushScoreRewardData(this);
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x0600367B RID: 13947 RVA: 0x0008919F File Offset: 0x0008739F
		// (set) Token: 0x0600367C RID: 13948 RVA: 0x000891A7 File Offset: 0x000873A7
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

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x0600367D RID: 13949 RVA: 0x000891B0 File Offset: 0x000873B0
		// (set) Token: 0x0600367E RID: 13950 RVA: 0x000891B8 File Offset: 0x000873B8
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

		// Token: 0x0600367F RID: 13951 RVA: 0x000891C1 File Offset: 0x000873C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushScoreRewardData);
		}

		// Token: 0x06003680 RID: 13952 RVA: 0x000891CF File Offset: 0x000873CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushScoreRewardData other)
		{
			return other != null && (other == this || (this.RewardId == other.RewardId && this.RewardClaimStatus == other.RewardClaimStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003681 RID: 13953 RVA: 0x00089210 File Offset: 0x00087410
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

		// Token: 0x06003682 RID: 13954 RVA: 0x0008926E File Offset: 0x0008746E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003683 RID: 13955 RVA: 0x0008927B File Offset: 0x0008747B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003684 RID: 13956 RVA: 0x00089284 File Offset: 0x00087484
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

		// Token: 0x06003685 RID: 13957 RVA: 0x000892DC File Offset: 0x000874DC
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

		// Token: 0x06003686 RID: 13958 RVA: 0x00089334 File Offset: 0x00087534
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

		// Token: 0x06003687 RID: 13959 RVA: 0x00089384 File Offset: 0x00087584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003688 RID: 13960 RVA: 0x00089390 File Offset: 0x00087590
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

		// Token: 0x04002AFE RID: 11006
		private static readonly MessageParser<BossRushScoreRewardData> _parser = new MessageParser<BossRushScoreRewardData>(() => new BossRushScoreRewardData());

		// Token: 0x04002AFF RID: 11007
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B00 RID: 11008
		public const int RewardIdFieldNumber = 1;

		// Token: 0x04002B01 RID: 11009
		private int rewardId_;

		// Token: 0x04002B02 RID: 11010
		public const int RewardClaimStatusFieldNumber = 2;

		// Token: 0x04002B03 RID: 11011
		private BossRushRewardClaimStatus rewardClaimStatus_;
	}
}
