using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C2B RID: 19499
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffActivityData : ActivityBaseData
	{
		// Token: 0x0603273B RID: 206651 RVA: 0x00BC1C52 File Offset: 0x00BBFE52
		protected override void OnInit(ActivityData data)
		{
		}

		// Token: 0x0603273C RID: 206652 RVA: 0x00BC1C54 File Offset: 0x00BBFE54
		protected override void PhraseEx(ActivityData data)
		{
			if (base.GetIfFirstOpen() && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 101, 0, 0) == 0)
			{
				ActivityModel.Instance.SaveActivityData(base.Id, 101, 0, 0, 1);
			}
		}

		// Token: 0x0603273D RID: 206653 RVA: 0x00BC1C8A File Offset: 0x00BBFE8A
		public override ERedDotName? GetExternalButtonRedPointName()
		{
			return new ERedDotName?(ERedDotName.CommonActivityPage);
		}

		// Token: 0x0603273E RID: 206654 RVA: 0x00BC1C93 File Offset: 0x00BBFE93
		public override int GetExternalButtonRedPointId()
		{
			return base.Id;
		}

		// Token: 0x0603273F RID: 206655 RVA: 0x00BC1C9B File Offset: 0x00BBFE9B
		public override bool GetExDataRedPointShowState()
		{
			return base.IsUnLock() && (SheriffModel.Instance.CheckShopRedDot() || this.IsUnlockRedDotActive());
		}

		// Token: 0x06032740 RID: 206656 RVA: 0x00BC1CBB File Offset: 0x00BBFEBB
		public bool GetTerminalRedPointShowState()
		{
			return this.CheckIfInShowTime() && !base.IsHiddenByConfig() && (this.IsTerminalFirstOpenRedDotActive() || this.GetExDataRedPointShowState());
		}

		// Token: 0x06032741 RID: 206657 RVA: 0x00BC1CE1 File Offset: 0x00BBFEE1
		public bool IsTerminalFirstOpenRedDotActive()
		{
			return base.IsUnLock() && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 101, 0, 0) == 1;
		}

		// Token: 0x06032742 RID: 206658 RVA: 0x00BC1D05 File Offset: 0x00BBFF05
		public bool IsUnlockRedDotActive()
		{
			return base.IsUnLock() && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 100, 0, 0) == 0;
		}

		// Token: 0x06032743 RID: 206659 RVA: 0x00BC1D29 File Offset: 0x00BBFF29
		public void ReadTerminalFirstOpenRedDot()
		{
			if (!this.MarkTerminalFirstOpenRedDotRead())
			{
				return;
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06032744 RID: 206660 RVA: 0x00BC1D4A File Offset: 0x00BBFF4A
		public void ReadRedDot()
		{
			if (!base.IsUnLock())
			{
				return;
			}
			ActivityModel.Instance.SaveActivityData(base.Id, 100, 0, 0, 1);
			this.MarkTerminalFirstOpenRedDotRead();
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06032745 RID: 206661 RVA: 0x00BC1D87 File Offset: 0x00BBFF87
		private bool MarkTerminalFirstOpenRedDotRead()
		{
			if (!this.IsTerminalFirstOpenRedDotActive())
			{
				return false;
			}
			ActivityModel.Instance.SaveActivityData(base.Id, 101, 0, 0, 2);
			return true;
		}

		// Token: 0x0401ADBA RID: 110010
		private const int SHERIFF_UNLOCK_RED_DOT_CACHE_KEY = 100;

		// Token: 0x0401ADBB RID: 110011
		private const int SHERIFF_TERMINAL_FIRST_OPEN_RED_DOT_CACHE_KEY = 101;
	}
}
