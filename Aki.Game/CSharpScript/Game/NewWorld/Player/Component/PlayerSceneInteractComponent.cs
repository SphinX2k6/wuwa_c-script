using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelEntityAbility;
using CSharpScript.Game.LevelGamePlay.SceneInteract;

namespace CSharpScript.Game.NewWorld.Player.Component
{
	// Token: 0x02007059 RID: 28761
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerSceneInteractComponent : EntityComponent
	{
		// Token: 0x06045FFB RID: 286715 RVA: 0x011732F2 File Offset: 0x011714F2
		[NullableContext(2)]
		public void SetBestInteractPoint(ISceneInteractPoint bestInteractPoint)
		{
			this.BestInteractPoint = bestInteractPoint;
		}

		// Token: 0x06045FFC RID: 286716 RVA: 0x011732FB File Offset: 0x011714FB
		[NullableContext(2)]
		public ISceneInteractPoint GetBestInteractPoint()
		{
			return this.BestInteractPoint;
		}

		// Token: 0x06045FFD RID: 286717 RVA: 0x01173304 File Offset: 0x01171504
		public int? AddInteractingPoint(ISceneInteractPoint point)
		{
			int? pointId = SceneInteractPointManager.Instance.GetPointId(point);
			if (pointId == null)
			{
				return null;
			}
			this.InteractingPointIds.Add(pointId.Value);
			return pointId;
		}

		// Token: 0x06045FFE RID: 286718 RVA: 0x01173344 File Offset: 0x01171544
		public void RemoveInteractingPoint(int pointId)
		{
			this.InteractingPointIds.Remove(pointId);
		}

		// Token: 0x06045FFF RID: 286719 RVA: 0x01173354 File Offset: 0x01171554
		public bool IsInteractingPoint(ISceneInteractPoint point)
		{
			int? pointId = SceneInteractPointManager.Instance.GetPointId(point);
			return pointId != null && this.InteractingPointIds.Contains(pointId.Value);
		}

		// Token: 0x06046000 RID: 286720 RVA: 0x0117338C File Offset: 0x0117158C
		protected override bool OnStart()
		{
			CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
			int? num = (component != null) ? new int?(component.GetPlayerId()) : null;
			int? id = PlayerInfoModel.Instance.GetId();
			if (num.GetValueOrDefault() == id.GetValueOrDefault() & num != null == (id != null))
			{
				this.AbilityContainer = new LevelEntityAbilityContainer(base.Entity);
				this.AbilityContainer.AddAbility(ELevelEntityAbilityType.PlayerSearchSceneInteractPoint);
				this.AbilityContainer.AddAbility(ELevelEntityAbilityType.PlayerSceneInteractPointView);
				this.AbilityContainer.AddAbility(ELevelEntityAbilityType.PlayerSceneInteractTag);
				SceneInteractPointManager.Instance.AddPointRemovedListener(new Action<int>(this.OnInteractPointRemoved));
			}
			return true;
		}

		// Token: 0x06046001 RID: 286721 RVA: 0x0117343E File Offset: 0x0117163E
		protected override void OnTick(float delta)
		{
			LevelEntityAbilityContainer abilityContainer = this.AbilityContainer;
			if (abilityContainer == null)
			{
				return;
			}
			abilityContainer.Tick(delta);
		}

		// Token: 0x06046002 RID: 286722 RVA: 0x01173454 File Offset: 0x01171654
		protected override bool OnEnd()
		{
			CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
			int? num = (component != null) ? new int?(component.GetPlayerId()) : null;
			int? id = PlayerInfoModel.Instance.GetId();
			if (num.GetValueOrDefault() == id.GetValueOrDefault() & num != null == (id != null))
			{
				SceneInteractPointManager.Instance.RemovePointRemovedListener(new Action<int>(this.OnInteractPointRemoved));
			}
			this.BestInteractPoint = null;
			this.InteractingPointIds.Clear();
			LevelEntityAbilityContainer abilityContainer = this.AbilityContainer;
			if (abilityContainer != null)
			{
				abilityContainer.Destroy();
			}
			this.AbilityContainer = null;
			return true;
		}

		// Token: 0x06046003 RID: 286723 RVA: 0x011734F5 File Offset: 0x011716F5
		private void OnInteractPointRemoved(int pointId)
		{
			this.InteractingPointIds.Remove(pointId);
		}

		// Token: 0x06046004 RID: 286724 RVA: 0x01173504 File Offset: 0x01171704
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			PlayerSceneInteractComponent playerSceneInteractComponent = (PlayerSceneInteractComponent)componentTemplate;
			if (base.CanResetComponentProperty("AbilityContainer"))
			{
				if (playerSceneInteractComponent.AbilityContainer == null)
				{
					this.AbilityContainer = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<LevelEntityAbilityContainer>(this.AbilityContainer), "AbilityContainer"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("BestInteractPoint"))
			{
				if (playerSceneInteractComponent.BestInteractPoint == null)
				{
					this.BestInteractPoint = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ISceneInteractPoint>(this.BestInteractPoint), "BestInteractPoint"))
				{
					return false;
				}
			}
			return !base.CanResetComponentProperty("InteractingPointIds") || playerSceneInteractComponent.InteractingPointIds == null || base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.InteractingPointIds), "InteractingPointIds");
		}

		// Token: 0x04024A61 RID: 150113
		[Nullable(2)]
		private LevelEntityAbilityContainer AbilityContainer;

		// Token: 0x04024A62 RID: 150114
		[Nullable(2)]
		private ISceneInteractPoint BestInteractPoint;

		// Token: 0x04024A63 RID: 150115
		private readonly HashSet<int> InteractingPointIds = new HashSet<int>();
	}
}
