using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000395 RID: 917
	public sealed class DangoMonopolyRewardPb : IMessage<DangoMonopolyRewardPb>, IMessage, IEquatable<DangoMonopolyRewardPb>, IDeepCloneable<DangoMonopolyRewardPb>, IBufferMessage
	{
		// Token: 0x06005AC0 RID: 23232 RVA: 0x000DD173 File Offset: 0x000DB373
		[NullableContext(1)]
		public static DangoMonopolyRewardPb Create()
		{
			return new DangoMonopolyRewardPb();
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x06005AC1 RID: 23233 RVA: 0x000DD17A File Offset: 0x000DB37A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoMonopolyRewardPb> Parser
		{
			get
			{
				return DangoMonopolyRewardPb._parser;
			}
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x06005AC2 RID: 23234 RVA: 0x000DD181 File Offset: 0x000DB381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x06005AC3 RID: 23235 RVA: 0x000DD184 File Offset: 0x000DB384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyRewardPb.Descriptor;
			}
		}

		// Token: 0x06005AC4 RID: 23236 RVA: 0x000DD18B File Offset: 0x000DB38B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyRewardPb()
		{
		}

		// Token: 0x06005AC5 RID: 23237 RVA: 0x000DD193 File Offset: 0x000DB393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyRewardPb(DangoMonopolyRewardPb other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemNum_ = other.itemNum_;
			this.multiple_ = other.multiple_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005AC6 RID: 23238 RVA: 0x000DD1D0 File Offset: 0x000DB3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyRewardPb Clone()
		{
			return new DangoMonopolyRewardPb(this);
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x06005AC7 RID: 23239 RVA: 0x000DD1D8 File Offset: 0x000DB3D8
		// (set) Token: 0x06005AC8 RID: 23240 RVA: 0x000DD1E0 File Offset: 0x000DB3E0
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

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x06005AC9 RID: 23241 RVA: 0x000DD1E9 File Offset: 0x000DB3E9
		// (set) Token: 0x06005ACA RID: 23242 RVA: 0x000DD1F1 File Offset: 0x000DB3F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemNum
		{
			get
			{
				return this.itemNum_;
			}
			set
			{
				this.itemNum_ = value;
			}
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x06005ACB RID: 23243 RVA: 0x000DD1FA File Offset: 0x000DB3FA
		// (set) Token: 0x06005ACC RID: 23244 RVA: 0x000DD202 File Offset: 0x000DB402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Multiple
		{
			get
			{
				return this.multiple_;
			}
			set
			{
				this.multiple_ = value;
			}
		}

		// Token: 0x06005ACD RID: 23245 RVA: 0x000DD20B File Offset: 0x000DB40B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyRewardPb);
		}

		// Token: 0x06005ACE RID: 23246 RVA: 0x000DD21C File Offset: 0x000DB41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyRewardPb other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemNum == other.ItemNum && this.Multiple == other.Multiple && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005ACF RID: 23247 RVA: 0x000DD278 File Offset: 0x000DB478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemNum != 0)
			{
				num ^= this.ItemNum.GetHashCode();
			}
			if (this.Multiple != 0)
			{
				num ^= this.Multiple.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005AD0 RID: 23248 RVA: 0x000DD2E9 File Offset: 0x000DB4E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005AD1 RID: 23249 RVA: 0x000DD2F6 File Offset: 0x000DB4F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005AD2 RID: 23250 RVA: 0x000DD300 File Offset: 0x000DB500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemNum);
			}
			if (this.Multiple != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Multiple);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005AD3 RID: 23251 RVA: 0x000DD374 File Offset: 0x000DB574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemNum);
			}
			if (this.Multiple != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Multiple);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005AD4 RID: 23252 RVA: 0x000DD3E4 File Offset: 0x000DB5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyRewardPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemNum != 0)
			{
				this.ItemNum = other.ItemNum;
			}
			if (other.Multiple != 0)
			{
				this.Multiple = other.Multiple;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005AD5 RID: 23253 RVA: 0x000DD448 File Offset: 0x000DB648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005AD6 RID: 23254 RVA: 0x000DD454 File Offset: 0x000DB654
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Multiple = input.ReadInt32();
						}
					}
					else
					{
						this.ItemNum = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400361E RID: 13854
		private static readonly MessageParser<DangoMonopolyRewardPb> _parser = new MessageParser<DangoMonopolyRewardPb>(() => new DangoMonopolyRewardPb());

		// Token: 0x0400361F RID: 13855
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003620 RID: 13856
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04003621 RID: 13857
		private int itemId_;

		// Token: 0x04003622 RID: 13858
		public const int ItemNumFieldNumber = 2;

		// Token: 0x04003623 RID: 13859
		private int itemNum_;

		// Token: 0x04003624 RID: 13860
		public const int MultipleFieldNumber = 3;

		// Token: 0x04003625 RID: 13861
		private int multiple_;
	}
}
