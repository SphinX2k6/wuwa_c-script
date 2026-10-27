using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.FlagChallenge;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C36 RID: 23606
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeMonsterLevelItem : StateExtraItemBase
	{
		// Token: 0x0603BA4F RID: 244303 RVA: 0x00E3B88C File Offset: 0x00E39A8C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603BA50 RID: 244304 RVA: 0x00E3B918 File Offset: 0x00E39B18
		protected override UniTask OnCreateAsync()
		{
			FlagChallengeMonsterLevelItem.<OnCreateAsync>d__14 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<FlagChallengeMonsterLevelItem.<OnCreateAsync>d__14>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BA51 RID: 244305 RVA: 0x00E3B95C File Offset: 0x00E39B5C
		protected override void OnStart()
		{
			base.OnStart();
			this.LevelDiffTexture = base.GetTexture(1);
			this.LightTexture = base.GetTexture(2);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			EventSystem.Instance.Add(EEventName.OnFlagChallengeTotalLevelChanged, new Action<int, int, int, int>(this.OnFlagChallengeTotalLevelChanged));
		}

		// Token: 0x0603BA52 RID: 244306 RVA: 0x00E3B9B8 File Offset: 0x00E39BB8
		protected override void OnBeforeDestroy()
		{
			Dictionary<EFlagChallengeLevelDiffType, UTexture> levelDiffTextureMap = this.LevelDiffTextureMap;
			if (levelDiffTextureMap != null)
			{
				levelDiffTextureMap.Clear();
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			EventSystem.Instance.Remove(EEventName.OnFlagChallengeTotalLevelChanged, new Action<int, int, int, int>(this.OnFlagChallengeTotalLevelChanged));
			base.OnBeforeDestroy();
		}

		// Token: 0x0603BA53 RID: 244307 RVA: 0x00E3BA09 File Offset: 0x00E39C09
		private void OnFlagChallengeTotalLevelChanged(int oldLevel, int newLevel, int oldTempLevel, int newTempLevel)
		{
			this.SetFlagChallengeLevelDiff(this.FlagChallengeLevel);
		}

		// Token: 0x0603BA54 RID: 244308 RVA: 0x00E3BA18 File Offset: 0x00E39C18
		protected override void OnInitExtraParams(ExtraItemParams paramsObj)
		{
			FlagChallengeLevelItemParams flagChallengeLevelItemParams = paramsObj as FlagChallengeLevelItemParams;
			if (flagChallengeLevelItemParams == null)
			{
				throw new InvalidCastException();
			}
			int flagChallengeLevel = flagChallengeLevelItemParams.FlagChallengeLevel;
			this.SetFlagChallengeLevel(flagChallengeLevel);
		}

		// Token: 0x0603BA55 RID: 244309 RVA: 0x00E3BA44 File Offset: 0x00E39C44
		private void SetFlagChallengeLevel(int mosnterLevelId)
		{
			int level = FlagChallengeConfig.Instance.GetMonsterLevelConfigById(mosnterLevelId).Value.Level;
			this.FlagChallengeLevel = level;
			UUIArtText artText = base.GetArtText(0);
			if (artText != null)
			{
				artText.SetText(level.ToString());
			}
			this.SetFlagChallengeLevelDiff(level);
		}

		// Token: 0x0603BA56 RID: 244310 RVA: 0x00E3BA94 File Offset: 0x00E39C94
		private void SetFlagChallengeLevelDiff(int flagChallengeLevel)
		{
			int activityId = FlagChallengeBattleModel.Instance.ActivityId;
			EFlagChallengeLevelDiffType levelDiffType = FlagChallengeModel.Instance.GetLevelDiffType(activityId, flagChallengeLevel, null);
			EFlagChallengeLevelDiffType eflagChallengeLevelDiffType = levelDiffType;
			EFlagChallengeLevelDiffType? flagChallengeLevelDiffType = this.FlagChallengeLevelDiffType;
			if (eflagChallengeLevelDiffType == flagChallengeLevelDiffType.GetValueOrDefault() & flagChallengeLevelDiffType != null)
			{
				return;
			}
			this.FlagChallengeLevelDiffType = new EFlagChallengeLevelDiffType?(levelDiffType);
			UTexture texture;
			if (this.LevelDiffTextureMap != null && this.LevelDiffTextureMap.TryGetValue(levelDiffType, out texture))
			{
				UUITexture levelDiffTexture = this.LevelDiffTexture;
				if (levelDiffTexture != null)
				{
					levelDiffTexture.SetTexture(texture);
				}
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, true);
			}
			switch (levelDiffType)
			{
			case EFlagChallengeLevelDiffType.Easy:
			{
				UUITexture lightTexture = this.LightTexture;
				if (lightTexture != null)
				{
					lightTexture.SetColor(FColor.FromHex("#8AD797"));
				}
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 == null)
				{
					return;
				}
				levelSequencePlayer2.PlaySequencePurely("Start01", false, false, null, null, false);
				return;
			}
			case EFlagChallengeLevelDiffType.Normal:
			{
				UUITexture lightTexture2 = this.LightTexture;
				if (lightTexture2 != null)
				{
					lightTexture2.SetColor(FColor.FromHex("#FF9517"));
				}
				LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
				if (levelSequencePlayer3 == null)
				{
					return;
				}
				levelSequencePlayer3.PlaySequencePurely("Start03", false, false, null, null, false);
				return;
			}
			case EFlagChallengeLevelDiffType.Hard:
			{
				UUITexture lightTexture3 = this.LightTexture;
				if (lightTexture3 != null)
				{
					lightTexture3.SetColor(FColor.FromHex("#FF1E18"));
				}
				LevelSequencePlayer levelSequencePlayer4 = this.LevelSequencePlayer;
				if (levelSequencePlayer4 == null)
				{
					return;
				}
				levelSequencePlayer4.PlaySequencePurely("Start02", false, false, null, null, false);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0603BA57 RID: 244311 RVA: 0x00E3BBF8 File Offset: 0x00E39DF8
		private UniTask LoadLevelDiffSprite(string path, EFlagChallengeLevelDiffType index)
		{
			FlagChallengeMonsterLevelItem.<LoadLevelDiffSprite>d__21 <LoadLevelDiffSprite>d__;
			<LoadLevelDiffSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadLevelDiffSprite>d__.<>4__this = this;
			<LoadLevelDiffSprite>d__.path = path;
			<LoadLevelDiffSprite>d__.index = index;
			<LoadLevelDiffSprite>d__.<>1__state = -1;
			<LoadLevelDiffSprite>d__.<>t__builder.Start<FlagChallengeMonsterLevelItem.<LoadLevelDiffSprite>d__21>(ref <LoadLevelDiffSprite>d__);
			return <LoadLevelDiffSprite>d__.<>t__builder.Task;
		}

		// Token: 0x0401F0CA RID: 127178
		private const string LEVEL_DIFF_SPRITE_EASY = "/Game/Aki/UI/UIResources/UiFight/Image/Activity/Activity32/Morale/T_EmenyMoraleLevelGreen.T_EmenyMoraleLevelGreen";

		// Token: 0x0401F0CB RID: 127179
		private const string LEVEL_DIFF_SPRITE_NORMAL = "/Game/Aki/UI/UIResources/UiFight/Image/Activity/Activity32/Morale/T_EmenyMoraleLevelYellow.T_EmenyMoraleLevelYellow";

		// Token: 0x0401F0CC RID: 127180
		private const string LEVEL_DIFF_SPRITE_HARD = "/Game/Aki/UI/UIResources/UiFight/Image/Activity/Activity32/Morale/T_EmenyMoraleLevelRed.T_EmenyMoraleLevelRed";

		// Token: 0x0401F0CD RID: 127181
		private const string LEVEL_DIFF_COLOR_EASY = "#8AD797";

		// Token: 0x0401F0CE RID: 127182
		private const string LEVEL_DIFF_COLOR_NORMAL = "#FF9517";

		// Token: 0x0401F0CF RID: 127183
		private const string LEVEL_DIFF_COLOR_HARD = "#FF1E18";

		// Token: 0x0401F0D0 RID: 127184
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<EFlagChallengeLevelDiffType, UTexture> LevelDiffTextureMap;

		// Token: 0x0401F0D1 RID: 127185
		[Nullable(2)]
		private UUITexture LevelDiffTexture;

		// Token: 0x0401F0D2 RID: 127186
		[Nullable(2)]
		private UUITexture LightTexture;

		// Token: 0x0401F0D3 RID: 127187
		private int FlagChallengeLevel = 1;

		// Token: 0x0401F0D4 RID: 127188
		private EFlagChallengeLevelDiffType? FlagChallengeLevelDiffType;

		// Token: 0x0401F0D5 RID: 127189
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200BE27 RID: 48679
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x04039579 RID: 234873
			LevelText,
			// Token: 0x0403957A RID: 234874
			LevelDiffTexture,
			// Token: 0x0403957B RID: 234875
			LightTexture
		}
	}
}
