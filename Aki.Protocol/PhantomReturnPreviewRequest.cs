using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CFB RID: 3323
	[NetMessage(EMessageId.PhantomReturnPreviewRequest)]
	public sealed class PhantomReturnPreviewRequest : IMessage<PhantomReturnPreviewRequest>, IMessage, IEquatable<PhantomReturnPreviewRequest>, IDeepCloneable<PhantomReturnPreviewRequest>, IBufferMessage
	{
		// Token: 0x06011F78 RID: 73592 RVA: 0x002A0A14 File Offset: 0x0029EC14
		[NullableContext(1)]
		public static PhantomReturnPreviewRequest Create()
		{
			return new PhantomReturnPreviewRequest();
		}

		// Token: 0x17003B8B RID: 15243
		// (get) Token: 0x06011F79 RID: 73593 RVA: 0x002A0A1B File Offset: 0x0029EC1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B8C RID: 15244
		// (get) Token: 0x06011F7A RID: 73594 RVA: 0x002A0A1E File Offset: 0x0029EC1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomReturnPreviewRequest.Descriptor;
			}
		}

		// Token: 0x06011F7B RID: 73595 RVA: 0x002A0A25 File Offset: 0x0029EC25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnPreviewRequest()
		{
		}

		// Token: 0x06011F7C RID: 73596 RVA: 0x002A0A38 File Offset: 0x0029EC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnPreviewRequest(PhantomReturnPreviewRequest other) : this()
		{
			this.stackEntries_ = other.stackEntries_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011F7D RID: 73597 RVA: 0x002A0A62 File Offset: 0x0029EC62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnPreviewRequest Clone()
		{
			return new PhantomReturnPreviewRequest(this);
		}

		// Token: 0x17003B8D RID: 15245
		// (get) Token: 0x06011F7E RID: 73598 RVA: 0x002A0A6A File Offset: 0x0029EC6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackConsumeEntry> StackEntries
		{
			get
			{
				return this.stackEntries_;
			}
		}

		// Token: 0x06011F7F RID: 73599 RVA: 0x002A0A72 File Offset: 0x0029EC72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomReturnPreviewRequest);
		}

		// Token: 0x06011F80 RID: 73600 RVA: 0x002A0A80 File Offset: 0x0029EC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomReturnPreviewRequest other)
		{
			return other != null && (other == this || (this.stackEntries_.Equals(other.stackEntries_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011F81 RID: 73601 RVA: 0x002A0AB4 File Offset: 0x0029ECB4
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

		// Token: 0x06011F82 RID: 73602 RVA: 0x002A0AE8 File Offset: 0x0029ECE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011F83 RID: 73603 RVA: 0x002A0AF5 File Offset: 0x0029ECF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011F84 RID: 73604 RVA: 0x002A0AFE File Offset: 0x0029ECFE
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

		// Token: 0x06011F85 RID: 73605 RVA: 0x002A0B28 File Offset: 0x0029ED28
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

		// Token: 0x06011F86 RID: 73606 RVA: 0x002A0B61 File Offset: 0x0029ED61
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

		// Token: 0x06011F87 RID: 73607 RVA: 0x002A0B8F File Offset: 0x0029ED8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011F88 RID: 73608 RVA: 0x002A0B98 File Offset: 0x0029ED98
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.stackEntries_.AddEntriesFrom(ref input, PhantomReturnPreviewRequest._repeated_stackEntries_codec);
				}
			}
		}

		// Token: 0x040070A2 RID: 28834
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070A3 RID: 28835
		public const int StackEntriesFieldNumber = 2;

		// Token: 0x040070A4 RID: 28836
		private static readonly FieldCodec<PhantomStackConsumeEntry> _repeated_stackEntries_codec = FieldCodec.ForMessage<PhantomStackConsumeEntry>(18U, PhantomStackConsumeEntry.Parser);

		// Token: 0x040070A5 RID: 28837
		private readonly RepeatedField<PhantomStackConsumeEntry> stackEntries_ = new RepeatedField<PhantomStackConsumeEntry>();
	}
}
