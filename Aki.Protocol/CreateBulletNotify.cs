using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000310 RID: 784
	[NetMessage(EMessageId.CreateBulletNotify)]
	public sealed class CreateBulletNotify : IMessage<CreateBulletNotify>, IMessage, IEquatable<CreateBulletNotify>, IDeepCloneable<CreateBulletNotify>, IBufferMessage
	{
		// Token: 0x06004EE5 RID: 20197 RVA: 0x000BF53C File Offset: 0x000BD73C
		[NullableContext(1)]
		public static CreateBulletNotify Create()
		{
			return new CreateBulletNotify();
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06004EE6 RID: 20198 RVA: 0x000BF543 File Offset: 0x000BD743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06004EE7 RID: 20199 RVA: 0x000BF546 File Offset: 0x000BD746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateBulletNotify.Descriptor;
			}
		}

		// Token: 0x06004EE8 RID: 20200 RVA: 0x000BF54D File Offset: 0x000BD74D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletNotify()
		{
		}

		// Token: 0x06004EE9 RID: 20201 RVA: 0x000BF560 File Offset: 0x000BD760
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

		// Token: 0x06004EEA RID: 20202 RVA: 0x000BF6F8 File Offset: 0x000BD8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletNotify Clone()
		{
			return new CreateBulletNotify(this);
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06004EEB RID: 20203 RVA: 0x000BF700 File Offset: 0x000BD900
		// (set) Token: 0x06004EEC RID: 20204 RVA: 0x000BF708 File Offset: 0x000BD908
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

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06004EED RID: 20205 RVA: 0x000BF711 File Offset: 0x000BD911
		// (set) Token: 0x06004EEE RID: 20206 RVA: 0x000BF719 File Offset: 0x000BD919
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

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06004EEF RID: 20207 RVA: 0x000BF722 File Offset: 0x000BD922
		// (set) Token: 0x06004EF0 RID: 20208 RVA: 0x000BF72A File Offset: 0x000BD92A
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

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06004EF1 RID: 20209 RVA: 0x000BF733 File Offset: 0x000BD933
		// (set) Token: 0x06004EF2 RID: 20210 RVA: 0x000BF73B File Offset: 0x000BD93B
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

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06004EF3 RID: 20211 RVA: 0x000BF744 File Offset: 0x000BD944
		// (set) Token: 0x06004EF4 RID: 20212 RVA: 0x000BF74C File Offset: 0x000BD94C
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

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06004EF5 RID: 20213 RVA: 0x000BF755 File Offset: 0x000BD955
		// (set) Token: 0x06004EF6 RID: 20214 RVA: 0x000BF75D File Offset: 0x000BD95D
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

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06004EF7 RID: 20215 RVA: 0x000BF766 File Offset: 0x000BD966
		// (set) Token: 0x06004EF8 RID: 20216 RVA: 0x000BF76E File Offset: 0x000BD96E
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

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06004EF9 RID: 20217 RVA: 0x000BF777 File Offset: 0x000BD977
		// (set) Token: 0x06004EFA RID: 20218 RVA: 0x000BF77F File Offset: 0x000BD97F
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

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06004EFB RID: 20219 RVA: 0x000BF788 File Offset: 0x000BD988
		// (set) Token: 0x06004EFC RID: 20220 RVA: 0x000BF790 File Offset: 0x000BD990
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

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06004EFD RID: 20221 RVA: 0x000BF799 File Offset: 0x000BD999
		// (set) Token: 0x06004EFE RID: 20222 RVA: 0x000BF7A1 File Offset: 0x000BD9A1
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

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06004EFF RID: 20223 RVA: 0x000BF7AA File Offset: 0x000BD9AA
		// (set) Token: 0x06004F00 RID: 20224 RVA: 0x000BF7B2 File Offset: 0x000BD9B2
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

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06004F01 RID: 20225 RVA: 0x000BF7BB File Offset: 0x000BD9BB
		// (set) Token: 0x06004F02 RID: 20226 RVA: 0x000BF7C3 File Offset: 0x000BD9C3
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

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06004F03 RID: 20227 RVA: 0x000BF7CC File Offset: 0x000BD9CC
		// (set) Token: 0x06004F04 RID: 20228 RVA: 0x000BF7D4 File Offset: 0x000BD9D4
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

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06004F05 RID: 20229 RVA: 0x000BF7DD File Offset: 0x000BD9DD
		// (set) Token: 0x06004F06 RID: 20230 RVA: 0x000BF7F5 File Offset: 0x000BD9F5
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

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06004F07 RID: 20231 RVA: 0x000BF80C File Offset: 0x000BDA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasLocationEntityId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004F08 RID: 20232 RVA: 0x000BF819 File Offset: 0x000BDA19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLocationEntityId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06004F09 RID: 20233 RVA: 0x000BF82A File Offset: 0x000BDA2A
		// (set) Token: 0x06004F0A RID: 20234 RVA: 0x000BF832 File Offset: 0x000BDA32
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

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06004F0B RID: 20235 RVA: 0x000BF83B File Offset: 0x000BDA3B
		// (set) Token: 0x06004F0C RID: 20236 RVA: 0x000BF843 File Offset: 0x000BDA43
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

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06004F0D RID: 20237 RVA: 0x000BF84C File Offset: 0x000BDA4C
		// (set) Token: 0x06004F0E RID: 20238 RVA: 0x000BF854 File Offset: 0x000BDA54
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

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06004F0F RID: 20239 RVA: 0x000BF85D File Offset: 0x000BDA5D
		// (set) Token: 0x06004F10 RID: 20240 RVA: 0x000BF865 File Offset: 0x000BDA65
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

		// Token: 0x06004F11 RID: 20241 RVA: 0x000BF878 File Offset: 0x000BDA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateBulletNotify);
		}

		// Token: 0x06004F12 RID: 20242 RVA: 0x000BF888 File Offset: 0x000BDA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CreateBulletNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.Handle, other.Handle) && this.OwnerEntityId == other.OwnerEntityId && this.BulletId == other.BulletId && this.SkillId == other.SkillId && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && object.Equals(this.ParentHandle, other.ParentHandle) && this.TargetId == other.TargetId && this.SpawnEntityId == other.SpawnEntityId && this.SpawnVelocityEntityId == other.SpawnVelocityEntityId && object.Equals(this.TarLocation, other.TarLocation) && this.DtType == other.DtType && this.LocationEntityId == other.LocationEntityId && object.Equals(this.Size, other.Size) && object.Equals(this.RandomInitPosOffset, other.RandomInitPosOffset) && object.Equals(this.RandomInitSpeed, other.RandomInitSpeed) && !(this.HitCase != other.HitCase) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004F13 RID: 20243 RVA: 0x000BFA04 File Offset: 0x000BDC04
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

		// Token: 0x06004F14 RID: 20244 RVA: 0x000BFBD3 File Offset: 0x000BDDD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004F15 RID: 20245 RVA: 0x000BFBE0 File Offset: 0x000BDDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F16 RID: 20246 RVA: 0x000BFBEC File Offset: 0x000BDDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.randomInitSpeed_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RandomInitSpeed);
			}
			if (this.SpawnEntityId != 0L)
			{
				output.WriteRawTag(144, 3);
				output.WriteInt64(this.SpawnEntityId);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(154, 3);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.SpawnVelocityEntityId != 0L)
			{
				output.WriteRawTag(200, 3);
				output.WriteInt64(this.SpawnVelocityEntityId);
			}
			if (this.TargetId != 0L)
			{
				output.WriteRawTag(144, 4);
				output.WriteInt64(this.TargetId);
			}
			if (this.randomInitPosOffset_ != null)
			{
				output.WriteRawTag(170, 4);
				output.WriteMessage(this.RandomInitPosOffset);
			}
			if (this.handle_ != null)
			{
				output.WriteRawTag(210, 4);
				output.WriteMessage(this.Handle);
			}
			if (this.parentHandle_ != null)
			{
				output.WriteRawTag(202, 5);
				output.WriteMessage(this.ParentHandle);
			}
			if (this.size_ != null)
			{
				output.WriteRawTag(138, 6);
				output.WriteMessage(this.Size);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(248, 6);
				output.WriteInt64(this.SkillId);
			}
			if (this.BulletId != 0L)
			{
				output.WriteRawTag(192, 7);
				output.WriteInt64(this.BulletId);
			}
			if (this.tarLocation_ != null)
			{
				output.WriteRawTag(130, 8);
				output.WriteMessage(this.TarLocation);
			}
			if (this.OwnerEntityId != 0L)
			{
				output.WriteRawTag(208, 8);
				output.WriteInt64(this.OwnerEntityId);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(242, 8);
				output.WriteMessage(this.Rotation);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(210, 10);
				output.WriteMessage(this.Location);
			}
			if (this.HasLocationEntityId)
			{
				output.WriteRawTag(168, 14);
				output.WriteInt64(this.LocationEntityId);
			}
			if (this.DtType != 0)
			{
				output.WriteRawTag(168, 15);
				output.WriteInt32(this.DtType);
			}
			if (this.HitCase.Length != 0)
			{
				output.WriteRawTag(242, 15);
				output.WriteString(this.HitCase);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004F17 RID: 20247 RVA: 0x000BFE54 File Offset: 0x000BE054
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
				num += 2 + CodedOutputStream.ComputeInt64Size(this.SpawnVelocityEntityId);
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
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RandomInitSpeed);
			}
			if (this.HitCase.Length != 0)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.HitCase);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004F18 RID: 20248 RVA: 0x000C0030 File Offset: 0x000BE230
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

		// Token: 0x06004F19 RID: 20249 RVA: 0x000C029D File Offset: 0x000BE49D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F1A RID: 20250 RVA: 0x000C02A8 File Offset: 0x000BE4A8
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
				if (num <= 778U)
				{
					if (num <= 456U)
					{
						if (num <= 400U)
						{
							if (num == 10U)
							{
								if (this.randomInitSpeed_ == null)
								{
									this.RandomInitSpeed = new Vector();
								}
								input.ReadMessage(this.RandomInitSpeed);
								continue;
							}
							if (num == 400U)
							{
								this.SpawnEntityId = input.ReadInt64();
								continue;
							}
						}
						else
						{
							if (num == 410U)
							{
								if (this.combatCommon_ == null)
								{
									this.CombatCommon = new CombatCommon();
								}
								input.ReadMessage(this.CombatCommon);
								continue;
							}
							if (num == 456U)
							{
								this.SpawnVelocityEntityId = input.ReadInt64();
								continue;
							}
						}
					}
					else if (num <= 554U)
					{
						if (num == 528U)
						{
							this.TargetId = input.ReadInt64();
							continue;
						}
						if (num == 554U)
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
						if (num == 594U)
						{
							if (this.handle_ == null)
							{
								this.Handle = new ActiveBulletHandle();
							}
							input.ReadMessage(this.Handle);
							continue;
						}
						if (num == 714U)
						{
							if (this.parentHandle_ == null)
							{
								this.ParentHandle = new ActiveBulletHandle();
							}
							input.ReadMessage(this.ParentHandle);
							continue;
						}
						if (num == 778U)
						{
							if (this.size_ == null)
							{
								this.Size = new Vector();
							}
							input.ReadMessage(this.Size);
							continue;
						}
					}
				}
				else if (num <= 1104U)
				{
					if (num <= 960U)
					{
						if (num == 888U)
						{
							this.SkillId = input.ReadInt64();
							continue;
						}
						if (num == 960U)
						{
							this.BulletId = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 1026U)
						{
							if (this.tarLocation_ == null)
							{
								this.TarLocation = new Vector();
							}
							input.ReadMessage(this.TarLocation);
							continue;
						}
						if (num == 1104U)
						{
							this.OwnerEntityId = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 1362U)
				{
					if (num == 1138U)
					{
						if (this.rotation_ == null)
						{
							this.Rotation = new Rotator();
						}
						input.ReadMessage(this.Rotation);
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
					if (num == 1832U)
					{
						this.LocationEntityId = input.ReadInt64();
						continue;
					}
					if (num == 1960U)
					{
						this.DtType = input.ReadInt32();
						continue;
					}
					if (num == 2034U)
					{
						this.HitCase = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040031B5 RID: 12725
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031B6 RID: 12726
		private int _hasBits0;

		// Token: 0x040031B7 RID: 12727
		public const int CombatCommonFieldNumber = 51;

		// Token: 0x040031B8 RID: 12728
		private CombatCommon combatCommon_;

		// Token: 0x040031B9 RID: 12729
		public const int HandleFieldNumber = 74;

		// Token: 0x040031BA RID: 12730
		private ActiveBulletHandle handle_;

		// Token: 0x040031BB RID: 12731
		public const int OwnerEntityIdFieldNumber = 138;

		// Token: 0x040031BC RID: 12732
		private long ownerEntityId_;

		// Token: 0x040031BD RID: 12733
		public const int BulletIdFieldNumber = 120;

		// Token: 0x040031BE RID: 12734
		private long bulletId_;

		// Token: 0x040031BF RID: 12735
		public const int SkillIdFieldNumber = 111;

		// Token: 0x040031C0 RID: 12736
		private long skillId_;

		// Token: 0x040031C1 RID: 12737
		public const int LocationFieldNumber = 170;

		// Token: 0x040031C2 RID: 12738
		private Vector location_;

		// Token: 0x040031C3 RID: 12739
		public const int RotationFieldNumber = 142;

		// Token: 0x040031C4 RID: 12740
		private Rotator rotation_;

		// Token: 0x040031C5 RID: 12741
		public const int ParentHandleFieldNumber = 89;

		// Token: 0x040031C6 RID: 12742
		private ActiveBulletHandle parentHandle_;

		// Token: 0x040031C7 RID: 12743
		public const int TargetIdFieldNumber = 66;

		// Token: 0x040031C8 RID: 12744
		private long targetId_;

		// Token: 0x040031C9 RID: 12745
		public const int SpawnEntityIdFieldNumber = 50;

		// Token: 0x040031CA RID: 12746
		private long spawnEntityId_;

		// Token: 0x040031CB RID: 12747
		public const int SpawnVelocityEntityIdFieldNumber = 57;

		// Token: 0x040031CC RID: 12748
		private long spawnVelocityEntityId_;

		// Token: 0x040031CD RID: 12749
		public const int TarLocationFieldNumber = 128;

		// Token: 0x040031CE RID: 12750
		private Vector tarLocation_;

		// Token: 0x040031CF RID: 12751
		public const int DtTypeFieldNumber = 245;

		// Token: 0x040031D0 RID: 12752
		private int dtType_;

		// Token: 0x040031D1 RID: 12753
		public const int LocationEntityIdFieldNumber = 229;

		// Token: 0x040031D2 RID: 12754
		private static readonly long LocationEntityIdDefaultValue;

		// Token: 0x040031D3 RID: 12755
		private long locationEntityId_;

		// Token: 0x040031D4 RID: 12756
		public const int SizeFieldNumber = 97;

		// Token: 0x040031D5 RID: 12757
		private Vector size_;

		// Token: 0x040031D6 RID: 12758
		public const int RandomInitPosOffsetFieldNumber = 69;

		// Token: 0x040031D7 RID: 12759
		private Vector randomInitPosOffset_;

		// Token: 0x040031D8 RID: 12760
		public const int RandomInitSpeedFieldNumber = 1;

		// Token: 0x040031D9 RID: 12761
		private Vector randomInitSpeed_;

		// Token: 0x040031DA RID: 12762
		public const int HitCaseFieldNumber = 254;

		// Token: 0x040031DB RID: 12763
		private string hitCase_ = "";
	}
}
