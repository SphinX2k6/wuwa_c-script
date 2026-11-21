using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000835 RID: 2101
	public sealed class ItemDeltaPb : IMessage<ItemDeltaPb>, IMessage, IEquatable<ItemDeltaPb>, IDeepCloneable<ItemDeltaPb>, IBufferMessage
	{
		// Token: 0x0600BBEA RID: 48106 RVA: 0x001BF6CD File Offset: 0x001BD8CD
		[NullableContext(1)]
		public static ItemDeltaPb Create()
		{
			return new ItemDeltaPb();
		}

		// Token: 0x170025EB RID: 9707
		// (get) Token: 0x0600BBEB RID: 48107 RVA: 0x001BF6D4 File Offset: 0x001BD8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025EC RID: 9708
		// (get) Token: 0x0600BBEC RID: 48108 RVA: 0x001BF6D7 File Offset: 0x001BD8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemDeltaPb.Descriptor;
			}
		}

		// Token: 0x0600BBED RID: 48109 RVA: 0x001BF6DE File Offset: 0x001BD8DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDeltaPb()
		{
		}

		// Token: 0x0600BBEE RID: 48110 RVA: 0x001BF6E6 File Offset: 0x001BD8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDeltaPb(ItemDeltaPb other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemCost_ = other.itemCost_;
			this.itemAdd_ = other.itemAdd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BBEF RID: 48111 RVA: 0x001BF723 File Offset: 0x001BD923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDeltaPb Clone()
		{
			return new ItemDeltaPb(this);
		}

		// Token: 0x170025ED RID: 9709
		// (get) Token: 0x0600BBF0 RID: 48112 RVA: 0x001BF72B File Offset: 0x001BD92B
		// (set) Token: 0x0600BBF1 RID: 48113 RVA: 0x001BF733 File Offset: 0x001BD933
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

		// Token: 0x170025EE RID: 9710
		// (get) Token: 0x0600BBF2 RID: 48114 RVA: 0x001BF73C File Offset: 0x001BD93C
		// (set) Token: 0x0600BBF3 RID: 48115 RVA: 0x001BF744 File Offset: 0x001BD944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemCost
		{
			get
			{
				return this.itemCost_;
			}
			set
			{
				this.itemCost_ = value;
			}
		}

		// Token: 0x170025EF RID: 9711
		// (get) Token: 0x0600BBF4 RID: 48116 RVA: 0x001BF74D File Offset: 0x001BD94D
		// (set) Token: 0x0600BBF5 RID: 48117 RVA: 0x001BF755 File Offset: 0x001BD955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemAdd
		{
			get
			{
				return this.itemAdd_;
			}
			set
			{
				this.itemAdd_ = value;
			}
		}

		// Token: 0x0600BBF6 RID: 48118 RVA: 0x001BF75E File Offset: 0x001BD95E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemDeltaPb);
		}

		// Token: 0x0600BBF7 RID: 48119 RVA: 0x001BF76C File Offset: 0x001BD96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemDeltaPb other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemCost == other.ItemCost && this.ItemAdd == other.ItemAdd && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BBF8 RID: 48120 RVA: 0x001BF7C8 File Offset: 0x001BD9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemCost != 0)
			{
				num ^= this.ItemCost.GetHashCode();
			}
			if (this.ItemAdd != 0)
			{
				num ^= this.ItemAdd.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BBF9 RID: 48121 RVA: 0x001BF839 File Offset: 0x001BDA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BBFA RID: 48122 RVA: 0x001BF846 File Offset: 0x001BDA46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BBFB RID: 48123 RVA: 0x001BF850 File Offset: 0x001BDA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemCost != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemCost);
			}
			if (this.ItemAdd != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ItemAdd);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BBFC RID: 48124 RVA: 0x001BF8C4 File Offset: 0x001BDAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemCost);
			}
			if (this.ItemAdd != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemAdd);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BBFD RID: 48125 RVA: 0x001BF934 File Offset: 0x001BDB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemDeltaPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemCost != 0)
			{
				this.ItemCost = other.ItemCost;
			}
			if (other.ItemAdd != 0)
			{
				this.ItemAdd = other.ItemAdd;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BBFE RID: 48126 RVA: 0x001BF998 File Offset: 0x001BDB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BBFF RID: 48127 RVA: 0x001BF9A4 File Offset: 0x001BDBA4
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
				if (num != 8U)
				{
					if (num != 24U)
					{
						if (num != 32U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ItemAdd = input.ReadInt32();
						}
					}
					else
					{
						this.ItemCost = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040052B2 RID: 21170
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052B3 RID: 21171
		public const int ItemIdFieldNumber = 1;

		// Token: 0x040052B4 RID: 21172
		private int itemId_;

		// Token: 0x040052B5 RID: 21173
		public const int ItemCostFieldNumber = 3;

		// Token: 0x040052B6 RID: 21174
		private int itemCost_;

		// Token: 0x040052B7 RID: 21175
		public const int ItemAddFieldNumber = 4;

		// Token: 0x040052B8 RID: 21176
		private int itemAdd_;
	}
}
