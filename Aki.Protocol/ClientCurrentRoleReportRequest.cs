using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002A0 RID: 672
	[NetMessage(EMessageId.ClientCurrentRoleReportRequest)]
	public sealed class ClientCurrentRoleReportRequest : IMessage<ClientCurrentRoleReportRequest>, IMessage, IEquatable<ClientCurrentRoleReportRequest>, IDeepCloneable<ClientCurrentRoleReportRequest>, IBufferMessage
	{
		// Token: 0x06004627 RID: 17959 RVA: 0x000ACBC7 File Offset: 0x000AADC7
		[NullableContext(1)]
		public static ClientCurrentRoleReportRequest Create()
		{
			return new ClientCurrentRoleReportRequest();
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06004628 RID: 17960 RVA: 0x000ACBCE File Offset: 0x000AADCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06004629 RID: 17961 RVA: 0x000ACBD1 File Offset: 0x000AADD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientCurrentRoleReportRequest.Descriptor;
			}
		}

		// Token: 0x0600462A RID: 17962 RVA: 0x000ACBD8 File Offset: 0x000AADD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportRequest()
		{
		}

		// Token: 0x0600462B RID: 17963 RVA: 0x000ACBE0 File Offset: 0x000AADE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportRequest(ClientCurrentRoleReportRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this.currentRoleId_ = other.currentRoleId_;
			this.currentEntityId_ = other.currentEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600462C RID: 17964 RVA: 0x000ACC1D File Offset: 0x000AAE1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportRequest Clone()
		{
			return new ClientCurrentRoleReportRequest(this);
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x0600462D RID: 17965 RVA: 0x000ACC25 File Offset: 0x000AAE25
		// (set) Token: 0x0600462E RID: 17966 RVA: 0x000ACC2D File Offset: 0x000AAE2D
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

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x0600462F RID: 17967 RVA: 0x000ACC36 File Offset: 0x000AAE36
		// (set) Token: 0x06004630 RID: 17968 RVA: 0x000ACC3E File Offset: 0x000AAE3E
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

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06004631 RID: 17969 RVA: 0x000ACC47 File Offset: 0x000AAE47
		// (set) Token: 0x06004632 RID: 17970 RVA: 0x000ACC4F File Offset: 0x000AAE4F
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

		// Token: 0x06004633 RID: 17971 RVA: 0x000ACC58 File Offset: 0x000AAE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientCurrentRoleReportRequest);
		}

		// Token: 0x06004634 RID: 17972 RVA: 0x000ACC68 File Offset: 0x000AAE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientCurrentRoleReportRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.CurrentRoleId == other.CurrentRoleId && this.CurrentEntityId == other.CurrentEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004635 RID: 17973 RVA: 0x000ACCC4 File Offset: 0x000AAEC4
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

		// Token: 0x06004636 RID: 17974 RVA: 0x000ACD35 File Offset: 0x000AAF35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x000ACD42 File Offset: 0x000AAF42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004638 RID: 17976 RVA: 0x000ACD4C File Offset: 0x000AAF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurrentRoleId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CurrentRoleId);
			}
			if (this.CurrentEntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.CurrentEntityId);
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

		// Token: 0x06004639 RID: 17977 RVA: 0x000ACDC4 File Offset: 0x000AAFC4
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

		// Token: 0x0600463A RID: 17978 RVA: 0x000ACE34 File Offset: 0x000AB034
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

		// Token: 0x0600463B RID: 17979 RVA: 0x000ACE98 File Offset: 0x000AB098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600463C RID: 17980 RVA: 0x000ACEA4 File Offset: 0x000AB0A4
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
				if (num != 40U)
				{
					if (num != 104U)
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
						this.CurrentEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.CurrentRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002F95 RID: 12181
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F96 RID: 12182
		public const int PlayerIdFieldNumber = 15;

		// Token: 0x04002F97 RID: 12183
		private int playerId_;

		// Token: 0x04002F98 RID: 12184
		public const int CurrentRoleIdFieldNumber = 5;

		// Token: 0x04002F99 RID: 12185
		private int currentRoleId_;

		// Token: 0x04002F9A RID: 12186
		public const int CurrentEntityIdFieldNumber = 13;

		// Token: 0x04002F9B RID: 12187
		private long currentEntityId_;
	}
}
