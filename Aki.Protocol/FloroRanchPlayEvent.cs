using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005B9 RID: 1465
	public sealed class FloroRanchPlayEvent : IMessage<FloroRanchPlayEvent>, IMessage, IEquatable<FloroRanchPlayEvent>, IDeepCloneable<FloroRanchPlayEvent>, IBufferMessage
	{
		// Token: 0x0600875B RID: 34651 RVA: 0x001459D0 File Offset: 0x00143BD0
		[NullableContext(1)]
		public static FloroRanchPlayEvent Create()
		{
			return new FloroRanchPlayEvent();
		}

		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x0600875C RID: 34652 RVA: 0x001459D7 File Offset: 0x00143BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x0600875D RID: 34653 RVA: 0x001459DA File Offset: 0x00143BDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayEvent.Descriptor;
			}
		}

		// Token: 0x0600875E RID: 34654 RVA: 0x001459E1 File Offset: 0x00143BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayEvent()
		{
		}

		// Token: 0x0600875F RID: 34655 RVA: 0x001459F4 File Offset: 0x00143BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayEvent(FloroRanchPlayEvent other) : this()
		{
			this.incId_ = other.incId_;
			this.eventId_ = other.eventId_;
			this.choice_ = other.choice_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008760 RID: 34656 RVA: 0x00145A41 File Offset: 0x00143C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayEvent Clone()
		{
			return new FloroRanchPlayEvent(this);
		}

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x06008761 RID: 34657 RVA: 0x00145A49 File Offset: 0x00143C49
		// (set) Token: 0x06008762 RID: 34658 RVA: 0x00145A51 File Offset: 0x00143C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x06008763 RID: 34659 RVA: 0x00145A5A File Offset: 0x00143C5A
		// (set) Token: 0x06008764 RID: 34660 RVA: 0x00145A62 File Offset: 0x00143C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x06008765 RID: 34661 RVA: 0x00145A6B File Offset: 0x00143C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Choice
		{
			get
			{
				return this.choice_;
			}
		}

		// Token: 0x06008766 RID: 34662 RVA: 0x00145A73 File Offset: 0x00143C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayEvent);
		}

		// Token: 0x06008767 RID: 34663 RVA: 0x00145A84 File Offset: 0x00143C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayEvent other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.EventId == other.EventId && this.choice_.Equals(other.choice_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008768 RID: 34664 RVA: 0x00145AE4 File Offset: 0x00143CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			num ^= this.choice_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008769 RID: 34665 RVA: 0x00145B4A File Offset: 0x00143D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600876A RID: 34666 RVA: 0x00145B57 File Offset: 0x00143D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600876B RID: 34667 RVA: 0x00145B60 File Offset: 0x00143D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IncId);
			}
			if (this.EventId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EventId);
			}
			this.choice_.WriteTo(ref output, FloroRanchPlayEvent._repeated_choice_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600876C RID: 34668 RVA: 0x00145BCC File Offset: 0x00143DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.EventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventId);
			}
			num += this.choice_.CalculateSize(FloroRanchPlayEvent._repeated_choice_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600876D RID: 34669 RVA: 0x00145C38 File Offset: 0x00143E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayEvent other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			this.choice_.Add(other.choice_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600876E RID: 34670 RVA: 0x00145C99 File Offset: 0x00143E99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600876F RID: 34671 RVA: 0x00145CA4 File Offset: 0x00143EA4
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.EventId = input.ReadInt32();
						continue;
					}
				}
				else if (num == 24U || num == 26U)
				{
					this.choice_.AddEntriesFrom(ref input, FloroRanchPlayEvent._repeated_choice_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040042B8 RID: 17080
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042B9 RID: 17081
		public const int IncIdFieldNumber = 1;

		// Token: 0x040042BA RID: 17082
		private int incId_;

		// Token: 0x040042BB RID: 17083
		public const int EventIdFieldNumber = 2;

		// Token: 0x040042BC RID: 17084
		private int eventId_;

		// Token: 0x040042BD RID: 17085
		public const int ChoiceFieldNumber = 3;

		// Token: 0x040042BE RID: 17086
		private static readonly FieldCodec<int> _repeated_choice_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040042BF RID: 17087
		private readonly RepeatedField<int> choice_ = new RepeatedField<int>();
	}
}
