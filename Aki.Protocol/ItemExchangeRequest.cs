using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200083D RID: 2109
	[NetMessage(EMessageId.ItemExchangeRequest)]
	public sealed class ItemExchangeRequest : IMessage<ItemExchangeRequest>, IMessage, IEquatable<ItemExchangeRequest>, IDeepCloneable<ItemExchangeRequest>, IBufferMessage
	{
		// Token: 0x0600BC8D RID: 48269 RVA: 0x001C0B15 File Offset: 0x001BED15
		[NullableContext(1)]
		public static ItemExchangeRequest Create()
		{
			return new ItemExchangeRequest();
		}

		// Token: 0x1700260D RID: 9741
		// (get) Token: 0x0600BC8E RID: 48270 RVA: 0x001C0B1C File Offset: 0x001BED1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700260E RID: 9742
		// (get) Token: 0x0600BC8F RID: 48271 RVA: 0x001C0B1F File Offset: 0x001BED1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemExchangeRequest.Descriptor;
			}
		}

		// Token: 0x0600BC90 RID: 48272 RVA: 0x001C0B26 File Offset: 0x001BED26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeRequest()
		{
		}

		// Token: 0x0600BC91 RID: 48273 RVA: 0x001C0B2E File Offset: 0x001BED2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeRequest(ItemExchangeRequest other) : this()
		{
			this.itemId_ = other.itemId_;
			this.exchangeTimes_ = other.exchangeTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BC92 RID: 48274 RVA: 0x001C0B5F File Offset: 0x001BED5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeRequest Clone()
		{
			return new ItemExchangeRequest(this);
		}

		// Token: 0x1700260F RID: 9743
		// (get) Token: 0x0600BC93 RID: 48275 RVA: 0x001C0B67 File Offset: 0x001BED67
		// (set) Token: 0x0600BC94 RID: 48276 RVA: 0x001C0B6F File Offset: 0x001BED6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17002610 RID: 9744
		// (get) Token: 0x0600BC95 RID: 48277 RVA: 0x001C0B78 File Offset: 0x001BED78
		// (set) Token: 0x0600BC96 RID: 48278 RVA: 0x001C0B80 File Offset: 0x001BED80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExchangeTimes
		{
			get
			{
				return this.exchangeTimes_;
			}
			set
			{
				this.exchangeTimes_ = value;
			}
		}

		// Token: 0x0600BC97 RID: 48279 RVA: 0x001C0B89 File Offset: 0x001BED89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemExchangeRequest);
		}

		// Token: 0x0600BC98 RID: 48280 RVA: 0x001C0B97 File Offset: 0x001BED97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemExchangeRequest other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ExchangeTimes == other.ExchangeTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BC99 RID: 48281 RVA: 0x001C0BD8 File Offset: 0x001BEDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ExchangeTimes != 0)
			{
				num ^= this.ExchangeTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BC9A RID: 48282 RVA: 0x001C0C30 File Offset: 0x001BEE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BC9B RID: 48283 RVA: 0x001C0C3D File Offset: 0x001BEE3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BC9C RID: 48284 RVA: 0x001C0C48 File Offset: 0x001BEE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ItemId);
			}
			if (this.ExchangeTimes != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ExchangeTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BC9D RID: 48285 RVA: 0x001C0CA4 File Offset: 0x001BEEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ExchangeTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExchangeTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BC9E RID: 48286 RVA: 0x001C0CFC File Offset: 0x001BEEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemExchangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ExchangeTimes != 0)
			{
				this.ExchangeTimes = other.ExchangeTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BC9F RID: 48287 RVA: 0x001C0D4C File Offset: 0x001BEF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BCA0 RID: 48288 RVA: 0x001C0D58 File Offset: 0x001BEF58
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
				if (num != 64U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ExchangeTimes = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040052DD RID: 21213
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052DE RID: 21214
		public const int ItemIdFieldNumber = 8;

		// Token: 0x040052DF RID: 21215
		private int itemId_;

		// Token: 0x040052E0 RID: 21216
		public const int ExchangeTimesFieldNumber = 14;

		// Token: 0x040052E1 RID: 21217
		private int exchangeTimes_;
	}
}
