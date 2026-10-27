using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200084B RID: 2123
	public sealed class ItemEntry : IMessage<ItemEntry>, IMessage, IEquatable<ItemEntry>, IDeepCloneable<ItemEntry>, IBufferMessage
	{
		// Token: 0x0600BD67 RID: 48487 RVA: 0x001C2559 File Offset: 0x001C0759
		[NullableContext(1)]
		public static ItemEntry Create()
		{
			return new ItemEntry();
		}

		// Token: 0x1700263D RID: 9789
		// (get) Token: 0x0600BD68 RID: 48488 RVA: 0x001C2560 File Offset: 0x001C0760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ItemEntry> Parser
		{
			get
			{
				return ItemEntry._parser;
			}
		}

		// Token: 0x1700263E RID: 9790
		// (get) Token: 0x0600BD69 RID: 48489 RVA: 0x001C2567 File Offset: 0x001C0767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700263F RID: 9791
		// (get) Token: 0x0600BD6A RID: 48490 RVA: 0x001C256A File Offset: 0x001C076A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemEntry.Descriptor;
			}
		}

		// Token: 0x0600BD6B RID: 48491 RVA: 0x001C2571 File Offset: 0x001C0771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemEntry()
		{
		}

		// Token: 0x0600BD6C RID: 48492 RVA: 0x001C2579 File Offset: 0x001C0779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemEntry(ItemEntry other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD6D RID: 48493 RVA: 0x001C25AA File Offset: 0x001C07AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemEntry Clone()
		{
			return new ItemEntry(this);
		}

		// Token: 0x17002640 RID: 9792
		// (get) Token: 0x0600BD6E RID: 48494 RVA: 0x001C25B2 File Offset: 0x001C07B2
		// (set) Token: 0x0600BD6F RID: 48495 RVA: 0x001C25BA File Offset: 0x001C07BA
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

		// Token: 0x17002641 RID: 9793
		// (get) Token: 0x0600BD70 RID: 48496 RVA: 0x001C25C3 File Offset: 0x001C07C3
		// (set) Token: 0x0600BD71 RID: 48497 RVA: 0x001C25CB File Offset: 0x001C07CB
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

		// Token: 0x0600BD72 RID: 48498 RVA: 0x001C25D4 File Offset: 0x001C07D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemEntry);
		}

		// Token: 0x0600BD73 RID: 48499 RVA: 0x001C25E2 File Offset: 0x001C07E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemEntry other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD74 RID: 48500 RVA: 0x001C2620 File Offset: 0x001C0820
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

		// Token: 0x0600BD75 RID: 48501 RVA: 0x001C2678 File Offset: 0x001C0878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BD76 RID: 48502 RVA: 0x001C2685 File Offset: 0x001C0885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD77 RID: 48503 RVA: 0x001C2690 File Offset: 0x001C0890
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

		// Token: 0x0600BD78 RID: 48504 RVA: 0x001C26E8 File Offset: 0x001C08E8
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

		// Token: 0x0600BD79 RID: 48505 RVA: 0x001C2740 File Offset: 0x001C0940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemEntry other)
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

		// Token: 0x0600BD7A RID: 48506 RVA: 0x001C2790 File Offset: 0x001C0990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD7B RID: 48507 RVA: 0x001C279C File Offset: 0x001C099C
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

		// Token: 0x040052C3 RID: 21187
		private static readonly MessageParser<ItemEntry> _parser = new MessageParser<ItemEntry>(() => new ItemEntry());

		// Token: 0x040052C4 RID: 21188
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052C5 RID: 21189
		public const int ItemIdFieldNumber = 1;

		// Token: 0x040052C6 RID: 21190
		private int itemId_;

		// Token: 0x040052C7 RID: 21191
		public const int ItemCountFieldNumber = 2;

		// Token: 0x040052C8 RID: 21192
		private int itemCount_;
	}
}
