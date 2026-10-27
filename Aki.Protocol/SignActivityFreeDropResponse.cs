using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001216 RID: 4630
	[NetMessage(EMessageId.SignActivityFreeDropResponse)]
	public sealed class SignActivityFreeDropResponse : IMessage<SignActivityFreeDropResponse>, IMessage, IEquatable<SignActivityFreeDropResponse>, IDeepCloneable<SignActivityFreeDropResponse>, IBufferMessage
	{
		// Token: 0x06018ACB RID: 101067 RVA: 0x00396A2D File Offset: 0x00394C2D
		[NullableContext(1)]
		public static SignActivityFreeDropResponse Create()
		{
			return new SignActivityFreeDropResponse();
		}

		// Token: 0x17005322 RID: 21282
		// (get) Token: 0x06018ACC RID: 101068 RVA: 0x00396A34 File Offset: 0x00394C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005323 RID: 21283
		// (get) Token: 0x06018ACD RID: 101069 RVA: 0x00396A37 File Offset: 0x00394C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SignActivityFreeDropResponse.Descriptor;
			}
		}

		// Token: 0x06018ACE RID: 101070 RVA: 0x00396A3E File Offset: 0x00394C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityFreeDropResponse()
		{
		}

		// Token: 0x06018ACF RID: 101071 RVA: 0x00396A46 File Offset: 0x00394C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityFreeDropResponse(SignActivityFreeDropResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018AD0 RID: 101072 RVA: 0x00396A6B File Offset: 0x00394C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivityFreeDropResponse Clone()
		{
			return new SignActivityFreeDropResponse(this);
		}

		// Token: 0x17005324 RID: 21284
		// (get) Token: 0x06018AD1 RID: 101073 RVA: 0x00396A73 File Offset: 0x00394C73
		// (set) Token: 0x06018AD2 RID: 101074 RVA: 0x00396A7B File Offset: 0x00394C7B
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

		// Token: 0x06018AD3 RID: 101075 RVA: 0x00396A84 File Offset: 0x00394C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SignActivityFreeDropResponse);
		}

		// Token: 0x06018AD4 RID: 101076 RVA: 0x00396A92 File Offset: 0x00394C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SignActivityFreeDropResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018AD5 RID: 101077 RVA: 0x00396AC0 File Offset: 0x00394CC0
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

		// Token: 0x06018AD6 RID: 101078 RVA: 0x00396B05 File Offset: 0x00394D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018AD7 RID: 101079 RVA: 0x00396B12 File Offset: 0x00394D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018AD8 RID: 101080 RVA: 0x00396B1B File Offset: 0x00394D1B
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

		// Token: 0x06018AD9 RID: 101081 RVA: 0x00396B50 File Offset: 0x00394D50
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

		// Token: 0x06018ADA RID: 101082 RVA: 0x00396B8E File Offset: 0x00394D8E
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

		// Token: 0x06018ADB RID: 101083 RVA: 0x00396BBF File Offset: 0x00394DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018ADC RID: 101084 RVA: 0x00396BC8 File Offset: 0x00394DC8
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

		// Token: 0x040091B8 RID: 37304
		private UnknownFieldSet _unknownFields;

		// Token: 0x040091B9 RID: 37305
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040091BA RID: 37306
		private ErrorCode errorCode_;
	}
}
