using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200037C RID: 892
	[NetMessage(EMessageId.DangoBrawlTaskRewardRequest)]
	public sealed class DangoBrawlTaskRewardRequest : IMessage<DangoBrawlTaskRewardRequest>, IMessage, IEquatable<DangoBrawlTaskRewardRequest>, IDeepCloneable<DangoBrawlTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x06005874 RID: 22644 RVA: 0x000D79F1 File Offset: 0x000D5BF1
		[NullableContext(1)]
		public static DangoBrawlTaskRewardRequest Create()
		{
			return new DangoBrawlTaskRewardRequest();
		}

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x06005875 RID: 22645 RVA: 0x000D79F8 File Offset: 0x000D5BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x06005876 RID: 22646 RVA: 0x000D79FB File Offset: 0x000D5BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x06005877 RID: 22647 RVA: 0x000D7A02 File Offset: 0x000D5C02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlTaskRewardRequest()
		{
		}

		// Token: 0x06005878 RID: 22648 RVA: 0x000D7A15 File Offset: 0x000D5C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlTaskRewardRequest(DangoBrawlTaskRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005879 RID: 22649 RVA: 0x000D7A4B File Offset: 0x000D5C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlTaskRewardRequest Clone()
		{
			return new DangoBrawlTaskRewardRequest(this);
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x0600587A RID: 22650 RVA: 0x000D7A53 File Offset: 0x000D5C53
		// (set) Token: 0x0600587B RID: 22651 RVA: 0x000D7A5B File Offset: 0x000D5C5B
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

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x0600587C RID: 22652 RVA: 0x000D7A64 File Offset: 0x000D5C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600587D RID: 22653 RVA: 0x000D7A6C File Offset: 0x000D5C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlTaskRewardRequest);
		}

		// Token: 0x0600587E RID: 22654 RVA: 0x000D7A7C File Offset: 0x000D5C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlTaskRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600587F RID: 22655 RVA: 0x000D7ACC File Offset: 0x000D5CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005880 RID: 22656 RVA: 0x000D7B19 File Offset: 0x000D5D19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005881 RID: 22657 RVA: 0x000D7B26 File Offset: 0x000D5D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005882 RID: 22658 RVA: 0x000D7B30 File Offset: 0x000D5D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, DangoBrawlTaskRewardRequest._repeated_taskIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005883 RID: 22659 RVA: 0x000D7B80 File Offset: 0x000D5D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.taskIds_.CalculateSize(DangoBrawlTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005884 RID: 22660 RVA: 0x000D7BD4 File Offset: 0x000D5DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005885 RID: 22661 RVA: 0x000D7C21 File Offset: 0x000D5E21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005886 RID: 22662 RVA: 0x000D7C2C File Offset: 0x000D5E2C
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
					if (num != 72U)
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
					this.taskIds_.AddEntriesFrom(ref input, DangoBrawlTaskRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04003512 RID: 13586
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003513 RID: 13587
		public const int ActivityIdFieldNumber = 9;

		// Token: 0x04003514 RID: 13588
		private int activityId_;

		// Token: 0x04003515 RID: 13589
		public const int TaskIdsFieldNumber = 6;

		// Token: 0x04003516 RID: 13590
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04003517 RID: 13591
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
