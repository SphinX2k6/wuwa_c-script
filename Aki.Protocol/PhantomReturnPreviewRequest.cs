using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CEB RID: 3307
	[NetMessage(EMessageId.PhantomReturnPreviewRequest)]
	public sealed class PhantomReturnPreviewRequest : IMessage<PhantomReturnPreviewRequest>, IMessage, IEquatable<PhantomReturnPreviewRequest>, IDeepCloneable<PhantomReturnPreviewRequest>, IBufferMessage
	{
		// Token: 0x06011E7C RID: 73340 RVA: 0x0029EDFC File Offset: 0x0029CFFC
		[NullableContext(1)]
		public static PhantomReturnPreviewRequest Create()
		{
			return new PhantomReturnPreviewRequest();
		}

		// Token: 0x17003B56 RID: 15190
		// (get) Token: 0x06011E7D RID: 73341 RVA: 0x0029EE03 File Offset: 0x0029D003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B57 RID: 15191
		// (get) Token: 0x06011E7E RID: 73342 RVA: 0x0029EE06 File Offset: 0x0029D006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomReturnPreviewRequest.Descriptor;
			}
		}

		// Token: 0x06011E7F RID: 73343 RVA: 0x0029EE0D File Offset: 0x0029D00D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnPreviewRequest()
		{
		}

		// Token: 0x06011E80 RID: 73344 RVA: 0x0029EE20 File Offset: 0x0029D020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnPreviewRequest(PhantomReturnPreviewRequest other) : this()
		{
			this.stackEntries_ = other.stackEntries_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011E81 RID: 73345 RVA: 0x0029EE4A File Offset: 0x0029D04A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnPreviewRequest Clone()
		{
			return new PhantomReturnPreviewRequest(this);
		}

		// Token: 0x17003B58 RID: 15192
		// (get) Token: 0x06011E82 RID: 73346 RVA: 0x0029EE52 File Offset: 0x0029D052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackConsumeEntry> StackEntries
		{
			get
			{
				return this.stackEntries_;
			}
		}

		// Token: 0x06011E83 RID: 73347 RVA: 0x0029EE5A File Offset: 0x0029D05A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomReturnPreviewRequest);
		}

		// Token: 0x06011E84 RID: 73348 RVA: 0x0029EE68 File Offset: 0x0029D068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomReturnPreviewRequest other)
		{
			return other != null && (other == this || (this.stackEntries_.Equals(other.stackEntries_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011E85 RID: 73349 RVA: 0x0029EE9C File Offset: 0x0029D09C
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

		// Token: 0x06011E86 RID: 73350 RVA: 0x0029EED0 File Offset: 0x0029D0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011E87 RID: 73351 RVA: 0x0029EEDD File Offset: 0x0029D0DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011E88 RID: 73352 RVA: 0x0029EEE6 File Offset: 0x0029D0E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stackEntries_.WriteTo(ref output, PhantomReturnPreviewRequest._repeated_stackEntries_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011E89 RID: 73353 RVA: 0x0029EF10 File Offset: 0x0029D110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.stackEntries_.CalculateSize(PhantomReturnPreviewRequest._repeated_stackEntries_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011E8A RID: 73354 RVA: 0x0029EF49 File Offset: 0x0029D149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomReturnPreviewRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.stackEntries_.Add(other.stackEntries_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011E8B RID: 73355 RVA: 0x0029EF77 File Offset: 0x0029D177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011E8C RID: 73356 RVA: 0x0029EF80 File Offset: 0x0029D180
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
					this.stackEntries_.AddEntriesFrom(ref input, PhantomReturnPreviewRequest._repeated_stackEntries_codec);
				}
			}
		}

		// Token: 0x040070BA RID: 28858
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070BB RID: 28859
		public const int StackEntriesFieldNumber = 1;

		// Token: 0x040070BC RID: 28860
		private static readonly FieldCodec<PhantomStackConsumeEntry> _repeated_stackEntries_codec = FieldCodec.ForMessage<PhantomStackConsumeEntry>(10U, PhantomStackConsumeEntry.Parser);

		// Token: 0x040070BD RID: 28861
		private readonly RepeatedField<PhantomStackConsumeEntry> stackEntries_ = new RepeatedField<PhantomStackConsumeEntry>();
	}
}
