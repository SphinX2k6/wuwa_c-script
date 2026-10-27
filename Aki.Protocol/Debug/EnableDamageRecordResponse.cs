using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x02001698 RID: 5784
	[NetMessage(EMessageId.EnableDamageRecordResponse)]
	public sealed class EnableDamageRecordResponse : IMessage<EnableDamageRecordResponse>, IMessage, IEquatable<EnableDamageRecordResponse>, IDeepCloneable<EnableDamageRecordResponse>, IBufferMessage
	{
		// Token: 0x0601CFDD RID: 118749 RVA: 0x0043E88B File Offset: 0x0043CA8B
		[NullableContext(1)]
		public static EnableDamageRecordResponse Create()
		{
			return new EnableDamageRecordResponse();
		}

		// Token: 0x17006262 RID: 25186
		// (get) Token: 0x0601CFDE RID: 118750 RVA: 0x0043E892 File Offset: 0x0043CA92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006263 RID: 25187
		// (get) Token: 0x0601CFDF RID: 118751 RVA: 0x0043E895 File Offset: 0x0043CA95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnableDamageRecordResponse.Descriptor;
			}
		}

		// Token: 0x0601CFE0 RID: 118752 RVA: 0x0043E89C File Offset: 0x0043CA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableDamageRecordResponse()
		{
		}

		// Token: 0x0601CFE1 RID: 118753 RVA: 0x0043E8A4 File Offset: 0x0043CAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableDamageRecordResponse(EnableDamageRecordResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CFE2 RID: 118754 RVA: 0x0043E8C9 File Offset: 0x0043CAC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableDamageRecordResponse Clone()
		{
			return new EnableDamageRecordResponse(this);
		}

		// Token: 0x17006264 RID: 25188
		// (get) Token: 0x0601CFE3 RID: 118755 RVA: 0x0043E8D1 File Offset: 0x0043CAD1
		// (set) Token: 0x0601CFE4 RID: 118756 RVA: 0x0043E8D9 File Offset: 0x0043CAD9
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

		// Token: 0x0601CFE5 RID: 118757 RVA: 0x0043E8E2 File Offset: 0x0043CAE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnableDamageRecordResponse);
		}

		// Token: 0x0601CFE6 RID: 118758 RVA: 0x0043E8F0 File Offset: 0x0043CAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnableDamageRecordResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CFE7 RID: 118759 RVA: 0x0043E920 File Offset: 0x0043CB20
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

		// Token: 0x0601CFE8 RID: 118760 RVA: 0x0043E965 File Offset: 0x0043CB65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CFE9 RID: 118761 RVA: 0x0043E972 File Offset: 0x0043CB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CFEA RID: 118762 RVA: 0x0043E97B File Offset: 0x0043CB7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CFEB RID: 118763 RVA: 0x0043E9B0 File Offset: 0x0043CBB0
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

		// Token: 0x0601CFEC RID: 118764 RVA: 0x0043E9EE File Offset: 0x0043CBEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnableDamageRecordResponse other)
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

		// Token: 0x0601CFED RID: 118765 RVA: 0x0043EA1F File Offset: 0x0043CC1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CFEE RID: 118766 RVA: 0x0043EA28 File Offset: 0x0043CC28
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400C3CA RID: 50122
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C3CB RID: 50123
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400C3CC RID: 50124
		private ErrorCode errorCode_;
	}
}
