using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x0200600A RID: 24586
	public class TetrisDetailIconPanel : UiPanelBase
	{
		// Token: 0x0603E442 RID: 255042 RVA: 0x00F08894 File Offset: 0x00F06A94
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
		}

		// Token: 0x0603E443 RID: 255043 RVA: 0x00F089FC File Offset: 0x00F06BFC
		[NullableContext(1)]
		public void Refresh(ITetrisSelectGroupData data)
		{
			this.LevelData = data;
			this.ChallengeId = new int?(this.LevelData.ChallengeIds[0]);
			this.IsOpen = ActivityTetrisController.Instance.GetTetrisData().CheckChallengeIsOpen(this.LevelData.ChallengeIds[0]);
			this.IsPrevComplete = ActivityTetrisController.Instance.GetTetrisData().CheckPreChallengeComplete(this.LevelData.ChallengeIds[0]);
			this.IsComplete = this.CheckAllChallengesComplete();
			this.RefreshPanel();
		}

		// Token: 0x0603E444 RID: 255044 RVA: 0x00F08A8C File Offset: 0x00F06C8C
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

		// Token: 0x0603E445 RID: 255045 RVA: 0x00F08B14 File Offset: 0x00F06D14
		private void RefreshCompletePanel()
		{
			if (TetrisUtils.IsEggLevel(ActivityTetrisConfig.Instance.GetLevelConfig(this.ChallengeId.Value)))
			{
				UUIItem item = base.GetItem(14);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUIItem item2 = base.GetItem(13);
				if (item2 != null)
				{
					item2.SetUIActive(false);
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
				UUIItem item3 = base.GetItem(13);
				if (item3 != null)
				{
					item3.SetUIActive(true);
				}
				UUIItem item4 = base.GetItem(14);
				if (item4 != null)
				{
					item4.SetUIActive(false);
				}
			}
			UUIItem item5 = base.GetItem(1);
			if (item5 != null)
			{
				item5.SetUIActive(true);
			}
			UUIItem item6 = base.GetItem(2);
			if (item6 != null)
			{
				item6.SetUIActive(false);
			}
			UUIItem item7 = base.GetItem(3);
			if (item7 != null)
			{
				item7.SetUIActive(false);
			}
			UUIArtText artText3 = base.GetArtText(7);
			if (artText3 != null)
			{
				artText3.SetColor(FColor.FromHex("5c89a0"));
			}
			UUIArtText artText4 = base.GetArtText(8);
			if (artText4 == null)
			{
				return;
			}
			artText4.SetColor(FColor.FromHex("7bffad"));
		}

		// Token: 0x0603E446 RID: 255046 RVA: 0x00F08C30 File Offset: 0x00F06E30
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
			if (item5 == null)
			{
				return;
			}
			item5.SetUIActive(false);
		}

		// Token: 0x0603E447 RID: 255047 RVA: 0x00F08D20 File Offset: 0x00F06F20
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
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(false);
		}

		// Token: 0x0603E448 RID: 255048 RVA: 0x00F08DA0 File Offset: 0x00F06FA0
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

		// Token: 0x04020887 RID: 133255
		[Nullable(2)]
		private ITetrisSelectGroupData LevelData;

		// Token: 0x04020888 RID: 133256
		private int? ChallengeId;

		// Token: 0x04020889 RID: 133257
		private bool IsOpen;

		// Token: 0x0402088A RID: 133258
		private bool IsPrevComplete;

		// Token: 0x0402088B RID: 133259
		private bool IsComplete;
	}
}
