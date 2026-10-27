using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.CountDown;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B0C RID: 27404
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventCommonTip2 : LevelEventBase
	{
		// Token: 0x0604407C RID: 278652 RVA: 0x010B8531 File Offset: 0x010B6731
		public LevelEventCommonTip2(int id) : base(id)
		{
		}

		// Token: 0x0604407D RID: 278653 RVA: 0x010B853C File Offset: 0x010B673C
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			CommonTip2 commonTip = inParams as CommonTip2;
			if (commonTip == null)
			{
				return;
			}
			ICommonTip2PrepareCountdown tipOption = commonTip.TipOption;
			if (tipOption.Type == ECommonTip2Type.PrepareCountdown)
			{
				ICommonTip2PrepareCountdown commonTip2PrepareCountdown = tipOption;
				this.IsBlockInput = commonTip2PrepareCountdown.IsBlockPlayer.GetValueOrDefault();
				if (this.IsBlockInput)
				{
					if (LevelEventLockInputState.Instance.IsLockInput())
					{
						LevelEventLockInputState.Instance.InputTagNames.Add("BlockAllInputTag");
						InputDistributeController.Instance.RefreshInputTag();
					}
					else
					{
						InputDistributeModel.Instance.SetInputDistributeTag("BlockAllInputTag");
						LevelEventLockInputState.Instance.Lock(new List<string>
						{
							"BlockAllInputTag"
						});
					}
				}
				ECountDownUiStyle? uiStyle = commonTip2PrepareCountdown.UiStyle;
				if (uiStyle != null)
				{
					ECountDownUiStyle valueOrDefault = uiStyle.GetValueOrDefault();
					if (valueOrDefault == ECountDownUiStyle.Common)
					{
						this.ViewName = new EUiViewName?(EUiViewName.LevelGamePlayPrepareCountDown);
						goto IL_EC;
					}
					if (valueOrDefault - ECountDownUiStyle.MotorRacing <= 1)
					{
						this.ViewName = new EUiViewName?(EUiViewName.LevelGamePlayMotorPrepareCountDown);
						goto IL_EC;
					}
				}
				this.ViewName = new EUiViewName?(EUiViewName.LevelGamePlayPrepareCountDown);
				IL_EC:
				LevelGamePlayPrepareCountDownViewParams param = new LevelGamePlayPrepareCountDownViewParams
				{
					CountDownNum = commonTip2PrepareCountdown.CountDownNum,
					TidText = commonTip2PrepareCountdown.TidCountDownTxt,
					UiStyle = commonTip2PrepareCountdown.UiStyle
				};
				UiManager.Instance.OpenView(this.ViewName.Value, param, null);
				if (this.IsAsync)
				{
					base.FinishExecute(true, false, true);
					return;
				}
				EventSystem.Instance.Add(EEventName.LevelGamePlayPrepareCountDownEnd, new Action(this.OnCountDownEnd));
			}
		}

		// Token: 0x0604407E RID: 278654 RVA: 0x010B86A4 File Offset: 0x010B68A4
		private void OnCountDownEnd()
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0604407F RID: 278655 RVA: 0x010B86B0 File Offset: 0x010B68B0
		protected override void OnFinish()
		{
			EventSystem.Instance.Remove(EEventName.LevelGamePlayPrepareCountDownEnd, new Action(this.OnCountDownEnd));
			if (this.IsBlockInput)
			{
				LevelEventLockInputState.Instance.Unlock();
				InputDistributeController.Instance.RefreshInputTag();
			}
			this.IsBlockInput = false;
		}

		// Token: 0x040238D2 RID: 145618
		private const string BLOCK_INPUTTAG = "BlockAllInputTag";

		// Token: 0x040238D3 RID: 145619
		private EUiViewName? ViewName;

		// Token: 0x040238D4 RID: 145620
		private bool IsBlockInput;
	}
}
