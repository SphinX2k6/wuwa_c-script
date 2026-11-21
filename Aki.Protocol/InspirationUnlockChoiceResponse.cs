using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000805 RID: 2053
	[NetMessage(EMessageId.InspirationUnlockChoiceResponse)]
	public sealed class InspirationUnlockChoiceResponse : IMessage<InspirationUnlockChoiceResponse>, IMessage, IEquatable<InspirationUnlockChoiceResponse>, IDeepCloneable<InspirationUnlockChoiceResponse>, IBufferMessage
	{
		// Token: 0x0600B7F6 RID: 47094 RVA: 0x001B6917 File Offset: 0x001B4B17
		[NullableContext(1)]
		public static InspirationUnlockChoiceResponse Create()
		{
			return new InspirationUnlockChoiceResponse();
		}

		// Token: 0x1700250C RID: 9484
		// (get) Token: 0x0600B7F7 RID: 47095 RVA: 0x001B691E File Offset: 0x001B4B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700250D RID: 9485
		// (get) Token: 0x0600B7F8 RID: 47096 RVA: 0x001B6921 File Offset: 0x001B4B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InspirationUnlockChoiceResponse.Descriptor;
			}
		}

		// Token: 0x0600B7F9 RID: 47097 RVA: 0x001B6928 File Offset: 0x001B4B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InspirationUnlockChoiceResponse()
		{
		}

		// Token: 0x0600B7FA RID: 47098 RVA: 0x001B6930 File Offset: 0x001B4B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InspirationUnlockChoiceResponse(InspirationUnlockChoiceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B7FB RID: 47099 RVA: 0x001B6955 File Offset: 0x001B4B55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InspirationUnlockChoiceResponse Clone()
		{
			return new InspirationUnlockChoiceResponse(this);
		}

		// Token: 0x1700250E RID: 9486
		// (get) Token: 0x0600B7FC RID: 47100 RVA: 0x001B695D File Offset: 0x001B4B5D
		// (set) Token: 0x0600B7FD RID: 47101 RVA: 0x001B6965 File Offset: 0x001B4B65
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

		// Token: 0x0600B7FE RID: 47102 RVA: 0x001B696E File Offset: 0x001B4B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InspirationUnlockChoiceResponse);
		}

		// Token: 0x0600B7FF RID: 47103 RVA: 0x001B697C File Offset: 0x001B4B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InspirationUnlockChoiceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B800 RID: 47104 RVA: 0x001B69AC File Offset: 0x001B4BAC
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

		// Token: 0x0600B801 RID: 47105 RVA: 0x001B69F1 File Offset: 0x001B4BF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B802 RID: 47106 RVA: 0x001B69FE File Offset: 0x001B4BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B803 RID: 47107 RVA: 0x001B6A07 File Offset: 0x001B4C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B804 RID: 47108 RVA: 0x001B6A3C File Offset: 0x001B4C3C
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

		// Token: 0x0600B805 RID: 47109 RVA: 0x001B6A7A File Offset: 0x001B4C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InspirationUnlockChoiceResponse other)
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

		// Token: 0x0600B806 RID: 47110 RVA: 0x001B6AAB File Offset: 0x001B4CAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B807 RID: 47111 RVA: 0x001B6AB4 File Offset: 0x001B4CB4
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005174 RID: 20852
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005175 RID: 20853
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04005176 RID: 20854
		private ErrorCode errorCode_;
	}
}
