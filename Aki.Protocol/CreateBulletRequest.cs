using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000312 RID: 786
	[NetMessage(EMessageId.CreateBulletRequest)]
	public sealed class CreateBulletRequest : IMessage<CreateBulletRequest>, IMessage, IEquatable<CreateBulletRequest>, IDeepCloneable<CreateBulletRequest>, IBufferMessage
	{
		// Token: 0x06004F49 RID: 20297 RVA: 0x000C12BC File Offset: 0x000BF4BC
		[NullableContext(1)]
		public static CreateBulletRequest Create()
		{
			return new CreateBulletRequest();
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06004F4A RID: 20298 RVA: 0x000C12C3 File Offset: 0x000BF4C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06004F4B RID: 20299 RVA: 0x000C12C6 File Offset: 0x000BF4C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateBulletRequest.Descriptor;
			}
		}

		// Token: 0x06004F4C RID: 20300 RVA: 0x000C12CD File Offset: 0x000BF4CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletRequest()
		{
		}

		// Token: 0x06004F4D RID: 20301 RVA: 0x000C12D8 File Offset: 0x000BF4D8
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

		// Token: 0x06004F4E RID: 20302 RVA: 0x000C1420 File Offset: 0x000BF620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletRequest Clone()
		{
			return new CreateBulletRequest(this);
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06004F4F RID: 20303 RVA: 0x000C1428 File Offset: 0x000BF628
		// (set) Token: 0x06004F50 RID: 20304 RVA: 0x000C1430 File Offset: 0x000BF630
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

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06004F51 RID: 20305 RVA: 0x000C1439 File Offset: 0x000BF639
		// (set) Token: 0x06004F52 RID: 20306 RVA: 0x000C1441 File Offset: 0x000BF641
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

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06004F53 RID: 20307 RVA: 0x000C144A File Offset: 0x000BF64A
		// (set) Token: 0x06004F54 RID: 20308 RVA: 0x000C1452 File Offset: 0x000BF652
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

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06004F55 RID: 20309 RVA: 0x000C145B File Offset: 0x000BF65B
		// (set) Token: 0x06004F56 RID: 20310 RVA: 0x000C1463 File Offset: 0x000BF663
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

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06004F57 RID: 20311 RVA: 0x000C146C File Offset: 0x000BF66C
		// (set) Token: 0x06004F58 RID: 20312 RVA: 0x000C1474 File Offset: 0x000BF674
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

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06004F59 RID: 20313 RVA: 0x000C147D File Offset: 0x000BF67D
		// (set) Token: 0x06004F5A RID: 20314 RVA: 0x000C1485 File Offset: 0x000BF685
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

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06004F5B RID: 20315 RVA: 0x000C148E File Offset: 0x000BF68E
		// (set) Token: 0x06004F5C RID: 20316 RVA: 0x000C1496 File Offset: 0x000BF696
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

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06004F5D RID: 20317 RVA: 0x000C149F File Offset: 0x000BF69F
		// (set) Token: 0x06004F5E RID: 20318 RVA: 0x000C14A7 File Offset: 0x000BF6A7
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

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06004F5F RID: 20319 RVA: 0x000C14B0 File Offset: 0x000BF6B0
		// (set) Token: 0x06004F60 RID: 20320 RVA: 0x000C14B8 File Offset: 0x000BF6B8
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

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06004F61 RID: 20321 RVA: 0x000C14C1 File Offset: 0x000BF6C1
		// (set) Token: 0x06004F62 RID: 20322 RVA: 0x000C14C9 File Offset: 0x000BF6C9
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

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06004F63 RID: 20323 RVA: 0x000C14D2 File Offset: 0x000BF6D2
		// (set) Token: 0x06004F64 RID: 20324 RVA: 0x000C14DA File Offset: 0x000BF6DA
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

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06004F65 RID: 20325 RVA: 0x000C14E3 File Offset: 0x000BF6E3
		// (set) Token: 0x06004F66 RID: 20326 RVA: 0x000C14EB File Offset: 0x000BF6EB
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

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06004F67 RID: 20327 RVA: 0x000C14F4 File Offset: 0x000BF6F4
		// (set) Token: 0x06004F68 RID: 20328 RVA: 0x000C14FC File Offset: 0x000BF6FC
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

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06004F69 RID: 20329 RVA: 0x000C1505 File Offset: 0x000BF705
		// (set) Token: 0x06004F6A RID: 20330 RVA: 0x000C150D File Offset: 0x000BF70D
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

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06004F6B RID: 20331 RVA: 0x000C1516 File Offset: 0x000BF716
		// (set) Token: 0x06004F6C RID: 20332 RVA: 0x000C151E File Offset: 0x000BF71E
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

		// Token: 0x06004F6D RID: 20333 RVA: 0x000C1527 File Offset: 0x000BF727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateBulletRequest);
		}

		// Token: 0x06004F6E RID: 20334 RVA: 0x000C1538 File Offset: 0x000BF738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CreateBulletRequest other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.Handle, other.Handle) && this.OwnerEntityId == other.OwnerEntityId && this.BulletId == other.BulletId && this.SkillId == other.SkillId && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && object.Equals(this.ParentHandle, other.ParentHandle) && this.TargetId == other.TargetId && this.SpawnEntityId == other.SpawnEntityId && this.SpawnVelocityEntityId == other.SpawnVelocityEntityId && this.IsLocal == other.IsLocal && this.DtType == other.DtType && object.Equals(this.RandomInitPosOffset, other.RandomInitPosOffset) && object.Equals(this.RandomInitSpeed, other.RandomInitSpeed) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004F6F RID: 20335 RVA: 0x000C1674 File Offset: 0x000BF874
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

		// Token: 0x06004F70 RID: 20336 RVA: 0x000C17FC File Offset: 0x000BF9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004F71 RID: 20337 RVA: 0x000C1809 File Offset: 0x000BFA09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F72 RID: 20338 RVA: 0x000C1814 File Offset: 0x000BFA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.SkillId);
			}
			if (this.TargetId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TargetId);
			}
			if (this.randomInitPosOffset_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RandomInitPosOffset);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Location);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Rotation);
			}
			if (this.handle_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Handle);
			}
			if (this.SpawnVelocityEntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.SpawnVelocityEntityId);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.randomInitSpeed_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.RandomInitSpeed);
			}
			if (this.SpawnEntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.SpawnEntityId);
			}
			if (this.IsLocal)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsLocal);
			}
			if (this.OwnerEntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.OwnerEntityId);
			}
			if (this.DtType != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.DtType);
			}
			if (this.parentHandle_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.ParentHandle);
			}
			if (this.BulletId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.BulletId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004F73 RID: 20339 RVA: 0x000C19D8 File Offset: 0x000BFBD8
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

		// Token: 0x06004F74 RID: 20340 RVA: 0x000C1B5C File Offset: 0x000BFD5C
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

		// Token: 0x06004F75 RID: 20341 RVA: 0x000C1D58 File Offset: 0x000BFF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F76 RID: 20342 RVA: 0x000C1D64 File Offset: 0x000BFF64
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
						if (num == 8U)
						{
							this.SkillId = input.ReadInt64();
							continue;
						}
						if (num == 16U)
						{
							this.TargetId = input.ReadInt64();
							continue;
						}
						if (num == 26U)
						{
							if (this.randomInitPosOffset_ == null)
							{
								this.RandomInitPosOffset = new Vector();
							}
							input.ReadMessage(this.RandomInitPosOffset);
							continue;
						}
					}
					else if (num <= 42U)
					{
						if (num == 34U)
						{
							if (this.location_ == null)
							{
								this.Location = new Vector();
							}
							input.ReadMessage(this.Location);
							continue;
						}
						if (num == 42U)
						{
							if (this.rotation_ == null)
							{
								this.Rotation = new Rotator();
							}
							input.ReadMessage(this.Rotation);
							continue;
						}
					}
					else
					{
						if (num == 50U)
						{
							if (this.handle_ == null)
							{
								this.Handle = new ActiveBulletHandle();
							}
							input.ReadMessage(this.Handle);
							continue;
						}
						if (num == 56U)
						{
							this.SpawnVelocityEntityId = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num <= 74U)
					{
						if (num == 66U)
						{
							if (this.combatCommon_ == null)
							{
								this.CombatCommon = new CombatCommon();
							}
							input.ReadMessage(this.CombatCommon);
							continue;
						}
						if (num == 74U)
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
						if (num == 80U)
						{
							this.SpawnEntityId = input.ReadInt64();
							continue;
						}
						if (num == 88U)
						{
							this.IsLocal = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 104U)
				{
					if (num == 96U)
					{
						this.OwnerEntityId = input.ReadInt64();
						continue;
					}
					if (num == 104U)
					{
						this.DtType = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						if (this.parentHandle_ == null)
						{
							this.ParentHandle = new ActiveBulletHandle();
						}
						input.ReadMessage(this.ParentHandle);
						continue;
					}
					if (num == 120U)
					{
						this.BulletId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040031FB RID: 12795
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031FC RID: 12796
		public const int CombatCommonFieldNumber = 8;

		// Token: 0x040031FD RID: 12797
		private CombatCommon combatCommon_;

		// Token: 0x040031FE RID: 12798
		public const int HandleFieldNumber = 6;

		// Token: 0x040031FF RID: 12799
		private ActiveBulletHandle handle_;

		// Token: 0x04003200 RID: 12800
		public const int OwnerEntityIdFieldNumber = 12;

		// Token: 0x04003201 RID: 12801
		private long ownerEntityId_;

		// Token: 0x04003202 RID: 12802
		public const int BulletIdFieldNumber = 15;

		// Token: 0x04003203 RID: 12803
		private long bulletId_;

		// Token: 0x04003204 RID: 12804
		public const int SkillIdFieldNumber = 1;

		// Token: 0x04003205 RID: 12805
		private long skillId_;

		// Token: 0x04003206 RID: 12806
		public const int LocationFieldNumber = 4;

		// Token: 0x04003207 RID: 12807
		private Vector location_;

		// Token: 0x04003208 RID: 12808
		public const int RotationFieldNumber = 5;

		// Token: 0x04003209 RID: 12809
		private Rotator rotation_;

		// Token: 0x0400320A RID: 12810
		public const int ParentHandleFieldNumber = 14;

		// Token: 0x0400320B RID: 12811
		private ActiveBulletHandle parentHandle_;

		// Token: 0x0400320C RID: 12812
		public const int TargetIdFieldNumber = 2;

		// Token: 0x0400320D RID: 12813
		private long targetId_;

		// Token: 0x0400320E RID: 12814
		public const int SpawnEntityIdFieldNumber = 10;

		// Token: 0x0400320F RID: 12815
		private long spawnEntityId_;

		// Token: 0x04003210 RID: 12816
		public const int SpawnVelocityEntityIdFieldNumber = 7;

		// Token: 0x04003211 RID: 12817
		private long spawnVelocityEntityId_;

		// Token: 0x04003212 RID: 12818
		public const int IsLocalFieldNumber = 11;

		// Token: 0x04003213 RID: 12819
		private bool isLocal_;

		// Token: 0x04003214 RID: 12820
		public const int DtTypeFieldNumber = 13;

		// Token: 0x04003215 RID: 12821
		private int dtType_;

		// Token: 0x04003216 RID: 12822
		public const int RandomInitPosOffsetFieldNumber = 3;

		// Token: 0x04003217 RID: 12823
		private Vector randomInitPosOffset_;

		// Token: 0x04003218 RID: 12824
		public const int RandomInitSpeedFieldNumber = 9;

		// Token: 0x04003219 RID: 12825
		private Vector randomInitSpeed_;
	}
}
