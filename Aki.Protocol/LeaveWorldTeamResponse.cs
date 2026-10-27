using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008F3 RID: 2291
	[NetMessage(EMessageId.LeaveWorldTeamResponse)]
	public sealed class LeaveWorldTeamResponse : IMessage<LeaveWorldTeamResponse>, IMessage, IEquatable<LeaveWorldTeamResponse>, IDeepCloneable<LeaveWorldTeamResponse>, IBufferMessage
	{
		// Token: 0x0600CA84 RID: 51844 RVA: 0x001DE3BC File Offset: 0x001DC5BC
		[NullableContext(1)]
		public static LeaveWorldTeamResponse Create()
		{
			return new LeaveWorldTeamResponse();
		}

		// Token: 0x170028E4 RID: 10468
		// (get) Token: 0x0600CA85 RID: 51845 RVA: 0x001DE3C3 File Offset: 0x001DC5C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028E5 RID: 10469
		// (get) Token: 0x0600CA86 RID: 51846 RVA: 0x001DE3C6 File Offset: 0x001DC5C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveWorldTeamResponse.Descriptor;
			}
		}

		// Token: 0x0600CA87 RID: 51847 RVA: 0x001DE3CD File Offset: 0x001DC5CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveWorldTeamResponse()
		{
		}

		// Token: 0x0600CA88 RID: 51848 RVA: 0x001DE3D5 File Offset: 0x001DC5D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveWorldTeamResponse(LeaveWorldTeamResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA89 RID: 51849 RVA: 0x001DE3FA File Offset: 0x001DC5FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveWorldTeamResponse Clone()
		{
			return new LeaveWorldTeamResponse(this);
		}

		// Token: 0x170028E6 RID: 10470
		// (get) Token: 0x0600CA8A RID: 51850 RVA: 0x001DE402 File Offset: 0x001DC602
		// (set) Token: 0x0600CA8B RID: 51851 RVA: 0x001DE40A File Offset: 0x001DC60A
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

		// Token: 0x0600CA8C RID: 51852 RVA: 0x001DE413 File Offset: 0x001DC613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveWorldTeamResponse);
		}

		// Token: 0x0600CA8D RID: 51853 RVA: 0x001DE421 File Offset: 0x001DC621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveWorldTeamResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CA8E RID: 51854 RVA: 0x001DE450 File Offset: 0x001DC650
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

		// Token: 0x0600CA8F RID: 51855 RVA: 0x001DE495 File Offset: 0x001DC695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CA90 RID: 51856 RVA: 0x001DE4A2 File Offset: 0x001DC6A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA91 RID: 51857 RVA: 0x001DE4AB File Offset: 0x001DC6AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CA92 RID: 51858 RVA: 0x001DE4E0 File Offset: 0x001DC6E0
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

		// Token: 0x0600CA93 RID: 51859 RVA: 0x001DE51E File Offset: 0x001DC71E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveWorldTeamResponse other)
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

		// Token: 0x0600CA94 RID: 51860 RVA: 0x001DE54F File Offset: 0x001DC74F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA95 RID: 51861 RVA: 0x001DE558 File Offset: 0x001DC758
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400562D RID: 22061
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400562E RID: 22062
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400562F RID: 22063
		private ErrorCode errorCode_;
	}
}
