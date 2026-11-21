using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000598 RID: 1432
	public sealed class FloroRanchEvent : IMessage<FloroRanchEvent>, IMessage, IEquatable<FloroRanchEvent>, IDeepCloneable<FloroRanchEvent>, IBufferMessage
	{
		// Token: 0x060084E6 RID: 34022 RVA: 0x00140124 File Offset: 0x0013E324
		[NullableContext(1)]
		public static FloroRanchEvent Create()
		{
			return new FloroRanchEvent();
		}

		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x060084E7 RID: 34023 RVA: 0x0014012B File Offset: 0x0013E32B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x060084E8 RID: 34024 RVA: 0x0014012E File Offset: 0x0013E32E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchEvent.Descriptor;
			}
		}

		// Token: 0x060084E9 RID: 34025 RVA: 0x00140135 File Offset: 0x0013E335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchEvent()
		{
		}

		// Token: 0x060084EA RID: 34026 RVA: 0x00140148 File Offset: 0x0013E348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchEvent(FloroRanchEvent other) : this()
		{
			this.eventId_ = other.eventId_;
			this.choice_ = other.choice_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060084EB RID: 34027 RVA: 0x0014017E File Offset: 0x0013E37E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchEvent Clone()
		{
			return new FloroRanchEvent(this);
		}

		// Token: 0x170019E9 RID: 6633
		// (get) Token: 0x060084EC RID: 34028 RVA: 0x00140186 File Offset: 0x0013E386
		// (set) Token: 0x060084ED RID: 34029 RVA: 0x0014018E File Offset: 0x0013E38E
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

		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x060084EE RID: 34030 RVA: 0x00140197 File Offset: 0x0013E397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Choice
		{
			get
			{
				return this.choice_;
			}
		}

		// Token: 0x060084EF RID: 34031 RVA: 0x0014019F File Offset: 0x0013E39F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchEvent);
		}

		// Token: 0x060084F0 RID: 34032 RVA: 0x001401B0 File Offset: 0x0013E3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchEvent other)
		{
			return other != null && (other == this || (this.EventId == other.EventId && this.choice_.Equals(other.choice_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060084F1 RID: 34033 RVA: 0x00140200 File Offset: 0x0013E400
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

		// Token: 0x060084F2 RID: 34034 RVA: 0x0014024D File Offset: 0x0013E44D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060084F3 RID: 34035 RVA: 0x0014025A File Offset: 0x0013E45A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060084F4 RID: 34036 RVA: 0x00140264 File Offset: 0x0013E464
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

		// Token: 0x060084F5 RID: 34037 RVA: 0x001402B4 File Offset: 0x0013E4B4
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

		// Token: 0x060084F6 RID: 34038 RVA: 0x00140308 File Offset: 0x0013E508
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

		// Token: 0x060084F7 RID: 34039 RVA: 0x00140355 File Offset: 0x0013E555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060084F8 RID: 34040 RVA: 0x00140360 File Offset: 0x0013E560
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

		// Token: 0x0400423B RID: 16955
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400423C RID: 16956
		public const int EventIdFieldNumber = 1;

		// Token: 0x0400423D RID: 16957
		private int eventId_;

		// Token: 0x0400423E RID: 16958
		public const int ChoiceFieldNumber = 2;

		// Token: 0x0400423F RID: 16959
		private static readonly FieldCodec<int> _repeated_choice_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04004240 RID: 16960
		private readonly RepeatedField<int> choice_ = new RepeatedField<int>();
	}
}
