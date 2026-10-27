using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001198 RID: 4504
	[NetMessage(EMessageId.ScheduleRewardRequest)]
	public sealed class ScheduleRewardRequest : IMessage<ScheduleRewardRequest>, IMessage, IEquatable<ScheduleRewardRequest>, IDeepCloneable<ScheduleRewardRequest>, IBufferMessage
	{
		// Token: 0x0601800B RID: 98315 RVA: 0x0037C575 File Offset: 0x0037A775
		[NullableContext(1)]
		public static ScheduleRewardRequest Create()
		{
			return new ScheduleRewardRequest();
		}

		// Token: 0x170050A9 RID: 20649
		// (get) Token: 0x0601800C RID: 98316 RVA: 0x0037C57C File Offset: 0x0037A77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050AA RID: 20650
		// (get) Token: 0x0601800D RID: 98317 RVA: 0x0037C57F File Offset: 0x0037A77F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScheduleRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601800E RID: 98318 RVA: 0x0037C586 File Offset: 0x0037A786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleRewardRequest()
		{
		}

		// Token: 0x0601800F RID: 98319 RVA: 0x0037C58E File Offset: 0x0037A78E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleRewardRequest(ScheduleRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.rewardId_ = other.rewardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018010 RID: 98320 RVA: 0x0037C5BF File Offset: 0x0037A7BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleRewardRequest Clone()
		{
			return new ScheduleRewardRequest(this);
		}

		// Token: 0x170050AB RID: 20651
		// (get) Token: 0x06018011 RID: 98321 RVA: 0x0037C5C7 File Offset: 0x0037A7C7
		// (set) Token: 0x06018012 RID: 98322 RVA: 0x0037C5CF File Offset: 0x0037A7CF
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

		// Token: 0x170050AC RID: 20652
		// (get) Token: 0x06018013 RID: 98323 RVA: 0x0037C5D8 File Offset: 0x0037A7D8
		// (set) Token: 0x06018014 RID: 98324 RVA: 0x0037C5E0 File Offset: 0x0037A7E0
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

		// Token: 0x06018015 RID: 98325 RVA: 0x0037C5E9 File Offset: 0x0037A7E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScheduleRewardRequest);
		}

		// Token: 0x06018016 RID: 98326 RVA: 0x0037C5F7 File Offset: 0x0037A7F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScheduleRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.RewardId == other.RewardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018017 RID: 98327 RVA: 0x0037C638 File Offset: 0x0037A838
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

		// Token: 0x06018018 RID: 98328 RVA: 0x0037C690 File Offset: 0x0037A890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018019 RID: 98329 RVA: 0x0037C69D File Offset: 0x0037A89D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601801A RID: 98330 RVA: 0x0037C6A8 File Offset: 0x0037A8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this.RewardId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RewardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601801B RID: 98331 RVA: 0x0037C704 File Offset: 0x0037A904
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

		// Token: 0x0601801C RID: 98332 RVA: 0x0037C75C File Offset: 0x0037A95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScheduleRewardRequest other)
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

		// Token: 0x0601801D RID: 98333 RVA: 0x0037C7AC File Offset: 0x0037A9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601801E RID: 98334 RVA: 0x0037C7B8 File Offset: 0x0037A9B8
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
				if (num != 56U)
				{
					if (num != 96U)
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

		// Token: 0x04008E26 RID: 36390
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E27 RID: 36391
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x04008E28 RID: 36392
		private int activityId_;

		// Token: 0x04008E29 RID: 36393
		public const int RewardIdFieldNumber = 12;

		// Token: 0x04008E2A RID: 36394
		private int rewardId_;
	}
}
