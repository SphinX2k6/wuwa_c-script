using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200029C RID: 668
	[NetMessage(EMessageId.ClientCurrentRoleReportResponse)]
	public sealed class ClientCurrentRoleReportResponse : IMessage<ClientCurrentRoleReportResponse>, IMessage, IEquatable<ClientCurrentRoleReportResponse>, IDeepCloneable<ClientCurrentRoleReportResponse>, IBufferMessage
	{
		// Token: 0x06004594 RID: 17812 RVA: 0x000AB18E File Offset: 0x000A938E
		[NullableContext(1)]
		public static ClientCurrentRoleReportResponse Create()
		{
			return new ClientCurrentRoleReportResponse();
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06004595 RID: 17813 RVA: 0x000AB195 File Offset: 0x000A9395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06004596 RID: 17814 RVA: 0x000AB198 File Offset: 0x000A9398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientCurrentRoleReportResponse.Descriptor;
			}
		}

		// Token: 0x06004597 RID: 17815 RVA: 0x000AB19F File Offset: 0x000A939F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportResponse()
		{
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x000AB1A7 File Offset: 0x000A93A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportResponse(ClientCurrentRoleReportResponse other) : this()
		{
			this.playerId_ = other.playerId_;
			this.currentEntityId_ = other.currentEntityId_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x000AB1E4 File Offset: 0x000A93E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportResponse Clone()
		{
			return new ClientCurrentRoleReportResponse(this);
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x0600459A RID: 17818 RVA: 0x000AB1EC File Offset: 0x000A93EC
		// (set) Token: 0x0600459B RID: 17819 RVA: 0x000AB1F4 File Offset: 0x000A93F4
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

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x0600459C RID: 17820 RVA: 0x000AB1FD File Offset: 0x000A93FD
		// (set) Token: 0x0600459D RID: 17821 RVA: 0x000AB205 File Offset: 0x000A9405
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

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x0600459E RID: 17822 RVA: 0x000AB20E File Offset: 0x000A940E
		// (set) Token: 0x0600459F RID: 17823 RVA: 0x000AB216 File Offset: 0x000A9416
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

		// Token: 0x060045A0 RID: 17824 RVA: 0x000AB21F File Offset: 0x000A941F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientCurrentRoleReportResponse);
		}

		// Token: 0x060045A1 RID: 17825 RVA: 0x000AB230 File Offset: 0x000A9430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientCurrentRoleReportResponse other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.CurrentEntityId == other.CurrentEntityId && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060045A2 RID: 17826 RVA: 0x000AB28C File Offset: 0x000A948C
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

		// Token: 0x060045A3 RID: 17827 RVA: 0x000AB303 File Offset: 0x000A9503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060045A4 RID: 17828 RVA: 0x000AB310 File Offset: 0x000A9510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x000AB31C File Offset: 0x000A951C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.CurrentEntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.CurrentEntityId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x000AB394 File Offset: 0x000A9594
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

		// Token: 0x060045A7 RID: 17831 RVA: 0x000AB404 File Offset: 0x000A9604
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

		// Token: 0x060045A8 RID: 17832 RVA: 0x000AB468 File Offset: 0x000A9668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060045A9 RID: 17833 RVA: 0x000AB474 File Offset: 0x000A9674
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
				if (num != 32U)
				{
					if (num != 56U)
					{
						if (num != 104U)
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

		// Token: 0x04002F16 RID: 12054
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F17 RID: 12055
		public const int PlayerIdFieldNumber = 13;

		// Token: 0x04002F18 RID: 12056
		private int playerId_;

		// Token: 0x04002F19 RID: 12057
		public const int CurrentEntityIdFieldNumber = 7;

		// Token: 0x04002F1A RID: 12058
		private long currentEntityId_;

		// Token: 0x04002F1B RID: 12059
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04002F1C RID: 12060
		private ErrorCode errorCode_;
	}
}
