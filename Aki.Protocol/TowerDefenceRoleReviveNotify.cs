using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001422 RID: 5154
	[NetMessage(EMessageId.TowerDefenceRoleReviveNotify)]
	public sealed class TowerDefenceRoleReviveNotify : IMessage<TowerDefenceRoleReviveNotify>, IMessage, IEquatable<TowerDefenceRoleReviveNotify>, IDeepCloneable<TowerDefenceRoleReviveNotify>, IBufferMessage
	{
		// Token: 0x0601B650 RID: 112208 RVA: 0x003FBCB7 File Offset: 0x003F9EB7
		[NullableContext(1)]
		public static TowerDefenceRoleReviveNotify Create()
		{
			return new TowerDefenceRoleReviveNotify();
		}

		// Token: 0x17005CBF RID: 23743
		// (get) Token: 0x0601B651 RID: 112209 RVA: 0x003FBCBE File Offset: 0x003F9EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CC0 RID: 23744
		// (get) Token: 0x0601B652 RID: 112210 RVA: 0x003FBCC1 File Offset: 0x003F9EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceRoleReviveNotify.Descriptor;
			}
		}

		// Token: 0x0601B653 RID: 112211 RVA: 0x003FBCC8 File Offset: 0x003F9EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRoleReviveNotify()
		{
		}

		// Token: 0x0601B654 RID: 112212 RVA: 0x003FBCD0 File Offset: 0x003F9ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRoleReviveNotify(TowerDefenceRoleReviveNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.roleId_ = other.roleId_;
			this.reviveTime_ = other.reviveTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B655 RID: 112213 RVA: 0x003FBD0D File Offset: 0x003F9F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRoleReviveNotify Clone()
		{
			return new TowerDefenceRoleReviveNotify(this);
		}

		// Token: 0x17005CC1 RID: 23745
		// (get) Token: 0x0601B656 RID: 112214 RVA: 0x003FBD15 File Offset: 0x003F9F15
		// (set) Token: 0x0601B657 RID: 112215 RVA: 0x003FBD1D File Offset: 0x003F9F1D
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

		// Token: 0x17005CC2 RID: 23746
		// (get) Token: 0x0601B658 RID: 112216 RVA: 0x003FBD26 File Offset: 0x003F9F26
		// (set) Token: 0x0601B659 RID: 112217 RVA: 0x003FBD2E File Offset: 0x003F9F2E
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

		// Token: 0x17005CC3 RID: 23747
		// (get) Token: 0x0601B65A RID: 112218 RVA: 0x003FBD37 File Offset: 0x003F9F37
		// (set) Token: 0x0601B65B RID: 112219 RVA: 0x003FBD3F File Offset: 0x003F9F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ReviveTime
		{
			get
			{
				return this.reviveTime_;
			}
			set
			{
				this.reviveTime_ = value;
			}
		}

		// Token: 0x0601B65C RID: 112220 RVA: 0x003FBD48 File Offset: 0x003F9F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceRoleReviveNotify);
		}

		// Token: 0x0601B65D RID: 112221 RVA: 0x003FBD58 File Offset: 0x003F9F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceRoleReviveNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.RoleId == other.RoleId && this.ReviveTime == other.ReviveTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B65E RID: 112222 RVA: 0x003FBDB4 File Offset: 0x003F9FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.ReviveTime != 0L)
			{
				num ^= this.ReviveTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B65F RID: 112223 RVA: 0x003FBE25 File Offset: 0x003FA025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B660 RID: 112224 RVA: 0x003FBE32 File Offset: 0x003FA032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B661 RID: 112225 RVA: 0x003FBE3C File Offset: 0x003FA03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PlayerId);
			}
			if (this.ReviveTime != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.ReviveTime);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B662 RID: 112226 RVA: 0x003FBEB4 File Offset: 0x003FA0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.ReviveTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ReviveTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B663 RID: 112227 RVA: 0x003FBF24 File Offset: 0x003FA124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceRoleReviveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.ReviveTime != 0L)
			{
				this.ReviveTime = other.ReviveTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B664 RID: 112228 RVA: 0x003FBF88 File Offset: 0x003FA188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B665 RID: 112229 RVA: 0x003FBF94 File Offset: 0x003FA194
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
					if (num != 64U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RoleId = input.ReadInt32();
						}
					}
					else
					{
						this.ReviveTime = input.ReadInt64();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009F89 RID: 40841
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F8A RID: 40842
		public const int PlayerIdFieldNumber = 2;

		// Token: 0x04009F8B RID: 40843
		private int playerId_;

		// Token: 0x04009F8C RID: 40844
		public const int RoleIdFieldNumber = 9;

		// Token: 0x04009F8D RID: 40845
		private int roleId_;

		// Token: 0x04009F8E RID: 40846
		public const int ReviveTimeFieldNumber = 8;

		// Token: 0x04009F8F RID: 40847
		private long reviveTime_;
	}
}
