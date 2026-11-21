using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200084B RID: 2123
	[NetMessage(EMessageId.ItemUseRequest)]
	public sealed class ItemUseRequest : IMessage<ItemUseRequest>, IMessage, IEquatable<ItemUseRequest>, IDeepCloneable<ItemUseRequest>, IBufferMessage
	{
		// Token: 0x0600BDAF RID: 48559 RVA: 0x001C3340 File Offset: 0x001C1540
		[NullableContext(1)]
		public static ItemUseRequest Create()
		{
			return new ItemUseRequest();
		}

		// Token: 0x1700264B RID: 9803
		// (get) Token: 0x0600BDB0 RID: 48560 RVA: 0x001C3347 File Offset: 0x001C1547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700264C RID: 9804
		// (get) Token: 0x0600BDB1 RID: 48561 RVA: 0x001C334A File Offset: 0x001C154A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemUseRequest.Descriptor;
			}
		}

		// Token: 0x0600BDB2 RID: 48562 RVA: 0x001C3351 File Offset: 0x001C1551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemUseRequest()
		{
		}

		// Token: 0x0600BDB3 RID: 48563 RVA: 0x001C3359 File Offset: 0x001C1559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemUseRequest(ItemUseRequest other) : this()
		{
			this.count_ = other.count_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BDB4 RID: 48564 RVA: 0x001C338A File Offset: 0x001C158A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemUseRequest Clone()
		{
			return new ItemUseRequest(this);
		}

		// Token: 0x1700264D RID: 9805
		// (get) Token: 0x0600BDB5 RID: 48565 RVA: 0x001C3392 File Offset: 0x001C1592
		// (set) Token: 0x0600BDB6 RID: 48566 RVA: 0x001C339A File Offset: 0x001C159A
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

		// Token: 0x1700264E RID: 9806
		// (get) Token: 0x0600BDB7 RID: 48567 RVA: 0x001C33A3 File Offset: 0x001C15A3
		// (set) Token: 0x0600BDB8 RID: 48568 RVA: 0x001C33AB File Offset: 0x001C15AB
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

		// Token: 0x0600BDB9 RID: 48569 RVA: 0x001C33B4 File Offset: 0x001C15B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemUseRequest);
		}

		// Token: 0x0600BDBA RID: 48570 RVA: 0x001C33C2 File Offset: 0x001C15C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemUseRequest other)
		{
			return other != null && (other == this || (this.Count == other.Count && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BDBB RID: 48571 RVA: 0x001C3400 File Offset: 0x001C1600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BDBC RID: 48572 RVA: 0x001C3458 File Offset: 0x001C1658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BDBD RID: 48573 RVA: 0x001C3465 File Offset: 0x001C1665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BDBE RID: 48574 RVA: 0x001C3470 File Offset: 0x001C1670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BDBF RID: 48575 RVA: 0x001C34CC File Offset: 0x001C16CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BDC0 RID: 48576 RVA: 0x001C3524 File Offset: 0x001C1724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemUseRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BDC1 RID: 48577 RVA: 0x001C3574 File Offset: 0x001C1774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BDC2 RID: 48578 RVA: 0x001C3580 File Offset: 0x001C1780
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
				if (num != 88U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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

		// Token: 0x04005336 RID: 21302
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005337 RID: 21303
		public const int CountFieldNumber = 14;

		// Token: 0x04005338 RID: 21304
		private int count_;

		// Token: 0x04005339 RID: 21305
		public const int ItemIdFieldNumber = 11;

		// Token: 0x0400533A RID: 21306
		private int itemId_;
	}
}
