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
	// Token: 0x02004D9D RID: 19869
	[NullableContext(2)]
	[Nullable(0)]
	public class LinkScoreItem : BaseScoreItem
	{
		// Token: 0x06031EC7 RID: 204487 RVA: 0x00DF71F8 File Offset: 0x00DF53F8
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

		// Token: 0x06031EC8 RID: 204488 RVA: 0x00DF7264 File Offset: 0x00DF5464
		protected override UniTask OnCreateAsync()
		{
			LinkScoreItem.<OnCreateAsync>d__22 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<LinkScoreItem.<OnCreateAsync>d__22>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031EC9 RID: 204489 RVA: 0x00DF72A8 File Offset: 0x00DF54A8
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

		// Token: 0x06031ECA RID: 204490 RVA: 0x00DF7378 File Offset: 0x00DF5578
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

		// Token: 0x06031ECB RID: 204491 RVA: 0x00DF7400 File Offset: 0x00DF5600
		private void OnCycleRefresh()
		{
			EventSystem.Instance.Remove(EEventName.WeeklyRogueCycleRefresh, new Action(this.OnCycleRefresh));
			this.IsScoreEnable = true;
			int cycleId = WeeklyRogueModel.Instance.CycleId;
			this.InitScore(cycleId);
			this.ShowScore();
		}

		// Token: 0x06031ECC RID: 204492 RVA: 0x00DF7448 File Offset: 0x00DF5648
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

		// Token: 0x06031ECD RID: 204493 RVA: 0x00DF74AC File Offset: 0x00DF56AC
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

		// Token: 0x06031ECE RID: 204494 RVA: 0x00DF74F8 File Offset: 0x00DF56F8
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

		// Token: 0x06031ECF RID: 204495 RVA: 0x00DF7580 File Offset: 0x00DF5780
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

		// Token: 0x06031ED0 RID: 204496 RVA: 0x00DF7658 File Offset: 0x00DF5858
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

		// Token: 0x06031ED1 RID: 204497 RVA: 0x00DF7728 File Offset: 0x00DF5928
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

		// Token: 0x06031ED2 RID: 204498 RVA: 0x00DF7778 File Offset: 0x00DF5978
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

		// Token: 0x06031ED3 RID: 204499 RVA: 0x00DF783C File Offset: 0x00DF5A3C
		public override bool IsValidScore(int scoreId)
		{
			BattleScoreConf? scoreConfig = BattleScoreModel.Instance.GetScoreConfig(scoreId, true);
			return scoreConfig != null && (scoreConfig.Value.Type == 4 || scoreConfig.Value.Type == 7);
		}

		// Token: 0x06031ED4 RID: 204500 RVA: 0x00DF7888 File Offset: 0x00DF5A88
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

		// Token: 0x06031ED5 RID: 204501 RVA: 0x00DF78FC File Offset: 0x00DF5AFC
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

		// Token: 0x0401A6C1 RID: 108225
		private const int LINK_SCORE_GROUP_ID = 2;

		// Token: 0x0401A6C2 RID: 108226
		[Nullable(1)]
		private const string SCORE_NIAGARA_PATH = "/Game/Aki/Effect/UI/Niagaras/RouGe/NS_Fx_LGUI_WhiteCat_Button_Panner.NS_Fx_LGUI_WhiteCat_Button_Panner";

		// Token: 0x0401A6C3 RID: 108227
		private const int MAX_SMOOTH_TIME = 200;

		// Token: 0x0401A6C4 RID: 108228
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat TickStatsObject = Stat.Create("[BattleView]LinkScoreItemTick", "", "");

		// Token: 0x0401A6C5 RID: 108229
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A6C6 RID: 108230
		private UNiagaraSystem ScoreNiagara;

		// Token: 0x0401A6C7 RID: 108231
		private UUINiagara ScoreUiNiagara;

		// Token: 0x0401A6C8 RID: 108232
		private UUIItem PointItem;

		// Token: 0x0401A6C9 RID: 108233
		private bool HasValidConfig;

		// Token: 0x0401A6CA RID: 108234
		private bool IsShowFull;

		// Token: 0x0401A6CB RID: 108235
		private int TickStartScore;

		// Token: 0x0401A6CC RID: 108236
		private int TickEndScore;

		// Token: 0x0401A6CD RID: 108237
		private int TickScore;

		// Token: 0x0401A6CE RID: 108238
		private int MaxScore;

		// Token: 0x0401A6CF RID: 108239
		private float SmoothTime;

		// Token: 0x0401A6D0 RID: 108240
		private IReadOnlyList<BattleScoreLevelConf> CurScoreLevelConfigList;

		// Token: 0x0401A6D1 RID: 108241
		private BattleScoreLevelConf? CurScoreLevelConfig;

		// Token: 0x0401A6D2 RID: 108242
		private BattleScoreLevelConf? MinScoreLevelConfig;

		// Token: 0x0401A6D3 RID: 108243
		private BattleScoreLevelConf? MaxScoreLevelConfig;

		// Token: 0x0401A6D4 RID: 108244
		private bool ScoreInitFlag;

		// Token: 0x0200AAAC RID: 43692
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034BE9 RID: 216041
			ScoreNiagara,
			// Token: 0x04034BEA RID: 216042
			PointItem
		}
	}
}
