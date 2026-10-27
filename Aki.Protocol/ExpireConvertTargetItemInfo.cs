using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004F0 RID: 1264
	public sealed class ExpireConvertTargetItemInfo : IMessage<ExpireConvertTargetItemInfo>, IMessage, IEquatable<ExpireConvertTargetItemInfo>, IDeepCloneable<ExpireConvertTargetItemInfo>, IBufferMessage
	{
		// Token: 0x0600777E RID: 30590 RVA: 0x00123864 File Offset: 0x00121A64
		[NullableContext(1)]
		public static ExpireConvertTargetItemInfo Create()
		{
			return new ExpireConvertTargetItemInfo();
		}

		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x0600777F RID: 30591 RVA: 0x0012386B File Offset: 0x00121A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExpireConvertTargetItemInfo> Parser
		{
			get
			{
				return ExpireConvertTargetItemInfo._parser;
			}
		}

		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x06007780 RID: 30592 RVA: 0x00123872 File Offset: 0x00121A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x06007781 RID: 30593 RVA: 0x00123875 File Offset: 0x00121A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExpireConvertTargetItemInfo.Descriptor;
			}
		}

		// Token: 0x06007782 RID: 30594 RVA: 0x0012387C File Offset: 0x00121A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpireConvertTargetItemInfo()
		{
		}

		// Token: 0x06007783 RID: 30595 RVA: 0x00123884 File Offset: 0x00121A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpireConvertTargetItemInfo(ExpireConvertTargetItemInfo other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007784 RID: 30596 RVA: 0x001238B5 File Offset: 0x00121AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpireConvertTargetItemInfo Clone()
		{
			return new ExpireConvertTargetItemInfo(this);
		}

		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x06007785 RID: 30597 RVA: 0x001238BD File Offset: 0x00121ABD
		// (set) Token: 0x06007786 RID: 30598 RVA: 0x001238C5 File Offset: 0x00121AC5
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

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x06007787 RID: 30599 RVA: 0x001238CE File Offset: 0x00121ACE
		// (set) Token: 0x06007788 RID: 30600 RVA: 0x001238D6 File Offset: 0x00121AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x06007789 RID: 30601 RVA: 0x001238DF File Offset: 0x00121ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExpireConvertTargetItemInfo);
		}

		// Token: 0x0600778A RID: 30602 RVA: 0x001238ED File Offset: 0x00121AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExpireConvertTargetItemInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600778B RID: 30603 RVA: 0x0012392C File Offset: 0x00121B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemCount != 0)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600778C RID: 30604 RVA: 0x00123984 File Offset: 0x00121B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600778D RID: 30605 RVA: 0x00123991 File Offset: 0x00121B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600778E RID: 30606 RVA: 0x0012399C File Offset: 0x00121B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600778F RID: 30607 RVA: 0x001239F4 File Offset: 0x00121BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007790 RID: 30608 RVA: 0x00123A4C File Offset: 0x00121C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExpireConvertTargetItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemCount != 0)
			{
				this.ItemCount = other.ItemCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007791 RID: 30609 RVA: 0x00123A9C File Offset: 0x00121C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007792 RID: 30610 RVA: 0x00123AA8 File Offset: 0x00121CA8
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
						this.ItemCount = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003E31 RID: 15921
		private static readonly MessageParser<ExpireConvertTargetItemInfo> _parser = new MessageParser<ExpireConvertTargetItemInfo>(() => new ExpireConvertTargetItemInfo());

		// Token: 0x04003E32 RID: 15922
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E33 RID: 15923
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04003E34 RID: 15924
		private int itemId_;

		// Token: 0x04003E35 RID: 15925
		public const int ItemCountFieldNumber = 2;

		// Token: 0x04003E36 RID: 15926
		private int itemCount_;
	}
}
