using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D15 RID: 3349
	public sealed class PhBaPlanAttr : IMessage<PhBaPlanAttr>, IMessage, IEquatable<PhBaPlanAttr>, IDeepCloneable<PhBaPlanAttr>, IBufferMessage
	{
		// Token: 0x0601217E RID: 74110 RVA: 0x002A4DC8 File Offset: 0x002A2FC8
		[NullableContext(1)]
		public static PhBaPlanAttr Create()
		{
			return new PhBaPlanAttr();
		}

		// Token: 0x17003BF4 RID: 15348
		// (get) Token: 0x0601217F RID: 74111 RVA: 0x002A4DCF File Offset: 0x002A2FCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhBaPlanAttr> Parser
		{
			get
			{
				return PhBaPlanAttr._parser;
			}
		}

		// Token: 0x17003BF5 RID: 15349
		// (get) Token: 0x06012180 RID: 74112 RVA: 0x002A4DD6 File Offset: 0x002A2FD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BF6 RID: 15350
		// (get) Token: 0x06012181 RID: 74113 RVA: 0x002A4DD9 File Offset: 0x002A2FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanAttr.Descriptor;
			}
		}

		// Token: 0x06012182 RID: 74114 RVA: 0x002A4DE0 File Offset: 0x002A2FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanAttr()
		{
		}

		// Token: 0x06012183 RID: 74115 RVA: 0x002A4DE8 File Offset: 0x002A2FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanAttr(PhBaPlanAttr other) : this()
		{
			this.attrId_ = other.attrId_;
			this.deal_ = other.deal_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012184 RID: 74116 RVA: 0x002A4E19 File Offset: 0x002A3019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanAttr Clone()
		{
			return new PhBaPlanAttr(this);
		}

		// Token: 0x17003BF7 RID: 15351
		// (get) Token: 0x06012185 RID: 74117 RVA: 0x002A4E21 File Offset: 0x002A3021
		// (set) Token: 0x06012186 RID: 74118 RVA: 0x002A4E29 File Offset: 0x002A3029
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

		// Token: 0x17003BF8 RID: 15352
		// (get) Token: 0x06012187 RID: 74119 RVA: 0x002A4E32 File Offset: 0x002A3032
		// (set) Token: 0x06012188 RID: 74120 RVA: 0x002A4E3A File Offset: 0x002A303A
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

		// Token: 0x06012189 RID: 74121 RVA: 0x002A4E43 File Offset: 0x002A3043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanAttr);
		}

		// Token: 0x0601218A RID: 74122 RVA: 0x002A4E51 File Offset: 0x002A3051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanAttr other)
		{
			return other != null && (other == this || (this.AttrId == other.AttrId && this.Deal == other.Deal && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601218B RID: 74123 RVA: 0x002A4E90 File Offset: 0x002A3090
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

		// Token: 0x0601218C RID: 74124 RVA: 0x002A4EEE File Offset: 0x002A30EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601218D RID: 74125 RVA: 0x002A4EFB File Offset: 0x002A30FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601218E RID: 74126 RVA: 0x002A4F04 File Offset: 0x002A3104
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

		// Token: 0x0601218F RID: 74127 RVA: 0x002A4F5C File Offset: 0x002A315C
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

		// Token: 0x06012190 RID: 74128 RVA: 0x002A4FB4 File Offset: 0x002A31B4
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

		// Token: 0x06012191 RID: 74129 RVA: 0x002A5004 File Offset: 0x002A3204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012192 RID: 74130 RVA: 0x002A5010 File Offset: 0x002A3210
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

		// Token: 0x04007130 RID: 28976
		private static readonly MessageParser<PhBaPlanAttr> _parser = new MessageParser<PhBaPlanAttr>(() => new PhBaPlanAttr());

		// Token: 0x04007131 RID: 28977
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007132 RID: 28978
		public const int AttrIdFieldNumber = 1;

		// Token: 0x04007133 RID: 28979
		private int attrId_;

		// Token: 0x04007134 RID: 28980
		public const int DealFieldNumber = 2;

		// Token: 0x04007135 RID: 28981
		private PhBaPlanAttrDeal deal_;
	}
}
