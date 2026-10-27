using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013AF RID: 5039
	[NetMessage(EMessageId.TowerDefenceRoleReviveNotify)]
	public sealed class TowerDefenceRoleReviveNotify : IMessage<TowerDefenceRoleReviveNotify>, IMessage, IEquatable<TowerDefenceRoleReviveNotify>, IDeepCloneable<TowerDefenceRoleReviveNotify>, IBufferMessage
	{
		// Token: 0x0601ABC5 RID: 109509 RVA: 0x003E09F7 File Offset: 0x003DEBF7
		[NullableContext(1)]
		public static TowerDefenceRoleReviveNotify Create()
		{
			return new TowerDefenceRoleReviveNotify();
		}

		// Token: 0x17005A2A RID: 23082
		// (get) Token: 0x0601ABC6 RID: 109510 RVA: 0x003E09FE File Offset: 0x003DEBFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A2B RID: 23083
		// (get) Token: 0x0601ABC7 RID: 109511 RVA: 0x003E0A01 File Offset: 0x003DEC01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceRoleReviveNotify.Descriptor;
			}
		}

		// Token: 0x0601ABC8 RID: 109512 RVA: 0x003E0A08 File Offset: 0x003DEC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRoleReviveNotify()
		{
		}

		// Token: 0x0601ABC9 RID: 109513 RVA: 0x003E0A10 File Offset: 0x003DEC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRoleReviveNotify(TowerDefenceRoleReviveNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.roleId_ = other.roleId_;
			this.reviveTime_ = other.reviveTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ABCA RID: 109514 RVA: 0x003E0A4D File Offset: 0x003DEC4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRoleReviveNotify Clone()
		{
			return new TowerDefenceRoleReviveNotify(this);
		}

		// Token: 0x17005A2C RID: 23084
		// (get) Token: 0x0601ABCB RID: 109515 RVA: 0x003E0A55 File Offset: 0x003DEC55
		// (set) Token: 0x0601ABCC RID: 109516 RVA: 0x003E0A5D File Offset: 0x003DEC5D
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

		// Token: 0x17005A2D RID: 23085
		// (get) Token: 0x0601ABCD RID: 109517 RVA: 0x003E0A66 File Offset: 0x003DEC66
		// (set) Token: 0x0601ABCE RID: 109518 RVA: 0x003E0A6E File Offset: 0x003DEC6E
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

		// Token: 0x17005A2E RID: 23086
		// (get) Token: 0x0601ABCF RID: 109519 RVA: 0x003E0A77 File Offset: 0x003DEC77
		// (set) Token: 0x0601ABD0 RID: 109520 RVA: 0x003E0A7F File Offset: 0x003DEC7F
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

		// Token: 0x0601ABD1 RID: 109521 RVA: 0x003E0A88 File Offset: 0x003DEC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceRoleReviveNotify);
		}

		// Token: 0x0601ABD2 RID: 109522 RVA: 0x003E0A98 File Offset: 0x003DEC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceRoleReviveNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.RoleId == other.RoleId && this.ReviveTime == other.ReviveTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ABD3 RID: 109523 RVA: 0x003E0AF4 File Offset: 0x003DECF4
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

		// Token: 0x0601ABD4 RID: 109524 RVA: 0x003E0B65 File Offset: 0x003DED65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ABD5 RID: 109525 RVA: 0x003E0B72 File Offset: 0x003DED72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ABD6 RID: 109526 RVA: 0x003E0B7C File Offset: 0x003DED7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReviveTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.ReviveTime);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PlayerId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ABD7 RID: 109527 RVA: 0x003E0BF4 File Offset: 0x003DEDF4
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

		// Token: 0x0601ABD8 RID: 109528 RVA: 0x003E0C64 File Offset: 0x003DEE64
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

		// Token: 0x0601ABD9 RID: 109529 RVA: 0x003E0CC8 File Offset: 0x003DEEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ABDA RID: 109530 RVA: 0x003E0CD4 File Offset: 0x003DEED4
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
					if (num != 104U)
					{
						if (num != 112U)
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
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.ReviveTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009B42 RID: 39746
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B43 RID: 39747
		public const int PlayerIdFieldNumber = 13;

		// Token: 0x04009B44 RID: 39748
		private int playerId_;

		// Token: 0x04009B45 RID: 39749
		public const int RoleIdFieldNumber = 14;

		// Token: 0x04009B46 RID: 39750
		private int roleId_;

		// Token: 0x04009B47 RID: 39751
		public const int ReviveTimeFieldNumber = 3;

		// Token: 0x04009B48 RID: 39752
		private long reviveTime_;
	}
}
