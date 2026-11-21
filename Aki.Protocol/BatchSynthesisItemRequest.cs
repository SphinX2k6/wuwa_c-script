using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000163 RID: 355
	[NetMessage(EMessageId.BatchSynthesisItemRequest)]
	public sealed class BatchSynthesisItemRequest : IMessage<BatchSynthesisItemRequest>, IMessage, IEquatable<BatchSynthesisItemRequest>, IDeepCloneable<BatchSynthesisItemRequest>, IBufferMessage
	{
		// Token: 0x06002C94 RID: 11412 RVA: 0x000743F2 File Offset: 0x000725F2
		[NullableContext(1)]
		public static BatchSynthesisItemRequest Create()
		{
			return new BatchSynthesisItemRequest();
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06002C95 RID: 11413 RVA: 0x000743F9 File Offset: 0x000725F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06002C96 RID: 11414 RVA: 0x000743FC File Offset: 0x000725FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchSynthesisItemRequest.Descriptor;
			}
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x00074403 File Offset: 0x00072603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchSynthesisItemRequest()
		{
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x00074416 File Offset: 0x00072616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchSynthesisItemRequest(BatchSynthesisItemRequest other) : this()
		{
			this.batchItems_ = other.batchItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x00074440 File Offset: 0x00072640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchSynthesisItemRequest Clone()
		{
			return new BatchSynthesisItemRequest(this);
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06002C9A RID: 11418 RVA: 0x00074448 File Offset: 0x00072648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BatchItem> BatchItems
		{
			get
			{
				return this.batchItems_;
			}
		}

		// Token: 0x06002C9B RID: 11419 RVA: 0x00074450 File Offset: 0x00072650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchSynthesisItemRequest);
		}

		// Token: 0x06002C9C RID: 11420 RVA: 0x0007445E File Offset: 0x0007265E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BatchSynthesisItemRequest other)
		{
			return other != null && (other == this || (this.batchItems_.Equals(other.batchItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x00074494 File Offset: 0x00072694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.batchItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x000744C8 File Offset: 0x000726C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x000744D5 File Offset: 0x000726D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x000744DE File Offset: 0x000726DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.batchItems_.WriteTo(ref output, BatchSynthesisItemRequest._repeated_batchItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x00074508 File Offset: 0x00072708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.batchItems_.CalculateSize(BatchSynthesisItemRequest._repeated_batchItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x00074541 File Offset: 0x00072741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BatchSynthesisItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.batchItems_.Add(other.batchItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x0007456F File Offset: 0x0007276F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x00074578 File Offset: 0x00072778
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.batchItems_.AddEntriesFrom(ref input, BatchSynthesisItemRequest._repeated_batchItems_codec);
				}
			}
		}

		// Token: 0x04002859 RID: 10329
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400285A RID: 10330
		public const int BatchItemsFieldNumber = 14;

		// Token: 0x0400285B RID: 10331
		private static readonly FieldCodec<BatchItem> _repeated_batchItems_codec = FieldCodec.ForMessage<BatchItem>(114U, BatchItem.Parser);

		// Token: 0x0400285C RID: 10332
		private readonly RepeatedField<BatchItem> batchItems_ = new RepeatedField<BatchItem>();
	}
}
