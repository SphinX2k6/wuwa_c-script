using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004DA RID: 1242
	public sealed class ExpireConvertTargetItemInfo : IMessage<ExpireConvertTargetItemInfo>, IMessage, IEquatable<ExpireConvertTargetItemInfo>, IDeepCloneable<ExpireConvertTargetItemInfo>, IBufferMessage
	{
		// Token: 0x06007602 RID: 30210 RVA: 0x001209D8 File Offset: 0x0011EBD8
		[NullableContext(1)]
		public static ExpireConvertTargetItemInfo Create()
		{
			return new ExpireConvertTargetItemInfo();
		}

		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x06007603 RID: 30211 RVA: 0x001209DF File Offset: 0x0011EBDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExpireConvertTargetItemInfo> Parser
		{
			get
			{
				return ExpireConvertTargetItemInfo._parser;
			}
		}

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x06007604 RID: 30212 RVA: 0x001209E6 File Offset: 0x0011EBE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x06007605 RID: 30213 RVA: 0x001209E9 File Offset: 0x0011EBE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExpireConvertTargetItemInfo.Descriptor;
			}
		}

		// Token: 0x06007606 RID: 30214 RVA: 0x001209F0 File Offset: 0x0011EBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpireConvertTargetItemInfo()
		{
		}

		// Token: 0x06007607 RID: 30215 RVA: 0x001209F8 File Offset: 0x0011EBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpireConvertTargetItemInfo(ExpireConvertTargetItemInfo other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007608 RID: 30216 RVA: 0x00120A29 File Offset: 0x0011EC29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExpireConvertTargetItemInfo Clone()
		{
			return new ExpireConvertTargetItemInfo(this);
		}

		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x06007609 RID: 30217 RVA: 0x00120A31 File Offset: 0x0011EC31
		// (set) Token: 0x0600760A RID: 30218 RVA: 0x00120A39 File Offset: 0x0011EC39
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

		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x0600760B RID: 30219 RVA: 0x00120A42 File Offset: 0x0011EC42
		// (set) Token: 0x0600760C RID: 30220 RVA: 0x00120A4A File Offset: 0x0011EC4A
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

		// Token: 0x0600760D RID: 30221 RVA: 0x00120A53 File Offset: 0x0011EC53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExpireConvertTargetItemInfo);
		}

		// Token: 0x0600760E RID: 30222 RVA: 0x00120A61 File Offset: 0x0011EC61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExpireConvertTargetItemInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600760F RID: 30223 RVA: 0x00120AA0 File Offset: 0x0011ECA0
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

		// Token: 0x06007610 RID: 30224 RVA: 0x00120AF8 File Offset: 0x0011ECF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007611 RID: 30225 RVA: 0x00120B05 File Offset: 0x0011ED05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007612 RID: 30226 RVA: 0x00120B10 File Offset: 0x0011ED10
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

		// Token: 0x06007613 RID: 30227 RVA: 0x00120B68 File Offset: 0x0011ED68
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

		// Token: 0x06007614 RID: 30228 RVA: 0x00120BC0 File Offset: 0x0011EDC0
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

		// Token: 0x06007615 RID: 30229 RVA: 0x00120C10 File Offset: 0x0011EE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007616 RID: 30230 RVA: 0x00120C1C File Offset: 0x0011EE1C
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

		// Token: 0x04003E22 RID: 15906
		private static readonly MessageParser<ExpireConvertTargetItemInfo> _parser = new MessageParser<ExpireConvertTargetItemInfo>(() => new ExpireConvertTargetItemInfo());

		// Token: 0x04003E23 RID: 15907
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E24 RID: 15908
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04003E25 RID: 15909
		private int itemId_;

		// Token: 0x04003E26 RID: 15910
		public const int ItemCountFieldNumber = 2;

		// Token: 0x04003E27 RID: 15911
		private int itemCount_;
	}
}
