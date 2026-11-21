using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200029F RID: 671
	[NetMessage(EMessageId.ClientCurrentRoleReportPush)]
	public sealed class ClientCurrentRoleReportPush : IMessage<ClientCurrentRoleReportPush>, IMessage, IEquatable<ClientCurrentRoleReportPush>, IDeepCloneable<ClientCurrentRoleReportPush>, IBufferMessage
	{
		// Token: 0x06004611 RID: 17937 RVA: 0x000AC87E File Offset: 0x000AAA7E
		[NullableContext(1)]
		public static ClientCurrentRoleReportPush Create()
		{
			return new ClientCurrentRoleReportPush();
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06004612 RID: 17938 RVA: 0x000AC885 File Offset: 0x000AAA85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06004613 RID: 17939 RVA: 0x000AC888 File Offset: 0x000AAA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientCurrentRoleReportPush.Descriptor;
			}
		}

		// Token: 0x06004614 RID: 17940 RVA: 0x000AC88F File Offset: 0x000AAA8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportPush()
		{
		}

		// Token: 0x06004615 RID: 17941 RVA: 0x000AC897 File Offset: 0x000AAA97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportPush(ClientCurrentRoleReportPush other) : this()
		{
			this.playerId_ = other.playerId_;
			this.currentRoleId_ = other.currentRoleId_;
			this.currentEntityId_ = other.currentEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004616 RID: 17942 RVA: 0x000AC8D4 File Offset: 0x000AAAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientCurrentRoleReportPush Clone()
		{
			return new ClientCurrentRoleReportPush(this);
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06004617 RID: 17943 RVA: 0x000AC8DC File Offset: 0x000AAADC
		// (set) Token: 0x06004618 RID: 17944 RVA: 0x000AC8E4 File Offset: 0x000AAAE4
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

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06004619 RID: 17945 RVA: 0x000AC8ED File Offset: 0x000AAAED
		// (set) Token: 0x0600461A RID: 17946 RVA: 0x000AC8F5 File Offset: 0x000AAAF5
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

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x0600461B RID: 17947 RVA: 0x000AC8FE File Offset: 0x000AAAFE
		// (set) Token: 0x0600461C RID: 17948 RVA: 0x000AC906 File Offset: 0x000AAB06
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

		// Token: 0x0600461D RID: 17949 RVA: 0x000AC90F File Offset: 0x000AAB0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientCurrentRoleReportPush);
		}

		// Token: 0x0600461E RID: 17950 RVA: 0x000AC920 File Offset: 0x000AAB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientCurrentRoleReportPush other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.CurrentRoleId == other.CurrentRoleId && this.CurrentEntityId == other.CurrentEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600461F RID: 17951 RVA: 0x000AC97C File Offset: 0x000AAB7C
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

		// Token: 0x06004620 RID: 17952 RVA: 0x000AC9ED File Offset: 0x000AABED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004621 RID: 17953 RVA: 0x000AC9FA File Offset: 0x000AABFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004622 RID: 17954 RVA: 0x000ACA04 File Offset: 0x000AAC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurrentRoleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CurrentRoleId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PlayerId);
			}
			if (this.CurrentEntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.CurrentEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004623 RID: 17955 RVA: 0x000ACA7C File Offset: 0x000AAC7C
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

		// Token: 0x06004624 RID: 17956 RVA: 0x000ACAEC File Offset: 0x000AACEC
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

		// Token: 0x06004625 RID: 17957 RVA: 0x000ACB50 File Offset: 0x000AAD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004626 RID: 17958 RVA: 0x000ACB5C File Offset: 0x000AAD5C
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
					if (num != 40U)
					{
						if (num != 80U)
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

		// Token: 0x04002F8E RID: 12174
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F8F RID: 12175
		public const int PlayerIdFieldNumber = 5;

		// Token: 0x04002F90 RID: 12176
		private int playerId_;

		// Token: 0x04002F91 RID: 12177
		public const int CurrentRoleIdFieldNumber = 4;

		// Token: 0x04002F92 RID: 12178
		private int currentRoleId_;

		// Token: 0x04002F93 RID: 12179
		public const int CurrentEntityIdFieldNumber = 10;

		// Token: 0x04002F94 RID: 12180
		private long currentEntityId_;
	}
}
