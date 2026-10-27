using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000311 RID: 785
	[NetMessage(EMessageId.CreateBulletPush)]
	public sealed class CreateBulletPush : IMessage<CreateBulletPush>, IMessage, IEquatable<CreateBulletPush>, IDeepCloneable<CreateBulletPush>, IBufferMessage
	{
		// Token: 0x06004F1B RID: 20251 RVA: 0x000C05C3 File Offset: 0x000BE7C3
		[NullableContext(1)]
		public static CreateBulletPush Create()
		{
			return new CreateBulletPush();
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06004F1C RID: 20252 RVA: 0x000C05CA File Offset: 0x000BE7CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06004F1D RID: 20253 RVA: 0x000C05CD File Offset: 0x000BE7CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreateBulletPush.Descriptor;
			}
		}

		// Token: 0x06004F1E RID: 20254 RVA: 0x000C05D4 File Offset: 0x000BE7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletPush()
		{
		}

		// Token: 0x06004F1F RID: 20255 RVA: 0x000C05DC File Offset: 0x000BE7DC
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

		// Token: 0x06004F20 RID: 20256 RVA: 0x000C0724 File Offset: 0x000BE924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreateBulletPush Clone()
		{
			return new CreateBulletPush(this);
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06004F21 RID: 20257 RVA: 0x000C072C File Offset: 0x000BE92C
		// (set) Token: 0x06004F22 RID: 20258 RVA: 0x000C0734 File Offset: 0x000BE934
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

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06004F23 RID: 20259 RVA: 0x000C073D File Offset: 0x000BE93D
		// (set) Token: 0x06004F24 RID: 20260 RVA: 0x000C0745 File Offset: 0x000BE945
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

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06004F25 RID: 20261 RVA: 0x000C074E File Offset: 0x000BE94E
		// (set) Token: 0x06004F26 RID: 20262 RVA: 0x000C0756 File Offset: 0x000BE956
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

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06004F27 RID: 20263 RVA: 0x000C075F File Offset: 0x000BE95F
		// (set) Token: 0x06004F28 RID: 20264 RVA: 0x000C0767 File Offset: 0x000BE967
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

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06004F29 RID: 20265 RVA: 0x000C0770 File Offset: 0x000BE970
		// (set) Token: 0x06004F2A RID: 20266 RVA: 0x000C0778 File Offset: 0x000BE978
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

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06004F2B RID: 20267 RVA: 0x000C0781 File Offset: 0x000BE981
		// (set) Token: 0x06004F2C RID: 20268 RVA: 0x000C0789 File Offset: 0x000BE989
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

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06004F2D RID: 20269 RVA: 0x000C0792 File Offset: 0x000BE992
		// (set) Token: 0x06004F2E RID: 20270 RVA: 0x000C079A File Offset: 0x000BE99A
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

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06004F2F RID: 20271 RVA: 0x000C07A3 File Offset: 0x000BE9A3
		// (set) Token: 0x06004F30 RID: 20272 RVA: 0x000C07AB File Offset: 0x000BE9AB
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

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06004F31 RID: 20273 RVA: 0x000C07B4 File Offset: 0x000BE9B4
		// (set) Token: 0x06004F32 RID: 20274 RVA: 0x000C07BC File Offset: 0x000BE9BC
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

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06004F33 RID: 20275 RVA: 0x000C07C5 File Offset: 0x000BE9C5
		// (set) Token: 0x06004F34 RID: 20276 RVA: 0x000C07CD File Offset: 0x000BE9CD
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

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06004F35 RID: 20277 RVA: 0x000C07D6 File Offset: 0x000BE9D6
		// (set) Token: 0x06004F36 RID: 20278 RVA: 0x000C07DE File Offset: 0x000BE9DE
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

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06004F37 RID: 20279 RVA: 0x000C07E7 File Offset: 0x000BE9E7
		// (set) Token: 0x06004F38 RID: 20280 RVA: 0x000C07EF File Offset: 0x000BE9EF
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

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06004F39 RID: 20281 RVA: 0x000C07F8 File Offset: 0x000BE9F8
		// (set) Token: 0x06004F3A RID: 20282 RVA: 0x000C0800 File Offset: 0x000BEA00
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

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06004F3B RID: 20283 RVA: 0x000C0809 File Offset: 0x000BEA09
		// (set) Token: 0x06004F3C RID: 20284 RVA: 0x000C0811 File Offset: 0x000BEA11
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

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06004F3D RID: 20285 RVA: 0x000C081A File Offset: 0x000BEA1A
		// (set) Token: 0x06004F3E RID: 20286 RVA: 0x000C0822 File Offset: 0x000BEA22
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

		// Token: 0x06004F3F RID: 20287 RVA: 0x000C082B File Offset: 0x000BEA2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreateBulletPush);
		}

		// Token: 0x06004F40 RID: 20288 RVA: 0x000C083C File Offset: 0x000BEA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CreateBulletPush other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this.Handle, other.Handle) && this.OwnerEntityId == other.OwnerEntityId && this.BulletId == other.BulletId && this.SkillId == other.SkillId && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && object.Equals(this.ParentHandle, other.ParentHandle) && this.TargetId == other.TargetId && this.SpawnEntityId == other.SpawnEntityId && this.SpawnVelocityEntityId == other.SpawnVelocityEntityId && this.IsLocal == other.IsLocal && this.DtType == other.DtType && object.Equals(this.RandomInitPosOffset, other.RandomInitPosOffset) && object.Equals(this.RandomInitSpeed, other.RandomInitSpeed) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004F41 RID: 20289 RVA: 0x000C0978 File Offset: 0x000BEB78
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

		// Token: 0x06004F42 RID: 20290 RVA: 0x000C0B00 File Offset: 0x000BED00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004F43 RID: 20291 RVA: 0x000C0B0D File Offset: 0x000BED0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F44 RID: 20292 RVA: 0x000C0B18 File Offset: 0x000BED18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsLocal)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsLocal);
			}
			if (this.handle_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Handle);
			}
			if (this.TargetId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.TargetId);
			}
			if (this.BulletId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.BulletId);
			}
			if (this.OwnerEntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.OwnerEntityId);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Rotation);
			}
			if (this.randomInitSpeed_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RandomInitSpeed);
			}
			if (this.DtType != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.DtType);
			}
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.SkillId);
			}
			if (this.SpawnVelocityEntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.SpawnVelocityEntityId);
			}
			if (this.SpawnEntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.SpawnEntityId);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.parentHandle_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.ParentHandle);
			}
			if (this.randomInitPosOffset_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.RandomInitPosOffset);
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

		// Token: 0x06004F45 RID: 20293 RVA: 0x000C0CDC File Offset: 0x000BEEDC
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

		// Token: 0x06004F46 RID: 20294 RVA: 0x000C0E60 File Offset: 0x000BF060
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

		// Token: 0x06004F47 RID: 20295 RVA: 0x000C105C File Offset: 0x000BF25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F48 RID: 20296 RVA: 0x000C1068 File Offset: 0x000BF268
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
				if (num <= 58U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.IsLocal = input.ReadBool();
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
						if (num == 24U)
						{
							this.TargetId = input.ReadInt64();
							continue;
						}
					}
					else if (num <= 40U)
					{
						if (num == 32U)
						{
							this.BulletId = input.ReadInt64();
							continue;
						}
						if (num == 40U)
						{
							this.OwnerEntityId = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 50U)
						{
							if (this.rotation_ == null)
							{
								this.Rotation = new Rotator();
							}
							input.ReadMessage(this.Rotation);
							continue;
						}
						if (num == 58U)
						{
							if (this.randomInitSpeed_ == null)
							{
								this.RandomInitSpeed = new Vector();
							}
							input.ReadMessage(this.RandomInitSpeed);
							continue;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num <= 72U)
					{
						if (num == 64U)
						{
							this.DtType = input.ReadInt32();
							continue;
						}
						if (num == 72U)
						{
							this.SkillId = input.ReadInt64();
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
						if (num == 88U)
						{
							this.SpawnEntityId = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 106U)
				{
					if (num == 98U)
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
						continue;
					}
					if (num == 106U)
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
					if (num == 114U)
					{
						if (this.randomInitPosOffset_ == null)
						{
							this.RandomInitPosOffset = new Vector();
						}
						input.ReadMessage(this.RandomInitPosOffset);
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

		// Token: 0x040031DC RID: 12764
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031DD RID: 12765
		public const int CombatCommonFieldNumber = 12;

		// Token: 0x040031DE RID: 12766
		private CombatCommon combatCommon_;

		// Token: 0x040031DF RID: 12767
		public const int HandleFieldNumber = 2;

		// Token: 0x040031E0 RID: 12768
		private ActiveBulletHandle handle_;

		// Token: 0x040031E1 RID: 12769
		public const int OwnerEntityIdFieldNumber = 5;

		// Token: 0x040031E2 RID: 12770
		private long ownerEntityId_;

		// Token: 0x040031E3 RID: 12771
		public const int BulletIdFieldNumber = 4;

		// Token: 0x040031E4 RID: 12772
		private long bulletId_;

		// Token: 0x040031E5 RID: 12773
		public const int SkillIdFieldNumber = 9;

		// Token: 0x040031E6 RID: 12774
		private long skillId_;

		// Token: 0x040031E7 RID: 12775
		public const int LocationFieldNumber = 15;

		// Token: 0x040031E8 RID: 12776
		private Vector location_;

		// Token: 0x040031E9 RID: 12777
		public const int RotationFieldNumber = 6;

		// Token: 0x040031EA RID: 12778
		private Rotator rotation_;

		// Token: 0x040031EB RID: 12779
		public const int ParentHandleFieldNumber = 13;

		// Token: 0x040031EC RID: 12780
		private ActiveBulletHandle parentHandle_;

		// Token: 0x040031ED RID: 12781
		public const int TargetIdFieldNumber = 3;

		// Token: 0x040031EE RID: 12782
		private long targetId_;

		// Token: 0x040031EF RID: 12783
		public const int SpawnEntityIdFieldNumber = 11;

		// Token: 0x040031F0 RID: 12784
		private long spawnEntityId_;

		// Token: 0x040031F1 RID: 12785
		public const int SpawnVelocityEntityIdFieldNumber = 10;

		// Token: 0x040031F2 RID: 12786
		private long spawnVelocityEntityId_;

		// Token: 0x040031F3 RID: 12787
		public const int IsLocalFieldNumber = 1;

		// Token: 0x040031F4 RID: 12788
		private bool isLocal_;

		// Token: 0x040031F5 RID: 12789
		public const int DtTypeFieldNumber = 8;

		// Token: 0x040031F6 RID: 12790
		private int dtType_;

		// Token: 0x040031F7 RID: 12791
		public const int RandomInitPosOffsetFieldNumber = 14;

		// Token: 0x040031F8 RID: 12792
		private Vector randomInitPosOffset_;

		// Token: 0x040031F9 RID: 12793
		public const int RandomInitSpeedFieldNumber = 7;

		// Token: 0x040031FA RID: 12794
		private Vector randomInitSpeed_;
	}
}
