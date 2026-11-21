using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DF3 RID: 11763
	public class SheriffChangeCriminalState : ActionParams
	{
		// Token: 0x0600FFCB RID: 65483 RVA: 0x0024D701 File Offset: 0x0024B901
		public static SheriffChangeCriminalState Create(ISheriffChangeCriminalState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SheriffChangeCriminalState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005093 RID: 20627
		// (get) Token: 0x0600FFCC RID: 65484 RVA: 0x0024D720 File Offset: 0x0024B920
		public virtual int CriminalId
		{
			get
			{
				return this.Instance.CriminalId;
			}
		}

		// Token: 0x17005094 RID: 20628
		// (get) Token: 0x0600FFCD RID: 65485 RVA: 0x0024D72D File Offset: 0x0024B92D
		public virtual ESheriffCriminalState CriminalState
		{
			get
			{
				return (ESheriffCriminalState)this.Instance.CriminalState;
			}
		}

		// Token: 0x04008BA1 RID: 35745
		private ISheriffChangeCriminalState Instance;
	}
}
