using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.Pawn.Component;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200621F RID: 25119
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemAdviceComponent : EntityComponent
	{
		// Token: 0x0603C64E RID: 247374 RVA: 0x0113C40C File Offset: 0x0113A60C
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

		// Token: 0x0603C64F RID: 247375 RVA: 0x0113C498 File Offset: 0x0113A698
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

		// Token: 0x0603C650 RID: 247376 RVA: 0x0113C548 File Offset: 0x0113A748
		private void OnInteractFinish(float delta)
		{
			this.ClearTimer();
			if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["关卡.Common.状态.激活"]))
			{
				this.TagComponent.ChangeLocalLevelTag(GameplayTagDefine.EGameplayTagId["关卡.Common.状态.常态"], GameplayTagDefine.EGameplayTagId["关卡.Common.状态.激活"]);
				EventSystem.Instance.EmitWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, GameplayTagDefine.EGameplayTagId["关卡.Common.状态.常态"], true);
			}
		}

		// Token: 0x0603C651 RID: 247377 RVA: 0x0113C5C6 File Offset: 0x0113A7C6
		private void ClearTimer()
		{
			if (this.RevertTimer != null)
			{
				TimerSystem.Instance.Remove(this.RevertTimer);
				this.RevertTimer = null;
			}
		}

		// Token: 0x0603C652 RID: 247378 RVA: 0x0113C5E8 File Offset: 0x0113A7E8
		protected override bool OnEnd()
		{
			this.ClearTimer();
			return true;
		}

		// Token: 0x0603C653 RID: 247379 RVA: 0x0113C5F4 File Offset: 0x0113A7F4
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemAdviceComponent sceneItemAdviceComponent = (SceneItemAdviceComponent)componentTemplate;
			if (sceneItemAdviceComponent.TagComponent == null)
			{
				this.TagComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComponent), "TagComponent"))
			{
				return false;
			}
			if (sceneItemAdviceComponent.RevertTimer == null)
			{
				this.RevertTimer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RevertTimer), "RevertTimer"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x17007210 RID: 29200
		// (get) Token: 0x0603C654 RID: 247380 RVA: 0x0113C66A File Offset: 0x0113A86A
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007211 RID: 29201
		// (get) Token: 0x0603C655 RID: 247381 RVA: 0x0113C66D File Offset: 0x0113A86D
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FFAA RID: 130986
		private const int REVERTIME = 3000;

		// Token: 0x0401FFAB RID: 130987
		private LevelTagComponent TagComponent;

		// Token: 0x0401FFAC RID: 130988
		private TimerHandle RevertTimer;
	}
}
