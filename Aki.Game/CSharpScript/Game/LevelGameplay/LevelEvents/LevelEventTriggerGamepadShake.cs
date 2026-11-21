using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.Guarantee;
using CSharpScript.Game.Module.Gamepad;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D25 RID: 23845
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventTriggerGamepadShake : LevelEventBase
	{
		// Token: 0x0603A469 RID: 238697 RVA: 0x010788C8 File Offset: 0x01076AC8
		public LevelEventTriggerGamepadShake(int id) : base(id)
		{
		}

		// Token: 0x0603A46A RID: 238698 RVA: 0x010788DC File Offset: 0x01076ADC
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			TriggerGamepadShake triggerGamepadShake = inParams as TriggerGamepadShake;
			if (triggerGamepadShake == null || StringUtils.IsBlank(triggerGamepadShake.KuroForceFeedbackEffect))
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YSQ, "执行行为LevelEventTriggerGamepadShake失败，参数错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			GamepadController.Instance.TriggerGamepadShakeEvent(new IGamepadShakeOptions
			{
				KuroForceFeedbackEffect = triggerGamepadShake.KuroForceFeedbackEffect,
				GamepadShakeConfig = triggerGamepadShake.GamepadShakeConfig
			}, this.StopGamepadShake);
		}

		// Token: 0x0603A46B RID: 238699 RVA: 0x0107894C File Offset: 0x01076B4C
		protected override void OnUpdateGuarantee()
		{
			GuaranteeActionInfo p = new GuaranteeActionInfo
			{
				Name = EGuaranteeAction.StopGamepadShake,
				Params = this.StopGamepadShake
			};
			EventSystem.Instance.Emit<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.AddGuaranteeAction, this.Type, this.BaseContext, p, null);
		}

		// Token: 0x0401EC15 RID: 125973
		private readonly StopGamepadShakeImpl StopGamepadShake = new StopGamepadShakeImpl();
	}
}
