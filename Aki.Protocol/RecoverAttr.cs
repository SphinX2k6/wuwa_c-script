using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EC5 RID: 3781
	public sealed class RecoverAttr : IMessage<RecoverAttr>, IMessage, IEquatable<RecoverAttr>, IDeepCloneable<RecoverAttr>, IBufferMessage
	{
		// Token: 0x060144BE RID: 83134 RVA: 0x002F3A17 File Offset: 0x002F1C17
		[NullableContext(1)]
		public static RecoverAttr Create()
		{
			return new RecoverAttr();
		}

		// Token: 0x1700437D RID: 17277
		// (get) Token: 0x060144BF RID: 83135 RVA: 0x002F3A1E File Offset: 0x002F1C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RecoverAttr> Parser
		{
			get
			{
				return RecoverAttr._parser;
			}
		}

		// Token: 0x1700437E RID: 17278
		// (get) Token: 0x060144C0 RID: 83136 RVA: 0x002F3A25 File Offset: 0x002F1C25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700437F RID: 17279
		// (get) Token: 0x060144C1 RID: 83137 RVA: 0x002F3A28 File Offset: 0x002F1C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecoverAttr.Descriptor;
			}
		}

		// Token: 0x060144C2 RID: 83138 RVA: 0x002F3A2F File Offset: 0x002F1C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecoverAttr()
		{
		}

		// Token: 0x060144C3 RID: 83139 RVA: 0x002F3A38 File Offset: 0x002F1C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecoverAttr(RecoverAttr other) : this()
		{
			this.attrId_ = other.attrId_;
			this.ratio_ = other.ratio_;
			this.maxValue_ = other.maxValue_;
			this.currentValue_ = other.currentValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060144C4 RID: 83140 RVA: 0x002F3A8C File Offset: 0x002F1C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecoverAttr Clone()
		{
			return new RecoverAttr(this);
		}

		// Token: 0x17004380 RID: 17280
		// (get) Token: 0x060144C5 RID: 83141 RVA: 0x002F3A94 File Offset: 0x002F1C94
		// (set) Token: 0x060144C6 RID: 83142 RVA: 0x002F3A9C File Offset: 0x002F1C9C
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

		// Token: 0x17004381 RID: 17281
		// (get) Token: 0x060144C7 RID: 83143 RVA: 0x002F3AA5 File Offset: 0x002F1CA5
		// (set) Token: 0x060144C8 RID: 83144 RVA: 0x002F3AAD File Offset: 0x002F1CAD
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

		// Token: 0x17004382 RID: 17282
		// (get) Token: 0x060144C9 RID: 83145 RVA: 0x002F3AB6 File Offset: 0x002F1CB6
		// (set) Token: 0x060144CA RID: 83146 RVA: 0x002F3ABE File Offset: 0x002F1CBE
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

		// Token: 0x17004383 RID: 17283
		// (get) Token: 0x060144CB RID: 83147 RVA: 0x002F3AC7 File Offset: 0x002F1CC7
		// (set) Token: 0x060144CC RID: 83148 RVA: 0x002F3ACF File Offset: 0x002F1CCF
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

		// Token: 0x060144CD RID: 83149 RVA: 0x002F3AD8 File Offset: 0x002F1CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecoverAttr);
		}

		// Token: 0x060144CE RID: 83150 RVA: 0x002F3AE8 File Offset: 0x002F1CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecoverAttr other)
		{
			return other != null && (other == this || (this.AttrId == other.AttrId && this.Ratio == other.Ratio && this.MaxValue == other.MaxValue && this.CurrentValue == other.CurrentValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060144CF RID: 83151 RVA: 0x002F3B54 File Offset: 0x002F1D54
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

		// Token: 0x060144D0 RID: 83152 RVA: 0x002F3BDE File Offset: 0x002F1DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060144D1 RID: 83153 RVA: 0x002F3BEB File Offset: 0x002F1DEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060144D2 RID: 83154 RVA: 0x002F3BF4 File Offset: 0x002F1DF4
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

		// Token: 0x060144D3 RID: 83155 RVA: 0x002F3C84 File Offset: 0x002F1E84
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

		// Token: 0x060144D4 RID: 83156 RVA: 0x002F3D0C File Offset: 0x002F1F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecoverAttr other)
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

		// Token: 0x060144D5 RID: 83157 RVA: 0x002F3D84 File Offset: 0x002F1F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060144D6 RID: 83158 RVA: 0x002F3D90 File Offset: 0x002F1F90
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

		// Token: 0x04007BB6 RID: 31670
		private static readonly MessageParser<RecoverAttr> _parser = new MessageParser<RecoverAttr>(() => new RecoverAttr());

		// Token: 0x04007BB7 RID: 31671
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BB8 RID: 31672
		public const int AttrIdFieldNumber = 1;

		// Token: 0x04007BB9 RID: 31673
		private int attrId_;

		// Token: 0x04007BBA RID: 31674
		public const int RatioFieldNumber = 2;

		// Token: 0x04007BBB RID: 31675
		private int ratio_;

		// Token: 0x04007BBC RID: 31676
		public const int MaxValueFieldNumber = 4;

		// Token: 0x04007BBD RID: 31677
		private int maxValue_;

		// Token: 0x04007BBE RID: 31678
		public const int CurrentValueFieldNumber = 5;

		// Token: 0x04007BBF RID: 31679
		private int currentValue_;
	}
}
