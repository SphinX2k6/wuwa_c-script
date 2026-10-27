using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200716C RID: 29036
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemAiInteractionComponent : EntityComponent, IComponentDependency
	{
		// Token: 0x17009D5F RID: 40287
		// (get) Token: 0x06046E03 RID: 290307 RVA: 0x011E0D28 File Offset: 0x011DEF28
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Type[] Dependencies
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return new Type[]
				{
					typeof(SceneItemActorComponent)
				};
			}
		}

		// Token: 0x06046E04 RID: 290308 RVA: 0x011E0D40 File Offset: 0x011DEF40
		protected override bool OnStart()
		{
			this.LastUsedTime = -2000.0;
			this.IsUsingByAi = new bool?(false);
			this.ClearSearchInfo();
			this.OnEntityDeadEvent = new Action(this.OnEntityDead);
			if (!base.Entity.GetComponent<CreatureDataComponent>().GetVisible())
			{
				this.EnableHandler = new int?(base.Entity.Disable("[SceneItemAiInteractionComponent.OnStart] visible为false"));
			}
			else
			{
				this.EnableHandler = new int?(-1);
			}
			this.MoveComp = base.Entity.GetComponent<AiWeaponMovementComponent>();
			AiInteractionItemQueryManager.Get().RegisterItem(base.Entity);
			return true;
		}

		// Token: 0x06046E05 RID: 290309 RVA: 0x011E0DDE File Offset: 0x011DEFDE
		protected override bool OnEnd()
		{
			AiInteractionItemQueryManager.Get().UnRegisterItem(base.Entity);
			return true;
		}

		// Token: 0x06046E06 RID: 290310 RVA: 0x011E0DF2 File Offset: 0x011DEFF2
		private void ClearSearchInfo()
		{
			this.IsSearchByAi = new bool?(false);
			this.SearchEntity = null;
		}

		// Token: 0x06046E07 RID: 290311 RVA: 0x011E0E07 File Offset: 0x011DF007
		public void OnEntityDead()
		{
			EventSystem.Instance.RemoveWithTarget(this.SearchEntity, EEventName.CharOnRoleDeadTargetSelf, this.OnEntityDeadEvent);
			this.ClearSearchInfo();
		}

		// Token: 0x06046E08 RID: 290312 RVA: 0x011E0E2B File Offset: 0x011DF02B
		public void SetSearched(Entity searchEntity)
		{
			if (this.IsSearchByAi.GetValueOrDefault())
			{
				return;
			}
			this.IsSearchByAi = new bool?(true);
			this.SearchEntity = searchEntity;
			EventSystem.Instance.AddWithTarget(searchEntity, EEventName.CharOnRoleDeadTargetSelf, this.OnEntityDeadEvent);
		}

		// Token: 0x06046E09 RID: 290313 RVA: 0x011E0E65 File Offset: 0x011DF065
		public void SetUnSearched()
		{
			if (!this.IsSearchByAi.GetValueOrDefault())
			{
				return;
			}
			this.OnEntityDead();
		}

		// Token: 0x06046E0A RID: 290314 RVA: 0x011E0E7B File Offset: 0x011DF07B
		public void OnLastUsed()
		{
			this.SetUnSearched();
			this.LastUsedTime = Time.Instance.WorldTime;
		}

		// Token: 0x06046E0B RID: 290315 RVA: 0x011E0E93 File Offset: 0x011DF093
		public bool CanBeUsed()
		{
			if (this.MoveComp != null)
			{
				return !this.MoveComp.EnableMovement.Value;
			}
			return Time.Instance.WorldTime - this.LastUsedTime > 2000.0;
		}

		// Token: 0x06046E0C RID: 290316 RVA: 0x011E0ED0 File Offset: 0x011DF0D0
		public bool HiddenItem(bool bHidden)
		{
			if (bHidden != (this.EnableHandler.GetValueOrDefault() != -1))
			{
				if (bHidden)
				{
					this.EnableHandler = new int?(base.Entity.Disable("[SceneItemAiInteractionComponent.HiddenItem] bHidden为true"));
				}
				else
				{
					base.Entity.Enable(this.EnableHandler.Value, "[SceneItemAiInteractionComponent.HiddenItem] bHidden为false");
					this.EnableHandler = new int?(-1);
				}
				return true;
			}
			return false;
		}

		// Token: 0x06046E0D RID: 290317 RVA: 0x011E0F3C File Offset: 0x011DF13C
		public void ItemAttachEntity(Entity entity)
		{
		}

		// Token: 0x06046E0E RID: 290318 RVA: 0x011E0F3E File Offset: 0x011DF13E
		public bool IsSearchByOther(int entityId)
		{
			return this.IsSearchByAi.GetValueOrDefault() && this.SearchEntity.Id != entityId;
		}

		// Token: 0x06046E0F RID: 290319 RVA: 0x011E0F60 File Offset: 0x011DF160
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemAiInteractionComponent sceneItemAiInteractionComponent = (SceneItemAiInteractionComponent)componentTemplate;
			if (base.CanResetComponentProperty("IsSearchByAi"))
			{
				this.IsSearchByAi = sceneItemAiInteractionComponent.IsSearchByAi;
			}
			if (base.CanResetComponentProperty("SearchEntity"))
			{
				if (sceneItemAiInteractionComponent.SearchEntity == null)
				{
					this.SearchEntity = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Entity>(this.SearchEntity), "SearchEntity"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsUsingByAi"))
			{
				this.IsUsingByAi = sceneItemAiInteractionComponent.IsUsingByAi;
			}
			if (base.CanResetComponentProperty("LastUsedTime"))
			{
				this.LastUsedTime = sceneItemAiInteractionComponent.LastUsedTime;
			}
			if (base.CanResetComponentProperty("EnableHandler"))
			{
				this.EnableHandler = sceneItemAiInteractionComponent.EnableHandler;
			}
			if (base.CanResetComponentProperty("MoveComp"))
			{
				if (sceneItemAiInteractionComponent.MoveComp == null)
				{
					this.MoveComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AiWeaponMovementComponent>(this.MoveComp), "MoveComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("OnEntityDeadEvent"))
			{
				if (sceneItemAiInteractionComponent.OnEntityDeadEvent == null)
				{
					this.OnEntityDeadEvent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Action>(this.OnEntityDeadEvent), "OnEntityDeadEvent"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04025346 RID: 152390
		private const int AI_USED_COLD_DOWN = 2000;

		// Token: 0x04025347 RID: 152391
		public bool? IsSearchByAi;

		// Token: 0x04025348 RID: 152392
		[Nullable(2)]
		public Entity SearchEntity;

		// Token: 0x04025349 RID: 152393
		public bool? IsUsingByAi;

		// Token: 0x0402534A RID: 152394
		public double LastUsedTime = -2000.0;

		// Token: 0x0402534B RID: 152395
		public int? EnableHandler;

		// Token: 0x0402534C RID: 152396
		[Nullable(2)]
		public AiWeaponMovementComponent MoveComp;

		// Token: 0x0402534D RID: 152397
		[Nullable(2)]
		public Action OnEntityDeadEvent;
	}
}
