using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AA5 RID: 2725
	[NetMessage(EMessageId.MotorUseSkinResponse)]
	public sealed class MotorUseSkinResponse : IMessage<MotorUseSkinResponse>, IMessage, IEquatable<MotorUseSkinResponse>, IDeepCloneable<MotorUseSkinResponse>, IBufferMessage
	{
		// Token: 0x0600ED77 RID: 60791 RVA: 0x0022ABDD File Offset: 0x00228DDD
		[NullableContext(1)]
		public static MotorUseSkinResponse Create()
		{
			return new MotorUseSkinResponse();
		}

		// Token: 0x17003039 RID: 12345
		// (get) Token: 0x0600ED78 RID: 60792 RVA: 0x0022ABE4 File Offset: 0x00228DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700303A RID: 12346
		// (get) Token: 0x0600ED79 RID: 60793 RVA: 0x0022ABE7 File Offset: 0x00228DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorUseSkinResponse.Descriptor;
			}
		}

		// Token: 0x0600ED7A RID: 60794 RVA: 0x0022ABEE File Offset: 0x00228DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSkinResponse()
		{
		}

		// Token: 0x0600ED7B RID: 60795 RVA: 0x0022ABF6 File Offset: 0x00228DF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSkinResponse(MotorUseSkinResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ED7C RID: 60796 RVA: 0x0022AC1B File Offset: 0x00228E1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorUseSkinResponse Clone()
		{
			return new MotorUseSkinResponse(this);
		}

		// Token: 0x1700303B RID: 12347
		// (get) Token: 0x0600ED7D RID: 60797 RVA: 0x0022AC23 File Offset: 0x00228E23
		// (set) Token: 0x0600ED7E RID: 60798 RVA: 0x0022AC2B File Offset: 0x00228E2B
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

		// Token: 0x0600ED7F RID: 60799 RVA: 0x0022AC34 File Offset: 0x00228E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorUseSkinResponse);
		}

		// Token: 0x0600ED80 RID: 60800 RVA: 0x0022AC42 File Offset: 0x00228E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorUseSkinResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ED81 RID: 60801 RVA: 0x0022AC70 File Offset: 0x00228E70
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

		// Token: 0x0600ED82 RID: 60802 RVA: 0x0022ACB5 File Offset: 0x00228EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ED83 RID: 60803 RVA: 0x0022ACC2 File Offset: 0x00228EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ED84 RID: 60804 RVA: 0x0022ACCB File Offset: 0x00228ECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ED85 RID: 60805 RVA: 0x0022AD00 File Offset: 0x00228F00
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

		// Token: 0x0600ED86 RID: 60806 RVA: 0x0022AD3E File Offset: 0x00228F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorUseSkinResponse other)
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

		// Token: 0x0600ED87 RID: 60807 RVA: 0x0022AD6F File Offset: 0x00228F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ED88 RID: 60808 RVA: 0x0022AD78 File Offset: 0x00228F78
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400607F RID: 24703
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006080 RID: 24704
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04006081 RID: 24705
		private ErrorCode errorCode_;
	}
}
