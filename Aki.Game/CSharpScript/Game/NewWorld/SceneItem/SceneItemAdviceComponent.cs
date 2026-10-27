using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.Pawn.Component;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200716B RID: 29035
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemAdviceComponent : EntityComponent
	{
		// Token: 0x06046DFC RID: 290300 RVA: 0x011E0AA8 File Offset: 0x011DECA8
		protected override void OnActivate()
		{
			PawnInteractNewComponent component = base.Entity.GetComponent<PawnInteractNewComponent>();
			if (component == null)
			{
				return;
			}
			if (component.GetInteractController() == null)
			{
				return;
			}
			CreatureDataComponent component2 = base.Entity.GetComponent<CreatureDataComponent>();
			if (component2 == null)
			{
				return;
			}
			AdviceEntityData adviceInfo = component2.GetAdviceInfo();
			if (adviceInfo == null)
			{
				return;
			}
			PawnInfoManageComponent component3 = base.Entity.GetComponent<PawnInfoManageComponent>();
			if (component3 == null)
			{
				return;
			}
			this.TagComponent = base.Entity.GetComponent<LevelTagComponent>();
			string text = AdviceConfig.Instance.GetAdviceInteractText();
			text = text.Replace("{PlayerName}", adviceInfo.GetPlayerName());
			component3.PawnName = text;
		}

		// Token: 0x06046DFD RID: 290301 RVA: 0x011E0B34 File Offset: 0x011DED34
		public void DoInteract()
		{
			this.ClearTimer();
			if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["关卡.Common.状态.常态"]))
			{
				this.TagComponent.ChangeLocalLevelTag(GameplayTagDefine.EGameplayTagId["关卡.Common.状态.激活"], GameplayTagDefine.EGameplayTagId["关卡.Common.状态.常态"]);
				EventSystem.Instance.EmitWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, GameplayTagDefine.EGameplayTagId["关卡.Common.状态.激活"], false);
				this.ClearTimer();
				this.RevertTimer = TimerSystem.Instance.Delay(new TTimerAction(this.OnInteractFinish), 3000f, null, null, true, 1f);
			}
		}

		// Token: 0x06046DFE RID: 290302 RVA: 0x011E0BE4 File Offset: 0x011DEDE4
		private void OnInteractFinish(float delta)
		{
			this.ClearTimer();
			if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["关卡.Common.状态.激活"]))
			{
				this.TagComponent.ChangeLocalLevelTag(GameplayTagDefine.EGameplayTagId["关卡.Common.状态.常态"], GameplayTagDefine.EGameplayTagId["关卡.Common.状态.激活"]);
				EventSystem.Instance.EmitWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, GameplayTagDefine.EGameplayTagId["关卡.Common.状态.常态"], true);
			}
		}

		// Token: 0x06046DFF RID: 290303 RVA: 0x011E0C62 File Offset: 0x011DEE62
		private void ClearTimer()
		{
			if (this.RevertTimer != null)
			{
				TimerSystem.Instance.Remove(this.RevertTimer);
				this.RevertTimer = null;
			}
		}

		// Token: 0x06046E00 RID: 290304 RVA: 0x011E0C84 File Offset: 0x011DEE84
		protected override bool OnEnd()
		{
			this.ClearTimer();
			return true;
		}

		// Token: 0x06046E01 RID: 290305 RVA: 0x011E0C90 File Offset: 0x011DEE90
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemAdviceComponent sceneItemAdviceComponent = (SceneItemAdviceComponent)componentTemplate;
			if (base.CanResetComponentProperty("TagComponent"))
			{
				if (sceneItemAdviceComponent.TagComponent == null)
				{
					this.TagComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<LevelTagComponent>(this.TagComponent), "TagComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("RevertTimer"))
			{
				if (sceneItemAdviceComponent.RevertTimer == null)
				{
					this.RevertTimer = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.RevertTimer), "RevertTimer"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04025343 RID: 152387
		private const int REVERTIME = 3000;

		// Token: 0x04025344 RID: 152388
		private LevelTagComponent TagComponent;

		// Token: 0x04025345 RID: 152389
		private TimerHandle RevertTimer;
	}
}
