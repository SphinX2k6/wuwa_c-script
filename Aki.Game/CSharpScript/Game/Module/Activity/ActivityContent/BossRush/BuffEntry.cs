using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.BossRush
{
	// Token: 0x02006907 RID: 26887
	public class BuffEntry : UiPanelBase
	{
		// Token: 0x060430B5 RID: 274613 RVA: 0x010559E8 File Offset: 0x01053BE8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickEntryButton))
			};
		}

		// Token: 0x060430B6 RID: 274614 RVA: 0x01055AEC File Offset: 0x01053CEC
		private void OnClickEntryButton()
		{
			BossRushBuffInfo currentSelectBuff = this.CurrentSelectBuff;
			if (currentSelectBuff != null && currentSelectBuff.State == BossRushBuffSelectionStatus.BuffLocked)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("BossRushLock", Array.Empty<object>());
				return;
			}
			BossRushBuffInfo currentSelectBuff2 = this.CurrentSelectBuff;
			if (currentSelectBuff2 != null && currentSelectBuff2.State == BossRushBuffSelectionStatus.BuffInactive)
			{
				return;
			}
			BossRushModel.Instance.CurrentChangeBuffSlot = this.SlotIndex;
			EventSystem.Instance.Emit<EUiTabViewName>(EEventName.RequestChangeBossRushView, EUiTabViewName.BossRushBuffSelectView);
		}

		// Token: 0x060430B7 RID: 274615 RVA: 0x01055B64 File Offset: 0x01053D64
		[NullableContext(1)]
		public void Refresh(BossRushBuffInfo buff)
		{
			this.CurrentSelectBuff = buff;
			if (buff.State == BossRushBuffSelectionStatus.BuffInactive)
			{
				UUIButtonComponent button = base.GetButton(0);
				if (button != null)
				{
					button.SetSelfInteractive(false);
				}
			}
			else
			{
				UUIButtonComponent button2 = base.GetButton(0);
				if (button2 != null)
				{
					button2.SetSelectionState(EUISelectableSelectionState.Normal);
				}
				UUIButtonComponent button3 = base.GetButton(0);
				if (button3 != null)
				{
					button3.SetSelfInteractive(true);
				}
			}
			this.RefreshNoneShow();
			this.RefreshBuffInfo();
			this.RefreshLockItemState();
			this.RefreshSwitchButton();
			this.RefreshBuffTips();
		}

		// Token: 0x060430B8 RID: 274616 RVA: 0x01055BDC File Offset: 0x01053DDC
		private void RefreshBuffTips()
		{
			if (this.CurrentSelectBuff == null)
			{
				return;
			}
			string textStringId;
			if (this.CurrentSelectBuff.State == BossRushBuffSelectionStatus.BuffLocked)
			{
				textStringId = "BossRushLock";
			}
			else if (this.CurrentSelectBuff.State == BossRushBuffSelectionStatus.BuffInactive)
			{
				textStringId = "BossRushBuffDisableTips";
			}
			else
			{
				textStringId = "BossRushBuffSelectTips";
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textStringId, Array.Empty<object>());
		}

		// Token: 0x060430B9 RID: 274617 RVA: 0x01055C41 File Offset: 0x01053E41
		private void RefreshLockItemState()
		{
			if (this.CurrentSelectBuff == null)
			{
				return;
			}
			base.GetItem(8).SetUIActive(this.CurrentSelectBuff.State == BossRushBuffSelectionStatus.BuffLocked);
		}

		// Token: 0x060430BA RID: 274618 RVA: 0x01055C66 File Offset: 0x01053E66
		private void RefreshSwitchButton()
		{
			if (this.CurrentSelectBuff == null)
			{
				return;
			}
			base.GetItem(7).SetUIActive(this.CurrentSelectBuff.BuffId != 0 && this.CurrentSelectBuff.State != BossRushBuffSelectionStatus.BuffLocked);
		}

		// Token: 0x060430BB RID: 274619 RVA: 0x01055C9E File Offset: 0x01053E9E
		private void RefreshNoneShow()
		{
			if (this.CurrentSelectBuff == null)
			{
				return;
			}
			base.GetItem(1).SetUIActive(this.CurrentSelectBuff.BuffId == 0);
			base.GetItem(2).SetUIActive(this.CurrentSelectBuff.BuffId != 0);
		}

		// Token: 0x060430BC RID: 274620 RVA: 0x01055CDD File Offset: 0x01053EDD
		private void RefreshBuffInfo()
		{
			if (this.CurrentSelectBuff == null || this.CurrentSelectBuff.BuffId == 0)
			{
				return;
			}
			this.RefreshBuffName();
			this.RefreshBuffDesc();
			this.RefreshBuffTexture();
		}

		// Token: 0x060430BD RID: 274621 RVA: 0x01055D08 File Offset: 0x01053F08
		private void RefreshBuffTexture()
		{
			if (this.CurrentSelectBuff == null)
			{
				return;
			}
			BossRushBuff? bossRushBuffConfigById = BossRushConfig.Instance.GetBossRushBuffConfigById(this.CurrentSelectBuff.BuffId);
			if (bossRushBuffConfigById == null)
			{
				return;
			}
			string texture = bossRushBuffConfigById.Value.Texture;
			base.SetTextureByPath(texture, base.GetTexture(4), null, null);
		}

		// Token: 0x060430BE RID: 274622 RVA: 0x01055D68 File Offset: 0x01053F68
		private void RefreshBuffDesc()
		{
			if (this.CurrentSelectBuff == null)
			{
				return;
			}
			BossRushBuff? bossRushBuffConfigById = BossRushConfig.Instance.GetBossRushBuffConfigById(this.CurrentSelectBuff.BuffId);
			if (bossRushBuffConfigById == null)
			{
				return;
			}
			List<string> list = new List<string>();
			foreach (string input in bossRushBuffConfigById.Value.DescriptionParam())
			{
				Match match = new Regex("\\[(.*?)\\]").Match(input);
				if (match.Success && match.Groups.Count > 1)
				{
					string[] collection = match.Groups[1].Value.Split(',', StringSplitOptions.None);
					list.AddRange(collection);
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), bossRushBuffConfigById.Value.Description, list.ToArray());
		}

		// Token: 0x060430BF RID: 274623 RVA: 0x01055E44 File Offset: 0x01054044
		private void RefreshBuffName()
		{
			if (this.CurrentSelectBuff == null)
			{
				return;
			}
			BossRushBuff? bossRushBuffConfigById = BossRushConfig.Instance.GetBossRushBuffConfigById(this.CurrentSelectBuff.BuffId);
			if (bossRushBuffConfigById == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), bossRushBuffConfigById.Value.Name, Array.Empty<object>());
		}

		// Token: 0x060430C0 RID: 274624 RVA: 0x01055E9F File Offset: 0x0105409F
		public bool HaveBuff()
		{
			BossRushBuffInfo currentSelectBuff = this.CurrentSelectBuff;
			return ((currentSelectBuff != null) ? currentSelectBuff.BuffId : 0) > 0;
		}

		// Token: 0x04022E78 RID: 142968
		public int SlotIndex;

		// Token: 0x04022E79 RID: 142969
		[Nullable(2)]
		private BossRushBuffInfo CurrentSelectBuff;
	}
}
