using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000844 RID: 2116
	[NetMessage(EMessageId.ItemDecomposePreviewRequest)]
	public sealed class ItemDecomposePreviewRequest : IMessage<ItemDecomposePreviewRequest>, IMessage, IEquatable<ItemDecomposePreviewRequest>, IDeepCloneable<ItemDecomposePreviewRequest>, IBufferMessage
	{
		// Token: 0x0600BCE4 RID: 48356 RVA: 0x001C167A File Offset: 0x001BF87A
		[NullableContext(1)]
		public static ItemDecomposePreviewRequest Create()
		{
			return new ItemDecomposePreviewRequest();
		}

		// Token: 0x17002625 RID: 9765
		// (get) Token: 0x0600BCE5 RID: 48357 RVA: 0x001C1681 File Offset: 0x001BF881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002626 RID: 9766
		// (get) Token: 0x0600BCE6 RID: 48358 RVA: 0x001C1684 File Offset: 0x001BF884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemDecomposePreviewRequest.Descriptor;
			}
		}

		// Token: 0x0600BCE7 RID: 48359 RVA: 0x001C168B File Offset: 0x001BF88B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposePreviewRequest()
		{
		}

		// Token: 0x0600BCE8 RID: 48360 RVA: 0x001C169E File Offset: 0x001BF89E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposePreviewRequest(ItemDecomposePreviewRequest other) : this()
		{
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BCE9 RID: 48361 RVA: 0x001C16C8 File Offset: 0x001BF8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposePreviewRequest Clone()
		{
			return new ItemDecomposePreviewRequest(this);
		}

		// Token: 0x17002627 RID: 9767
		// (get) Token: 0x0600BCEA RID: 48362 RVA: 0x001C16D0 File Offset: 0x001BF8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DecomposeItemInfo> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x0600BCEB RID: 48363 RVA: 0x001C16D8 File Offset: 0x001BF8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemDecomposePreviewRequest);
		}

		// Token: 0x0600BCEC RID: 48364 RVA: 0x001C16E6 File Offset: 0x001BF8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemDecomposePreviewRequest other)
		{
			return other != null && (other == this || (this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BCED RID: 48365 RVA: 0x001C171C File Offset: 0x001BF91C
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

		// Token: 0x0600BCEE RID: 48366 RVA: 0x001C1750 File Offset: 0x001BF950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BCEF RID: 48367 RVA: 0x001C175D File Offset: 0x001BF95D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BCF0 RID: 48368 RVA: 0x001C1766 File Offset: 0x001BF966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemList_.WriteTo(ref output, ItemDecomposePreviewRequest._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BCF1 RID: 48369 RVA: 0x001C1790 File Offset: 0x001BF990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemList_.CalculateSize(ItemDecomposePreviewRequest._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BCF2 RID: 48370 RVA: 0x001C17C9 File Offset: 0x001BF9C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemDecomposePreviewRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.itemList_.Add(other.itemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BCF3 RID: 48371 RVA: 0x001C17F7 File Offset: 0x001BF9F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BCF4 RID: 48372 RVA: 0x001C1800 File Offset: 0x001BFA00
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.itemList_.AddEntriesFrom(ref input, ItemDecomposePreviewRequest._repeated_itemList_codec);
				}
			}
		}

		// Token: 0x040052A5 RID: 21157
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052A6 RID: 21158
		public const int ItemListFieldNumber = 12;

		// Token: 0x040052A7 RID: 21159
		private static readonly FieldCodec<DecomposeItemInfo> _repeated_itemList_codec = FieldCodec.ForMessage<DecomposeItemInfo>(98U, DecomposeItemInfo.Parser);

		// Token: 0x040052A8 RID: 21160
		private readonly RepeatedField<DecomposeItemInfo> itemList_ = new RepeatedField<DecomposeItemInfo>();
	}
}
