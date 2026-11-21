using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C46 RID: 19526
	public class BattleUiAudioInfo
	{
		// Token: 0x06030BE4 RID: 199652 RVA: 0x00D98530 File Offset: 0x00D96730
		public void PlayAudio()
		{
			if (Time.Instance.Now < this.CoolDownEndTime)
			{
				return;
			}
			if (!BattleUiModel.Instance.ChildViewData.GetChildVisible(this.UiChildType))
			{
				return;
			}
			this.PlayAudioImmediately();
		}

		// Token: 0x06030BE5 RID: 199653 RVA: 0x00D98563 File Offset: 0x00D96763
		private void PlayAudioImmediately()
		{
			this.CoolDownEndTime = Time.Instance.Now + 500.0;
			EventSystem.Instance.Emit<string>(EEventName.BattleUiPlayAudio, BattleUiAudioInfo.AudioIds[(int)this.AudioType]);
		}

		// Token: 0x06030BE6 RID: 199654 RVA: 0x00D9859B File Offset: 0x00D9679B
		public void Reset()
		{
			this.CoolDownEndTime = 0.0;
		}

		// Token: 0x04019CDD RID: 105693
		private const int DEFAULT_COOL_DOWN = 500;

		// Token: 0x04019CDE RID: 105694
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly string[] AudioIds = new string[]
		{
			"play_ui_fb_concerto_energy",
			"play_ui_fb_concerto_energy_rogue",
			"play_scene_ui_fight_focus_on",
			"play_scene_ui_fight_focus_switch"
		};

		// Token: 0x04019CDF RID: 105695
		public EBattleUiAudioType AudioType;

		// Token: 0x04019CE0 RID: 105696
		public double CoolDownEndTime;

		// Token: 0x04019CE1 RID: 105697
		public EBattleUiChild UiChildType;
	}
}
