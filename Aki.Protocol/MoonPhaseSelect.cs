using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A14 RID: 2580
	public sealed class MoonPhaseSelect : IMessage<MoonPhaseSelect>, IMessage, IEquatable<MoonPhaseSelect>, IDeepCloneable<MoonPhaseSelect>, IBufferMessage
	{
		// Token: 0x0600E1A4 RID: 57764 RVA: 0x00210B21 File Offset: 0x0020ED21
		[NullableContext(1)]
		public static MoonPhaseSelect Create()
		{
			return new MoonPhaseSelect();
		}

		// Token: 0x17002DBD RID: 11709
		// (get) Token: 0x0600E1A5 RID: 57765 RVA: 0x00210B28 File Offset: 0x0020ED28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MoonPhaseSelect> Parser
		{
			get
			{
				return MoonPhaseSelect._parser;
			}
		}

		// Token: 0x17002DBE RID: 11710
		// (get) Token: 0x0600E1A6 RID: 57766 RVA: 0x00210B2F File Offset: 0x0020ED2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DBF RID: 11711
		// (get) Token: 0x0600E1A7 RID: 57767 RVA: 0x00210B32 File Offset: 0x0020ED32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoonPhaseSelect.Descriptor;
			}
		}

		// Token: 0x0600E1A8 RID: 57768 RVA: 0x00210B39 File Offset: 0x0020ED39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseSelect()
		{
		}

		// Token: 0x0600E1A9 RID: 57769 RVA: 0x00210B41 File Offset: 0x0020ED41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseSelect(MoonPhaseSelect other) : this()
		{
			this.moonPhaseId_ = other.moonPhaseId_;
			this.label1_ = other.label1_;
			this.label2_ = other.label2_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E1AA RID: 57770 RVA: 0x00210B7E File Offset: 0x0020ED7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoonPhaseSelect Clone()
		{
			return new MoonPhaseSelect(this);
		}

		// Token: 0x17002DC0 RID: 11712
		// (get) Token: 0x0600E1AB RID: 57771 RVA: 0x00210B86 File Offset: 0x0020ED86
		// (set) Token: 0x0600E1AC RID: 57772 RVA: 0x00210B8E File Offset: 0x0020ED8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoonPhaseId
		{
			get
			{
				return this.moonPhaseId_;
			}
			set
			{
				this.moonPhaseId_ = value;
			}
		}

		// Token: 0x17002DC1 RID: 11713
		// (get) Token: 0x0600E1AD RID: 57773 RVA: 0x00210B97 File Offset: 0x0020ED97
		// (set) Token: 0x0600E1AE RID: 57774 RVA: 0x00210B9F File Offset: 0x0020ED9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Label1
		{
			get
			{
				return this.label1_;
			}
			set
			{
				this.label1_ = value;
			}
		}

		// Token: 0x17002DC2 RID: 11714
		// (get) Token: 0x0600E1AF RID: 57775 RVA: 0x00210BA8 File Offset: 0x0020EDA8
		// (set) Token: 0x0600E1B0 RID: 57776 RVA: 0x00210BB0 File Offset: 0x0020EDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Label2
		{
			get
			{
				return this.label2_;
			}
			set
			{
				this.label2_ = value;
			}
		}

		// Token: 0x0600E1B1 RID: 57777 RVA: 0x00210BB9 File Offset: 0x0020EDB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoonPhaseSelect);
		}

		// Token: 0x0600E1B2 RID: 57778 RVA: 0x00210BC8 File Offset: 0x0020EDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoonPhaseSelect other)
		{
			return other != null && (other == this || (this.MoonPhaseId == other.MoonPhaseId && this.Label1 == other.Label1 && this.Label2 == other.Label2 && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E1B3 RID: 57779 RVA: 0x00210C24 File Offset: 0x0020EE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MoonPhaseId != 0)
			{
				num ^= this.MoonPhaseId.GetHashCode();
			}
			if (this.Label1 != 0)
			{
				num ^= this.Label1.GetHashCode();
			}
			if (this.Label2 != 0)
			{
				num ^= this.Label2.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E1B4 RID: 57780 RVA: 0x00210C95 File Offset: 0x0020EE95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E1B5 RID: 57781 RVA: 0x00210CA2 File Offset: 0x0020EEA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E1B6 RID: 57782 RVA: 0x00210CAC File Offset: 0x0020EEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MoonPhaseId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MoonPhaseId);
			}
			if (this.Label1 != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Label1);
			}
			if (this.Label2 != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Label2);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E1B7 RID: 57783 RVA: 0x00210D20 File Offset: 0x0020EF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MoonPhaseId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MoonPhaseId);
			}
			if (this.Label1 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Label1);
			}
			if (this.Label2 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Label2);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E1B8 RID: 57784 RVA: 0x00210D90 File Offset: 0x0020EF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoonPhaseSelect other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MoonPhaseId != 0)
			{
				this.MoonPhaseId = other.MoonPhaseId;
			}
			if (other.Label1 != 0)
			{
				this.Label1 = other.Label1;
			}
			if (other.Label2 != 0)
			{
				this.Label2 = other.Label2;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E1B9 RID: 57785 RVA: 0x00210DF4 File Offset: 0x0020EFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E1BA RID: 57786 RVA: 0x00210E00 File Offset: 0x0020F000
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
							this.Label2 = input.ReadInt32();
						}
					}
					else
					{
						this.Label1 = input.ReadInt32();
					}
				}
				else
				{
					this.MoonPhaseId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005CB1 RID: 23729
		private static readonly MessageParser<MoonPhaseSelect> _parser = new MessageParser<MoonPhaseSelect>(() => new MoonPhaseSelect());

		// Token: 0x04005CB2 RID: 23730
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CB3 RID: 23731
		public const int MoonPhaseIdFieldNumber = 1;

		// Token: 0x04005CB4 RID: 23732
		private int moonPhaseId_;

		// Token: 0x04005CB5 RID: 23733
		public const int Label1FieldNumber = 2;

		// Token: 0x04005CB6 RID: 23734
		private int label1_;

		// Token: 0x04005CB7 RID: 23735
		public const int Label2FieldNumber = 3;

		// Token: 0x04005CB8 RID: 23736
		private int label2_;
	}
}
