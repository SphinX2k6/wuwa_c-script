using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02006220 RID: 25120
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemAiInteractionComponent : EntityComponent
	{
		// Token: 0x17007212 RID: 29202
		// (get) Token: 0x0603C657 RID: 247383 RVA: 0x0113C678 File Offset: 0x0113A878
		public override Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(SceneItemActorComponent)
				};
			}
		}

		// Token: 0x0603C658 RID: 247384 RVA: 0x0113C690 File Offset: 0x0113A890
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

		// Token: 0x0603C659 RID: 247385 RVA: 0x0113C72E File Offset: 0x0113A92E
		protected override bool OnEnd()
		{
			AiInteractionItemQueryManager.Get().UnRegisterItem(base.Entity);
			return true;
		}

		// Token: 0x0603C65A RID: 247386 RVA: 0x0113C742 File Offset: 0x0113A942
		private void ClearSearchInfo()
		{
			this.IsSearchByAi = new bool?(false);
			this.SearchEntity = null;
		}

		// Token: 0x0603C65B RID: 247387 RVA: 0x0113C757 File Offset: 0x0113A957
		public void OnEntityDead()
		{
			EventSystem.Instance.RemoveWithTarget(this.SearchEntity, EEventName.CharOnRoleDeadTargetSelf, this.OnEntityDeadEvent);
			this.ClearSearchInfo();
		}

		// Token: 0x0603C65C RID: 247388 RVA: 0x0113C77B File Offset: 0x0113A97B
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

		// Token: 0x0603C65D RID: 247389 RVA: 0x0113C7B5 File Offset: 0x0113A9B5
		public void SetUnSearched()
		{
			if (!this.IsSearchByAi.GetValueOrDefault())
			{
				return;
			}
			this.OnEntityDead();
		}

		// Token: 0x0603C65E RID: 247390 RVA: 0x0113C7CB File Offset: 0x0113A9CB
		public void OnLastUsed()
		{
			this.SetUnSearched();
			this.LastUsedTime = Time.Instance.WorldTime;
		}

		// Token: 0x0603C65F RID: 247391 RVA: 0x0113C7E3 File Offset: 0x0113A9E3
		public bool CanBeUsed()
		{
			if (this.MoveComp != null)
			{
				return !this.MoveComp.EnableMovement.Value;
			}
			return Time.Instance.WorldTime - this.LastUsedTime > 2000.0;
		}

		// Token: 0x0603C660 RID: 247392 RVA: 0x0113C820 File Offset: 0x0113AA20
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

		// Token: 0x0603C661 RID: 247393 RVA: 0x0113C88C File Offset: 0x0113AA8C
		public void ItemAttachEntity(Entity entity)
		{
		}

		// Token: 0x0603C662 RID: 247394 RVA: 0x0113C88E File Offset: 0x0113AA8E
		public bool IsSearchByOther(int entityId)
		{
			return this.IsSearchByAi.GetValueOrDefault() && this.SearchEntity.Id != entityId;
		}

		// Token: 0x0603C663 RID: 247395 RVA: 0x0113C8B0 File Offset: 0x0113AAB0
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemAiInteractionComponent sceneItemAiInteractionComponent = (SceneItemAiInteractionComponent)componentTemplate;
			this.IsSearchByAi = sceneItemAiInteractionComponent.IsSearchByAi;
			if (sceneItemAiInteractionComponent.SearchEntity == null)
			{
				this.SearchEntity = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SearchEntity), "SearchEntity"))
			{
				return false;
			}
			this.IsUsingByAi = sceneItemAiInteractionComponent.IsUsingByAi;
			this.LastUsedTime = sceneItemAiInteractionComponent.LastUsedTime;
			this.EnableHandler = sceneItemAiInteractionComponent.EnableHandler;
			if (sceneItemAiInteractionComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
			{
				return false;
			}
			if (sceneItemAiInteractionComponent.OnEntityDeadEvent == null)
			{
				this.OnEntityDeadEvent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnEntityDeadEvent), "OnEntityDeadEvent"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x17007213 RID: 29203
		// (get) Token: 0x0603C664 RID: 247396 RVA: 0x0113C981 File Offset: 0x0113AB81
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007214 RID: 29204
		// (get) Token: 0x0603C665 RID: 247397 RVA: 0x0113C984 File Offset: 0x0113AB84
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FFAD RID: 130989
		private const int AI_USED_COLD_DOWN = 2000;

		// Token: 0x0401FFAE RID: 130990
		public bool? IsSearchByAi;

		// Token: 0x0401FFAF RID: 130991
		[Nullable(2)]
		public Entity SearchEntity;

		// Token: 0x0401FFB0 RID: 130992
		public bool? IsUsingByAi;

		// Token: 0x0401FFB1 RID: 130993
		public double LastUsedTime = -2000.0;

		// Token: 0x0401FFB2 RID: 130994
		public int? EnableHandler;

		// Token: 0x0401FFB3 RID: 130995
		[Nullable(2)]
		public AiWeaponMovementComponent MoveComp;

		// Token: 0x0401FFB4 RID: 130996
		[Nullable(2)]
		public Action OnEntityDeadEvent;
	}
}
