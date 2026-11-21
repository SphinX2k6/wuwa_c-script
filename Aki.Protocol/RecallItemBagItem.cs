using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E9C RID: 3740
	public sealed class RecallItemBagItem : IMessage<RecallItemBagItem>, IMessage, IEquatable<RecallItemBagItem>, IDeepCloneable<RecallItemBagItem>, IBufferMessage
	{
		// Token: 0x0601419A RID: 82330 RVA: 0x002ED63F File Offset: 0x002EB83F
		[NullableContext(1)]
		public static RecallItemBagItem Create()
		{
			return new RecallItemBagItem();
		}

		// Token: 0x170042E0 RID: 17120
		// (get) Token: 0x0601419B RID: 82331 RVA: 0x002ED646 File Offset: 0x002EB846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RecallItemBagItem> Parser
		{
			get
			{
				return RecallItemBagItem._parser;
			}
		}

		// Token: 0x170042E1 RID: 17121
		// (get) Token: 0x0601419C RID: 82332 RVA: 0x002ED64D File Offset: 0x002EB84D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042E2 RID: 17122
		// (get) Token: 0x0601419D RID: 82333 RVA: 0x002ED650 File Offset: 0x002EB850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallItemBagItem.Descriptor;
			}
		}

		// Token: 0x0601419E RID: 82334 RVA: 0x002ED657 File Offset: 0x002EB857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagItem()
		{
		}

		// Token: 0x0601419F RID: 82335 RVA: 0x002ED65F File Offset: 0x002EB85F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagItem(RecallItemBagItem other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060141A0 RID: 82336 RVA: 0x002ED690 File Offset: 0x002EB890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagItem Clone()
		{
			return new RecallItemBagItem(this);
		}

		// Token: 0x170042E3 RID: 17123
		// (get) Token: 0x060141A1 RID: 82337 RVA: 0x002ED698 File Offset: 0x002EB898
		// (set) Token: 0x060141A2 RID: 82338 RVA: 0x002ED6A0 File Offset: 0x002EB8A0
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

		// Token: 0x170042E4 RID: 17124
		// (get) Token: 0x060141A3 RID: 82339 RVA: 0x002ED6A9 File Offset: 0x002EB8A9
		// (set) Token: 0x060141A4 RID: 82340 RVA: 0x002ED6B1 File Offset: 0x002EB8B1
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

		// Token: 0x060141A5 RID: 82341 RVA: 0x002ED6BA File Offset: 0x002EB8BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallItemBagItem);
		}

		// Token: 0x060141A6 RID: 82342 RVA: 0x002ED6C8 File Offset: 0x002EB8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallItemBagItem other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060141A7 RID: 82343 RVA: 0x002ED708 File Offset: 0x002EB908
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

		// Token: 0x060141A8 RID: 82344 RVA: 0x002ED760 File Offset: 0x002EB960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060141A9 RID: 82345 RVA: 0x002ED76D File Offset: 0x002EB96D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060141AA RID: 82346 RVA: 0x002ED778 File Offset: 0x002EB978
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

		// Token: 0x060141AB RID: 82347 RVA: 0x002ED7D0 File Offset: 0x002EB9D0
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

		// Token: 0x060141AC RID: 82348 RVA: 0x002ED828 File Offset: 0x002EBA28
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

		// Token: 0x060141AD RID: 82349 RVA: 0x002ED878 File Offset: 0x002EBA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060141AE RID: 82350 RVA: 0x002ED884 File Offset: 0x002EBA84
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

		// Token: 0x04007AEE RID: 31470
		private static readonly MessageParser<RecallItemBagItem> _parser = new MessageParser<RecallItemBagItem>(() => new RecallItemBagItem());

		// Token: 0x04007AEF RID: 31471
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AF0 RID: 31472
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04007AF1 RID: 31473
		private int itemId_;

		// Token: 0x04007AF2 RID: 31474
		public const int CountFieldNumber = 2;

		// Token: 0x04007AF3 RID: 31475
		private int count_;
	}
}
