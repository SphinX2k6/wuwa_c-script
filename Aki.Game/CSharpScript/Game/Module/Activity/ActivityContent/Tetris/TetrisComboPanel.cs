using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FFB RID: 24571
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisComboPanel : UiPanelBase
	{
		// Token: 0x0603E3F6 RID: 254966 RVA: 0x00F071F8 File Offset: 0x00F053F8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIArtText)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIArtText))
			};
		}

		// Token: 0x0603E3F7 RID: 254967 RVA: 0x00F072D6 File Offset: 0x00F054D6
		protected override void OnStart()
		{
			this.GemList = new GenericLayout<TetrisComboGemGrid, ITetrisGemGetData>(base.GetHorizontalLayout(3), new Func<TetrisComboGemGrid>(this.CreateGemItem), null, false, true);
			this.ViewSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603E3F8 RID: 254968 RVA: 0x00F0730A File Offset: 0x00F0550A
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.Clear();
			}
			this.ViewSequencePlayer = null;
		}

		// Token: 0x0603E3F9 RID: 254969 RVA: 0x00F07324 File Offset: 0x00F05524
		private TetrisComboGemGrid CreateGemItem()
		{
			return new TetrisComboGemGrid();
		}

		// Token: 0x0603E3FA RID: 254970 RVA: 0x00F0732C File Offset: 0x00F0552C
		public void Refresh(IComboData data)
		{
			if (data.GameMode == EGameMode.GemCollection && data.ClearedLines <= 1 && data.GemList.Count == 0)
			{
				base.SetUiActive(false);
				AudioSystem.Instance.PostEvent("play_ui_cube_efx_match_level1");
				return;
			}
			base.SetUiActive(true);
			this.RefreshViewSequence(data);
			this.RefreshEvaluation(data.ClearedLines, data.IsBoardEmpty);
			this.RefreshColor(data.ClearedLines, data.IsBoardEmpty);
			this.RefreshScore(data.Score, data.GameMode);
			this.RefreshCombo(data.ComboCount);
			this.RefreshGemList(data.GemList);
		}

		// Token: 0x0603E3FB RID: 254971 RVA: 0x00F073CC File Offset: 0x00F055CC
		private void RefreshViewSequence(IComboData data)
		{
			if (data.IsBoardEmpty)
			{
				this.ViewSequencePlayer.PlayLevelSequenceByName("Yellow", false, null, false);
				return;
			}
			if (data.ClearedLines >= 4)
			{
				this.ViewSequencePlayer.PlayLevelSequenceByName("Red", false, null, false);
				return;
			}
			this.ViewSequencePlayer.PlayLevelSequenceByName("Normal", false, null, false);
		}

		// Token: 0x0603E3FC RID: 254972 RVA: 0x00F07440 File Offset: 0x00F05640
		private void RefreshEvaluation(int clearedLines, bool isBoardEmpty)
		{
			UUIItem item = base.GetItem(1);
			UUITexture texture = base.GetTexture(2);
			if (item == null || texture == null)
			{
				return;
			}
			if (clearedLines <= 1 && !isBoardEmpty)
			{
				item.SetUIActive(false);
				AudioSystem.Instance.PostEvent("play_ui_cube_efx_match_level1");
				return;
			}
			item.SetUIActive(true);
			EComboTexturePath value = EComboTexturePath.Good;
			if (isBoardEmpty)
			{
				value = EComboTexturePath.Unbelievable;
			}
			else if (clearedLines >= 4)
			{
				value = EComboTexturePath.Excellent;
			}
			else if (clearedLines >= 3)
			{
				value = EComboTexturePath.Great;
				AudioSystem.Instance.PostEvent("play_ui_cube_efx_match_level2");
			}
			else if (clearedLines >= 2)
			{
				AudioSystem.Instance.PostEvent("play_ui_cube_efx_match_level2");
			}
			base.SetTextureByPath(value.ToEnumString(), texture, null, null);
		}

		// Token: 0x0603E3FD RID: 254973 RVA: 0x00F074E0 File Offset: 0x00F056E0
		private void RefreshColor(int clearedLines, bool isBoardEmpty)
		{
			EComboTextColor ecomboTextColor = EComboTextColor.Good;
			EComboBgTexturePath value = EComboBgTexturePath.Good;
			if (isBoardEmpty)
			{
				ecomboTextColor = EComboTextColor.Unbelievable;
				value = EComboBgTexturePath.Unbelievable;
			}
			else if (clearedLines >= 4)
			{
				ecomboTextColor = EComboTextColor.Excellent;
				value = EComboBgTexturePath.Excellent;
			}
			else if (clearedLines >= 3)
			{
				value = EComboBgTexturePath.Great;
				ecomboTextColor = EComboTextColor.Great;
			}
			else if (clearedLines <= 1)
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

		// Token: 0x0603E3FE RID: 254974 RVA: 0x00F07558 File Offset: 0x00F05758
		private void RefreshScore(int score, EGameMode gameMode)
		{
			UUIItem item = base.GetItem(5);
			UUIArtText artText = base.GetArtText(6);
			if (item == null || artText == null)
			{
				return;
			}
			bool flag = gameMode != EGameMode.GemCollection && score > 0;
			item.SetUIActive(flag);
			if (flag)
			{
				artText.SetText("+" + score.ToString());
			}
		}

		// Token: 0x0603E3FF RID: 254975 RVA: 0x00F075AC File Offset: 0x00F057AC
		private void RefreshCombo(int comboCount)
		{
			UUIItem item = base.GetItem(7);
			UUIArtText artText = base.GetArtText(8);
			if (item == null || artText == null)
			{
				return;
			}
			bool flag = comboCount >= 2;
			item.SetUIActive(flag);
			if (flag)
			{
				artText.SetText(comboCount.ToString());
			}
		}

		// Token: 0x0603E400 RID: 254976 RVA: 0x00F075F0 File Offset: 0x00F057F0
		private void RefreshGemList(List<ITetrisGemGetData> gemList)
		{
			if (gemList.Count == 0)
			{
				base.GetHorizontalLayout(3).RootUIComp.Get().SetUIActive(false);
				return;
			}
			base.GetHorizontalLayout(3).RootUIComp.Get().SetUIActive(true);
			base.GetItem(5).SetUIActive(false);
			this.GemList.RefreshByData(gemList, null, false);
		}

		// Token: 0x0402083E RID: 133182
		[StaticVariableRuleIgnore]
		public static EComboTextColor CurrentComboColorHex;

		// Token: 0x0402083F RID: 133183
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<TetrisComboGemGrid, ITetrisGemGetData> GemList;

		// Token: 0x04020840 RID: 133184
		[Nullable(2)]
		private LevelSequencePlayer ViewSequencePlayer;
	}
}
