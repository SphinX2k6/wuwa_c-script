using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000380 RID: 896
	public sealed class DangoBrawlShopSlotInfo : IMessage<DangoBrawlShopSlotInfo>, IMessage, IEquatable<DangoBrawlShopSlotInfo>, IDeepCloneable<DangoBrawlShopSlotInfo>, IBufferMessage
	{
		// Token: 0x06005915 RID: 22805 RVA: 0x000D97D1 File Offset: 0x000D79D1
		[NullableContext(1)]
		public static DangoBrawlShopSlotInfo Create()
		{
			return new DangoBrawlShopSlotInfo();
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x06005916 RID: 22806 RVA: 0x000D97D8 File Offset: 0x000D79D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoBrawlShopSlotInfo> Parser
		{
			get
			{
				return DangoBrawlShopSlotInfo._parser;
			}
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x06005917 RID: 22807 RVA: 0x000D97DF File Offset: 0x000D79DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x06005918 RID: 22808 RVA: 0x000D97E2 File Offset: 0x000D79E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopSlotInfo.Descriptor;
			}
		}

		// Token: 0x06005919 RID: 22809 RVA: 0x000D97E9 File Offset: 0x000D79E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopSlotInfo()
		{
		}

		// Token: 0x0600591A RID: 22810 RVA: 0x000D97F4 File Offset: 0x000D79F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopSlotInfo(DangoBrawlShopSlotInfo other) : this()
		{
			this.item_ = ((other.item_ != null) ? other.item_.Clone() : null);
			this.locked_ = other.locked_;
			this.price_ = other.price_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600591B RID: 22811 RVA: 0x000D984C File Offset: 0x000D7A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopSlotInfo Clone()
		{
			return new DangoBrawlShopSlotInfo(this);
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x0600591C RID: 22812 RVA: 0x000D9854 File Offset: 0x000D7A54
		// (set) Token: 0x0600591D RID: 22813 RVA: 0x000D985C File Offset: 0x000D7A5C
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

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x0600591E RID: 22814 RVA: 0x000D9865 File Offset: 0x000D7A65
		// (set) Token: 0x0600591F RID: 22815 RVA: 0x000D986D File Offset: 0x000D7A6D
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

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x06005920 RID: 22816 RVA: 0x000D9876 File Offset: 0x000D7A76
		// (set) Token: 0x06005921 RID: 22817 RVA: 0x000D987E File Offset: 0x000D7A7E
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

		// Token: 0x06005922 RID: 22818 RVA: 0x000D9887 File Offset: 0x000D7A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopSlotInfo);
		}

		// Token: 0x06005923 RID: 22819 RVA: 0x000D9898 File Offset: 0x000D7A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopSlotInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Item, other.Item) && this.Locked == other.Locked && this.Price == other.Price && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005924 RID: 22820 RVA: 0x000D98F8 File Offset: 0x000D7AF8
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

		// Token: 0x06005925 RID: 22821 RVA: 0x000D9966 File Offset: 0x000D7B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005926 RID: 22822 RVA: 0x000D9973 File Offset: 0x000D7B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005927 RID: 22823 RVA: 0x000D997C File Offset: 0x000D7B7C
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

		// Token: 0x06005928 RID: 22824 RVA: 0x000D99F4 File Offset: 0x000D7BF4
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

		// Token: 0x06005929 RID: 22825 RVA: 0x000D9A58 File Offset: 0x000D7C58
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

		// Token: 0x0600592A RID: 22826 RVA: 0x000D9AD4 File Offset: 0x000D7CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600592B RID: 22827 RVA: 0x000D9AE0 File Offset: 0x000D7CE0
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

		// Token: 0x0400359E RID: 13726
		private static readonly MessageParser<DangoBrawlShopSlotInfo> _parser = new MessageParser<DangoBrawlShopSlotInfo>(() => new DangoBrawlShopSlotInfo());

		// Token: 0x0400359F RID: 13727
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035A0 RID: 13728
		public const int ItemFieldNumber = 1;

		// Token: 0x040035A1 RID: 13729
		private DangoBrawlBaseItemInfo item_;

		// Token: 0x040035A2 RID: 13730
		public const int LockedFieldNumber = 2;

		// Token: 0x040035A3 RID: 13731
		private bool locked_;

		// Token: 0x040035A4 RID: 13732
		public const int PriceFieldNumber = 3;

		// Token: 0x040035A5 RID: 13733
		private int price_;
	}
}
