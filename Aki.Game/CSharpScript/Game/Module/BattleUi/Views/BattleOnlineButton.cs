using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Module.InstanceDungeon;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CD8 RID: 23768
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleOnlineButton : BattleEntranceButton
	{
		// Token: 0x0603C24A RID: 246346 RVA: 0x00E65D28 File Offset: 0x00E63F28
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUISprite)));
		}

		// Token: 0x0603C24B RID: 246347 RVA: 0x00E65D66 File Offset: 0x00E63F66
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

		// Token: 0x0603C24C RID: 246348 RVA: 0x00E65D9C File Offset: 0x00E63F9C
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

		// Token: 0x0603C24D RID: 246349 RVA: 0x00E65E35 File Offset: 0x00E64035
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

		// Token: 0x0603C24E RID: 246350 RVA: 0x00E65E5C File Offset: 0x00E6405C
		protected void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
			EventSystem.Instance.Add(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationInfoChanged));
			EventSystem.Instance.Add(EEventName.ChangeModeFinish, new Action(this.OnChangeModeFinish));
			EventSystem.Instance.Add(EEventName.OnlineDisableStateChange, new Action(this.OnlineDisableStateChange));
		}

		// Token: 0x0603C24F RID: 246351 RVA: 0x00E65EF8 File Offset: 0x00E640F8
		protected void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
			EventSystem.Instance.Remove(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationInfoChanged));
			EventSystem.Instance.Remove(EEventName.ChangeModeFinish, new Action(this.OnChangeModeFinish));
			EventSystem.Instance.Remove(EEventName.OnlineDisableStateChange, new Action(this.OnlineDisableStateChange));
		}

		// Token: 0x0603C250 RID: 246352 RVA: 0x00E65F91 File Offset: 0x00E64191
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

		// Token: 0x0603C251 RID: 246353 RVA: 0x00E65FC0 File Offset: 0x00E641C0
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

		// Token: 0x0603C252 RID: 246354 RVA: 0x00E6600D File Offset: 0x00E6420D
		private void OnFormationInfoChanged()
		{
			if (GameModeModel.Instance.IsMulti)
			{
				this.RefreshButtonState();
			}
		}

		// Token: 0x0603C253 RID: 246355 RVA: 0x00E66021 File Offset: 0x00E64221
		private void OnChangeModeFinish()
		{
			this.RefreshButtonState();
		}

		// Token: 0x0603C254 RID: 246356 RVA: 0x00E66029 File Offset: 0x00E64229
		private void OnlineDisableStateChange()
		{
			this.RefreshButtonState();
		}

		// Token: 0x0603C255 RID: 246357 RVA: 0x00E66031 File Offset: 0x00E64231
		public override void SetGamepadHide(bool isGamepad)
		{
			if (GameModeModel.Instance.IsMulti)
			{
				base.SetGamepadHide(false);
				return;
			}
			base.SetGamepadHide(isGamepad);
		}

		// Token: 0x0603C256 RID: 246358 RVA: 0x00E66050 File Offset: 0x00E64250
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

		// Token: 0x0603C257 RID: 246359 RVA: 0x00E660F4 File Offset: 0x00E642F4
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

		// Token: 0x0401F5B8 RID: 128440
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly string[] OnlinePlayerIconList = new string[]
		{
			"Online1PIcon",
			"Online2PIcon",
			"Online3PIcon"
		};

		// Token: 0x0401F5B9 RID: 128441
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F5BA RID: 128442
		private UUISprite OnlineIconComponent;

		// Token: 0x0401F5BB RID: 128443
		[Nullable(1)]
		private string LastIconPathKey = string.Empty;

		// Token: 0x0200BF30 RID: 48944
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039AB4 RID: 236212
			Button,
			// Token: 0x04039AB5 RID: 236213
			RedDotItem,
			// Token: 0x04039AB6 RID: 236214
			AniItem,
			// Token: 0x04039AB7 RID: 236215
			Icon
		}
	}
}
