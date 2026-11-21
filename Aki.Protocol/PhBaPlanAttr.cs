using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D05 RID: 3333
	public sealed class PhBaPlanAttr : IMessage<PhBaPlanAttr>, IMessage, IEquatable<PhBaPlanAttr>, IDeepCloneable<PhBaPlanAttr>, IBufferMessage
	{
		// Token: 0x06012082 RID: 73858 RVA: 0x002A31A4 File Offset: 0x002A13A4
		[NullableContext(1)]
		public static PhBaPlanAttr Create()
		{
			return new PhBaPlanAttr();
		}

		// Token: 0x17003BBF RID: 15295
		// (get) Token: 0x06012083 RID: 73859 RVA: 0x002A31AB File Offset: 0x002A13AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhBaPlanAttr> Parser
		{
			get
			{
				return PhBaPlanAttr._parser;
			}
		}

		// Token: 0x17003BC0 RID: 15296
		// (get) Token: 0x06012084 RID: 73860 RVA: 0x002A31B2 File Offset: 0x002A13B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BC1 RID: 15297
		// (get) Token: 0x06012085 RID: 73861 RVA: 0x002A31B5 File Offset: 0x002A13B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanAttr.Descriptor;
			}
		}

		// Token: 0x06012086 RID: 73862 RVA: 0x002A31BC File Offset: 0x002A13BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanAttr()
		{
		}

		// Token: 0x06012087 RID: 73863 RVA: 0x002A31C4 File Offset: 0x002A13C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanAttr(PhBaPlanAttr other) : this()
		{
			this.attrId_ = other.attrId_;
			this.deal_ = other.deal_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012088 RID: 73864 RVA: 0x002A31F5 File Offset: 0x002A13F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanAttr Clone()
		{
			return new PhBaPlanAttr(this);
		}

		// Token: 0x17003BC2 RID: 15298
		// (get) Token: 0x06012089 RID: 73865 RVA: 0x002A31FD File Offset: 0x002A13FD
		// (set) Token: 0x0601208A RID: 73866 RVA: 0x002A3205 File Offset: 0x002A1405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AttrId
		{
			get
			{
				return this.attrId_;
			}
			set
			{
				this.attrId_ = value;
			}
		}

		// Token: 0x17003BC3 RID: 15299
		// (get) Token: 0x0601208B RID: 73867 RVA: 0x002A320E File Offset: 0x002A140E
		// (set) Token: 0x0601208C RID: 73868 RVA: 0x002A3216 File Offset: 0x002A1416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanAttrDeal Deal
		{
			get
			{
				return this.deal_;
			}
			set
			{
				this.deal_ = value;
			}
		}

		// Token: 0x0601208D RID: 73869 RVA: 0x002A321F File Offset: 0x002A141F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanAttr);
		}

		// Token: 0x0601208E RID: 73870 RVA: 0x002A322D File Offset: 0x002A142D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanAttr other)
		{
			return other != null && (other == this || (this.AttrId == other.AttrId && this.Deal == other.Deal && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601208F RID: 73871 RVA: 0x002A326C File Offset: 0x002A146C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AttrId != 0)
			{
				num ^= this.AttrId.GetHashCode();
			}
			if (this.Deal != PhBaPlanAttrDeal.PhBaDefault)
			{
				num ^= this.Deal.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012090 RID: 73872 RVA: 0x002A32CA File Offset: 0x002A14CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012091 RID: 73873 RVA: 0x002A32D7 File Offset: 0x002A14D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012092 RID: 73874 RVA: 0x002A32E0 File Offset: 0x002A14E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AttrId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AttrId);
			}
			if (this.Deal != PhBaPlanAttrDeal.PhBaDefault)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Deal);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012093 RID: 73875 RVA: 0x002A3338 File Offset: 0x002A1538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AttrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AttrId);
			}
			if (this.Deal != PhBaPlanAttrDeal.PhBaDefault)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Deal);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012094 RID: 73876 RVA: 0x002A3390 File Offset: 0x002A1590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanAttr other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AttrId != 0)
			{
				this.AttrId = other.AttrId;
			}
			if (other.Deal != PhBaPlanAttrDeal.PhBaDefault)
			{
				this.Deal = other.Deal;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012095 RID: 73877 RVA: 0x002A33E0 File Offset: 0x002A15E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012096 RID: 73878 RVA: 0x002A33EC File Offset: 0x002A15EC
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
						this.Deal = (PhBaPlanAttrDeal)input.ReadEnum();
					}
				}
				else
				{
					this.AttrId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007148 RID: 29000
		private static readonly MessageParser<PhBaPlanAttr> _parser = new MessageParser<PhBaPlanAttr>(() => new PhBaPlanAttr());

		// Token: 0x04007149 RID: 29001
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400714A RID: 29002
		public const int AttrIdFieldNumber = 1;

		// Token: 0x0400714B RID: 29003
		private int attrId_;

		// Token: 0x0400714C RID: 29004
		public const int DealFieldNumber = 2;

		// Token: 0x0400714D RID: 29005
		private PhBaPlanAttrDeal deal_;
	}
}
