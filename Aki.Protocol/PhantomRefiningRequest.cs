using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CE9 RID: 3305
	[NetMessage(EMessageId.PhantomRefiningRequest)]
	public sealed class PhantomRefiningRequest : IMessage<PhantomRefiningRequest>, IMessage, IEquatable<PhantomRefiningRequest>, IDeepCloneable<PhantomRefiningRequest>, IBufferMessage
	{
		// Token: 0x06011E54 RID: 73300 RVA: 0x0029E80F File Offset: 0x0029CA0F
		[NullableContext(1)]
		public static PhantomRefiningRequest Create()
		{
			return new PhantomRefiningRequest();
		}

		// Token: 0x17003B4D RID: 15181
		// (get) Token: 0x06011E55 RID: 73301 RVA: 0x0029E816 File Offset: 0x0029CA16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B4E RID: 15182
		// (get) Token: 0x06011E56 RID: 73302 RVA: 0x0029E819 File Offset: 0x0029CA19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomRefiningRequest.Descriptor;
			}
		}

		// Token: 0x06011E57 RID: 73303 RVA: 0x0029E820 File Offset: 0x0029CA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRefiningRequest()
		{
		}

		// Token: 0x06011E58 RID: 73304 RVA: 0x0029E833 File Offset: 0x0029CA33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRefiningRequest(PhantomRefiningRequest other) : this()
		{
			this.stackEntries_ = other.stackEntries_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011E59 RID: 73305 RVA: 0x0029E85D File Offset: 0x0029CA5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRefiningRequest Clone()
		{
			return new PhantomRefiningRequest(this);
		}

		// Token: 0x17003B4F RID: 15183
		// (get) Token: 0x06011E5A RID: 73306 RVA: 0x0029E865 File Offset: 0x0029CA65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackConsumeEntry> StackEntries
		{
			get
			{
				return this.stackEntries_;
			}
		}

		// Token: 0x06011E5B RID: 73307 RVA: 0x0029E86D File Offset: 0x0029CA6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomRefiningRequest);
		}

		// Token: 0x06011E5C RID: 73308 RVA: 0x0029E87B File Offset: 0x0029CA7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomRefiningRequest other)
		{
			return other != null && (other == this || (this.stackEntries_.Equals(other.stackEntries_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011E5D RID: 73309 RVA: 0x0029E8B0 File Offset: 0x0029CAB0
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

		// Token: 0x06011E5E RID: 73310 RVA: 0x0029E8E4 File Offset: 0x0029CAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011E5F RID: 73311 RVA: 0x0029E8F1 File Offset: 0x0029CAF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011E60 RID: 73312 RVA: 0x0029E8FA File Offset: 0x0029CAFA
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

		// Token: 0x06011E61 RID: 73313 RVA: 0x0029E924 File Offset: 0x0029CB24
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

		// Token: 0x06011E62 RID: 73314 RVA: 0x0029E95D File Offset: 0x0029CB5D
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

		// Token: 0x06011E63 RID: 73315 RVA: 0x0029E98B File Offset: 0x0029CB8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011E64 RID: 73316 RVA: 0x0029E994 File Offset: 0x0029CB94
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
					this.stackEntries_.AddEntriesFrom(ref input, PhantomRefiningRequest._repeated_stackEntries_codec);
				}
			}
		}

		// Token: 0x040070AA RID: 28842
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070AB RID: 28843
		public const int StackEntriesFieldNumber = 2;

		// Token: 0x040070AC RID: 28844
		private static readonly FieldCodec<PhantomStackConsumeEntry> _repeated_stackEntries_codec = FieldCodec.ForMessage<PhantomStackConsumeEntry>(18U, PhantomStackConsumeEntry.Parser);

		// Token: 0x040070AD RID: 28845
		private readonly RepeatedField<PhantomStackConsumeEntry> stackEntries_ = new RepeatedField<PhantomStackConsumeEntry>();
	}
}
