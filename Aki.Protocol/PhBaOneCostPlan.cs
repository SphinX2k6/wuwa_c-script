using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D03 RID: 3331
	public sealed class PhBaOneCostPlan : IMessage<PhBaOneCostPlan>, IMessage, IEquatable<PhBaOneCostPlan>, IDeepCloneable<PhBaOneCostPlan>, IBufferMessage
	{
		// Token: 0x06012056 RID: 73814 RVA: 0x002A2B68 File Offset: 0x002A0D68
		[NullableContext(1)]
		public static PhBaOneCostPlan Create()
		{
			return new PhBaOneCostPlan();
		}

		// Token: 0x17003BB4 RID: 15284
		// (get) Token: 0x06012057 RID: 73815 RVA: 0x002A2B6F File Offset: 0x002A0D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhBaOneCostPlan> Parser
		{
			get
			{
				return PhBaOneCostPlan._parser;
			}
		}

		// Token: 0x17003BB5 RID: 15285
		// (get) Token: 0x06012058 RID: 73816 RVA: 0x002A2B76 File Offset: 0x002A0D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BB6 RID: 15286
		// (get) Token: 0x06012059 RID: 73817 RVA: 0x002A2B79 File Offset: 0x002A0D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaOneCostPlan.Descriptor;
			}
		}

		// Token: 0x0601205A RID: 73818 RVA: 0x002A2B80 File Offset: 0x002A0D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaOneCostPlan()
		{
		}

		// Token: 0x0601205B RID: 73819 RVA: 0x002A2B93 File Offset: 0x002A0D93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaOneCostPlan(PhBaOneCostPlan other) : this()
		{
			this.costType_ = other.costType_;
			this.attrList_ = other.attrList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601205C RID: 73820 RVA: 0x002A2BC9 File Offset: 0x002A0DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaOneCostPlan Clone()
		{
			return new PhBaOneCostPlan(this);
		}

		// Token: 0x17003BB7 RID: 15287
		// (get) Token: 0x0601205D RID: 73821 RVA: 0x002A2BD1 File Offset: 0x002A0DD1
		// (set) Token: 0x0601205E RID: 73822 RVA: 0x002A2BD9 File Offset: 0x002A0DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaCostType CostType
		{
			get
			{
				return this.costType_;
			}
			set
			{
				this.costType_ = value;
			}
		}

		// Token: 0x17003BB8 RID: 15288
		// (get) Token: 0x0601205F RID: 73823 RVA: 0x002A2BE2 File Offset: 0x002A0DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhBaPlanAttr> AttrList
		{
			get
			{
				return this.attrList_;
			}
		}

		// Token: 0x06012060 RID: 73824 RVA: 0x002A2BEA File Offset: 0x002A0DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaOneCostPlan);
		}

		// Token: 0x06012061 RID: 73825 RVA: 0x002A2BF8 File Offset: 0x002A0DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaOneCostPlan other)
		{
			return other != null && (other == this || (this.CostType == other.CostType && this.attrList_.Equals(other.attrList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012062 RID: 73826 RVA: 0x002A2C48 File Offset: 0x002A0E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CostType != PhBaCostType.PhBaCostDefault)
			{
				num ^= this.CostType.GetHashCode();
			}
			num ^= this.attrList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012063 RID: 73827 RVA: 0x002A2C9B File Offset: 0x002A0E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012064 RID: 73828 RVA: 0x002A2CA8 File Offset: 0x002A0EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012065 RID: 73829 RVA: 0x002A2CB4 File Offset: 0x002A0EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CostType != PhBaCostType.PhBaCostDefault)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.CostType);
			}
			this.attrList_.WriteTo(ref output, PhBaOneCostPlan._repeated_attrList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012066 RID: 73830 RVA: 0x002A2D04 File Offset: 0x002A0F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CostType != PhBaCostType.PhBaCostDefault)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.CostType);
			}
			num += this.attrList_.CalculateSize(PhBaOneCostPlan._repeated_attrList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012067 RID: 73831 RVA: 0x002A2D58 File Offset: 0x002A0F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaOneCostPlan other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CostType != PhBaCostType.PhBaCostDefault)
			{
				this.CostType = other.CostType;
			}
			this.attrList_.Add(other.attrList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012068 RID: 73832 RVA: 0x002A2DA5 File Offset: 0x002A0FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012069 RID: 73833 RVA: 0x002A2DB0 File Offset: 0x002A0FB0
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.attrList_.AddEntriesFrom(ref input, PhBaOneCostPlan._repeated_attrList_codec);
					}
				}
				else
				{
					this.CostType = (PhBaCostType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007138 RID: 28984
		private static readonly MessageParser<PhBaOneCostPlan> _parser = new MessageParser<PhBaOneCostPlan>(() => new PhBaOneCostPlan());

		// Token: 0x04007139 RID: 28985
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400713A RID: 28986
		public const int CostTypeFieldNumber = 1;

		// Token: 0x0400713B RID: 28987
		private PhBaCostType costType_;

		// Token: 0x0400713C RID: 28988
		public const int AttrListFieldNumber = 2;

		// Token: 0x0400713D RID: 28989
		private static readonly FieldCodec<PhBaPlanAttr> _repeated_attrList_codec = FieldCodec.ForMessage<PhBaPlanAttr>(18U, PhBaPlanAttr.Parser);

		// Token: 0x0400713E RID: 28990
		private readonly RepeatedField<PhBaPlanAttr> attrList_ = new RepeatedField<PhBaPlanAttr>();
	}
}
