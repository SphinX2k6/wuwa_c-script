using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F12 RID: 3858
	public sealed class RemoveValidTimeItem : IMessage<RemoveValidTimeItem>, IMessage, IEquatable<RemoveValidTimeItem>, IDeepCloneable<RemoveValidTimeItem>, IBufferMessage
	{
		// Token: 0x06014A7A RID: 84602 RVA: 0x002FF891 File Offset: 0x002FDA91
		[NullableContext(1)]
		public static RemoveValidTimeItem Create()
		{
			return new RemoveValidTimeItem();
		}

		// Token: 0x170044A8 RID: 17576
		// (get) Token: 0x06014A7B RID: 84603 RVA: 0x002FF898 File Offset: 0x002FDA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RemoveValidTimeItem> Parser
		{
			get
			{
				return RemoveValidTimeItem._parser;
			}
		}

		// Token: 0x170044A9 RID: 17577
		// (get) Token: 0x06014A7C RID: 84604 RVA: 0x002FF89F File Offset: 0x002FDA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044AA RID: 17578
		// (get) Token: 0x06014A7D RID: 84605 RVA: 0x002FF8A2 File Offset: 0x002FDAA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveValidTimeItem.Descriptor;
			}
		}

		// Token: 0x06014A7E RID: 84606 RVA: 0x002FF8A9 File Offset: 0x002FDAA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveValidTimeItem()
		{
		}

		// Token: 0x06014A7F RID: 84607 RVA: 0x002FF8B1 File Offset: 0x002FDAB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveValidTimeItem(RemoveValidTimeItem other) : this()
		{
			this.itemId_ = other.itemId_;
			this.incrId_ = other.incrId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014A80 RID: 84608 RVA: 0x002FF8E2 File Offset: 0x002FDAE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveValidTimeItem Clone()
		{
			return new RemoveValidTimeItem(this);
		}

		// Token: 0x170044AB RID: 17579
		// (get) Token: 0x06014A81 RID: 84609 RVA: 0x002FF8EA File Offset: 0x002FDAEA
		// (set) Token: 0x06014A82 RID: 84610 RVA: 0x002FF8F2 File Offset: 0x002FDAF2
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

		// Token: 0x170044AC RID: 17580
		// (get) Token: 0x06014A83 RID: 84611 RVA: 0x002FF8FB File Offset: 0x002FDAFB
		// (set) Token: 0x06014A84 RID: 84612 RVA: 0x002FF903 File Offset: 0x002FDB03
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

		// Token: 0x06014A85 RID: 84613 RVA: 0x002FF90C File Offset: 0x002FDB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveValidTimeItem);
		}

		// Token: 0x06014A86 RID: 84614 RVA: 0x002FF91A File Offset: 0x002FDB1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveValidTimeItem other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.IncrId == other.IncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014A87 RID: 84615 RVA: 0x002FF958 File Offset: 0x002FDB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
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

		// Token: 0x06014A88 RID: 84616 RVA: 0x002FF9B0 File Offset: 0x002FDBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014A89 RID: 84617 RVA: 0x002FF9BD File Offset: 0x002FDBBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014A8A RID: 84618 RVA: 0x002FF9C8 File Offset: 0x002FDBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014A8B RID: 84619 RVA: 0x002FFA20 File Offset: 0x002FDC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
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

		// Token: 0x06014A8C RID: 84620 RVA: 0x002FFA78 File Offset: 0x002FDC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveValidTimeItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014A8D RID: 84621 RVA: 0x002FFAC8 File Offset: 0x002FDCC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014A8E RID: 84622 RVA: 0x002FFAD4 File Offset: 0x002FDCD4
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IncrId = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007CEC RID: 31980
		private static readonly MessageParser<RemoveValidTimeItem> _parser = new MessageParser<RemoveValidTimeItem>(() => new RemoveValidTimeItem());

		// Token: 0x04007CED RID: 31981
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CEE RID: 31982
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04007CEF RID: 31983
		private int itemId_;

		// Token: 0x04007CF0 RID: 31984
		public const int IncrIdFieldNumber = 2;

		// Token: 0x04007CF1 RID: 31985
		private int incrId_;
	}
}
