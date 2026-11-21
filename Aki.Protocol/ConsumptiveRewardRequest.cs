using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002ED RID: 749
	[NetMessage(EMessageId.ConsumptiveRewardRequest)]
	public sealed class ConsumptiveRewardRequest : IMessage<ConsumptiveRewardRequest>, IMessage, IEquatable<ConsumptiveRewardRequest>, IDeepCloneable<ConsumptiveRewardRequest>, IBufferMessage
	{
		// Token: 0x06004C52 RID: 19538 RVA: 0x000BA1C7 File Offset: 0x000B83C7
		[NullableContext(1)]
		public static ConsumptiveRewardRequest Create()
		{
			return new ConsumptiveRewardRequest();
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x06004C53 RID: 19539 RVA: 0x000BA1CE File Offset: 0x000B83CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06004C54 RID: 19540 RVA: 0x000BA1D1 File Offset: 0x000B83D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveRewardRequest.Descriptor;
			}
		}

		// Token: 0x06004C55 RID: 19541 RVA: 0x000BA1D8 File Offset: 0x000B83D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveRewardRequest()
		{
		}

		// Token: 0x06004C56 RID: 19542 RVA: 0x000BA1EB File Offset: 0x000B83EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveRewardRequest(ConsumptiveRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C57 RID: 19543 RVA: 0x000BA221 File Offset: 0x000B8421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveRewardRequest Clone()
		{
			return new ConsumptiveRewardRequest(this);
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06004C58 RID: 19544 RVA: 0x000BA229 File Offset: 0x000B8429
		// (set) Token: 0x06004C59 RID: 19545 RVA: 0x000BA231 File Offset: 0x000B8431
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

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06004C5A RID: 19546 RVA: 0x000BA23A File Offset: 0x000B843A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x06004C5B RID: 19547 RVA: 0x000BA242 File Offset: 0x000B8442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveRewardRequest);
		}

		// Token: 0x06004C5C RID: 19548 RVA: 0x000BA250 File Offset: 0x000B8450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004C5D RID: 19549 RVA: 0x000BA2A0 File Offset: 0x000B84A0
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

		// Token: 0x06004C5E RID: 19550 RVA: 0x000BA2ED File Offset: 0x000B84ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004C5F RID: 19551 RVA: 0x000BA2FA File Offset: 0x000B84FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C60 RID: 19552 RVA: 0x000BA304 File Offset: 0x000B8504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			this.taskIds_.WriteTo(ref output, ConsumptiveRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C61 RID: 19553 RVA: 0x000BA354 File Offset: 0x000B8554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.taskIds_.CalculateSize(ConsumptiveRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004C62 RID: 19554 RVA: 0x000BA3A8 File Offset: 0x000B85A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConsumptiveRewardRequest other)
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

		// Token: 0x06004C63 RID: 19555 RVA: 0x000BA3F5 File Offset: 0x000B85F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C64 RID: 19556 RVA: 0x000BA400 File Offset: 0x000B8600
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
					if (num != 48U && num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskIds_.AddEntriesFrom(ref input, ConsumptiveRewardRequest._repeated_taskIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400314C RID: 12620
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400314D RID: 12621
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x0400314E RID: 12622
		private int activityId_;

		// Token: 0x0400314F RID: 12623
		public const int TaskIdsFieldNumber = 6;

		// Token: 0x04003150 RID: 12624
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04003151 RID: 12625
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
