using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005AD RID: 1453
	public sealed class FloroRanchEvent : IMessage<FloroRanchEvent>, IMessage, IEquatable<FloroRanchEvent>, IDeepCloneable<FloroRanchEvent>, IBufferMessage
	{
		// Token: 0x0600864E RID: 34382 RVA: 0x00142D30 File Offset: 0x00140F30
		[NullableContext(1)]
		public static FloroRanchEvent Create()
		{
			return new FloroRanchEvent();
		}

		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x0600864F RID: 34383 RVA: 0x00142D37 File Offset: 0x00140F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x06008650 RID: 34384 RVA: 0x00142D3A File Offset: 0x00140F3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchEvent.Descriptor;
			}
		}

		// Token: 0x06008651 RID: 34385 RVA: 0x00142D41 File Offset: 0x00140F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchEvent()
		{
		}

		// Token: 0x06008652 RID: 34386 RVA: 0x00142D54 File Offset: 0x00140F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchEvent(FloroRanchEvent other) : this()
		{
			this.eventId_ = other.eventId_;
			this.choice_ = other.choice_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008653 RID: 34387 RVA: 0x00142D8A File Offset: 0x00140F8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchEvent Clone()
		{
			return new FloroRanchEvent(this);
		}

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x06008654 RID: 34388 RVA: 0x00142D92 File Offset: 0x00140F92
		// (set) Token: 0x06008655 RID: 34389 RVA: 0x00142D9A File Offset: 0x00140F9A
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

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x06008656 RID: 34390 RVA: 0x00142DA3 File Offset: 0x00140FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Choice
		{
			get
			{
				return this.choice_;
			}
		}

		// Token: 0x06008657 RID: 34391 RVA: 0x00142DAB File Offset: 0x00140FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchEvent);
		}

		// Token: 0x06008658 RID: 34392 RVA: 0x00142DBC File Offset: 0x00140FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchEvent other)
		{
			return other != null && (other == this || (this.EventId == other.EventId && this.choice_.Equals(other.choice_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008659 RID: 34393 RVA: 0x00142E0C File Offset: 0x0014100C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600865A RID: 34394 RVA: 0x00142E59 File Offset: 0x00141059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600865B RID: 34395 RVA: 0x00142E66 File Offset: 0x00141066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600865C RID: 34396 RVA: 0x00142E70 File Offset: 0x00141070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EventId);
			}
			this.choice_.WriteTo(ref output, FloroRanchEvent._repeated_choice_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600865D RID: 34397 RVA: 0x00142EC0 File Offset: 0x001410C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventId);
			}
			num += this.choice_.CalculateSize(FloroRanchEvent._repeated_choice_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600865E RID: 34398 RVA: 0x00142F14 File Offset: 0x00141114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchEvent other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			this.choice_.Add(other.choice_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600865F RID: 34399 RVA: 0x00142F61 File Offset: 0x00141161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008660 RID: 34400 RVA: 0x00142F6C File Offset: 0x0014116C
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
				if (num != 8U)
				{
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.choice_.AddEntriesFrom(ref input, FloroRanchEvent._repeated_choice_codec);
					}
				}
				else
				{
					this.EventId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004245 RID: 16965
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004246 RID: 16966
		public const int EventIdFieldNumber = 1;

		// Token: 0x04004247 RID: 16967
		private int eventId_;

		// Token: 0x04004248 RID: 16968
		public const int ChoiceFieldNumber = 2;

		// Token: 0x04004249 RID: 16969
		private static readonly FieldCodec<int> _repeated_choice_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400424A RID: 16970
		private readonly RepeatedField<int> choice_ = new RepeatedField<int>();
	}
}
