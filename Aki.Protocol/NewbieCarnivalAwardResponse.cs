using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AF0 RID: 2800
	[NetMessage(EMessageId.NewbieCarnivalAwardResponse)]
	public sealed class NewbieCarnivalAwardResponse : IMessage<NewbieCarnivalAwardResponse>, IMessage, IEquatable<NewbieCarnivalAwardResponse>, IDeepCloneable<NewbieCarnivalAwardResponse>, IBufferMessage
	{
		// Token: 0x0600F3C2 RID: 62402 RVA: 0x00239B68 File Offset: 0x00237D68
		[NullableContext(1)]
		public static NewbieCarnivalAwardResponse Create()
		{
			return new NewbieCarnivalAwardResponse();
		}

		// Token: 0x170031A3 RID: 12707
		// (get) Token: 0x0600F3C3 RID: 62403 RVA: 0x00239B6F File Offset: 0x00237D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031A4 RID: 12708
		// (get) Token: 0x0600F3C4 RID: 62404 RVA: 0x00239B72 File Offset: 0x00237D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCarnivalAwardResponse.Descriptor;
			}
		}

		// Token: 0x0600F3C5 RID: 62405 RVA: 0x00239B79 File Offset: 0x00237D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalAwardResponse()
		{
		}

		// Token: 0x0600F3C6 RID: 62406 RVA: 0x00239B81 File Offset: 0x00237D81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalAwardResponse(NewbieCarnivalAwardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F3C7 RID: 62407 RVA: 0x00239BA6 File Offset: 0x00237DA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCarnivalAwardResponse Clone()
		{
			return new NewbieCarnivalAwardResponse(this);
		}

		// Token: 0x170031A5 RID: 12709
		// (get) Token: 0x0600F3C8 RID: 62408 RVA: 0x00239BAE File Offset: 0x00237DAE
		// (set) Token: 0x0600F3C9 RID: 62409 RVA: 0x00239BB6 File Offset: 0x00237DB6
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

		// Token: 0x0600F3CA RID: 62410 RVA: 0x00239BBF File Offset: 0x00237DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCarnivalAwardResponse);
		}

		// Token: 0x0600F3CB RID: 62411 RVA: 0x00239BCD File Offset: 0x00237DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCarnivalAwardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F3CC RID: 62412 RVA: 0x00239BFC File Offset: 0x00237DFC
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

		// Token: 0x0600F3CD RID: 62413 RVA: 0x00239C41 File Offset: 0x00237E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F3CE RID: 62414 RVA: 0x00239C4E File Offset: 0x00237E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F3CF RID: 62415 RVA: 0x00239C57 File Offset: 0x00237E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F3D0 RID: 62416 RVA: 0x00239C8C File Offset: 0x00237E8C
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

		// Token: 0x0600F3D1 RID: 62417 RVA: 0x00239CCA File Offset: 0x00237ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieCarnivalAwardResponse other)
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

		// Token: 0x0600F3D2 RID: 62418 RVA: 0x00239CFB File Offset: 0x00237EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F3D3 RID: 62419 RVA: 0x00239D04 File Offset: 0x00237F04
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006295 RID: 25237
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006296 RID: 25238
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04006297 RID: 25239
		private ErrorCode errorCode_;
	}
}
