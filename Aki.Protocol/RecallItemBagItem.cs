using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EAC RID: 3756
	public sealed class RecallItemBagItem : IMessage<RecallItemBagItem>, IMessage, IEquatable<RecallItemBagItem>, IDeepCloneable<RecallItemBagItem>, IBufferMessage
	{
		// Token: 0x0601427F RID: 82559 RVA: 0x002EECEB File Offset: 0x002ECEEB
		[NullableContext(1)]
		public static RecallItemBagItem Create()
		{
			return new RecallItemBagItem();
		}

		// Token: 0x1700430A RID: 17162
		// (get) Token: 0x06014280 RID: 82560 RVA: 0x002EECF2 File Offset: 0x002ECEF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RecallItemBagItem> Parser
		{
			get
			{
				return RecallItemBagItem._parser;
			}
		}

		// Token: 0x1700430B RID: 17163
		// (get) Token: 0x06014281 RID: 82561 RVA: 0x002EECF9 File Offset: 0x002ECEF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700430C RID: 17164
		// (get) Token: 0x06014282 RID: 82562 RVA: 0x002EECFC File Offset: 0x002ECEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallItemBagItem.Descriptor;
			}
		}

		// Token: 0x06014283 RID: 82563 RVA: 0x002EED03 File Offset: 0x002ECF03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagItem()
		{
		}

		// Token: 0x06014284 RID: 82564 RVA: 0x002EED0B File Offset: 0x002ECF0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagItem(RecallItemBagItem other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014285 RID: 82565 RVA: 0x002EED3C File Offset: 0x002ECF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagItem Clone()
		{
			return new RecallItemBagItem(this);
		}

		// Token: 0x1700430D RID: 17165
		// (get) Token: 0x06014286 RID: 82566 RVA: 0x002EED44 File Offset: 0x002ECF44
		// (set) Token: 0x06014287 RID: 82567 RVA: 0x002EED4C File Offset: 0x002ECF4C
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

		// Token: 0x1700430E RID: 17166
		// (get) Token: 0x06014288 RID: 82568 RVA: 0x002EED55 File Offset: 0x002ECF55
		// (set) Token: 0x06014289 RID: 82569 RVA: 0x002EED5D File Offset: 0x002ECF5D
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

		// Token: 0x0601428A RID: 82570 RVA: 0x002EED66 File Offset: 0x002ECF66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallItemBagItem);
		}

		// Token: 0x0601428B RID: 82571 RVA: 0x002EED74 File Offset: 0x002ECF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallItemBagItem other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601428C RID: 82572 RVA: 0x002EEDB4 File Offset: 0x002ECFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601428D RID: 82573 RVA: 0x002EEE0C File Offset: 0x002ED00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601428E RID: 82574 RVA: 0x002EEE19 File Offset: 0x002ED019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601428F RID: 82575 RVA: 0x002EEE24 File Offset: 0x002ED024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014290 RID: 82576 RVA: 0x002EEE7C File Offset: 0x002ED07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014291 RID: 82577 RVA: 0x002EEED4 File Offset: 0x002ED0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallItemBagItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014292 RID: 82578 RVA: 0x002EEF24 File Offset: 0x002ED124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014293 RID: 82579 RVA: 0x002EEF30 File Offset: 0x002ED130
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
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007AC4 RID: 31428
		private static readonly MessageParser<RecallItemBagItem> _parser = new MessageParser<RecallItemBagItem>(() => new RecallItemBagItem());

		// Token: 0x04007AC5 RID: 31429
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AC6 RID: 31430
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04007AC7 RID: 31431
		private int itemId_;

		// Token: 0x04007AC8 RID: 31432
		public const int CountFieldNumber = 2;

		// Token: 0x04007AC9 RID: 31433
		private int count_;
	}
}
