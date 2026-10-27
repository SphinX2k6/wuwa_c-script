using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02006012 RID: 24594
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisSelectLevelItemDetailPanel : UiPanelBase
	{
		// Token: 0x0603E488 RID: 255112 RVA: 0x00F0A964 File Offset: 0x00F08B64
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIArtText)),
				new ValueTuple<int, Type>(8, typeof(UUIArtText)),
				new ValueTuple<int, Type>(9, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUIText)),
				new ValueTuple<int, Type>(11, typeof(UUIText)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickedSelectButton))
			};
		}

		// Token: 0x0603E489 RID: 255113 RVA: 0x00F0AAF0 File Offset: 0x00F08CF0
		private void InitTickSystem()
		{
			this.TickId = TickSystem.Instance.Add(new Action<float>(this.RefreshTimeTick), "TetrisSelectLevelItemDetailPanel", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
			if (this.TickId != -1)
			{
				TickSystem.Instance.Pause(this.TickId);
			}
		}

		// Token: 0x0603E48A RID: 255114 RVA: 0x00F0AB41 File Offset: 0x00F08D41
		protected override void OnStart()
		{
			this.InitTickSystem();
			this.LevelData = (this.OpenParam as ITetrisSelectGroupData);
			this.ViewSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603E48B RID: 255115 RVA: 0x00F0AB6B File Offset: 0x00F08D6B
		protected override void OnBeforeShow()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Resume(this.TickId);
			}
		}

		// Token: 0x0603E48C RID: 255116 RVA: 0x00F0AB88 File Offset: 0x00F08D88
		public void Refresh(ITetrisSelectGroupData data)
		{
			this.LevelData = data;
			this.ChallengeId = new int?(this.LevelData.ChallengeIds[0]);
			this.IsOpen = ActivityTetrisController.Instance.GetTetrisData().CheckChallengeIsOpen(this.LevelData.ChallengeIds[0]);
			this.IsPrevComplete = ActivityTetrisController.Instance.GetTetrisData().CheckPreChallengeComplete(this.LevelData.ChallengeIds[0]);
			this.IsComplete = this.CheckAllChallengesComplete();
			this.RefreshPanel();
			this.RefreshRedPoint();
			this.PlayAnim("Start");
		}

		// Token: 0x0603E48D RID: 255117 RVA: 0x00F0AC27 File Offset: 0x00F08E27
		protected override void OnAfterHide()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Pause(this.TickId);
			}
		}

		// Token: 0x0603E48E RID: 255118 RVA: 0x00F0AC43 File Offset: 0x00F08E43
		protected override void OnBeforeDestroy()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Remove(this.TickId);
				this.TickId = -1;
			}
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.Clear();
			}
			this.ViewSequencePlayer = null;
		}

		// Token: 0x0603E48F RID: 255119 RVA: 0x00F0AC80 File Offset: 0x00F08E80
		private void RefreshPanel()
		{
			UUIArtText artText = base.GetArtText(7);
			if (artText != null)
			{
				artText.SetText("0");
			}
			UUIArtText artText2 = base.GetArtText(8);
			if (artText2 != null)
			{
				artText2.SetText(this.LevelData.GroupId.ToString());
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), ActivityTetrisConfig.Instance.GetLevelConfig(this.ChallengeId.Value).TotalLevelName, Array.Empty<object>());
			if (this.IsComplete)
			{
				this.RefreshCompletePanel();
				return;
			}
			if (this.IsOpen && this.IsPrevComplete)
			{
				this.RefreshOpenPanel();
				return;
			}
			if (!this.IsOpen || !this.IsPrevComplete)
			{
				this.RefreshLockPanel();
			}
		}

		// Token: 0x0603E490 RID: 255120 RVA: 0x00F0AD3C File Offset: 0x00F08F3C
		private void RefreshCompletePanel()
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(3);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			if (TetrisUtils.IsEggLevel(ActivityTetrisConfig.Instance.GetLevelConfig(this.ChallengeId.Value)))
			{
				UUIItem item4 = base.GetItem(14);
				if (item4 != null)
				{
					item4.SetUIActive(true);
				}
				UUIItem item5 = base.GetItem(13);
				if (item5 != null)
				{
					item5.SetUIActive(false);
				}
				UUIArtText artText = base.GetArtText(7);
				if (artText != null)
				{
					artText.SetText("");
				}
				UUIArtText artText2 = base.GetArtText(8);
				if (artText2 != null)
				{
					artText2.SetText("");
				}
			}
			else
			{
				UUIItem item6 = base.GetItem(13);
				if (item6 != null)
				{
					item6.SetUIActive(true);
				}
				UUIItem item7 = base.GetItem(14);
				if (item7 != null)
				{
					item7.SetUIActive(false);
				}
			}
			UUIArtText artText3 = base.GetArtText(7);
			if (artText3 != null)
			{
				artText3.SetColor(FColor.FromHex("5c89a0"));
			}
			UUIArtText artText4 = base.GetArtText(8);
			if (artText4 != null)
			{
				artText4.SetColor(FColor.FromHex("7bffad"));
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "Tetristext_03", Array.Empty<object>());
		}

		// Token: 0x0603E491 RID: 255121 RVA: 0x00F0AE74 File Offset: 0x00F09074
		private void RefreshOpenPanel()
		{
			UUIArtText artText = base.GetArtText(7);
			if (artText != null)
			{
				artText.SetColor(FColor.FromHex("9277fc"));
			}
			UUIArtText artText2 = base.GetArtText(8);
			if (artText2 != null)
			{
				artText2.SetColor(FColor.FromHex("ebd4ff"));
			}
			if (TetrisUtils.IsEggLevel(ActivityTetrisConfig.Instance.GetLevelConfig(this.ChallengeId.Value)))
			{
				UUIItem item = base.GetItem(6);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUIItem item2 = base.GetItem(5);
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
				UUIArtText artText3 = base.GetArtText(7);
				if (artText3 != null)
				{
					artText3.SetText("");
				}
				UUIArtText artText4 = base.GetArtText(8);
				if (artText4 != null)
				{
					artText4.SetText("");
				}
			}
			UUIItem item3 = base.GetItem(2);
			if (item3 != null)
			{
				item3.SetUIActive(true);
			}
			UUIItem item4 = base.GetItem(1);
			if (item4 != null)
			{
				item4.SetUIActive(false);
			}
			UUIItem item5 = base.GetItem(3);
			if (item5 != null)
			{
				item5.SetUIActive(false);
			}
			int num = 0;
			foreach (int challengeId in this.LevelData.ChallengeIds)
			{
				if (ActivityTetrisController.Instance.GetTetrisData().CheckChallengeComplete(challengeId))
				{
					num++;
				}
			}
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey("Tetristext_04", "Tetristext_04");
			UUIText text = base.GetText(11);
			string str = multiTextByKey;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.LevelData.ChallengeIds.Count);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			text.SetText(str + defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0603E492 RID: 255122 RVA: 0x00F0B03C File Offset: 0x00F0923C
		private void RefreshLockPanel()
		{
			UUIArtText artText = base.GetArtText(7);
			if (artText != null)
			{
				artText.SetColor(FColor.FromHex("4c4c4c"));
			}
			UUIArtText artText2 = base.GetArtText(8);
			if (artText2 != null)
			{
				artText2.SetColor(FColor.FromHex("8f8f8e"));
			}
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(2);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			if (!this.IsOpen)
			{
				base.GetText(4).SetText(ActivityTetrisController.Instance.GetTetrisData().GetUnlockDesc(this.ChallengeId.Value), true);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "Tetristext_12", Array.Empty<object>());
		}

		// Token: 0x0603E493 RID: 255123 RVA: 0x00F0B108 File Offset: 0x00F09308
		private bool CheckAllChallengesComplete()
		{
			ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
			if (tetrisData == null || this.LevelData == null)
			{
				return false;
			}
			foreach (int challengeId in this.LevelData.ChallengeIds)
			{
				if (!tetrisData.CheckChallengeComplete(challengeId))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603E494 RID: 255124 RVA: 0x00F0B184 File Offset: 0x00F09384
		private void RefreshRedPoint()
		{
			ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
			if (tetrisData == null)
			{
				return;
			}
			bool uiactive = tetrisData.CheckGroupRedPointShow(this.LevelData.ChallengeIds);
			UUIItem item = base.GetItem(12);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x0603E495 RID: 255125 RVA: 0x00F0B1C8 File Offset: 0x00F093C8
		public void PlayAnim(string sequenceName)
		{
			if (this.ViewSequencePlayer.GetCurrentSequence() == sequenceName)
			{
				this.ViewSequencePlayer.ReplaySequenceByKey(sequenceName);
				return;
			}
			this.ViewSequencePlayer.StopPlayingSequence(false, true);
			this.ViewSequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
		}

		// Token: 0x0603E496 RID: 255126 RVA: 0x00F0B21C File Offset: 0x00F0941C
		public void RefreshTimeTick(float deltaTime)
		{
			if (ActivityTetrisController.Instance.GetTetrisData() == null)
			{
				return;
			}
			if (this.LevelData == null)
			{
				return;
			}
			bool isOpen = this.IsOpen;
			this.IsOpen = ActivityTetrisController.Instance.GetTetrisData().CheckChallengeIsOpen(this.LevelData.ChallengeIds[0]);
			if (isOpen != this.IsOpen)
			{
				this.IsPrevComplete = ActivityTetrisController.Instance.GetTetrisData().CheckPreChallengeComplete(this.LevelData.ChallengeIds[0]);
				this.IsComplete = this.CheckAllChallengesComplete();
				this.RefreshPanel();
				this.RefreshRedPoint();
				return;
			}
			if (!this.IsOpen)
			{
				base.GetText(4).SetText(ActivityTetrisController.Instance.GetTetrisData().GetUnlockDesc(this.ChallengeId.Value), true);
			}
		}

		// Token: 0x0603E497 RID: 255127 RVA: 0x00F0B2E4 File Offset: 0x00F094E4
		private void OnClickedSelectButton()
		{
			if (!this.IsOpen)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Encirle_LevelLockTips_Text", Array.Empty<object>());
				return;
			}
			if (this.IsPrevComplete)
			{
				UiManager.Instance.OpenView(EUiViewName.TetrisLevelDetailView, this.LevelData, null);
				return;
			}
			int unlockId = ActivityTetrisConfig.Instance.GetLevelConfig(this.ChallengeId.Value).UnlockId;
			if (unlockId == 0)
			{
				return;
			}
			string levelName = ActivityTetrisConfig.Instance.GetLevelConfig(unlockId).LevelName;
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(levelName, levelName);
			ScrollingTipsController.Instance.ShowTipsByTextId("Encirle_DifficultyLockTips_Text", new object[]
			{
				multiTextByKey
			});
		}

		// Token: 0x040208CC RID: 133324
		[Nullable(2)]
		private ITetrisSelectGroupData LevelData;

		// Token: 0x040208CD RID: 133325
		private bool IsOpen;

		// Token: 0x040208CE RID: 133326
		private bool IsPrevComplete;

		// Token: 0x040208CF RID: 133327
		private int? ChallengeId;

		// Token: 0x040208D0 RID: 133328
		[Nullable(2)]
		private LevelSequencePlayer ViewSequencePlayer;

		// Token: 0x040208D1 RID: 133329
		private bool IsComplete;

		// Token: 0x040208D2 RID: 133330
		private int TickId = -1;
	}
}
