using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CFB RID: 3323
	public sealed class PhantomStackSplitInfo : IMessage<PhantomStackSplitInfo>, IMessage, IEquatable<PhantomStackSplitInfo>, IDeepCloneable<PhantomStackSplitInfo>, IBufferMessage
	{
		// Token: 0x06011FB5 RID: 73653 RVA: 0x002A154E File Offset: 0x0029F74E
		[NullableContext(1)]
		public static PhantomStackSplitInfo Create()
		{
			return new PhantomStackSplitInfo();
		}

		// Token: 0x17003B93 RID: 15251
		// (get) Token: 0x06011FB6 RID: 73654 RVA: 0x002A1555 File Offset: 0x0029F755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomStackSplitInfo> Parser
		{
			get
			{
				return PhantomStackSplitInfo._parser;
			}
		}

		// Token: 0x17003B94 RID: 15252
		// (get) Token: 0x06011FB7 RID: 73655 RVA: 0x002A155C File Offset: 0x0029F75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B95 RID: 15253
		// (get) Token: 0x06011FB8 RID: 73656 RVA: 0x002A155F File Offset: 0x0029F75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomStackSplitInfo.Descriptor;
			}
		}

		// Token: 0x06011FB9 RID: 73657 RVA: 0x002A1566 File Offset: 0x0029F766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomStackSplitInfo()
		{
		}

		// Token: 0x06011FBA RID: 73658 RVA: 0x002A1570 File Offset: 0x0029F770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomStackSplitInfo(PhantomStackSplitInfo other) : this()
		{
			this.operateItem_ = ((other.operateItem_ != null) ? other.operateItem_.Clone() : null);
			this.operateBeforeCount_ = other.operateBeforeCount_;
			this.remainderItem_ = ((other.remainderItem_ != null) ? other.remainderItem_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011FBB RID: 73659 RVA: 0x002A15D8 File Offset: 0x0029F7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomStackSplitInfo Clone()
		{
			return new PhantomStackSplitInfo(this);
		}

		// Token: 0x17003B96 RID: 15254
		// (get) Token: 0x06011FBC RID: 73660 RVA: 0x002A15E0 File Offset: 0x0029F7E0
		// (set) Token: 0x06011FBD RID: 73661 RVA: 0x002A15E8 File Offset: 0x0029F7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItem OperateItem
		{
			get
			{
				return this.operateItem_;
			}
			set
			{
				this.operateItem_ = value;
			}
		}

		// Token: 0x17003B97 RID: 15255
		// (get) Token: 0x06011FBE RID: 73662 RVA: 0x002A15F1 File Offset: 0x0029F7F1
		// (set) Token: 0x06011FBF RID: 73663 RVA: 0x002A15F9 File Offset: 0x0029F7F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OperateBeforeCount
		{
			get
			{
				return this.operateBeforeCount_;
			}
			set
			{
				this.operateBeforeCount_ = value;
			}
		}

		// Token: 0x17003B98 RID: 15256
		// (get) Token: 0x06011FC0 RID: 73664 RVA: 0x002A1602 File Offset: 0x0029F802
		// (set) Token: 0x06011FC1 RID: 73665 RVA: 0x002A160A File Offset: 0x0029F80A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItem RemainderItem
		{
			get
			{
				return this.remainderItem_;
			}
			set
			{
				this.remainderItem_ = value;
			}
		}

		// Token: 0x06011FC2 RID: 73666 RVA: 0x002A1613 File Offset: 0x0029F813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomStackSplitInfo);
		}

		// Token: 0x06011FC3 RID: 73667 RVA: 0x002A1624 File Offset: 0x0029F824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomStackSplitInfo other)
		{
			return other != null && (other == this || (object.Equals(this.OperateItem, other.OperateItem) && this.OperateBeforeCount == other.OperateBeforeCount && object.Equals(this.RemainderItem, other.RemainderItem) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011FC4 RID: 73668 RVA: 0x002A1688 File Offset: 0x0029F888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.operateItem_ != null)
			{
				num ^= this.OperateItem.GetHashCode();
			}
			if (this.OperateBeforeCount != 0)
			{
				num ^= this.OperateBeforeCount.GetHashCode();
			}
			if (this.remainderItem_ != null)
			{
				num ^= this.RemainderItem.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011FC5 RID: 73669 RVA: 0x002A16F3 File Offset: 0x0029F8F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011FC6 RID: 73670 RVA: 0x002A1700 File Offset: 0x0029F900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011FC7 RID: 73671 RVA: 0x002A170C File Offset: 0x0029F90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.operateItem_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.OperateItem);
			}
			if (this.OperateBeforeCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.OperateBeforeCount);
			}
			if (this.remainderItem_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RemainderItem);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011FC8 RID: 73672 RVA: 0x002A1784 File Offset: 0x0029F984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.operateItem_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OperateItem);
			}
			if (this.OperateBeforeCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OperateBeforeCount);
			}
			if (this.remainderItem_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RemainderItem);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011FC9 RID: 73673 RVA: 0x002A17F4 File Offset: 0x0029F9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomStackSplitInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.operateItem_ != null)
			{
				if (this.operateItem_ == null)
				{
					this.OperateItem = new PhantomItem();
				}
				this.OperateItem.MergeFrom(other.OperateItem);
			}
			if (other.OperateBeforeCount != 0)
			{
				this.OperateBeforeCount = other.OperateBeforeCount;
			}
			if (other.remainderItem_ != null)
			{
				if (this.remainderItem_ == null)
				{
					this.RemainderItem = new PhantomItem();
				}
				this.RemainderItem.MergeFrom(other.RemainderItem);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011FCA RID: 73674 RVA: 0x002A1888 File Offset: 0x0029FA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011FCB RID: 73675 RVA: 0x002A1894 File Offset: 0x0029FA94
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.remainderItem_ == null)
							{
								this.RemainderItem = new PhantomItem();
							}
							input.ReadMessage(this.RemainderItem);
						}
					}
					else
					{
						this.OperateBeforeCount = input.ReadInt32();
					}
				}
				else
				{
					if (this.operateItem_ == null)
					{
						this.OperateItem = new PhantomItem();
					}
					input.ReadMessage(this.OperateItem);
				}
			}
		}

		// Token: 0x0400710A RID: 28938
		private static readonly MessageParser<PhantomStackSplitInfo> _parser = new MessageParser<PhantomStackSplitInfo>(() => new PhantomStackSplitInfo());

		// Token: 0x0400710B RID: 28939
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400710C RID: 28940
		public const int OperateItemFieldNumber = 1;

		// Token: 0x0400710D RID: 28941
		private PhantomItem operateItem_;

		// Token: 0x0400710E RID: 28942
		public const int OperateBeforeCountFieldNumber = 2;

		// Token: 0x0400710F RID: 28943
		private int operateBeforeCount_;

		// Token: 0x04007110 RID: 28944
		public const int RemainderItemFieldNumber = 3;

		// Token: 0x04007111 RID: 28945
		private PhantomItem remainderItem_;
	}
}
