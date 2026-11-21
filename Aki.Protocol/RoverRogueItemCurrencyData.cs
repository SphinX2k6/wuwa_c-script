using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001145 RID: 4421
	public sealed class RoverRogueItemCurrencyData : IMessage<RoverRogueItemCurrencyData>, IMessage, IEquatable<RoverRogueItemCurrencyData>, IDeepCloneable<RoverRogueItemCurrencyData>, IBufferMessage
	{
		// Token: 0x060179F7 RID: 96759 RVA: 0x003704A4 File Offset: 0x0036E6A4
		[NullableContext(1)]
		public static RoverRogueItemCurrencyData Create()
		{
			return new RoverRogueItemCurrencyData();
		}

		// Token: 0x17004F76 RID: 20342
		// (get) Token: 0x060179F8 RID: 96760 RVA: 0x003704AB File Offset: 0x0036E6AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueItemCurrencyData> Parser
		{
			get
			{
				return RoverRogueItemCurrencyData._parser;
			}
		}

		// Token: 0x17004F77 RID: 20343
		// (get) Token: 0x060179F9 RID: 96761 RVA: 0x003704B2 File Offset: 0x0036E6B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F78 RID: 20344
		// (get) Token: 0x060179FA RID: 96762 RVA: 0x003704B5 File Offset: 0x0036E6B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueItemCurrencyData.Descriptor;
			}
		}

		// Token: 0x060179FB RID: 96763 RVA: 0x003704BC File Offset: 0x0036E6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueItemCurrencyData()
		{
		}

		// Token: 0x060179FC RID: 96764 RVA: 0x003704C4 File Offset: 0x0036E6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueItemCurrencyData(RoverRogueItemCurrencyData other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060179FD RID: 96765 RVA: 0x003704F5 File Offset: 0x0036E6F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueItemCurrencyData Clone()
		{
			return new RoverRogueItemCurrencyData(this);
		}

		// Token: 0x17004F79 RID: 20345
		// (get) Token: 0x060179FE RID: 96766 RVA: 0x003704FD File Offset: 0x0036E6FD
		// (set) Token: 0x060179FF RID: 96767 RVA: 0x00370505 File Offset: 0x0036E705
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

		// Token: 0x17004F7A RID: 20346
		// (get) Token: 0x06017A00 RID: 96768 RVA: 0x0037050E File Offset: 0x0036E70E
		// (set) Token: 0x06017A01 RID: 96769 RVA: 0x00370516 File Offset: 0x0036E716
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

		// Token: 0x06017A02 RID: 96770 RVA: 0x0037051F File Offset: 0x0036E71F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueItemCurrencyData);
		}

		// Token: 0x06017A03 RID: 96771 RVA: 0x0037052D File Offset: 0x0036E72D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueItemCurrencyData other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017A04 RID: 96772 RVA: 0x0037056C File Offset: 0x0036E76C
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

		// Token: 0x06017A05 RID: 96773 RVA: 0x003705C4 File Offset: 0x0036E7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017A06 RID: 96774 RVA: 0x003705D1 File Offset: 0x0036E7D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017A07 RID: 96775 RVA: 0x003705DC File Offset: 0x0036E7DC
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

		// Token: 0x06017A08 RID: 96776 RVA: 0x00370634 File Offset: 0x0036E834
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

		// Token: 0x06017A09 RID: 96777 RVA: 0x0037068C File Offset: 0x0036E88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueItemCurrencyData other)
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

		// Token: 0x06017A0A RID: 96778 RVA: 0x003706DC File Offset: 0x0036E8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017A0B RID: 96779 RVA: 0x003706E8 File Offset: 0x0036E8E8
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

		// Token: 0x04008D08 RID: 36104
		private static readonly MessageParser<RoverRogueItemCurrencyData> _parser = new MessageParser<RoverRogueItemCurrencyData>(() => new RoverRogueItemCurrencyData());

		// Token: 0x04008D09 RID: 36105
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D0A RID: 36106
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04008D0B RID: 36107
		private int itemId_;

		// Token: 0x04008D0C RID: 36108
		public const int CountFieldNumber = 2;

		// Token: 0x04008D0D RID: 36109
		private int count_;
	}
}
