using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005DB RID: 1499
	[NetMessage(EMessageId.FloroRanchRewardMilestoneRequest)]
	public sealed class FloroRanchRewardMilestoneRequest : IMessage<FloroRanchRewardMilestoneRequest>, IMessage, IEquatable<FloroRanchRewardMilestoneRequest>, IDeepCloneable<FloroRanchRewardMilestoneRequest>, IBufferMessage
	{
		// Token: 0x06008AB3 RID: 35507 RVA: 0x0014F5BF File Offset: 0x0014D7BF
		[NullableContext(1)]
		public static FloroRanchRewardMilestoneRequest Create()
		{
			return new FloroRanchRewardMilestoneRequest();
		}

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x06008AB4 RID: 35508 RVA: 0x0014F5C6 File Offset: 0x0014D7C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x06008AB5 RID: 35509 RVA: 0x0014F5C9 File Offset: 0x0014D7C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchRewardMilestoneRequest.Descriptor;
			}
		}

		// Token: 0x06008AB6 RID: 35510 RVA: 0x0014F5D0 File Offset: 0x0014D7D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardMilestoneRequest()
		{
		}

		// Token: 0x06008AB7 RID: 35511 RVA: 0x0014F5E3 File Offset: 0x0014D7E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardMilestoneRequest(FloroRanchRewardMilestoneRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.milestoneIds_ = other.milestoneIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008AB8 RID: 35512 RVA: 0x0014F619 File Offset: 0x0014D819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardMilestoneRequest Clone()
		{
			return new FloroRanchRewardMilestoneRequest(this);
		}

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x06008AB9 RID: 35513 RVA: 0x0014F621 File Offset: 0x0014D821
		// (set) Token: 0x06008ABA RID: 35514 RVA: 0x0014F629 File Offset: 0x0014D829
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

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x06008ABB RID: 35515 RVA: 0x0014F632 File Offset: 0x0014D832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MilestoneIds
		{
			get
			{
				return this.milestoneIds_;
			}
		}

		// Token: 0x06008ABC RID: 35516 RVA: 0x0014F63A File Offset: 0x0014D83A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchRewardMilestoneRequest);
		}

		// Token: 0x06008ABD RID: 35517 RVA: 0x0014F648 File Offset: 0x0014D848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchRewardMilestoneRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.milestoneIds_.Equals(other.milestoneIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008ABE RID: 35518 RVA: 0x0014F698 File Offset: 0x0014D898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.milestoneIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008ABF RID: 35519 RVA: 0x0014F6E5 File Offset: 0x0014D8E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008AC0 RID: 35520 RVA: 0x0014F6F2 File Offset: 0x0014D8F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008AC1 RID: 35521 RVA: 0x0014F6FC File Offset: 0x0014D8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.milestoneIds_.WriteTo(ref output, FloroRanchRewardMilestoneRequest._repeated_milestoneIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008AC2 RID: 35522 RVA: 0x0014F74C File Offset: 0x0014D94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.milestoneIds_.CalculateSize(FloroRanchRewardMilestoneRequest._repeated_milestoneIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008AC3 RID: 35523 RVA: 0x0014F7A0 File Offset: 0x0014D9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchRewardMilestoneRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.milestoneIds_.Add(other.milestoneIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008AC4 RID: 35524 RVA: 0x0014F7ED File Offset: 0x0014D9ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008AC5 RID: 35525 RVA: 0x0014F7F8 File Offset: 0x0014D9F8
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
				if (num != 48U && num != 50U)
				{
					if (num != 88U)
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
					this.milestoneIds_.AddEntriesFrom(ref input, FloroRanchRewardMilestoneRequest._repeated_milestoneIds_codec);
				}
			}
		}

		// Token: 0x04004417 RID: 17431
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004418 RID: 17432
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04004419 RID: 17433
		private int activityId_;

		// Token: 0x0400441A RID: 17434
		public const int MilestoneIdsFieldNumber = 6;

		// Token: 0x0400441B RID: 17435
		private static readonly FieldCodec<int> _repeated_milestoneIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x0400441C RID: 17436
		private readonly RepeatedField<int> milestoneIds_ = new RepeatedField<int>();
	}
}
