using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001231 RID: 4657
	public sealed class SingleItemInfo : IMessage<SingleItemInfo>, IMessage, IEquatable<SingleItemInfo>, IDeepCloneable<SingleItemInfo>, IBufferMessage
	{
		// Token: 0x06018D15 RID: 101653 RVA: 0x0039C7A5 File Offset: 0x0039A9A5
		[NullableContext(1)]
		public static SingleItemInfo Create()
		{
			return new SingleItemInfo();
		}

		// Token: 0x170053A8 RID: 21416
		// (get) Token: 0x06018D16 RID: 101654 RVA: 0x0039C7AC File Offset: 0x0039A9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SingleItemInfo> Parser
		{
			get
			{
				return SingleItemInfo._parser;
			}
		}

		// Token: 0x170053A9 RID: 21417
		// (get) Token: 0x06018D17 RID: 101655 RVA: 0x0039C7B3 File Offset: 0x0039A9B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053AA RID: 21418
		// (get) Token: 0x06018D18 RID: 101656 RVA: 0x0039C7B6 File Offset: 0x0039A9B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SingleItemInfo.Descriptor;
			}
		}

		// Token: 0x06018D19 RID: 101657 RVA: 0x0039C7BD File Offset: 0x0039A9BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleItemInfo()
		{
		}

		// Token: 0x06018D1A RID: 101658 RVA: 0x0039C7C5 File Offset: 0x0039A9C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleItemInfo(SingleItemInfo other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemNum_ = other.itemNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018D1B RID: 101659 RVA: 0x0039C7F6 File Offset: 0x0039A9F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleItemInfo Clone()
		{
			return new SingleItemInfo(this);
		}

		// Token: 0x170053AB RID: 21419
		// (get) Token: 0x06018D1C RID: 101660 RVA: 0x0039C7FE File Offset: 0x0039A9FE
		// (set) Token: 0x06018D1D RID: 101661 RVA: 0x0039C806 File Offset: 0x0039AA06
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

		// Token: 0x170053AC RID: 21420
		// (get) Token: 0x06018D1E RID: 101662 RVA: 0x0039C80F File Offset: 0x0039AA0F
		// (set) Token: 0x06018D1F RID: 101663 RVA: 0x0039C817 File Offset: 0x0039AA17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemNum
		{
			get
			{
				return this.itemNum_;
			}
			set
			{
				this.itemNum_ = value;
			}
		}

		// Token: 0x06018D20 RID: 101664 RVA: 0x0039C820 File Offset: 0x0039AA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SingleItemInfo);
		}

		// Token: 0x06018D21 RID: 101665 RVA: 0x0039C82E File Offset: 0x0039AA2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SingleItemInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemNum == other.ItemNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018D22 RID: 101666 RVA: 0x0039C86C File Offset: 0x0039AA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemNum != 0)
			{
				num ^= this.ItemNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018D23 RID: 101667 RVA: 0x0039C8C4 File Offset: 0x0039AAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018D24 RID: 101668 RVA: 0x0039C8D1 File Offset: 0x0039AAD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018D25 RID: 101669 RVA: 0x0039C8DC File Offset: 0x0039AADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018D26 RID: 101670 RVA: 0x0039C934 File Offset: 0x0039AB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018D27 RID: 101671 RVA: 0x0039C98C File Offset: 0x0039AB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SingleItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemNum != 0)
			{
				this.ItemNum = other.ItemNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018D28 RID: 101672 RVA: 0x0039C9DC File Offset: 0x0039ABDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018D29 RID: 101673 RVA: 0x0039C9E8 File Offset: 0x0039ABE8
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
						this.ItemNum = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009268 RID: 37480
		private static readonly MessageParser<SingleItemInfo> _parser = new MessageParser<SingleItemInfo>(() => new SingleItemInfo());

		// Token: 0x04009269 RID: 37481
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400926A RID: 37482
		public const int ItemIdFieldNumber = 1;

		// Token: 0x0400926B RID: 37483
		private int itemId_;

		// Token: 0x0400926C RID: 37484
		public const int ItemNumFieldNumber = 2;

		// Token: 0x0400926D RID: 37485
		private int itemNum_;
	}
}
