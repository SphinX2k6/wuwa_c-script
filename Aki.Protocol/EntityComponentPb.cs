using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Protocol.Summon;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000468 RID: 1128
	public sealed class EntityComponentPb : IMessage<EntityComponentPb>, IMessage, IEquatable<EntityComponentPb>, IDeepCloneable<EntityComponentPb>, IBufferMessage
	{
		// Token: 0x06006BF8 RID: 27640 RVA: 0x001051C0 File Offset: 0x001033C0
		[NullableContext(1)]
		public static EntityComponentPb Create()
		{
			return new EntityComponentPb();
		}

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x06006BF9 RID: 27641 RVA: 0x001051C7 File Offset: 0x001033C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityComponentPb> Parser
		{
			get
			{
				return EntityComponentPb._parser;
			}
		}

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x06006BFA RID: 27642 RVA: 0x001051CE File Offset: 0x001033CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x06006BFB RID: 27643 RVA: 0x001051D1 File Offset: 0x001033D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityComponentPb.Descriptor;
			}
		}

		// Token: 0x06006BFC RID: 27644 RVA: 0x001051D8 File Offset: 0x001033D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityComponentPb()
		{
		}

		// Token: 0x06006BFD RID: 27645 RVA: 0x001051E0 File Offset: 0x001033E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityComponentPb(EntityComponentPb other) : this()
		{
			switch (other.ComponentCase)
			{
			case EntityComponentPb.ComponentOneofCase.AttributeComponent:
				this.AttributeComponent = other.AttributeComponent.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.TagComponent:
				this.TagComponent = other.TagComponent.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.TriggerComponent:
				this.TriggerComponent = other.TriggerComponent.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.SummonerComponent:
				this.SummonerComponent = other.SummonerComponent.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.PartComponent:
				this.PartComponent = other.PartComponent.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.VisionSkillComponent:
				this.VisionSkillComponent = other.VisionSkillComponent.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.AnimationStateComponent:
				this.AnimationStateComponent = other.AnimationStateComponent.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.BlackboardParamComponent:
				this.BlackboardParamComponent = other.BlackboardParamComponent.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.SysBuffComponent:
				this.SysBuffComponent = other.SysBuffComponent.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.ClientDataComponent:
				this.ClientDataComponent = other.ClientDataComponent.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.MonsterWeaponComponentPb:
				this.MonsterWeaponComponentPb = other.MonsterWeaponComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.MonsterAiComponentPb:
				this.MonsterAiComponentPb = other.MonsterAiComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.FightBuffComponent:
				this.FightBuffComponent = other.FightBuffComponent.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.NearbyTrackingComponentPb:
				this.NearbyTrackingComponentPb = other.NearbyTrackingComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.DropComponentPb:
				this.DropComponentPb = other.DropComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.MonsterCaptureComponent:
				this.MonsterCaptureComponent = other.MonsterCaptureComponent.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.LogicStateComponentPb:
				this.LogicStateComponentPb = other.LogicStateComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.AdviceComponentPb:
				this.AdviceComponentPb = other.AdviceComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.LiftComponentPb:
				this.LiftComponentPb = other.LiftComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.InteractComponent:
				this.InteractComponent = other.InteractComponent.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.EquipComponent:
				this.EquipComponent = other.EquipComponent.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.BeControlledComponentPb:
				this.BeControlledComponentPb = other.BeControlledComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.ConcomitantsComponentPb:
				this.ConcomitantsComponentPb = other.ConcomitantsComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.TimelineTrackComponentPb:
				this.TimelineTrackComponentPb = other.TimelineTrackComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.SummonsComponentPb:
				this.SummonsComponentPb = other.SummonsComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.EntityFsmComponentPb:
				this.EntityFsmComponentPb = other.EntityFsmComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.BoardPb:
				this.BoardPb = other.BoardPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.PlacementItemPb:
				this.PlacementItemPb = other.PlacementItemPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.StateTagComponentPb:
				this.StateTagComponentPb = other.StateTagComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.MonsterGachaDataPb:
				this.MonsterGachaDataPb = other.MonsterGachaDataPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.FanComponentPb:
				this.FanComponentPb = other.FanComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.NpcPb:
				this.NpcPb = other.NpcPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.BubbleComponent:
				this.BubbleComponent = other.BubbleComponent.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.PatrolComponent:
				this.PatrolComponent = other.PatrolComponent.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.RangeComponent:
				this.RangeComponent = other.RangeComponent.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.PassiveSkillComponentPb:
				this.PassiveSkillComponentPb = other.PassiveSkillComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.SkillComponentPb:
				this.SkillComponentPb = other.SkillComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.DynamicAttachComponentPb:
				this.DynamicAttachComponentPb = other.DynamicAttachComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.VarComponentPb:
				this.VarComponentPb = other.VarComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.PlayerFollowerSelfComponentPb:
				this.PlayerFollowerSelfComponentPb = other.PlayerFollowerSelfComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.SceneItemLifeCycleComponentPb:
				this.SceneItemLifeCycleComponentPb = other.SceneItemLifeCycleComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.EntityBulletComponentPb:
				this.EntityBulletComponentPb = other.EntityBulletComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.BuffProducerComponentPb:
				this.BuffProducerComponentPb = other.BuffProducerComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.BuffConsumerComponentPb:
				this.BuffConsumerComponentPb = other.BuffConsumerComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.SceneItemComponentPb:
				this.SceneItemComponentPb = other.SceneItemComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.ShieldComponentPb:
				this.ShieldComponentPb = other.ShieldComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.NpcPerformComponentPb:
				this.NpcPerformComponentPb = other.NpcPerformComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.DependenceComponentPb:
				this.DependenceComponentPb = other.DependenceComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.RenjuDataPb:
				this.RenjuDataPb = other.RenjuDataPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.AiRoleComponentPb:
				this.AiRoleComponentPb = other.AiRoleComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.PlayerFollowersComponentPb:
				this.PlayerFollowersComponentPb = other.PlayerFollowersComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.SceneItemAttributeComponentPb:
				this.SceneItemAttributeComponentPb = other.SceneItemAttributeComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.PullingFoundationComponentPb:
				this.PullingFoundationComponentPb = other.PullingFoundationComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.BatchBulletCastComponentPb:
				this.BatchBulletCastComponentPb = other.BatchBulletCastComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.RoleWeaponSkinComponent:
				this.RoleWeaponSkinComponent = other.RoleWeaponSkinComponent.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.CombineEntityInfoPb:
				this.CombineEntityInfoPb = other.CombineEntityInfoPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.SceneItemAiComponentPb:
				this.SceneItemAiComponentPb = other.SceneItemAiComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.AnimalCollectComponentPb:
				this.AnimalCollectComponentPb = other.AnimalCollectComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.VehiclePassengerComponentPb:
				this.VehiclePassengerComponentPb = other.VehiclePassengerComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.HookLockPointComponentPb:
				this.HookLockPointComponentPb = other.HookLockPointComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.HackingComponentPb:
				this.HackingComponentPb = other.HackingComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.HackTargetComponentPb:
				this.HackTargetComponentPb = other.HackTargetComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.GravityFlipComponentPb:
				this.GravityFlipComponentPb = other.GravityFlipComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.EntityMoveSplineComponentPb:
				this.EntityMoveSplineComponentPb = other.EntityMoveSplineComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.EntityRewardItemPb:
				this.EntityRewardItemPb = other.EntityRewardItemPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.TemplateEntitySpawnerComponentPb:
				this.TemplateEntitySpawnerComponentPb = other.TemplateEntitySpawnerComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.GridObjectComponentPb:
				this.GridObjectComponentPb = other.GridObjectComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.SimpleCombatComponentPb:
				this.SimpleCombatComponentPb = other.SimpleCombatComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.TrapDefenseComponentPb:
				this.TrapDefenseComponentPb = other.TrapDefenseComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.HoldHandComponentPb:
				this.HoldHandComponentPb = other.HoldHandComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.ListenerComponentPb:
				this.ListenerComponentPb = other.ListenerComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.ActivityComponentPb:
				this.ActivityComponentPb = other.ActivityComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.CalabashSkinComponentPb:
				this.CalabashSkinComponentPb = other.CalabashSkinComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.HonamiStoryDropItemComponentPb:
				this.HonamiStoryDropItemComponentPb = other.HonamiStoryDropItemComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.HonamiStoryEnhanceLevelComponentPb:
				this.HonamiStoryEnhanceLevelComponentPb = other.HonamiStoryEnhanceLevelComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.MoveToPointComponentPb:
				this.MoveToPointComponentPb = other.MoveToPointComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.RbBlockComponentPb:
				this.RbBlockComponentPb = other.RbBlockComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.SpiritGearComponentPb:
				this.SpiritGearComponentPb = other.SpiritGearComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.VehiclePb:
				this.VehiclePb = other.VehiclePb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.RbFloorComponentPb:
				this.RbFloorComponentPb = other.RbFloorComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.RbItemComponentPb:
				this.RbItemComponentPb = other.RbItemComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.RoadNetworkComponentPb:
				this.RoadNetworkComponentPb = other.RoadNetworkComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.FollowEntityComponentPb:
				this.FollowEntityComponentPb = other.FollowEntityComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.MotorOutlookComponentPb:
				this.MotorOutlookComponentPb = other.MotorOutlookComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.MotorDaCtxComponentPb:
				this.MotorDaCtxComponentPb = other.MotorDaCtxComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.ExhibitionComponentPb:
				this.ExhibitionComponentPb = other.ExhibitionComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.FurnitureComponentPb:
				this.FurnitureComponentPb = other.FurnitureComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.OrnamentComponentPb:
				this.OrnamentComponentPb = other.OrnamentComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.FlowerPollutionComponentPb:
				this.FlowerPollutionComponentPb = other.FlowerPollutionComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.DollGrabMachineComponentPb:
				this.DollGrabMachineComponentPb = other.DollGrabMachineComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.DollGrabShowcaseComponentPb:
				this.DollGrabShowcaseComponentPb = other.DollGrabShowcaseComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.GpuEntityComponentPb:
				this.GpuEntityComponentPb = other.GpuEntityComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.RoverRoguePortalComponentPb:
				this.RoverRoguePortalComponentPb = other.RoverRoguePortalComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.ElementalHolderComponentPb:
				this.ElementalHolderComponentPb = other.ElementalHolderComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.SkillAvatarComponentPb:
				this.SkillAvatarComponentPb = other.SkillAvatarComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.EntityFoundationComponentPb:
				this.EntityFoundationComponentPb = other.EntityFoundationComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.SquadPropComponentPb:
				this.SquadPropComponentPb = other.SquadPropComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.ConnectorComponentPb:
				this.ConnectorComponentPb = other.ConnectorComponentPb.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006BFE RID: 27646 RVA: 0x00105C09 File Offset: 0x00103E09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityComponentPb Clone()
		{
			return new EntityComponentPb(this);
		}

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x06006BFF RID: 27647 RVA: 0x00105C11 File Offset: 0x00103E11
		// (set) Token: 0x06006C00 RID: 27648 RVA: 0x00105C29 File Offset: 0x00103E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeComponentPb AttributeComponent
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.AttributeComponent)
				{
					return null;
				}
				return (AttributeComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.AttributeComponent);
			}
		}

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x06006C01 RID: 27649 RVA: 0x00105C3F File Offset: 0x00103E3F
		// (set) Token: 0x06006C02 RID: 27650 RVA: 0x00105C57 File Offset: 0x00103E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TagComponentPb TagComponent
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.TagComponent)
				{
					return null;
				}
				return (TagComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.TagComponent);
			}
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x06006C03 RID: 27651 RVA: 0x00105C6D File Offset: 0x00103E6D
		// (set) Token: 0x06006C04 RID: 27652 RVA: 0x00105C85 File Offset: 0x00103E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerComponentPb TriggerComponent
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.TriggerComponent)
				{
					return null;
				}
				return (TriggerComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.TriggerComponent);
			}
		}

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x06006C05 RID: 27653 RVA: 0x00105C9B File Offset: 0x00103E9B
		// (set) Token: 0x06006C06 RID: 27654 RVA: 0x00105CB3 File Offset: 0x00103EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonerComponentPb SummonerComponent
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.SummonerComponent)
				{
					return null;
				}
				return (SummonerComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.SummonerComponent);
			}
		}

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x06006C07 RID: 27655 RVA: 0x00105CC9 File Offset: 0x00103EC9
		// (set) Token: 0x06006C08 RID: 27656 RVA: 0x00105CE1 File Offset: 0x00103EE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentPb PartComponent
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.PartComponent)
				{
					return null;
				}
				return (PartComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.PartComponent);
			}
		}

		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x06006C09 RID: 27657 RVA: 0x00105CF7 File Offset: 0x00103EF7
		// (set) Token: 0x06006C0A RID: 27658 RVA: 0x00105D0F File Offset: 0x00103F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionSkillComponentPb VisionSkillComponent
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.VisionSkillComponent)
				{
					return null;
				}
				return (VisionSkillComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.VisionSkillComponent);
			}
		}

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x06006C0B RID: 27659 RVA: 0x00105D25 File Offset: 0x00103F25
		// (set) Token: 0x06006C0C RID: 27660 RVA: 0x00105D3D File Offset: 0x00103F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateComponentPb AnimationStateComponent
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.AnimationStateComponent)
				{
					return null;
				}
				return (AnimationStateComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.AnimationStateComponent);
			}
		}

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x06006C0D RID: 27661 RVA: 0x00105D53 File Offset: 0x00103F53
		// (set) Token: 0x06006C0E RID: 27662 RVA: 0x00105D6B File Offset: 0x00103F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackboardParamComponentPb BlackboardParamComponent
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.BlackboardParamComponent)
				{
					return null;
				}
				return (BlackboardParamComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.BlackboardParamComponent);
			}
		}

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x06006C0F RID: 27663 RVA: 0x00105D81 File Offset: 0x00103F81
		// (set) Token: 0x06006C10 RID: 27664 RVA: 0x00105D9A File Offset: 0x00103F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysBuffComponentPb SysBuffComponent
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.SysBuffComponent)
				{
					return null;
				}
				return (SysBuffComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.SysBuffComponent);
			}
		}

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x06006C11 RID: 27665 RVA: 0x00105DB1 File Offset: 0x00103FB1
		// (set) Token: 0x06006C12 RID: 27666 RVA: 0x00105DCA File Offset: 0x00103FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientDataComponentPb ClientDataComponent
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.ClientDataComponent)
				{
					return null;
				}
				return (ClientDataComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.ClientDataComponent);
			}
		}

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x06006C13 RID: 27667 RVA: 0x00105DE1 File Offset: 0x00103FE1
		// (set) Token: 0x06006C14 RID: 27668 RVA: 0x00105DFA File Offset: 0x00103FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterWeaponComponentPb MonsterWeaponComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.MonsterWeaponComponentPb)
				{
					return null;
				}
				return (MonsterWeaponComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.MonsterWeaponComponentPb);
			}
		}

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x06006C15 RID: 27669 RVA: 0x00105E11 File Offset: 0x00104011
		// (set) Token: 0x06006C16 RID: 27670 RVA: 0x00105E2A File Offset: 0x0010402A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterAiComponentPb MonsterAiComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.MonsterAiComponentPb)
				{
					return null;
				}
				return (MonsterAiComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.MonsterAiComponentPb);
			}
		}

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x06006C17 RID: 27671 RVA: 0x00105E41 File Offset: 0x00104041
		// (set) Token: 0x06006C18 RID: 27672 RVA: 0x00105E5A File Offset: 0x0010405A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightBuffComponentPb FightBuffComponent
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.FightBuffComponent)
				{
					return null;
				}
				return (FightBuffComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.FightBuffComponent);
			}
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06006C19 RID: 27673 RVA: 0x00105E71 File Offset: 0x00104071
		// (set) Token: 0x06006C1A RID: 27674 RVA: 0x00105E8A File Offset: 0x0010408A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NearbyTrackingComponentPb NearbyTrackingComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.NearbyTrackingComponentPb)
				{
					return null;
				}
				return (NearbyTrackingComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.NearbyTrackingComponentPb);
			}
		}

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x06006C1B RID: 27675 RVA: 0x00105EA1 File Offset: 0x001040A1
		// (set) Token: 0x06006C1C RID: 27676 RVA: 0x00105EBA File Offset: 0x001040BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropComponentPb DropComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.DropComponentPb)
				{
					return null;
				}
				return (DropComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.DropComponentPb);
			}
		}

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x06006C1D RID: 27677 RVA: 0x00105ED1 File Offset: 0x001040D1
		// (set) Token: 0x06006C1E RID: 27678 RVA: 0x00105EEA File Offset: 0x001040EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterCaptureComponentPb MonsterCaptureComponent
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.MonsterCaptureComponent)
				{
					return null;
				}
				return (MonsterCaptureComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.MonsterCaptureComponent);
			}
		}

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x06006C1F RID: 27679 RVA: 0x00105F01 File Offset: 0x00104101
		// (set) Token: 0x06006C20 RID: 27680 RVA: 0x00105F1A File Offset: 0x0010411A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateComponentPb LogicStateComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.LogicStateComponentPb)
				{
					return null;
				}
				return (LogicStateComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.LogicStateComponentPb);
			}
		}

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x06006C21 RID: 27681 RVA: 0x00105F31 File Offset: 0x00104131
		// (set) Token: 0x06006C22 RID: 27682 RVA: 0x00105F4A File Offset: 0x0010414A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceComponentPb AdviceComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.AdviceComponentPb)
				{
					return null;
				}
				return (AdviceComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.AdviceComponentPb);
			}
		}

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x06006C23 RID: 27683 RVA: 0x00105F61 File Offset: 0x00104161
		// (set) Token: 0x06006C24 RID: 27684 RVA: 0x00105F7A File Offset: 0x0010417A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftComponentPb LiftComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.LiftComponentPb)
				{
					return null;
				}
				return (LiftComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.LiftComponentPb);
			}
		}

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x06006C25 RID: 27685 RVA: 0x00105F91 File Offset: 0x00104191
		// (set) Token: 0x06006C26 RID: 27686 RVA: 0x00105FAA File Offset: 0x001041AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractComponentPb InteractComponent
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.InteractComponent)
				{
					return null;
				}
				return (InteractComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.InteractComponent);
			}
		}

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x06006C27 RID: 27687 RVA: 0x00105FC1 File Offset: 0x001041C1
		// (set) Token: 0x06006C28 RID: 27688 RVA: 0x00105FDA File Offset: 0x001041DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipComponentPb EquipComponent
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.EquipComponent)
				{
					return null;
				}
				return (EquipComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.EquipComponent);
			}
		}

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x06006C29 RID: 27689 RVA: 0x00105FF1 File Offset: 0x001041F1
		// (set) Token: 0x06006C2A RID: 27690 RVA: 0x0010600A File Offset: 0x0010420A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledComponentPb BeControlledComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.BeControlledComponentPb)
				{
					return null;
				}
				return (BeControlledComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.BeControlledComponentPb);
			}
		}

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x06006C2B RID: 27691 RVA: 0x00106021 File Offset: 0x00104221
		// (set) Token: 0x06006C2C RID: 27692 RVA: 0x0010603A File Offset: 0x0010423A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConcomitantsComponentPb ConcomitantsComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.ConcomitantsComponentPb)
				{
					return null;
				}
				return (ConcomitantsComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.ConcomitantsComponentPb);
			}
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x06006C2D RID: 27693 RVA: 0x00106051 File Offset: 0x00104251
		// (set) Token: 0x06006C2E RID: 27694 RVA: 0x0010606A File Offset: 0x0010426A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimelineTrackComponentPb TimelineTrackComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.TimelineTrackComponentPb)
				{
					return null;
				}
				return (TimelineTrackComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.TimelineTrackComponentPb);
			}
		}

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x06006C2F RID: 27695 RVA: 0x00106081 File Offset: 0x00104281
		// (set) Token: 0x06006C30 RID: 27696 RVA: 0x0010609A File Offset: 0x0010429A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonsComponentPb SummonsComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.SummonsComponentPb)
				{
					return null;
				}
				return (SummonsComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.SummonsComponentPb);
			}
		}

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x06006C31 RID: 27697 RVA: 0x001060B1 File Offset: 0x001042B1
		// (set) Token: 0x06006C32 RID: 27698 RVA: 0x001060CA File Offset: 0x001042CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFsmComponentPb EntityFsmComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.EntityFsmComponentPb)
				{
					return null;
				}
				return (EntityFsmComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.EntityFsmComponentPb);
			}
		}

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x06006C33 RID: 27699 RVA: 0x001060E1 File Offset: 0x001042E1
		// (set) Token: 0x06006C34 RID: 27700 RVA: 0x001060FA File Offset: 0x001042FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardPb BoardPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.BoardPb)
				{
					return null;
				}
				return (BoardPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.BoardPb);
			}
		}

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x06006C35 RID: 27701 RVA: 0x00106111 File Offset: 0x00104311
		// (set) Token: 0x06006C36 RID: 27702 RVA: 0x0010612A File Offset: 0x0010432A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlacementItemPb PlacementItemPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.PlacementItemPb)
				{
					return null;
				}
				return (PlacementItemPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.PlacementItemPb);
			}
		}

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x06006C37 RID: 27703 RVA: 0x00106141 File Offset: 0x00104341
		// (set) Token: 0x06006C38 RID: 27704 RVA: 0x0010615A File Offset: 0x0010435A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StateTagComponentPb StateTagComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.StateTagComponentPb)
				{
					return null;
				}
				return (StateTagComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.StateTagComponentPb);
			}
		}

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x06006C39 RID: 27705 RVA: 0x00106171 File Offset: 0x00104371
		// (set) Token: 0x06006C3A RID: 27706 RVA: 0x0010618A File Offset: 0x0010438A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterGachaDataPb MonsterGachaDataPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.MonsterGachaDataPb)
				{
					return null;
				}
				return (MonsterGachaDataPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.MonsterGachaDataPb);
			}
		}

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x06006C3B RID: 27707 RVA: 0x001061A1 File Offset: 0x001043A1
		// (set) Token: 0x06006C3C RID: 27708 RVA: 0x001061BA File Offset: 0x001043BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FanComponentPb FanComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.FanComponentPb)
				{
					return null;
				}
				return (FanComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.FanComponentPb);
			}
		}

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x06006C3D RID: 27709 RVA: 0x001061D1 File Offset: 0x001043D1
		// (set) Token: 0x06006C3E RID: 27710 RVA: 0x001061EA File Offset: 0x001043EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPb NpcPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.NpcPb)
				{
					return null;
				}
				return (NpcPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.NpcPb);
			}
		}

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x06006C3F RID: 27711 RVA: 0x00106201 File Offset: 0x00104401
		// (set) Token: 0x06006C40 RID: 27712 RVA: 0x0010621A File Offset: 0x0010441A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BubbleComponentPb BubbleComponent
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.BubbleComponent)
				{
					return null;
				}
				return (BubbleComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.BubbleComponent);
			}
		}

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x06006C41 RID: 27713 RVA: 0x00106231 File Offset: 0x00104431
		// (set) Token: 0x06006C42 RID: 27714 RVA: 0x0010624A File Offset: 0x0010444A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PatrolComponentPb PatrolComponent
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.PatrolComponent)
				{
					return null;
				}
				return (PatrolComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.PatrolComponent);
			}
		}

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x06006C43 RID: 27715 RVA: 0x00106261 File Offset: 0x00104461
		// (set) Token: 0x06006C44 RID: 27716 RVA: 0x0010627A File Offset: 0x0010447A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RangeComponentPb RangeComponent
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.RangeComponent)
				{
					return null;
				}
				return (RangeComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.RangeComponent);
			}
		}

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x06006C45 RID: 27717 RVA: 0x00106291 File Offset: 0x00104491
		// (set) Token: 0x06006C46 RID: 27718 RVA: 0x001062AA File Offset: 0x001044AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillComponentPb PassiveSkillComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.PassiveSkillComponentPb)
				{
					return null;
				}
				return (PassiveSkillComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.PassiveSkillComponentPb);
			}
		}

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x06006C47 RID: 27719 RVA: 0x001062C1 File Offset: 0x001044C1
		// (set) Token: 0x06006C48 RID: 27720 RVA: 0x001062DA File Offset: 0x001044DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillComponentPb SkillComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.SkillComponentPb)
				{
					return null;
				}
				return (SkillComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.SkillComponentPb);
			}
		}

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x06006C49 RID: 27721 RVA: 0x001062F1 File Offset: 0x001044F1
		// (set) Token: 0x06006C4A RID: 27722 RVA: 0x0010630A File Offset: 0x0010450A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DynamicAttachComponentPb DynamicAttachComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.DynamicAttachComponentPb)
				{
					return null;
				}
				return (DynamicAttachComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.DynamicAttachComponentPb);
			}
		}

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x06006C4B RID: 27723 RVA: 0x00106321 File Offset: 0x00104521
		// (set) Token: 0x06006C4C RID: 27724 RVA: 0x0010633A File Offset: 0x0010453A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarComponentPb VarComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.VarComponentPb)
				{
					return null;
				}
				return (VarComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.VarComponentPb);
			}
		}

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x06006C4D RID: 27725 RVA: 0x00106351 File Offset: 0x00104551
		// (set) Token: 0x06006C4E RID: 27726 RVA: 0x0010636A File Offset: 0x0010456A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowerSelfComponentPb PlayerFollowerSelfComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.PlayerFollowerSelfComponentPb)
				{
					return null;
				}
				return (PlayerFollowerSelfComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.PlayerFollowerSelfComponentPb);
			}
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x06006C4F RID: 27727 RVA: 0x00106381 File Offset: 0x00104581
		// (set) Token: 0x06006C50 RID: 27728 RVA: 0x0010639A File Offset: 0x0010459A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemLifeCycleComponentPb SceneItemLifeCycleComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.SceneItemLifeCycleComponentPb)
				{
					return null;
				}
				return (SceneItemLifeCycleComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.SceneItemLifeCycleComponentPb);
			}
		}

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x06006C51 RID: 27729 RVA: 0x001063B1 File Offset: 0x001045B1
		// (set) Token: 0x06006C52 RID: 27730 RVA: 0x001063CA File Offset: 0x001045CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBulletComponentPb EntityBulletComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.EntityBulletComponentPb)
				{
					return null;
				}
				return (EntityBulletComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.EntityBulletComponentPb);
			}
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x06006C53 RID: 27731 RVA: 0x001063E1 File Offset: 0x001045E1
		// (set) Token: 0x06006C54 RID: 27732 RVA: 0x001063FA File Offset: 0x001045FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffProducerComponentPb BuffProducerComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.BuffProducerComponentPb)
				{
					return null;
				}
				return (BuffProducerComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.BuffProducerComponentPb);
			}
		}

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x06006C55 RID: 27733 RVA: 0x00106411 File Offset: 0x00104611
		// (set) Token: 0x06006C56 RID: 27734 RVA: 0x0010642A File Offset: 0x0010462A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffConsumerComponentPb BuffConsumerComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.BuffConsumerComponentPb)
				{
					return null;
				}
				return (BuffConsumerComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.BuffConsumerComponentPb);
			}
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x06006C57 RID: 27735 RVA: 0x00106441 File Offset: 0x00104641
		// (set) Token: 0x06006C58 RID: 27736 RVA: 0x0010645A File Offset: 0x0010465A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemComponentPb SceneItemComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.SceneItemComponentPb)
				{
					return null;
				}
				return (SceneItemComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.SceneItemComponentPb);
			}
		}

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x06006C59 RID: 27737 RVA: 0x00106471 File Offset: 0x00104671
		// (set) Token: 0x06006C5A RID: 27738 RVA: 0x0010648A File Offset: 0x0010468A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldComponentPb ShieldComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.ShieldComponentPb)
				{
					return null;
				}
				return (ShieldComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.ShieldComponentPb);
			}
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x06006C5B RID: 27739 RVA: 0x001064A1 File Offset: 0x001046A1
		// (set) Token: 0x06006C5C RID: 27740 RVA: 0x001064BA File Offset: 0x001046BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPerformComponentPb NpcPerformComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.NpcPerformComponentPb)
				{
					return null;
				}
				return (NpcPerformComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.NpcPerformComponentPb);
			}
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x06006C5D RID: 27741 RVA: 0x001064D1 File Offset: 0x001046D1
		// (set) Token: 0x06006C5E RID: 27742 RVA: 0x001064EA File Offset: 0x001046EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DependenceComponentPb DependenceComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.DependenceComponentPb)
				{
					return null;
				}
				return (DependenceComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.DependenceComponentPb);
			}
		}

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x06006C5F RID: 27743 RVA: 0x00106501 File Offset: 0x00104701
		// (set) Token: 0x06006C60 RID: 27744 RVA: 0x0010651A File Offset: 0x0010471A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuDataPb RenjuDataPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.RenjuDataPb)
				{
					return null;
				}
				return (RenjuDataPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.RenjuDataPb);
			}
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x06006C61 RID: 27745 RVA: 0x00106531 File Offset: 0x00104731
		// (set) Token: 0x06006C62 RID: 27746 RVA: 0x0010654A File Offset: 0x0010474A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiRoleComponentPb AiRoleComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.AiRoleComponentPb)
				{
					return null;
				}
				return (AiRoleComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.AiRoleComponentPb);
			}
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x06006C63 RID: 27747 RVA: 0x00106561 File Offset: 0x00104761
		// (set) Token: 0x06006C64 RID: 27748 RVA: 0x0010657A File Offset: 0x0010477A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowersComponentPb PlayerFollowersComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.PlayerFollowersComponentPb)
				{
					return null;
				}
				return (PlayerFollowersComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.PlayerFollowersComponentPb);
			}
		}

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x06006C65 RID: 27749 RVA: 0x00106591 File Offset: 0x00104791
		// (set) Token: 0x06006C66 RID: 27750 RVA: 0x001065AA File Offset: 0x001047AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAttributeComponentPb SceneItemAttributeComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.SceneItemAttributeComponentPb)
				{
					return null;
				}
				return (SceneItemAttributeComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.SceneItemAttributeComponentPb);
			}
		}

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x06006C67 RID: 27751 RVA: 0x001065C1 File Offset: 0x001047C1
		// (set) Token: 0x06006C68 RID: 27752 RVA: 0x001065DA File Offset: 0x001047DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PullingFoundationComponentPb PullingFoundationComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.PullingFoundationComponentPb)
				{
					return null;
				}
				return (PullingFoundationComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.PullingFoundationComponentPb);
			}
		}

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x06006C69 RID: 27753 RVA: 0x001065F1 File Offset: 0x001047F1
		// (set) Token: 0x06006C6A RID: 27754 RVA: 0x0010660A File Offset: 0x0010480A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchBulletCastComponentPb BatchBulletCastComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.BatchBulletCastComponentPb)
				{
					return null;
				}
				return (BatchBulletCastComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.BatchBulletCastComponentPb);
			}
		}

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x06006C6B RID: 27755 RVA: 0x00106621 File Offset: 0x00104821
		// (set) Token: 0x06006C6C RID: 27756 RVA: 0x0010663A File Offset: 0x0010483A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleWeaponSkinComponentPb RoleWeaponSkinComponent
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.RoleWeaponSkinComponent)
				{
					return null;
				}
				return (RoleWeaponSkinComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.RoleWeaponSkinComponent);
			}
		}

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x06006C6D RID: 27757 RVA: 0x00106651 File Offset: 0x00104851
		// (set) Token: 0x06006C6E RID: 27758 RVA: 0x0010666A File Offset: 0x0010486A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombineEntityInfoPb CombineEntityInfoPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.CombineEntityInfoPb)
				{
					return null;
				}
				return (CombineEntityInfoPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.CombineEntityInfoPb);
			}
		}

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x06006C6F RID: 27759 RVA: 0x00106681 File Offset: 0x00104881
		// (set) Token: 0x06006C70 RID: 27760 RVA: 0x0010669A File Offset: 0x0010489A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiComponentPb SceneItemAiComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.SceneItemAiComponentPb)
				{
					return null;
				}
				return (SceneItemAiComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.SceneItemAiComponentPb);
			}
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x06006C71 RID: 27761 RVA: 0x001066B1 File Offset: 0x001048B1
		// (set) Token: 0x06006C72 RID: 27762 RVA: 0x001066CA File Offset: 0x001048CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalCollectComponentPb AnimalCollectComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.AnimalCollectComponentPb)
				{
					return null;
				}
				return (AnimalCollectComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.AnimalCollectComponentPb);
			}
		}

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x06006C73 RID: 27763 RVA: 0x001066E1 File Offset: 0x001048E1
		// (set) Token: 0x06006C74 RID: 27764 RVA: 0x001066FA File Offset: 0x001048FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePassengerComponentPb VehiclePassengerComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.VehiclePassengerComponentPb)
				{
					return null;
				}
				return (VehiclePassengerComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.VehiclePassengerComponentPb);
			}
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x06006C75 RID: 27765 RVA: 0x00106711 File Offset: 0x00104911
		// (set) Token: 0x06006C76 RID: 27766 RVA: 0x0010672A File Offset: 0x0010492A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointComponentPb HookLockPointComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.HookLockPointComponentPb)
				{
					return null;
				}
				return (HookLockPointComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.HookLockPointComponentPb);
			}
		}

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x06006C77 RID: 27767 RVA: 0x00106741 File Offset: 0x00104941
		// (set) Token: 0x06006C78 RID: 27768 RVA: 0x0010675A File Offset: 0x0010495A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HackingComponentPb HackingComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.HackingComponentPb)
				{
					return null;
				}
				return (HackingComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.HackingComponentPb);
			}
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x06006C79 RID: 27769 RVA: 0x00106771 File Offset: 0x00104971
		// (set) Token: 0x06006C7A RID: 27770 RVA: 0x0010678A File Offset: 0x0010498A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HackTargetComponentPb HackTargetComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.HackTargetComponentPb)
				{
					return null;
				}
				return (HackTargetComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.HackTargetComponentPb);
			}
		}

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x06006C7B RID: 27771 RVA: 0x001067A1 File Offset: 0x001049A1
		// (set) Token: 0x06006C7C RID: 27772 RVA: 0x001067BA File Offset: 0x001049BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipComponentPb GravityFlipComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.GravityFlipComponentPb)
				{
					return null;
				}
				return (GravityFlipComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.GravityFlipComponentPb);
			}
		}

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x06006C7D RID: 27773 RVA: 0x001067D1 File Offset: 0x001049D1
		// (set) Token: 0x06006C7E RID: 27774 RVA: 0x001067EA File Offset: 0x001049EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMoveSplineComponentPb EntityMoveSplineComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.EntityMoveSplineComponentPb)
				{
					return null;
				}
				return (EntityMoveSplineComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.EntityMoveSplineComponentPb);
			}
		}

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x06006C7F RID: 27775 RVA: 0x00106801 File Offset: 0x00104A01
		// (set) Token: 0x06006C80 RID: 27776 RVA: 0x0010681A File Offset: 0x00104A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRewardItemPb EntityRewardItemPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.EntityRewardItemPb)
				{
					return null;
				}
				return (EntityRewardItemPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.EntityRewardItemPb);
			}
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x06006C81 RID: 27777 RVA: 0x00106831 File Offset: 0x00104A31
		// (set) Token: 0x06006C82 RID: 27778 RVA: 0x0010684A File Offset: 0x00104A4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemplateEntitySpawnerComponentPb TemplateEntitySpawnerComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.TemplateEntitySpawnerComponentPb)
				{
					return null;
				}
				return (TemplateEntitySpawnerComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.TemplateEntitySpawnerComponentPb);
			}
		}

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x06006C83 RID: 27779 RVA: 0x00106861 File Offset: 0x00104A61
		// (set) Token: 0x06006C84 RID: 27780 RVA: 0x0010687A File Offset: 0x00104A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridObjectComponentPb GridObjectComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.GridObjectComponentPb)
				{
					return null;
				}
				return (GridObjectComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.GridObjectComponentPb);
			}
		}

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x06006C85 RID: 27781 RVA: 0x00106891 File Offset: 0x00104A91
		// (set) Token: 0x06006C86 RID: 27782 RVA: 0x001068AA File Offset: 0x00104AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatComponentPb SimpleCombatComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.SimpleCombatComponentPb)
				{
					return null;
				}
				return (SimpleCombatComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.SimpleCombatComponentPb);
			}
		}

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x06006C87 RID: 27783 RVA: 0x001068C1 File Offset: 0x00104AC1
		// (set) Token: 0x06006C88 RID: 27784 RVA: 0x001068DA File Offset: 0x00104ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseComponentPb TrapDefenseComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.TrapDefenseComponentPb)
				{
					return null;
				}
				return (TrapDefenseComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.TrapDefenseComponentPb);
			}
		}

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x06006C89 RID: 27785 RVA: 0x001068F1 File Offset: 0x00104AF1
		// (set) Token: 0x06006C8A RID: 27786 RVA: 0x0010690A File Offset: 0x00104B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldHandComponentPb HoldHandComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.HoldHandComponentPb)
				{
					return null;
				}
				return (HoldHandComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.HoldHandComponentPb);
			}
		}

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x06006C8B RID: 27787 RVA: 0x00106921 File Offset: 0x00104B21
		// (set) Token: 0x06006C8C RID: 27788 RVA: 0x0010693A File Offset: 0x00104B3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemEventListenerComponentPb ListenerComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.ListenerComponentPb)
				{
					return null;
				}
				return (SceneItemEventListenerComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.ListenerComponentPb);
			}
		}

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x06006C8D RID: 27789 RVA: 0x00106951 File Offset: 0x00104B51
		// (set) Token: 0x06006C8E RID: 27790 RVA: 0x0010696A File Offset: 0x00104B6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityComponentPb ActivityComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.ActivityComponentPb)
				{
					return null;
				}
				return (ActivityComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.ActivityComponentPb);
			}
		}

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x06006C8F RID: 27791 RVA: 0x00106981 File Offset: 0x00104B81
		// (set) Token: 0x06006C90 RID: 27792 RVA: 0x0010699A File Offset: 0x00104B9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinComponentPb CalabashSkinComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.CalabashSkinComponentPb)
				{
					return null;
				}
				return (CalabashSkinComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.CalabashSkinComponentPb);
			}
		}

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x06006C91 RID: 27793 RVA: 0x001069B1 File Offset: 0x00104BB1
		// (set) Token: 0x06006C92 RID: 27794 RVA: 0x001069CA File Offset: 0x00104BCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryDropItemComponentPb HonamiStoryDropItemComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.HonamiStoryDropItemComponentPb)
				{
					return null;
				}
				return (HonamiStoryDropItemComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.HonamiStoryDropItemComponentPb);
			}
		}

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x06006C93 RID: 27795 RVA: 0x001069E1 File Offset: 0x00104BE1
		// (set) Token: 0x06006C94 RID: 27796 RVA: 0x001069FA File Offset: 0x00104BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEnhanceLevelComponentPb HonamiStoryEnhanceLevelComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.HonamiStoryEnhanceLevelComponentPb)
				{
					return null;
				}
				return (HonamiStoryEnhanceLevelComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.HonamiStoryEnhanceLevelComponentPb);
			}
		}

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x06006C95 RID: 27797 RVA: 0x00106A11 File Offset: 0x00104C11
		// (set) Token: 0x06006C96 RID: 27798 RVA: 0x00106A2A File Offset: 0x00104C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveToPointComponentPb MoveToPointComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.MoveToPointComponentPb)
				{
					return null;
				}
				return (MoveToPointComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.MoveToPointComponentPb);
			}
		}

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x06006C97 RID: 27799 RVA: 0x00106A41 File Offset: 0x00104C41
		// (set) Token: 0x06006C98 RID: 27800 RVA: 0x00106A5A File Offset: 0x00104C5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBlockComponentPb RbBlockComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.RbBlockComponentPb)
				{
					return null;
				}
				return (RbBlockComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.RbBlockComponentPb);
			}
		}

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x06006C99 RID: 27801 RVA: 0x00106A71 File Offset: 0x00104C71
		// (set) Token: 0x06006C9A RID: 27802 RVA: 0x00106A8A File Offset: 0x00104C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritGearComponentPb SpiritGearComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.SpiritGearComponentPb)
				{
					return null;
				}
				return (SunSpiritGearComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.SpiritGearComponentPb);
			}
		}

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x06006C9B RID: 27803 RVA: 0x00106AA1 File Offset: 0x00104CA1
		// (set) Token: 0x06006C9C RID: 27804 RVA: 0x00106ABA File Offset: 0x00104CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePb VehiclePb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.VehiclePb)
				{
					return null;
				}
				return (VehiclePb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.VehiclePb);
			}
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x06006C9D RID: 27805 RVA: 0x00106AD1 File Offset: 0x00104CD1
		// (set) Token: 0x06006C9E RID: 27806 RVA: 0x00106AEA File Offset: 0x00104CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbFloorComponentPb RbFloorComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.RbFloorComponentPb)
				{
					return null;
				}
				return (RbFloorComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.RbFloorComponentPb);
			}
		}

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x06006C9F RID: 27807 RVA: 0x00106B01 File Offset: 0x00104D01
		// (set) Token: 0x06006CA0 RID: 27808 RVA: 0x00106B1A File Offset: 0x00104D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbItemComponentPb RbItemComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.RbItemComponentPb)
				{
					return null;
				}
				return (RbItemComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.RbItemComponentPb);
			}
		}

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x06006CA1 RID: 27809 RVA: 0x00106B31 File Offset: 0x00104D31
		// (set) Token: 0x06006CA2 RID: 27810 RVA: 0x00106B4A File Offset: 0x00104D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNetworkComponentPb RoadNetworkComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.RoadNetworkComponentPb)
				{
					return null;
				}
				return (RoadNetworkComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.RoadNetworkComponentPb);
			}
		}

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x06006CA3 RID: 27811 RVA: 0x00106B61 File Offset: 0x00104D61
		// (set) Token: 0x06006CA4 RID: 27812 RVA: 0x00106B7A File Offset: 0x00104D7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowEntityComponentPb FollowEntityComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.FollowEntityComponentPb)
				{
					return null;
				}
				return (FollowEntityComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.FollowEntityComponentPb);
			}
		}

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x06006CA5 RID: 27813 RVA: 0x00106B91 File Offset: 0x00104D91
		// (set) Token: 0x06006CA6 RID: 27814 RVA: 0x00106BAA File Offset: 0x00104DAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEquippedPb MotorOutlookComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.MotorOutlookComponentPb)
				{
					return null;
				}
				return (MotorOutlookEquippedPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.MotorOutlookComponentPb);
			}
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x06006CA7 RID: 27815 RVA: 0x00106BC1 File Offset: 0x00104DC1
		// (set) Token: 0x06006CA8 RID: 27816 RVA: 0x00106BDA File Offset: 0x00104DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDaCtxComponentPb MotorDaCtxComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.MotorDaCtxComponentPb)
				{
					return null;
				}
				return (MotorDaCtxComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.MotorDaCtxComponentPb);
			}
		}

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x06006CA9 RID: 27817 RVA: 0x00106BF1 File Offset: 0x00104DF1
		// (set) Token: 0x06006CAA RID: 27818 RVA: 0x00106C0A File Offset: 0x00104E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExhibitionComponentPb ExhibitionComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.ExhibitionComponentPb)
				{
					return null;
				}
				return (ExhibitionComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.ExhibitionComponentPb);
			}
		}

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x06006CAB RID: 27819 RVA: 0x00106C21 File Offset: 0x00104E21
		// (set) Token: 0x06006CAC RID: 27820 RVA: 0x00106C3A File Offset: 0x00104E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FurnitureComponentPb FurnitureComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.FurnitureComponentPb)
				{
					return null;
				}
				return (FurnitureComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.FurnitureComponentPb);
			}
		}

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x06006CAD RID: 27821 RVA: 0x00106C51 File Offset: 0x00104E51
		// (set) Token: 0x06006CAE RID: 27822 RVA: 0x00106C6A File Offset: 0x00104E6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentComponentPb OrnamentComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.OrnamentComponentPb)
				{
					return null;
				}
				return (OrnamentComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.OrnamentComponentPb);
			}
		}

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x06006CAF RID: 27823 RVA: 0x00106C81 File Offset: 0x00104E81
		// (set) Token: 0x06006CB0 RID: 27824 RVA: 0x00106C9A File Offset: 0x00104E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowerPollutionComponentPb FlowerPollutionComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.FlowerPollutionComponentPb)
				{
					return null;
				}
				return (FlowerPollutionComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.FlowerPollutionComponentPb);
			}
		}

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x06006CB1 RID: 27825 RVA: 0x00106CB1 File Offset: 0x00104EB1
		// (set) Token: 0x06006CB2 RID: 27826 RVA: 0x00106CCA File Offset: 0x00104ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabMachineComponentPb DollGrabMachineComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.DollGrabMachineComponentPb)
				{
					return null;
				}
				return (DollGrabMachineComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.DollGrabMachineComponentPb);
			}
		}

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x06006CB3 RID: 27827 RVA: 0x00106CE1 File Offset: 0x00104EE1
		// (set) Token: 0x06006CB4 RID: 27828 RVA: 0x00106CFA File Offset: 0x00104EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabShowcaseComponentPb DollGrabShowcaseComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.DollGrabShowcaseComponentPb)
				{
					return null;
				}
				return (DollGrabShowcaseComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.DollGrabShowcaseComponentPb);
			}
		}

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x06006CB5 RID: 27829 RVA: 0x00106D11 File Offset: 0x00104F11
		// (set) Token: 0x06006CB6 RID: 27830 RVA: 0x00106D2A File Offset: 0x00104F2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuEntityComponentPb GpuEntityComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.GpuEntityComponentPb)
				{
					return null;
				}
				return (GpuEntityComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.GpuEntityComponentPb);
			}
		}

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x06006CB7 RID: 27831 RVA: 0x00106D41 File Offset: 0x00104F41
		// (set) Token: 0x06006CB8 RID: 27832 RVA: 0x00106D5A File Offset: 0x00104F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRoguePortalComponentPb RoverRoguePortalComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.RoverRoguePortalComponentPb)
				{
					return null;
				}
				return (RoverRoguePortalComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.RoverRoguePortalComponentPb);
			}
		}

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x06006CB9 RID: 27833 RVA: 0x00106D71 File Offset: 0x00104F71
		// (set) Token: 0x06006CBA RID: 27834 RVA: 0x00106D8A File Offset: 0x00104F8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ElementalHolderComponentPb ElementalHolderComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.ElementalHolderComponentPb)
				{
					return null;
				}
				return (ElementalHolderComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.ElementalHolderComponentPb);
			}
		}

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x06006CBB RID: 27835 RVA: 0x00106DA1 File Offset: 0x00104FA1
		// (set) Token: 0x06006CBC RID: 27836 RVA: 0x00106DBA File Offset: 0x00104FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillAvatarComponentPb SkillAvatarComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.SkillAvatarComponentPb)
				{
					return null;
				}
				return (SkillAvatarComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.SkillAvatarComponentPb);
			}
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x06006CBD RID: 27837 RVA: 0x00106DD1 File Offset: 0x00104FD1
		// (set) Token: 0x06006CBE RID: 27838 RVA: 0x00106DEA File Offset: 0x00104FEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFoundationComponentPb EntityFoundationComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.EntityFoundationComponentPb)
				{
					return null;
				}
				return (EntityFoundationComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.EntityFoundationComponentPb);
			}
		}

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x06006CBF RID: 27839 RVA: 0x00106E01 File Offset: 0x00105001
		// (set) Token: 0x06006CC0 RID: 27840 RVA: 0x00106E1A File Offset: 0x0010501A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SquadPropComponentPb SquadPropComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.SquadPropComponentPb)
				{
					return null;
				}
				return (SquadPropComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.SquadPropComponentPb);
			}
		}

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x06006CC1 RID: 27841 RVA: 0x00106E31 File Offset: 0x00105031
		// (set) Token: 0x06006CC2 RID: 27842 RVA: 0x00106E4A File Offset: 0x0010504A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorComponentPb ConnectorComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.ConnectorComponentPb)
				{
					return null;
				}
				return (ConnectorComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.ConnectorComponentPb);
			}
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x06006CC3 RID: 27843 RVA: 0x00106E61 File Offset: 0x00105061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityComponentPb.ComponentOneofCase ComponentCase
		{
			get
			{
				return this.componentCase_;
			}
		}

		// Token: 0x06006CC4 RID: 27844 RVA: 0x00106E69 File Offset: 0x00105069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearComponent()
		{
			this.componentCase_ = EntityComponentPb.ComponentOneofCase.None;
			this.component_ = null;
		}

		// Token: 0x06006CC5 RID: 27845 RVA: 0x00106E79 File Offset: 0x00105079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityComponentPb);
		}

		// Token: 0x06006CC6 RID: 27846 RVA: 0x00106E88 File Offset: 0x00105088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityComponentPb other)
		{
			return other != null && (other == this || (object.Equals(this.AttributeComponent, other.AttributeComponent) && object.Equals(this.TagComponent, other.TagComponent) && object.Equals(this.TriggerComponent, other.TriggerComponent) && object.Equals(this.SummonerComponent, other.SummonerComponent) && object.Equals(this.PartComponent, other.PartComponent) && object.Equals(this.VisionSkillComponent, other.VisionSkillComponent) && object.Equals(this.AnimationStateComponent, other.AnimationStateComponent) && object.Equals(this.BlackboardParamComponent, other.BlackboardParamComponent) && object.Equals(this.SysBuffComponent, other.SysBuffComponent) && object.Equals(this.ClientDataComponent, other.ClientDataComponent) && object.Equals(this.MonsterWeaponComponentPb, other.MonsterWeaponComponentPb) && object.Equals(this.MonsterAiComponentPb, other.MonsterAiComponentPb) && object.Equals(this.FightBuffComponent, other.FightBuffComponent) && object.Equals(this.NearbyTrackingComponentPb, other.NearbyTrackingComponentPb) && object.Equals(this.DropComponentPb, other.DropComponentPb) && object.Equals(this.MonsterCaptureComponent, other.MonsterCaptureComponent) && object.Equals(this.LogicStateComponentPb, other.LogicStateComponentPb) && object.Equals(this.AdviceComponentPb, other.AdviceComponentPb) && object.Equals(this.LiftComponentPb, other.LiftComponentPb) && object.Equals(this.InteractComponent, other.InteractComponent) && object.Equals(this.EquipComponent, other.EquipComponent) && object.Equals(this.BeControlledComponentPb, other.BeControlledComponentPb) && object.Equals(this.ConcomitantsComponentPb, other.ConcomitantsComponentPb) && object.Equals(this.TimelineTrackComponentPb, other.TimelineTrackComponentPb) && object.Equals(this.SummonsComponentPb, other.SummonsComponentPb) && object.Equals(this.EntityFsmComponentPb, other.EntityFsmComponentPb) && object.Equals(this.BoardPb, other.BoardPb) && object.Equals(this.PlacementItemPb, other.PlacementItemPb) && object.Equals(this.StateTagComponentPb, other.StateTagComponentPb) && object.Equals(this.MonsterGachaDataPb, other.MonsterGachaDataPb) && object.Equals(this.FanComponentPb, other.FanComponentPb) && object.Equals(this.NpcPb, other.NpcPb) && object.Equals(this.BubbleComponent, other.BubbleComponent) && object.Equals(this.PatrolComponent, other.PatrolComponent) && object.Equals(this.RangeComponent, other.RangeComponent) && object.Equals(this.PassiveSkillComponentPb, other.PassiveSkillComponentPb) && object.Equals(this.SkillComponentPb, other.SkillComponentPb) && object.Equals(this.DynamicAttachComponentPb, other.DynamicAttachComponentPb) && object.Equals(this.VarComponentPb, other.VarComponentPb) && object.Equals(this.PlayerFollowerSelfComponentPb, other.PlayerFollowerSelfComponentPb) && object.Equals(this.SceneItemLifeCycleComponentPb, other.SceneItemLifeCycleComponentPb) && object.Equals(this.EntityBulletComponentPb, other.EntityBulletComponentPb) && object.Equals(this.BuffProducerComponentPb, other.BuffProducerComponentPb) && object.Equals(this.BuffConsumerComponentPb, other.BuffConsumerComponentPb) && object.Equals(this.SceneItemComponentPb, other.SceneItemComponentPb) && object.Equals(this.ShieldComponentPb, other.ShieldComponentPb) && object.Equals(this.NpcPerformComponentPb, other.NpcPerformComponentPb) && object.Equals(this.DependenceComponentPb, other.DependenceComponentPb) && object.Equals(this.RenjuDataPb, other.RenjuDataPb) && object.Equals(this.AiRoleComponentPb, other.AiRoleComponentPb) && object.Equals(this.PlayerFollowersComponentPb, other.PlayerFollowersComponentPb) && object.Equals(this.SceneItemAttributeComponentPb, other.SceneItemAttributeComponentPb) && object.Equals(this.PullingFoundationComponentPb, other.PullingFoundationComponentPb) && object.Equals(this.BatchBulletCastComponentPb, other.BatchBulletCastComponentPb) && object.Equals(this.RoleWeaponSkinComponent, other.RoleWeaponSkinComponent) && object.Equals(this.CombineEntityInfoPb, other.CombineEntityInfoPb) && object.Equals(this.SceneItemAiComponentPb, other.SceneItemAiComponentPb) && object.Equals(this.AnimalCollectComponentPb, other.AnimalCollectComponentPb) && object.Equals(this.VehiclePassengerComponentPb, other.VehiclePassengerComponentPb) && object.Equals(this.HookLockPointComponentPb, other.HookLockPointComponentPb) && object.Equals(this.HackingComponentPb, other.HackingComponentPb) && object.Equals(this.HackTargetComponentPb, other.HackTargetComponentPb) && object.Equals(this.GravityFlipComponentPb, other.GravityFlipComponentPb) && object.Equals(this.EntityMoveSplineComponentPb, other.EntityMoveSplineComponentPb) && object.Equals(this.EntityRewardItemPb, other.EntityRewardItemPb) && object.Equals(this.TemplateEntitySpawnerComponentPb, other.TemplateEntitySpawnerComponentPb) && object.Equals(this.GridObjectComponentPb, other.GridObjectComponentPb) && object.Equals(this.SimpleCombatComponentPb, other.SimpleCombatComponentPb) && object.Equals(this.TrapDefenseComponentPb, other.TrapDefenseComponentPb) && object.Equals(this.HoldHandComponentPb, other.HoldHandComponentPb) && object.Equals(this.ListenerComponentPb, other.ListenerComponentPb) && object.Equals(this.ActivityComponentPb, other.ActivityComponentPb) && object.Equals(this.CalabashSkinComponentPb, other.CalabashSkinComponentPb) && object.Equals(this.HonamiStoryDropItemComponentPb, other.HonamiStoryDropItemComponentPb) && object.Equals(this.HonamiStoryEnhanceLevelComponentPb, other.HonamiStoryEnhanceLevelComponentPb) && object.Equals(this.MoveToPointComponentPb, other.MoveToPointComponentPb) && object.Equals(this.RbBlockComponentPb, other.RbBlockComponentPb) && object.Equals(this.SpiritGearComponentPb, other.SpiritGearComponentPb) && object.Equals(this.VehiclePb, other.VehiclePb) && object.Equals(this.RbFloorComponentPb, other.RbFloorComponentPb) && object.Equals(this.RbItemComponentPb, other.RbItemComponentPb) && object.Equals(this.RoadNetworkComponentPb, other.RoadNetworkComponentPb) && object.Equals(this.FollowEntityComponentPb, other.FollowEntityComponentPb) && object.Equals(this.MotorOutlookComponentPb, other.MotorOutlookComponentPb) && object.Equals(this.MotorDaCtxComponentPb, other.MotorDaCtxComponentPb) && object.Equals(this.ExhibitionComponentPb, other.ExhibitionComponentPb) && object.Equals(this.FurnitureComponentPb, other.FurnitureComponentPb) && object.Equals(this.OrnamentComponentPb, other.OrnamentComponentPb) && object.Equals(this.FlowerPollutionComponentPb, other.FlowerPollutionComponentPb) && object.Equals(this.DollGrabMachineComponentPb, other.DollGrabMachineComponentPb) && object.Equals(this.DollGrabShowcaseComponentPb, other.DollGrabShowcaseComponentPb) && object.Equals(this.GpuEntityComponentPb, other.GpuEntityComponentPb) && object.Equals(this.RoverRoguePortalComponentPb, other.RoverRoguePortalComponentPb) && object.Equals(this.ElementalHolderComponentPb, other.ElementalHolderComponentPb) && object.Equals(this.SkillAvatarComponentPb, other.SkillAvatarComponentPb) && object.Equals(this.EntityFoundationComponentPb, other.EntityFoundationComponentPb) && object.Equals(this.SquadPropComponentPb, other.SquadPropComponentPb) && object.Equals(this.ConnectorComponentPb, other.ConnectorComponentPb) && this.ComponentCase == other.ComponentCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006CC7 RID: 27847 RVA: 0x001076CC File Offset: 0x001058CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.AttributeComponent)
			{
				num ^= this.AttributeComponent.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.TagComponent)
			{
				num ^= this.TagComponent.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.TriggerComponent)
			{
				num ^= this.TriggerComponent.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SummonerComponent)
			{
				num ^= this.SummonerComponent.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PartComponent)
			{
				num ^= this.PartComponent.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.VisionSkillComponent)
			{
				num ^= this.VisionSkillComponent.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.AnimationStateComponent)
			{
				num ^= this.AnimationStateComponent.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BlackboardParamComponent)
			{
				num ^= this.BlackboardParamComponent.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SysBuffComponent)
			{
				num ^= this.SysBuffComponent.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ClientDataComponent)
			{
				num ^= this.ClientDataComponent.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MonsterWeaponComponentPb)
			{
				num ^= this.MonsterWeaponComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MonsterAiComponentPb)
			{
				num ^= this.MonsterAiComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.FightBuffComponent)
			{
				num ^= this.FightBuffComponent.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.NearbyTrackingComponentPb)
			{
				num ^= this.NearbyTrackingComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DropComponentPb)
			{
				num ^= this.DropComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MonsterCaptureComponent)
			{
				num ^= this.MonsterCaptureComponent.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.LogicStateComponentPb)
			{
				num ^= this.LogicStateComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.AdviceComponentPb)
			{
				num ^= this.AdviceComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.LiftComponentPb)
			{
				num ^= this.LiftComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.InteractComponent)
			{
				num ^= this.InteractComponent.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EquipComponent)
			{
				num ^= this.EquipComponent.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BeControlledComponentPb)
			{
				num ^= this.BeControlledComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ConcomitantsComponentPb)
			{
				num ^= this.ConcomitantsComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.TimelineTrackComponentPb)
			{
				num ^= this.TimelineTrackComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SummonsComponentPb)
			{
				num ^= this.SummonsComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EntityFsmComponentPb)
			{
				num ^= this.EntityFsmComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BoardPb)
			{
				num ^= this.BoardPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PlacementItemPb)
			{
				num ^= this.PlacementItemPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.StateTagComponentPb)
			{
				num ^= this.StateTagComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MonsterGachaDataPb)
			{
				num ^= this.MonsterGachaDataPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.FanComponentPb)
			{
				num ^= this.FanComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.NpcPb)
			{
				num ^= this.NpcPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BubbleComponent)
			{
				num ^= this.BubbleComponent.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PatrolComponent)
			{
				num ^= this.PatrolComponent.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RangeComponent)
			{
				num ^= this.RangeComponent.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PassiveSkillComponentPb)
			{
				num ^= this.PassiveSkillComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SkillComponentPb)
			{
				num ^= this.SkillComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DynamicAttachComponentPb)
			{
				num ^= this.DynamicAttachComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.VarComponentPb)
			{
				num ^= this.VarComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PlayerFollowerSelfComponentPb)
			{
				num ^= this.PlayerFollowerSelfComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SceneItemLifeCycleComponentPb)
			{
				num ^= this.SceneItemLifeCycleComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EntityBulletComponentPb)
			{
				num ^= this.EntityBulletComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BuffProducerComponentPb)
			{
				num ^= this.BuffProducerComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BuffConsumerComponentPb)
			{
				num ^= this.BuffConsumerComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SceneItemComponentPb)
			{
				num ^= this.SceneItemComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ShieldComponentPb)
			{
				num ^= this.ShieldComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.NpcPerformComponentPb)
			{
				num ^= this.NpcPerformComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DependenceComponentPb)
			{
				num ^= this.DependenceComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RenjuDataPb)
			{
				num ^= this.RenjuDataPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.AiRoleComponentPb)
			{
				num ^= this.AiRoleComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PlayerFollowersComponentPb)
			{
				num ^= this.PlayerFollowersComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SceneItemAttributeComponentPb)
			{
				num ^= this.SceneItemAttributeComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PullingFoundationComponentPb)
			{
				num ^= this.PullingFoundationComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BatchBulletCastComponentPb)
			{
				num ^= this.BatchBulletCastComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RoleWeaponSkinComponent)
			{
				num ^= this.RoleWeaponSkinComponent.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.CombineEntityInfoPb)
			{
				num ^= this.CombineEntityInfoPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SceneItemAiComponentPb)
			{
				num ^= this.SceneItemAiComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.AnimalCollectComponentPb)
			{
				num ^= this.AnimalCollectComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.VehiclePassengerComponentPb)
			{
				num ^= this.VehiclePassengerComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HookLockPointComponentPb)
			{
				num ^= this.HookLockPointComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HackingComponentPb)
			{
				num ^= this.HackingComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HackTargetComponentPb)
			{
				num ^= this.HackTargetComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.GravityFlipComponentPb)
			{
				num ^= this.GravityFlipComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EntityMoveSplineComponentPb)
			{
				num ^= this.EntityMoveSplineComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EntityRewardItemPb)
			{
				num ^= this.EntityRewardItemPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.TemplateEntitySpawnerComponentPb)
			{
				num ^= this.TemplateEntitySpawnerComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.GridObjectComponentPb)
			{
				num ^= this.GridObjectComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SimpleCombatComponentPb)
			{
				num ^= this.SimpleCombatComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.TrapDefenseComponentPb)
			{
				num ^= this.TrapDefenseComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HoldHandComponentPb)
			{
				num ^= this.HoldHandComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ListenerComponentPb)
			{
				num ^= this.ListenerComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ActivityComponentPb)
			{
				num ^= this.ActivityComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.CalabashSkinComponentPb)
			{
				num ^= this.CalabashSkinComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HonamiStoryDropItemComponentPb)
			{
				num ^= this.HonamiStoryDropItemComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HonamiStoryEnhanceLevelComponentPb)
			{
				num ^= this.HonamiStoryEnhanceLevelComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MoveToPointComponentPb)
			{
				num ^= this.MoveToPointComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RbBlockComponentPb)
			{
				num ^= this.RbBlockComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SpiritGearComponentPb)
			{
				num ^= this.SpiritGearComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.VehiclePb)
			{
				num ^= this.VehiclePb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RbFloorComponentPb)
			{
				num ^= this.RbFloorComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RbItemComponentPb)
			{
				num ^= this.RbItemComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RoadNetworkComponentPb)
			{
				num ^= this.RoadNetworkComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.FollowEntityComponentPb)
			{
				num ^= this.FollowEntityComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MotorOutlookComponentPb)
			{
				num ^= this.MotorOutlookComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MotorDaCtxComponentPb)
			{
				num ^= this.MotorDaCtxComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ExhibitionComponentPb)
			{
				num ^= this.ExhibitionComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.FurnitureComponentPb)
			{
				num ^= this.FurnitureComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.OrnamentComponentPb)
			{
				num ^= this.OrnamentComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.FlowerPollutionComponentPb)
			{
				num ^= this.FlowerPollutionComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DollGrabMachineComponentPb)
			{
				num ^= this.DollGrabMachineComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DollGrabShowcaseComponentPb)
			{
				num ^= this.DollGrabShowcaseComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.GpuEntityComponentPb)
			{
				num ^= this.GpuEntityComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RoverRoguePortalComponentPb)
			{
				num ^= this.RoverRoguePortalComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ElementalHolderComponentPb)
			{
				num ^= this.ElementalHolderComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SkillAvatarComponentPb)
			{
				num ^= this.SkillAvatarComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EntityFoundationComponentPb)
			{
				num ^= this.EntityFoundationComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SquadPropComponentPb)
			{
				num ^= this.SquadPropComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ConnectorComponentPb)
			{
				num ^= this.ConnectorComponentPb.GetHashCode();
			}
			num ^= (int)this.componentCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006CC8 RID: 27848 RVA: 0x00108023 File Offset: 0x00106223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006CC9 RID: 27849 RVA: 0x00108030 File Offset: 0x00106230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006CCA RID: 27850 RVA: 0x0010803C File Offset: 0x0010623C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.AttributeComponent)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AttributeComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.TagComponent)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TagComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.TriggerComponent)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.TriggerComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SummonerComponent)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.SummonerComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PartComponent)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.PartComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.VisionSkillComponent)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.VisionSkillComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.AnimationStateComponent)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.AnimationStateComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BlackboardParamComponent)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.BlackboardParamComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SysBuffComponent)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.SysBuffComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ClientDataComponent)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ClientDataComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MonsterWeaponComponentPb)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.MonsterWeaponComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MonsterAiComponentPb)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.MonsterAiComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.FightBuffComponent)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.FightBuffComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.NearbyTrackingComponentPb)
			{
				output.WriteRawTag(130, 1);
				output.WriteMessage(this.NearbyTrackingComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DropComponentPb)
			{
				output.WriteRawTag(138, 1);
				output.WriteMessage(this.DropComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MonsterCaptureComponent)
			{
				output.WriteRawTag(146, 1);
				output.WriteMessage(this.MonsterCaptureComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.LogicStateComponentPb)
			{
				output.WriteRawTag(154, 1);
				output.WriteMessage(this.LogicStateComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.AdviceComponentPb)
			{
				output.WriteRawTag(162, 1);
				output.WriteMessage(this.AdviceComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.LiftComponentPb)
			{
				output.WriteRawTag(170, 1);
				output.WriteMessage(this.LiftComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.InteractComponent)
			{
				output.WriteRawTag(178, 1);
				output.WriteMessage(this.InteractComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EquipComponent)
			{
				output.WriteRawTag(186, 1);
				output.WriteMessage(this.EquipComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BeControlledComponentPb)
			{
				output.WriteRawTag(194, 1);
				output.WriteMessage(this.BeControlledComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ConcomitantsComponentPb)
			{
				output.WriteRawTag(202, 1);
				output.WriteMessage(this.ConcomitantsComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.TimelineTrackComponentPb)
			{
				output.WriteRawTag(210, 1);
				output.WriteMessage(this.TimelineTrackComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SummonsComponentPb)
			{
				output.WriteRawTag(218, 1);
				output.WriteMessage(this.SummonsComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EntityFsmComponentPb)
			{
				output.WriteRawTag(226, 1);
				output.WriteMessage(this.EntityFsmComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BoardPb)
			{
				output.WriteRawTag(234, 1);
				output.WriteMessage(this.BoardPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PlacementItemPb)
			{
				output.WriteRawTag(242, 1);
				output.WriteMessage(this.PlacementItemPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.StateTagComponentPb)
			{
				output.WriteRawTag(250, 1);
				output.WriteMessage(this.StateTagComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MonsterGachaDataPb)
			{
				output.WriteRawTag(130, 2);
				output.WriteMessage(this.MonsterGachaDataPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.FanComponentPb)
			{
				output.WriteRawTag(138, 2);
				output.WriteMessage(this.FanComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.NpcPb)
			{
				output.WriteRawTag(146, 2);
				output.WriteMessage(this.NpcPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BubbleComponent)
			{
				output.WriteRawTag(154, 2);
				output.WriteMessage(this.BubbleComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PatrolComponent)
			{
				output.WriteRawTag(162, 2);
				output.WriteMessage(this.PatrolComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RangeComponent)
			{
				output.WriteRawTag(170, 2);
				output.WriteMessage(this.RangeComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PassiveSkillComponentPb)
			{
				output.WriteRawTag(178, 2);
				output.WriteMessage(this.PassiveSkillComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SkillComponentPb)
			{
				output.WriteRawTag(186, 2);
				output.WriteMessage(this.SkillComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DynamicAttachComponentPb)
			{
				output.WriteRawTag(194, 2);
				output.WriteMessage(this.DynamicAttachComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.VarComponentPb)
			{
				output.WriteRawTag(202, 2);
				output.WriteMessage(this.VarComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PlayerFollowerSelfComponentPb)
			{
				output.WriteRawTag(210, 2);
				output.WriteMessage(this.PlayerFollowerSelfComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SceneItemLifeCycleComponentPb)
			{
				output.WriteRawTag(218, 2);
				output.WriteMessage(this.SceneItemLifeCycleComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EntityBulletComponentPb)
			{
				output.WriteRawTag(226, 2);
				output.WriteMessage(this.EntityBulletComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BuffProducerComponentPb)
			{
				output.WriteRawTag(234, 2);
				output.WriteMessage(this.BuffProducerComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BuffConsumerComponentPb)
			{
				output.WriteRawTag(242, 2);
				output.WriteMessage(this.BuffConsumerComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SceneItemComponentPb)
			{
				output.WriteRawTag(250, 2);
				output.WriteMessage(this.SceneItemComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ShieldComponentPb)
			{
				output.WriteRawTag(130, 3);
				output.WriteMessage(this.ShieldComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.NpcPerformComponentPb)
			{
				output.WriteRawTag(138, 3);
				output.WriteMessage(this.NpcPerformComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DependenceComponentPb)
			{
				output.WriteRawTag(146, 3);
				output.WriteMessage(this.DependenceComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RenjuDataPb)
			{
				output.WriteRawTag(154, 3);
				output.WriteMessage(this.RenjuDataPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.AiRoleComponentPb)
			{
				output.WriteRawTag(162, 3);
				output.WriteMessage(this.AiRoleComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PlayerFollowersComponentPb)
			{
				output.WriteRawTag(170, 3);
				output.WriteMessage(this.PlayerFollowersComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SceneItemAttributeComponentPb)
			{
				output.WriteRawTag(178, 3);
				output.WriteMessage(this.SceneItemAttributeComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PullingFoundationComponentPb)
			{
				output.WriteRawTag(186, 3);
				output.WriteMessage(this.PullingFoundationComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BatchBulletCastComponentPb)
			{
				output.WriteRawTag(194, 3);
				output.WriteMessage(this.BatchBulletCastComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RoleWeaponSkinComponent)
			{
				output.WriteRawTag(202, 3);
				output.WriteMessage(this.RoleWeaponSkinComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.CombineEntityInfoPb)
			{
				output.WriteRawTag(210, 3);
				output.WriteMessage(this.CombineEntityInfoPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SceneItemAiComponentPb)
			{
				output.WriteRawTag(218, 3);
				output.WriteMessage(this.SceneItemAiComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.AnimalCollectComponentPb)
			{
				output.WriteRawTag(226, 3);
				output.WriteMessage(this.AnimalCollectComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.VehiclePassengerComponentPb)
			{
				output.WriteRawTag(234, 3);
				output.WriteMessage(this.VehiclePassengerComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HookLockPointComponentPb)
			{
				output.WriteRawTag(242, 3);
				output.WriteMessage(this.HookLockPointComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HackingComponentPb)
			{
				output.WriteRawTag(250, 3);
				output.WriteMessage(this.HackingComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HackTargetComponentPb)
			{
				output.WriteRawTag(130, 4);
				output.WriteMessage(this.HackTargetComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.GravityFlipComponentPb)
			{
				output.WriteRawTag(138, 4);
				output.WriteMessage(this.GravityFlipComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EntityMoveSplineComponentPb)
			{
				output.WriteRawTag(146, 4);
				output.WriteMessage(this.EntityMoveSplineComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EntityRewardItemPb)
			{
				output.WriteRawTag(154, 4);
				output.WriteMessage(this.EntityRewardItemPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.TemplateEntitySpawnerComponentPb)
			{
				output.WriteRawTag(162, 4);
				output.WriteMessage(this.TemplateEntitySpawnerComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.GridObjectComponentPb)
			{
				output.WriteRawTag(170, 4);
				output.WriteMessage(this.GridObjectComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SimpleCombatComponentPb)
			{
				output.WriteRawTag(178, 4);
				output.WriteMessage(this.SimpleCombatComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.TrapDefenseComponentPb)
			{
				output.WriteRawTag(186, 4);
				output.WriteMessage(this.TrapDefenseComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HoldHandComponentPb)
			{
				output.WriteRawTag(194, 4);
				output.WriteMessage(this.HoldHandComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ListenerComponentPb)
			{
				output.WriteRawTag(202, 4);
				output.WriteMessage(this.ListenerComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ActivityComponentPb)
			{
				output.WriteRawTag(210, 4);
				output.WriteMessage(this.ActivityComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.CalabashSkinComponentPb)
			{
				output.WriteRawTag(218, 4);
				output.WriteMessage(this.CalabashSkinComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HonamiStoryDropItemComponentPb)
			{
				output.WriteRawTag(226, 4);
				output.WriteMessage(this.HonamiStoryDropItemComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HonamiStoryEnhanceLevelComponentPb)
			{
				output.WriteRawTag(234, 4);
				output.WriteMessage(this.HonamiStoryEnhanceLevelComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MoveToPointComponentPb)
			{
				output.WriteRawTag(242, 4);
				output.WriteMessage(this.MoveToPointComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RbBlockComponentPb)
			{
				output.WriteRawTag(250, 4);
				output.WriteMessage(this.RbBlockComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SpiritGearComponentPb)
			{
				output.WriteRawTag(130, 5);
				output.WriteMessage(this.SpiritGearComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.VehiclePb)
			{
				output.WriteRawTag(138, 5);
				output.WriteMessage(this.VehiclePb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RbFloorComponentPb)
			{
				output.WriteRawTag(146, 5);
				output.WriteMessage(this.RbFloorComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RbItemComponentPb)
			{
				output.WriteRawTag(154, 5);
				output.WriteMessage(this.RbItemComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RoadNetworkComponentPb)
			{
				output.WriteRawTag(162, 5);
				output.WriteMessage(this.RoadNetworkComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.FollowEntityComponentPb)
			{
				output.WriteRawTag(170, 5);
				output.WriteMessage(this.FollowEntityComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MotorOutlookComponentPb)
			{
				output.WriteRawTag(178, 5);
				output.WriteMessage(this.MotorOutlookComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MotorDaCtxComponentPb)
			{
				output.WriteRawTag(186, 5);
				output.WriteMessage(this.MotorDaCtxComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ExhibitionComponentPb)
			{
				output.WriteRawTag(194, 5);
				output.WriteMessage(this.ExhibitionComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.FurnitureComponentPb)
			{
				output.WriteRawTag(202, 5);
				output.WriteMessage(this.FurnitureComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.OrnamentComponentPb)
			{
				output.WriteRawTag(210, 5);
				output.WriteMessage(this.OrnamentComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.FlowerPollutionComponentPb)
			{
				output.WriteRawTag(218, 5);
				output.WriteMessage(this.FlowerPollutionComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DollGrabMachineComponentPb)
			{
				output.WriteRawTag(226, 5);
				output.WriteMessage(this.DollGrabMachineComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DollGrabShowcaseComponentPb)
			{
				output.WriteRawTag(234, 5);
				output.WriteMessage(this.DollGrabShowcaseComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.GpuEntityComponentPb)
			{
				output.WriteRawTag(242, 5);
				output.WriteMessage(this.GpuEntityComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RoverRoguePortalComponentPb)
			{
				output.WriteRawTag(250, 5);
				output.WriteMessage(this.RoverRoguePortalComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ElementalHolderComponentPb)
			{
				output.WriteRawTag(138, 6);
				output.WriteMessage(this.ElementalHolderComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SkillAvatarComponentPb)
			{
				output.WriteRawTag(146, 6);
				output.WriteMessage(this.SkillAvatarComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EntityFoundationComponentPb)
			{
				output.WriteRawTag(154, 6);
				output.WriteMessage(this.EntityFoundationComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SquadPropComponentPb)
			{
				output.WriteRawTag(162, 6);
				output.WriteMessage(this.SquadPropComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ConnectorComponentPb)
			{
				output.WriteRawTag(186, 6);
				output.WriteMessage(this.ConnectorComponentPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006CCB RID: 27851 RVA: 0x00108D28 File Offset: 0x00106F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.AttributeComponent)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AttributeComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.TagComponent)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TagComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.TriggerComponent)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TriggerComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SummonerComponent)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SummonerComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PartComponent)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PartComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.VisionSkillComponent)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.VisionSkillComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.AnimationStateComponent)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AnimationStateComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BlackboardParamComponent)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BlackboardParamComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SysBuffComponent)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SysBuffComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ClientDataComponent)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClientDataComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MonsterWeaponComponentPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MonsterWeaponComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MonsterAiComponentPb)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MonsterAiComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.FightBuffComponent)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FightBuffComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.NearbyTrackingComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.NearbyTrackingComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DropComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DropComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MonsterCaptureComponent)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MonsterCaptureComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.LogicStateComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.LogicStateComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.AdviceComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AdviceComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.LiftComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.LiftComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.InteractComponent)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.InteractComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EquipComponent)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EquipComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BeControlledComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BeControlledComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ConcomitantsComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ConcomitantsComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.TimelineTrackComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TimelineTrackComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SummonsComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SummonsComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EntityFsmComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EntityFsmComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BoardPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BoardPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PlacementItemPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PlacementItemPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.StateTagComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.StateTagComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MonsterGachaDataPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MonsterGachaDataPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.FanComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FanComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.NpcPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.NpcPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BubbleComponent)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BubbleComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PatrolComponent)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PatrolComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RangeComponent)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RangeComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PassiveSkillComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PassiveSkillComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SkillComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SkillComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DynamicAttachComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DynamicAttachComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.VarComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.VarComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PlayerFollowerSelfComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PlayerFollowerSelfComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SceneItemLifeCycleComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SceneItemLifeCycleComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EntityBulletComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EntityBulletComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BuffProducerComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BuffProducerComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BuffConsumerComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BuffConsumerComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SceneItemComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SceneItemComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ShieldComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ShieldComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.NpcPerformComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.NpcPerformComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DependenceComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DependenceComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RenjuDataPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RenjuDataPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.AiRoleComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AiRoleComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PlayerFollowersComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PlayerFollowersComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SceneItemAttributeComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SceneItemAttributeComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PullingFoundationComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.PullingFoundationComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BatchBulletCastComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.BatchBulletCastComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RoleWeaponSkinComponent)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RoleWeaponSkinComponent);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.CombineEntityInfoPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CombineEntityInfoPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SceneItemAiComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SceneItemAiComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.AnimalCollectComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.AnimalCollectComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.VehiclePassengerComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.VehiclePassengerComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HookLockPointComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.HookLockPointComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HackingComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.HackingComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HackTargetComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.HackTargetComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.GravityFlipComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GravityFlipComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EntityMoveSplineComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EntityMoveSplineComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EntityRewardItemPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EntityRewardItemPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.TemplateEntitySpawnerComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TemplateEntitySpawnerComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.GridObjectComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GridObjectComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SimpleCombatComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SimpleCombatComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.TrapDefenseComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.TrapDefenseComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HoldHandComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.HoldHandComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ListenerComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ListenerComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ActivityComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ActivityComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.CalabashSkinComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.CalabashSkinComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HonamiStoryDropItemComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.HonamiStoryDropItemComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HonamiStoryEnhanceLevelComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.HonamiStoryEnhanceLevelComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MoveToPointComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MoveToPointComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RbBlockComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RbBlockComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SpiritGearComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SpiritGearComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.VehiclePb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.VehiclePb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RbFloorComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RbFloorComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RbItemComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RbItemComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RoadNetworkComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RoadNetworkComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.FollowEntityComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FollowEntityComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MotorOutlookComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MotorOutlookComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MotorDaCtxComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.MotorDaCtxComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ExhibitionComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ExhibitionComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.FurnitureComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FurnitureComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.OrnamentComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.OrnamentComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.FlowerPollutionComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.FlowerPollutionComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DollGrabMachineComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DollGrabMachineComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DollGrabShowcaseComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DollGrabShowcaseComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.GpuEntityComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.GpuEntityComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RoverRoguePortalComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RoverRoguePortalComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ElementalHolderComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ElementalHolderComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SkillAvatarComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SkillAvatarComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EntityFoundationComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.EntityFoundationComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SquadPropComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.SquadPropComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ConnectorComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ConnectorComponentPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006CCC RID: 27852 RVA: 0x0010973C File Offset: 0x0010793C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			switch (other.ComponentCase)
			{
			case EntityComponentPb.ComponentOneofCase.AttributeComponent:
				if (this.AttributeComponent == null)
				{
					this.AttributeComponent = new AttributeComponentPb();
				}
				this.AttributeComponent.MergeFrom(other.AttributeComponent);
				break;
			case EntityComponentPb.ComponentOneofCase.TagComponent:
				if (this.TagComponent == null)
				{
					this.TagComponent = new TagComponentPb();
				}
				this.TagComponent.MergeFrom(other.TagComponent);
				break;
			case EntityComponentPb.ComponentOneofCase.TriggerComponent:
				if (this.TriggerComponent == null)
				{
					this.TriggerComponent = new TriggerComponentPb();
				}
				this.TriggerComponent.MergeFrom(other.TriggerComponent);
				break;
			case EntityComponentPb.ComponentOneofCase.SummonerComponent:
				if (this.SummonerComponent == null)
				{
					this.SummonerComponent = new SummonerComponentPb();
				}
				this.SummonerComponent.MergeFrom(other.SummonerComponent);
				break;
			case EntityComponentPb.ComponentOneofCase.PartComponent:
				if (this.PartComponent == null)
				{
					this.PartComponent = new PartComponentPb();
				}
				this.PartComponent.MergeFrom(other.PartComponent);
				break;
			case EntityComponentPb.ComponentOneofCase.VisionSkillComponent:
				if (this.VisionSkillComponent == null)
				{
					this.VisionSkillComponent = new VisionSkillComponentPb();
				}
				this.VisionSkillComponent.MergeFrom(other.VisionSkillComponent);
				break;
			case EntityComponentPb.ComponentOneofCase.AnimationStateComponent:
				if (this.AnimationStateComponent == null)
				{
					this.AnimationStateComponent = new AnimationStateComponentPb();
				}
				this.AnimationStateComponent.MergeFrom(other.AnimationStateComponent);
				break;
			case EntityComponentPb.ComponentOneofCase.BlackboardParamComponent:
				if (this.BlackboardParamComponent == null)
				{
					this.BlackboardParamComponent = new BlackboardParamComponentPb();
				}
				this.BlackboardParamComponent.MergeFrom(other.BlackboardParamComponent);
				break;
			case EntityComponentPb.ComponentOneofCase.SysBuffComponent:
				if (this.SysBuffComponent == null)
				{
					this.SysBuffComponent = new SysBuffComponentPb();
				}
				this.SysBuffComponent.MergeFrom(other.SysBuffComponent);
				break;
			case EntityComponentPb.ComponentOneofCase.ClientDataComponent:
				if (this.ClientDataComponent == null)
				{
					this.ClientDataComponent = new ClientDataComponentPb();
				}
				this.ClientDataComponent.MergeFrom(other.ClientDataComponent);
				break;
			case EntityComponentPb.ComponentOneofCase.MonsterWeaponComponentPb:
				if (this.MonsterWeaponComponentPb == null)
				{
					this.MonsterWeaponComponentPb = new MonsterWeaponComponentPb();
				}
				this.MonsterWeaponComponentPb.MergeFrom(other.MonsterWeaponComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.MonsterAiComponentPb:
				if (this.MonsterAiComponentPb == null)
				{
					this.MonsterAiComponentPb = new MonsterAiComponentPb();
				}
				this.MonsterAiComponentPb.MergeFrom(other.MonsterAiComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.FightBuffComponent:
				if (this.FightBuffComponent == null)
				{
					this.FightBuffComponent = new FightBuffComponentPb();
				}
				this.FightBuffComponent.MergeFrom(other.FightBuffComponent);
				break;
			case EntityComponentPb.ComponentOneofCase.NearbyTrackingComponentPb:
				if (this.NearbyTrackingComponentPb == null)
				{
					this.NearbyTrackingComponentPb = new NearbyTrackingComponentPb();
				}
				this.NearbyTrackingComponentPb.MergeFrom(other.NearbyTrackingComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.DropComponentPb:
				if (this.DropComponentPb == null)
				{
					this.DropComponentPb = new DropComponentPb();
				}
				this.DropComponentPb.MergeFrom(other.DropComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.MonsterCaptureComponent:
				if (this.MonsterCaptureComponent == null)
				{
					this.MonsterCaptureComponent = new MonsterCaptureComponentPb();
				}
				this.MonsterCaptureComponent.MergeFrom(other.MonsterCaptureComponent);
				break;
			case EntityComponentPb.ComponentOneofCase.LogicStateComponentPb:
				if (this.LogicStateComponentPb == null)
				{
					this.LogicStateComponentPb = new LogicStateComponentPb();
				}
				this.LogicStateComponentPb.MergeFrom(other.LogicStateComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.AdviceComponentPb:
				if (this.AdviceComponentPb == null)
				{
					this.AdviceComponentPb = new AdviceComponentPb();
				}
				this.AdviceComponentPb.MergeFrom(other.AdviceComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.LiftComponentPb:
				if (this.LiftComponentPb == null)
				{
					this.LiftComponentPb = new LiftComponentPb();
				}
				this.LiftComponentPb.MergeFrom(other.LiftComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.InteractComponent:
				if (this.InteractComponent == null)
				{
					this.InteractComponent = new InteractComponentPb();
				}
				this.InteractComponent.MergeFrom(other.InteractComponent);
				break;
			case EntityComponentPb.ComponentOneofCase.EquipComponent:
				if (this.EquipComponent == null)
				{
					this.EquipComponent = new EquipComponentPb();
				}
				this.EquipComponent.MergeFrom(other.EquipComponent);
				break;
			case EntityComponentPb.ComponentOneofCase.BeControlledComponentPb:
				if (this.BeControlledComponentPb == null)
				{
					this.BeControlledComponentPb = new BeControlledComponentPb();
				}
				this.BeControlledComponentPb.MergeFrom(other.BeControlledComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.ConcomitantsComponentPb:
				if (this.ConcomitantsComponentPb == null)
				{
					this.ConcomitantsComponentPb = new ConcomitantsComponentPb();
				}
				this.ConcomitantsComponentPb.MergeFrom(other.ConcomitantsComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.TimelineTrackComponentPb:
				if (this.TimelineTrackComponentPb == null)
				{
					this.TimelineTrackComponentPb = new TimelineTrackComponentPb();
				}
				this.TimelineTrackComponentPb.MergeFrom(other.TimelineTrackComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.SummonsComponentPb:
				if (this.SummonsComponentPb == null)
				{
					this.SummonsComponentPb = new SummonsComponentPb();
				}
				this.SummonsComponentPb.MergeFrom(other.SummonsComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.EntityFsmComponentPb:
				if (this.EntityFsmComponentPb == null)
				{
					this.EntityFsmComponentPb = new EntityFsmComponentPb();
				}
				this.EntityFsmComponentPb.MergeFrom(other.EntityFsmComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.BoardPb:
				if (this.BoardPb == null)
				{
					this.BoardPb = new BoardPb();
				}
				this.BoardPb.MergeFrom(other.BoardPb);
				break;
			case EntityComponentPb.ComponentOneofCase.PlacementItemPb:
				if (this.PlacementItemPb == null)
				{
					this.PlacementItemPb = new PlacementItemPb();
				}
				this.PlacementItemPb.MergeFrom(other.PlacementItemPb);
				break;
			case EntityComponentPb.ComponentOneofCase.StateTagComponentPb:
				if (this.StateTagComponentPb == null)
				{
					this.StateTagComponentPb = new StateTagComponentPb();
				}
				this.StateTagComponentPb.MergeFrom(other.StateTagComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.MonsterGachaDataPb:
				if (this.MonsterGachaDataPb == null)
				{
					this.MonsterGachaDataPb = new MonsterGachaDataPb();
				}
				this.MonsterGachaDataPb.MergeFrom(other.MonsterGachaDataPb);
				break;
			case EntityComponentPb.ComponentOneofCase.FanComponentPb:
				if (this.FanComponentPb == null)
				{
					this.FanComponentPb = new FanComponentPb();
				}
				this.FanComponentPb.MergeFrom(other.FanComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.NpcPb:
				if (this.NpcPb == null)
				{
					this.NpcPb = new NpcPb();
				}
				this.NpcPb.MergeFrom(other.NpcPb);
				break;
			case EntityComponentPb.ComponentOneofCase.BubbleComponent:
				if (this.BubbleComponent == null)
				{
					this.BubbleComponent = new BubbleComponentPb();
				}
				this.BubbleComponent.MergeFrom(other.BubbleComponent);
				break;
			case EntityComponentPb.ComponentOneofCase.PatrolComponent:
				if (this.PatrolComponent == null)
				{
					this.PatrolComponent = new PatrolComponentPb();
				}
				this.PatrolComponent.MergeFrom(other.PatrolComponent);
				break;
			case EntityComponentPb.ComponentOneofCase.RangeComponent:
				if (this.RangeComponent == null)
				{
					this.RangeComponent = new RangeComponentPb();
				}
				this.RangeComponent.MergeFrom(other.RangeComponent);
				break;
			case EntityComponentPb.ComponentOneofCase.PassiveSkillComponentPb:
				if (this.PassiveSkillComponentPb == null)
				{
					this.PassiveSkillComponentPb = new PassiveSkillComponentPb();
				}
				this.PassiveSkillComponentPb.MergeFrom(other.PassiveSkillComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.SkillComponentPb:
				if (this.SkillComponentPb == null)
				{
					this.SkillComponentPb = new SkillComponentPb();
				}
				this.SkillComponentPb.MergeFrom(other.SkillComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.DynamicAttachComponentPb:
				if (this.DynamicAttachComponentPb == null)
				{
					this.DynamicAttachComponentPb = new DynamicAttachComponentPb();
				}
				this.DynamicAttachComponentPb.MergeFrom(other.DynamicAttachComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.VarComponentPb:
				if (this.VarComponentPb == null)
				{
					this.VarComponentPb = new VarComponentPb();
				}
				this.VarComponentPb.MergeFrom(other.VarComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.PlayerFollowerSelfComponentPb:
				if (this.PlayerFollowerSelfComponentPb == null)
				{
					this.PlayerFollowerSelfComponentPb = new PlayerFollowerSelfComponentPb();
				}
				this.PlayerFollowerSelfComponentPb.MergeFrom(other.PlayerFollowerSelfComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.SceneItemLifeCycleComponentPb:
				if (this.SceneItemLifeCycleComponentPb == null)
				{
					this.SceneItemLifeCycleComponentPb = new SceneItemLifeCycleComponentPb();
				}
				this.SceneItemLifeCycleComponentPb.MergeFrom(other.SceneItemLifeCycleComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.EntityBulletComponentPb:
				if (this.EntityBulletComponentPb == null)
				{
					this.EntityBulletComponentPb = new EntityBulletComponentPb();
				}
				this.EntityBulletComponentPb.MergeFrom(other.EntityBulletComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.BuffProducerComponentPb:
				if (this.BuffProducerComponentPb == null)
				{
					this.BuffProducerComponentPb = new BuffProducerComponentPb();
				}
				this.BuffProducerComponentPb.MergeFrom(other.BuffProducerComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.BuffConsumerComponentPb:
				if (this.BuffConsumerComponentPb == null)
				{
					this.BuffConsumerComponentPb = new BuffConsumerComponentPb();
				}
				this.BuffConsumerComponentPb.MergeFrom(other.BuffConsumerComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.SceneItemComponentPb:
				if (this.SceneItemComponentPb == null)
				{
					this.SceneItemComponentPb = new SceneItemComponentPb();
				}
				this.SceneItemComponentPb.MergeFrom(other.SceneItemComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.ShieldComponentPb:
				if (this.ShieldComponentPb == null)
				{
					this.ShieldComponentPb = new ShieldComponentPb();
				}
				this.ShieldComponentPb.MergeFrom(other.ShieldComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.NpcPerformComponentPb:
				if (this.NpcPerformComponentPb == null)
				{
					this.NpcPerformComponentPb = new NpcPerformComponentPb();
				}
				this.NpcPerformComponentPb.MergeFrom(other.NpcPerformComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.DependenceComponentPb:
				if (this.DependenceComponentPb == null)
				{
					this.DependenceComponentPb = new DependenceComponentPb();
				}
				this.DependenceComponentPb.MergeFrom(other.DependenceComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.RenjuDataPb:
				if (this.RenjuDataPb == null)
				{
					this.RenjuDataPb = new RenjuDataPb();
				}
				this.RenjuDataPb.MergeFrom(other.RenjuDataPb);
				break;
			case EntityComponentPb.ComponentOneofCase.AiRoleComponentPb:
				if (this.AiRoleComponentPb == null)
				{
					this.AiRoleComponentPb = new AiRoleComponentPb();
				}
				this.AiRoleComponentPb.MergeFrom(other.AiRoleComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.PlayerFollowersComponentPb:
				if (this.PlayerFollowersComponentPb == null)
				{
					this.PlayerFollowersComponentPb = new PlayerFollowersComponentPb();
				}
				this.PlayerFollowersComponentPb.MergeFrom(other.PlayerFollowersComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.SceneItemAttributeComponentPb:
				if (this.SceneItemAttributeComponentPb == null)
				{
					this.SceneItemAttributeComponentPb = new SceneItemAttributeComponentPb();
				}
				this.SceneItemAttributeComponentPb.MergeFrom(other.SceneItemAttributeComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.PullingFoundationComponentPb:
				if (this.PullingFoundationComponentPb == null)
				{
					this.PullingFoundationComponentPb = new PullingFoundationComponentPb();
				}
				this.PullingFoundationComponentPb.MergeFrom(other.PullingFoundationComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.BatchBulletCastComponentPb:
				if (this.BatchBulletCastComponentPb == null)
				{
					this.BatchBulletCastComponentPb = new BatchBulletCastComponentPb();
				}
				this.BatchBulletCastComponentPb.MergeFrom(other.BatchBulletCastComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.RoleWeaponSkinComponent:
				if (this.RoleWeaponSkinComponent == null)
				{
					this.RoleWeaponSkinComponent = new RoleWeaponSkinComponentPb();
				}
				this.RoleWeaponSkinComponent.MergeFrom(other.RoleWeaponSkinComponent);
				break;
			case EntityComponentPb.ComponentOneofCase.CombineEntityInfoPb:
				if (this.CombineEntityInfoPb == null)
				{
					this.CombineEntityInfoPb = new CombineEntityInfoPb();
				}
				this.CombineEntityInfoPb.MergeFrom(other.CombineEntityInfoPb);
				break;
			case EntityComponentPb.ComponentOneofCase.SceneItemAiComponentPb:
				if (this.SceneItemAiComponentPb == null)
				{
					this.SceneItemAiComponentPb = new SceneItemAiComponentPb();
				}
				this.SceneItemAiComponentPb.MergeFrom(other.SceneItemAiComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.AnimalCollectComponentPb:
				if (this.AnimalCollectComponentPb == null)
				{
					this.AnimalCollectComponentPb = new AnimalCollectComponentPb();
				}
				this.AnimalCollectComponentPb.MergeFrom(other.AnimalCollectComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.VehiclePassengerComponentPb:
				if (this.VehiclePassengerComponentPb == null)
				{
					this.VehiclePassengerComponentPb = new VehiclePassengerComponentPb();
				}
				this.VehiclePassengerComponentPb.MergeFrom(other.VehiclePassengerComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.HookLockPointComponentPb:
				if (this.HookLockPointComponentPb == null)
				{
					this.HookLockPointComponentPb = new HookLockPointComponentPb();
				}
				this.HookLockPointComponentPb.MergeFrom(other.HookLockPointComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.HackingComponentPb:
				if (this.HackingComponentPb == null)
				{
					this.HackingComponentPb = new HackingComponentPb();
				}
				this.HackingComponentPb.MergeFrom(other.HackingComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.HackTargetComponentPb:
				if (this.HackTargetComponentPb == null)
				{
					this.HackTargetComponentPb = new HackTargetComponentPb();
				}
				this.HackTargetComponentPb.MergeFrom(other.HackTargetComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.GravityFlipComponentPb:
				if (this.GravityFlipComponentPb == null)
				{
					this.GravityFlipComponentPb = new GravityFlipComponentPb();
				}
				this.GravityFlipComponentPb.MergeFrom(other.GravityFlipComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.EntityMoveSplineComponentPb:
				if (this.EntityMoveSplineComponentPb == null)
				{
					this.EntityMoveSplineComponentPb = new EntityMoveSplineComponentPb();
				}
				this.EntityMoveSplineComponentPb.MergeFrom(other.EntityMoveSplineComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.EntityRewardItemPb:
				if (this.EntityRewardItemPb == null)
				{
					this.EntityRewardItemPb = new EntityRewardItemPb();
				}
				this.EntityRewardItemPb.MergeFrom(other.EntityRewardItemPb);
				break;
			case EntityComponentPb.ComponentOneofCase.TemplateEntitySpawnerComponentPb:
				if (this.TemplateEntitySpawnerComponentPb == null)
				{
					this.TemplateEntitySpawnerComponentPb = new TemplateEntitySpawnerComponentPb();
				}
				this.TemplateEntitySpawnerComponentPb.MergeFrom(other.TemplateEntitySpawnerComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.GridObjectComponentPb:
				if (this.GridObjectComponentPb == null)
				{
					this.GridObjectComponentPb = new GridObjectComponentPb();
				}
				this.GridObjectComponentPb.MergeFrom(other.GridObjectComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.SimpleCombatComponentPb:
				if (this.SimpleCombatComponentPb == null)
				{
					this.SimpleCombatComponentPb = new SimpleCombatComponentPb();
				}
				this.SimpleCombatComponentPb.MergeFrom(other.SimpleCombatComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.TrapDefenseComponentPb:
				if (this.TrapDefenseComponentPb == null)
				{
					this.TrapDefenseComponentPb = new TrapDefenseComponentPb();
				}
				this.TrapDefenseComponentPb.MergeFrom(other.TrapDefenseComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.HoldHandComponentPb:
				if (this.HoldHandComponentPb == null)
				{
					this.HoldHandComponentPb = new HoldHandComponentPb();
				}
				this.HoldHandComponentPb.MergeFrom(other.HoldHandComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.ListenerComponentPb:
				if (this.ListenerComponentPb == null)
				{
					this.ListenerComponentPb = new SceneItemEventListenerComponentPb();
				}
				this.ListenerComponentPb.MergeFrom(other.ListenerComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.ActivityComponentPb:
				if (this.ActivityComponentPb == null)
				{
					this.ActivityComponentPb = new ActivityComponentPb();
				}
				this.ActivityComponentPb.MergeFrom(other.ActivityComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.CalabashSkinComponentPb:
				if (this.CalabashSkinComponentPb == null)
				{
					this.CalabashSkinComponentPb = new CalabashSkinComponentPb();
				}
				this.CalabashSkinComponentPb.MergeFrom(other.CalabashSkinComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.HonamiStoryDropItemComponentPb:
				if (this.HonamiStoryDropItemComponentPb == null)
				{
					this.HonamiStoryDropItemComponentPb = new HonamiStoryDropItemComponentPb();
				}
				this.HonamiStoryDropItemComponentPb.MergeFrom(other.HonamiStoryDropItemComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.HonamiStoryEnhanceLevelComponentPb:
				if (this.HonamiStoryEnhanceLevelComponentPb == null)
				{
					this.HonamiStoryEnhanceLevelComponentPb = new HonamiStoryEnhanceLevelComponentPb();
				}
				this.HonamiStoryEnhanceLevelComponentPb.MergeFrom(other.HonamiStoryEnhanceLevelComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.MoveToPointComponentPb:
				if (this.MoveToPointComponentPb == null)
				{
					this.MoveToPointComponentPb = new MoveToPointComponentPb();
				}
				this.MoveToPointComponentPb.MergeFrom(other.MoveToPointComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.RbBlockComponentPb:
				if (this.RbBlockComponentPb == null)
				{
					this.RbBlockComponentPb = new RbBlockComponentPb();
				}
				this.RbBlockComponentPb.MergeFrom(other.RbBlockComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.SpiritGearComponentPb:
				if (this.SpiritGearComponentPb == null)
				{
					this.SpiritGearComponentPb = new SunSpiritGearComponentPb();
				}
				this.SpiritGearComponentPb.MergeFrom(other.SpiritGearComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.VehiclePb:
				if (this.VehiclePb == null)
				{
					this.VehiclePb = new VehiclePb();
				}
				this.VehiclePb.MergeFrom(other.VehiclePb);
				break;
			case EntityComponentPb.ComponentOneofCase.RbFloorComponentPb:
				if (this.RbFloorComponentPb == null)
				{
					this.RbFloorComponentPb = new RbFloorComponentPb();
				}
				this.RbFloorComponentPb.MergeFrom(other.RbFloorComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.RbItemComponentPb:
				if (this.RbItemComponentPb == null)
				{
					this.RbItemComponentPb = new RbItemComponentPb();
				}
				this.RbItemComponentPb.MergeFrom(other.RbItemComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.RoadNetworkComponentPb:
				if (this.RoadNetworkComponentPb == null)
				{
					this.RoadNetworkComponentPb = new RoadNetworkComponentPb();
				}
				this.RoadNetworkComponentPb.MergeFrom(other.RoadNetworkComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.FollowEntityComponentPb:
				if (this.FollowEntityComponentPb == null)
				{
					this.FollowEntityComponentPb = new FollowEntityComponentPb();
				}
				this.FollowEntityComponentPb.MergeFrom(other.FollowEntityComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.MotorOutlookComponentPb:
				if (this.MotorOutlookComponentPb == null)
				{
					this.MotorOutlookComponentPb = new MotorOutlookEquippedPb();
				}
				this.MotorOutlookComponentPb.MergeFrom(other.MotorOutlookComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.MotorDaCtxComponentPb:
				if (this.MotorDaCtxComponentPb == null)
				{
					this.MotorDaCtxComponentPb = new MotorDaCtxComponentPb();
				}
				this.MotorDaCtxComponentPb.MergeFrom(other.MotorDaCtxComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.ExhibitionComponentPb:
				if (this.ExhibitionComponentPb == null)
				{
					this.ExhibitionComponentPb = new ExhibitionComponentPb();
				}
				this.ExhibitionComponentPb.MergeFrom(other.ExhibitionComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.FurnitureComponentPb:
				if (this.FurnitureComponentPb == null)
				{
					this.FurnitureComponentPb = new FurnitureComponentPb();
				}
				this.FurnitureComponentPb.MergeFrom(other.FurnitureComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.OrnamentComponentPb:
				if (this.OrnamentComponentPb == null)
				{
					this.OrnamentComponentPb = new OrnamentComponentPb();
				}
				this.OrnamentComponentPb.MergeFrom(other.OrnamentComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.FlowerPollutionComponentPb:
				if (this.FlowerPollutionComponentPb == null)
				{
					this.FlowerPollutionComponentPb = new FlowerPollutionComponentPb();
				}
				this.FlowerPollutionComponentPb.MergeFrom(other.FlowerPollutionComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.DollGrabMachineComponentPb:
				if (this.DollGrabMachineComponentPb == null)
				{
					this.DollGrabMachineComponentPb = new DollGrabMachineComponentPb();
				}
				this.DollGrabMachineComponentPb.MergeFrom(other.DollGrabMachineComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.DollGrabShowcaseComponentPb:
				if (this.DollGrabShowcaseComponentPb == null)
				{
					this.DollGrabShowcaseComponentPb = new DollGrabShowcaseComponentPb();
				}
				this.DollGrabShowcaseComponentPb.MergeFrom(other.DollGrabShowcaseComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.GpuEntityComponentPb:
				if (this.GpuEntityComponentPb == null)
				{
					this.GpuEntityComponentPb = new GpuEntityComponentPb();
				}
				this.GpuEntityComponentPb.MergeFrom(other.GpuEntityComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.RoverRoguePortalComponentPb:
				if (this.RoverRoguePortalComponentPb == null)
				{
					this.RoverRoguePortalComponentPb = new RoverRoguePortalComponentPb();
				}
				this.RoverRoguePortalComponentPb.MergeFrom(other.RoverRoguePortalComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.ElementalHolderComponentPb:
				if (this.ElementalHolderComponentPb == null)
				{
					this.ElementalHolderComponentPb = new ElementalHolderComponentPb();
				}
				this.ElementalHolderComponentPb.MergeFrom(other.ElementalHolderComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.SkillAvatarComponentPb:
				if (this.SkillAvatarComponentPb == null)
				{
					this.SkillAvatarComponentPb = new SkillAvatarComponentPb();
				}
				this.SkillAvatarComponentPb.MergeFrom(other.SkillAvatarComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.EntityFoundationComponentPb:
				if (this.EntityFoundationComponentPb == null)
				{
					this.EntityFoundationComponentPb = new EntityFoundationComponentPb();
				}
				this.EntityFoundationComponentPb.MergeFrom(other.EntityFoundationComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.SquadPropComponentPb:
				if (this.SquadPropComponentPb == null)
				{
					this.SquadPropComponentPb = new SquadPropComponentPb();
				}
				this.SquadPropComponentPb.MergeFrom(other.SquadPropComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.ConnectorComponentPb:
				if (this.ConnectorComponentPb == null)
				{
					this.ConnectorComponentPb = new ConnectorComponentPb();
				}
				this.ConnectorComponentPb.MergeFrom(other.ConnectorComponentPb);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006CCD RID: 27853 RVA: 0x0010A8B8 File Offset: 0x00108AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006CCE RID: 27854 RVA: 0x0010A8C4 File Offset: 0x00108AC4
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
				if (num <= 410U)
				{
					if (num <= 210U)
					{
						if (num <= 106U)
						{
							if (num <= 50U)
							{
								if (num <= 26U)
								{
									if (num == 10U)
									{
										AttributeComponentPb attributeComponentPb = new AttributeComponentPb();
										if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.AttributeComponent)
										{
											attributeComponentPb.MergeFrom(this.AttributeComponent);
										}
										input.ReadMessage(attributeComponentPb);
										this.AttributeComponent = attributeComponentPb;
										continue;
									}
									if (num == 18U)
									{
										TagComponentPb tagComponentPb = new TagComponentPb();
										if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.TagComponent)
										{
											tagComponentPb.MergeFrom(this.TagComponent);
										}
										input.ReadMessage(tagComponentPb);
										this.TagComponent = tagComponentPb;
										continue;
									}
									if (num == 26U)
									{
										TriggerComponentPb triggerComponentPb = new TriggerComponentPb();
										if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.TriggerComponent)
										{
											triggerComponentPb.MergeFrom(this.TriggerComponent);
										}
										input.ReadMessage(triggerComponentPb);
										this.TriggerComponent = triggerComponentPb;
										continue;
									}
								}
								else
								{
									if (num == 34U)
									{
										SummonerComponentPb summonerComponentPb = new SummonerComponentPb();
										if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SummonerComponent)
										{
											summonerComponentPb.MergeFrom(this.SummonerComponent);
										}
										input.ReadMessage(summonerComponentPb);
										this.SummonerComponent = summonerComponentPb;
										continue;
									}
									if (num == 42U)
									{
										PartComponentPb partComponentPb = new PartComponentPb();
										if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PartComponent)
										{
											partComponentPb.MergeFrom(this.PartComponent);
										}
										input.ReadMessage(partComponentPb);
										this.PartComponent = partComponentPb;
										continue;
									}
									if (num == 50U)
									{
										VisionSkillComponentPb visionSkillComponentPb = new VisionSkillComponentPb();
										if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.VisionSkillComponent)
										{
											visionSkillComponentPb.MergeFrom(this.VisionSkillComponent);
										}
										input.ReadMessage(visionSkillComponentPb);
										this.VisionSkillComponent = visionSkillComponentPb;
										continue;
									}
								}
							}
							else if (num <= 82U)
							{
								if (num == 58U)
								{
									AnimationStateComponentPb animationStateComponentPb = new AnimationStateComponentPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.AnimationStateComponent)
									{
										animationStateComponentPb.MergeFrom(this.AnimationStateComponent);
									}
									input.ReadMessage(animationStateComponentPb);
									this.AnimationStateComponent = animationStateComponentPb;
									continue;
								}
								if (num == 66U)
								{
									BlackboardParamComponentPb blackboardParamComponentPb = new BlackboardParamComponentPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BlackboardParamComponent)
									{
										blackboardParamComponentPb.MergeFrom(this.BlackboardParamComponent);
									}
									input.ReadMessage(blackboardParamComponentPb);
									this.BlackboardParamComponent = blackboardParamComponentPb;
									continue;
								}
								if (num == 82U)
								{
									SysBuffComponentPb sysBuffComponentPb = new SysBuffComponentPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SysBuffComponent)
									{
										sysBuffComponentPb.MergeFrom(this.SysBuffComponent);
									}
									input.ReadMessage(sysBuffComponentPb);
									this.SysBuffComponent = sysBuffComponentPb;
									continue;
								}
							}
							else
							{
								if (num == 90U)
								{
									ClientDataComponentPb clientDataComponentPb = new ClientDataComponentPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ClientDataComponent)
									{
										clientDataComponentPb.MergeFrom(this.ClientDataComponent);
									}
									input.ReadMessage(clientDataComponentPb);
									this.ClientDataComponent = clientDataComponentPb;
									continue;
								}
								if (num == 98U)
								{
									MonsterWeaponComponentPb monsterWeaponComponentPb = new MonsterWeaponComponentPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MonsterWeaponComponentPb)
									{
										monsterWeaponComponentPb.MergeFrom(this.MonsterWeaponComponentPb);
									}
									input.ReadMessage(monsterWeaponComponentPb);
									this.MonsterWeaponComponentPb = monsterWeaponComponentPb;
									continue;
								}
								if (num == 106U)
								{
									MonsterAiComponentPb monsterAiComponentPb = new MonsterAiComponentPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MonsterAiComponentPb)
									{
										monsterAiComponentPb.MergeFrom(this.MonsterAiComponentPb);
									}
									input.ReadMessage(monsterAiComponentPb);
									this.MonsterAiComponentPb = monsterAiComponentPb;
									continue;
								}
							}
						}
						else if (num <= 162U)
						{
							if (num <= 138U)
							{
								if (num == 122U)
								{
									FightBuffComponentPb fightBuffComponentPb = new FightBuffComponentPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.FightBuffComponent)
									{
										fightBuffComponentPb.MergeFrom(this.FightBuffComponent);
									}
									input.ReadMessage(fightBuffComponentPb);
									this.FightBuffComponent = fightBuffComponentPb;
									continue;
								}
								if (num == 130U)
								{
									NearbyTrackingComponentPb nearbyTrackingComponentPb = new NearbyTrackingComponentPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.NearbyTrackingComponentPb)
									{
										nearbyTrackingComponentPb.MergeFrom(this.NearbyTrackingComponentPb);
									}
									input.ReadMessage(nearbyTrackingComponentPb);
									this.NearbyTrackingComponentPb = nearbyTrackingComponentPb;
									continue;
								}
								if (num == 138U)
								{
									DropComponentPb dropComponentPb = new DropComponentPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DropComponentPb)
									{
										dropComponentPb.MergeFrom(this.DropComponentPb);
									}
									input.ReadMessage(dropComponentPb);
									this.DropComponentPb = dropComponentPb;
									continue;
								}
							}
							else
							{
								if (num == 146U)
								{
									MonsterCaptureComponentPb monsterCaptureComponentPb = new MonsterCaptureComponentPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MonsterCaptureComponent)
									{
										monsterCaptureComponentPb.MergeFrom(this.MonsterCaptureComponent);
									}
									input.ReadMessage(monsterCaptureComponentPb);
									this.MonsterCaptureComponent = monsterCaptureComponentPb;
									continue;
								}
								if (num == 154U)
								{
									LogicStateComponentPb logicStateComponentPb = new LogicStateComponentPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.LogicStateComponentPb)
									{
										logicStateComponentPb.MergeFrom(this.LogicStateComponentPb);
									}
									input.ReadMessage(logicStateComponentPb);
									this.LogicStateComponentPb = logicStateComponentPb;
									continue;
								}
								if (num == 162U)
								{
									AdviceComponentPb adviceComponentPb = new AdviceComponentPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.AdviceComponentPb)
									{
										adviceComponentPb.MergeFrom(this.AdviceComponentPb);
									}
									input.ReadMessage(adviceComponentPb);
									this.AdviceComponentPb = adviceComponentPb;
									continue;
								}
							}
						}
						else if (num <= 186U)
						{
							if (num == 170U)
							{
								LiftComponentPb liftComponentPb = new LiftComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.LiftComponentPb)
								{
									liftComponentPb.MergeFrom(this.LiftComponentPb);
								}
								input.ReadMessage(liftComponentPb);
								this.LiftComponentPb = liftComponentPb;
								continue;
							}
							if (num == 178U)
							{
								InteractComponentPb interactComponentPb = new InteractComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.InteractComponent)
								{
									interactComponentPb.MergeFrom(this.InteractComponent);
								}
								input.ReadMessage(interactComponentPb);
								this.InteractComponent = interactComponentPb;
								continue;
							}
							if (num == 186U)
							{
								EquipComponentPb equipComponentPb = new EquipComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EquipComponent)
								{
									equipComponentPb.MergeFrom(this.EquipComponent);
								}
								input.ReadMessage(equipComponentPb);
								this.EquipComponent = equipComponentPb;
								continue;
							}
						}
						else
						{
							if (num == 194U)
							{
								BeControlledComponentPb beControlledComponentPb = new BeControlledComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BeControlledComponentPb)
								{
									beControlledComponentPb.MergeFrom(this.BeControlledComponentPb);
								}
								input.ReadMessage(beControlledComponentPb);
								this.BeControlledComponentPb = beControlledComponentPb;
								continue;
							}
							if (num == 202U)
							{
								ConcomitantsComponentPb concomitantsComponentPb = new ConcomitantsComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ConcomitantsComponentPb)
								{
									concomitantsComponentPb.MergeFrom(this.ConcomitantsComponentPb);
								}
								input.ReadMessage(concomitantsComponentPb);
								this.ConcomitantsComponentPb = concomitantsComponentPb;
								continue;
							}
							if (num == 210U)
							{
								TimelineTrackComponentPb timelineTrackComponentPb = new TimelineTrackComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.TimelineTrackComponentPb)
								{
									timelineTrackComponentPb.MergeFrom(this.TimelineTrackComponentPb);
								}
								input.ReadMessage(timelineTrackComponentPb);
								this.TimelineTrackComponentPb = timelineTrackComponentPb;
								continue;
							}
						}
					}
					else if (num <= 306U)
					{
						if (num <= 258U)
						{
							if (num <= 234U)
							{
								if (num == 218U)
								{
									SummonsComponentPb summonsComponentPb = new SummonsComponentPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SummonsComponentPb)
									{
										summonsComponentPb.MergeFrom(this.SummonsComponentPb);
									}
									input.ReadMessage(summonsComponentPb);
									this.SummonsComponentPb = summonsComponentPb;
									continue;
								}
								if (num == 226U)
								{
									EntityFsmComponentPb entityFsmComponentPb = new EntityFsmComponentPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EntityFsmComponentPb)
									{
										entityFsmComponentPb.MergeFrom(this.EntityFsmComponentPb);
									}
									input.ReadMessage(entityFsmComponentPb);
									this.EntityFsmComponentPb = entityFsmComponentPb;
									continue;
								}
								if (num == 234U)
								{
									BoardPb boardPb = new BoardPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BoardPb)
									{
										boardPb.MergeFrom(this.BoardPb);
									}
									input.ReadMessage(boardPb);
									this.BoardPb = boardPb;
									continue;
								}
							}
							else
							{
								if (num == 242U)
								{
									PlacementItemPb placementItemPb = new PlacementItemPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PlacementItemPb)
									{
										placementItemPb.MergeFrom(this.PlacementItemPb);
									}
									input.ReadMessage(placementItemPb);
									this.PlacementItemPb = placementItemPb;
									continue;
								}
								if (num == 250U)
								{
									StateTagComponentPb stateTagComponentPb = new StateTagComponentPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.StateTagComponentPb)
									{
										stateTagComponentPb.MergeFrom(this.StateTagComponentPb);
									}
									input.ReadMessage(stateTagComponentPb);
									this.StateTagComponentPb = stateTagComponentPb;
									continue;
								}
								if (num == 258U)
								{
									MonsterGachaDataPb monsterGachaDataPb = new MonsterGachaDataPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MonsterGachaDataPb)
									{
										monsterGachaDataPb.MergeFrom(this.MonsterGachaDataPb);
									}
									input.ReadMessage(monsterGachaDataPb);
									this.MonsterGachaDataPb = monsterGachaDataPb;
									continue;
								}
							}
						}
						else if (num <= 282U)
						{
							if (num == 266U)
							{
								FanComponentPb fanComponentPb = new FanComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.FanComponentPb)
								{
									fanComponentPb.MergeFrom(this.FanComponentPb);
								}
								input.ReadMessage(fanComponentPb);
								this.FanComponentPb = fanComponentPb;
								continue;
							}
							if (num == 274U)
							{
								NpcPb npcPb = new NpcPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.NpcPb)
								{
									npcPb.MergeFrom(this.NpcPb);
								}
								input.ReadMessage(npcPb);
								this.NpcPb = npcPb;
								continue;
							}
							if (num == 282U)
							{
								BubbleComponentPb bubbleComponentPb = new BubbleComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BubbleComponent)
								{
									bubbleComponentPb.MergeFrom(this.BubbleComponent);
								}
								input.ReadMessage(bubbleComponentPb);
								this.BubbleComponent = bubbleComponentPb;
								continue;
							}
						}
						else
						{
							if (num == 290U)
							{
								PatrolComponentPb patrolComponentPb = new PatrolComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PatrolComponent)
								{
									patrolComponentPb.MergeFrom(this.PatrolComponent);
								}
								input.ReadMessage(patrolComponentPb);
								this.PatrolComponent = patrolComponentPb;
								continue;
							}
							if (num == 298U)
							{
								RangeComponentPb rangeComponentPb = new RangeComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RangeComponent)
								{
									rangeComponentPb.MergeFrom(this.RangeComponent);
								}
								input.ReadMessage(rangeComponentPb);
								this.RangeComponent = rangeComponentPb;
								continue;
							}
							if (num == 306U)
							{
								PassiveSkillComponentPb passiveSkillComponentPb = new PassiveSkillComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PassiveSkillComponentPb)
								{
									passiveSkillComponentPb.MergeFrom(this.PassiveSkillComponentPb);
								}
								input.ReadMessage(passiveSkillComponentPb);
								this.PassiveSkillComponentPb = passiveSkillComponentPb;
								continue;
							}
						}
					}
					else if (num <= 354U)
					{
						if (num <= 330U)
						{
							if (num == 314U)
							{
								SkillComponentPb skillComponentPb = new SkillComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SkillComponentPb)
								{
									skillComponentPb.MergeFrom(this.SkillComponentPb);
								}
								input.ReadMessage(skillComponentPb);
								this.SkillComponentPb = skillComponentPb;
								continue;
							}
							if (num == 322U)
							{
								DynamicAttachComponentPb dynamicAttachComponentPb = new DynamicAttachComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DynamicAttachComponentPb)
								{
									dynamicAttachComponentPb.MergeFrom(this.DynamicAttachComponentPb);
								}
								input.ReadMessage(dynamicAttachComponentPb);
								this.DynamicAttachComponentPb = dynamicAttachComponentPb;
								continue;
							}
							if (num == 330U)
							{
								VarComponentPb varComponentPb = new VarComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.VarComponentPb)
								{
									varComponentPb.MergeFrom(this.VarComponentPb);
								}
								input.ReadMessage(varComponentPb);
								this.VarComponentPb = varComponentPb;
								continue;
							}
						}
						else
						{
							if (num == 338U)
							{
								PlayerFollowerSelfComponentPb playerFollowerSelfComponentPb = new PlayerFollowerSelfComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PlayerFollowerSelfComponentPb)
								{
									playerFollowerSelfComponentPb.MergeFrom(this.PlayerFollowerSelfComponentPb);
								}
								input.ReadMessage(playerFollowerSelfComponentPb);
								this.PlayerFollowerSelfComponentPb = playerFollowerSelfComponentPb;
								continue;
							}
							if (num == 346U)
							{
								SceneItemLifeCycleComponentPb sceneItemLifeCycleComponentPb = new SceneItemLifeCycleComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SceneItemLifeCycleComponentPb)
								{
									sceneItemLifeCycleComponentPb.MergeFrom(this.SceneItemLifeCycleComponentPb);
								}
								input.ReadMessage(sceneItemLifeCycleComponentPb);
								this.SceneItemLifeCycleComponentPb = sceneItemLifeCycleComponentPb;
								continue;
							}
							if (num == 354U)
							{
								EntityBulletComponentPb entityBulletComponentPb = new EntityBulletComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EntityBulletComponentPb)
								{
									entityBulletComponentPb.MergeFrom(this.EntityBulletComponentPb);
								}
								input.ReadMessage(entityBulletComponentPb);
								this.EntityBulletComponentPb = entityBulletComponentPb;
								continue;
							}
						}
					}
					else if (num <= 378U)
					{
						if (num == 362U)
						{
							BuffProducerComponentPb buffProducerComponentPb = new BuffProducerComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BuffProducerComponentPb)
							{
								buffProducerComponentPb.MergeFrom(this.BuffProducerComponentPb);
							}
							input.ReadMessage(buffProducerComponentPb);
							this.BuffProducerComponentPb = buffProducerComponentPb;
							continue;
						}
						if (num == 370U)
						{
							BuffConsumerComponentPb buffConsumerComponentPb = new BuffConsumerComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BuffConsumerComponentPb)
							{
								buffConsumerComponentPb.MergeFrom(this.BuffConsumerComponentPb);
							}
							input.ReadMessage(buffConsumerComponentPb);
							this.BuffConsumerComponentPb = buffConsumerComponentPb;
							continue;
						}
						if (num == 378U)
						{
							SceneItemComponentPb sceneItemComponentPb = new SceneItemComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SceneItemComponentPb)
							{
								sceneItemComponentPb.MergeFrom(this.SceneItemComponentPb);
							}
							input.ReadMessage(sceneItemComponentPb);
							this.SceneItemComponentPb = sceneItemComponentPb;
							continue;
						}
					}
					else if (num <= 394U)
					{
						if (num == 386U)
						{
							ShieldComponentPb shieldComponentPb = new ShieldComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ShieldComponentPb)
							{
								shieldComponentPb.MergeFrom(this.ShieldComponentPb);
							}
							input.ReadMessage(shieldComponentPb);
							this.ShieldComponentPb = shieldComponentPb;
							continue;
						}
						if (num == 394U)
						{
							NpcPerformComponentPb npcPerformComponentPb = new NpcPerformComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.NpcPerformComponentPb)
							{
								npcPerformComponentPb.MergeFrom(this.NpcPerformComponentPb);
							}
							input.ReadMessage(npcPerformComponentPb);
							this.NpcPerformComponentPb = npcPerformComponentPb;
							continue;
						}
					}
					else
					{
						if (num == 402U)
						{
							DependenceComponentPb dependenceComponentPb = new DependenceComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DependenceComponentPb)
							{
								dependenceComponentPb.MergeFrom(this.DependenceComponentPb);
							}
							input.ReadMessage(dependenceComponentPb);
							this.DependenceComponentPb = dependenceComponentPb;
							continue;
						}
						if (num == 410U)
						{
							RenjuDataPb renjuDataPb = new RenjuDataPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RenjuDataPb)
							{
								renjuDataPb.MergeFrom(this.RenjuDataPb);
							}
							input.ReadMessage(renjuDataPb);
							this.RenjuDataPb = renjuDataPb;
							continue;
						}
					}
				}
				else if (num <= 602U)
				{
					if (num <= 506U)
					{
						if (num <= 458U)
						{
							if (num <= 434U)
							{
								if (num == 418U)
								{
									AiRoleComponentPb aiRoleComponentPb = new AiRoleComponentPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.AiRoleComponentPb)
									{
										aiRoleComponentPb.MergeFrom(this.AiRoleComponentPb);
									}
									input.ReadMessage(aiRoleComponentPb);
									this.AiRoleComponentPb = aiRoleComponentPb;
									continue;
								}
								if (num == 426U)
								{
									PlayerFollowersComponentPb playerFollowersComponentPb = new PlayerFollowersComponentPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PlayerFollowersComponentPb)
									{
										playerFollowersComponentPb.MergeFrom(this.PlayerFollowersComponentPb);
									}
									input.ReadMessage(playerFollowersComponentPb);
									this.PlayerFollowersComponentPb = playerFollowersComponentPb;
									continue;
								}
								if (num == 434U)
								{
									SceneItemAttributeComponentPb sceneItemAttributeComponentPb = new SceneItemAttributeComponentPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SceneItemAttributeComponentPb)
									{
										sceneItemAttributeComponentPb.MergeFrom(this.SceneItemAttributeComponentPb);
									}
									input.ReadMessage(sceneItemAttributeComponentPb);
									this.SceneItemAttributeComponentPb = sceneItemAttributeComponentPb;
									continue;
								}
							}
							else
							{
								if (num == 442U)
								{
									PullingFoundationComponentPb pullingFoundationComponentPb = new PullingFoundationComponentPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.PullingFoundationComponentPb)
									{
										pullingFoundationComponentPb.MergeFrom(this.PullingFoundationComponentPb);
									}
									input.ReadMessage(pullingFoundationComponentPb);
									this.PullingFoundationComponentPb = pullingFoundationComponentPb;
									continue;
								}
								if (num == 450U)
								{
									BatchBulletCastComponentPb batchBulletCastComponentPb = new BatchBulletCastComponentPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.BatchBulletCastComponentPb)
									{
										batchBulletCastComponentPb.MergeFrom(this.BatchBulletCastComponentPb);
									}
									input.ReadMessage(batchBulletCastComponentPb);
									this.BatchBulletCastComponentPb = batchBulletCastComponentPb;
									continue;
								}
								if (num == 458U)
								{
									RoleWeaponSkinComponentPb roleWeaponSkinComponentPb = new RoleWeaponSkinComponentPb();
									if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RoleWeaponSkinComponent)
									{
										roleWeaponSkinComponentPb.MergeFrom(this.RoleWeaponSkinComponent);
									}
									input.ReadMessage(roleWeaponSkinComponentPb);
									this.RoleWeaponSkinComponent = roleWeaponSkinComponentPb;
									continue;
								}
							}
						}
						else if (num <= 482U)
						{
							if (num == 466U)
							{
								CombineEntityInfoPb combineEntityInfoPb = new CombineEntityInfoPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.CombineEntityInfoPb)
								{
									combineEntityInfoPb.MergeFrom(this.CombineEntityInfoPb);
								}
								input.ReadMessage(combineEntityInfoPb);
								this.CombineEntityInfoPb = combineEntityInfoPb;
								continue;
							}
							if (num == 474U)
							{
								SceneItemAiComponentPb sceneItemAiComponentPb = new SceneItemAiComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SceneItemAiComponentPb)
								{
									sceneItemAiComponentPb.MergeFrom(this.SceneItemAiComponentPb);
								}
								input.ReadMessage(sceneItemAiComponentPb);
								this.SceneItemAiComponentPb = sceneItemAiComponentPb;
								continue;
							}
							if (num == 482U)
							{
								AnimalCollectComponentPb animalCollectComponentPb = new AnimalCollectComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.AnimalCollectComponentPb)
								{
									animalCollectComponentPb.MergeFrom(this.AnimalCollectComponentPb);
								}
								input.ReadMessage(animalCollectComponentPb);
								this.AnimalCollectComponentPb = animalCollectComponentPb;
								continue;
							}
						}
						else
						{
							if (num == 490U)
							{
								VehiclePassengerComponentPb vehiclePassengerComponentPb = new VehiclePassengerComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.VehiclePassengerComponentPb)
								{
									vehiclePassengerComponentPb.MergeFrom(this.VehiclePassengerComponentPb);
								}
								input.ReadMessage(vehiclePassengerComponentPb);
								this.VehiclePassengerComponentPb = vehiclePassengerComponentPb;
								continue;
							}
							if (num == 498U)
							{
								HookLockPointComponentPb hookLockPointComponentPb = new HookLockPointComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HookLockPointComponentPb)
								{
									hookLockPointComponentPb.MergeFrom(this.HookLockPointComponentPb);
								}
								input.ReadMessage(hookLockPointComponentPb);
								this.HookLockPointComponentPb = hookLockPointComponentPb;
								continue;
							}
							if (num == 506U)
							{
								HackingComponentPb hackingComponentPb = new HackingComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HackingComponentPb)
								{
									hackingComponentPb.MergeFrom(this.HackingComponentPb);
								}
								input.ReadMessage(hackingComponentPb);
								this.HackingComponentPb = hackingComponentPb;
								continue;
							}
						}
					}
					else if (num <= 554U)
					{
						if (num <= 530U)
						{
							if (num == 514U)
							{
								HackTargetComponentPb hackTargetComponentPb = new HackTargetComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HackTargetComponentPb)
								{
									hackTargetComponentPb.MergeFrom(this.HackTargetComponentPb);
								}
								input.ReadMessage(hackTargetComponentPb);
								this.HackTargetComponentPb = hackTargetComponentPb;
								continue;
							}
							if (num == 522U)
							{
								GravityFlipComponentPb gravityFlipComponentPb = new GravityFlipComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.GravityFlipComponentPb)
								{
									gravityFlipComponentPb.MergeFrom(this.GravityFlipComponentPb);
								}
								input.ReadMessage(gravityFlipComponentPb);
								this.GravityFlipComponentPb = gravityFlipComponentPb;
								continue;
							}
							if (num == 530U)
							{
								EntityMoveSplineComponentPb entityMoveSplineComponentPb = new EntityMoveSplineComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EntityMoveSplineComponentPb)
								{
									entityMoveSplineComponentPb.MergeFrom(this.EntityMoveSplineComponentPb);
								}
								input.ReadMessage(entityMoveSplineComponentPb);
								this.EntityMoveSplineComponentPb = entityMoveSplineComponentPb;
								continue;
							}
						}
						else
						{
							if (num == 538U)
							{
								EntityRewardItemPb entityRewardItemPb = new EntityRewardItemPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EntityRewardItemPb)
								{
									entityRewardItemPb.MergeFrom(this.EntityRewardItemPb);
								}
								input.ReadMessage(entityRewardItemPb);
								this.EntityRewardItemPb = entityRewardItemPb;
								continue;
							}
							if (num == 546U)
							{
								TemplateEntitySpawnerComponentPb templateEntitySpawnerComponentPb = new TemplateEntitySpawnerComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.TemplateEntitySpawnerComponentPb)
								{
									templateEntitySpawnerComponentPb.MergeFrom(this.TemplateEntitySpawnerComponentPb);
								}
								input.ReadMessage(templateEntitySpawnerComponentPb);
								this.TemplateEntitySpawnerComponentPb = templateEntitySpawnerComponentPb;
								continue;
							}
							if (num == 554U)
							{
								GridObjectComponentPb gridObjectComponentPb = new GridObjectComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.GridObjectComponentPb)
								{
									gridObjectComponentPb.MergeFrom(this.GridObjectComponentPb);
								}
								input.ReadMessage(gridObjectComponentPb);
								this.GridObjectComponentPb = gridObjectComponentPb;
								continue;
							}
						}
					}
					else if (num <= 578U)
					{
						if (num == 562U)
						{
							SimpleCombatComponentPb simpleCombatComponentPb = new SimpleCombatComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SimpleCombatComponentPb)
							{
								simpleCombatComponentPb.MergeFrom(this.SimpleCombatComponentPb);
							}
							input.ReadMessage(simpleCombatComponentPb);
							this.SimpleCombatComponentPb = simpleCombatComponentPb;
							continue;
						}
						if (num == 570U)
						{
							TrapDefenseComponentPb trapDefenseComponentPb = new TrapDefenseComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.TrapDefenseComponentPb)
							{
								trapDefenseComponentPb.MergeFrom(this.TrapDefenseComponentPb);
							}
							input.ReadMessage(trapDefenseComponentPb);
							this.TrapDefenseComponentPb = trapDefenseComponentPb;
							continue;
						}
						if (num == 578U)
						{
							HoldHandComponentPb holdHandComponentPb = new HoldHandComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HoldHandComponentPb)
							{
								holdHandComponentPb.MergeFrom(this.HoldHandComponentPb);
							}
							input.ReadMessage(holdHandComponentPb);
							this.HoldHandComponentPb = holdHandComponentPb;
							continue;
						}
					}
					else
					{
						if (num == 586U)
						{
							SceneItemEventListenerComponentPb sceneItemEventListenerComponentPb = new SceneItemEventListenerComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ListenerComponentPb)
							{
								sceneItemEventListenerComponentPb.MergeFrom(this.ListenerComponentPb);
							}
							input.ReadMessage(sceneItemEventListenerComponentPb);
							this.ListenerComponentPb = sceneItemEventListenerComponentPb;
							continue;
						}
						if (num == 594U)
						{
							ActivityComponentPb activityComponentPb = new ActivityComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ActivityComponentPb)
							{
								activityComponentPb.MergeFrom(this.ActivityComponentPb);
							}
							input.ReadMessage(activityComponentPb);
							this.ActivityComponentPb = activityComponentPb;
							continue;
						}
						if (num == 602U)
						{
							CalabashSkinComponentPb calabashSkinComponentPb = new CalabashSkinComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.CalabashSkinComponentPb)
							{
								calabashSkinComponentPb.MergeFrom(this.CalabashSkinComponentPb);
							}
							input.ReadMessage(calabashSkinComponentPb);
							this.CalabashSkinComponentPb = calabashSkinComponentPb;
							continue;
						}
					}
				}
				else if (num <= 698U)
				{
					if (num <= 650U)
					{
						if (num <= 626U)
						{
							if (num == 610U)
							{
								HonamiStoryDropItemComponentPb honamiStoryDropItemComponentPb = new HonamiStoryDropItemComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HonamiStoryDropItemComponentPb)
								{
									honamiStoryDropItemComponentPb.MergeFrom(this.HonamiStoryDropItemComponentPb);
								}
								input.ReadMessage(honamiStoryDropItemComponentPb);
								this.HonamiStoryDropItemComponentPb = honamiStoryDropItemComponentPb;
								continue;
							}
							if (num == 618U)
							{
								HonamiStoryEnhanceLevelComponentPb honamiStoryEnhanceLevelComponentPb = new HonamiStoryEnhanceLevelComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.HonamiStoryEnhanceLevelComponentPb)
								{
									honamiStoryEnhanceLevelComponentPb.MergeFrom(this.HonamiStoryEnhanceLevelComponentPb);
								}
								input.ReadMessage(honamiStoryEnhanceLevelComponentPb);
								this.HonamiStoryEnhanceLevelComponentPb = honamiStoryEnhanceLevelComponentPb;
								continue;
							}
							if (num == 626U)
							{
								MoveToPointComponentPb moveToPointComponentPb = new MoveToPointComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MoveToPointComponentPb)
								{
									moveToPointComponentPb.MergeFrom(this.MoveToPointComponentPb);
								}
								input.ReadMessage(moveToPointComponentPb);
								this.MoveToPointComponentPb = moveToPointComponentPb;
								continue;
							}
						}
						else
						{
							if (num == 634U)
							{
								RbBlockComponentPb rbBlockComponentPb = new RbBlockComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RbBlockComponentPb)
								{
									rbBlockComponentPb.MergeFrom(this.RbBlockComponentPb);
								}
								input.ReadMessage(rbBlockComponentPb);
								this.RbBlockComponentPb = rbBlockComponentPb;
								continue;
							}
							if (num == 642U)
							{
								SunSpiritGearComponentPb sunSpiritGearComponentPb = new SunSpiritGearComponentPb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SpiritGearComponentPb)
								{
									sunSpiritGearComponentPb.MergeFrom(this.SpiritGearComponentPb);
								}
								input.ReadMessage(sunSpiritGearComponentPb);
								this.SpiritGearComponentPb = sunSpiritGearComponentPb;
								continue;
							}
							if (num == 650U)
							{
								VehiclePb vehiclePb = new VehiclePb();
								if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.VehiclePb)
								{
									vehiclePb.MergeFrom(this.VehiclePb);
								}
								input.ReadMessage(vehiclePb);
								this.VehiclePb = vehiclePb;
								continue;
							}
						}
					}
					else if (num <= 674U)
					{
						if (num == 658U)
						{
							RbFloorComponentPb rbFloorComponentPb = new RbFloorComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RbFloorComponentPb)
							{
								rbFloorComponentPb.MergeFrom(this.RbFloorComponentPb);
							}
							input.ReadMessage(rbFloorComponentPb);
							this.RbFloorComponentPb = rbFloorComponentPb;
							continue;
						}
						if (num == 666U)
						{
							RbItemComponentPb rbItemComponentPb = new RbItemComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RbItemComponentPb)
							{
								rbItemComponentPb.MergeFrom(this.RbItemComponentPb);
							}
							input.ReadMessage(rbItemComponentPb);
							this.RbItemComponentPb = rbItemComponentPb;
							continue;
						}
						if (num == 674U)
						{
							RoadNetworkComponentPb roadNetworkComponentPb = new RoadNetworkComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RoadNetworkComponentPb)
							{
								roadNetworkComponentPb.MergeFrom(this.RoadNetworkComponentPb);
							}
							input.ReadMessage(roadNetworkComponentPb);
							this.RoadNetworkComponentPb = roadNetworkComponentPb;
							continue;
						}
					}
					else
					{
						if (num == 682U)
						{
							FollowEntityComponentPb followEntityComponentPb = new FollowEntityComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.FollowEntityComponentPb)
							{
								followEntityComponentPb.MergeFrom(this.FollowEntityComponentPb);
							}
							input.ReadMessage(followEntityComponentPb);
							this.FollowEntityComponentPb = followEntityComponentPb;
							continue;
						}
						if (num == 690U)
						{
							MotorOutlookEquippedPb motorOutlookEquippedPb = new MotorOutlookEquippedPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MotorOutlookComponentPb)
							{
								motorOutlookEquippedPb.MergeFrom(this.MotorOutlookComponentPb);
							}
							input.ReadMessage(motorOutlookEquippedPb);
							this.MotorOutlookComponentPb = motorOutlookEquippedPb;
							continue;
						}
						if (num == 698U)
						{
							MotorDaCtxComponentPb motorDaCtxComponentPb = new MotorDaCtxComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.MotorDaCtxComponentPb)
							{
								motorDaCtxComponentPb.MergeFrom(this.MotorDaCtxComponentPb);
							}
							input.ReadMessage(motorDaCtxComponentPb);
							this.MotorDaCtxComponentPb = motorDaCtxComponentPb;
							continue;
						}
					}
				}
				else if (num <= 746U)
				{
					if (num <= 722U)
					{
						if (num == 706U)
						{
							ExhibitionComponentPb exhibitionComponentPb = new ExhibitionComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ExhibitionComponentPb)
							{
								exhibitionComponentPb.MergeFrom(this.ExhibitionComponentPb);
							}
							input.ReadMessage(exhibitionComponentPb);
							this.ExhibitionComponentPb = exhibitionComponentPb;
							continue;
						}
						if (num == 714U)
						{
							FurnitureComponentPb furnitureComponentPb = new FurnitureComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.FurnitureComponentPb)
							{
								furnitureComponentPb.MergeFrom(this.FurnitureComponentPb);
							}
							input.ReadMessage(furnitureComponentPb);
							this.FurnitureComponentPb = furnitureComponentPb;
							continue;
						}
						if (num == 722U)
						{
							OrnamentComponentPb ornamentComponentPb = new OrnamentComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.OrnamentComponentPb)
							{
								ornamentComponentPb.MergeFrom(this.OrnamentComponentPb);
							}
							input.ReadMessage(ornamentComponentPb);
							this.OrnamentComponentPb = ornamentComponentPb;
							continue;
						}
					}
					else
					{
						if (num == 730U)
						{
							FlowerPollutionComponentPb flowerPollutionComponentPb = new FlowerPollutionComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.FlowerPollutionComponentPb)
							{
								flowerPollutionComponentPb.MergeFrom(this.FlowerPollutionComponentPb);
							}
							input.ReadMessage(flowerPollutionComponentPb);
							this.FlowerPollutionComponentPb = flowerPollutionComponentPb;
							continue;
						}
						if (num == 738U)
						{
							DollGrabMachineComponentPb dollGrabMachineComponentPb = new DollGrabMachineComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DollGrabMachineComponentPb)
							{
								dollGrabMachineComponentPb.MergeFrom(this.DollGrabMachineComponentPb);
							}
							input.ReadMessage(dollGrabMachineComponentPb);
							this.DollGrabMachineComponentPb = dollGrabMachineComponentPb;
							continue;
						}
						if (num == 746U)
						{
							DollGrabShowcaseComponentPb dollGrabShowcaseComponentPb = new DollGrabShowcaseComponentPb();
							if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DollGrabShowcaseComponentPb)
							{
								dollGrabShowcaseComponentPb.MergeFrom(this.DollGrabShowcaseComponentPb);
							}
							input.ReadMessage(dollGrabShowcaseComponentPb);
							this.DollGrabShowcaseComponentPb = dollGrabShowcaseComponentPb;
							continue;
						}
					}
				}
				else if (num <= 778U)
				{
					if (num == 754U)
					{
						GpuEntityComponentPb gpuEntityComponentPb = new GpuEntityComponentPb();
						if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.GpuEntityComponentPb)
						{
							gpuEntityComponentPb.MergeFrom(this.GpuEntityComponentPb);
						}
						input.ReadMessage(gpuEntityComponentPb);
						this.GpuEntityComponentPb = gpuEntityComponentPb;
						continue;
					}
					if (num == 762U)
					{
						RoverRoguePortalComponentPb roverRoguePortalComponentPb = new RoverRoguePortalComponentPb();
						if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.RoverRoguePortalComponentPb)
						{
							roverRoguePortalComponentPb.MergeFrom(this.RoverRoguePortalComponentPb);
						}
						input.ReadMessage(roverRoguePortalComponentPb);
						this.RoverRoguePortalComponentPb = roverRoguePortalComponentPb;
						continue;
					}
					if (num == 778U)
					{
						ElementalHolderComponentPb elementalHolderComponentPb = new ElementalHolderComponentPb();
						if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ElementalHolderComponentPb)
						{
							elementalHolderComponentPb.MergeFrom(this.ElementalHolderComponentPb);
						}
						input.ReadMessage(elementalHolderComponentPb);
						this.ElementalHolderComponentPb = elementalHolderComponentPb;
						continue;
					}
				}
				else if (num <= 794U)
				{
					if (num == 786U)
					{
						SkillAvatarComponentPb skillAvatarComponentPb = new SkillAvatarComponentPb();
						if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SkillAvatarComponentPb)
						{
							skillAvatarComponentPb.MergeFrom(this.SkillAvatarComponentPb);
						}
						input.ReadMessage(skillAvatarComponentPb);
						this.SkillAvatarComponentPb = skillAvatarComponentPb;
						continue;
					}
					if (num == 794U)
					{
						EntityFoundationComponentPb entityFoundationComponentPb = new EntityFoundationComponentPb();
						if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EntityFoundationComponentPb)
						{
							entityFoundationComponentPb.MergeFrom(this.EntityFoundationComponentPb);
						}
						input.ReadMessage(entityFoundationComponentPb);
						this.EntityFoundationComponentPb = entityFoundationComponentPb;
						continue;
					}
				}
				else
				{
					if (num == 802U)
					{
						SquadPropComponentPb squadPropComponentPb = new SquadPropComponentPb();
						if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SquadPropComponentPb)
						{
							squadPropComponentPb.MergeFrom(this.SquadPropComponentPb);
						}
						input.ReadMessage(squadPropComponentPb);
						this.SquadPropComponentPb = squadPropComponentPb;
						continue;
					}
					if (num == 826U)
					{
						ConnectorComponentPb connectorComponentPb = new ConnectorComponentPb();
						if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ConnectorComponentPb)
						{
							connectorComponentPb.MergeFrom(this.ConnectorComponentPb);
						}
						input.ReadMessage(connectorComponentPb);
						this.ConnectorComponentPb = connectorComponentPb;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003B28 RID: 15144
		private static readonly MessageParser<EntityComponentPb> _parser = new MessageParser<EntityComponentPb>(() => new EntityComponentPb());

		// Token: 0x04003B29 RID: 15145
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B2A RID: 15146
		public const int AttributeComponentFieldNumber = 1;

		// Token: 0x04003B2B RID: 15147
		public const int TagComponentFieldNumber = 2;

		// Token: 0x04003B2C RID: 15148
		public const int TriggerComponentFieldNumber = 3;

		// Token: 0x04003B2D RID: 15149
		public const int SummonerComponentFieldNumber = 4;

		// Token: 0x04003B2E RID: 15150
		public const int PartComponentFieldNumber = 5;

		// Token: 0x04003B2F RID: 15151
		public const int VisionSkillComponentFieldNumber = 6;

		// Token: 0x04003B30 RID: 15152
		public const int AnimationStateComponentFieldNumber = 7;

		// Token: 0x04003B31 RID: 15153
		public const int BlackboardParamComponentFieldNumber = 8;

		// Token: 0x04003B32 RID: 15154
		public const int SysBuffComponentFieldNumber = 10;

		// Token: 0x04003B33 RID: 15155
		public const int ClientDataComponentFieldNumber = 11;

		// Token: 0x04003B34 RID: 15156
		public const int MonsterWeaponComponentPbFieldNumber = 12;

		// Token: 0x04003B35 RID: 15157
		public const int MonsterAiComponentPbFieldNumber = 13;

		// Token: 0x04003B36 RID: 15158
		public const int FightBuffComponentFieldNumber = 15;

		// Token: 0x04003B37 RID: 15159
		public const int NearbyTrackingComponentPbFieldNumber = 16;

		// Token: 0x04003B38 RID: 15160
		public const int DropComponentPbFieldNumber = 17;

		// Token: 0x04003B39 RID: 15161
		public const int MonsterCaptureComponentFieldNumber = 18;

		// Token: 0x04003B3A RID: 15162
		public const int LogicStateComponentPbFieldNumber = 19;

		// Token: 0x04003B3B RID: 15163
		public const int AdviceComponentPbFieldNumber = 20;

		// Token: 0x04003B3C RID: 15164
		public const int LiftComponentPbFieldNumber = 21;

		// Token: 0x04003B3D RID: 15165
		public const int InteractComponentFieldNumber = 22;

		// Token: 0x04003B3E RID: 15166
		public const int EquipComponentFieldNumber = 23;

		// Token: 0x04003B3F RID: 15167
		public const int BeControlledComponentPbFieldNumber = 24;

		// Token: 0x04003B40 RID: 15168
		public const int ConcomitantsComponentPbFieldNumber = 25;

		// Token: 0x04003B41 RID: 15169
		public const int TimelineTrackComponentPbFieldNumber = 26;

		// Token: 0x04003B42 RID: 15170
		public const int SummonsComponentPbFieldNumber = 27;

		// Token: 0x04003B43 RID: 15171
		public const int EntityFsmComponentPbFieldNumber = 28;

		// Token: 0x04003B44 RID: 15172
		public const int BoardPbFieldNumber = 29;

		// Token: 0x04003B45 RID: 15173
		public const int PlacementItemPbFieldNumber = 30;

		// Token: 0x04003B46 RID: 15174
		public const int StateTagComponentPbFieldNumber = 31;

		// Token: 0x04003B47 RID: 15175
		public const int MonsterGachaDataPbFieldNumber = 32;

		// Token: 0x04003B48 RID: 15176
		public const int FanComponentPbFieldNumber = 33;

		// Token: 0x04003B49 RID: 15177
		public const int NpcPbFieldNumber = 34;

		// Token: 0x04003B4A RID: 15178
		public const int BubbleComponentFieldNumber = 35;

		// Token: 0x04003B4B RID: 15179
		public const int PatrolComponentFieldNumber = 36;

		// Token: 0x04003B4C RID: 15180
		public const int RangeComponentFieldNumber = 37;

		// Token: 0x04003B4D RID: 15181
		public const int PassiveSkillComponentPbFieldNumber = 38;

		// Token: 0x04003B4E RID: 15182
		public const int SkillComponentPbFieldNumber = 39;

		// Token: 0x04003B4F RID: 15183
		public const int DynamicAttachComponentPbFieldNumber = 40;

		// Token: 0x04003B50 RID: 15184
		public const int VarComponentPbFieldNumber = 41;

		// Token: 0x04003B51 RID: 15185
		public const int PlayerFollowerSelfComponentPbFieldNumber = 42;

		// Token: 0x04003B52 RID: 15186
		public const int SceneItemLifeCycleComponentPbFieldNumber = 43;

		// Token: 0x04003B53 RID: 15187
		public const int EntityBulletComponentPbFieldNumber = 44;

		// Token: 0x04003B54 RID: 15188
		public const int BuffProducerComponentPbFieldNumber = 45;

		// Token: 0x04003B55 RID: 15189
		public const int BuffConsumerComponentPbFieldNumber = 46;

		// Token: 0x04003B56 RID: 15190
		public const int SceneItemComponentPbFieldNumber = 47;

		// Token: 0x04003B57 RID: 15191
		public const int ShieldComponentPbFieldNumber = 48;

		// Token: 0x04003B58 RID: 15192
		public const int NpcPerformComponentPbFieldNumber = 49;

		// Token: 0x04003B59 RID: 15193
		public const int DependenceComponentPbFieldNumber = 50;

		// Token: 0x04003B5A RID: 15194
		public const int RenjuDataPbFieldNumber = 51;

		// Token: 0x04003B5B RID: 15195
		public const int AiRoleComponentPbFieldNumber = 52;

		// Token: 0x04003B5C RID: 15196
		public const int PlayerFollowersComponentPbFieldNumber = 53;

		// Token: 0x04003B5D RID: 15197
		public const int SceneItemAttributeComponentPbFieldNumber = 54;

		// Token: 0x04003B5E RID: 15198
		public const int PullingFoundationComponentPbFieldNumber = 55;

		// Token: 0x04003B5F RID: 15199
		public const int BatchBulletCastComponentPbFieldNumber = 56;

		// Token: 0x04003B60 RID: 15200
		public const int RoleWeaponSkinComponentFieldNumber = 57;

		// Token: 0x04003B61 RID: 15201
		public const int CombineEntityInfoPbFieldNumber = 58;

		// Token: 0x04003B62 RID: 15202
		public const int SceneItemAiComponentPbFieldNumber = 59;

		// Token: 0x04003B63 RID: 15203
		public const int AnimalCollectComponentPbFieldNumber = 60;

		// Token: 0x04003B64 RID: 15204
		public const int VehiclePassengerComponentPbFieldNumber = 61;

		// Token: 0x04003B65 RID: 15205
		public const int HookLockPointComponentPbFieldNumber = 62;

		// Token: 0x04003B66 RID: 15206
		public const int HackingComponentPbFieldNumber = 63;

		// Token: 0x04003B67 RID: 15207
		public const int HackTargetComponentPbFieldNumber = 64;

		// Token: 0x04003B68 RID: 15208
		public const int GravityFlipComponentPbFieldNumber = 65;

		// Token: 0x04003B69 RID: 15209
		public const int EntityMoveSplineComponentPbFieldNumber = 66;

		// Token: 0x04003B6A RID: 15210
		public const int EntityRewardItemPbFieldNumber = 67;

		// Token: 0x04003B6B RID: 15211
		public const int TemplateEntitySpawnerComponentPbFieldNumber = 68;

		// Token: 0x04003B6C RID: 15212
		public const int GridObjectComponentPbFieldNumber = 69;

		// Token: 0x04003B6D RID: 15213
		public const int SimpleCombatComponentPbFieldNumber = 70;

		// Token: 0x04003B6E RID: 15214
		public const int TrapDefenseComponentPbFieldNumber = 71;

		// Token: 0x04003B6F RID: 15215
		public const int HoldHandComponentPbFieldNumber = 72;

		// Token: 0x04003B70 RID: 15216
		public const int ListenerComponentPbFieldNumber = 73;

		// Token: 0x04003B71 RID: 15217
		public const int ActivityComponentPbFieldNumber = 74;

		// Token: 0x04003B72 RID: 15218
		public const int CalabashSkinComponentPbFieldNumber = 75;

		// Token: 0x04003B73 RID: 15219
		public const int HonamiStoryDropItemComponentPbFieldNumber = 76;

		// Token: 0x04003B74 RID: 15220
		public const int HonamiStoryEnhanceLevelComponentPbFieldNumber = 77;

		// Token: 0x04003B75 RID: 15221
		public const int MoveToPointComponentPbFieldNumber = 78;

		// Token: 0x04003B76 RID: 15222
		public const int RbBlockComponentPbFieldNumber = 79;

		// Token: 0x04003B77 RID: 15223
		public const int SpiritGearComponentPbFieldNumber = 80;

		// Token: 0x04003B78 RID: 15224
		public const int VehiclePbFieldNumber = 81;

		// Token: 0x04003B79 RID: 15225
		public const int RbFloorComponentPbFieldNumber = 82;

		// Token: 0x04003B7A RID: 15226
		public const int RbItemComponentPbFieldNumber = 83;

		// Token: 0x04003B7B RID: 15227
		public const int RoadNetworkComponentPbFieldNumber = 84;

		// Token: 0x04003B7C RID: 15228
		public const int FollowEntityComponentPbFieldNumber = 85;

		// Token: 0x04003B7D RID: 15229
		public const int MotorOutlookComponentPbFieldNumber = 86;

		// Token: 0x04003B7E RID: 15230
		public const int MotorDaCtxComponentPbFieldNumber = 87;

		// Token: 0x04003B7F RID: 15231
		public const int ExhibitionComponentPbFieldNumber = 88;

		// Token: 0x04003B80 RID: 15232
		public const int FurnitureComponentPbFieldNumber = 89;

		// Token: 0x04003B81 RID: 15233
		public const int OrnamentComponentPbFieldNumber = 90;

		// Token: 0x04003B82 RID: 15234
		public const int FlowerPollutionComponentPbFieldNumber = 91;

		// Token: 0x04003B83 RID: 15235
		public const int DollGrabMachineComponentPbFieldNumber = 92;

		// Token: 0x04003B84 RID: 15236
		public const int DollGrabShowcaseComponentPbFieldNumber = 93;

		// Token: 0x04003B85 RID: 15237
		public const int GpuEntityComponentPbFieldNumber = 94;

		// Token: 0x04003B86 RID: 15238
		public const int RoverRoguePortalComponentPbFieldNumber = 95;

		// Token: 0x04003B87 RID: 15239
		public const int ElementalHolderComponentPbFieldNumber = 97;

		// Token: 0x04003B88 RID: 15240
		public const int SkillAvatarComponentPbFieldNumber = 98;

		// Token: 0x04003B89 RID: 15241
		public const int EntityFoundationComponentPbFieldNumber = 99;

		// Token: 0x04003B8A RID: 15242
		public const int SquadPropComponentPbFieldNumber = 100;

		// Token: 0x04003B8B RID: 15243
		public const int ConnectorComponentPbFieldNumber = 103;

		// Token: 0x04003B8C RID: 15244
		private object component_;

		// Token: 0x04003B8D RID: 15245
		private EntityComponentPb.ComponentOneofCase componentCase_;

		// Token: 0x020017E5 RID: 6117
		public enum ComponentOneofCase
		{
			// Token: 0x0400CB45 RID: 52037
			None,
			// Token: 0x0400CB46 RID: 52038
			AttributeComponent,
			// Token: 0x0400CB47 RID: 52039
			TagComponent,
			// Token: 0x0400CB48 RID: 52040
			TriggerComponent,
			// Token: 0x0400CB49 RID: 52041
			SummonerComponent,
			// Token: 0x0400CB4A RID: 52042
			PartComponent,
			// Token: 0x0400CB4B RID: 52043
			VisionSkillComponent,
			// Token: 0x0400CB4C RID: 52044
			AnimationStateComponent,
			// Token: 0x0400CB4D RID: 52045
			BlackboardParamComponent,
			// Token: 0x0400CB4E RID: 52046
			SysBuffComponent = 10,
			// Token: 0x0400CB4F RID: 52047
			ClientDataComponent,
			// Token: 0x0400CB50 RID: 52048
			MonsterWeaponComponentPb,
			// Token: 0x0400CB51 RID: 52049
			MonsterAiComponentPb,
			// Token: 0x0400CB52 RID: 52050
			FightBuffComponent = 15,
			// Token: 0x0400CB53 RID: 52051
			NearbyTrackingComponentPb,
			// Token: 0x0400CB54 RID: 52052
			DropComponentPb,
			// Token: 0x0400CB55 RID: 52053
			MonsterCaptureComponent,
			// Token: 0x0400CB56 RID: 52054
			LogicStateComponentPb,
			// Token: 0x0400CB57 RID: 52055
			AdviceComponentPb,
			// Token: 0x0400CB58 RID: 52056
			LiftComponentPb,
			// Token: 0x0400CB59 RID: 52057
			InteractComponent,
			// Token: 0x0400CB5A RID: 52058
			EquipComponent,
			// Token: 0x0400CB5B RID: 52059
			BeControlledComponentPb,
			// Token: 0x0400CB5C RID: 52060
			ConcomitantsComponentPb,
			// Token: 0x0400CB5D RID: 52061
			TimelineTrackComponentPb,
			// Token: 0x0400CB5E RID: 52062
			SummonsComponentPb,
			// Token: 0x0400CB5F RID: 52063
			EntityFsmComponentPb,
			// Token: 0x0400CB60 RID: 52064
			BoardPb,
			// Token: 0x0400CB61 RID: 52065
			PlacementItemPb,
			// Token: 0x0400CB62 RID: 52066
			StateTagComponentPb,
			// Token: 0x0400CB63 RID: 52067
			MonsterGachaDataPb,
			// Token: 0x0400CB64 RID: 52068
			FanComponentPb,
			// Token: 0x0400CB65 RID: 52069
			NpcPb,
			// Token: 0x0400CB66 RID: 52070
			BubbleComponent,
			// Token: 0x0400CB67 RID: 52071
			PatrolComponent,
			// Token: 0x0400CB68 RID: 52072
			RangeComponent,
			// Token: 0x0400CB69 RID: 52073
			PassiveSkillComponentPb,
			// Token: 0x0400CB6A RID: 52074
			SkillComponentPb,
			// Token: 0x0400CB6B RID: 52075
			DynamicAttachComponentPb,
			// Token: 0x0400CB6C RID: 52076
			VarComponentPb,
			// Token: 0x0400CB6D RID: 52077
			PlayerFollowerSelfComponentPb,
			// Token: 0x0400CB6E RID: 52078
			SceneItemLifeCycleComponentPb,
			// Token: 0x0400CB6F RID: 52079
			EntityBulletComponentPb,
			// Token: 0x0400CB70 RID: 52080
			BuffProducerComponentPb,
			// Token: 0x0400CB71 RID: 52081
			BuffConsumerComponentPb,
			// Token: 0x0400CB72 RID: 52082
			SceneItemComponentPb,
			// Token: 0x0400CB73 RID: 52083
			ShieldComponentPb,
			// Token: 0x0400CB74 RID: 52084
			NpcPerformComponentPb,
			// Token: 0x0400CB75 RID: 52085
			DependenceComponentPb,
			// Token: 0x0400CB76 RID: 52086
			RenjuDataPb,
			// Token: 0x0400CB77 RID: 52087
			AiRoleComponentPb,
			// Token: 0x0400CB78 RID: 52088
			PlayerFollowersComponentPb,
			// Token: 0x0400CB79 RID: 52089
			SceneItemAttributeComponentPb,
			// Token: 0x0400CB7A RID: 52090
			PullingFoundationComponentPb,
			// Token: 0x0400CB7B RID: 52091
			BatchBulletCastComponentPb,
			// Token: 0x0400CB7C RID: 52092
			RoleWeaponSkinComponent,
			// Token: 0x0400CB7D RID: 52093
			CombineEntityInfoPb,
			// Token: 0x0400CB7E RID: 52094
			SceneItemAiComponentPb,
			// Token: 0x0400CB7F RID: 52095
			AnimalCollectComponentPb,
			// Token: 0x0400CB80 RID: 52096
			VehiclePassengerComponentPb,
			// Token: 0x0400CB81 RID: 52097
			HookLockPointComponentPb,
			// Token: 0x0400CB82 RID: 52098
			HackingComponentPb,
			// Token: 0x0400CB83 RID: 52099
			HackTargetComponentPb,
			// Token: 0x0400CB84 RID: 52100
			GravityFlipComponentPb,
			// Token: 0x0400CB85 RID: 52101
			EntityMoveSplineComponentPb,
			// Token: 0x0400CB86 RID: 52102
			EntityRewardItemPb,
			// Token: 0x0400CB87 RID: 52103
			TemplateEntitySpawnerComponentPb,
			// Token: 0x0400CB88 RID: 52104
			GridObjectComponentPb,
			// Token: 0x0400CB89 RID: 52105
			SimpleCombatComponentPb,
			// Token: 0x0400CB8A RID: 52106
			TrapDefenseComponentPb,
			// Token: 0x0400CB8B RID: 52107
			HoldHandComponentPb,
			// Token: 0x0400CB8C RID: 52108
			ListenerComponentPb,
			// Token: 0x0400CB8D RID: 52109
			ActivityComponentPb,
			// Token: 0x0400CB8E RID: 52110
			CalabashSkinComponentPb,
			// Token: 0x0400CB8F RID: 52111
			HonamiStoryDropItemComponentPb,
			// Token: 0x0400CB90 RID: 52112
			HonamiStoryEnhanceLevelComponentPb,
			// Token: 0x0400CB91 RID: 52113
			MoveToPointComponentPb,
			// Token: 0x0400CB92 RID: 52114
			RbBlockComponentPb,
			// Token: 0x0400CB93 RID: 52115
			SpiritGearComponentPb,
			// Token: 0x0400CB94 RID: 52116
			VehiclePb,
			// Token: 0x0400CB95 RID: 52117
			RbFloorComponentPb,
			// Token: 0x0400CB96 RID: 52118
			RbItemComponentPb,
			// Token: 0x0400CB97 RID: 52119
			RoadNetworkComponentPb,
			// Token: 0x0400CB98 RID: 52120
			FollowEntityComponentPb,
			// Token: 0x0400CB99 RID: 52121
			MotorOutlookComponentPb,
			// Token: 0x0400CB9A RID: 52122
			MotorDaCtxComponentPb,
			// Token: 0x0400CB9B RID: 52123
			ExhibitionComponentPb,
			// Token: 0x0400CB9C RID: 52124
			FurnitureComponentPb,
			// Token: 0x0400CB9D RID: 52125
			OrnamentComponentPb,
			// Token: 0x0400CB9E RID: 52126
			FlowerPollutionComponentPb,
			// Token: 0x0400CB9F RID: 52127
			DollGrabMachineComponentPb,
			// Token: 0x0400CBA0 RID: 52128
			DollGrabShowcaseComponentPb,
			// Token: 0x0400CBA1 RID: 52129
			GpuEntityComponentPb,
			// Token: 0x0400CBA2 RID: 52130
			RoverRoguePortalComponentPb,
			// Token: 0x0400CBA3 RID: 52131
			ElementalHolderComponentPb = 97,
			// Token: 0x0400CBA4 RID: 52132
			SkillAvatarComponentPb,
			// Token: 0x0400CBA5 RID: 52133
			EntityFoundationComponentPb,
			// Token: 0x0400CBA6 RID: 52134
			SquadPropComponentPb,
			// Token: 0x0400CBA7 RID: 52135
			ConnectorComponentPb = 103
		}
	}
}
