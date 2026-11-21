using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000499 RID: 1177
	public sealed class EntityPb : IMessage<EntityPb>, IMessage, IEquatable<EntityPb>, IDeepCloneable<EntityPb>, IBufferMessage
	{
		// Token: 0x060070A9 RID: 28841 RVA: 0x00114B5D File Offset: 0x00112D5D
		[NullableContext(1)]
		public static EntityPb Create()
		{
			return new EntityPb();
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x060070AA RID: 28842 RVA: 0x00114B64 File Offset: 0x00112D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityPb> Parser
		{
			get
			{
				return EntityPb._parser;
			}
		}

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x060070AB RID: 28843 RVA: 0x00114B6B File Offset: 0x00112D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x060070AC RID: 28844 RVA: 0x00114B6E File Offset: 0x00112D6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityPb.Descriptor;
			}
		}

		// Token: 0x060070AD RID: 28845 RVA: 0x00114B75 File Offset: 0x00112D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPb()
		{
		}

		// Token: 0x060070AE RID: 28846 RVA: 0x00114B88 File Offset: 0x00112D88
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
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060070AF RID: 28847 RVA: 0x00114D45 File Offset: 0x00112F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityPb Clone()
		{
			return new EntityPb(this);
		}

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x060070B0 RID: 28848 RVA: 0x00114D4D File Offset: 0x00112F4D
		// (set) Token: 0x060070B1 RID: 28849 RVA: 0x00114D55 File Offset: 0x00112F55
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

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x060070B2 RID: 28850 RVA: 0x00114D5E File Offset: 0x00112F5E
		// (set) Token: 0x060070B3 RID: 28851 RVA: 0x00114D66 File Offset: 0x00112F66
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

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x060070B4 RID: 28852 RVA: 0x00114D6F File Offset: 0x00112F6F
		// (set) Token: 0x060070B5 RID: 28853 RVA: 0x00114D77 File Offset: 0x00112F77
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

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x060070B6 RID: 28854 RVA: 0x00114D80 File Offset: 0x00112F80
		// (set) Token: 0x060070B7 RID: 28855 RVA: 0x00114D88 File Offset: 0x00112F88
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

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x060070B8 RID: 28856 RVA: 0x00114D91 File Offset: 0x00112F91
		// (set) Token: 0x060070B9 RID: 28857 RVA: 0x00114D99 File Offset: 0x00112F99
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

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x060070BA RID: 28858 RVA: 0x00114DA2 File Offset: 0x00112FA2
		// (set) Token: 0x060070BB RID: 28859 RVA: 0x00114DAA File Offset: 0x00112FAA
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

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x060070BC RID: 28860 RVA: 0x00114DB3 File Offset: 0x00112FB3
		// (set) Token: 0x060070BD RID: 28861 RVA: 0x00114DBB File Offset: 0x00112FBB
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

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x060070BE RID: 28862 RVA: 0x00114DC4 File Offset: 0x00112FC4
		// (set) Token: 0x060070BF RID: 28863 RVA: 0x00114DCC File Offset: 0x00112FCC
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

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x060070C0 RID: 28864 RVA: 0x00114DD5 File Offset: 0x00112FD5
		// (set) Token: 0x060070C1 RID: 28865 RVA: 0x00114DDD File Offset: 0x00112FDD
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

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x060070C2 RID: 28866 RVA: 0x00114DE6 File Offset: 0x00112FE6
		// (set) Token: 0x060070C3 RID: 28867 RVA: 0x00114DEE File Offset: 0x00112FEE
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

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x060070C4 RID: 28868 RVA: 0x00114DF7 File Offset: 0x00112FF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityComponentPb> ComponentPbs
		{
			get
			{
				return this.componentPbs_;
			}
		}

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x060070C5 RID: 28869 RVA: 0x00114DFF File Offset: 0x00112FFF
		// (set) Token: 0x060070C6 RID: 28870 RVA: 0x00114E07 File Offset: 0x00113007
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

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x060070C7 RID: 28871 RVA: 0x00114E10 File Offset: 0x00113010
		// (set) Token: 0x060070C8 RID: 28872 RVA: 0x00114E18 File Offset: 0x00113018
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

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x060070C9 RID: 28873 RVA: 0x00114E21 File Offset: 0x00113021
		// (set) Token: 0x060070CA RID: 28874 RVA: 0x00114E29 File Offset: 0x00113029
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

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x060070CB RID: 28875 RVA: 0x00114E32 File Offset: 0x00113032
		// (set) Token: 0x060070CC RID: 28876 RVA: 0x00114E3A File Offset: 0x0011303A
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

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x060070CD RID: 28877 RVA: 0x00114E43 File Offset: 0x00113043
		// (set) Token: 0x060070CE RID: 28878 RVA: 0x00114E4B File Offset: 0x0011304B
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

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x060070CF RID: 28879 RVA: 0x00114E54 File Offset: 0x00113054
		// (set) Token: 0x060070D0 RID: 28880 RVA: 0x00114E5C File Offset: 0x0011305C
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

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x060070D1 RID: 28881 RVA: 0x00114E65 File Offset: 0x00113065
		// (set) Token: 0x060070D2 RID: 28882 RVA: 0x00114E6D File Offset: 0x0011306D
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

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x060070D3 RID: 28883 RVA: 0x00114E76 File Offset: 0x00113076
		// (set) Token: 0x060070D4 RID: 28884 RVA: 0x00114E8E File Offset: 0x0011308E
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

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x060070D5 RID: 28885 RVA: 0x00114EA5 File Offset: 0x001130A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasCamp
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060070D6 RID: 28886 RVA: 0x00114EB2 File Offset: 0x001130B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearCamp()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x060070D7 RID: 28887 RVA: 0x00114EC3 File Offset: 0x001130C3
		// (set) Token: 0x060070D8 RID: 28888 RVA: 0x00114ECB File Offset: 0x001130CB
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

		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x060070D9 RID: 28889 RVA: 0x00114ED4 File Offset: 0x001130D4
		// (set) Token: 0x060070DA RID: 28890 RVA: 0x00114EDC File Offset: 0x001130DC
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

		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x060070DB RID: 28891 RVA: 0x00114EE5 File Offset: 0x001130E5
		// (set) Token: 0x060070DC RID: 28892 RVA: 0x00114EED File Offset: 0x001130ED
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

		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x060070DD RID: 28893 RVA: 0x00114EF6 File Offset: 0x001130F6
		// (set) Token: 0x060070DE RID: 28894 RVA: 0x00114EFE File Offset: 0x001130FE
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

		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x060070DF RID: 28895 RVA: 0x00114F07 File Offset: 0x00113107
		// (set) Token: 0x060070E0 RID: 28896 RVA: 0x00114F0F File Offset: 0x0011310F
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

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x060070E1 RID: 28897 RVA: 0x00114F18 File Offset: 0x00113118
		// (set) Token: 0x060070E2 RID: 28898 RVA: 0x00114F20 File Offset: 0x00113120
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

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x060070E3 RID: 28899 RVA: 0x00114F29 File Offset: 0x00113129
		// (set) Token: 0x060070E4 RID: 28900 RVA: 0x00114F31 File Offset: 0x00113131
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

		// Token: 0x060070E5 RID: 28901 RVA: 0x00114F3A File Offset: 0x0011313A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityPb);
		}

		// Token: 0x060070E6 RID: 28902 RVA: 0x00114F48 File Offset: 0x00113148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.ConfigId == other.ConfigId && this.ConfigType == other.ConfigType && this.EntityType == other.EntityType && object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && object.Equals(this.InitPos, other.InitPos) && this.LivingStatus == other.LivingStatus && this.IsVisible == other.IsVisible && this.PlayerId == other.PlayerId && this.componentPbs_.Equals(other.componentPbs_) && this.DurabilityValue == other.DurabilityValue && this.EntityState == other.EntityState && object.Equals(this.InitLinearVelocity, other.InitLinearVelocity) && this.IsPosAbnormal == other.IsPosAbnormal && this.PrefabId == other.PrefabId && this.PrefabIncId == other.PrefabIncId && this.SubEntityType == other.SubEntityType && this.Camp == other.Camp && this.OwnerIncId == other.OwnerIncId && object.Equals(this.GravityDirection, other.GravityDirection) && this.RoleSkinId == other.RoleSkinId && this.IsActorVisible == other.IsActorVisible && this.GlideWingSkinId == other.GlideWingSkinId && this.GlideBrollySkinId == other.GlideBrollySkinId && this.IsSnap == other.IsSnap && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060070E7 RID: 28903 RVA: 0x00115130 File Offset: 0x00113330
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060070E8 RID: 28904 RVA: 0x001153DE File Offset: 0x001135DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060070E9 RID: 28905 RVA: 0x001153EB File Offset: 0x001135EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060070EA RID: 28906 RVA: 0x001153F4 File Offset: 0x001135F4
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
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060070EB RID: 28907 RVA: 0x00115710 File Offset: 0x00113910
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060070EC RID: 28908 RVA: 0x00115974 File Offset: 0x00113B74
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060070ED RID: 28909 RVA: 0x00115C19 File Offset: 0x00113E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060070EE RID: 28910 RVA: 0x00115C24 File Offset: 0x00113E24
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
				else if (num <= 160U)
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
					else
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
						if (num == 160U)
						{
							this.Camp = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 184U)
				{
					if (num == 168U)
					{
						this.OwnerIncId = input.ReadInt64();
						continue;
					}
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
				}
				else if (num <= 200U)
				{
					if (num == 192U)
					{
						this.IsActorVisible = input.ReadBool();
						continue;
					}
					if (num == 200U)
					{
						this.GlideWingSkinId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 208U)
					{
						this.GlideBrollySkinId = input.ReadInt32();
						continue;
					}
					if (num == 216U)
					{
						this.IsSnap = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C9C RID: 15516
		private static readonly MessageParser<EntityPb> _parser = new MessageParser<EntityPb>(() => new EntityPb());

		// Token: 0x04003C9D RID: 15517
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C9E RID: 15518
		private int _hasBits0;

		// Token: 0x04003C9F RID: 15519
		public const int IdFieldNumber = 1;

		// Token: 0x04003CA0 RID: 15520
		private long id_;

		// Token: 0x04003CA1 RID: 15521
		public const int ConfigIdFieldNumber = 2;

		// Token: 0x04003CA2 RID: 15522
		private int configId_;

		// Token: 0x04003CA3 RID: 15523
		public const int ConfigTypeFieldNumber = 3;

		// Token: 0x04003CA4 RID: 15524
		private EntityConfigType configType_;

		// Token: 0x04003CA5 RID: 15525
		public const int EntityTypeFieldNumber = 4;

		// Token: 0x04003CA6 RID: 15526
		private int entityType_;

		// Token: 0x04003CA7 RID: 15527
		public const int PosFieldNumber = 5;

		// Token: 0x04003CA8 RID: 15528
		private Vector pos_;

		// Token: 0x04003CA9 RID: 15529
		public const int RotFieldNumber = 6;

		// Token: 0x04003CAA RID: 15530
		private Rotator rot_;

		// Token: 0x04003CAB RID: 15531
		public const int InitPosFieldNumber = 7;

		// Token: 0x04003CAC RID: 15532
		private Vector initPos_;

		// Token: 0x04003CAD RID: 15533
		public const int LivingStatusFieldNumber = 8;

		// Token: 0x04003CAE RID: 15534
		private LivingStatus livingStatus_;

		// Token: 0x04003CAF RID: 15535
		public const int IsVisibleFieldNumber = 9;

		// Token: 0x04003CB0 RID: 15536
		private bool isVisible_;

		// Token: 0x04003CB1 RID: 15537
		public const int PlayerIdFieldNumber = 10;

		// Token: 0x04003CB2 RID: 15538
		private int playerId_;

		// Token: 0x04003CB3 RID: 15539
		public const int ComponentPbsFieldNumber = 11;

		// Token: 0x04003CB4 RID: 15540
		private static readonly FieldCodec<EntityComponentPb> _repeated_componentPbs_codec = FieldCodec.ForMessage<EntityComponentPb>(90U, EntityComponentPb.Parser);

		// Token: 0x04003CB5 RID: 15541
		private readonly RepeatedField<EntityComponentPb> componentPbs_ = new RepeatedField<EntityComponentPb>();

		// Token: 0x04003CB6 RID: 15542
		public const int DurabilityValueFieldNumber = 12;

		// Token: 0x04003CB7 RID: 15543
		private int durabilityValue_;

		// Token: 0x04003CB8 RID: 15544
		public const int EntityStateFieldNumber = 13;

		// Token: 0x04003CB9 RID: 15545
		private EntityState entityState_;

		// Token: 0x04003CBA RID: 15546
		public const int InitLinearVelocityFieldNumber = 14;

		// Token: 0x04003CBB RID: 15547
		private Vector initLinearVelocity_;

		// Token: 0x04003CBC RID: 15548
		public const int IsPosAbnormalFieldNumber = 15;

		// Token: 0x04003CBD RID: 15549
		private bool isPosAbnormal_;

		// Token: 0x04003CBE RID: 15550
		public const int PrefabIdFieldNumber = 17;

		// Token: 0x04003CBF RID: 15551
		private int prefabId_;

		// Token: 0x04003CC0 RID: 15552
		public const int PrefabIncIdFieldNumber = 18;

		// Token: 0x04003CC1 RID: 15553
		private long prefabIncId_;

		// Token: 0x04003CC2 RID: 15554
		public const int SubEntityTypeFieldNumber = 19;

		// Token: 0x04003CC3 RID: 15555
		private int subEntityType_;

		// Token: 0x04003CC4 RID: 15556
		public const int CampFieldNumber = 20;

		// Token: 0x04003CC5 RID: 15557
		private static readonly int CampDefaultValue = 0;

		// Token: 0x04003CC6 RID: 15558
		private int camp_;

		// Token: 0x04003CC7 RID: 15559
		public const int OwnerIncIdFieldNumber = 21;

		// Token: 0x04003CC8 RID: 15560
		private long ownerIncId_;

		// Token: 0x04003CC9 RID: 15561
		public const int GravityDirectionFieldNumber = 22;

		// Token: 0x04003CCA RID: 15562
		private Vector gravityDirection_;

		// Token: 0x04003CCB RID: 15563
		public const int RoleSkinIdFieldNumber = 23;

		// Token: 0x04003CCC RID: 15564
		private int roleSkinId_;

		// Token: 0x04003CCD RID: 15565
		public const int IsActorVisibleFieldNumber = 24;

		// Token: 0x04003CCE RID: 15566
		private bool isActorVisible_;

		// Token: 0x04003CCF RID: 15567
		public const int GlideWingSkinIdFieldNumber = 25;

		// Token: 0x04003CD0 RID: 15568
		private int glideWingSkinId_;

		// Token: 0x04003CD1 RID: 15569
		public const int GlideBrollySkinIdFieldNumber = 26;

		// Token: 0x04003CD2 RID: 15570
		private int glideBrollySkinId_;

		// Token: 0x04003CD3 RID: 15571
		public const int IsSnapFieldNumber = 27;

		// Token: 0x04003CD4 RID: 15572
		private bool isSnap_;
	}
}
