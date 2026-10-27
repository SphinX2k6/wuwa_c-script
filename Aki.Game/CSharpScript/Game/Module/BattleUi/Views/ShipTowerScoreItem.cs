using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DBB RID: 23995
	[NullableContext(1)]
	[Nullable(0)]
	public class ShipTowerScoreItem : BaseScoreItem
	{
		// Token: 0x0603CF83 RID: 249731 RVA: 0x00EA7DA8 File Offset: 0x00EA5FA8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603CF84 RID: 249732 RVA: 0x00EA7EB4 File Offset: 0x00EA60B4
		protected override void OnStart()
		{
			base.OnStart();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
			this.PointItem = base.GetItem(4);
			this.PointRotator = new FRotator(0f, 0f, 0f);
			this.ProgressText = base.GetText(2);
			this.ProgressText.SetText("0%", true);
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetFillAmount(0f);
			}
			if (ShipTowerModel.Instance.CurSeasonCfg == null)
			{
				return;
			}
			int num = 2304;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "ShipTower评分组ID";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("scoreGroupId", num);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.CurScoreLevelConfigList = BattleScoreConfig.Instance.GetBattleScoreActionConfigByGroupId(num);
			this.UpdateMaxAndMinScore();
			foreach (KeyValuePair<int, int> keyValuePair in BattleScoreModel.Instance.GetScoreMap())
			{
				int num2;
				int num3;
				keyValuePair.Deconstruct(out num2, out num3);
				int scoreId = num2;
				int num4 = num3;
				if (num4 > 0)
				{
					this.OnBattleScoreChanged(scoreId, num4);
				}
			}
		}

		// Token: 0x0603CF85 RID: 249733 RVA: 0x00EA800C File Offset: 0x00EA620C
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
			this.RemoveScoreTextTimer();
			base.OnBeforeDestroy();
		}

		// Token: 0x0603CF86 RID: 249734 RVA: 0x00EA8034 File Offset: 0x00EA6234
		protected override void OnBattleScoreChanged(int scoreId, int score)
		{
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

		// Token: 0x0603CF87 RID: 249735 RVA: 0x00EA80B4 File Offset: 0x00EA62B4
		private void UpdateScore(int score, BattleScoreLevelConf? scoreLevelConfig)
		{
			this.HasValidConfig = (scoreLevelConfig != null);
			this.SetTickEndScore(score);
			if (!base.IsShowOrShowing)
			{
				this.ShowScore();
			}
			if (this.MaxScore > 0)
			{
				int num = (int)Math.Floor((double)((float)score / (float)this.MaxScore * 100f));
				this.ProgressText.SetText(num.ToString() + "%", true);
			}
		}

		// Token: 0x0603CF88 RID: 249736 RVA: 0x00EA8124 File Offset: 0x00EA6324
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
			if (this.MaxScore <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "ShipTower评分最大值不合法";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MaxScore", this.MaxScore);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x0603CF89 RID: 249737 RVA: 0x00EA821C File Offset: 0x00EA641C
		public override void OnTick(float delta)
		{
			if (this.HasValidConfig && this.TickScore != this.TickEndScore && base.GetActive() && Time.Instance.TimeDilation != 0f)
			{
				this.SmoothTime = Math.Min(this.MaxSmoothTime, this.SmoothTime + delta);
				float num = this.SmoothTime / this.MaxSmoothTime;
				this.TickScore = this.TickStartScore * (1f - num) + this.TickEndScore * num;
				if (this.MaxScore > 0)
				{
					float num2 = this.TickScore / (float)this.MaxScore;
					UUISprite sprite = base.GetSprite(0);
					if (sprite != null)
					{
						sprite.SetFillAmount(num2);
					}
					this.PointRotator.Yaw = num2 * -360f;
					UUIItem pointItem = this.PointItem;
					if (pointItem == null)
					{
						return;
					}
					pointItem.SetUIRelativeRotation(this.PointRotator);
				}
			}
		}

		// Token: 0x0603CF8A RID: 249738 RVA: 0x00EA82FC File Offset: 0x00EA64FC
		private float GetMaxSmoothTime()
		{
			PropSmallItemGrid propSmallItemGrid = ShipTowerModel.Instance.GetInTheBattleBuffInfo().ItemInfo as PropSmallItemGrid;
			int valueOrDefault = ((propSmallItemGrid != null) ? propSmallItemGrid.ItemConfigId : null).GetValueOrDefault();
			if (valueOrDefault != 0)
			{
				SlashBuffToItem? buffCfgByItemId = ShipTowerConfig.Instance.GetBuffCfgByItemId(valueOrDefault);
				int? num = (buffCfgByItemId != null) ? new int?(buffCfgByItemId.GetValueOrDefault().BuffTime) : null;
				bool flag;
				if (num != null)
				{
					int valueOrDefault2 = num.GetValueOrDefault();
					if (valueOrDefault2 > 0 || valueOrDefault2 == -1)
					{
						flag = true;
						goto IL_8C;
					}
				}
				flag = false;
				IL_8C:
				if (flag)
				{
					return (float)buffCfgByItemId.Value.BuffTime;
				}
			}
			return (float)((this.CurScoreLevelConfig != null) ? this.CurScoreLevelConfig.GetValueOrDefault().BuffTime : 0);
		}

		// Token: 0x0603CF8B RID: 249739 RVA: 0x00EA83CC File Offset: 0x00EA65CC
		private void ScoreTextSmoothToZero()
		{
			this.RemoveScoreTextTimer();
			this.ScoreTextHandle = TimerSystem.FlowTimeInstance.Forever(delegate(float _)
			{
				int num = (int)Math.Floor((double)((1f - this.SmoothTime / this.MaxSmoothTime) * 100f));
				this.ProgressText.SetText(num.ToString() + "%", true);
				if (num <= 0)
				{
					this.RemoveScoreTextTimer();
				}
			}, 200f, 1f, null, null, true);
		}

		// Token: 0x0603CF8C RID: 249740 RVA: 0x00EA83FD File Offset: 0x00EA65FD
		private void RemoveScoreTextTimer()
		{
			if (this.ScoreTextHandle != null)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.StopSequenceByKey("Back", true, true);
				}
				TimerSystem.FlowTimeInstance.Remove(this.ScoreTextHandle);
				this.ScoreTextHandle = null;
			}
		}

		// Token: 0x0603CF8D RID: 249741 RVA: 0x00EA8438 File Offset: 0x00EA6638
		private void SetTickEndScore(int score)
		{
			if (score <= 0)
			{
				this.RemoveScoreTextTimer();
				this.TickStartScore = this.TickScore;
				this.TickEndScore = 0f;
				this.SmoothTime = 200f;
				this.MaxSmoothTime = 200f;
				this.PlayLevelSequence("Start2");
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "焚潮结束";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("score", score);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				EventSystem.Instance.Emit<string>(EEventName.ShipTowerBattleTip, "ShipTower_BurningTide_End");
				return;
			}
			this.TickStartScore = this.TickScore;
			this.TickEndScore = (float)score;
			this.SmoothTime = 0f;
			if (score < this.MaxScore)
			{
				this.MaxSmoothTime = 200f;
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Battle;
			ELogAuthor author2 = ELogAuthor.LRC;
			string message2 = "焚潮开始";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("score", score);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			EventSystem.Instance.Emit<string>(EEventName.ShipTowerBattleTip, "ShipTower_BurningTide_Start");
			float maxSmoothTime = this.GetMaxSmoothTime();
			if (maxSmoothTime > 0f)
			{
				this.PlayLevelSequence("Start");
				this.MaxSmoothTime = maxSmoothTime;
				this.TickEndScore = 0f;
				this.ScoreTextSmoothToZero();
				return;
			}
			this.PlayLevelSequence("Immortal");
			this.MaxSmoothTime = 200f;
		}

		// Token: 0x0603CF8E RID: 249742 RVA: 0x00EA8590 File Offset: 0x00EA6790
		public override bool IsValidScore(int scoreId)
		{
			BattleScoreConf? scoreConfig = BattleScoreModel.Instance.GetScoreConfig(scoreId, true);
			return scoreConfig != null && scoreConfig.Value.Type == 9;
		}

		// Token: 0x0603CF8F RID: 249743 RVA: 0x00EA85D4 File Offset: 0x00EA67D4
		private void PlayLevelSequence(string sequenceName)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "播放序列";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("sequenceName", sequenceName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
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
			levelSequencePlayer2.PlaySequencePurely(sequenceName, false, false, null, null, false);
		}

		// Token: 0x0603CF90 RID: 249744 RVA: 0x00EA863C File Offset: 0x00EA683C
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "Start")
			{
				if (this.TickEndScore <= 0f)
				{
					LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
					if (levelSequencePlayer == null)
					{
						return;
					}
					levelSequencePlayer.PlayLevelSequenceByName("Back", false, new float?(1000f / this.MaxSmoothTime), false);
					return;
				}
			}
			else if (sequenceName == "Start2")
			{
				this.PlayLevelSequence("Loop1");
			}
		}

		// Token: 0x0603CF91 RID: 249745 RVA: 0x00EA86A4 File Offset: 0x00EA68A4
		private void OnButtonClick()
		{
			ShipTowerScoreItemViewParams param = new ShipTowerScoreItemViewParams
			{
				CurScore = (int)this.TickScore,
				MaxScore = this.MaxScore
			};
			UiManager.Instance.OpenView(EUiViewName.ShipTowerLevelInfoView, param, null);
		}

		// Token: 0x0603CF92 RID: 249746 RVA: 0x00EA86E1 File Offset: 0x00EA68E1
		public override void ShowScore()
		{
			base.ShowScore();
			base.Show(null);
			this.PlayLevelSequence("Start2");
		}

		// Token: 0x0603CF93 RID: 249747 RVA: 0x00EA86FB File Offset: 0x00EA68FB
		public override void HideScore()
		{
			base.HideScore();
			base.Hide(null);
		}

		// Token: 0x0401FC47 RID: 130119
		private const int MAX_SMOOTH_TIME = 200;

		// Token: 0x0401FC48 RID: 130120
		private const int SHIP_TOWER_SCORE_GROUP_ID = 2304;

		// Token: 0x0401FC49 RID: 130121
		[StaticVariableRuleIgnore]
		private static readonly Stat TickStatsObject = Stat.Create("[BattleView]ShipTowerScoreItemTick", "", "");

		// Token: 0x0401FC4A RID: 130122
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401FC4B RID: 130123
		private UUIText ProgressText;

		// Token: 0x0401FC4C RID: 130124
		[Nullable(2)]
		private IReadOnlyList<BattleScoreLevelConf> CurScoreLevelConfigList;

		// Token: 0x0401FC4D RID: 130125
		private BattleScoreLevelConf? CurScoreLevelConfig;

		// Token: 0x0401FC4E RID: 130126
		private BattleScoreLevelConf? MinScoreLevelConfig;

		// Token: 0x0401FC4F RID: 130127
		private BattleScoreLevelConf? MaxScoreLevelConfig;

		// Token: 0x0401FC50 RID: 130128
		private bool HasValidConfig;

		// Token: 0x0401FC51 RID: 130129
		private float TickStartScore;

		// Token: 0x0401FC52 RID: 130130
		private float TickEndScore;

		// Token: 0x0401FC53 RID: 130131
		private float TickScore;

		// Token: 0x0401FC54 RID: 130132
		private int MaxScore;

		// Token: 0x0401FC55 RID: 130133
		private float SmoothTime;

		// Token: 0x0401FC56 RID: 130134
		[Nullable(2)]
		private UUIItem PointItem;

		// Token: 0x0401FC57 RID: 130135
		private FRotator PointRotator;

		// Token: 0x0401FC58 RID: 130136
		private float MaxSmoothTime;

		// Token: 0x0401FC59 RID: 130137
		[Nullable(2)]
		private TimerHandle ScoreTextHandle;

		// Token: 0x0200C0B0 RID: 49328
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403A250 RID: 238160
			ProgressSprite,
			// Token: 0x0403A251 RID: 238161
			BuffIconTexture,
			// Token: 0x0403A252 RID: 238162
			ProgressText,
			// Token: 0x0403A253 RID: 238163
			Button,
			// Token: 0x0403A254 RID: 238164
			PointItem
		}
	}
}
