using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;

namespace CSharpScript.Game.NewWorld.SceneItem.ExploreInteractiveCondition
{
	// Token: 0x020071FF RID: 29183
	public class QuantumDiffusionConditionListener : CustomConditionListener
	{
		// Token: 0x060476D1 RID: 292561 RVA: 0x0122F6CF File Offset: 0x0122D8CF
		[NullableContext(1)]
		public QuantumDiffusionConditionListener(Action<bool> onConditionChange) : base(onConditionChange)
		{
		}

		// Token: 0x060476D2 RID: 292562 RVA: 0x0122F6D8 File Offset: 0x0122D8D8
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

		// Token: 0x060476D3 RID: 292563 RVA: 0x0122F756 File Offset: 0x0122D956
		public override void SetListenerEnable(bool enable)
		{
			if (enable)
			{
				this.AddEvents();
				return;
			}
			this.RemoveEvents();
		}

		// Token: 0x060476D4 RID: 292564 RVA: 0x0122F768 File Offset: 0x0122D968
		private void AddEvents()
		{
			if (!EventSystem.Instance.Has<bool>(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.OnPlayerFollowerEnableChange)))
			{
				EventSystem.Instance.Add<bool>(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.OnPlayerFollowerEnableChange));
			}
		}

		// Token: 0x060476D5 RID: 292565 RVA: 0x0122F7A3 File Offset: 0x0122D9A3
		private void RemoveEvents()
		{
			if (EventSystem.Instance.Has<bool>(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.OnPlayerFollowerEnableChange)))
			{
				EventSystem.Instance.Remove<bool>(EEventName.OnPlayerFollowerEnableChange, new Action<bool>(this.OnPlayerFollowerEnableChange));
			}
		}

		// Token: 0x060476D6 RID: 292566 RVA: 0x0122F7DE File Offset: 0x0122D9DE
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
