using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions
{
	// Token: 0x02005F97 RID: 24471
	public class GuaranteeActionStopGamepadShake : GuaranteeActionBase
	{
		// Token: 0x0603ACDE RID: 240862 RVA: 0x010A02BC File Offset: 0x0109E4BC
		[NullableContext(2)]
		protected override void OnExecute(ActionParams @params)
		{
			IStopGamepadShake stopGamepadShake = @params as IStopGamepadShake;
			if (stopGamepadShake == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YSQ, "执行保底行为GuaranteeActionStopGamepadShake失败，参数错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			Global.CharacterController.StopKuroForceFeedback(stopGamepadShake.GamepadShakeAsset, stopGamepadShake.Tag);
			UForceFeedbackComponent feedbackComponent = stopGamepadShake.FeedbackComponent;
			if (feedbackComponent != null && feedbackComponent.IsValid())
			{
				stopGamepadShake.FeedbackComponent.Stop();
			}
			global::Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.CB, "保底终止", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}
}
