using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CF9 RID: 3321
	[NetMessage(EMessageId.PhantomRefiningRequest)]
	public sealed class PhantomRefiningRequest : IMessage<PhantomRefiningRequest>, IMessage, IEquatable<PhantomRefiningRequest>, IDeepCloneable<PhantomRefiningRequest>, IBufferMessage
	{
		// Token: 0x06011F50 RID: 73552 RVA: 0x002A0427 File Offset: 0x0029E627
		[NullableContext(1)]
		public static PhantomRefiningRequest Create()
		{
			return new PhantomRefiningRequest();
		}

		// Token: 0x17003B82 RID: 15234
		// (get) Token: 0x06011F51 RID: 73553 RVA: 0x002A042E File Offset: 0x0029E62E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B83 RID: 15235
		// (get) Token: 0x06011F52 RID: 73554 RVA: 0x002A0431 File Offset: 0x0029E631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomRefiningRequest.Descriptor;
			}
		}

		// Token: 0x06011F53 RID: 73555 RVA: 0x002A0438 File Offset: 0x0029E638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRefiningRequest()
		{
		}

		// Token: 0x06011F54 RID: 73556 RVA: 0x002A044B File Offset: 0x0029E64B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRefiningRequest(PhantomRefiningRequest other) : this()
		{
			this.stackEntries_ = other.stackEntries_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011F55 RID: 73557 RVA: 0x002A0475 File Offset: 0x0029E675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRefiningRequest Clone()
		{
			return new PhantomRefiningRequest(this);
		}

		// Token: 0x17003B84 RID: 15236
		// (get) Token: 0x06011F56 RID: 73558 RVA: 0x002A047D File Offset: 0x0029E67D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackConsumeEntry> StackEntries
		{
			get
			{
				return this.stackEntries_;
			}
		}

		// Token: 0x06011F57 RID: 73559 RVA: 0x002A0485 File Offset: 0x0029E685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomRefiningRequest);
		}

		// Token: 0x06011F58 RID: 73560 RVA: 0x002A0493 File Offset: 0x0029E693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomRefiningRequest other)
		{
			return other != null && (other == this || (this.stackEntries_.Equals(other.stackEntries_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011F59 RID: 73561 RVA: 0x002A04C8 File Offset: 0x0029E6C8
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

		// Token: 0x06011F5A RID: 73562 RVA: 0x002A04FC File Offset: 0x0029E6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011F5B RID: 73563 RVA: 0x002A0509 File Offset: 0x0029E709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011F5C RID: 73564 RVA: 0x002A0512 File Offset: 0x0029E712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stackEntries_.WriteTo(ref output, PhantomRefiningRequest._repeated_stackEntries_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011F5D RID: 73565 RVA: 0x002A053C File Offset: 0x0029E73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.stackEntries_.CalculateSize(PhantomRefiningRequest._repeated_stackEntries_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011F5E RID: 73566 RVA: 0x002A0575 File Offset: 0x0029E775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomRefiningRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.stackEntries_.Add(other.stackEntries_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011F5F RID: 73567 RVA: 0x002A05A3 File Offset: 0x0029E7A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011F60 RID: 73568 RVA: 0x002A05AC File Offset: 0x0029E7AC
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.stackEntries_.AddEntriesFrom(ref input, PhantomRefiningRequest._repeated_stackEntries_codec);
				}
			}
		}

		// Token: 0x04007092 RID: 28818
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007093 RID: 28819
		public const int StackEntriesFieldNumber = 8;

		// Token: 0x04007094 RID: 28820
		private static readonly FieldCodec<PhantomStackConsumeEntry> _repeated_stackEntries_codec = FieldCodec.ForMessage<PhantomStackConsumeEntry>(66U, PhantomStackConsumeEntry.Parser);

		// Token: 0x04007095 RID: 28821
		private readonly RepeatedField<PhantomStackConsumeEntry> stackEntries_ = new RepeatedField<PhantomStackConsumeEntry>();
	}
}
