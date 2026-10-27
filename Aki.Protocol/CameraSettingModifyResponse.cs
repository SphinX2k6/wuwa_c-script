using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200022D RID: 557
	[NetMessage(EMessageId.CameraSettingModifyResponse)]
	public sealed class CameraSettingModifyResponse : IMessage<CameraSettingModifyResponse>, IMessage, IEquatable<CameraSettingModifyResponse>, IDeepCloneable<CameraSettingModifyResponse>, IBufferMessage
	{
		// Token: 0x06003C81 RID: 15489 RVA: 0x000966B0 File Offset: 0x000948B0
		[NullableContext(1)]
		public static CameraSettingModifyResponse Create()
		{
			return new CameraSettingModifyResponse();
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06003C82 RID: 15490 RVA: 0x000966B7 File Offset: 0x000948B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06003C83 RID: 15491 RVA: 0x000966BA File Offset: 0x000948BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CameraSettingModifyResponse.Descriptor;
			}
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x000966C1 File Offset: 0x000948C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingModifyResponse()
		{
		}

		// Token: 0x06003C85 RID: 15493 RVA: 0x000966C9 File Offset: 0x000948C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingModifyResponse(CameraSettingModifyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003C86 RID: 15494 RVA: 0x000966EE File Offset: 0x000948EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CameraSettingModifyResponse Clone()
		{
			return new CameraSettingModifyResponse(this);
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06003C87 RID: 15495 RVA: 0x000966F6 File Offset: 0x000948F6
		// (set) Token: 0x06003C88 RID: 15496 RVA: 0x000966FE File Offset: 0x000948FE
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

		// Token: 0x06003C89 RID: 15497 RVA: 0x00096707 File Offset: 0x00094907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CameraSettingModifyResponse);
		}

		// Token: 0x06003C8A RID: 15498 RVA: 0x00096715 File Offset: 0x00094915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CameraSettingModifyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x00096744 File Offset: 0x00094944
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

		// Token: 0x06003C8C RID: 15500 RVA: 0x00096789 File Offset: 0x00094989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x00096796 File Offset: 0x00094996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x0009679F File Offset: 0x0009499F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003C8F RID: 15503 RVA: 0x000967D4 File Offset: 0x000949D4
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

		// Token: 0x06003C90 RID: 15504 RVA: 0x00096812 File Offset: 0x00094A12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CameraSettingModifyResponse other)
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

		// Token: 0x06003C91 RID: 15505 RVA: 0x00096843 File Offset: 0x00094A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003C92 RID: 15506 RVA: 0x0009684C File Offset: 0x00094A4C
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002C7A RID: 11386
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C7B RID: 11387
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04002C7C RID: 11388
		private ErrorCode errorCode_;
	}
}
