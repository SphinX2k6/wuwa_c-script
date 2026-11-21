using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001D8 RID: 472
	[NetMessage(EMessageId.BossRushClaimRewardRequest)]
	public sealed class BossRushClaimRewardRequest : IMessage<BossRushClaimRewardRequest>, IMessage, IEquatable<BossRushClaimRewardRequest>, IDeepCloneable<BossRushClaimRewardRequest>, IBufferMessage
	{
		// Token: 0x060035AB RID: 13739 RVA: 0x000870C0 File Offset: 0x000852C0
		[NullableContext(1)]
		public static BossRushClaimRewardRequest Create()
		{
			return new BossRushClaimRewardRequest();
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x060035AC RID: 13740 RVA: 0x000870C7 File Offset: 0x000852C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x060035AD RID: 13741 RVA: 0x000870CA File Offset: 0x000852CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushClaimRewardRequest.Descriptor;
			}
		}

		// Token: 0x060035AE RID: 13742 RVA: 0x000870D1 File Offset: 0x000852D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushClaimRewardRequest()
		{
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x000870D9 File Offset: 0x000852D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushClaimRewardRequest(BossRushClaimRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.rewardId_ = other.rewardId_;
			this.rewardType_ = other.rewardType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x00087116 File Offset: 0x00085316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushClaimRewardRequest Clone()
		{
			return new BossRushClaimRewardRequest(this);
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x060035B1 RID: 13745 RVA: 0x0008711E File Offset: 0x0008531E
		// (set) Token: 0x060035B2 RID: 13746 RVA: 0x00087126 File Offset: 0x00085326
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

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x060035B3 RID: 13747 RVA: 0x0008712F File Offset: 0x0008532F
		// (set) Token: 0x060035B4 RID: 13748 RVA: 0x00087137 File Offset: 0x00085337
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

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x060035B5 RID: 13749 RVA: 0x00087140 File Offset: 0x00085340
		// (set) Token: 0x060035B6 RID: 13750 RVA: 0x00087148 File Offset: 0x00085348
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

		// Token: 0x060035B7 RID: 13751 RVA: 0x00087151 File Offset: 0x00085351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushClaimRewardRequest);
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x00087160 File Offset: 0x00085360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushClaimRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.RewardId == other.RewardId && this.RewardType == other.RewardType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x000871BC File Offset: 0x000853BC
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

		// Token: 0x060035BA RID: 13754 RVA: 0x00087233 File Offset: 0x00085433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x00087240 File Offset: 0x00085440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x0008724C File Offset: 0x0008544C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardType != BossRushRewardType.Level)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.RewardType);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this.RewardId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RewardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x000872C4 File Offset: 0x000854C4
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

		// Token: 0x060035BE RID: 13758 RVA: 0x00087334 File Offset: 0x00085534
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

		// Token: 0x060035BF RID: 13759 RVA: 0x00087398 File Offset: 0x00085598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x000873A4 File Offset: 0x000855A4
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
				if (num != 24U)
				{
					if (num != 104U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RewardId = input.ReadInt32();
						}
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.RewardType = (BossRushRewardType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002AAD RID: 10925
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AAE RID: 10926
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04002AAF RID: 10927
		private int activityId_;

		// Token: 0x04002AB0 RID: 10928
		public const int RewardIdFieldNumber = 14;

		// Token: 0x04002AB1 RID: 10929
		private int rewardId_;

		// Token: 0x04002AB2 RID: 10930
		public const int RewardTypeFieldNumber = 3;

		// Token: 0x04002AB3 RID: 10931
		private BossRushRewardType rewardType_;
	}
}
