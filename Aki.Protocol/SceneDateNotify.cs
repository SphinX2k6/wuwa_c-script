using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001186 RID: 4486
	[NetMessage(EMessageId.SceneDateNotify)]
	public sealed class SceneDateNotify : IMessage<SceneDateNotify>, IMessage, IEquatable<SceneDateNotify>, IDeepCloneable<SceneDateNotify>, IBufferMessage
	{
		// Token: 0x06017F58 RID: 98136 RVA: 0x0037CA30 File Offset: 0x0037AC30
		[NullableContext(1)]
		public static SceneDateNotify Create()
		{
			return new SceneDateNotify();
		}

		// Token: 0x170050A6 RID: 20646
		// (get) Token: 0x06017F59 RID: 98137 RVA: 0x0037CA37 File Offset: 0x0037AC37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050A7 RID: 20647
		// (get) Token: 0x06017F5A RID: 98138 RVA: 0x0037CA3A File Offset: 0x0037AC3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneDateNotify.Descriptor;
			}
		}

		// Token: 0x06017F5B RID: 98139 RVA: 0x0037CA41 File Offset: 0x0037AC41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneDateNotify()
		{
		}

		// Token: 0x06017F5C RID: 98140 RVA: 0x0037CA49 File Offset: 0x0037AC49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneDateNotify(SceneDateNotify other) : this()
		{
			this.currDate_ = other.currDate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017F5D RID: 98141 RVA: 0x0037CA6E File Offset: 0x0037AC6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneDateNotify Clone()
		{
			return new SceneDateNotify(this);
		}

		// Token: 0x170050A8 RID: 20648
		// (get) Token: 0x06017F5E RID: 98142 RVA: 0x0037CA76 File Offset: 0x0037AC76
		// (set) Token: 0x06017F5F RID: 98143 RVA: 0x0037CA7E File Offset: 0x0037AC7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurrDate
		{
			get
			{
				return this.currDate_;
			}
			set
			{
				this.currDate_ = value;
			}
		}

		// Token: 0x06017F60 RID: 98144 RVA: 0x0037CA87 File Offset: 0x0037AC87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneDateNotify);
		}

		// Token: 0x06017F61 RID: 98145 RVA: 0x0037CA95 File Offset: 0x0037AC95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneDateNotify other)
		{
			return other != null && (other == this || (this.CurrDate == other.CurrDate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017F62 RID: 98146 RVA: 0x0037CAC4 File Offset: 0x0037ACC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurrDate != 0U)
			{
				num ^= this.CurrDate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017F63 RID: 98147 RVA: 0x0037CB03 File Offset: 0x0037AD03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017F64 RID: 98148 RVA: 0x0037CB10 File Offset: 0x0037AD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017F65 RID: 98149 RVA: 0x0037CB19 File Offset: 0x0037AD19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurrDate != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.CurrDate);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017F66 RID: 98150 RVA: 0x0037CB4C File Offset: 0x0037AD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurrDate != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurrDate);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017F67 RID: 98151 RVA: 0x0037CB8A File Offset: 0x0037AD8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneDateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurrDate != 0U)
			{
				this.CurrDate = other.CurrDate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017F68 RID: 98152 RVA: 0x0037CBBB File Offset: 0x0037ADBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017F69 RID: 98153 RVA: 0x0037CBC4 File Offset: 0x0037ADC4
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CurrDate = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04008EBC RID: 36540
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008EBD RID: 36541
		public const int CurrDateFieldNumber = 3;

		// Token: 0x04008EBE RID: 36542
		private uint currDate_;
	}
}
