using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002C6 RID: 710
	[NetMessage(EMessageId.CommonTouchUiSettingUpdateResponse)]
	public sealed class CommonTouchUiSettingUpdateResponse : IMessage<CommonTouchUiSettingUpdateResponse>, IMessage, IEquatable<CommonTouchUiSettingUpdateResponse>, IDeepCloneable<CommonTouchUiSettingUpdateResponse>, IBufferMessage
	{
		// Token: 0x06004947 RID: 18759 RVA: 0x000B3C41 File Offset: 0x000B1E41
		[NullableContext(1)]
		public static CommonTouchUiSettingUpdateResponse Create()
		{
			return new CommonTouchUiSettingUpdateResponse();
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06004948 RID: 18760 RVA: 0x000B3C48 File Offset: 0x000B1E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06004949 RID: 18761 RVA: 0x000B3C4B File Offset: 0x000B1E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommonTouchUiSettingUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0600494A RID: 18762 RVA: 0x000B3C52 File Offset: 0x000B1E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonTouchUiSettingUpdateResponse()
		{
		}

		// Token: 0x0600494B RID: 18763 RVA: 0x000B3C5A File Offset: 0x000B1E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonTouchUiSettingUpdateResponse(CommonTouchUiSettingUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600494C RID: 18764 RVA: 0x000B3C7F File Offset: 0x000B1E7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonTouchUiSettingUpdateResponse Clone()
		{
			return new CommonTouchUiSettingUpdateResponse(this);
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x0600494D RID: 18765 RVA: 0x000B3C87 File Offset: 0x000B1E87
		// (set) Token: 0x0600494E RID: 18766 RVA: 0x000B3C8F File Offset: 0x000B1E8F
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

		// Token: 0x0600494F RID: 18767 RVA: 0x000B3C98 File Offset: 0x000B1E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommonTouchUiSettingUpdateResponse);
		}

		// Token: 0x06004950 RID: 18768 RVA: 0x000B3CA6 File Offset: 0x000B1EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommonTouchUiSettingUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004951 RID: 18769 RVA: 0x000B3CD4 File Offset: 0x000B1ED4
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

		// Token: 0x06004952 RID: 18770 RVA: 0x000B3D19 File Offset: 0x000B1F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004953 RID: 18771 RVA: 0x000B3D26 File Offset: 0x000B1F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004954 RID: 18772 RVA: 0x000B3D2F File Offset: 0x000B1F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004955 RID: 18773 RVA: 0x000B3D64 File Offset: 0x000B1F64
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

		// Token: 0x06004956 RID: 18774 RVA: 0x000B3DA2 File Offset: 0x000B1FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CommonTouchUiSettingUpdateResponse other)
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

		// Token: 0x06004957 RID: 18775 RVA: 0x000B3DD3 File Offset: 0x000B1FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004958 RID: 18776 RVA: 0x000B3DDC File Offset: 0x000B1FDC
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003079 RID: 12409
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400307A RID: 12410
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400307B RID: 12411
		private ErrorCode errorCode_;
	}
}
