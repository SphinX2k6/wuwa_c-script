using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.Guarantee;
using CSharpScript.Game.Module.Gamepad;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006BAD RID: 27565
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventTriggerGamepadShake : LevelEventBase
	{
		// Token: 0x06044313 RID: 279315 RVA: 0x010CEA3C File Offset: 0x010CCC3C
		public LevelEventTriggerGamepadShake(int id) : base(id)
		{
		}

		// Token: 0x06044314 RID: 279316 RVA: 0x010CEA50 File Offset: 0x010CCC50
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

		// Token: 0x06044315 RID: 279317 RVA: 0x010CEAC0 File Offset: 0x010CCCC0
		protected override void OnUpdateGuarantee()
		{
			GuaranteeActionInfo p = new GuaranteeActionInfo
			{
				Name = EGuaranteeAction.StopGamepadShake,
				Params = this.StopGamepadShake
			};
			EventSystem.Instance.Emit<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.AddGuaranteeAction, this.Type, this.BaseContext, p, null);
		}

		// Token: 0x04023973 RID: 145779
		private readonly StopGamepadShakeImpl StopGamepadShake = new StopGamepadShakeImpl();
	}
}
