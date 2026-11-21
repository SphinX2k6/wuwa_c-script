using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002A1 RID: 673
	[NetMessage(EMessageId.ClientCurrentRoleReportResponse)]
	public sealed class ClientCurrentRoleReportResponse : IMessage<ClientCurrentRoleReportResponse>, IMessage, IEquatable<ClientCurrentRoleReportResponse>, IDeepCloneable<ClientCurrentRoleReportResponse>, IBufferMessage
	{
		// Token: 0x0600463D RID: 17981 RVA: 0x000ACF0F File Offset: 0x000AB10F
		[NullableContext(1)]
		public static ClientCurrentRoleReportResponse Create()
		{
			return new ClientCurrentRoleReportResponse();
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x0600463E RID: 17982 RVA: 0x000ACF16 File Offset: 0x000AB116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x0600463F RID: 17983 RVA: 0x000ACF19 File Offset: 0x000AB119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientCurrentRoleReportResponse.Descriptor;
			}
		}

		// Token: 0x06004640 RID: 17984 RVA: 0x000ACF20 File Offset: 0x000AB120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportResponse()
		{
		}

		// Token: 0x06004641 RID: 17985 RVA: 0x000ACF28 File Offset: 0x000AB128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportResponse(ClientCurrentRoleReportResponse other) : this()
		{
			this.playerId_ = other.playerId_;
			this.currentEntityId_ = other.currentEntityId_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x000ACF65 File Offset: 0x000AB165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportResponse Clone()
		{
			return new ClientCurrentRoleReportResponse(this);
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06004643 RID: 17987 RVA: 0x000ACF6D File Offset: 0x000AB16D
		// (set) Token: 0x06004644 RID: 17988 RVA: 0x000ACF75 File Offset: 0x000AB175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x06004645 RID: 17989 RVA: 0x000ACF7E File Offset: 0x000AB17E
		// (set) Token: 0x06004646 RID: 17990 RVA: 0x000ACF86 File Offset: 0x000AB186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CurrentEntityId
		{
			get
			{
				return this.currentEntityId_;
			}
			set
			{
				this.currentEntityId_ = value;
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06004647 RID: 17991 RVA: 0x000ACF8F File Offset: 0x000AB18F
		// (set) Token: 0x06004648 RID: 17992 RVA: 0x000ACF97 File Offset: 0x000AB197
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

		// Token: 0x06004649 RID: 17993 RVA: 0x000ACFA0 File Offset: 0x000AB1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientCurrentRoleReportResponse);
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x000ACFB0 File Offset: 0x000AB1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientCurrentRoleReportResponse other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.CurrentEntityId == other.CurrentEntityId && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x000AD00C File Offset: 0x000AB20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.CurrentEntityId != 0L)
			{
				num ^= this.CurrentEntityId.GetHashCode();
			}
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

		// Token: 0x0600464C RID: 17996 RVA: 0x000AD083 File Offset: 0x000AB283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x000AD090 File Offset: 0x000AB290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600464E RID: 17998 RVA: 0x000AD09C File Offset: 0x000AB29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.CurrentEntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.CurrentEntityId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x000AD114 File Offset: 0x000AB314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.CurrentEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurrentEntityId);
			}
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

		// Token: 0x06004650 RID: 18000 RVA: 0x000AD184 File Offset: 0x000AB384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientCurrentRoleReportResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.CurrentEntityId != 0L)
			{
				this.CurrentEntityId = other.CurrentEntityId;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x000AD1E8 File Offset: 0x000AB3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004652 RID: 18002 RVA: 0x000AD1F4 File Offset: 0x000AB3F4
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
					if (num != 72U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PlayerId = input.ReadInt32();
						}
					}
					else
					{
						this.CurrentEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002F9C RID: 12188
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F9D RID: 12189
		public const int PlayerIdFieldNumber = 11;

		// Token: 0x04002F9E RID: 12190
		private int playerId_;

		// Token: 0x04002F9F RID: 12191
		public const int CurrentEntityIdFieldNumber = 9;

		// Token: 0x04002FA0 RID: 12192
		private long currentEntityId_;

		// Token: 0x04002FA1 RID: 12193
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04002FA2 RID: 12194
		private ErrorCode errorCode_;
	}
}
