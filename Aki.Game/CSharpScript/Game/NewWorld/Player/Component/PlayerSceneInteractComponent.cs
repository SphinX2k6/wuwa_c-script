using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelEntityAbility;
using CSharpScript.Game.LevelGamePlay.SceneInteract;

namespace CSharpScript.Game.NewWorld.Player.Component
{
	// Token: 0x020061DA RID: 25050
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerSceneInteractComponent : EntityComponent
	{
		// Token: 0x0603C1EE RID: 246254 RVA: 0x0111CF0A File Offset: 0x0111B10A
		[NullableContext(2)]
		public void SetBestInteractPoint(ISceneInteractPoint bestInteractPoint)
		{
			this.BestInteractPoint = bestInteractPoint;
		}

		// Token: 0x0603C1EF RID: 246255 RVA: 0x0111CF13 File Offset: 0x0111B113
		[NullableContext(2)]
		public ISceneInteractPoint GetBestInteractPoint()
		{
			return this.BestInteractPoint;
		}

		// Token: 0x0603C1F0 RID: 246256 RVA: 0x0111CF1C File Offset: 0x0111B11C
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

		// Token: 0x0603C1F1 RID: 246257 RVA: 0x0111CF5C File Offset: 0x0111B15C
		public void RemoveInteractingPoint(int pointId)
		{
			this.InteractingPointIds.Remove(pointId);
		}

		// Token: 0x0603C1F2 RID: 246258 RVA: 0x0111CF6C File Offset: 0x0111B16C
		public bool IsInteractingPoint(ISceneInteractPoint point)
		{
			int? pointId = SceneInteractPointManager.Instance.GetPointId(point);
			return pointId != null && this.InteractingPointIds.Contains(pointId.Value);
		}

		// Token: 0x0603C1F3 RID: 246259 RVA: 0x0111CFA4 File Offset: 0x0111B1A4
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

		// Token: 0x0603C1F4 RID: 246260 RVA: 0x0111D056 File Offset: 0x0111B256
		protected override void OnTick(float delta)
		{
			LevelEntityAbilityContainer abilityContainer = this.AbilityContainer;
			if (abilityContainer == null)
			{
				return;
			}
			abilityContainer.Tick(delta);
		}

		// Token: 0x0603C1F5 RID: 246261 RVA: 0x0111D06C File Offset: 0x0111B26C
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

		// Token: 0x0603C1F6 RID: 246262 RVA: 0x0111D10D File Offset: 0x0111B30D
		private void OnInteractPointRemoved(int pointId)
		{
			this.InteractingPointIds.Remove(pointId);
		}

		// Token: 0x0603C1F7 RID: 246263 RVA: 0x0111D11C File Offset: 0x0111B31C
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			PlayerSceneInteractComponent playerSceneInteractComponent = (PlayerSceneInteractComponent)componentTemplate;
			if (playerSceneInteractComponent.AbilityContainer == null)
			{
				this.AbilityContainer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AbilityContainer), "AbilityContainer"))
			{
				return false;
			}
			if (playerSceneInteractComponent.BestInteractPoint == null)
			{
				this.BestInteractPoint = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BestInteractPoint), "BestInteractPoint"))
			{
				return false;
			}
			return playerSceneInteractComponent.InteractingPointIds == null || base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.InteractingPointIds), "InteractingPointIds");
		}

		// Token: 0x17007170 RID: 29040
		// (get) Token: 0x0603C1F8 RID: 246264 RVA: 0x0111D1B4 File Offset: 0x0111B3B4
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007171 RID: 29041
		// (get) Token: 0x0603C1F9 RID: 246265 RVA: 0x0111D1B7 File Offset: 0x0111B3B7
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007172 RID: 29042
		// (get) Token: 0x0603C1FA RID: 246266 RVA: 0x0111D1BA File Offset: 0x0111B3BA
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FD17 RID: 130327
		[Nullable(2)]
		private LevelEntityAbilityContainer AbilityContainer;

		// Token: 0x0401FD18 RID: 130328
		[Nullable(2)]
		private ISceneInteractPoint BestInteractPoint;

		// Token: 0x0401FD19 RID: 130329
		private readonly HashSet<int> InteractingPointIds = new HashSet<int>();
	}
}
