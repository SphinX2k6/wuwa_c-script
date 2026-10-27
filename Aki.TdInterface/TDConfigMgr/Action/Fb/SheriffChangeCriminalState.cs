using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AFF RID: 11007
	public class SheriffChangeCriminalState : ActionParams
	{
		// Token: 0x0600F115 RID: 61717 RVA: 0x0022F9F5 File Offset: 0x0022DBF5
		[NullableContext(1)]
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

		// Token: 0x17004CD9 RID: 19673
		// (get) Token: 0x0600F116 RID: 61718 RVA: 0x0022FA14 File Offset: 0x0022DC14
		public virtual int CriminalId
		{
			get
			{
				return this.Instance.CriminalId;
			}
		}

		// Token: 0x17004CDA RID: 19674
		// (get) Token: 0x0600F117 RID: 61719 RVA: 0x0022FA21 File Offset: 0x0022DC21
		public virtual ESheriffCriminalState CriminalState
		{
			get
			{
				return (ESheriffCriminalState)this.Instance.CriminalState;
			}
		}

		// Token: 0x0400849D RID: 33949
		private ISheriffChangeCriminalState Instance;
	}
}
