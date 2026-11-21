using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004BC RID: 1212
	public sealed class EquipBuffItem : IMessage<EquipBuffItem>, IMessage, IEquatable<EquipBuffItem>, IDeepCloneable<EquipBuffItem>, IBufferMessage
	{
		// Token: 0x060073BA RID: 29626 RVA: 0x0011C27E File Offset: 0x0011A47E
		[NullableContext(1)]
		public static EquipBuffItem Create()
		{
			return new EquipBuffItem();
		}

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x060073BB RID: 29627 RVA: 0x0011C285 File Offset: 0x0011A485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EquipBuffItem> Parser
		{
			get
			{
				return EquipBuffItem._parser;
			}
		}

		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x060073BC RID: 29628 RVA: 0x0011C28C File Offset: 0x0011A48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x060073BD RID: 29629 RVA: 0x0011C28F File Offset: 0x0011A48F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipBuffItem.Descriptor;
			}
		}

		// Token: 0x060073BE RID: 29630 RVA: 0x0011C296 File Offset: 0x0011A496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipBuffItem()
		{
		}

		// Token: 0x060073BF RID: 29631 RVA: 0x0011C29E File Offset: 0x0011A49E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipBuffItem(EquipBuffItem other) : this()
		{
			this.itemId_ = other.itemId_;
			this.equiped_ = other.equiped_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060073C0 RID: 29632 RVA: 0x0011C2CF File Offset: 0x0011A4CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipBuffItem Clone()
		{
			return new EquipBuffItem(this);
		}

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x060073C1 RID: 29633 RVA: 0x0011C2D7 File Offset: 0x0011A4D7
		// (set) Token: 0x060073C2 RID: 29634 RVA: 0x0011C2DF File Offset: 0x0011A4DF
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

		// Token: 0x1700166D RID: 5741
		// (get) Token: 0x060073C3 RID: 29635 RVA: 0x0011C2E8 File Offset: 0x0011A4E8
		// (set) Token: 0x060073C4 RID: 29636 RVA: 0x0011C2F0 File Offset: 0x0011A4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equiped
		{
			get
			{
				return this.equiped_;
			}
			set
			{
				this.equiped_ = value;
			}
		}

		// Token: 0x060073C5 RID: 29637 RVA: 0x0011C2F9 File Offset: 0x0011A4F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipBuffItem);
		}

		// Token: 0x060073C6 RID: 29638 RVA: 0x0011C307 File Offset: 0x0011A507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipBuffItem other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Equiped == other.Equiped && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060073C7 RID: 29639 RVA: 0x0011C348 File Offset: 0x0011A548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Equiped)
			{
				num ^= this.Equiped.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060073C8 RID: 29640 RVA: 0x0011C3A0 File Offset: 0x0011A5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060073C9 RID: 29641 RVA: 0x0011C3AD File Offset: 0x0011A5AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060073CA RID: 29642 RVA: 0x0011C3B8 File Offset: 0x0011A5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Equiped)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Equiped);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060073CB RID: 29643 RVA: 0x0011C410 File Offset: 0x0011A610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Equiped)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060073CC RID: 29644 RVA: 0x0011C45C File Offset: 0x0011A65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EquipBuffItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Equiped)
			{
				this.Equiped = other.Equiped;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060073CD RID: 29645 RVA: 0x0011C4AC File Offset: 0x0011A6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060073CE RID: 29646 RVA: 0x0011C4B8 File Offset: 0x0011A6B8
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
						this.Equiped = input.ReadBool();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003D94 RID: 15764
		private static readonly MessageParser<EquipBuffItem> _parser = new MessageParser<EquipBuffItem>(() => new EquipBuffItem());

		// Token: 0x04003D95 RID: 15765
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D96 RID: 15766
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04003D97 RID: 15767
		private int itemId_;

		// Token: 0x04003D98 RID: 15768
		public const int EquipedFieldNumber = 2;

		// Token: 0x04003D99 RID: 15769
		private bool equiped_;
	}
}
