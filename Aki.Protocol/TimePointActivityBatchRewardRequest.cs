using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001379 RID: 4985
	[NetMessage(EMessageId.TimePointActivityBatchRewardRequest)]
	public sealed class TimePointActivityBatchRewardRequest : IMessage<TimePointActivityBatchRewardRequest>, IMessage, IEquatable<TimePointActivityBatchRewardRequest>, IDeepCloneable<TimePointActivityBatchRewardRequest>, IBufferMessage
	{
		// Token: 0x0601A77B RID: 108411 RVA: 0x003D79A5 File Offset: 0x003D5BA5
		[NullableContext(1)]
		public static TimePointActivityBatchRewardRequest Create()
		{
			return new TimePointActivityBatchRewardRequest();
		}

		// Token: 0x17005946 RID: 22854
		// (get) Token: 0x0601A77C RID: 108412 RVA: 0x003D79AC File Offset: 0x003D5BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005947 RID: 22855
		// (get) Token: 0x0601A77D RID: 108413 RVA: 0x003D79AF File Offset: 0x003D5BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimePointActivityBatchRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601A77E RID: 108414 RVA: 0x003D79B6 File Offset: 0x003D5BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityBatchRewardRequest()
		{
		}

		// Token: 0x0601A77F RID: 108415 RVA: 0x003D79C9 File Offset: 0x003D5BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityBatchRewardRequest(TimePointActivityBatchRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A780 RID: 108416 RVA: 0x003D79FF File Offset: 0x003D5BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointActivityBatchRewardRequest Clone()
		{
			return new TimePointActivityBatchRewardRequest(this);
		}

		// Token: 0x17005948 RID: 22856
		// (get) Token: 0x0601A781 RID: 108417 RVA: 0x003D7A07 File Offset: 0x003D5C07
		// (set) Token: 0x0601A782 RID: 108418 RVA: 0x003D7A0F File Offset: 0x003D5C0F
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

		// Token: 0x17005949 RID: 22857
		// (get) Token: 0x0601A783 RID: 108419 RVA: 0x003D7A18 File Offset: 0x003D5C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601A784 RID: 108420 RVA: 0x003D7A20 File Offset: 0x003D5C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimePointActivityBatchRewardRequest);
		}

		// Token: 0x0601A785 RID: 108421 RVA: 0x003D7A30 File Offset: 0x003D5C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimePointActivityBatchRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A786 RID: 108422 RVA: 0x003D7A80 File Offset: 0x003D5C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A787 RID: 108423 RVA: 0x003D7ACD File Offset: 0x003D5CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A788 RID: 108424 RVA: 0x003D7ADA File Offset: 0x003D5CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A789 RID: 108425 RVA: 0x003D7AE4 File Offset: 0x003D5CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			this.ids_.WriteTo(ref output, TimePointActivityBatchRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A78A RID: 108426 RVA: 0x003D7B34 File Offset: 0x003D5D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.ids_.CalculateSize(TimePointActivityBatchRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A78B RID: 108427 RVA: 0x003D7B88 File Offset: 0x003D5D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimePointActivityBatchRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A78C RID: 108428 RVA: 0x003D7BD5 File Offset: 0x003D5DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A78D RID: 108429 RVA: 0x003D7BE0 File Offset: 0x003D5DE0
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
				if (num != 16U)
				{
					if (num != 64U && num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ids_.AddEntriesFrom(ref input, TimePointActivityBatchRewardRequest._repeated_ids_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009A0F RID: 39439
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A10 RID: 39440
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x04009A11 RID: 39441
		private int activityId_;

		// Token: 0x04009A12 RID: 39442
		public const int IdsFieldNumber = 8;

		// Token: 0x04009A13 RID: 39443
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04009A14 RID: 39444
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
