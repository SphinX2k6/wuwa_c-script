using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DD3 RID: 3539
	[NetMessage(EMessageId.PrivateChatOperateResponse)]
	public sealed class PrivateChatOperateResponse : IMessage<PrivateChatOperateResponse>, IMessage, IEquatable<PrivateChatOperateResponse>, IDeepCloneable<PrivateChatOperateResponse>, IBufferMessage
	{
		// Token: 0x06013121 RID: 78113 RVA: 0x002C7CE0 File Offset: 0x002C5EE0
		[NullableContext(1)]
		public static PrivateChatOperateResponse Create()
		{
			return new PrivateChatOperateResponse();
		}

		// Token: 0x17003F49 RID: 16201
		// (get) Token: 0x06013122 RID: 78114 RVA: 0x002C7CE7 File Offset: 0x002C5EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F4A RID: 16202
		// (get) Token: 0x06013123 RID: 78115 RVA: 0x002C7CEA File Offset: 0x002C5EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatOperateResponse.Descriptor;
			}
		}

		// Token: 0x06013124 RID: 78116 RVA: 0x002C7CF1 File Offset: 0x002C5EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatOperateResponse()
		{
		}

		// Token: 0x06013125 RID: 78117 RVA: 0x002C7CF9 File Offset: 0x002C5EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatOperateResponse(PrivateChatOperateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013126 RID: 78118 RVA: 0x002C7D1E File Offset: 0x002C5F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatOperateResponse Clone()
		{
			return new PrivateChatOperateResponse(this);
		}

		// Token: 0x17003F4B RID: 16203
		// (get) Token: 0x06013127 RID: 78119 RVA: 0x002C7D26 File Offset: 0x002C5F26
		// (set) Token: 0x06013128 RID: 78120 RVA: 0x002C7D2E File Offset: 0x002C5F2E
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

		// Token: 0x06013129 RID: 78121 RVA: 0x002C7D37 File Offset: 0x002C5F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatOperateResponse);
		}

		// Token: 0x0601312A RID: 78122 RVA: 0x002C7D45 File Offset: 0x002C5F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatOperateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601312B RID: 78123 RVA: 0x002C7D74 File Offset: 0x002C5F74
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

		// Token: 0x0601312C RID: 78124 RVA: 0x002C7DB9 File Offset: 0x002C5FB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601312D RID: 78125 RVA: 0x002C7DC6 File Offset: 0x002C5FC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601312E RID: 78126 RVA: 0x002C7DCF File Offset: 0x002C5FCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601312F RID: 78127 RVA: 0x002C7E04 File Offset: 0x002C6004
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

		// Token: 0x06013130 RID: 78128 RVA: 0x002C7E42 File Offset: 0x002C6042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrivateChatOperateResponse other)
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

		// Token: 0x06013131 RID: 78129 RVA: 0x002C7E73 File Offset: 0x002C6073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013132 RID: 78130 RVA: 0x002C7E7C File Offset: 0x002C607C
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007608 RID: 30216
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007609 RID: 30217
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400760A RID: 30218
		private ErrorCode errorCode_;
	}
}
