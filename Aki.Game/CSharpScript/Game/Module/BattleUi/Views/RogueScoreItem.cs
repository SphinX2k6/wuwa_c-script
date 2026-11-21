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
	// Token: 0x02004D9E RID: 19870
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueScoreItem : BaseScoreItem
	{
		// Token: 0x06031ED9 RID: 204505 RVA: 0x00DF79A4 File Offset: 0x00DF5BA4
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

		// Token: 0x06031EDA RID: 204506 RVA: 0x00DF7B08 File Offset: 0x00DF5D08
		protected override UniTask OnCreateAsync()
		{
			RogueScoreItem.<OnCreateAsync>d__49 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<RogueScoreItem.<OnCreateAsync>d__49>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031EDB RID: 204507 RVA: 0x00DF7B4C File Offset: 0x00DF5D4C
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

		// Token: 0x06031EDC RID: 204508 RVA: 0x00DF7BA0 File Offset: 0x00DF5DA0
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

		// Token: 0x06031EDD RID: 204509 RVA: 0x00DF7BF4 File Offset: 0x00DF5DF4
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

		// Token: 0x06031EDE RID: 204510 RVA: 0x00DF7C40 File Offset: 0x00DF5E40
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

		// Token: 0x06031EDF RID: 204511 RVA: 0x00DF7DE8 File Offset: 0x00DF5FE8
		protected override void OnBeforeDestroy()
		{
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
			base.OnBeforeDestroy();
		}

		// Token: 0x06031EE0 RID: 204512 RVA: 0x00DF7E04 File Offset: 0x00DF6004
		protected override UniTask OnShowAsyncImplement()
		{
			RogueScoreItem.<OnShowAsyncImplement>d__55 <OnShowAsyncImplement>d__;
			<OnShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplement>d__.<>4__this = this;
			<OnShowAsyncImplement>d__.<>1__state = -1;
			<OnShowAsyncImplement>d__.<>t__builder.Start<RogueScoreItem.<OnShowAsyncImplement>d__55>(ref <OnShowAsyncImplement>d__);
			return <OnShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06031EE1 RID: 204513 RVA: 0x00DF7E47 File Offset: 0x00DF6047
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

		// Token: 0x06031EE2 RID: 204514 RVA: 0x00DF7E80 File Offset: 0x00DF6080
		public void UpdateScore(int score, BattleScoreLevelConf? scoreLevelConfig)
		{
			this.RogueScoreMachine.UpdateTargetScore((float)score, scoreLevelConfig);
		}

		// Token: 0x06031EE3 RID: 204515 RVA: 0x00DF7E90 File Offset: 0x00DF6090
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

		// Token: 0x06031EE4 RID: 204516 RVA: 0x00DF8021 File Offset: 0x00DF6221
		private void SetScoreLevelUi(int level)
		{
			this.SetScoreTexture(level);
			this.SetScoreBgTexture(level);
			this.SetScoreNiagara(level);
			this.SetNode(level);
		}

		// Token: 0x06031EE5 RID: 204517 RVA: 0x00DF8040 File Offset: 0x00DF6240
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

		// Token: 0x06031EE6 RID: 204518 RVA: 0x00DF8084 File Offset: 0x00DF6284
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

		// Token: 0x06031EE7 RID: 204519 RVA: 0x00DF811C File Offset: 0x00DF631C
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

		// Token: 0x06031EE8 RID: 204520 RVA: 0x00DF8168 File Offset: 0x00DF6368
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

		// Token: 0x06031EE9 RID: 204521 RVA: 0x00DF81C0 File Offset: 0x00DF63C0
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

		// Token: 0x06031EEA RID: 204522 RVA: 0x00DF81FC File Offset: 0x00DF63FC
		private void PlayChangeAnim(int level)
		{
			if (this.IsPlayingStartAnim)
			{
				return;
			}
			this.LevelSequencePlayer.PlaySequencePurely(RogueScoreItem.sequenceNameList[level - 1], false, false, null, null, false);
		}

		// Token: 0x06031EEB RID: 204523 RVA: 0x00DF8233 File Offset: 0x00DF6433
		private void SetPercent(float percent)
		{
			this.ScoreBgTexture.SetCustomMaterialScalarParameter(RogueScoreItem.filledAmount, percent);
		}

		// Token: 0x06031EEC RID: 204524 RVA: 0x00DF8246 File Offset: 0x00DF6446
		private void PlayUpAnim()
		{
			this.IsPlayingUpAnim = true;
			this.UpAnimStartTime = Time.Instance.Now;
			this.UpEffectCountdown = 100f;
			this.PlayUpEffect(1f);
		}

		// Token: 0x06031EED RID: 204525 RVA: 0x00DF8275 File Offset: 0x00DF6475
		private void PlayUpEffect(float param)
		{
			if (this.GlobalShaderCollection != null)
			{
				UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.GameInstance.GetWorld(), this.GlobalShaderCollection, RogueScoreItem.rgbSplitProgress, param);
			}
		}

		// Token: 0x06031EEE RID: 204526 RVA: 0x00DF829C File Offset: 0x00DF649C
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

		// Token: 0x06031EEF RID: 204527 RVA: 0x00DF83A8 File Offset: 0x00DF65A8
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

		// Token: 0x06031EF0 RID: 204528 RVA: 0x00DF83FF File Offset: 0x00DF65FF
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

		// Token: 0x06031EF1 RID: 204529 RVA: 0x00DF8434 File Offset: 0x00DF6634
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

		// Token: 0x06031EF2 RID: 204530 RVA: 0x00DF84AC File Offset: 0x00DF66AC
		public override void OnShowFirstTime()
		{
			if (this.IsScoreEnable && this.CurScore > 0f)
			{
				this.ShowScore();
			}
		}

		// Token: 0x06031EF3 RID: 204531 RVA: 0x00DF84CC File Offset: 0x00DF66CC
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

		// Token: 0x06031EF4 RID: 204532 RVA: 0x00DF8600 File Offset: 0x00DF6800
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

		// Token: 0x06031EF5 RID: 204533 RVA: 0x00DF86A0 File Offset: 0x00DF68A0
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

		// Token: 0x06031EF6 RID: 204534 RVA: 0x00DF87B7 File Offset: 0x00DF69B7
		private void ResetScore()
		{
			this.CurScore = 0f;
			this.UiScoreLevelConfig = null;
			this.CurScoreLevelConfig = null;
			this.CurScoreLevelId = 0;
		}

		// Token: 0x0401A6D5 RID: 108245
		private const int UP_ANIM_TIME = 600;

		// Token: 0x0401A6D6 RID: 108246
		private const int HALF_UP_ANIM_TIME = 0;

		// Token: 0x0401A6D7 RID: 108247
		private const int UP_EFFECT_TIME = 100;

		// Token: 0x0401A6D8 RID: 108248
		private const string SHADER_PATH = "/Game/Aki/Render/Shaders/UI/MPC_RGBSplitGlitch_FightScore.MPC_RGBSplitGlitch_FightScore";

		// Token: 0x0401A6D9 RID: 108249
		[StaticVariableRuleIgnore]
		private static readonly Stat TickStatsObject = Stat.Create("[BattleView]RogueScoreItem", "", "");

		// Token: 0x0401A6DA RID: 108250
		private static readonly FName filledAmount = new FName("FilledAmount");

		// Token: 0x0401A6DB RID: 108251
		private static readonly FName fillColor = new FName("FillColor");

		// Token: 0x0401A6DC RID: 108252
		private static readonly FName flowColorA = new FName("FlowColorA");

		// Token: 0x0401A6DD RID: 108253
		private static readonly FName flowColorB = new FName("FlowColorB");

		// Token: 0x0401A6DE RID: 108254
		private static readonly FName globalInt = new FName("GlobalInt");

		// Token: 0x0401A6DF RID: 108255
		private static readonly FName rgbSplitProgress = new FName("RGBSplit_Progress");

		// Token: 0x0401A6E0 RID: 108256
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

		// Token: 0x0401A6E1 RID: 108257
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

		// Token: 0x0401A6E2 RID: 108258
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

		// Token: 0x0401A6E3 RID: 108259
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

		// Token: 0x0401A6E4 RID: 108260
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

		// Token: 0x0401A6E5 RID: 108261
		[StaticVariableRuleIgnore]
		private static readonly string[] scoreNiagaraPathList = new string[]
		{
			"/Game/Aki/Effect/UI/Niagaras/RouGe/PingFen/NS_Fx_LGUI_Rouge_CD.NS_Fx_LGUI_Rouge_CD",
			"/Game/Aki/Effect/UI/Niagaras/RouGe/PingFen/NS_Fx_LGUI_Rouge_AB.NS_Fx_LGUI_Rouge_AB",
			"/Game/Aki/Effect/UI/Niagaras/RouGe/PingFen/NS_Fx_LGUI_Rouge_S.NS_Fx_LGUI_Rouge_S",
			"/Game/Aki/Effect/UI/Niagaras/RouGe/PingFen/NS_Fx_LGUI_Rouge_S02.NS_Fx_LGUI_Rouge_S02"
		};

		// Token: 0x0401A6E6 RID: 108262
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

		// Token: 0x0401A6E7 RID: 108263
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

		// Token: 0x0401A6E8 RID: 108264
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

		// Token: 0x0401A6E9 RID: 108265
		private float CurScore;

		// Token: 0x0401A6EA RID: 108266
		private int CurScoreLevelId;

		// Token: 0x0401A6EB RID: 108267
		private BattleScoreLevelConf? CurScoreLevelConfig;

		// Token: 0x0401A6EC RID: 108268
		[Nullable(2)]
		private IReadOnlyList<BattleScoreLevelConf> CurScoreLevelConfigList;

		// Token: 0x0401A6ED RID: 108269
		private BattleScoreLevelConf? UiScoreLevelConfig;

		// Token: 0x0401A6EE RID: 108270
		private BattleScoreLevelConf? MinScoreLevelConfig;

		// Token: 0x0401A6EF RID: 108271
		private BattleScoreLevelConf? MaxScoreLevelConfig;

		// Token: 0x0401A6F0 RID: 108272
		private readonly RogueScoreMachine RogueScoreMachine = new RogueScoreMachine();

		// Token: 0x0401A6F1 RID: 108273
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A6F2 RID: 108274
		[Nullable(2)]
		private UUITexture ScoreTexture;

		// Token: 0x0401A6F3 RID: 108275
		[Nullable(2)]
		private UUITextureTransitionComponent ScoreTextureTransitionComp;

		// Token: 0x0401A6F4 RID: 108276
		[Nullable(2)]
		private UUITexture ScoreBgTexture;

		// Token: 0x0401A6F5 RID: 108277
		[Nullable(2)]
		private UUITextureTransitionComponent ScoreBgTextureTransitionComp;

		// Token: 0x0401A6F6 RID: 108278
		[Nullable(2)]
		private UUINiagara ScoreNiagara;

		// Token: 0x0401A6F7 RID: 108279
		private int CurScoreNiagaraIndex = -1;

		// Token: 0x0401A6F8 RID: 108280
		private readonly List<UUIItem> NodeList = new List<UUIItem>();

		// Token: 0x0401A6F9 RID: 108281
		private int CurNodeIndex = -1;

		// Token: 0x0401A6FA RID: 108282
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private UTexture[] ScoreTextureDataList = Array.Empty<UTexture>();

		// Token: 0x0401A6FB RID: 108283
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private UTexture[] ScoreBgTextureDataList = Array.Empty<UTexture>();

		// Token: 0x0401A6FC RID: 108284
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private UNiagaraSystem[] ScoreNiagaraList = Array.Empty<UNiagaraSystem>();

		// Token: 0x0401A6FD RID: 108285
		private bool IsPlayingStartAnim;

		// Token: 0x0401A6FE RID: 108286
		private bool IsPlayingUpAnim;

		// Token: 0x0401A6FF RID: 108287
		private readonly SquaredCurve UpAnimCurve = CurveUtils.DefaultPara;

		// Token: 0x0401A700 RID: 108288
		private double UpAnimStartTime;

		// Token: 0x0401A701 RID: 108289
		[Nullable(2)]
		private UMaterialParameterCollection GlobalShaderCollection;

		// Token: 0x0401A702 RID: 108290
		private float UpEffectCountdown = -1f;

		// Token: 0x0401A703 RID: 108291
		private bool IsMobile;

		// Token: 0x0200AAB0 RID: 43696
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034BF7 RID: 216055
			ScoreTexture,
			// Token: 0x04034BF8 RID: 216056
			ScoreBgTexture,
			// Token: 0x04034BF9 RID: 216057
			ScoreNiagara,
			// Token: 0x04034BFA RID: 216058
			NodeD,
			// Token: 0x04034BFB RID: 216059
			NodeC,
			// Token: 0x04034BFC RID: 216060
			NodeB,
			// Token: 0x04034BFD RID: 216061
			NodeA,
			// Token: 0x04034BFE RID: 216062
			NodeS,
			// Token: 0x04034BFF RID: 216063
			NodeSS
		}
	}
}
