using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003D7 RID: 983
	public sealed class DollGrabItemInfo : IMessage<DollGrabItemInfo>, IMessage, IEquatable<DollGrabItemInfo>, IDeepCloneable<DollGrabItemInfo>, IBufferMessage
	{
		// Token: 0x06005FF3 RID: 24563 RVA: 0x000E824D File Offset: 0x000E644D
		[NullableContext(1)]
		public static DollGrabItemInfo Create()
		{
			return new DollGrabItemInfo();
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x06005FF4 RID: 24564 RVA: 0x000E8254 File Offset: 0x000E6454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DollGrabItemInfo> Parser
		{
			get
			{
				return DollGrabItemInfo._parser;
			}
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x06005FF5 RID: 24565 RVA: 0x000E825B File Offset: 0x000E645B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x06005FF6 RID: 24566 RVA: 0x000E825E File Offset: 0x000E645E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabItemInfo.Descriptor;
			}
		}

		// Token: 0x06005FF7 RID: 24567 RVA: 0x000E8265 File Offset: 0x000E6465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabItemInfo()
		{
		}

		// Token: 0x06005FF8 RID: 24568 RVA: 0x000E826D File Offset: 0x000E646D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabItemInfo(DollGrabItemInfo other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005FF9 RID: 24569 RVA: 0x000E829E File Offset: 0x000E649E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabItemInfo Clone()
		{
			return new DollGrabItemInfo(this);
		}

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x06005FFA RID: 24570 RVA: 0x000E82A6 File Offset: 0x000E64A6
		// (set) Token: 0x06005FFB RID: 24571 RVA: 0x000E82AE File Offset: 0x000E64AE
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

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x06005FFC RID: 24572 RVA: 0x000E82B7 File Offset: 0x000E64B7
		// (set) Token: 0x06005FFD RID: 24573 RVA: 0x000E82BF File Offset: 0x000E64BF
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

		// Token: 0x06005FFE RID: 24574 RVA: 0x000E82C8 File Offset: 0x000E64C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabItemInfo);
		}

		// Token: 0x06005FFF RID: 24575 RVA: 0x000E82D6 File Offset: 0x000E64D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabItemInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006000 RID: 24576 RVA: 0x000E8314 File Offset: 0x000E6514
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

		// Token: 0x06006001 RID: 24577 RVA: 0x000E836C File Offset: 0x000E656C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006002 RID: 24578 RVA: 0x000E8379 File Offset: 0x000E6579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006003 RID: 24579 RVA: 0x000E8384 File Offset: 0x000E6584
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

		// Token: 0x06006004 RID: 24580 RVA: 0x000E83DC File Offset: 0x000E65DC
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

		// Token: 0x06006005 RID: 24581 RVA: 0x000E8434 File Offset: 0x000E6634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGrabItemInfo other)
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

		// Token: 0x06006006 RID: 24582 RVA: 0x000E8484 File Offset: 0x000E6684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006007 RID: 24583 RVA: 0x000E8490 File Offset: 0x000E6690
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

		// Token: 0x0400378D RID: 14221
		private static readonly MessageParser<DollGrabItemInfo> _parser = new MessageParser<DollGrabItemInfo>(() => new DollGrabItemInfo());

		// Token: 0x0400378E RID: 14222
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400378F RID: 14223
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04003790 RID: 14224
		private int itemId_;

		// Token: 0x04003791 RID: 14225
		public const int ItemCountFieldNumber = 2;

		// Token: 0x04003792 RID: 14226
		private int itemCount_;
	}
}
