using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001252 RID: 4690
	[NetMessage(EMessageId.SignActivityFreeDropResponse)]
	public sealed class SignActivityFreeDropResponse : IMessage<SignActivityFreeDropResponse>, IMessage, IEquatable<SignActivityFreeDropResponse>, IDeepCloneable<SignActivityFreeDropResponse>, IBufferMessage
	{
		// Token: 0x060190A5 RID: 102565 RVA: 0x003A68D5 File Offset: 0x003A4AD5
		[NullableContext(1)]
		public static SignActivityFreeDropResponse Create()
		{
			return new SignActivityFreeDropResponse();
		}

		// Token: 0x1700549F RID: 21663
		// (get) Token: 0x060190A6 RID: 102566 RVA: 0x003A68DC File Offset: 0x003A4ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054A0 RID: 21664
		// (get) Token: 0x060190A7 RID: 102567 RVA: 0x003A68DF File Offset: 0x003A4ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SignActivityFreeDropResponse.Descriptor;
			}
		}

		// Token: 0x060190A8 RID: 102568 RVA: 0x003A68E6 File Offset: 0x003A4AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityFreeDropResponse()
		{
		}

		// Token: 0x060190A9 RID: 102569 RVA: 0x003A68EE File Offset: 0x003A4AEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityFreeDropResponse(SignActivityFreeDropResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060190AA RID: 102570 RVA: 0x003A6913 File Offset: 0x003A4B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityFreeDropResponse Clone()
		{
			return new SignActivityFreeDropResponse(this);
		}

		// Token: 0x170054A1 RID: 21665
		// (get) Token: 0x060190AB RID: 102571 RVA: 0x003A691B File Offset: 0x003A4B1B
		// (set) Token: 0x060190AC RID: 102572 RVA: 0x003A6923 File Offset: 0x003A4B23
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

		// Token: 0x060190AD RID: 102573 RVA: 0x003A692C File Offset: 0x003A4B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SignActivityFreeDropResponse);
		}

		// Token: 0x060190AE RID: 102574 RVA: 0x003A693A File Offset: 0x003A4B3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SignActivityFreeDropResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060190AF RID: 102575 RVA: 0x003A6968 File Offset: 0x003A4B68
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

		// Token: 0x060190B0 RID: 102576 RVA: 0x003A69AD File Offset: 0x003A4BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060190B1 RID: 102577 RVA: 0x003A69BA File Offset: 0x003A4BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060190B2 RID: 102578 RVA: 0x003A69C3 File Offset: 0x003A4BC3
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

		// Token: 0x060190B3 RID: 102579 RVA: 0x003A69F8 File Offset: 0x003A4BF8
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

		// Token: 0x060190B4 RID: 102580 RVA: 0x003A6A36 File Offset: 0x003A4C36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SignActivityFreeDropResponse other)
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

		// Token: 0x060190B5 RID: 102581 RVA: 0x003A6A67 File Offset: 0x003A4C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060190B6 RID: 102582 RVA: 0x003A6A70 File Offset: 0x003A4C70
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

		// Token: 0x04009469 RID: 37993
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400946A RID: 37994
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400946B RID: 37995
		private ErrorCode errorCode_;
	}
}
