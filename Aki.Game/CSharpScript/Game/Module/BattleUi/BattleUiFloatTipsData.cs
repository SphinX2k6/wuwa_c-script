using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C8A RID: 23690
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiFloatTipsData
	{
		// Token: 0x0603BD73 RID: 245107 RVA: 0x00E4AD3A File Offset: 0x00E48F3A
		public void Init()
		{
		}

		// Token: 0x0603BD74 RID: 245108 RVA: 0x00E4AD3C File Offset: 0x00E48F3C
		public void OnLeaveLevel()
		{
			this.CurTip = null;
			this.Tips.Clear();
		}

		// Token: 0x0603BD75 RID: 245109 RVA: 0x00E4AD50 File Offset: 0x00E48F50
		public void Clear()
		{
		}

		// Token: 0x0603BD76 RID: 245110 RVA: 0x00E4AD54 File Offset: 0x00E48F54
		[NullableContext(2)]
		public BattleUiFloatTip GetNextFloatTip()
		{
			BattleUiFloatTip battleUiFloatTip;
			while (this.Tips.TryPop(out battleUiFloatTip))
			{
				if (!this.CheckIsExpired(battleUiFloatTip))
				{
					return battleUiFloatTip;
				}
			}
			return null;
		}

		// Token: 0x0603BD77 RID: 245111 RVA: 0x00E4AD7C File Offset: 0x00E48F7C
		public void PlayNormalFloatTip(string textKey, float duration)
		{
			BattleUiFloatTip tip = new BattleUiFloatTip
			{
				Type = EBattleUiFloatTip.Normal,
				TextKey = textKey,
				EndTime = (float)Time.Instance.WorldTimeSeconds + duration
			};
			this.AddNewFloatTip(tip);
		}

		// Token: 0x0603BD78 RID: 245112 RVA: 0x00E4ADB8 File Offset: 0x00E48FB8
		public void PlayCountdownFloatTip(string textKey, float duration, float countdown)
		{
			BattleUiFloatTip tip = new BattleUiFloatTip
			{
				Type = EBattleUiFloatTip.Countdown,
				TextKey = textKey,
				EndTime = (float)Time.Instance.WorldTimeSeconds + duration,
				CountdownEndTime = (float)Time.Instance.WorldTimeSeconds + countdown
			};
			this.AddNewFloatTip(tip);
		}

		// Token: 0x0603BD79 RID: 245113 RVA: 0x00E4AE08 File Offset: 0x00E49008
		public void AddNewFloatTip(BattleUiFloatTip tip)
		{
			if (this.CurTip == null)
			{
				this.CurTip = tip;
			}
			else
			{
				this.Tips.Add(this.CurTip);
				this.CurTip = tip;
			}
			if (!UiManager.Instance.IsViewOpen(EUiViewName.BattleFloatTipsView))
			{
				UiManager.Instance.OpenView(EUiViewName.BattleFloatTipsView, null, null);
				return;
			}
			EventSystem.Instance.Emit(EEventName.BattleUiFloatTipUpdate);
		}

		// Token: 0x0603BD7A RID: 245114 RVA: 0x00E4AE71 File Offset: 0x00E49071
		public bool CheckIsExpired(BattleUiFloatTip tip)
		{
			return tip.EndTime - (float)Time.Instance.WorldTimeSeconds < 0.1f;
		}

		// Token: 0x0401F324 RID: 127780
		private const float MIN_VALID_TIME = 0.1f;

		// Token: 0x0401F325 RID: 127781
		private readonly List<BattleUiFloatTip> Tips = new List<BattleUiFloatTip>();

		// Token: 0x0401F326 RID: 127782
		[Nullable(2)]
		public BattleUiFloatTip CurTip;
	}
}
