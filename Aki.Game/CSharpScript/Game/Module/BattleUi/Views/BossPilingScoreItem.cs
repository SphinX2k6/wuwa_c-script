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
	// Token: 0x02004D9A RID: 19866
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingScoreItem : BaseScoreItem
	{
		// Token: 0x06031E8B RID: 204427 RVA: 0x00DF5710 File Offset: 0x00DF3910
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

		// Token: 0x06031E8C RID: 204428 RVA: 0x00DF57DC File Offset: 0x00DF39DC
		protected override UniTask OnCreateAsync()
		{
			BossPilingScoreItem.<OnCreateAsync>d__19 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<BossPilingScoreItem.<OnCreateAsync>d__19>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031E8D RID: 204429 RVA: 0x00DF5820 File Offset: 0x00DF3A20
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

		// Token: 0x06031E8E RID: 204430 RVA: 0x00DF5878 File Offset: 0x00DF3A78
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

		// Token: 0x06031E8F RID: 204431 RVA: 0x00DF592D File Offset: 0x00DF3B2D
		protected override void OnBeforeDestroy()
		{
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
			this.RemoveEvent();
			this.RemoveTimer();
			base.OnBeforeDestroy();
		}

		// Token: 0x06031E90 RID: 204432 RVA: 0x00DF5954 File Offset: 0x00DF3B54
		protected override UniTask OnShowAsyncImplementImplement()
		{
			BossPilingScoreItem.<OnShowAsyncImplementImplement>d__23 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<BossPilingScoreItem.<OnShowAsyncImplementImplement>d__23>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06031E91 RID: 204433 RVA: 0x00DF5998 File Offset: 0x00DF3B98
		protected override UniTask OnHideAsyncImplementImplement()
		{
			BossPilingScoreItem.<OnHideAsyncImplementImplement>d__24 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<BossPilingScoreItem.<OnHideAsyncImplementImplement>d__24>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06031E92 RID: 204434 RVA: 0x00DF59DC File Offset: 0x00DF3BDC
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

		// Token: 0x06031E93 RID: 204435 RVA: 0x00DF5AC4 File Offset: 0x00DF3CC4
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

		// Token: 0x06031E94 RID: 204436 RVA: 0x00DF5B36 File Offset: 0x00DF3D36
		private void RemoveTimer()
		{
			if (this.TimeoutHd != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimeoutHd);
				this.TimeoutHd = null;
			}
		}

		// Token: 0x06031E95 RID: 204437 RVA: 0x00DF5B58 File Offset: 0x00DF3D58
		private void ShowScoreOnWorldDone()
		{
			EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
			this.TimeoutHd = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.RemoveTimer();
				this.OnWorldDoneAndCloseLoading();
			}, 5000f, null, null, true, 1f);
		}

		// Token: 0x06031E96 RID: 204438 RVA: 0x00DF5BAA File Offset: 0x00DF3DAA
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

		// Token: 0x06031E97 RID: 204439 RVA: 0x00DF5BE3 File Offset: 0x00DF3DE3
		private void RemoveEvent()
		{
			if (EventSystem.Instance.Has(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading)))
			{
				EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
			}
		}

		// Token: 0x06031E98 RID: 204440 RVA: 0x00DF5C1E File Offset: 0x00DF3E1E
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

		// Token: 0x06031E99 RID: 204441 RVA: 0x00DF5C5C File Offset: 0x00DF3E5C
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

		// Token: 0x06031E9A RID: 204442 RVA: 0x00DF5CD8 File Offset: 0x00DF3ED8
		private bool IsMaxScore(float score)
		{
			return score >= this.ScoreMaxValue;
		}

		// Token: 0x06031E9B RID: 204443 RVA: 0x00DF5CE8 File Offset: 0x00DF3EE8
		private float GetNextPhaseScore(BattleScoreLevelConf? lvCfg)
		{
			if (lvCfg != null && lvCfg.Value.Level > 0 && lvCfg.Value.Level - 1 < this.ScorePhaseValues.Count)
			{
				return this.ScorePhaseValues[lvCfg.Value.Level - 1];
			}
			return 0f;
		}

		// Token: 0x06031E9C RID: 204444 RVA: 0x00DF5D50 File Offset: 0x00DF3F50
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

		// Token: 0x06031E9D RID: 204445 RVA: 0x00DF5F18 File Offset: 0x00DF4118
		private void SetLevelSprite(int level)
		{
			ULGUISpriteData_BaseObject ulguispriteData_BaseObject = this.BarSpriteDataList[level - 1];
			if (ulguispriteData_BaseObject != null && ulguispriteData_BaseObject.IsValid())
			{
				this.IconSprite.SetSprite(ulguispriteData_BaseObject, true);
			}
		}

		// Token: 0x06031E9E RID: 204446 RVA: 0x00DF5F48 File Offset: 0x00DF4148
		private void OnPlaySequenceEvent(string sequenceName, string eventName)
		{
			if (eventName == "Sequence_Grade_Change" && this.NextScoreLevelConfig != null)
			{
				this.SetLevelSprite(this.NextScoreLevelConfig.Value.Level);
			}
		}

		// Token: 0x06031E9F RID: 204447 RVA: 0x00DF5F88 File Offset: 0x00DF4188
		private void PlayUpAnim()
		{
		}

		// Token: 0x06031EA0 RID: 204448 RVA: 0x00DF5F8C File Offset: 0x00DF418C
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

		// Token: 0x06031EA1 RID: 204449 RVA: 0x00DF601D File Offset: 0x00DF421D
		public override void OnTick(float delta)
		{
			this.InstScoreMachine.Tick(delta);
		}

		// Token: 0x06031EA2 RID: 204450 RVA: 0x00DF602C File Offset: 0x00DF422C
		public override bool IsValidScore(int scoreId)
		{
			BattleScoreConf? scoreConfig = BattleScoreModel.Instance.GetScoreConfig(scoreId, false);
			return scoreConfig != null && scoreConfig.Value.Type == 10;
		}

		// Token: 0x06031EA3 RID: 204451 RVA: 0x00DF6065 File Offset: 0x00DF4265
		public override void ShowScore()
		{
			base.ShowScore();
			this.SetLevelSprite(1);
			this.SetPercent(0f);
			base.Show(null);
		}

		// Token: 0x06031EA4 RID: 204452 RVA: 0x00DF6086 File Offset: 0x00DF4286
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

		// Token: 0x06031EA5 RID: 204453 RVA: 0x00DF60AC File Offset: 0x00DF42AC
		public override void OnShowFirstTime()
		{
			if (this.IsScoreEnable && this.CurScoreValue > 0f)
			{
				this.ShowScore();
			}
		}

		// Token: 0x06031EA6 RID: 204454 RVA: 0x00DF60CC File Offset: 0x00DF42CC
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

		// Token: 0x06031EA7 RID: 204455 RVA: 0x00DF630C File Offset: 0x00DF450C
		private void ResetScore()
		{
			this.CurScoreValue = -1f;
			this.CurScoreGroupId = -1;
			this.NextScoreLevelConfig = null;
			this.LastScoreLevelConfig = null;
		}

		// Token: 0x0401A68B RID: 108171
		[StaticVariableRuleIgnore]
		private static readonly string[] scoreSpritePathList = new string[]
		{
			"/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity33/BossPiling/Game/SP_BossPilingGameScoreBGrey.SP_BossPilingGameScoreBGrey",
			"/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity33/BossPiling/Game/SP_BossPilingGameScoreB.SP_BossPilingGameScoreB",
			"/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity33/BossPiling/Game/SP_BossPilingGameScoreA.SP_BossPilingGameScoreA",
			"/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity33/BossPiling/Game/SP_BossPilingGameScoreS.SP_BossPilingGameScoreS",
			"/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity33/BossPiling/Game/SP_BossPilingGameScoreSS.SP_BossPilingGameScoreSS"
		};

		// Token: 0x0401A68C RID: 108172
		private float CurScoreValue = -1f;

		// Token: 0x0401A68D RID: 108173
		private int CurScoreGroupId = -1;

		// Token: 0x0401A68E RID: 108174
		private BattleScoreLevelConf? LastScoreLevelConfig;

		// Token: 0x0401A68F RID: 108175
		private BattleScoreLevelConf? NextScoreLevelConfig;

		// Token: 0x0401A690 RID: 108176
		private readonly List<float> ScorePhaseValues = new List<float>();

		// Token: 0x0401A691 RID: 108177
		private float ScoreMaxValue;

		// Token: 0x0401A692 RID: 108178
		private int ScoreMaxLevel;

		// Token: 0x0401A693 RID: 108179
		private RogueScoreMachine InstScoreMachine = new RogueScoreMachine();

		// Token: 0x0401A694 RID: 108180
		private UUISprite BarSprite;

		// Token: 0x0401A695 RID: 108181
		private UUISprite BarBgSprite;

		// Token: 0x0401A696 RID: 108182
		private UUITexture BarWhite;

		// Token: 0x0401A697 RID: 108183
		private UUISprite IconSprite;

		// Token: 0x0401A698 RID: 108184
		private UUIText ValueText;

		// Token: 0x0401A699 RID: 108185
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly ULGUISpriteData_BaseObject[] BarSpriteDataList = new ULGUISpriteData_BaseObject[BossPilingScoreItem.scoreSpritePathList.Length];

		// Token: 0x0401A69A RID: 108186
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A69B RID: 108187
		private bool IsPlayingMaxLevel;

		// Token: 0x0401A69C RID: 108188
		[Nullable(2)]
		private TimerHandle TimeoutHd;

		// Token: 0x0401A69D RID: 108189
		private static readonly FName P1Name = new FName("MainTexRotate");

		// Token: 0x0401A69E RID: 108190
		private static readonly FName P2Name = new FName("MaskAngle");

		// Token: 0x0401A69F RID: 108191
		private FLinearColor P1Color = new FLinearColor(0.5f, 0.5f, 0.5f, 1f);

		// Token: 0x0401A6A0 RID: 108192
		private float LastMaskValue = -1f;

		// Token: 0x0401A6A1 RID: 108193
		[Nullable(2)]
		private IReadOnlyList<BattleScoreLevelConf> ScoreLevelConfigList;

		// Token: 0x0401A6A2 RID: 108194
		private BattleScoreLevelConf? ScoreLevelConfigMax;

		// Token: 0x0200AAA0 RID: 43680
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034BB7 RID: 215991
			SprProgress,
			// Token: 0x04034BB8 RID: 215992
			SprProgressLight,
			// Token: 0x04034BB9 RID: 215993
			TextureWhite,
			// Token: 0x04034BBA RID: 215994
			SprScoreIcon,
			// Token: 0x04034BBB RID: 215995
			ValueText
		}
	}
}
