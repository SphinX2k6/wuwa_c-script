using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000827 RID: 2087
	public sealed class InvalidItem : IMessage<InvalidItem>, IMessage, IEquatable<InvalidItem>, IDeepCloneable<InvalidItem>, IBufferMessage
	{
		// Token: 0x0600BAD4 RID: 47828 RVA: 0x001BD443 File Offset: 0x001BB643
		[NullableContext(1)]
		public static InvalidItem Create()
		{
			return new InvalidItem();
		}

		// Token: 0x170025B4 RID: 9652
		// (get) Token: 0x0600BAD5 RID: 47829 RVA: 0x001BD44A File Offset: 0x001BB64A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InvalidItem> Parser
		{
			get
			{
				return InvalidItem._parser;
			}
		}

		// Token: 0x170025B5 RID: 9653
		// (get) Token: 0x0600BAD6 RID: 47830 RVA: 0x001BD451 File Offset: 0x001BB651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025B6 RID: 9654
		// (get) Token: 0x0600BAD7 RID: 47831 RVA: 0x001BD454 File Offset: 0x001BB654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvalidItem.Descriptor;
			}
		}

		// Token: 0x0600BAD8 RID: 47832 RVA: 0x001BD45B File Offset: 0x001BB65B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvalidItem()
		{
		}

		// Token: 0x0600BAD9 RID: 47833 RVA: 0x001BD463 File Offset: 0x001BB663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvalidItem(InvalidItem other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this.incrId_ = other.incrId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BADA RID: 47834 RVA: 0x001BD4A0 File Offset: 0x001BB6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvalidItem Clone()
		{
			return new InvalidItem(this);
		}

		// Token: 0x170025B7 RID: 9655
		// (get) Token: 0x0600BADB RID: 47835 RVA: 0x001BD4A8 File Offset: 0x001BB6A8
		// (set) Token: 0x0600BADC RID: 47836 RVA: 0x001BD4B0 File Offset: 0x001BB6B0
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

		// Token: 0x170025B8 RID: 9656
		// (get) Token: 0x0600BADD RID: 47837 RVA: 0x001BD4B9 File Offset: 0x001BB6B9
		// (set) Token: 0x0600BADE RID: 47838 RVA: 0x001BD4C1 File Offset: 0x001BB6C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x170025B9 RID: 9657
		// (get) Token: 0x0600BADF RID: 47839 RVA: 0x001BD4CA File Offset: 0x001BB6CA
		// (set) Token: 0x0600BAE0 RID: 47840 RVA: 0x001BD4D2 File Offset: 0x001BB6D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x0600BAE1 RID: 47841 RVA: 0x001BD4DB File Offset: 0x001BB6DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InvalidItem);
		}

		// Token: 0x0600BAE2 RID: 47842 RVA: 0x001BD4EC File Offset: 0x001BB6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InvalidItem other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && this.IncrId == other.IncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BAE3 RID: 47843 RVA: 0x001BD548 File Offset: 0x001BB748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BAE4 RID: 47844 RVA: 0x001BD5B9 File Offset: 0x001BB7B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BAE5 RID: 47845 RVA: 0x001BD5C6 File Offset: 0x001BB7C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BAE6 RID: 47846 RVA: 0x001BD5D0 File Offset: 0x001BB7D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BAE7 RID: 47847 RVA: 0x001BD644 File Offset: 0x001BB844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BAE8 RID: 47848 RVA: 0x001BD6B4 File Offset: 0x001BB8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InvalidItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BAE9 RID: 47849 RVA: 0x001BD718 File Offset: 0x001BB918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BAEA RID: 47850 RVA: 0x001BD724 File Offset: 0x001BB924
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IncrId = input.ReadInt32();
						}
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400526C RID: 21100
		private static readonly MessageParser<InvalidItem> _parser = new MessageParser<InvalidItem>(() => new InvalidItem());

		// Token: 0x0400526D RID: 21101
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400526E RID: 21102
		public const int ItemIdFieldNumber = 1;

		// Token: 0x0400526F RID: 21103
		private int itemId_;

		// Token: 0x04005270 RID: 21104
		public const int CountFieldNumber = 2;

		// Token: 0x04005271 RID: 21105
		private int count_;

		// Token: 0x04005272 RID: 21106
		public const int IncrIdFieldNumber = 3;

		// Token: 0x04005273 RID: 21107
		private int incrId_;
	}
}
