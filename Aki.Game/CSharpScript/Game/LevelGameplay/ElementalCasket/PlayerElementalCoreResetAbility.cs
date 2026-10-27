using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelEntityAbility;
using CSharpScript.Game.Module.Teleport;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02006E6E RID: 28270
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerElementalCoreResetAbility : LevelEntityAbilityBase
	{
		// Token: 0x06044E35 RID: 282165 RVA: 0x01101DD1 File Offset: 0x010FFFD1
		public PlayerElementalCoreResetAbility(ELevelEntityAbilityType Type, EAbilityTickPhase TickPhase, int TickOrder, bool NeedTickActivate) : base(Type, TickPhase, TickOrder, NeedTickActivate)
		{
		}

		// Token: 0x06044E36 RID: 282166 RVA: 0x01101E00 File Offset: 0x01100000
		public override void OnActivated(Entity entity)
		{
			EntityHandle coreFoundationEntityHandle = entity.GetComponent<PlayerElementalCasketComponent>().GetCoreFoundationEntityHandle();
			if (coreFoundationEntityHandle == null || !coreFoundationEntityHandle.IsInit)
			{
				return;
			}
			WorldEntity entity2 = coreFoundationEntityHandle.Entity;
			SceneItemElementalCoreFoundationComponent component = entity2.GetComponent<SceneItemElementalCoreFoundationComponent>();
			BaseActorComponent component2 = entity2.GetComponent<BaseActorComponent>();
			this.StartLocation.DeepCopy(component2.ActorLocationProxy);
			int resetDistance = component.GetResetDistance();
			this.ResetDistanceSquared = (long)resetDistance * (long)resetDistance;
			this.MappingFoundationPbDataId = component.GetMappingFoundationPbDataId();
			this.MappingInited = false;
		}

		// Token: 0x06044E37 RID: 282167 RVA: 0x01101E74 File Offset: 0x01100074
		public override void OnDeactivated(Entity entity)
		{
			this.ResetDistanceSquared = 0L;
			this.StartLocation.Reset();
			this.MappingLocation.Reset();
			this.MappingResetDistanceSquared = 0L;
			this.MappingFoundationPbDataId = 0;
			this.MappingInited = false;
			this.IsResetting = false;
		}

		// Token: 0x06044E38 RID: 282168 RVA: 0x01101EB4 File Offset: 0x011000B4
		public override void OnTick(Entity entity, float deltaMilliseconds)
		{
			if (this.IsResetting || this.ResetDistanceSquared <= 0L || TeleportModel.Instance.IsTeleport)
			{
				return;
			}
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null || !baseCharacter.IsValid())
			{
				return;
			}
			Vector tempVector = this.TempVector;
			FVectorDouble fvectorDouble = baseCharacter.D_K2_GetActorLocation();
			tempVector.FromUeVector(fvectorDouble);
			if (Vector.DistSquared(this.TempVector, this.StartLocation) <= (double)this.ResetDistanceSquared)
			{
				return;
			}
			if (this.TryInitMappingRange() && Vector.DistSquared(this.TempVector, this.MappingLocation) <= (double)this.MappingResetDistanceSquared)
			{
				return;
			}
			this.IsResetting = true;
			ElementalCasketController.Instance.PlayerResetElementalCore(delegate(bool _)
			{
				this.IsResetting = false;
			});
		}

		// Token: 0x06044E39 RID: 282169 RVA: 0x01101F68 File Offset: 0x01100168
		private bool TryInitMappingRange()
		{
			if (this.MappingInited)
			{
				return true;
			}
			if (this.MappingFoundationPbDataId <= 0)
			{
				return false;
			}
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.MappingFoundationPbDataId);
			if (entityByPbDataId == null || !entityByPbDataId.IsInit)
			{
				return false;
			}
			WorldEntity entity = entityByPbDataId.Entity;
			SceneItemElementalCoreFoundationComponent component = entity.GetComponent<SceneItemElementalCoreFoundationComponent>();
			BaseActorComponent component2 = entity.GetComponent<BaseActorComponent>();
			if (component == null || component2 == null)
			{
				return false;
			}
			this.MappingLocation.FromUeVector(component2.ActorLocationProxy);
			int resetDistance = component.GetResetDistance();
			this.MappingResetDistanceSquared = (long)resetDistance * (long)resetDistance;
			this.MappingInited = true;
			return true;
		}

		// Token: 0x04023DDC RID: 146908
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x04023DDD RID: 146909
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x04023DDE RID: 146910
		private long ResetDistanceSquared;

		// Token: 0x04023DDF RID: 146911
		private readonly Vector MappingLocation = Vector.Create();

		// Token: 0x04023DE0 RID: 146912
		private long MappingResetDistanceSquared;

		// Token: 0x04023DE1 RID: 146913
		private int MappingFoundationPbDataId;

		// Token: 0x04023DE2 RID: 146914
		private bool MappingInited;

		// Token: 0x04023DE3 RID: 146915
		private bool IsResetting;
	}
}
