using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024B9 RID: 9401
	public class ToggleTimerPauseState : ActionParams
	{
		// Token: 0x0600CC6C RID: 52332 RVA: 0x001D1E70 File Offset: 0x001D0070
		private ToggleTimerPauseState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ToggleTimerPauseState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ToggleTimerPauseState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ToggleTimerPauseState_SetValue());
			}
			return result;
		}

		// Token: 0x0600CC6D RID: 52333 RVA: 0x001D1EA8 File Offset: 0x001D00A8
		public static ToggleTimerPauseState Create([Nullable(2)] ToggleTimerPauseState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ToggleTimerPauseState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CC6E RID: 52334 RVA: 0x001D1EBB File Offset: 0x001D00BB
		public static ToggleTimerPauseState CreateFromSetValue([Nullable(2)] ToggleTimerPauseState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ToggleTimerPauseState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CC6F RID: 52335 RVA: 0x001D1ECE File Offset: 0x001D00CE
		public ToggleTimerPauseState_SetValue ToSetValue()
		{
			return new ToggleTimerPauseState_SetValue
			{
				TimerType = this.TimerType,
				IsPause = this.IsPause
			};
		}

		// Token: 0x17003D43 RID: 15683
		// (get) Token: 0x0600CC70 RID: 52336 RVA: 0x001D1EED File Offset: 0x001D00ED
		// (set) Token: 0x0600CC71 RID: 52337 RVA: 0x001D1F18 File Offset: 0x001D0118
		public virtual ETimerType TimerType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimerType;
				}
				if (this.PocoInterface == null)
				{
					return ETimerType.CountDownChallenge;
				}
				return this.PocoInterface.TimerType;
			}
			set
			{
				this.GetOrCreatePoco().TimerType = value;
			}
		}

		// Token: 0x17003D44 RID: 15684
		// (get) Token: 0x0600CC72 RID: 52338 RVA: 0x001D1F26 File Offset: 0x001D0126
		// (set) Token: 0x0600CC73 RID: 52339 RVA: 0x001D1F51 File Offset: 0x001D0151
		public virtual bool IsPause
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsPause;
				}
				return this.PocoInterface != null && this.PocoInterface.IsPause;
			}
			set
			{
				this.GetOrCreatePoco().IsPause = value;
			}
		}

		// Token: 0x04007921 RID: 31009
		[Nullable(2)]
		protected new ToggleTimerPauseState FbInstance;

		// Token: 0x04007922 RID: 31010
		[Nullable(2)]
		protected ToggleTimerPauseState_SetValue PocoInterface;
	}
}
