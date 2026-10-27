using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002C0 RID: 704
	[NetMessage(EMessageId.CommonTouchUiSettingUpdateResponse)]
	public sealed class CommonTouchUiSettingUpdateResponse : IMessage<CommonTouchUiSettingUpdateResponse>, IMessage, IEquatable<CommonTouchUiSettingUpdateResponse>, IDeepCloneable<CommonTouchUiSettingUpdateResponse>, IBufferMessage
	{
		// Token: 0x06004880 RID: 18560 RVA: 0x000B1A39 File Offset: 0x000AFC39
		[NullableContext(1)]
		public static CommonTouchUiSettingUpdateResponse Create()
		{
			return new CommonTouchUiSettingUpdateResponse();
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06004881 RID: 18561 RVA: 0x000B1A40 File Offset: 0x000AFC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06004882 RID: 18562 RVA: 0x000B1A43 File Offset: 0x000AFC43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommonTouchUiSettingUpdateResponse.Descriptor;
			}
		}

		// Token: 0x06004883 RID: 18563 RVA: 0x000B1A4A File Offset: 0x000AFC4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonTouchUiSettingUpdateResponse()
		{
		}

		// Token: 0x06004884 RID: 18564 RVA: 0x000B1A52 File Offset: 0x000AFC52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonTouchUiSettingUpdateResponse(CommonTouchUiSettingUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004885 RID: 18565 RVA: 0x000B1A77 File Offset: 0x000AFC77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonTouchUiSettingUpdateResponse Clone()
		{
			return new CommonTouchUiSettingUpdateResponse(this);
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06004886 RID: 18566 RVA: 0x000B1A7F File Offset: 0x000AFC7F
		// (set) Token: 0x06004887 RID: 18567 RVA: 0x000B1A87 File Offset: 0x000AFC87
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

		// Token: 0x06004888 RID: 18568 RVA: 0x000B1A90 File Offset: 0x000AFC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommonTouchUiSettingUpdateResponse);
		}

		// Token: 0x06004889 RID: 18569 RVA: 0x000B1A9E File Offset: 0x000AFC9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommonTouchUiSettingUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600488A RID: 18570 RVA: 0x000B1ACC File Offset: 0x000AFCCC
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

		// Token: 0x0600488B RID: 18571 RVA: 0x000B1B11 File Offset: 0x000AFD11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600488C RID: 18572 RVA: 0x000B1B1E File Offset: 0x000AFD1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600488D RID: 18573 RVA: 0x000B1B27 File Offset: 0x000AFD27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600488E RID: 18574 RVA: 0x000B1B5C File Offset: 0x000AFD5C
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

		// Token: 0x0600488F RID: 18575 RVA: 0x000B1B9A File Offset: 0x000AFD9A
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

		// Token: 0x06004890 RID: 18576 RVA: 0x000B1BCB File Offset: 0x000AFDCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004891 RID: 18577 RVA: 0x000B1BD4 File Offset: 0x000AFDD4
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002FE6 RID: 12262
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FE7 RID: 12263
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04002FE8 RID: 12264
		private ErrorCode errorCode_;
	}
}
