using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C10 RID: 3088
	[NetMessage(EMessageId.PhantomBatchPolishRequest)]
	public sealed class PhantomBatchPolishRequest : IMessage<PhantomBatchPolishRequest>, IMessage, IEquatable<PhantomBatchPolishRequest>, IDeepCloneable<PhantomBatchPolishRequest>, IBufferMessage
	{
		// Token: 0x06010C8A RID: 68746 RVA: 0x00275BA5 File Offset: 0x00273DA5
		[NullableContext(1)]
		public static PhantomBatchPolishRequest Create()
		{
			return new PhantomBatchPolishRequest();
		}

		// Token: 0x17003766 RID: 14182
		// (get) Token: 0x06010C8B RID: 68747 RVA: 0x00275BAC File Offset: 0x00273DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003767 RID: 14183
		// (get) Token: 0x06010C8C RID: 68748 RVA: 0x00275BAF File Offset: 0x00273DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBatchPolishRequest.Descriptor;
			}
		}

		// Token: 0x06010C8D RID: 68749 RVA: 0x00275BB6 File Offset: 0x00273DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchPolishRequest()
		{
		}

		// Token: 0x06010C8E RID: 68750 RVA: 0x00275BC9 File Offset: 0x00273DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchPolishRequest(PhantomBatchPolishRequest other) : this()
		{
			this.phantomMainPropItemId_ = other.phantomMainPropItemId_;
			this.stackEntries_ = other.stackEntries_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010C8F RID: 68751 RVA: 0x00275BFF File Offset: 0x00273DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchPolishRequest Clone()
		{
			return new PhantomBatchPolishRequest(this);
		}

		// Token: 0x17003768 RID: 14184
		// (get) Token: 0x06010C90 RID: 68752 RVA: 0x00275C07 File Offset: 0x00273E07
		// (set) Token: 0x06010C91 RID: 68753 RVA: 0x00275C0F File Offset: 0x00273E0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomMainPropItemId
		{
			get
			{
				return this.phantomMainPropItemId_;
			}
			set
			{
				this.phantomMainPropItemId_ = value;
			}
		}

		// Token: 0x17003769 RID: 14185
		// (get) Token: 0x06010C92 RID: 68754 RVA: 0x00275C18 File Offset: 0x00273E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackConsumeEntry> StackEntries
		{
			get
			{
				return this.stackEntries_;
			}
		}

		// Token: 0x06010C93 RID: 68755 RVA: 0x00275C20 File Offset: 0x00273E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBatchPolishRequest);
		}

		// Token: 0x06010C94 RID: 68756 RVA: 0x00275C30 File Offset: 0x00273E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBatchPolishRequest other)
		{
			return other != null && (other == this || (this.PhantomMainPropItemId == other.PhantomMainPropItemId && this.stackEntries_.Equals(other.stackEntries_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010C95 RID: 68757 RVA: 0x00275C80 File Offset: 0x00273E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomMainPropItemId != 0)
			{
				num ^= this.PhantomMainPropItemId.GetHashCode();
			}
			num ^= this.stackEntries_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010C96 RID: 68758 RVA: 0x00275CCD File Offset: 0x00273ECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010C97 RID: 68759 RVA: 0x00275CDA File Offset: 0x00273EDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010C98 RID: 68760 RVA: 0x00275CE4 File Offset: 0x00273EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomMainPropItemId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PhantomMainPropItemId);
			}
			this.stackEntries_.WriteTo(ref output, PhantomBatchPolishRequest._repeated_stackEntries_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010C99 RID: 68761 RVA: 0x00275D34 File Offset: 0x00273F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomMainPropItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomMainPropItemId);
			}
			num += this.stackEntries_.CalculateSize(PhantomBatchPolishRequest._repeated_stackEntries_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010C9A RID: 68762 RVA: 0x00275D88 File Offset: 0x00273F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBatchPolishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomMainPropItemId != 0)
			{
				this.PhantomMainPropItemId = other.PhantomMainPropItemId;
			}
			this.stackEntries_.Add(other.stackEntries_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010C9B RID: 68763 RVA: 0x00275DD5 File Offset: 0x00273FD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010C9C RID: 68764 RVA: 0x00275DE0 File Offset: 0x00273FE0
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
				if (num != 48U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.stackEntries_.AddEntriesFrom(ref input, PhantomBatchPolishRequest._repeated_stackEntries_codec);
					}
				}
				else
				{
					this.PhantomMainPropItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006B03 RID: 27395
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B04 RID: 27396
		public const int PhantomMainPropItemIdFieldNumber = 6;

		// Token: 0x04006B05 RID: 27397
		private int phantomMainPropItemId_;

		// Token: 0x04006B06 RID: 27398
		public const int StackEntriesFieldNumber = 14;

		// Token: 0x04006B07 RID: 27399
		private static readonly FieldCodec<PhantomStackConsumeEntry> _repeated_stackEntries_codec = FieldCodec.ForMessage<PhantomStackConsumeEntry>(114U, PhantomStackConsumeEntry.Parser);

		// Token: 0x04006B08 RID: 27400
		private readonly RepeatedField<PhantomStackConsumeEntry> stackEntries_ = new RepeatedField<PhantomStackConsumeEntry>();
	}
}
