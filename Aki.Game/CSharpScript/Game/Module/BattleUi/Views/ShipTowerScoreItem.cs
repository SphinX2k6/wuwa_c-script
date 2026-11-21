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
	// Token: 0x02004D9F RID: 19871
	[NullableContext(1)]
	[Nullable(0)]
	public class ShipTowerScoreItem : BaseScoreItem
	{
		// Token: 0x06031EFA RID: 204538 RVA: 0x00DF8C84 File Offset: 0x00DF6E84
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

		// Token: 0x06031EFB RID: 204539 RVA: 0x00DF8D90 File Offset: 0x00DF6F90
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

		// Token: 0x06031EFC RID: 204540 RVA: 0x00DF8EE8 File Offset: 0x00DF70E8
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

		// Token: 0x06031EFD RID: 204541 RVA: 0x00DF8F10 File Offset: 0x00DF7110
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

		// Token: 0x06031EFE RID: 204542 RVA: 0x00DF8F90 File Offset: 0x00DF7190
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

		// Token: 0x06031EFF RID: 204543 RVA: 0x00DF9000 File Offset: 0x00DF7200
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

		// Token: 0x06031F00 RID: 204544 RVA: 0x00DF90F8 File Offset: 0x00DF72F8
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

		// Token: 0x06031F01 RID: 204545 RVA: 0x00DF91D8 File Offset: 0x00DF73D8
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

		// Token: 0x06031F02 RID: 204546 RVA: 0x00DF92A8 File Offset: 0x00DF74A8
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

		// Token: 0x06031F03 RID: 204547 RVA: 0x00DF92D9 File Offset: 0x00DF74D9
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

		// Token: 0x06031F04 RID: 204548 RVA: 0x00DF9314 File Offset: 0x00DF7514
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

		// Token: 0x06031F05 RID: 204549 RVA: 0x00DF946C File Offset: 0x00DF766C
		public override bool IsValidScore(int scoreId)
		{
			BattleScoreConf? scoreConfig = BattleScoreModel.Instance.GetScoreConfig(scoreId, true);
			return scoreConfig != null && scoreConfig.Value.Type == 9;
		}

		// Token: 0x06031F06 RID: 204550 RVA: 0x00DF94B0 File Offset: 0x00DF76B0
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

		// Token: 0x06031F07 RID: 204551 RVA: 0x00DF9518 File Offset: 0x00DF7718
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

		// Token: 0x06031F08 RID: 204552 RVA: 0x00DF9580 File Offset: 0x00DF7780
		private void OnButtonClick()
		{
			ShipTowerScoreItemViewParams param = new ShipTowerScoreItemViewParams
			{
				CurScore = (int)this.TickScore,
				MaxScore = this.MaxScore
			};
			UiManager.Instance.OpenView(EUiViewName.ShipTowerLevelInfoView, param, null);
		}

		// Token: 0x06031F09 RID: 204553 RVA: 0x00DF95BD File Offset: 0x00DF77BD
		public override void ShowScore()
		{
			base.ShowScore();
			base.Show(null);
			this.PlayLevelSequence("Start2");
		}

		// Token: 0x06031F0A RID: 204554 RVA: 0x00DF95D7 File Offset: 0x00DF77D7
		public override void HideScore()
		{
			base.HideScore();
			base.Hide(null);
		}

		// Token: 0x0401A704 RID: 108292
		private const int MAX_SMOOTH_TIME = 200;

		// Token: 0x0401A705 RID: 108293
		private const int SHIP_TOWER_SCORE_GROUP_ID = 2304;

		// Token: 0x0401A706 RID: 108294
		[StaticVariableRuleIgnore]
		private static readonly Stat TickStatsObject = Stat.Create("[BattleView]ShipTowerScoreItemTick", "", "");

		// Token: 0x0401A707 RID: 108295
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A708 RID: 108296
		private UUIText ProgressText;

		// Token: 0x0401A709 RID: 108297
		[Nullable(2)]
		private IReadOnlyList<BattleScoreLevelConf> CurScoreLevelConfigList;

		// Token: 0x0401A70A RID: 108298
		private BattleScoreLevelConf? CurScoreLevelConfig;

		// Token: 0x0401A70B RID: 108299
		private BattleScoreLevelConf? MinScoreLevelConfig;

		// Token: 0x0401A70C RID: 108300
		private BattleScoreLevelConf? MaxScoreLevelConfig;

		// Token: 0x0401A70D RID: 108301
		private bool HasValidConfig;

		// Token: 0x0401A70E RID: 108302
		private float TickStartScore;

		// Token: 0x0401A70F RID: 108303
		private float TickEndScore;

		// Token: 0x0401A710 RID: 108304
		private float TickScore;

		// Token: 0x0401A711 RID: 108305
		private int MaxScore;

		// Token: 0x0401A712 RID: 108306
		private float SmoothTime;

		// Token: 0x0401A713 RID: 108307
		[Nullable(2)]
		private UUIItem PointItem;

		// Token: 0x0401A714 RID: 108308
		private FRotator PointRotator;

		// Token: 0x0401A715 RID: 108309
		private float MaxSmoothTime;

		// Token: 0x0401A716 RID: 108310
		[Nullable(2)]
		private TimerHandle ScoreTextHandle;

		// Token: 0x0200AAB9 RID: 43705
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04034C22 RID: 216098
			ProgressSprite,
			// Token: 0x04034C23 RID: 216099
			BuffIconTexture,
			// Token: 0x04034C24 RID: 216100
			ProgressText,
			// Token: 0x04034C25 RID: 216101
			Button,
			// Token: 0x04034C26 RID: 216102
			PointItem
		}
	}
}
