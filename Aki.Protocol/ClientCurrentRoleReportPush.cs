using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200029A RID: 666
	[NetMessage(EMessageId.ClientCurrentRoleReportPush)]
	public sealed class ClientCurrentRoleReportPush : IMessage<ClientCurrentRoleReportPush>, IMessage, IEquatable<ClientCurrentRoleReportPush>, IDeepCloneable<ClientCurrentRoleReportPush>, IBufferMessage
	{
		// Token: 0x06004568 RID: 17768 RVA: 0x000AAB02 File Offset: 0x000A8D02
		[NullableContext(1)]
		public static ClientCurrentRoleReportPush Create()
		{
			return new ClientCurrentRoleReportPush();
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06004569 RID: 17769 RVA: 0x000AAB09 File Offset: 0x000A8D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x0600456A RID: 17770 RVA: 0x000AAB0C File Offset: 0x000A8D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientCurrentRoleReportPush.Descriptor;
			}
		}

		// Token: 0x0600456B RID: 17771 RVA: 0x000AAB13 File Offset: 0x000A8D13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportPush()
		{
		}

		// Token: 0x0600456C RID: 17772 RVA: 0x000AAB1B File Offset: 0x000A8D1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportPush(ClientCurrentRoleReportPush other) : this()
		{
			this.playerId_ = other.playerId_;
			this.currentRoleId_ = other.currentRoleId_;
			this.currentEntityId_ = other.currentEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600456D RID: 17773 RVA: 0x000AAB58 File Offset: 0x000A8D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportPush Clone()
		{
			return new ClientCurrentRoleReportPush(this);
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x0600456E RID: 17774 RVA: 0x000AAB60 File Offset: 0x000A8D60
		// (set) Token: 0x0600456F RID: 17775 RVA: 0x000AAB68 File Offset: 0x000A8D68
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

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06004570 RID: 17776 RVA: 0x000AAB71 File Offset: 0x000A8D71
		// (set) Token: 0x06004571 RID: 17777 RVA: 0x000AAB79 File Offset: 0x000A8D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrentRoleId
		{
			get
			{
				return this.currentRoleId_;
			}
			set
			{
				this.currentRoleId_ = value;
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06004572 RID: 17778 RVA: 0x000AAB82 File Offset: 0x000A8D82
		// (set) Token: 0x06004573 RID: 17779 RVA: 0x000AAB8A File Offset: 0x000A8D8A
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

		// Token: 0x06004574 RID: 17780 RVA: 0x000AAB93 File Offset: 0x000A8D93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientCurrentRoleReportPush);
		}

		// Token: 0x06004575 RID: 17781 RVA: 0x000AABA4 File Offset: 0x000A8DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientCurrentRoleReportPush other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.CurrentRoleId == other.CurrentRoleId && this.CurrentEntityId == other.CurrentEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004576 RID: 17782 RVA: 0x000AAC00 File Offset: 0x000A8E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.CurrentRoleId != 0)
			{
				num ^= this.CurrentRoleId.GetHashCode();
			}
			if (this.CurrentEntityId != 0L)
			{
				num ^= this.CurrentEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004577 RID: 17783 RVA: 0x000AAC71 File Offset: 0x000A8E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004578 RID: 17784 RVA: 0x000AAC7E File Offset: 0x000A8E7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004579 RID: 17785 RVA: 0x000AAC88 File Offset: 0x000A8E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurrentRoleId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CurrentRoleId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.PlayerId);
			}
			if (this.CurrentEntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.CurrentEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600457A RID: 17786 RVA: 0x000AAD00 File Offset: 0x000A8F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.CurrentRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrentRoleId);
			}
			if (this.CurrentEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurrentEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600457B RID: 17787 RVA: 0x000AAD70 File Offset: 0x000A8F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientCurrentRoleReportPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.CurrentRoleId != 0)
			{
				this.CurrentRoleId = other.CurrentRoleId;
			}
			if (other.CurrentEntityId != 0L)
			{
				this.CurrentEntityId = other.CurrentEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600457C RID: 17788 RVA: 0x000AADD4 File Offset: 0x000A8FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600457D RID: 17789 RVA: 0x000AADE0 File Offset: 0x000A8FE0
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
				if (num != 56U)
				{
					if (num != 72U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CurrentEntityId = input.ReadInt64();
						}
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.CurrentRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002F08 RID: 12040
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F09 RID: 12041
		public const int PlayerIdFieldNumber = 9;

		// Token: 0x04002F0A RID: 12042
		private int playerId_;

		// Token: 0x04002F0B RID: 12043
		public const int CurrentRoleIdFieldNumber = 7;

		// Token: 0x04002F0C RID: 12044
		private int currentRoleId_;

		// Token: 0x04002F0D RID: 12045
		public const int CurrentEntityIdFieldNumber = 12;

		// Token: 0x04002F0E RID: 12046
		private long currentEntityId_;
	}
}
