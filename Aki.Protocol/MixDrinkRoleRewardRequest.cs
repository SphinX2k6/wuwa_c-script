using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009DC RID: 2524
	[NetMessage(EMessageId.MixDrinkRoleRewardRequest)]
	public sealed class MixDrinkRoleRewardRequest : IMessage<MixDrinkRoleRewardRequest>, IMessage, IEquatable<MixDrinkRoleRewardRequest>, IDeepCloneable<MixDrinkRoleRewardRequest>, IBufferMessage
	{
		// Token: 0x0600DD3A RID: 56634 RVA: 0x00207539 File Offset: 0x00205739
		[NullableContext(1)]
		public static MixDrinkRoleRewardRequest Create()
		{
			return new MixDrinkRoleRewardRequest();
		}

		// Token: 0x17002CD6 RID: 11478
		// (get) Token: 0x0600DD3B RID: 56635 RVA: 0x00207540 File Offset: 0x00205740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CD7 RID: 11479
		// (get) Token: 0x0600DD3C RID: 56636 RVA: 0x00207543 File Offset: 0x00205743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MixDrinkRoleRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600DD3D RID: 56637 RVA: 0x0020754A File Offset: 0x0020574A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleRewardRequest()
		{
		}

		// Token: 0x0600DD3E RID: 56638 RVA: 0x00207552 File Offset: 0x00205752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleRewardRequest(MixDrinkRoleRewardRequest other) : this()
		{
			this.roleInviteId_ = other.roleInviteId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD3F RID: 56639 RVA: 0x00207577 File Offset: 0x00205777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleRewardRequest Clone()
		{
			return new MixDrinkRoleRewardRequest(this);
		}

		// Token: 0x17002CD8 RID: 11480
		// (get) Token: 0x0600DD40 RID: 56640 RVA: 0x0020757F File Offset: 0x0020577F
		// (set) Token: 0x0600DD41 RID: 56641 RVA: 0x00207587 File Offset: 0x00205787
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

		// Token: 0x0600DD42 RID: 56642 RVA: 0x00207590 File Offset: 0x00205790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MixDrinkRoleRewardRequest);
		}

		// Token: 0x0600DD43 RID: 56643 RVA: 0x0020759E File Offset: 0x0020579E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MixDrinkRoleRewardRequest other)
		{
			return other != null && (other == this || (this.RoleInviteId == other.RoleInviteId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD44 RID: 56644 RVA: 0x002075CC File Offset: 0x002057CC
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

		// Token: 0x0600DD45 RID: 56645 RVA: 0x0020760B File Offset: 0x0020580B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DD46 RID: 56646 RVA: 0x00207618 File Offset: 0x00205818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD47 RID: 56647 RVA: 0x00207621 File Offset: 0x00205821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleInviteId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RoleInviteId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD48 RID: 56648 RVA: 0x00207654 File Offset: 0x00205854
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

		// Token: 0x0600DD49 RID: 56649 RVA: 0x00207692 File Offset: 0x00205892
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

		// Token: 0x0600DD4A RID: 56650 RVA: 0x002076C3 File Offset: 0x002058C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD4B RID: 56651 RVA: 0x002076CC File Offset: 0x002058CC
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleInviteId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005B82 RID: 23426
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B83 RID: 23427
		public const int RoleInviteIdFieldNumber = 14;

		// Token: 0x04005B84 RID: 23428
		private int roleInviteId_;
	}
}
