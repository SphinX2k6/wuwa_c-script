using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000625 RID: 1573
	public sealed class FormationAttr : IMessage<FormationAttr>, IMessage, IEquatable<FormationAttr>, IDeepCloneable<FormationAttr>, IBufferMessage
	{
		// Token: 0x0600911E RID: 37150 RVA: 0x0015F452 File Offset: 0x0015D652
		[NullableContext(1)]
		public static FormationAttr Create()
		{
			return new FormationAttr();
		}

		// Token: 0x17001CD7 RID: 7383
		// (get) Token: 0x0600911F RID: 37151 RVA: 0x0015F459 File Offset: 0x0015D659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FormationAttr> Parser
		{
			get
			{
				return FormationAttr._parser;
			}
		}

		// Token: 0x17001CD8 RID: 7384
		// (get) Token: 0x06009120 RID: 37152 RVA: 0x0015F460 File Offset: 0x0015D660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x06009121 RID: 37153 RVA: 0x0015F463 File Offset: 0x0015D663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationAttr.Descriptor;
			}
		}

		// Token: 0x06009122 RID: 37154 RVA: 0x0015F46A File Offset: 0x0015D66A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttr()
		{
		}

		// Token: 0x06009123 RID: 37155 RVA: 0x0015F474 File Offset: 0x0015D674
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

		// Token: 0x06009124 RID: 37156 RVA: 0x0015F4D4 File Offset: 0x0015D6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttr Clone()
		{
			return new FormationAttr(this);
		}

		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x06009125 RID: 37157 RVA: 0x0015F4DC File Offset: 0x0015D6DC
		// (set) Token: 0x06009126 RID: 37158 RVA: 0x0015F4E4 File Offset: 0x0015D6E4
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

		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x06009127 RID: 37159 RVA: 0x0015F4ED File Offset: 0x0015D6ED
		// (set) Token: 0x06009128 RID: 37160 RVA: 0x0015F4F5 File Offset: 0x0015D6F5
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

		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x06009129 RID: 37161 RVA: 0x0015F4FE File Offset: 0x0015D6FE
		// (set) Token: 0x0600912A RID: 37162 RVA: 0x0015F506 File Offset: 0x0015D706
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

		// Token: 0x17001CDD RID: 7389
		// (get) Token: 0x0600912B RID: 37163 RVA: 0x0015F50F File Offset: 0x0015D70F
		// (set) Token: 0x0600912C RID: 37164 RVA: 0x0015F517 File Offset: 0x0015D717
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

		// Token: 0x17001CDE RID: 7390
		// (get) Token: 0x0600912D RID: 37165 RVA: 0x0015F520 File Offset: 0x0015D720
		// (set) Token: 0x0600912E RID: 37166 RVA: 0x0015F528 File Offset: 0x0015D728
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

		// Token: 0x0600912F RID: 37167 RVA: 0x0015F531 File Offset: 0x0015D731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationAttr);
		}

		// Token: 0x06009130 RID: 37168 RVA: 0x0015F540 File Offset: 0x0015D740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationAttr other)
		{
			return other != null && (other == this || (this.AttrId == other.AttrId && this.Ratio == other.Ratio && this.BaseMaxValue == other.BaseMaxValue && this.MaxValue == other.MaxValue && this.CurrentValue == other.CurrentValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009131 RID: 37169 RVA: 0x0015F5BC File Offset: 0x0015D7BC
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

		// Token: 0x06009132 RID: 37170 RVA: 0x0015F65F File Offset: 0x0015D85F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009133 RID: 37171 RVA: 0x0015F66C File Offset: 0x0015D86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009134 RID: 37172 RVA: 0x0015F678 File Offset: 0x0015D878
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

		// Token: 0x06009135 RID: 37173 RVA: 0x0015F724 File Offset: 0x0015D924
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

		// Token: 0x06009136 RID: 37174 RVA: 0x0015F7C4 File Offset: 0x0015D9C4
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

		// Token: 0x06009137 RID: 37175 RVA: 0x0015F850 File Offset: 0x0015DA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009138 RID: 37176 RVA: 0x0015F85C File Offset: 0x0015DA5C
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

		// Token: 0x0400462B RID: 17963
		private static readonly MessageParser<FormationAttr> _parser = new MessageParser<FormationAttr>(() => new FormationAttr());

		// Token: 0x0400462C RID: 17964
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400462D RID: 17965
		public const int AttrIdFieldNumber = 1;

		// Token: 0x0400462E RID: 17966
		private int attrId_;

		// Token: 0x0400462F RID: 17967
		public const int RatioFieldNumber = 2;

		// Token: 0x04004630 RID: 17968
		private int ratio_;

		// Token: 0x04004631 RID: 17969
		public const int BaseMaxValueFieldNumber = 3;

		// Token: 0x04004632 RID: 17970
		private int baseMaxValue_;

		// Token: 0x04004633 RID: 17971
		public const int MaxValueFieldNumber = 4;

		// Token: 0x04004634 RID: 17972
		private int maxValue_;

		// Token: 0x04004635 RID: 17973
		public const int CurrentValueFieldNumber = 5;

		// Token: 0x04004636 RID: 17974
		private int currentValue_;
	}
}
