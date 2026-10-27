using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200015D RID: 349
	[NetMessage(EMessageId.BatchMaterialReplaceRequest)]
	public sealed class BatchMaterialReplaceRequest : IMessage<BatchMaterialReplaceRequest>, IMessage, IEquatable<BatchMaterialReplaceRequest>, IDeepCloneable<BatchMaterialReplaceRequest>, IBufferMessage
	{
		// Token: 0x06002BE2 RID: 11234 RVA: 0x00072880 File Offset: 0x00070A80
		[NullableContext(1)]
		public static BatchMaterialReplaceRequest Create()
		{
			return new BatchMaterialReplaceRequest();
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06002BE3 RID: 11235 RVA: 0x00072887 File Offset: 0x00070A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06002BE4 RID: 11236 RVA: 0x0007288A File Offset: 0x00070A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchMaterialReplaceRequest.Descriptor;
			}
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x00072891 File Offset: 0x00070A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchMaterialReplaceRequest()
		{
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x000728A4 File Offset: 0x00070AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchMaterialReplaceRequest(BatchMaterialReplaceRequest other) : this()
		{
			this.replaceItems_ = other.replaceItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x000728CE File Offset: 0x00070ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchMaterialReplaceRequest Clone()
		{
			return new BatchMaterialReplaceRequest(this);
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06002BE8 RID: 11240 RVA: 0x000728D6 File Offset: 0x00070AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BatchReplaceItem> ReplaceItems
		{
			get
			{
				return this.replaceItems_;
			}
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x000728DE File Offset: 0x00070ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchMaterialReplaceRequest);
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x000728EC File Offset: 0x00070AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BatchMaterialReplaceRequest other)
		{
			return other != null && (other == this || (this.replaceItems_.Equals(other.replaceItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x00072920 File Offset: 0x00070B20
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

		// Token: 0x06002BEC RID: 11244 RVA: 0x00072954 File Offset: 0x00070B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x00072961 File Offset: 0x00070B61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x0007296A File Offset: 0x00070B6A
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

		// Token: 0x06002BEF RID: 11247 RVA: 0x00072994 File Offset: 0x00070B94
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

		// Token: 0x06002BF0 RID: 11248 RVA: 0x000729CD File Offset: 0x00070BCD
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

		// Token: 0x06002BF1 RID: 11249 RVA: 0x000729FB File Offset: 0x00070BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x00072A04 File Offset: 0x00070C04
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
					this.replaceItems_.AddEntriesFrom(ref input, BatchMaterialReplaceRequest._repeated_replaceItems_codec);
				}
			}
		}

		// Token: 0x040027D5 RID: 10197
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027D6 RID: 10198
		public const int ReplaceItemsFieldNumber = 1;

		// Token: 0x040027D7 RID: 10199
		private static readonly FieldCodec<BatchReplaceItem> _repeated_replaceItems_codec = FieldCodec.ForMessage<BatchReplaceItem>(10U, BatchReplaceItem.Parser);

		// Token: 0x040027D8 RID: 10200
		private readonly RepeatedField<BatchReplaceItem> replaceItems_ = new RepeatedField<BatchReplaceItem>();
	}
}
