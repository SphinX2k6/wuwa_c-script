using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009CB RID: 2507
	[NetMessage(EMessageId.MixDrinkRoleRewardRequest)]
	public sealed class MixDrinkRoleRewardRequest : IMessage<MixDrinkRoleRewardRequest>, IMessage, IEquatable<MixDrinkRoleRewardRequest>, IDeepCloneable<MixDrinkRoleRewardRequest>, IBufferMessage
	{
		// Token: 0x0600DC20 RID: 56352 RVA: 0x0020534D File Offset: 0x0020354D
		[NullableContext(1)]
		public static MixDrinkRoleRewardRequest Create()
		{
			return new MixDrinkRoleRewardRequest();
		}

		// Token: 0x17002C98 RID: 11416
		// (get) Token: 0x0600DC21 RID: 56353 RVA: 0x00205354 File Offset: 0x00203554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C99 RID: 11417
		// (get) Token: 0x0600DC22 RID: 56354 RVA: 0x00205357 File Offset: 0x00203557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MixDrinkRoleRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600DC23 RID: 56355 RVA: 0x0020535E File Offset: 0x0020355E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleRewardRequest()
		{
		}

		// Token: 0x0600DC24 RID: 56356 RVA: 0x00205366 File Offset: 0x00203566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleRewardRequest(MixDrinkRoleRewardRequest other) : this()
		{
			this.roleInviteId_ = other.roleInviteId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DC25 RID: 56357 RVA: 0x0020538B File Offset: 0x0020358B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleRewardRequest Clone()
		{
			return new MixDrinkRoleRewardRequest(this);
		}

		// Token: 0x17002C9A RID: 11418
		// (get) Token: 0x0600DC26 RID: 56358 RVA: 0x00205393 File Offset: 0x00203593
		// (set) Token: 0x0600DC27 RID: 56359 RVA: 0x0020539B File Offset: 0x0020359B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleInviteId
		{
			get
			{
				return this.roleInviteId_;
			}
			set
			{
				this.roleInviteId_ = value;
			}
		}

		// Token: 0x0600DC28 RID: 56360 RVA: 0x002053A4 File Offset: 0x002035A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MixDrinkRoleRewardRequest);
		}

		// Token: 0x0600DC29 RID: 56361 RVA: 0x002053B2 File Offset: 0x002035B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MixDrinkRoleRewardRequest other)
		{
			return other != null && (other == this || (this.RoleInviteId == other.RoleInviteId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DC2A RID: 56362 RVA: 0x002053E0 File Offset: 0x002035E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleInviteId != 0)
			{
				num ^= this.RoleInviteId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DC2B RID: 56363 RVA: 0x0020541F File Offset: 0x0020361F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DC2C RID: 56364 RVA: 0x0020542C File Offset: 0x0020362C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC2D RID: 56365 RVA: 0x00205435 File Offset: 0x00203635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleInviteId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleInviteId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DC2E RID: 56366 RVA: 0x00205468 File Offset: 0x00203668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleInviteId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleInviteId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DC2F RID: 56367 RVA: 0x002054A6 File Offset: 0x002036A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MixDrinkRoleRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleInviteId != 0)
			{
				this.RoleInviteId = other.RoleInviteId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DC30 RID: 56368 RVA: 0x002054D7 File Offset: 0x002036D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC31 RID: 56369 RVA: 0x002054E0 File Offset: 0x002036E0
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
					this.RoleInviteId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005B8B RID: 23435
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B8C RID: 23436
		public const int RoleInviteIdFieldNumber = 2;

		// Token: 0x04005B8D RID: 23437
		private int roleInviteId_;
	}
}
