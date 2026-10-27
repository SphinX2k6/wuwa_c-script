using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EE2 RID: 3810
	[NetMessage(EMessageId.RegressQuestionOpenResponse)]
	public sealed class RegressQuestionOpenResponse : IMessage<RegressQuestionOpenResponse>, IMessage, IEquatable<RegressQuestionOpenResponse>, IDeepCloneable<RegressQuestionOpenResponse>, IBufferMessage
	{
		// Token: 0x060146BE RID: 83646 RVA: 0x002F7C51 File Offset: 0x002F5E51
		[NullableContext(1)]
		public static RegressQuestionOpenResponse Create()
		{
			return new RegressQuestionOpenResponse();
		}

		// Token: 0x170043EA RID: 17386
		// (get) Token: 0x060146BF RID: 83647 RVA: 0x002F7C58 File Offset: 0x002F5E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043EB RID: 17387
		// (get) Token: 0x060146C0 RID: 83648 RVA: 0x002F7C5B File Offset: 0x002F5E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressQuestionOpenResponse.Descriptor;
			}
		}

		// Token: 0x060146C1 RID: 83649 RVA: 0x002F7C62 File Offset: 0x002F5E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressQuestionOpenResponse()
		{
		}

		// Token: 0x060146C2 RID: 83650 RVA: 0x002F7C6A File Offset: 0x002F5E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressQuestionOpenResponse(RegressQuestionOpenResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060146C3 RID: 83651 RVA: 0x002F7C8F File Offset: 0x002F5E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressQuestionOpenResponse Clone()
		{
			return new RegressQuestionOpenResponse(this);
		}

		// Token: 0x170043EC RID: 17388
		// (get) Token: 0x060146C4 RID: 83652 RVA: 0x002F7C97 File Offset: 0x002F5E97
		// (set) Token: 0x060146C5 RID: 83653 RVA: 0x002F7C9F File Offset: 0x002F5E9F
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

		// Token: 0x060146C6 RID: 83654 RVA: 0x002F7CA8 File Offset: 0x002F5EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressQuestionOpenResponse);
		}

		// Token: 0x060146C7 RID: 83655 RVA: 0x002F7CB6 File Offset: 0x002F5EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressQuestionOpenResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060146C8 RID: 83656 RVA: 0x002F7CE4 File Offset: 0x002F5EE4
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

		// Token: 0x060146C9 RID: 83657 RVA: 0x002F7D29 File Offset: 0x002F5F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060146CA RID: 83658 RVA: 0x002F7D36 File Offset: 0x002F5F36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060146CB RID: 83659 RVA: 0x002F7D3F File Offset: 0x002F5F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060146CC RID: 83660 RVA: 0x002F7D74 File Offset: 0x002F5F74
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

		// Token: 0x060146CD RID: 83661 RVA: 0x002F7DB2 File Offset: 0x002F5FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressQuestionOpenResponse other)
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

		// Token: 0x060146CE RID: 83662 RVA: 0x002F7DE3 File Offset: 0x002F5FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060146CF RID: 83663 RVA: 0x002F7DEC File Offset: 0x002F5FEC
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007BF6 RID: 31734
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BF7 RID: 31735
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04007BF8 RID: 31736
		private ErrorCode errorCode_;
	}
}
