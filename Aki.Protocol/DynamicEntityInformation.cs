using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000404 RID: 1028
	public sealed class DynamicEntityInformation : IMessage<DynamicEntityInformation>, IMessage, IEquatable<DynamicEntityInformation>, IDeepCloneable<DynamicEntityInformation>, IBufferMessage
	{
		// Token: 0x06006368 RID: 25448 RVA: 0x000EF0E8 File Offset: 0x000ED2E8
		[NullableContext(1)]
		public static DynamicEntityInformation Create()
		{
			return new DynamicEntityInformation();
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x06006369 RID: 25449 RVA: 0x000EF0EF File Offset: 0x000ED2EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DynamicEntityInformation> Parser
		{
			get
			{
				return DynamicEntityInformation._parser;
			}
		}

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x0600636A RID: 25450 RVA: 0x000EF0F6 File Offset: 0x000ED2F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x0600636B RID: 25451 RVA: 0x000EF0F9 File Offset: 0x000ED2F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DynamicEntityInformation.Descriptor;
			}
		}

		// Token: 0x0600636C RID: 25452 RVA: 0x000EF100 File Offset: 0x000ED300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicEntityInformation()
		{
		}

		// Token: 0x0600636D RID: 25453 RVA: 0x000EF198 File Offset: 0x000ED398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicEntityInformation(DynamicEntityInformation other) : this()
		{
			this.id_ = other.id_;
			this.entityType_ = other.entityType_;
			this.configId_ = other.configId_;
			this.playerId_ = other.playerId_;
			this.ownerId_ = other.ownerId_;
			this.movementInformation_ = ((other.movementInformation_ != null) ? other.movementInformation_.Clone() : null);
			this.gameAttributes_ = other.gameAttributes_.Clone();
			this.initAttribute_ = other.initAttribute_;
			this.isVisible_ = other.isVisible_;
			this.animationStates_ = other.animationStates_.Clone();
			this.initGameplayTag_ = other.initGameplayTag_;
			this.gameplayTags_ = other.gameplayTags_.Clone();
			this.level_ = other.level_;
			this.blackboardParams_ = other.blackboardParams_.Clone();
			this.tags_ = other.tags_.Clone();
			this.privateTags_ = other.privateTags_.Clone();
			this.deathStatus_ = other.deathStatus_;
			this.hardnessModeId_ = other.hardnessModeId_;
			this.partLifeInfos_ = other.partLifeInfos_.Clone();
			this.visionSkillInfos_ = other.visionSkillInfos_.Clone();
			this.fightBuffInfos_ = other.fightBuffInfos_.Clone();
			this.creatureGroup_ = other.creatureGroup_;
			this.listenInformation_ = ((other.listenInformation_ != null) ? other.listenInformation_.Clone() : null);
			this.sysBuffInfos_ = other.sysBuffInfos_.Clone();
			this.livingStatus_ = other.livingStatus_;
			this.entityCommonTags_ = other.entityCommonTags_.Clone();
			this.weaponConfId_ = other.weaponConfId_;
			this.durabilityValue_ = other.durabilityValue_;
			this.initLocation_ = ((other.initLocation_ != null) ? other.initLocation_.Clone() : null);
			this.summonInfo_ = ((other.summonInfo_ != null) ? other.summonInfo_.Clone() : null);
			this.componentPbs_ = other.componentPbs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600636E RID: 25454 RVA: 0x000EF3AC File Offset: 0x000ED5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicEntityInformation Clone()
		{
			return new DynamicEntityInformation(this);
		}

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x0600636F RID: 25455 RVA: 0x000EF3B4 File Offset: 0x000ED5B4
		// (set) Token: 0x06006370 RID: 25456 RVA: 0x000EF3BC File Offset: 0x000ED5BC
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

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x06006371 RID: 25457 RVA: 0x000EF3C5 File Offset: 0x000ED5C5
		// (set) Token: 0x06006372 RID: 25458 RVA: 0x000EF3CD File Offset: 0x000ED5CD
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

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x06006373 RID: 25459 RVA: 0x000EF3D6 File Offset: 0x000ED5D6
		// (set) Token: 0x06006374 RID: 25460 RVA: 0x000EF3DE File Offset: 0x000ED5DE
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

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x06006375 RID: 25461 RVA: 0x000EF3E7 File Offset: 0x000ED5E7
		// (set) Token: 0x06006376 RID: 25462 RVA: 0x000EF3EF File Offset: 0x000ED5EF
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

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x06006377 RID: 25463 RVA: 0x000EF3F8 File Offset: 0x000ED5F8
		// (set) Token: 0x06006378 RID: 25464 RVA: 0x000EF400 File Offset: 0x000ED600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OwnerId
		{
			get
			{
				return this.ownerId_;
			}
			set
			{
				this.ownerId_ = value;
			}
		}

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x06006379 RID: 25465 RVA: 0x000EF409 File Offset: 0x000ED609
		// (set) Token: 0x0600637A RID: 25466 RVA: 0x000EF411 File Offset: 0x000ED611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovementInformation MovementInformation
		{
			get
			{
				return this.movementInformation_;
			}
			set
			{
				this.movementInformation_ = value;
			}
		}

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x0600637B RID: 25467 RVA: 0x000EF41A File Offset: 0x000ED61A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> GameAttributes
		{
			get
			{
				return this.gameAttributes_;
			}
		}

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x0600637C RID: 25468 RVA: 0x000EF422 File Offset: 0x000ED622
		// (set) Token: 0x0600637D RID: 25469 RVA: 0x000EF42A File Offset: 0x000ED62A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool InitAttribute
		{
			get
			{
				return this.initAttribute_;
			}
			set
			{
				this.initAttribute_ = value;
			}
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x0600637E RID: 25470 RVA: 0x000EF433 File Offset: 0x000ED633
		// (set) Token: 0x0600637F RID: 25471 RVA: 0x000EF43B File Offset: 0x000ED63B
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

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x06006380 RID: 25472 RVA: 0x000EF444 File Offset: 0x000ED644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AnimationStates
		{
			get
			{
				return this.animationStates_;
			}
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x06006381 RID: 25473 RVA: 0x000EF44C File Offset: 0x000ED64C
		// (set) Token: 0x06006382 RID: 25474 RVA: 0x000EF454 File Offset: 0x000ED654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool InitGameplayTag
		{
			get
			{
				return this.initGameplayTag_;
			}
			set
			{
				this.initGameplayTag_ = value;
			}
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x06006383 RID: 25475 RVA: 0x000EF45D File Offset: 0x000ED65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayTagData> GameplayTags
		{
			get
			{
				return this.gameplayTags_;
			}
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x06006384 RID: 25476 RVA: 0x000EF465 File Offset: 0x000ED665
		// (set) Token: 0x06006385 RID: 25477 RVA: 0x000EF46D File Offset: 0x000ED66D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x06006386 RID: 25478 RVA: 0x000EF476 File Offset: 0x000ED676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackboardParam> BlackboardParams
		{
			get
			{
				return this.blackboardParams_;
			}
		}

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x06006387 RID: 25479 RVA: 0x000EF47E File Offset: 0x000ED67E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Tags
		{
			get
			{
				return this.tags_;
			}
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x06006388 RID: 25480 RVA: 0x000EF486 File Offset: 0x000ED686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PrivateTag> PrivateTags
		{
			get
			{
				return this.privateTags_;
			}
		}

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x06006389 RID: 25481 RVA: 0x000EF48E File Offset: 0x000ED68E
		// (set) Token: 0x0600638A RID: 25482 RVA: 0x000EF496 File Offset: 0x000ED696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DeathStatus
		{
			get
			{
				return this.deathStatus_;
			}
			set
			{
				this.deathStatus_ = value;
			}
		}

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x0600638B RID: 25483 RVA: 0x000EF49F File Offset: 0x000ED69F
		// (set) Token: 0x0600638C RID: 25484 RVA: 0x000EF4A7 File Offset: 0x000ED6A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HardnessModeId
		{
			get
			{
				return this.hardnessModeId_;
			}
			set
			{
				this.hardnessModeId_ = value;
			}
		}

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x0600638D RID: 25485 RVA: 0x000EF4B0 File Offset: 0x000ED6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PartInformation> PartLifeInfos
		{
			get
			{
				return this.partLifeInfos_;
			}
		}

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x0600638E RID: 25486 RVA: 0x000EF4B8 File Offset: 0x000ED6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<VisionSkillInformation> VisionSkillInfos
		{
			get
			{
				return this.visionSkillInfos_;
			}
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x0600638F RID: 25487 RVA: 0x000EF4C0 File Offset: 0x000ED6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightBuffInformation> FightBuffInfos
		{
			get
			{
				return this.fightBuffInfos_;
			}
		}

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x06006390 RID: 25488 RVA: 0x000EF4C8 File Offset: 0x000ED6C8
		// (set) Token: 0x06006391 RID: 25489 RVA: 0x000EF4D0 File Offset: 0x000ED6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CreatureGroup
		{
			get
			{
				return this.creatureGroup_;
			}
			set
			{
				this.creatureGroup_ = value;
			}
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x06006392 RID: 25490 RVA: 0x000EF4D9 File Offset: 0x000ED6D9
		// (set) Token: 0x06006393 RID: 25491 RVA: 0x000EF4E1 File Offset: 0x000ED6E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ListenInformation ListenInformation
		{
			get
			{
				return this.listenInformation_;
			}
			set
			{
				this.listenInformation_ = value;
			}
		}

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x06006394 RID: 25492 RVA: 0x000EF4EA File Offset: 0x000ED6EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SysBuffInformation> SysBuffInfos
		{
			get
			{
				return this.sysBuffInfos_;
			}
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x06006395 RID: 25493 RVA: 0x000EF4F2 File Offset: 0x000ED6F2
		// (set) Token: 0x06006396 RID: 25494 RVA: 0x000EF4FA File Offset: 0x000ED6FA
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

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x06006397 RID: 25495 RVA: 0x000EF503 File Offset: 0x000ED703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EntityCommonTags
		{
			get
			{
				return this.entityCommonTags_;
			}
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x06006398 RID: 25496 RVA: 0x000EF50B File Offset: 0x000ED70B
		// (set) Token: 0x06006399 RID: 25497 RVA: 0x000EF513 File Offset: 0x000ED713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponConfId
		{
			get
			{
				return this.weaponConfId_;
			}
			set
			{
				this.weaponConfId_ = value;
			}
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x0600639A RID: 25498 RVA: 0x000EF51C File Offset: 0x000ED71C
		// (set) Token: 0x0600639B RID: 25499 RVA: 0x000EF524 File Offset: 0x000ED724
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

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x0600639C RID: 25500 RVA: 0x000EF52D File Offset: 0x000ED72D
		// (set) Token: 0x0600639D RID: 25501 RVA: 0x000EF535 File Offset: 0x000ED735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector InitLocation
		{
			get
			{
				return this.initLocation_;
			}
			set
			{
				this.initLocation_ = value;
			}
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x0600639E RID: 25502 RVA: 0x000EF53E File Offset: 0x000ED73E
		// (set) Token: 0x0600639F RID: 25503 RVA: 0x000EF546 File Offset: 0x000ED746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonInfo SummonInfo
		{
			get
			{
				return this.summonInfo_;
			}
			set
			{
				this.summonInfo_ = value;
			}
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x060063A0 RID: 25504 RVA: 0x000EF54F File Offset: 0x000ED74F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityComponentPb> ComponentPbs
		{
			get
			{
				return this.componentPbs_;
			}
		}

		// Token: 0x060063A1 RID: 25505 RVA: 0x000EF557 File Offset: 0x000ED757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DynamicEntityInformation);
		}

		// Token: 0x060063A2 RID: 25506 RVA: 0x000EF568 File Offset: 0x000ED768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DynamicEntityInformation other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.EntityType == other.EntityType && this.ConfigId == other.ConfigId && this.PlayerId == other.PlayerId && this.OwnerId == other.OwnerId && object.Equals(this.MovementInformation, other.MovementInformation) && this.gameAttributes_.Equals(other.gameAttributes_) && this.InitAttribute == other.InitAttribute && this.IsVisible == other.IsVisible && this.animationStates_.Equals(other.animationStates_) && this.InitGameplayTag == other.InitGameplayTag && this.gameplayTags_.Equals(other.gameplayTags_) && this.Level == other.Level && this.blackboardParams_.Equals(other.blackboardParams_) && this.tags_.Equals(other.tags_) && this.privateTags_.Equals(other.privateTags_) && this.DeathStatus == other.DeathStatus && this.HardnessModeId == other.HardnessModeId && this.partLifeInfos_.Equals(other.partLifeInfos_) && this.visionSkillInfos_.Equals(other.visionSkillInfos_) && this.fightBuffInfos_.Equals(other.fightBuffInfos_) && this.CreatureGroup == other.CreatureGroup && object.Equals(this.ListenInformation, other.ListenInformation) && this.sysBuffInfos_.Equals(other.sysBuffInfos_) && this.LivingStatus == other.LivingStatus && this.entityCommonTags_.Equals(other.entityCommonTags_) && this.WeaponConfId == other.WeaponConfId && this.DurabilityValue == other.DurabilityValue && object.Equals(this.InitLocation, other.InitLocation) && object.Equals(this.SummonInfo, other.SummonInfo) && this.componentPbs_.Equals(other.componentPbs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060063A3 RID: 25507 RVA: 0x000EF7D4 File Offset: 0x000ED9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.EntityType != 0)
			{
				num ^= this.EntityType.GetHashCode();
			}
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.OwnerId != 0L)
			{
				num ^= this.OwnerId.GetHashCode();
			}
			if (this.movementInformation_ != null)
			{
				num ^= this.MovementInformation.GetHashCode();
			}
			num ^= this.gameAttributes_.GetHashCode();
			if (this.InitAttribute)
			{
				num ^= this.InitAttribute.GetHashCode();
			}
			if (this.IsVisible)
			{
				num ^= this.IsVisible.GetHashCode();
			}
			num ^= this.animationStates_.GetHashCode();
			if (this.InitGameplayTag)
			{
				num ^= this.InitGameplayTag.GetHashCode();
			}
			num ^= this.gameplayTags_.GetHashCode();
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			num ^= this.blackboardParams_.GetHashCode();
			num ^= this.tags_.GetHashCode();
			num ^= this.privateTags_.GetHashCode();
			if (this.DeathStatus)
			{
				num ^= this.DeathStatus.GetHashCode();
			}
			if (this.HardnessModeId != 0)
			{
				num ^= this.HardnessModeId.GetHashCode();
			}
			num ^= this.partLifeInfos_.GetHashCode();
			num ^= this.visionSkillInfos_.GetHashCode();
			num ^= this.fightBuffInfos_.GetHashCode();
			if (this.CreatureGroup != 0)
			{
				num ^= this.CreatureGroup.GetHashCode();
			}
			if (this.listenInformation_ != null)
			{
				num ^= this.ListenInformation.GetHashCode();
			}
			num ^= this.sysBuffInfos_.GetHashCode();
			if (this.LivingStatus != LivingStatus.Alive)
			{
				num ^= this.LivingStatus.GetHashCode();
			}
			num ^= this.entityCommonTags_.GetHashCode();
			if (this.WeaponConfId != 0)
			{
				num ^= this.WeaponConfId.GetHashCode();
			}
			if (this.DurabilityValue != 0)
			{
				num ^= this.DurabilityValue.GetHashCode();
			}
			if (this.initLocation_ != null)
			{
				num ^= this.InitLocation.GetHashCode();
			}
			if (this.summonInfo_ != null)
			{
				num ^= this.SummonInfo.GetHashCode();
			}
			num ^= this.componentPbs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060063A4 RID: 25508 RVA: 0x000EFA78 File Offset: 0x000EDC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060063A5 RID: 25509 RVA: 0x000EFA85 File Offset: 0x000EDC85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060063A6 RID: 25510 RVA: 0x000EFA90 File Offset: 0x000EDC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.Id);
			}
			if (this.EntityType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EntityType);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ConfigId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PlayerId);
			}
			if (this.OwnerId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.OwnerId);
			}
			if (this.movementInformation_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.MovementInformation);
			}
			this.gameAttributes_.WriteTo(ref output, DynamicEntityInformation._repeated_gameAttributes_codec);
			if (this.InitAttribute)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.InitAttribute);
			}
			if (this.IsVisible)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsVisible);
			}
			this.animationStates_.WriteTo(ref output, DynamicEntityInformation._repeated_animationStates_codec);
			if (this.InitGameplayTag)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.InitGameplayTag);
			}
			this.gameplayTags_.WriteTo(ref output, DynamicEntityInformation._repeated_gameplayTags_codec);
			if (this.Level != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Level);
			}
			this.blackboardParams_.WriteTo(ref output, DynamicEntityInformation._repeated_blackboardParams_codec);
			this.tags_.WriteTo(ref output, DynamicEntityInformation._repeated_tags_codec);
			this.privateTags_.WriteTo(ref output, DynamicEntityInformation._repeated_privateTags_codec);
			if (this.DeathStatus)
			{
				output.WriteRawTag(136, 1);
				output.WriteBool(this.DeathStatus);
			}
			if (this.HardnessModeId != 0)
			{
				output.WriteRawTag(152, 1);
				output.WriteInt32(this.HardnessModeId);
			}
			this.partLifeInfos_.WriteTo(ref output, DynamicEntityInformation._repeated_partLifeInfos_codec);
			this.visionSkillInfos_.WriteTo(ref output, DynamicEntityInformation._repeated_visionSkillInfos_codec);
			this.fightBuffInfos_.WriteTo(ref output, DynamicEntityInformation._repeated_fightBuffInfos_codec);
			if (this.CreatureGroup != 0)
			{
				output.WriteRawTag(184, 1);
				output.WriteInt32(this.CreatureGroup);
			}
			if (this.listenInformation_ != null)
			{
				output.WriteRawTag(194, 1);
				output.WriteMessage(this.ListenInformation);
			}
			this.sysBuffInfos_.WriteTo(ref output, DynamicEntityInformation._repeated_sysBuffInfos_codec);
			if (this.LivingStatus != LivingStatus.Alive)
			{
				output.WriteRawTag(208, 1);
				output.WriteEnum((int)this.LivingStatus);
			}
			this.entityCommonTags_.WriteTo(ref output, DynamicEntityInformation._repeated_entityCommonTags_codec);
			if (this.WeaponConfId != 0)
			{
				output.WriteRawTag(224, 1);
				output.WriteInt32(this.WeaponConfId);
			}
			if (this.DurabilityValue != 0)
			{
				output.WriteRawTag(232, 1);
				output.WriteInt32(this.DurabilityValue);
			}
			if (this.initLocation_ != null)
			{
				output.WriteRawTag(242, 1);
				output.WriteMessage(this.InitLocation);
			}
			if (this.summonInfo_ != null)
			{
				output.WriteRawTag(250, 1);
				output.WriteMessage(this.SummonInfo);
			}
			this.componentPbs_.WriteTo(ref output, DynamicEntityInformation._repeated_componentPbs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060063A7 RID: 25511 RVA: 0x000EFDB4 File Offset: 0x000EDFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.EntityType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityType);
			}
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.OwnerId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.OwnerId);
			}
			if (this.movementInformation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MovementInformation);
			}
			num += this.gameAttributes_.CalculateSize(DynamicEntityInformation._repeated_gameAttributes_codec);
			if (this.InitAttribute)
			{
				num += 2;
			}
			if (this.IsVisible)
			{
				num += 2;
			}
			num += this.animationStates_.CalculateSize(DynamicEntityInformation._repeated_animationStates_codec);
			if (this.InitGameplayTag)
			{
				num += 2;
			}
			num += this.gameplayTags_.CalculateSize(DynamicEntityInformation._repeated_gameplayTags_codec);
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			num += this.blackboardParams_.CalculateSize(DynamicEntityInformation._repeated_blackboardParams_codec);
			num += this.tags_.CalculateSize(DynamicEntityInformation._repeated_tags_codec);
			num += this.privateTags_.CalculateSize(DynamicEntityInformation._repeated_privateTags_codec);
			if (this.DeathStatus)
			{
				num += 3;
			}
			if (this.HardnessModeId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.HardnessModeId);
			}
			num += this.partLifeInfos_.CalculateSize(DynamicEntityInformation._repeated_partLifeInfos_codec);
			num += this.visionSkillInfos_.CalculateSize(DynamicEntityInformation._repeated_visionSkillInfos_codec);
			num += this.fightBuffInfos_.CalculateSize(DynamicEntityInformation._repeated_fightBuffInfos_codec);
			if (this.CreatureGroup != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.CreatureGroup);
			}
			if (this.listenInformation_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ListenInformation);
			}
			num += this.sysBuffInfos_.CalculateSize(DynamicEntityInformation._repeated_sysBuffInfos_codec);
			if (this.LivingStatus != LivingStatus.Alive)
			{
				num += 2 + CodedOutputStream.ComputeEnumSize((int)this.LivingStatus);
			}
			num += this.entityCommonTags_.CalculateSize(DynamicEntityInformation._repeated_entityCommonTags_codec);
			if (this.WeaponConfId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.WeaponConfId);
			}
			if (this.DurabilityValue != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.DurabilityValue);
			}
			if (this.initLocation_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.InitLocation);
			}
			if (this.summonInfo_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SummonInfo);
			}
			num += this.componentPbs_.CalculateSize(DynamicEntityInformation._repeated_componentPbs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060063A8 RID: 25512 RVA: 0x000F0058 File Offset: 0x000EE258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DynamicEntityInformation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.EntityType != 0)
			{
				this.EntityType = other.EntityType;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.OwnerId != 0L)
			{
				this.OwnerId = other.OwnerId;
			}
			if (other.movementInformation_ != null)
			{
				if (this.movementInformation_ == null)
				{
					this.MovementInformation = new MovementInformation();
				}
				this.MovementInformation.MergeFrom(other.MovementInformation);
			}
			this.gameAttributes_.Add(other.gameAttributes_);
			if (other.InitAttribute)
			{
				this.InitAttribute = other.InitAttribute;
			}
			if (other.IsVisible)
			{
				this.IsVisible = other.IsVisible;
			}
			this.animationStates_.Add(other.animationStates_);
			if (other.InitGameplayTag)
			{
				this.InitGameplayTag = other.InitGameplayTag;
			}
			this.gameplayTags_.Add(other.gameplayTags_);
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this.blackboardParams_.Add(other.blackboardParams_);
			this.tags_.Add(other.tags_);
			this.privateTags_.Add(other.privateTags_);
			if (other.DeathStatus)
			{
				this.DeathStatus = other.DeathStatus;
			}
			if (other.HardnessModeId != 0)
			{
				this.HardnessModeId = other.HardnessModeId;
			}
			this.partLifeInfos_.Add(other.partLifeInfos_);
			this.visionSkillInfos_.Add(other.visionSkillInfos_);
			this.fightBuffInfos_.Add(other.fightBuffInfos_);
			if (other.CreatureGroup != 0)
			{
				this.CreatureGroup = other.CreatureGroup;
			}
			if (other.listenInformation_ != null)
			{
				if (this.listenInformation_ == null)
				{
					this.ListenInformation = new ListenInformation();
				}
				this.ListenInformation.MergeFrom(other.ListenInformation);
			}
			this.sysBuffInfos_.Add(other.sysBuffInfos_);
			if (other.LivingStatus != LivingStatus.Alive)
			{
				this.LivingStatus = other.LivingStatus;
			}
			this.entityCommonTags_.Add(other.entityCommonTags_);
			if (other.WeaponConfId != 0)
			{
				this.WeaponConfId = other.WeaponConfId;
			}
			if (other.DurabilityValue != 0)
			{
				this.DurabilityValue = other.DurabilityValue;
			}
			if (other.initLocation_ != null)
			{
				if (this.initLocation_ == null)
				{
					this.InitLocation = new Vector();
				}
				this.InitLocation.MergeFrom(other.InitLocation);
			}
			if (other.summonInfo_ != null)
			{
				if (this.summonInfo_ == null)
				{
					this.SummonInfo = new SummonInfo();
				}
				this.SummonInfo.MergeFrom(other.SummonInfo);
			}
			this.componentPbs_.Add(other.componentPbs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060063A9 RID: 25513 RVA: 0x000F0328 File Offset: 0x000EE528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060063AA RID: 25514 RVA: 0x000F0334 File Offset: 0x000EE534
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
				if (num <= 122U)
				{
					if (num <= 64U)
					{
						if (num <= 32U)
						{
							if (num <= 16U)
							{
								if (num == 8U)
								{
									this.Id = input.ReadInt64();
									continue;
								}
								if (num == 16U)
								{
									this.EntityType = input.ReadInt32();
									continue;
								}
							}
							else
							{
								if (num == 24U)
								{
									this.ConfigId = input.ReadInt32();
									continue;
								}
								if (num == 32U)
								{
									this.PlayerId = input.ReadInt32();
									continue;
								}
							}
						}
						else if (num <= 50U)
						{
							if (num == 40U)
							{
								this.OwnerId = input.ReadInt64();
								continue;
							}
							if (num == 50U)
							{
								if (this.movementInformation_ == null)
								{
									this.MovementInformation = new MovementInformation();
								}
								input.ReadMessage(this.MovementInformation);
								continue;
							}
						}
						else
						{
							if (num == 58U)
							{
								this.gameAttributes_.AddEntriesFrom(ref input, DynamicEntityInformation._repeated_gameAttributes_codec);
								continue;
							}
							if (num == 64U)
							{
								this.InitAttribute = input.ReadBool();
								continue;
							}
						}
					}
					else
					{
						if (num <= 88U)
						{
							if (num <= 80U)
							{
								if (num == 72U)
								{
									this.IsVisible = input.ReadBool();
									continue;
								}
								if (num != 80U)
								{
									goto IL_1EE;
								}
							}
							else if (num != 82U)
							{
								if (num != 88U)
								{
									goto IL_1EE;
								}
								this.InitGameplayTag = input.ReadBool();
								continue;
							}
							this.animationStates_.AddEntriesFrom(ref input, DynamicEntityInformation._repeated_animationStates_codec);
							continue;
						}
						if (num <= 104U)
						{
							if (num == 98U)
							{
								this.gameplayTags_.AddEntriesFrom(ref input, DynamicEntityInformation._repeated_gameplayTags_codec);
								continue;
							}
							if (num == 104U)
							{
								this.Level = input.ReadInt32();
								continue;
							}
						}
						else
						{
							if (num == 114U)
							{
								this.blackboardParams_.AddEntriesFrom(ref input, DynamicEntityInformation._repeated_blackboardParams_codec);
								continue;
							}
							if (num == 122U)
							{
								this.tags_.AddEntriesFrom(ref input, DynamicEntityInformation._repeated_tags_codec);
								continue;
							}
						}
					}
				}
				else if (num <= 194U)
				{
					if (num <= 162U)
					{
						if (num <= 136U)
						{
							if (num == 130U)
							{
								this.privateTags_.AddEntriesFrom(ref input, DynamicEntityInformation._repeated_privateTags_codec);
								continue;
							}
							if (num == 136U)
							{
								this.DeathStatus = input.ReadBool();
								continue;
							}
						}
						else
						{
							if (num == 152U)
							{
								this.HardnessModeId = input.ReadInt32();
								continue;
							}
							if (num == 162U)
							{
								this.partLifeInfos_.AddEntriesFrom(ref input, DynamicEntityInformation._repeated_partLifeInfos_codec);
								continue;
							}
						}
					}
					else if (num <= 178U)
					{
						if (num == 170U)
						{
							this.visionSkillInfos_.AddEntriesFrom(ref input, DynamicEntityInformation._repeated_visionSkillInfos_codec);
							continue;
						}
						if (num == 178U)
						{
							this.fightBuffInfos_.AddEntriesFrom(ref input, DynamicEntityInformation._repeated_fightBuffInfos_codec);
							continue;
						}
					}
					else
					{
						if (num == 184U)
						{
							this.CreatureGroup = input.ReadInt32();
							continue;
						}
						if (num == 194U)
						{
							if (this.listenInformation_ == null)
							{
								this.ListenInformation = new ListenInformation();
							}
							input.ReadMessage(this.ListenInformation);
							continue;
						}
					}
				}
				else if (num <= 218U)
				{
					if (num <= 208U)
					{
						if (num == 202U)
						{
							this.sysBuffInfos_.AddEntriesFrom(ref input, DynamicEntityInformation._repeated_sysBuffInfos_codec);
							continue;
						}
						if (num == 208U)
						{
							this.LivingStatus = (LivingStatus)input.ReadEnum();
							continue;
						}
					}
					else if (num == 216U || num == 218U)
					{
						this.entityCommonTags_.AddEntriesFrom(ref input, DynamicEntityInformation._repeated_entityCommonTags_codec);
						continue;
					}
				}
				else if (num <= 232U)
				{
					if (num == 224U)
					{
						this.WeaponConfId = input.ReadInt32();
						continue;
					}
					if (num == 232U)
					{
						this.DurabilityValue = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 242U)
					{
						if (this.initLocation_ == null)
						{
							this.InitLocation = new Vector();
						}
						input.ReadMessage(this.InitLocation);
						continue;
					}
					if (num == 250U)
					{
						if (this.summonInfo_ == null)
						{
							this.SummonInfo = new SummonInfo();
						}
						input.ReadMessage(this.SummonInfo);
						continue;
					}
					if (num == 258U)
					{
						this.componentPbs_.AddEntriesFrom(ref input, DynamicEntityInformation._repeated_componentPbs_codec);
						continue;
					}
				}
				IL_1EE:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400386B RID: 14443
		private static readonly MessageParser<DynamicEntityInformation> _parser = new MessageParser<DynamicEntityInformation>(() => new DynamicEntityInformation());

		// Token: 0x0400386C RID: 14444
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400386D RID: 14445
		public const int IdFieldNumber = 1;

		// Token: 0x0400386E RID: 14446
		private long id_;

		// Token: 0x0400386F RID: 14447
		public const int EntityTypeFieldNumber = 2;

		// Token: 0x04003870 RID: 14448
		private int entityType_;

		// Token: 0x04003871 RID: 14449
		public const int ConfigIdFieldNumber = 3;

		// Token: 0x04003872 RID: 14450
		private int configId_;

		// Token: 0x04003873 RID: 14451
		public const int PlayerIdFieldNumber = 4;

		// Token: 0x04003874 RID: 14452
		private int playerId_;

		// Token: 0x04003875 RID: 14453
		public const int OwnerIdFieldNumber = 5;

		// Token: 0x04003876 RID: 14454
		private long ownerId_;

		// Token: 0x04003877 RID: 14455
		public const int MovementInformationFieldNumber = 6;

		// Token: 0x04003878 RID: 14456
		private MovementInformation movementInformation_;

		// Token: 0x04003879 RID: 14457
		public const int GameAttributesFieldNumber = 7;

		// Token: 0x0400387A RID: 14458
		private static readonly FieldCodec<GameplayAttributeData> _repeated_gameAttributes_codec = FieldCodec.ForMessage<GameplayAttributeData>(58U, GameplayAttributeData.Parser);

		// Token: 0x0400387B RID: 14459
		private readonly RepeatedField<GameplayAttributeData> gameAttributes_ = new RepeatedField<GameplayAttributeData>();

		// Token: 0x0400387C RID: 14460
		public const int InitAttributeFieldNumber = 8;

		// Token: 0x0400387D RID: 14461
		private bool initAttribute_;

		// Token: 0x0400387E RID: 14462
		public const int IsVisibleFieldNumber = 9;

		// Token: 0x0400387F RID: 14463
		private bool isVisible_;

		// Token: 0x04003880 RID: 14464
		public const int AnimationStatesFieldNumber = 10;

		// Token: 0x04003881 RID: 14465
		private static readonly FieldCodec<int> _repeated_animationStates_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04003882 RID: 14466
		private readonly RepeatedField<int> animationStates_ = new RepeatedField<int>();

		// Token: 0x04003883 RID: 14467
		public const int InitGameplayTagFieldNumber = 11;

		// Token: 0x04003884 RID: 14468
		private bool initGameplayTag_;

		// Token: 0x04003885 RID: 14469
		public const int GameplayTagsFieldNumber = 12;

		// Token: 0x04003886 RID: 14470
		private static readonly FieldCodec<GameplayTagData> _repeated_gameplayTags_codec = FieldCodec.ForMessage<GameplayTagData>(98U, GameplayTagData.Parser);

		// Token: 0x04003887 RID: 14471
		private readonly RepeatedField<GameplayTagData> gameplayTags_ = new RepeatedField<GameplayTagData>();

		// Token: 0x04003888 RID: 14472
		public const int LevelFieldNumber = 13;

		// Token: 0x04003889 RID: 14473
		private int level_;

		// Token: 0x0400388A RID: 14474
		public const int BlackboardParamsFieldNumber = 14;

		// Token: 0x0400388B RID: 14475
		private static readonly FieldCodec<BlackboardParam> _repeated_blackboardParams_codec = FieldCodec.ForMessage<BlackboardParam>(114U, BlackboardParam.Parser);

		// Token: 0x0400388C RID: 14476
		private readonly RepeatedField<BlackboardParam> blackboardParams_ = new RepeatedField<BlackboardParam>();

		// Token: 0x0400388D RID: 14477
		public const int TagsFieldNumber = 15;

		// Token: 0x0400388E RID: 14478
		private static readonly FieldCodec<string> _repeated_tags_codec = FieldCodec.ForString(122U);

		// Token: 0x0400388F RID: 14479
		private readonly RepeatedField<string> tags_ = new RepeatedField<string>();

		// Token: 0x04003890 RID: 14480
		public const int PrivateTagsFieldNumber = 16;

		// Token: 0x04003891 RID: 14481
		private static readonly FieldCodec<PrivateTag> _repeated_privateTags_codec = FieldCodec.ForMessage<PrivateTag>(130U, PrivateTag.Parser);

		// Token: 0x04003892 RID: 14482
		private readonly RepeatedField<PrivateTag> privateTags_ = new RepeatedField<PrivateTag>();

		// Token: 0x04003893 RID: 14483
		public const int DeathStatusFieldNumber = 17;

		// Token: 0x04003894 RID: 14484
		private bool deathStatus_;

		// Token: 0x04003895 RID: 14485
		public const int HardnessModeIdFieldNumber = 19;

		// Token: 0x04003896 RID: 14486
		private int hardnessModeId_;

		// Token: 0x04003897 RID: 14487
		public const int PartLifeInfosFieldNumber = 20;

		// Token: 0x04003898 RID: 14488
		private static readonly FieldCodec<PartInformation> _repeated_partLifeInfos_codec = FieldCodec.ForMessage<PartInformation>(162U, PartInformation.Parser);

		// Token: 0x04003899 RID: 14489
		private readonly RepeatedField<PartInformation> partLifeInfos_ = new RepeatedField<PartInformation>();

		// Token: 0x0400389A RID: 14490
		public const int VisionSkillInfosFieldNumber = 21;

		// Token: 0x0400389B RID: 14491
		private static readonly FieldCodec<VisionSkillInformation> _repeated_visionSkillInfos_codec = FieldCodec.ForMessage<VisionSkillInformation>(170U, VisionSkillInformation.Parser);

		// Token: 0x0400389C RID: 14492
		private readonly RepeatedField<VisionSkillInformation> visionSkillInfos_ = new RepeatedField<VisionSkillInformation>();

		// Token: 0x0400389D RID: 14493
		public const int FightBuffInfosFieldNumber = 22;

		// Token: 0x0400389E RID: 14494
		private static readonly FieldCodec<FightBuffInformation> _repeated_fightBuffInfos_codec = FieldCodec.ForMessage<FightBuffInformation>(178U, FightBuffInformation.Parser);

		// Token: 0x0400389F RID: 14495
		private readonly RepeatedField<FightBuffInformation> fightBuffInfos_ = new RepeatedField<FightBuffInformation>();

		// Token: 0x040038A0 RID: 14496
		public const int CreatureGroupFieldNumber = 23;

		// Token: 0x040038A1 RID: 14497
		private int creatureGroup_;

		// Token: 0x040038A2 RID: 14498
		public const int ListenInformationFieldNumber = 24;

		// Token: 0x040038A3 RID: 14499
		private ListenInformation listenInformation_;

		// Token: 0x040038A4 RID: 14500
		public const int SysBuffInfosFieldNumber = 25;

		// Token: 0x040038A5 RID: 14501
		private static readonly FieldCodec<SysBuffInformation> _repeated_sysBuffInfos_codec = FieldCodec.ForMessage<SysBuffInformation>(202U, SysBuffInformation.Parser);

		// Token: 0x040038A6 RID: 14502
		private readonly RepeatedField<SysBuffInformation> sysBuffInfos_ = new RepeatedField<SysBuffInformation>();

		// Token: 0x040038A7 RID: 14503
		public const int LivingStatusFieldNumber = 26;

		// Token: 0x040038A8 RID: 14504
		private LivingStatus livingStatus_;

		// Token: 0x040038A9 RID: 14505
		public const int EntityCommonTagsFieldNumber = 27;

		// Token: 0x040038AA RID: 14506
		private static readonly FieldCodec<int> _repeated_entityCommonTags_codec = FieldCodec.ForInt32(218U);

		// Token: 0x040038AB RID: 14507
		private readonly RepeatedField<int> entityCommonTags_ = new RepeatedField<int>();

		// Token: 0x040038AC RID: 14508
		public const int WeaponConfIdFieldNumber = 28;

		// Token: 0x040038AD RID: 14509
		private int weaponConfId_;

		// Token: 0x040038AE RID: 14510
		public const int DurabilityValueFieldNumber = 29;

		// Token: 0x040038AF RID: 14511
		private int durabilityValue_;

		// Token: 0x040038B0 RID: 14512
		public const int InitLocationFieldNumber = 30;

		// Token: 0x040038B1 RID: 14513
		private Vector initLocation_;

		// Token: 0x040038B2 RID: 14514
		public const int SummonInfoFieldNumber = 31;

		// Token: 0x040038B3 RID: 14515
		private SummonInfo summonInfo_;

		// Token: 0x040038B4 RID: 14516
		public const int ComponentPbsFieldNumber = 32;

		// Token: 0x040038B5 RID: 14517
		private static readonly FieldCodec<EntityComponentPb> _repeated_componentPbs_codec = FieldCodec.ForMessage<EntityComponentPb>(258U, EntityComponentPb.Parser);

		// Token: 0x040038B6 RID: 14518
		private readonly RepeatedField<EntityComponentPb> componentPbs_ = new RepeatedField<EntityComponentPb>();
	}
}
