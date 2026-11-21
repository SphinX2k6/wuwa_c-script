using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CC8 RID: 23752
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventGuestAnimation : LevelEventBase
	{
		// Token: 0x0603A309 RID: 238345 RVA: 0x0106C257 File Offset: 0x0106A457
		public LevelEventGuestAnimation(int id) : base(id)
		{
		}

		// Token: 0x0603A30A RID: 238346 RVA: 0x0106C260 File Offset: 0x0106A460
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			GuestOperateUiAnimation guestOperateUiAnimation = inParams as GuestOperateUiAnimation;
			EGuestOperateUiAnimation type = guestOperateUiAnimation.UiAnimationConfig.Type;
			if (type == EGuestOperateUiAnimation.Play)
			{
				this.PlayUiEffect(guestOperateUiAnimation.UiAnimationConfig as IPlayGuestUiAnimation);
				return;
			}
			if (type != EGuestOperateUiAnimation.Stop)
			{
				return;
			}
			this.StopUiEffect(guestOperateUiAnimation.UiAnimationConfig as IStopGuestUiAnimation);
		}

		// Token: 0x0603A30B RID: 238347 RVA: 0x0106C2AB File Offset: 0x0106A4AB
		private void PlayUiEffect(IPlayGuestUiAnimation config)
		{
			if (config.PlayGuestUiAnimation.Type == EGuestUiAnimationType.GuestCartethyia)
			{
				BattleUiModel.Instance.GuestEffect = true;
				EventSystem.Instance.Emit<bool>(EEventName.ShowGuestEffect, true);
			}
		}

		// Token: 0x0603A30C RID: 238348 RVA: 0x0106C2D6 File Offset: 0x0106A4D6
		private void StopUiEffect(IStopGuestUiAnimation config)
		{
			if (config.StopGuestUiAnimation.Type == EGuestUiAnimationType.GuestCartethyia)
			{
				BattleUiModel.Instance.GuestEffect = false;
				EventSystem.Instance.Emit<bool>(EEventName.ShowGuestEffect, false);
			}
		}
	}
}
