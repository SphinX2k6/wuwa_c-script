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
	// Token: 0x02005DB7 RID: 23991
	[NullableContext(2)]
	[Nullable(0)]
	public class DreamLinkScoreItem : BaseScoreItem
	{
		// Token: 0x0603CF34 RID: 249652 RVA: 0x00EA5540 File Offset: 0x00EA3740
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

		// Token: 0x0603CF35 RID: 249653 RVA: 0x00EA5650 File Offset: 0x00EA3850
		protected override UniTask OnCreateAsync()
		{
			DreamLinkScoreItem.<OnCreateAsync>d__29 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<DreamLinkScoreItem.<OnCreateAsync>d__29>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CF36 RID: 249654 RVA: 0x00EA5694 File Offset: 0x00EA3894
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

		// Token: 0x0603CF37 RID: 249655 RVA: 0x00EA57EC File Offset: 0x00EA39EC
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

		// Token: 0x0603CF38 RID: 249656 RVA: 0x00EA580C File Offset: 0x00EA3A0C
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

		// Token: 0x0603CF39 RID: 249657 RVA: 0x00EA5860 File Offset: 0x00EA3A60
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

		// Token: 0x0603CF3A RID: 249658 RVA: 0x00EA5948 File Offset: 0x00EA3B48
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

		// Token: 0x0603CF3B RID: 249659 RVA: 0x00EA59C0 File Offset: 0x00EA3BC0
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

		// Token: 0x0603CF3C RID: 249660 RVA: 0x00EA5BA4 File Offset: 0x00EA3DA4
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

		// Token: 0x0603CF3D RID: 249661 RVA: 0x00EA5BF8 File Offset: 0x00EA3DF8
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

		// Token: 0x0603CF3E RID: 249662 RVA: 0x00EA5C5C File Offset: 0x00EA3E5C
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

		// Token: 0x0603CF3F RID: 249663 RVA: 0x00EA5DBC File Offset: 0x00EA3FBC
		public override bool IsValidScore(int scoreId)
		{
			BattleScoreConf? scoreConfig = BattleScoreModel.Instance.GetScoreConfig(scoreId, true);
			return scoreConfig != null && scoreConfig.Value.Type == 5;
		}

		// Token: 0x0603CF40 RID: 249664 RVA: 0x00EA5DF4 File Offset: 0x00EA3FF4
		public override void ShowScore()
		{
			base.ShowScore();
			base.Show(null);
		}

		// Token: 0x0603CF41 RID: 249665 RVA: 0x00EA5E03 File Offset: 0x00EA4003
		public override void HideScore()
		{
			base.HideScore();
			base.Hide(null);
		}

		// Token: 0x0401FBE6 RID: 130022
		private const int DREAM_LINK_SCORE_GROUP_ID = 4;

		// Token: 0x0401FBE7 RID: 130023
		[Nullable(1)]
		private const string SCORE_LEVEL_UP_NIAGARA_PATH = "/Game/Aki/Effect/UI/Niagaras/RouGe/NS_Fx_LGUI_RouGeIcon_Brust_Weak.NS_Fx_LGUI_RouGeIcon_Brust_Weak";

		// Token: 0x0401FBE8 RID: 130024
		[Nullable(1)]
		private const string SCORE_FULL_NIAGARA_PATH = "/Game/Aki/Effect/UI/Niagaras/RouGe/NS_Fx_LGUI_RouGeIcon_Brust.NS_Fx_LGUI_RouGeIcon_Brust";

		// Token: 0x0401FBE9 RID: 130025
		private const int MAX_SMOOTH_TIME = 200;

		// Token: 0x0401FBEA RID: 130026
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat TickStatsObject = Stat.Create("[BattleView]DreamLinkScoreItemTick", "", "");

		// Token: 0x0401FBEB RID: 130027
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401FBEC RID: 130028
		private UNiagaraSystem ScoreFullNiagara;

		// Token: 0x0401FBED RID: 130029
		private UNiagaraSystem ScoreLevelUpNiagara;

		// Token: 0x0401FBEE RID: 130030
		private UUINiagara ScoreNiagara;

		// Token: 0x0401FBEF RID: 130031
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<UUISprite> ScoreBarList;

		// Token: 0x0401FBF0 RID: 130032
		private UUIItem PointItem;

		// Token: 0x0401FBF1 RID: 130033
		private UUIText ProgressText;

		// Token: 0x0401FBF2 RID: 130034
		private bool HasValidConfig;

		// Token: 0x0401FBF3 RID: 130035
		private int TickStartScore;

		// Token: 0x0401FBF4 RID: 130036
		private int TickEndScore;

		// Token: 0x0401FBF5 RID: 130037
		private int TickScore;

		// Token: 0x0401FBF6 RID: 130038
		private int MaxScore;

		// Token: 0x0401FBF7 RID: 130039
		private float SmoothTime;

		// Token: 0x0401FBF8 RID: 130040
		private int CurScoreGroup;

		// Token: 0x0401FBF9 RID: 130041
		private IReadOnlyList<BattleScoreLevelConf> CurScoreLevelConfigList;

		// Token: 0x0401FBFA RID: 130042
		private BattleScoreLevelConf? CurScoreLevelConfig;

		// Token: 0x0401FBFB RID: 130043
		private BattleScoreLevelConf? MinScoreLevelConfig;

		// Token: 0x0401FBFC RID: 130044
		private BattleScoreLevelConf? MaxScoreLevelConfig;

		// Token: 0x0401FBFD RID: 130045
		private List<int> ScoreGroup;

		// Token: 0x0401FBFE RID: 130046
		private List<float> ScoreProgressGroup;

		// Token: 0x0401FBFF RID: 130047
		private int MaxScoreGroup;

		// Token: 0x0200C09D RID: 49309
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A1FC RID: 238076
			ScoreBarA,
			// Token: 0x0403A1FD RID: 238077
			ScoreBarB,
			// Token: 0x0403A1FE RID: 238078
			ScoreBarC,
			// Token: 0x0403A1FF RID: 238079
			ScoreBarD,
			// Token: 0x0403A200 RID: 238080
			PointItem,
			// Token: 0x0403A201 RID: 238081
			ProgressText,
			// Token: 0x0403A202 RID: 238082
			ScoreNiagara
		}

		// Token: 0x0200C09E RID: 49310
		[NullableContext(0)]
		private enum EScoreNiagaraType
		{
			// Token: 0x0403A204 RID: 238084
			LevelUp,
			// Token: 0x0403A205 RID: 238085
			Full
		}
	}
}
