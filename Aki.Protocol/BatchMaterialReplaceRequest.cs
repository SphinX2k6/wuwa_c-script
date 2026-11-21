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
	[NetMessage(EMessageId.BatchMaterialReplaceRequest)]
	public sealed class BatchMaterialReplaceRequest : IMessage<BatchMaterialReplaceRequest>, IMessage, IEquatable<BatchMaterialReplaceRequest>, IDeepCloneable<BatchMaterialReplaceRequest>, IBufferMessage
	{
		// Token: 0x06002C59 RID: 11353 RVA: 0x00073CB0 File Offset: 0x00071EB0
		[NullableContext(1)]
		public static BatchMaterialReplaceRequest Create()
		{
			return new BatchMaterialReplaceRequest();
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06002C5A RID: 11354 RVA: 0x00073CB7 File Offset: 0x00071EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06002C5B RID: 11355 RVA: 0x00073CBA File Offset: 0x00071EBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchMaterialReplaceRequest.Descriptor;
			}
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x00073CC1 File Offset: 0x00071EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchMaterialReplaceRequest()
		{
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x00073CD4 File Offset: 0x00071ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchMaterialReplaceRequest(BatchMaterialReplaceRequest other) : this()
		{
			this.replaceItems_ = other.replaceItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x00073CFE File Offset: 0x00071EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchMaterialReplaceRequest Clone()
		{
			return new BatchMaterialReplaceRequest(this);
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06002C5F RID: 11359 RVA: 0x00073D06 File Offset: 0x00071F06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BatchReplaceItem> ReplaceItems
		{
			get
			{
				return this.replaceItems_;
			}
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x00073D0E File Offset: 0x00071F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchMaterialReplaceRequest);
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x00073D1C File Offset: 0x00071F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BatchMaterialReplaceRequest other)
		{
			return other != null && (other == this || (this.replaceItems_.Equals(other.replaceItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x00073D50 File Offset: 0x00071F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.replaceItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x00073D84 File Offset: 0x00071F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x00073D91 File Offset: 0x00071F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x00073D9A File Offset: 0x00071F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.replaceItems_.WriteTo(ref output, BatchMaterialReplaceRequest._repeated_replaceItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x00073DC4 File Offset: 0x00071FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.replaceItems_.CalculateSize(BatchMaterialReplaceRequest._repeated_replaceItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x00073DFD File Offset: 0x00071FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BatchMaterialReplaceRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.replaceItems_.Add(other.replaceItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x00073E2B File Offset: 0x0007202B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x00073E34 File Offset: 0x00072034
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.replaceItems_.AddEntriesFrom(ref input, BatchMaterialReplaceRequest._repeated_replaceItems_codec);
				}
			}
		}

		// Token: 0x04002849 RID: 10313
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400284A RID: 10314
		public const int ReplaceItemsFieldNumber = 11;

		// Token: 0x0400284B RID: 10315
		private static readonly FieldCodec<BatchReplaceItem> _repeated_replaceItems_codec = FieldCodec.ForMessage<BatchReplaceItem>(90U, BatchReplaceItem.Parser);

		// Token: 0x0400284C RID: 10316
		private readonly RepeatedField<BatchReplaceItem> replaceItems_ = new RepeatedField<BatchReplaceItem>();
	}
}
