using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008EF RID: 2287
	[NetMessage(EMessageId.LeaveMatchTeamResponse)]
	public sealed class LeaveMatchTeamResponse : IMessage<LeaveMatchTeamResponse>, IMessage, IEquatable<LeaveMatchTeamResponse>, IDeepCloneable<LeaveMatchTeamResponse>, IBufferMessage
	{
		// Token: 0x0600CA34 RID: 51764 RVA: 0x001DD95A File Offset: 0x001DBB5A
		[NullableContext(1)]
		public static LeaveMatchTeamResponse Create()
		{
			return new LeaveMatchTeamResponse();
		}

		// Token: 0x170028D4 RID: 10452
		// (get) Token: 0x0600CA35 RID: 51765 RVA: 0x001DD961 File Offset: 0x001DBB61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028D5 RID: 10453
		// (get) Token: 0x0600CA36 RID: 51766 RVA: 0x001DD964 File Offset: 0x001DBB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveMatchTeamResponse.Descriptor;
			}
		}

		// Token: 0x0600CA37 RID: 51767 RVA: 0x001DD96B File Offset: 0x001DBB6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMatchTeamResponse()
		{
		}

		// Token: 0x0600CA38 RID: 51768 RVA: 0x001DD973 File Offset: 0x001DBB73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMatchTeamResponse(LeaveMatchTeamResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA39 RID: 51769 RVA: 0x001DD998 File Offset: 0x001DBB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveMatchTeamResponse Clone()
		{
			return new LeaveMatchTeamResponse(this);
		}

		// Token: 0x170028D6 RID: 10454
		// (get) Token: 0x0600CA3A RID: 51770 RVA: 0x001DD9A0 File Offset: 0x001DBBA0
		// (set) Token: 0x0600CA3B RID: 51771 RVA: 0x001DD9A8 File Offset: 0x001DBBA8
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

		// Token: 0x0600CA3C RID: 51772 RVA: 0x001DD9B1 File Offset: 0x001DBBB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveMatchTeamResponse);
		}

		// Token: 0x0600CA3D RID: 51773 RVA: 0x001DD9BF File Offset: 0x001DBBBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveMatchTeamResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CA3E RID: 51774 RVA: 0x001DD9F0 File Offset: 0x001DBBF0
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

		// Token: 0x0600CA3F RID: 51775 RVA: 0x001DDA35 File Offset: 0x001DBC35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CA40 RID: 51776 RVA: 0x001DDA42 File Offset: 0x001DBC42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA41 RID: 51777 RVA: 0x001DDA4B File Offset: 0x001DBC4B
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

		// Token: 0x0600CA42 RID: 51778 RVA: 0x001DDA80 File Offset: 0x001DBC80
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

		// Token: 0x0600CA43 RID: 51779 RVA: 0x001DDABE File Offset: 0x001DBCBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveMatchTeamResponse other)
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

		// Token: 0x0600CA44 RID: 51780 RVA: 0x001DDAEF File Offset: 0x001DBCEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA45 RID: 51781 RVA: 0x001DDAF8 File Offset: 0x001DBCF8
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

		// Token: 0x04005618 RID: 22040
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005619 RID: 22041
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400561A RID: 22042
		private ErrorCode errorCode_;
	}
}
