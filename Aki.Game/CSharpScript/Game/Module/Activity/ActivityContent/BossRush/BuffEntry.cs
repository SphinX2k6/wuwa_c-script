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
	// Token: 0x02005857 RID: 22615
	public class BuffEntry : UiPanelBase
	{
		// Token: 0x06037C0D RID: 228365 RVA: 0x00F9701C File Offset: 0x00F9521C
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

		// Token: 0x06037C0E RID: 228366 RVA: 0x00F97120 File Offset: 0x00F95320
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

		// Token: 0x06037C0F RID: 228367 RVA: 0x00F97198 File Offset: 0x00F95398
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

		// Token: 0x06037C10 RID: 228368 RVA: 0x00F97210 File Offset: 0x00F95410
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

		// Token: 0x06037C11 RID: 228369 RVA: 0x00F97275 File Offset: 0x00F95475
		private void RefreshLockItemState()
		{
			if (this.CurrentSelectBuff == null)
			{
				return;
			}
			base.GetItem(8).SetUIActive(this.CurrentSelectBuff.State == BossRushBuffSelectionStatus.BuffLocked);
		}

		// Token: 0x06037C12 RID: 228370 RVA: 0x00F9729A File Offset: 0x00F9549A
		private void RefreshSwitchButton()
		{
			if (this.CurrentSelectBuff == null)
			{
				return;
			}
			base.GetItem(7).SetUIActive(this.CurrentSelectBuff.BuffId != 0 && this.CurrentSelectBuff.State != BossRushBuffSelectionStatus.BuffLocked);
		}

		// Token: 0x06037C13 RID: 228371 RVA: 0x00F972D2 File Offset: 0x00F954D2
		private void RefreshNoneShow()
		{
			if (this.CurrentSelectBuff == null)
			{
				return;
			}
			base.GetItem(1).SetUIActive(this.CurrentSelectBuff.BuffId == 0);
			base.GetItem(2).SetUIActive(this.CurrentSelectBuff.BuffId != 0);
		}

		// Token: 0x06037C14 RID: 228372 RVA: 0x00F97311 File Offset: 0x00F95511
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

		// Token: 0x06037C15 RID: 228373 RVA: 0x00F9733C File Offset: 0x00F9553C
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

		// Token: 0x06037C16 RID: 228374 RVA: 0x00F9739C File Offset: 0x00F9559C
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

		// Token: 0x06037C17 RID: 228375 RVA: 0x00F97478 File Offset: 0x00F95678
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

		// Token: 0x06037C18 RID: 228376 RVA: 0x00F974D3 File Offset: 0x00F956D3
		public bool HaveBuff()
		{
			BossRushBuffInfo currentSelectBuff = this.CurrentSelectBuff;
			return ((currentSelectBuff != null) ? currentSelectBuff.BuffId : 0) > 0;
		}

		// Token: 0x0401D6D4 RID: 120532
		public int SlotIndex;

		// Token: 0x0401D6D5 RID: 120533
		[Nullable(2)]
		private BossRushBuffInfo CurrentSelectBuff;
	}
}
