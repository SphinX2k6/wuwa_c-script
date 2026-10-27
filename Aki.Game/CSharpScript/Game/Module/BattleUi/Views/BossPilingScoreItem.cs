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
	// Token: 0x02005DB6 RID: 23990
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingScoreItem : BaseScoreItem
	{
		// Token: 0x0603CF14 RID: 249620 RVA: 0x00EA4834 File Offset: 0x00EA2A34
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CF15 RID: 249621 RVA: 0x00EA4900 File Offset: 0x00EA2B00
		protected override UniTask OnCreateAsync()
		{
			BossPilingScoreItem.<OnCreateAsync>d__19 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<BossPilingScoreItem.<OnCreateAsync>d__19>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CF16 RID: 249622 RVA: 0x00EA4944 File Offset: 0x00EA2B44
		private UniTask LoadResource(string path, int index, [Nullable(new byte[]
		{
			1,
			2
		})] ULGUISpriteData_BaseObject[] spriteDataList)
		{
			CustomPromise promise = new CustomPromise();
			ResourceSystem.Instance.LoadAsync<ULGUISpriteData_BaseObject>(path, delegate([Nullable(2)] ULGUISpriteData_BaseObject res, string _)
			{
				spriteDataList[index] = res;
				promise.SetResult();
			}, 103, "js_undefined");
			return promise.Promise;
		}

		// Token: 0x0603CF17 RID: 249623 RVA: 0x00EA499C File Offset: 0x00EA2B9C
		protected override void OnStart()
		{
			base.OnStart();
			this.BarSprite = base.GetSprite(0);
			this.BarBgSprite = base.GetSprite(1);
			this.BarWhite = base.GetTexture(2);
			this.IconSprite = base.GetSprite(3);
			this.ValueText = base.GetText(4);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnPlaySequenceEvent));
			this.SetPercent(0f);
			this.InstScoreMachine.SetUpdateCallback(new Action<float, BattleScoreLevelConf?>(this.OnUpdateScore), new Action(this.PlayUpAnim));
			this.InitScore();
		}

		// Token: 0x0603CF18 RID: 249624 RVA: 0x00EA4A51 File Offset: 0x00EA2C51
		protected override void OnBeforeDestroy()
		{
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
			this.RemoveEvent();
			this.RemoveTimer();
			base.OnBeforeDestroy();
		}

		// Token: 0x0603CF19 RID: 249625 RVA: 0x00EA4A78 File Offset: 0x00EA2C78
		protected override UniTask OnShowAsyncImplementImplement()
		{
			BossPilingScoreItem.<OnShowAsyncImplementImplement>d__23 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<BossPilingScoreItem.<OnShowAsyncImplementImplement>d__23>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603CF1A RID: 249626 RVA: 0x00EA4ABC File Offset: 0x00EA2CBC
		protected override UniTask OnHideAsyncImplementImplement()
		{
			BossPilingScoreItem.<OnHideAsyncImplementImplement>d__24 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<BossPilingScoreItem.<OnHideAsyncImplementImplement>d__24>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603CF1B RID: 249627 RVA: 0x00EA4B00 File Offset: 0x00EA2D00
		[NullableContext(0)]
		private ValueTuple<int, int> GetValidScoreId()
		{
			foreach (KeyValuePair<int, int> keyValuePair in BattleScoreModel.Instance.GetScoreMap())
			{
				int num;
				int num2;
				keyValuePair.Deconstruct(out num, out num2);
				int num3 = num;
				int num4 = num2;
				if (num4 > 0 && this.IsValidScore(num3))
				{
					return new ValueTuple<int, int>(num3, num4);
				}
			}
			foreach (KeyValuePair<int, bool> keyValuePair2 in BattleScoreModel.Instance.GetScoreEnableMap())
			{
				int num2;
				bool flag;
				keyValuePair2.Deconstruct(out num2, out flag);
				int num5 = num2;
				if (flag && this.IsValidScore(num5))
				{
					return new ValueTuple<int, int>(num5, 0);
				}
			}
			return new ValueTuple<int, int>(0, 0);
		}

		// Token: 0x0603CF1C RID: 249628 RVA: 0x00EA4BE8 File Offset: 0x00EA2DE8
		private void InitScore()
		{
			ValueTuple<int, int> validScoreId = this.GetValidScoreId();
			int item = validScoreId.Item1;
			int item2 = validScoreId.Item2;
			if (item != 0)
			{
				this.OnBattleScoreChanged(item, item2);
			}
			if (item == 0)
			{
				LguiUtil.Instance.SetLocalTextNew(this.ValueText, "BossPilingActivity_Dungeon20", new <>z__ReadOnlySingleElementList<object>("0"));
				return;
			}
			if (GameModeModel.Instance.Loading)
			{
				this.ShowScoreOnWorldDone();
				return;
			}
			this.ShowScore();
			this.OnTick(0f);
		}

		// Token: 0x0603CF1D RID: 249629 RVA: 0x00EA4C5A File Offset: 0x00EA2E5A
		private void RemoveTimer()
		{
			if (this.TimeoutHd != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimeoutHd);
				this.TimeoutHd = null;
			}
		}

		// Token: 0x0603CF1E RID: 249630 RVA: 0x00EA4C7C File Offset: 0x00EA2E7C
		private void ShowScoreOnWorldDone()
		{
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
			this.TimeoutHd = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.RemoveTimer();
				this.OnWorldDoneAndCloseLoading();
			}, 5000f, null, null, true, 1f);
		}

		// Token: 0x0603CF1F RID: 249631 RVA: 0x00EA4CCE File Offset: 0x00EA2ECE
		private void OnWorldDoneAndCloseLoading()
		{
			this.RemoveEvent();
			this.RemoveTimer();
			if (this.GetValidScoreId().Item1 != 0 && !this.RootItem.IsUIActiveSelf())
			{
				this.ShowScore();
				this.OnTick(0f);
			}
		}

		// Token: 0x0603CF20 RID: 249632 RVA: 0x00EA4D07 File Offset: 0x00EA2F07
		private void RemoveEvent()
		{
			if (EventSystem.Instance.Has(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading)))
			{
				EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
			}
		}

		// Token: 0x0603CF21 RID: 249633 RVA: 0x00EA4D42 File Offset: 0x00EA2F42
		protected override void OnBattleScoreChanged(int scoreId, int score)
		{
			if (base.IsHideOrHiding)
			{
				this.ShowScore();
			}
			this.UpdateScoreConfig(scoreId, (float)score);
			if (this.NextScoreLevelConfig != null)
			{
				this.UpdateScoreValue((float)score, this.NextScoreLevelConfig);
				base.SetUiActive(true);
			}
		}

		// Token: 0x0603CF22 RID: 249634 RVA: 0x00EA4D80 File Offset: 0x00EA2F80
		private void UpdateScoreValue(float score, BattleScoreLevelConf? scoreLevelConfig)
		{
			this.InstScoreMachine.UpdateTargetScore(score, scoreLevelConfig);
			if (this.IsMaxScore(score))
			{
				LguiUtil.Instance.SetLocalTextNew(this.ValueText, "BossPilingActivity_Dungeon20", new <>z__ReadOnlySingleElementList<object>(score));
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(this.ValueText, "BossPilingActivity_Dungeon19", new <>z__ReadOnlyArray<object>(new object[]
			{
				score,
				this.GetNextPhaseScore(scoreLevelConfig)
			}));
		}

		// Token: 0x0603CF23 RID: 249635 RVA: 0x00EA4DFC File Offset: 0x00EA2FFC
		private bool IsMaxScore(float score)
		{
			return score >= this.ScoreMaxValue;
		}

		// Token: 0x0603CF24 RID: 249636 RVA: 0x00EA4E0C File Offset: 0x00EA300C
		private float GetNextPhaseScore(BattleScoreLevelConf? lvCfg)
		{
			if (lvCfg != null && lvCfg.Value.Level > 0 && lvCfg.Value.Level - 1 < this.ScorePhaseValues.Count)
			{
				return this.ScorePhaseValues[lvCfg.Value.Level - 1];
			}
			return 0f;
		}

		// Token: 0x0603CF25 RID: 249637 RVA: 0x00EA4E74 File Offset: 0x00EA3074
		private void OnUpdateScore(float value, BattleScoreLevelConf? scoreCfg)
		{
			if (this.CurScoreValue == value)
			{
				return;
			}
			this.CurScoreValue = value;
			int? num = (this.LastScoreLevelConfig != null) ? new int?(this.LastScoreLevelConfig.GetValueOrDefault().Id) : null;
			int? num2 = (scoreCfg != null) ? new int?(scoreCfg.GetValueOrDefault().Id) : null;
			if (!(num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null)) && scoreCfg != null && this.LastScoreLevelConfig != null)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.PlayLevelSequenceByName("GradeChange", false, null, false);
				}
				if (scoreCfg.Value.Level == this.ScoreMaxLevel)
				{
					this.IsPlayingMaxLevel = true;
					LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
					if (levelSequencePlayer2 != null)
					{
						levelSequencePlayer2.PlayLevelSequenceByName("SS_In", false, null, false);
					}
				}
				else if (this.IsPlayingMaxLevel)
				{
					this.IsPlayingMaxLevel = false;
					LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
					if (levelSequencePlayer3 != null)
					{
						levelSequencePlayer3.PlayLevelSequenceByName("SS_Out", false, null, false);
					}
				}
				this.LastScoreLevelConfig = scoreCfg;
			}
			if (this.IsMaxScore(value))
			{
				this.SetPercent(1f);
				return;
			}
			if (scoreCfg != null)
			{
				int num3 = scoreCfg.Value.LowerUpperLimits(0);
				int num4 = scoreCfg.Value.LowerUpperLimits(1);
				float num5;
				if (num4 == num3)
				{
					num5 = 1f;
				}
				else
				{
					num5 = (value - (float)num3) / (float)(num4 - num3);
					num5 = Math.Min(num5, 1f);
				}
				this.SetPercent(num5);
			}
		}

		// Token: 0x0603CF26 RID: 249638 RVA: 0x00EA503C File Offset: 0x00EA323C
		private void SetLevelSprite(int level)
		{
			ULGUISpriteData_BaseObject ulguispriteData_BaseObject = this.BarSpriteDataList[level - 1];
			if (ulguispriteData_BaseObject != null && ulguispriteData_BaseObject.IsValid())
			{
				this.IconSprite.SetSprite(ulguispriteData_BaseObject, true);
			}
		}

		// Token: 0x0603CF27 RID: 249639 RVA: 0x00EA506C File Offset: 0x00EA326C
		private void OnPlaySequenceEvent(string sequenceName, string eventName)
		{
			if (eventName == "Sequence_Grade_Change" && this.NextScoreLevelConfig != null)
			{
				this.SetLevelSprite(this.NextScoreLevelConfig.Value.Level);
			}
		}

		// Token: 0x0603CF28 RID: 249640 RVA: 0x00EA50AC File Offset: 0x00EA32AC
		private void PlayUpAnim()
		{
		}

		// Token: 0x0603CF29 RID: 249641 RVA: 0x00EA50B0 File Offset: 0x00EA32B0
		private void SetPercent(float percent)
		{
			this.BarSprite.SetFillAmount(percent);
			this.BarBgSprite.SetFillAmount(percent);
			this.P1Color.A = MathUtils.Instance.Lerp(0.25f, -0.75f, percent);
			this.BarWhite.SetCustomMaterialVectorParameter(BossPilingScoreItem.P1Name, this.P1Color);
			float num = (percent > 0.5f) ? 0.5f : 0f;
			if (num != this.LastMaskValue)
			{
				this.BarWhite.SetCustomMaterialScalarParameter(BossPilingScoreItem.P2Name, num);
				this.LastMaskValue = num;
			}
		}

		// Token: 0x0603CF2A RID: 249642 RVA: 0x00EA5141 File Offset: 0x00EA3341
		public override void OnTick(float delta)
		{
			this.InstScoreMachine.Tick(delta);
		}

		// Token: 0x0603CF2B RID: 249643 RVA: 0x00EA5150 File Offset: 0x00EA3350
		public override bool IsValidScore(int scoreId)
		{
			BattleScoreConf? scoreConfig = BattleScoreModel.Instance.GetScoreConfig(scoreId, false);
			return scoreConfig != null && scoreConfig.Value.Type == 10;
		}

		// Token: 0x0603CF2C RID: 249644 RVA: 0x00EA5189 File Offset: 0x00EA3389
		public override void ShowScore()
		{
			base.ShowScore();
			this.SetLevelSprite(1);
			this.SetPercent(0f);
			base.Show(null);
		}

		// Token: 0x0603CF2D RID: 249645 RVA: 0x00EA51AA File Offset: 0x00EA33AA
		public override void HideScore()
		{
			base.HideScore();
			this.ResetScore();
			RogueScoreMachine instScoreMachine = this.InstScoreMachine;
			if (instScoreMachine != null)
			{
				instScoreMachine.ResetScore();
			}
			base.Hide(null);
		}

		// Token: 0x0603CF2E RID: 249646 RVA: 0x00EA51D0 File Offset: 0x00EA33D0
		public override void OnShowFirstTime()
		{
			if (this.IsScoreEnable && this.CurScoreValue > 0f)
			{
				this.ShowScore();
			}
		}

		// Token: 0x0603CF2F RID: 249647 RVA: 0x00EA51F0 File Offset: 0x00EA33F0
		private void UpdateScoreConfig(int scoreId, float score)
		{
			BattleScoreConf? scoreConfig = BattleScoreModel.Instance.GetScoreConfig(scoreId, false);
			if (scoreConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.HWR;
				string message = "BossPilingScoreItem 没有找到分数配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("scoreId", scoreId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			int levelGroupId = scoreConfig.Value.LevelGroupId;
			if (this.CurScoreGroupId != levelGroupId)
			{
				this.CurScoreGroupId = levelGroupId;
				IReadOnlyList<BattleScoreLevelConf> battleScoreActionConfigByGroupId = BattleScoreConfig.Instance.GetBattleScoreActionConfigByGroupId(levelGroupId);
				if (battleScoreActionConfigByGroupId == null || battleScoreActionConfigByGroupId.Count == 0)
				{
					return;
				}
				this.ScoreLevelConfigList = battleScoreActionConfigByGroupId;
				BattleScoreLevelConf? scoreLevelConfigMax = null;
				this.ScorePhaseValues.Clear();
				foreach (BattleScoreLevelConf value in battleScoreActionConfigByGroupId)
				{
					this.ScorePhaseValues.Add((float)value.LowerUpperLimits(1));
					if (scoreLevelConfigMax == null || scoreLevelConfigMax.Value.LowerUpperLimits(0) < value.LowerUpperLimits(0))
					{
						scoreLevelConfigMax = new BattleScoreLevelConf?(value);
					}
				}
				this.ScorePhaseValues.Sort((float a, float b) => a.CompareTo(b));
				this.ScoreLevelConfigMax = scoreLevelConfigMax;
				if (scoreLevelConfigMax != null)
				{
					this.ScoreMaxValue = (float)scoreLevelConfigMax.Value.LowerUpperLimits(0);
					this.ScoreMaxLevel = scoreLevelConfigMax.Value.Level;
				}
			}
			if (this.ScoreLevelConfigList != null && this.ScoreLevelConfigList.Count > 0)
			{
				foreach (BattleScoreLevelConf value2 in this.ScoreLevelConfigList)
				{
					if (score >= (float)value2.LowerUpperLimits(0) && score < (float)value2.LowerUpperLimits(1))
					{
						this.NextScoreLevelConfig = new BattleScoreLevelConf?(value2);
						break;
					}
				}
				if (this.ScoreLevelConfigMax != null && score >= (float)this.ScoreLevelConfigMax.Value.LowerUpperLimits(1))
				{
					this.NextScoreLevelConfig = this.ScoreLevelConfigMax;
				}
			}
		}

		// Token: 0x0603CF30 RID: 249648 RVA: 0x00EA5430 File Offset: 0x00EA3630
		private void ResetScore()
		{
			this.CurScoreValue = -1f;
			this.CurScoreGroupId = -1;
			this.NextScoreLevelConfig = null;
			this.LastScoreLevelConfig = null;
		}

		// Token: 0x0401FBCE RID: 129998
		[StaticVariableRuleIgnore]
		private static readonly string[] scoreSpritePathList = new string[]
		{
			"/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity33/BossPiling/Game/SP_BossPilingGameScoreBGrey.SP_BossPilingGameScoreBGrey",
			"/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity33/BossPiling/Game/SP_BossPilingGameScoreB.SP_BossPilingGameScoreB",
			"/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity33/BossPiling/Game/SP_BossPilingGameScoreA.SP_BossPilingGameScoreA",
			"/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity33/BossPiling/Game/SP_BossPilingGameScoreS.SP_BossPilingGameScoreS",
			"/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity33/BossPiling/Game/SP_BossPilingGameScoreSS.SP_BossPilingGameScoreSS"
		};

		// Token: 0x0401FBCF RID: 129999
		private float CurScoreValue = -1f;

		// Token: 0x0401FBD0 RID: 130000
		private int CurScoreGroupId = -1;

		// Token: 0x0401FBD1 RID: 130001
		private BattleScoreLevelConf? LastScoreLevelConfig;

		// Token: 0x0401FBD2 RID: 130002
		private BattleScoreLevelConf? NextScoreLevelConfig;

		// Token: 0x0401FBD3 RID: 130003
		private readonly List<float> ScorePhaseValues = new List<float>();

		// Token: 0x0401FBD4 RID: 130004
		private float ScoreMaxValue;

		// Token: 0x0401FBD5 RID: 130005
		private int ScoreMaxLevel;

		// Token: 0x0401FBD6 RID: 130006
		private RogueScoreMachine InstScoreMachine = new RogueScoreMachine();

		// Token: 0x0401FBD7 RID: 130007
		private UUISprite BarSprite;

		// Token: 0x0401FBD8 RID: 130008
		private UUISprite BarBgSprite;

		// Token: 0x0401FBD9 RID: 130009
		private UUITexture BarWhite;

		// Token: 0x0401FBDA RID: 130010
		private UUISprite IconSprite;

		// Token: 0x0401FBDB RID: 130011
		private UUIText ValueText;

		// Token: 0x0401FBDC RID: 130012
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly ULGUISpriteData_BaseObject[] BarSpriteDataList = new ULGUISpriteData_BaseObject[BossPilingScoreItem.scoreSpritePathList.Length];

		// Token: 0x0401FBDD RID: 130013
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401FBDE RID: 130014
		private bool IsPlayingMaxLevel;

		// Token: 0x0401FBDF RID: 130015
		[Nullable(2)]
		private TimerHandle TimeoutHd;

		// Token: 0x0401FBE0 RID: 130016
		private static readonly FName P1Name = new FName("MainTexRotate");

		// Token: 0x0401FBE1 RID: 130017
		private static readonly FName P2Name = new FName("MaskAngle");

		// Token: 0x0401FBE2 RID: 130018
		private FLinearColor P1Color = new FLinearColor(0.5f, 0.5f, 0.5f, 1f);

		// Token: 0x0401FBE3 RID: 130019
		private float LastMaskValue = -1f;

		// Token: 0x0401FBE4 RID: 130020
		[Nullable(2)]
		private IReadOnlyList<BattleScoreLevelConf> ScoreLevelConfigList;

		// Token: 0x0401FBE5 RID: 130021
		private BattleScoreLevelConf? ScoreLevelConfigMax;

		// Token: 0x0200C097 RID: 49303
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A1E5 RID: 238053
			SprProgress,
			// Token: 0x0403A1E6 RID: 238054
			SprProgressLight,
			// Token: 0x0403A1E7 RID: 238055
			TextureWhite,
			// Token: 0x0403A1E8 RID: 238056
			SprScoreIcon,
			// Token: 0x0403A1E9 RID: 238057
			ValueText
		}
	}
}
