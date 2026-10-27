using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027C5 RID: 10181
	public class ToggleTimerPauseState : ActionParams
	{
		// Token: 0x0600E26F RID: 57967 RVA: 0x0021713C File Offset: 0x0021533C
		[NullableContext(1)]
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

		// Token: 0x170044A7 RID: 17575
		// (get) Token: 0x0600E270 RID: 57968 RVA: 0x0021715B File Offset: 0x0021535B
		public virtual ETimerType TimerType
		{
			get
			{
				return (ETimerType)this.Instance.TimerType;
			}
		}

		// Token: 0x170044A8 RID: 17576
		// (get) Token: 0x0600E271 RID: 57969 RVA: 0x00217168 File Offset: 0x00215368
		public virtual bool IsPause
		{
			get
			{
				return this.Instance.IsPause;
			}
		}

		// Token: 0x04007D93 RID: 32147
		private IToggleTimerPauseState Instance;
	}
}
