using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B50 RID: 27472
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventGuestAnimation : LevelEventBase
	{
		// Token: 0x060441B7 RID: 278967 RVA: 0x010C26A3 File Offset: 0x010C08A3
		public LevelEventGuestAnimation(int id) : base(id)
		{
		}

		// Token: 0x060441B8 RID: 278968 RVA: 0x010C26AC File Offset: 0x010C08AC
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

		// Token: 0x060441B9 RID: 278969 RVA: 0x010C26F7 File Offset: 0x010C08F7
		private void PlayUiEffect(IPlayGuestUiAnimation config)
		{
			if (config.PlayGuestUiAnimation.Type == EGuestUiAnimationType.GuestCartethyia)
			{
				BattleUiModel.Instance.GuestEffect = true;
				EventSystem.Instance.Emit<bool>(EEventName.ShowGuestEffect, true);
			}
		}

		// Token: 0x060441BA RID: 278970 RVA: 0x010C2722 File Offset: 0x010C0922
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
