using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C33 RID: 19507
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleMonsterLevelItem : StateExtraItemBase
	{
		// Token: 0x06030B23 RID: 199459 RVA: 0x00D94CE4 File Offset: 0x00D92EE4
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

		// Token: 0x06030B24 RID: 199460 RVA: 0x00D94D70 File Offset: 0x00D92F70
		protected override UniTask OnCreateAsync()
		{
			MoraleMonsterLevelItem.<OnCreateAsync>d__14 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<MoraleMonsterLevelItem.<OnCreateAsync>d__14>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030B25 RID: 199461 RVA: 0x00D94DB4 File Offset: 0x00D92FB4
		protected override void OnStart()
		{
			base.OnStart();
			this.LevelDiffTexture = base.GetTexture(1);
			this.LightTexture = base.GetTexture(2);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			EventSystem.Instance.Add(EEventName.OnMoraleSumLevelChanged, new Action<int, int, int, int>(this.OnMoraleSumLevelChanged));
		}

		// Token: 0x06030B26 RID: 199462 RVA: 0x00D94E10 File Offset: 0x00D93010
		protected override void OnBeforeDestroy()
		{
			Dictionary<EMoraleLevelDiffType, UTexture> levelDiffTextureMap = this.LevelDiffTextureMap;
			if (levelDiffTextureMap != null)
			{
				levelDiffTextureMap.Clear();
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			EventSystem.Instance.Remove(EEventName.OnMoraleSumLevelChanged, new Action<int, int, int, int>(this.OnMoraleSumLevelChanged));
			base.OnBeforeDestroy();
		}

		// Token: 0x06030B27 RID: 199463 RVA: 0x00D94E61 File Offset: 0x00D93061
		private void OnMoraleSumLevelChanged(int oldLevel, int newLevel, int oldTempLevel, int newTempLevel)
		{
			this.SetMoraleLevelDiff(this.MoraleLevel);
		}

		// Token: 0x06030B28 RID: 199464 RVA: 0x00D94E70 File Offset: 0x00D93070
		protected override void OnInitExtraParams(ExtraItemParams param)
		{
			int moraleLevel = ((MoraleLevelItemParams)param).MoraleLevel;
			this.SetMoraleLevel(moraleLevel);
		}

		// Token: 0x06030B29 RID: 199465 RVA: 0x00D94E90 File Offset: 0x00D93090
		private void SetMoraleLevel(int moraleLevel)
		{
			this.MoraleLevel = moraleLevel;
			UUIArtText artText = base.GetArtText(0);
			if (artText != null)
			{
				artText.SetText(moraleLevel.ToString());
			}
			this.SetMoraleLevelDiff(moraleLevel);
		}

		// Token: 0x06030B2A RID: 199466 RVA: 0x00D94EBC File Offset: 0x00D930BC
		private void SetMoraleLevelDiff(int moraleLevel)
		{
			EMoraleLevelDiffType moraleLevelDiffType = MoraleBattleModel.Instance.GetMoraleLevelDiffType(moraleLevel, null);
			EMoraleLevelDiffType emoraleLevelDiffType = moraleLevelDiffType;
			EMoraleLevelDiffType? moraleLevelDiffType2 = this.MoraleLevelDiffType;
			if (emoraleLevelDiffType == moraleLevelDiffType2.GetValueOrDefault() & moraleLevelDiffType2 != null)
			{
				return;
			}
			this.MoraleLevelDiffType = new EMoraleLevelDiffType?(moraleLevelDiffType);
			UTexture texture;
			if (this.LevelDiffTextureMap != null && this.LevelDiffTextureMap.TryGetValue(moraleLevelDiffType, out texture))
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
			switch (moraleLevelDiffType)
			{
			case EMoraleLevelDiffType.Easy:
			{
				UUITexture lightTexture = this.LightTexture;
				if (lightTexture != null)
				{
					lightTexture.SetColor(FColor.FromHex("#000000cc"));
				}
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 == null)
				{
					return;
				}
				levelSequencePlayer2.PlaySequencePurely("Start01", false, false, null, null, false);
				return;
			}
			case EMoraleLevelDiffType.Normal:
			{
				UUITexture lightTexture2 = this.LightTexture;
				if (lightTexture2 != null)
				{
					lightTexture2.SetColor(FColor.FromHex("#ff9517cc"));
				}
				LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
				if (levelSequencePlayer3 == null)
				{
					return;
				}
				levelSequencePlayer3.PlaySequencePurely("Start03", false, false, null, null, false);
				return;
			}
			case EMoraleLevelDiffType.Hard:
			{
				UUITexture lightTexture3 = this.LightTexture;
				if (lightTexture3 != null)
				{
					lightTexture3.SetColor(FColor.FromHex("#ff1e18cc"));
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

		// Token: 0x06030B2B RID: 199467 RVA: 0x00D95014 File Offset: 0x00D93214
		private UniTask LoadLevelDiffSprite(string path, EMoraleLevelDiffType index)
		{
			MoraleMonsterLevelItem.<LoadLevelDiffSprite>d__21 <LoadLevelDiffSprite>d__;
			<LoadLevelDiffSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadLevelDiffSprite>d__.<>4__this = this;
			<LoadLevelDiffSprite>d__.path = path;
			<LoadLevelDiffSprite>d__.index = index;
			<LoadLevelDiffSprite>d__.<>1__state = -1;
			<LoadLevelDiffSprite>d__.<>t__builder.Start<MoraleMonsterLevelItem.<LoadLevelDiffSprite>d__21>(ref <LoadLevelDiffSprite>d__);
			return <LoadLevelDiffSprite>d__.<>t__builder.Task;
		}

		// Token: 0x04019C5D RID: 105565
		private const string LEVEL_DIFF_SPRITE_EASY = "/Game/Aki/UI/UIResources/UiFight/Image/Flag/T_EmenyMoraleLevelGray.T_EmenyMoraleLevelGray";

		// Token: 0x04019C5E RID: 105566
		private const string LEVEL_DIFF_SPRITE_NORMAL = "/Game/Aki/UI/UIResources/UiFight/Image/Flag/T_EmenyMoraleLevelYellow.T_EmenyMoraleLevelYellow";

		// Token: 0x04019C5F RID: 105567
		private const string LEVEL_DIFF_SPRITE_HARD = "/Game/Aki/UI/UIResources/UiFight/Image/Flag/T_EmenyMoraleLevelRed.T_EmenyMoraleLevelRed";

		// Token: 0x04019C60 RID: 105568
		private const string LEVEL_DIFF_COLOR_EASY = "#000000cc";

		// Token: 0x04019C61 RID: 105569
		private const string LEVEL_DIFF_COLOR_NORMAL = "#ff9517cc";

		// Token: 0x04019C62 RID: 105570
		private const string LEVEL_DIFF_COLOR_HARD = "#ff1e18cc";

		// Token: 0x04019C63 RID: 105571
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<EMoraleLevelDiffType, UTexture> LevelDiffTextureMap;

		// Token: 0x04019C64 RID: 105572
		[Nullable(2)]
		private UUITexture LevelDiffTexture;

		// Token: 0x04019C65 RID: 105573
		[Nullable(2)]
		private UUITexture LightTexture;

		// Token: 0x04019C66 RID: 105574
		private int MoraleLevel = 1;

		// Token: 0x04019C67 RID: 105575
		private EMoraleLevelDiffType? MoraleLevelDiffType;

		// Token: 0x04019C68 RID: 105576
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200A869 RID: 43113
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034063 RID: 213091
			LevelText,
			// Token: 0x04034064 RID: 213092
			LevelDiffTexture,
			// Token: 0x04034065 RID: 213093
			LightTexture
		}
	}
}
