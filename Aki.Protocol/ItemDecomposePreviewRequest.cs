using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000831 RID: 2097
	[NetMessage(EMessageId.ItemDecomposePreviewRequest)]
	public sealed class ItemDecomposePreviewRequest : IMessage<ItemDecomposePreviewRequest>, IMessage, IEquatable<ItemDecomposePreviewRequest>, IDeepCloneable<ItemDecomposePreviewRequest>, IBufferMessage
	{
		// Token: 0x0600BBA0 RID: 48032 RVA: 0x001BEE6A File Offset: 0x001BD06A
		[NullableContext(1)]
		public static ItemDecomposePreviewRequest Create()
		{
			return new ItemDecomposePreviewRequest();
		}

		// Token: 0x170025DE RID: 9694
		// (get) Token: 0x0600BBA1 RID: 48033 RVA: 0x001BEE71 File Offset: 0x001BD071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025DF RID: 9695
		// (get) Token: 0x0600BBA2 RID: 48034 RVA: 0x001BEE74 File Offset: 0x001BD074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemDecomposePreviewRequest.Descriptor;
			}
		}

		// Token: 0x0600BBA3 RID: 48035 RVA: 0x001BEE7B File Offset: 0x001BD07B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposePreviewRequest()
		{
		}

		// Token: 0x0600BBA4 RID: 48036 RVA: 0x001BEE8E File Offset: 0x001BD08E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposePreviewRequest(ItemDecomposePreviewRequest other) : this()
		{
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BBA5 RID: 48037 RVA: 0x001BEEB8 File Offset: 0x001BD0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposePreviewRequest Clone()
		{
			return new ItemDecomposePreviewRequest(this);
		}

		// Token: 0x170025E0 RID: 9696
		// (get) Token: 0x0600BBA6 RID: 48038 RVA: 0x001BEEC0 File Offset: 0x001BD0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DecomposeItemInfo> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x0600BBA7 RID: 48039 RVA: 0x001BEEC8 File Offset: 0x001BD0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemDecomposePreviewRequest);
		}

		// Token: 0x0600BBA8 RID: 48040 RVA: 0x001BEED6 File Offset: 0x001BD0D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemDecomposePreviewRequest other)
		{
			return other != null && (other == this || (this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BBA9 RID: 48041 RVA: 0x001BEF0C File Offset: 0x001BD10C
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

		// Token: 0x0600BBAA RID: 48042 RVA: 0x001BEF40 File Offset: 0x001BD140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BBAB RID: 48043 RVA: 0x001BEF4D File Offset: 0x001BD14D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BBAC RID: 48044 RVA: 0x001BEF56 File Offset: 0x001BD156
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

		// Token: 0x0600BBAD RID: 48045 RVA: 0x001BEF80 File Offset: 0x001BD180
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

		// Token: 0x0600BBAE RID: 48046 RVA: 0x001BEFB9 File Offset: 0x001BD1B9
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

		// Token: 0x0600BBAF RID: 48047 RVA: 0x001BEFE7 File Offset: 0x001BD1E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BBB0 RID: 48048 RVA: 0x001BEFF0 File Offset: 0x001BD1F0
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
					this.itemList_.AddEntriesFrom(ref input, ItemDecomposePreviewRequest._repeated_itemList_codec);
				}
			}
		}

		// Token: 0x040052A1 RID: 21153
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052A2 RID: 21154
		public const int ItemListFieldNumber = 13;

		// Token: 0x040052A3 RID: 21155
		private static readonly FieldCodec<DecomposeItemInfo> _repeated_itemList_codec = FieldCodec.ForMessage<DecomposeItemInfo>(106U, DecomposeItemInfo.Parser);

		// Token: 0x040052A4 RID: 21156
		private readonly RepeatedField<DecomposeItemInfo> itemList_ = new RepeatedField<DecomposeItemInfo>();
	}
}
