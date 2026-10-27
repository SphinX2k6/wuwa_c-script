using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C66 RID: 23654
	public class BattleUiAudioInfo
	{
		// Token: 0x0603BC99 RID: 244889 RVA: 0x00E48150 File Offset: 0x00E46350
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

		// Token: 0x0603BC9A RID: 244890 RVA: 0x00E48183 File Offset: 0x00E46383
		private void PlayAudioImmediately()
		{
			this.CoolDownEndTime = Time.Instance.Now + 500.0;
			EventSystem.Instance.Emit<string>(EEventName.BattleUiPlayAudio, BattleUiAudioInfo.AudioIds[(int)this.AudioType]);
		}

		// Token: 0x0603BC9B RID: 244891 RVA: 0x00E481BB File Offset: 0x00E463BB
		public void Reset()
		{
			this.CoolDownEndTime = 0.0;
		}

		// Token: 0x0401F22C RID: 127532
		private const int DEFAULT_COOL_DOWN = 500;

		// Token: 0x0401F22D RID: 127533
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly string[] AudioIds = new string[]
		{
			"play_ui_fb_concerto_energy",
			"play_ui_fb_concerto_energy_rogue",
			"play_scene_ui_fight_focus_on",
			"play_scene_ui_fight_focus_switch"
		};

		// Token: 0x0401F22E RID: 127534
		public EBattleUiAudioType AudioType;

		// Token: 0x0401F22F RID: 127535
		public double CoolDownEndTime;

		// Token: 0x0401F230 RID: 127536
		public EBattleUiChild UiChildType;
	}
}
