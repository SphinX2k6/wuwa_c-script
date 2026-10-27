using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200224C RID: 8780
	[NullableContext(1)]
	[Nullable(0)]
	public class ToggleTimerPauseState : ActionParams
	{
		// Token: 0x0600C0A6 RID: 49318 RVA: 0x001BA6EC File Offset: 0x001B88EC
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

		// Token: 0x0600C0A7 RID: 49319 RVA: 0x001BA724 File Offset: 0x001B8924
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

		// Token: 0x0600C0A8 RID: 49320 RVA: 0x001BA737 File Offset: 0x001B8937
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

		// Token: 0x0600C0A9 RID: 49321 RVA: 0x001BA74A File Offset: 0x001B894A
		public ToggleTimerPauseState_SetValue ToSetValue()
		{
			return new ToggleTimerPauseState_SetValue
			{
				TimerType = this.TimerType,
				IsPause = this.IsPause
			};
		}

		// Token: 0x17003A4C RID: 14924
		// (get) Token: 0x0600C0AA RID: 49322 RVA: 0x001BA769 File Offset: 0x001B8969
		// (set) Token: 0x0600C0AB RID: 49323 RVA: 0x001BA794 File Offset: 0x001B8994
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

		// Token: 0x17003A4D RID: 14925
		// (get) Token: 0x0600C0AC RID: 49324 RVA: 0x001BA7A2 File Offset: 0x001B89A2
		// (set) Token: 0x0600C0AD RID: 49325 RVA: 0x001BA7CD File Offset: 0x001B89CD
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

		// Token: 0x040072D4 RID: 29396
		[Nullable(2)]
		protected new ToggleTimerPauseState FbInstance;

		// Token: 0x040072D5 RID: 29397
		[Nullable(2)]
		protected ToggleTimerPauseState_SetValue PocoInterface;
	}
}
