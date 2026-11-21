using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Module.InstanceDungeon;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CBA RID: 19642
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleOnlineButton : BattleEntranceButton
	{
		// Token: 0x060311A0 RID: 201120 RVA: 0x00DB62DC File Offset: 0x00DB44DC
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUISprite)));
		}

		// Token: 0x060311A1 RID: 201121 RVA: 0x00DB631A File Offset: 0x00DB451A
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			if (param == null)
			{
				return;
			}
			this.OnlineIconComponent = base.GetSprite(3);
			this.AddEvents();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem.GetParentAsUIItem());
		}

		// Token: 0x060311A2 RID: 201122 RVA: 0x00DB6350 File Offset: 0x00DB4550
		protected override void OnShowBattleChildView()
		{
			base.OnShowBattleChildView();
			if (InstanceDungeonEntranceModel.Instance.GetMatchingState() == EInstanceMatchState.Matching)
			{
				base.GetItem(2).SetUIActive(true);
				if (this.LevelSequencePlayer.GetCurrentSequence() == "AutoLoop")
				{
					this.LevelSequencePlayer.ReplaySequenceByKey("AutoLoop");
				}
				else
				{
					this.LevelSequencePlayer.PlayLevelSequenceByName("AutoLoop", false, null, false);
				}
			}
			else
			{
				base.GetItem(2).SetUIActive(false);
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.StopCurrentSequence(false, false);
				}
			}
			this.RefreshButtonState();
		}

		// Token: 0x060311A3 RID: 201123 RVA: 0x00DB63E9 File Offset: 0x00DB45E9
		public override void Reset()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
			this.RemoveEvents();
			base.Reset();
		}

		// Token: 0x060311A4 RID: 201124 RVA: 0x00DB6410 File Offset: 0x00DB4610
		protected void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
			EventSystem.Instance.Add(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationInfoChanged));
			EventSystem.Instance.Add(EEventName.ChangeModeFinish, new Action(this.OnChangeModeFinish));
			EventSystem.Instance.Add(EEventName.OnlineDisableStateChange, new Action(this.OnlineDisableStateChange));
		}

		// Token: 0x060311A5 RID: 201125 RVA: 0x00DB64AC File Offset: 0x00DB46AC
		protected void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
			EventSystem.Instance.Remove(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationInfoChanged));
			EventSystem.Instance.Remove(EEventName.ChangeModeFinish, new Action(this.OnChangeModeFinish));
			EventSystem.Instance.Remove(EEventName.OnlineDisableStateChange, new Action(this.OnlineDisableStateChange));
		}

		// Token: 0x060311A6 RID: 201126 RVA: 0x00DB6545 File Offset: 0x00DB4745
		private void OnMatchingChange()
		{
			if (InstanceDungeonEntranceModel.Instance.GetMatchingState() == EInstanceMatchState.Default)
			{
				base.GetItem(2).SetUIActive(false);
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer == null)
				{
					return;
				}
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
		}

		// Token: 0x060311A7 RID: 201127 RVA: 0x00DB6574 File Offset: 0x00DB4774
		private void OnMatchingBegin()
		{
			base.GetItem(2).SetUIActive(true);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 == null)
			{
				return;
			}
			levelSequencePlayer2.PlayLevelSequenceByName("AutoLoop", false, null, false);
		}

		// Token: 0x060311A8 RID: 201128 RVA: 0x00DB65C1 File Offset: 0x00DB47C1
		private void OnFormationInfoChanged()
		{
			if (GameModeModel.Instance.IsMulti)
			{
				this.RefreshButtonState();
			}
		}

		// Token: 0x060311A9 RID: 201129 RVA: 0x00DB65D5 File Offset: 0x00DB47D5
		private void OnChangeModeFinish()
		{
			this.RefreshButtonState();
		}

		// Token: 0x060311AA RID: 201130 RVA: 0x00DB65DD File Offset: 0x00DB47DD
		private void OnlineDisableStateChange()
		{
			this.RefreshButtonState();
		}

		// Token: 0x060311AB RID: 201131 RVA: 0x00DB65E5 File Offset: 0x00DB47E5
		public override void SetGamepadHide(bool isGamepad)
		{
			if (GameModeModel.Instance.IsMulti)
			{
				base.SetGamepadHide(false);
				return;
			}
			base.SetGamepadHide(isGamepad);
		}

		// Token: 0x060311AC RID: 201132 RVA: 0x00DB6604 File Offset: 0x00DB4804
		private void RefreshOnlineIcon()
		{
			string text;
			if (GameModeModel.Instance.IsMulti)
			{
				int playerId = CreatureModel.Instance.GetPlayerId();
				OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(playerId);
				if (currentTeamListById == null)
				{
					return;
				}
				text = BattleOnlineButton.OnlinePlayerIconList[currentTeamListById.PlayerNumber - 1];
			}
			else
			{
				text = (OnlineModel.Instance.IsOnlineDisabled() ? "OnlineLimitIcon" : "OnlineNoLimitIcon");
			}
			if (this.LastIconPathKey == text)
			{
				return;
			}
			this.LastIconPathKey = text;
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(text);
			if (!string.IsNullOrEmpty(resourcePath))
			{
				this.SetSpriteByPath(resourcePath, this.OnlineIconComponent, true, null, null);
			}
		}

		// Token: 0x060311AD RID: 201133 RVA: 0x00DB66A8 File Offset: 0x00DB48A8
		public void RefreshButtonState()
		{
			if (this.OnlineIconComponent == null)
			{
				return;
			}
			if (GameModeController.Instance.IsInInstance())
			{
				base.SetOtherHide(true);
				return;
			}
			bool isMulti = GameModeModel.Instance.IsMulti;
			if (InstanceDungeonEntranceModel.Instance.GetMatchingState() != EInstanceMatchState.Matching && !isMulti && Info.Instance.IsInGamepad())
			{
				base.SetOtherHide(true);
				return;
			}
			base.SetOtherHide(false);
			this.RefreshOnlineIcon();
		}

		// Token: 0x0401A071 RID: 106609
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly string[] OnlinePlayerIconList = new string[]
		{
			"Online1PIcon",
			"Online2PIcon",
			"Online3PIcon"
		};

		// Token: 0x0401A072 RID: 106610
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A073 RID: 106611
		private UUISprite OnlineIconComponent;

		// Token: 0x0401A074 RID: 106612
		[Nullable(1)]
		private string LastIconPathKey = string.Empty;

		// Token: 0x0200A936 RID: 43318
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034476 RID: 214134
			Button,
			// Token: 0x04034477 RID: 214135
			RedDotItem,
			// Token: 0x04034478 RID: 214136
			AniItem,
			// Token: 0x04034479 RID: 214137
			Icon
		}
	}
}
