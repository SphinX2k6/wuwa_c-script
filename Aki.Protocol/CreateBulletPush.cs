using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000318 RID: 792
	[NetMessage(EMessageId.CreateBulletPush)]
	public sealed class CreateBulletPush : IMessage<CreateBulletPush>, IMessage, IEquatable<CreateBulletPush>, IDeepCloneable<CreateBulletPush>, IBufferMessage
	{
		// Token: 0x06004FF4 RID: 20468 RVA: 0x000C29AF File Offset: 0x000C0BAF
		[NullableContext(1)]
		public static CreateBulletPush Create()
		{
			return new CreateBulletPush();
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06004FF5 RID: 20469 RVA: 0x000C29B6 File Offset: 0x000C0BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06004FF6 RID: 20470 RVA: 0x000C29B9 File Offset: 0x000C0BB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateBulletPush.Descriptor;
			}
		}

		// Token: 0x06004FF7 RID: 20471 RVA: 0x000C29C0 File Offset: 0x000C0BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletPush()
		{
		}

		// Token: 0x06004FF8 RID: 20472 RVA: 0x000C29C8 File Offset: 0x000C0BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletPush(CreateBulletPush other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.handle_ = ((other.handle_ != null) ? other.handle_.Clone() : null);
			this.ownerEntityId_ = other.ownerEntityId_;
			this.bulletId_ = other.bulletId_;
			this.skillId_ = other.skillId_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this.parentHandle_ = ((other.parentHandle_ != null) ? other.parentHandle_.Clone() : null);
			this.targetId_ = other.targetId_;
			this.spawnEntityId_ = other.spawnEntityId_;
			this.spawnVelocityEntityId_ = other.spawnVelocityEntityId_;
			this.isLocal_ = other.isLocal_;
			this.dtType_ = other.dtType_;
			this.randomInitPosOffset_ = ((other.randomInitPosOffset_ != null) ? other.randomInitPosOffset_.Clone() : null);
			this.randomInitSpeed_ = ((other.randomInitSpeed_ != null) ? other.randomInitSpeed_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004FF9 RID: 20473 RVA: 0x000C2B10 File Offset: 0x000C0D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletPush Clone()
		{
			return new CreateBulletPush(this);
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06004FFA RID: 20474 RVA: 0x000C2B18 File Offset: 0x000C0D18
		// (set) Token: 0x06004FFB RID: 20475 RVA: 0x000C2B20 File Offset: 0x000C0D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon CombatCommon
		{
			get
			{
				return this.combatCommon_;
			}
			set
			{
				this.combatCommon_ = value;
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06004FFC RID: 20476 RVA: 0x000C2B29 File Offset: 0x000C0D29
		// (set) Token: 0x06004FFD RID: 20477 RVA: 0x000C2B31 File Offset: 0x000C0D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveBulletHandle Handle
		{
			get
			{
				return this.handle_;
			}
			set
			{
				this.handle_ = value;
			}
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06004FFE RID: 20478 RVA: 0x000C2B3A File Offset: 0x000C0D3A
		// (set) Token: 0x06004FFF RID: 20479 RVA: 0x000C2B42 File Offset: 0x000C0D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OwnerEntityId
		{
			get
			{
				return this.ownerEntityId_;
			}
			set
			{
				this.ownerEntityId_ = value;
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06005000 RID: 20480 RVA: 0x000C2B4B File Offset: 0x000C0D4B
		// (set) Token: 0x06005001 RID: 20481 RVA: 0x000C2B53 File Offset: 0x000C0D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BulletId
		{
			get
			{
				return this.bulletId_;
			}
			set
			{
				this.bulletId_ = value;
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06005002 RID: 20482 RVA: 0x000C2B5C File Offset: 0x000C0D5C
		// (set) Token: 0x06005003 RID: 20483 RVA: 0x000C2B64 File Offset: 0x000C0D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06005004 RID: 20484 RVA: 0x000C2B6D File Offset: 0x000C0D6D
		// (set) Token: 0x06005005 RID: 20485 RVA: 0x000C2B75 File Offset: 0x000C0D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06005006 RID: 20486 RVA: 0x000C2B7E File Offset: 0x000C0D7E
		// (set) Token: 0x06005007 RID: 20487 RVA: 0x000C2B86 File Offset: 0x000C0D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rotation
		{
			get
			{
				return this.rotation_;
			}
			set
			{
				this.rotation_ = value;
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06005008 RID: 20488 RVA: 0x000C2B8F File Offset: 0x000C0D8F
		// (set) Token: 0x06005009 RID: 20489 RVA: 0x000C2B97 File Offset: 0x000C0D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActiveBulletHandle ParentHandle
		{
			get
			{
				return this.parentHandle_;
			}
			set
			{
				this.parentHandle_ = value;
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x0600500A RID: 20490 RVA: 0x000C2BA0 File Offset: 0x000C0DA0
		// (set) Token: 0x0600500B RID: 20491 RVA: 0x000C2BA8 File Offset: 0x000C0DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x0600500C RID: 20492 RVA: 0x000C2BB1 File Offset: 0x000C0DB1
		// (set) Token: 0x0600500D RID: 20493 RVA: 0x000C2BB9 File Offset: 0x000C0DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SpawnEntityId
		{
			get
			{
				return this.spawnEntityId_;
			}
			set
			{
				this.spawnEntityId_ = value;
			}
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x0600500E RID: 20494 RVA: 0x000C2BC2 File Offset: 0x000C0DC2
		// (set) Token: 0x0600500F RID: 20495 RVA: 0x000C2BCA File Offset: 0x000C0DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SpawnVelocityEntityId
		{
			get
			{
				return this.spawnVelocityEntityId_;
			}
			set
			{
				this.spawnVelocityEntityId_ = value;
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06005010 RID: 20496 RVA: 0x000C2BD3 File Offset: 0x000C0DD3
		// (set) Token: 0x06005011 RID: 20497 RVA: 0x000C2BDB File Offset: 0x000C0DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsLocal
		{
			get
			{
				return this.isLocal_;
			}
			set
			{
				this.isLocal_ = value;
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06005012 RID: 20498 RVA: 0x000C2BE4 File Offset: 0x000C0DE4
		// (set) Token: 0x06005013 RID: 20499 RVA: 0x000C2BEC File Offset: 0x000C0DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DtType
		{
			get
			{
				return this.dtType_;
			}
			set
			{
				this.dtType_ = value;
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06005014 RID: 20500 RVA: 0x000C2BF5 File Offset: 0x000C0DF5
		// (set) Token: 0x06005015 RID: 20501 RVA: 0x000C2BFD File Offset: 0x000C0DFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector RandomInitPosOffset
		{
			get
			{
				return this.randomInitPosOffset_;
			}
			set
			{
				this.randomInitPosOffset_ = value;
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06005016 RID: 20502 RVA: 0x000C2C06 File Offset: 0x000C0E06
		// (set) Token: 0x06005017 RID: 20503 RVA: 0x000C2C0E File Offset: 0x000C0E0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector RandomInitSpeed
		{
			get
			{
				return this.randomInitSpeed_;
			}
			set
			{
				this.randomInitSpeed_ = value;
			}
		}

		// Token: 0x06005018 RID: 20504 RVA: 0x000C2C17 File Offset: 0x000C0E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateBulletPush);
		}

		// Token: 0x06005019 RID: 20505 RVA: 0x000C2C28 File Offset: 0x000C0E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CreateBulletPush other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.Handle, other.Handle) && this.OwnerEntityId == other.OwnerEntityId && this.BulletId == other.BulletId && this.SkillId == other.SkillId && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && object.Equals(this.ParentHandle, other.ParentHandle) && this.TargetId == other.TargetId && this.SpawnEntityId == other.SpawnEntityId && this.SpawnVelocityEntityId == other.SpawnVelocityEntityId && this.IsLocal == other.IsLocal && this.DtType == other.DtType && object.Equals(this.RandomInitPosOffset, other.RandomInitPosOffset) && object.Equals(this.RandomInitSpeed, other.RandomInitSpeed) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600501A RID: 20506 RVA: 0x000C2D64 File Offset: 0x000C0F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.handle_ != null)
			{
				num ^= this.Handle.GetHashCode();
			}
			if (this.OwnerEntityId != 0L)
			{
				num ^= this.OwnerEntityId.GetHashCode();
			}
			if (this.BulletId != 0L)
			{
				num ^= this.BulletId.GetHashCode();
			}
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this.rotation_ != null)
			{
				num ^= this.Rotation.GetHashCode();
			}
			if (this.parentHandle_ != null)
			{
				num ^= this.ParentHandle.GetHashCode();
			}
			if (this.TargetId != 0L)
			{
				num ^= this.TargetId.GetHashCode();
			}
			if (this.SpawnEntityId != 0L)
			{
				num ^= this.SpawnEntityId.GetHashCode();
			}
			if (this.SpawnVelocityEntityId != 0L)
			{
				num ^= this.SpawnVelocityEntityId.GetHashCode();
			}
			if (this.IsLocal)
			{
				num ^= this.IsLocal.GetHashCode();
			}
			if (this.DtType != 0)
			{
				num ^= this.DtType.GetHashCode();
			}
			if (this.randomInitPosOffset_ != null)
			{
				num ^= this.RandomInitPosOffset.GetHashCode();
			}
			if (this.randomInitSpeed_ != null)
			{
				num ^= this.RandomInitSpeed.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600501B RID: 20507 RVA: 0x000C2EEC File Offset: 0x000C10EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600501C RID: 20508 RVA: 0x000C2EF9 File Offset: 0x000C10F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600501D RID: 20509 RVA: 0x000C2F04 File Offset: 0x000C1104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.handle_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Handle);
			}
			if (this.randomInitPosOffset_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RandomInitPosOffset);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.SkillId);
			}
			if (this.SpawnVelocityEntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.SpawnVelocityEntityId);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.randomInitSpeed_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RandomInitSpeed);
			}
			if (this.TargetId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.TargetId);
			}
			if (this.OwnerEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.OwnerEntityId);
			}
			if (this.parentHandle_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.ParentHandle);
			}
			if (this.IsLocal)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsLocal);
			}
			if (this.DtType != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.DtType);
			}
			if (this.BulletId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.BulletId);
			}
			if (this.SpawnEntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.SpawnEntityId);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Rotation);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Location);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600501E RID: 20510 RVA: 0x000C30CC File Offset: 0x000C12CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.handle_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Handle);
			}
			if (this.OwnerEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.OwnerEntityId);
			}
			if (this.BulletId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BulletId);
			}
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this.rotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rotation);
			}
			if (this.parentHandle_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ParentHandle);
			}
			if (this.TargetId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetId);
			}
			if (this.SpawnEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SpawnEntityId);
			}
			if (this.SpawnVelocityEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SpawnVelocityEntityId);
			}
			if (this.IsLocal)
			{
				num += 2;
			}
			if (this.DtType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DtType);
			}
			if (this.randomInitPosOffset_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RandomInitPosOffset);
			}
			if (this.randomInitSpeed_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RandomInitSpeed);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600501F RID: 20511 RVA: 0x000C3250 File Offset: 0x000C1450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CreateBulletPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.combatCommon_ != null)
			{
				if (this.combatCommon_ == null)
				{
					this.CombatCommon = new CombatCommon();
				}
				this.CombatCommon.MergeFrom(other.CombatCommon);
			}
			if (other.handle_ != null)
			{
				if (this.handle_ == null)
				{
					this.Handle = new ActiveBulletHandle();
				}
				this.Handle.MergeFrom(other.Handle);
			}
			if (other.OwnerEntityId != 0L)
			{
				this.OwnerEntityId = other.OwnerEntityId;
			}
			if (other.BulletId != 0L)
			{
				this.BulletId = other.BulletId;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			if (other.rotation_ != null)
			{
				if (this.rotation_ == null)
				{
					this.Rotation = new Rotator();
				}
				this.Rotation.MergeFrom(other.Rotation);
			}
			if (other.parentHandle_ != null)
			{
				if (this.parentHandle_ == null)
				{
					this.ParentHandle = new ActiveBulletHandle();
				}
				this.ParentHandle.MergeFrom(other.ParentHandle);
			}
			if (other.TargetId != 0L)
			{
				this.TargetId = other.TargetId;
			}
			if (other.SpawnEntityId != 0L)
			{
				this.SpawnEntityId = other.SpawnEntityId;
			}
			if (other.SpawnVelocityEntityId != 0L)
			{
				this.SpawnVelocityEntityId = other.SpawnVelocityEntityId;
			}
			if (other.IsLocal)
			{
				this.IsLocal = other.IsLocal;
			}
			if (other.DtType != 0)
			{
				this.DtType = other.DtType;
			}
			if (other.randomInitPosOffset_ != null)
			{
				if (this.randomInitPosOffset_ == null)
				{
					this.RandomInitPosOffset = new Vector();
				}
				this.RandomInitPosOffset.MergeFrom(other.RandomInitPosOffset);
			}
			if (other.randomInitSpeed_ != null)
			{
				if (this.randomInitSpeed_ == null)
				{
					this.RandomInitSpeed = new Vector();
				}
				this.RandomInitSpeed.MergeFrom(other.RandomInitSpeed);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005020 RID: 20512 RVA: 0x000C344C File Offset: 0x000C164C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005021 RID: 20513 RVA: 0x000C3458 File Offset: 0x000C1658
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
				if (num <= 56U)
				{
					if (num <= 24U)
					{
						if (num == 10U)
						{
							if (this.handle_ == null)
							{
								this.Handle = new ActiveBulletHandle();
							}
							input.ReadMessage(this.Handle);
							continue;
						}
						if (num == 18U)
						{
							if (this.randomInitPosOffset_ == null)
							{
								this.RandomInitPosOffset = new Vector();
							}
							input.ReadMessage(this.RandomInitPosOffset);
							continue;
						}
						if (num == 24U)
						{
							this.SkillId = input.ReadInt64();
							continue;
						}
					}
					else if (num <= 42U)
					{
						if (num == 32U)
						{
							this.SpawnVelocityEntityId = input.ReadInt64();
							continue;
						}
						if (num == 42U)
						{
							if (this.combatCommon_ == null)
							{
								this.CombatCommon = new CombatCommon();
							}
							input.ReadMessage(this.CombatCommon);
							continue;
						}
					}
					else
					{
						if (num == 50U)
						{
							if (this.randomInitSpeed_ == null)
							{
								this.RandomInitSpeed = new Vector();
							}
							input.ReadMessage(this.RandomInitSpeed);
							continue;
						}
						if (num == 56U)
						{
							this.TargetId = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num <= 74U)
					{
						if (num == 64U)
						{
							this.OwnerEntityId = input.ReadInt64();
							continue;
						}
						if (num == 74U)
						{
							if (this.parentHandle_ == null)
							{
								this.ParentHandle = new ActiveBulletHandle();
							}
							input.ReadMessage(this.ParentHandle);
							continue;
						}
					}
					else
					{
						if (num == 80U)
						{
							this.IsLocal = input.ReadBool();
							continue;
						}
						if (num == 88U)
						{
							this.DtType = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 104U)
				{
					if (num == 96U)
					{
						this.BulletId = input.ReadInt64();
						continue;
					}
					if (num == 104U)
					{
						this.SpawnEntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						if (this.rotation_ == null)
						{
							this.Rotation = new Rotator();
						}
						input.ReadMessage(this.Rotation);
						continue;
					}
					if (num == 122U)
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003273 RID: 12915
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003274 RID: 12916
		public const int CombatCommonFieldNumber = 5;

		// Token: 0x04003275 RID: 12917
		private CombatCommon combatCommon_;

		// Token: 0x04003276 RID: 12918
		public const int HandleFieldNumber = 1;

		// Token: 0x04003277 RID: 12919
		private ActiveBulletHandle handle_;

		// Token: 0x04003278 RID: 12920
		public const int OwnerEntityIdFieldNumber = 8;

		// Token: 0x04003279 RID: 12921
		private long ownerEntityId_;

		// Token: 0x0400327A RID: 12922
		public const int BulletIdFieldNumber = 12;

		// Token: 0x0400327B RID: 12923
		private long bulletId_;

		// Token: 0x0400327C RID: 12924
		public const int SkillIdFieldNumber = 3;

		// Token: 0x0400327D RID: 12925
		private long skillId_;

		// Token: 0x0400327E RID: 12926
		public const int LocationFieldNumber = 15;

		// Token: 0x0400327F RID: 12927
		private Vector location_;

		// Token: 0x04003280 RID: 12928
		public const int RotationFieldNumber = 14;

		// Token: 0x04003281 RID: 12929
		private Rotator rotation_;

		// Token: 0x04003282 RID: 12930
		public const int ParentHandleFieldNumber = 9;

		// Token: 0x04003283 RID: 12931
		private ActiveBulletHandle parentHandle_;

		// Token: 0x04003284 RID: 12932
		public const int TargetIdFieldNumber = 7;

		// Token: 0x04003285 RID: 12933
		private long targetId_;

		// Token: 0x04003286 RID: 12934
		public const int SpawnEntityIdFieldNumber = 13;

		// Token: 0x04003287 RID: 12935
		private long spawnEntityId_;

		// Token: 0x04003288 RID: 12936
		public const int SpawnVelocityEntityIdFieldNumber = 4;

		// Token: 0x04003289 RID: 12937
		private long spawnVelocityEntityId_;

		// Token: 0x0400328A RID: 12938
		public const int IsLocalFieldNumber = 10;

		// Token: 0x0400328B RID: 12939
		private bool isLocal_;

		// Token: 0x0400328C RID: 12940
		public const int DtTypeFieldNumber = 11;

		// Token: 0x0400328D RID: 12941
		private int dtType_;

		// Token: 0x0400328E RID: 12942
		public const int RandomInitPosOffsetFieldNumber = 2;

		// Token: 0x0400328F RID: 12943
		private Vector randomInitPosOffset_;

		// Token: 0x04003290 RID: 12944
		public const int RandomInitSpeedFieldNumber = 6;

		// Token: 0x04003291 RID: 12945
		private Vector randomInitSpeed_;
	}
}
