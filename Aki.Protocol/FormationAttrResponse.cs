using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000628 RID: 1576
	[NetMessage(EMessageId.FormationAttrResponse)]
	public sealed class FormationAttrResponse : IMessage<FormationAttrResponse>, IMessage, IEquatable<FormationAttrResponse>, IDeepCloneable<FormationAttrResponse>, IBufferMessage
	{
		// Token: 0x06009162 RID: 37218 RVA: 0x0015FE68 File Offset: 0x0015E068
		[NullableContext(1)]
		public static FormationAttrResponse Create()
		{
			return new FormationAttrResponse();
		}

		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x06009163 RID: 37219 RVA: 0x0015FE6F File Offset: 0x0015E06F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x06009164 RID: 37220 RVA: 0x0015FE72 File Offset: 0x0015E072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationAttrResponse.Descriptor;
			}
		}

		// Token: 0x06009165 RID: 37221 RVA: 0x0015FE79 File Offset: 0x0015E079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttrResponse()
		{
		}

		// Token: 0x06009166 RID: 37222 RVA: 0x0015FE81 File Offset: 0x0015E081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttrResponse(FormationAttrResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009167 RID: 37223 RVA: 0x0015FEA6 File Offset: 0x0015E0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationAttrResponse Clone()
		{
			return new FormationAttrResponse(this);
		}

		// Token: 0x17001CE9 RID: 7401
		// (get) Token: 0x06009168 RID: 37224 RVA: 0x0015FEAE File Offset: 0x0015E0AE
		// (set) Token: 0x06009169 RID: 37225 RVA: 0x0015FEB6 File Offset: 0x0015E0B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0600916A RID: 37226 RVA: 0x0015FEBF File Offset: 0x0015E0BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationAttrResponse);
		}

		// Token: 0x0600916B RID: 37227 RVA: 0x0015FECD File Offset: 0x0015E0CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationAttrResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600916C RID: 37228 RVA: 0x0015FEFC File Offset: 0x0015E0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600916D RID: 37229 RVA: 0x0015FF41 File Offset: 0x0015E141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600916E RID: 37230 RVA: 0x0015FF4E File Offset: 0x0015E14E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600916F RID: 37231 RVA: 0x0015FF57 File Offset: 0x0015E157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009170 RID: 37232 RVA: 0x0015FF8C File Offset: 0x0015E18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009171 RID: 37233 RVA: 0x0015FFCA File Offset: 0x0015E1CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationAttrResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009172 RID: 37234 RVA: 0x0015FFFB File Offset: 0x0015E1FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009173 RID: 37235 RVA: 0x00160004 File Offset: 0x0015E204
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004643 RID: 17987
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004644 RID: 17988
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04004645 RID: 17989
		private ErrorCode errorCode_;
	}
}
