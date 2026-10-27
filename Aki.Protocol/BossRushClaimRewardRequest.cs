using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001D4 RID: 468
	[NetMessage(EMessageId.BossRushClaimRewardRequest)]
	public sealed class BossRushClaimRewardRequest : IMessage<BossRushClaimRewardRequest>, IMessage, IEquatable<BossRushClaimRewardRequest>, IDeepCloneable<BossRushClaimRewardRequest>, IBufferMessage
	{
		// Token: 0x0600351E RID: 13598 RVA: 0x0008594C File Offset: 0x00083B4C
		[NullableContext(1)]
		public static BossRushClaimRewardRequest Create()
		{
			return new BossRushClaimRewardRequest();
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x0600351F RID: 13599 RVA: 0x00085953 File Offset: 0x00083B53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06003520 RID: 13600 RVA: 0x00085956 File Offset: 0x00083B56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushClaimRewardRequest.Descriptor;
			}
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x0008595D File Offset: 0x00083B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushClaimRewardRequest()
		{
		}

		// Token: 0x06003522 RID: 13602 RVA: 0x00085965 File Offset: 0x00083B65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushClaimRewardRequest(BossRushClaimRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.rewardId_ = other.rewardId_;
			this.rewardType_ = other.rewardType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003523 RID: 13603 RVA: 0x000859A2 File Offset: 0x00083BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushClaimRewardRequest Clone()
		{
			return new BossRushClaimRewardRequest(this);
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06003524 RID: 13604 RVA: 0x000859AA File Offset: 0x00083BAA
		// (set) Token: 0x06003525 RID: 13605 RVA: 0x000859B2 File Offset: 0x00083BB2
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

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06003526 RID: 13606 RVA: 0x000859BB File Offset: 0x00083BBB
		// (set) Token: 0x06003527 RID: 13607 RVA: 0x000859C3 File Offset: 0x00083BC3
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

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06003528 RID: 13608 RVA: 0x000859CC File Offset: 0x00083BCC
		// (set) Token: 0x06003529 RID: 13609 RVA: 0x000859D4 File Offset: 0x00083BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushRewardType RewardType
		{
			get
			{
				return this.rewardType_;
			}
			set
			{
				this.rewardType_ = value;
			}
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x000859DD File Offset: 0x00083BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushClaimRewardRequest);
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x000859EC File Offset: 0x00083BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushClaimRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.RewardId == other.RewardId && this.RewardType == other.RewardType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x00085A48 File Offset: 0x00083C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.RewardId != 0)
			{
				num ^= this.RewardId.GetHashCode();
			}
			if (this.RewardType != BossRushRewardType.Level)
			{
				num ^= this.RewardType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x00085ABF File Offset: 0x00083CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x00085ACC File Offset: 0x00083CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600352F RID: 13615 RVA: 0x00085AD8 File Offset: 0x00083CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardType != BossRushRewardType.Level)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.RewardType);
			}
			if (this.RewardId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RewardId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003530 RID: 13616 RVA: 0x00085B50 File Offset: 0x00083D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.RewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardId);
			}
			if (this.RewardType != BossRushRewardType.Level)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RewardType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003531 RID: 13617 RVA: 0x00085BC0 File Offset: 0x00083DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushClaimRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.RewardId != 0)
			{
				this.RewardId = other.RewardId;
			}
			if (other.RewardType != BossRushRewardType.Level)
			{
				this.RewardType = other.RewardType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x00085C24 File Offset: 0x00083E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x00085C30 File Offset: 0x00083E30
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
				if (num != 40U)
				{
					if (num != 72U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ActivityId = input.ReadInt32();
						}
					}
					else
					{
						this.RewardId = input.ReadInt32();
					}
				}
				else
				{
					this.RewardType = (BossRushRewardType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002A32 RID: 10802
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A33 RID: 10803
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04002A34 RID: 10804
		private int activityId_;

		// Token: 0x04002A35 RID: 10805
		public const int RewardIdFieldNumber = 9;

		// Token: 0x04002A36 RID: 10806
		private int rewardId_;

		// Token: 0x04002A37 RID: 10807
		public const int RewardTypeFieldNumber = 5;

		// Token: 0x04002A38 RID: 10808
		private BossRushRewardType rewardType_;
	}
}
