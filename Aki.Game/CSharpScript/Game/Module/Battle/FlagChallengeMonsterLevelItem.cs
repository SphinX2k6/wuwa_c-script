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
	// Token: 0x02004C16 RID: 19478
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeMonsterLevelItem : StateExtraItemBase
	{
		// Token: 0x0603099A RID: 199066 RVA: 0x00D8BBFC File Offset: 0x00D89DFC
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

		// Token: 0x0603099B RID: 199067 RVA: 0x00D8BC88 File Offset: 0x00D89E88
		protected override UniTask OnCreateAsync()
		{
			FlagChallengeMonsterLevelItem.<OnCreateAsync>d__14 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<FlagChallengeMonsterLevelItem.<OnCreateAsync>d__14>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603099C RID: 199068 RVA: 0x00D8BCCC File Offset: 0x00D89ECC
		protected override void OnStart()
		{
			base.OnStart();
			this.LevelDiffTexture = base.GetTexture(1);
			this.LightTexture = base.GetTexture(2);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			EventSystem.Instance.Add(EEventName.OnFlagChallengeTotalLevelChanged, new Action<int, int, int, int>(this.OnFlagChallengeTotalLevelChanged));
		}

		// Token: 0x0603099D RID: 199069 RVA: 0x00D8BD28 File Offset: 0x00D89F28
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

		// Token: 0x0603099E RID: 199070 RVA: 0x00D8BD79 File Offset: 0x00D89F79
		private void OnFlagChallengeTotalLevelChanged(int oldLevel, int newLevel, int oldTempLevel, int newTempLevel)
		{
			this.SetFlagChallengeLevelDiff(this.FlagChallengeLevel);
		}

		// Token: 0x0603099F RID: 199071 RVA: 0x00D8BD88 File Offset: 0x00D89F88
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

		// Token: 0x060309A0 RID: 199072 RVA: 0x00D8BDB4 File Offset: 0x00D89FB4
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

		// Token: 0x060309A1 RID: 199073 RVA: 0x00D8BE04 File Offset: 0x00D8A004
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

		// Token: 0x060309A2 RID: 199074 RVA: 0x00D8BF68 File Offset: 0x00D8A168
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

		// Token: 0x04019B7B RID: 105339
		private const string LEVEL_DIFF_SPRITE_EASY = "/Game/Aki/UI/UIResources/UiFight/Image/Activity/Activity32/Morale/T_EmenyMoraleLevelGreen.T_EmenyMoraleLevelGreen";

		// Token: 0x04019B7C RID: 105340
		private const string LEVEL_DIFF_SPRITE_NORMAL = "/Game/Aki/UI/UIResources/UiFight/Image/Activity/Activity32/Morale/T_EmenyMoraleLevelYellow.T_EmenyMoraleLevelYellow";

		// Token: 0x04019B7D RID: 105341
		private const string LEVEL_DIFF_SPRITE_HARD = "/Game/Aki/UI/UIResources/UiFight/Image/Activity/Activity32/Morale/T_EmenyMoraleLevelRed.T_EmenyMoraleLevelRed";

		// Token: 0x04019B7E RID: 105342
		private const string LEVEL_DIFF_COLOR_EASY = "#8AD797";

		// Token: 0x04019B7F RID: 105343
		private const string LEVEL_DIFF_COLOR_NORMAL = "#FF9517";

		// Token: 0x04019B80 RID: 105344
		private const string LEVEL_DIFF_COLOR_HARD = "#FF1E18";

		// Token: 0x04019B81 RID: 105345
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<EFlagChallengeLevelDiffType, UTexture> LevelDiffTextureMap;

		// Token: 0x04019B82 RID: 105346
		[Nullable(2)]
		private UUITexture LevelDiffTexture;

		// Token: 0x04019B83 RID: 105347
		[Nullable(2)]
		private UUITexture LightTexture;

		// Token: 0x04019B84 RID: 105348
		private int FlagChallengeLevel = 1;

		// Token: 0x04019B85 RID: 105349
		private EFlagChallengeLevelDiffType? FlagChallengeLevelDiffType;

		// Token: 0x04019B86 RID: 105350
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200A82F RID: 43055
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x04033F3C RID: 212796
			LevelText,
			// Token: 0x04033F3D RID: 212797
			LevelDiffTexture,
			// Token: 0x04033F3E RID: 212798
			LightTexture
		}
	}
}
