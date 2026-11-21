using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200083C RID: 2108
	[NetMessage(EMessageId.ItemExchangeInfoResponse)]
	public sealed class ItemExchangeInfoResponse : IMessage<ItemExchangeInfoResponse>, IMessage, IEquatable<ItemExchangeInfoResponse>, IDeepCloneable<ItemExchangeInfoResponse>, IBufferMessage
	{
		// Token: 0x0600BC7B RID: 48251 RVA: 0x001C0932 File Offset: 0x001BEB32
		[NullableContext(1)]
		public static ItemExchangeInfoResponse Create()
		{
			return new ItemExchangeInfoResponse();
		}

		// Token: 0x1700260A RID: 9738
		// (get) Token: 0x0600BC7C RID: 48252 RVA: 0x001C0939 File Offset: 0x001BEB39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700260B RID: 9739
		// (get) Token: 0x0600BC7D RID: 48253 RVA: 0x001C093C File Offset: 0x001BEB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemExchangeInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600BC7E RID: 48254 RVA: 0x001C0943 File Offset: 0x001BEB43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeInfoResponse()
		{
		}

		// Token: 0x0600BC7F RID: 48255 RVA: 0x001C0956 File Offset: 0x001BEB56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeInfoResponse(ItemExchangeInfoResponse other) : this()
		{
			this.itemExchangeInfos_ = other.itemExchangeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BC80 RID: 48256 RVA: 0x001C0980 File Offset: 0x001BEB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeInfoResponse Clone()
		{
			return new ItemExchangeInfoResponse(this);
		}

		// Token: 0x1700260C RID: 9740
		// (get) Token: 0x0600BC81 RID: 48257 RVA: 0x001C0988 File Offset: 0x001BEB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ItemExchangeInfo> ItemExchangeInfos
		{
			get
			{
				return this.itemExchangeInfos_;
			}
		}

		// Token: 0x0600BC82 RID: 48258 RVA: 0x001C0990 File Offset: 0x001BEB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemExchangeInfoResponse);
		}

		// Token: 0x0600BC83 RID: 48259 RVA: 0x001C099E File Offset: 0x001BEB9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemExchangeInfoResponse other)
		{
			return other != null && (other == this || (this.itemExchangeInfos_.Equals(other.itemExchangeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BC84 RID: 48260 RVA: 0x001C09D4 File Offset: 0x001BEBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemExchangeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BC85 RID: 48261 RVA: 0x001C0A08 File Offset: 0x001BEC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BC86 RID: 48262 RVA: 0x001C0A15 File Offset: 0x001BEC15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BC87 RID: 48263 RVA: 0x001C0A1E File Offset: 0x001BEC1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemExchangeInfos_.WriteTo(ref output, ItemExchangeInfoResponse._repeated_itemExchangeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BC88 RID: 48264 RVA: 0x001C0A48 File Offset: 0x001BEC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemExchangeInfos_.CalculateSize(ItemExchangeInfoResponse._repeated_itemExchangeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BC89 RID: 48265 RVA: 0x001C0A81 File Offset: 0x001BEC81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemExchangeInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.itemExchangeInfos_.Add(other.itemExchangeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BC8A RID: 48266 RVA: 0x001C0AAF File Offset: 0x001BECAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BC8B RID: 48267 RVA: 0x001C0AB8 File Offset: 0x001BECB8
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.itemExchangeInfos_.AddEntriesFrom(ref input, ItemExchangeInfoResponse._repeated_itemExchangeInfos_codec);
				}
			}
		}

		// Token: 0x040052D9 RID: 21209
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052DA RID: 21210
		public const int ItemExchangeInfosFieldNumber = 7;

		// Token: 0x040052DB RID: 21211
		private static readonly FieldCodec<ItemExchangeInfo> _repeated_itemExchangeInfos_codec = FieldCodec.ForMessage<ItemExchangeInfo>(58U, ItemExchangeInfo.Parser);

		// Token: 0x040052DC RID: 21212
		private readonly RepeatedField<ItemExchangeInfo> itemExchangeInfos_ = new RepeatedField<ItemExchangeInfo>();
	}
}
