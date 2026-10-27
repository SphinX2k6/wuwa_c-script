using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CDA RID: 23770
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleQuestButton : BattleEntranceButton
	{
		// Token: 0x0603C264 RID: 246372 RVA: 0x00E6635F File Offset: 0x00E6455F
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUIText)));
		}

		// Token: 0x0603C265 RID: 246373 RVA: 0x00E663A0 File Offset: 0x00E645A0
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SequencePlayer.BindSequenceStartEvent(new TSequenceStartEvent(this.OnSequenceStart));
			this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
			this.AddEvents();
		}

		// Token: 0x0603C266 RID: 246374 RVA: 0x00E663FA File Offset: 0x00E645FA
		public override void Reset()
		{
			this.RemoveEvents();
			base.Reset();
		}

		// Token: 0x0603C267 RID: 246375 RVA: 0x00E66408 File Offset: 0x00E64608
		protected override void OnShowBattleChildView()
		{
			base.OnShowBattleChildView();
			if (this.SequencePlayer.GetCurrentSequence() != null)
			{
				this.SequencePlayer.ResumeSequence();
			}
		}

		// Token: 0x0603C268 RID: 246376 RVA: 0x00E66428 File Offset: 0x00E64628
		protected override void OnHideBattleChildView()
		{
			base.OnHideBattleChildView();
			if (this.SequencePlayer.GetCurrentSequence() != null)
			{
				this.SequencePlayer.PauseSequence();
			}
		}

		// Token: 0x0603C269 RID: 246377 RVA: 0x00E66448 File Offset: 0x00E64648
		protected void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.MissionUpdate, new Action<bool>(this.OnMissionUpdate));
		}

		// Token: 0x0603C26A RID: 246378 RVA: 0x00E66466 File Offset: 0x00E64666
		protected void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.MissionUpdate, new Action<bool>(this.OnMissionUpdate));
		}

		// Token: 0x0603C26B RID: 246379 RVA: 0x00E66484 File Offset: 0x00E64684
		private void OnSequenceStart(string sequenceName)
		{
			if (!(sequenceName == "MissionUpgradeIn"))
			{
				sequenceName == "MissionUpgradeOut";
				return;
			}
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(BattleUiModel.Instance.IsMissionPanelVisible);
		}

		// Token: 0x0603C26C RID: 246380 RVA: 0x00E664BC File Offset: 0x00E646BC
		private void OnSequenceClose(string sequenceName)
		{
			if (!(sequenceName == "MissionUpgradeIn"))
			{
				sequenceName == "MissionUpgradeOut";
				return;
			}
			this.SequencePlayer.PlayLevelSequenceByName("MissionUpgradeOut", false, null, false);
			if (AutoRunModel.Instance.GetAutoRunMode() > EAutoRunMode.Disabled)
			{
				this.SequencePlayer.StopCurrentSequence(true, true);
			}
		}

		// Token: 0x0603C26D RID: 246381 RVA: 0x00E6651C File Offset: 0x00E6471C
		private void OnMissionUpdate(bool bNewQuest)
		{
			UUIText text = base.GetText(3);
			LguiUtil.Instance.SetLocalText(text, bNewQuest ? "QuestUpdateNewQuestTips" : "QuestUpdateNewGoalTips", Array.Empty<object>());
			this.SequencePlayer.StopCurrentSequence(true, true);
			this.SequencePlayer.PlayLevelSequenceByName("MissionUpgradeIn", false, null, false);
			if (AutoRunModel.Instance.GetAutoRunMode() > EAutoRunMode.Disabled)
			{
				this.SequencePlayer.StopCurrentSequence(true, true);
			}
		}

		// Token: 0x0401F5BD RID: 128445
		private const string MISSION_UPGRADE_IN = "MissionUpgradeIn";

		// Token: 0x0401F5BE RID: 128446
		private const string MISSION_UPGRADE_OUT = "MissionUpgradeOut";

		// Token: 0x0401F5BF RID: 128447
		[Nullable(2)]
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x0200BF32 RID: 48946
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039AC2 RID: 236226
			AnimNode = 2,
			// Token: 0x04039AC3 RID: 236227
			QuestUpdateText
		}
	}
}
