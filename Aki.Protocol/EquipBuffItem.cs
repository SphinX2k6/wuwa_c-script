using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004D3 RID: 1235
	public sealed class EquipBuffItem : IMessage<EquipBuffItem>, IMessage, IEquatable<EquipBuffItem>, IDeepCloneable<EquipBuffItem>, IBufferMessage
	{
		// Token: 0x0600754A RID: 30026 RVA: 0x0011F396 File Offset: 0x0011D596
		[NullableContext(1)]
		public static EquipBuffItem Create()
		{
			return new EquipBuffItem();
		}

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x0600754B RID: 30027 RVA: 0x0011F39D File Offset: 0x0011D59D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EquipBuffItem> Parser
		{
			get
			{
				return EquipBuffItem._parser;
			}
		}

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x0600754C RID: 30028 RVA: 0x0011F3A4 File Offset: 0x0011D5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x0600754D RID: 30029 RVA: 0x0011F3A7 File Offset: 0x0011D5A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipBuffItem.Descriptor;
			}
		}

		// Token: 0x0600754E RID: 30030 RVA: 0x0011F3AE File Offset: 0x0011D5AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipBuffItem()
		{
		}

		// Token: 0x0600754F RID: 30031 RVA: 0x0011F3B6 File Offset: 0x0011D5B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipBuffItem(EquipBuffItem other) : this()
		{
			this.itemId_ = other.itemId_;
			this.equiped_ = other.equiped_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007550 RID: 30032 RVA: 0x0011F3E7 File Offset: 0x0011D5E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipBuffItem Clone()
		{
			return new EquipBuffItem(this);
		}

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x06007551 RID: 30033 RVA: 0x0011F3EF File Offset: 0x0011D5EF
		// (set) Token: 0x06007552 RID: 30034 RVA: 0x0011F3F7 File Offset: 0x0011D5F7
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

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x06007553 RID: 30035 RVA: 0x0011F400 File Offset: 0x0011D600
		// (set) Token: 0x06007554 RID: 30036 RVA: 0x0011F408 File Offset: 0x0011D608
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

		// Token: 0x06007555 RID: 30037 RVA: 0x0011F411 File Offset: 0x0011D611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipBuffItem);
		}

		// Token: 0x06007556 RID: 30038 RVA: 0x0011F41F File Offset: 0x0011D61F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipBuffItem other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Equiped == other.Equiped && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007557 RID: 30039 RVA: 0x0011F460 File Offset: 0x0011D660
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

		// Token: 0x06007558 RID: 30040 RVA: 0x0011F4B8 File Offset: 0x0011D6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007559 RID: 30041 RVA: 0x0011F4C5 File Offset: 0x0011D6C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600755A RID: 30042 RVA: 0x0011F4D0 File Offset: 0x0011D6D0
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

		// Token: 0x0600755B RID: 30043 RVA: 0x0011F528 File Offset: 0x0011D728
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

		// Token: 0x0600755C RID: 30044 RVA: 0x0011F574 File Offset: 0x0011D774
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

		// Token: 0x0600755D RID: 30045 RVA: 0x0011F5C4 File Offset: 0x0011D7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600755E RID: 30046 RVA: 0x0011F5D0 File Offset: 0x0011D7D0
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

		// Token: 0x04003DA8 RID: 15784
		private static readonly MessageParser<EquipBuffItem> _parser = new MessageParser<EquipBuffItem>(() => new EquipBuffItem());

		// Token: 0x04003DA9 RID: 15785
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DAA RID: 15786
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04003DAB RID: 15787
		private int itemId_;

		// Token: 0x04003DAC RID: 15788
		public const int EquipedFieldNumber = 2;

		// Token: 0x04003DAD RID: 15789
		private bool equiped_;
	}
}
