using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CFD RID: 3325
	[NetMessage(EMessageId.PhantomReturnRequest)]
	public sealed class PhantomReturnRequest : IMessage<PhantomReturnRequest>, IMessage, IEquatable<PhantomReturnRequest>, IDeepCloneable<PhantomReturnRequest>, IBufferMessage
	{
		// Token: 0x06011F9E RID: 73630 RVA: 0x002A0EB2 File Offset: 0x0029F0B2
		[NullableContext(1)]
		public static PhantomReturnRequest Create()
		{
			return new PhantomReturnRequest();
		}

		// Token: 0x17003B92 RID: 15250
		// (get) Token: 0x06011F9F RID: 73631 RVA: 0x002A0EB9 File Offset: 0x0029F0B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B93 RID: 15251
		// (get) Token: 0x06011FA0 RID: 73632 RVA: 0x002A0EBC File Offset: 0x0029F0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomReturnRequest.Descriptor;
			}
		}

		// Token: 0x06011FA1 RID: 73633 RVA: 0x002A0EC3 File Offset: 0x0029F0C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnRequest()
		{
		}

		// Token: 0x06011FA2 RID: 73634 RVA: 0x002A0ED6 File Offset: 0x0029F0D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnRequest(PhantomReturnRequest other) : this()
		{
			this.stackEntries_ = other.stackEntries_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011FA3 RID: 73635 RVA: 0x002A0F00 File Offset: 0x0029F100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomReturnRequest Clone()
		{
			return new PhantomReturnRequest(this);
		}

		// Token: 0x17003B94 RID: 15252
		// (get) Token: 0x06011FA4 RID: 73636 RVA: 0x002A0F08 File Offset: 0x0029F108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackConsumeEntry> StackEntries
		{
			get
			{
				return this.stackEntries_;
			}
		}

		// Token: 0x06011FA5 RID: 73637 RVA: 0x002A0F10 File Offset: 0x0029F110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomReturnRequest);
		}

		// Token: 0x06011FA6 RID: 73638 RVA: 0x002A0F1E File Offset: 0x0029F11E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomReturnRequest other)
		{
			return other != null && (other == this || (this.stackEntries_.Equals(other.stackEntries_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011FA7 RID: 73639 RVA: 0x002A0F54 File Offset: 0x0029F154
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

		// Token: 0x06011FA8 RID: 73640 RVA: 0x002A0F88 File Offset: 0x0029F188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011FA9 RID: 73641 RVA: 0x002A0F95 File Offset: 0x0029F195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011FAA RID: 73642 RVA: 0x002A0F9E File Offset: 0x0029F19E
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

		// Token: 0x06011FAB RID: 73643 RVA: 0x002A0FC8 File Offset: 0x0029F1C8
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

		// Token: 0x06011FAC RID: 73644 RVA: 0x002A1001 File Offset: 0x0029F201
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

		// Token: 0x06011FAD RID: 73645 RVA: 0x002A102F File Offset: 0x0029F22F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011FAE RID: 73646 RVA: 0x002A1038 File Offset: 0x0029F238
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.stackEntries_.AddEntriesFrom(ref input, PhantomReturnRequest._repeated_stackEntries_codec);
				}
			}
		}

		// Token: 0x040070AC RID: 28844
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070AD RID: 28845
		public const int StackEntriesFieldNumber = 6;

		// Token: 0x040070AE RID: 28846
		private static readonly FieldCodec<PhantomStackConsumeEntry> _repeated_stackEntries_codec = FieldCodec.ForMessage<PhantomStackConsumeEntry>(50U, PhantomStackConsumeEntry.Parser);

		// Token: 0x040070AF RID: 28847
		private readonly RepeatedField<PhantomStackConsumeEntry> stackEntries_ = new RepeatedField<PhantomStackConsumeEntry>();
	}
}
