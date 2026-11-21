using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009C9 RID: 2505
	[NetMessage(EMessageId.MixDrinkRoleInviteRequest)]
	public sealed class MixDrinkRoleInviteRequest : IMessage<MixDrinkRoleInviteRequest>, IMessage, IEquatable<MixDrinkRoleInviteRequest>, IDeepCloneable<MixDrinkRoleInviteRequest>, IBufferMessage
	{
		// Token: 0x0600DBFC RID: 56316 RVA: 0x00204F95 File Offset: 0x00203195
		[NullableContext(1)]
		public static MixDrinkRoleInviteRequest Create()
		{
			return new MixDrinkRoleInviteRequest();
		}

		// Token: 0x17002C92 RID: 11410
		// (get) Token: 0x0600DBFD RID: 56317 RVA: 0x00204F9C File Offset: 0x0020319C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C93 RID: 11411
		// (get) Token: 0x0600DBFE RID: 56318 RVA: 0x00204F9F File Offset: 0x0020319F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MixDrinkRoleInviteRequest.Descriptor;
			}
		}

		// Token: 0x0600DBFF RID: 56319 RVA: 0x00204FA6 File Offset: 0x002031A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleInviteRequest()
		{
		}

		// Token: 0x0600DC00 RID: 56320 RVA: 0x00204FAE File Offset: 0x002031AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleInviteRequest(MixDrinkRoleInviteRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DC01 RID: 56321 RVA: 0x00204FD3 File Offset: 0x002031D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleInviteRequest Clone()
		{
			return new MixDrinkRoleInviteRequest(this);
		}

		// Token: 0x17002C94 RID: 11412
		// (get) Token: 0x0600DC02 RID: 56322 RVA: 0x00204FDB File Offset: 0x002031DB
		// (set) Token: 0x0600DC03 RID: 56323 RVA: 0x00204FE3 File Offset: 0x002031E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x0600DC04 RID: 56324 RVA: 0x00204FEC File Offset: 0x002031EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MixDrinkRoleInviteRequest);
		}

		// Token: 0x0600DC05 RID: 56325 RVA: 0x00204FFA File Offset: 0x002031FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MixDrinkRoleInviteRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DC06 RID: 56326 RVA: 0x00205028 File Offset: 0x00203228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DC07 RID: 56327 RVA: 0x00205067 File Offset: 0x00203267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DC08 RID: 56328 RVA: 0x00205074 File Offset: 0x00203274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC09 RID: 56329 RVA: 0x0020507D File Offset: 0x0020327D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DC0A RID: 56330 RVA: 0x002050B0 File Offset: 0x002032B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DC0B RID: 56331 RVA: 0x002050EE File Offset: 0x002032EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MixDrinkRoleInviteRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DC0C RID: 56332 RVA: 0x0020511F File Offset: 0x0020331F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC0D RID: 56333 RVA: 0x00205128 File Offset: 0x00203328
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005B85 RID: 23429
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B86 RID: 23430
		public const int RoleIdFieldNumber = 11;

		// Token: 0x04005B87 RID: 23431
		private int roleId_;
	}
}
