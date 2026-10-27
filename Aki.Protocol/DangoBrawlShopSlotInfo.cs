using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000378 RID: 888
	public sealed class DangoBrawlShopSlotInfo : IMessage<DangoBrawlShopSlotInfo>, IMessage, IEquatable<DangoBrawlShopSlotInfo>, IDeepCloneable<DangoBrawlShopSlotInfo>, IBufferMessage
	{
		// Token: 0x06005828 RID: 22568 RVA: 0x000D7149 File Offset: 0x000D5349
		[NullableContext(1)]
		public static DangoBrawlShopSlotInfo Create()
		{
			return new DangoBrawlShopSlotInfo();
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x06005829 RID: 22569 RVA: 0x000D7150 File Offset: 0x000D5350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoBrawlShopSlotInfo> Parser
		{
			get
			{
				return DangoBrawlShopSlotInfo._parser;
			}
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x0600582A RID: 22570 RVA: 0x000D7157 File Offset: 0x000D5357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x0600582B RID: 22571 RVA: 0x000D715A File Offset: 0x000D535A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopSlotInfo.Descriptor;
			}
		}

		// Token: 0x0600582C RID: 22572 RVA: 0x000D7161 File Offset: 0x000D5361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopSlotInfo()
		{
		}

		// Token: 0x0600582D RID: 22573 RVA: 0x000D716C File Offset: 0x000D536C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopSlotInfo(DangoBrawlShopSlotInfo other) : this()
		{
			this.item_ = ((other.item_ != null) ? other.item_.Clone() : null);
			this.locked_ = other.locked_;
			this.price_ = other.price_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600582E RID: 22574 RVA: 0x000D71C4 File Offset: 0x000D53C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopSlotInfo Clone()
		{
			return new DangoBrawlShopSlotInfo(this);
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x0600582F RID: 22575 RVA: 0x000D71CC File Offset: 0x000D53CC
		// (set) Token: 0x06005830 RID: 22576 RVA: 0x000D71D4 File Offset: 0x000D53D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBaseItemInfo Item
		{
			get
			{
				return this.item_;
			}
			set
			{
				this.item_ = value;
			}
		}

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x06005831 RID: 22577 RVA: 0x000D71DD File Offset: 0x000D53DD
		// (set) Token: 0x06005832 RID: 22578 RVA: 0x000D71E5 File Offset: 0x000D53E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Locked
		{
			get
			{
				return this.locked_;
			}
			set
			{
				this.locked_ = value;
			}
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x06005833 RID: 22579 RVA: 0x000D71EE File Offset: 0x000D53EE
		// (set) Token: 0x06005834 RID: 22580 RVA: 0x000D71F6 File Offset: 0x000D53F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Price
		{
			get
			{
				return this.price_;
			}
			set
			{
				this.price_ = value;
			}
		}

		// Token: 0x06005835 RID: 22581 RVA: 0x000D71FF File Offset: 0x000D53FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopSlotInfo);
		}

		// Token: 0x06005836 RID: 22582 RVA: 0x000D7210 File Offset: 0x000D5410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopSlotInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Item, other.Item) && this.Locked == other.Locked && this.Price == other.Price && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005837 RID: 22583 RVA: 0x000D7270 File Offset: 0x000D5470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.item_ != null)
			{
				num ^= this.Item.GetHashCode();
			}
			if (this.Locked)
			{
				num ^= this.Locked.GetHashCode();
			}
			if (this.Price != 0)
			{
				num ^= this.Price.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005838 RID: 22584 RVA: 0x000D72DE File Offset: 0x000D54DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005839 RID: 22585 RVA: 0x000D72EB File Offset: 0x000D54EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600583A RID: 22586 RVA: 0x000D72F4 File Offset: 0x000D54F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.item_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Item);
			}
			if (this.Locked)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Locked);
			}
			if (this.Price != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Price);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600583B RID: 22587 RVA: 0x000D736C File Offset: 0x000D556C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.item_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Item);
			}
			if (this.Locked)
			{
				num += 2;
			}
			if (this.Price != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Price);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600583C RID: 22588 RVA: 0x000D73D0 File Offset: 0x000D55D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlShopSlotInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.item_ != null)
			{
				if (this.item_ == null)
				{
					this.Item = new DangoBrawlBaseItemInfo();
				}
				this.Item.MergeFrom(other.Item);
			}
			if (other.Locked)
			{
				this.Locked = other.Locked;
			}
			if (other.Price != 0)
			{
				this.Price = other.Price;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600583D RID: 22589 RVA: 0x000D744C File Offset: 0x000D564C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600583E RID: 22590 RVA: 0x000D7458 File Offset: 0x000D5658
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Price = input.ReadInt32();
						}
					}
					else
					{
						this.Locked = input.ReadBool();
					}
				}
				else
				{
					if (this.item_ == null)
					{
						this.Item = new DangoBrawlBaseItemInfo();
					}
					input.ReadMessage(this.Item);
				}
			}
		}

		// Token: 0x04003502 RID: 13570
		private static readonly MessageParser<DangoBrawlShopSlotInfo> _parser = new MessageParser<DangoBrawlShopSlotInfo>(() => new DangoBrawlShopSlotInfo());

		// Token: 0x04003503 RID: 13571
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003504 RID: 13572
		public const int ItemFieldNumber = 1;

		// Token: 0x04003505 RID: 13573
		private DangoBrawlBaseItemInfo item_;

		// Token: 0x04003506 RID: 13574
		public const int LockedFieldNumber = 2;

		// Token: 0x04003507 RID: 13575
		private bool locked_;

		// Token: 0x04003508 RID: 13576
		public const int PriceFieldNumber = 3;

		// Token: 0x04003509 RID: 13577
		private int price_;
	}
}
