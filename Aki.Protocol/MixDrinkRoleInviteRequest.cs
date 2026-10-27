using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009DA RID: 2522
	[NetMessage(EMessageId.MixDrinkRoleInviteRequest)]
	public sealed class MixDrinkRoleInviteRequest : IMessage<MixDrinkRoleInviteRequest>, IMessage, IEquatable<MixDrinkRoleInviteRequest>, IDeepCloneable<MixDrinkRoleInviteRequest>, IBufferMessage
	{
		// Token: 0x0600DD16 RID: 56598 RVA: 0x00207181 File Offset: 0x00205381
		[NullableContext(1)]
		public static MixDrinkRoleInviteRequest Create()
		{
			return new MixDrinkRoleInviteRequest();
		}

		// Token: 0x17002CD0 RID: 11472
		// (get) Token: 0x0600DD17 RID: 56599 RVA: 0x00207188 File Offset: 0x00205388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CD1 RID: 11473
		// (get) Token: 0x0600DD18 RID: 56600 RVA: 0x0020718B File Offset: 0x0020538B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MixDrinkRoleInviteRequest.Descriptor;
			}
		}

		// Token: 0x0600DD19 RID: 56601 RVA: 0x00207192 File Offset: 0x00205392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleInviteRequest()
		{
		}

		// Token: 0x0600DD1A RID: 56602 RVA: 0x0020719A File Offset: 0x0020539A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleInviteRequest(MixDrinkRoleInviteRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD1B RID: 56603 RVA: 0x002071BF File Offset: 0x002053BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleInviteRequest Clone()
		{
			return new MixDrinkRoleInviteRequest(this);
		}

		// Token: 0x17002CD2 RID: 11474
		// (get) Token: 0x0600DD1C RID: 56604 RVA: 0x002071C7 File Offset: 0x002053C7
		// (set) Token: 0x0600DD1D RID: 56605 RVA: 0x002071CF File Offset: 0x002053CF
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

		// Token: 0x0600DD1E RID: 56606 RVA: 0x002071D8 File Offset: 0x002053D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MixDrinkRoleInviteRequest);
		}

		// Token: 0x0600DD1F RID: 56607 RVA: 0x002071E6 File Offset: 0x002053E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MixDrinkRoleInviteRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD20 RID: 56608 RVA: 0x00207214 File Offset: 0x00205414
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

		// Token: 0x0600DD21 RID: 56609 RVA: 0x00207253 File Offset: 0x00205453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DD22 RID: 56610 RVA: 0x00207260 File Offset: 0x00205460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD23 RID: 56611 RVA: 0x00207269 File Offset: 0x00205469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD24 RID: 56612 RVA: 0x0020729C File Offset: 0x0020549C
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

		// Token: 0x0600DD25 RID: 56613 RVA: 0x002072DA File Offset: 0x002054DA
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

		// Token: 0x0600DD26 RID: 56614 RVA: 0x0020730B File Offset: 0x0020550B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD27 RID: 56615 RVA: 0x00207314 File Offset: 0x00205514
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005B7C RID: 23420
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B7D RID: 23421
		public const int RoleIdFieldNumber = 3;

		// Token: 0x04005B7E RID: 23422
		private int roleId_;
	}
}
