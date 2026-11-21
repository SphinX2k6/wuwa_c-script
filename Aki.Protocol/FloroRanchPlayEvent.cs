using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005A4 RID: 1444
	public sealed class FloroRanchPlayEvent : IMessage<FloroRanchPlayEvent>, IMessage, IEquatable<FloroRanchPlayEvent>, IDeepCloneable<FloroRanchPlayEvent>, IBufferMessage
	{
		// Token: 0x060085F3 RID: 34291 RVA: 0x00142DC0 File Offset: 0x00140FC0
		[NullableContext(1)]
		public static FloroRanchPlayEvent Create()
		{
			return new FloroRanchPlayEvent();
		}

		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x060085F4 RID: 34292 RVA: 0x00142DC7 File Offset: 0x00140FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x060085F5 RID: 34293 RVA: 0x00142DCA File Offset: 0x00140FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayEvent.Descriptor;
			}
		}

		// Token: 0x060085F6 RID: 34294 RVA: 0x00142DD1 File Offset: 0x00140FD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayEvent()
		{
		}

		// Token: 0x060085F7 RID: 34295 RVA: 0x00142DE4 File Offset: 0x00140FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayEvent(FloroRanchPlayEvent other) : this()
		{
			this.incId_ = other.incId_;
			this.eventId_ = other.eventId_;
			this.choice_ = other.choice_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060085F8 RID: 34296 RVA: 0x00142E31 File Offset: 0x00141031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayEvent Clone()
		{
			return new FloroRanchPlayEvent(this);
		}

		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x060085F9 RID: 34297 RVA: 0x00142E39 File Offset: 0x00141039
		// (set) Token: 0x060085FA RID: 34298 RVA: 0x00142E41 File Offset: 0x00141041
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

		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x060085FB RID: 34299 RVA: 0x00142E4A File Offset: 0x0014104A
		// (set) Token: 0x060085FC RID: 34300 RVA: 0x00142E52 File Offset: 0x00141052
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

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x060085FD RID: 34301 RVA: 0x00142E5B File Offset: 0x0014105B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Choice
		{
			get
			{
				return this.choice_;
			}
		}

		// Token: 0x060085FE RID: 34302 RVA: 0x00142E63 File Offset: 0x00141063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayEvent);
		}

		// Token: 0x060085FF RID: 34303 RVA: 0x00142E74 File Offset: 0x00141074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayEvent other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.EventId == other.EventId && this.choice_.Equals(other.choice_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008600 RID: 34304 RVA: 0x00142ED4 File Offset: 0x001410D4
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

		// Token: 0x06008601 RID: 34305 RVA: 0x00142F3A File Offset: 0x0014113A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008602 RID: 34306 RVA: 0x00142F47 File Offset: 0x00141147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008603 RID: 34307 RVA: 0x00142F50 File Offset: 0x00141150
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

		// Token: 0x06008604 RID: 34308 RVA: 0x00142FBC File Offset: 0x001411BC
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

		// Token: 0x06008605 RID: 34309 RVA: 0x00143028 File Offset: 0x00141228
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

		// Token: 0x06008606 RID: 34310 RVA: 0x00143089 File Offset: 0x00141289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008607 RID: 34311 RVA: 0x00143094 File Offset: 0x00141294
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

		// Token: 0x040042AE RID: 17070
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042AF RID: 17071
		public const int IncIdFieldNumber = 1;

		// Token: 0x040042B0 RID: 17072
		private int incId_;

		// Token: 0x040042B1 RID: 17073
		public const int EventIdFieldNumber = 2;

		// Token: 0x040042B2 RID: 17074
		private int eventId_;

		// Token: 0x040042B3 RID: 17075
		public const int ChoiceFieldNumber = 3;

		// Token: 0x040042B4 RID: 17076
		private static readonly FieldCodec<int> _repeated_choice_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040042B5 RID: 17077
		private readonly RepeatedField<int> choice_ = new RepeatedField<int>();
	}
}
