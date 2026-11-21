using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CED RID: 3309
	[NetMessage(EMessageId.PhantomReturnRequest)]
	public sealed class PhantomReturnRequest : IMessage<PhantomReturnRequest>, IMessage, IEquatable<PhantomReturnRequest>, IDeepCloneable<PhantomReturnRequest>, IBufferMessage
	{
		// Token: 0x06011EA2 RID: 73378 RVA: 0x0029F29A File Offset: 0x0029D49A
		[NullableContext(1)]
		public static PhantomReturnRequest Create()
		{
			return new PhantomReturnRequest();
		}

		// Token: 0x17003B5D RID: 15197
		// (get) Token: 0x06011EA3 RID: 73379 RVA: 0x0029F2A1 File Offset: 0x0029D4A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B5E RID: 15198
		// (get) Token: 0x06011EA4 RID: 73380 RVA: 0x0029F2A4 File Offset: 0x0029D4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomReturnRequest.Descriptor;
			}
		}

		// Token: 0x06011EA5 RID: 73381 RVA: 0x0029F2AB File Offset: 0x0029D4AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnRequest()
		{
		}

		// Token: 0x06011EA6 RID: 73382 RVA: 0x0029F2BE File Offset: 0x0029D4BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnRequest(PhantomReturnRequest other) : this()
		{
			this.stackEntries_ = other.stackEntries_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011EA7 RID: 73383 RVA: 0x0029F2E8 File Offset: 0x0029D4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnRequest Clone()
		{
			return new PhantomReturnRequest(this);
		}

		// Token: 0x17003B5F RID: 15199
		// (get) Token: 0x06011EA8 RID: 73384 RVA: 0x0029F2F0 File Offset: 0x0029D4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackConsumeEntry> StackEntries
		{
			get
			{
				return this.stackEntries_;
			}
		}

		// Token: 0x06011EA9 RID: 73385 RVA: 0x0029F2F8 File Offset: 0x0029D4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomReturnRequest);
		}

		// Token: 0x06011EAA RID: 73386 RVA: 0x0029F306 File Offset: 0x0029D506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomReturnRequest other)
		{
			return other != null && (other == this || (this.stackEntries_.Equals(other.stackEntries_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011EAB RID: 73387 RVA: 0x0029F33C File Offset: 0x0029D53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.stackEntries_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011EAC RID: 73388 RVA: 0x0029F370 File Offset: 0x0029D570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011EAD RID: 73389 RVA: 0x0029F37D File Offset: 0x0029D57D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011EAE RID: 73390 RVA: 0x0029F386 File Offset: 0x0029D586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stackEntries_.WriteTo(ref output, PhantomReturnRequest._repeated_stackEntries_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011EAF RID: 73391 RVA: 0x0029F3B0 File Offset: 0x0029D5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.stackEntries_.CalculateSize(PhantomReturnRequest._repeated_stackEntries_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011EB0 RID: 73392 RVA: 0x0029F3E9 File Offset: 0x0029D5E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomReturnRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.stackEntries_.Add(other.stackEntries_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011EB1 RID: 73393 RVA: 0x0029F417 File Offset: 0x0029D617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011EB2 RID: 73394 RVA: 0x0029F420 File Offset: 0x0029D620
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.stackEntries_.AddEntriesFrom(ref input, PhantomReturnRequest._repeated_stackEntries_codec);
				}
			}
		}

		// Token: 0x040070C4 RID: 28868
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070C5 RID: 28869
		public const int StackEntriesFieldNumber = 1;

		// Token: 0x040070C6 RID: 28870
		private static readonly FieldCodec<PhantomStackConsumeEntry> _repeated_stackEntries_codec = FieldCodec.ForMessage<PhantomStackConsumeEntry>(10U, PhantomStackConsumeEntry.Parser);

		// Token: 0x040070C7 RID: 28871
		private readonly RepeatedField<PhantomStackConsumeEntry> stackEntries_ = new RepeatedField<PhantomStackConsumeEntry>();
	}
}
