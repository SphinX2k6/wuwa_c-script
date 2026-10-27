using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200038D RID: 909
	public sealed class DangoMonopolyRewardPb : IMessage<DangoMonopolyRewardPb>, IMessage, IEquatable<DangoMonopolyRewardPb>, IDeepCloneable<DangoMonopolyRewardPb>, IBufferMessage
	{
		// Token: 0x060059D3 RID: 22995 RVA: 0x000DAAEC File Offset: 0x000D8CEC
		[NullableContext(1)]
		public static DangoMonopolyRewardPb Create()
		{
			return new DangoMonopolyRewardPb();
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x060059D4 RID: 22996 RVA: 0x000DAAF3 File Offset: 0x000D8CF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoMonopolyRewardPb> Parser
		{
			get
			{
				return DangoMonopolyRewardPb._parser;
			}
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x060059D5 RID: 22997 RVA: 0x000DAAFA File Offset: 0x000D8CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x060059D6 RID: 22998 RVA: 0x000DAAFD File Offset: 0x000D8CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyRewardPb.Descriptor;
			}
		}

		// Token: 0x060059D7 RID: 22999 RVA: 0x000DAB04 File Offset: 0x000D8D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyRewardPb()
		{
		}

		// Token: 0x060059D8 RID: 23000 RVA: 0x000DAB0C File Offset: 0x000D8D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyRewardPb(DangoMonopolyRewardPb other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemNum_ = other.itemNum_;
			this.multiple_ = other.multiple_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060059D9 RID: 23001 RVA: 0x000DAB49 File Offset: 0x000D8D49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyRewardPb Clone()
		{
			return new DangoMonopolyRewardPb(this);
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x060059DA RID: 23002 RVA: 0x000DAB51 File Offset: 0x000D8D51
		// (set) Token: 0x060059DB RID: 23003 RVA: 0x000DAB59 File Offset: 0x000D8D59
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

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x060059DC RID: 23004 RVA: 0x000DAB62 File Offset: 0x000D8D62
		// (set) Token: 0x060059DD RID: 23005 RVA: 0x000DAB6A File Offset: 0x000D8D6A
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

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x060059DE RID: 23006 RVA: 0x000DAB73 File Offset: 0x000D8D73
		// (set) Token: 0x060059DF RID: 23007 RVA: 0x000DAB7B File Offset: 0x000D8D7B
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

		// Token: 0x060059E0 RID: 23008 RVA: 0x000DAB84 File Offset: 0x000D8D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyRewardPb);
		}

		// Token: 0x060059E1 RID: 23009 RVA: 0x000DAB94 File Offset: 0x000D8D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyRewardPb other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemNum == other.ItemNum && this.Multiple == other.Multiple && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060059E2 RID: 23010 RVA: 0x000DABF0 File Offset: 0x000D8DF0
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

		// Token: 0x060059E3 RID: 23011 RVA: 0x000DAC61 File Offset: 0x000D8E61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060059E4 RID: 23012 RVA: 0x000DAC6E File Offset: 0x000D8E6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060059E5 RID: 23013 RVA: 0x000DAC78 File Offset: 0x000D8E78
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

		// Token: 0x060059E6 RID: 23014 RVA: 0x000DACEC File Offset: 0x000D8EEC
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

		// Token: 0x060059E7 RID: 23015 RVA: 0x000DAD5C File Offset: 0x000D8F5C
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

		// Token: 0x060059E8 RID: 23016 RVA: 0x000DADC0 File Offset: 0x000D8FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060059E9 RID: 23017 RVA: 0x000DADCC File Offset: 0x000D8FCC
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

		// Token: 0x04003582 RID: 13698
		private static readonly MessageParser<DangoMonopolyRewardPb> _parser = new MessageParser<DangoMonopolyRewardPb>(() => new DangoMonopolyRewardPb());

		// Token: 0x04003583 RID: 13699
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003584 RID: 13700
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04003585 RID: 13701
		private int itemId_;

		// Token: 0x04003586 RID: 13702
		public const int ItemNumFieldNumber = 2;

		// Token: 0x04003587 RID: 13703
		private int itemNum_;

		// Token: 0x04003588 RID: 13704
		public const int MultipleFieldNumber = 3;

		// Token: 0x04003589 RID: 13705
		private int multiple_;
	}
}
