using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015A5 RID: 5541
	[NetMessage(EMessageId.XboxSettingUpdateResponse)]
	public sealed class XboxSettingUpdateResponse : IMessage<XboxSettingUpdateResponse>, IMessage, IEquatable<XboxSettingUpdateResponse>, IDeepCloneable<XboxSettingUpdateResponse>, IBufferMessage
	{
		// Token: 0x0601D53D RID: 120125 RVA: 0x0043EBC0 File Offset: 0x0043CDC0
		[NullableContext(1)]
		public static XboxSettingUpdateResponse Create()
		{
			return new XboxSettingUpdateResponse();
		}

		// Token: 0x17006339 RID: 25401
		// (get) Token: 0x0601D53E RID: 120126 RVA: 0x0043EBC7 File Offset: 0x0043CDC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700633A RID: 25402
		// (get) Token: 0x0601D53F RID: 120127 RVA: 0x0043EBCA File Offset: 0x0043CDCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return XboxSettingUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0601D540 RID: 120128 RVA: 0x0043EBD1 File Offset: 0x0043CDD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingUpdateResponse()
		{
		}

		// Token: 0x0601D541 RID: 120129 RVA: 0x0043EBD9 File Offset: 0x0043CDD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingUpdateResponse(XboxSettingUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D542 RID: 120130 RVA: 0x0043EBFE File Offset: 0x0043CDFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public XboxSettingUpdateResponse Clone()
		{
			return new XboxSettingUpdateResponse(this);
		}

		// Token: 0x1700633B RID: 25403
		// (get) Token: 0x0601D543 RID: 120131 RVA: 0x0043EC06 File Offset: 0x0043CE06
		// (set) Token: 0x0601D544 RID: 120132 RVA: 0x0043EC0E File Offset: 0x0043CE0E
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

		// Token: 0x0601D545 RID: 120133 RVA: 0x0043EC17 File Offset: 0x0043CE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as XboxSettingUpdateResponse);
		}

		// Token: 0x0601D546 RID: 120134 RVA: 0x0043EC25 File Offset: 0x0043CE25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(XboxSettingUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D547 RID: 120135 RVA: 0x0043EC54 File Offset: 0x0043CE54
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

		// Token: 0x0601D548 RID: 120136 RVA: 0x0043EC99 File Offset: 0x0043CE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D549 RID: 120137 RVA: 0x0043ECA6 File Offset: 0x0043CEA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D54A RID: 120138 RVA: 0x0043ECAF File Offset: 0x0043CEAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D54B RID: 120139 RVA: 0x0043ECE4 File Offset: 0x0043CEE4
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

		// Token: 0x0601D54C RID: 120140 RVA: 0x0043ED22 File Offset: 0x0043CF22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(XboxSettingUpdateResponse other)
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

		// Token: 0x0601D54D RID: 120141 RVA: 0x0043ED53 File Offset: 0x0043CF53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D54E RID: 120142 RVA: 0x0043ED5C File Offset: 0x0043CF5C
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A822 RID: 43042
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A823 RID: 43043
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400A824 RID: 43044
		private ErrorCode errorCode_;
	}
}
