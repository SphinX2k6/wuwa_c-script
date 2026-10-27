using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DB9 RID: 23993
	[NullableContext(2)]
	[Nullable(0)]
	public class LinkScoreItem : BaseScoreItem
	{
		// Token: 0x0603CF50 RID: 249680 RVA: 0x00EA631C File Offset: 0x00EA451C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CF51 RID: 249681 RVA: 0x00EA6388 File Offset: 0x00EA4588
		protected override UniTask OnCreateAsync()
		{
			LinkScoreItem.<OnCreateAsync>d__22 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<LinkScoreItem.<OnCreateAsync>d__22>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CF52 RID: 249682 RVA: 0x00EA63CC File Offset: 0x00EA45CC
		protected override void OnStart()
		{
			base.OnStart();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.ScoreUiNiagara = base.GetUiNiagara(0);
			if (this.ScoreNiagara != null)
			{
				UUINiagara scoreUiNiagara = this.ScoreUiNiagara;
				if (scoreUiNiagara != null)
				{
					scoreUiNiagara.SetUIActive(false);
				}
				UUINiagara scoreUiNiagara2 = this.ScoreUiNiagara;
				if (scoreUiNiagara2 != null)
				{
					scoreUiNiagara2.SetNiagaraSystem(this.ScoreNiagara);
				}
			}
			this.PointItem = base.GetItem(1);
			if (!WeeklyRogueModel.Instance.CheckIsInWeeklyRogue())
			{
				this.InitScore(2);
				return;
			}
			bool flag = WeeklyRogueModel.Instance.CurrentActivityId != 0;
			this.IsScoreEnable = flag;
			if (!flag)
			{
				EventSystem.Instance.Add(EEventName.WeeklyRogueCycleRefresh, new Action(this.OnCycleRefresh));
				return;
			}
			this.InitScore(WeeklyRogueModel.Instance.CycleId);
			this.ShowScore();
		}

		// Token: 0x0603CF53 RID: 249683 RVA: 0x00EA649C File Offset: 0x00EA469C
		private void InitScore(int groupId)
		{
			this.ScoreInitFlag = true;
			this.CurScoreLevelConfigList = BattleScoreConfig.Instance.GetBattleScoreActionConfigByGroupId(groupId);
			this.UpdateMaxAndMinScore();
			foreach (KeyValuePair<int, int> keyValuePair in BattleScoreModel.Instance.GetScoreMap())
			{
				int num;
				int num2;
				keyValuePair.Deconstruct(out num, out num2);
				int scoreId = num;
				int num3 = num2;
				if (num3 > 0)
				{
					this.OnBattleScoreChanged(scoreId, num3);
				}
			}
		}

		// Token: 0x0603CF54 RID: 249684 RVA: 0x00EA6524 File Offset: 0x00EA4724
		private void OnCycleRefresh()
		{
			EventSystem.Instance.Remove(EEventName.WeeklyRogueCycleRefresh, new Action(this.OnCycleRefresh));
			this.IsScoreEnable = true;
			int cycleId = WeeklyRogueModel.Instance.CycleId;
			this.InitScore(cycleId);
			this.ShowScore();
		}

		// Token: 0x0603CF55 RID: 249685 RVA: 0x00EA656C File Offset: 0x00EA476C
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
			if (EventSystem.Instance.Has(EEventName.WeeklyRogueCycleRefresh, new Action(this.OnCycleRefresh)))
			{
				EventSystem.Instance.Remove(EEventName.WeeklyRogueCycleRefresh, new Action(this.OnCycleRefresh));
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x0603CF56 RID: 249686 RVA: 0x00EA65D0 File Offset: 0x00EA47D0
		[NullableContext(1)]
		private UniTask LoadNiagara(string path)
		{
			LinkScoreItem.<LoadNiagara>d__27 <LoadNiagara>d__;
			<LoadNiagara>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadNiagara>d__.<>4__this = this;
			<LoadNiagara>d__.path = path;
			<LoadNiagara>d__.<>1__state = -1;
			<LoadNiagara>d__.<>t__builder.Start<LinkScoreItem.<LoadNiagara>d__27>(ref <LoadNiagara>d__);
			return <LoadNiagara>d__.<>t__builder.Task;
		}

		// Token: 0x0603CF57 RID: 249687 RVA: 0x00EA661C File Offset: 0x00EA481C
		protected override void OnBattleScoreChanged(int scoreId, int score)
		{
			if (!this.ScoreInitFlag)
			{
				return;
			}
			if (base.IsHideOrHiding)
			{
				this.ShowScore();
			}
			if (score < this.MinScoreLevelConfig.Value.LowerUpperLimits(0))
			{
				this.CurScoreLevelConfig = null;
			}
			else if (score >= this.MaxScoreLevelConfig.Value.LowerUpperLimits(1))
			{
				this.CurScoreLevelConfig = this.MaxScoreLevelConfig;
			}
			else
			{
				this.CurScoreLevelConfig = this.MinScoreLevelConfig;
			}
			this.UpdateScore(score, this.CurScoreLevelConfig);
		}

		// Token: 0x0603CF58 RID: 249688 RVA: 0x00EA66A4 File Offset: 0x00EA48A4
		private void UpdateScore(int score, BattleScoreLevelConf? scoreLevelConfig)
		{
			this.HasValidConfig = (scoreLevelConfig != null);
			this.SetTickEndScore(score);
			if (!base.IsShowOrShowing)
			{
				this.ShowScore();
				return;
			}
			if (score < this.MaxScore || this.IsShowFull)
			{
				if (score != this.MaxScore && this.IsShowFull)
				{
					this.IsShowFull = false;
					LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
					if (levelSequencePlayer != null)
					{
						levelSequencePlayer.StopSequenceByKey("Full", false, false);
					}
					LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
					if (levelSequencePlayer2 == null)
					{
						return;
					}
					levelSequencePlayer2.PlaySequencePurely("Restart", false, false, null, null, false);
				}
				return;
			}
			this.IsShowFull = true;
			LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
			if (levelSequencePlayer3 != null)
			{
				levelSequencePlayer3.StopSequenceByKey("Restart", false, false);
			}
			LevelSequencePlayer levelSequencePlayer4 = this.LevelSequencePlayer;
			if (levelSequencePlayer4 == null)
			{
				return;
			}
			levelSequencePlayer4.PlaySequencePurely("Full", false, false, null, null, false);
		}

		// Token: 0x0603CF59 RID: 249689 RVA: 0x00EA677C File Offset: 0x00EA497C
		public override void OnTick(float delta)
		{
			if (this.HasValidConfig && this.TickScore != this.TickEndScore && base.GetActive())
			{
				this.SmoothTime = Math.Min(200f, this.SmoothTime + delta);
				float num = this.SmoothTime / 200f;
				this.TickScore = (int)((float)this.TickStartScore * (1f - num) + (float)this.TickEndScore * num);
				if (this.MaxScore > 0)
				{
					float num2 = (float)this.TickScore / (float)this.MaxScore;
					UUINiagara scoreUiNiagara = this.ScoreUiNiagara;
					if (scoreUiNiagara != null)
					{
						scoreUiNiagara.SetNiagaraVarFloat("Dissolve", num2);
					}
					UUIItem pointItem = this.PointItem;
					if (pointItem == null)
					{
						return;
					}
					FRotator frotator = new FRotator();
					frotator.Yaw = num2 * -360f;
					pointItem.SetUIRelativeRotation(frotator);
				}
			}
		}

		// Token: 0x0603CF5A RID: 249690 RVA: 0x00EA684C File Offset: 0x00EA4A4C
		private void SetTickEndScore(int score)
		{
			if (score > 0)
			{
				this.TickStartScore = this.TickScore;
				this.TickEndScore = score;
				this.SmoothTime = 0f;
				return;
			}
			this.TickStartScore = this.TickScore;
			this.TickEndScore = 0;
			this.SmoothTime = 200f;
		}

		// Token: 0x0603CF5B RID: 249691 RVA: 0x00EA689C File Offset: 0x00EA4A9C
		private void UpdateMaxAndMinScore()
		{
			this.MinScoreLevelConfig = null;
			this.MaxScoreLevelConfig = null;
			if (this.CurScoreLevelConfigList == null)
			{
				return;
			}
			int num = int.MaxValue;
			int num2 = 0;
			foreach (BattleScoreLevelConf value in this.CurScoreLevelConfigList)
			{
				int level = value.Level;
				if (num > level)
				{
					num = level;
					this.MinScoreLevelConfig = new BattleScoreLevelConf?(value);
				}
				if (num2 < level)
				{
					num2 = level;
					this.MaxScoreLevelConfig = new BattleScoreLevelConf?(value);
				}
			}
			this.MaxScore = this.MaxScoreLevelConfig.Value.LowerUpperLimits(0);
			int maxScore = this.MaxScore;
		}

		// Token: 0x0603CF5C RID: 249692 RVA: 0x00EA6960 File Offset: 0x00EA4B60
		public override bool IsValidScore(int scoreId)
		{
			BattleScoreConf? scoreConfig = BattleScoreModel.Instance.GetScoreConfig(scoreId, true);
			return scoreConfig != null && (scoreConfig.Value.Type == 4 || scoreConfig.Value.Type == 7);
		}

		// Token: 0x0603CF5D RID: 249693 RVA: 0x00EA69AC File Offset: 0x00EA4BAC
		public override void ShowScore()
		{
			base.ShowScore();
			base.Show(null);
			UUINiagara scoreUiNiagara = this.ScoreUiNiagara;
			if (scoreUiNiagara != null)
			{
				scoreUiNiagara.SetUIActive(true);
			}
			UUINiagara scoreUiNiagara2 = this.ScoreUiNiagara;
			if (scoreUiNiagara2 != null)
			{
				scoreUiNiagara2.ActivateSystem(true);
			}
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
			levelSequencePlayer2.PlaySequencePurely("Start", false, false, null, null, false);
		}

		// Token: 0x0603CF5E RID: 249694 RVA: 0x00EA6A20 File Offset: 0x00EA4C20
		public override void HideScore()
		{
			base.HideScore();
			UUINiagara scoreUiNiagara = this.ScoreUiNiagara;
			if (scoreUiNiagara != null)
			{
				scoreUiNiagara.SetUIActive(false);
			}
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
			levelSequencePlayer2.PlaySequenceAsync("Close", new CustomPromise<bool>(), false, false, null, false).ContinueWith(delegate()
			{
				if (!this.IsScoreEnable)
				{
					base.Hide(null);
				}
			}).Forget();
		}

		// Token: 0x0401FC04 RID: 130052
		private const int LINK_SCORE_GROUP_ID = 2;

		// Token: 0x0401FC05 RID: 130053
		[Nullable(1)]
		private const string SCORE_NIAGARA_PATH = "/Game/Aki/Effect/UI/Niagaras/RouGe/NS_Fx_LGUI_WhiteCat_Button_Panner.NS_Fx_LGUI_WhiteCat_Button_Panner";

		// Token: 0x0401FC06 RID: 130054
		private const int MAX_SMOOTH_TIME = 200;

		// Token: 0x0401FC07 RID: 130055
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat TickStatsObject = Stat.Create("[BattleView]LinkScoreItemTick", "", "");

		// Token: 0x0401FC08 RID: 130056
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401FC09 RID: 130057
		private UNiagaraSystem ScoreNiagara;

		// Token: 0x0401FC0A RID: 130058
		private UUINiagara ScoreUiNiagara;

		// Token: 0x0401FC0B RID: 130059
		private UUIItem PointItem;

		// Token: 0x0401FC0C RID: 130060
		private bool HasValidConfig;

		// Token: 0x0401FC0D RID: 130061
		private bool IsShowFull;

		// Token: 0x0401FC0E RID: 130062
		private int TickStartScore;

		// Token: 0x0401FC0F RID: 130063
		private int TickEndScore;

		// Token: 0x0401FC10 RID: 130064
		private int TickScore;

		// Token: 0x0401FC11 RID: 130065
		private int MaxScore;

		// Token: 0x0401FC12 RID: 130066
		private float SmoothTime;

		// Token: 0x0401FC13 RID: 130067
		private IReadOnlyList<BattleScoreLevelConf> CurScoreLevelConfigList;

		// Token: 0x0401FC14 RID: 130068
		private BattleScoreLevelConf? CurScoreLevelConfig;

		// Token: 0x0401FC15 RID: 130069
		private BattleScoreLevelConf? MinScoreLevelConfig;

		// Token: 0x0401FC16 RID: 130070
		private BattleScoreLevelConf? MaxScoreLevelConfig;

		// Token: 0x0401FC17 RID: 130071
		private bool ScoreInitFlag;

		// Token: 0x0200C0A3 RID: 49315
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A217 RID: 238103
			ScoreNiagara,
			// Token: 0x0403A218 RID: 238104
			PointItem
		}
	}
}
