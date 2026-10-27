using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using Aki.Config;
using CSharpScript.Game.Module.Battle;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DBC RID: 23996
	[NullableContext(2)]
	[Nullable(0)]
	public class VisionArenaScoreItem : BaseScoreItem
	{
		// Token: 0x0603CF97 RID: 249751 RVA: 0x00EA8788 File Offset: 0x00EA6988
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CF98 RID: 249752 RVA: 0x00EA8898 File Offset: 0x00EA6A98
		protected override UniTask OnCreateAsync()
		{
			VisionArenaScoreItem.<OnCreateAsync>d__10 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<VisionArenaScoreItem.<OnCreateAsync>d__10>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CF99 RID: 249753 RVA: 0x00EA88DB File Offset: 0x00EA6ADB
		[NullableContext(1)]
		private void OnAnimationClose(string sequenceName)
		{
		}

		// Token: 0x0603CF9A RID: 249754 RVA: 0x00EA88E0 File Offset: 0x00EA6AE0
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnAnimationClose), false);
			this.WaveUiNiagara = base.GetUiNiagara(0);
			if (this.WaveNiagara != null)
			{
				UUINiagara waveUiNiagara = this.WaveUiNiagara;
				if (waveUiNiagara != null)
				{
					waveUiNiagara.SetNiagaraSystem(this.WaveNiagara);
				}
			}
			bool flag = false;
			foreach (KeyValuePair<int, int> keyValuePair in BattleScoreModel.Instance.GetScoreMap())
			{
				int num;
				int num2;
				keyValuePair.Deconstruct(out num, out num2);
				int scoreId = num;
				int num3 = num2;
				if (num3 >= 0 && this.IsValidScore(scoreId))
				{
					this.OnBattleScoreChanged(scoreId, num3);
					flag = true;
				}
			}
			if (!flag)
			{
				int scoreId2 = (int)this.OpenParam;
				this.OnBattleScoreChanged(scoreId2, 0);
			}
		}

		// Token: 0x0603CF9B RID: 249755 RVA: 0x00EA89CC File Offset: 0x00EA6BCC
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

		// Token: 0x0603CF9C RID: 249756 RVA: 0x00EA89EC File Offset: 0x00EA6BEC
		[NullableContext(1)]
		private UniTask LoadNiagara(string path)
		{
			VisionArenaScoreItem.<LoadNiagara>d__14 <LoadNiagara>d__;
			<LoadNiagara>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadNiagara>d__.<>4__this = this;
			<LoadNiagara>d__.path = path;
			<LoadNiagara>d__.<>1__state = -1;
			<LoadNiagara>d__.<>t__builder.Start<VisionArenaScoreItem.<LoadNiagara>d__14>(ref <LoadNiagara>d__);
			return <LoadNiagara>d__.<>t__builder.Task;
		}

		// Token: 0x0603CF9D RID: 249757 RVA: 0x00EA8A38 File Offset: 0x00EA6C38
		protected override void OnBattleScoreChanged(int scoreId, int score)
		{
			if (base.IsHideOrHiding)
			{
				this.ShowScore();
			}
			if (this.ScoreLevelConfigList == null)
			{
				BattleScoreConf? scoreConfig = BattleScoreModel.Instance.GetScoreConfig(scoreId, true);
				if (scoreConfig == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Battle;
					ELogAuthor author = ELogAuthor.LPH;
					string message = "VisionArenaScoreItem 没有找到分数配置";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("scoreId", scoreId);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				this.ScoreLevelConfigList = BattleScoreConfig.Instance.GetBattleScoreActionConfigByGroupId(scoreConfig.Value.LevelGroupId);
			}
			this.UpdateCurrentLevel(score);
			if (this.CurrentLevelConfig != null)
			{
				BattleScoreLevelConf value = this.CurrentLevelConfig.Value;
				if (value.LowerUpperLimits(1) > 0)
				{
					UUINiagara uiNiagara = base.GetUiNiagara(3);
					if (uiNiagara != null)
					{
						uiNiagara.SetNiagaraVarFloat("Dissolve", (float)(score - value.LowerUpperLimits(0)) / (float)(value.LowerUpperLimits(1) - value.LowerUpperLimits(0)));
					}
				}
			}
			if (this.IsDirty)
			{
				this.UpdateSpine();
				this.UpdateWaveEffect();
				this.IsDirty = false;
			}
		}

		// Token: 0x0603CF9E RID: 249758 RVA: 0x00EA8B38 File Offset: 0x00EA6D38
		public override bool IsValidScore(int scoreId)
		{
			BattleScoreConf? scoreConfig = BattleScoreModel.Instance.GetScoreConfig(scoreId, true);
			return scoreConfig != null && scoreConfig.Value.Type == 8;
		}

		// Token: 0x0603CF9F RID: 249759 RVA: 0x00EA8B70 File Offset: 0x00EA6D70
		public override void ShowScore()
		{
			base.ShowScore();
			base.Show(null);
			UUINiagara waveUiNiagara = this.WaveUiNiagara;
			if (waveUiNiagara != null)
			{
				waveUiNiagara.SetUIActive(true);
			}
			UUINiagara waveUiNiagara2 = this.WaveUiNiagara;
			if (waveUiNiagara2 != null)
			{
				waveUiNiagara2.ActivateSystem(true);
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 == null)
			{
				return;
			}
			levelSequencePlayer2.PlaySequencePurely("Start", false, false, null, null, false);
		}

		// Token: 0x0603CFA0 RID: 249760 RVA: 0x00EA8BE3 File Offset: 0x00EA6DE3
		public override void HideScore()
		{
			base.HideScore();
			UUINiagara waveUiNiagara = this.WaveUiNiagara;
			if (waveUiNiagara != null)
			{
				waveUiNiagara.SetUIActive(false);
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
			this.<HideScore>g__HideAfterAnimation|18_0().Forget();
		}

		// Token: 0x0603CFA1 RID: 249761 RVA: 0x00EA8C1C File Offset: 0x00EA6E1C
		private void UpdateCurrentLevel(int score)
		{
			if (this.ScoreLevelConfigList == null)
			{
				return;
			}
			foreach (BattleScoreLevelConf value in this.ScoreLevelConfigList)
			{
				if (score >= value.LowerUpperLimits(0) && score < value.LowerUpperLimits(1) && this.CurrentLevel != value.Level)
				{
					this.CurrentLevel = value.Level;
					this.CurrentLevelConfig = new BattleScoreLevelConf?(value);
					this.IsDirty = true;
				}
			}
		}

		// Token: 0x0603CFA2 RID: 249762 RVA: 0x00EA8CB0 File Offset: 0x00EA6EB0
		private void UpdateSpine()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
			switch (this.CurrentLevel)
			{
			case 1:
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("VisionArenaScoreIte_Idle");
				this.SetSpriteByPath(resourcePath, base.GetSprite(1), false, null, delegate(bool _)
				{
					AActor owner = base.GetSprite(1).GetOwner();
					(((owner != null) ? owner.GetComponentByClass(UUISpriteAnimator.StaticClass()) : null) as UUISpriteAnimator).ResetSpriteImporter();
					LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
					if (levelSequencePlayer3 != null)
					{
						levelSequencePlayer3.PlayLevelSequenceByName("Switch2to1", false, null, false);
					}
					LevelSequencePlayer levelSequencePlayer4 = this.LevelSequencePlayer;
					if (levelSequencePlayer4 == null)
					{
						return;
					}
					levelSequencePlayer4.PlayLevelSequenceByName("Loop1", false, null, false);
				});
				break;
			}
			case 2:
			{
				string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("VisionArenaScoreIte_B");
				this.SetSpriteByPath(resourcePath2, base.GetSprite(6), false, null, delegate(bool _)
				{
					AActor owner = base.GetSprite(6).GetOwner();
					(((owner != null) ? owner.GetComponentByClass(UUISpriteAnimator.StaticClass()) : null) as UUISpriteAnimator).ResetSpriteImporter();
					LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
					if (levelSequencePlayer3 != null)
					{
						levelSequencePlayer3.PlayLevelSequenceByName("Switch1to2", false, null, false);
					}
					LevelSequencePlayer levelSequencePlayer4 = this.LevelSequencePlayer;
					if (levelSequencePlayer4 == null)
					{
						return;
					}
					levelSequencePlayer4.PlayLevelSequenceByName("Loop2", false, null, false);
				});
				break;
			}
			case 3:
			{
				string resourcePath3 = UiResourceConfig.Instance.GetResourcePath("VisionArenaScoreIte_A");
				this.SetSpriteByPath(resourcePath3, base.GetSprite(1), false, null, delegate(bool _)
				{
					AActor owner = base.GetSprite(1).GetOwner();
					(((owner != null) ? owner.GetComponentByClass(UUISpriteAnimator.StaticClass()) : null) as UUISpriteAnimator).ResetSpriteImporter();
					LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
					if (levelSequencePlayer3 != null)
					{
						levelSequencePlayer3.PlayLevelSequenceByName("Switch2to1", false, null, false);
					}
					LevelSequencePlayer levelSequencePlayer4 = this.LevelSequencePlayer;
					if (levelSequencePlayer4 == null)
					{
						return;
					}
					levelSequencePlayer4.PlayLevelSequenceByName("Loop1", false, null, false);
				});
				break;
			}
			case 4:
			{
				string resourcePath4 = UiResourceConfig.Instance.GetResourcePath("VisionArenaScoreIte_S");
				this.SetSpriteByPath(resourcePath4, base.GetSprite(6), false, null, delegate(bool _)
				{
					AActor owner = base.GetSprite(6).GetOwner();
					(((owner != null) ? owner.GetComponentByClass(UUISpriteAnimator.StaticClass()) : null) as UUISpriteAnimator).ResetSpriteImporter();
					LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
					if (levelSequencePlayer3 != null)
					{
						levelSequencePlayer3.PlayLevelSequenceByName("Switch1to2", false, null, false);
					}
					LevelSequencePlayer levelSequencePlayer4 = this.LevelSequencePlayer;
					if (levelSequencePlayer4 == null)
					{
						return;
					}
					levelSequencePlayer4.PlayLevelSequenceByName("Loop2", false, null, false);
				});
				break;
			}
			default:
			{
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 != null)
				{
					levelSequencePlayer2.PlayLevelSequenceByName("Loop1", false, null, false);
				}
				break;
			}
			}
			UiResourceConfig instance = UiResourceConfig.Instance;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
			defaultInterpolatedStringHandler.AppendLiteral("VisionArena_ScoreItem_Bg_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurrentLevel);
			string resourcePath5 = instance.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear());
			if (!string.IsNullOrEmpty(resourcePath5))
			{
				base.SetTextureShowUntilLoaded(resourcePath5, base.GetTexture(2), null);
			}
		}

		// Token: 0x0603CFA3 RID: 249763 RVA: 0x00EA8E48 File Offset: 0x00EA7048
		private unsafe void UpdateWaveEffect()
		{
			bool uiactive = this.CurrentLevel > 1;
			UUINiagara uiNiagara = base.GetUiNiagara(3);
			UUINiagara uiNiagara2 = base.GetUiNiagara(0);
			if (uiNiagara2 != null)
			{
				uiNiagara2.SetUIActive(uiactive);
			}
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(uiactive);
			}
			string text = null;
			switch (this.CurrentLevel)
			{
			case 1:
				if (uiNiagara != null)
				{
					uiNiagara.SetUIActive(false);
				}
				break;
			case 2:
				text = ConfigCommonParamById.GetStringConfig("VisionArenaScoreEffectConfigB");
				if (uiNiagara != null)
				{
					uiNiagara.SetUIActive(true);
				}
				break;
			case 3:
				text = ConfigCommonParamById.GetStringConfig("VisionArenaScoreEffectConfigA");
				if (uiNiagara != null)
				{
					uiNiagara.SetUIActive(true);
				}
				break;
			case 4:
				text = ConfigCommonParamById.GetStringConfig("VisionArenaScoreEffectConfigS");
				if (uiNiagara != null)
				{
					uiNiagara.SetUIActive(true);
				}
				break;
			}
			if (text != null)
			{
				try
				{
					JsonElement jsonElement = JsonDocument.Parse(text, default(JsonDocumentOptions)).RootElement;
					foreach (JsonProperty jsonProperty in jsonElement.EnumerateObject())
					{
						string name = jsonProperty.Name;
						if (!(name == "Wave"))
						{
							if (!(name == "Progress"))
							{
								if (name == "Burst")
								{
									UUINiagara uiNiagara3 = base.GetUiNiagara(4);
									if (uiNiagara3 != null)
									{
										uiNiagara3.SetUIActive(true);
										UUINiagara niagara = uiNiagara3;
										jsonElement = jsonProperty.Value;
										VisionArenaScoreItem.<UpdateWaveEffect>g__Func|21_0(niagara, jsonElement);
									}
									UUIItem item = base.GetItem(5);
									object obj;
									if (item == null)
									{
										obj = null;
									}
									else
									{
										AActor owner = item.GetOwner();
										obj = ((owner != null) ? owner.GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) : null);
									}
									ULGUIPlayTweenComponent ulguiplayTweenComponent = obj as ULGUIPlayTweenComponent;
									if (ulguiplayTweenComponent != null)
									{
										ulguiplayTweenComponent.Play();
									}
								}
							}
							else
							{
								UUINiagara niagara2 = uiNiagara;
								jsonElement = jsonProperty.Value;
								VisionArenaScoreItem.<UpdateWaveEffect>g__Func|21_0(niagara2, jsonElement);
							}
						}
						else
						{
							UUINiagara niagara3 = uiNiagara2;
							jsonElement = jsonProperty.Value;
							VisionArenaScoreItem.<UpdateWaveEffect>g__Func|21_0(niagara3, jsonElement);
						}
					}
				}
				catch (Exception item2)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Battle;
					ELogAuthor author = ELogAuthor.LPH;
					string message = "VisionArenaScoreItem 解析配置失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("config", text);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", item2);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
		}

		// Token: 0x0603CFA5 RID: 249765 RVA: 0x00EA90A8 File Offset: 0x00EA72A8
		[CompilerGenerated]
		private UniTask <HideScore>g__HideAfterAnimation|18_0()
		{
			VisionArenaScoreItem.<<HideScore>g__HideAfterAnimation|18_0>d <<HideScore>g__HideAfterAnimation|18_0>d;
			<<HideScore>g__HideAfterAnimation|18_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<HideScore>g__HideAfterAnimation|18_0>d.<>4__this = this;
			<<HideScore>g__HideAfterAnimation|18_0>d.<>1__state = -1;
			<<HideScore>g__HideAfterAnimation|18_0>d.<>t__builder.Start<VisionArenaScoreItem.<<HideScore>g__HideAfterAnimation|18_0>d>(ref <<HideScore>g__HideAfterAnimation|18_0>d);
			return <<HideScore>g__HideAfterAnimation|18_0>d.<>t__builder.Task;
		}

		// Token: 0x0603CFAA RID: 249770 RVA: 0x00EA92DC File Offset: 0x00EA74DC
		[CompilerGenerated]
		internal static void <UpdateWaveEffect>g__Func|21_0(UUINiagara niagara, in JsonElement configData)
		{
			if (configData.ValueKind == JsonValueKind.Null)
			{
				return;
			}
			foreach (JsonProperty jsonProperty in configData.EnumerateObject())
			{
				if (jsonProperty.Value.ValueKind != JsonValueKind.Null)
				{
					if (jsonProperty.Name.Contains("Color"))
					{
						if (niagara != null)
						{
							string name = jsonProperty.Name;
							FColor fcolor = FColor.FromHex(jsonProperty.Value.GetString());
							niagara.SetNiagaraVarLinearColor(name, new FLinearColor(ref fcolor));
						}
					}
					else if (niagara != null)
					{
						niagara.SetNiagaraVarFloat(jsonProperty.Name, float.Parse(jsonProperty.Value.GetString()));
					}
				}
			}
		}

		// Token: 0x0401FC5A RID: 130138
		[Nullable(1)]
		private const string WAVE_NIAGARA_PATH = "/Game/Aki/Effect/UI/Niagaras/Shengyuan/NI_Fx_LGUI_SoundRing.NI_Fx_LGUI_SoundRing";

		// Token: 0x0401FC5B RID: 130139
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401FC5C RID: 130140
		private UNiagaraSystem WaveNiagara;

		// Token: 0x0401FC5D RID: 130141
		private UUINiagara WaveUiNiagara;

		// Token: 0x0401FC5E RID: 130142
		private IReadOnlyList<BattleScoreLevelConf> ScoreLevelConfigList;

		// Token: 0x0401FC5F RID: 130143
		private BattleScoreLevelConf? CurrentLevelConfig;

		// Token: 0x0401FC60 RID: 130144
		private bool IsDirty;

		// Token: 0x0401FC61 RID: 130145
		private int CurrentLevel;

		// Token: 0x0200C0B1 RID: 49329
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A256 RID: 238166
			WaveNiagara,
			// Token: 0x0403A257 RID: 238167
			NowSprite,
			// Token: 0x0403A258 RID: 238168
			TextureBg,
			// Token: 0x0403A259 RID: 238169
			ProgressNiagara,
			// Token: 0x0403A25A RID: 238170
			BurstNiagara,
			// Token: 0x0403A25B RID: 238171
			BurstAnimationActor,
			// Token: 0x0403A25C RID: 238172
			NextSprite
		}
	}
}
