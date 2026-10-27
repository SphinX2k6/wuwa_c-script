using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004B0 RID: 1200
	public sealed class EntityPb : IMessage<EntityPb>, IMessage, IEquatable<EntityPb>, IDeepCloneable<EntityPb>, IBufferMessage
	{
		// Token: 0x06007237 RID: 29239 RVA: 0x00117BCD File Offset: 0x00115DCD
		[NullableContext(1)]
		public static EntityPb Create()
		{
			return new EntityPb();
		}

		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x06007238 RID: 29240 RVA: 0x00117BD4 File Offset: 0x00115DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityPb> Parser
		{
			get
			{
				return EntityPb._parser;
			}
		}

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x06007239 RID: 29241 RVA: 0x00117BDB File Offset: 0x00115DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x0600723A RID: 29242 RVA: 0x00117BDE File Offset: 0x00115DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPb.Descriptor;
			}
		}

		// Token: 0x0600723B RID: 29243 RVA: 0x00117BE5 File Offset: 0x00115DE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPb()
		{
		}

		// Token: 0x0600723C RID: 29244 RVA: 0x00117BF8 File Offset: 0x00115DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPb(EntityPb other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.configId_ = other.configId_;
			this.configType_ = other.configType_;
			this.entityType_ = other.entityType_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this.initPos_ = ((other.initPos_ != null) ? other.initPos_.Clone() : null);
			this.livingStatus_ = other.livingStatus_;
			this.isVisible_ = other.isVisible_;
			this.playerId_ = other.playerId_;
			this.componentPbs_ = other.componentPbs_.Clone();
			this.durabilityValue_ = other.durabilityValue_;
			this.entityState_ = other.entityState_;
			this.initLinearVelocity_ = ((other.initLinearVelocity_ != null) ? other.initLinearVelocity_.Clone() : null);
			this.isPosAbnormal_ = other.isPosAbnormal_;
			this.prefabId_ = other.prefabId_;
			this.prefabIncId_ = other.prefabIncId_;
			this.subEntityType_ = other.subEntityType_;
			this.camp_ = other.camp_;
			this.ownerIncId_ = other.ownerIncId_;
			this.gravityDirection_ = ((other.gravityDirection_ != null) ? other.gravityDirection_.Clone() : null);
			this.roleSkinId_ = other.roleSkinId_;
			this.isActorVisible_ = other.isActorVisible_;
			this.glideWingSkinId_ = other.glideWingSkinId_;
			this.glideBrollySkinId_ = other.glideBrollySkinId_;
			this.isSnap_ = other.isSnap_;
			this.clientHiddenFlag_ = other.clientHiddenFlag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600723D RID: 29245 RVA: 0x00117DC1 File Offset: 0x00115FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPb Clone()
		{
			return new EntityPb(this);
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x0600723E RID: 29246 RVA: 0x00117DC9 File Offset: 0x00115FC9
		// (set) Token: 0x0600723F RID: 29247 RVA: 0x00117DD1 File Offset: 0x00115FD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x06007240 RID: 29248 RVA: 0x00117DDA File Offset: 0x00115FDA
		// (set) Token: 0x06007241 RID: 29249 RVA: 0x00117DE2 File Offset: 0x00115FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x06007242 RID: 29250 RVA: 0x00117DEB File Offset: 0x00115FEB
		// (set) Token: 0x06007243 RID: 29251 RVA: 0x00117DF3 File Offset: 0x00115FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityConfigType ConfigType
		{
			get
			{
				return this.configType_;
			}
			set
			{
				this.configType_ = value;
			}
		}

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x06007244 RID: 29252 RVA: 0x00117DFC File Offset: 0x00115FFC
		// (set) Token: 0x06007245 RID: 29253 RVA: 0x00117E04 File Offset: 0x00116004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityType
		{
			get
			{
				return this.entityType_;
			}
			set
			{
				this.entityType_ = value;
			}
		}

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x06007246 RID: 29254 RVA: 0x00117E0D File Offset: 0x0011600D
		// (set) Token: 0x06007247 RID: 29255 RVA: 0x00117E15 File Offset: 0x00116015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x06007248 RID: 29256 RVA: 0x00117E1E File Offset: 0x0011601E
		// (set) Token: 0x06007249 RID: 29257 RVA: 0x00117E26 File Offset: 0x00116026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rot
		{
			get
			{
				return this.rot_;
			}
			set
			{
				this.rot_ = value;
			}
		}

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x0600724A RID: 29258 RVA: 0x00117E2F File Offset: 0x0011602F
		// (set) Token: 0x0600724B RID: 29259 RVA: 0x00117E37 File Offset: 0x00116037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector InitPos
		{
			get
			{
				return this.initPos_;
			}
			set
			{
				this.initPos_ = value;
			}
		}

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x0600724C RID: 29260 RVA: 0x00117E40 File Offset: 0x00116040
		// (set) Token: 0x0600724D RID: 29261 RVA: 0x00117E48 File Offset: 0x00116048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivingStatus LivingStatus
		{
			get
			{
				return this.livingStatus_;
			}
			set
			{
				this.livingStatus_ = value;
			}
		}

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x0600724E RID: 29262 RVA: 0x00117E51 File Offset: 0x00116051
		// (set) Token: 0x0600724F RID: 29263 RVA: 0x00117E59 File Offset: 0x00116059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsVisible
		{
			get
			{
				return this.isVisible_;
			}
			set
			{
				this.isVisible_ = value;
			}
		}

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x06007250 RID: 29264 RVA: 0x00117E62 File Offset: 0x00116062
		// (set) Token: 0x06007251 RID: 29265 RVA: 0x00117E6A File Offset: 0x0011606A
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

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x06007252 RID: 29266 RVA: 0x00117E73 File Offset: 0x00116073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityComponentPb> ComponentPbs
		{
			get
			{
				return this.componentPbs_;
			}
		}

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x06007253 RID: 29267 RVA: 0x00117E7B File Offset: 0x0011607B
		// (set) Token: 0x06007254 RID: 29268 RVA: 0x00117E83 File Offset: 0x00116083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DurabilityValue
		{
			get
			{
				return this.durabilityValue_;
			}
			set
			{
				this.durabilityValue_ = value;
			}
		}

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x06007255 RID: 29269 RVA: 0x00117E8C File Offset: 0x0011608C
		// (set) Token: 0x06007256 RID: 29270 RVA: 0x00117E94 File Offset: 0x00116094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityState EntityState
		{
			get
			{
				return this.entityState_;
			}
			set
			{
				this.entityState_ = value;
			}
		}

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x06007257 RID: 29271 RVA: 0x00117E9D File Offset: 0x0011609D
		// (set) Token: 0x06007258 RID: 29272 RVA: 0x00117EA5 File Offset: 0x001160A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector InitLinearVelocity
		{
			get
			{
				return this.initLinearVelocity_;
			}
			set
			{
				this.initLinearVelocity_ = value;
			}
		}

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x06007259 RID: 29273 RVA: 0x00117EAE File Offset: 0x001160AE
		// (set) Token: 0x0600725A RID: 29274 RVA: 0x00117EB6 File Offset: 0x001160B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPosAbnormal
		{
			get
			{
				return this.isPosAbnormal_;
			}
			set
			{
				this.isPosAbnormal_ = value;
			}
		}

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x0600725B RID: 29275 RVA: 0x00117EBF File Offset: 0x001160BF
		// (set) Token: 0x0600725C RID: 29276 RVA: 0x00117EC7 File Offset: 0x001160C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PrefabId
		{
			get
			{
				return this.prefabId_;
			}
			set
			{
				this.prefabId_ = value;
			}
		}

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x0600725D RID: 29277 RVA: 0x00117ED0 File Offset: 0x001160D0
		// (set) Token: 0x0600725E RID: 29278 RVA: 0x00117ED8 File Offset: 0x001160D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PrefabIncId
		{
			get
			{
				return this.prefabIncId_;
			}
			set
			{
				this.prefabIncId_ = value;
			}
		}

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x0600725F RID: 29279 RVA: 0x00117EE1 File Offset: 0x001160E1
		// (set) Token: 0x06007260 RID: 29280 RVA: 0x00117EE9 File Offset: 0x001160E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubEntityType
		{
			get
			{
				return this.subEntityType_;
			}
			set
			{
				this.subEntityType_ = value;
			}
		}

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x06007261 RID: 29281 RVA: 0x00117EF2 File Offset: 0x001160F2
		// (set) Token: 0x06007262 RID: 29282 RVA: 0x00117F0A File Offset: 0x0011610A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Camp
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.camp_;
				}
				return EntityPb.CampDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.camp_ = value;
			}
		}

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x06007263 RID: 29283 RVA: 0x00117F21 File Offset: 0x00116121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasCamp
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007264 RID: 29284 RVA: 0x00117F2E File Offset: 0x0011612E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearCamp()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x06007265 RID: 29285 RVA: 0x00117F3F File Offset: 0x0011613F
		// (set) Token: 0x06007266 RID: 29286 RVA: 0x00117F47 File Offset: 0x00116147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OwnerIncId
		{
			get
			{
				return this.ownerIncId_;
			}
			set
			{
				this.ownerIncId_ = value;
			}
		}

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x06007267 RID: 29287 RVA: 0x00117F50 File Offset: 0x00116150
		// (set) Token: 0x06007268 RID: 29288 RVA: 0x00117F58 File Offset: 0x00116158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector GravityDirection
		{
			get
			{
				return this.gravityDirection_;
			}
			set
			{
				this.gravityDirection_ = value;
			}
		}

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x06007269 RID: 29289 RVA: 0x00117F61 File Offset: 0x00116161
		// (set) Token: 0x0600726A RID: 29290 RVA: 0x00117F69 File Offset: 0x00116169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleSkinId
		{
			get
			{
				return this.roleSkinId_;
			}
			set
			{
				this.roleSkinId_ = value;
			}
		}

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x0600726B RID: 29291 RVA: 0x00117F72 File Offset: 0x00116172
		// (set) Token: 0x0600726C RID: 29292 RVA: 0x00117F7A File Offset: 0x0011617A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsActorVisible
		{
			get
			{
				return this.isActorVisible_;
			}
			set
			{
				this.isActorVisible_ = value;
			}
		}

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x0600726D RID: 29293 RVA: 0x00117F83 File Offset: 0x00116183
		// (set) Token: 0x0600726E RID: 29294 RVA: 0x00117F8B File Offset: 0x0011618B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GlideWingSkinId
		{
			get
			{
				return this.glideWingSkinId_;
			}
			set
			{
				this.glideWingSkinId_ = value;
			}
		}

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x0600726F RID: 29295 RVA: 0x00117F94 File Offset: 0x00116194
		// (set) Token: 0x06007270 RID: 29296 RVA: 0x00117F9C File Offset: 0x0011619C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GlideBrollySkinId
		{
			get
			{
				return this.glideBrollySkinId_;
			}
			set
			{
				this.glideBrollySkinId_ = value;
			}
		}

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x06007271 RID: 29297 RVA: 0x00117FA5 File Offset: 0x001161A5
		// (set) Token: 0x06007272 RID: 29298 RVA: 0x00117FAD File Offset: 0x001161AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSnap
		{
			get
			{
				return this.isSnap_;
			}
			set
			{
				this.isSnap_ = value;
			}
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x06007273 RID: 29299 RVA: 0x00117FB6 File Offset: 0x001161B6
		// (set) Token: 0x06007274 RID: 29300 RVA: 0x00117FBE File Offset: 0x001161BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ClientHiddenFlag
		{
			get
			{
				return this.clientHiddenFlag_;
			}
			set
			{
				this.clientHiddenFlag_ = value;
			}
		}

		// Token: 0x06007275 RID: 29301 RVA: 0x00117FC7 File Offset: 0x001161C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPb);
		}

		// Token: 0x06007276 RID: 29302 RVA: 0x00117FD8 File Offset: 0x001161D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.ConfigId == other.ConfigId && this.ConfigType == other.ConfigType && this.EntityType == other.EntityType && object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && object.Equals(this.InitPos, other.InitPos) && this.LivingStatus == other.LivingStatus && this.IsVisible == other.IsVisible && this.PlayerId == other.PlayerId && this.componentPbs_.Equals(other.componentPbs_) && this.DurabilityValue == other.DurabilityValue && this.EntityState == other.EntityState && object.Equals(this.InitLinearVelocity, other.InitLinearVelocity) && this.IsPosAbnormal == other.IsPosAbnormal && this.PrefabId == other.PrefabId && this.PrefabIncId == other.PrefabIncId && this.SubEntityType == other.SubEntityType && this.Camp == other.Camp && this.OwnerIncId == other.OwnerIncId && object.Equals(this.GravityDirection, other.GravityDirection) && this.RoleSkinId == other.RoleSkinId && this.IsActorVisible == other.IsActorVisible && this.GlideWingSkinId == other.GlideWingSkinId && this.GlideBrollySkinId == other.GlideBrollySkinId && this.IsSnap == other.IsSnap && this.ClientHiddenFlag == other.ClientHiddenFlag && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007277 RID: 29303 RVA: 0x001181D0 File Offset: 0x001163D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.ConfigType != EntityConfigType.OldEntity)
			{
				num ^= this.ConfigType.GetHashCode();
			}
			if (this.EntityType != 0)
			{
				num ^= this.EntityType.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.rot_ != null)
			{
				num ^= this.Rot.GetHashCode();
			}
			if (this.initPos_ != null)
			{
				num ^= this.InitPos.GetHashCode();
			}
			if (this.LivingStatus != LivingStatus.Alive)
			{
				num ^= this.LivingStatus.GetHashCode();
			}
			if (this.IsVisible)
			{
				num ^= this.IsVisible.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			num ^= this.componentPbs_.GetHashCode();
			if (this.DurabilityValue != 0)
			{
				num ^= this.DurabilityValue.GetHashCode();
			}
			if (this.EntityState != EntityState.Default)
			{
				num ^= this.EntityState.GetHashCode();
			}
			if (this.initLinearVelocity_ != null)
			{
				num ^= this.InitLinearVelocity.GetHashCode();
			}
			if (this.IsPosAbnormal)
			{
				num ^= this.IsPosAbnormal.GetHashCode();
			}
			if (this.PrefabId != 0)
			{
				num ^= this.PrefabId.GetHashCode();
			}
			if (this.PrefabIncId != 0L)
			{
				num ^= this.PrefabIncId.GetHashCode();
			}
			if (this.SubEntityType != 0)
			{
				num ^= this.SubEntityType.GetHashCode();
			}
			if (this.HasCamp)
			{
				num ^= this.Camp.GetHashCode();
			}
			if (this.OwnerIncId != 0L)
			{
				num ^= this.OwnerIncId.GetHashCode();
			}
			if (this.gravityDirection_ != null)
			{
				num ^= this.GravityDirection.GetHashCode();
			}
			if (this.RoleSkinId != 0)
			{
				num ^= this.RoleSkinId.GetHashCode();
			}
			if (this.IsActorVisible)
			{
				num ^= this.IsActorVisible.GetHashCode();
			}
			if (this.GlideWingSkinId != 0)
			{
				num ^= this.GlideWingSkinId.GetHashCode();
			}
			if (this.GlideBrollySkinId != 0)
			{
				num ^= this.GlideBrollySkinId.GetHashCode();
			}
			if (this.IsSnap)
			{
				num ^= this.IsSnap.GetHashCode();
			}
			if (this.ClientHiddenFlag)
			{
				num ^= this.ClientHiddenFlag.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007278 RID: 29304 RVA: 0x00118498 File Offset: 0x00116698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007279 RID: 29305 RVA: 0x001184A5 File Offset: 0x001166A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600727A RID: 29306 RVA: 0x001184B0 File Offset: 0x001166B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.Id);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ConfigId);
			}
			if (this.ConfigType != EntityConfigType.OldEntity)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ConfigType);
			}
			if (this.EntityType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.EntityType);
			}
			if (this.pos_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Pos);
			}
			if (this.rot_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Rot);
			}
			if (this.initPos_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.InitPos);
			}
			if (this.LivingStatus != LivingStatus.Alive)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.LivingStatus);
			}
			if (this.IsVisible)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsVisible);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.PlayerId);
			}
			this.componentPbs_.WriteTo(ref output, EntityPb._repeated_componentPbs_codec);
			if (this.DurabilityValue != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.DurabilityValue);
			}
			if (this.EntityState != EntityState.Default)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.EntityState);
			}
			if (this.initLinearVelocity_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.InitLinearVelocity);
			}
			if (this.IsPosAbnormal)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsPosAbnormal);
			}
			if (this.PrefabId != 0)
			{
				output.WriteRawTag(136, 1);
				output.WriteInt32(this.PrefabId);
			}
			if (this.PrefabIncId != 0L)
			{
				output.WriteRawTag(144, 1);
				output.WriteInt64(this.PrefabIncId);
			}
			if (this.SubEntityType != 0)
			{
				output.WriteRawTag(152, 1);
				output.WriteInt32(this.SubEntityType);
			}
			if (this.HasCamp)
			{
				output.WriteRawTag(160, 1);
				output.WriteInt32(this.Camp);
			}
			if (this.OwnerIncId != 0L)
			{
				output.WriteRawTag(168, 1);
				output.WriteInt64(this.OwnerIncId);
			}
			if (this.gravityDirection_ != null)
			{
				output.WriteRawTag(178, 1);
				output.WriteMessage(this.GravityDirection);
			}
			if (this.RoleSkinId != 0)
			{
				output.WriteRawTag(184, 1);
				output.WriteInt32(this.RoleSkinId);
			}
			if (this.IsActorVisible)
			{
				output.WriteRawTag(192, 1);
				output.WriteBool(this.IsActorVisible);
			}
			if (this.GlideWingSkinId != 0)
			{
				output.WriteRawTag(200, 1);
				output.WriteInt32(this.GlideWingSkinId);
			}
			if (this.GlideBrollySkinId != 0)
			{
				output.WriteRawTag(208, 1);
				output.WriteInt32(this.GlideBrollySkinId);
			}
			if (this.IsSnap)
			{
				output.WriteRawTag(216, 1);
				output.WriteBool(this.IsSnap);
			}
			if (this.ClientHiddenFlag)
			{
				output.WriteRawTag(224, 1);
				output.WriteBool(this.ClientHiddenFlag);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600727B RID: 29307 RVA: 0x001187EC File Offset: 0x001169EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.ConfigType != EntityConfigType.OldEntity)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ConfigType);
			}
			if (this.EntityType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityType);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this.rot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rot);
			}
			if (this.initPos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InitPos);
			}
			if (this.LivingStatus != LivingStatus.Alive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.LivingStatus);
			}
			if (this.IsVisible)
			{
				num += 2;
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.componentPbs_.CalculateSize(EntityPb._repeated_componentPbs_codec);
			if (this.DurabilityValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DurabilityValue);
			}
			if (this.EntityState != EntityState.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.EntityState);
			}
			if (this.initLinearVelocity_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InitLinearVelocity);
			}
			if (this.IsPosAbnormal)
			{
				num += 2;
			}
			if (this.PrefabId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.PrefabId);
			}
			if (this.PrefabIncId != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.PrefabIncId);
			}
			if (this.SubEntityType != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.SubEntityType);
			}
			if (this.HasCamp)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Camp);
			}
			if (this.OwnerIncId != 0L)
			{
				num += 2 + CodedOutputStream.ComputeInt64Size(this.OwnerIncId);
			}
			if (this.gravityDirection_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GravityDirection);
			}
			if (this.RoleSkinId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RoleSkinId);
			}
			if (this.IsActorVisible)
			{
				num += 3;
			}
			if (this.GlideWingSkinId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.GlideWingSkinId);
			}
			if (this.GlideBrollySkinId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.GlideBrollySkinId);
			}
			if (this.IsSnap)
			{
				num += 3;
			}
			if (this.ClientHiddenFlag)
			{
				num += 3;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600727C RID: 29308 RVA: 0x00118A5C File Offset: 0x00116C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.ConfigType != EntityConfigType.OldEntity)
			{
				this.ConfigType = other.ConfigType;
			}
			if (other.EntityType != 0)
			{
				this.EntityType = other.EntityType;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			if (other.rot_ != null)
			{
				if (this.rot_ == null)
				{
					this.Rot = new Rotator();
				}
				this.Rot.MergeFrom(other.Rot);
			}
			if (other.initPos_ != null)
			{
				if (this.initPos_ == null)
				{
					this.InitPos = new Vector();
				}
				this.InitPos.MergeFrom(other.InitPos);
			}
			if (other.LivingStatus != LivingStatus.Alive)
			{
				this.LivingStatus = other.LivingStatus;
			}
			if (other.IsVisible)
			{
				this.IsVisible = other.IsVisible;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this.componentPbs_.Add(other.componentPbs_);
			if (other.DurabilityValue != 0)
			{
				this.DurabilityValue = other.DurabilityValue;
			}
			if (other.EntityState != EntityState.Default)
			{
				this.EntityState = other.EntityState;
			}
			if (other.initLinearVelocity_ != null)
			{
				if (this.initLinearVelocity_ == null)
				{
					this.InitLinearVelocity = new Vector();
				}
				this.InitLinearVelocity.MergeFrom(other.InitLinearVelocity);
			}
			if (other.IsPosAbnormal)
			{
				this.IsPosAbnormal = other.IsPosAbnormal;
			}
			if (other.PrefabId != 0)
			{
				this.PrefabId = other.PrefabId;
			}
			if (other.PrefabIncId != 0L)
			{
				this.PrefabIncId = other.PrefabIncId;
			}
			if (other.SubEntityType != 0)
			{
				this.SubEntityType = other.SubEntityType;
			}
			if (other.HasCamp)
			{
				this.Camp = other.Camp;
			}
			if (other.OwnerIncId != 0L)
			{
				this.OwnerIncId = other.OwnerIncId;
			}
			if (other.gravityDirection_ != null)
			{
				if (this.gravityDirection_ == null)
				{
					this.GravityDirection = new Vector();
				}
				this.GravityDirection.MergeFrom(other.GravityDirection);
			}
			if (other.RoleSkinId != 0)
			{
				this.RoleSkinId = other.RoleSkinId;
			}
			if (other.IsActorVisible)
			{
				this.IsActorVisible = other.IsActorVisible;
			}
			if (other.GlideWingSkinId != 0)
			{
				this.GlideWingSkinId = other.GlideWingSkinId;
			}
			if (other.GlideBrollySkinId != 0)
			{
				this.GlideBrollySkinId = other.GlideBrollySkinId;
			}
			if (other.IsSnap)
			{
				this.IsSnap = other.IsSnap;
			}
			if (other.ClientHiddenFlag)
			{
				this.ClientHiddenFlag = other.ClientHiddenFlag;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600727D RID: 29309 RVA: 0x00118D15 File Offset: 0x00116F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600727E RID: 29310 RVA: 0x00118D20 File Offset: 0x00116F20
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
				if (num <= 104U)
				{
					if (num <= 50U)
					{
						if (num <= 24U)
						{
							if (num == 8U)
							{
								this.Id = input.ReadInt64();
								continue;
							}
							if (num == 16U)
							{
								this.ConfigId = input.ReadInt32();
								continue;
							}
							if (num == 24U)
							{
								this.ConfigType = (EntityConfigType)input.ReadEnum();
								continue;
							}
						}
						else
						{
							if (num == 32U)
							{
								this.EntityType = input.ReadInt32();
								continue;
							}
							if (num == 42U)
							{
								if (this.pos_ == null)
								{
									this.Pos = new Vector();
								}
								input.ReadMessage(this.Pos);
								continue;
							}
							if (num == 50U)
							{
								if (this.rot_ == null)
								{
									this.Rot = new Rotator();
								}
								input.ReadMessage(this.Rot);
								continue;
							}
						}
					}
					else if (num <= 72U)
					{
						if (num == 58U)
						{
							if (this.initPos_ == null)
							{
								this.InitPos = new Vector();
							}
							input.ReadMessage(this.InitPos);
							continue;
						}
						if (num == 64U)
						{
							this.LivingStatus = (LivingStatus)input.ReadEnum();
							continue;
						}
						if (num == 72U)
						{
							this.IsVisible = input.ReadBool();
							continue;
						}
					}
					else if (num <= 90U)
					{
						if (num == 80U)
						{
							this.PlayerId = input.ReadInt32();
							continue;
						}
						if (num == 90U)
						{
							this.componentPbs_.AddEntriesFrom(ref input, EntityPb._repeated_componentPbs_codec);
							continue;
						}
					}
					else
					{
						if (num == 96U)
						{
							this.DurabilityValue = input.ReadInt32();
							continue;
						}
						if (num == 104U)
						{
							this.EntityState = (EntityState)input.ReadEnum();
							continue;
						}
					}
				}
				else if (num <= 168U)
				{
					if (num <= 136U)
					{
						if (num == 114U)
						{
							if (this.initLinearVelocity_ == null)
							{
								this.InitLinearVelocity = new Vector();
							}
							input.ReadMessage(this.InitLinearVelocity);
							continue;
						}
						if (num == 120U)
						{
							this.IsPosAbnormal = input.ReadBool();
							continue;
						}
						if (num == 136U)
						{
							this.PrefabId = input.ReadInt32();
							continue;
						}
					}
					else if (num <= 152U)
					{
						if (num == 144U)
						{
							this.PrefabIncId = input.ReadInt64();
							continue;
						}
						if (num == 152U)
						{
							this.SubEntityType = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 160U)
						{
							this.Camp = input.ReadInt32();
							continue;
						}
						if (num == 168U)
						{
							this.OwnerIncId = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 192U)
				{
					if (num == 178U)
					{
						if (this.gravityDirection_ == null)
						{
							this.GravityDirection = new Vector();
						}
						input.ReadMessage(this.GravityDirection);
						continue;
					}
					if (num == 184U)
					{
						this.RoleSkinId = input.ReadInt32();
						continue;
					}
					if (num == 192U)
					{
						this.IsActorVisible = input.ReadBool();
						continue;
					}
				}
				else if (num <= 208U)
				{
					if (num == 200U)
					{
						this.GlideWingSkinId = input.ReadInt32();
						continue;
					}
					if (num == 208U)
					{
						this.GlideBrollySkinId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 216U)
					{
						this.IsSnap = input.ReadBool();
						continue;
					}
					if (num == 224U)
					{
						this.ClientHiddenFlag = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003CAE RID: 15534
		private static readonly MessageParser<EntityPb> _parser = new MessageParser<EntityPb>(() => new EntityPb());

		// Token: 0x04003CAF RID: 15535
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CB0 RID: 15536
		private int _hasBits0;

		// Token: 0x04003CB1 RID: 15537
		public const int IdFieldNumber = 1;

		// Token: 0x04003CB2 RID: 15538
		private long id_;

		// Token: 0x04003CB3 RID: 15539
		public const int ConfigIdFieldNumber = 2;

		// Token: 0x04003CB4 RID: 15540
		private int configId_;

		// Token: 0x04003CB5 RID: 15541
		public const int ConfigTypeFieldNumber = 3;

		// Token: 0x04003CB6 RID: 15542
		private EntityConfigType configType_;

		// Token: 0x04003CB7 RID: 15543
		public const int EntityTypeFieldNumber = 4;

		// Token: 0x04003CB8 RID: 15544
		private int entityType_;

		// Token: 0x04003CB9 RID: 15545
		public const int PosFieldNumber = 5;

		// Token: 0x04003CBA RID: 15546
		private Vector pos_;

		// Token: 0x04003CBB RID: 15547
		public const int RotFieldNumber = 6;

		// Token: 0x04003CBC RID: 15548
		private Rotator rot_;

		// Token: 0x04003CBD RID: 15549
		public const int InitPosFieldNumber = 7;

		// Token: 0x04003CBE RID: 15550
		private Vector initPos_;

		// Token: 0x04003CBF RID: 15551
		public const int LivingStatusFieldNumber = 8;

		// Token: 0x04003CC0 RID: 15552
		private LivingStatus livingStatus_;

		// Token: 0x04003CC1 RID: 15553
		public const int IsVisibleFieldNumber = 9;

		// Token: 0x04003CC2 RID: 15554
		private bool isVisible_;

		// Token: 0x04003CC3 RID: 15555
		public const int PlayerIdFieldNumber = 10;

		// Token: 0x04003CC4 RID: 15556
		private int playerId_;

		// Token: 0x04003CC5 RID: 15557
		public const int ComponentPbsFieldNumber = 11;

		// Token: 0x04003CC6 RID: 15558
		private static readonly FieldCodec<EntityComponentPb> _repeated_componentPbs_codec = FieldCodec.ForMessage<EntityComponentPb>(90U, EntityComponentPb.Parser);

		// Token: 0x04003CC7 RID: 15559
		private readonly RepeatedField<EntityComponentPb> componentPbs_ = new RepeatedField<EntityComponentPb>();

		// Token: 0x04003CC8 RID: 15560
		public const int DurabilityValueFieldNumber = 12;

		// Token: 0x04003CC9 RID: 15561
		private int durabilityValue_;

		// Token: 0x04003CCA RID: 15562
		public const int EntityStateFieldNumber = 13;

		// Token: 0x04003CCB RID: 15563
		private EntityState entityState_;

		// Token: 0x04003CCC RID: 15564
		public const int InitLinearVelocityFieldNumber = 14;

		// Token: 0x04003CCD RID: 15565
		private Vector initLinearVelocity_;

		// Token: 0x04003CCE RID: 15566
		public const int IsPosAbnormalFieldNumber = 15;

		// Token: 0x04003CCF RID: 15567
		private bool isPosAbnormal_;

		// Token: 0x04003CD0 RID: 15568
		public const int PrefabIdFieldNumber = 17;

		// Token: 0x04003CD1 RID: 15569
		private int prefabId_;

		// Token: 0x04003CD2 RID: 15570
		public const int PrefabIncIdFieldNumber = 18;

		// Token: 0x04003CD3 RID: 15571
		private long prefabIncId_;

		// Token: 0x04003CD4 RID: 15572
		public const int SubEntityTypeFieldNumber = 19;

		// Token: 0x04003CD5 RID: 15573
		private int subEntityType_;

		// Token: 0x04003CD6 RID: 15574
		public const int CampFieldNumber = 20;

		// Token: 0x04003CD7 RID: 15575
		private static readonly int CampDefaultValue = 0;

		// Token: 0x04003CD8 RID: 15576
		private int camp_;

		// Token: 0x04003CD9 RID: 15577
		public const int OwnerIncIdFieldNumber = 21;

		// Token: 0x04003CDA RID: 15578
		private long ownerIncId_;

		// Token: 0x04003CDB RID: 15579
		public const int GravityDirectionFieldNumber = 22;

		// Token: 0x04003CDC RID: 15580
		private Vector gravityDirection_;

		// Token: 0x04003CDD RID: 15581
		public const int RoleSkinIdFieldNumber = 23;

		// Token: 0x04003CDE RID: 15582
		private int roleSkinId_;

		// Token: 0x04003CDF RID: 15583
		public const int IsActorVisibleFieldNumber = 24;

		// Token: 0x04003CE0 RID: 15584
		private bool isActorVisible_;

		// Token: 0x04003CE1 RID: 15585
		public const int GlideWingSkinIdFieldNumber = 25;

		// Token: 0x04003CE2 RID: 15586
		private int glideWingSkinId_;

		// Token: 0x04003CE3 RID: 15587
		public const int GlideBrollySkinIdFieldNumber = 26;

		// Token: 0x04003CE4 RID: 15588
		private int glideBrollySkinId_;

		// Token: 0x04003CE5 RID: 15589
		public const int IsSnapFieldNumber = 27;

		// Token: 0x04003CE6 RID: 15590
		private bool isSnap_;

		// Token: 0x04003CE7 RID: 15591
		public const int ClientHiddenFlagFieldNumber = 28;

		// Token: 0x04003CE8 RID: 15592
		private bool clientHiddenFlag_;
	}
}
