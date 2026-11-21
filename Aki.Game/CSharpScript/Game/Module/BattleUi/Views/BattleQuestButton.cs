using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CBC RID: 19644
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleQuestButton : BattleEntranceButton
	{
		// Token: 0x060311BA RID: 201146 RVA: 0x00DB6913 File Offset: 0x00DB4B13
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUIText)));
		}

		// Token: 0x060311BB RID: 201147 RVA: 0x00DB6954 File Offset: 0x00DB4B54
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SequencePlayer.BindSequenceStartEvent(new TSequenceStartEvent(this.OnSequenceStart));
			this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
			this.AddEvents();
		}

		// Token: 0x060311BC RID: 201148 RVA: 0x00DB69AE File Offset: 0x00DB4BAE
		public override void Reset()
		{
			this.RemoveEvents();
			base.Reset();
		}

		// Token: 0x060311BD RID: 201149 RVA: 0x00DB69BC File Offset: 0x00DB4BBC
		protected override void OnShowBattleChildView()
		{
			base.OnShowBattleChildView();
			if (this.SequencePlayer.GetCurrentSequence() != null)
			{
				this.SequencePlayer.ResumeSequence();
			}
		}

		// Token: 0x060311BE RID: 201150 RVA: 0x00DB69DC File Offset: 0x00DB4BDC
		protected override void OnHideBattleChildView()
		{
			base.OnHideBattleChildView();
			if (this.SequencePlayer.GetCurrentSequence() != null)
			{
				this.SequencePlayer.PauseSequence();
			}
		}

		// Token: 0x060311BF RID: 201151 RVA: 0x00DB69FC File Offset: 0x00DB4BFC
		protected void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.MissionUpdate, new Action<bool>(this.OnMissionUpdate));
		}

		// Token: 0x060311C0 RID: 201152 RVA: 0x00DB6A1A File Offset: 0x00DB4C1A
		protected void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.MissionUpdate, new Action<bool>(this.OnMissionUpdate));
		}

		// Token: 0x060311C1 RID: 201153 RVA: 0x00DB6A38 File Offset: 0x00DB4C38
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

		// Token: 0x060311C2 RID: 201154 RVA: 0x00DB6A70 File Offset: 0x00DB4C70
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

		// Token: 0x060311C3 RID: 201155 RVA: 0x00DB6AD0 File Offset: 0x00DB4CD0
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

		// Token: 0x0401A076 RID: 106614
		private const string MISSION_UPGRADE_IN = "MissionUpgradeIn";

		// Token: 0x0401A077 RID: 106615
		private const string MISSION_UPGRADE_OUT = "MissionUpgradeOut";

		// Token: 0x0401A078 RID: 106616
		[Nullable(2)]
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x0200A938 RID: 43320
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034484 RID: 214148
			AnimNode = 2,
			// Token: 0x04034485 RID: 214149
			QuestUpdateText
		}
	}
}
