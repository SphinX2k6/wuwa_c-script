using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200029B RID: 667
	[NetMessage(EMessageId.ClientCurrentRoleReportRequest)]
	public sealed class ClientCurrentRoleReportRequest : IMessage<ClientCurrentRoleReportRequest>, IMessage, IEquatable<ClientCurrentRoleReportRequest>, IDeepCloneable<ClientCurrentRoleReportRequest>, IBufferMessage
	{
		// Token: 0x0600457E RID: 17790 RVA: 0x000AAE4B File Offset: 0x000A904B
		[NullableContext(1)]
		public static ClientCurrentRoleReportRequest Create()
		{
			return new ClientCurrentRoleReportRequest();
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x0600457F RID: 17791 RVA: 0x000AAE52 File Offset: 0x000A9052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06004580 RID: 17792 RVA: 0x000AAE55 File Offset: 0x000A9055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientCurrentRoleReportRequest.Descriptor;
			}
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x000AAE5C File Offset: 0x000A905C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportRequest()
		{
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x000AAE64 File Offset: 0x000A9064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportRequest(ClientCurrentRoleReportRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this.currentRoleId_ = other.currentRoleId_;
			this.currentEntityId_ = other.currentEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x000AAEA1 File Offset: 0x000A90A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportRequest Clone()
		{
			return new ClientCurrentRoleReportRequest(this);
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06004584 RID: 17796 RVA: 0x000AAEA9 File Offset: 0x000A90A9
		// (set) Token: 0x06004585 RID: 17797 RVA: 0x000AAEB1 File Offset: 0x000A90B1
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

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06004586 RID: 17798 RVA: 0x000AAEBA File Offset: 0x000A90BA
		// (set) Token: 0x06004587 RID: 17799 RVA: 0x000AAEC2 File Offset: 0x000A90C2
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

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06004588 RID: 17800 RVA: 0x000AAECB File Offset: 0x000A90CB
		// (set) Token: 0x06004589 RID: 17801 RVA: 0x000AAED3 File Offset: 0x000A90D3
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

		// Token: 0x0600458A RID: 17802 RVA: 0x000AAEDC File Offset: 0x000A90DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientCurrentRoleReportRequest);
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x000AAEEC File Offset: 0x000A90EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientCurrentRoleReportRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.CurrentRoleId == other.CurrentRoleId && this.CurrentEntityId == other.CurrentEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x000AAF48 File Offset: 0x000A9148
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

		// Token: 0x0600458D RID: 17805 RVA: 0x000AAFB9 File Offset: 0x000A91B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600458E RID: 17806 RVA: 0x000AAFC6 File Offset: 0x000A91C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x000AAFD0 File Offset: 0x000A91D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurrentEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.CurrentEntityId);
			}
			if (this.CurrentRoleId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.CurrentRoleId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004590 RID: 17808 RVA: 0x000AB044 File Offset: 0x000A9244
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

		// Token: 0x06004591 RID: 17809 RVA: 0x000AB0B4 File Offset: 0x000A92B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientCurrentRoleReportRequest other)
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

		// Token: 0x06004592 RID: 17810 RVA: 0x000AB118 File Offset: 0x000A9318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004593 RID: 17811 RVA: 0x000AB124 File Offset: 0x000A9324
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
				if (num != 8U)
				{
					if (num != 72U)
					{
						if (num != 120U)
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
						this.CurrentRoleId = input.ReadInt32();
					}
				}
				else
				{
					this.CurrentEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002F0F RID: 12047
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F10 RID: 12048
		public const int PlayerIdFieldNumber = 15;

		// Token: 0x04002F11 RID: 12049
		private int playerId_;

		// Token: 0x04002F12 RID: 12050
		public const int CurrentRoleIdFieldNumber = 9;

		// Token: 0x04002F13 RID: 12051
		private int currentRoleId_;

		// Token: 0x04002F14 RID: 12052
		public const int CurrentEntityIdFieldNumber = 1;

		// Token: 0x04002F15 RID: 12053
		private long currentEntityId_;
	}
}
