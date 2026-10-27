using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200084E RID: 2126
	[NetMessage(EMessageId.ItemExchangeInfoResponse)]
	public sealed class ItemExchangeInfoResponse : IMessage<ItemExchangeInfoResponse>, IMessage, IEquatable<ItemExchangeInfoResponse>, IDeepCloneable<ItemExchangeInfoResponse>, IBufferMessage
	{
		// Token: 0x0600BDA9 RID: 48553 RVA: 0x001C2E06 File Offset: 0x001C1006
		[NullableContext(1)]
		public static ItemExchangeInfoResponse Create()
		{
			return new ItemExchangeInfoResponse();
		}

		// Token: 0x1700264C RID: 9804
		// (get) Token: 0x0600BDAA RID: 48554 RVA: 0x001C2E0D File Offset: 0x001C100D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700264D RID: 9805
		// (get) Token: 0x0600BDAB RID: 48555 RVA: 0x001C2E10 File Offset: 0x001C1010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemExchangeInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600BDAC RID: 48556 RVA: 0x001C2E17 File Offset: 0x001C1017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeInfoResponse()
		{
		}

		// Token: 0x0600BDAD RID: 48557 RVA: 0x001C2E2A File Offset: 0x001C102A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeInfoResponse(ItemExchangeInfoResponse other) : this()
		{
			this.itemExchangeInfos_ = other.itemExchangeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BDAE RID: 48558 RVA: 0x001C2E54 File Offset: 0x001C1054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeInfoResponse Clone()
		{
			return new ItemExchangeInfoResponse(this);
		}

		// Token: 0x1700264E RID: 9806
		// (get) Token: 0x0600BDAF RID: 48559 RVA: 0x001C2E5C File Offset: 0x001C105C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ItemExchangeInfo> ItemExchangeInfos
		{
			get
			{
				return this.itemExchangeInfos_;
			}
		}

		// Token: 0x0600BDB0 RID: 48560 RVA: 0x001C2E64 File Offset: 0x001C1064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemExchangeInfoResponse);
		}

		// Token: 0x0600BDB1 RID: 48561 RVA: 0x001C2E72 File Offset: 0x001C1072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemExchangeInfoResponse other)
		{
			return other != null && (other == this || (this.itemExchangeInfos_.Equals(other.itemExchangeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BDB2 RID: 48562 RVA: 0x001C2EA8 File Offset: 0x001C10A8
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

		// Token: 0x0600BDB3 RID: 48563 RVA: 0x001C2EDC File Offset: 0x001C10DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BDB4 RID: 48564 RVA: 0x001C2EE9 File Offset: 0x001C10E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BDB5 RID: 48565 RVA: 0x001C2EF2 File Offset: 0x001C10F2
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

		// Token: 0x0600BDB6 RID: 48566 RVA: 0x001C2F1C File Offset: 0x001C111C
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

		// Token: 0x0600BDB7 RID: 48567 RVA: 0x001C2F55 File Offset: 0x001C1155
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

		// Token: 0x0600BDB8 RID: 48568 RVA: 0x001C2F83 File Offset: 0x001C1183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BDB9 RID: 48569 RVA: 0x001C2F8C File Offset: 0x001C118C
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.itemExchangeInfos_.AddEntriesFrom(ref input, ItemExchangeInfoResponse._repeated_itemExchangeInfos_codec);
				}
			}
		}

		// Token: 0x040052D6 RID: 21206
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052D7 RID: 21207
		public const int ItemExchangeInfosFieldNumber = 10;

		// Token: 0x040052D8 RID: 21208
		private static readonly FieldCodec<ItemExchangeInfo> _repeated_itemExchangeInfos_codec = FieldCodec.ForMessage<ItemExchangeInfo>(82U, ItemExchangeInfo.Parser);

		// Token: 0x040052D9 RID: 21209
		private readonly RepeatedField<ItemExchangeInfo> itemExchangeInfos_ = new RepeatedField<ItemExchangeInfo>();
	}
}
