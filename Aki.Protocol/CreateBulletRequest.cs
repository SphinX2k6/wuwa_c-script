using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000319 RID: 793
	[NetMessage(EMessageId.CreateBulletRequest)]
	public sealed class CreateBulletRequest : IMessage<CreateBulletRequest>, IMessage, IEquatable<CreateBulletRequest>, IDeepCloneable<CreateBulletRequest>, IBufferMessage
	{
		// Token: 0x06005022 RID: 20514 RVA: 0x000C36A4 File Offset: 0x000C18A4
		[NullableContext(1)]
		public static CreateBulletRequest Create()
		{
			return new CreateBulletRequest();
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06005023 RID: 20515 RVA: 0x000C36AB File Offset: 0x000C18AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06005024 RID: 20516 RVA: 0x000C36AE File Offset: 0x000C18AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateBulletRequest.Descriptor;
			}
		}

		// Token: 0x06005025 RID: 20517 RVA: 0x000C36B5 File Offset: 0x000C18B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletRequest()
		{
		}

		// Token: 0x06005026 RID: 20518 RVA: 0x000C36C0 File Offset: 0x000C18C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletRequest(CreateBulletRequest other) : this()
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

		// Token: 0x06005027 RID: 20519 RVA: 0x000C3808 File Offset: 0x000C1A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletRequest Clone()
		{
			return new CreateBulletRequest(this);
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06005028 RID: 20520 RVA: 0x000C3810 File Offset: 0x000C1A10
		// (set) Token: 0x06005029 RID: 20521 RVA: 0x000C3818 File Offset: 0x000C1A18
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

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x0600502A RID: 20522 RVA: 0x000C3821 File Offset: 0x000C1A21
		// (set) Token: 0x0600502B RID: 20523 RVA: 0x000C3829 File Offset: 0x000C1A29
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

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x0600502C RID: 20524 RVA: 0x000C3832 File Offset: 0x000C1A32
		// (set) Token: 0x0600502D RID: 20525 RVA: 0x000C383A File Offset: 0x000C1A3A
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

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x0600502E RID: 20526 RVA: 0x000C3843 File Offset: 0x000C1A43
		// (set) Token: 0x0600502F RID: 20527 RVA: 0x000C384B File Offset: 0x000C1A4B
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

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06005030 RID: 20528 RVA: 0x000C3854 File Offset: 0x000C1A54
		// (set) Token: 0x06005031 RID: 20529 RVA: 0x000C385C File Offset: 0x000C1A5C
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

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06005032 RID: 20530 RVA: 0x000C3865 File Offset: 0x000C1A65
		// (set) Token: 0x06005033 RID: 20531 RVA: 0x000C386D File Offset: 0x000C1A6D
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

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06005034 RID: 20532 RVA: 0x000C3876 File Offset: 0x000C1A76
		// (set) Token: 0x06005035 RID: 20533 RVA: 0x000C387E File Offset: 0x000C1A7E
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

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06005036 RID: 20534 RVA: 0x000C3887 File Offset: 0x000C1A87
		// (set) Token: 0x06005037 RID: 20535 RVA: 0x000C388F File Offset: 0x000C1A8F
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

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06005038 RID: 20536 RVA: 0x000C3898 File Offset: 0x000C1A98
		// (set) Token: 0x06005039 RID: 20537 RVA: 0x000C38A0 File Offset: 0x000C1AA0
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

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x0600503A RID: 20538 RVA: 0x000C38A9 File Offset: 0x000C1AA9
		// (set) Token: 0x0600503B RID: 20539 RVA: 0x000C38B1 File Offset: 0x000C1AB1
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

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x0600503C RID: 20540 RVA: 0x000C38BA File Offset: 0x000C1ABA
		// (set) Token: 0x0600503D RID: 20541 RVA: 0x000C38C2 File Offset: 0x000C1AC2
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

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x0600503E RID: 20542 RVA: 0x000C38CB File Offset: 0x000C1ACB
		// (set) Token: 0x0600503F RID: 20543 RVA: 0x000C38D3 File Offset: 0x000C1AD3
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

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06005040 RID: 20544 RVA: 0x000C38DC File Offset: 0x000C1ADC
		// (set) Token: 0x06005041 RID: 20545 RVA: 0x000C38E4 File Offset: 0x000C1AE4
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

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06005042 RID: 20546 RVA: 0x000C38ED File Offset: 0x000C1AED
		// (set) Token: 0x06005043 RID: 20547 RVA: 0x000C38F5 File Offset: 0x000C1AF5
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

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06005044 RID: 20548 RVA: 0x000C38FE File Offset: 0x000C1AFE
		// (set) Token: 0x06005045 RID: 20549 RVA: 0x000C3906 File Offset: 0x000C1B06
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

		// Token: 0x06005046 RID: 20550 RVA: 0x000C390F File Offset: 0x000C1B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateBulletRequest);
		}

		// Token: 0x06005047 RID: 20551 RVA: 0x000C3920 File Offset: 0x000C1B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CreateBulletRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.Handle, other.Handle) && this.OwnerEntityId == other.OwnerEntityId && this.BulletId == other.BulletId && this.SkillId == other.SkillId && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && object.Equals(this.ParentHandle, other.ParentHandle) && this.TargetId == other.TargetId && this.SpawnEntityId == other.SpawnEntityId && this.SpawnVelocityEntityId == other.SpawnVelocityEntityId && this.IsLocal == other.IsLocal && this.DtType == other.DtType && object.Equals(this.RandomInitPosOffset, other.RandomInitPosOffset) && object.Equals(this.RandomInitSpeed, other.RandomInitSpeed) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005048 RID: 20552 RVA: 0x000C3A5C File Offset: 0x000C1C5C
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

		// Token: 0x06005049 RID: 20553 RVA: 0x000C3BE4 File Offset: 0x000C1DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600504A RID: 20554 RVA: 0x000C3BF1 File Offset: 0x000C1DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600504B RID: 20555 RVA: 0x000C3BFC File Offset: 0x000C1DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.parentHandle_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ParentHandle);
			}
			if (this.handle_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Handle);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.TargetId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.TargetId);
			}
			if (this.DtType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.DtType);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Location);
			}
			if (this.IsLocal)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsLocal);
			}
			if (this.SpawnEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.SpawnEntityId);
			}
			if (this.randomInitPosOffset_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.RandomInitPosOffset);
			}
			if (this.SpawnVelocityEntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.SpawnVelocityEntityId);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Rotation);
			}
			if (this.BulletId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.BulletId);
			}
			if (this.randomInitSpeed_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.RandomInitSpeed);
			}
			if (this.OwnerEntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.OwnerEntityId);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600504C RID: 20556 RVA: 0x000C3DC4 File Offset: 0x000C1FC4
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

		// Token: 0x0600504D RID: 20557 RVA: 0x000C3F48 File Offset: 0x000C2148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CreateBulletRequest other)
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

		// Token: 0x0600504E RID: 20558 RVA: 0x000C4144 File Offset: 0x000C2344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600504F RID: 20559 RVA: 0x000C4150 File Offset: 0x000C2350
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
					if (num <= 26U)
					{
						if (num == 10U)
						{
							if (this.parentHandle_ == null)
							{
								this.ParentHandle = new ActiveBulletHandle();
							}
							input.ReadMessage(this.ParentHandle);
							continue;
						}
						if (num == 18U)
						{
							if (this.handle_ == null)
							{
								this.Handle = new ActiveBulletHandle();
							}
							input.ReadMessage(this.Handle);
							continue;
						}
						if (num == 26U)
						{
							if (this.combatCommon_ == null)
							{
								this.CombatCommon = new CombatCommon();
							}
							input.ReadMessage(this.CombatCommon);
							continue;
						}
					}
					else if (num <= 40U)
					{
						if (num == 32U)
						{
							this.TargetId = input.ReadInt64();
							continue;
						}
						if (num == 40U)
						{
							this.DtType = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 50U)
						{
							if (this.location_ == null)
							{
								this.Location = new Vector();
							}
							input.ReadMessage(this.Location);
							continue;
						}
						if (num == 56U)
						{
							this.IsLocal = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 90U)
				{
					if (num <= 74U)
					{
						if (num == 64U)
						{
							this.SpawnEntityId = input.ReadInt64();
							continue;
						}
						if (num == 74U)
						{
							if (this.randomInitPosOffset_ == null)
							{
								this.RandomInitPosOffset = new Vector();
							}
							input.ReadMessage(this.RandomInitPosOffset);
							continue;
						}
					}
					else
					{
						if (num == 80U)
						{
							this.SpawnVelocityEntityId = input.ReadInt64();
							continue;
						}
						if (num == 90U)
						{
							if (this.rotation_ == null)
							{
								this.Rotation = new Rotator();
							}
							input.ReadMessage(this.Rotation);
							continue;
						}
					}
				}
				else if (num <= 106U)
				{
					if (num == 96U)
					{
						this.BulletId = input.ReadInt64();
						continue;
					}
					if (num == 106U)
					{
						if (this.randomInitSpeed_ == null)
						{
							this.RandomInitSpeed = new Vector();
						}
						input.ReadMessage(this.RandomInitSpeed);
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.OwnerEntityId = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.SkillId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003292 RID: 12946
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003293 RID: 12947
		public const int CombatCommonFieldNumber = 3;

		// Token: 0x04003294 RID: 12948
		private CombatCommon combatCommon_;

		// Token: 0x04003295 RID: 12949
		public const int HandleFieldNumber = 2;

		// Token: 0x04003296 RID: 12950
		private ActiveBulletHandle handle_;

		// Token: 0x04003297 RID: 12951
		public const int OwnerEntityIdFieldNumber = 14;

		// Token: 0x04003298 RID: 12952
		private long ownerEntityId_;

		// Token: 0x04003299 RID: 12953
		public const int BulletIdFieldNumber = 12;

		// Token: 0x0400329A RID: 12954
		private long bulletId_;

		// Token: 0x0400329B RID: 12955
		public const int SkillIdFieldNumber = 15;

		// Token: 0x0400329C RID: 12956
		private long skillId_;

		// Token: 0x0400329D RID: 12957
		public const int LocationFieldNumber = 6;

		// Token: 0x0400329E RID: 12958
		private Vector location_;

		// Token: 0x0400329F RID: 12959
		public const int RotationFieldNumber = 11;

		// Token: 0x040032A0 RID: 12960
		private Rotator rotation_;

		// Token: 0x040032A1 RID: 12961
		public const int ParentHandleFieldNumber = 1;

		// Token: 0x040032A2 RID: 12962
		private ActiveBulletHandle parentHandle_;

		// Token: 0x040032A3 RID: 12963
		public const int TargetIdFieldNumber = 4;

		// Token: 0x040032A4 RID: 12964
		private long targetId_;

		// Token: 0x040032A5 RID: 12965
		public const int SpawnEntityIdFieldNumber = 8;

		// Token: 0x040032A6 RID: 12966
		private long spawnEntityId_;

		// Token: 0x040032A7 RID: 12967
		public const int SpawnVelocityEntityIdFieldNumber = 10;

		// Token: 0x040032A8 RID: 12968
		private long spawnVelocityEntityId_;

		// Token: 0x040032A9 RID: 12969
		public const int IsLocalFieldNumber = 7;

		// Token: 0x040032AA RID: 12970
		private bool isLocal_;

		// Token: 0x040032AB RID: 12971
		public const int DtTypeFieldNumber = 5;

		// Token: 0x040032AC RID: 12972
		private int dtType_;

		// Token: 0x040032AD RID: 12973
		public const int RandomInitPosOffsetFieldNumber = 9;

		// Token: 0x040032AE RID: 12974
		private Vector randomInitPosOffset_;

		// Token: 0x040032AF RID: 12975
		public const int RandomInitSpeedFieldNumber = 13;

		// Token: 0x040032B0 RID: 12976
		private Vector randomInitSpeed_;
	}
}
