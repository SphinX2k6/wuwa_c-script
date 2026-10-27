using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200084F RID: 2127
	[NetMessage(EMessageId.ItemExchangeRequest)]
	public sealed class ItemExchangeRequest : IMessage<ItemExchangeRequest>, IMessage, IEquatable<ItemExchangeRequest>, IDeepCloneable<ItemExchangeRequest>, IBufferMessage
	{
		// Token: 0x0600BDBB RID: 48571 RVA: 0x001C2FE9 File Offset: 0x001C11E9
		[NullableContext(1)]
		public static ItemExchangeRequest Create()
		{
			return new ItemExchangeRequest();
		}

		// Token: 0x1700264F RID: 9807
		// (get) Token: 0x0600BDBC RID: 48572 RVA: 0x001C2FF0 File Offset: 0x001C11F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002650 RID: 9808
		// (get) Token: 0x0600BDBD RID: 48573 RVA: 0x001C2FF3 File Offset: 0x001C11F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemExchangeRequest.Descriptor;
			}
		}

		// Token: 0x0600BDBE RID: 48574 RVA: 0x001C2FFA File Offset: 0x001C11FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeRequest()
		{
		}

		// Token: 0x0600BDBF RID: 48575 RVA: 0x001C3002 File Offset: 0x001C1202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeRequest(ItemExchangeRequest other) : this()
		{
			this.itemId_ = other.itemId_;
			this.exchangeTimes_ = other.exchangeTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BDC0 RID: 48576 RVA: 0x001C3033 File Offset: 0x001C1233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemExchangeRequest Clone()
		{
			return new ItemExchangeRequest(this);
		}

		// Token: 0x17002651 RID: 9809
		// (get) Token: 0x0600BDC1 RID: 48577 RVA: 0x001C303B File Offset: 0x001C123B
		// (set) Token: 0x0600BDC2 RID: 48578 RVA: 0x001C3043 File Offset: 0x001C1243
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

		// Token: 0x17002652 RID: 9810
		// (get) Token: 0x0600BDC3 RID: 48579 RVA: 0x001C304C File Offset: 0x001C124C
		// (set) Token: 0x0600BDC4 RID: 48580 RVA: 0x001C3054 File Offset: 0x001C1254
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

		// Token: 0x0600BDC5 RID: 48581 RVA: 0x001C305D File Offset: 0x001C125D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemExchangeRequest);
		}

		// Token: 0x0600BDC6 RID: 48582 RVA: 0x001C306B File Offset: 0x001C126B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemExchangeRequest other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ExchangeTimes == other.ExchangeTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BDC7 RID: 48583 RVA: 0x001C30AC File Offset: 0x001C12AC
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

		// Token: 0x0600BDC8 RID: 48584 RVA: 0x001C3104 File Offset: 0x001C1304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BDC9 RID: 48585 RVA: 0x001C3111 File Offset: 0x001C1311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BDCA RID: 48586 RVA: 0x001C311C File Offset: 0x001C131C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ItemId);
			}
			if (this.ExchangeTimes != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ExchangeTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BDCB RID: 48587 RVA: 0x001C3178 File Offset: 0x001C1378
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

		// Token: 0x0600BDCC RID: 48588 RVA: 0x001C31D0 File Offset: 0x001C13D0
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

		// Token: 0x0600BDCD RID: 48589 RVA: 0x001C3220 File Offset: 0x001C1420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BDCE RID: 48590 RVA: 0x001C322C File Offset: 0x001C142C
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
				if (num != 32U)
				{
					if (num != 96U)
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

		// Token: 0x040052DA RID: 21210
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052DB RID: 21211
		public const int ItemIdFieldNumber = 4;

		// Token: 0x040052DC RID: 21212
		private int itemId_;

		// Token: 0x040052DD RID: 21213
		public const int ExchangeTimesFieldNumber = 12;

		// Token: 0x040052DE RID: 21214
		private int exchangeTimes_;
	}
}
