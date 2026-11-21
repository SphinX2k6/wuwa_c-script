using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;

namespace CSharpScript.Game.NewWorld.SceneItem.ExploreInteractiveCondition
{
	// Token: 0x020062B4 RID: 25268
	public class QuantumDiffusionConditionListener : CustomConditionListener
	{
		// Token: 0x0603CFD9 RID: 249817 RVA: 0x01189291 File Offset: 0x01187491
		[NullableContext(1)]
		public QuantumDiffusionConditionListener(Action<bool> onConditionChange) : base(onConditionChange)
		{
		}

		// Token: 0x0603CFDA RID: 249818 RVA: 0x0118929C File Offset: 0x0118749C
		public override bool CheckCondition()
		{
			int playerId = CreatureModel.Instance.GetPlayerId();
			WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(playerId);
			PlayerFollowableComponent playerFollowableComponent = (playerEntity != null) ? playerEntity.GetComponent<PlayerFollowableComponent>() : null;
			if (playerFollowableComponent == null)
			{
				return false;
			}
			EntityHandle follower = playerFollowableComponent.GetFollower();
			if (follower == null || !follower.IsInit)
			{
				return false;
			}
			if (!playerFollowableComponent.IsFollowerEnable())
			{
				return false;
			}
			BaseTagComponent component = follower.Entity.GetComponent<BaseTagComponent>();
			return component != null && component.HasTag(GameplayTagDefine.EGameplayTagId["辅助机.量子转换.持有中"]);
		}

		// Token: 0x0603CFDB RID: 249819 RVA: 0x0118931A File Offset: 0x0118751A
		public override void SetListenerEnable(bool enable)
		{
			if (enable)
			{
				this.AddEvents();
				return;
			}
			this.RemoveEvents();
		}

		// Token: 0x0603CFDC RID: 249820 RVA: 0x0118932C File Offset: 0x0118752C
		private void AddEvents()
		{
			if (!EventSystem.Instance.Has<bool>(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.OnPlayerFollowerEnableChange)))
			{
				EventSystem.Instance.Add<bool>(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.OnPlayerFollowerEnableChange));
			}
		}

		// Token: 0x0603CFDD RID: 249821 RVA: 0x01189367 File Offset: 0x01187567
		private void RemoveEvents()
		{
			if (EventSystem.Instance.Has<bool>(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.OnPlayerFollowerEnableChange)))
			{
				EventSystem.Instance.Remove<bool>(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.OnPlayerFollowerEnableChange));
			}
		}

		// Token: 0x0603CFDE RID: 249822 RVA: 0x011893A2 File Offset: 0x011875A2
		private void OnPlayerFollowerEnableChange(bool isEnable)
		{
			Action<bool> onConditionChange = this.OnConditionChange;
			if (onConditionChange == null)
			{
				return;
			}
			onConditionChange(this.CheckCondition());
		}
	}
}
