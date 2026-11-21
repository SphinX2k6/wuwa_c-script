using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FC4 RID: 12228
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisComboPanel : UiPanelBase
	{
		// Token: 0x17002E25 RID: 11813
		// (get) Token: 0x0601D073 RID: 118899 RVA: 0x008DDA78 File Offset: 0x008DBC78
		// (set) Token: 0x0601D074 RID: 118900 RVA: 0x008DDA7F File Offset: 0x008DBC7F
		[StaticVariableRuleIgnore]
		public static EComboTextColor CurrentComboColorHex { get; private set; }

		// Token: 0x0601D075 RID: 118901 RVA: 0x008DDA88 File Offset: 0x008DBC88
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601D076 RID: 118902 RVA: 0x008DDC40 File Offset: 0x008DBE40
		protected override void OnStart()
		{
			this.GemList = new GenericLayout<TetrisComboGemGrid, TetrisGemGetData>(base.GetHorizontalLayout(3), new Func<TetrisComboGemGrid>(this.CreateGemItem), null, false, true);
			this.ViewSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.ViewSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
		}

		// Token: 0x0601D077 RID: 118903 RVA: 0x008DDC97 File Offset: 0x008DBE97
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.Clear();
			}
			this.ViewSequencePlayer = null;
		}

		// Token: 0x0601D078 RID: 118904 RVA: 0x008DDCB1 File Offset: 0x008DBEB1
		private TetrisComboGemGrid CreateGemItem()
		{
			return new TetrisComboGemGrid();
		}

		// Token: 0x0601D079 RID: 118905 RVA: 0x008DDCB8 File Offset: 0x008DBEB8
		public void Refresh(ComboData data)
		{
			if (data != null && data.GameMode == EGameMode.GemCollection)
			{
				TetrisClearInfo clearInfo = data.ClearInfo;
				if (clearInfo.Lines <= 1 && !clearInfo.IsBombExplosion)
				{
					Dictionary<EGemType, int> collectedGems = clearInfo.CollectedGems;
					if (collectedGems != null && collectedGems.Count == 0)
					{
						base.SetUiActive(false);
						AudioSystem.Instance.PostEvent("play_ui_cube_efx_match_level1");
						return;
					}
				}
			}
			base.SetUiActive(true);
			UUIItem item = base.GetItem(11);
			if (item != null)
			{
				item.SetUIActive(data.GameMode != EGameMode.GemCollection || data.ClearInfo.CollectedGems.Count != 0);
			}
			this.RefreshViewSequence(data);
			this.RefreshEvaluation(data);
			this.RefreshColor(data.ClearInfo);
			this.RefreshScore(data.Score, data.GameMode);
			this.RefreshCombo(data);
			this.RefreshBoom(data);
			List<TetrisGemGetData> list = new List<TetrisGemGetData>();
			foreach (KeyValuePair<EGemType, int> keyValuePair in data.ClearInfo.CollectedGems)
			{
				list.Add(new TetrisGemGetData
				{
					GemId = (int)keyValuePair.Key,
					GetGemCount = keyValuePair.Value
				});
			}
			this.RefreshGemList(list);
		}

		// Token: 0x0601D07A RID: 118906 RVA: 0x008DDE08 File Offset: 0x008DC008
		private void RefreshViewSequence(ComboData data)
		{
			if (data.ClearInfo.IsBoardAllCleared)
			{
				this.PlaySequence("Yellow");
				return;
			}
			if (data.ClearInfo.Lines >= 4)
			{
				this.PlaySequence("Red");
				return;
			}
			this.PlaySequence("Normal");
		}

		// Token: 0x0601D07B RID: 118907 RVA: 0x008DDE5C File Offset: 0x008DC05C
		private void RefreshEvaluation(ComboData data)
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				UUITexture texture = base.GetTexture(2);
				if (texture != null)
				{
					TetrisClearInfo clearInfo = data.ClearInfo;
					if (!clearInfo.IsBombExplosion && clearInfo.Lines <= 1 && !clearInfo.IsBoardAllCleared)
					{
						item.SetUIActive(false);
						AudioSystem.Instance.PostEvent("play_ui_cube_efx_match_level1");
						return;
					}
					if (data.ClearInfo.IsBombExplosion)
					{
						if (data.ClearInfo.IsBoardAllCleared)
						{
							item.SetUIActive(true);
							base.SetTextureByPath(EComboTexturePath.Unbelievable.ToEnumString(), texture, null, null);
						}
						else
						{
							item.SetUIActive(false);
						}
						AudioSystem.Instance.PostEvent("play_ui_cube_efx_match_level2");
						return;
					}
					item.SetUIActive(true);
					EComboTexturePath value = EComboTexturePath.Good;
					if (data.ClearInfo.IsBoardAllCleared)
					{
						value = EComboTexturePath.Unbelievable;
					}
					else
					{
						int lines = data.ClearInfo.Lines;
						if (lines >= 3)
						{
							if (lines < 4)
							{
								value = EComboTexturePath.Great;
								AudioSystem.Instance.PostEvent("play_ui_cube_efx_match_level2");
							}
							else
							{
								value = EComboTexturePath.Excellent;
							}
						}
						else if (lines >= 2)
						{
							AudioSystem.Instance.PostEvent("play_ui_cube_efx_match_level2");
						}
					}
					base.SetTextureByPath(value.ToEnumString(), texture, null, null);
					return;
				}
			}
		}

		// Token: 0x0601D07C RID: 118908 RVA: 0x008DDF94 File Offset: 0x008DC194
		private void RefreshColor(TetrisClearInfo clearInfo)
		{
			EComboTextColor ecomboTextColor = EComboTextColor.Good;
			EComboBgTexturePath value = EComboBgTexturePath.Good;
			if (clearInfo.IsBoardAllCleared)
			{
				ecomboTextColor = EComboTextColor.Unbelievable;
				value = EComboBgTexturePath.Unbelievable;
			}
			else if (clearInfo.IsBombExplosion)
			{
				ecomboTextColor = EComboTextColor.Combo;
				value = EComboBgTexturePath.Combo;
			}
			else if (clearInfo.Lines >= 4)
			{
				ecomboTextColor = EComboTextColor.Excellent;
				value = EComboBgTexturePath.Excellent;
			}
			else if (clearInfo.Lines >= 3)
			{
				value = EComboBgTexturePath.Great;
				ecomboTextColor = EComboTextColor.Great;
			}
			else if (clearInfo.Lines <= 1)
			{
				ecomboTextColor = EComboTextColor.Default;
				value = EComboBgTexturePath.Default;
			}
			TetrisComboPanel.CurrentComboColorHex = ecomboTextColor;
			FColor color = FColor.FromHex(ecomboTextColor.ToEnumString());
			base.SetTextureByPath(value.ToEnumString(), base.GetTexture(0), null, null);
			UUIArtText artText = base.GetArtText(6);
			if (artText == null)
			{
				return;
			}
			artText.SetColor(color);
		}

		// Token: 0x0601D07D RID: 118909 RVA: 0x008DE034 File Offset: 0x008DC234
		private void RefreshScore(int score, EGameMode gameMode)
		{
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				UUIArtText artText = base.GetArtText(6);
				if (artText != null)
				{
					bool flag = gameMode != EGameMode.GemCollection && score > 0;
					item.SetUIActive(flag);
					if (flag)
					{
						artText.SetText("+" + score.ToString());
					}
					return;
				}
			}
		}

		// Token: 0x0601D07E RID: 118910 RVA: 0x008DE088 File Offset: 0x008DC288
		private void RefreshCombo(ComboData data)
		{
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				UUIArtText artText = base.GetArtText(8);
				if (artText != null)
				{
					bool flag = data != null && !data.ClearInfo.IsBombExplosion && data.ComboCount >= 2;
					item.SetUIActive(flag);
					if (flag)
					{
						artText.SetText(data.ComboCount.ToString());
					}
					return;
				}
			}
		}

		// Token: 0x0601D07F RID: 118911 RVA: 0x008DE0F0 File Offset: 0x008DC2F0
		private void RefreshBoom(ComboData data)
		{
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				UUIArtText artText = base.GetArtText(10);
				if (artText != null)
				{
					TetrisClearInfo clearInfo = data.ClearInfo;
					bool flag = clearInfo.IsBombExplosion && clearInfo.CumulateBombCount > 0;
					item.SetUIActive(flag);
					if (flag)
					{
						artText.SetText(data.ClearInfo.CumulateBombCount.ToString());
					}
					return;
				}
			}
		}

		// Token: 0x0601D080 RID: 118912 RVA: 0x008DE15C File Offset: 0x008DC35C
		private void RefreshGemList(List<TetrisGemGetData> gemList)
		{
			UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(3);
			UUIItem uuiitem = (horizontalLayout != null) ? horizontalLayout.RootUIComp.Get() : null;
			if (uuiitem != null)
			{
				if (gemList.Count == 0)
				{
					uuiitem.SetUIActive(false);
					return;
				}
				uuiitem.SetUIActive(true);
				base.GetItem(5).SetUIActive(false);
				this.GemList.RefreshByData(gemList, null, false);
			}
		}

		// Token: 0x0601D081 RID: 118913 RVA: 0x008DE1BC File Offset: 0x008DC3BC
		private void PlaySequence(string sequenceName)
		{
			if (this.ViewSequencePlayer.GetCurrentSequence() == sequenceName)
			{
				this.ViewSequencePlayer.ReplaySequenceByKey(sequenceName);
				return;
			}
			this.ViewSequencePlayer.StopPlayingSequence(false, true);
			this.ViewSequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
		}

		// Token: 0x0601D082 RID: 118914 RVA: 0x008DE20D File Offset: 0x008DC40D
		private void OnSequenceEndEvent(string sequenceName)
		{
			base.SetUiActive(false);
		}

		// Token: 0x0400F48D RID: 62605
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<TetrisComboGemGrid, TetrisGemGetData> GemList;

		// Token: 0x0400F48E RID: 62606
		[Nullable(2)]
		private LevelSequencePlayer ViewSequencePlayer;

		// Token: 0x02008C4C RID: 35916
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0402C66D RID: 181869
			public const int EvaluationBg = 0;

			// Token: 0x0402C66E RID: 181870
			public const int EvaluationPanel = 1;

			// Token: 0x0402C66F RID: 181871
			public const int EvaluationIcon = 2;

			// Token: 0x0402C670 RID: 181872
			public const int GemListLayout = 3;

			// Token: 0x0402C671 RID: 181873
			public const int GemItem = 4;

			// Token: 0x0402C672 RID: 181874
			public const int ScoreValuePanel = 5;

			// Token: 0x0402C673 RID: 181875
			public const int ScoreValueText = 6;

			// Token: 0x0402C674 RID: 181876
			public const int ComboPanel = 7;

			// Token: 0x0402C675 RID: 181877
			public const int ComboArtText = 8;

			// Token: 0x0402C676 RID: 181878
			public const int BoomPanel = 9;

			// Token: 0x0402C677 RID: 181879
			public const int BoomArtText = 10;

			// Token: 0x0402C678 RID: 181880
			public const int PnlComBg = 11;
		}
	}
}
