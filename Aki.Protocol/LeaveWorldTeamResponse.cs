using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008E2 RID: 2274
	[NetMessage(EMessageId.LeaveWorldTeamResponse)]
	public sealed class LeaveWorldTeamResponse : IMessage<LeaveWorldTeamResponse>, IMessage, IEquatable<LeaveWorldTeamResponse>, IDeepCloneable<LeaveWorldTeamResponse>, IBufferMessage
	{
		// Token: 0x0600C968 RID: 51560 RVA: 0x001DC0E0 File Offset: 0x001DA2E0
		[NullableContext(1)]
		public static LeaveWorldTeamResponse Create()
		{
			return new LeaveWorldTeamResponse();
		}

		// Token: 0x170028A5 RID: 10405
		// (get) Token: 0x0600C969 RID: 51561 RVA: 0x001DC0E7 File Offset: 0x001DA2E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028A6 RID: 10406
		// (get) Token: 0x0600C96A RID: 51562 RVA: 0x001DC0EA File Offset: 0x001DA2EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveWorldTeamResponse.Descriptor;
			}
		}

		// Token: 0x0600C96B RID: 51563 RVA: 0x001DC0F1 File Offset: 0x001DA2F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveWorldTeamResponse()
		{
		}

		// Token: 0x0600C96C RID: 51564 RVA: 0x001DC0F9 File Offset: 0x001DA2F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveWorldTeamResponse(LeaveWorldTeamResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C96D RID: 51565 RVA: 0x001DC11E File Offset: 0x001DA31E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveWorldTeamResponse Clone()
		{
			return new LeaveWorldTeamResponse(this);
		}

		// Token: 0x170028A7 RID: 10407
		// (get) Token: 0x0600C96E RID: 51566 RVA: 0x001DC126 File Offset: 0x001DA326
		// (set) Token: 0x0600C96F RID: 51567 RVA: 0x001DC12E File Offset: 0x001DA32E
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

		// Token: 0x0600C970 RID: 51568 RVA: 0x001DC137 File Offset: 0x001DA337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveWorldTeamResponse);
		}

		// Token: 0x0600C971 RID: 51569 RVA: 0x001DC145 File Offset: 0x001DA345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveWorldTeamResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C972 RID: 51570 RVA: 0x001DC174 File Offset: 0x001DA374
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

		// Token: 0x0600C973 RID: 51571 RVA: 0x001DC1B9 File Offset: 0x001DA3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C974 RID: 51572 RVA: 0x001DC1C6 File Offset: 0x001DA3C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C975 RID: 51573 RVA: 0x001DC1CF File Offset: 0x001DA3CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C976 RID: 51574 RVA: 0x001DC204 File Offset: 0x001DA404
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

		// Token: 0x0600C977 RID: 51575 RVA: 0x001DC242 File Offset: 0x001DA442
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

		// Token: 0x0600C978 RID: 51576 RVA: 0x001DC273 File Offset: 0x001DA473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C979 RID: 51577 RVA: 0x001DC27C File Offset: 0x001DA47C
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005634 RID: 22068
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005635 RID: 22069
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04005636 RID: 22070
		private ErrorCode errorCode_;
	}
}
