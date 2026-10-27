using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000160 RID: 352
	[NetMessage(EMessageId.BatchSynthesisItemRequest)]
	public sealed class BatchSynthesisItemRequest : IMessage<BatchSynthesisItemRequest>, IMessage, IEquatable<BatchSynthesisItemRequest>, IDeepCloneable<BatchSynthesisItemRequest>, IBufferMessage
	{
		// Token: 0x06002C1D RID: 11293 RVA: 0x00072FC2 File Offset: 0x000711C2
		[NullableContext(1)]
		public static BatchSynthesisItemRequest Create()
		{
			return new BatchSynthesisItemRequest();
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06002C1E RID: 11294 RVA: 0x00072FC9 File Offset: 0x000711C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06002C1F RID: 11295 RVA: 0x00072FCC File Offset: 0x000711CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchSynthesisItemRequest.Descriptor;
			}
		}

		// Token: 0x06002C20 RID: 11296 RVA: 0x00072FD3 File Offset: 0x000711D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchSynthesisItemRequest()
		{
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x00072FE6 File Offset: 0x000711E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchSynthesisItemRequest(BatchSynthesisItemRequest other) : this()
		{
			this.batchItems_ = other.batchItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x00073010 File Offset: 0x00071210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchSynthesisItemRequest Clone()
		{
			return new BatchSynthesisItemRequest(this);
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06002C23 RID: 11299 RVA: 0x00073018 File Offset: 0x00071218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BatchItem> BatchItems
		{
			get
			{
				return this.batchItems_;
			}
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x00073020 File Offset: 0x00071220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchSynthesisItemRequest);
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x0007302E File Offset: 0x0007122E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BatchSynthesisItemRequest other)
		{
			return other != null && (other == this || (this.batchItems_.Equals(other.batchItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x00073064 File Offset: 0x00071264
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

		// Token: 0x06002C27 RID: 11303 RVA: 0x00073098 File Offset: 0x00071298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x000730A5 File Offset: 0x000712A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x000730AE File Offset: 0x000712AE
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

		// Token: 0x06002C2A RID: 11306 RVA: 0x000730D8 File Offset: 0x000712D8
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

		// Token: 0x06002C2B RID: 11307 RVA: 0x00073111 File Offset: 0x00071311
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

		// Token: 0x06002C2C RID: 11308 RVA: 0x0007313F File Offset: 0x0007133F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x00073148 File Offset: 0x00071348
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.batchItems_.AddEntriesFrom(ref input, BatchSynthesisItemRequest._repeated_batchItems_codec);
				}
			}
		}

		// Token: 0x040027E5 RID: 10213
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027E6 RID: 10214
		public const int BatchItemsFieldNumber = 5;

		// Token: 0x040027E7 RID: 10215
		private static readonly FieldCodec<BatchItem> _repeated_batchItems_codec = FieldCodec.ForMessage<BatchItem>(42U, BatchItem.Parser);

		// Token: 0x040027E8 RID: 10216
		private readonly RepeatedField<BatchItem> batchItems_ = new RepeatedField<BatchItem>();
	}
}
