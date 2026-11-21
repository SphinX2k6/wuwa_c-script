using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Game.Module.Activity.ActivityContent.Tetris.Activity;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FDA RID: 12250
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisSelectLevelItemDetailPanel : UiPanelBase
	{
		// Token: 0x0601D14B RID: 119115 RVA: 0x008E3560 File Offset: 0x008E1760
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickedSelectButton))
			};
		}

		// Token: 0x0601D14C RID: 119116 RVA: 0x008E37C4 File Offset: 0x008E19C4
		private void InitTickSystem()
		{
			this.TickId = TickSystem.Instance.Add(new Action<float>(this.RefreshTimeTick), "TetrisSelectLevelItemDetailPanel", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
			if (this.TickId != -1)
			{
				TickSystem.Instance.Pause(this.TickId);
			}
		}

		// Token: 0x0601D14D RID: 119117 RVA: 0x008E3815 File Offset: 0x008E1A15
		protected override void OnStart()
		{
			this.InitTickSystem();
			this.LevelData = (this.OpenParam as TetrisSelectGroupData);
			this.ViewSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0601D14E RID: 119118 RVA: 0x008E383F File Offset: 0x008E1A3F
		protected override void OnBeforeShow()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Resume(this.TickId);
			}
		}

		// Token: 0x0601D14F RID: 119119 RVA: 0x008E385C File Offset: 0x008E1A5C
		public void Refresh(TetrisSelectGroupData data)
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

		// Token: 0x0601D150 RID: 119120 RVA: 0x008E38FB File Offset: 0x008E1AFB
		protected override void OnAfterHide()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Pause(this.TickId);
			}
		}

		// Token: 0x0601D151 RID: 119121 RVA: 0x008E3917 File Offset: 0x008E1B17
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

		// Token: 0x0601D152 RID: 119122 RVA: 0x008E3954 File Offset: 0x008E1B54
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
			}
			else if (this.IsOpen && this.IsPrevComplete)
			{
				this.RefreshOpenPanel();
			}
			else if (!this.IsOpen || !this.IsPrevComplete)
			{
				this.RefreshLockPanel();
			}
			ActivityTetrisData tetrisData = ActivityTetrisController.Instance.GetTetrisData();
			int? num = (tetrisData != null) ? tetrisData.GetChallengeRecord(this.ChallengeId.Value, 0) : null;
			UUIText text = base.GetText(15);
			if (text != null)
			{
				text.SetUIActive(num != null);
			}
			if (num != null)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "Tetris2UIText_009", new <>z__ReadOnlySingleElementList<object>((num.Value > 0) ? num.Value.ToString() : ConfigMultiTextLang.GetLocalTextNew("Tetris2UIText_008", null)));
			}
		}

		// Token: 0x0601D153 RID: 119123 RVA: 0x008E3A98 File Offset: 0x008E1C98
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
			if (TetrisUtils.IsActivityEggLevel(ActivityTetrisConfig.Instance.GetLevelConfig(this.ChallengeId.Value)))
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

		// Token: 0x0601D154 RID: 119124 RVA: 0x008E3BD0 File Offset: 0x008E1DD0
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
			if (TetrisUtils.IsActivityEggLevel(ActivityTetrisConfig.Instance.GetLevelConfig(this.ChallengeId.Value)))
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

		// Token: 0x0601D155 RID: 119125 RVA: 0x008E3D98 File Offset: 0x008E1F98
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

		// Token: 0x0601D156 RID: 119126 RVA: 0x008E3E64 File Offset: 0x008E2064
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

		// Token: 0x0601D157 RID: 119127 RVA: 0x008E3EE4 File Offset: 0x008E20E4
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

		// Token: 0x0601D158 RID: 119128 RVA: 0x008E3F28 File Offset: 0x008E2128
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

		// Token: 0x0601D159 RID: 119129 RVA: 0x008E3F7C File Offset: 0x008E217C
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

		// Token: 0x0601D15A RID: 119130 RVA: 0x008E4048 File Offset: 0x008E2248
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

		// Token: 0x0400F513 RID: 62739
		[Nullable(2)]
		private TetrisSelectGroupData LevelData;

		// Token: 0x0400F514 RID: 62740
		private bool IsOpen;

		// Token: 0x0400F515 RID: 62741
		private bool IsPrevComplete;

		// Token: 0x0400F516 RID: 62742
		private int? ChallengeId;

		// Token: 0x0400F517 RID: 62743
		[Nullable(2)]
		private LevelSequencePlayer ViewSequencePlayer;

		// Token: 0x0400F518 RID: 62744
		private bool IsComplete;

		// Token: 0x0400F519 RID: 62745
		private int TickId = -1;
	}
}
