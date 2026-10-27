using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C22 RID: 3106
	[NetMessage(EMessageId.PhantomBatchRefiningRequest)]
	public sealed class PhantomBatchRefiningRequest : IMessage<PhantomBatchRefiningRequest>, IMessage, IEquatable<PhantomBatchRefiningRequest>, IDeepCloneable<PhantomBatchRefiningRequest>, IBufferMessage
	{
		// Token: 0x06010DB4 RID: 69044 RVA: 0x00277FC0 File Offset: 0x002761C0
		[NullableContext(1)]
		public static PhantomBatchRefiningRequest Create()
		{
			return new PhantomBatchRefiningRequest();
		}

		// Token: 0x170037A7 RID: 14247
		// (get) Token: 0x06010DB5 RID: 69045 RVA: 0x00277FC7 File Offset: 0x002761C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037A8 RID: 14248
		// (get) Token: 0x06010DB6 RID: 69046 RVA: 0x00277FCA File Offset: 0x002761CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBatchRefiningRequest.Descriptor;
			}
		}

		// Token: 0x06010DB7 RID: 69047 RVA: 0x00277FD1 File Offset: 0x002761D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchRefiningRequest()
		{
		}

		// Token: 0x06010DB8 RID: 69048 RVA: 0x00277FE4 File Offset: 0x002761E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchRefiningRequest(PhantomBatchRefiningRequest other) : this()
		{
			this.stackEntries_ = other.stackEntries_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010DB9 RID: 69049 RVA: 0x0027800E File Offset: 0x0027620E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBatchRefiningRequest Clone()
		{
			return new PhantomBatchRefiningRequest(this);
		}

		// Token: 0x170037A9 RID: 14249
		// (get) Token: 0x06010DBA RID: 69050 RVA: 0x00278016 File Offset: 0x00276216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomStackConsumeEntry> StackEntries
		{
			get
			{
				return this.stackEntries_;
			}
		}

		// Token: 0x06010DBB RID: 69051 RVA: 0x0027801E File Offset: 0x0027621E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBatchRefiningRequest);
		}

		// Token: 0x06010DBC RID: 69052 RVA: 0x0027802C File Offset: 0x0027622C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBatchRefiningRequest other)
		{
			return other != null && (other == this || (this.stackEntries_.Equals(other.stackEntries_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010DBD RID: 69053 RVA: 0x00278060 File Offset: 0x00276260
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

		// Token: 0x06010DBE RID: 69054 RVA: 0x00278094 File Offset: 0x00276294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010DBF RID: 69055 RVA: 0x002780A1 File Offset: 0x002762A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010DC0 RID: 69056 RVA: 0x002780AA File Offset: 0x002762AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.stackEntries_.WriteTo(ref output, PhantomBatchRefiningRequest._repeated_stackEntries_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010DC1 RID: 69057 RVA: 0x002780D4 File Offset: 0x002762D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.stackEntries_.CalculateSize(PhantomBatchRefiningRequest._repeated_stackEntries_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010DC2 RID: 69058 RVA: 0x0027810D File Offset: 0x0027630D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBatchRefiningRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.stackEntries_.Add(other.stackEntries_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010DC3 RID: 69059 RVA: 0x0027813B File Offset: 0x0027633B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010DC4 RID: 69060 RVA: 0x00278144 File Offset: 0x00276344
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.stackEntries_.AddEntriesFrom(ref input, PhantomBatchRefiningRequest._repeated_stackEntries_codec);
				}
			}
		}

		// Token: 0x04006B01 RID: 27393
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B02 RID: 27394
		public const int StackEntriesFieldNumber = 13;

		// Token: 0x04006B03 RID: 27395
		private static readonly FieldCodec<PhantomStackConsumeEntry> _repeated_stackEntries_codec = FieldCodec.ForMessage<PhantomStackConsumeEntry>(106U, PhantomStackConsumeEntry.Parser);

		// Token: 0x04006B04 RID: 27396
		private readonly RepeatedField<PhantomStackConsumeEntry> stackEntries_ = new RepeatedField<PhantomStackConsumeEntry>();
	}
}
