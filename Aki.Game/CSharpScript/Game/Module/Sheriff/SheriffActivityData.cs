using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BDC RID: 15324
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffActivityData : ActivityBaseData
	{
		// Token: 0x060274EE RID: 161006 RVA: 0x00B06885 File Offset: 0x00B04A85
		protected override void OnInit(ActivityData data)
		{
		}

		// Token: 0x060274EF RID: 161007 RVA: 0x00B06887 File Offset: 0x00B04A87
		protected override void PhraseEx(ActivityData data)
		{
			if (base.GetIfFirstOpen() && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 101, 0, 0) == 0)
			{
				ActivityModel.Instance.SaveActivityData(base.Id, 101, 0, 0, 1);
			}
		}

		// Token: 0x060274F0 RID: 161008 RVA: 0x00B068BD File Offset: 0x00B04ABD
		public override ERedDotName? GetExternalButtonRedPointName()
		{
			return new ERedDotName?(ERedDotName.CommonActivityPage);
		}

		// Token: 0x060274F1 RID: 161009 RVA: 0x00B068C6 File Offset: 0x00B04AC6
		public override int GetExternalButtonRedPointId()
		{
			return base.Id;
		}

		// Token: 0x060274F2 RID: 161010 RVA: 0x00B068CE File Offset: 0x00B04ACE
		public override bool GetExDataRedPointShowState()
		{
			return base.IsUnLock() && (SheriffModel.Instance.CheckShopRedDot() || this.IsUnlockRedDotActive());
		}

		// Token: 0x060274F3 RID: 161011 RVA: 0x00B068EE File Offset: 0x00B04AEE
		public bool GetTerminalRedPointShowState()
		{
			return this.CheckIfInShowTime() && !base.IsHiddenByConfig() && (this.IsTerminalFirstOpenRedDotActive() || this.GetExDataRedPointShowState());
		}

		// Token: 0x060274F4 RID: 161012 RVA: 0x00B06914 File Offset: 0x00B04B14
		public bool IsTerminalFirstOpenRedDotActive()
		{
			return base.IsUnLock() && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 101, 0, 0) == 1;
		}

		// Token: 0x060274F5 RID: 161013 RVA: 0x00B06938 File Offset: 0x00B04B38
		public bool IsUnlockRedDotActive()
		{
			return base.IsUnLock() && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 100, 0, 0) == 0;
		}

		// Token: 0x060274F6 RID: 161014 RVA: 0x00B0695C File Offset: 0x00B04B5C
		public void ReadTerminalFirstOpenRedDot()
		{
			if (!this.MarkTerminalFirstOpenRedDotRead())
			{
				return;
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x060274F7 RID: 161015 RVA: 0x00B0697D File Offset: 0x00B04B7D
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

		// Token: 0x060274F8 RID: 161016 RVA: 0x00B069BA File Offset: 0x00B04BBA
		private bool MarkTerminalFirstOpenRedDotRead()
		{
			if (!this.IsTerminalFirstOpenRedDotActive())
			{
				return false;
			}
			ActivityModel.Instance.SaveActivityData(base.Id, 101, 0, 0, 2);
			return true;
		}

		// Token: 0x04015717 RID: 87831
		private const int SHERIFF_UNLOCK_RED_DOT_CACHE_KEY = 100;

		// Token: 0x04015718 RID: 87832
		private const int SHERIFF_TERMINAL_FIRST_OPEN_RED_DOT_CACHE_KEY = 101;
	}
}
