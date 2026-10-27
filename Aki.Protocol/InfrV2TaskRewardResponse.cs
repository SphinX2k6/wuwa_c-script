using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000808 RID: 2056
	[NetMessage(EMessageId.InfrV2TaskRewardResponse)]
	public sealed class InfrV2TaskRewardResponse : IMessage<InfrV2TaskRewardResponse>, IMessage, IEquatable<InfrV2TaskRewardResponse>, IDeepCloneable<InfrV2TaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600B7FE RID: 47102 RVA: 0x001B6821 File Offset: 0x001B4A21
		[NullableContext(1)]
		public static InfrV2TaskRewardResponse Create()
		{
			return new InfrV2TaskRewardResponse();
		}

		// Token: 0x17002514 RID: 9492
		// (get) Token: 0x0600B7FF RID: 47103 RVA: 0x001B6828 File Offset: 0x001B4A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002515 RID: 9493
		// (get) Token: 0x0600B800 RID: 47104 RVA: 0x001B682B File Offset: 0x001B4A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2TaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600B801 RID: 47105 RVA: 0x001B6832 File Offset: 0x001B4A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TaskRewardResponse()
		{
		}

		// Token: 0x0600B802 RID: 47106 RVA: 0x001B683A File Offset: 0x001B4A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TaskRewardResponse(InfrV2TaskRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B803 RID: 47107 RVA: 0x001B685F File Offset: 0x001B4A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TaskRewardResponse Clone()
		{
			return new InfrV2TaskRewardResponse(this);
		}

		// Token: 0x17002516 RID: 9494
		// (get) Token: 0x0600B804 RID: 47108 RVA: 0x001B6867 File Offset: 0x001B4A67
		// (set) Token: 0x0600B805 RID: 47109 RVA: 0x001B686F File Offset: 0x001B4A6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0600B806 RID: 47110 RVA: 0x001B6878 File Offset: 0x001B4A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2TaskRewardResponse);
		}

		// Token: 0x0600B807 RID: 47111 RVA: 0x001B6886 File Offset: 0x001B4A86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2TaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B808 RID: 47112 RVA: 0x001B68B4 File Offset: 0x001B4AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B809 RID: 47113 RVA: 0x001B68F9 File Offset: 0x001B4AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B80A RID: 47114 RVA: 0x001B6906 File Offset: 0x001B4B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B80B RID: 47115 RVA: 0x001B690F File Offset: 0x001B4B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B80C RID: 47116 RVA: 0x001B6944 File Offset: 0x001B4B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B80D RID: 47117 RVA: 0x001B6982 File Offset: 0x001B4B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2TaskRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B80E RID: 47118 RVA: 0x001B69B3 File Offset: 0x001B4BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B80F RID: 47119 RVA: 0x001B69BC File Offset: 0x001B4BBC
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005125 RID: 20773
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005126 RID: 20774
		public const int ErrCodeFieldNumber = 2;

		// Token: 0x04005127 RID: 20775
		private ErrorCode errCode_;
	}
}
