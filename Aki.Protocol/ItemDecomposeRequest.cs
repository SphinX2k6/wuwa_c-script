using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000846 RID: 2118
	[NetMessage(EMessageId.ItemDecomposeRequest)]
	public sealed class ItemDecomposeRequest : IMessage<ItemDecomposeRequest>, IMessage, IEquatable<ItemDecomposeRequest>, IDeepCloneable<ItemDecomposeRequest>, IBufferMessage
	{
		// Token: 0x0600BD0A RID: 48394 RVA: 0x001C1B1A File Offset: 0x001BFD1A
		[NullableContext(1)]
		public static ItemDecomposeRequest Create()
		{
			return new ItemDecomposeRequest();
		}

		// Token: 0x1700262C RID: 9772
		// (get) Token: 0x0600BD0B RID: 48395 RVA: 0x001C1B21 File Offset: 0x001BFD21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700262D RID: 9773
		// (get) Token: 0x0600BD0C RID: 48396 RVA: 0x001C1B24 File Offset: 0x001BFD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemDecomposeRequest.Descriptor;
			}
		}

		// Token: 0x0600BD0D RID: 48397 RVA: 0x001C1B2B File Offset: 0x001BFD2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposeRequest()
		{
		}

		// Token: 0x0600BD0E RID: 48398 RVA: 0x001C1B3E File Offset: 0x001BFD3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposeRequest(ItemDecomposeRequest other) : this()
		{
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD0F RID: 48399 RVA: 0x001C1B68 File Offset: 0x001BFD68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposeRequest Clone()
		{
			return new ItemDecomposeRequest(this);
		}

		// Token: 0x1700262E RID: 9774
		// (get) Token: 0x0600BD10 RID: 48400 RVA: 0x001C1B70 File Offset: 0x001BFD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DecomposeItemInfo> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x0600BD11 RID: 48401 RVA: 0x001C1B78 File Offset: 0x001BFD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemDecomposeRequest);
		}

		// Token: 0x0600BD12 RID: 48402 RVA: 0x001C1B86 File Offset: 0x001BFD86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemDecomposeRequest other)
		{
			return other != null && (other == this || (this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD13 RID: 48403 RVA: 0x001C1BBC File Offset: 0x001BFDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BD14 RID: 48404 RVA: 0x001C1BF0 File Offset: 0x001BFDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BD15 RID: 48405 RVA: 0x001C1BFD File Offset: 0x001BFDFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD16 RID: 48406 RVA: 0x001C1C06 File Offset: 0x001BFE06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemList_.WriteTo(ref output, ItemDecomposeRequest._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BD17 RID: 48407 RVA: 0x001C1C30 File Offset: 0x001BFE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemList_.CalculateSize(ItemDecomposeRequest._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BD18 RID: 48408 RVA: 0x001C1C69 File Offset: 0x001BFE69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemDecomposeRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.itemList_.Add(other.itemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BD19 RID: 48409 RVA: 0x001C1C97 File Offset: 0x001BFE97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD1A RID: 48410 RVA: 0x001C1CA0 File Offset: 0x001BFEA0
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
					this.itemList_.AddEntriesFrom(ref input, ItemDecomposeRequest._repeated_itemList_codec);
				}
			}
		}

		// Token: 0x040052AF RID: 21167
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052B0 RID: 21168
		public const int ItemListFieldNumber = 11;

		// Token: 0x040052B1 RID: 21169
		private static readonly FieldCodec<DecomposeItemInfo> _repeated_itemList_codec = FieldCodec.ForMessage<DecomposeItemInfo>(90U, DecomposeItemInfo.Parser);

		// Token: 0x040052B2 RID: 21170
		private readonly RepeatedField<DecomposeItemInfo> itemList_ = new RepeatedField<DecomposeItemInfo>();
	}
}
