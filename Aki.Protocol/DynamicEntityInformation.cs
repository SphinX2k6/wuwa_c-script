using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200041B RID: 1051
	public sealed class DynamicEntityInformation : IMessage<DynamicEntityInformation>, IMessage, IEquatable<DynamicEntityInformation>, IDeepCloneable<DynamicEntityInformation>, IBufferMessage
	{
		// Token: 0x060064F8 RID: 25848 RVA: 0x000F225C File Offset: 0x000F045C
		[NullableContext(1)]
		public static DynamicEntityInformation Create()
		{
			return new DynamicEntityInformation();
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x060064F9 RID: 25849 RVA: 0x000F2263 File Offset: 0x000F0463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DynamicEntityInformation> Parser
		{
			get
			{
				return DynamicEntityInformation._parser;
			}
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x060064FA RID: 25850 RVA: 0x000F226A File Offset: 0x000F046A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x060064FB RID: 25851 RVA: 0x000F226D File Offset: 0x000F046D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DynamicEntityInformation.Descriptor;
			}
		}

		// Token: 0x060064FC RID: 25852 RVA: 0x000F2274 File Offset: 0x000F0474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicEntityInformation()
		{
		}

		// Token: 0x060064FD RID: 25853 RVA: 0x000F230C File Offset: 0x000F050C
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

		// Token: 0x060064FE RID: 25854 RVA: 0x000F2520 File Offset: 0x000F0720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicEntityInformation Clone()
		{
			return new DynamicEntityInformation(this);
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x060064FF RID: 25855 RVA: 0x000F2528 File Offset: 0x000F0728
		// (set) Token: 0x06006500 RID: 25856 RVA: 0x000F2530 File Offset: 0x000F0730
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

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x06006501 RID: 25857 RVA: 0x000F2539 File Offset: 0x000F0739
		// (set) Token: 0x06006502 RID: 25858 RVA: 0x000F2541 File Offset: 0x000F0741
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

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x06006503 RID: 25859 RVA: 0x000F254A File Offset: 0x000F074A
		// (set) Token: 0x06006504 RID: 25860 RVA: 0x000F2552 File Offset: 0x000F0752
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

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x06006505 RID: 25861 RVA: 0x000F255B File Offset: 0x000F075B
		// (set) Token: 0x06006506 RID: 25862 RVA: 0x000F2563 File Offset: 0x000F0763
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

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x06006507 RID: 25863 RVA: 0x000F256C File Offset: 0x000F076C
		// (set) Token: 0x06006508 RID: 25864 RVA: 0x000F2574 File Offset: 0x000F0774
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

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x06006509 RID: 25865 RVA: 0x000F257D File Offset: 0x000F077D
		// (set) Token: 0x0600650A RID: 25866 RVA: 0x000F2585 File Offset: 0x000F0785
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

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x0600650B RID: 25867 RVA: 0x000F258E File Offset: 0x000F078E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> GameAttributes
		{
			get
			{
				return this.gameAttributes_;
			}
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x0600650C RID: 25868 RVA: 0x000F2596 File Offset: 0x000F0796
		// (set) Token: 0x0600650D RID: 25869 RVA: 0x000F259E File Offset: 0x000F079E
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

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x0600650E RID: 25870 RVA: 0x000F25A7 File Offset: 0x000F07A7
		// (set) Token: 0x0600650F RID: 25871 RVA: 0x000F25AF File Offset: 0x000F07AF
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

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x06006510 RID: 25872 RVA: 0x000F25B8 File Offset: 0x000F07B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AnimationStates
		{
			get
			{
				return this.animationStates_;
			}
		}

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x06006511 RID: 25873 RVA: 0x000F25C0 File Offset: 0x000F07C0
		// (set) Token: 0x06006512 RID: 25874 RVA: 0x000F25C8 File Offset: 0x000F07C8
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

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x06006513 RID: 25875 RVA: 0x000F25D1 File Offset: 0x000F07D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayTagData> GameplayTags
		{
			get
			{
				return this.gameplayTags_;
			}
		}

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x06006514 RID: 25876 RVA: 0x000F25D9 File Offset: 0x000F07D9
		// (set) Token: 0x06006515 RID: 25877 RVA: 0x000F25E1 File Offset: 0x000F07E1
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

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x06006516 RID: 25878 RVA: 0x000F25EA File Offset: 0x000F07EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackboardParam> BlackboardParams
		{
			get
			{
				return this.blackboardParams_;
			}
		}

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x06006517 RID: 25879 RVA: 0x000F25F2 File Offset: 0x000F07F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Tags
		{
			get
			{
				return this.tags_;
			}
		}

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x06006518 RID: 25880 RVA: 0x000F25FA File Offset: 0x000F07FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PrivateTag> PrivateTags
		{
			get
			{
				return this.privateTags_;
			}
		}

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x06006519 RID: 25881 RVA: 0x000F2602 File Offset: 0x000F0802
		// (set) Token: 0x0600651A RID: 25882 RVA: 0x000F260A File Offset: 0x000F080A
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

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x0600651B RID: 25883 RVA: 0x000F2613 File Offset: 0x000F0813
		// (set) Token: 0x0600651C RID: 25884 RVA: 0x000F261B File Offset: 0x000F081B
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

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x0600651D RID: 25885 RVA: 0x000F2624 File Offset: 0x000F0824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PartInformation> PartLifeInfos
		{
			get
			{
				return this.partLifeInfos_;
			}
		}

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x0600651E RID: 25886 RVA: 0x000F262C File Offset: 0x000F082C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<VisionSkillInformation> VisionSkillInfos
		{
			get
			{
				return this.visionSkillInfos_;
			}
		}

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x0600651F RID: 25887 RVA: 0x000F2634 File Offset: 0x000F0834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightBuffInformation> FightBuffInfos
		{
			get
			{
				return this.fightBuffInfos_;
			}
		}

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x06006520 RID: 25888 RVA: 0x000F263C File Offset: 0x000F083C
		// (set) Token: 0x06006521 RID: 25889 RVA: 0x000F2644 File Offset: 0x000F0844
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

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x06006522 RID: 25890 RVA: 0x000F264D File Offset: 0x000F084D
		// (set) Token: 0x06006523 RID: 25891 RVA: 0x000F2655 File Offset: 0x000F0855
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

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x06006524 RID: 25892 RVA: 0x000F265E File Offset: 0x000F085E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SysBuffInformation> SysBuffInfos
		{
			get
			{
				return this.sysBuffInfos_;
			}
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x06006525 RID: 25893 RVA: 0x000F2666 File Offset: 0x000F0866
		// (set) Token: 0x06006526 RID: 25894 RVA: 0x000F266E File Offset: 0x000F086E
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

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x06006527 RID: 25895 RVA: 0x000F2677 File Offset: 0x000F0877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EntityCommonTags
		{
			get
			{
				return this.entityCommonTags_;
			}
		}

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x06006528 RID: 25896 RVA: 0x000F267F File Offset: 0x000F087F
		// (set) Token: 0x06006529 RID: 25897 RVA: 0x000F2687 File Offset: 0x000F0887
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

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x0600652A RID: 25898 RVA: 0x000F2690 File Offset: 0x000F0890
		// (set) Token: 0x0600652B RID: 25899 RVA: 0x000F2698 File Offset: 0x000F0898
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

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x0600652C RID: 25900 RVA: 0x000F26A1 File Offset: 0x000F08A1
		// (set) Token: 0x0600652D RID: 25901 RVA: 0x000F26A9 File Offset: 0x000F08A9
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

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x0600652E RID: 25902 RVA: 0x000F26B2 File Offset: 0x000F08B2
		// (set) Token: 0x0600652F RID: 25903 RVA: 0x000F26BA File Offset: 0x000F08BA
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

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x06006530 RID: 25904 RVA: 0x000F26C3 File Offset: 0x000F08C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityComponentPb> ComponentPbs
		{
			get
			{
				return this.componentPbs_;
			}
		}

		// Token: 0x06006531 RID: 25905 RVA: 0x000F26CB File Offset: 0x000F08CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DynamicEntityInformation);
		}

		// Token: 0x06006532 RID: 25906 RVA: 0x000F26DC File Offset: 0x000F08DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DynamicEntityInformation other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.EntityType == other.EntityType && this.ConfigId == other.ConfigId && this.PlayerId == other.PlayerId && this.OwnerId == other.OwnerId && object.Equals(this.MovementInformation, other.MovementInformation) && this.gameAttributes_.Equals(other.gameAttributes_) && this.InitAttribute == other.InitAttribute && this.IsVisible == other.IsVisible && this.animationStates_.Equals(other.animationStates_) && this.InitGameplayTag == other.InitGameplayTag && this.gameplayTags_.Equals(other.gameplayTags_) && this.Level == other.Level && this.blackboardParams_.Equals(other.blackboardParams_) && this.tags_.Equals(other.tags_) && this.privateTags_.Equals(other.privateTags_) && this.DeathStatus == other.DeathStatus && this.HardnessModeId == other.HardnessModeId && this.partLifeInfos_.Equals(other.partLifeInfos_) && this.visionSkillInfos_.Equals(other.visionSkillInfos_) && this.fightBuffInfos_.Equals(other.fightBuffInfos_) && this.CreatureGroup == other.CreatureGroup && object.Equals(this.ListenInformation, other.ListenInformation) && this.sysBuffInfos_.Equals(other.sysBuffInfos_) && this.LivingStatus == other.LivingStatus && this.entityCommonTags_.Equals(other.entityCommonTags_) && this.WeaponConfId == other.WeaponConfId && this.DurabilityValue == other.DurabilityValue && object.Equals(this.InitLocation, other.InitLocation) && object.Equals(this.SummonInfo, other.SummonInfo) && this.componentPbs_.Equals(other.componentPbs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006533 RID: 25907 RVA: 0x000F2948 File Offset: 0x000F0B48
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

		// Token: 0x06006534 RID: 25908 RVA: 0x000F2BEC File Offset: 0x000F0DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006535 RID: 25909 RVA: 0x000F2BF9 File Offset: 0x000F0DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006536 RID: 25910 RVA: 0x000F2C04 File Offset: 0x000F0E04
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

		// Token: 0x06006537 RID: 25911 RVA: 0x000F2F28 File Offset: 0x000F1128
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

		// Token: 0x06006538 RID: 25912 RVA: 0x000F31CC File Offset: 0x000F13CC
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

		// Token: 0x06006539 RID: 25913 RVA: 0x000F349C File Offset: 0x000F169C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600653A RID: 25914 RVA: 0x000F34A8 File Offset: 0x000F16A8
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

		// Token: 0x0400387E RID: 14462
		private static readonly MessageParser<DynamicEntityInformation> _parser = new MessageParser<DynamicEntityInformation>(() => new DynamicEntityInformation());

		// Token: 0x0400387F RID: 14463
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003880 RID: 14464
		public const int IdFieldNumber = 1;

		// Token: 0x04003881 RID: 14465
		private long id_;

		// Token: 0x04003882 RID: 14466
		public const int EntityTypeFieldNumber = 2;

		// Token: 0x04003883 RID: 14467
		private int entityType_;

		// Token: 0x04003884 RID: 14468
		public const int ConfigIdFieldNumber = 3;

		// Token: 0x04003885 RID: 14469
		private int configId_;

		// Token: 0x04003886 RID: 14470
		public const int PlayerIdFieldNumber = 4;

		// Token: 0x04003887 RID: 14471
		private int playerId_;

		// Token: 0x04003888 RID: 14472
		public const int OwnerIdFieldNumber = 5;

		// Token: 0x04003889 RID: 14473
		private long ownerId_;

		// Token: 0x0400388A RID: 14474
		public const int MovementInformationFieldNumber = 6;

		// Token: 0x0400388B RID: 14475
		private MovementInformation movementInformation_;

		// Token: 0x0400388C RID: 14476
		public const int GameAttributesFieldNumber = 7;

		// Token: 0x0400388D RID: 14477
		private static readonly FieldCodec<GameplayAttributeData> _repeated_gameAttributes_codec = FieldCodec.ForMessage<GameplayAttributeData>(58U, GameplayAttributeData.Parser);

		// Token: 0x0400388E RID: 14478
		private readonly RepeatedField<GameplayAttributeData> gameAttributes_ = new RepeatedField<GameplayAttributeData>();

		// Token: 0x0400388F RID: 14479
		public const int InitAttributeFieldNumber = 8;

		// Token: 0x04003890 RID: 14480
		private bool initAttribute_;

		// Token: 0x04003891 RID: 14481
		public const int IsVisibleFieldNumber = 9;

		// Token: 0x04003892 RID: 14482
		private bool isVisible_;

		// Token: 0x04003893 RID: 14483
		public const int AnimationStatesFieldNumber = 10;

		// Token: 0x04003894 RID: 14484
		private static readonly FieldCodec<int> _repeated_animationStates_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04003895 RID: 14485
		private readonly RepeatedField<int> animationStates_ = new RepeatedField<int>();

		// Token: 0x04003896 RID: 14486
		public const int InitGameplayTagFieldNumber = 11;

		// Token: 0x04003897 RID: 14487
		private bool initGameplayTag_;

		// Token: 0x04003898 RID: 14488
		public const int GameplayTagsFieldNumber = 12;

		// Token: 0x04003899 RID: 14489
		private static readonly FieldCodec<GameplayTagData> _repeated_gameplayTags_codec = FieldCodec.ForMessage<GameplayTagData>(98U, GameplayTagData.Parser);

		// Token: 0x0400389A RID: 14490
		private readonly RepeatedField<GameplayTagData> gameplayTags_ = new RepeatedField<GameplayTagData>();

		// Token: 0x0400389B RID: 14491
		public const int LevelFieldNumber = 13;

		// Token: 0x0400389C RID: 14492
		private int level_;

		// Token: 0x0400389D RID: 14493
		public const int BlackboardParamsFieldNumber = 14;

		// Token: 0x0400389E RID: 14494
		private static readonly FieldCodec<BlackboardParam> _repeated_blackboardParams_codec = FieldCodec.ForMessage<BlackboardParam>(114U, BlackboardParam.Parser);

		// Token: 0x0400389F RID: 14495
		private readonly RepeatedField<BlackboardParam> blackboardParams_ = new RepeatedField<BlackboardParam>();

		// Token: 0x040038A0 RID: 14496
		public const int TagsFieldNumber = 15;

		// Token: 0x040038A1 RID: 14497
		private static readonly FieldCodec<string> _repeated_tags_codec = FieldCodec.ForString(122U);

		// Token: 0x040038A2 RID: 14498
		private readonly RepeatedField<string> tags_ = new RepeatedField<string>();

		// Token: 0x040038A3 RID: 14499
		public const int PrivateTagsFieldNumber = 16;

		// Token: 0x040038A4 RID: 14500
		private static readonly FieldCodec<PrivateTag> _repeated_privateTags_codec = FieldCodec.ForMessage<PrivateTag>(130U, PrivateTag.Parser);

		// Token: 0x040038A5 RID: 14501
		private readonly RepeatedField<PrivateTag> privateTags_ = new RepeatedField<PrivateTag>();

		// Token: 0x040038A6 RID: 14502
		public const int DeathStatusFieldNumber = 17;

		// Token: 0x040038A7 RID: 14503
		private bool deathStatus_;

		// Token: 0x040038A8 RID: 14504
		public const int HardnessModeIdFieldNumber = 19;

		// Token: 0x040038A9 RID: 14505
		private int hardnessModeId_;

		// Token: 0x040038AA RID: 14506
		public const int PartLifeInfosFieldNumber = 20;

		// Token: 0x040038AB RID: 14507
		private static readonly FieldCodec<PartInformation> _repeated_partLifeInfos_codec = FieldCodec.ForMessage<PartInformation>(162U, PartInformation.Parser);

		// Token: 0x040038AC RID: 14508
		private readonly RepeatedField<PartInformation> partLifeInfos_ = new RepeatedField<PartInformation>();

		// Token: 0x040038AD RID: 14509
		public const int VisionSkillInfosFieldNumber = 21;

		// Token: 0x040038AE RID: 14510
		private static readonly FieldCodec<VisionSkillInformation> _repeated_visionSkillInfos_codec = FieldCodec.ForMessage<VisionSkillInformation>(170U, VisionSkillInformation.Parser);

		// Token: 0x040038AF RID: 14511
		private readonly RepeatedField<VisionSkillInformation> visionSkillInfos_ = new RepeatedField<VisionSkillInformation>();

		// Token: 0x040038B0 RID: 14512
		public const int FightBuffInfosFieldNumber = 22;

		// Token: 0x040038B1 RID: 14513
		private static readonly FieldCodec<FightBuffInformation> _repeated_fightBuffInfos_codec = FieldCodec.ForMessage<FightBuffInformation>(178U, FightBuffInformation.Parser);

		// Token: 0x040038B2 RID: 14514
		private readonly RepeatedField<FightBuffInformation> fightBuffInfos_ = new RepeatedField<FightBuffInformation>();

		// Token: 0x040038B3 RID: 14515
		public const int CreatureGroupFieldNumber = 23;

		// Token: 0x040038B4 RID: 14516
		private int creatureGroup_;

		// Token: 0x040038B5 RID: 14517
		public const int ListenInformationFieldNumber = 24;

		// Token: 0x040038B6 RID: 14518
		private ListenInformation listenInformation_;

		// Token: 0x040038B7 RID: 14519
		public const int SysBuffInfosFieldNumber = 25;

		// Token: 0x040038B8 RID: 14520
		private static readonly FieldCodec<SysBuffInformation> _repeated_sysBuffInfos_codec = FieldCodec.ForMessage<SysBuffInformation>(202U, SysBuffInformation.Parser);

		// Token: 0x040038B9 RID: 14521
		private readonly RepeatedField<SysBuffInformation> sysBuffInfos_ = new RepeatedField<SysBuffInformation>();

		// Token: 0x040038BA RID: 14522
		public const int LivingStatusFieldNumber = 26;

		// Token: 0x040038BB RID: 14523
		private LivingStatus livingStatus_;

		// Token: 0x040038BC RID: 14524
		public const int EntityCommonTagsFieldNumber = 27;

		// Token: 0x040038BD RID: 14525
		private static readonly FieldCodec<int> _repeated_entityCommonTags_codec = FieldCodec.ForInt32(218U);

		// Token: 0x040038BE RID: 14526
		private readonly RepeatedField<int> entityCommonTags_ = new RepeatedField<int>();

		// Token: 0x040038BF RID: 14527
		public const int WeaponConfIdFieldNumber = 28;

		// Token: 0x040038C0 RID: 14528
		private int weaponConfId_;

		// Token: 0x040038C1 RID: 14529
		public const int DurabilityValueFieldNumber = 29;

		// Token: 0x040038C2 RID: 14530
		private int durabilityValue_;

		// Token: 0x040038C3 RID: 14531
		public const int InitLocationFieldNumber = 30;

		// Token: 0x040038C4 RID: 14532
		private Vector initLocation_;

		// Token: 0x040038C5 RID: 14533
		public const int SummonInfoFieldNumber = 31;

		// Token: 0x040038C6 RID: 14534
		private SummonInfo summonInfo_;

		// Token: 0x040038C7 RID: 14535
		public const int ComponentPbsFieldNumber = 32;

		// Token: 0x040038C8 RID: 14536
		private static readonly FieldCodec<EntityComponentPb> _repeated_componentPbs_codec = FieldCodec.ForMessage<EntityComponentPb>(258U, EntityComponentPb.Parser);

		// Token: 0x040038C9 RID: 14537
		private readonly RepeatedField<EntityComponentPb> componentPbs_ = new RepeatedField<EntityComponentPb>();
	}
}
