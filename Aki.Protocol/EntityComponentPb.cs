using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Protocol.Summon;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200047F RID: 1151
	public sealed class EntityComponentPb : IMessage<EntityComponentPb>, IMessage, IEquatable<EntityComponentPb>, IDeepCloneable<EntityComponentPb>, IBufferMessage
	{
		// Token: 0x06006D86 RID: 28038 RVA: 0x00108234 File Offset: 0x00106434
		[NullableContext(1)]
		public static EntityComponentPb Create()
		{
			return new EntityComponentPb();
		}

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x06006D87 RID: 28039 RVA: 0x0010823B File Offset: 0x0010643B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityComponentPb> Parser
		{
			get
			{
				return EntityComponentPb._parser;
			}
		}

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x06006D88 RID: 28040 RVA: 0x00108242 File Offset: 0x00106442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x06006D89 RID: 28041 RVA: 0x00108245 File Offset: 0x00106445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityComponentPb.Descriptor;
			}
		}

		// Token: 0x06006D8A RID: 28042 RVA: 0x0010824C File Offset: 0x0010644C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityComponentPb()
		{
		}

		// Token: 0x06006D8B RID: 28043 RVA: 0x00108254 File Offset: 0x00106454
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
			case EntityComponentPb.ComponentOneofCase.DarkTideComponentPb:
				this.DarkTideComponentPb = other.DarkTideComponentPb.Clone();
				break;
			case EntityComponentPb.ComponentOneofCase.ElementalHolderComponentPb:
				this.ElementalHolderComponentPb = other.ElementalHolderComponentPb.Clone();
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

		// Token: 0x06006D8C RID: 28044 RVA: 0x00108C7D File Offset: 0x00106E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityComponentPb Clone()
		{
			return new EntityComponentPb(this);
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x06006D8D RID: 28045 RVA: 0x00108C85 File Offset: 0x00106E85
		// (set) Token: 0x06006D8E RID: 28046 RVA: 0x00108C9D File Offset: 0x00106E9D
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

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x06006D8F RID: 28047 RVA: 0x00108CB3 File Offset: 0x00106EB3
		// (set) Token: 0x06006D90 RID: 28048 RVA: 0x00108CCB File Offset: 0x00106ECB
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

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x06006D91 RID: 28049 RVA: 0x00108CE1 File Offset: 0x00106EE1
		// (set) Token: 0x06006D92 RID: 28050 RVA: 0x00108CF9 File Offset: 0x00106EF9
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

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x06006D93 RID: 28051 RVA: 0x00108D0F File Offset: 0x00106F0F
		// (set) Token: 0x06006D94 RID: 28052 RVA: 0x00108D27 File Offset: 0x00106F27
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

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x06006D95 RID: 28053 RVA: 0x00108D3D File Offset: 0x00106F3D
		// (set) Token: 0x06006D96 RID: 28054 RVA: 0x00108D55 File Offset: 0x00106F55
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

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x06006D97 RID: 28055 RVA: 0x00108D6B File Offset: 0x00106F6B
		// (set) Token: 0x06006D98 RID: 28056 RVA: 0x00108D83 File Offset: 0x00106F83
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

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x06006D99 RID: 28057 RVA: 0x00108D99 File Offset: 0x00106F99
		// (set) Token: 0x06006D9A RID: 28058 RVA: 0x00108DB1 File Offset: 0x00106FB1
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

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x06006D9B RID: 28059 RVA: 0x00108DC7 File Offset: 0x00106FC7
		// (set) Token: 0x06006D9C RID: 28060 RVA: 0x00108DDF File Offset: 0x00106FDF
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

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x06006D9D RID: 28061 RVA: 0x00108DF5 File Offset: 0x00106FF5
		// (set) Token: 0x06006D9E RID: 28062 RVA: 0x00108E0E File Offset: 0x0010700E
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

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x06006D9F RID: 28063 RVA: 0x00108E25 File Offset: 0x00107025
		// (set) Token: 0x06006DA0 RID: 28064 RVA: 0x00108E3E File Offset: 0x0010703E
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

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x06006DA1 RID: 28065 RVA: 0x00108E55 File Offset: 0x00107055
		// (set) Token: 0x06006DA2 RID: 28066 RVA: 0x00108E6E File Offset: 0x0010706E
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

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x06006DA3 RID: 28067 RVA: 0x00108E85 File Offset: 0x00107085
		// (set) Token: 0x06006DA4 RID: 28068 RVA: 0x00108E9E File Offset: 0x0010709E
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

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x06006DA5 RID: 28069 RVA: 0x00108EB5 File Offset: 0x001070B5
		// (set) Token: 0x06006DA6 RID: 28070 RVA: 0x00108ECE File Offset: 0x001070CE
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

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x06006DA7 RID: 28071 RVA: 0x00108EE5 File Offset: 0x001070E5
		// (set) Token: 0x06006DA8 RID: 28072 RVA: 0x00108EFE File Offset: 0x001070FE
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

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x06006DA9 RID: 28073 RVA: 0x00108F15 File Offset: 0x00107115
		// (set) Token: 0x06006DAA RID: 28074 RVA: 0x00108F2E File Offset: 0x0010712E
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

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x06006DAB RID: 28075 RVA: 0x00108F45 File Offset: 0x00107145
		// (set) Token: 0x06006DAC RID: 28076 RVA: 0x00108F5E File Offset: 0x0010715E
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

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x06006DAD RID: 28077 RVA: 0x00108F75 File Offset: 0x00107175
		// (set) Token: 0x06006DAE RID: 28078 RVA: 0x00108F8E File Offset: 0x0010718E
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

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x06006DAF RID: 28079 RVA: 0x00108FA5 File Offset: 0x001071A5
		// (set) Token: 0x06006DB0 RID: 28080 RVA: 0x00108FBE File Offset: 0x001071BE
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

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x06006DB1 RID: 28081 RVA: 0x00108FD5 File Offset: 0x001071D5
		// (set) Token: 0x06006DB2 RID: 28082 RVA: 0x00108FEE File Offset: 0x001071EE
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

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x06006DB3 RID: 28083 RVA: 0x00109005 File Offset: 0x00107205
		// (set) Token: 0x06006DB4 RID: 28084 RVA: 0x0010901E File Offset: 0x0010721E
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

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x06006DB5 RID: 28085 RVA: 0x00109035 File Offset: 0x00107235
		// (set) Token: 0x06006DB6 RID: 28086 RVA: 0x0010904E File Offset: 0x0010724E
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

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x06006DB7 RID: 28087 RVA: 0x00109065 File Offset: 0x00107265
		// (set) Token: 0x06006DB8 RID: 28088 RVA: 0x0010907E File Offset: 0x0010727E
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

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x06006DB9 RID: 28089 RVA: 0x00109095 File Offset: 0x00107295
		// (set) Token: 0x06006DBA RID: 28090 RVA: 0x001090AE File Offset: 0x001072AE
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

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x06006DBB RID: 28091 RVA: 0x001090C5 File Offset: 0x001072C5
		// (set) Token: 0x06006DBC RID: 28092 RVA: 0x001090DE File Offset: 0x001072DE
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

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x06006DBD RID: 28093 RVA: 0x001090F5 File Offset: 0x001072F5
		// (set) Token: 0x06006DBE RID: 28094 RVA: 0x0010910E File Offset: 0x0010730E
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

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x06006DBF RID: 28095 RVA: 0x00109125 File Offset: 0x00107325
		// (set) Token: 0x06006DC0 RID: 28096 RVA: 0x0010913E File Offset: 0x0010733E
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

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x06006DC1 RID: 28097 RVA: 0x00109155 File Offset: 0x00107355
		// (set) Token: 0x06006DC2 RID: 28098 RVA: 0x0010916E File Offset: 0x0010736E
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

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x06006DC3 RID: 28099 RVA: 0x00109185 File Offset: 0x00107385
		// (set) Token: 0x06006DC4 RID: 28100 RVA: 0x0010919E File Offset: 0x0010739E
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

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x06006DC5 RID: 28101 RVA: 0x001091B5 File Offset: 0x001073B5
		// (set) Token: 0x06006DC6 RID: 28102 RVA: 0x001091CE File Offset: 0x001073CE
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

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x06006DC7 RID: 28103 RVA: 0x001091E5 File Offset: 0x001073E5
		// (set) Token: 0x06006DC8 RID: 28104 RVA: 0x001091FE File Offset: 0x001073FE
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

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x06006DC9 RID: 28105 RVA: 0x00109215 File Offset: 0x00107415
		// (set) Token: 0x06006DCA RID: 28106 RVA: 0x0010922E File Offset: 0x0010742E
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

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x06006DCB RID: 28107 RVA: 0x00109245 File Offset: 0x00107445
		// (set) Token: 0x06006DCC RID: 28108 RVA: 0x0010925E File Offset: 0x0010745E
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

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x06006DCD RID: 28109 RVA: 0x00109275 File Offset: 0x00107475
		// (set) Token: 0x06006DCE RID: 28110 RVA: 0x0010928E File Offset: 0x0010748E
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

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x06006DCF RID: 28111 RVA: 0x001092A5 File Offset: 0x001074A5
		// (set) Token: 0x06006DD0 RID: 28112 RVA: 0x001092BE File Offset: 0x001074BE
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

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x06006DD1 RID: 28113 RVA: 0x001092D5 File Offset: 0x001074D5
		// (set) Token: 0x06006DD2 RID: 28114 RVA: 0x001092EE File Offset: 0x001074EE
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

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x06006DD3 RID: 28115 RVA: 0x00109305 File Offset: 0x00107505
		// (set) Token: 0x06006DD4 RID: 28116 RVA: 0x0010931E File Offset: 0x0010751E
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

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x06006DD5 RID: 28117 RVA: 0x00109335 File Offset: 0x00107535
		// (set) Token: 0x06006DD6 RID: 28118 RVA: 0x0010934E File Offset: 0x0010754E
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

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x06006DD7 RID: 28119 RVA: 0x00109365 File Offset: 0x00107565
		// (set) Token: 0x06006DD8 RID: 28120 RVA: 0x0010937E File Offset: 0x0010757E
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

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x06006DD9 RID: 28121 RVA: 0x00109395 File Offset: 0x00107595
		// (set) Token: 0x06006DDA RID: 28122 RVA: 0x001093AE File Offset: 0x001075AE
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

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x06006DDB RID: 28123 RVA: 0x001093C5 File Offset: 0x001075C5
		// (set) Token: 0x06006DDC RID: 28124 RVA: 0x001093DE File Offset: 0x001075DE
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

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x06006DDD RID: 28125 RVA: 0x001093F5 File Offset: 0x001075F5
		// (set) Token: 0x06006DDE RID: 28126 RVA: 0x0010940E File Offset: 0x0010760E
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

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x06006DDF RID: 28127 RVA: 0x00109425 File Offset: 0x00107625
		// (set) Token: 0x06006DE0 RID: 28128 RVA: 0x0010943E File Offset: 0x0010763E
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

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x06006DE1 RID: 28129 RVA: 0x00109455 File Offset: 0x00107655
		// (set) Token: 0x06006DE2 RID: 28130 RVA: 0x0010946E File Offset: 0x0010766E
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

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x06006DE3 RID: 28131 RVA: 0x00109485 File Offset: 0x00107685
		// (set) Token: 0x06006DE4 RID: 28132 RVA: 0x0010949E File Offset: 0x0010769E
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

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x06006DE5 RID: 28133 RVA: 0x001094B5 File Offset: 0x001076B5
		// (set) Token: 0x06006DE6 RID: 28134 RVA: 0x001094CE File Offset: 0x001076CE
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

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x06006DE7 RID: 28135 RVA: 0x001094E5 File Offset: 0x001076E5
		// (set) Token: 0x06006DE8 RID: 28136 RVA: 0x001094FE File Offset: 0x001076FE
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

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x06006DE9 RID: 28137 RVA: 0x00109515 File Offset: 0x00107715
		// (set) Token: 0x06006DEA RID: 28138 RVA: 0x0010952E File Offset: 0x0010772E
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

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x06006DEB RID: 28139 RVA: 0x00109545 File Offset: 0x00107745
		// (set) Token: 0x06006DEC RID: 28140 RVA: 0x0010955E File Offset: 0x0010775E
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

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x06006DED RID: 28141 RVA: 0x00109575 File Offset: 0x00107775
		// (set) Token: 0x06006DEE RID: 28142 RVA: 0x0010958E File Offset: 0x0010778E
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

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x06006DEF RID: 28143 RVA: 0x001095A5 File Offset: 0x001077A5
		// (set) Token: 0x06006DF0 RID: 28144 RVA: 0x001095BE File Offset: 0x001077BE
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

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x06006DF1 RID: 28145 RVA: 0x001095D5 File Offset: 0x001077D5
		// (set) Token: 0x06006DF2 RID: 28146 RVA: 0x001095EE File Offset: 0x001077EE
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

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x06006DF3 RID: 28147 RVA: 0x00109605 File Offset: 0x00107805
		// (set) Token: 0x06006DF4 RID: 28148 RVA: 0x0010961E File Offset: 0x0010781E
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

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x06006DF5 RID: 28149 RVA: 0x00109635 File Offset: 0x00107835
		// (set) Token: 0x06006DF6 RID: 28150 RVA: 0x0010964E File Offset: 0x0010784E
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

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x06006DF7 RID: 28151 RVA: 0x00109665 File Offset: 0x00107865
		// (set) Token: 0x06006DF8 RID: 28152 RVA: 0x0010967E File Offset: 0x0010787E
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

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x06006DF9 RID: 28153 RVA: 0x00109695 File Offset: 0x00107895
		// (set) Token: 0x06006DFA RID: 28154 RVA: 0x001096AE File Offset: 0x001078AE
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

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x06006DFB RID: 28155 RVA: 0x001096C5 File Offset: 0x001078C5
		// (set) Token: 0x06006DFC RID: 28156 RVA: 0x001096DE File Offset: 0x001078DE
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

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x06006DFD RID: 28157 RVA: 0x001096F5 File Offset: 0x001078F5
		// (set) Token: 0x06006DFE RID: 28158 RVA: 0x0010970E File Offset: 0x0010790E
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

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x06006DFF RID: 28159 RVA: 0x00109725 File Offset: 0x00107925
		// (set) Token: 0x06006E00 RID: 28160 RVA: 0x0010973E File Offset: 0x0010793E
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

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x06006E01 RID: 28161 RVA: 0x00109755 File Offset: 0x00107955
		// (set) Token: 0x06006E02 RID: 28162 RVA: 0x0010976E File Offset: 0x0010796E
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

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x06006E03 RID: 28163 RVA: 0x00109785 File Offset: 0x00107985
		// (set) Token: 0x06006E04 RID: 28164 RVA: 0x0010979E File Offset: 0x0010799E
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

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x06006E05 RID: 28165 RVA: 0x001097B5 File Offset: 0x001079B5
		// (set) Token: 0x06006E06 RID: 28166 RVA: 0x001097CE File Offset: 0x001079CE
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

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x06006E07 RID: 28167 RVA: 0x001097E5 File Offset: 0x001079E5
		// (set) Token: 0x06006E08 RID: 28168 RVA: 0x001097FE File Offset: 0x001079FE
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

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x06006E09 RID: 28169 RVA: 0x00109815 File Offset: 0x00107A15
		// (set) Token: 0x06006E0A RID: 28170 RVA: 0x0010982E File Offset: 0x00107A2E
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

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x06006E0B RID: 28171 RVA: 0x00109845 File Offset: 0x00107A45
		// (set) Token: 0x06006E0C RID: 28172 RVA: 0x0010985E File Offset: 0x00107A5E
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

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x06006E0D RID: 28173 RVA: 0x00109875 File Offset: 0x00107A75
		// (set) Token: 0x06006E0E RID: 28174 RVA: 0x0010988E File Offset: 0x00107A8E
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

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x06006E0F RID: 28175 RVA: 0x001098A5 File Offset: 0x00107AA5
		// (set) Token: 0x06006E10 RID: 28176 RVA: 0x001098BE File Offset: 0x00107ABE
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

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x06006E11 RID: 28177 RVA: 0x001098D5 File Offset: 0x00107AD5
		// (set) Token: 0x06006E12 RID: 28178 RVA: 0x001098EE File Offset: 0x00107AEE
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

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x06006E13 RID: 28179 RVA: 0x00109905 File Offset: 0x00107B05
		// (set) Token: 0x06006E14 RID: 28180 RVA: 0x0010991E File Offset: 0x00107B1E
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

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x06006E15 RID: 28181 RVA: 0x00109935 File Offset: 0x00107B35
		// (set) Token: 0x06006E16 RID: 28182 RVA: 0x0010994E File Offset: 0x00107B4E
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

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x06006E17 RID: 28183 RVA: 0x00109965 File Offset: 0x00107B65
		// (set) Token: 0x06006E18 RID: 28184 RVA: 0x0010997E File Offset: 0x00107B7E
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

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x06006E19 RID: 28185 RVA: 0x00109995 File Offset: 0x00107B95
		// (set) Token: 0x06006E1A RID: 28186 RVA: 0x001099AE File Offset: 0x00107BAE
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

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x06006E1B RID: 28187 RVA: 0x001099C5 File Offset: 0x00107BC5
		// (set) Token: 0x06006E1C RID: 28188 RVA: 0x001099DE File Offset: 0x00107BDE
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

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x06006E1D RID: 28189 RVA: 0x001099F5 File Offset: 0x00107BF5
		// (set) Token: 0x06006E1E RID: 28190 RVA: 0x00109A0E File Offset: 0x00107C0E
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

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x06006E1F RID: 28191 RVA: 0x00109A25 File Offset: 0x00107C25
		// (set) Token: 0x06006E20 RID: 28192 RVA: 0x00109A3E File Offset: 0x00107C3E
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

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x06006E21 RID: 28193 RVA: 0x00109A55 File Offset: 0x00107C55
		// (set) Token: 0x06006E22 RID: 28194 RVA: 0x00109A6E File Offset: 0x00107C6E
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

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x06006E23 RID: 28195 RVA: 0x00109A85 File Offset: 0x00107C85
		// (set) Token: 0x06006E24 RID: 28196 RVA: 0x00109A9E File Offset: 0x00107C9E
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

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x06006E25 RID: 28197 RVA: 0x00109AB5 File Offset: 0x00107CB5
		// (set) Token: 0x06006E26 RID: 28198 RVA: 0x00109ACE File Offset: 0x00107CCE
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

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x06006E27 RID: 28199 RVA: 0x00109AE5 File Offset: 0x00107CE5
		// (set) Token: 0x06006E28 RID: 28200 RVA: 0x00109AFE File Offset: 0x00107CFE
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

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x06006E29 RID: 28201 RVA: 0x00109B15 File Offset: 0x00107D15
		// (set) Token: 0x06006E2A RID: 28202 RVA: 0x00109B2E File Offset: 0x00107D2E
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

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x06006E2B RID: 28203 RVA: 0x00109B45 File Offset: 0x00107D45
		// (set) Token: 0x06006E2C RID: 28204 RVA: 0x00109B5E File Offset: 0x00107D5E
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

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x06006E2D RID: 28205 RVA: 0x00109B75 File Offset: 0x00107D75
		// (set) Token: 0x06006E2E RID: 28206 RVA: 0x00109B8E File Offset: 0x00107D8E
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

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x06006E2F RID: 28207 RVA: 0x00109BA5 File Offset: 0x00107DA5
		// (set) Token: 0x06006E30 RID: 28208 RVA: 0x00109BBE File Offset: 0x00107DBE
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

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x06006E31 RID: 28209 RVA: 0x00109BD5 File Offset: 0x00107DD5
		// (set) Token: 0x06006E32 RID: 28210 RVA: 0x00109BEE File Offset: 0x00107DEE
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

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x06006E33 RID: 28211 RVA: 0x00109C05 File Offset: 0x00107E05
		// (set) Token: 0x06006E34 RID: 28212 RVA: 0x00109C1E File Offset: 0x00107E1E
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

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x06006E35 RID: 28213 RVA: 0x00109C35 File Offset: 0x00107E35
		// (set) Token: 0x06006E36 RID: 28214 RVA: 0x00109C4E File Offset: 0x00107E4E
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

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x06006E37 RID: 28215 RVA: 0x00109C65 File Offset: 0x00107E65
		// (set) Token: 0x06006E38 RID: 28216 RVA: 0x00109C7E File Offset: 0x00107E7E
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

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x06006E39 RID: 28217 RVA: 0x00109C95 File Offset: 0x00107E95
		// (set) Token: 0x06006E3A RID: 28218 RVA: 0x00109CAE File Offset: 0x00107EAE
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

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x06006E3B RID: 28219 RVA: 0x00109CC5 File Offset: 0x00107EC5
		// (set) Token: 0x06006E3C RID: 28220 RVA: 0x00109CDE File Offset: 0x00107EDE
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

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x06006E3D RID: 28221 RVA: 0x00109CF5 File Offset: 0x00107EF5
		// (set) Token: 0x06006E3E RID: 28222 RVA: 0x00109D0E File Offset: 0x00107F0E
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

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x06006E3F RID: 28223 RVA: 0x00109D25 File Offset: 0x00107F25
		// (set) Token: 0x06006E40 RID: 28224 RVA: 0x00109D3E File Offset: 0x00107F3E
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

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x06006E41 RID: 28225 RVA: 0x00109D55 File Offset: 0x00107F55
		// (set) Token: 0x06006E42 RID: 28226 RVA: 0x00109D6E File Offset: 0x00107F6E
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

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x06006E43 RID: 28227 RVA: 0x00109D85 File Offset: 0x00107F85
		// (set) Token: 0x06006E44 RID: 28228 RVA: 0x00109D9E File Offset: 0x00107F9E
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

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x06006E45 RID: 28229 RVA: 0x00109DB5 File Offset: 0x00107FB5
		// (set) Token: 0x06006E46 RID: 28230 RVA: 0x00109DCE File Offset: 0x00107FCE
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

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x06006E47 RID: 28231 RVA: 0x00109DE5 File Offset: 0x00107FE5
		// (set) Token: 0x06006E48 RID: 28232 RVA: 0x00109DFE File Offset: 0x00107FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideComponentPb DarkTideComponentPb
		{
			get
			{
				if (this.componentCase_ != EntityComponentPb.ComponentOneofCase.DarkTideComponentPb)
				{
					return null;
				}
				return (DarkTideComponentPb)this.component_;
			}
			set
			{
				this.component_ = value;
				this.componentCase_ = ((value == null) ? EntityComponentPb.ComponentOneofCase.None : EntityComponentPb.ComponentOneofCase.DarkTideComponentPb);
			}
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x06006E49 RID: 28233 RVA: 0x00109E15 File Offset: 0x00108015
		// (set) Token: 0x06006E4A RID: 28234 RVA: 0x00109E2E File Offset: 0x0010802E
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

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x06006E4B RID: 28235 RVA: 0x00109E45 File Offset: 0x00108045
		// (set) Token: 0x06006E4C RID: 28236 RVA: 0x00109E5E File Offset: 0x0010805E
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

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x06006E4D RID: 28237 RVA: 0x00109E75 File Offset: 0x00108075
		// (set) Token: 0x06006E4E RID: 28238 RVA: 0x00109E8E File Offset: 0x0010808E
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

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x06006E4F RID: 28239 RVA: 0x00109EA5 File Offset: 0x001080A5
		// (set) Token: 0x06006E50 RID: 28240 RVA: 0x00109EBE File Offset: 0x001080BE
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

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x06006E51 RID: 28241 RVA: 0x00109ED5 File Offset: 0x001080D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityComponentPb.ComponentOneofCase ComponentCase
		{
			get
			{
				return this.componentCase_;
			}
		}

		// Token: 0x06006E52 RID: 28242 RVA: 0x00109EDD File Offset: 0x001080DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearComponent()
		{
			this.componentCase_ = EntityComponentPb.ComponentOneofCase.None;
			this.component_ = null;
		}

		// Token: 0x06006E53 RID: 28243 RVA: 0x00109EED File Offset: 0x001080ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityComponentPb);
		}

		// Token: 0x06006E54 RID: 28244 RVA: 0x00109EFC File Offset: 0x001080FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityComponentPb other)
		{
			return other != null && (other == this || (object.Equals(this.AttributeComponent, other.AttributeComponent) && object.Equals(this.TagComponent, other.TagComponent) && object.Equals(this.TriggerComponent, other.TriggerComponent) && object.Equals(this.SummonerComponent, other.SummonerComponent) && object.Equals(this.PartComponent, other.PartComponent) && object.Equals(this.VisionSkillComponent, other.VisionSkillComponent) && object.Equals(this.AnimationStateComponent, other.AnimationStateComponent) && object.Equals(this.BlackboardParamComponent, other.BlackboardParamComponent) && object.Equals(this.SysBuffComponent, other.SysBuffComponent) && object.Equals(this.ClientDataComponent, other.ClientDataComponent) && object.Equals(this.MonsterWeaponComponentPb, other.MonsterWeaponComponentPb) && object.Equals(this.MonsterAiComponentPb, other.MonsterAiComponentPb) && object.Equals(this.FightBuffComponent, other.FightBuffComponent) && object.Equals(this.NearbyTrackingComponentPb, other.NearbyTrackingComponentPb) && object.Equals(this.DropComponentPb, other.DropComponentPb) && object.Equals(this.MonsterCaptureComponent, other.MonsterCaptureComponent) && object.Equals(this.LogicStateComponentPb, other.LogicStateComponentPb) && object.Equals(this.AdviceComponentPb, other.AdviceComponentPb) && object.Equals(this.LiftComponentPb, other.LiftComponentPb) && object.Equals(this.InteractComponent, other.InteractComponent) && object.Equals(this.EquipComponent, other.EquipComponent) && object.Equals(this.BeControlledComponentPb, other.BeControlledComponentPb) && object.Equals(this.ConcomitantsComponentPb, other.ConcomitantsComponentPb) && object.Equals(this.TimelineTrackComponentPb, other.TimelineTrackComponentPb) && object.Equals(this.SummonsComponentPb, other.SummonsComponentPb) && object.Equals(this.EntityFsmComponentPb, other.EntityFsmComponentPb) && object.Equals(this.BoardPb, other.BoardPb) && object.Equals(this.PlacementItemPb, other.PlacementItemPb) && object.Equals(this.StateTagComponentPb, other.StateTagComponentPb) && object.Equals(this.MonsterGachaDataPb, other.MonsterGachaDataPb) && object.Equals(this.FanComponentPb, other.FanComponentPb) && object.Equals(this.NpcPb, other.NpcPb) && object.Equals(this.BubbleComponent, other.BubbleComponent) && object.Equals(this.PatrolComponent, other.PatrolComponent) && object.Equals(this.RangeComponent, other.RangeComponent) && object.Equals(this.PassiveSkillComponentPb, other.PassiveSkillComponentPb) && object.Equals(this.SkillComponentPb, other.SkillComponentPb) && object.Equals(this.DynamicAttachComponentPb, other.DynamicAttachComponentPb) && object.Equals(this.VarComponentPb, other.VarComponentPb) && object.Equals(this.PlayerFollowerSelfComponentPb, other.PlayerFollowerSelfComponentPb) && object.Equals(this.SceneItemLifeCycleComponentPb, other.SceneItemLifeCycleComponentPb) && object.Equals(this.EntityBulletComponentPb, other.EntityBulletComponentPb) && object.Equals(this.BuffProducerComponentPb, other.BuffProducerComponentPb) && object.Equals(this.BuffConsumerComponentPb, other.BuffConsumerComponentPb) && object.Equals(this.SceneItemComponentPb, other.SceneItemComponentPb) && object.Equals(this.ShieldComponentPb, other.ShieldComponentPb) && object.Equals(this.NpcPerformComponentPb, other.NpcPerformComponentPb) && object.Equals(this.DependenceComponentPb, other.DependenceComponentPb) && object.Equals(this.RenjuDataPb, other.RenjuDataPb) && object.Equals(this.AiRoleComponentPb, other.AiRoleComponentPb) && object.Equals(this.PlayerFollowersComponentPb, other.PlayerFollowersComponentPb) && object.Equals(this.SceneItemAttributeComponentPb, other.SceneItemAttributeComponentPb) && object.Equals(this.PullingFoundationComponentPb, other.PullingFoundationComponentPb) && object.Equals(this.BatchBulletCastComponentPb, other.BatchBulletCastComponentPb) && object.Equals(this.RoleWeaponSkinComponent, other.RoleWeaponSkinComponent) && object.Equals(this.CombineEntityInfoPb, other.CombineEntityInfoPb) && object.Equals(this.SceneItemAiComponentPb, other.SceneItemAiComponentPb) && object.Equals(this.AnimalCollectComponentPb, other.AnimalCollectComponentPb) && object.Equals(this.VehiclePassengerComponentPb, other.VehiclePassengerComponentPb) && object.Equals(this.HookLockPointComponentPb, other.HookLockPointComponentPb) && object.Equals(this.HackingComponentPb, other.HackingComponentPb) && object.Equals(this.HackTargetComponentPb, other.HackTargetComponentPb) && object.Equals(this.GravityFlipComponentPb, other.GravityFlipComponentPb) && object.Equals(this.EntityMoveSplineComponentPb, other.EntityMoveSplineComponentPb) && object.Equals(this.EntityRewardItemPb, other.EntityRewardItemPb) && object.Equals(this.TemplateEntitySpawnerComponentPb, other.TemplateEntitySpawnerComponentPb) && object.Equals(this.GridObjectComponentPb, other.GridObjectComponentPb) && object.Equals(this.SimpleCombatComponentPb, other.SimpleCombatComponentPb) && object.Equals(this.TrapDefenseComponentPb, other.TrapDefenseComponentPb) && object.Equals(this.HoldHandComponentPb, other.HoldHandComponentPb) && object.Equals(this.ListenerComponentPb, other.ListenerComponentPb) && object.Equals(this.ActivityComponentPb, other.ActivityComponentPb) && object.Equals(this.CalabashSkinComponentPb, other.CalabashSkinComponentPb) && object.Equals(this.HonamiStoryDropItemComponentPb, other.HonamiStoryDropItemComponentPb) && object.Equals(this.HonamiStoryEnhanceLevelComponentPb, other.HonamiStoryEnhanceLevelComponentPb) && object.Equals(this.MoveToPointComponentPb, other.MoveToPointComponentPb) && object.Equals(this.RbBlockComponentPb, other.RbBlockComponentPb) && object.Equals(this.SpiritGearComponentPb, other.SpiritGearComponentPb) && object.Equals(this.VehiclePb, other.VehiclePb) && object.Equals(this.RbFloorComponentPb, other.RbFloorComponentPb) && object.Equals(this.RbItemComponentPb, other.RbItemComponentPb) && object.Equals(this.RoadNetworkComponentPb, other.RoadNetworkComponentPb) && object.Equals(this.FollowEntityComponentPb, other.FollowEntityComponentPb) && object.Equals(this.MotorOutlookComponentPb, other.MotorOutlookComponentPb) && object.Equals(this.MotorDaCtxComponentPb, other.MotorDaCtxComponentPb) && object.Equals(this.ExhibitionComponentPb, other.ExhibitionComponentPb) && object.Equals(this.FurnitureComponentPb, other.FurnitureComponentPb) && object.Equals(this.OrnamentComponentPb, other.OrnamentComponentPb) && object.Equals(this.FlowerPollutionComponentPb, other.FlowerPollutionComponentPb) && object.Equals(this.DollGrabMachineComponentPb, other.DollGrabMachineComponentPb) && object.Equals(this.DollGrabShowcaseComponentPb, other.DollGrabShowcaseComponentPb) && object.Equals(this.GpuEntityComponentPb, other.GpuEntityComponentPb) && object.Equals(this.RoverRoguePortalComponentPb, other.RoverRoguePortalComponentPb) && object.Equals(this.DarkTideComponentPb, other.DarkTideComponentPb) && object.Equals(this.ElementalHolderComponentPb, other.ElementalHolderComponentPb) && object.Equals(this.EntityFoundationComponentPb, other.EntityFoundationComponentPb) && object.Equals(this.SquadPropComponentPb, other.SquadPropComponentPb) && object.Equals(this.ConnectorComponentPb, other.ConnectorComponentPb) && this.ComponentCase == other.ComponentCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006E55 RID: 28245 RVA: 0x0010A740 File Offset: 0x00108940
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
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DarkTideComponentPb)
			{
				num ^= this.DarkTideComponentPb.GetHashCode();
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ElementalHolderComponentPb)
			{
				num ^= this.ElementalHolderComponentPb.GetHashCode();
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

		// Token: 0x06006E56 RID: 28246 RVA: 0x0010B097 File Offset: 0x00109297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006E57 RID: 28247 RVA: 0x0010B0A4 File Offset: 0x001092A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E58 RID: 28248 RVA: 0x0010B0B0 File Offset: 0x001092B0
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
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DarkTideComponentPb)
			{
				output.WriteRawTag(130, 6);
				output.WriteMessage(this.DarkTideComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ElementalHolderComponentPb)
			{
				output.WriteRawTag(138, 6);
				output.WriteMessage(this.ElementalHolderComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.EntityFoundationComponentPb)
			{
				output.WriteRawTag(146, 6);
				output.WriteMessage(this.EntityFoundationComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.SquadPropComponentPb)
			{
				output.WriteRawTag(154, 6);
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

		// Token: 0x06006E59 RID: 28249 RVA: 0x0010BD9C File Offset: 0x00109F9C
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
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DarkTideComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.DarkTideComponentPb);
			}
			if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.ElementalHolderComponentPb)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.ElementalHolderComponentPb);
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

		// Token: 0x06006E5A RID: 28250 RVA: 0x0010C7B0 File Offset: 0x0010A9B0
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
			case EntityComponentPb.ComponentOneofCase.DarkTideComponentPb:
				if (this.DarkTideComponentPb == null)
				{
					this.DarkTideComponentPb = new DarkTideComponentPb();
				}
				this.DarkTideComponentPb.MergeFrom(other.DarkTideComponentPb);
				break;
			case EntityComponentPb.ComponentOneofCase.ElementalHolderComponentPb:
				if (this.ElementalHolderComponentPb == null)
				{
					this.ElementalHolderComponentPb = new ElementalHolderComponentPb();
				}
				this.ElementalHolderComponentPb.MergeFrom(other.ElementalHolderComponentPb);
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

		// Token: 0x06006E5B RID: 28251 RVA: 0x0010D92C File Offset: 0x0010BB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E5C RID: 28252 RVA: 0x0010D938 File Offset: 0x0010BB38
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
				else if (num <= 770U)
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
					if (num == 770U)
					{
						DarkTideComponentPb darkTideComponentPb = new DarkTideComponentPb();
						if (this.componentCase_ == EntityComponentPb.ComponentOneofCase.DarkTideComponentPb)
						{
							darkTideComponentPb.MergeFrom(this.DarkTideComponentPb);
						}
						input.ReadMessage(darkTideComponentPb);
						this.DarkTideComponentPb = darkTideComponentPb;
						continue;
					}
				}
				else if (num <= 786U)
				{
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
					if (num == 786U)
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
					if (num == 794U)
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

		// Token: 0x04003B3A RID: 15162
		private static readonly MessageParser<EntityComponentPb> _parser = new MessageParser<EntityComponentPb>(() => new EntityComponentPb());

		// Token: 0x04003B3B RID: 15163
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B3C RID: 15164
		public const int AttributeComponentFieldNumber = 1;

		// Token: 0x04003B3D RID: 15165
		public const int TagComponentFieldNumber = 2;

		// Token: 0x04003B3E RID: 15166
		public const int TriggerComponentFieldNumber = 3;

		// Token: 0x04003B3F RID: 15167
		public const int SummonerComponentFieldNumber = 4;

		// Token: 0x04003B40 RID: 15168
		public const int PartComponentFieldNumber = 5;

		// Token: 0x04003B41 RID: 15169
		public const int VisionSkillComponentFieldNumber = 6;

		// Token: 0x04003B42 RID: 15170
		public const int AnimationStateComponentFieldNumber = 7;

		// Token: 0x04003B43 RID: 15171
		public const int BlackboardParamComponentFieldNumber = 8;

		// Token: 0x04003B44 RID: 15172
		public const int SysBuffComponentFieldNumber = 10;

		// Token: 0x04003B45 RID: 15173
		public const int ClientDataComponentFieldNumber = 11;

		// Token: 0x04003B46 RID: 15174
		public const int MonsterWeaponComponentPbFieldNumber = 12;

		// Token: 0x04003B47 RID: 15175
		public const int MonsterAiComponentPbFieldNumber = 13;

		// Token: 0x04003B48 RID: 15176
		public const int FightBuffComponentFieldNumber = 15;

		// Token: 0x04003B49 RID: 15177
		public const int NearbyTrackingComponentPbFieldNumber = 16;

		// Token: 0x04003B4A RID: 15178
		public const int DropComponentPbFieldNumber = 17;

		// Token: 0x04003B4B RID: 15179
		public const int MonsterCaptureComponentFieldNumber = 18;

		// Token: 0x04003B4C RID: 15180
		public const int LogicStateComponentPbFieldNumber = 19;

		// Token: 0x04003B4D RID: 15181
		public const int AdviceComponentPbFieldNumber = 20;

		// Token: 0x04003B4E RID: 15182
		public const int LiftComponentPbFieldNumber = 21;

		// Token: 0x04003B4F RID: 15183
		public const int InteractComponentFieldNumber = 22;

		// Token: 0x04003B50 RID: 15184
		public const int EquipComponentFieldNumber = 23;

		// Token: 0x04003B51 RID: 15185
		public const int BeControlledComponentPbFieldNumber = 24;

		// Token: 0x04003B52 RID: 15186
		public const int ConcomitantsComponentPbFieldNumber = 25;

		// Token: 0x04003B53 RID: 15187
		public const int TimelineTrackComponentPbFieldNumber = 26;

		// Token: 0x04003B54 RID: 15188
		public const int SummonsComponentPbFieldNumber = 27;

		// Token: 0x04003B55 RID: 15189
		public const int EntityFsmComponentPbFieldNumber = 28;

		// Token: 0x04003B56 RID: 15190
		public const int BoardPbFieldNumber = 29;

		// Token: 0x04003B57 RID: 15191
		public const int PlacementItemPbFieldNumber = 30;

		// Token: 0x04003B58 RID: 15192
		public const int StateTagComponentPbFieldNumber = 31;

		// Token: 0x04003B59 RID: 15193
		public const int MonsterGachaDataPbFieldNumber = 32;

		// Token: 0x04003B5A RID: 15194
		public const int FanComponentPbFieldNumber = 33;

		// Token: 0x04003B5B RID: 15195
		public const int NpcPbFieldNumber = 34;

		// Token: 0x04003B5C RID: 15196
		public const int BubbleComponentFieldNumber = 35;

		// Token: 0x04003B5D RID: 15197
		public const int PatrolComponentFieldNumber = 36;

		// Token: 0x04003B5E RID: 15198
		public const int RangeComponentFieldNumber = 37;

		// Token: 0x04003B5F RID: 15199
		public const int PassiveSkillComponentPbFieldNumber = 38;

		// Token: 0x04003B60 RID: 15200
		public const int SkillComponentPbFieldNumber = 39;

		// Token: 0x04003B61 RID: 15201
		public const int DynamicAttachComponentPbFieldNumber = 40;

		// Token: 0x04003B62 RID: 15202
		public const int VarComponentPbFieldNumber = 41;

		// Token: 0x04003B63 RID: 15203
		public const int PlayerFollowerSelfComponentPbFieldNumber = 42;

		// Token: 0x04003B64 RID: 15204
		public const int SceneItemLifeCycleComponentPbFieldNumber = 43;

		// Token: 0x04003B65 RID: 15205
		public const int EntityBulletComponentPbFieldNumber = 44;

		// Token: 0x04003B66 RID: 15206
		public const int BuffProducerComponentPbFieldNumber = 45;

		// Token: 0x04003B67 RID: 15207
		public const int BuffConsumerComponentPbFieldNumber = 46;

		// Token: 0x04003B68 RID: 15208
		public const int SceneItemComponentPbFieldNumber = 47;

		// Token: 0x04003B69 RID: 15209
		public const int ShieldComponentPbFieldNumber = 48;

		// Token: 0x04003B6A RID: 15210
		public const int NpcPerformComponentPbFieldNumber = 49;

		// Token: 0x04003B6B RID: 15211
		public const int DependenceComponentPbFieldNumber = 50;

		// Token: 0x04003B6C RID: 15212
		public const int RenjuDataPbFieldNumber = 51;

		// Token: 0x04003B6D RID: 15213
		public const int AiRoleComponentPbFieldNumber = 52;

		// Token: 0x04003B6E RID: 15214
		public const int PlayerFollowersComponentPbFieldNumber = 53;

		// Token: 0x04003B6F RID: 15215
		public const int SceneItemAttributeComponentPbFieldNumber = 54;

		// Token: 0x04003B70 RID: 15216
		public const int PullingFoundationComponentPbFieldNumber = 55;

		// Token: 0x04003B71 RID: 15217
		public const int BatchBulletCastComponentPbFieldNumber = 56;

		// Token: 0x04003B72 RID: 15218
		public const int RoleWeaponSkinComponentFieldNumber = 57;

		// Token: 0x04003B73 RID: 15219
		public const int CombineEntityInfoPbFieldNumber = 58;

		// Token: 0x04003B74 RID: 15220
		public const int SceneItemAiComponentPbFieldNumber = 59;

		// Token: 0x04003B75 RID: 15221
		public const int AnimalCollectComponentPbFieldNumber = 60;

		// Token: 0x04003B76 RID: 15222
		public const int VehiclePassengerComponentPbFieldNumber = 61;

		// Token: 0x04003B77 RID: 15223
		public const int HookLockPointComponentPbFieldNumber = 62;

		// Token: 0x04003B78 RID: 15224
		public const int HackingComponentPbFieldNumber = 63;

		// Token: 0x04003B79 RID: 15225
		public const int HackTargetComponentPbFieldNumber = 64;

		// Token: 0x04003B7A RID: 15226
		public const int GravityFlipComponentPbFieldNumber = 65;

		// Token: 0x04003B7B RID: 15227
		public const int EntityMoveSplineComponentPbFieldNumber = 66;

		// Token: 0x04003B7C RID: 15228
		public const int EntityRewardItemPbFieldNumber = 67;

		// Token: 0x04003B7D RID: 15229
		public const int TemplateEntitySpawnerComponentPbFieldNumber = 68;

		// Token: 0x04003B7E RID: 15230
		public const int GridObjectComponentPbFieldNumber = 69;

		// Token: 0x04003B7F RID: 15231
		public const int SimpleCombatComponentPbFieldNumber = 70;

		// Token: 0x04003B80 RID: 15232
		public const int TrapDefenseComponentPbFieldNumber = 71;

		// Token: 0x04003B81 RID: 15233
		public const int HoldHandComponentPbFieldNumber = 72;

		// Token: 0x04003B82 RID: 15234
		public const int ListenerComponentPbFieldNumber = 73;

		// Token: 0x04003B83 RID: 15235
		public const int ActivityComponentPbFieldNumber = 74;

		// Token: 0x04003B84 RID: 15236
		public const int CalabashSkinComponentPbFieldNumber = 75;

		// Token: 0x04003B85 RID: 15237
		public const int HonamiStoryDropItemComponentPbFieldNumber = 76;

		// Token: 0x04003B86 RID: 15238
		public const int HonamiStoryEnhanceLevelComponentPbFieldNumber = 77;

		// Token: 0x04003B87 RID: 15239
		public const int MoveToPointComponentPbFieldNumber = 78;

		// Token: 0x04003B88 RID: 15240
		public const int RbBlockComponentPbFieldNumber = 79;

		// Token: 0x04003B89 RID: 15241
		public const int SpiritGearComponentPbFieldNumber = 80;

		// Token: 0x04003B8A RID: 15242
		public const int VehiclePbFieldNumber = 81;

		// Token: 0x04003B8B RID: 15243
		public const int RbFloorComponentPbFieldNumber = 82;

		// Token: 0x04003B8C RID: 15244
		public const int RbItemComponentPbFieldNumber = 83;

		// Token: 0x04003B8D RID: 15245
		public const int RoadNetworkComponentPbFieldNumber = 84;

		// Token: 0x04003B8E RID: 15246
		public const int FollowEntityComponentPbFieldNumber = 85;

		// Token: 0x04003B8F RID: 15247
		public const int MotorOutlookComponentPbFieldNumber = 86;

		// Token: 0x04003B90 RID: 15248
		public const int MotorDaCtxComponentPbFieldNumber = 87;

		// Token: 0x04003B91 RID: 15249
		public const int ExhibitionComponentPbFieldNumber = 88;

		// Token: 0x04003B92 RID: 15250
		public const int FurnitureComponentPbFieldNumber = 89;

		// Token: 0x04003B93 RID: 15251
		public const int OrnamentComponentPbFieldNumber = 90;

		// Token: 0x04003B94 RID: 15252
		public const int FlowerPollutionComponentPbFieldNumber = 91;

		// Token: 0x04003B95 RID: 15253
		public const int DollGrabMachineComponentPbFieldNumber = 92;

		// Token: 0x04003B96 RID: 15254
		public const int DollGrabShowcaseComponentPbFieldNumber = 93;

		// Token: 0x04003B97 RID: 15255
		public const int GpuEntityComponentPbFieldNumber = 94;

		// Token: 0x04003B98 RID: 15256
		public const int RoverRoguePortalComponentPbFieldNumber = 95;

		// Token: 0x04003B99 RID: 15257
		public const int DarkTideComponentPbFieldNumber = 96;

		// Token: 0x04003B9A RID: 15258
		public const int ElementalHolderComponentPbFieldNumber = 97;

		// Token: 0x04003B9B RID: 15259
		public const int EntityFoundationComponentPbFieldNumber = 98;

		// Token: 0x04003B9C RID: 15260
		public const int SquadPropComponentPbFieldNumber = 99;

		// Token: 0x04003B9D RID: 15261
		public const int ConnectorComponentPbFieldNumber = 103;

		// Token: 0x04003B9E RID: 15262
		private object component_;

		// Token: 0x04003B9F RID: 15263
		private EntityComponentPb.ComponentOneofCase componentCase_;

		// Token: 0x0200176D RID: 5997
		public enum ComponentOneofCase
		{
			// Token: 0x0400C61A RID: 50714
			None,
			// Token: 0x0400C61B RID: 50715
			AttributeComponent,
			// Token: 0x0400C61C RID: 50716
			TagComponent,
			// Token: 0x0400C61D RID: 50717
			TriggerComponent,
			// Token: 0x0400C61E RID: 50718
			SummonerComponent,
			// Token: 0x0400C61F RID: 50719
			PartComponent,
			// Token: 0x0400C620 RID: 50720
			VisionSkillComponent,
			// Token: 0x0400C621 RID: 50721
			AnimationStateComponent,
			// Token: 0x0400C622 RID: 50722
			BlackboardParamComponent,
			// Token: 0x0400C623 RID: 50723
			SysBuffComponent = 10,
			// Token: 0x0400C624 RID: 50724
			ClientDataComponent,
			// Token: 0x0400C625 RID: 50725
			MonsterWeaponComponentPb,
			// Token: 0x0400C626 RID: 50726
			MonsterAiComponentPb,
			// Token: 0x0400C627 RID: 50727
			FightBuffComponent = 15,
			// Token: 0x0400C628 RID: 50728
			NearbyTrackingComponentPb,
			// Token: 0x0400C629 RID: 50729
			DropComponentPb,
			// Token: 0x0400C62A RID: 50730
			MonsterCaptureComponent,
			// Token: 0x0400C62B RID: 50731
			LogicStateComponentPb,
			// Token: 0x0400C62C RID: 50732
			AdviceComponentPb,
			// Token: 0x0400C62D RID: 50733
			LiftComponentPb,
			// Token: 0x0400C62E RID: 50734
			InteractComponent,
			// Token: 0x0400C62F RID: 50735
			EquipComponent,
			// Token: 0x0400C630 RID: 50736
			BeControlledComponentPb,
			// Token: 0x0400C631 RID: 50737
			ConcomitantsComponentPb,
			// Token: 0x0400C632 RID: 50738
			TimelineTrackComponentPb,
			// Token: 0x0400C633 RID: 50739
			SummonsComponentPb,
			// Token: 0x0400C634 RID: 50740
			EntityFsmComponentPb,
			// Token: 0x0400C635 RID: 50741
			BoardPb,
			// Token: 0x0400C636 RID: 50742
			PlacementItemPb,
			// Token: 0x0400C637 RID: 50743
			StateTagComponentPb,
			// Token: 0x0400C638 RID: 50744
			MonsterGachaDataPb,
			// Token: 0x0400C639 RID: 50745
			FanComponentPb,
			// Token: 0x0400C63A RID: 50746
			NpcPb,
			// Token: 0x0400C63B RID: 50747
			BubbleComponent,
			// Token: 0x0400C63C RID: 50748
			PatrolComponent,
			// Token: 0x0400C63D RID: 50749
			RangeComponent,
			// Token: 0x0400C63E RID: 50750
			PassiveSkillComponentPb,
			// Token: 0x0400C63F RID: 50751
			SkillComponentPb,
			// Token: 0x0400C640 RID: 50752
			DynamicAttachComponentPb,
			// Token: 0x0400C641 RID: 50753
			VarComponentPb,
			// Token: 0x0400C642 RID: 50754
			PlayerFollowerSelfComponentPb,
			// Token: 0x0400C643 RID: 50755
			SceneItemLifeCycleComponentPb,
			// Token: 0x0400C644 RID: 50756
			EntityBulletComponentPb,
			// Token: 0x0400C645 RID: 50757
			BuffProducerComponentPb,
			// Token: 0x0400C646 RID: 50758
			BuffConsumerComponentPb,
			// Token: 0x0400C647 RID: 50759
			SceneItemComponentPb,
			// Token: 0x0400C648 RID: 50760
			ShieldComponentPb,
			// Token: 0x0400C649 RID: 50761
			NpcPerformComponentPb,
			// Token: 0x0400C64A RID: 50762
			DependenceComponentPb,
			// Token: 0x0400C64B RID: 50763
			RenjuDataPb,
			// Token: 0x0400C64C RID: 50764
			AiRoleComponentPb,
			// Token: 0x0400C64D RID: 50765
			PlayerFollowersComponentPb,
			// Token: 0x0400C64E RID: 50766
			SceneItemAttributeComponentPb,
			// Token: 0x0400C64F RID: 50767
			PullingFoundationComponentPb,
			// Token: 0x0400C650 RID: 50768
			BatchBulletCastComponentPb,
			// Token: 0x0400C651 RID: 50769
			RoleWeaponSkinComponent,
			// Token: 0x0400C652 RID: 50770
			CombineEntityInfoPb,
			// Token: 0x0400C653 RID: 50771
			SceneItemAiComponentPb,
			// Token: 0x0400C654 RID: 50772
			AnimalCollectComponentPb,
			// Token: 0x0400C655 RID: 50773
			VehiclePassengerComponentPb,
			// Token: 0x0400C656 RID: 50774
			HookLockPointComponentPb,
			// Token: 0x0400C657 RID: 50775
			HackingComponentPb,
			// Token: 0x0400C658 RID: 50776
			HackTargetComponentPb,
			// Token: 0x0400C659 RID: 50777
			GravityFlipComponentPb,
			// Token: 0x0400C65A RID: 50778
			EntityMoveSplineComponentPb,
			// Token: 0x0400C65B RID: 50779
			EntityRewardItemPb,
			// Token: 0x0400C65C RID: 50780
			TemplateEntitySpawnerComponentPb,
			// Token: 0x0400C65D RID: 50781
			GridObjectComponentPb,
			// Token: 0x0400C65E RID: 50782
			SimpleCombatComponentPb,
			// Token: 0x0400C65F RID: 50783
			TrapDefenseComponentPb,
			// Token: 0x0400C660 RID: 50784
			HoldHandComponentPb,
			// Token: 0x0400C661 RID: 50785
			ListenerComponentPb,
			// Token: 0x0400C662 RID: 50786
			ActivityComponentPb,
			// Token: 0x0400C663 RID: 50787
			CalabashSkinComponentPb,
			// Token: 0x0400C664 RID: 50788
			HonamiStoryDropItemComponentPb,
			// Token: 0x0400C665 RID: 50789
			HonamiStoryEnhanceLevelComponentPb,
			// Token: 0x0400C666 RID: 50790
			MoveToPointComponentPb,
			// Token: 0x0400C667 RID: 50791
			RbBlockComponentPb,
			// Token: 0x0400C668 RID: 50792
			SpiritGearComponentPb,
			// Token: 0x0400C669 RID: 50793
			VehiclePb,
			// Token: 0x0400C66A RID: 50794
			RbFloorComponentPb,
			// Token: 0x0400C66B RID: 50795
			RbItemComponentPb,
			// Token: 0x0400C66C RID: 50796
			RoadNetworkComponentPb,
			// Token: 0x0400C66D RID: 50797
			FollowEntityComponentPb,
			// Token: 0x0400C66E RID: 50798
			MotorOutlookComponentPb,
			// Token: 0x0400C66F RID: 50799
			MotorDaCtxComponentPb,
			// Token: 0x0400C670 RID: 50800
			ExhibitionComponentPb,
			// Token: 0x0400C671 RID: 50801
			FurnitureComponentPb,
			// Token: 0x0400C672 RID: 50802
			OrnamentComponentPb,
			// Token: 0x0400C673 RID: 50803
			FlowerPollutionComponentPb,
			// Token: 0x0400C674 RID: 50804
			DollGrabMachineComponentPb,
			// Token: 0x0400C675 RID: 50805
			DollGrabShowcaseComponentPb,
			// Token: 0x0400C676 RID: 50806
			GpuEntityComponentPb,
			// Token: 0x0400C677 RID: 50807
			RoverRoguePortalComponentPb,
			// Token: 0x0400C678 RID: 50808
			DarkTideComponentPb,
			// Token: 0x0400C679 RID: 50809
			ElementalHolderComponentPb,
			// Token: 0x0400C67A RID: 50810
			EntityFoundationComponentPb,
			// Token: 0x0400C67B RID: 50811
			SquadPropComponentPb,
			// Token: 0x0400C67C RID: 50812
			ConnectorComponentPb = 103
		}
	}
}
