using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005BA RID: 1466
	[NetMessage(EMessageId.FloroRanchPlayEventChoiceRequest)]
	public sealed class FloroRanchPlayEventChoiceRequest : IMessage<FloroRanchPlayEventChoiceRequest>, IMessage, IEquatable<FloroRanchPlayEventChoiceRequest>, IDeepCloneable<FloroRanchPlayEventChoiceRequest>, IBufferMessage
	{
		// Token: 0x06008771 RID: 34673 RVA: 0x00145D2D File Offset: 0x00143F2D
		[NullableContext(1)]
		public static FloroRanchPlayEventChoiceRequest Create()
		{
			return new FloroRanchPlayEventChoiceRequest();
		}

		// Token: 0x17001A7D RID: 6781
		// (get) Token: 0x06008772 RID: 34674 RVA: 0x00145D34 File Offset: 0x00143F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x06008773 RID: 34675 RVA: 0x00145D37 File Offset: 0x00143F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayEventChoiceRequest.Descriptor;
			}
		}

		// Token: 0x06008774 RID: 34676 RVA: 0x00145D3E File Offset: 0x00143F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayEventChoiceRequest()
		{
		}

		// Token: 0x06008775 RID: 34677 RVA: 0x00145D48 File Offset: 0x00143F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayEventChoiceRequest(FloroRanchPlayEventChoiceRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.eventId_ = other.eventId_;
			this.choiceId_ = other.choiceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008776 RID: 34678 RVA: 0x00145D9C File Offset: 0x00143F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayEventChoiceRequest Clone()
		{
			return new FloroRanchPlayEventChoiceRequest(this);
		}

		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x06008777 RID: 34679 RVA: 0x00145DA4 File Offset: 0x00143FA4
		// (set) Token: 0x06008778 RID: 34680 RVA: 0x00145DAC File Offset: 0x00143FAC
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

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x06008779 RID: 34681 RVA: 0x00145DB5 File Offset: 0x00143FB5
		// (set) Token: 0x0600877A RID: 34682 RVA: 0x00145DBD File Offset: 0x00143FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x0600877B RID: 34683 RVA: 0x00145DC6 File Offset: 0x00143FC6
		// (set) Token: 0x0600877C RID: 34684 RVA: 0x00145DCE File Offset: 0x00143FCE
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

		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x0600877D RID: 34685 RVA: 0x00145DD7 File Offset: 0x00143FD7
		// (set) Token: 0x0600877E RID: 34686 RVA: 0x00145DDF File Offset: 0x00143FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChoiceId
		{
			get
			{
				return this.choiceId_;
			}
			set
			{
				this.choiceId_ = value;
			}
		}

		// Token: 0x0600877F RID: 34687 RVA: 0x00145DE8 File Offset: 0x00143FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayEventChoiceRequest);
		}

		// Token: 0x06008780 RID: 34688 RVA: 0x00145DF8 File Offset: 0x00143FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayEventChoiceRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.EventId == other.EventId && this.ChoiceId == other.ChoiceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008781 RID: 34689 RVA: 0x00145E64 File Offset: 0x00144064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.ChoiceId != 0)
			{
				num ^= this.ChoiceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008782 RID: 34690 RVA: 0x00145EEE File Offset: 0x001440EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008783 RID: 34691 RVA: 0x00145EFB File Offset: 0x001440FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008784 RID: 34692 RVA: 0x00145F04 File Offset: 0x00144104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EventId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			if (this.ChoiceId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ChoiceId);
			}
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SubInsId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008785 RID: 34693 RVA: 0x00145F98 File Offset: 0x00144198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			if (this.EventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventId);
			}
			if (this.ChoiceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChoiceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008786 RID: 34694 RVA: 0x00146020 File Offset: 0x00144220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayEventChoiceRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.ChoiceId != 0)
			{
				this.ChoiceId = other.ChoiceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008787 RID: 34695 RVA: 0x00146098 File Offset: 0x00144298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008788 RID: 34696 RVA: 0x001460A4 File Offset: 0x001442A4
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
				if (num <= 64U)
				{
					if (num == 16U)
					{
						this.EventId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.ChoiceId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.SubInsId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040042C0 RID: 17088
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042C1 RID: 17089
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x040042C2 RID: 17090
		private int activityId_;

		// Token: 0x040042C3 RID: 17091
		public const int SubInsIdFieldNumber = 14;

		// Token: 0x040042C4 RID: 17092
		private int subInsId_;

		// Token: 0x040042C5 RID: 17093
		public const int EventIdFieldNumber = 2;

		// Token: 0x040042C6 RID: 17094
		private int eventId_;

		// Token: 0x040042C7 RID: 17095
		public const int ChoiceIdFieldNumber = 9;

		// Token: 0x040042C8 RID: 17096
		private int choiceId_;
	}
}
