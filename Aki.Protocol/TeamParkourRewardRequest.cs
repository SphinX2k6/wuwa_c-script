using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200132E RID: 4910
	[NetMessage(EMessageId.TeamParkourRewardRequest)]
	public sealed class TeamParkourRewardRequest : IMessage<TeamParkourRewardRequest>, IMessage, IEquatable<TeamParkourRewardRequest>, IDeepCloneable<TeamParkourRewardRequest>, IBufferMessage
	{
		// Token: 0x0601A16D RID: 106861 RVA: 0x003CA2DA File Offset: 0x003C84DA
		[NullableContext(1)]
		public static TeamParkourRewardRequest Create()
		{
			return new TeamParkourRewardRequest();
		}

		// Token: 0x170057FE RID: 22526
		// (get) Token: 0x0601A16E RID: 106862 RVA: 0x003CA2E1 File Offset: 0x003C84E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057FF RID: 22527
		// (get) Token: 0x0601A16F RID: 106863 RVA: 0x003CA2E4 File Offset: 0x003C84E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamParkourRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601A170 RID: 106864 RVA: 0x003CA2EB File Offset: 0x003C84EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourRewardRequest()
		{
		}

		// Token: 0x0601A171 RID: 106865 RVA: 0x003CA2F3 File Offset: 0x003C84F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourRewardRequest(TeamParkourRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.rewardId_ = other.rewardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A172 RID: 106866 RVA: 0x003CA324 File Offset: 0x003C8524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourRewardRequest Clone()
		{
			return new TeamParkourRewardRequest(this);
		}

		// Token: 0x17005800 RID: 22528
		// (get) Token: 0x0601A173 RID: 106867 RVA: 0x003CA32C File Offset: 0x003C852C
		// (set) Token: 0x0601A174 RID: 106868 RVA: 0x003CA334 File Offset: 0x003C8534
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

		// Token: 0x17005801 RID: 22529
		// (get) Token: 0x0601A175 RID: 106869 RVA: 0x003CA33D File Offset: 0x003C853D
		// (set) Token: 0x0601A176 RID: 106870 RVA: 0x003CA345 File Offset: 0x003C8545
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

		// Token: 0x0601A177 RID: 106871 RVA: 0x003CA34E File Offset: 0x003C854E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamParkourRewardRequest);
		}

		// Token: 0x0601A178 RID: 106872 RVA: 0x003CA35C File Offset: 0x003C855C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamParkourRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.RewardId == other.RewardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A179 RID: 106873 RVA: 0x003CA39C File Offset: 0x003C859C
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A17A RID: 106874 RVA: 0x003CA3F4 File Offset: 0x003C85F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A17B RID: 106875 RVA: 0x003CA401 File Offset: 0x003C8601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A17C RID: 106876 RVA: 0x003CA40C File Offset: 0x003C860C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.RewardId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.RewardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A17D RID: 106877 RVA: 0x003CA468 File Offset: 0x003C8668
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A17E RID: 106878 RVA: 0x003CA4C0 File Offset: 0x003C86C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamParkourRewardRequest other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A17F RID: 106879 RVA: 0x003CA510 File Offset: 0x003C8710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A180 RID: 106880 RVA: 0x003CA51C File Offset: 0x003C871C
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
					if (num != 88U)
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
		}

		// Token: 0x04009852 RID: 38994
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009853 RID: 38995
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04009854 RID: 38996
		private int activityId_;

		// Token: 0x04009855 RID: 38997
		public const int RewardIdFieldNumber = 11;

		// Token: 0x04009856 RID: 38998
		private int rewardId_;
	}
}
