using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200139B RID: 5019
	[NetMessage(EMessageId.TeamParkourRewardRequest)]
	public sealed class TeamParkourRewardRequest : IMessage<TeamParkourRewardRequest>, IMessage, IEquatable<TeamParkourRewardRequest>, IDeepCloneable<TeamParkourRewardRequest>, IBufferMessage
	{
		// Token: 0x0601AB7D RID: 109437 RVA: 0x003E4596 File Offset: 0x003E2796
		[NullableContext(1)]
		public static TeamParkourRewardRequest Create()
		{
			return new TeamParkourRewardRequest();
		}

		// Token: 0x17005A78 RID: 23160
		// (get) Token: 0x0601AB7E RID: 109438 RVA: 0x003E459D File Offset: 0x003E279D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A79 RID: 23161
		// (get) Token: 0x0601AB7F RID: 109439 RVA: 0x003E45A0 File Offset: 0x003E27A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamParkourRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601AB80 RID: 109440 RVA: 0x003E45A7 File Offset: 0x003E27A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourRewardRequest()
		{
		}

		// Token: 0x0601AB81 RID: 109441 RVA: 0x003E45AF File Offset: 0x003E27AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourRewardRequest(TeamParkourRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.rewardId_ = other.rewardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AB82 RID: 109442 RVA: 0x003E45E0 File Offset: 0x003E27E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamParkourRewardRequest Clone()
		{
			return new TeamParkourRewardRequest(this);
		}

		// Token: 0x17005A7A RID: 23162
		// (get) Token: 0x0601AB83 RID: 109443 RVA: 0x003E45E8 File Offset: 0x003E27E8
		// (set) Token: 0x0601AB84 RID: 109444 RVA: 0x003E45F0 File Offset: 0x003E27F0
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

		// Token: 0x17005A7B RID: 23163
		// (get) Token: 0x0601AB85 RID: 109445 RVA: 0x003E45F9 File Offset: 0x003E27F9
		// (set) Token: 0x0601AB86 RID: 109446 RVA: 0x003E4601 File Offset: 0x003E2801
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

		// Token: 0x0601AB87 RID: 109447 RVA: 0x003E460A File Offset: 0x003E280A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamParkourRewardRequest);
		}

		// Token: 0x0601AB88 RID: 109448 RVA: 0x003E4618 File Offset: 0x003E2818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamParkourRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.RewardId == other.RewardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AB89 RID: 109449 RVA: 0x003E4658 File Offset: 0x003E2858
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

		// Token: 0x0601AB8A RID: 109450 RVA: 0x003E46B0 File Offset: 0x003E28B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AB8B RID: 109451 RVA: 0x003E46BD File Offset: 0x003E28BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AB8C RID: 109452 RVA: 0x003E46C8 File Offset: 0x003E28C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RewardId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AB8D RID: 109453 RVA: 0x003E4724 File Offset: 0x003E2924
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

		// Token: 0x0601AB8E RID: 109454 RVA: 0x003E477C File Offset: 0x003E297C
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

		// Token: 0x0601AB8F RID: 109455 RVA: 0x003E47CC File Offset: 0x003E29CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AB90 RID: 109456 RVA: 0x003E47D8 File Offset: 0x003E29D8
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
				if (num != 72U)
				{
					if (num != 112U)
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
		}

		// Token: 0x04009C74 RID: 40052
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C75 RID: 40053
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x04009C76 RID: 40054
		private int activityId_;

		// Token: 0x04009C77 RID: 40055
		public const int RewardIdFieldNumber = 9;

		// Token: 0x04009C78 RID: 40056
		private int rewardId_;
	}
}
