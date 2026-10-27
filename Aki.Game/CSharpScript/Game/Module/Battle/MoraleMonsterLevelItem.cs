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
	// Token: 0x02005C53 RID: 23635
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleMonsterLevelItem : StateExtraItemBase
	{
		// Token: 0x0603BBD8 RID: 244696 RVA: 0x00E44918 File Offset: 0x00E42B18
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

		// Token: 0x0603BBD9 RID: 244697 RVA: 0x00E449A4 File Offset: 0x00E42BA4
		protected override UniTask OnCreateAsync()
		{
			MoraleMonsterLevelItem.<OnCreateAsync>d__14 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<MoraleMonsterLevelItem.<OnCreateAsync>d__14>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BBDA RID: 244698 RVA: 0x00E449E8 File Offset: 0x00E42BE8
		protected override void OnStart()
		{
			base.OnStart();
			this.LevelDiffTexture = base.GetTexture(1);
			this.LightTexture = base.GetTexture(2);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			EventSystem.Instance.Add(EEventName.OnMoraleSumLevelChanged, new Action<int, int, int, int>(this.OnMoraleSumLevelChanged));
		}

		// Token: 0x0603BBDB RID: 244699 RVA: 0x00E44A44 File Offset: 0x00E42C44
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

		// Token: 0x0603BBDC RID: 244700 RVA: 0x00E44A95 File Offset: 0x00E42C95
		private void OnMoraleSumLevelChanged(int oldLevel, int newLevel, int oldTempLevel, int newTempLevel)
		{
			this.SetMoraleLevelDiff(this.MoraleLevel);
		}

		// Token: 0x0603BBDD RID: 244701 RVA: 0x00E44AA4 File Offset: 0x00E42CA4
		protected override void OnInitExtraParams(ExtraItemParams param)
		{
			int moraleLevel = ((MoraleLevelItemParams)param).MoraleLevel;
			this.SetMoraleLevel(moraleLevel);
		}

		// Token: 0x0603BBDE RID: 244702 RVA: 0x00E44AC4 File Offset: 0x00E42CC4
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

		// Token: 0x0603BBDF RID: 244703 RVA: 0x00E44AF0 File Offset: 0x00E42CF0
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

		// Token: 0x0603BBE0 RID: 244704 RVA: 0x00E44C48 File Offset: 0x00E42E48
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

		// Token: 0x0401F1AC RID: 127404
		private const string LEVEL_DIFF_SPRITE_EASY = "/Game/Aki/UI/UIResources/UiFight/Image/Flag/T_EmenyMoraleLevelGray.T_EmenyMoraleLevelGray";

		// Token: 0x0401F1AD RID: 127405
		private const string LEVEL_DIFF_SPRITE_NORMAL = "/Game/Aki/UI/UIResources/UiFight/Image/Flag/T_EmenyMoraleLevelYellow.T_EmenyMoraleLevelYellow";

		// Token: 0x0401F1AE RID: 127406
		private const string LEVEL_DIFF_SPRITE_HARD = "/Game/Aki/UI/UIResources/UiFight/Image/Flag/T_EmenyMoraleLevelRed.T_EmenyMoraleLevelRed";

		// Token: 0x0401F1AF RID: 127407
		private const string LEVEL_DIFF_COLOR_EASY = "#000000cc";

		// Token: 0x0401F1B0 RID: 127408
		private const string LEVEL_DIFF_COLOR_NORMAL = "#ff9517cc";

		// Token: 0x0401F1B1 RID: 127409
		private const string LEVEL_DIFF_COLOR_HARD = "#ff1e18cc";

		// Token: 0x0401F1B2 RID: 127410
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<EMoraleLevelDiffType, UTexture> LevelDiffTextureMap;

		// Token: 0x0401F1B3 RID: 127411
		[Nullable(2)]
		private UUITexture LevelDiffTexture;

		// Token: 0x0401F1B4 RID: 127412
		[Nullable(2)]
		private UUITexture LightTexture;

		// Token: 0x0401F1B5 RID: 127413
		private int MoraleLevel = 1;

		// Token: 0x0401F1B6 RID: 127414
		private EMoraleLevelDiffType? MoraleLevelDiffType;

		// Token: 0x0401F1B7 RID: 127415
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200BE63 RID: 48739
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040396A2 RID: 235170
			LevelText,
			// Token: 0x040396A3 RID: 235171
			LevelDiffTexture,
			// Token: 0x040396A4 RID: 235172
			LightTexture
		}
	}
}
