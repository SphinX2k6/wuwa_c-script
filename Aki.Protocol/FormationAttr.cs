using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000611 RID: 1553
	public sealed class FormationAttr : IMessage<FormationAttr>, IMessage, IEquatable<FormationAttr>, IDeepCloneable<FormationAttr>, IBufferMessage
	{
		// Token: 0x06008FC8 RID: 36808 RVA: 0x0015CA22 File Offset: 0x0015AC22
		[NullableContext(1)]
		public static FormationAttr Create()
		{
			return new FormationAttr();
		}

		// Token: 0x17001C8D RID: 7309
		// (get) Token: 0x06008FC9 RID: 36809 RVA: 0x0015CA29 File Offset: 0x0015AC29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FormationAttr> Parser
		{
			get
			{
				return FormationAttr._parser;
			}
		}

		// Token: 0x17001C8E RID: 7310
		// (get) Token: 0x06008FCA RID: 36810 RVA: 0x0015CA30 File Offset: 0x0015AC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C8F RID: 7311
		// (get) Token: 0x06008FCB RID: 36811 RVA: 0x0015CA33 File Offset: 0x0015AC33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationAttr.Descriptor;
			}
		}

		// Token: 0x06008FCC RID: 36812 RVA: 0x0015CA3A File Offset: 0x0015AC3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttr()
		{
		}

		// Token: 0x06008FCD RID: 36813 RVA: 0x0015CA44 File Offset: 0x0015AC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttr(FormationAttr other) : this()
		{
			this.attrId_ = other.attrId_;
			this.ratio_ = other.ratio_;
			this.baseMaxValue_ = other.baseMaxValue_;
			this.maxValue_ = other.maxValue_;
			this.currentValue_ = other.currentValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008FCE RID: 36814 RVA: 0x0015CAA4 File Offset: 0x0015ACA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttr Clone()
		{
			return new FormationAttr(this);
		}

		// Token: 0x17001C90 RID: 7312
		// (get) Token: 0x06008FCF RID: 36815 RVA: 0x0015CAAC File Offset: 0x0015ACAC
		// (set) Token: 0x06008FD0 RID: 36816 RVA: 0x0015CAB4 File Offset: 0x0015ACB4
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

		// Token: 0x17001C91 RID: 7313
		// (get) Token: 0x06008FD1 RID: 36817 RVA: 0x0015CABD File Offset: 0x0015ACBD
		// (set) Token: 0x06008FD2 RID: 36818 RVA: 0x0015CAC5 File Offset: 0x0015ACC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Ratio
		{
			get
			{
				return this.ratio_;
			}
			set
			{
				this.ratio_ = value;
			}
		}

		// Token: 0x17001C92 RID: 7314
		// (get) Token: 0x06008FD3 RID: 36819 RVA: 0x0015CACE File Offset: 0x0015ACCE
		// (set) Token: 0x06008FD4 RID: 36820 RVA: 0x0015CAD6 File Offset: 0x0015ACD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BaseMaxValue
		{
			get
			{
				return this.baseMaxValue_;
			}
			set
			{
				this.baseMaxValue_ = value;
			}
		}

		// Token: 0x17001C93 RID: 7315
		// (get) Token: 0x06008FD5 RID: 36821 RVA: 0x0015CADF File Offset: 0x0015ACDF
		// (set) Token: 0x06008FD6 RID: 36822 RVA: 0x0015CAE7 File Offset: 0x0015ACE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxValue
		{
			get
			{
				return this.maxValue_;
			}
			set
			{
				this.maxValue_ = value;
			}
		}

		// Token: 0x17001C94 RID: 7316
		// (get) Token: 0x06008FD7 RID: 36823 RVA: 0x0015CAF0 File Offset: 0x0015ACF0
		// (set) Token: 0x06008FD8 RID: 36824 RVA: 0x0015CAF8 File Offset: 0x0015ACF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrentValue
		{
			get
			{
				return this.currentValue_;
			}
			set
			{
				this.currentValue_ = value;
			}
		}

		// Token: 0x06008FD9 RID: 36825 RVA: 0x0015CB01 File Offset: 0x0015AD01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationAttr);
		}

		// Token: 0x06008FDA RID: 36826 RVA: 0x0015CB10 File Offset: 0x0015AD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationAttr other)
		{
			return other != null && (other == this || (this.AttrId == other.AttrId && this.Ratio == other.Ratio && this.BaseMaxValue == other.BaseMaxValue && this.MaxValue == other.MaxValue && this.CurrentValue == other.CurrentValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008FDB RID: 36827 RVA: 0x0015CB8C File Offset: 0x0015AD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AttrId != 0)
			{
				num ^= this.AttrId.GetHashCode();
			}
			if (this.Ratio != 0)
			{
				num ^= this.Ratio.GetHashCode();
			}
			if (this.BaseMaxValue != 0)
			{
				num ^= this.BaseMaxValue.GetHashCode();
			}
			if (this.MaxValue != 0)
			{
				num ^= this.MaxValue.GetHashCode();
			}
			if (this.CurrentValue != 0)
			{
				num ^= this.CurrentValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008FDC RID: 36828 RVA: 0x0015CC2F File Offset: 0x0015AE2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008FDD RID: 36829 RVA: 0x0015CC3C File Offset: 0x0015AE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008FDE RID: 36830 RVA: 0x0015CC48 File Offset: 0x0015AE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AttrId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AttrId);
			}
			if (this.Ratio != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Ratio);
			}
			if (this.BaseMaxValue != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BaseMaxValue);
			}
			if (this.MaxValue != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MaxValue);
			}
			if (this.CurrentValue != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CurrentValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008FDF RID: 36831 RVA: 0x0015CCF4 File Offset: 0x0015AEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AttrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AttrId);
			}
			if (this.Ratio != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Ratio);
			}
			if (this.BaseMaxValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BaseMaxValue);
			}
			if (this.MaxValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxValue);
			}
			if (this.CurrentValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrentValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008FE0 RID: 36832 RVA: 0x0015CD94 File Offset: 0x0015AF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationAttr other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AttrId != 0)
			{
				this.AttrId = other.AttrId;
			}
			if (other.Ratio != 0)
			{
				this.Ratio = other.Ratio;
			}
			if (other.BaseMaxValue != 0)
			{
				this.BaseMaxValue = other.BaseMaxValue;
			}
			if (other.MaxValue != 0)
			{
				this.MaxValue = other.MaxValue;
			}
			if (other.CurrentValue != 0)
			{
				this.CurrentValue = other.CurrentValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008FE1 RID: 36833 RVA: 0x0015CE20 File Offset: 0x0015B020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008FE2 RID: 36834 RVA: 0x0015CE2C File Offset: 0x0015B02C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.AttrId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Ratio = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.BaseMaxValue = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.MaxValue = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.CurrentValue = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004624 RID: 17956
		private static readonly MessageParser<FormationAttr> _parser = new MessageParser<FormationAttr>(() => new FormationAttr());

		// Token: 0x04004625 RID: 17957
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004626 RID: 17958
		public const int AttrIdFieldNumber = 1;

		// Token: 0x04004627 RID: 17959
		private int attrId_;

		// Token: 0x04004628 RID: 17960
		public const int RatioFieldNumber = 2;

		// Token: 0x04004629 RID: 17961
		private int ratio_;

		// Token: 0x0400462A RID: 17962
		public const int BaseMaxValueFieldNumber = 3;

		// Token: 0x0400462B RID: 17963
		private int baseMaxValue_;

		// Token: 0x0400462C RID: 17964
		public const int MaxValueFieldNumber = 4;

		// Token: 0x0400462D RID: 17965
		private int maxValue_;

		// Token: 0x0400462E RID: 17966
		public const int CurrentValueFieldNumber = 5;

		// Token: 0x0400462F RID: 17967
		private int currentValue_;
	}
}
