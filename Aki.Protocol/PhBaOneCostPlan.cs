using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D13 RID: 3347
	public sealed class PhBaOneCostPlan : IMessage<PhBaOneCostPlan>, IMessage, IEquatable<PhBaOneCostPlan>, IDeepCloneable<PhBaOneCostPlan>, IBufferMessage
	{
		// Token: 0x06012152 RID: 74066 RVA: 0x002A478C File Offset: 0x002A298C
		[NullableContext(1)]
		public static PhBaOneCostPlan Create()
		{
			return new PhBaOneCostPlan();
		}

		// Token: 0x17003BE9 RID: 15337
		// (get) Token: 0x06012153 RID: 74067 RVA: 0x002A4793 File Offset: 0x002A2993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhBaOneCostPlan> Parser
		{
			get
			{
				return PhBaOneCostPlan._parser;
			}
		}

		// Token: 0x17003BEA RID: 15338
		// (get) Token: 0x06012154 RID: 74068 RVA: 0x002A479A File Offset: 0x002A299A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BEB RID: 15339
		// (get) Token: 0x06012155 RID: 74069 RVA: 0x002A479D File Offset: 0x002A299D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaOneCostPlan.Descriptor;
			}
		}

		// Token: 0x06012156 RID: 74070 RVA: 0x002A47A4 File Offset: 0x002A29A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaOneCostPlan()
		{
		}

		// Token: 0x06012157 RID: 74071 RVA: 0x002A47B7 File Offset: 0x002A29B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaOneCostPlan(PhBaOneCostPlan other) : this()
		{
			this.costType_ = other.costType_;
			this.attrList_ = other.attrList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012158 RID: 74072 RVA: 0x002A47ED File Offset: 0x002A29ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaOneCostPlan Clone()
		{
			return new PhBaOneCostPlan(this);
		}

		// Token: 0x17003BEC RID: 15340
		// (get) Token: 0x06012159 RID: 74073 RVA: 0x002A47F5 File Offset: 0x002A29F5
		// (set) Token: 0x0601215A RID: 74074 RVA: 0x002A47FD File Offset: 0x002A29FD
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

		// Token: 0x17003BED RID: 15341
		// (get) Token: 0x0601215B RID: 74075 RVA: 0x002A4806 File Offset: 0x002A2A06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhBaPlanAttr> AttrList
		{
			get
			{
				return this.attrList_;
			}
		}

		// Token: 0x0601215C RID: 74076 RVA: 0x002A480E File Offset: 0x002A2A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaOneCostPlan);
		}

		// Token: 0x0601215D RID: 74077 RVA: 0x002A481C File Offset: 0x002A2A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaOneCostPlan other)
		{
			return other != null && (other == this || (this.CostType == other.CostType && this.attrList_.Equals(other.attrList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601215E RID: 74078 RVA: 0x002A486C File Offset: 0x002A2A6C
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

		// Token: 0x0601215F RID: 74079 RVA: 0x002A48BF File Offset: 0x002A2ABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012160 RID: 74080 RVA: 0x002A48CC File Offset: 0x002A2ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012161 RID: 74081 RVA: 0x002A48D8 File Offset: 0x002A2AD8
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

		// Token: 0x06012162 RID: 74082 RVA: 0x002A4928 File Offset: 0x002A2B28
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

		// Token: 0x06012163 RID: 74083 RVA: 0x002A497C File Offset: 0x002A2B7C
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

		// Token: 0x06012164 RID: 74084 RVA: 0x002A49C9 File Offset: 0x002A2BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012165 RID: 74085 RVA: 0x002A49D4 File Offset: 0x002A2BD4
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

		// Token: 0x04007120 RID: 28960
		private static readonly MessageParser<PhBaOneCostPlan> _parser = new MessageParser<PhBaOneCostPlan>(() => new PhBaOneCostPlan());

		// Token: 0x04007121 RID: 28961
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007122 RID: 28962
		public const int CostTypeFieldNumber = 1;

		// Token: 0x04007123 RID: 28963
		private PhBaCostType costType_;

		// Token: 0x04007124 RID: 28964
		public const int AttrListFieldNumber = 2;

		// Token: 0x04007125 RID: 28965
		private static readonly FieldCodec<PhBaPlanAttr> _repeated_attrList_codec = FieldCodec.ForMessage<PhBaPlanAttr>(18U, PhBaPlanAttr.Parser);

		// Token: 0x04007126 RID: 28966
		private readonly RepeatedField<PhBaPlanAttr> attrList_ = new RepeatedField<PhBaPlanAttr>();
	}
}
