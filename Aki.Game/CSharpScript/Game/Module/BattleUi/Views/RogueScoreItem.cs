using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Battle;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DBA RID: 23994
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueScoreItem : BaseScoreItem
	{
		// Token: 0x0603CF62 RID: 249698 RVA: 0x00EA6AC8 File Offset: 0x00EA4CC8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			this.IsMobile = Info.Instance.IsInTouch();
		}

		// Token: 0x0603CF63 RID: 249699 RVA: 0x00EA6C2C File Offset: 0x00EA4E2C
		protected override UniTask OnCreateAsync()
		{
			RogueScoreItem.<OnCreateAsync>d__49 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<RogueScoreItem.<OnCreateAsync>d__49>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CF64 RID: 249700 RVA: 0x00EA6C70 File Offset: 0x00EA4E70
		private UniTask LoadTexture(string path, int index, [Nullable(new byte[]
		{
			1,
			2
		})] UTexture[] textureDataList)
		{
			RogueScoreItem.<LoadTexture>d__50 <LoadTexture>d__;
			<LoadTexture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadTexture>d__.path = path;
			<LoadTexture>d__.index = index;
			<LoadTexture>d__.textureDataList = textureDataList;
			<LoadTexture>d__.<>1__state = -1;
			<LoadTexture>d__.<>t__builder.Start<RogueScoreItem.<LoadTexture>d__50>(ref <LoadTexture>d__);
			return <LoadTexture>d__.<>t__builder.Task;
		}

		// Token: 0x0603CF65 RID: 249701 RVA: 0x00EA6CC4 File Offset: 0x00EA4EC4
		private UniTask LoadNiagara(string path, int index, [Nullable(new byte[]
		{
			1,
			2
		})] UNiagaraSystem[] niagaraList)
		{
			RogueScoreItem.<LoadNiagara>d__51 <LoadNiagara>d__;
			<LoadNiagara>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadNiagara>d__.path = path;
			<LoadNiagara>d__.index = index;
			<LoadNiagara>d__.niagaraList = niagaraList;
			<LoadNiagara>d__.<>1__state = -1;
			<LoadNiagara>d__.<>t__builder.Start<RogueScoreItem.<LoadNiagara>d__51>(ref <LoadNiagara>d__);
			return <LoadNiagara>d__.<>t__builder.Task;
		}

		// Token: 0x0603CF66 RID: 249702 RVA: 0x00EA6D18 File Offset: 0x00EA4F18
		private UniTask LoadShader(string path)
		{
			RogueScoreItem.<LoadShader>d__52 <LoadShader>d__;
			<LoadShader>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadShader>d__.<>4__this = this;
			<LoadShader>d__.path = path;
			<LoadShader>d__.<>1__state = -1;
			<LoadShader>d__.<>t__builder.Start<RogueScoreItem.<LoadShader>d__52>(ref <LoadShader>d__);
			return <LoadShader>d__.<>t__builder.Task;
		}

		// Token: 0x0603CF67 RID: 249703 RVA: 0x00EA6D64 File Offset: 0x00EA4F64
		protected override void OnStart()
		{
			base.OnStart();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.ScoreTexture = base.GetTexture(0);
			this.ScoreTextureTransitionComp = (this.ScoreTexture.GetOwner().GetComponentByClass(UUITextureTransitionComponent.StaticClass()) as UUITextureTransitionComponent);
			this.ScoreBgTexture = base.GetTexture(1);
			this.ScoreBgTextureTransitionComp = (this.ScoreBgTexture.GetOwner().GetComponentByClass(UUITextureTransitionComponent.StaticClass()) as UUITextureTransitionComponent);
			this.ScoreNiagara = base.GetUiNiagara(2);
			for (int i = 3; i <= 8; i++)
			{
				UUIItem item = base.GetItem(i);
				this.NodeList.Add(item);
			}
			this.SetPercent(0f);
			this.RogueScoreMachine.SetUpdateCallback(new Action<float, BattleScoreLevelConf?>(this.OnUpdateScore), new Action(this.PlayUpAnim));
			foreach (KeyValuePair<int, bool> keyValuePair in BattleScoreModel.Instance.GetScoreEnableMap())
			{
				int num;
				bool flag;
				keyValuePair.Deconstruct(out num, out flag);
				int scoreId = num;
				if (flag)
				{
					this.UpdateScoreOffset(scoreId);
				}
			}
			foreach (KeyValuePair<int, int> keyValuePair2 in BattleScoreModel.Instance.GetScoreMap())
			{
				int num;
				int num2;
				keyValuePair2.Deconstruct(out num, out num2);
				int scoreId2 = num;
				int num3 = num2;
				if (num3 > 0 && this.IsValidScore(scoreId2))
				{
					this.OnBattleScoreChanged(scoreId2, num3);
				}
			}
		}

		// Token: 0x0603CF68 RID: 249704 RVA: 0x00EA6F0C File Offset: 0x00EA510C
		protected override void OnBeforeDestroy()
		{
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
			base.OnBeforeDestroy();
		}

		// Token: 0x0603CF69 RID: 249705 RVA: 0x00EA6F28 File Offset: 0x00EA5128
		protected override UniTask OnShowAsyncImplement()
		{
			RogueScoreItem.<OnShowAsyncImplement>d__55 <OnShowAsyncImplement>d__;
			<OnShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplement>d__.<>4__this = this;
			<OnShowAsyncImplement>d__.<>1__state = -1;
			<OnShowAsyncImplement>d__.<>t__builder.Start<RogueScoreItem.<OnShowAsyncImplement>d__55>(ref <OnShowAsyncImplement>d__);
			return <OnShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603CF6A RID: 249706 RVA: 0x00EA6F6B File Offset: 0x00EA516B
		protected override void OnBattleScoreChanged(int scoreId, int score)
		{
			if (base.IsHideOrHiding)
			{
				this.ShowScore();
			}
			this.UpdateScoreConfig(scoreId, score);
			this.UpdateScore(score, this.CurScoreLevelConfig);
			if (this.CurScoreLevelConfig != null)
			{
				base.SetUiActive(true);
			}
		}

		// Token: 0x0603CF6B RID: 249707 RVA: 0x00EA6FA4 File Offset: 0x00EA51A4
		public void UpdateScore(int score, BattleScoreLevelConf? scoreLevelConfig)
		{
			this.RogueScoreMachine.UpdateTargetScore((float)score, scoreLevelConfig);
		}

		// Token: 0x0603CF6C RID: 249708 RVA: 0x00EA6FB4 File Offset: 0x00EA51B4
		private void OnUpdateScore(float curScore, BattleScoreLevelConf? curScoreLevelConfig)
		{
			if (this.CurScore == curScore)
			{
				return;
			}
			this.CurScore = curScore;
			int? num = (this.UiScoreLevelConfig != null) ? new int?(this.UiScoreLevelConfig.GetValueOrDefault().Id) : null;
			int? num2 = (curScoreLevelConfig != null) ? new int?(curScoreLevelConfig.GetValueOrDefault().Id) : null;
			if (!(num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null)))
			{
				int num3 = (this.UiScoreLevelConfig != null) ? this.UiScoreLevelConfig.GetValueOrDefault().Level : 0;
				bool flag = this.UiScoreLevelConfig != null;
				this.UiScoreLevelConfig = curScoreLevelConfig;
				if (this.UiScoreLevelConfig != null)
				{
					BattleScoreLevelConf value = this.UiScoreLevelConfig.Value;
					this.SetScoreLevelUi(value.Level);
					this.PlayAudio(value.Level, value.Level > num3);
					if (flag)
					{
						this.PlayChangeAnim(value.Level);
					}
				}
				else
				{
					base.SetUiActive(false);
					this.PlayAudio(0, false);
				}
			}
			if (this.UiScoreLevelConfig != null)
			{
				BattleScoreLevelConf value2 = this.UiScoreLevelConfig.Value;
				int num4 = value2.LowerUpperLimits(0);
				int num5 = value2.LowerUpperLimits(1);
				float num6;
				if (num5 == num4)
				{
					num6 = 1f;
				}
				else
				{
					num6 = (curScore - (float)num4) / (float)(num5 - num4);
					num6 = Math.Min(num6, 1f);
				}
				this.SetPercent(num6);
			}
		}

		// Token: 0x0603CF6D RID: 249709 RVA: 0x00EA7145 File Offset: 0x00EA5345
		private void SetScoreLevelUi(int level)
		{
			this.SetScoreTexture(level);
			this.SetScoreBgTexture(level);
			this.SetScoreNiagara(level);
			this.SetNode(level);
		}

		// Token: 0x0603CF6E RID: 249710 RVA: 0x00EA7164 File Offset: 0x00EA5364
		private void SetScoreTexture(int level)
		{
			UTexture utexture = this.ScoreTextureDataList[level - 1];
			this.ScoreTexture.SetTexture(utexture);
			UUITextureTransitionComponent scoreTextureTransitionComp = this.ScoreTextureTransitionComp;
			if (scoreTextureTransitionComp != null)
			{
				scoreTextureTransitionComp.SetAllStateTexture(utexture);
			}
			this.ScoreTexture.SetSizeFromTexture();
		}

		// Token: 0x0603CF6F RID: 249711 RVA: 0x00EA71A8 File Offset: 0x00EA53A8
		private void SetScoreBgTexture(int level)
		{
			UTexture utexture = this.ScoreBgTextureDataList[level - 1];
			this.ScoreBgTexture.SetTexture(utexture);
			UUITextureTransitionComponent scoreBgTextureTransitionComp = this.ScoreBgTextureTransitionComp;
			if (scoreBgTextureTransitionComp != null)
			{
				scoreBgTextureTransitionComp.SetAllStateTexture(utexture);
			}
			this.ScoreBgTexture.SetSizeFromTexture();
			this.ScoreBgTexture.SetCustomMaterialVectorParameter(RogueScoreItem.fillColor, RogueScoreItem.fillColorList[level - 1]);
			this.ScoreBgTexture.SetCustomMaterialVectorParameter(RogueScoreItem.flowColorA, RogueScoreItem.flowColorListA[level - 1]);
			this.ScoreBgTexture.SetCustomMaterialVectorParameter(RogueScoreItem.flowColorB, RogueScoreItem.flowColorListB[level - 1]);
		}

		// Token: 0x0603CF70 RID: 249712 RVA: 0x00EA7240 File Offset: 0x00EA5440
		private void SetScoreNiagara(int level)
		{
			int num = RogueScoreItem.scoreNiagaraIndexList[level - 1];
			if (this.CurScoreNiagaraIndex == num)
			{
				return;
			}
			this.CurScoreNiagaraIndex = num;
			UNiagaraSystem niagaraSystem = this.ScoreNiagaraList[num];
			this.ScoreNiagara.SetNiagaraSystem(niagaraSystem);
			this.ScoreNiagara.ActivateSystem(true);
		}

		// Token: 0x0603CF71 RID: 249713 RVA: 0x00EA728C File Offset: 0x00EA548C
		private void SetNode(int level)
		{
			int num = level - 1;
			if (this.CurNodeIndex == num)
			{
				return;
			}
			if (this.CurNodeIndex >= 0)
			{
				this.NodeList[this.CurNodeIndex].SetUIActive(false);
			}
			if (num >= 0)
			{
				this.NodeList[num].SetUIActive(true);
			}
			this.CurNodeIndex = num;
		}

		// Token: 0x0603CF72 RID: 249714 RVA: 0x00EA72E4 File Offset: 0x00EA54E4
		private void PlayAudio(int level, bool isLevelUp)
		{
			BattleScoreModel.Instance.RougeScoreMusicState.State = RogueScoreItem.musicStateList[level];
			if (isLevelUp)
			{
				AudioSystem.Instance.PostEvent("play_ui_rogue_combo");
				return;
			}
			AudioSystem.Instance.PostEvent("play_ui_rogue_combo_down");
		}

		// Token: 0x0603CF73 RID: 249715 RVA: 0x00EA7320 File Offset: 0x00EA5520
		private void PlayChangeAnim(int level)
		{
			if (this.IsPlayingStartAnim)
			{
				return;
			}
			this.LevelSequencePlayer.PlaySequencePurely(RogueScoreItem.sequenceNameList[level - 1], false, false, null, null, false);
		}

		// Token: 0x0603CF74 RID: 249716 RVA: 0x00EA7357 File Offset: 0x00EA5557
		private void SetPercent(float percent)
		{
			this.ScoreBgTexture.SetCustomMaterialScalarParameter(RogueScoreItem.filledAmount, percent);
		}

		// Token: 0x0603CF75 RID: 249717 RVA: 0x00EA736A File Offset: 0x00EA556A
		private void PlayUpAnim()
		{
			this.IsPlayingUpAnim = true;
			this.UpAnimStartTime = Time.Instance.Now;
			this.UpEffectCountdown = 100f;
			this.PlayUpEffect(1f);
		}

		// Token: 0x0603CF76 RID: 249718 RVA: 0x00EA7399 File Offset: 0x00EA5599
		private void PlayUpEffect(float param)
		{
			if (this.GlobalShaderCollection != null)
			{
				UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.GameInstance.GetWorld(), this.GlobalShaderCollection, RogueScoreItem.rgbSplitProgress, param);
			}
		}

		// Token: 0x0603CF77 RID: 249719 RVA: 0x00EA73C0 File Offset: 0x00EA55C0
		public override void OnTick(float delta)
		{
			if (base.GetActive())
			{
				this.RogueScoreMachine.Tick(delta);
				if (this.IsPlayingUpAnim)
				{
					double num = Time.Instance.Now - this.UpAnimStartTime;
					if (num >= 600.0)
					{
						num = 600.0;
						this.IsPlayingUpAnim = false;
					}
					double num2;
					if (num < 0.0)
					{
						num2 = num / 0.0;
					}
					else
					{
						num2 = (600.0 - num) / 600.0;
					}
					float currentValue = this.UpAnimCurve.GetCurrentValue((float)num2);
					this.ScoreBgTexture.SetCustomMaterialScalarParameter(RogueScoreItem.globalInt, 0.1f + currentValue * 0.9f);
				}
				if (this.UpEffectCountdown > 0f)
				{
					this.UpEffectCountdown -= delta;
					if (this.UpEffectCountdown <= 0f)
					{
						this.PlayUpEffect(0f);
						return;
					}
					float currentValue2 = this.UpAnimCurve.GetCurrentValue(this.UpEffectCountdown / 100f);
					this.PlayUpEffect(currentValue2);
				}
			}
		}

		// Token: 0x0603CF78 RID: 249720 RVA: 0x00EA74CC File Offset: 0x00EA56CC
		public override bool IsValidScore(int scoreId)
		{
			BattleScoreModel instance = BattleScoreModel.Instance;
			BattleScoreConf? battleScoreConf = (instance != null) ? instance.GetScoreConfig(scoreId, false) : null;
			if (battleScoreConf == null)
			{
				return false;
			}
			int type = battleScoreConf.Value.Type;
			return type == 1 || type == 2 || type == 3 || type == 6;
		}

		// Token: 0x0603CF79 RID: 249721 RVA: 0x00EA7523 File Offset: 0x00EA5723
		public override void ShowScore()
		{
			base.ShowScore();
			this.SetScoreLevelUi(1);
			this.SetPercent(0f);
			base.Show(null);
			UUINiagara scoreNiagara = this.ScoreNiagara;
			if (scoreNiagara == null)
			{
				return;
			}
			scoreNiagara.SetUIActive(true);
		}

		// Token: 0x0603CF7A RID: 249722 RVA: 0x00EA7558 File Offset: 0x00EA5758
		public override void HideScore()
		{
			base.HideScore();
			UUINiagara scoreNiagara = this.ScoreNiagara;
			if (scoreNiagara != null)
			{
				scoreNiagara.SetUIActive(false);
			}
			this.ResetScore();
			RogueScoreMachine rogueScoreMachine = this.RogueScoreMachine;
			if (rogueScoreMachine != null)
			{
				rogueScoreMachine.ResetScore();
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlaySequenceAsync("Close", new CustomPromise<bool>(), false, false, null, false).ContinueWith(delegate()
			{
				if (!base.IsDestroyOrDestroying && !this.IsScoreEnable)
				{
					base.Hide(null);
				}
			}).Forget();
		}

		// Token: 0x0603CF7B RID: 249723 RVA: 0x00EA75D0 File Offset: 0x00EA57D0
		public override void OnShowFirstTime()
		{
			if (this.IsScoreEnable && this.CurScore > 0f)
			{
				this.ShowScore();
			}
		}

		// Token: 0x0603CF7C RID: 249724 RVA: 0x00EA75F0 File Offset: 0x00EA57F0
		private void UpdateScoreConfig(int scoreId, int score)
		{
			BattleScoreConf? scoreConfig = BattleScoreModel.Instance.GetScoreConfig(scoreId, false);
			if (scoreConfig == null)
			{
				return;
			}
			int levelGroupId = scoreConfig.Value.LevelGroupId;
			if (this.CurScoreLevelId != levelGroupId)
			{
				this.CurScoreLevelId = levelGroupId;
				this.CurScoreLevelConfigList = BattleScoreConfig.Instance.GetBattleScoreActionConfigByGroupId(levelGroupId);
				this.UpdateMaxAndMinScore();
			}
			if (this.CurScoreLevelConfigList == null || this.CurScoreLevelConfigList.Count == 0)
			{
				return;
			}
			if (score < this.MinScoreLevelConfig.Value.LowerUpperLimits(0))
			{
				this.CurScoreLevelConfig = null;
				return;
			}
			if (score >= this.MaxScoreLevelConfig.Value.LowerUpperLimits(1))
			{
				this.CurScoreLevelConfig = this.MaxScoreLevelConfig;
				return;
			}
			this.CurScoreLevelConfig = null;
			foreach (BattleScoreLevelConf value in this.CurScoreLevelConfigList)
			{
				if (value.LowerUpperLimitsLength >= 2 && score >= value.LowerUpperLimits(0) && score < value.LowerUpperLimits(1))
				{
					this.CurScoreLevelConfig = new BattleScoreLevelConf?(value);
					break;
				}
			}
		}

		// Token: 0x0603CF7D RID: 249725 RVA: 0x00EA7724 File Offset: 0x00EA5924
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
		}

		// Token: 0x0603CF7E RID: 249726 RVA: 0x00EA77C4 File Offset: 0x00EA59C4
		private void UpdateScoreOffset(int scoreId)
		{
			BattleScoreModel instance = BattleScoreModel.Instance;
			BattleScoreConf? battleScoreConf = (instance != null) ? instance.GetScoreConfig(scoreId, false) : null;
			int? num = (battleScoreConf != null) ? new int?(battleScoreConf.GetValueOrDefault().Type) : null;
			if (num == null)
			{
				BattleScoreConf? battleScoreConfig = BattleScoreConfig.Instance.GetBattleScoreConfig(scoreId);
				num = ((battleScoreConfig != null) ? new int?(battleScoreConfig.GetValueOrDefault().Type) : null);
			}
			if (num == null)
			{
				return;
			}
			FVector2D anchorOffset = new FVector2D();
			if (num.Value == 6)
			{
				IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("ScoreOffsetLevelPlayReport");
				if (intArrayConfig != null && intArrayConfig.Count >= 4)
				{
					if (this.IsMobile)
					{
						anchorOffset.Set((float)intArrayConfig[2], (float)intArrayConfig[3]);
					}
					else
					{
						anchorOffset.Set((float)intArrayConfig[0], (float)intArrayConfig[1]);
					}
				}
			}
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAnchorOffset(anchorOffset);
		}

		// Token: 0x0603CF7F RID: 249727 RVA: 0x00EA78DB File Offset: 0x00EA5ADB
		private void ResetScore()
		{
			this.CurScore = 0f;
			this.UiScoreLevelConfig = null;
			this.CurScoreLevelConfig = null;
			this.CurScoreLevelId = 0;
		}

		// Token: 0x0401FC18 RID: 130072
		private const int UP_ANIM_TIME = 600;

		// Token: 0x0401FC19 RID: 130073
		private const int HALF_UP_ANIM_TIME = 0;

		// Token: 0x0401FC1A RID: 130074
		private const int UP_EFFECT_TIME = 100;

		// Token: 0x0401FC1B RID: 130075
		private const string SHADER_PATH = "/Game/Aki/Render/Shaders/UI/MPC_RGBSplitGlitch_FightScore.MPC_RGBSplitGlitch_FightScore";

		// Token: 0x0401FC1C RID: 130076
		[StaticVariableRuleIgnore]
		private static readonly Stat TickStatsObject = Stat.Create("[BattleView]RogueScoreItem", "", "");

		// Token: 0x0401FC1D RID: 130077
		private static readonly FName filledAmount = new FName("FilledAmount");

		// Token: 0x0401FC1E RID: 130078
		private static readonly FName fillColor = new FName("FillColor");

		// Token: 0x0401FC1F RID: 130079
		private static readonly FName flowColorA = new FName("FlowColorA");

		// Token: 0x0401FC20 RID: 130080
		private static readonly FName flowColorB = new FName("FlowColorB");

		// Token: 0x0401FC21 RID: 130081
		private static readonly FName globalInt = new FName("GlobalInt");

		// Token: 0x0401FC22 RID: 130082
		private static readonly FName rgbSplitProgress = new FName("RGBSplit_Progress");

		// Token: 0x0401FC23 RID: 130083
		[StaticVariableRuleIgnore]
		private static readonly string[] scoreTexturePathList = new string[]
		{
			"/Game/Aki/UI/UIResources/UiFight/Image/T_FightScoreD.T_FightScoreD",
			"/Game/Aki/UI/UIResources/UiFight/Image/T_FightScoreC.T_FightScoreC",
			"/Game/Aki/UI/UIResources/UiFight/Image/T_FightScoreB.T_FightScoreB",
			"/Game/Aki/UI/UIResources/UiFight/Image/T_FightScoreA.T_FightScoreA",
			"/Game/Aki/UI/UIResources/UiFight/Image/T_FightScoreS.T_FightScoreS",
			"/Game/Aki/UI/UIResources/UiFight/Image/T_FightScoreSS.T_FightScoreSS"
		};

		// Token: 0x0401FC24 RID: 130084
		[StaticVariableRuleIgnore]
		private static readonly string[] scoreBgTexturePathList = new string[]
		{
			"/Game/Aki/UI/UIResources/UiFight/Image/T_FightScoreBgD.T_FightScoreBgD",
			"/Game/Aki/UI/UIResources/UiFight/Image/T_FightScoreBgC.T_FightScoreBgC",
			"/Game/Aki/UI/UIResources/UiFight/Image/T_FightScoreBgB.T_FightScoreBgB",
			"/Game/Aki/UI/UIResources/UiFight/Image/T_FightScoreBgA.T_FightScoreBgA",
			"/Game/Aki/UI/UIResources/UiFight/Image/T_FightScoreBgS.T_FightScoreBgS",
			"/Game/Aki/UI/UIResources/UiFight/Image/T_FightScoreBgSS.T_FightScoreBgSS"
		};

		// Token: 0x0401FC25 RID: 130085
		[StaticVariableRuleIgnore]
		private static readonly FLinearColor[] fillColorList = new FLinearColor[]
		{
			new FLinearColor(0.0118f, 0.2588f, 1f, 0.5255f),
			new FLinearColor(0.0118f, 0.2588f, 1f, 0.5255f),
			new FLinearColor(1f, 0.2588f, 0.5961f, 0.5255f),
			new FLinearColor(1f, 0.2588f, 0.5961f, 0.5255f),
			new FLinearColor(1f, 0.5725f, 0.1098f, 0.651f),
			new FLinearColor(1f, 0.5725f, 0.1098f, 0.651f)
		};

		// Token: 0x0401FC26 RID: 130086
		[StaticVariableRuleIgnore]
		private static readonly FLinearColor[] flowColorListA = new FLinearColor[]
		{
			new FLinearColor(0.451f, 0.5922f, 0.949f, 1f),
			new FLinearColor(0.451f, 0.5922f, 0.949f, 1f),
			new FLinearColor(1f, 0.2824f, 0.7098f, 1f),
			new FLinearColor(1f, 0.2824f, 0.7098f, 1f),
			new FLinearColor(1f, 0.8588f, 0.7451f, 1f),
			new FLinearColor(1f, 0.8588f, 0.7451f, 1f)
		};

		// Token: 0x0401FC27 RID: 130087
		[StaticVariableRuleIgnore]
		private static readonly FLinearColor[] flowColorListB = new FLinearColor[]
		{
			new FLinearColor(0.5686f, 0.6196f, 0.702f, 0.0941f),
			new FLinearColor(0.5686f, 0.6196f, 0.702f, 0.0941f),
			new FLinearColor(0.7255f, 0.5451f, 0.5451f, 0.0941f),
			new FLinearColor(0.7255f, 0.5451f, 0.5451f, 0.0941f),
			new FLinearColor(0.7255f, 0.6471f, 0.1882f, 0.0941f),
			new FLinearColor(0.7255f, 0.6471f, 0.1882f, 0.0941f)
		};

		// Token: 0x0401FC28 RID: 130088
		[StaticVariableRuleIgnore]
		private static readonly string[] scoreNiagaraPathList = new string[]
		{
			"/Game/Aki/Effect/UI/Niagaras/RouGe/PingFen/NS_Fx_LGUI_Rouge_CD.NS_Fx_LGUI_Rouge_CD",
			"/Game/Aki/Effect/UI/Niagaras/RouGe/PingFen/NS_Fx_LGUI_Rouge_AB.NS_Fx_LGUI_Rouge_AB",
			"/Game/Aki/Effect/UI/Niagaras/RouGe/PingFen/NS_Fx_LGUI_Rouge_S.NS_Fx_LGUI_Rouge_S",
			"/Game/Aki/Effect/UI/Niagaras/RouGe/PingFen/NS_Fx_LGUI_Rouge_S02.NS_Fx_LGUI_Rouge_S02"
		};

		// Token: 0x0401FC29 RID: 130089
		[StaticVariableRuleIgnore]
		private static readonly int[] scoreNiagaraIndexList = new int[]
		{
			0,
			0,
			1,
			1,
			2,
			3
		};

		// Token: 0x0401FC2A RID: 130090
		[StaticVariableRuleIgnore]
		private static readonly string[] sequenceNameList = new string[]
		{
			"StartD",
			"StartC",
			"StartB",
			"StartA",
			"StartS",
			"StartSS"
		};

		// Token: 0x0401FC2B RID: 130091
		[StaticVariableRuleIgnore]
		private static readonly string[] musicStateList = new string[]
		{
			"none",
			"d",
			"c",
			"b",
			"a",
			"s",
			"ss"
		};

		// Token: 0x0401FC2C RID: 130092
		private float CurScore;

		// Token: 0x0401FC2D RID: 130093
		private int CurScoreLevelId;

		// Token: 0x0401FC2E RID: 130094
		private BattleScoreLevelConf? CurScoreLevelConfig;

		// Token: 0x0401FC2F RID: 130095
		[Nullable(2)]
		private IReadOnlyList<BattleScoreLevelConf> CurScoreLevelConfigList;

		// Token: 0x0401FC30 RID: 130096
		private BattleScoreLevelConf? UiScoreLevelConfig;

		// Token: 0x0401FC31 RID: 130097
		private BattleScoreLevelConf? MinScoreLevelConfig;

		// Token: 0x0401FC32 RID: 130098
		private BattleScoreLevelConf? MaxScoreLevelConfig;

		// Token: 0x0401FC33 RID: 130099
		private readonly RogueScoreMachine RogueScoreMachine = new RogueScoreMachine();

		// Token: 0x0401FC34 RID: 130100
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401FC35 RID: 130101
		[Nullable(2)]
		private UUITexture ScoreTexture;

		// Token: 0x0401FC36 RID: 130102
		[Nullable(2)]
		private UUITextureTransitionComponent ScoreTextureTransitionComp;

		// Token: 0x0401FC37 RID: 130103
		[Nullable(2)]
		private UUITexture ScoreBgTexture;

		// Token: 0x0401FC38 RID: 130104
		[Nullable(2)]
		private UUITextureTransitionComponent ScoreBgTextureTransitionComp;

		// Token: 0x0401FC39 RID: 130105
		[Nullable(2)]
		private UUINiagara ScoreNiagara;

		// Token: 0x0401FC3A RID: 130106
		private int CurScoreNiagaraIndex = -1;

		// Token: 0x0401FC3B RID: 130107
		private readonly List<UUIItem> NodeList = new List<UUIItem>();

		// Token: 0x0401FC3C RID: 130108
		private int CurNodeIndex = -1;

		// Token: 0x0401FC3D RID: 130109
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private UTexture[] ScoreTextureDataList = Array.Empty<UTexture>();

		// Token: 0x0401FC3E RID: 130110
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private UTexture[] ScoreBgTextureDataList = Array.Empty<UTexture>();

		// Token: 0x0401FC3F RID: 130111
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private UNiagaraSystem[] ScoreNiagaraList = Array.Empty<UNiagaraSystem>();

		// Token: 0x0401FC40 RID: 130112
		private bool IsPlayingStartAnim;

		// Token: 0x0401FC41 RID: 130113
		private bool IsPlayingUpAnim;

		// Token: 0x0401FC42 RID: 130114
		private readonly SquaredCurve UpAnimCurve = CurveUtils.DefaultPara;

		// Token: 0x0401FC43 RID: 130115
		private double UpAnimStartTime;

		// Token: 0x0401FC44 RID: 130116
		[Nullable(2)]
		private UMaterialParameterCollection GlobalShaderCollection;

		// Token: 0x0401FC45 RID: 130117
		private float UpEffectCountdown = -1f;

		// Token: 0x0401FC46 RID: 130118
		private bool IsMobile;

		// Token: 0x0200C0A7 RID: 49319
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A225 RID: 238117
			ScoreTexture,
			// Token: 0x0403A226 RID: 238118
			ScoreBgTexture,
			// Token: 0x0403A227 RID: 238119
			ScoreNiagara,
			// Token: 0x0403A228 RID: 238120
			NodeD,
			// Token: 0x0403A229 RID: 238121
			NodeC,
			// Token: 0x0403A22A RID: 238122
			NodeB,
			// Token: 0x0403A22B RID: 238123
			NodeA,
			// Token: 0x0403A22C RID: 238124
			NodeS,
			// Token: 0x0403A22D RID: 238125
			NodeSS
		}
	}
}
