using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A98 RID: 10904
	public class ToggleTimerPauseState : ActionParams
	{
		// Token: 0x0600F091 RID: 61585 RVA: 0x00233F10 File Offset: 0x00232110
		public static ToggleTimerPauseState Create(IToggleTimerPauseState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ToggleTimerPauseState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700480F RID: 18447
		// (get) Token: 0x0600F092 RID: 61586 RVA: 0x00233F2F File Offset: 0x0023212F
		public virtual ETimerType TimerType
		{
			get
			{
				return (ETimerType)this.Instance.TimerType;
			}
		}

		// Token: 0x17004810 RID: 18448
		// (get) Token: 0x0600F093 RID: 61587 RVA: 0x00233F3C File Offset: 0x0023213C
		public virtual bool IsPause
		{
			get
			{
				return this.Instance.IsPause;
			}
		}

		// Token: 0x0400844A RID: 33866
		private IToggleTimerPauseState Instance;
	}
}
