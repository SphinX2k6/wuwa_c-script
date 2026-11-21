using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelEntityAbility;
using CSharpScript.Game.Module.Teleport;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02005FEF RID: 24559
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerElementalCoreResetAbility : LevelEntityAbilityBase
	{
		// Token: 0x0603AFC7 RID: 241607 RVA: 0x010AC33C File Offset: 0x010AA53C
		public PlayerElementalCoreResetAbility(ELevelEntityAbilityType Type, EAbilityTickPhase TickPhase, int TickOrder, bool NeedTickActivate) : base(Type, TickPhase, TickOrder, NeedTickActivate)
		{
		}

		// Token: 0x0603AFC8 RID: 241608 RVA: 0x010AC36C File Offset: 0x010AA56C
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

		// Token: 0x0603AFC9 RID: 241609 RVA: 0x010AC3E0 File Offset: 0x010AA5E0
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

		// Token: 0x0603AFCA RID: 241610 RVA: 0x010AC420 File Offset: 0x010AA620
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

		// Token: 0x0603AFCB RID: 241611 RVA: 0x010AC4D4 File Offset: 0x010AA6D4
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

		// Token: 0x17006F6C RID: 28524
		// (get) Token: 0x0603AFCC RID: 241612 RVA: 0x010AC560 File Offset: 0x010AA760
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401F091 RID: 127121
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x0401F092 RID: 127122
		private readonly Vector TempVector = Vector.Create();

		// Token: 0x0401F093 RID: 127123
		private long ResetDistanceSquared;

		// Token: 0x0401F094 RID: 127124
		private readonly Vector MappingLocation = Vector.Create();

		// Token: 0x0401F095 RID: 127125
		private long MappingResetDistanceSquared;

		// Token: 0x0401F096 RID: 127126
		private int MappingFoundationPbDataId;

		// Token: 0x0401F097 RID: 127127
		private bool MappingInited;

		// Token: 0x0401F098 RID: 127128
		private bool IsResetting;
	}
}
