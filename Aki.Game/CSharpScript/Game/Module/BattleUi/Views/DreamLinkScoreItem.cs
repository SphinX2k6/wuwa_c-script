using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Battle;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D9B RID: 19867
	[NullableContext(2)]
	[Nullable(0)]
	public class DreamLinkScoreItem : BaseScoreItem
	{
		// Token: 0x06031EAB RID: 204459 RVA: 0x00DF641C File Offset: 0x00DF461C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031EAC RID: 204460 RVA: 0x00DF652C File Offset: 0x00DF472C
		protected override UniTask OnCreateAsync()
		{
			DreamLinkScoreItem.<OnCreateAsync>d__29 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<DreamLinkScoreItem.<OnCreateAsync>d__29>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031EAD RID: 204461 RVA: 0x00DF6570 File Offset: 0x00DF4770
		protected unsafe override void OnStart()
		{
			base.OnStart();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.ScoreNiagara = base.GetUiNiagara(6);
			UUINiagara scoreNiagara = this.ScoreNiagara;
			if (scoreNiagara != null)
			{
				scoreNiagara.SetUIActive(false);
			}
			int num = 3;
			List<UUISprite> list = new List<UUISprite>(num);
			CollectionsMarshal.SetCount<UUISprite>(list, num);
			Span<UUISprite> span = CollectionsMarshal.AsSpan<UUISprite>(list);
			int num2 = 0;
			*span[num2] = base.GetSprite(2);
			num2++;
			*span[num2] = base.GetSprite(1);
			num2++;
			*span[num2] = base.GetSprite(0);
			this.ScoreBarList = list;
			this.ResetScoreGroup();
			UUISprite sprite = base.GetSprite(3);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			this.ProgressText = base.GetText(5);
			UUIText progressText = this.ProgressText;
			if (progressText != null)
			{
				progressText.SetText("0%", true);
			}
			this.PointItem = base.GetItem(4);
			this.CurScoreLevelConfigList = BattleScoreConfig.Instance.GetBattleScoreActionConfigByGroupId(4);
			this.UpdateMaxAndMinScore();
			foreach (KeyValuePair<int, int> keyValuePair in BattleScoreModel.Instance.GetScoreMap())
			{
				keyValuePair.Deconstruct(out num2, out num);
				int scoreId = num2;
				int num3 = num;
				if (num3 > 0)
				{
					this.OnBattleScoreChanged(scoreId, num3);
				}
			}
		}

		// Token: 0x06031EAE RID: 204462 RVA: 0x00DF66C8 File Offset: 0x00DF48C8
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
			base.OnBeforeDestroy();
		}

		// Token: 0x06031EAF RID: 204463 RVA: 0x00DF66E8 File Offset: 0x00DF48E8
		[NullableContext(1)]
		private UniTask LoadNiagara(string path, DreamLinkScoreItem.EScoreNiagaraType niagaraType)
		{
			DreamLinkScoreItem.<LoadNiagara>d__32 <LoadNiagara>d__;
			<LoadNiagara>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadNiagara>d__.<>4__this = this;
			<LoadNiagara>d__.path = path;
			<LoadNiagara>d__.niagaraType = niagaraType;
			<LoadNiagara>d__.<>1__state = -1;
			<LoadNiagara>d__.<>t__builder.Start<DreamLinkScoreItem.<LoadNiagara>d__32>(ref <LoadNiagara>d__);
			return <LoadNiagara>d__.<>t__builder.Task;
		}

		// Token: 0x06031EB0 RID: 204464 RVA: 0x00DF673C File Offset: 0x00DF493C
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
				this.CurScoreLevelConfig = null;
				if (this.CurScoreLevelConfigList != null)
				{
					foreach (BattleScoreLevelConf value in this.CurScoreLevelConfigList)
					{
						if (score >= value.LowerUpperLimits(0) && score < value.LowerUpperLimits(1))
						{
							this.CurScoreLevelConfig = new BattleScoreLevelConf?(value);
							break;
						}
					}
				}
			}
			this.UpdateScore(score, this.CurScoreLevelConfig);
		}

		// Token: 0x06031EB1 RID: 204465 RVA: 0x00DF6824 File Offset: 0x00DF4A24
		private void UpdateScore(int score, BattleScoreLevelConf? scoreLevelConfig)
		{
			this.HasValidConfig = (scoreLevelConfig != null);
			this.SetTickEndScore(score);
			if (this.MaxScore > 0)
			{
				int value = (int)Math.Floor((double)((float)score / (float)this.MaxScore * 100f));
				UUIText progressText = this.ProgressText;
				if (progressText == null)
				{
					return;
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				defaultInterpolatedStringHandler.AppendLiteral("%");
				progressText.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
		}

		// Token: 0x06031EB2 RID: 204466 RVA: 0x00DF689C File Offset: 0x00DF4A9C
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
					int curScoreGroup = this.CurScoreGroup;
					if (this.ScoreBarList != null)
					{
						for (int i = 0; i < this.ScoreBarList.Count; i++)
						{
							UUISprite uuisprite = this.ScoreBarList[i];
							if (i >= this.CurScoreGroup && this.TickScore >= this.ScoreGroup[i])
							{
								if (this.TickScore < this.ScoreGroup[i + 1])
								{
									this.CurScoreGroup = i;
									uuisprite.SetFillAmount(num2);
								}
								else
								{
									if (this.TickScore == this.ScoreGroup[this.MaxScoreGroup])
									{
										this.CurScoreGroup = this.MaxScoreGroup;
									}
									uuisprite.SetFillAmount(this.ScoreProgressGroup[i + 1]);
								}
							}
						}
					}
					if (curScoreGroup < this.CurScoreGroup)
					{
						if (this.CurScoreGroup < this.MaxScoreGroup)
						{
							UUINiagara scoreNiagara = this.ScoreNiagara;
							if (scoreNiagara != null)
							{
								scoreNiagara.SetNiagaraSystem(this.ScoreLevelUpNiagara);
							}
						}
						else
						{
							UUINiagara scoreNiagara2 = this.ScoreNiagara;
							if (scoreNiagara2 != null)
							{
								scoreNiagara2.SetNiagaraSystem(this.ScoreFullNiagara);
							}
						}
						UUINiagara scoreNiagara3 = this.ScoreNiagara;
						if (scoreNiagara3 != null)
						{
							scoreNiagara3.SetUIActive(true);
						}
						UUINiagara scoreNiagara4 = this.ScoreNiagara;
						if (scoreNiagara4 != null)
						{
							scoreNiagara4.ActivateSystem(true);
						}
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

		// Token: 0x06031EB3 RID: 204467 RVA: 0x00DF6A80 File Offset: 0x00DF4C80
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
			this.ResetScoreGroup();
		}

		// Token: 0x06031EB4 RID: 204468 RVA: 0x00DF6AD4 File Offset: 0x00DF4CD4
		private void ResetScoreGroup()
		{
			this.CurScoreGroup = 0;
			if (this.ScoreBarList != null)
			{
				foreach (UUISprite uuisprite in this.ScoreBarList)
				{
					uuisprite.SetFillAmount(0f);
				}
			}
		}

		// Token: 0x06031EB5 RID: 204469 RVA: 0x00DF6B38 File Offset: 0x00DF4D38
		private void UpdateMaxAndMinScore()
		{
			this.MinScoreLevelConfig = null;
			this.MaxScoreLevelConfig = null;
			this.ScoreGroup = new List<int>();
			this.ScoreProgressGroup = new List<float>();
			if (this.CurScoreLevelConfigList == null || this.CurScoreLevelConfigList.Count == 0)
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
				this.ScoreGroup.Add(value.LowerUpperLimits(0));
			}
			this.MaxScoreGroup = this.ScoreGroup.Count - 1;
			this.MaxScore = this.MaxScoreLevelConfig.Value.LowerUpperLimits(1);
			if (this.MaxScore > 0)
			{
				foreach (int num3 in this.ScoreGroup)
				{
					this.ScoreProgressGroup.Add((float)num3 / (float)this.MaxScore);
				}
			}
		}

		// Token: 0x06031EB6 RID: 204470 RVA: 0x00DF6C98 File Offset: 0x00DF4E98
		public override bool IsValidScore(int scoreId)
		{
			BattleScoreConf? scoreConfig = BattleScoreModel.Instance.GetScoreConfig(scoreId, true);
			return scoreConfig != null && scoreConfig.Value.Type == 5;
		}

		// Token: 0x06031EB7 RID: 204471 RVA: 0x00DF6CD0 File Offset: 0x00DF4ED0
		public override void ShowScore()
		{
			base.ShowScore();
			base.Show(null);
		}

		// Token: 0x06031EB8 RID: 204472 RVA: 0x00DF6CDF File Offset: 0x00DF4EDF
		public override void HideScore()
		{
			base.HideScore();
			base.Hide(null);
		}

		// Token: 0x0401A6A3 RID: 108195
		private const int DREAM_LINK_SCORE_GROUP_ID = 4;

		// Token: 0x0401A6A4 RID: 108196
		[Nullable(1)]
		private const string SCORE_LEVEL_UP_NIAGARA_PATH = "/Game/Aki/Effect/UI/Niagaras/RouGe/NS_Fx_LGUI_RouGeIcon_Brust_Weak.NS_Fx_LGUI_RouGeIcon_Brust_Weak";

		// Token: 0x0401A6A5 RID: 108197
		[Nullable(1)]
		private const string SCORE_FULL_NIAGARA_PATH = "/Game/Aki/Effect/UI/Niagaras/RouGe/NS_Fx_LGUI_RouGeIcon_Brust.NS_Fx_LGUI_RouGeIcon_Brust";

		// Token: 0x0401A6A6 RID: 108198
		private const int MAX_SMOOTH_TIME = 200;

		// Token: 0x0401A6A7 RID: 108199
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat TickStatsObject = Stat.Create("[BattleView]DreamLinkScoreItemTick", "", "");

		// Token: 0x0401A6A8 RID: 108200
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A6A9 RID: 108201
		private UNiagaraSystem ScoreFullNiagara;

		// Token: 0x0401A6AA RID: 108202
		private UNiagaraSystem ScoreLevelUpNiagara;

		// Token: 0x0401A6AB RID: 108203
		private UUINiagara ScoreNiagara;

		// Token: 0x0401A6AC RID: 108204
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<UUISprite> ScoreBarList;

		// Token: 0x0401A6AD RID: 108205
		private UUIItem PointItem;

		// Token: 0x0401A6AE RID: 108206
		private UUIText ProgressText;

		// Token: 0x0401A6AF RID: 108207
		private bool HasValidConfig;

		// Token: 0x0401A6B0 RID: 108208
		private int TickStartScore;

		// Token: 0x0401A6B1 RID: 108209
		private int TickEndScore;

		// Token: 0x0401A6B2 RID: 108210
		private int TickScore;

		// Token: 0x0401A6B3 RID: 108211
		private int MaxScore;

		// Token: 0x0401A6B4 RID: 108212
		private float SmoothTime;

		// Token: 0x0401A6B5 RID: 108213
		private int CurScoreGroup;

		// Token: 0x0401A6B6 RID: 108214
		private IReadOnlyList<BattleScoreLevelConf> CurScoreLevelConfigList;

		// Token: 0x0401A6B7 RID: 108215
		private BattleScoreLevelConf? CurScoreLevelConfig;

		// Token: 0x0401A6B8 RID: 108216
		private BattleScoreLevelConf? MinScoreLevelConfig;

		// Token: 0x0401A6B9 RID: 108217
		private BattleScoreLevelConf? MaxScoreLevelConfig;

		// Token: 0x0401A6BA RID: 108218
		private List<int> ScoreGroup;

		// Token: 0x0401A6BB RID: 108219
		private List<float> ScoreProgressGroup;

		// Token: 0x0401A6BC RID: 108220
		private int MaxScoreGroup;

		// Token: 0x0200AAA6 RID: 43686
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034BCE RID: 216014
			ScoreBarA,
			// Token: 0x04034BCF RID: 216015
			ScoreBarB,
			// Token: 0x04034BD0 RID: 216016
			ScoreBarC,
			// Token: 0x04034BD1 RID: 216017
			ScoreBarD,
			// Token: 0x04034BD2 RID: 216018
			PointItem,
			// Token: 0x04034BD3 RID: 216019
			ProgressText,
			// Token: 0x04034BD4 RID: 216020
			ScoreNiagara
		}

		// Token: 0x0200AAA7 RID: 43687
		[NullableContext(0)]
		private enum EScoreNiagaraType
		{
			// Token: 0x04034BD6 RID: 216022
			LevelUp,
			// Token: 0x04034BD7 RID: 216023
			Full
		}
	}
}
