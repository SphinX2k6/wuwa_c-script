using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000317 RID: 791
	[NetMessage(EMessageId.CreateBulletNotify)]
	public sealed class CreateBulletNotify : IMessage<CreateBulletNotify>, IMessage, IEquatable<CreateBulletNotify>, IDeepCloneable<CreateBulletNotify>, IBufferMessage
	{
		// Token: 0x06004FBE RID: 20414 RVA: 0x000C1928 File Offset: 0x000BFB28
		[NullableContext(1)]
		public static CreateBulletNotify Create()
		{
			return new CreateBulletNotify();
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06004FBF RID: 20415 RVA: 0x000C192F File Offset: 0x000BFB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06004FC0 RID: 20416 RVA: 0x000C1932 File Offset: 0x000BFB32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateBulletNotify.Descriptor;
			}
		}

		// Token: 0x06004FC1 RID: 20417 RVA: 0x000C1939 File Offset: 0x000BFB39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletNotify()
		{
		}

		// Token: 0x06004FC2 RID: 20418 RVA: 0x000C194C File Offset: 0x000BFB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletNotify(CreateBulletNotify other) : this()
		{
			this._hasBits0 = other._hasBits0;
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
			this.tarLocation_ = ((other.tarLocation_ != null) ? other.tarLocation_.Clone() : null);
			this.dtType_ = other.dtType_;
			this.locationEntityId_ = other.locationEntityId_;
			this.size_ = ((other.size_ != null) ? other.size_.Clone() : null);
			this.randomInitPosOffset_ = ((other.randomInitPosOffset_ != null) ? other.randomInitPosOffset_.Clone() : null);
			this.randomInitSpeed_ = ((other.randomInitSpeed_ != null) ? other.randomInitSpeed_.Clone() : null);
			this.hitCase_ = other.hitCase_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004FC3 RID: 20419 RVA: 0x000C1AE4 File Offset: 0x000BFCE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletNotify Clone()
		{
			return new CreateBulletNotify(this);
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06004FC4 RID: 20420 RVA: 0x000C1AEC File Offset: 0x000BFCEC
		// (set) Token: 0x06004FC5 RID: 20421 RVA: 0x000C1AF4 File Offset: 0x000BFCF4
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

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06004FC6 RID: 20422 RVA: 0x000C1AFD File Offset: 0x000BFCFD
		// (set) Token: 0x06004FC7 RID: 20423 RVA: 0x000C1B05 File Offset: 0x000BFD05
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

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06004FC8 RID: 20424 RVA: 0x000C1B0E File Offset: 0x000BFD0E
		// (set) Token: 0x06004FC9 RID: 20425 RVA: 0x000C1B16 File Offset: 0x000BFD16
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

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06004FCA RID: 20426 RVA: 0x000C1B1F File Offset: 0x000BFD1F
		// (set) Token: 0x06004FCB RID: 20427 RVA: 0x000C1B27 File Offset: 0x000BFD27
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

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06004FCC RID: 20428 RVA: 0x000C1B30 File Offset: 0x000BFD30
		// (set) Token: 0x06004FCD RID: 20429 RVA: 0x000C1B38 File Offset: 0x000BFD38
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

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06004FCE RID: 20430 RVA: 0x000C1B41 File Offset: 0x000BFD41
		// (set) Token: 0x06004FCF RID: 20431 RVA: 0x000C1B49 File Offset: 0x000BFD49
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

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06004FD0 RID: 20432 RVA: 0x000C1B52 File Offset: 0x000BFD52
		// (set) Token: 0x06004FD1 RID: 20433 RVA: 0x000C1B5A File Offset: 0x000BFD5A
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

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06004FD2 RID: 20434 RVA: 0x000C1B63 File Offset: 0x000BFD63
		// (set) Token: 0x06004FD3 RID: 20435 RVA: 0x000C1B6B File Offset: 0x000BFD6B
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

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06004FD4 RID: 20436 RVA: 0x000C1B74 File Offset: 0x000BFD74
		// (set) Token: 0x06004FD5 RID: 20437 RVA: 0x000C1B7C File Offset: 0x000BFD7C
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

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06004FD6 RID: 20438 RVA: 0x000C1B85 File Offset: 0x000BFD85
		// (set) Token: 0x06004FD7 RID: 20439 RVA: 0x000C1B8D File Offset: 0x000BFD8D
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

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06004FD8 RID: 20440 RVA: 0x000C1B96 File Offset: 0x000BFD96
		// (set) Token: 0x06004FD9 RID: 20441 RVA: 0x000C1B9E File Offset: 0x000BFD9E
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

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06004FDA RID: 20442 RVA: 0x000C1BA7 File Offset: 0x000BFDA7
		// (set) Token: 0x06004FDB RID: 20443 RVA: 0x000C1BAF File Offset: 0x000BFDAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector TarLocation
		{
			get
			{
				return this.tarLocation_;
			}
			set
			{
				this.tarLocation_ = value;
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06004FDC RID: 20444 RVA: 0x000C1BB8 File Offset: 0x000BFDB8
		// (set) Token: 0x06004FDD RID: 20445 RVA: 0x000C1BC0 File Offset: 0x000BFDC0
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

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06004FDE RID: 20446 RVA: 0x000C1BC9 File Offset: 0x000BFDC9
		// (set) Token: 0x06004FDF RID: 20447 RVA: 0x000C1BE1 File Offset: 0x000BFDE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LocationEntityId
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.locationEntityId_;
				}
				return CreateBulletNotify.LocationEntityIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.locationEntityId_ = value;
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06004FE0 RID: 20448 RVA: 0x000C1BF8 File Offset: 0x000BFDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasLocationEntityId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004FE1 RID: 20449 RVA: 0x000C1C05 File Offset: 0x000BFE05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLocationEntityId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06004FE2 RID: 20450 RVA: 0x000C1C16 File Offset: 0x000BFE16
		// (set) Token: 0x06004FE3 RID: 20451 RVA: 0x000C1C1E File Offset: 0x000BFE1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Size
		{
			get
			{
				return this.size_;
			}
			set
			{
				this.size_ = value;
			}
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06004FE4 RID: 20452 RVA: 0x000C1C27 File Offset: 0x000BFE27
		// (set) Token: 0x06004FE5 RID: 20453 RVA: 0x000C1C2F File Offset: 0x000BFE2F
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

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06004FE6 RID: 20454 RVA: 0x000C1C38 File Offset: 0x000BFE38
		// (set) Token: 0x06004FE7 RID: 20455 RVA: 0x000C1C40 File Offset: 0x000BFE40
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

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06004FE8 RID: 20456 RVA: 0x000C1C49 File Offset: 0x000BFE49
		// (set) Token: 0x06004FE9 RID: 20457 RVA: 0x000C1C51 File Offset: 0x000BFE51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string HitCase
		{
			get
			{
				return this.hitCase_;
			}
			set
			{
				this.hitCase_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06004FEA RID: 20458 RVA: 0x000C1C64 File Offset: 0x000BFE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateBulletNotify);
		}

		// Token: 0x06004FEB RID: 20459 RVA: 0x000C1C74 File Offset: 0x000BFE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CreateBulletNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.Handle, other.Handle) && this.OwnerEntityId == other.OwnerEntityId && this.BulletId == other.BulletId && this.SkillId == other.SkillId && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && object.Equals(this.ParentHandle, other.ParentHandle) && this.TargetId == other.TargetId && this.SpawnEntityId == other.SpawnEntityId && this.SpawnVelocityEntityId == other.SpawnVelocityEntityId && object.Equals(this.TarLocation, other.TarLocation) && this.DtType == other.DtType && this.LocationEntityId == other.LocationEntityId && object.Equals(this.Size, other.Size) && object.Equals(this.RandomInitPosOffset, other.RandomInitPosOffset) && object.Equals(this.RandomInitSpeed, other.RandomInitSpeed) && !(this.HitCase != other.HitCase) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004FEC RID: 20460 RVA: 0x000C1DF0 File Offset: 0x000BFFF0
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
			if (this.tarLocation_ != null)
			{
				num ^= this.TarLocation.GetHashCode();
			}
			if (this.DtType != 0)
			{
				num ^= this.DtType.GetHashCode();
			}
			if (this.HasLocationEntityId)
			{
				num ^= this.LocationEntityId.GetHashCode();
			}
			if (this.size_ != null)
			{
				num ^= this.Size.GetHashCode();
			}
			if (this.randomInitPosOffset_ != null)
			{
				num ^= this.RandomInitPosOffset.GetHashCode();
			}
			if (this.randomInitSpeed_ != null)
			{
				num ^= this.RandomInitSpeed.GetHashCode();
			}
			if (this.HitCase.Length != 0)
			{
				num ^= this.HitCase.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004FED RID: 20461 RVA: 0x000C1FBF File Offset: 0x000C01BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004FEE RID: 20462 RVA: 0x000C1FCC File Offset: 0x000C01CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004FEF RID: 20463 RVA: 0x000C1FD8 File Offset: 0x000C01D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SpawnVelocityEntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.SpawnVelocityEntityId);
			}
			if (this.HitCase.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.HitCase);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(248, 1);
				output.WriteInt64(this.SkillId);
			}
			if (this.parentHandle_ != null)
			{
				output.WriteRawTag(186, 2);
				output.WriteMessage(this.ParentHandle);
			}
			if (this.handle_ != null)
			{
				output.WriteRawTag(218, 3);
				output.WriteMessage(this.Handle);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(170, 6);
				output.WriteMessage(this.Rotation);
			}
			if (this.randomInitSpeed_ != null)
			{
				output.WriteRawTag(186, 6);
				output.WriteMessage(this.RandomInitSpeed);
			}
			if (this.OwnerEntityId != 0L)
			{
				output.WriteRawTag(232, 7);
				output.WriteInt64(this.OwnerEntityId);
			}
			if (this.DtType != 0)
			{
				output.WriteRawTag(216, 9);
				output.WriteInt32(this.DtType);
			}
			if (this.BulletId != 0L)
			{
				output.WriteRawTag(168, 10);
				output.WriteInt64(this.BulletId);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(210, 10);
				output.WriteMessage(this.Location);
			}
			if (this.TargetId != 0L)
			{
				output.WriteRawTag(192, 11);
				output.WriteInt64(this.TargetId);
			}
			if (this.SpawnEntityId != 0L)
			{
				output.WriteRawTag(208, 11);
				output.WriteInt64(this.SpawnEntityId);
			}
			if (this.size_ != null)
			{
				output.WriteRawTag(154, 12);
				output.WriteMessage(this.Size);
			}
			if (this.HasLocationEntityId)
			{
				output.WriteRawTag(248, 12);
				output.WriteInt64(this.LocationEntityId);
			}
			if (this.tarLocation_ != null)
			{
				output.WriteRawTag(178, 13);
				output.WriteMessage(this.TarLocation);
			}
			if (this.randomInitPosOffset_ != null)
			{
				output.WriteRawTag(146, 14);
				output.WriteMessage(this.RandomInitPosOffset);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(130, 15);
				output.WriteMessage(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004FF0 RID: 20464 RVA: 0x000C2240 File Offset: 0x000C0440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.handle_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.Handle);
			}
			if (this.OwnerEntityId != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.OwnerEntityId);
			}
			if (this.BulletId != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.BulletId);
			}
			if (this.SkillId != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this.location_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this.rotation_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.Rotation);
			}
			if (this.parentHandle_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ParentHandle);
			}
			if (this.TargetId != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.TargetId);
			}
			if (this.SpawnEntityId != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.SpawnEntityId);
			}
			if (this.SpawnVelocityEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SpawnVelocityEntityId);
			}
			if (this.tarLocation_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TarLocation);
			}
			if (this.DtType != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.DtType);
			}
			if (this.HasLocationEntityId)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.LocationEntityId);
			}
			if (this.size_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.Size);
			}
			if (this.randomInitPosOffset_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RandomInitPosOffset);
			}
			if (this.randomInitSpeed_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RandomInitSpeed);
			}
			if (this.HitCase.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HitCase);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004FF1 RID: 20465 RVA: 0x000C241C File Offset: 0x000C061C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CreateBulletNotify other)
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
			if (other.tarLocation_ != null)
			{
				if (this.tarLocation_ == null)
				{
					this.TarLocation = new Vector();
				}
				this.TarLocation.MergeFrom(other.TarLocation);
			}
			if (other.DtType != 0)
			{
				this.DtType = other.DtType;
			}
			if (other.HasLocationEntityId)
			{
				this.LocationEntityId = other.LocationEntityId;
			}
			if (other.size_ != null)
			{
				if (this.size_ == null)
				{
					this.Size = new Vector();
				}
				this.Size.MergeFrom(other.Size);
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
			if (other.HitCase.Length != 0)
			{
				this.HitCase = other.HitCase;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004FF2 RID: 20466 RVA: 0x000C2689 File Offset: 0x000C0889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004FF3 RID: 20467 RVA: 0x000C2694 File Offset: 0x000C0894
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
				if (num <= 1240U)
				{
					if (num <= 314U)
					{
						if (num <= 50U)
						{
							if (num == 24U)
							{
								this.SpawnVelocityEntityId = input.ReadInt64();
								continue;
							}
							if (num == 50U)
							{
								this.HitCase = input.ReadString();
								continue;
							}
						}
						else
						{
							if (num == 248U)
							{
								this.SkillId = input.ReadInt64();
								continue;
							}
							if (num == 314U)
							{
								if (this.parentHandle_ == null)
								{
									this.ParentHandle = new ActiveBulletHandle();
								}
								input.ReadMessage(this.ParentHandle);
								continue;
							}
						}
					}
					else if (num <= 810U)
					{
						if (num == 474U)
						{
							if (this.handle_ == null)
							{
								this.Handle = new ActiveBulletHandle();
							}
							input.ReadMessage(this.Handle);
							continue;
						}
						if (num == 810U)
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
						if (num == 826U)
						{
							if (this.randomInitSpeed_ == null)
							{
								this.RandomInitSpeed = new Vector();
							}
							input.ReadMessage(this.RandomInitSpeed);
							continue;
						}
						if (num == 1000U)
						{
							this.OwnerEntityId = input.ReadInt64();
							continue;
						}
						if (num == 1240U)
						{
							this.DtType = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 1488U)
				{
					if (num <= 1362U)
					{
						if (num == 1320U)
						{
							this.BulletId = input.ReadInt64();
							continue;
						}
						if (num == 1362U)
						{
							if (this.location_ == null)
							{
								this.Location = new Vector();
							}
							input.ReadMessage(this.Location);
							continue;
						}
					}
					else
					{
						if (num == 1472U)
						{
							this.TargetId = input.ReadInt64();
							continue;
						}
						if (num == 1488U)
						{
							this.SpawnEntityId = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 1656U)
				{
					if (num == 1562U)
					{
						if (this.size_ == null)
						{
							this.Size = new Vector();
						}
						input.ReadMessage(this.Size);
						continue;
					}
					if (num == 1656U)
					{
						this.LocationEntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 1714U)
					{
						if (this.tarLocation_ == null)
						{
							this.TarLocation = new Vector();
						}
						input.ReadMessage(this.TarLocation);
						continue;
					}
					if (num == 1810U)
					{
						if (this.randomInitPosOffset_ == null)
						{
							this.RandomInitPosOffset = new Vector();
						}
						input.ReadMessage(this.RandomInitPosOffset);
						continue;
					}
					if (num == 1922U)
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400324C RID: 12876
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400324D RID: 12877
		private int _hasBits0;

		// Token: 0x0400324E RID: 12878
		public const int CombatCommonFieldNumber = 240;

		// Token: 0x0400324F RID: 12879
		private CombatCommon combatCommon_;

		// Token: 0x04003250 RID: 12880
		public const int HandleFieldNumber = 59;

		// Token: 0x04003251 RID: 12881
		private ActiveBulletHandle handle_;

		// Token: 0x04003252 RID: 12882
		public const int OwnerEntityIdFieldNumber = 125;

		// Token: 0x04003253 RID: 12883
		private long ownerEntityId_;

		// Token: 0x04003254 RID: 12884
		public const int BulletIdFieldNumber = 165;

		// Token: 0x04003255 RID: 12885
		private long bulletId_;

		// Token: 0x04003256 RID: 12886
		public const int SkillIdFieldNumber = 31;

		// Token: 0x04003257 RID: 12887
		private long skillId_;

		// Token: 0x04003258 RID: 12888
		public const int LocationFieldNumber = 170;

		// Token: 0x04003259 RID: 12889
		private Vector location_;

		// Token: 0x0400325A RID: 12890
		public const int RotationFieldNumber = 101;

		// Token: 0x0400325B RID: 12891
		private Rotator rotation_;

		// Token: 0x0400325C RID: 12892
		public const int ParentHandleFieldNumber = 39;

		// Token: 0x0400325D RID: 12893
		private ActiveBulletHandle parentHandle_;

		// Token: 0x0400325E RID: 12894
		public const int TargetIdFieldNumber = 184;

		// Token: 0x0400325F RID: 12895
		private long targetId_;

		// Token: 0x04003260 RID: 12896
		public const int SpawnEntityIdFieldNumber = 186;

		// Token: 0x04003261 RID: 12897
		private long spawnEntityId_;

		// Token: 0x04003262 RID: 12898
		public const int SpawnVelocityEntityIdFieldNumber = 3;

		// Token: 0x04003263 RID: 12899
		private long spawnVelocityEntityId_;

		// Token: 0x04003264 RID: 12900
		public const int TarLocationFieldNumber = 214;

		// Token: 0x04003265 RID: 12901
		private Vector tarLocation_;

		// Token: 0x04003266 RID: 12902
		public const int DtTypeFieldNumber = 155;

		// Token: 0x04003267 RID: 12903
		private int dtType_;

		// Token: 0x04003268 RID: 12904
		public const int LocationEntityIdFieldNumber = 207;

		// Token: 0x04003269 RID: 12905
		private static readonly long LocationEntityIdDefaultValue;

		// Token: 0x0400326A RID: 12906
		private long locationEntityId_;

		// Token: 0x0400326B RID: 12907
		public const int SizeFieldNumber = 195;

		// Token: 0x0400326C RID: 12908
		private Vector size_;

		// Token: 0x0400326D RID: 12909
		public const int RandomInitPosOffsetFieldNumber = 226;

		// Token: 0x0400326E RID: 12910
		private Vector randomInitPosOffset_;

		// Token: 0x0400326F RID: 12911
		public const int RandomInitSpeedFieldNumber = 103;

		// Token: 0x04003270 RID: 12912
		private Vector randomInitSpeed_;

		// Token: 0x04003271 RID: 12913
		public const int HitCaseFieldNumber = 6;

		// Token: 0x04003272 RID: 12914
		private string hitCase_ = "";
	}
}
