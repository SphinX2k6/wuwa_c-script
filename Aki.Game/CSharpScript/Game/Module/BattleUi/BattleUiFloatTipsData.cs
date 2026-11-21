using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C6B RID: 19563
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiFloatTipsData
	{
		// Token: 0x06030CC1 RID: 199873 RVA: 0x00D9B2B6 File Offset: 0x00D994B6
		public void Init()
		{
		}

		// Token: 0x06030CC2 RID: 199874 RVA: 0x00D9B2B8 File Offset: 0x00D994B8
		public void OnLeaveLevel()
		{
			this.CurTip = null;
			this.Tips.Clear();
		}

		// Token: 0x06030CC3 RID: 199875 RVA: 0x00D9B2CC File Offset: 0x00D994CC
		public void Clear()
		{
		}

		// Token: 0x06030CC4 RID: 199876 RVA: 0x00D9B2D0 File Offset: 0x00D994D0
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

		// Token: 0x06030CC5 RID: 199877 RVA: 0x00D9B2F8 File Offset: 0x00D994F8
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

		// Token: 0x06030CC6 RID: 199878 RVA: 0x00D9B334 File Offset: 0x00D99534
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

		// Token: 0x06030CC7 RID: 199879 RVA: 0x00D9B384 File Offset: 0x00D99584
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

		// Token: 0x06030CC8 RID: 199880 RVA: 0x00D9B3ED File Offset: 0x00D995ED
		public bool CheckIsExpired(BattleUiFloatTip tip)
		{
			return tip.EndTime - (float)Time.Instance.WorldTimeSeconds < 0.1f;
		}

		// Token: 0x04019DDA RID: 105946
		private const float MIN_VALID_TIME = 0.1f;

		// Token: 0x04019DDB RID: 105947
		private readonly List<BattleUiFloatTip> Tips = new List<BattleUiFloatTip>();

		// Token: 0x04019DDC RID: 105948
		[Nullable(2)]
		public BattleUiFloatTip CurTip;
	}
}
